using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AtencionPublico.settings;

namespace AtencionPublico
{
    class ClsConexionBD
    {
        //private string sqlCadenaCon = "Data Source=10.102.0.193;Initial Catalog=OSI_Pruebas; User Id=sa;Password=geoc@tmin";

        //public Dictionary<int,string> ObtenerModulos()
        //{
        //    Dictionary<int, string> diccionario_modulos = new Dictionary<int, string>();
        //    //string SQLstr_modulos = string.Format("SELECT ID_MODULO, MODULO FROM VW_ACCESS WHERE USER = '{0}'", user);
        //    string SQLstr_modulos = "SELECT ID_MODULO, MODULO FROM ATPUB_MODULOS";

        //    try
        //    {
        //        SqlConnection conn = new SqlConnection(sqlCadenaCon);
        //        SqlDataAdapter da = new SqlDataAdapter(SQLstr_modulos, conn);
        //        da.SelectCommand.CommandType = System.Data.CommandType.Text;
        //        DataSet ds = new DataSet();

        //        //SQLcmd.CommandText = SQLstr_modulos
        //        //SQLdr = SQLcmd.ExecuteReader()
        //        //modulosDict.Clear()
        //        //While SQLdr.Read()
        //        //    modulosDict.Add(SQLdr.GetValue(0), SQLdr.GetValue(1))
        //        //End While
        //        //SQLdr.Close()

        //        da.Fill(ds, "Modulos");
        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {
        //            var id = int.Parse(ds.Tables[0].Rows[i]["ID_MODULO"].ToString());
        //            var modulo = ds.Tables[0].Rows[i]["MODULO"].ToString();

        //            diccionario_modulos.Add(id, modulo);
        //        }
        //        ds.Dispose();
        //        da.Dispose();
        //        return diccionario_modulos;
        //    }
        //    catch(Exception )
        //    {
        //        return diccionario_modulos;
                
        //    }
        //}
        public Dictionary<int,string> ObtenerModulossqlite()
        {
            Dictionary<int, string> diccionario_modulos = new Dictionary<int, string>();

            // Value to search as SQL Query - return first match
            // Dim SQLstr_validate As String = String.Format("SELECT COUNT(*) FROM TB_USER WHERE USER  ='{ 0}
            // AND PASSWORD = '{ 1}
            // ", user, pass)
            string SQLstr_modulos = string.Format("SELECT ID_MODULO, MODULO FROM ATPUB_MODULOS");


            // Define file to open - .path passed from parent form
            string connectionString = "Data Source=" + _path_sqlite;

            SQLiteConnection SqlConn = new SQLiteConnection(connectionString);
            SQLiteCommand SqlCmd = new SQLiteCommand(SqlConn);
            SQLiteDataReader Sqldr;
            SqlConn.Open();

            //modulos disponibles
            SqlCmd.CommandText = SQLstr_modulos;
            Sqldr = SqlCmd.ExecuteReader();
            while (Sqldr.Read())
            {
                int key = int.Parse(Sqldr[0].ToString());
                string valor = Sqldr[1].ToString();
                diccionario_modulos.Add(key, valor);
            }
            Sqldr.Close();

            //Cierre de conexion
            SqlConn.Close();
            return diccionario_modulos;

        }

        public Dictionary<int, string> ObtenerCartasOracle()
        {
            Dictionary<int, string> diccionario_cartas = new Dictionary<int, string>();
            string connectionString = "";
            //OracleConnection conn = new OracleConnection(connectionString);



            return diccionario_cartas;
        }
    }

}
