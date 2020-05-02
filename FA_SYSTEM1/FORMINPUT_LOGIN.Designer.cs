//using Microsoft.VisualBasic.PowerPacks;

namespace FA_SYSTEM1
{
    partial class FORMINPUT_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORMINPUT_LOGIN));
            this.TXTB1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linesZ1 = new ButtonZ.LinesZ();
            this.linesZ2 = new ButtonZ.LinesZ();
            this.BNTBORDER1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTB1
            // 
            this.TXTB1.BackColor = System.Drawing.Color.SteelBlue;
            this.TXTB1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTB1.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB1.ForeColor = System.Drawing.SystemColors.Info;
            this.TXTB1.Location = new System.Drawing.Point(105, 385);
            this.TXTB1.Name = "TXTB1";
            this.TXTB1.Size = new System.Drawing.Size(232, 45);
            this.TXTB1.TabIndex = 1;
            this.TXTB1.TextChanged += new System.EventHandler(this.TXTB1_TEXTCHANGED);
            this.TXTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FMKEYPRESS);
            this.TXTB1.GotFocus += new System.EventHandler(this.TXTB1_TEXTGOTFOCUS);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 385);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.ErrorImage = global::FA_SYSTEM1.Properties.Resources.logo_tbkk;
            this.pictureBox1.Image = global::FA_SYSTEM1.Properties.Resources.logo_tbkk;
            this.pictureBox1.InitialImage = global::FA_SYSTEM1.Properties.Resources.logo_tbkk;
            this.pictureBox1.Location = new System.Drawing.Point(20, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // linesZ1
            // 
            this.linesZ1.axitX1 = 9;
            this.linesZ1.axitX2 = 9;
            this.linesZ1.axitY1 = 0;
            this.linesZ1.axitY2 = 248;
            this.linesZ1.bordercolor = System.Drawing.Color.Gainsboro;
            this.linesZ1.borderlength = 2;
            this.linesZ1.Location = new System.Drawing.Point(101, 427);
            this.linesZ1.Name = "linesZ1";
            this.linesZ1.Size = new System.Drawing.Size(248, 19);
            this.linesZ1.TabIndex = 4;
            // 
            // linesZ2
            // 
            this.linesZ2.axitX1 = 9;
            this.linesZ2.axitX2 = 9;
            this.linesZ2.axitY1 = 0;
            this.linesZ2.axitY2 = 313;
            this.linesZ2.bordercolor = System.Drawing.Color.Gainsboro;
            this.linesZ2.borderlength = 1;
            this.linesZ2.Location = new System.Drawing.Point(56, 227);
            this.linesZ2.Name = "linesZ2";
            this.linesZ2.Size = new System.Drawing.Size(313, 19);
            this.linesZ2.TabIndex = 4;
            // 
            // BNTBORDER1
            // 
            this.BNTBORDER1.BackColor = System.Drawing.Color.SteelBlue;
            this.BNTBORDER1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BNTBORDER1.Enabled = false;
            this.BNTBORDER1.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.BNTBORDER1.FlatAppearance.BorderSize = 3;
            this.BNTBORDER1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.BNTBORDER1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BNTBORDER1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNTBORDER1.Location = new System.Drawing.Point(0, 0);
            this.BNTBORDER1.Name = "BNTBORDER1";
            this.BNTBORDER1.Size = new System.Drawing.Size(400, 540);
            this.BNTBORDER1.TabIndex = 5;
            this.BNTBORDER1.TabStop = false;
            this.BNTBORDER1.UseVisualStyleBackColor = false;
            // 
            // FORMINPUT_LOGIN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(400, 540);
            this.Controls.Add(this.TXTB1);
            this.Controls.Add(this.linesZ2);
            this.Controls.Add(this.linesZ1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BNTBORDER1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FORMINPUT_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FORMINPUT_LOGIN";
            this.Load += new System.EventHandler(this.FORMINPUT_LOGIN_LOAD);
            this.Shown += new System.EventHandler(this.FORMINPUT_LOGINSHOW);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTB1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ButtonZ.LinesZ linesZ1;
        private ButtonZ.LinesZ linesZ2;
        private System.Windows.Forms.Button BNTBORDER1;
    }
}