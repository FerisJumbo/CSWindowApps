namespace ClickTheButton
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
            this.btnClick = new System.Windows.Forms.Button();
            this.btnHa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClick.Location = new System.Drawing.Point(230, 158);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(70, 20);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click Me!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            this.btnClick.MouseEnter += new System.EventHandler(this.btnClick_MouseEnter);
            // 
            // btnHa
            // 
            this.btnHa.Location = new System.Drawing.Point(646, 326);
            this.btnHa.Name = "btnHa";
            this.btnHa.Size = new System.Drawing.Size(42, 23);
            this.btnHa.TabIndex = 1;
            this.btnHa.Text = "Haha";
            this.btnHa.UseVisualStyleBackColor = true;
            this.btnHa.Click += new System.EventHandler(this.btnHa_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnHa);
            this.Controls.Add(this.btnClick);
            this.Name = "FrmMain";
            this.Text = "Click The Button";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnHa;
    }
}

