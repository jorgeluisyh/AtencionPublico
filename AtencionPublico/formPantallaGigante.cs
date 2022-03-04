using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AtencionPublico.settings;
using static AtencionPublico.toolbox;

namespace AtencionPublico
{
    public partial class formPantallaGigante : Form
    {
        public List<object> parametros = new List<object>();
        public AtencionPublicoExceptions RuntimeError = new AtencionPublicoExceptions();
        private Dictionary<string, string> cartasDictByCodigo= new Dictionary<string, string>();
        private Dictionary<string, string> cartasDictByNombre = new Dictionary<string, string>();

        private Dictionary<string, string> dicDistritosCodigo = new Dictionary<string, string>();
        private Dictionary<string, string> dicDistritosNombre = new Dictionary<string, string>();

        private Dictionary<string, string> dicParamsGraficar = new Dictionary<string, string>();
        private bool toggletool = false;
        private string lastTabIdx = "99";
        private string sel_carta = "";
        private string sel_distrito = "";
        private string sel_coord = "";
        private string sel_dm = "";
        private string sel_zona = "18";
        private ICommandItem currentCommand;

        public formPantallaGigante()
        {
            InitializeComponent();
        }

        

        private void formPantallaGigante_Load(object sender, EventArgs e)
        {
            runProgressBar();
            btn_graficar.FlatStyle = FlatStyle.Flat;
            btn_graficar.FlatAppearance.BorderSize = 1;
            btn_graficar.BackColor = Color.Gainsboro;


            cargarDiccionarioCarta();
            cargarDiccionarioDistrito();
            runProgressBar("ini");

        }

        private void rbtn_carta_codigo_CheckedChanged(object sender, EventArgs e)
        {
            cbx_carta.SelectedIndexChanged -= cbx_carta_SelectedIndexChanged;
            cbx_carta.DataSource = null;
            cbx_carta.DataSource = new BindingSource(cartasDictByCodigo, null);
            cbx_carta.DisplayMember = "Value";
            cbx_carta.ValueMember = "Key";
            cbx_carta.SelectedIndexChanged += cbx_carta_SelectedIndexChanged;

        }

        private void rbtn_carta_nombre_CheckedChanged(object sender, EventArgs e)
        {
            cbx_carta.SelectedIndexChanged -= cbx_carta_SelectedIndexChanged;
            cbx_carta.DataSource = null;
            cbx_carta.DataSource = new BindingSource(cartasDictByNombre, null);
            cbx_carta.DisplayMember = "Value";
            cbx_carta.ValueMember = "Key";
            cbx_carta.SelectedIndexChanged += cbx_carta_SelectedIndexChanged;

        }

        private void btn_ver_cartas_Click(object sender, EventArgs e)
        {
            Process.Start(_grillas_path);
        }


        private void btn_graficar_Click(object sender, EventArgs e)
        {
            var sel_tab_id = tabControl1.SelectedIndex;
            dicParamsGraficar.Clear();
            if (sel_tab_id == 0)
            {
                //Carta
                dicParamsGraficar.Add("carta", sel_carta);
            }
            else if (sel_tab_id == 1)
            {
                //Distrito
                dicParamsGraficar.Add("distrito", sel_distrito);
            }
            else if (sel_tab_id == 2)
            {
                //Coordenada
                var xyzona = nbx_este.Value + ";"+nbx_norte.Value + ";" + sel_zona;
                dicParamsGraficar.Add("coordenada", xyzona);
            }
            else if (sel_tab_id == 3)
            {
                //Coordenada
                dicParamsGraficar.Add("dm", sel_dm);
            }

            
            if (toggletool)
            {
                ArcMap.Application.CurrentTool = null;
                toggletool = false;
                btn_graficar.FlatAppearance.BorderColor = Color.Gray;
                lbl_carta_o_nombre.Focus();
                return;
            }

            CleanTableOfContents();
            var distancia = int.Parse(nbx_radiokm.Value.ToString());
            var distancia_km = distancia * 1000;
            graficarCartaNacional(dicParamsGraficar.Keys.ToList()[0], dicParamsGraficar.Values.ToList()[0], distancia_km.ToString());

            UID dockWinID = new UIDClass();
            dockWinID.Value = ThisAddIn.IDs.GraficarPunto;
            ICommandItem commandItem = ArcMap.Application.Document.CommandBars.Find(dockWinID, false, false);
            Cursor.Current = Cursors.Default;
            ArcMap.Application.CurrentTool = commandItem;
            currentCommand = commandItem;
            btn_graficar.FlatAppearance.BorderColor = Color.Red;
            toggletool = true;
            lbl_carta_o_nombre.Focus();
            lastTabIdx = sel_tab_id.ToString();

        }


