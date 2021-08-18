using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Conexion_SQLServer_C_Sharp.Clases
{
    class CConexion
    {
        SqlConnection conex = new SqlConnection();

        static string servidor ="localhost";
        static string bd="pp";
        static string usuario="sserver";
        static string password ="root";
        static string puerto="1433";

        string cadenaConexion = "Data Source=" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info=true";


        public SqlConnection establecerConexion() {

            try {
                conex.ConnectionString= cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conectó correctamente a la Base de Datos");

            }
            catch (SqlException e) {

                MessageBox.Show("No se logró conectar a la Base de Datos"+ e.ToString());
            }

            return conex;
        }


    }
}
