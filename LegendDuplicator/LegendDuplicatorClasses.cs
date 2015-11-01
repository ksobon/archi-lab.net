using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.DB;

namespace LegendDuplicator
{
    public class SheetWrapper
    {
        public ElementId ID { get; set; }
        public bool SelectSheet { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public string Name
        {
            get
            {
                try
                {
                    return Parameters["Name"];
                }
                catch (KeyNotFoundException)
                {
                    return ID.ToString();
                }
            }
        }
        public string Number
        {
            get
            {
                try
                {
                    return Parameters["Number"];
                }
                catch (KeyNotFoundException)
                {
                    return ID.ToString();
                }
            }
        }
    }

    public class InputData
    {
        public Document activeDoc;
        public IList<Reference> selectedViews;
        public List<SheetWrapper> Sheets;

        public InputData(Document doc, IList<Reference> selection)
        {
            activeDoc = doc;
            selectedViews = selection;
            LoadSheetData();
        }

        public void ProcessSelection()
        {
            using (Transaction trans = new Transaction(activeDoc, "CopyLegends"))
            {
                trans.Start();
                foreach (SheetWrapper sw in Sheets)
                {
                    if (sw.SelectSheet)
                    {
                        // extract elements from element references
                        foreach (Reference r in selectedViews)
                        {
                            Element e = activeDoc.GetElement(r.ElementId);

                            // check if element is schedule or legend 
                            if (e.Category.Id.IntegerValue.Equals((int)BuiltInCategory.OST_ScheduleGraphics))
                            {
                                // process as schedule
                                try
                                {
                                    ScheduleSheetInstance sch = (ScheduleSheetInstance)e;
                                    bool scheduleOnSheet = false;

                                    // get viewsheet and check if schedule already on sheet
                                    // if schedule on sheet adjust position else create new
                                    foreach (ScheduleSheetInstance si in new FilteredElementCollector(activeDoc)
                                        .OfClass(typeof(ScheduleSheetInstance)))
                                    {
                                        if (si.OwnerViewId == sw.ID
                                            && si.ScheduleId == sch.ScheduleId)
                                        {
                                            si.Point = sch.Point;
                                            scheduleOnSheet = true;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }

                                    if (!scheduleOnSheet)
                                    {
                                        // create new schedule instance
                                        ScheduleSheetInstance.Create(activeDoc, sw.ID, sch.ScheduleId, sch.Point);
                                    }
                                }
                                catch (Exception) { }
                            }
                            else
                            {
                                // process as legend
                                try
                                {
                                    Viewport vp = (Viewport)e;
                                    bool legendOnSheet = false;

                                    // get all viewports on this sheet and check if legend already on sheet
                                    // if legend on sheet adjust position else add new one
                                    ViewSheet vs = activeDoc.GetElement(sw.ID) as ViewSheet;
                                    ICollection<ElementId> allViewports = vs.GetAllViewports();
                                    foreach (ElementId id in allViewports)
                                    {
                                        Viewport currentVp = activeDoc.GetElement(id) as Viewport;
                                        if (currentVp.ViewId == vp.ViewId)
                                        {
                                            currentVp.SetBoxCenter(vp.GetBoxCenter());
                                            legendOnSheet = true;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }

                                    if (!legendOnSheet)
                                    {
                                        // create new legend on sheet
                                        Viewport.Create(activeDoc, sw.ID, vp.ViewId, vp.GetBoxCenter());
                                    }
                                }
                                catch (Exception) { }
                            }
                        }
                    }
                }
                trans.Commit();
            }
        }

        private void LoadSheetData()
        {
            IList<Element> sheets = new FilteredElementCollector(activeDoc)
                .OfClass(typeof(ViewSheet))
                .ToElements();

            Dictionary<ElementId, SheetWrapper> sheetsDict = new Dictionary<ElementId, SheetWrapper>();

            foreach (var obj in sheets)
            {
                try
                {
                    // cast obj as ViewSheet
                    ViewSheet sht = (ViewSheet)obj;

                    // create new instance of Sheet wrapper
                    SheetWrapper shtObj = new SheetWrapper();
                    shtObj.ID = sht.Id;
                    shtObj.Parameters = new Dictionary<string, string>();

                    // add name, number and revision to Parameters Dictionary
                    BuiltInParameter bipName = BuiltInParameter.SHEET_NAME;
                    BuiltInParameter bipNumber = BuiltInParameter.SHEET_NUMBER;

                    shtObj.Parameters["Name"] = sht.get_Parameter(bipName).AsString();
                    shtObj.Parameters["Number"] = sht.get_Parameter(bipNumber).AsString();

                    // bind id to sheet object
                    sheetsDict[shtObj.ID] = shtObj;
                }
                catch (Exception) { }
            }
            Sheets = sheetsDict.Values.ToList<SheetWrapper>();
        }
    } // InputData class
} // Namespace