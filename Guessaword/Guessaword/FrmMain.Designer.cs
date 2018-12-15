namespace Guessaword
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
            this.lblHiddenword = new System.Windows.Forms.Label();
            this.lblGal = new System.Windows.Forms.Label();
            this.lblNumberofTries = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.txtTries = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLettersused = new System.Windows.Forms.Label();
            this.lblUsedletters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHiddenword
            // 
            this.lblHiddenword.AutoSize = true;
            this.lblHiddenword.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiddenword.Location = new System.Drawing.Point(96, 9);
            this.lblHiddenword.Name = "lblHiddenword";
            this.lblHiddenword.Size = new System.Drawing.Size(153, 23);
            this.lblHiddenword.TabIndex = 0;
            this.lblHiddenword.Text = "Hidden Word";
            this.lblHiddenword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGal
            // 
            this.lblGal.AutoSize = true;
            this.lblGal.Location = new System.Drawing.Point(13, 55);
            this.lblGal.Name = "lblGal";
            this.lblGal.Size = new System.Drawing.Size(75, 13);
            this.lblGal.TabIndex = 1;
            this.lblGal.Text = "Guess a letter:";
            // 
            // lblNumberofTries
            // 
            this.lblNumberofTries.AutoSize = true;
            this.lblNumberofTries.Location = new System.Drawing.Point(13, 86);
            this.lblNumberofTries.Name = "lblNumberofTries";
            this.lblNumberofTries.Size = new System.Drawing.Size(81, 13);
            this.lblNumberofTries.TabIndex = 2;
            this.lblNumberofTries.Text = "Number of tries:";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(100, 52);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(47, 20);
            this.txtGuess.TabIndex = 3;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(153, 50);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(234, 50);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(99, 23);
            this.btnPlayAgain.TabIndex = 5;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // txtTries
            // 
            this.txtTries.Enabled = false;
            this.txtTries.Location = new System.Drawing.Point(100, 83);
            this.txtTries.Name = "txtTries";
            this.txtTries.Size = new System.Drawing.Size(47, 20);
            this.txtTries.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(153, 86);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status Message";
            // 
            // lblLettersused
            // 
            this.lblLettersused.AutoSize = true;
            this.lblLettersused.Location = new System.Drawing.Point(13, 123);
            this.lblLettersused.Name = "lblLettersused";
            this.lblLettersused.Size = new System.Drawing.Size(68, 13);
            this.lblLettersused.TabIndex = 8;
            this.lblLettersused.Text = "Letters used:";
            // 
            // lblUsedletters
            // 
            this.lblUsedletters.AutoSize = true;
            this.lblUsedletters.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedletters.Location = new System.Drawing.Point(87, 120);
            this.lblUsedletters.Name = "lblUsedletters";
            this.lblUsedletters.Size = new System.Drawing.Size(129, 19);
            this.lblUsedletters.TabIndex = 9;
            this.lblUsedletters.Text = "Letters Used";
            this.lblUsedletters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 146);
            this.Controls.Add(this.lblUsedletters);
            this.Controls.Add(this.lblLettersused);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtTries);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblNumberofTries);
            this.Controls.Add(this.lblGal);
            this.Controls.Add(this.lblHiddenword);
            this.Name = "FrmMain";
            this.Text = "Guess a Word";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHiddenword;
        private System.Windows.Forms.Label lblGal;
        private System.Windows.Forms.Label lblNumberofTries;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.TextBox txtTries;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLettersused;
        private System.Windows.Forms.Label lblUsedletters;
    }
}

