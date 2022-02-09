using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Framework;


namespace AtencionPublico
{
    public class OpenDockableWindow : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public OpenDockableWindow()
        {
        }

        protected override void OnClick()
        {
            //
            //  TODO: Sample code showing how to access button host
            //
            UID dockWinID = new UIDClass();
            dockWinID.Value = ThisAddIn.IDs.AtencionPublicodock;
            IDockableWindow dockWindow = ArcMap.DockableWindowManager.GetDockableWindow(dockWinID);
            dockWindow.Show(true);
            ArcMap.Application.CurrentTool = null;
        }

        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }
}
