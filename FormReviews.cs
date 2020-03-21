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
    public partial class FormReviews : Form
    {
        public string chosenTitle; //Zmienna przchowująca wybrany tytuł filmu z listboxa

        public FormReviews()
        {
            InitializeComponent();
            getDataToTable();
            getDataToMovieListBox();
        }

        /// <summary>
        /// Zczytywanie danych do tabeli z recenzjami
        /// </summary>
        public void getDataToTable()
        {
            var context = new FilmBaseContext();

            var reviews =
                from r in context.Reviews
                select new
                {
                    Film = r.Movie.Title, Treść = r.Contest, Użytkownik = r.UserLogin.UserName 
                };

            dataGridViewReviews.DataSource = reviews.ToList();
        }
        /// <summary>
        /// Przycisk wyjścia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Dodanie filmów do listy do wyboru wpisywania recenzji
        /// </summary>
        public void getDataToMovieListBox()
        {
            var context = new FilmBaseContext();

            var movies = context.Movies;

            foreach (var movie in movies)
                listBoxMovies.Items.Add(movie.Title);
        }
        /// <summary>
        /// Obsługa dodawania receznji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddReview(string title)
        {

            string contest = textBoxReview.Text.ToString();
            var context = new FilmBaseContext();
            {
                var review = new Review
                {
                    Contest = contest,
                    Movie = context.Movies.SingleOrDefault(m => m.Title.Equals(title)),
                    UserLogin = context.UserLogins.SingleOrDefault(u => u.UserName.Equals(Program.user))
                };

                context.Reviews.Add(review);
                context.SaveChanges();

                MessageBox.Show("Pomyślnie dodałeś recenzję filmu. Dzięki!");
            }

        }

        /// <summary>
        /// Zmiana wyboru na listboxie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxMovies_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxMovies.Items.Count; i++)
            {
                if (listBoxMovies.SelectedIndex == i)
                {
                    chosenTitle = listBoxMovies.Items[listBoxMovies.SelectedIndex].ToString();
                }
            }
        }
        /// <summary>
        /// Przycisk dodawania recenzji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddReview_Click(object sender, EventArgs e)
        {
            AddReview(chosenTitle);
        }
    }
}
