using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksApp
{
  public partial class registerForm : Form
  {
    DB db = new DB();

    public registerForm()
    {
      InitializeComponent();
    }

    private void registerForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void submit_Click(object sender, EventArgs e)
    {
      errorLabel.Text = "";
      if (fullnameField.Text.Length == 0 || fullnameField.Text.Split(" ").Length != 3)
        errorLabel.Text = "Введите ФИО в формате (Фамилия Имя Отчество)";
      else if (phoneField.Text.Length < 11) errorLabel.Text = "Номер телефона введен неверно";
      else if (ageField.Text.Length == 0) errorLabel.Text = "Заполните поле возраст";
      else if (emailField.Text.Length == 0) errorLabel.Text = "Заполните поле EMail";
      else if (loginField.Text.Length == 0) errorLabel.Text = "Заполните поле логин";
      else if (pswdField.Text.Length == 0) errorLabel.Text = "Заполните поле пароль";
      else if (repeatPswdField.Text.Length == 0) errorLabel.Text = "Заполните поле повторного пароля";
      else if (pswdField.Text.CompareTo(repeatPswdField.Text) != 0) errorLabel.Text = "Пароли не совпадают";
      var user = db.get_user_by_login(loginField.Text);
      if (user.Count != 0)
        errorLabel.Text = "Пользователь с таким логином уже существует";
      if (errorLabel.Text.Length > 0) return;
      var pswd = db.sha256(pswdField.Text);
      db.register_user(fullnameField.Text, phoneField.Text, emailField.Text,
                      ageField.Text, loginField.Text, pswd);
      Glob.user = db.get_user_by_login(loginField.Text);
      new catalogForm().Show();
      Hide();
    }
  }
}
