using System;
using System.Collections.Generic;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI.Selection;

namespace LegendDuplicator
{
    public class LegendScheduleFilter : ISelectionFilter
    {
        Document doc = null;

        public LegendScheduleFilter(Document document)
        {
            doc = document;
        }

        public bool AllowElement(Element elem)
        {
            if (elem.Category.Id.IntegerValue.Equals((int)BuiltInCategory.OST_ScheduleGraphics))
            {
                return true;
            }
            else if (((View)(doc.GetElement(((Viewport)elem).ViewId))).ViewType == ViewType.Legend)
            {
                return true;
            }
            return false;
        }

        public bool AllowReference(Reference reference, XYZ position)
        {
            return false;
        }
    }

    [Transaction(TransactionMode.Manual)]
    public class CmdLegendDuplicator : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData, 
            ref string message, 
            ElementSet elements)
        {
            // Get application and document objects
            UIApplication uiApp = commandData.Application;
            Document doc = uiApp.ActiveUIDocument.Document;
            UIDocument uidoc = uiApp.ActiveUIDocument;

            try
            {
                IList<Reference> refs = null;
                LegendScheduleFilter selFilter = new LegendScheduleFilter(doc);

                Selection sel = uidoc.Selection;
                refs = sel.PickObjects(ObjectType.Element, selFilter, "Select Legends and/or Schedules only.");

                InputData inData = new InputData(doc, refs);
                LegendDuplicatorForm form = new LegendDuplicatorForm(inData);
                form.ShowDialog();

                return Result.Succeeded;
            }
            // Catch any exceptions and display them
            catch (Autodesk.Revit.Exceptions.OperationCanceledException)
            {
                return Result.Cancelled;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Result.Failed;
            }
        }
    }
}
