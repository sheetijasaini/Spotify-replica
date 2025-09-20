using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;
using System.Globalization;

namespace proiect
{
    public partial class Spotify : Form
    {
        static string ConnectionString = "Data Source = localhost; port = 3306; username = root; password = ; database = proiect;";
        MySqlConnection DBConnection = new MySqlConnection(ConnectionString);
        List<string> Covers = new List<string>();
        List<string> Profiles = new List<string>();
        List<string> AlbumSongs = new List<string>();
        ImageList img = new ImageList();
        ImageList ProfilePictures = new ImageList();
        MySqlCommand cmd;
        MySqlDataReader reader;
        string Name = "", Band = "", idAlbum = "";
        public static string idUser = "1";
        bool playing = false;
        public Spotify()
        {
            InitializeComponent();
            UpdateFavorites();
            Volume.Value = 4;
            player.settings.volume = 4;
            PlayPause.BackgroundImage = proiect.Properties.Resources.Play;
            //MessageBox.Show(idUser);
            Covers = Directory.GetFiles("Covers", "*jpg", SearchOption.TopDirectoryOnly).ToList();
            img.ImageSize = new Size(180, 180);
            img.ColorDepth = ColorDepth.Depth32Bit;
            int i = 0;
            foreach (var file in Covers)
            {
                img.Images.Add(Image.FromFile(file));
                img.Images.SetKeyName(i, file.ToString().Substring(0, file.Length - 4).Substring(7));
                i++;
            }
            SongView.LargeImageList = img;

            Profiles = Directory.GetFiles("Profiles", "*jpg", SearchOption.TopDirectoryOnly).ToList();
            ProfilePictures.ImageSize = new Size(40, 40);
            ProfilePictures.ColorDepth = ColorDepth.Depth32Bit;
            i = 0;
            foreach (var file in Profiles)
            {
                ProfilePictures.Images.Add(Image.FromFile(file));
                ProfilePictures.Images.SetKeyName(i, file.ToString().Substring(0, file.Length - 4).Substring(9));
                i++;
            }
            FriendList.SmallImageList = ProfilePictures;

            Initial();
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT username FROM utilizatori WHERE id = " + idUser;
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    UserName.Text = reader.GetString(0);
                    ProfilePicture.ImageLocation = "Profiles/" + reader.GetString(0) + ".jpg";
                    BigProfilePicture.ImageLocation = "Profiles/" + reader.GetString(0) + ".jpg";
                }
                reader.Close();
                DBConnection.Close();
            }
            catch(Exception ex)
            {
                if (reader != null)
                    reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void Initial()
        {
            SongView.Items.Clear();
            FriendList.Items.Clear();
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT nume, trupa, imagine FROM album";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0) + "\n" + reader.GetString(1), img.Images.IndexOfKey(reader.GetString(2)));
                    SongView.Items.Add(item);
                }
                reader.Close();

                query = "SELECT username, imagine FROM utilizatori WHERE id IN (SELECT id_user2 FROM prietenii WHERE id_user1 = " + idUser + ")";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0), ProfilePictures.Images.IndexOfKey(reader.GetString(1)));
                    FriendList.Items.Add(item);
                }

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

        private void listView1_Click(object sender, EventArgs e)
        {
            ListViewItem item = SongView.Items[SongView.SelectedIndices[0]];
            Name = item.Text.Split('\n')[0];
            Band = item.Text.Split('\n')[1];
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT id FROM album WHERE nume = '" + Name + "' and trupa = '" + Band + "'";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                    idAlbum = reader.GetString(0);
                reader.Close();
                DBConnection.Close();
            }
            catch(Exception ex)
            {
                if (reader != null)
                    reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.ToString());
            }
            SongView.Hide();
            try
            {
                SongTable.Rows.Clear();
                Title.Text = Name;
                Composer.Text = Band;
                pictureBox1.ImageLocation = "Covers/" + Name + ".jpg";
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT id, titlu, lungime FROM melodii WHERE album = " + idAlbum;
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2) };
                    SongTable.Rows.Add(row);
                }
                reader.Close();
                DBConnection.Close();
            }
            catch(Exception ex)
            {
                if (reader != null)
                    reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.ToString());
            }
            bool exists = inFavorites(idAlbum);
            if (exists is true)
                Favorites.Text = "n";
            else
                Favorites.Text = "f";
            if (Favorites.Text == "n")
            {
                Favorites.BackgroundImage = proiect.Properties.Resources.favorite;
                Favorites.ForeColor = Color.Red;
            }
            else
            {
                Favorites.BackgroundImage = proiect.Properties.Resources.notfavorite;
                Favorites.ForeColor = Color.White;
            }

        }

        private bool inFavorites(string id)
        {
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT " + id + " IN (SELECT id_album FROM favorite WHERE id_user = " + idUser + ")";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                reader.Read();
                if(reader.HasRows)
                {
                    string value = reader.GetString(0);
                    reader.Close();
                    DBConnection.Close();
                    if (value == "1")
                        return true;
                    else
                        return false;
                }
            }
            catch(Exception ex)
            {
                if (reader != null)
                    reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.ToString());
            }
            return false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            SongView.Show();
            pictureBox1.Show();
            Title.Show();
            Composer.Show();
            richTextBox3.Show();
            Favorites.Show();
            SongTable.Show();
            SearchBox.Text = "";
            SongView.Show();
            Initial();
        }

        private void LikedAlbums_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            Color myColor = Color.FromArgb(46, 46, 46);
            Brush myBrush = new SolidBrush(myColor);
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Near;

                using (var headerFont = new Font("Geometr706 BlkCn BT", 10, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(myBrush, e.Bounds);
                    e.Graphics.DrawString(e.Header.Text, headerFont,
                        Brushes.White, e.Bounds, sf);
                }
            }
        }

        private void LikedAlbums_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Color myColor = Color.FromArgb(38, 38, 38);
            Brush myBrush = new SolidBrush(myColor);
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Near;

                using (var headerFont = new Font("Geometr706 BlkCn BT", 10, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(myBrush, e.Bounds);
                    e.Graphics.DrawString(e.Item.Text, headerFont,
                        Brushes.White, e.Bounds, sf);
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                SongView.Items.Clear();
                SongView.Show();
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT nume, trupa, imagine FROM album WHERE nume = '" + SearchBox.Text + "' OR trupa = '" + SearchBox.Text + "' OR id IN (SELECT album FROM melodii WHERE titlu = '" + SearchBox.Text + "')";
                //MessageBox.Show(query);
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ListViewItem item;
                    if (reader.HasRows)
                    {
                        item = new ListViewItem(reader.GetString(0) + "\n" + reader.GetString(1), img.Images.IndexOfKey(reader.GetString(2)));
                        SongView.Items.Add(item);
                    }
                }
                reader.Close();
                DBConnection.Close();
            }
            catch(Exception ex)
            {
                if (reader != null)
                    reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void LikedAlbums_Click(object sender, EventArgs e)
        {
            ListViewItem item = LikedAlbums.Items[LikedAlbums.SelectedIndices[0]];
            Name = item.Text;
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT id FROM album WHERE nume = '" + Name + "'";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                    idAlbum = reader.GetString(0);
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
            SongView.Hide();
            try
            {
                SongTable.Rows.Clear();
                Title.Text = Name;
                Composer.Text = Band;
                pictureBox1.ImageLocation = "Covers/" + Name + ".jpg";
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "SELECT id, titlu, lungime FROM melodii WHERE album = " + idAlbum;
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2) };
                    SongTable.Rows.Add(row);
                }
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

        private void Favorites_Click(object sender, EventArgs e)
        {
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "";
                if (Favorites.Text == "f")
                {
                    query = "INSERT INTO favorite VALUES(" + idUser + ", " + idAlbum + ")";
                    Favorites.BackgroundImage = proiect.Properties.Resources.favorite;
                    Favorites.ForeColor = Color.Red;
                    Favorites.Text = "n";
                }
                else
                {
                    query = "DELETE FROM favorite WHERE id_user = " + idUser + " AND id_album = " + idAlbum;
                    Favorites.BackgroundImage = proiect.Properties.Resources.notfavorite;
                    Favorites.ForeColor = Color.White;
                    Favorites.Text = "f";
                }
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                reader.Close();
                DBConnection.Close();
                UpdateFavorites();
            }
            catch(Exception ex)
            {
                if (reader != null)
                    reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void FriendList_Click(object sender, EventArgs e)
        {
            SongView.Items.Clear();
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                string query = "select nume, trupa, imagine from album where id in (select id_album from favorite where id_user = (SELECT id FROM utilizatori WHERE username = '" + FriendList.SelectedItems[0].Text + "'))";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0) + "\n" + reader.GetString(1), img.Images.IndexOfKey(reader.GetString(2)));
                    SongView.Items.Add(item);
                }
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

        private void AddFriend_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.ShowDialog();
            Initial();
        }

        private void PlayPause_Click(object sender, EventArgs e)
        {
            switch(playing)
            {
                case true: PlayPause.BackgroundImage = proiect.Properties.Resources.Play; playing = false; player.Ctlcontrols.pause(); //MessageBox.Show("The song is no longer playing"); 
                    break;
                case false: PlayPause.BackgroundImage = proiect.Properties.Resources.Pause; playing = true; player.Ctlcontrols.play(); //MessageBox.Show("The song is now playing"); 
                    break;
            }
                
        }

        private void LikedAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = Volume.Value;
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                TrackBar.Maximum = Convert.ToInt32(player.Ctlcontrols.currentItem.duration);
                timer.Start();
            }
            else
                if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
                    timer.Stop();
                else
                    if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
                        timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Remaining.Text = player.Ctlcontrols.currentPositionString;
            Time.Text = player.Ctlcontrols.currentItem.durationString;
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                TrackBar.Value = Convert.ToInt32(player.Ctlcontrols.currentPosition);
            }
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            timer.Stop();
            int temp = Volume.Value;
            Volume.Value = 0;
            player.Ctlcontrols.currentPosition = TrackBar.Value;
            timer.Start();
            Volume.Value = temp;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            int val = AlbumSongs.IndexOf(SongName.Text);
            MessageBox.Show(AlbumSongs.Count.ToString());
            try
            {
                SongName.Text = AlbumSongs[val + 1];
                player.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Songs/" + SongName.Text + ".mp3");
                MessageBox.Show(player.URL.ToString());
            }
            catch(Exception ex)
            {
                if (reader != null)
                    reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.ToString());
            }
                
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            int val = AlbumSongs.IndexOf(SongName.Text);
            MessageBox.Show(AlbumSongs.Count.ToString());
            try
            {
                SongName.Text = AlbumSongs[val - 1];
                player.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Songs/" + SongName.Text + ".mp3");
                MessageBox.Show(player.URL.ToString());
            }
            catch (Exception ex)
            {
                if (reader != null)
                    reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            SongView.Hide();
            pictureBox1.Hide();
            Title.Hide();
            Composer.Hide();
            richTextBox3.Hide();
            Favorites.Hide();
            SongTable.Hide();
            BigProfilePicture.Show();
            UsernameLabel.Show();
            Profile.Show();
            Info.Show();
        }

        private void SongTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(SongTable.CurrentCell.ColumnIndex == 0)
            {
                try
                {
                    AlbumSongs.Clear();
                    if (DBConnection.State != ConnectionState.Open)
                        DBConnection.Open();
                    string query = "SELECT titlu FROM melodii WHERE album = (SELECT id FROM album WHERE trupa = '" + Band + "')";
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    while(reader.Read())
                    {
                        AlbumSongs.Add(reader.GetString(0));
                    }
                    reader.Close();
                    query = "SELECT titlu FROM melodii WHERE id = " + SongTable.CurrentCell.Value;
                    cmd = new MySqlCommand(query, DBConnection);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                        SongName.Text = reader.GetString(0);
                    DBConnection.Close();
                }
                catch (Exception ex)
                {
                    if (reader != null)
                        reader.Close();
                    DBConnection.Close();
                    MessageBox.Show(ex.ToString());
                }
                Author.Text = Band;
                AlbumCover.ImageLocation = "Covers/" + Name + ".jpg";

                PlayPause.BackgroundImage = proiect.Properties.Resources.Pause;
                playing = true;
                player.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Songs/" + SongName.Text + ".mp3");
                MessageBox.Show(player.URL.ToString());
            }
        }

        private void UpdateFavorites()
        {
            try
            {
                LikedAlbums.Items.Clear();
                if (DBConnection.State != ConnectionState.Open)
                    DBConnection.Open();
                //MessageBox.Show(idUser);
                string query = "select nume from album where id in (select id_album from favorite where id_user = " + idUser + ")";
                cmd = new MySqlCommand(query, DBConnection);
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0));
                    LikedAlbums.Items.Add(item);
                }
                reader.Close();
                DBConnection.Close();
            }
            catch(Exception ex)
            {
                if (reader != null)
                    reader.Close();
                DBConnection.Close();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
