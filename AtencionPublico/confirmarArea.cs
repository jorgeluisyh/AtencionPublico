using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AtencionPublico.settings;
using static AtencionPublico.toolbox;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;

namespace AtencionPublico
{
    public partial class frm_confirmarArea : Form
    {
        public frm_confirmarArea()
        {
            InitializeComponent();
        }
        public List<object> parametros = new List<object>();

        private void btn_si_Click(object sender, EventArgs e)
        {

            CleanTableOfContents("Carta");
            btn_si.Enabled = false;
            btn_no.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            runProgressBar();

            parametros.Clear();
            parametros.Add(puntoConsulta_x);
            parametros.Add(puntoConsulta_y);
            parametros.Add("4326");
            parametros.Add(radio_consulta*1000);

            IMxDocument pMxDoc = ArcMap.Application.Document as IMxDocument;
            IGraphicsContainer graphicsContainer = pMxDoc.FocusMap as IGraphicsContainer;
            graphicsContainer.DeleteAllElements();

            var response = ExecuteGP(_tool_graficarCapas, parametros, _toolboxPath_PantallaGigante);
            var responseJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
            if (int.Parse(responseJson["status"].ToString()) == 0)
            {
                RuntimeError.PythonError = responseJson["message"].ToString();
                MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
                runProgressBar("ini");
                this.Close();
                return;
            }
            this.Close();
            runProgressBar("ini");
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_confirmarArea_Load(object sender, EventArgs e)
        {
            btn_si.Enabled = true;
            btn_no.Enabled = true;
        }
    }
}
