using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YumYard.DatabaseAccess
{
    static class DbAccess
    {
        //this is the connection string to the database is only available on my computer (Nafim) add your own connection string to the code

        // public static string ConnectionString = "Data Source=NPC\\SQLEXPRESS;Initial Catalog=YumYardDb;Integrated Security=True;Encrypt=False";
        //Karib connection
        //public static string ConnectionString = "Data Source=DESKTOP-DFDO1KK\\SQLEXPRESS;Initial Catalog=YumYardDB;Integrated Security=True;Encrypt=False";
        //Data Source=NPC\SQLEXPRESS;Initial Catalog=YumYardDb;Integrated Security=True;Encrypt=False (Use Encription as Optional and dont use trust certificate)

        public static string ConnectionString = "Data Source=DESKTOP-8GC16NO\\SQLEXPRESS;Initial Catalog=YumYardDB;Integrated Security=True;Encrypt=False";

        public static DataTable GetData(string query, out string error)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);

                DataTable dt = ds.Tables[0];

                con.Close();
                error = "";
                return dt;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;

            }

        }

        public static void ExecuteQuery(string query, out string error)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                error = "";
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
        }
    }
}
