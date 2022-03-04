using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Geometry;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using System.Drawing;
using ESRI.ArcGIS.Desktop.AddIns;

namespace AtencionPublico
{
    public class GraficarPunto : ESRI.ArcGIS.Desktop.AddIns.Tool
    {
        public GraficarPunto()
        {
        }

        protected override void OnUpdate()
        {

        }


        protected override void OnMouseDown(MouseEventArgs args)
        {
            IMxDocument pMxDoc = ArcMap.Application.Document as IMxDocument;
            IGraphicsContainer graphicsContainer = pMxDoc.FocusMap as IGraphicsContainer;
            graphicsContainer.DeleteAllElements();

            IPoint a = new ESRI.ArcGIS.Geometry.Point();
            IPoint b = new ESRI.ArcGIS.Geometry.Point();

            IPoint pPoint = pMxDoc.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(args.Location.X, args.Location.Y) as IPoint;
            a.PutCoords(pPoint.X + 1/111.11, pPoint.Y + 1/111.11);
            b.PutCoords(pPoint.X - 1/111.11, pPoint.Y + 1/111.11);
            //MessageBox.Show("Map X: " + pPoint.X + System.Environment.NewLine + "Map Y: " + pPoint.Y);

            IActiveView activeView = pMxDoc.ActiveView;
            IScreenDisplay screenDisplay = activeView.ScreenDisplay;

            screenDisplay.StartDrawing(screenDisplay.hDC, (short)esriScreenCache.esriNoScreenCache);


            IRgbColor rgbColor = new RgbColorClass() as IRgbColor;
            rgbColor.Red = 255;
            IColor color = rgbColor as IColor;

            ISimpleMarkerSymbol simpleMarkerSymbol = new SimpleMarkerSymbolClass();
            simpleMarkerSymbol.Color = color;

            //screenDisplay.SetSymbol(symbol);
            ////IDisplayTransformation displayTransformation = screenDisplay.DisplayTransformation;
            //screenDisplay.DrawPoint(pPoint);
            //screenDisplay.FinishDrawing();

            
            ISimpleLineSymbol simpleLineSymbol = new SimpleLineSymbolClass();
            simpleLineSymbol.Color = color;
            simpleLineSymbol.Width = 3;

            ISimpleFillSymbol simpleFillSymbol = new SimpleFillSymbolClass();
            simpleFillSymbol.Color = color;

            //ICircularArc circularArcThreePoint = new CircularArc();
            //IConstructCircularArc constructionCircularArc = circularArcThreePoint as IConstructCircularArc;
            //constructionCircularArc.ConstructThreePoints(a, pPoint, b, true);

            ICircularArc circleElement = new CircularArc();
            IConstructCircularArc constructionCircularArc = circleElement as IConstructCircularArc;
            constructionCircularArc.ConstructCircle(pPoint, 8 / 111.11, true);


            object missing = Type.Missing;
            ISymbol symbol = simpleMarkerSymbol as ISymbol;

            //screenDisplay.SetSymbol(symbol);
            //IDisplayTransformation displayTransformation = screenDisplay.DisplayTransformation;
            //screenDisplay.DrawPoint(pPoint);
            //screenDisplay.DrawPoint(a);
            //screenDisplay.DrawPoint(b);

            //ISegment pSegment = circularArcThreePoint as ISegment;
            ISegment pSegment = circleElement as ISegment;

            ISegmentCollection psegColl = new Polyline() as ISegmentCollection;
            psegColl.AddSegment(pSegment, ref missing, ref missing);
            IGeometry pGeometry = psegColl as IGeometry;
            symbol = simpleLineSymbol as ISymbol;
            screenDisplay.SetSymbol(symbol);
            screenDisplay.DrawPolyline(pGeometry);


            IElement element = new LineElement() as IElement;
            element.Geometry = pGeometry;
            ILineElement linea = element as ILineElement;
            linea.Symbol = simpleLineSymbol;

            graphicsContainer.AddElement(element, 0);
            screenDisplay.FinishDrawing();






        }

        //protected override void OnMouseMove(MouseEventArgs arg)
        //{
        //    base.OnMouseMove(arg);

        //}
    }

}
