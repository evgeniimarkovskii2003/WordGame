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
    public partial class ComputerPlayerWinners : Form
    {
        public ComputerPlayerWinners()
        {
            InitializeComponent();
        }

        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.FormClosing -= ComputerPlayerWinners_FormClosing;
            this.Close();
        }

        private void AnotherLevel_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayMenu playMenu = new PlayMenu();
            playMenu.ShowDialog();
            this.FormClosing -= ComputerPlayerWinners_FormClosing;
            this.Close();
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        { 
            Hide();
            if (level.Text == "новичок")
            {
                EasyLevel easyLevel = new EasyLevel();
                easyLevel.ShowDialog();
                this.FormClosing -= ComputerPlayerWinners_FormClosing;
                this.Close();
            }
            else if (level.Text == "профессионал")
            {
                ProfessionalLevel professionalLevel = new ProfessionalLevel();
                professionalLevel.ShowDialog();
                this.FormClosing -= ComputerPlayerWinners_FormClosing;
                this.Close();
            }
            else if (level.Text == "легенда")
            {
                LegendLevel legendLevel = new LegendLevel();
                legendLevel.ShowDialog();
                this.FormClosing -= ComputerPlayerWinners_FormClosing;
                this.Close();
            }
            else
            {
                EnglishLevel englishLevel = new EnglishLevel();
                englishLevel.ShowDialog();
                this.FormClosing -= ComputerPlayerWinners_FormClosing;
                this.Close();
            }
        }

        private void ComputerPlayerWinners_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть игру? При закрытии выход из аккаунта будет выполнен автоматически.", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}
