namespace proiect
{
    partial class Spotify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spotify));
            this.SongTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lungime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.TrackBar = new System.Windows.Forms.TrackBar();
            this.Time = new System.Windows.Forms.Label();
            this.Remaining = new System.Windows.Forms.Label();
            this.SongName = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SongView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = new System.Windows.Forms.RichTextBox();
            this.Composer = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.LikedAlbums = new System.Windows.Forms.ListView();
            this.Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Search = new System.Windows.Forms.Button();
            this.FriendList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.PlayPause = new System.Windows.Forms.Button();
            this.AddFriend = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.AlbumCover = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Favorites = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Profile = new System.Windows.Forms.Label();
            this.BigProfilePicture = new System.Windows.Forms.PictureBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SongTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SongTable
            // 
            this.SongTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.SongTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SongTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SongTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SongTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Titlu,
            this.Lungime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SongTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.SongTable.Location = new System.Drawing.Point(148, 209);
            this.SongTable.Name = "SongTable";
            this.SongTable.RowHeadersVisible = false;
            this.SongTable.Size = new System.Drawing.Size(894, 613);
            this.SongTable.TabIndex = 1;
            this.SongTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SongTable_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Nr.";
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 40;
            // 
            // Titlu
            // 
            this.Titlu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titlu.HeaderText = "Title";
            this.Titlu.Name = "Titlu";
            this.Titlu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lungime
            // 
            this.Lungime.HeaderText = "Length";
            this.Lungime.Name = "Lungime";
            this.Lungime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Lungime.Width = 50;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(33, 863);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(1145, 847);
            this.Volume.Maximum = 100;
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(144, 45);
            this.Volume.TabIndex = 4;
            this.Volume.Scroll += new System.EventHandler(this.Volume_Scroll);
            // 
            // TrackBar
            // 
            this.TrackBar.Location = new System.Drawing.Point(343, 863);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(566, 45);
            this.TrackBar.TabIndex = 8;
            this.TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(915, 863);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(44, 16);
            this.Time.TabIndex = 9;
            this.Time.Text = "label2";
            // 
            // Remaining
            // 
            this.Remaining.AutoSize = true;
            this.Remaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remaining.ForeColor = System.Drawing.Color.White;
            this.Remaining.Location = new System.Drawing.Point(292, 863);
            this.Remaining.Name = "Remaining";
            this.Remaining.Size = new System.Drawing.Size(44, 16);
            this.Remaining.TabIndex = 10;
            this.Remaining.Text = "label1";
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.ForeColor = System.Drawing.Color.White;
            this.SongName.Location = new System.Drawing.Point(90, 851);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(0, 24);
            this.SongName.TabIndex = 12;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.ForeColor = System.Drawing.Color.White;
            this.Author.Location = new System.Drawing.Point(90, 874);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(0, 13);
            this.Author.TabIndex = 13;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(943, 15);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(51, 20);
            this.UserName.TabIndex = 15;
            this.UserName.Text = "Bazar";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(208, 17);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(255, 20);
            this.SearchBox.TabIndex = 16;
            // 
            // SongView
            // 
            this.SongView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.SongView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SongView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.SongView.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongView.ForeColor = System.Drawing.SystemColors.Window;
            this.SongView.HideSelection = false;
            this.SongView.Location = new System.Drawing.Point(148, 49);
            this.SongView.Name = "SongView";
            this.SongView.Size = new System.Drawing.Size(894, 774);
            this.SongView.TabIndex = 17;
            this.SongView.UseCompatibleStateImageBehavior = false;
            this.SongView.Click += new System.EventHandler(this.listView1_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.DetectUrls = false;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(295, 103);
            this.Title.Margin = new System.Windows.Forms.Padding(0);
            this.Title.Multiline = false;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(740, 85);
            this.Title.TabIndex = 19;
            this.Title.Text = "Bad - 25th Anniversary";
            // 
            // Composer
            // 
            this.Composer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Composer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Composer.DetectUrls = false;
            this.Composer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Composer.ForeColor = System.Drawing.Color.White;
            this.Composer.Location = new System.Drawing.Point(295, 175);
            this.Composer.Margin = new System.Windows.Forms.Padding(0);
            this.Composer.Multiline = false;
            this.Composer.Name = "Composer";
            this.Composer.ReadOnly = true;
            this.Composer.Size = new System.Drawing.Size(253, 28);
            this.Composer.TabIndex = 21;
            this.Composer.Text = "Michael Jackson";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.DetectUrls = false;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(295, 84);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox3.Multiline = false;
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(35, 19);
            this.richTextBox3.TabIndex = 22;
            this.richTextBox3.Text = "Album";
            // 
            // LikedAlbums
            // 
            this.LikedAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LikedAlbums.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LikedAlbums.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Album});
            this.LikedAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikedAlbums.ForeColor = System.Drawing.Color.White;
            this.LikedAlbums.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LikedAlbums.HideSelection = false;
            this.LikedAlbums.Location = new System.Drawing.Point(2, 16);
            this.LikedAlbums.Name = "LikedAlbums";
            this.LikedAlbums.OwnerDraw = true;
            this.LikedAlbums.Size = new System.Drawing.Size(150, 806);
            this.LikedAlbums.TabIndex = 24;
            this.LikedAlbums.UseCompatibleStateImageBehavior = false;
            this.LikedAlbums.View = System.Windows.Forms.View.Details;
            this.LikedAlbums.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.LikedAlbums_DrawColumnHeader);
            this.LikedAlbums.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.LikedAlbums_DrawSubItem);
            this.LikedAlbums.SelectedIndexChanged += new System.EventHandler(this.LikedAlbums_SelectedIndexChanged);
            this.LikedAlbums.Click += new System.EventHandler(this.LikedAlbums_Click);
            // 
            // Album
            // 
            this.Album.Text = "Albume Favorite";
            this.Album.Width = 150;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(469, 15);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 25;
            this.Search.Text = "Cauta";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // FriendList
            // 
            this.FriendList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.FriendList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FriendList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.FriendList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendList.ForeColor = System.Drawing.Color.White;
            this.FriendList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FriendList.HideSelection = false;
            this.FriendList.Location = new System.Drawing.Point(1038, 49);
            this.FriendList.Name = "FriendList";
            this.FriendList.Size = new System.Drawing.Size(257, 774);
            this.FriendList.TabIndex = 26;
            this.FriendList.UseCompatibleStateImageBehavior = false;
            this.FriendList.View = System.Windows.Forms.View.SmallIcon;
            this.FriendList.Click += new System.EventHandler(this.FriendList_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Picture";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 187;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(1038, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(176, 27);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = " Activitatea prietenilor";
            // 
            // Next
            // 
            this.Next.BackgroundImage = global::proiect.Properties.Resources.Next;
            this.Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Location = new System.Drawing.Point(669, 829);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 6;
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.BackgroundImage = global::proiect.Properties.Resources.Previous;
            this.Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Previous.FlatAppearance.BorderSize = 0;
            this.Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous.Location = new System.Drawing.Point(507, 829);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 7;
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // PlayPause
            // 
            this.PlayPause.BackgroundImage = global::proiect.Properties.Resources.Play;
            this.PlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayPause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PlayPause.FlatAppearance.BorderSize = 0;
            this.PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayPause.ForeColor = System.Drawing.Color.Transparent;
            this.PlayPause.Location = new System.Drawing.Point(588, 828);
            this.PlayPause.Name = "PlayPause";
            this.PlayPause.Size = new System.Drawing.Size(75, 24);
            this.PlayPause.TabIndex = 5;
            this.PlayPause.UseVisualStyleBackColor = true;
            this.PlayPause.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // AddFriend
            // 
            this.AddFriend.BackColor = System.Drawing.Color.Transparent;
            this.AddFriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFriend.BackgroundImage")));
            this.AddFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddFriend.FlatAppearance.BorderSize = 0;
            this.AddFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFriend.ForeColor = System.Drawing.Color.Transparent;
            this.AddFriend.Location = new System.Drawing.Point(1209, 11);
            this.AddFriend.Name = "AddFriend";
            this.AddFriend.Size = new System.Drawing.Size(30, 31);
            this.AddFriend.TabIndex = 28;
            this.AddFriend.UseVisualStyleBackColor = false;
            this.AddFriend.Click += new System.EventHandler(this.AddFriend_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(158, 15);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(37, 23);
            this.Back.TabIndex = 18;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicture.Image")));
            this.ProfilePicture.Location = new System.Drawing.Point(902, 12);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(35, 31);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 14;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Click += new System.EventHandler(this.ProfilePicture_Click);
            // 
            // AlbumCover
            // 
            this.AlbumCover.Location = new System.Drawing.Point(22, 842);
            this.AlbumCover.Name = "AlbumCover";
            this.AlbumCover.Size = new System.Drawing.Size(62, 50);
            this.AlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlbumCover.TabIndex = 11;
            this.AlbumCover.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Favorites
            // 
            this.Favorites.BackgroundImage = global::proiect.Properties.Resources.favorite;
            this.Favorites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Favorites.FlatAppearance.BorderSize = 0;
            this.Favorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Favorites.ForeColor = System.Drawing.Color.Transparent;
            this.Favorites.Location = new System.Drawing.Point(343, 78);
            this.Favorites.Margin = new System.Windows.Forms.Padding(0);
            this.Favorites.Name = "Favorites";
            this.Favorites.Size = new System.Drawing.Size(33, 29);
            this.Favorites.TabIndex = 23;
            this.Favorites.UseVisualStyleBackColor = true;
            this.Favorites.Click += new System.EventHandler(this.Favorites_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(23, 851);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(51, 28);
            this.player.TabIndex = 29;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Profile
            // 
            this.Profile.AutoSize = true;
            this.Profile.Location = new System.Drawing.Point(416, 103);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(52, 13);
            this.Profile.TabIndex = 30;
            this.Profile.Text = "PROFILE";
            this.Profile.Visible = false;
            // 
            // BigProfilePicture
            // 
            this.BigProfilePicture.Location = new System.Drawing.Point(208, 72);
            this.BigProfilePicture.Name = "BigProfilePicture";
            this.BigProfilePicture.Size = new System.Drawing.Size(189, 171);
            this.BigProfilePicture.TabIndex = 31;
            this.BigProfilePicture.TabStop = false;
            this.BigProfilePicture.Visible = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(416, 144);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 32;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Visible = false;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(416, 184);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(122, 13);
            this.Info.TabIndex = 33;
            this.Info.Text = "The user has 0 followers";
            this.Info.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Followers";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Following";
            this.label5.Visible = false;
            // 
            // Spotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1301, 900);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.BigProfilePicture);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.PlayPause);
            this.Controls.Add(this.AddFriend);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.FriendList);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.LikedAlbums);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SongView);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.SongName);
            this.Controls.Add(this.AlbumCover);
            this.Controls.Add(this.Remaining);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.SongTable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.Favorites);
            this.Controls.Add(this.Composer);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.player);
            this.Name = "Spotify";
            this.Text = "Spotify";
            ((System.ComponentModel.ISupportInitialize)(this.SongTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView SongTable;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TrackBar Volume;
        private System.Windows.Forms.Button PlayPause;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.TrackBar TrackBar;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Remaining;
        private System.Windows.Forms.PictureBox AlbumCover;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ListView SongView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.RichTextBox Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox Composer;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button Favorites;
        private System.Windows.Forms.ListView LikedAlbums;
        private System.Windows.Forms.ColumnHeader Album;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListView FriendList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AddFriend;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lungime;
        private System.Windows.Forms.Label Profile;
        private System.Windows.Forms.PictureBox BigProfilePicture;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}