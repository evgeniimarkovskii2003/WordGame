using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace WordGame
{
    public partial class AddNewWord : Form
    {
        public AddNewWord()
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
                this.FormClosing -= AddNewWord_FormClosing;
                this.Close();
            }
        }

        private void AddNewWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть игру? При закрытии выход из аккаунта будет выполнен автоматически.", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string sequence = word.Text; //слово, введенное пользователем
            int count; //количество слов в БД на данный момент
            if (EasyLevel.Checked == true && Prolevel.Checked == false && LegendLevel.Checked == false) //если нажат уровень "Новичок"
            {
                //считывание текущего количества записей в БД
                DataBase database = new DataBase();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `easy_level`;", database.getConnection());
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                count = table.Rows.Count + 1;
                string sequence2 = sequence.ToUpper(); //в словаре Ожегова слова выделены с больших заглавых букв
                if (!SearchWordInFile('\n' + sequence2 + ',', "D://Ожегов.txt")) //каждое слово начинается с новой строки и после него есть запятая, если не нашлось
                {
                    MessageBox.Show("Слово написано с орфографической ошибкой");
                    return;
                }
                else //если нашлось в словаре
                {
                    //добавление в БД
                    database.openConnection();
                    command = new MySqlCommand("INSERT INTO `easy_level` (`word`, `number`) VALUES (@seq, @count)", database.getConnection());
                    command.Parameters.Add("@seq", MySqlDbType.VarChar).Value = sequence;
                    command.Parameters.Add("@count", MySqlDbType.VarChar).Value = count;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    MessageBox.Show("Слово добавлено в базу данных");
                    database.closeConnection();
                    word.Text = "";

                }
            }
            else if (EasyLevel.Checked == false && Prolevel.Checked == true && LegendLevel.Checked == false) //если нажат профессиональный уровень (все аналогично)
            {
                DataBase database = new DataBase();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `pro_level`;", database.getConnection());
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                count = table.Rows.Count + 1;
                string sequence2 = sequence.ToUpper(); 
                if (!SearchWordInFile('\n' + sequence2 + ',', "D://Ожегов.txt")) 
                {
                    MessageBox.Show("Слово написано с орфографической ошибкой");
                    return;
                }
                else 
                {
                    //добавление в БД
                    database.openConnection();
                    command = new MySqlCommand("INSERT INTO `pro_level` (`word`, `number`) VALUES (@seq, @count)", database.getConnection());
                    command.Parameters.Add("@seq", MySqlDbType.VarChar).Value = sequence;
                    command.Parameters.Add("@count", MySqlDbType.VarChar).Value = count;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    MessageBox.Show("Слово добавлено в базу данных");
                    database.closeConnection();
                    word.Text = "";

                }
            }
            else if (EasyLevel.Checked == false && Prolevel.Checked == false && LegendLevel.Checked == true) //если нажат легендарный уровень (все аналогично)
            {
                DataBase database = new DataBase();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `legend_level`;", database.getConnection());
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                database.openConnection();
                adapter.Fill(table);
                count = table.Rows.Count + 1;
                string sequence2 = sequence.ToUpper();
                if (!SearchWordInFile('\n' + sequence2 + ',', "D://Ожегов.txt"))
                {
                    MessageBox.Show("Слово написано с орфографической ошибкой");
                    return;
                }
                else
                {
                    //добавление в БД
                    database.openConnection();
                    command = new MySqlCommand("INSERT INTO `legend_level` (`word`, `number`) VALUES (@seq, @count)", database.getConnection());
                    command.Parameters.Add("@seq", MySqlDbType.VarChar).Value = sequence;
                    command.Parameters.Add("@count", MySqlDbType.VarChar).Value = count;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    MessageBox.Show("Слово добавлено в базу данных");
                    database.closeConnection();
                    word.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Выберите один уровень");
            }
        }
        private bool SearchWordInFile(string word, string filePath)
        {
            try
            {
                string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
                return fileContent.Contains(word);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
                return false;
            }
        }
        private void EasyLevel_CheckedChanged(object sender, EventArgs e)
        {
            EasyLevel.Enabled = true;
        }

        private void Prolevel_CheckedChanged(object sender, EventArgs e)
        {
            Prolevel.Enabled = true;
        }

        private void LegendLevel_CheckedChanged(object sender, EventArgs e)
        {
            LegendLevel.Enabled = true;
        }
    }
} 