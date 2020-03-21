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
    public partial class FormDirectors : Form
    {
        public string chosenDirector;

        public FormDirectors()
        {
            InitializeComponent();
            GetDataToMovieTable();
            GetDirectorsDataToListbox();
        }

        /// <summary>
        /// Wgranie danych do tabeli z filmami
        /// </summary>
        public void GetDataToMovieTable()
        {
            var context = new FilmBaseContext();

            var movies =
                from m in context.Movies
                select new
                {
                    Tytuł = m.Title,
                    Gatunek = m.Genre.Name,
                    Rok_produkcji = m.YearOfRelease
                };
            dataGridViewDirectors.DataSource = movies.ToList();
        }
        /// <summary>
        /// Zmiana wyboru na liście reżyserów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxDirectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxDirectors.Items.Count; i++)
            {
                if (listBoxDirectors.SelectedIndex == i)
                {
                    FiltrDirector(listBoxDirectors.Items[listBoxDirectors.SelectedIndex].ToString());
                }
            }
        }
        /// <summary>
        /// Dodanie reżyserów do listy
        /// </summary>
        public void GetDirectorsDataToListbox()
        {
            var context = new FilmBaseContext();

            var directors= context.Directors;

            foreach (var director in directors)
                listBoxDirectors.Items.Add(director.Name);
        }
        /// <summary>
        /// Filtruje filmy w zależności od wyboru reżysera
        /// </summary>
        /// <param name="chosenDirector"></param>
        public void FiltrDirector(string chosenDirector)
        {
            var context = new FilmBaseContext();

            var movies =
                from m in context.Movies
                where m.Director.Name.Equals(chosenDirector)
                select new
                {
                    Tytuł = m.Title,
                    Gatunek = m.Genre.Name,
                    Rok_produkcji = m.YearOfRelease
                };
            dataGridViewDirectors.DataSource = movies.ToList();
        }
        /// <summary>
        /// Wyjście z okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
