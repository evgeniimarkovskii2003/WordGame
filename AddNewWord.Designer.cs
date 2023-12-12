namespace WordGame
{
    partial class AddNewWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewWord));
            this.label1 = new System.Windows.Forms.Label();
            this.ToMainMenu = new System.Windows.Forms.Label();
            this.EasyLevel = new System.Windows.Forms.CheckBox();
            this.Prolevel = new System.Windows.Forms.CheckBox();
            this.LegendLevel = new System.Windows.Forms.CheckBox();
            this.word = new System.Windows.Forms.TextBox();
            this.newWord = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(472, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "ДОБАВЛЕНИЕ СЛОВА";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.AutoSize = true;
            this.ToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.ToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToMainMenu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.ToMainMenu.Location = new System.Drawing.Point(1001, 18);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(285, 32);
            this.ToMainMenu.TabIndex = 10;
            this.ToMainMenu.Text = "В ГЛАВНОЕ МЕНЮ";
            this.ToMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // EasyLevel
            // 
            this.EasyLevel.AutoSize = true;
            this.EasyLevel.BackColor = System.Drawing.Color.Transparent;
            this.EasyLevel.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.EasyLevel.Location = new System.Drawing.Point(28, 140);
            this.EasyLevel.Name = "EasyLevel";
            this.EasyLevel.Size = new System.Drawing.Size(187, 46);
            this.EasyLevel.TabIndex = 11;
            this.EasyLevel.Text = "Новичок";
            this.EasyLevel.UseVisualStyleBackColor = false;
            this.EasyLevel.CheckedChanged += new System.EventHandler(this.EasyLevel_CheckedChanged);
            // 
            // Prolevel
            // 
            this.Prolevel.AutoSize = true;
            this.Prolevel.BackColor = System.Drawing.Color.Transparent;
            this.Prolevel.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prolevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.Prolevel.Location = new System.Drawing.Point(28, 207);
            this.Prolevel.Name = "Prolevel";
            this.Prolevel.Size = new System.Drawing.Size(281, 46);
            this.Prolevel.TabIndex = 12;
            this.Prolevel.Text = "Профессионал";
            this.Prolevel.UseVisualStyleBackColor = false;
            this.Prolevel.CheckedChanged += new System.EventHandler(this.Prolevel_CheckedChanged);
            // 
            // LegendLevel
            // 
            this.LegendLevel.AutoSize = true;
            this.LegendLevel.BackColor = System.Drawing.Color.Transparent;
            this.LegendLevel.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LegendLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.LegendLevel.Location = new System.Drawing.Point(28, 278);
            this.LegendLevel.Name = "LegendLevel";
            this.LegendLevel.Size = new System.Drawing.Size(176, 46);
            this.LegendLevel.TabIndex = 13;
            this.LegendLevel.Text = "Легенда";
            this.LegendLevel.UseVisualStyleBackColor = false;
            this.LegendLevel.CheckedChanged += new System.EventHandler(this.LegendLevel_CheckedChanged);
            // 
            // word
            // 
            this.word.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.word.Location = new System.Drawing.Point(704, 366);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(447, 38);
            this.word.TabIndex = 14;
            // 
            // newWord
            // 
            this.newWord.AutoSize = true;
            this.newWord.BackColor = System.Drawing.Color.Transparent;
            this.newWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newWord.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.newWord.Location = new System.Drawing.Point(12, 366);
            this.newWord.Name = "newWord";
            this.newWord.Size = new System.Drawing.Size(611, 34);
            this.newWord.TabIndex = 15;
            this.newWord.Text = "Введите слово для добавления в базу данных";
            this.newWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.confirm.Location = new System.Drawing.Point(1197, 361);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(72, 45);
            this.confirm.TabIndex = 25;
            this.confirm.Text = "ОК";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // AddNewWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordGame.Properties.Resources._1640225949_20_www_funnyart_club_p_foni_dlya_prilozhenii_20;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1298, 684);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.newWord);
            this.Controls.Add(this.word);
            this.Controls.Add(this.LegendLevel);
            this.Controls.Add(this.Prolevel);
            this.Controls.Add(this.EasyLevel);
            this.Controls.Add(this.ToMainMenu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewWord";
            this.Text = "WordGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewWord_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ToMainMenu;
        private System.Windows.Forms.CheckBox EasyLevel;
        private System.Windows.Forms.CheckBox Prolevel;
        private System.Windows.Forms.CheckBox LegendLevel;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Label newWord;
        private System.Windows.Forms.Button confirm;
    }
}