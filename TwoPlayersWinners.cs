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
    public partial class TwoPlayersWinners : Form
    {
        public TwoPlayersWinners()
        {
            InitializeComponent();
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Hide();
            TwoPlayers twoPlayers = new TwoPlayers();
            twoPlayers.ShowDialog();
            this.FormClosing -= TwoPlayersWinners_FormClosing;
            this.Close();
        }

        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.FormClosing -= TwoPlayersWinners_FormClosing;
            this.Close();
        }

    
        private void TwoPlayersWinners_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть игру? При закрытии выход из аккаунта будет выполнен автоматически.", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }


}
