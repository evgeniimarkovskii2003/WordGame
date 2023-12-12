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
    public partial class ProfessionalLevel : Form
    {
        int fl = 0;
        int fl2 = 0;
        string usedLetters = "";
        string word2 = "";
        int attemp = 6;
        string login = "";
        public ProfessionalLevel()
        {
            InitializeComponent();
        }
        public void decrease_rating()
        {
            DataBase database = new DataBase();
            database.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `currentlogin`;", database.getConnection());
            MySqlDataReader dr = command.ExecuteReader();
            dr.Read();
            login = dr[0].ToString();
            dr.Close();
            command = new MySqlCommand("SELECT `rating` FROM `users` WHERE `login` = @l", database.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
            dr = command.ExecuteReader();
            dr.Read();
            int rating = Convert.ToInt32(dr[0]) - 10;
            dr.Close();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            command = new MySqlCommand("UPDATE `users` SET `rating` = @r WHERE `users`.`login` = @l;", database.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@r", MySqlDbType.VarChar).Value = rating;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            database.closeConnection();
        }
        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы хотите вернуться в главное меню? Рейтинг будет снижен на 10 очков.", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                decrease_rating();
                Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
                this.FormClosing -= ProfessionalLevel_FormClosing;
                this.Close();
            }
        }
        public string new_word(string word, char letter)
        {
            string word3 = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != '_')
                {
                    word3 += word[i];
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
        public string new_rating(int i)
        {
            DataBase database = new DataBase();
            database.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT `rating` FROM `users` WHERE `login` = @l", database.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
            MySqlDataReader dr = command.ExecuteReader();
            dr.Read();
            int rating = Convert.ToInt32(dr[0]);
            if (i == 0 && rating < 1500)
                rating += 20;
            else if (i == 1 && rating - 20 < 0)
                rating = 0;
            else if (i == 1 && rating < 1500)
                rating -= 10;
            database.closeConnection();
            database.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            command = new MySqlCommand("UPDATE `users` SET `rating` = @r WHERE `users`.`login` = @l;", database.getConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@r", MySqlDbType.VarChar).Value = rating;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            database.closeConnection();
            return rating.ToString();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (fl2 == 0)
            {
                DataBase database = new DataBase();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `pro_level`;", database.getConnection());
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                database.openConnection();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                int count = table.Rows.Count;
                Random rnd = new Random();
                int len = rnd.Next(1, count);
                command = new MySqlCommand("SELECT * FROM `pro_level` WHERE `number` = @num", database.getConnection());
                command.Parameters.Add("@num", MySqlDbType.VarChar).Value = len;
                MySqlDataReader dr = command.ExecuteReader();
                dr.Read();
                word2 = dr[0].ToString(); 
                database.closeConnection();
                string l = Convert.ToString(word2[0]);
                for (int i = 0; i < word2.Length - 2; i++)
                {
                    l += " _";
                }
                l = l + " " + word2[word2.Length - 1];
                word.Text = l;
                attemps.Text = attemp.ToString();
                fl2 += 1;

                command = new MySqlCommand("SELECT * FROM `currentlogin`;", database.getConnection());
                database.openConnection();
                dr = command.ExecuteReader();
                dr.Read();
                login = dr[0].ToString();
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            char letter = '-';
            string rating;
            if (letters.Text.Length == 1)
            {
                letter = Convert.ToChar(letters.Text);
            }
            if ((letter >= 'а' && letter <= 'я'  || letter >= 'a' && letter <= 'z' ) && letters.Text.Length == 1)
            {
                if (usedLetters.IndexOf(letter) == -1)
                {
                    int fl1 = fl;
                    string Word = word.Text;
                    string word3 = new_word(Word, letter);
                    word.Text = word3;
                    if (fl1 >= fl)
                        attemps.Text = Convert.ToString(Convert.ToInt32(attemps.Text) - 1);
                    usedLetters += letter + " ";
                    used_letters.Text = usedLetters;
                    letters.Text = "";
                    if (attemps.Text == "0")
                    {
                        Hide();
                        ComputerPlayerWinners computerPlayerWinners = new ComputerPlayerWinners();
                        computerPlayerWinners.word.Text = word2;
                        computerPlayerWinners.level.Text = "профессионал";
                        rating = new_rating(1);
                        computerPlayerWinners.winner.Text = "Вы проиграли!";
                        computerPlayerWinners.rating.Text = rating;
                        computerPlayerWinners.ShowDialog();
                        this.FormClosing -= ProfessionalLevel_FormClosing;
                        this.Close();
                    }
                    if (fl == word2.Length - 2)
                    {
                        Hide();
                        ComputerPlayerWinners computerPlayerWinners = new ComputerPlayerWinners();
                        computerPlayerWinners.word.Text = word2;
                        computerPlayerWinners.level.Text = "профессионал";
                        rating = new_rating(0);
                        computerPlayerWinners.winner.Text = "Вы победили!";
                        computerPlayerWinners.rating.Text = rating;
                        computerPlayerWinners.ShowDialog();
                        this.FormClosing -= ProfessionalLevel_FormClosing;
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
                MessageBox.Show("Введите одну строчную букву!");
                letters.Text = "";
            }
        }

        private void ProfessionalLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть игру? При закрытии выход из аккаунта будет выполнен автоматически. Рейтинг будет снижен на 10 очков.", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                decrease_rating();
                e.Cancel = false;
            }
        }
    }
}