        private void cbx_carta_SelectedIndexChanged(object sender, EventArgs e)
        {
            sel_carta = cbx_carta.SelectedValue.ToString();
        }

        private void cargarDiccionarioCarta()
        {

            Cursor.Current = Cursors.WaitCursor;
            cbx_carta.SelectedIndexChanged -= cbx_carta_SelectedIndexChanged;

            parametros.Clear();
            var response = ExecuteGP(_tool_getCartas, parametros, _toolboxPath_general);
            var responseJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
            if (int.Parse(responseJson["status"].ToString()) == 0)
            {
                RuntimeError.PythonError = responseJson["message"].ToString();
                MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
                runProgressBar("ini");
                return;
            }

            JArray responselist = (JArray)responseJson["response"];
            foreach (var current in responselist)
            {
                var llave = current.First.ToString();
                var valor = current.Last.ToString();
                var valor2 = "";
                try
                {
                    char[] separator = { ':' };
                    string[] strlist = valor.Split(separator);
                    valor2 = strlist[1].Trim() + " : " + strlist[0].Trim();
                }
                catch
                {
                    valor2 = valor;
                }


                cartasDictByCodigo.Add(llave, valor);
                cartasDictByNombre.Add(llave, valor2);
            }

            cbx_carta.DataSource = new BindingSource(cartasDictByCodigo, null);
            cbx_carta.DisplayMember = "Value";
            cbx_carta.ValueMember = "Key";

            cbx_carta.SelectedIndexChanged += cbx_carta_SelectedIndexChanged;
            Cursor.Current = Cursors.Default;
        }

        private void cargarDiccionarioDistrito()
        {

            Cursor.Current = Cursors.WaitCursor;
            cbx_distrito.SelectedIndexChanged -= cbx_distrito_SelectedIndexChanged;

            parametros.Clear();
            var response = ExecuteGP(_tool_getDistritos, parametros, _toolboxPath_general);
            var responseJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
            if (int.Parse(responseJson["status"].ToString()) == 0)
            {
                RuntimeError.PythonError = responseJson["message"].ToString();
                MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
                runProgressBar("ini");
                return;
            }

            JArray responselist = (JArray)responseJson["response"];
            foreach (var current in responselist)
            {
                var llave = current.First.ToString();
                var valor = current.Last.ToString();
                var valor2 = "";
                try
                {
                    char[] separator = { ':' };
                    string[] strlist = valor.Split(separator);
                    valor2 = strlist[1].Trim() + " : " + strlist[0].Trim();
                }
                catch
                {
                    valor2 = valor;
                }


                dicDistritosCodigo.Add(llave, valor);
                dicDistritosNombre.Add(llave, valor2);
            }

            cbx_distrito.DataSource = new BindingSource(dicDistritosCodigo, null);
            cbx_distrito.DisplayMember = "Value";
            cbx_distrito.ValueMember = "Key";

            cbx_distrito.SelectedIndexChanged += cbx_distrito_SelectedIndexChanged;
            Cursor.Current = Cursors.Default;
        }

