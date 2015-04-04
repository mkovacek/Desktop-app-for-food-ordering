namespace eNarudžba.Forme
{
    partial class PovijestNarudzbi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PovijestNarudzbi));
            this.btnPracenjeStanjaNarudzbe = new System.Windows.Forms.Button();
            this.dgwPovijestNarudzbi = new System.Windows.Forms.DataGridView();
            this.dgwPovijestNarudzbiDetalji = new System.Windows.Forms.DataGridView();
            this.btnKomentiranje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPovijestNarudzbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPovijestNarudzbiDetalji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPracenjeStanjaNarudzbe
            // 
            this.btnPracenjeStanjaNarudzbe.BackColor = System.Drawing.Color.White;
            this.btnPracenjeStanjaNarudzbe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPracenjeStanjaNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPracenjeStanjaNarudzbe.Location = new System.Drawing.Point(382, 232);
            this.btnPracenjeStanjaNarudzbe.Name = "btnPracenjeStanjaNarudzbe";
            this.btnPracenjeStanjaNarudzbe.Size = new System.Drawing.Size(132, 23);
            this.btnPracenjeStanjaNarudzbe.TabIndex = 1;
            this.btnPracenjeStanjaNarudzbe.Text = "Praćenje stanja narudžbe";
            this.toolTip1.SetToolTip(this.btnPracenjeStanjaNarudzbe, "Gumb za praćenje stanja narudžbe.\r\nPotrebno je odabrati određenu narudžbu,\r\nda bi" +
        " mogli pratiti njezino stanje.");
            this.btnPracenjeStanjaNarudzbe.UseVisualStyleBackColor = false;
            this.btnPracenjeStanjaNarudzbe.Click += new System.EventHandler(this.btnPracenjeStanjaNarudzbe_Click);
            // 
            // dgwPovijestNarudzbi
            // 
            this.dgwPovijestNarudzbi.AllowUserToAddRows = false;
            this.dgwPovijestNarudzbi.AllowUserToDeleteRows = false;
            this.dgwPovijestNarudzbi.AllowUserToResizeColumns = false;
            this.dgwPovijestNarudzbi.AllowUserToResizeRows = false;
            this.dgwPovijestNarudzbi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwPovijestNarudzbi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgwPovijestNarudzbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPovijestNarudzbi.GridColor = System.Drawing.SystemColors.Window;
            this.dgwPovijestNarudzbi.Location = new System.Drawing.Point(15, 59);
            this.dgwPovijestNarudzbi.Name = "dgwPovijestNarudzbi";
            this.dgwPovijestNarudzbi.ReadOnly = true;
            this.dgwPovijestNarudzbi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPovijestNarudzbi.ShowCellToolTips = false;
            this.dgwPovijestNarudzbi.Size = new System.Drawing.Size(499, 167);
            this.dgwPovijestNarudzbi.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dgwPovijestNarudzbi, "Prikaz Vaših narudžbi");
            this.dgwPovijestNarudzbi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPovijestNarudzbi_CellClick);
            // 
            // dgwPovijestNarudzbiDetalji
            // 
            this.dgwPovijestNarudzbiDetalji.AllowUserToAddRows = false;
            this.dgwPovijestNarudzbiDetalji.AllowUserToDeleteRows = false;
            this.dgwPovijestNarudzbiDetalji.AllowUserToResizeColumns = false;
            this.dgwPovijestNarudzbiDetalji.AllowUserToResizeRows = false;
            this.dgwPovijestNarudzbiDetalji.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwPovijestNarudzbiDetalji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwPovijestNarudzbiDetalji.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgwPovijestNarudzbiDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPovijestNarudzbiDetalji.GridColor = System.Drawing.SystemColors.Window;
            this.dgwPovijestNarudzbiDetalji.Location = new System.Drawing.Point(15, 272);
            this.dgwPovijestNarudzbiDetalji.Name = "dgwPovijestNarudzbiDetalji";
            this.dgwPovijestNarudzbiDetalji.ReadOnly = true;
            this.dgwPovijestNarudzbiDetalji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPovijestNarudzbiDetalji.ShowCellToolTips = false;
            this.dgwPovijestNarudzbiDetalji.Size = new System.Drawing.Size(499, 169);
            this.dgwPovijestNarudzbiDetalji.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dgwPovijestNarudzbiDetalji, "Prikaz detalja Vaše narudžbe.\r\nZa prikaz detalja potrebno je odabrati narudžbu.");
            this.dgwPovijestNarudzbiDetalji.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPovijestNarudzbiDetalji_CellClick);
            // 
            // btnKomentiranje
            // 
            this.btnKomentiranje.BackColor = System.Drawing.Color.White;
            this.btnKomentiranje.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKomentiranje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKomentiranje.Location = new System.Drawing.Point(382, 448);
            this.btnKomentiranje.Name = "btnKomentiranje";
            this.btnKomentiranje.Size = new System.Drawing.Size(132, 23);
            this.btnKomentiranje.TabIndex = 2;
            this.btnKomentiranje.Text = "Komentiranje hrane";
            this.toolTip1.SetToolTip(this.btnKomentiranje, "Gumb za komentiranje određnog jela.\r\nPotrebno je odabrati naručeno jelo kako bi s" +
        "te\r\nmogli komentrirati.");
            this.btnKomentiranje.UseVisualStyleBackColor = false;
            this.btnKomentiranje.Click += new System.EventHandler(this.btnKomentiranje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Detalji narudžbe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Povijest narudžbi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Povratak na prethodnu formu");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(460, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Minimiziranje forme");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(488, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Zatvaranje forme");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PovijestNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(531, 479);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwPovijestNarudzbiDetalji);
            this.Controls.Add(this.dgwPovijestNarudzbi);
            this.Controls.Add(this.btnKomentiranje);
            this.Controls.Add(this.btnPracenjeStanjaNarudzbe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PovijestNarudzbi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eNarudžba";
            this.Load += new System.EventHandler(this.PovijestNarudzbi_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PovijestNarudzbi_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PovijestNarudzbi_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPovijestNarudzbi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPovijestNarudzbiDetalji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPracenjeStanjaNarudzbe;
        private System.Windows.Forms.DataGridView dgwPovijestNarudzbi;
        private System.Windows.Forms.DataGridView dgwPovijestNarudzbiDetalji;
        private System.Windows.Forms.Button btnKomentiranje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;



    }
}