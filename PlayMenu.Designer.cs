namespace WordGame
{
    partial class PlayMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToMainMenu = new System.Windows.Forms.Label();
            this.legendlevel = new System.Windows.Forms.Label();
            this.prolevel = new System.Windows.Forms.Label();
            this.easylevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WordGame.Properties.Resources._1640225949_20_www_funnyart_club_p_foni_dlya_prilozhenii_20;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ToMainMenu);
            this.panel1.Controls.Add(this.legendlevel);
            this.panel1.Controls.Add(this.prolevel);
            this.panel1.Controls.Add(this.easylevel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 568);
            this.panel1.TabIndex = 0;
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.AutoSize = true;
            this.ToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.ToMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToMainMenu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.ToMainMenu.Location = new System.Drawing.Point(683, 26);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(285, 32);
            this.ToMainMenu.TabIndex = 6;
            this.ToMainMenu.Text = "В ГЛАВНОЕ МЕНЮ";
            this.ToMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // legendlevel
            // 
            this.legendlevel.AutoSize = true;
            this.legendlevel.BackColor = System.Drawing.Color.Transparent;
            this.legendlevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.legendlevel.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legendlevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.legendlevel.Location = new System.Drawing.Point(309, 232);
            this.legendlevel.Name = "legendlevel";
            this.legendlevel.Size = new System.Drawing.Size(227, 49);
            this.legendlevel.TabIndex = 4;
            this.legendlevel.Text = "ЛЕГЕНДА";
            this.legendlevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.legendlevel.Click += new System.EventHandler(this.legendlevel_Click);
            // 
            // prolevel
            // 
            this.prolevel.AutoSize = true;
            this.prolevel.BackColor = System.Drawing.Color.Transparent;
            this.prolevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prolevel.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prolevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.prolevel.Location = new System.Drawing.Point(248, 170);
            this.prolevel.Name = "prolevel";
            this.prolevel.Size = new System.Drawing.Size(392, 49);
            this.prolevel.TabIndex = 3;
            this.prolevel.Text = "ПРОФЕССИОНАЛ";
            this.prolevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prolevel.Click += new System.EventHandler(this.prolevel_Click);
            // 
            // easylevel
            // 
            this.easylevel.AutoSize = true;
            this.easylevel.BackColor = System.Drawing.Color.Transparent;
            this.easylevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easylevel.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easylevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.easylevel.Location = new System.Drawing.Point(309, 109);
            this.easylevel.Name = "easylevel";
            this.easylevel.Size = new System.Drawing.Size(240, 49);
            this.easylevel.TabIndex = 2;
            this.easylevel.Text = "НОВИЧОК";
            this.easylevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.easylevel.Click += new System.EventHandler(this.easylevel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "GAME WORD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(197)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(264, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "АНГЛИЙСКИЙ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PlayMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayMenu";
            this.Text = "WordGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayMenu_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label legendlevel;
        private System.Windows.Forms.Label prolevel;
        private System.Windows.Forms.Label easylevel;
        private System.Windows.Forms.Label ToMainMenu;
        private System.Windows.Forms.Label label2;
    }
}