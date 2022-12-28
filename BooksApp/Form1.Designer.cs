namespace BooksApp
{
  partial class authForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.title = new System.Windows.Forms.Label();
      this.subtitle = new System.Windows.Forms.Label();
      this.loginField = new System.Windows.Forms.TextBox();
      this.loginLabel = new System.Windows.Forms.Label();
      this.pswdLabel = new System.Windows.Forms.Label();
      this.pswdField = new System.Windows.Forms.TextBox();
      this.submit = new System.Windows.Forms.Button();
      this.registerlabel = new System.Windows.Forms.Label();
      this.registerButton = new System.Windows.Forms.Button();
      this.errorLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // title
      // 
      this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.title.AutoSize = true;
      this.title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.title.Location = new System.Drawing.Point(78, 9);
      this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.title.Name = "title";
      this.title.Size = new System.Drawing.Size(286, 45);
      this.title.TabIndex = 0;
      this.title.Text = "Книжный магазин";
      this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // subtitle
      // 
      this.subtitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.subtitle.AutoSize = true;
      this.subtitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.subtitle.Location = new System.Drawing.Point(124, 54);
      this.subtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.subtitle.Name = "subtitle";
      this.subtitle.Size = new System.Drawing.Size(181, 32);
      this.subtitle.TabIndex = 1;
      this.subtitle.Text = "Вход в систему";
      this.subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // loginField
      // 
      this.loginField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.loginField.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.loginField.Location = new System.Drawing.Point(12, 170);
      this.loginField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.loginField.Name = "loginField";
      this.loginField.Size = new System.Drawing.Size(423, 32);
      this.loginField.TabIndex = 2;
      // 
      // loginLabel
      // 
      this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.loginLabel.AutoSize = true;
      this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.loginLabel.Location = new System.Drawing.Point(12, 138);
      this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.loginLabel.Name = "loginLabel";
      this.loginLabel.Size = new System.Drawing.Size(69, 25);
      this.loginLabel.TabIndex = 3;
      this.loginLabel.Text = "Логин:";
      this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pswdLabel
      // 
      this.pswdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.pswdLabel.AutoSize = true;
      this.pswdLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.pswdLabel.Location = new System.Drawing.Point(12, 205);
      this.pswdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.pswdLabel.Name = "pswdLabel";
      this.pswdLabel.Size = new System.Drawing.Size(82, 25);
      this.pswdLabel.TabIndex = 5;
      this.pswdLabel.Text = "Пароль:";
      this.pswdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pswdField
      // 
      this.pswdField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.pswdField.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.pswdField.Location = new System.Drawing.Point(12, 237);
      this.pswdField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.pswdField.Name = "pswdField";
      this.pswdField.PasswordChar = '*';
      this.pswdField.Size = new System.Drawing.Size(423, 32);
      this.pswdField.TabIndex = 4;
      // 
      // submit
      // 
      this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.submit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.submit.Location = new System.Drawing.Point(12, 273);
      this.submit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.submit.Name = "submit";
      this.submit.Size = new System.Drawing.Size(423, 43);
      this.submit.TabIndex = 6;
      this.submit.Text = "Войти";
      this.submit.UseVisualStyleBackColor = true;
      this.submit.Click += new System.EventHandler(this.submit_Click);
      // 
      // registerlabel
      // 
      this.registerlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.registerlabel.AutoSize = true;
      this.registerlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.registerlabel.Location = new System.Drawing.Point(12, 345);
      this.registerlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.registerlabel.Name = "registerlabel";
      this.registerlabel.Size = new System.Drawing.Size(111, 21);
      this.registerlabel.TabIndex = 7;
      this.registerlabel.Text = "Нет аккаунта?";
      this.registerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // registerButton
      // 
      this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.registerButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.registerButton.Location = new System.Drawing.Point(12, 372);
      this.registerButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.registerButton.Name = "registerButton";
      this.registerButton.Size = new System.Drawing.Size(423, 43);
      this.registerButton.TabIndex = 8;
      this.registerButton.Text = "Зарегистрироваться";
      this.registerButton.UseVisualStyleBackColor = true;
      this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
      // 
      // errorLabel
      // 
      this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.errorLabel.AutoSize = true;
      this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.errorLabel.ForeColor = System.Drawing.Color.OrangeRed;
      this.errorLabel.Location = new System.Drawing.Point(12, 102);
      this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.errorLabel.Name = "errorLabel";
      this.errorLabel.Size = new System.Drawing.Size(0, 25);
      this.errorLabel.TabIndex = 9;
      this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // authForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(447, 435);
      this.Controls.Add(this.errorLabel);
      this.Controls.Add(this.registerButton);
      this.Controls.Add(this.registerlabel);
      this.Controls.Add(this.submit);
      this.Controls.Add(this.pswdLabel);
      this.Controls.Add(this.pswdField);
      this.Controls.Add(this.loginLabel);
      this.Controls.Add(this.loginField);
      this.Controls.Add(this.subtitle);
      this.Controls.Add(this.title);
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "authForm";
      this.Text = "Вход в систему";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Label title;
        private Label subtitle;
        private TextBox loginField;
        private Label loginLabel;
        private Label pswdLabel;
        private TextBox pswdField;
        private Button submit;
        private Label registerlabel;
        private Button registerButton;
        private Label errorLabel;
    }
}