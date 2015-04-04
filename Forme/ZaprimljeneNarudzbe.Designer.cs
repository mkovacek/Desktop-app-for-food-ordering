namespace eNarudžba.Forme
{
    partial class ZaprimljeneNarudzbe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaprimljeneNarudzbe));
            this.dgvZaprimljeneNarudzbe = new System.Windows.Forms.DataGridView();
            this.dgvZaprimljeneNarudzbeDetalji = new System.Windows.Forms.DataGridView();
            this.btnPromijenaStatusa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneNarudzbeDetalji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaprimljeneNarudzbe
            // 
            this.dgvZaprimljeneNarudzbe.AllowUserToAddRows = false;
            this.dgvZaprimljeneNarudzbe.AllowUserToDeleteRows = false;
            this.dgvZaprimljeneNarudzbe.AllowUserToResizeColumns = false;
            this.dgvZaprimljeneNarudzbe.AllowUserToResizeRows = false;
            this.dgvZaprimljeneNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvZaprimljeneNarudzbe.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvZaprimljeneNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaprimljeneNarudzbe.GridColor = System.Drawing.SystemColors.Window;
            this.dgvZaprimljeneNarudzbe.Location = new System.Drawing.Point(12, 57);
            this.dgvZaprimljeneNarudzbe.Name = "dgvZaprimljeneNarudzbe";
            this.dgvZaprimljeneNarudzbe.ReadOnly = true;
            this.dgvZaprimljeneNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaprimljeneNarudzbe.ShowCellToolTips = false;
            this.dgvZaprimljeneNarudzbe.Size = new System.Drawing.Size(582, 160);
            this.dgvZaprimljeneNarudzbe.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgvZaprimljeneNarudzbe, "Prikaz zaprimljenih narudžbi.\r\nPrikaz se ažurira svaku minutu ako je pristigla no" +
        "va narudžba.\r\nOdabirom narudžbe prikazuju se detalji narudžbe.\r\n");
            this.dgvZaprimljeneNarudzbe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZaprimljeneNarudzbe_CellClick);
            // 
            // dgvZaprimljeneNarudzbeDetalji
            // 
            this.dgvZaprimljeneNarudzbeDetalji.AllowUserToAddRows = false;
            this.dgvZaprimljeneNarudzbeDetalji.AllowUserToDeleteRows = false;
            this.dgvZaprimljeneNarudzbeDetalji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvZaprimljeneNarudzbeDetalji.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvZaprimljeneNarudzbeDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaprimljeneNarudzbeDetalji.GridColor = System.Drawing.SystemColors.Window;
            this.dgvZaprimljeneNarudzbeDetalji.Location = new System.Drawing.Point(12, 247);
            this.dgvZaprimljeneNarudzbeDetalji.Name = "dgvZaprimljeneNarudzbeDetalji";
            this.dgvZaprimljeneNarudzbeDetalji.ReadOnly = true;
            this.dgvZaprimljeneNarudzbeDetalji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaprimljeneNarudzbeDetalji.ShowCellToolTips = false;
            this.dgvZaprimljeneNarudzbeDetalji.Size = new System.Drawing.Size(582, 172);
            this.dgvZaprimljeneNarudzbeDetalji.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dgvZaprimljeneNarudzbeDetalji, "Prikaz detalja odabrane narudžbe.\r\n");
            // 
            // btnPromijenaStatusa
            // 
            this.btnPromijenaStatusa.BackColor = System.Drawing.Color.White;
            this.btnPromijenaStatusa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPromijenaStatusa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromijenaStatusa.Location = new System.Drawing.Point(484, 425);
            this.btnPromijenaStatusa.Name = "btnPromijenaStatusa";
            this.btnPromijenaStatusa.Size = new System.Drawing.Size(110, 24);
            this.btnPromijenaStatusa.TabIndex = 2;
            this.btnPromijenaStatusa.Text = "Promijeni status";
            this.toolTip1.SetToolTip(this.btnPromijenaStatusa, "Gumb za promjenu statusa narudžbe.\r\nPotrebno je odabrati narudžbu.");
            this.btnPromijenaStatusa.UseVisualStyleBackColor = false;
            this.btnPromijenaStatusa.Click += new System.EventHandler(this.btnPromijenaStatusa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Povratak na prethodnu formu");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zaprimljene narudžbe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detalji narudžbe";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(536, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Minimiziranje forme");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(568, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Zatvaranje forme");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ZaprimljeneNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(606, 460);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPromijenaStatusa);
            this.Controls.Add(this.dgvZaprimljeneNarudzbeDetalji);
            this.Controls.Add(this.dgvZaprimljeneNarudzbe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ZaprimljeneNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eNarudžba";
            this.Load += new System.EventHandler(this.ZaprimljeneNarudzbe_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ZaprimljeneNarudzbe_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ZaprimljeneNarudzbe_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneNarudzbeDetalji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaprimljeneNarudzbe;
        private System.Windows.Forms.DataGridView dgvZaprimljeneNarudzbeDetalji;
        private System.Windows.Forms.Button btnPromijenaStatusa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}