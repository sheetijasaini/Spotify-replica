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
    public partial class AddForm : Form
    {
        static string ConnectionString = "Data Source = localhost; port = 3306; username = root; password = ; database = proiect;";
        MySqlConnection DBConnection = new MySqlConnection(ConnectionString);
        MySqlCommand cmd;
        MySqlDataReader reader;
        private readonly Form1 frm1;
        public AddForm(Form1 frm)
        {
            InitializeComponent();
            frm1 = frm;
            if (Form1.inalbum is true)
            {
                LTrupa.Hide();
                Band.Hide();
                LNume.Hide();
                Nume.Hide();
                LLansare.Hide();
                Launch.Hide();
                LDurata.Hide();
                Duration.Hide();
                LGen.Hide();
                Genre.Hide();
            }
            else
            {
                LTitlu.Hide();
                LLungime.Hide();
                Length.Hide();
                Title.Hide();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Form1.inalbum is false)
            {
                try
                {
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    string query = "";
                    if (File.Exists("Covers/" + Nume.Text + ".jpg"))
                        query = "INSERT INTO album VALUES(NULL, '" + Nume.Text + "', '" + Band.Text + "', '" + Launch.Text + "'  , '" + Duration.Text + "', '" + Genre.Text + "', '" + Nume.Text + "')";
                    else
                        query = "INSERT INTO album VALUES(NULL, '" + Nume.Text + "', '" + Band.Text + "', '" + Launch.Text + "'  , '" + Duration.Text + "', '" + Genre.Text + "', " + "'default')";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                    Refresh(Form1.album);
                    DBConnection.Close();

                }
                catch (Exception ex)
                {
                    DBConnection.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    string query = "INSERT INTO melodii VALUES (NULL, '" + Title.Text + "', '" + Form1.album + "', '" + Length.Text + "')";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                    Refresh(Form1.album);
                    DBConnection.Close();
                }
                catch (Exception ex)
                {
                    reader.Close();
                    DBConnection.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            foreach (TextBox t in this.Controls.OfType<TextBox>())
                t.Text = "";
            foreach (MaskedTextBox t in this.Controls.OfType<MaskedTextBox>())
                t.Text = "";
        }

        void Refresh(string idalbum)
        {
            frm1.Table.Rows.Clear();
            GetSongNumber();
            if (Form1.inalbum is false)
            {
                try
                {
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    string query = "SELECT * FROM album";
                    cmd = new MySqlCommand(query, DBConnection);
                    frm1.Table.Rows.Clear();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string[] row = new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), Form1.SongNumber[Convert.ToInt32(reader.GetString(0))], reader.GetString(4), reader.GetString(5) };
                        frm1.Table.Rows.Add(row);
                    }
                    reader.Close();
                    DBConnection.Close();
                }
                catch (Exception ex)
                {
                    reader.Close();
                    DBConnection.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    GetSongGenre();
                    GetSongBand();
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    string query = "SELECT * FROM melodii WHERE album = " + idalbum;
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string[] row = new string[] { reader.GetString(0), reader.GetString(1), Form1.SongBand[Convert.ToInt32(reader.GetString(2))], Form1.numealbum, reader.GetString(3), Form1.SongGenre[Convert.ToInt32(reader.GetString(2))] };
                        frm1.Table.Rows.Add(row);
                    }
                    reader.Close();
                    DBConnection.Close();
                }
                catch (Exception ex)
                {
                    reader.Close();
                    DBConnection.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void GetSongNumber()
        {

            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT album, COUNT(*) FROM melodii GROUP BY album";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int poz = Convert.ToInt32(reader.GetString(0));
                    Form1.SongNumber[poz] = reader.GetString(1);
                }

                reader.Close();
                DBConnection.Close();
            }
            catch (Exception ex)
            {
                reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        void GetSongGenre()
        {
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT id, gen FROM album";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    Form1.SongGenre[Convert.ToInt32(reader.GetString(0))] = reader.GetString(1);

                reader.Close();
                DBConnection.Close();
            }
            catch (Exception ex)
            {
                reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        void GetSongBand()
        {
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT id, trupa FROM album";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    Form1.SongBand[Convert.ToInt32(reader.GetString(0))] = reader.GetString(1);

                reader.Close();
                DBConnection.Close();
            }
            catch (Exception ex)
            {
                reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                try
                {
                    //MessageBox.Show(Nume.Text);
                    if (Nume.Text != "" && File.Exists("Covers/" + Nume.Text + ".jpg"))
                        File.Delete("Covers/" + Nume.Text + ".jpg");
                    if(Nume.Text != "")
                    {
                        //MessageBox.Show(Nume.Text);
                        //MessageBox.Show(ofd.FileName);
                        File.Copy(ofd.FileName, "Covers/" + Nume.Text + ".jpg");
                    }
                        
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }
    }
}
