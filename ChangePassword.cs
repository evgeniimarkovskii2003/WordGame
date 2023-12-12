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
    public partial class ChangePassword : Form
    {
        String loginUser;
        String secretUser;
        String passUser;

        public ChangePassword()
        {
            InitializeComponent();
            login.Text = "от 3 до 8 символов";
            password.Text = "от 4 до 12 символов";
            secret.Text = "от 3 до 8 символов";

            login.ForeColor = Color.Gray;
            password.ForeColor = Color.Gray;
            secret.ForeColor = Color.Gray;

            password.UseSystemPasswordChar = false;
            secret.UseSystemPasswordChar = false;
        }

       
        private void ButtonChangePassword_Click(object sender, EventArgs e) //кнопка сменить пароль
        {
            loginUser = login.Text; //введенный логин
            secretUser = secret.Text; //введенное секретное слово
            passUser = password.Text; //введенный новый пароль 
            //проверка данных на корректность
            if (loginUser.Length < 3 || loginUser.Length > 8)
            {
                MessageBox.Show("Введите логин от 3 до 8 символов");
                return;
            }
            if (secretUser.Length < 3 || secretUser.Length > 8)
            {
                MessageBox.Show("Введите секретное слово от 3 до 8 символов");
                return;
            }
            if (passUser == "" || passUser.Length < 4 || passUser.Length > 12)
            {
                MessageBox.Show("Введите новый пароль от 4 до 12 символов");
                return;
            }

            DataBase database = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `secret_word` = @uW", database.getConnection()); //проверка логина и секретного слова 

            command.Parameters.Add("@uW", MySqlDbType.VarChar).Value = secretUser;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0) //если логин и соответствующее секретное слово есть в БД 
            {
                command = new MySqlCommand("UPDATE `users` SET `password` = @uP WHERE `users`.`login` = @uL;", database.getConnection()); //замена пароля у соответствующего логина
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                MessageBox.Show("Пароль успешно сменен");
                Hide();//закрытие формы
                LoginForm loginform = new LoginForm();
                loginform.ShowDialog(); //переход к авторизации
                this.FormClosing -= ChangePassword_FormClosing;
                this.Close();
            }
            else //если логина и соответствующего секретного слова в БД нет
            {
                MessageBox.Show("Неправильный логин или секретное слово");
            }
        }

        private void authLabel_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
            this.FormClosing -= ChangePassword_FormClosing;
            this.Close();
        }

        private void login_Enter(object sender, EventArgs e)
        {
            if (login.Text == "от 3 до 8 символов")
            {
                login.Text = "";
                login.ForeColor = Color.Black;
            }
        }

        private void secret_Enter(object sender, EventArgs e)
        {
            if (secret.Text == "от 3 до 8 символов")
            {
                secret.Text = "";
                secret.ForeColor = Color.Black;
                secret.UseSystemPasswordChar = true;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "от 4 до 12 символов")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true;
            }
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                login.Text = "от 3 до 8 символов";
                login.ForeColor = Color.Gray;
            }
        }

        private void secret_Leave(object sender, EventArgs e)
        {
            if (secret.Text == "")
            {
                secret.Text = "от 3 до 8 символов";
                secret.ForeColor = Color.Gray;
                secret.UseSystemPasswordChar = false;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "от 4 до 12 символов";
                password.ForeColor = Color.Gray;
                password.UseSystemPasswordChar = false;
            }
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть игру?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}
