namespace JakubPietrusLab4Zadanie
{
    partial class FormReviews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReviews));
            this.dataGridViewReviews = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxReview = new System.Windows.Forms.TextBox();
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.buttonAddReview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReviews
            // 
            this.dataGridViewReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReviews.Location = new System.Drawing.Point(12, 61);
            this.dataGridViewReviews.Name = "dataGridViewReviews";
            this.dataGridViewReviews.RowHeadersWidth = 51;
            this.dataGridViewReviews.RowTemplate.Height = 24;
            this.dataGridViewReviews.Size = new System.Drawing.Size(542, 546);
            this.dataGridViewReviews.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(734, 533);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(118, 48);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Wyjdź";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(676, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Napisz recenzję:";
            // 
            // textBoxReview
            // 
            this.textBoxReview.Location = new System.Drawing.Point(679, 76);
            this.textBoxReview.Name = "textBoxReview";
            this.textBoxReview.Size = new System.Drawing.Size(150, 22);
            this.textBoxReview.TabIndex = 21;
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.ItemHeight = 16;
            this.listBoxMovies.Location = new System.Drawing.Point(625, 139);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(271, 132);
            this.listBoxMovies.Sorted = true;
            this.listBoxMovies.TabIndex = 23;
            this.listBoxMovies.SelectedIndexChanged += new System.EventHandler(this.listBoxMovies_SelectedIndexChanged_1);
            // 
            // buttonAddReview
            // 
            this.buttonAddReview.Location = new System.Drawing.Point(694, 299);
            this.buttonAddReview.Name = "buttonAddReview";
            this.buttonAddReview.Size = new System.Drawing.Size(126, 43);
            this.buttonAddReview.TabIndex = 24;
            this.buttonAddReview.Text = "Dodaj recenzję";
            this.buttonAddReview.UseVisualStyleBackColor = true;
            this.buttonAddReview.Click += new System.EventHandler(this.buttonAddReview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(417, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 44);
            this.label1.TabIndex = 25;
            this.label1.Text = "RECENZJE";
            // 
            // FormReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1115, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddReview);
            this.Controls.Add(this.listBoxMovies);
            this.Controls.Add(this.textBoxReview);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewReviews);
            this.Name = "FormReviews";
            this.Text = "FormReviews";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReviews;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxReview;
        private System.Windows.Forms.ListBox listBoxMovies;
        private System.Windows.Forms.Button buttonAddReview;
        private System.Windows.Forms.Label label1;
    }
}