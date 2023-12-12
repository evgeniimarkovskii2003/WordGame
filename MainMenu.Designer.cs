using System;

namespace WordGame
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.newWord = new System.Windows.Forms.Label();
            this.playFriend = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.rules = new System.Windows.Forms.Label();
            this.rating = new System.Windows.Forms.Label();
            this.playComputer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::WordGame.Properties.Resources._1640225949_20_www_funnyart_club_p_foni_dlya_prilozhenii_20;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.newWord);
            this.mainPanel.Controls.Add(this.playFriend);
            this.mainPanel.Controls.Add(this.exit);
            this.mainPanel.Controls.Add(this.rules);
            this.mainPanel.Controls.Add(this.rating);
            this.mainPanel.Controls.Add(this.playComputer);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(950, 665);
            this.mainPanel.TabIndex = 0;
            // 
            // newWord
            // 
            this.newWord.AutoSize = true;
            this.newWord.BackColor = System.Drawing.Color.Transparent;
            this.newWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newWord.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.newWord.Location = new System.Drawing.Point(257, 359);
            this.newWord.Name = "newWord";
            this.newWord.Size = new System.Drawing.Size(423, 49);
            this.newWord.TabIndex = 7;
            this.newWord.Text = "ДОБАВИТЬ СЛОВО ";
            this.newWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newWord.Click += new System.EventHandler(this.newWord_Click);
            // 
            // playFriend
            // 
            this.playFriend.AutoSize = true;
            this.playFriend.BackColor = System.Drawing.Color.Transparent;
            this.playFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playFriend.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playFriend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.playFriend.Location = new System.Drawing.Point(270, 168);
            this.playFriend.Name = "playFriend";
            this.playFriend.Size = new System.Drawing.Size(410, 49);
            this.playFriend.TabIndex = 6;
            this.playFriend.Text = "ИГРАТЬ С ДРУГОМ";
            this.playFriend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playFriend.Click += new System.EventHandler(this.playFriend_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.exit.Location = new System.Drawing.Point(802, 23);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(124, 32);
            this.exit.TabIndex = 4;
            this.exit.Text = "ВЫЙТИ";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // rules
            // 
            this.rules.AutoSize = true;
            this.rules.BackColor = System.Drawing.Color.Transparent;
            this.rules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rules.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.rules.Location = new System.Drawing.Point(335, 295);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(227, 49);
            this.rules.TabIndex = 3;
            this.rules.Text = "ПРАВИЛА";
            this.rules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rules.Click += new System.EventHandler(this.rules_Click);
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.BackColor = System.Drawing.Color.Transparent;
            this.rating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rating.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.rating.Location = new System.Drawing.Point(334, 235);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(228, 49);
            this.rating.TabIndex = 2;
            this.rating.Text = "РЕЙТИНГ";
            this.rating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rating.Click += new System.EventHandler(this.rating_Click);
            // 
            // playComputer
            // 
            this.playComputer.AutoSize = true;
            this.playComputer.BackColor = System.Drawing.Color.Transparent;
            this.playComputer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playComputer.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playComputer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.playComputer.Location = new System.Drawing.Point(209, 103);
            this.playComputer.Name = "playComputer";
            this.playComputer.Size = new System.Drawing.Size(583, 49);
            this.playComputer.TabIndex = 1;
            this.playComputer.Text = "ИГРАТЬ С КОМПЬЮТЕРОМ";
            this.playComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playComputer.Click += new System.EventHandler(this.play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "WORD GAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 665);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Label playComputer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label rules;
        private System.Windows.Forms.Label playFriend;
        private System.Windows.Forms.Label newWord;
    }
}