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
    public partial class TwoPlayers : Form
    {
        string word;
        int attemps;
        public TwoPlayers()
        {
            InitializeComponent();
            TheHiddenWord.Text = "от 3 до 12 символов";
            NumberOfAttemps.Text = "от 1 до 8";
            TheHiddenWord.ForeColor = Color.Gray;
            NumberOfAttemps.ForeColor = Color.Gray;
        }

        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы хотите вернуться в главное меню?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
                this.FormClosing -= TwoPlayers_FormClosing;
                this.Close();
            }
        }

        private void TheHiddenWord_Enter(object sender, EventArgs e)
        {
            if (TheHiddenWord.Text == "от 3 до 12 символов")
            {
                TheHiddenWord.Text = "";
                TheHiddenWord.ForeColor = Color.Black;
            }
        }

        private void NumberOfAttemps_Enter(object sender, EventArgs e)
        {
            if (NumberOfAttemps.Text == "от 1 до 8")
            {
                NumberOfAttemps.Text = "";
                NumberOfAttemps.ForeColor = Color.Black;
            }
        }

        private void TheHiddenWord_Leave(object sender, EventArgs e)
        {
            if (TheHiddenWord.Text == "") {
                TheHiddenWord.Text = "от 3 до 12 символов";
                TheHiddenWord.ForeColor = Color.Gray;
            }
        }

        private void NumberOfAttemps_Leave(object sender, EventArgs e)
        {
            if (NumberOfAttemps.Text == "")
            {
                NumberOfAttemps.Text = "от 1 до 8";
                NumberOfAttemps.ForeColor = Color.Gray;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            int fl = 1;
            int fl2 = 1;
            for (int i = 0; i < NumberOfAttemps.Text.Length; i ++)
            {
                string attemps = NumberOfAttemps.Text;
                if ('1' <= attemps[i] && attemps[i] <= '9')
                    continue;
                else
                    fl = 0;
            }
            for (int i = 0; i < TheHiddenWord.Text.Length; i++)
            {
                string hidden_word = TheHiddenWord.Text;
                if ('а' <= hidden_word[i] && hidden_word[i] <= 'я' || 'А' <= hidden_word[i] && hidden_word[i] <= 'Я' || 'a' <= hidden_word[i] && hidden_word[i] <= 'z' || 'A' <= hidden_word[i] && hidden_word[i] <= 'Z')
                    continue;
                else
                    fl2 = 0;
            } 
            if (fl == 0)
            {
                MessageBox.Show("Введите количество попыток от 1 до 8");
                return;
            }
            else if (fl2 == 0)
            {
                MessageBox.Show("Введите слово от 3 до 12 букв");
                return;
            }
            else if (Convert.ToInt16(NumberOfAttemps.Text) < 1 || Convert.ToInt16(NumberOfAttemps.Text) > 8 || NumberOfAttemps.Text.Length == 0 || fl == 0)
            {
                MessageBox.Show("Введите количество попыток от 1 до 8");
                return;
            }
            else if (TheHiddenWord.Text.Length < 3 || TheHiddenWord.Text.Length > 12 || TheHiddenWord.Text.Length == 0)
            {
                MessageBox.Show("Введите слово от 3 до 12 букв");
                return;
            }  
            else
            {  
                word = TheHiddenWord.Text;
                attemps = Convert.ToInt32(NumberOfAttemps.Text);
                DataBase database = new DataBase();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("UPDATE `twoplayers` SET `word` = @w, `attemps` = @a WHERE `twoplayers`.`count` = '0';", database.getConnection());
                command.Parameters.Add("@w", MySqlDbType.VarChar).Value = word;
         
                command.Parameters.Add("@a", MySqlDbType.VarChar).Value = attemps;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                
                Hide();
                GuessingFriendWord guessingFriendWord = new GuessingFriendWord();
                guessingFriendWord.ShowDialog();
                this.FormClosing -= TwoPlayers_FormClosing;
                this.Close();
            }

        }
        private void TwoPlayers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть игру? При закрытии выход из аккаунта будет выполнен автоматически.", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}
