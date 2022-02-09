using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static AtencionPublico.settings;

namespace AtencionPublico
{
    /// <summary>
    /// Designer class of the dockable window add-in. It contains user interfaces that
    /// make up the dockable window.
    /// </summary>
    public partial class AtencionPublicodock : UserControl
    {
        public AtencionPublicodock(object hook)
        {
            InitializeComponent();
            this.Hook = hook;
        }

        /// <summary>
        /// Host object of the dockable window
        /// </summary>
        private object Hook
        {
            get;
            set;
        }

        /// <summary>
        /// Implementation class of the dockable window add-in. It is responsible for 
        /// creating and disposing the user interface class of the dockable window.
        /// </summary>
        public class AddinImpl : ESRI.ArcGIS.Desktop.AddIns.DockableWindow
        {
            private AtencionPublicodock m_windowUI;

            public AddinImpl()
            {
            }

            protected override IntPtr OnCreateChild()
            {
                m_windowUI = new AtencionPublicodock(this.Hook);
                return m_windowUI.Handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (m_windowUI != null)
                    m_windowUI.Dispose(disposing);

                base.Dispose(disposing);
            }

        }

        private void AtencionPublicodock_Load(object sender, EventArgs e)
        {
            ClsConexionBD conexionBD = new ClsConexionBD();
            modulosDict = conexionBD.ObtenerModulossqlite();
            Form Modulosform = new Modulos();
            openFormByName(Modulosform, pnl_main);
        }

        private void AtencionPublicodock_Resize(object sender, EventArgs e)
        {
            // Permite cambiar el size del formulario en funcion del DockableWindow
            int numberControls = pnl_main.Controls.Count;
            if ((numberControls > 0))
            {
                var control = pnl_main.Controls[0];
                try
                {
                    control.Size = pnl_main.Size;
                    control.Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
