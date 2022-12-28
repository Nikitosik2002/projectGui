namespace BooksApp
{
  partial class addBookForm
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
      this.prev = new System.Windows.Forms.Button();
      this.titleLabel = new System.Windows.Forms.Label();
      this.titleField = new System.Windows.Forms.TextBox();
      this.genreLabel = new System.Windows.Forms.Label();
      this.genreField = new System.Windows.Forms.TextBox();
      this.authorLabel = new System.Windows.Forms.Label();
      this.authorField = new System.Windows.Forms.ComboBox();
      this.priceLabel = new System.Windows.Forms.Label();
      this.priceField = new System.Windows.Forms.TextBox();
      this.numberOfPagesField = new System.Windows.Forms.TextBox();
      this.numberOfPagesLabel = new System.Windows.Forms.Label();
      this.typeOfBindingField = new System.Windows.Forms.TextBox();
      this.typeOfBindingLabel = new System.Windows.Forms.Label();
      this.annotationField = new System.Windows.Forms.TextBox();
      this.annotationLabel = new System.Windows.Forms.Label();
      this.storageField = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.publishingHouseField = new System.Windows.Forms.ComboBox();
      this.publishingHouseLabel = new System.Windows.Forms.Label();
      this.writingYearField = new System.Windows.Forms.TextBox();
      this.writingYearLabel = new System.Windows.Forms.Label();
      this.photoLabel = new System.Windows.Forms.Label();
      this.photoButton = new System.Windows.Forms.Button();
      this.submit = new System.Windows.Forms.Button();
      this.errorLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // title
      // 
      this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.title.AutoSize = true;
      this.title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.title.Location = new System.Drawing.Point(175, 12);
      this.title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.title.Name = "title";
      this.title.Size = new System.Drawing.Size(362, 54);
      this.title.TabIndex = 4;
      this.title.Text = "Добавление книги";
      this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // prev
      // 
      this.prev.Location = new System.Drawing.Point(14, 76);
      this.prev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.prev.Name = "prev";
      this.prev.Size = new System.Drawing.Size(155, 36);
      this.prev.TabIndex = 17;
      this.prev.Text = "< Вернуться назад";
      this.prev.UseVisualStyleBackColor = true;
      this.prev.Click += new System.EventHandler(this.prev_Click);
      // 
      // titleLabel
      // 
      this.titleLabel.AutoSize = true;
      this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.titleLabel.Location = new System.Drawing.Point(8, 175);
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Size = new System.Drawing.Size(182, 32);
      this.titleLabel.TabIndex = 18;
      this.titleLabel.Text = "Произведение:";
      // 
      // titleField
      // 
      this.titleField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.titleField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.titleField.Location = new System.Drawing.Point(184, 171);
      this.titleField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.titleField.Name = "titleField";
      this.titleField.Size = new System.Drawing.Size(474, 39);
      this.titleField.TabIndex = 1;
      // 
      // genreLabel
      // 
      this.genreLabel.AutoSize = true;
      this.genreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.genreLabel.Location = new System.Drawing.Point(6, 281);
      this.genreLabel.Name = "genreLabel";
      this.genreLabel.Size = new System.Drawing.Size(80, 32);
      this.genreLabel.TabIndex = 20;
      this.genreLabel.Text = "Жанр:";
      // 
      // genreField
      // 
      this.genreField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.genreField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.genreField.Location = new System.Drawing.Point(86, 277);
      this.genreField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.genreField.Name = "genreField";
      this.genreField.Size = new System.Drawing.Size(572, 39);
      this.genreField.TabIndex = 3;
      // 
      // authorLabel
      // 
      this.authorLabel.AutoSize = true;
      this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.authorLabel.Location = new System.Drawing.Point(6, 227);
      this.authorLabel.Name = "authorLabel";
      this.authorLabel.Size = new System.Drawing.Size(85, 32);
      this.authorLabel.TabIndex = 21;
      this.authorLabel.Text = "Автор:";
      // 
      // authorField
      // 
      this.authorField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.authorField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.authorField.FormattingEnabled = true;
      this.authorField.Location = new System.Drawing.Point(86, 223);
      this.authorField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.authorField.Name = "authorField";
      this.authorField.Size = new System.Drawing.Size(572, 40);
      this.authorField.TabIndex = 22;
      // 
      // priceLabel
      // 
      this.priceLabel.AutoSize = true;
      this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.priceLabel.Location = new System.Drawing.Point(6, 333);
      this.priceLabel.Name = "priceLabel";
      this.priceLabel.Size = new System.Drawing.Size(197, 32);
      this.priceLabel.TabIndex = 23;
      this.priceLabel.Text = "Стоимость (руб):";
      // 
      // priceField
      // 
      this.priceField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.priceField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.priceField.Location = new System.Drawing.Point(192, 329);
      this.priceField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.priceField.Name = "priceField";
      this.priceField.Size = new System.Drawing.Size(466, 39);
      this.priceField.TabIndex = 24;
      // 
      // numberOfPagesField
      // 
      this.numberOfPagesField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.numberOfPagesField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.numberOfPagesField.Location = new System.Drawing.Point(184, 381);
      this.numberOfPagesField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.numberOfPagesField.Name = "numberOfPagesField";
      this.numberOfPagesField.Size = new System.Drawing.Size(474, 39);
      this.numberOfPagesField.TabIndex = 26;
      // 
      // numberOfPagesLabel
      // 
      this.numberOfPagesLabel.AutoSize = true;
      this.numberOfPagesLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.numberOfPagesLabel.Location = new System.Drawing.Point(6, 385);
      this.numberOfPagesLabel.Name = "numberOfPagesLabel";
      this.numberOfPagesLabel.Size = new System.Drawing.Size(193, 32);
      this.numberOfPagesLabel.TabIndex = 25;
      this.numberOfPagesLabel.Text = "Кол-во страниц:";
      // 
      // typeOfBindingField
      // 
      this.typeOfBindingField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.typeOfBindingField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.typeOfBindingField.Location = new System.Drawing.Point(177, 433);
      this.typeOfBindingField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.typeOfBindingField.Name = "typeOfBindingField";
      this.typeOfBindingField.Size = new System.Drawing.Size(481, 39);
      this.typeOfBindingField.TabIndex = 28;
      // 
      // typeOfBindingLabel
      // 
      this.typeOfBindingLabel.AutoSize = true;
      this.typeOfBindingLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.typeOfBindingLabel.Location = new System.Drawing.Point(6, 437);
      this.typeOfBindingLabel.Name = "typeOfBindingLabel";
      this.typeOfBindingLabel.Size = new System.Drawing.Size(183, 32);
      this.typeOfBindingLabel.TabIndex = 27;
      this.typeOfBindingLabel.Text = "Тип переплета:";
      // 
      // annotationField
      // 
      this.annotationField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.annotationField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.annotationField.Location = new System.Drawing.Point(139, 485);
      this.annotationField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.annotationField.Name = "annotationField";
      this.annotationField.Size = new System.Drawing.Size(518, 39);
      this.annotationField.TabIndex = 30;
      // 
      // annotationLabel
      // 
      this.annotationLabel.AutoSize = true;
      this.annotationLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.annotationLabel.Location = new System.Drawing.Point(6, 489);
      this.annotationLabel.Name = "annotationLabel";
      this.annotationLabel.Size = new System.Drawing.Size(138, 32);
      this.annotationLabel.TabIndex = 29;
      this.annotationLabel.Text = "Аннотация:";
      // 
      // storageField
      // 
      this.storageField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.storageField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.storageField.FormattingEnabled = true;
      this.storageField.Location = new System.Drawing.Point(115, 537);
      this.storageField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.storageField.Name = "storageField";
      this.storageField.Size = new System.Drawing.Size(542, 40);
      this.storageField.TabIndex = 32;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(6, 541);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(113, 32);
      this.label1.TabIndex = 31;
      this.label1.Text = "Магазин:";
      // 
      // publishingHouseField
      // 
      this.publishingHouseField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.publishingHouseField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.publishingHouseField.FormattingEnabled = true;
      this.publishingHouseField.Location = new System.Drawing.Point(166, 589);
      this.publishingHouseField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.publishingHouseField.Name = "publishingHouseField";
      this.publishingHouseField.Size = new System.Drawing.Size(492, 40);
      this.publishingHouseField.TabIndex = 34;
      // 
      // publishingHouseLabel
      // 
      this.publishingHouseLabel.AutoSize = true;
      this.publishingHouseLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.publishingHouseLabel.Location = new System.Drawing.Point(6, 593);
      this.publishingHouseLabel.Name = "publishingHouseLabel";
      this.publishingHouseLabel.Size = new System.Drawing.Size(169, 32);
      this.publishingHouseLabel.TabIndex = 33;
      this.publishingHouseLabel.Text = "Издательство:";
      // 
      // writingYearField
      // 
      this.writingYearField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.writingYearField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.writingYearField.Location = new System.Drawing.Point(177, 641);
      this.writingYearField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.writingYearField.Name = "writingYearField";
      this.writingYearField.Size = new System.Drawing.Size(481, 39);
      this.writingYearField.TabIndex = 36;
      // 
      // writingYearLabel
      // 
      this.writingYearLabel.AutoSize = true;
      this.writingYearLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.writingYearLabel.Location = new System.Drawing.Point(6, 645);
      this.writingYearLabel.Name = "writingYearLabel";
      this.writingYearLabel.Size = new System.Drawing.Size(181, 32);
      this.writingYearLabel.TabIndex = 35;
      this.writingYearLabel.Text = "Год написания:";
      // 
      // photoLabel
      // 
      this.photoLabel.AutoSize = true;
      this.photoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.photoLabel.Location = new System.Drawing.Point(6, 700);
      this.photoLabel.Name = "photoLabel";
      this.photoLabel.Size = new System.Drawing.Size(151, 32);
      this.photoLabel.TabIndex = 37;
      this.photoLabel.Text = "Фотография:";
      // 
      // photoButton
      // 
      this.photoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.photoButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.photoButton.Location = new System.Drawing.Point(152, 693);
      this.photoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.photoButton.Name = "photoButton";
      this.photoButton.Size = new System.Drawing.Size(506, 47);
      this.photoButton.TabIndex = 38;
      this.photoButton.Text = "Загрузить фотографию";
      this.photoButton.UseVisualStyleBackColor = true;
      this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
      // 
      // submit
      // 
      this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.submit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.submit.Location = new System.Drawing.Point(14, 799);
      this.submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.submit.Name = "submit";
      this.submit.Size = new System.Drawing.Size(645, 47);
      this.submit.TabIndex = 39;
      this.submit.Text = "Загрузить книгу\r\n";
      this.submit.UseVisualStyleBackColor = true;
      this.submit.Click += new System.EventHandler(this.submit_Click);
      // 
      // errorLabel
      // 
      this.errorLabel.AutoSize = true;
      this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.errorLabel.ForeColor = System.Drawing.Color.Firebrick;
      this.errorLabel.Location = new System.Drawing.Point(14, 128);
      this.errorLabel.Name = "errorLabel";
      this.errorLabel.Size = new System.Drawing.Size(0, 32);
      this.errorLabel.TabIndex = 40;
      // 
      // addBookForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(672, 861);
      this.Controls.Add(this.errorLabel);
      this.Controls.Add(this.submit);
      this.Controls.Add(this.photoButton);
      this.Controls.Add(this.photoLabel);
      this.Controls.Add(this.writingYearField);
      this.Controls.Add(this.writingYearLabel);
      this.Controls.Add(this.publishingHouseField);
      this.Controls.Add(this.publishingHouseLabel);
      this.Controls.Add(this.storageField);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.annotationField);
      this.Controls.Add(this.annotationLabel);
      this.Controls.Add(this.typeOfBindingField);
      this.Controls.Add(this.typeOfBindingLabel);
      this.Controls.Add(this.numberOfPagesField);
      this.Controls.Add(this.numberOfPagesLabel);
      this.Controls.Add(this.priceField);
      this.Controls.Add(this.priceLabel);
      this.Controls.Add(this.authorField);
      this.Controls.Add(this.authorLabel);
      this.Controls.Add(this.genreField);
      this.Controls.Add(this.genreLabel);
      this.Controls.Add(this.titleField);
      this.Controls.Add(this.titleLabel);
      this.Controls.Add(this.prev);
      this.Controls.Add(this.title);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "addBookForm";
      this.Text = "Добавление книги";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addBookForm_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Label title;
        private Button prev;
        private Label titleLabel;
        private TextBox titleField;
        private Label genreLabel;
        private TextBox genreField;
        private Label authorLabel;
        private ComboBox authorField;
        private Label priceLabel;
        private TextBox priceField;
        private TextBox numberOfPagesField;
        private Label numberOfPagesLabel;
        private TextBox typeOfBindingField;
        private Label typeOfBindingLabel;
        private TextBox annotationField;
        private Label annotationLabel;
        private ComboBox storageField;
        private Label label1;
        private ComboBox publishingHouseField;
        private Label publishingHouseLabel;
        private TextBox writingYearField;
        private Label writingYearLabel;
        private Label photoLabel;
        private Button photoButton;
        private Button submit;
        private Label errorLabel;
    }
}