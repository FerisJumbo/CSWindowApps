namespace Monopoly_Assistant
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyABuildingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lboxPlayers = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad500 = new System.Windows.Forms.RadioButton();
            this.rad100 = new System.Windows.Forms.RadioButton();
            this.rad50 = new System.Windows.Forms.RadioButton();
            this.rad20 = new System.Windows.Forms.RadioButton();
            this.rad10 = new System.Windows.Forms.RadioButton();
            this.rad5 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.chkUseMoney = new System.Windows.Forms.CheckBox();
            this.numericA = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlayerToolStripMenuItem,
            this.buyABuildingToolStripMenuItem,
            this.tradeToolStripMenuItem,
            this.payPlayerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newPlayerToolStripMenuItem
            // 
            this.newPlayerToolStripMenuItem.Name = "newPlayerToolStripMenuItem";
            this.newPlayerToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.newPlayerToolStripMenuItem.Text = "New Player";
            this.newPlayerToolStripMenuItem.Click += new System.EventHandler(this.newPlayerToolStripMenuItem_Click);
            // 
            // buyABuildingToolStripMenuItem
            // 
            this.buyABuildingToolStripMenuItem.Name = "buyABuildingToolStripMenuItem";
            this.buyABuildingToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.buyABuildingToolStripMenuItem.Text = "Buy a Building";
            // 
            // tradeToolStripMenuItem
            // 
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.tradeToolStripMenuItem.Text = "Trade";
            // 
            // payPlayerToolStripMenuItem
            // 
            this.payPlayerToolStripMenuItem.Name = "payPlayerToolStripMenuItem";
            this.payPlayerToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.payPlayerToolStripMenuItem.Text = "Pay a Player";
            // 
            // lboxPlayers
            // 
            this.lboxPlayers.FormattingEnabled = true;
            this.lboxPlayers.Location = new System.Drawing.Point(70, 25);
            this.lboxPlayers.Name = "lboxPlayers";
            this.lboxPlayers.Size = new System.Drawing.Size(120, 212);
            this.lboxPlayers.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(52, 212);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad500);
            this.groupBox1.Controls.Add(this.rad100);
            this.groupBox1.Controls.Add(this.rad50);
            this.groupBox1.Controls.Add(this.rad20);
            this.groupBox1.Controls.Add(this.rad10);
            this.groupBox1.Controls.Add(this.rad5);
            this.groupBox1.Controls.Add(this.rad1);
            this.groupBox1.Location = new System.Drawing.Point(197, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Money";
            // 
            // rad500
            // 
            this.rad500.AutoSize = true;
            this.rad500.Location = new System.Drawing.Point(121, 43);
            this.rad500.Name = "rad500";
            this.rad500.Size = new System.Drawing.Size(49, 17);
            this.rad500.TabIndex = 6;
            this.rad500.TabStop = true;
            this.rad500.Text = "$500";
            this.rad500.UseVisualStyleBackColor = true;
            // 
            // rad100
            // 
            this.rad100.AutoSize = true;
            this.rad100.Location = new System.Drawing.Point(66, 43);
            this.rad100.Name = "rad100";
            this.rad100.Size = new System.Drawing.Size(49, 17);
            this.rad100.TabIndex = 5;
            this.rad100.TabStop = true;
            this.rad100.Text = "$100";
            this.rad100.UseVisualStyleBackColor = true;
            // 
            // rad50
            // 
            this.rad50.AutoSize = true;
            this.rad50.Location = new System.Drawing.Point(17, 43);
            this.rad50.Name = "rad50";
            this.rad50.Size = new System.Drawing.Size(43, 17);
            this.rad50.TabIndex = 4;
            this.rad50.TabStop = true;
            this.rad50.Text = "$50";
            this.rad50.UseVisualStyleBackColor = true;
            // 
            // rad20
            // 
            this.rad20.AutoSize = true;
            this.rad20.Location = new System.Drawing.Point(142, 20);
            this.rad20.Name = "rad20";
            this.rad20.Size = new System.Drawing.Size(43, 17);
            this.rad20.TabIndex = 3;
            this.rad20.TabStop = true;
            this.rad20.Text = "$20";
            this.rad20.UseVisualStyleBackColor = true;
            // 
            // rad10
            // 
            this.rad10.AutoSize = true;
            this.rad10.Location = new System.Drawing.Point(93, 20);
            this.rad10.Name = "rad10";
            this.rad10.Size = new System.Drawing.Size(43, 17);
            this.rad10.TabIndex = 2;
            this.rad10.TabStop = true;
            this.rad10.Text = "$10";
            this.rad10.UseVisualStyleBackColor = true;
            // 
            // rad5
            // 
            this.rad5.AutoSize = true;
            this.rad5.Location = new System.Drawing.Point(50, 20);
            this.rad5.Name = "rad5";
            this.rad5.Size = new System.Drawing.Size(37, 17);
            this.rad5.TabIndex = 1;
            this.rad5.TabStop = true;
            this.rad5.Text = "$5";
            this.rad5.UseVisualStyleBackColor = true;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(7, 20);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(37, 17);
            this.rad1.TabIndex = 0;
            this.rad1.TabStop = true;
            this.rad1.Text = "$1";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(395, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 95);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(446, 28);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(55, 95);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "Subtract";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // chkUseMoney
            // 
            this.chkUseMoney.AutoSize = true;
            this.chkUseMoney.Location = new System.Drawing.Point(204, 106);
            this.chkUseMoney.Name = "chkUseMoney";
            this.chkUseMoney.Size = new System.Drawing.Size(110, 17);
            this.chkUseMoney.TabIndex = 6;
            this.chkUseMoney.Text = "Use Money Input:";
            this.chkUseMoney.UseVisualStyleBackColor = true;
            this.chkUseMoney.CheckedChanged += new System.EventHandler(this.chkUseMoney_CheckedChanged);
            // 
            // numericA
            // 
            this.numericA.Location = new System.Drawing.Point(320, 105);
            this.numericA.Maximum = new decimal(new int[] {
            7500,
            0,
            0,
            0});
            this.numericA.Name = "numericA";
            this.numericA.Size = new System.Drawing.Size(69, 20);
            this.numericA.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 249);
            this.Controls.Add(this.numericA);
            this.Controls.Add(this.chkUseMoney);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lboxPlayers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Monopoly Assistant";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyABuildingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payPlayerToolStripMenuItem;
        private System.Windows.Forms.ListBox lboxPlayers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad500;
        private System.Windows.Forms.RadioButton rad100;
        private System.Windows.Forms.RadioButton rad50;
        private System.Windows.Forms.RadioButton rad20;
        private System.Windows.Forms.RadioButton rad10;
        private System.Windows.Forms.RadioButton rad5;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.CheckBox chkUseMoney;
        private System.Windows.Forms.NumericUpDown numericA;
    }
}

