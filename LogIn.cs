using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proiect
{
    public partial class LogIn : Form
    {
        static string ConnectionString = "Data Source = localhost; port = 3306; username = root; password = ; database = proiect;";
        MySqlConnection DBConnection = new MySqlConnection(ConnectionString);
        MySqlCommand cmd;
        MySqlDataReader reader;
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "admin" && Password.Text == "admin")
            {
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }    
            else
                try
                {
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    string query = "SELECT id FROM utilizatori WHERE username = '" + Username.Text + "' and parola = '" + Password.Text + "'";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if(reader.HasRows)
                    {
                        Spotify.idUser = reader.GetString(0);
                        reader.Close();
                        DBConnection.Close();
                        this.Hide();
                        Spotify s = new Spotify();
                        s.ShowDialog();
                        this.Close();
                    }

                }
                catch(Exception ex)
                {
                    reader.Close();
                    DBConnection.Close();
                    MessageBox.Show(ex.ToString());
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }
    }
}
