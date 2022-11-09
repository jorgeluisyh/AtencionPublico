using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static AtencionPublico.settings;

namespace AtencionPublico
{
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
        }

        private void cbx_modulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentModule = ((KeyValuePair<int, string>)cbx_modulos.SelectedItem).Key;

            if ((currentModule == 1))
            {
                var pantallaGiganteForm = new formPantallaGigante();
                openFormByName(pantallaGiganteForm, pnl_modulos_form);
            }
        }

        private void Modulos_Load(object sender, EventArgs e)
        {
            cbx_modulos.DataSource = new BindingSource(modulosDict, null);
            cbx_modulos.DisplayMember = "Value";
            cbx_modulos.ValueMember = "Key";
            _LOADER_CONTROL = pgb_modulos;
        }


        private void Modulos_Resize(object sender, EventArgs e)
        {
            // Permite cambiar el size del formulario en funcion del DockableWindow
            int numberControls = pnl_modulos_form.Controls.Count;
            if ((numberControls > 0))
            {
                var control = pnl_modulos_form.Controls[0];
                try
                {
                    control.Size = pnl_modulos_form.Size;
                    control.Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pbx_user_guide_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(_manual_path);
            }
            catch
            {
                MessageBox.Show("Muy pronto estará disponible el manual de usuario para este módulo", __title__, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
