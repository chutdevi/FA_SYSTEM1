namespace FA_SYSTEM1
{
    partial class FORM_CONF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_CONF));
            this.PNL01 = new System.Windows.Forms.Panel();
            this.BNTSAVE = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LINE01 = new ButtonZ.LinesZ();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.CMB03 = new System.Windows.Forms.ComboBox();
            this.CMB02 = new System.Windows.Forms.ComboBox();
            this.BNTEDIT2 = new System.Windows.Forms.Button();
            this.LAB4 = new System.Windows.Forms.Label();
            this.LAB3 = new System.Windows.Forms.Label();
            this.LAB02 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CMB01 = new System.Windows.Forms.ComboBox();
            this.BNTEDIT1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PNLHEADER = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BNTCLOSE = new System.Windows.Forms.Button();
            this.LABTITAL = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.PNL01.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PNLHEADER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL01
            // 
            this.PNL01.BackColor = System.Drawing.Color.CadetBlue;
            this.PNL01.Controls.Add(this.BNTSAVE);
            this.PNL01.Controls.Add(this.panel3);
            this.PNL01.Controls.Add(this.panel2);
            this.PNL01.Controls.Add(this.PNLHEADER);
            this.PNL01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL01.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNL01.Location = new System.Drawing.Point(0, 0);
            this.PNL01.Name = "PNL01";
            this.PNL01.Size = new System.Drawing.Size(484, 661);
            this.PNL01.TabIndex = 1;
            this.PNL01.Tag = "CS";
            // 
            // BNTSAVE
            // 
            this.BNTSAVE.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BNTSAVE.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.BNTSAVE.FlatAppearance.BorderSize = 0;
            this.BNTSAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.BNTSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.BNTSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNTSAVE.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BNTSAVE.Image = ((System.Drawing.Image)(resources.GetObject("BNTSAVE.Image")));
            this.BNTSAVE.Location = new System.Drawing.Point(81, 547);
            this.BNTSAVE.Name = "BNTSAVE";
            this.BNTSAVE.Size = new System.Drawing.Size(331, 82);
            this.BNTSAVE.TabIndex = 6;
            this.BNTSAVE.Tag = "SV";
            this.BNTSAVE.Text = "Save configuration";
            this.BNTSAVE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BNTSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BNTSAVE.UseVisualStyleBackColor = false;
            this.BNTSAVE.Click += new System.EventHandler(this.BUTTONCONFCLICK);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LINE01);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.CMB03);
            this.panel3.Controls.Add(this.CMB02);
            this.panel3.Controls.Add(this.BNTEDIT2);
            this.panel3.Controls.Add(this.LAB4);
            this.panel3.Controls.Add(this.LAB3);
            this.panel3.Controls.Add(this.LAB02);
            this.panel3.Location = new System.Drawing.Point(13, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 205);
            this.panel3.TabIndex = 5;
            // 
            // LINE01
            // 
            this.LINE01.axitX1 = 3;
            this.LINE01.axitX2 = 3;
            this.LINE01.axitY1 = 0;
            this.LINE01.axitY2 = 406;
            this.LINE01.bordercolor = System.Drawing.Color.AliceBlue;
            this.LINE01.borderlength = 3;
            this.LINE01.Location = new System.Drawing.Point(48, 42);
            this.LINE01.Name = "LINE01";
            this.LINE01.Size = new System.Drawing.Size(406, 13);
            this.LINE01.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // CMB03
            // 
            this.CMB03.AutoCompleteCustomSource.AddRange(new string[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.CMB03.BackColor = System.Drawing.Color.CadetBlue;
            this.CMB03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB03.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB03.ForeColor = System.Drawing.SystemColors.Window;
            this.CMB03.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.CMB03.Location = new System.Drawing.Point(93, 131);
            this.CMB03.Name = "CMB03";
            this.CMB03.Size = new System.Drawing.Size(306, 31);
            this.CMB03.TabIndex = 4;
            this.CMB03.Visible = false;
            // 
            // CMB02
            // 
            this.CMB02.AutoCompleteCustomSource.AddRange(new string[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.CMB02.BackColor = System.Drawing.Color.CadetBlue;
            this.CMB02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB02.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB02.ForeColor = System.Drawing.SystemColors.Window;
            this.CMB02.FormattingEnabled = true;
            this.CMB02.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.CMB02.Location = new System.Drawing.Point(93, 75);
            this.CMB02.Name = "CMB02";
            this.CMB02.Size = new System.Drawing.Size(306, 31);
            this.CMB02.TabIndex = 3;
            // 
            // BNTEDIT2
            // 
            this.BNTEDIT2.BackColor = System.Drawing.Color.CadetBlue;
            this.BNTEDIT2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BNTEDIT2.BackgroundImage")));
            this.BNTEDIT2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BNTEDIT2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BNTEDIT2.FlatAppearance.BorderSize = 0;
            this.BNTEDIT2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.BNTEDIT2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BNTEDIT2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNTEDIT2.Location = new System.Drawing.Point(404, 71);
            this.BNTEDIT2.Name = "BNTEDIT2";
            this.BNTEDIT2.Size = new System.Drawing.Size(49, 38);
            this.BNTEDIT2.TabIndex = 0;
            this.BNTEDIT2.Tag = "ED";
            this.BNTEDIT2.UseVisualStyleBackColor = false;
            this.BNTEDIT2.Click += new System.EventHandler(this.BUTTONCONFCLICK);
            // 
            // LAB4
            // 
            this.LAB4.AutoSize = true;
            this.LAB4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAB4.Location = new System.Drawing.Point(4, 137);
            this.LAB4.Name = "LAB4";
            this.LAB4.Size = new System.Drawing.Size(75, 19);
            this.LAB4.TabIndex = 4;
            this.LAB4.Text = "PAGE LAYOUT";
            this.LAB4.Visible = false;
            // 
            // LAB3
            // 
            this.LAB3.AutoSize = true;
            this.LAB3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAB3.Location = new System.Drawing.Point(4, 81);
            this.LAB3.Name = "LAB3";
            this.LAB3.Size = new System.Drawing.Size(85, 19);
            this.LAB3.TabIndex = 4;
            this.LAB3.Text = "PRINTER NAME";
            // 
            // LAB02
            // 
            this.LAB02.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB02.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAB02.Location = new System.Drawing.Point(46, 11);
            this.LAB02.Name = "LAB02";
            this.LAB02.Size = new System.Drawing.Size(124, 29);
            this.LAB02.TabIndex = 4;
            this.LAB02.Text = "TAG PRINTER";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.CMB01);
            this.panel2.Controls.Add(this.BNTEDIT1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 64);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // CMB01
            // 
            this.CMB01.AutoCompleteCustomSource.AddRange(new string[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.CMB01.BackColor = System.Drawing.Color.CadetBlue;
            this.CMB01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB01.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB01.ForeColor = System.Drawing.SystemColors.Window;
            this.CMB01.FormattingEnabled = true;
            this.CMB01.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.CMB01.Location = new System.Drawing.Point(183, 14);
            this.CMB01.Name = "CMB01";
            this.CMB01.Size = new System.Drawing.Size(176, 37);
            this.CMB01.TabIndex = 1;
            // 
            // BNTEDIT1
            // 
            this.BNTEDIT1.BackColor = System.Drawing.Color.CadetBlue;
            this.BNTEDIT1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BNTEDIT1.BackgroundImage")));
            this.BNTEDIT1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BNTEDIT1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BNTEDIT1.FlatAppearance.BorderSize = 0;
            this.BNTEDIT1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.BNTEDIT1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.BNTEDIT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNTEDIT1.Location = new System.Drawing.Point(393, 11);
            this.BNTEDIT1.Name = "BNTEDIT1";
            this.BNTEDIT1.Size = new System.Drawing.Size(49, 38);
            this.BNTEDIT1.TabIndex = 0;
            this.BNTEDIT1.Tag = "ED";
            this.BNTEDIT1.UseVisualStyleBackColor = false;
            this.BNTEDIT1.Click += new System.EventHandler(this.BUTTONCONFCLICK);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(47, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "PORT SCANNER";
            // 
            // PNLHEADER
            // 
            this.PNLHEADER.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PNLHEADER.Controls.Add(this.pictureBox1);
            this.PNLHEADER.Controls.Add(this.BNTCLOSE);
            this.PNLHEADER.Controls.Add(this.LABTITAL);
            this.PNLHEADER.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNLHEADER.Location = new System.Drawing.Point(0, 0);
            this.PNLHEADER.Name = "PNLHEADER";
            this.PNLHEADER.Size = new System.Drawing.Size(484, 47);
            this.PNLHEADER.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BNTCLOSE
            // 
            this.BNTCLOSE.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BNTCLOSE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BNTCLOSE.BackgroundImage")));
            this.BNTCLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BNTCLOSE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BNTCLOSE.FlatAppearance.BorderSize = 0;
            this.BNTCLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.BNTCLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.BNTCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNTCLOSE.Location = new System.Drawing.Point(441, 6);
            this.BNTCLOSE.Name = "BNTCLOSE";
            this.BNTCLOSE.Size = new System.Drawing.Size(31, 34);
            this.BNTCLOSE.TabIndex = 0;
            this.BNTCLOSE.TabStop = false;
            this.BNTCLOSE.Tag = "CS";
            this.BNTCLOSE.UseVisualStyleBackColor = false;
            this.BNTCLOSE.Click += new System.EventHandler(this.BUTTONCONFCLICK);
            // 
            // LABTITAL
            // 
            this.LABTITAL.AutoSize = true;
            this.LABTITAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LABTITAL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LABTITAL.Location = new System.Drawing.Point(53, 7);
            this.LABTITAL.Name = "LABTITAL";
            this.LABTITAL.Size = new System.Drawing.Size(214, 33);
            this.LABTITAL.TabIndex = 0;
            this.LABTITAL.Text = "Configuration program";
            // 
            // FORM_CONF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.PNL01);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FORM_CONF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_CONF";
            this.Load += new System.EventHandler(this.FORM_CONFLOAD);
            this.PNL01.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PNLHEADER.ResumeLayout(false);
            this.PNLHEADER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BNTEDIT1;
        private System.Windows.Forms.Panel PNL01;
        private System.Windows.Forms.Button BNTSAVE;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox CMB02;
        private System.Windows.Forms.Button BNTEDIT2;
        private System.Windows.Forms.Label LAB02;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox CMB01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PNLHEADER;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LABTITAL;
        private System.Windows.Forms.Button BNTCLOSE;
        private ButtonZ.LinesZ LINE01;
        private System.Windows.Forms.Label LAB3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox CMB03;
        private System.Windows.Forms.Label LAB4;
    }
}