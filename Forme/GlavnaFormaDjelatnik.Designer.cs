namespace eNarudžba.Forme
{
    partial class GlavnaFormaDjelatnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaFormaDjelatnik));
            this.btnPregledZaprimljenihNarudzbi = new System.Windows.Forms.Button();
            this.btnUpravljanjeKorisnikom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPregledZaprimljenihNarudzbi
            // 
            this.btnPregledZaprimljenihNarudzbi.BackColor = System.Drawing.Color.White;
            this.btnPregledZaprimljenihNarudzbi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPregledZaprimljenihNarudzbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledZaprimljenihNarudzbi.Location = new System.Drawing.Point(53, 54);
            this.btnPregledZaprimljenihNarudzbi.Name = "btnPregledZaprimljenihNarudzbi";
            this.btnPregledZaprimljenihNarudzbi.Size = new System.Drawing.Size(283, 62);
            this.btnPregledZaprimljenihNarudzbi.TabIndex = 0;
            this.btnPregledZaprimljenihNarudzbi.Text = "Pregled zaprimljenih narudžbi";
            this.toolTip1.SetToolTip(this.btnPregledZaprimljenihNarudzbi, "Gumb za pregled zaprimljenih narudžbi");
            this.btnPregledZaprimljenihNarudzbi.UseVisualStyleBackColor = false;
            this.btnPregledZaprimljenihNarudzbi.Click += new System.EventHandler(this.btnPregledZaprimljenihNarudzbi_Click);
            // 
            // btnUpravljanjeKorisnikom
            // 
            this.btnUpravljanjeKorisnikom.BackColor = System.Drawing.Color.White;
            this.btnUpravljanjeKorisnikom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpravljanjeKorisnikom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpravljanjeKorisnikom.Location = new System.Drawing.Point(53, 142);
            this.btnUpravljanjeKorisnikom.Name = "btnUpravljanjeKorisnikom";
            this.btnUpravljanjeKorisnikom.Size = new System.Drawing.Size(283, 62);
            this.btnUpravljanjeKorisnikom.TabIndex = 1;
            this.btnUpravljanjeKorisnikom.Text = "Upravljanje naručiteljima";
            this.toolTip1.SetToolTip(this.btnUpravljanjeKorisnikom, "Gumb za upravljanje korisnikom");
            this.btnUpravljanjeKorisnikom.UseVisualStyleBackColor = false;
            this.btnUpravljanjeKorisnikom.Click += new System.EventHandler(this.btnUpravljanjeKorisnikom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Minimiziranje forme");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(358, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Zatvaranje forme");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // GlavnaFormaDjelatnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(391, 269);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpravljanjeKorisnikom);
            this.Controls.Add(this.btnPregledZaprimljenihNarudzbi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "GlavnaFormaDjelatnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eNarudžba";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GlavnaFormaDjelatnik_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GlavnaFormaDjelatnik_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPregledZaprimljenihNarudzbi;
        private System.Windows.Forms.Button btnUpravljanjeKorisnikom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}