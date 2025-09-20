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
    public partial class Users : Form
    {
        static string ConnectionString = "Data Source = localhost; port = 3306; username = user_proiect; password = parola; database = proiect;";
        MySqlConnection DBConnection = new MySqlConnection(ConnectionString);
        MySqlCommand cmd;
        MySqlDataReader reader;
        ImageList img = new ImageList();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            RefreshDB();
        }

        private void RefreshDB()
        {
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT id, imagine, username, nume, prenume FROM utilizatori WHERE id IN (SELECT id_user2 FROM prietenii WHERE id_user1 = " + Spotify.idUser + ") AND id <> " + Spotify.idUser;
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                int i = 0;
                dataGridView1.RowCount = 1;
                while (reader.Read())
                {
                    dataGridView1.RowCount++;
                    Bitmap img = new Bitmap(@"Profiles/" + reader.GetString(1) + ".jpg");
                    img = new Bitmap(img, 50, 50);
                    dataGridView1.Rows[i].Cells[0].Value = reader.GetString(0);
                    dataGridView1.Rows[i].Cells[1].Value = img;
                    dataGridView1.Rows[i].Cells[2].Value = reader.GetString(2);
                    dataGridView1.Rows[i].Cells[3].Value = reader.GetString(3);
                    dataGridView1.Rows[i].Cells[4].Value = reader.GetString(4);
                    i++;
                    
                }
                if (reader != null)
                    reader.Close();
                query = "SELECT id, imagine, username, nume, prenume FROM utilizatori WHERE id NOT IN (SELECT id_user2 FROM prietenii WHERE id_user1 = " + Spotify.idUser + ") AND id <> " + Spotify.idUser;
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.RowCount++;
                    Bitmap img = new Bitmap(@"Profiles/" + reader.GetString(1) + ".jpg");
                    img = new Bitmap(img, 50, 50);
                    dataGridView1.Rows[i].Cells[0].Value = reader.GetString(0);
                    dataGridView1.Rows[i].Cells[1].Value = img;
                    dataGridView1.Rows[i].Cells[2].Value = reader.GetString(2);
                    dataGridView1.Rows[i].Cells[3].Value = reader.GetString(3);
                    dataGridView1.Rows[i].Cells[4].Value = reader.GetString(4);
                    i++;
                }
                dataGridView1.RowCount--;

                if (reader != null)
                    reader.Close();
                DBConnection.Close();
            }
            catch (Exception ex)
            {
                if (reader != null)
                    reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.ToString());
            }

            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT id_user2 FROM prietenii WHERE id_user1 = " + Spotify.idUser;
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                        if (Convert.ToInt32(row.Cells[0].Value) == Convert.ToInt32(reader.GetString(0)))
                            row.Cells[5].Value = "-";
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                        if(row.Cells[5].Value is null)
                            row.Cells[5].Value = "+";
                }
                if (reader != null)
                    reader.Close();
                DBConnection.Close();
                    
            }
            catch (Exception ex)
            {
                if (reader != null)
                    reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var width = 10;
            var height = 0;
            foreach (DataGridViewColumn cl in dataGridView1.Columns)
                width += cl.Width;
            foreach (DataGridViewRow rw in dataGridView1.Rows)
                height += rw.Height;
            dataGridView1.Width = width;
            if(height < 400)
                dataGridView1.Height = height;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();

                if (dataGridView1.CurrentCell.ColumnIndex == 5)
                {
                    if (dataGridView1.CurrentCell.Value.ToString() == "+")
                    {
                        string query = "INSERT INTO prietenii VALUES (" + Spotify.idUser + ", " + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString() + ")";
                        cmd = new MySqlCommand(query, DBConnection);
                        reader = cmd.ExecuteReader();
                        if (reader != null)
                            reader.Close();
                        DBConnection.Close();
                    }
                    else
                    {
                        string query = "DELETE FROM prietenii WHERE id_user1 = " + Spotify.idUser + " AND id_user2 = " + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                        cmd = new MySqlCommand(query, DBConnection);
                        reader = cmd.ExecuteReader();
                        if (reader != null)
                            reader.Close();
                    }
                }

                DBConnection.Close();
            }
            catch(Exception ex)
            {
                if (reader != null)
                    reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.ToString());
            }
            RefreshDB();
        }
    }
}
