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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Obsługa wyjścia z ekranu rejestracji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExitSignInForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void signIn()
        {
            string userLogin = textBoxNewUserLogin.Text.ToString();
            string userPassword = textBoxNewUserPassword.Text.ToString();

            var context = new FilmBaseContext();

             
            var users = context.UserLogins
                .Where(u => u.UserName.Equals(userLogin));
            //sprawdzanie czy takiego użytkownika nie ma już w bazie
            if (users.Any() == true)
            {
                MessageBox.Show("Użytkownik o podanej nazwie istnieje już w bazie");
            }
            else //dodawanie nowego użytkownika do bazy
            {
                var newUser = new UserLogin
                {
                    UserName = userLogin,
                    Password = userPassword
                };

                context.UserLogins.Add(newUser);
                context.SaveChanges();
            }
        }
        /// <summary>
        /// Obsługa przycisku tworzenia konta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewUserLogin.Text.ToString()) ||
                string.IsNullOrEmpty(textBoxNewUserPassword.Text.ToString()))
            {
                MessageBox.Show("Nie wprowadzono hasła bądź nazwy użytkownika." +
                                " Uzupełnij dane aby stworzyć konto!");
            }
            else
            {
                signIn();
                MessageBox.Show("Konto zostało utworzone. Witaj w naszym gronie!");
            }
        }
    }
}
