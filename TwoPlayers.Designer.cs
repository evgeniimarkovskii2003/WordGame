namespace WordGame
{
    partial class TwoPlayers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoPlayers));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ToMainMenu = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.NumberOfAttemps = new System.Windows.Forms.TextBox();
            this.TheHiddenWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::WordGame.Properties.Resources.rm251_mind_01_a;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.ToMainMenu);
            this.mainPanel.Controls.Add(this.confirm);
            this.mainPanel.Controls.Add(this.NumberOfAttemps);
            this.mainPanel.Controls.Add(this.TheHiddenWord);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1146, 680);
            this.mainPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.label3.Location = new System.Drawing.Point(528, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "ИГРОК 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.AutoSize = true;
            this.ToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.ToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToMainMenu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.ToMainMenu.Location = new System.Drawing.Point(849, 9);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(285, 32);
            this.ToMainMenu.TabIndex = 7;
            this.ToMainMenu.Text = "В ГЛАВНОЕ МЕНЮ";
            this.ToMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(99)))), ((int)(((byte)(194)))));
            this.confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.confirm.Location = new System.Drawing.Point(438, 474);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(241, 72);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "Подтвердить";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // NumberOfAttemps
            // 
            this.NumberOfAttemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfAttemps.Location = new System.Drawing.Point(636, 370);
            this.NumberOfAttemps.Multiline = true;
            this.NumberOfAttemps.Name = "NumberOfAttemps";
            this.NumberOfAttemps.Size = new System.Drawing.Size(247, 51);
            this.NumberOfAttemps.TabIndex = 5;
            this.NumberOfAttemps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberOfAttemps.Enter += new System.EventHandler(this.NumberOfAttemps_Enter);
            this.NumberOfAttemps.Leave += new System.EventHandler(this.NumberOfAttemps_Leave);
            // 
            // TheHiddenWord
            // 
            this.TheHiddenWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TheHiddenWord.Location = new System.Drawing.Point(636, 273);
            this.TheHiddenWord.Multiline = true;
            this.TheHiddenWord.Name = "TheHiddenWord";
            this.TheHiddenWord.Size = new System.Drawing.Size(359, 51);
            this.TheHiddenWord.TabIndex = 4;
            this.TheHiddenWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TheHiddenWord.Enter += new System.EventHandler(this.TheHiddenWord_Enter);
            this.TheHiddenWord.Leave += new System.EventHandler(this.TheHiddenWord_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(26, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(562, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите количество попыток:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(26, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите загадываемое слово: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TwoPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 680);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TwoPlayers";
            this.Text = "WordGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TwoPlayers_FormClosing);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox NumberOfAttemps;
        private System.Windows.Forms.TextBox TheHiddenWord;
        private System.Windows.Forms.Label ToMainMenu;
        private System.Windows.Forms.Label label3;
    }
}