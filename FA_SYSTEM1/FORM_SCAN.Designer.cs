using System;

namespace FA_SYSTEM1
{
    partial class FORM_SCAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SCAN));
            this.LABTITAL = new System.Windows.Forms.Label();
            this.TXTSC01 = new System.Windows.Forms.TextBox();
            this.PICBSCAN = new System.Windows.Forms.PictureBox();
            this.BNTBORDERTITAL = new System.Windows.Forms.Button();
            this.BNTBORDERINPUT = new System.Windows.Forms.Button();
            this.PNL01 = new System.Windows.Forms.Panel();
            this.PNL02 = new System.Windows.Forms.Panel();
            this.BNTSENDERROR = new System.Windows.Forms.Button();
            this.LAB3 = new System.Windows.Forms.Label();
            this.LAB2 = new System.Windows.Forms.Label();
            this.PICBWARNING = new System.Windows.Forms.PictureBox();
            this.LAB1 = new System.Windows.Forms.Label();
            this.LAB0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PICBSCAN)).BeginInit();
            this.PNL01.SuspendLayout();
            this.PNL02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBWARNING)).BeginInit();
            this.SuspendLayout();
            // 
            // LABTITAL
            // 
            this.LABTITAL.AutoSize = true;
            this.LABTITAL.Font = new System.Drawing.Font("Microsoft YaHei UI", 38.25F, System.Drawing.FontStyle.Bold);
            this.LABTITAL.ForeColor = System.Drawing.Color.AliceBlue;
            this.LABTITAL.Location = new System.Drawing.Point(25, 85);
            this.LABTITAL.Name = "LABTITAL";
            this.LABTITAL.Size = new System.Drawing.Size(428, 68);
            this.LABTITAL.TabIndex = 0;
            this.LABTITAL.Text = "SCAN QR CODE";
            // 
            // TXTSC01
            // 
            this.TXTSC01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.TXTSC01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTSC01.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 51.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSC01.ForeColor = System.Drawing.Color.White;
            this.TXTSC01.Location = new System.Drawing.Point(8, 4);
            this.TXTSC01.Name = "TXTSC01";
            this.TXTSC01.Size = new System.Drawing.Size(384, 83);
            this.TXTSC01.TabIndex = 0;
            this.TXTSC01.Text = "8888888888";
            this.TXTSC01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTSC01.TextChanged += new System.EventHandler(this.TXTCHANGED);
            this.TXTSC01.GotFocus += new System.EventHandler(this.TXTB1_TEXTGOTFOCUS);
            // 
            // PICBSCAN
            // 
            this.PICBSCAN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PICBSCAN.BackgroundImage")));
            this.PICBSCAN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PICBSCAN.Location = new System.Drawing.Point(0, 39);
            this.PICBSCAN.Name = "PICBSCAN";
            this.PICBSCAN.Size = new System.Drawing.Size(325, 289);
            this.PICBSCAN.TabIndex = 2;
            this.PICBSCAN.TabStop = false;
            // 
            // BNTBORDERTITAL
            // 
            this.BNTBORDERTITAL.Enabled = false;
            this.BNTBORDERTITAL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BNTBORDERTITAL.FlatAppearance.BorderSize = 3;
            this.BNTBORDERTITAL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.BNTBORDERTITAL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.BNTBORDERTITAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNTBORDERTITAL.Location = new System.Drawing.Point(18, 78);
            this.BNTBORDERTITAL.Name = "BNTBORDERTITAL";
            this.BNTBORDERTITAL.Size = new System.Drawing.Size(443, 80);
            this.BNTBORDERTITAL.TabIndex = 3;
            this.BNTBORDERTITAL.TabStop = false;
            this.BNTBORDERTITAL.UseVisualStyleBackColor = true;
            // 
            // BNTBORDERINPUT
            // 
            this.BNTBORDERINPUT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BNTBORDERINPUT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BNTBORDERINPUT.FlatAppearance.BorderSize = 2;
            this.BNTBORDERINPUT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.BNTBORDERINPUT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.BNTBORDERINPUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNTBORDERINPUT.Location = new System.Drawing.Point(0, 0);
            this.BNTBORDERINPUT.Name = "BNTBORDERINPUT";
            this.BNTBORDERINPUT.Size = new System.Drawing.Size(400, 93);
            this.BNTBORDERINPUT.TabIndex = 4;
            this.BNTBORDERINPUT.TabStop = false;
            this.BNTBORDERINPUT.UseVisualStyleBackColor = true;
            // 
            // PNL01
            // 
            this.PNL01.Controls.Add(this.TXTSC01);
            this.PNL01.Controls.Add(this.BNTBORDERINPUT);
            this.PNL01.Location = new System.Drawing.Point(37, 204);
            this.PNL01.Name = "PNL01";
            this.PNL01.Size = new System.Drawing.Size(400, 93);
            this.PNL01.TabIndex = 5;
            // 
            // PNL02
            // 
            this.PNL02.BackColor = System.Drawing.Color.MediumTurquoise;
            this.PNL02.Controls.Add(this.BNTSENDERROR);
            this.PNL02.Controls.Add(this.LAB3);
            this.PNL02.Controls.Add(this.LAB2);
            this.PNL02.Controls.Add(this.PICBWARNING);
            this.PNL02.Controls.Add(this.PICBSCAN);
            this.PNL02.Location = new System.Drawing.Point(474, -1);
            this.PNL02.Name = "PNL02";
            this.PNL02.Size = new System.Drawing.Size(328, 602);
            this.PNL02.TabIndex = 6;
            // 
            // BNTSENDERROR
            // 
            this.BNTSENDERROR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BNTSENDERROR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BNTSENDERROR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BNTSENDERROR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BNTSENDERROR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNTSENDERROR.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNTSENDERROR.Image = ((System.Drawing.Image)(resources.GetObject("BNTSENDERROR.Image")));
            this.BNTSENDERROR.Location = new System.Drawing.Point(63, 460);
            this.BNTSENDERROR.Name = "BNTSENDERROR";
            this.BNTSENDERROR.Size = new System.Drawing.Size(195, 53);
            this.BNTSENDERROR.TabIndex = 8;
            this.BNTSENDERROR.TabStop = false;
            this.BNTSENDERROR.Text = "Send error to system";
            this.BNTSENDERROR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BNTSENDERROR.UseVisualStyleBackColor = false;
            this.BNTSENDERROR.Click += new System.EventHandler(this.BNTSENDERRORCLICK);
            // 
            // LAB3
            // 
            this.LAB3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LAB3.Location = new System.Drawing.Point(8, 409);
            this.LAB3.Name = "LAB3";
            this.LAB3.Size = new System.Drawing.Size(306, 37);
            this.LAB3.TabIndex = 7;
            this.LAB3.Text = "Please press the button to notify the administrator";
            this.LAB3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB2
            // 
            this.LAB2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LAB2.Location = new System.Drawing.Point(59, 376);
            this.LAB2.Name = "LAB2";
            this.LAB2.Size = new System.Drawing.Size(239, 30);
            this.LAB2.TabIndex = 7;
            this.LAB2.Text = "Encountered a scanning problem ";
            this.LAB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PICBWARNING
            // 
            this.PICBWARNING.Image = ((System.Drawing.Image)(resources.GetObject("PICBWARNING.Image")));
            this.PICBWARNING.Location = new System.Drawing.Point(26, 376);
            this.PICBWARNING.Name = "PICBWARNING";
            this.PICBWARNING.Size = new System.Drawing.Size(27, 30);
            this.PICBWARNING.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICBWARNING.TabIndex = 3;
            this.PICBWARNING.TabStop = false;
            // 
            // LAB1
            // 
            this.LAB1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAB1.Location = new System.Drawing.Point(25, 517);
            this.LAB1.Name = "LAB1";
            this.LAB1.Size = new System.Drawing.Size(443, 37);
            this.LAB1.TabIndex = 7;
            this.LAB1.Text = "for receive part data search";
            this.LAB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB0
            // 
            this.LAB0.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LAB0.Location = new System.Drawing.Point(25, 463);
            this.LAB0.Name = "LAB0";
            this.LAB0.Size = new System.Drawing.Size(443, 37);
            this.LAB0.TabIndex = 7;
            this.LAB0.Text = "Scan Qr code on tag suplier to get po number ";
            this.LAB0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FORM_SCAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.LAB0);
            this.Controls.Add(this.LAB1);
            this.Controls.Add(this.PNL01);
            this.Controls.Add(this.LABTITAL);
            this.Controls.Add(this.BNTBORDERTITAL);
            this.Controls.Add(this.PNL02);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_SCAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FORM_SCANCLOSED);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PICBSCAN)).EndInit();
            this.PNL01.ResumeLayout(false);
            this.PNL01.PerformLayout();
            this.PNL02.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PICBWARNING)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label LABTITAL;
        private System.Windows.Forms.TextBox TXTSC01;
        private System.Windows.Forms.PictureBox PICBSCAN;
        private System.Windows.Forms.Button BNTBORDERTITAL;
        private System.Windows.Forms.Button BNTBORDERINPUT;
        private System.Windows.Forms.Panel PNL01;
        private System.Windows.Forms.Panel PNL02;
        private System.Windows.Forms.Label LAB1;
        private System.Windows.Forms.Label LAB2;
        private System.Windows.Forms.PictureBox PICBWARNING;
        private System.Windows.Forms.Button BNTSENDERROR;
        private System.Windows.Forms.Label LAB3;
        private System.Windows.Forms.Label LAB0;
    }
}