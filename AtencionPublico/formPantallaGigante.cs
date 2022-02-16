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
        private Dictionary<string, string> cartasDictByCombobox = new Dictionary<string, string>();
        private Dictionary<string, string> cartasDictByCodigo= new Dictionary<string, string>();
        private Dictionary<string, string> cartasDictByNombre = new Dictionary<string, string>();

        public formPantallaGigante()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void formPantallaGigante_Load(object sender, EventArgs e)
        {
            runProgressBar();
            Cursor.Current = Cursors.WaitCursor;
            cbx_carta.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;

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
                var valor2= "";
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


                cartasDictByCombobox.Add(llave, valor);
                cartasDictByCodigo.Add(llave, valor);
                cartasDictByNombre.Add(llave, valor2);
            }
                
            cbx_carta.DataSource = new BindingSource(cartasDictByCombobox, null);
            cbx_carta.DisplayMember = "Value";
            cbx_carta.ValueMember = "Key";

            cbx_carta.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            Cursor.Current = Cursors.Default;
            runProgressBar("ini");

        }

        private void rbtn_carta_codigo_CheckedChanged(object sender, EventArgs e)
        {
            cbx_carta.DataSource = null;
            cbx_carta.DataSource = new BindingSource(cartasDictByCodigo, null);
            cbx_carta.DisplayMember = "Value";
            cbx_carta.ValueMember = "Key";

        }

        private void rbtn_carta_nombre_CheckedChanged(object sender, EventArgs e)
        {
            cbx_carta.DataSource = null;
            cbx_carta.DataSource = new BindingSource(cartasDictByNombre, null);
            cbx_carta.DisplayMember = "Value";
            cbx_carta.ValueMember = "Key";

        }

        private void btn_ver_cartas_Click(object sender, EventArgs e)
        {
            Process.Start(_grillas_path);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
