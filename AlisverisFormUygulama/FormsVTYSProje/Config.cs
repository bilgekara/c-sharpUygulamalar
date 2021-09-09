using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsVTYSProje
{
    class Config
    {
        string ConectionString = "";  // save connection string
        public NpgsqlConnection connection = null;
        public string server = "localhost";//  host / ip of the computer
        public string port = "5432";//  host / ip of the computer
        public string user = "postgres";//  user
        public string password = "nokta.";//  password 
        DataTable dt;
        public string Table = "Kullanici"; // initialize db table
        public string ConnectionType = "";
        string RecordSource = "";
        ArrayList Isimler = new ArrayList();

        public Config()
        {

        }

        // function to connect to the database
        public void Connect(string database_name)
        {
            try
            {

                ConectionString = "Server=" + server + ";" +"port="+port+";"+ "Database=" + database_name + ";" + "User Id=" + user + ";" + "Password=" + password + ";";

                connection = new NpgsqlConnection(ConectionString);
                connection.Open();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
       
        // Function to execute select statements
        public void ExecuteSql(string Sql_command)
        {

            nowquiee(Sql_command);

        }

        // creates connection to MySQL before execution
        public void nowquiee(string sql_comm)
        {
            try
            {
                NpgsqlConnection cs = new NpgsqlConnection(ConectionString);
                cs.Open();
                NpgsqlCommand myc = new NpgsqlCommand(sql_comm, cs);
                myc.ExecuteNonQuery();
                cs.Close();


            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }


        //
        //NpgsqlDataAdapter da = new NpgsqlDataAdapter(deneme, connection);
        //DataTable tablo = new DataTable();
        //da.Fill(tablo);
        //        //dataGridView1.DataSource = tablo;
        //        //baglanti.Close();
        // function to execute delete , insert and update
        public void Execute(string Sql_command)
        {
            //RecordSource = Sql_command;
            ConnectionType =   "Urun";
            dt = new DataTable(ConnectionType);
            string deneme = "Select *From " + '"' + "Urun" + '"';
            try
            {
                //string command = RecordSource.ToUpper();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(deneme, connection);
                DataTable tablo = new DataTable();
                da.Fill(dt);
                //======================if sql contains select==========================================
                //NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(deneme, connection);

                //DataSet tempds = new DataSet();
                //da2.Fill(tempds, ConnectionType);
                //da2.Fill(tempds);


                //======================================================================================


            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        public void ExecuteSearch(string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = "Urun";
            dt = new DataTable(ConnectionType);
            try
            {
                //string command = RecordSource.ToUpper();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(RecordSource, connection);
                DataTable tablo = new DataTable();
                da.Fill(dt);
                //======================if sql contains select==========================================
                //NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(deneme, connection);

                //DataSet tempds = new DataSet();
                //da2.Fill(tempds, ConnectionType);
                //da2.Fill(tempds);


                //======================================================================================


            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        // Execute select statement


        public void ExecuteSelect(string Sql_command, string tablo)
        {
            connection.Close();
            connection.Open();
            RecordSource = Sql_command;

            Isimler.Clear();

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(RecordSource, connection);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Isimler.Add(dr[tablo]);
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        } 
        public bool ExecuteLogin(string Sql_command)
        {
            Isimler.Clear();

            try
            {
                RecordSource = Sql_command;
                NpgsqlCommand cmd = new NpgsqlCommand(RecordSource, connection);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
                //dr.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı Lütfen Tekrar Deneyiniz");
                return false;
            }

        }
        public string Results(int ROW, string COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return "";

            }
        }

        // function to bring selected results based on column index and row index
        public string Results(int ROW, int COLUMN_NAME)
        {
            try
            {
                string deneme = dt.Rows[ROW][COLUMN_NAME].ToString();
                return deneme;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return dt.Rows[ROW][COLUMN_NAME].ToString();

            }
        }

        public string Results(int ROW)
        {
            try
            {
                string bak = Isimler[ROW].ToString();
                //string deneme = dt.Rows[ROW][COLUMN_NAME].ToString();
                return bak;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return dt.Rows[ROW].ToString();

            }
        }
        // count Number of rows after selecy
        public int Count()
        {
            return Isimler.Count;
            // return dt.Rows.Count;
        }
        public int Countt()
        {
            return dt.Rows.Count;
        }

    }
}
