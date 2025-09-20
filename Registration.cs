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
using System.IO;

namespace proiect
{
    public partial class Registration : Form
    {
        static string ConnectionString = "Data Source = localhost; port = 3306; username = user_proiect; password = parola; database = proiect;";
        MySqlConnection DBConnection = new MySqlConnection(ConnectionString);
        MySqlCommand cmd;
        MySqlDataReader reader;
        public Registration()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "";
                if (Username.Text != "" && Names.Text != "" && Surname.Text != "" && Email.Text != "" && Password.Text != "")
                    if (File.Exists("Profiles/" + Username.Text + ".jpg"))
                        query = "INSERT INTO utilizatori VALUES(NULL, '" + Username.Text + "', '" + Names.Text + "', '" + Surname.Text + "', '" + Email.Text + "', '" + Password.Text + "', '" + Username.Text + "')";
                    else
                        query = "INSERT INTO utilizatori VALUES(NULL, '" + Username.Text + "', '" + Names.Text + "', '" + Surname.Text + "', '" + Email.Text + "', '" + Password.Text + "', 'default ')";
                else
                    MessageBox.Show("Completeaza toate campurile!");
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                reader.Close();
                DBConnection.Close();
                MessageBox.Show("Inregistrare cu succes!");
                this.Close();
            }
            catch(Exception ex)
            {
                reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                try
                {
                    //MessageBox.Show(Nume.Text);
                    if (Username.Text != "" && File.Exists("Profiles/" + Username.Text + ".jpg"))
                        File.Delete("Profiles/" + Username.Text + ".jpg");
                    if (Username.Text != "")
                    {
                        //MessageBox.Show(Nume.Text);
                        //MessageBox.Show(ofd.FileName);
                        File.Copy(ofd.FileName, "Profiles/" + Username.Text + ".jpg");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
    }
}
