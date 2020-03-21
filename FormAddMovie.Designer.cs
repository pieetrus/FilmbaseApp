namespace JakubPietrusLab4Zadanie
{
    partial class FormAddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMovie));
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxYearOfRelease = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNewDirector = new System.Windows.Forms.TextBox();
            this.buttonAddDirector = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDeleteDirector = new System.Windows.Forms.TextBox();
            this.buttonDeleteDirector = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxOldDirectorName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNewDirectorName = new System.Windows.Forms.TextBox();
            this.buttonDirectorNameUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.textBoxNewGenre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(174, 70);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 22);
            this.textBoxTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tytuł";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rok produkcji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gatunek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Reżyser";
            // 
            // textBoxYearOfRelease
            // 
            this.textBoxYearOfRelease.Location = new System.Drawing.Point(174, 132);
            this.textBoxYearOfRelease.Name = "textBoxYearOfRelease";
            this.textBoxYearOfRelease.Size = new System.Drawing.Size(100, 22);
            this.textBoxYearOfRelease.TabIndex = 5;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(174, 182);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 22);
            this.textBoxGenre.TabIndex = 6;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(174, 229);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(100, 22);
            this.textBoxDirector.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(95, 296);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 43);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Dodaj film";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(774, 434);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(115, 40);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Wyjdź";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dodawanie nowego filmu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dodawanie nowego reżysera:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Imię i Nazwisko:";
            // 
            // textBoxNewDirector
            // 
            this.textBoxNewDirector.Location = new System.Drawing.Point(512, 50);
            this.textBoxNewDirector.Name = "textBoxNewDirector";
            this.textBoxNewDirector.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewDirector.TabIndex = 13;
            // 
            // buttonAddDirector
            // 
            this.buttonAddDirector.Location = new System.Drawing.Point(437, 88);
            this.buttonAddDirector.Name = "buttonAddDirector";
            this.buttonAddDirector.Size = new System.Drawing.Size(126, 43);
            this.buttonAddDirector.TabIndex = 14;
            this.buttonAddDirector.Text = "Dodaj reżysera";
            this.buttonAddDirector.UseVisualStyleBackColor = true;
            this.buttonAddDirector.Click += new System.EventHandler(this.buttonAddDirector_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Usuń reżysera z bazy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Imię i nazwisko";
            // 
            // textBoxDeleteDirector
            // 
            this.textBoxDeleteDirector.Location = new System.Drawing.Point(512, 212);
            this.textBoxDeleteDirector.Name = "textBoxDeleteDirector";
            this.textBoxDeleteDirector.Size = new System.Drawing.Size(100, 22);
            this.textBoxDeleteDirector.TabIndex = 17;
            // 
            // buttonDeleteDirector
            // 
            this.buttonDeleteDirector.Location = new System.Drawing.Point(437, 254);
            this.buttonDeleteDirector.Name = "buttonDeleteDirector";
            this.buttonDeleteDirector.Size = new System.Drawing.Size(115, 40);
            this.buttonDeleteDirector.TabIndex = 18;
            this.buttonDeleteDirector.Text = "Usuń";
            this.buttonDeleteDirector.UseVisualStyleBackColor = true;
            this.buttonDeleteDirector.Click += new System.EventHandler(this.buttonDeleteDirector_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(754, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Zmień dane reżysera:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(655, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 34);
            this.label11.TabIndex = 20;
            this.label11.Text = "Imię i Nazwisko\r\n (w bazie):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxOldDirectorName
            // 
            this.textBoxOldDirectorName.Location = new System.Drawing.Point(787, 45);
            this.textBoxOldDirectorName.Name = "textBoxOldDirectorName";
            this.textBoxOldDirectorName.Size = new System.Drawing.Size(100, 22);
            this.textBoxOldDirectorName.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(655, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 34);
            this.label12.TabIndex = 22;
            this.label12.Text = "Imię i Nazwisko\r\n(nowe):";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNewDirectorName
            // 
            this.textBoxNewDirectorName.Location = new System.Drawing.Point(787, 110);
            this.textBoxNewDirectorName.Name = "textBoxNewDirectorName";
            this.textBoxNewDirectorName.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewDirectorName.TabIndex = 23;
            // 
            // buttonDirectorNameUpdate
            // 
            this.buttonDirectorNameUpdate.Location = new System.Drawing.Point(774, 161);
            this.buttonDirectorNameUpdate.Name = "buttonDirectorNameUpdate";
            this.buttonDirectorNameUpdate.Size = new System.Drawing.Size(126, 43);
            this.buttonDirectorNameUpdate.TabIndex = 24;
            this.buttonDirectorNameUpdate.Text = "Zmień";
            this.buttonDirectorNameUpdate.UseVisualStyleBackColor = true;
            this.buttonDirectorNameUpdate.Click += new System.EventHandler(this.buttonDirectorNameUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(726, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Dodawanie nowego gatunku:";
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.Location = new System.Drawing.Point(774, 341);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(126, 43);
            this.buttonAddGenre.TabIndex = 28;
            this.buttonAddGenre.Text = "Dodaj gatunek";
            this.buttonAddGenre.UseVisualStyleBackColor = true;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // textBoxNewGenre
            // 
            this.textBoxNewGenre.Location = new System.Drawing.Point(787, 293);
            this.textBoxNewGenre.Name = "textBoxNewGenre";
            this.textBoxNewGenre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewGenre.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(709, 296);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Nazwa";
            // 
            // FormAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(917, 484);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.textBoxNewGenre);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonDirectorNameUpdate);
            this.Controls.Add(this.textBoxNewDirectorName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxOldDirectorName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonDeleteDirector);
            this.Controls.Add(this.textBoxDeleteDirector);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAddDirector);
            this.Controls.Add(this.textBoxNewDirector);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxYearOfRelease);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "FormAddMovie";
            this.Text = "FormAddMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxYearOfRelease;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNewDirector;
        private System.Windows.Forms.Button buttonAddDirector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDeleteDirector;
        private System.Windows.Forms.Button buttonDeleteDirector;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxOldDirectorName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNewDirectorName;
        private System.Windows.Forms.Button buttonDirectorNameUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonAddGenre;
        private System.Windows.Forms.TextBox textBoxNewGenre;
        private System.Windows.Forms.Label label14;
    }
}