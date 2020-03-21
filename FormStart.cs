using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JakubPietrusLab4Zadanie.Models;

namespace JakubPietrusLab4Zadanie
{
    public partial class FormStart : Form
    {

        public FormStart()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda sprawdzająca obecność użytkownika w bazie i logowanie
        /// </summary>
        public void login()
        {
            string userLogin = textBoxLogin.Text.ToString();
            string userPassword = textBoxPassword.Text.ToString();

            var context = new FilmBaseContext();

            var users = context.UserLogins
                .Where(u => u.UserName.Equals(userLogin))
                .Where(u => u.Password.Equals(userPassword));

            if (users.Any() == true)
            {
                MessageBox.Show("Witaj! Udało Ci się zalogować");
                Program.user = userLogin;
                var form = new FormAfterLoginIn();
                form.Show();
            }
                
            else
                MessageBox.Show("Nie ma takiego konta, bądź hasło zostało źle wpisane");
        }
        /// <summary>
        /// Obsługa przycisku logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }
        /// <summary>
        /// Metoda otwierająca ekran rejestracji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var myForm = new FormSignIn();
            myForm.Show();
        }
        /// <summary>
        /// Przycisk do zamykania aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
