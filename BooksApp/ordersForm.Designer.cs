namespace BooksApp
{
  partial class ordersForm
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
      this.dgv = new System.Windows.Forms.DataGridView();
      this.prev = new System.Windows.Forms.Button();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
      this.SuspendLayout();
      // 
      // title
      // 
      this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.title.AutoSize = true;
      this.title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.title.Location = new System.Drawing.Point(388, 9);
      this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.title.Name = "title";
      this.title.Size = new System.Drawing.Size(195, 45);
      this.title.TabIndex = 2;
      this.title.Text = "Мои заказы";
      this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dgv
      // 
      this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
      this.dgv.Location = new System.Drawing.Point(12, 89);
      this.dgv.Name = "dgv";
      this.dgv.ReadOnly = true;
      this.dgv.RowTemplate.Height = 25;
      this.dgv.Size = new System.Drawing.Size(957, 223);
      this.dgv.TabIndex = 3;
      this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
      // 
      // prev
      // 
      this.prev.Location = new System.Drawing.Point(12, 56);
      this.prev.Name = "prev";
      this.prev.Size = new System.Drawing.Size(136, 27);
      this.prev.TabIndex = 16;
      this.prev.Text = "< Вернуться назад";
      this.prev.UseVisualStyleBackColor = true;
      this.prev.Click += new System.EventHandler(this.prev_Click);
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Номер заказа";
      this.Column1.Name = "Column1";
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Номер заказа";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 90;
      // 
      // Column3
      // 
      this.Column3.HeaderText = "Дата оформления";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.Width = 170;
      // 
      // Column6
      // 
      this.Column6.HeaderText = "Магазин";
      this.Column6.Name = "Column6";
      this.Column6.ReadOnly = true;
      this.Column6.Width = 260;
      // 
      // Column4
      // 
      this.Column4.HeaderText = "Сумма заказа";
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.Width = 170;
      // 
      // Column5
      // 
      this.Column5.HeaderText = "Статус";
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column5.Width = 170;
      // 
      // ordersForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(981, 324);
      this.Controls.Add(this.prev);
      this.Controls.Add(this.dgv);
      this.Controls.Add(this.title);
      this.Name = "ordersForm";
      this.Text = "ordersForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ordersForm_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Label title;
        private DataGridView dgv;
        private Button prev;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}