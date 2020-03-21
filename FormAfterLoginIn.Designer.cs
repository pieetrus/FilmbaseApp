namespace JakubPietrusLab4Zadanie
{
    partial class FormAfterLoginIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.labelMovieBase = new System.Windows.Forms.Label();
            this.buttonAddData = new System.Windows.Forms.Button();
            this.buttonAddReview = new System.Windows.Forms.Button();
            this.listBoxGenres = new System.Windows.Forms.ListBox();
            this.textBoxMovieName = new System.Windows.Forms.TextBox();
            this.labelMovieName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxYearOfRelease = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDirectors = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(30, 95);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.RowHeadersWidth = 51;
            this.dataGridViewMovies.RowTemplate.Height = 24;
            this.dataGridViewMovies.Size = new System.Drawing.Size(757, 430);
            this.dataGridViewMovies.TabIndex = 0;
            // 
            // labelMovieBase
            // 
            this.labelMovieBase.AutoSize = true;
            this.labelMovieBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.15F);
            this.labelMovieBase.Location = new System.Drawing.Point(25, 45);
            this.labelMovieBase.Name = "labelMovieBase";
            this.labelMovieBase.Size = new System.Drawing.Size(408, 30);
            this.labelMovieBase.TabIndex = 1;
            this.labelMovieBase.Text = "Oto wszystkie filmy w naszej bazie";
            // 
            // buttonAddData
            // 
            this.buttonAddData.Location = new System.Drawing.Point(48, 545);
            this.buttonAddData.Name = "buttonAddData";
            this.buttonAddData.Size = new System.Drawing.Size(153, 65);
            this.buttonAddData.TabIndex = 2;
            this.buttonAddData.Text = "Dodaj coś do bazy!";
            this.buttonAddData.UseVisualStyleBackColor = true;
            this.buttonAddData.Click += new System.EventHandler(this.buttonAddData_Click);
            // 
            // buttonAddReview
            // 
            this.buttonAddReview.Location = new System.Drawing.Point(327, 545);
            this.buttonAddReview.Name = "buttonAddReview";
            this.buttonAddReview.Size = new System.Drawing.Size(141, 65);
            this.buttonAddReview.TabIndex = 5;
            this.buttonAddReview.Text = "Recenzje";
            this.buttonAddReview.UseVisualStyleBackColor = true;
            this.buttonAddReview.Click += new System.EventHandler(this.buttonAddReview_Click);
            // 
            // listBoxGenres
            // 
            this.listBoxGenres.FormattingEnabled = true;
            this.listBoxGenres.ItemHeight = 16;
            this.listBoxGenres.Location = new System.Drawing.Point(813, 95);
            this.listBoxGenres.Name = "listBoxGenres";
            this.listBoxGenres.Size = new System.Drawing.Size(202, 164);
            this.listBoxGenres.TabIndex = 6;
            this.listBoxGenres.SelectedIndexChanged += new System.EventHandler(this.listBoxGenres_SelectedIndexChanged);
            // 
            // textBoxMovieName
            // 
            this.textBoxMovieName.Location = new System.Drawing.Point(855, 315);
            this.textBoxMovieName.Name = "textBoxMovieName";
            this.textBoxMovieName.Size = new System.Drawing.Size(100, 22);
            this.textBoxMovieName.TabIndex = 7;
            // 
            // labelMovieName
            // 
            this.labelMovieName.AutoSize = true;
            this.labelMovieName.Location = new System.Drawing.Point(830, 295);
            this.labelMovieName.Name = "labelMovieName";
            this.labelMovieName.Size = new System.Drawing.Size(141, 17);
            this.labelMovieName.TabIndex = 8;
            this.labelMovieName.Text = "Szukaj filmu po tytule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(819, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Szukaj filmu po roku produkcji";
            // 
            // textBoxYearOfRelease
            // 
            this.textBoxYearOfRelease.Location = new System.Drawing.Point(855, 373);
            this.textBoxYearOfRelease.Name = "textBoxYearOfRelease";
            this.textBoxYearOfRelease.Size = new System.Drawing.Size(100, 22);
            this.textBoxYearOfRelease.TabIndex = 10;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(855, 414);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 32);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(897, 545);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(135, 65);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Wyjdź";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDirectors
            // 
            this.buttonDirectors.Location = new System.Drawing.Point(565, 543);
            this.buttonDirectors.Name = "buttonDirectors";
            this.buttonDirectors.Size = new System.Drawing.Size(140, 67);
            this.buttonDirectors.TabIndex = 13;
            this.buttonDirectors.Text = "Reżyserzy";
            this.buttonDirectors.UseVisualStyleBackColor = true;
            this.buttonDirectors.Click += new System.EventHandler(this.buttonDirectors_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(855, 488);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 37);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormAfterLoginIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1044, 626);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDirectors);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxYearOfRelease);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMovieName);
            this.Controls.Add(this.textBoxMovieName);
            this.Controls.Add(this.listBoxGenres);
            this.Controls.Add(this.buttonAddReview);
            this.Controls.Add(this.buttonAddData);
            this.Controls.Add(this.labelMovieBase);
            this.Controls.Add(this.dataGridViewMovies);
            this.Name = "FormAfterLoginIn";
            this.Text = "FormAfterLoginIn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.Label labelMovieBase;
        private System.Windows.Forms.Button buttonAddData;
        private System.Windows.Forms.Button buttonAddReview;
        private System.Windows.Forms.ListBox listBoxGenres;
        private System.Windows.Forms.TextBox textBoxMovieName;
        private System.Windows.Forms.Label labelMovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYearOfRelease;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDirectors;
        private System.Windows.Forms.Button buttonRefresh;
    }
}