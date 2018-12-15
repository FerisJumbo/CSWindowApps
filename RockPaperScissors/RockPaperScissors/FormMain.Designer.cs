namespace RockPaperScissors
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblComputerChoice = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.txtComputerWins = new System.Windows.Forms.TextBox();
            this.txtPlayerWins = new System.Windows.Forms.TextBox();
            this.lblPlayerChoice = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTie = new System.Windows.Forms.Label();
            this.txtTieWins = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(12, 26);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(85, 34);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(103, 26);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(78, 34);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(187, 26);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(74, 34);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblComputerChoice
            // 
            this.lblComputerChoice.AutoSize = true;
            this.lblComputerChoice.Location = new System.Drawing.Point(9, 101);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(88, 13);
            this.lblComputerChoice.TabIndex = 3;
            this.lblComputerChoice.Text = "Computer Chose:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 128);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result:";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Location = new System.Drawing.Point(9, 170);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(86, 13);
            this.lblComputerScore.TabIndex = 5;
            this.lblComputerScore.Text = "Computer Score:";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(9, 195);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(70, 13);
            this.lblPlayerScore.TabIndex = 6;
            this.lblPlayerScore.Text = "Player Score:";
            // 
            // txtComputerWins
            // 
            this.txtComputerWins.Enabled = false;
            this.txtComputerWins.Location = new System.Drawing.Point(101, 167);
            this.txtComputerWins.Name = "txtComputerWins";
            this.txtComputerWins.Size = new System.Drawing.Size(42, 20);
            this.txtComputerWins.TabIndex = 7;
            // 
            // txtPlayerWins
            // 
            this.txtPlayerWins.Enabled = false;
            this.txtPlayerWins.Location = new System.Drawing.Point(101, 192);
            this.txtPlayerWins.Name = "txtPlayerWins";
            this.txtPlayerWins.Size = new System.Drawing.Size(42, 20);
            this.txtPlayerWins.TabIndex = 8;
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.AutoSize = true;
            this.lblPlayerChoice.Location = new System.Drawing.Point(9, 73);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(72, 13);
            this.lblPlayerChoice.TabIndex = 9;
            this.lblPlayerChoice.Text = "Player Chose:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(283, 26);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(44, 34);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTie
            // 
            this.lblTie.AutoSize = true;
            this.lblTie.Location = new System.Drawing.Point(9, 220);
            this.lblTie.Name = "lblTie";
            this.lblTie.Size = new System.Drawing.Size(56, 13);
            this.lblTie.TabIndex = 11;
            this.lblTie.Text = "Tie Score:";
            // 
            // txtTieWins
            // 
            this.txtTieWins.Enabled = false;
            this.txtTieWins.Location = new System.Drawing.Point(101, 217);
            this.txtTieWins.Name = "txtTieWins";
            this.txtTieWins.Size = new System.Drawing.Size(42, 20);
            this.txtTieWins.TabIndex = 12;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 252);
            this.Controls.Add(this.txtTieWins);
            this.Controls.Add(this.lblTie);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPlayerChoice);
            this.Controls.Add(this.txtPlayerWins);
            this.Controls.Add(this.txtComputerWins);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblComputerChoice);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "FrmMain";
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblComputerChoice;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.TextBox txtComputerWins;
        private System.Windows.Forms.TextBox txtPlayerWins;
        private System.Windows.Forms.Label lblPlayerChoice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTie;
        private System.Windows.Forms.TextBox txtTieWins;
    }
}

