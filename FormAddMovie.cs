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
    public partial class FormAddMovie : Form
    {
        public string chosenTitle;
        public FormAddMovie()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Zamykanie okienka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Dodawanie nowego filmu
        /// </summary>
        public void AddMovie()
        {
            int n;
            if (string.IsNullOrEmpty(textBoxTitle.Text.ToString()) ||
                string.IsNullOrEmpty(textBoxGenre.Text.ToString()) ||
                string.IsNullOrEmpty(textBoxDirector.Text.ToString()) ||
                string.IsNullOrEmpty(textBoxYearOfRelease.Text.ToString())||
                !int.TryParse(textBoxYearOfRelease.Text.ToString(),out n))
            {
                MessageBox.Show("Wprowadzono błędne dane, lub wprowadzono ich za mało!");
            }
            else
            {
                string title = textBoxTitle.Text.ToString();
                int yearOfRelease = int.Parse(textBoxYearOfRelease.Text.ToString());
                string genre = textBoxGenre.Text.ToString();
                string director = textBoxDirector.Text.ToString();

                var context = new FilmBaseContext();

                var ifTitle = context.Movies.Where(m => m.Title.Equals(title));
                //var ifYearOfRelease = context.Movies.Where(m => m.YearOfRelease.Equals(yearOfRelease));
                var ifGenre = context.Genres.Where(g => g.Name.Equals(genre));
                var ifDirector = context.Directors.Where(d => d.Name.Equals(director));

                //  var asdf = context.Directors.Where(d => d.Name.Equals());

                if (ifTitle.Any() == true)
                    MessageBox.Show("Film o podanym tytule już znajduje się w bazie");
                if (ifDirector.Any() == false)
                    MessageBox.Show("Podanego reżysera nie ma w bazie. Najpierw dodaj reżysera do bazy!");
                if (ifGenre.Any() == false)
                    MessageBox.Show("Podanego gatunku nie ma w bazie. Najpierw dodaj ten gatunek do bazy!");

                if (ifTitle.Any() == false && ifDirector.Any() == true && ifGenre.Any() == true)
                {
                    var movie = new Movie
                    {
                        Title = title,
                        Director = context.Directors.SingleOrDefault(d => d.Name.Equals(director)),
                        Genre = context.Genres.SingleOrDefault(g => g.Name.Equals(genre)),
                        YearOfRelease = yearOfRelease
                    };

                    context.Movies.Add(movie);
                    context.SaveChanges();
                    MessageBox.Show("Film został pomyślnie dodany do naszej bazy!");
                }
            }
        }
        /// <summary>
        /// Dodawanie nowego reżysera
        /// </summary>
        public void AddDirector()
        {
            string name = textBoxNewDirector.Text.ToString();
            var context = new FilmBaseContext();

            var ifDirector = context.Directors.Where(d => d.Name.Equals(name));
            if (string.IsNullOrEmpty(textBoxNewDirector.Text.ToString()))
                MessageBox.Show("Nie wpisano kogo dodać");
            else if (ifDirector.Any() == true)
                MessageBox.Show("Ten reżyser już znajduje się w naszej bazie!");
            else
            {
                var director = new Director
                {
                    Name = name
                };

                context.Directors.Add(director);
                context.SaveChanges();

                MessageBox.Show("Pomyślnie dodałeś reżysera do bazy! Może dodaj teraz parę filmów do jego dorobku?");
            }

            
        }
        /// <summary>
        /// Usuwanie reżysera
        /// </summary>
        public void DeleteDirector()
        {
            string name = textBoxDeleteDirector.Text.ToString();
            var context = new FilmBaseContext();

            var director = context.Directors.SingleOrDefault(d => d.Name.Equals(name));

            if (string.IsNullOrEmpty(textBoxDeleteDirector.Text.ToString()))
                MessageBox.Show("Nie wpisano kogo usnąć");
            else if (director == null)
                MessageBox.Show("Tego reżysera nie ma w naszej bazie!");
            else
            {
                context.Directors.Remove(director);
                context.SaveChanges();
                MessageBox.Show("Pomyślnie usunięto tego reżysera z bazy!");
            }
        }

        /// <summary>
        /// Przycisk do dodania filmu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddMovie();
        }
        /// <summary>
        /// Funkcja do zmieniania nazwy reżysera
        /// </summary>
        public void UpdateDirector()
        {
            var context = new FilmBaseContext();

            string oldName = textBoxOldDirectorName.Text.ToString();
            string newName = textBoxNewDirectorName.Text.ToString();

            var director = context.Directors.SingleOrDefault(d => d.Name.Equals(oldName));


            if (string.IsNullOrEmpty(oldName) || string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Wprowadzono niewystarczającą ilość danych");
            }
            else if (director == null)
            {
                MessageBox.Show("Wybrany reżyser nie znajduje się w bazie");
            }
            else
            {
                director.Name = newName;
                context.SaveChanges();
                MessageBox.Show("Pomyślnie zmieniono nazwę reżysera na: " + newName);
            }
        }
        /// <summary>
        /// Przycisk do dodania reżysera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDirector_Click(object sender, EventArgs e)
        {
            AddDirector();
        }
        /// <summary>
        /// Przycisk do usunięcia reżysera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteDirector_Click(object sender, EventArgs e)
        {
            DeleteDirector();
        }
        /// <summary>
        /// Zmiana danych reżysera - obsługa przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDirectorNameUpdate_Click(object sender, EventArgs e)
        {
            UpdateDirector();
        }
        /// <summary>
        /// Dodanie nowego gatunku - obsługa przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            AddGenre();
        }
        /// <summary>
        /// Dodanie gatunku
        /// </summary>
        public void AddGenre()
        {
            string name = textBoxNewGenre.Text.ToString();
            var context = new FilmBaseContext();

            var ifGenre = context.Genres.SingleOrDefault(g => g.Name.Equals(name));

            if (string.IsNullOrEmpty(textBoxNewGenre.Text.ToString()))
                MessageBox.Show("Nie wpisano nazwy gatunku");
            else if (ifGenre != null)
                MessageBox.Show("Ten gatunek już znajduje się w naszej bazie!");
            else
            {
                var genre = new Genre
                {
                    Name = name
                };

                context.Genres.Add(genre);
                context.SaveChanges();

                MessageBox.Show("Pomyślnie dodałeś gatunek do bazy!");
            }


        }

    }
}
