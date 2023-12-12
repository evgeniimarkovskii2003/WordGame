using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordGame
{
    public partial class RegisterForm : Form
    {
        String loginUser;
        String passwordUser;
        String secretUser;
        public RegisterForm()
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

        public Boolean checkUser() //проверка есть ли введенный логин 
        {
            DataBase database = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", database.getConnection()); //поиск логина

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) //если логин найден
            {
                MessageBox.Show("Такой логин уже есть, введите другой"); //необходимо ввести новый логин
                return true;
            }
            else //если логина нет
                return false;
        }
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            loginUser = login.Text; //введенный логин
            passwordUser = password.Text; //введенный пароль
            secretUser = secret.Text; //введенное секретное слово
            //проверка корректного ввода
            if (loginUser == "" || loginUser.Length < 3 || loginUser.Length > 8)
            {
                MessageBox.Show("Введите логин от 3 до 8 символов");
                return;
            }
            if (passwordUser == "" || passwordUser.Length < 4 || passwordUser.Length > 12)
            {
                MessageBox.Show("Введите пароль от 4 до 12 символов");
                return;
            }
            if (secretUser == "" || secretUser.Length < 3 || secretUser.Length > 8)
            {
                MessageBox.Show("Введите секретное слово от 3 до 8 символов");
                return;
            }
            if (checkUser() == true) //если логин уже есть
                return;
            DataBase database = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `secret_word`, `rating`) VALUES(@login, @password, @secret_word, '0')", database.getConnection()); //вставка новой записи в БД

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordUser;
            command.Parameters.Add("@secret_word", MySqlDbType.VarChar).Value = secretUser;

            database.openConnection(); 

            if (command.ExecuteNonQuery() == 1) //если запись была добавлена
            {
                MessageBox.Show("Аккаунт был создан");
                Hide(); //закрытие формы
                LoginForm loginform = new LoginForm();
                loginform.ShowDialog(); //переход к форме авторизации
                this.FormClosing -= RegisterForm_FormClosing;
                this.Close();
            } 
            else //если запись не была добавлена
                MessageBox.Show("Аккаунт не был создан");

            database.closeConnection();
        }
        
        

        private void authLabel_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
            this.FormClosing -= RegisterForm_FormClosing;
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

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "от 4 до 12 символов")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true;
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

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                login.Text = "от 3 до 8 символов";
                login.ForeColor = Color.Gray;
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

        private void secret_Leave(object sender, EventArgs e)
        {
            if (secret.Text == "")
            {
                secret.Text = "от 3 до 8 символов";
                secret.ForeColor = Color.Gray;
                secret.UseSystemPasswordChar = false;
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть игру?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }

}
