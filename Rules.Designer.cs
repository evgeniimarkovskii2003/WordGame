namespace WordGame
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.WordGame = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rulesText = new System.Windows.Forms.Label();
            this.ToMainMenu = new System.Windows.Forms.Label();
            this.WordGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // WordGame
            // 
            this.WordGame.BackgroundImage = global::WordGame.Properties.Resources._1640225949_20_www_funnyart_club_p_foni_dlya_prilozhenii_20;
            this.WordGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WordGame.Controls.Add(this.label1);
            this.WordGame.Controls.Add(this.rulesText);
            this.WordGame.Controls.Add(this.ToMainMenu);
            this.WordGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordGame.Location = new System.Drawing.Point(0, 0);
            this.WordGame.Name = "WordGame";
            this.WordGame.Size = new System.Drawing.Size(1172, 653);
            this.WordGame.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(466, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "ПРАВИЛА";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rulesText
            // 
            this.rulesText.AutoSize = true;
            this.rulesText.BackColor = System.Drawing.Color.Transparent;
            this.rulesText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.rulesText.Location = new System.Drawing.Point(25, 70);
            this.rulesText.Name = "rulesText";
            this.rulesText.Size = new System.Drawing.Size(1051, 299);
            this.rulesText.TabIndex = 7;
            this.rulesText.Text = resources.GetString("rulesText.Text");
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.AutoSize = true;
            this.ToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.ToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToMainMenu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.ToMainMenu.Location = new System.Drawing.Point(875, 14);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(285, 32);
            this.ToMainMenu.TabIndex = 5;
            this.ToMainMenu.Text = "В ГЛАВНОЕ МЕНЮ";
            this.ToMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 653);
            this.Controls.Add(this.WordGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Rules";
            this.Text = "WordGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rules_FormClosing);
            this.WordGame.ResumeLayout(false);
            this.WordGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WordGame;
        private System.Windows.Forms.Label ToMainMenu;
        private System.Windows.Forms.Label rulesText;
        private System.Windows.Forms.Label label1;
    }
}