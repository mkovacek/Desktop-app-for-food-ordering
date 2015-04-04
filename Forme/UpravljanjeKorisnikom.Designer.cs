namespace eNarudžba.Forme
{
    partial class UpravljanjeKorisnikom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpravljanjeKorisnikom));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPasivni = new System.Windows.Forms.DataGridView();
            this.dgvAktivni = new System.Windows.Forms.DataGridView();
            this.btnAktiviraj = new System.Windows.Forms.Button();
            this.btnBlokiraj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasivni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasivni naručitelji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aktivni naručitelji";
            // 
            // dgvPasivni
            // 
            this.dgvPasivni.AllowUserToAddRows = false;
            this.dgvPasivni.AllowUserToDeleteRows = false;
            this.dgvPasivni.AllowUserToResizeColumns = false;
            this.dgvPasivni.AllowUserToResizeRows = false;
            this.dgvPasivni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPasivni.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPasivni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasivni.GridColor = System.Drawing.SystemColors.Window;
            this.dgvPasivni.Location = new System.Drawing.Point(39, 60);
            this.dgvPasivni.MultiSelect = false;
            this.dgvPasivni.Name = "dgvPasivni";
            this.dgvPasivni.ReadOnly = true;
            this.dgvPasivni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasivni.ShowCellToolTips = false;
            this.dgvPasivni.Size = new System.Drawing.Size(337, 150);
            this.dgvPasivni.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dgvPasivni, "Prikaz korisnka koji trenutno imaju zabranjen pristup aplikaciji.");
            this.dgvPasivni.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPasivni_RowHeaderMouseClick);
            // 
            // dgvAktivni
            // 
            this.dgvAktivni.AllowUserToResizeColumns = false;
            this.dgvAktivni.AllowUserToResizeRows = false;
            this.dgvAktivni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAktivni.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAktivni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktivni.GridColor = System.Drawing.SystemColors.Window;
            this.dgvAktivni.Location = new System.Drawing.Point(39, 262);
            this.dgvAktivni.MultiSelect = false;
            this.dgvAktivni.Name = "dgvAktivni";
            this.dgvAktivni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAktivni.ShowCellToolTips = false;
            this.dgvAktivni.Size = new System.Drawing.Size(337, 150);
            this.dgvAktivni.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dgvAktivni, "Prikaz korisnka koji trenutno imaju pristup aplikaciji.");
            this.dgvAktivni.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAktivni_RowHeaderMouseClick);
            // 
            // btnAktiviraj
            // 
            this.btnAktiviraj.BackColor = System.Drawing.Color.White;
            this.btnAktiviraj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAktiviraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktiviraj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAktiviraj.Location = new System.Drawing.Point(301, 216);
            this.btnAktiviraj.Name = "btnAktiviraj";
            this.btnAktiviraj.Size = new System.Drawing.Size(75, 23);
            this.btnAktiviraj.TabIndex = 4;
            this.btnAktiviraj.Text = "Aktiviraj";
            this.toolTip1.SetToolTip(this.btnAktiviraj, "Gumb za omogućavanje pristupa trenutno blokiranom korisniku.\r\nPotrebno je odabrat" +
        "i pasivnog korisnika.");
            this.btnAktiviraj.UseVisualStyleBackColor = false;
            this.btnAktiviraj.Click += new System.EventHandler(this.btnAktiviraj_Click);
            // 
            // btnBlokiraj
            // 
            this.btnBlokiraj.BackColor = System.Drawing.Color.White;
            this.btnBlokiraj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBlokiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlokiraj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBlokiraj.Location = new System.Drawing.Point(301, 418);
            this.btnBlokiraj.Name = "btnBlokiraj";
            this.btnBlokiraj.Size = new System.Drawing.Size(75, 23);
            this.btnBlokiraj.TabIndex = 5;
            this.btnBlokiraj.Text = "Blokiraj";
            this.toolTip1.SetToolTip(this.btnBlokiraj, "Gumb za onemogućavanje pristupa trenutno aktivnom korisniku.\r\nPotrebno je odabrat" +
        "i aktivnog korisnika.\r\n");
            this.btnBlokiraj.UseVisualStyleBackColor = false;
            this.btnBlokiraj.Click += new System.EventHandler(this.btnBlokiraj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Povratak na prethodnu formu");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(340, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Minimiziranje forme");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(370, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Zatvaranje forme");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // UpravljanjeKorisnikom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(408, 455);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBlokiraj);
            this.Controls.Add(this.btnAktiviraj);
            this.Controls.Add(this.dgvAktivni);
            this.Controls.Add(this.dgvPasivni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpravljanjeKorisnikom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eNarudžba";
            this.Load += new System.EventHandler(this.UpravljanjeKorisnikom_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpravljanjeKorisnikom_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpravljanjeKorisnikom_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasivni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPasivni;
        private System.Windows.Forms.DataGridView dgvAktivni;
        private System.Windows.Forms.Button btnAktiviraj;
        private System.Windows.Forms.Button btnBlokiraj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}