using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;

namespace TotalLength
{
    class AddPanel : IExternalApplication
    {
        // define a method that will create our tab and button
        static void AddRibbonPanel(UIControlledApplication application)
        {
            // Create a custom ribbon tab
            String tabName = "Grimshaw";
            application.CreateRibbonTab(tabName);

            // Add a new ribbon panel
            RibbonPanel ribbonPanel = application.CreateRibbonPanel(tabName, "Tools");

            // Get dll assembly path
            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;

            // create push button for CurveTotalLength
            PushButtonData b1Data = new PushButtonData(
                "cmdCurveTotalLength",
                "Total" + System.Environment.NewLine + "  Length  ",
                thisAssemblyPath,
                "GrimshawRibbon.CurveTotalLength");

            PushButton pb1 = ribbonPanel.AddItem(b1Data) as PushButton;
            pb1.ToolTip = "Select Multiple Lines to Obtain Total Length";
            BitmapImage pb1Image = new BitmapImage(new Uri("pack://application:,,,/GrimshawRibbon;component/Resources/totalLength.png"));
            pb1.LargeImage = pb1Image;
        }
        
        public Result OnShutdown(UIControlledApplication application)
        {
            // do nothing
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            // call our method that will load up our toolbar
            AddRibbonPanel(application);
            return Result.Succeeded;
        }
    }
}
