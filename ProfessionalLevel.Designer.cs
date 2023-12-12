namespace WordGame
{
    partial class ProfessionalLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessionalLevel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirm = new System.Windows.Forms.Button();
            this.letters = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.word = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.attemps = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.used_letters = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ToMainMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WordGame.Properties.Resources.rm251_mind_01_a;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.confirm);
            this.panel1.Controls.Add(this.letters);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.word);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.attemps);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.used_letters);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ToMainMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 680);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(99)))), ((int)(((byte)(194)))));
            this.confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(225)))));
            this.confirm.Location = new System.Drawing.Point(649, 446);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(72, 45);
            this.confirm.TabIndex = 28;
            this.confirm.Text = "ОК";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // letters
            // 
            this.letters.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.letters.Location = new System.Drawing.Point(446, 444);
            this.letters.Multiline = true;
            this.letters.Name = "letters";
            this.letters.Size = new System.Drawing.Size(157, 40);
            this.letters.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.label4.Location = new System.Drawing.Point(85, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "ВВЕДИТЕ БУКВУ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.BackColor = System.Drawing.Color.Transparent;
            this.word.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.word.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.word.Location = new System.Drawing.Point(252, 309);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(239, 68);
            this.word.TabIndex = 25;
            this.word.Text = "_ _ _ _ _";
            this.word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.label3.Location = new System.Drawing.Point(85, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "СЛОВО";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attemps
            // 
            this.attemps.AutoSize = true;
            this.attemps.BackColor = System.Drawing.Color.Transparent;
            this.attemps.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attemps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.attemps.Location = new System.Drawing.Point(431, 246);
            this.attemps.Name = "attemps";
            this.attemps.Size = new System.Drawing.Size(28, 32);
            this.attemps.TabIndex = 23;
            this.attemps.Text = "5";
            this.attemps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(86, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "ОСТАЛОСЬ ПОПЫТОК: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // used_letters
            // 
            this.used_letters.AutoSize = true;
            this.used_letters.BackColor = System.Drawing.Color.Transparent;
            this.used_letters.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.used_letters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.used_letters.Location = new System.Drawing.Point(371, 150);
            this.used_letters.Name = "used_letters";
            this.used_letters.Size = new System.Drawing.Size(36, 49);
            this.used_letters.TabIndex = 21;
            this.used_letters.Text = "-";
            this.used_letters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.label5.Location = new System.Drawing.Point(357, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(486, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "ИСПОЛЬЗОВАННЫЕ БУКВЫ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ToMainMenu.TabIndex = 19;
            this.ToMainMenu.Text = "В ГЛАВНОЕ МЕНЮ";
            this.ToMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 74);
            this.label1.TabIndex = 18;
            this.label1.Text = "PRO LEVEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfessionalLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 680);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProfessionalLevel";
            this.Text = "WordGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfessionalLevel_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ToMainMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label used_letters;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label attemps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox letters;
        private System.Windows.Forms.Button confirm;
    }
}