using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class ConectarBD
    {
        MySqlConnection con;
        public ConectarBD(string servidor, string usuario, string password, string database)
        {
            con = new MySqlConnection(string.Format("server={0};user={1};password={2};database={3}",
                servidor, usuario, password, database));
        }
        public string Comando(string q)
        {
            string rs = "";
            try
            {
                MySqlCommand c = new MySqlCommand(q, con);
                con.Open();
                c.ExecuteNonQuery();
                con.Close();
                rs = "Correcto";
            }
            catch (Exception ex)
            {
                con.Close();
                rs = ex.Message;
            }
            return rs;
        }

        public bool Dato(string q)
        {
            int rs=0;
            try
            {
                con.Open();
                MySqlCommand c = new MySqlCommand(q, con);
                rs = Convert.ToInt32(c.ExecuteScalar());
            }
            catch (Exception ex)
            {
               con.Close() ;
            }
            return rs==1;
        }
        public string Dato2(string query, Dictionary<string, object> parameters)
        {
            string rs = "";
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }
                rs = Convert.ToString(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }

            return rs;
        }
        public bool Dato3(string query, Dictionary<string, object> parameters)
        {
            int count=0;
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(query, con);
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }
                count = Convert.ToInt32(command.ExecuteScalar());
                //rs = Convert.ToString(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            return count == 1;
        }

        public DataSet Obtener(string q, string tabla)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(q, con);
                con.Open();
                da.Fill(ds, tabla);
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
            }
            return ds;
        }
    }
}
