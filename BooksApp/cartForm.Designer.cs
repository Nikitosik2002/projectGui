namespace BooksApp
{
  partial class cartForm
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
      this.cartList = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.prev = new System.Windows.Forms.Button();
      this.storageLabel = new System.Windows.Forms.Label();
      this.storageList = new System.Windows.Forms.ComboBox();
      this.totalPriceLabel = new System.Windows.Forms.Label();
      this.totalPrice = new System.Windows.Forms.Label();
      this.submit = new System.Windows.Forms.Button();
      this.customerLabel = new System.Windows.Forms.Label();
      this.customer = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.cartList)).BeginInit();
      this.SuspendLayout();
      // 
      // title
      // 
      this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.title.AutoSize = true;
      this.title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.title.Location = new System.Drawing.Point(371, 12);
      this.title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.title.Name = "title";
      this.title.Size = new System.Drawing.Size(177, 54);
      this.title.TabIndex = 2;
      this.title.Text = "Корзина";
      this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cartList
      // 
      this.cartList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.cartList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
      this.cartList.Location = new System.Drawing.Point(14, 120);
      this.cartList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.cartList.Name = "cartList";
      this.cartList.ReadOnly = true;
      this.cartList.RowHeadersWidth = 51;
      this.cartList.RowTemplate.Height = 25;
      this.cartList.Size = new System.Drawing.Size(874, 203);
      this.cartList.TabIndex = 3;
      this.cartList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartList_CellContentClick);
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Название";
      this.Column1.MinimumWidth = 6;
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Width = 170;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Автор";
      this.Column2.MinimumWidth = 6;
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 170;
      // 
      // Column3
      // 
      this.Column3.HeaderText = "Стоимость (руб)";
      this.Column3.MinimumWidth = 6;
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Width = 125;
      // 
      // Column4
      // 
      this.Column4.HeaderText = "Количество";
      this.Column4.MinimumWidth = 6;
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Width = 125;
      // 
      // Column5
      // 
      this.Column5.HeaderText = "Всего";
      this.Column5.MinimumWidth = 6;
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column5.Width = 125;
      // 
      // prev
      // 
      this.prev.Location = new System.Drawing.Point(14, 76);
      this.prev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.prev.Name = "prev";
      this.prev.Size = new System.Drawing.Size(203, 36);
      this.prev.TabIndex = 4;
      this.prev.Text = "< Вернуться назад";
      this.prev.UseVisualStyleBackColor = true;
      this.prev.Click += new System.EventHandler(this.prev_Click);
      // 
      // storageLabel
      // 
      this.storageLabel.AutoSize = true;
      this.storageLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.storageLabel.Location = new System.Drawing.Point(14, 331);
      this.storageLabel.Name = "storageLabel";
      this.storageLabel.Size = new System.Drawing.Size(246, 32);
      this.storageLabel.TabIndex = 5;
      this.storageLabel.Text = "Забрать из магазина:";
      // 
      // storageList
      // 
      this.storageList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.storageList.FormattingEnabled = true;
      this.storageList.Location = new System.Drawing.Point(253, 333);
      this.storageList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.storageList.Name = "storageList";
      this.storageList.Size = new System.Drawing.Size(634, 28);
      this.storageList.TabIndex = 6;
      this.storageList.SelectedIndexChanged += new System.EventHandler(this.storageList_SelectedIndexChanged);
      // 
      // totalPriceLabel
      // 
      this.totalPriceLabel.AutoSize = true;
      this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.totalPriceLabel.Location = new System.Drawing.Point(14, 364);
      this.totalPriceLabel.Name = "totalPriceLabel";
      this.totalPriceLabel.Size = new System.Drawing.Size(213, 32);
      this.totalPriceLabel.TabIndex = 7;
      this.totalPriceLabel.Text = "Стоимость заказа:";
      // 
      // totalPrice
      // 
      this.totalPrice.AutoSize = true;
      this.totalPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.totalPrice.Location = new System.Drawing.Point(214, 364);
      this.totalPrice.Name = "totalPrice";
      this.totalPrice.Size = new System.Drawing.Size(54, 32);
      this.totalPrice.TabIndex = 8;
      this.totalPrice.Text = "руб";
      // 
      // submit
      // 
      this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.submit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.submit.Location = new System.Drawing.Point(14, 472);
      this.submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.submit.Name = "submit";
      this.submit.Size = new System.Drawing.Size(874, 52);
      this.submit.TabIndex = 9;
      this.submit.Text = "Оформить заказ";
      this.submit.UseVisualStyleBackColor = true;
      this.submit.Click += new System.EventHandler(this.submit_Click);
      // 
      // customerLabel
      // 
      this.customerLabel.AutoSize = true;
      this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.customerLabel.Location = new System.Drawing.Point(14, 397);
      this.customerLabel.Name = "customerLabel";
      this.customerLabel.Size = new System.Drawing.Size(119, 32);
      this.customerLabel.TabIndex = 10;
      this.customerLabel.Text = "Заказчик:";
      // 
      // customer
      // 
      this.customer.AutoSize = true;
      this.customer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.customer.Location = new System.Drawing.Point(128, 397);
      this.customer.Name = "customer";
      this.customer.Size = new System.Drawing.Size(67, 32);
      this.customer.TabIndex = 11;
      this.customer.Text = "ФИО";
      // 
      // cartForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(902, 540);
      this.Controls.Add(this.customer);
      this.Controls.Add(this.customerLabel);
      this.Controls.Add(this.submit);
      this.Controls.Add(this.totalPrice);
      this.Controls.Add(this.totalPriceLabel);
      this.Controls.Add(this.storageList);
      this.Controls.Add(this.storageLabel);
      this.Controls.Add(this.prev);
      this.Controls.Add(this.cartList);
      this.Controls.Add(this.title);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "cartForm";
      this.Text = "cartForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cartForm_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.cartList)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Label title;
        private DataGridView cartList;
        private Button prev;
        private Label storageLabel;
        private ComboBox storageList;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
    private Label totalPriceLabel;
    private Label totalPrice;
    private Button submit;
        private Label customerLabel;
        private Label customer;
    }
}