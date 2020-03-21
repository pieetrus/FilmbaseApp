namespace JakubPietrusLab4Zadanie
{
    partial class FormDirectors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDirectors));
            this.dataGridViewDirectors = new System.Windows.Forms.DataGridView();
            this.listBoxDirectors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDirectors
            // 
            this.dataGridViewDirectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDirectors.Location = new System.Drawing.Point(30, 75);
            this.dataGridViewDirectors.Name = "dataGridViewDirectors";
            this.dataGridViewDirectors.RowHeadersWidth = 51;
            this.dataGridViewDirectors.RowTemplate.Height = 24;
            this.dataGridViewDirectors.Size = new System.Drawing.Size(505, 471);
            this.dataGridViewDirectors.TabIndex = 0;
            // 
            // listBoxDirectors
            // 
            this.listBoxDirectors.FormattingEnabled = true;
            this.listBoxDirectors.ItemHeight = 16;
            this.listBoxDirectors.Location = new System.Drawing.Point(682, 134);
            this.listBoxDirectors.Name = "listBoxDirectors";
            this.listBoxDirectors.Size = new System.Drawing.Size(199, 276);
            this.listBoxDirectors.TabIndex = 1;
            this.listBoxDirectors.SelectedIndexChanged += new System.EventHandler(this.listBoxDirectors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(206, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sprawdź filmy swojego ulubionego reżysera!";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(742, 490);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(154, 56);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Wyjdź";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormDirectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(928, 576);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDirectors);
            this.Controls.Add(this.dataGridViewDirectors);
            this.Name = "FormDirectors";
            this.Text = "FormDirectors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDirectors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDirectors;
        private System.Windows.Forms.ListBox listBoxDirectors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
    }
}