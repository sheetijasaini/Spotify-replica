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
    public partial class Form1 : Form
    {
        static string ConnectionString = "Data Source = localhost; port = 3306; username = root; password = ; database = proiect;";
        MySqlConnection DBConnection = new MySqlConnection(ConnectionString);
        MySqlCommand cmd;
        MySqlDataReader reader;
        public static bool inalbum = false;
        private string idalbum = "";
        public static string album = "", numealbum = "";
        public static string[] SongNumber = new string[100], SongGenre = new string[100], SongBand = new string[100];
        public Form1()
        {
            InitializeComponent();
            Default();
            Initial();
            SearchType.Text = "Album";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(inalbum is false)
            {
                switch(Table.CurrentCell.ColumnIndex)
                {
                    case 1:
                        {
                            inalbum = true;
                            idalbum = Table.Rows[e.RowIndex].Cells[0].Value.ToString();
                            album = idalbum;
                            SetTable();
                            try
                            {
                                GetSongGenre();
                                GetSongBand();
                                if (DBConnection.State != ConnectionState.Open)
                                    DBConnection.Open();
                                string query = "SELECT nume FROM album WHERE id = " + idalbum;
                                cmd = new MySqlCommand(query, DBConnection);
                                reader = cmd.ExecuteReader();
                                reader.Read();
                                numealbum = reader.GetString(0);
                                reader.Close();

                                query = "SELECT * FROM melodii WHERE album = " + idalbum;
                                cmd = new MySqlCommand(query, DBConnection);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    string[] row = new string[] { reader.GetString(0), reader.GetString(1), SongBand[Convert.ToInt32(reader.GetString(2))], numealbum, reader.GetString(3), SongGenre[Convert.ToInt32(reader.GetString(2))] };
                                    Table.Rows.Add(row);
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
                            break;
                        }
                    case 2:
                        {
                            try
                            {
                                if (DBConnection.State != ConnectionState.Open)
                                    DBConnection.Open();
                                string query = "SELECT * FROM album WHERE trupa = '" + Table.CurrentCell.Value.ToString() + "'";
                                cmd = new MySqlCommand(query, DBConnection);
                                Table.Rows.Clear();
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    string[] row = new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), SongNumber[Convert.ToInt32(reader.GetString(0))], reader.GetString(4), reader.GetString(5) };
                                    Table.Rows.Add(row);
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
                            break;
                        }
                    case 6:
                        {
                            try
                            {
                                if (DBConnection.State != ConnectionState.Open)
                                    DBConnection.Open();
                                string query = "SELECT * FROM album WHERE gen = '" + Table.CurrentCell.Value.ToString() + "'";
                                cmd = new MySqlCommand(query, DBConnection);
                                Table.Rows.Clear();
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    string[] row = new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), SongNumber[Convert.ToInt32(reader.GetString(0))], reader.GetString(4), reader.GetString(5) };
                                    Table.Rows.Add(row);
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
                            break;
                        }
                }
            }
            else
            {
                int poz = 0;
                int[] songId = new int[100];

                try
                {
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    string query = "SELECT id FROM melodii WHERE album = " + idalbum;
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        songId[poz] = Convert.ToInt32(reader.GetString(0));
                        poz++;
                    }
                    reader.Close();
                    DBConnection.Close();
                }
                catch(Exception ex)
                {
                    reader.Close();
                    DBConnection.Close();
                    MessageBox.Show(ex.Message);
                }

                switch(Table.CurrentCell.ColumnIndex)
                {
                    case 6:
                        {
                            int playId = songId[e.RowIndex];
                            //MessageBox.Show(songId[e.RowIndex].ToString());
                            break;
                        }
                }
            }
        }

        private void Initial()
        {
            Table.Columns.Clear();
            Table.Rows.Clear();
            try
            {
                GetSongNumber();
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT * FROM album";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                inalbum = false;
                SetTable();
                while (reader.Read())
                {
                    string[] row = new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), SongNumber[Convert.ToInt32(reader.GetString(0))], reader.GetString(4), reader.GetString(5) };
                    Table.Rows.Add(row);
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

        private void Back_Click(object sender, EventArgs e)
        {
            inalbum = false;
            Initial();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (SearchType.SelectedItem.ToString() == "Album")
            {
                Table.Rows.Clear();
                string query;
                try
                {
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    query = "SELECT * FROM album WHERE nume = '" + SearchBox.Text + "' OR trupa = '" + SearchBox.Text + "'";
                    inalbum = false;
                    SetTable();
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string[] row = new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), SongNumber[Convert.ToInt32(reader.GetString(0))], reader.GetString(4), reader.GetString(5) };
                        Table.Rows.Add(row);
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
                Table.Rows.Clear();
                string query;
                try
                {
                    GetSongGenre();
                    GetSongBand();
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    query = "SELECT * FROM melodii WHERE titlu = '" + SearchBox.Text + "' OR album IN (SELECT id FROM album WHERE trupa = '" + SearchBox.Text + "')";
                    inalbum = true;
                    SetTable();
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string[] row = new string[] { reader.GetString(0), reader.GetString(1), SongBand[Convert.ToInt32(reader.GetString(2))], reader.GetString(2), reader.GetString(3), SongGenre[Convert.ToInt32(reader.GetString(2))] };
                        Table.Rows.Add(row);
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

        private void SetTable()
        {
            Table.Rows.Clear();
            Table.Columns.Clear();
            if (inalbum is false)
            {
                Table.ColumnCount = 7;
                Table.Columns[0].Name = "ID";
                Table.Columns[1].Name = "Nume";
                Table.Columns[2].Name = "Trupa";
                Table.Columns[3].Name = "Lansare";
                Table.Columns[4].Name = "Nr_Melodii";
                Table.Columns[5].Name = "Durata";
                Table.Columns[6].Name = "Gen";
            }
            else
            {
                Table.ColumnCount = 6;
                Table.Columns[0].Name = "ID";
                Table.Columns[1].Name = "Titlu";
                Table.Columns[2].Name = "Trupa";
                Table.Columns[3].Name = "Album";
                Table.Columns[4].Name = "Lungime";
                Table.Columns[5].Name = "Gen";

                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Play";
                Table.Columns.Add(btn);
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
                    SongNumber[poz] = reader.GetString(1);
                }

                reader.Close();
                DBConnection.Close();
            }
            catch(Exception ex)
            {
                reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddForm F = new AddForm(this);
            F.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (inalbum is false)
            {
                try
                {
                    int id = 0;
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    string query = "DELETE FROM album WHERE id = '" + Table.CurrentCell.Value.ToString() + "'";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Close();

                    query = "SELECT id FROM album";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                        id = Convert.ToInt32(reader.GetString(0));
                    id += 1;
                    reader.Close();

                    query = "ALTER TABLE album AUTO_INCREMENT = " + id.ToString();
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                    DBConnection.Close();
                    Refresh("0");
                }
                catch(Exception ex)
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
                    int id = 0;
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    string query = "SELECT album FROM melodii WHERE id = '" + Table.CurrentCell.Value.ToString() + "'";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    string album = reader.GetString(0);
                    reader.Close();

                    query = "DELETE FROM melodii WHERE id = '" + Table.CurrentCell.Value.ToString() + "'";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Close();

                    query = "SELECT id FROM melodii";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                        id = Convert.ToInt32(reader.GetString(0));
                    id += 1;
                    reader.Close();

                    query = "ALTER TABLE melodii AUTO_INCREMENT = " + id.ToString();
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Close();

                    DBConnection.Close();
                    reader.Close();
                    Refresh(album);
                }
                catch (Exception ex)
                {
                    reader.Close();
                    DBConnection.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            var AlbumPath = "";
            var SongsPath = "";
            saveFile.Title = "Selecteaza fisierul pentru tabela album";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                AlbumPath = saveFile.FileName;
            }
            saveFile.Title = "Selecteaza fisierul pentru tabela melodii";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                SongsPath = saveFile.FileName;
            }
            
            File.WriteAllText(AlbumPath, "");
            File.WriteAllText(SongsPath, "");
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT * FROM album";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string date = reader.GetString(3);
                    date = date.Substring(0, date.Length - 12);
                    string[] temp = date.Split('/');
                    date = temp[2] + "-" + temp[0] + "-" + temp[1];
                    File.AppendAllText(AlbumPath, reader.GetString(1) + "~" + reader.GetString(2) + "~" + date + "~" + reader.GetString(4) + "~" + reader.GetString(5) + "\n");
                }
                reader.Close();

                query = "SELECT * from melodii";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    File.AppendAllText(SongsPath, reader.GetString(1) + "~" + reader.GetString(2) + "~" + reader.GetString(3) + "\n");
                }
                reader.Close();
                DBConnection.Close();

            }
            catch(Exception ex)
            {
                reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            string text = "";
            openFile.Title = "Selecteaza fisierul din care sa se introduca in tabela album";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    StreamReader file = new StreamReader(@"1albumDefault.txt");
                    while ((text = file.ReadLine()) != null)
                    {
                        string[] subs = text.Split('~');
                        string query = "INSERT INTO album VALUES(NULL, '" + subs[0] + "', '" + subs[1] + "', '" + subs[2] + "'  , '" + subs[3] + "', '" + subs[4] + "', '" + subs[5] + "')";
                        cmd = new MySqlCommand(query, DBConnection);
                        reader = cmd.ExecuteReader();
                        reader.Close();
                    }
                    DBConnection.Close();
                    if(inalbum is false)
                        Refresh("0");
                }
                catch(Exception ex)
                {
                    if (reader != null)
                        reader.Close();
                    DBConnection.Close();
                    MessageBox.Show(ex.Message);
                } 
            }

            openFile.Title = "Selecteaza fisierul din care sa se introduca in tabela melodii";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    StreamReader file = new StreamReader(openFile.FileName);
                    while ((text = file.ReadLine()) != null)
                    {
                        string[] subs = text.Split('~');
                        string query = "INSERT INTO melodii VALUES(NULL, '" + subs[0] + "', '" + subs[1] + "', '" + subs[2] + "')";
                        cmd = new MySqlCommand(query, DBConnection);
                        reader = cmd.ExecuteReader();
                        reader.Close();
                    }
                    DBConnection.Close();
                    if(inalbum is true)
                        Refresh(album);
                }
                catch (Exception ex)
                {
                    if (reader != null)
                        reader.Close();
                    DBConnection.Close();
                    MessageBox.Show(ex.Message);
                }
            }


        }

        void Refresh(string idalbum)
        {
            Table.Rows.Clear();
            if (inalbum is false)
            {
                try
                {
                    GetSongNumber();
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    string query = "SELECT * FROM album";
                    cmd = new MySqlCommand(query, DBConnection);
                    Table.Rows.Clear();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string[] row = new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), SongNumber[Convert.ToInt32(reader.GetString(0))], reader.GetString(4), reader.GetString(5) };
                        Table.Rows.Add(row);
                    }
                    reader.Close();
                    DBConnection.Close();
                }
                catch (Exception ex)
                {
                    if (reader != null)
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
                        string[] row = new string[] { reader.GetString(0), reader.GetString(1), SongBand[Convert.ToInt32(reader.GetString(2))], numealbum, reader.GetString(3), SongGenre[Convert.ToInt32(reader.GetString(2))] };
                        Table.Rows.Add(row);
                    }
                    reader.Close();
                    DBConnection.Close();
                }
                catch (Exception ex)
                {
                    if (reader != null)
                        reader.Close();
                    DBConnection.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DefaultValues_Click(object sender, EventArgs e)
        {
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "DELETE FROM album";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                reader.Close();

                query = "ALTER TABLE album AUTO_INCREMENT = 1";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                reader.Close();

                query = "DELETE FROM melodii";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                reader.Close();

                query = "ALTER TABLE melodii AUTO_INCREMENT = 1";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                reader.Close();

                string text = "";
                StreamReader file = new StreamReader(@"1albumDefault.txt");
                while ((text = file.ReadLine()) != null)
                {
                    string[] subs = text.Split('~');
                    query = "INSERT INTO album VALUES(NULL, '" + subs[0] + "', '" + subs[1] + "', '" + subs[2] + "'  , '" + subs[3] + "', '" + subs[4] + "', '" + subs[5] + "')";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
                Refresh("0");

                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();

                text = "";
                file = new StreamReader(@"2melodiiDefault.txt");
                while ((text = file.ReadLine()) != null)
                {
                    string[] subs = text.Split('~');
                    query = "INSERT INTO melodii VALUES(NULL, '" + subs[0] + "', '" + subs[1] + "', '" + subs[2] + "')";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }
                Refresh(album);
            }
            catch(Exception ex)
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
                while(reader.Read())
                    SongGenre[Convert.ToInt32(reader.GetString(0))] = reader.GetString(1);
                    
                reader.Close();
                DBConnection.Close();
            }
            catch(Exception ex)
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
                    SongBand[Convert.ToInt32(reader.GetString(0))] = reader.GetString(1);

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

        void Default()
        {
            try
            {
                bool albumExists = false, melodiiExists = false, proiectExists = false;
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SHOW DATABASES LIKE 'proiect'";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    proiectExists = true;
                reader.Close();

                query = "SHOW TABLES LIKE 'album'";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    albumExists = true;
                reader.Close();

                query = "SHOW TABLES LIKE 'melodii'";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    melodiiExists = true;
                reader.Close();

                if(proiectExists is false)
                {
                    query = "CREATE DATABASE proiect";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Close();
                }

                if (albumExists is false)
                {
                    query = "CREATE TABLE album (id int(10) unsigned NOT NULL KEY AUTO_INCREMENT, nume varchar(50) NOT NULL, trupa varchar(50) NOT NULL, lansare date NOT NULL, durata varchar(6) NOT NULL, gen varchar(50) NOT NULL)";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Close();

                    string text = "";
                    StreamReader file = new StreamReader(@"1albumDefault.txt");
                    while ((text = file.ReadLine()) != null)
                    {
                        string[] subs = text.Split('~');
                        query = "INSERT INTO album VALUES(NULL, '" + subs[0] + "', '" + subs[1] + "', '" + subs[2] + "'  , '" + subs[3] + "', '" + subs[4] + "')";
                        cmd = new MySqlCommand(query, DBConnection);
                        reader = cmd.ExecuteReader();
                        reader.Close();
                    }
                }

                if(melodiiExists is false)
                {
                    query = "CREATE TABLE melodii (id int(10) unsigned NOT NULL KEY AUTO_INCREMENT, titlu varchar(50) NOT NULL, album int(11) NOT NULL, lungime varchar(5) NOT NULL)";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Close();

                    string text = "";
                    StreamReader file = new StreamReader(@"2melodiiDefault.txt");
                    while ((text = file.ReadLine()) != null)
                    {
                        string[] subs = text.Split('~');
                        query = "INSERT INTO melodii VALUES(NULL, '" + subs[0] + "', '" + subs[1] + "', '" + subs[2] + "')";
                        cmd = new MySqlCommand(query, DBConnection);
                        reader = cmd.ExecuteReader();
                        reader.Close();
                    }
                }
                DBConnection.Close();
            }
            catch(Exception ex)
            {
                if(reader != null)
                    reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
