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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WordGame
{
    public partial class LoginForm : Form
    {
        String loginUser;
        String passUser;

        public LoginForm()
        {
            InitializeComponent();
            this.password.Size = new Size(this.login.Size.Width, this.login.Size.Height);
            this.password.AutoSize = false;
        }


        private void LoginButton_Click(object sender, EventArgs e)  // кнопка Войти
        {

            loginUser = login.Text; //введенный логин
            passUser = password.Text; //введенный пароль

            DataBase database = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", database.getConnection()); //поиск человека с введенными данными

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) //если нашлось совпадение 
            {
                Hide(); //закрытие окна
                MainMenu mainMenu = new MainMenu(); //переход в главное меню 
                command = new MySqlCommand("UPDATE `currentlogin` SET `login`= @uL WHERE 1", database.getConnection()); //обновление текущего аккаунта 
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                adapter.SelectCommand = command;
                adapter.Fill(table);  
                mainMenu.ShowDialog();
                this.FormClosing -= LoginForm_FormClosing;
                this.Close();

            }
            else //если совпадений не было
                MessageBox.Show("Неверный логин или пароль");

        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.FormClosing -= LoginForm_FormClosing;
            this.Close();
        }

        private void ToChangePassword_Click(object sender, EventArgs e)
        {
            Hide();
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
            this.FormClosing -= LoginForm_FormClosing;
            this.Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть игру?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}
