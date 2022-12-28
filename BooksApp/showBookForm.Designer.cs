namespace BooksApp
{
  partial class showBookForm
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
      this.title = new System.Windows.Forms.Label();
      this.author = new System.Windows.Forms.Label();
      this.genre = new System.Windows.Forms.Label();
      this.number_of_pages = new System.Windows.Forms.Label();
      this.type_of_binding = new System.Windows.Forms.Label();
      this.annotationLabel = new System.Windows.Forms.Label();
      this.annotation = new System.Windows.Forms.RichTextBox();
      this.year_of_writing = new System.Windows.Forms.Label();
      this.publisher_name = new System.Windows.Forms.Label();
      this.publisher_city = new System.Windows.Forms.Label();
      this.publisher_phone = new System.Windows.Forms.Label();
      this.publisher_about = new System.Windows.Forms.Label();
      this.authorBiographyLabel = new System.Windows.Forms.Label();
      this.authorBiography = new System.Windows.Forms.RichTextBox();
      this.prev = new System.Windows.Forms.Button();
      this.addToCart = new System.Windows.Forms.Button();
      this.photo = new System.Windows.Forms.PictureBox();
      this.price = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
      this.SuspendLayout();
      // 
      // title
      // 
      this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.title.AutoSize = true;
      this.title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.title.Location = new System.Drawing.Point(278, 12);
      this.title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.title.Name = "title";
      this.title.Size = new System.Drawing.Size(312, 54);
      this.title.TabIndex = 1;
      this.title.Text = "Название книги";
      this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // author
      // 
      this.author.AutoSize = true;
      this.author.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.author.Location = new System.Drawing.Point(15, 123);
      this.author.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.author.Name = "author";
      this.author.Size = new System.Drawing.Size(92, 32);
      this.author.TabIndex = 2;
      this.author.Text = "Автор: ";
      this.author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // genre
      // 
      this.genre.AutoSize = true;
      this.genre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.genre.Location = new System.Drawing.Point(15, 156);
      this.genre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.genre.Name = "genre";
      this.genre.Size = new System.Drawing.Size(80, 32);
      this.genre.TabIndex = 3;
      this.genre.Text = "Жанр:";
      this.genre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // number_of_pages
      // 
      this.number_of_pages.AutoSize = true;
      this.number_of_pages.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.number_of_pages.Location = new System.Drawing.Point(15, 189);
      this.number_of_pages.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.number_of_pages.Name = "number_of_pages";
      this.number_of_pages.Size = new System.Drawing.Size(245, 32);
      this.number_of_pages.TabIndex = 4;
      this.number_of_pages.Text = "Количество страниц:";
      this.number_of_pages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.number_of_pages.Click += new System.EventHandler(this.number_of_pages_Click);
      // 
      // type_of_binding
      // 
      this.type_of_binding.AutoSize = true;
      this.type_of_binding.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.type_of_binding.Location = new System.Drawing.Point(15, 223);
      this.type_of_binding.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.type_of_binding.Name = "type_of_binding";
      this.type_of_binding.Size = new System.Drawing.Size(126, 32);
      this.type_of_binding.TabIndex = 5;
      this.type_of_binding.Text = "Переплет:";
      this.type_of_binding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // annotationLabel
      // 
      this.annotationLabel.AutoSize = true;
      this.annotationLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.annotationLabel.Location = new System.Drawing.Point(15, 256);
      this.annotationLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.annotationLabel.Name = "annotationLabel";
      this.annotationLabel.Size = new System.Drawing.Size(138, 32);
      this.annotationLabel.TabIndex = 6;
      this.annotationLabel.Text = "Аннотация:";
      this.annotationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // annotation
      // 
      this.annotation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.annotation.Location = new System.Drawing.Point(14, 293);
      this.annotation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.annotation.Name = "annotation";
      this.annotation.ReadOnly = true;
      this.annotation.Size = new System.Drawing.Size(463, 125);
      this.annotation.TabIndex = 7;
      this.annotation.Text = "";
      // 
      // year_of_writing
      // 
      this.year_of_writing.AutoSize = true;
      this.year_of_writing.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.year_of_writing.Location = new System.Drawing.Point(15, 424);
      this.year_of_writing.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.year_of_writing.Name = "year_of_writing";
      this.year_of_writing.Size = new System.Drawing.Size(181, 32);
      this.year_of_writing.TabIndex = 8;
      this.year_of_writing.Text = "Год написания:";
      this.year_of_writing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // publisher_name
      // 
      this.publisher_name.AutoSize = true;
      this.publisher_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.publisher_name.Location = new System.Drawing.Point(14, 457);
      this.publisher_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.publisher_name.Name = "publisher_name";
      this.publisher_name.Size = new System.Drawing.Size(169, 32);
      this.publisher_name.TabIndex = 9;
      this.publisher_name.Text = "Издательство:";
      this.publisher_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // publisher_city
      // 
      this.publisher_city.AutoSize = true;
      this.publisher_city.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.publisher_city.Location = new System.Drawing.Point(70, 491);
      this.publisher_city.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.publisher_city.Name = "publisher_city";
      this.publisher_city.Size = new System.Drawing.Size(85, 32);
      this.publisher_city.TabIndex = 10;
      this.publisher_city.Text = "Город:";
      this.publisher_city.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // publisher_phone
      // 
      this.publisher_phone.AutoSize = true;
      this.publisher_phone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.publisher_phone.Location = new System.Drawing.Point(70, 524);
      this.publisher_phone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.publisher_phone.Name = "publisher_phone";
      this.publisher_phone.Size = new System.Drawing.Size(115, 32);
      this.publisher_phone.TabIndex = 11;
      this.publisher_phone.Text = "Телефон:";
      this.publisher_phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // publisher_about
      // 
      this.publisher_about.AutoSize = true;
      this.publisher_about.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.publisher_about.Location = new System.Drawing.Point(70, 557);
      this.publisher_about.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.publisher_about.Name = "publisher_about";
      this.publisher_about.Size = new System.Drawing.Size(129, 32);
      this.publisher_about.TabIndex = 12;
      this.publisher_about.Text = "Описание:";
      this.publisher_about.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // authorBiographyLabel
      // 
      this.authorBiographyLabel.AutoSize = true;
      this.authorBiographyLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.authorBiographyLabel.Location = new System.Drawing.Point(15, 629);
      this.authorBiographyLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.authorBiographyLabel.Name = "authorBiographyLabel";
      this.authorBiographyLabel.Size = new System.Drawing.Size(220, 32);
      this.authorBiographyLabel.TabIndex = 13;
      this.authorBiographyLabel.Text = "Биография автора:";
      this.authorBiographyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // authorBiography
      // 
      this.authorBiography.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.authorBiography.Location = new System.Drawing.Point(14, 667);
      this.authorBiography.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.authorBiography.Name = "authorBiography";
      this.authorBiography.ReadOnly = true;
      this.authorBiography.Size = new System.Drawing.Size(809, 125);
      this.authorBiography.TabIndex = 14;
      this.authorBiography.Text = "";
      // 
      // prev
      // 
      this.prev.Location = new System.Drawing.Point(14, 79);
      this.prev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.prev.Name = "prev";
      this.prev.Size = new System.Drawing.Size(155, 36);
      this.prev.TabIndex = 15;
      this.prev.Text = "< Вернуться назад";
      this.prev.UseVisualStyleBackColor = true;
      this.prev.Click += new System.EventHandler(this.prev_Click);
      // 
      // addToCart
      // 
      this.addToCart.Location = new System.Drawing.Point(14, 801);
      this.addToCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.addToCart.Name = "addToCart";
      this.addToCart.Size = new System.Drawing.Size(155, 36);
      this.addToCart.TabIndex = 16;
      this.addToCart.Text = "Добавить в корзину";
      this.addToCart.UseVisualStyleBackColor = true;
      this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
      // 
      // photo
      // 
      this.photo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.photo.Location = new System.Drawing.Point(497, 79);
      this.photo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.photo.Name = "photo";
      this.photo.Size = new System.Drawing.Size(326, 512);
      this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.photo.TabIndex = 17;
      this.photo.TabStop = false;
      // 
      // price
      // 
      this.price.AutoSize = true;
      this.price.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.price.Location = new System.Drawing.Point(15, 591);
      this.price.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.price.Name = "price";
      this.price.Size = new System.Drawing.Size(136, 32);
      this.price.TabIndex = 18;
      this.price.Text = "Стоимость:";
      this.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // showBookForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(837, 860);
      this.Controls.Add(this.price);
      this.Controls.Add(this.photo);
      this.Controls.Add(this.addToCart);
      this.Controls.Add(this.prev);
      this.Controls.Add(this.authorBiography);
      this.Controls.Add(this.authorBiographyLabel);
      this.Controls.Add(this.publisher_about);
      this.Controls.Add(this.publisher_phone);
      this.Controls.Add(this.publisher_city);
      this.Controls.Add(this.publisher_name);
      this.Controls.Add(this.year_of_writing);
      this.Controls.Add(this.annotation);
      this.Controls.Add(this.annotationLabel);
      this.Controls.Add(this.type_of_binding);
      this.Controls.Add(this.number_of_pages);
      this.Controls.Add(this.genre);
      this.Controls.Add(this.author);
      this.Controls.Add(this.title);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "showBookForm";
      this.Text = "showBookForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.showBookForm_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Label title;
        private Label author;
        private Label genre;
        private Label number_of_pages;
        private Label type_of_binding;
        private Label annotationLabel;
        private RichTextBox annotation;
        private Label year_of_writing;
        private Label publisher_name;
        private Label publisher_city;
        private Label publisher_phone;
        private Label publisher_about;
        private Label authorBiographyLabel;
        private RichTextBox authorBiography;
        private Button prev;
        private Button addToCart;
        private PictureBox photo;
        private Label price;
    }
}