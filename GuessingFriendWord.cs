using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    public partial class GuessingFriendWord : Form
    {
        int fl = 0;
        string usedLetters = "";
        public GuessingFriendWord()
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
                this.FormClosing -= GuessingFriendWord_FormClosing;
                this.Close();
            }
        }
        public string new_word(string word, string word2, char letter)
        {
            string word3 = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != '_')
                {
                    word3 += word[i];
                    continue;
                }

                else if (word2[i / 2] == letter)
                {
                    word3 += letter;
                    fl++;
                }
                else
                {
                    word3 += "_";
                }

            }
            return word3;
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            DataBase database = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `twoplayers`;", database.getConnection());
            database.openConnection();
            MySqlDataReader dr = command.ExecuteReader();
            dr.Read();
            string word2 = dr[0].ToString();
            database.closeConnection();
            char letter = '-';
            if (letters.Text.Length == 1)
            {
                letter = Convert.ToChar(letters.Text);
            }
            if ((letter >= 'а' && letter <= 'я' || letter >= 'А' && letter <= 'Я' || letter >= 'a' && letter <= 'z' || letter >= 'A' && letter <= 'Z') && letters.Text.Length == 1)
            {  
                if (usedLetters.IndexOf(letter) == -1)
                {
                    int fl1 = fl;
                    string Word = word.Text;
                    string word3 = new_word(Word, word2, letter);
                    word.Text = word3;
                    if (fl1 >= fl)
                        attemps.Text = Convert.ToString(Convert.ToInt32(attemps.Text) - 1);
                    usedLetters += letter + " ";
                    used_letters.Text = usedLetters;
                    letters.Text = "";
                    if (attemps.Text == "0")
                    {
                        Hide();
                        TwoPlayersWinners twoPlayersWinners= new TwoPlayersWinners();
                        twoPlayersWinners.word.Text = word2;
                        twoPlayersWinners.NumberPlayersWinner.Text = "1";
                        twoPlayersWinners.ShowDialog();
                        this.FormClosing -= GuessingFriendWord_FormClosing;
                        this.Close();
                    }
                    if (fl == word2.Length - 2)
                    {
                        Hide();
                        TwoPlayersWinners twoPlayersWinners = new TwoPlayersWinners();
                        twoPlayersWinners.word.Text = word2;
                        twoPlayersWinners.NumberPlayersWinner.Text = "2";
                        twoPlayersWinners.ShowDialog();
                        this.FormClosing -= GuessingFriendWord_FormClosing;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Такая буква уже была использована. Введите другую!");
                    letters.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Введите одну букву!");
                letters.Text = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (usedLetters == "")
            {
                DataBase database = new DataBase();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `twoplayers`;", database.getConnection());
                database.openConnection();
                MySqlDataReader dr = command.ExecuteReader();
                dr.Read();
                string word1 = dr[0].ToString();
                string attemps1 = dr[1].ToString();
                database.closeConnection();
                attemps.Text = attemps1;
                string l = Convert.ToString(word1[0]);
                for (int i = 0; i < word1.Length - 2; i++)
                {
                    l += " _";
                }
                l = l + " " + word1[word1.Length - 1];
                word.Text = l;
            }
        }

        private void GuessingFriendWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть игру? При закрытии выход из аккаунта будет выполнен автоматически.", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}
