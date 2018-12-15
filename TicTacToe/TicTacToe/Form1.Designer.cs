namespace TicTacToe
{
    partial class FrmMain
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblTTT = new System.Windows.Forms.Label();
            this.pbox7 = new System.Windows.Forms.PictureBox();
            this.pbox8 = new System.Windows.Forms.PictureBox();
            this.pbox9 = new System.Windows.Forms.PictureBox();
            this.pbox6 = new System.Windows.Forms.PictureBox();
            this.pbox5 = new System.Windows.Forms.PictureBox();
            this.pbox4 = new System.Windows.Forms.PictureBox();
            this.pbox3 = new System.Windows.Forms.PictureBox();
            this.pbox2 = new System.Windows.Forms.PictureBox();
            this.pbox1 = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(71, 227);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblTTT
            // 
            this.lblTTT.AutoSize = true;
            this.lblTTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTT.Location = new System.Drawing.Point(47, 9);
            this.lblTTT.Name = "lblTTT";
            this.lblTTT.Size = new System.Drawing.Size(126, 25);
            this.lblTTT.TabIndex = 1;
            this.lblTTT.Text = "Tic Tac Toe";
            // 
            // pbox7
            // 
            this.pbox7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pbox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox7.Location = new System.Drawing.Point(27, 59);
            this.pbox7.Name = "pbox7";
            this.pbox7.Size = new System.Drawing.Size(50, 50);
            this.pbox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox7.TabIndex = 2;
            this.pbox7.TabStop = false;
            this.pbox7.Click += new System.EventHandler(this.pbox7_Click);
            // 
            // pbox8
            // 
            this.pbox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox8.Location = new System.Drawing.Point(83, 59);
            this.pbox8.Name = "pbox8";
            this.pbox8.Size = new System.Drawing.Size(50, 50);
            this.pbox8.TabIndex = 3;
            this.pbox8.TabStop = false;
            this.pbox8.Click += new System.EventHandler(this.pbox8_Click);
            // 
            // pbox9
            // 
            this.pbox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox9.Location = new System.Drawing.Point(139, 59);
            this.pbox9.Name = "pbox9";
            this.pbox9.Size = new System.Drawing.Size(50, 50);
            this.pbox9.TabIndex = 4;
            this.pbox9.TabStop = false;
            this.pbox9.Click += new System.EventHandler(this.pbox9_Click);
            // 
            // pbox6
            // 
            this.pbox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox6.Location = new System.Drawing.Point(139, 115);
            this.pbox6.Name = "pbox6";
            this.pbox6.Size = new System.Drawing.Size(50, 50);
            this.pbox6.TabIndex = 7;
            this.pbox6.TabStop = false;
            this.pbox6.Click += new System.EventHandler(this.pbox6_Click);
            // 
            // pbox5
            // 
            this.pbox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox5.Location = new System.Drawing.Point(83, 115);
            this.pbox5.Name = "pbox5";
            this.pbox5.Size = new System.Drawing.Size(50, 50);
            this.pbox5.TabIndex = 6;
            this.pbox5.TabStop = false;
            this.pbox5.Click += new System.EventHandler(this.pbox5_Click);
            // 
            // pbox4
            // 
            this.pbox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox4.Location = new System.Drawing.Point(27, 115);
            this.pbox4.Name = "pbox4";
            this.pbox4.Size = new System.Drawing.Size(50, 50);
            this.pbox4.TabIndex = 5;
            this.pbox4.TabStop = false;
            this.pbox4.Click += new System.EventHandler(this.pbox4_Click);
            // 
            // pbox3
            // 
            this.pbox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox3.Location = new System.Drawing.Point(139, 171);
            this.pbox3.Name = "pbox3";
            this.pbox3.Size = new System.Drawing.Size(50, 50);
            this.pbox3.TabIndex = 10;
            this.pbox3.TabStop = false;
            this.pbox3.Click += new System.EventHandler(this.pbox3_Click);
            // 
            // pbox2
            // 
            this.pbox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox2.Location = new System.Drawing.Point(83, 171);
            this.pbox2.Name = "pbox2";
            this.pbox2.Size = new System.Drawing.Size(50, 50);
            this.pbox2.TabIndex = 9;
            this.pbox2.TabStop = false;
            this.pbox2.Click += new System.EventHandler(this.pbox2_Click);
            // 
            // pbox1
            // 
            this.pbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox1.Location = new System.Drawing.Point(27, 171);
            this.pbox1.Name = "pbox1";
            this.pbox1.Size = new System.Drawing.Size(50, 50);
            this.pbox1.TabIndex = 8;
            this.pbox1.TabStop = false;
            this.pbox1.Click += new System.EventHandler(this.pbox1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 15);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 266);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbox3);
            this.Controls.Add(this.pbox2);
            this.Controls.Add(this.pbox1);
            this.Controls.Add(this.pbox6);
            this.Controls.Add(this.pbox5);
            this.Controls.Add(this.pbox4);
            this.Controls.Add(this.pbox9);
            this.Controls.Add(this.pbox8);
            this.Controls.Add(this.pbox7);
            this.Controls.Add(this.lblTTT);
            this.Controls.Add(this.btnRestart);
            this.Name = "FrmMain";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTTT;
        protected System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pbox7;
        private System.Windows.Forms.PictureBox pbox8;
        private System.Windows.Forms.PictureBox pbox9;
        private System.Windows.Forms.PictureBox pbox6;
        private System.Windows.Forms.PictureBox pbox5;
        private System.Windows.Forms.PictureBox pbox4;
        private System.Windows.Forms.PictureBox pbox3;
        private System.Windows.Forms.PictureBox pbox2;
        private System.Windows.Forms.PictureBox pbox1;
        private System.Windows.Forms.Label lblStatus;
    }
}

