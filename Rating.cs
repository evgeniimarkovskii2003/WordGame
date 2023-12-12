using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySqlX.XDevAPI.Common;
using System.Drawing.Printing;

namespace WordGame
{
    public partial class Rating : Form
    {
        string print_result = "";
        public Rating()
        {
            InitializeComponent();
        }
        //метод для обмена элементов массива
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //метод возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы хотите вернуться в главное меню?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
                this.FormClosing -= Rating_FormClosing;
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DataBase database = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT `rating` FROM `users`;", database.getConnection()); //все рейтинги из БД
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            database.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int count = table.Rows.Count; //количество пользователей
            var scores = new int[count]; //массив с рейтингами
            MySqlDataReader dr = command.ExecuteReader();
            for (int i = 0; i < count; i++) //считывание рейтинга
            {
                dr.Read();
                scores[i] = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            QuickSort(scores); //сортировка рейтинга по убыванию
            if (scores[0] == scores[1] && scores[0] != scores[2]) // если первое и второе имеют одинаковое кол-во очков, то два 1 места
                two_place.Text = "1";
            if (scores[0] == scores[1] && scores[0] == scores[2]) // если первое, второе и третье имеют одинаковое кол-во очков, то три 1 места
            {
                two_place.Text = "1";
                three_place.Text = "1";
            }
            if (scores[0] != scores[1] && scores[1] == scores[2]) // второе и третье имеют одинаковое кол-во очков, то два 2 места
                three_place.Text = "2";
            //запись очков для всех мест
            first_place.Text = scores[0].ToString(); 
            second_place.Text = scores[1].ToString();
            third_place.Text = scores[2].ToString();
            var used_login = new string[100]; //массив для использованных логинов
            command = new MySqlCommand("SELECT `login` FROM `users` WHERE `rating` = @r;", database.getConnection()); //поиск логина по рейтингу
            command.Parameters.Add("@r", MySqlDbType.VarChar).Value = scores[0];
            dr = command.ExecuteReader();
            dr.Read();
            login_first.Text = dr[0].ToString(); //запись логина 1 место
            used_login[0] = dr[0].ToString(); //запись использованных логинов
            dr.Close();
            command = new MySqlCommand("SELECT `login` FROM `users` WHERE `rating` = @r AND `login` <> @l;", database.getConnection()); //поиск слудеющего логина по рейтингу
            command.Parameters.Add("@r", MySqlDbType.VarChar).Value = scores[1];
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = used_login[0];
            dr = command.ExecuteReader();
            dr.Read();
            login_second.Text = dr[0].ToString(); //запись логина 2 место
            used_login[1] = dr[0].ToString();
            dr.Close();
            command = new MySqlCommand("SELECT `login` FROM `users` WHERE `rating` = @r AND `login` <> @l AND `login` <> @l2;", database.getConnection()); //поиск слудеющего логина по рейтингу
            command.Parameters.Add("@r", MySqlDbType.VarChar).Value = scores[2];
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = used_login[0];
            command.Parameters.Add("@l2", MySqlDbType.VarChar).Value = used_login[1];
            dr = command.ExecuteReader();
            dr.Read();
            login_third.Text = dr[0].ToString(); //запись логина 3 место
            used_login[2] = dr[0].ToString();
            dr.Close();
            command = new MySqlCommand("SELECT * FROM `currentlogin`;", database.getConnection());
            dr = command.ExecuteReader();
            dr.Read();
            string login = dr[0].ToString(); //текущий логин
            command = new MySqlCommand("SELECT `rating` FROM `users` WHERE `login` = @l;", database.getConnection()); //поиск рейтинга для текущего логина
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
            dr.Close();
            dr = command.ExecuteReader();
            dr.Read();
            int place = 1; //место текущего пользователя
            for (int i = 0; i < count; i++) //нахождения места пользователя
            {
                if (scores[i] == Convert.ToInt32(dr[0]))
                {
                    break;
                }
                place++;
            }
            current_place.Text = place.ToString(); //запись места текущего пользователя
            current_rating.Text = dr[0].ToString(); //запись рейтинга текущего пользователя
            database.closeConnection();
        }

        private void Rating_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть игру? При закрытии выход из аккаунта будет выполнен автоматически.", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void save_rating_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Text files|*.txt";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, false))
                {
                    sw.WriteLine("Рейтинг: ");
                    sw.WriteLine("1. " + login_first.Text + " - " + first_place.Text);
                    sw.WriteLine("2. " + login_second.Text + " - " + second_place.Text);
                    sw.WriteLine("3. " + login_third.Text + " - " + third_place.Text);
                    sw.WriteLine("Вы находитесь на " + current_place.Text + " месте! Ваш рейтинг: " + current_rating.Text);
                    sw.Close();
                }
            }
        }
        private void print_rating_Click(object sender, EventArgs e)
        {
            print_result = "Рейтинг: \n";
            print_result += "1. " + login_first.Text + " - " + first_place.Text + "\n";
            print_result += "2. " + login_second.Text + " - " + second_place.Text + "\n";
            print_result += "3. " + login_third.Text + " - " + third_place.Text + "\n";
            print_result += "Вы находитесь на " + current_place.Text + " месте! Ваш рейтинг: " + current_rating.Text + "\n";
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += PrintPageHandler;

            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); 
        }
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(print_result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

    }
}
