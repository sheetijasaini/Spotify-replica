namespace proiect
{
    partial class AddForm
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
            this.Nume = new System.Windows.Forms.TextBox();
            this.Band = new System.Windows.Forms.MaskedTextBox();
            this.Title = new System.Windows.Forms.MaskedTextBox();
            this.Genre = new System.Windows.Forms.MaskedTextBox();
            this.Duration = new System.Windows.Forms.MaskedTextBox();
            this.Launch = new System.Windows.Forms.MaskedTextBox();
            this.Length = new System.Windows.Forms.MaskedTextBox();
            this.LNume = new System.Windows.Forms.Label();
            this.LTrupa = new System.Windows.Forms.Label();
            this.LLungime = new System.Windows.Forms.Label();
            this.LTitlu = new System.Windows.Forms.Label();
            this.LLansare = new System.Windows.Forms.Label();
            this.LDurata = new System.Windows.Forms.Label();
            this.LGen = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(53, 87);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(144, 20);
            this.Nume.TabIndex = 0;
            // 
            // Band
            // 
            this.Band.Location = new System.Drawing.Point(53, 113);
            this.Band.Name = "Band";
            this.Band.Size = new System.Drawing.Size(144, 20);
            this.Band.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(53, 35);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(144, 20);
            this.Title.TabIndex = 2;
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(53, 191);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(144, 20);
            this.Genre.TabIndex = 3;
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(53, 165);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(144, 20);
            this.Duration.TabIndex = 4;
            // 
            // Launch
            // 
            this.Launch.Location = new System.Drawing.Point(53, 139);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(144, 20);
            this.Launch.TabIndex = 5;
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(53, 61);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(144, 20);
            this.Length.TabIndex = 6;
            // 
            // LNume
            // 
            this.LNume.AutoSize = true;
            this.LNume.Location = new System.Drawing.Point(4, 90);
            this.LNume.Name = "LNume";
            this.LNume.Size = new System.Drawing.Size(35, 13);
            this.LNume.TabIndex = 7;
            this.LNume.Text = "Nume";
            // 
            // LTrupa
            // 
            this.LTrupa.AutoSize = true;
            this.LTrupa.Location = new System.Drawing.Point(4, 116);
            this.LTrupa.Name = "LTrupa";
            this.LTrupa.Size = new System.Drawing.Size(35, 13);
            this.LTrupa.TabIndex = 8;
            this.LTrupa.Text = "Trupa";
            // 
            // LLungime
            // 
            this.LLungime.AutoSize = true;
            this.LLungime.Location = new System.Drawing.Point(4, 64);
            this.LLungime.Name = "LLungime";
            this.LLungime.Size = new System.Drawing.Size(47, 13);
            this.LLungime.TabIndex = 9;
            this.LLungime.Text = "Lungime";
            // 
            // LTitlu
            // 
            this.LTitlu.AutoSize = true;
            this.LTitlu.Location = new System.Drawing.Point(4, 38);
            this.LTitlu.Name = "LTitlu";
            this.LTitlu.Size = new System.Drawing.Size(27, 13);
            this.LTitlu.TabIndex = 10;
            this.LTitlu.Text = "Titlu";
            // 
            // LLansare
            // 
            this.LLansare.AutoSize = true;
            this.LLansare.Location = new System.Drawing.Point(4, 142);
            this.LLansare.Name = "LLansare";
            this.LLansare.Size = new System.Drawing.Size(45, 13);
            this.LLansare.TabIndex = 11;
            this.LLansare.Text = "Lansare";
            // 
            // LDurata
            // 
            this.LDurata.AutoSize = true;
            this.LDurata.Location = new System.Drawing.Point(4, 168);
            this.LDurata.Name = "LDurata";
            this.LDurata.Size = new System.Drawing.Size(39, 13);
            this.LDurata.TabIndex = 12;
            this.LDurata.Text = "Durata";
            // 
            // LGen
            // 
            this.LGen.AutoSize = true;
            this.LGen.Location = new System.Drawing.Point(4, 194);
            this.LGen.Name = "LGen";
            this.LGen.Size = new System.Drawing.Size(27, 13);
            this.LGen.TabIndex = 13;
            this.LGen.Text = "Gen";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(80, 6);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 15;
            this.Add.Text = "Adauga";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Imagine";
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(53, 215);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(144, 23);
            this.Load.TabIndex = 17;
            this.Load.Text = "Incarca";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 245);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.LGen);
            this.Controls.Add(this.LDurata);
            this.Controls.Add(this.LLansare);
            this.Controls.Add(this.LTitlu);
            this.Controls.Add(this.LLungime);
            this.Controls.Add(this.LTrupa);
            this.Controls.Add(this.LNume);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Band);
            this.Controls.Add(this.Nume);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.MaskedTextBox Band;
        private System.Windows.Forms.MaskedTextBox Title;
        private System.Windows.Forms.MaskedTextBox Genre;
        private System.Windows.Forms.MaskedTextBox Duration;
        private System.Windows.Forms.MaskedTextBox Launch;
        private System.Windows.Forms.MaskedTextBox Length;
        private System.Windows.Forms.Label LNume;
        private System.Windows.Forms.Label LTrupa;
        private System.Windows.Forms.Label LLungime;
        private System.Windows.Forms.Label LTitlu;
        private System.Windows.Forms.Label LLansare;
        private System.Windows.Forms.Label LDurata;
        private System.Windows.Forms.Label LGen;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Load;
    }
}