namespace BooksApp
{
  partial class registerForm
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
      this.subtitle = new System.Windows.Forms.Label();
      this.fullnameLabel = new System.Windows.Forms.Label();
      this.fullnameField = new System.Windows.Forms.TextBox();
      this.phoneLabel = new System.Windows.Forms.Label();
      this.phoneField = new System.Windows.Forms.TextBox();
      this.emailLabel = new System.Windows.Forms.Label();
      this.emailField = new System.Windows.Forms.TextBox();
      this.loginLabel = new System.Windows.Forms.Label();
      this.loginField = new System.Windows.Forms.TextBox();
      this.pswdLabel = new System.Windows.Forms.Label();
      this.pswdField = new System.Windows.Forms.TextBox();
      this.ageLabel = new System.Windows.Forms.Label();
      this.ageField = new System.Windows.Forms.TextBox();
      this.submit = new System.Windows.Forms.Button();
      this.errorLabel = new System.Windows.Forms.Label();
      this.repeatPswdField = new System.Windows.Forms.TextBox();
      this.repeatPswdLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // title
      // 
      this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.title.AutoSize = true;
      this.title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.title.Location = new System.Drawing.Point(184, 12);
      this.title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.title.Name = "title";
      this.title.Size = new System.Drawing.Size(354, 54);
      this.title.TabIndex = 1;
      this.title.Text = "Книжный магазин";
      this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // subtitle
      // 
      this.subtitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.subtitle.AutoSize = true;
      this.subtitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.subtitle.Location = new System.Drawing.Point(257, 72);
      this.subtitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.subtitle.Name = "subtitle";
      this.subtitle.Size = new System.Drawing.Size(188, 41);
      this.subtitle.TabIndex = 2;
      this.subtitle.Text = "Регистрация";
      this.subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // fullnameLabel
      // 
      this.fullnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.fullnameLabel.AutoSize = true;
      this.fullnameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.fullnameLabel.Location = new System.Drawing.Point(15, 233);
      this.fullnameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.fullnameLabel.Name = "fullnameLabel";
      this.fullnameLabel.Size = new System.Drawing.Size(72, 32);
      this.fullnameLabel.TabIndex = 5;
      this.fullnameLabel.Text = "ФИО:";
      this.fullnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // fullnameField
      // 
      this.fullnameField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.fullnameField.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.fullnameField.Location = new System.Drawing.Point(90, 229);
      this.fullnameField.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.fullnameField.Name = "fullnameField";
      this.fullnameField.Size = new System.Drawing.Size(540, 39);
      this.fullnameField.TabIndex = 1;
      // 
      // phoneLabel
      // 
      this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.phoneLabel.AutoSize = true;
      this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.phoneLabel.Location = new System.Drawing.Point(15, 284);
      this.phoneLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.phoneLabel.Name = "phoneLabel";
      this.phoneLabel.Size = new System.Drawing.Size(115, 32);
      this.phoneLabel.TabIndex = 7;
      this.phoneLabel.Text = "Телефон:";
      this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // phoneField
      // 
      this.phoneField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.phoneField.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.phoneField.Location = new System.Drawing.Point(128, 280);
      this.phoneField.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.phoneField.Name = "phoneField";
      this.phoneField.Size = new System.Drawing.Size(502, 39);
      this.phoneField.TabIndex = 2;
      // 
      // emailLabel
      // 
      this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.emailLabel.AutoSize = true;
      this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.emailLabel.Location = new System.Drawing.Point(15, 385);
      this.emailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new System.Drawing.Size(87, 32);
      this.emailLabel.TabIndex = 10;
      this.emailLabel.Text = "E-Mail:";
      this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // emailField
      // 
      this.emailField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.emailField.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.emailField.Location = new System.Drawing.Point(105, 381);
      this.emailField.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.emailField.Name = "emailField";
      this.emailField.Size = new System.Drawing.Size(525, 39);
      this.emailField.TabIndex = 4;
      // 
      // loginLabel
      // 
      this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.loginLabel.AutoSize = true;
      this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.loginLabel.Location = new System.Drawing.Point(15, 436);
      this.loginLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.loginLabel.Name = "loginLabel";
      this.loginLabel.Size = new System.Drawing.Size(86, 32);
      this.loginLabel.TabIndex = 12;
      this.loginLabel.Text = "Логин:";
      this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // loginField
      // 
      this.loginField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.loginField.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.loginField.Location = new System.Drawing.Point(103, 432);
      this.loginField.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.loginField.Name = "loginField";
      this.loginField.Size = new System.Drawing.Size(527, 39);
      this.loginField.TabIndex = 5;
      // 
      // pswdLabel
      // 
      this.pswdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.pswdLabel.AutoSize = true;
      this.pswdLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.pswdLabel.Location = new System.Drawing.Point(15, 487);
      this.pswdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.pswdLabel.Name = "pswdLabel";
      this.pswdLabel.Size = new System.Drawing.Size(101, 32);
      this.pswdLabel.TabIndex = 14;
      this.pswdLabel.Text = "Пароль:";
      this.pswdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pswdField
      // 
      this.pswdField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.pswdField.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.pswdField.Location = new System.Drawing.Point(118, 483);
      this.pswdField.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.pswdField.Name = "pswdField";
      this.pswdField.Size = new System.Drawing.Size(513, 39);
      this.pswdField.TabIndex = 6;
      // 
      // ageLabel
      // 
      this.ageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.ageLabel.AutoSize = true;
      this.ageLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ageLabel.Location = new System.Drawing.Point(15, 335);
      this.ageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.ageLabel.Name = "ageLabel";
      this.ageLabel.Size = new System.Drawing.Size(105, 32);
      this.ageLabel.TabIndex = 16;
      this.ageLabel.Text = "Возраст:";
      this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ageField
      // 
      this.ageField.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.ageField.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ageField.Location = new System.Drawing.Point(128, 331);
      this.ageField.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.ageField.Name = "ageField";
      this.ageField.Size = new System.Drawing.Size(63, 39);
      this.ageField.TabIndex = 3;
      // 
      // submit
      // 
      this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.submit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.submit.Location = new System.Drawing.Point(15, 600);
      this.submit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.submit.Name = "submit";
      this.submit.Size = new System.Drawing.Size(616, 57);
      this.submit.TabIndex = 8;
      this.submit.Text = "Зарегистрироваться";
      this.submit.UseVisualStyleBackColor = true;
      this.submit.Click += new System.EventHandler(this.submit_Click);
      // 
      // errorLabel
      // 
      this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.errorLabel.AutoSize = true;
      this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.errorLabel.ForeColor = System.Drawing.Color.OrangeRed;
      this.errorLabel.Location = new System.Drawing.Point(15, 168);
      this.errorLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.errorLabel.Name = "errorLabel";
      this.errorLabel.Size = new System.Drawing.Size(0, 32);
      this.errorLabel.TabIndex = 18;
      this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // repeatPswdField
      // 
      this.repeatPswdField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.repeatPswdField.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.repeatPswdField.Location = new System.Drawing.Point(227, 533);
      this.repeatPswdField.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
      this.repeatPswdField.Name = "repeatPswdField";
      this.repeatPswdField.Size = new System.Drawing.Size(403, 39);
      this.repeatPswdField.TabIndex = 7;
      // 
      // repeatPswdLabel
      // 
      this.repeatPswdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.repeatPswdLabel.AutoSize = true;
      this.repeatPswdLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.repeatPswdLabel.Location = new System.Drawing.Point(15, 537);
      this.repeatPswdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.repeatPswdLabel.Name = "repeatPswdLabel";
      this.repeatPswdLabel.Size = new System.Drawing.Size(224, 32);
      this.repeatPswdLabel.TabIndex = 20;
      this.repeatPswdLabel.Text = "Повторите пароль:";
      this.repeatPswdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // registerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(646, 671);
      this.Controls.Add(this.repeatPswdField);
      this.Controls.Add(this.repeatPswdLabel);
      this.Controls.Add(this.errorLabel);
      this.Controls.Add(this.submit);
      this.Controls.Add(this.ageField);
      this.Controls.Add(this.ageLabel);
      this.Controls.Add(this.pswdField);
      this.Controls.Add(this.pswdLabel);
      this.Controls.Add(this.loginField);
      this.Controls.Add(this.loginLabel);
      this.Controls.Add(this.emailField);
      this.Controls.Add(this.emailLabel);
      this.Controls.Add(this.phoneLabel);
      this.Controls.Add(this.phoneField);
      this.Controls.Add(this.fullnameLabel);
      this.Controls.Add(this.fullnameField);
      this.Controls.Add(this.subtitle);
      this.Controls.Add(this.title);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "registerForm";
      this.Text = "Регистрация";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.registerForm_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Label title;
        private Label subtitle;
        private Label fullnameLabel;
        private TextBox fullnameField;
        private Label phoneLabel;
        private TextBox phoneField;
        private Label emailLabel;
        private TextBox emailField;
        private Label loginLabel;
        private TextBox loginField;
        private Label pswdLabel;
        private TextBox pswdField;
        private Label ageLabel;
        private TextBox ageField;
        private Button submit;
        private Label errorLabel;
        private TextBox repeatPswdField;
        private Label repeatPswdLabel;
    }
}