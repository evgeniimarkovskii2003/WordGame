using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    public partial class PlayMenu : Form
    {
        public PlayMenu()
        {
            InitializeComponent();
        }

        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы хотите вернуться в главное меню?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
                this.FormClosing -= PlayMenu_FormClosing;
                this.Close();
            }
        }

        private void easylevel_Click(object sender, EventArgs e)
        {
            Hide();
            EasyLevel easyLevel = new EasyLevel();
            easyLevel.ShowDialog();
            this.FormClosing -= PlayMenu_FormClosing;
            this.Close();
        }

        private void prolevel_Click(object sender, EventArgs e)
        {
            Hide();
            ProfessionalLevel professionalLevel = new ProfessionalLevel();
            professionalLevel.ShowDialog();
            this.FormClosing -= PlayMenu_FormClosing;
            this.Close();
        }

        private void legendlevel_Click(object sender, EventArgs e)
        {
            Hide();
            LegendLevel legendLevel = new LegendLevel();
            legendLevel.ShowDialog();
            this.FormClosing -= PlayMenu_FormClosing;
            this.Close();
        }

        private void PlayMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть игру? При закрытии выход из аккаунта будет выполнен автоматически.", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
            EnglishLevel englishLevel = new EnglishLevel();
            englishLevel.ShowDialog();
            this.FormClosing -= PlayMenu_FormClosing;
            this.Close();
        }
    }
}
