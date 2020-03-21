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
    public partial class FormAfterLoginIn : Form
    {
     
        public FormAfterLoginIn()
        {
            InitializeComponent();
            GetDataToMovieTable();
            GetMoviesDataToListbox();
        }

        /// <summary>
        /// Funkcja dodająca dane do tabeli z filmami
        /// </summary>
        public void GetDataToMovieTable()
        {
            var context = new FilmBaseContext();

            var movies =
                from m in context.Movies
                select new
                {
                    Tytuł = m.Title, Reżyser = m.Director.Name, Gatunek = m.Genre.Name,
                    Data_Produkcji = m.YearOfRelease, Ilość_Recenzji = m.Reviews.Count
                };

            dataGridViewMovies.DataSource = movies.ToList();

        }
        /// <summary>
        /// Funkcją dodająca nazwy gatunków filmowych do listboxa
        /// </summary>
        public void GetMoviesDataToListbox()
        {
            var context = new FilmBaseContext();

            var genres = context.Genres;

            foreach (var genre in genres)
                listBoxGenres.Items.Add(genre.Name);
        }
        /// <summary>
        /// Filtrowanie po gatunku
        /// </summary>
        /// <param name="genre"></param>
        public void FiltrGenre(string genre)
        {
            var context = new FilmBaseContext();

            var movies =
                from m in context.Movies
                where m.Genre.Name.Equals(genre)
                select new
                {
                    Tytuł = m.Title,
                    Reżyser = m.Director.Name,
                    Gatunek = m.Genre.Name,
                    Data_Produkcji = m.YearOfRelease,
                    Ilość_Recenzji = m.Reviews.Count
                };
            dataGridViewMovies.DataSource = movies.ToList();

        }
        /// <summary>
        /// Filtrowanie po roku i tytule
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        public void Filtr(string title, int year)
        {
            var context = new FilmBaseContext();

            var movies =
                from m in context.Movies
                where m.Title.Equals(title)
                where m.YearOfRelease.Equals(year)
                select new
                {
                    Tytuł = m.Title,
                    Reżyser = m.Director.Name,
                    Gatunek = m.Genre.Name,
                    Data_Produkcji = m.YearOfRelease,
                    Ilość_Recenzji = m.Reviews.Count
                };
            dataGridViewMovies.DataSource = movies.ToList();

        }
        /// <summary>
        /// Filtrowanie po roku
        /// </summary>
        /// <param name="year"></param>
        public void FiltrYear(int year)
        {
            var context = new FilmBaseContext();

            var movies =
                from m in context.Movies
                where m.YearOfRelease.Equals(year)
                select new
                {
                    Tytuł = m.Title,
                    Reżyser = m.Director.Name,
                    Gatunek = m.Genre.Name,
                    Data_Produkcji = m.YearOfRelease,
                    Ilość_Recenzji = m.Reviews.Count
                };
            dataGridViewMovies.DataSource = movies.ToList();

        }
        /// <summary>
        /// Filtrowanie po tytule
        /// </summary>
        /// <param name="title"></param>
        public void FiltrTitle(string title)
        {
            var context = new FilmBaseContext();

            var movies =
                from m in context.Movies
                where m.Title.Equals(title)
                select new
                {
                    Tytuł = m.Title,
                    Reżyser = m.Director.Name,
                    Gatunek = m.Genre.Name,
                    Data_Produkcji = m.YearOfRelease,
                    Ilość_Recenzji = m.Reviews.Count
                };
            dataGridViewMovies.DataSource = movies.ToList();

        }
        /// <summary>
        /// Reakcja na zmianę wyboru na listboxie/
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxGenres.Items.Count; i++)
            {
                if (listBoxGenres.SelectedIndex == i)
                {
                    FiltrGenre(listBoxGenres.Items[listBoxGenres.SelectedIndex].ToString());
                }
            }
        }
        /// <summary>
        /// Obsługa przycisku szukania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxYearOfRelease.Text.ToString()) &
                string.IsNullOrEmpty(textBoxMovieName.Text.ToString()))
                MessageBox.Show("Nie wprowadzono żadnych danych do komórek");
            else
            {
                if (string.IsNullOrEmpty(textBoxYearOfRelease.Text.ToString()))
                    FiltrTitle(textBoxMovieName.Text.ToString());
                if(string.IsNullOrEmpty(textBoxMovieName.Text.ToString()))
                    FiltrYear(int.Parse(textBoxYearOfRelease.Text));
                else if(string.IsNullOrEmpty(textBoxYearOfRelease.Text.ToString()) == false)
                    Filtr(textBoxMovieName.Text.ToString(), int.Parse(textBoxYearOfRelease.Text));
            }
        }
        /// <summary>
        /// wyjście z okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Otwiera okno do edycji danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddData_Click(object sender, EventArgs e)
        {
            var newForm = new FormAddMovie();
            newForm.Show();
        }
        /// <summary>
        /// Otwiera okno z dodawaniem i przeglądaniem recenzji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddReview_Click(object sender, EventArgs e)
        {
            FormReviews newForm = new FormReviews();
            newForm.Show();
        }
        /// <summary>
        /// Otwiera okno z wyświetlaniem filmów w zależności od wyboru reżysera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDirectors_Click(object sender, EventArgs e)
        {
            FormDirectors newForm = new FormDirectors();
            newForm.Show();
        }
        /// <summary>
        /// Ładuje datagridview na nowo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetDataToMovieTable();
            GetMoviesDataToListbox();
        }
    }
}
