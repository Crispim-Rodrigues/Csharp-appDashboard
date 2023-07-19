using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
namespace GBM.DALL
{
    internal class DALLCon
    {
        private static string myConn = "server=localhost; user=root; database=dashgbm; password=";
        private MySqlConnection Conn = new MySqlConnection(myConn);
        public void Open()
        {
            
            try
            {
                Conn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception)
            {
                
            }
            finally { Conn.Close(); }
        }
        public void Close() => Conn.Close();
    }
}
