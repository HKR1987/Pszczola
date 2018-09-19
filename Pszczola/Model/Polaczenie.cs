using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Pszczola
{
    public class Polaczenie
    {
        private SQLiteConnection _dbConnection = new SQLiteConnection("Data Source=baza.sqlite;Version=3;");

        private SQLiteCommand _command;

        public void ZapytanieB(string s)
        {
            try
            {
                _dbConnection.Open();

                _command = new SQLiteCommand(s, _dbConnection);

                _command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                _dbConnection.Close();
            }
        }

        public DataSet ZapytanieZ(string s)
        {
            DataSet ds = new DataSet();

            try
            {
                _dbConnection.Open();

                var da = new SQLiteDataAdapter(s, _dbConnection);

                SQLiteCommand command = new SQLiteCommand(s, _dbConnection);



                da.Fill(ds);
            }
            catch (System.Data.SQLite.SQLiteException e)
            {
                if(e.ErrorCode==1)
                {
                    MessageBox.Show("Błąd SQLite");
                }
                else
                {
                    MessageBox.Show(e.Message);
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                _dbConnection.Close();
            }
            return ds;
        }
    }
}
