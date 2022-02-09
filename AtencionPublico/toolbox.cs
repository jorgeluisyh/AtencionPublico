using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AtencionPublico.settings;

namespace AtencionPublico
{
    public static class toolbox
    {
        //1. Variables globales
        //* _toolboxPath: Construye la ruta donde se encuentra el archivo *.tbx
        public static string _toolboxPath_general = _path + @"\scripts\T00_automapic.tbx";
        public static string _toolboxPath_PantallaGigante = _path + @"\scripts\T01_plano_topografico_25k.tbx";
    }
}
