using MySql.Data.MySqlClient;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

 
        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы хотите выйти из аккаунта?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Hide();
                LoginForm loginform = new LoginForm();
                loginform.ShowDialog();
                this.FormClosing -= MainMenu_FormClosing;
                this.Close();
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            Hide();
            PlayMenu playMenu = new PlayMenu();
            playMenu.ShowDialog();
            this.FormClosing -= MainMenu_FormClosing;
            this.Close();
        }

        private void rating_Click(object sender, EventArgs e)
        {
            Hide();
            Rating rating = new Rating();
            rating.ShowDialog();
            this.FormClosing -= MainMenu_FormClosing;
            this.Close();
        }

        private void rules_Click(object sender, EventArgs e)
        {
            Hide();
            Rules rules = new Rules();
            rules.ShowDialog();
            this.FormClosing -= MainMenu_FormClosing;
            this.Close();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть игру? При закрытии выход из аккаунта будет выполнен автоматически.", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void playFriend_Click(object sender, EventArgs e)
        {
            Hide();
            TwoPlayers twoPlayers = new TwoPlayers();
            twoPlayers.ShowDialog();
            this.FormClosing -= MainMenu_FormClosing;
            this.Close();
        }

        private void newWord_Click(object sender, EventArgs e)
        {
            Hide();
            AddNewWord addNewWord = new AddNewWord();
            addNewWord.ShowDialog();
            this.FormClosing -= MainMenu_FormClosing;
            this.Close();
        }
    }
}