        private void graficarCartaNacional(string parametro, string valor, string distancia)
        {
            parametros.Clear();
            parametros.Add(parametro);
            parametros.Add(valor);
            parametros.Add(distancia);
            var response = ExecuteGP(_tool_getCartasByParam, parametros, _toolboxPath_PantallaGigante);
            var responseJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
            if (int.Parse(responseJson["status"].ToString()) == 0)
            {
                RuntimeError.PythonError = responseJson["message"].ToString();
                MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            return;
        }

        private void VisualizarDatosDM(bool parametro)
        {
            if (parametro)
            {
                lbl_dm_1.Visible = true;
                lbl_dm_2.Visible = true;
                lbl_dm_3.Visible = true;
                lbl_dm_4.Visible = true;
                lbl_dm_5.Visible = true;

                lbl_dm_name.Visible = true;
                lbl_dm_titular.Visible = true;
                lbl_dm_hoja.Visible = true;
                lbl_dm_zona.Visible = true;
                lbl_dm_ha.Visible = true;
            }
            else
            {
                lbl_dm_name.Visible = true;
                lbl_dm_name.Text = "No se encontró DM";

                lbl_dm_1.Visible = false;
                lbl_dm_2.Visible = false;
                lbl_dm_3.Visible = false;
                lbl_dm_4.Visible = false;
                lbl_dm_5.Visible = false;

                lbl_dm_titular.Visible = false;
                lbl_dm_hoja.Visible = false;
                lbl_dm_zona.Visible = false;
                lbl_dm_ha.Visible = false;
            }
            
        }


        private void rbtn_distrito_ubigeo_CheckedChanged(object sender, EventArgs e)
        {
            cbx_distrito.SelectedIndexChanged -= cbx_distrito_SelectedIndexChanged;
            cbx_distrito.DataSource = null;
            cbx_distrito.DataSource = new BindingSource(dicDistritosCodigo, null);
            cbx_distrito.DisplayMember = "Value";
            cbx_distrito.ValueMember = "Key";
            cbx_distrito.SelectedIndexChanged += cbx_distrito_SelectedIndexChanged;

        }
        private void rbtn_distrito_nombre_CheckedChanged(object sender, EventArgs e)
        {
            cbx_distrito.SelectedIndexChanged -= cbx_distrito_SelectedIndexChanged;
            cbx_distrito.DataSource = null;
            cbx_distrito.DataSource = new BindingSource(dicDistritosNombre, null);
            cbx_distrito.DisplayMember = "Value";
            cbx_distrito.ValueMember = "Key";
            cbx_distrito.SelectedIndexChanged += cbx_distrito_SelectedIndexChanged;
        }

        
        private void cbx_distrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            sel_distrito = cbx_distrito.SelectedValue.ToString();
        }

        private void btn_ver_cartas_dist_Click(object sender, EventArgs e)
        {
            Process.Start(_grillas_path);
        }

        private void rbtn_zona_17_CheckedChanged(object sender, EventArgs e)
        {
            sel_zona = "17";
        }

        private void rbtn_zona_18_CheckedChanged(object sender, EventArgs e)
        {
            sel_zona = "18";
        }

        private void rbtn_zona_19_CheckedChanged(object sender, EventArgs e)
        {
            sel_zona = "19";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lastTabIdx!= tabControl1.SelectedIndex.ToString())
            {
                ArcMap.Application.CurrentTool = null;
                toggletool = false;
                btn_graficar.FlatAppearance.BorderColor = Color.Gray;
                lbl_carta_o_nombre.Focus();
                return;
            }
            else
            {
                ArcMap.Application.CurrentTool = currentCommand;
                toggletool = true;
                btn_graficar.FlatAppearance.BorderColor = Color.Red;
                return;
            }
            
        }

        private void btn_buscar_dm_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            parametros.Clear();
            parametros.Add(tbx_codigodm.Text);
            var response = ExecuteGP(_tool_getDmValues, parametros, _toolboxPath_general);
            var responseJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
            if (int.Parse(responseJson["status"].ToString()) == 0)
            {
                RuntimeError.PythonError = responseJson["message"].ToString();
                MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
                runProgressBar("ini");
                VisualizarDatosDM(false);
                return;
            }

            JArray responselist = (JArray)responseJson["response"];
            foreach (var current in responselist)
            {
                lbl_dm_name.Text = current.ElementAt(1).ToString();
                lbl_dm_titular.Text = current.ElementAt(2).ToString();
                lbl_dm_hoja.Text = current.ElementAt(3).ToString();
                lbl_dm_zona.Text = current.ElementAt(4).ToString();
                lbl_dm_ha.Text = current.ElementAt(5).ToString();
                sel_dm = current.ElementAt(0).ToString();

                VisualizarDatosDM(true);

            }
            
        }

        private void tbx_codigodm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_buscar_dm_Click(this,EventArgs.Empty);
            }
        }
    }
}

