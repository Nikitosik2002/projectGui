namespace BooksApp
{
  partial class employeeForm
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
      this.subtitle = new System.Windows.Forms.Label();
      this.dgv = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.number_of_pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.year_of_writing = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.publisher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.addBookButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
      this.SuspendLayout();
      // 
      // subtitle
      // 
      this.subtitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.subtitle.AutoSize = true;
      this.subtitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.subtitle.Location = new System.Drawing.Point(534, 9);
      this.subtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.subtitle.Name = "subtitle";
      this.subtitle.Size = new System.Drawing.Size(304, 45);
      this.subtitle.TabIndex = 3;
      this.subtitle.Text = "Панель сотрудника";
      this.subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dgv
      // 
      this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.author_name,
            this.genre,
            this.price,
            this.number_of_pages,
            this.year_of_writing,
            this.publisher_name});
      this.dgv.Location = new System.Drawing.Point(12, 94);
      this.dgv.Name = "dgv";
      this.dgv.ReadOnly = true;
      this.dgv.RowHeadersWidth = 60;
      this.dgv.RowTemplate.Height = 25;
      this.dgv.Size = new System.Drawing.Size(1344, 405);
      this.dgv.TabIndex = 4;
      // 
      // id
      // 
      this.id.HeaderText = "Артикул";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 70;
      // 
      // title
      // 
      this.title.HeaderText = "Название";
      this.title.Name = "title";
      this.title.ReadOnly = true;
      this.title.Width = 170;
      // 
      // author_name
      // 
      this.author_name.HeaderText = "Автор";
      this.author_name.Name = "author_name";
      this.author_name.ReadOnly = true;
      this.author_name.Width = 170;
      // 
      // genre
      // 
      this.genre.HeaderText = "Жанр";
      this.genre.Name = "genre";
      this.genre.ReadOnly = true;
      this.genre.Width = 170;
      // 
      // price
      // 
      this.price.HeaderText = "Стоимость (руб)";
      this.price.Name = "price";
      this.price.ReadOnly = true;
      this.price.Width = 170;
      // 
      // number_of_pages
      // 
      this.number_of_pages.HeaderText = "Кол-во страниц";
      this.number_of_pages.Name = "number_of_pages";
      this.number_of_pages.ReadOnly = true;
      this.number_of_pages.Width = 170;
      // 
      // year_of_writing
      // 
      this.year_of_writing.HeaderText = "Год написания";
      this.year_of_writing.Name = "year_of_writing";
      this.year_of_writing.ReadOnly = true;
      this.year_of_writing.Width = 170;
      // 
      // publisher_name
      // 
      this.publisher_name.HeaderText = "Издание";
      this.publisher_name.Name = "publisher_name";
      this.publisher_name.ReadOnly = true;
      this.publisher_name.Width = 170;
      // 
      // addBookButton
      // 
      this.addBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.addBookButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.addBookButton.Location = new System.Drawing.Point(1187, 60);
      this.addBookButton.Name = "addBookButton";
      this.addBookButton.Size = new System.Drawing.Size(169, 28);
      this.addBookButton.TabIndex = 5;
      this.addBookButton.Text = "Добавить книгу";
      this.addBookButton.UseVisualStyleBackColor = true;
      this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
      // 
      // employeeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1368, 526);
      this.Controls.Add(this.addBookButton);
      this.Controls.Add(this.dgv);
      this.Controls.Add(this.subtitle);
      this.Name = "employeeForm";
      this.Text = "панель сотрудника";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.employeeForm_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Label subtitle;
        private DataGridView dgv;
        private Button addBookButton;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn author_name;
        private DataGridViewTextBoxColumn genre;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn number_of_pages;
        private DataGridViewTextBoxColumn year_of_writing;
        private DataGridViewTextBoxColumn publisher_name;
    }
}