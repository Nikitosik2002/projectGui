namespace BooksApp
{
  partial class catalogForm
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
      this.dgv = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.cartButton = new System.Windows.Forms.Button();
      this.lowPrice = new System.Windows.Forms.Label();
      this.ordersButton = new System.Windows.Forms.Button();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.number_of_pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.year_of_writing = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.publisher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
      this.SuspendLayout();
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
      this.dgv.Location = new System.Drawing.Point(12, 57);
      this.dgv.Name = "dgv";
      this.dgv.ReadOnly = true;
      this.dgv.RowHeadersWidth = 60;
      this.dgv.RowTemplate.Height = 25;
      this.dgv.Size = new System.Drawing.Size(1372, 366);
      this.dgv.TabIndex = 0;
      this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(13, 9);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(206, 45);
      this.label1.TabIndex = 1;
      this.label1.Text = "Каталог книг";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cartButton
      // 
      this.cartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.cartButton.Location = new System.Drawing.Point(1177, 22);
      this.cartButton.Name = "cartButton";
      this.cartButton.Size = new System.Drawing.Size(207, 29);
      this.cartButton.TabIndex = 2;
      this.cartButton.Text = "Перейти в корзину";
      this.cartButton.UseVisualStyleBackColor = true;
      this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
      // 
      // lowPrice
      // 
      this.lowPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lowPrice.AutoSize = true;
      this.lowPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lowPrice.Location = new System.Drawing.Point(13, 426);
      this.lowPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lowPrice.Name = "lowPrice";
      this.lowPrice.Size = new System.Drawing.Size(404, 30);
      this.lowPrice.TabIndex = 3;
      this.lowPrice.Text = "Самая дешевая книга у нас стоит всего: ";
      this.lowPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ordersButton
      // 
      this.ordersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ordersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ordersButton.Location = new System.Drawing.Point(964, 22);
      this.ordersButton.Name = "ordersButton";
      this.ordersButton.Size = new System.Drawing.Size(207, 29);
      this.ordersButton.TabIndex = 4;
      this.ordersButton.Text = "Перейти к заказам";
      this.ordersButton.UseVisualStyleBackColor = true;
      this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
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
      // catalogForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1396, 467);
      this.Controls.Add(this.ordersButton);
      this.Controls.Add(this.lowPrice);
      this.Controls.Add(this.cartButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgv);
      this.Name = "catalogForm";
      this.Text = "Каталог книг";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.catalogForm_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private DataGridView dgv;
        private Label label1;
        private Button cartButton;
        private Label lowPrice;
        private Button ordersButton;
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