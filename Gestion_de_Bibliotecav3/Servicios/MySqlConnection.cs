using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Gestion_de_Biblioteca.Servicios
{
    public class MySqlConnection
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        private String myConnectionString;

        public MySqlConnection()
        {
            try
            {
                string archivoJson = "config.json";
                string contenidoJson = File.ReadAllText(archivoJson);
                dynamic configuracion = JsonConvert.DeserializeObject(contenidoJson);
                myConnectionString = configuracion.ConnectionString;
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool IsConnectionOpen()
        {
            return conn != null && conn.State == System.Data.ConnectionState.Open;
        }
    }
}

