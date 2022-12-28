using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BooksApp
{
  public partial class addBookForm : Form
  {
    String directory = "C:\\Users\\nikit\\source\\repos\\BooksApp";
    String imageLocation;
    String image;
    DB db = new DB();

    public addBookForm()
    {
      InitializeComponent();
      var authors = db.get_authors();
      foreach (var author in authors)
        authorField.Items.Add(author["full_name"]);
      var storages = db.get_storages();
      foreach (var storage in storages)
        storageField.Items.Add(storage["address"]);
      var publishingHouses = db.get_publishing_houses();
      foreach (var publishingHouse in publishingHouses)
        publishingHouseField.Items.Add(publishingHouse["publisher_name"]);
    }

    private void prev_Click(object sender, EventArgs e)
    {
      new employeeForm().Show();
      Hide();
    }

    private void addBookForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void photoButton_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "jpg files|*.jpg| PNG files|*.png" })
      {
        if (ofd.ShowDialog() == DialogResult.OK)
        {
          imageLocation = ofd.FileName;
          image = ofd.SafeFileName;
          photoButton.Text = "Фотография выбрана";
          photoButton.Enabled = false;
        }
      }
    }

    private void submit_Click(object sender, EventArgs e)
    {
      errorLabel.Text = "";
      if (titleField.Text.Length == 0) errorLabel.Text = "Название произведения не может быть пустым";
      else if (authorField.Text.Length == 0) errorLabel.Text = "Выберите автора произведения";
      else if (genreField.Text.Length == 0) errorLabel.Text = "Выберите жанр произведения";
      else if (priceField.Text.Length == 0) errorLabel.Text = "Стоимость книги не может быть пустой";
      else if (numberOfPagesField.Text.Length == 0) errorLabel.Text = "Кол-во страниц книги не может быть пустым";
      else if (typeOfBindingField.Text.Length == 0) errorLabel.Text = "Тип переплета книги не может быть пустым";
      else if (annotationField.Text.Length == 0) errorLabel.Text = "Аннотация не может быть пустой";
      else if (storageField.Text.Length == 0) errorLabel.Text = "Выберите магазин";
      else if (publishingHouseField.Text.Length == 0) errorLabel.Text = "Выберите издтательство произвдеения";
      else if (writingYearField.Text.Length == 0) errorLabel.Text = "Введите год написания произведения";
      if (errorLabel.Text.Length != 0) return;
      if (imageLocation.Length != 0)
        File.Copy(imageLocation, directory + @"/images/" + image);
      db.add_book(titleField.Text, authorField.Text, genreField.Text, priceField.Text, numberOfPagesField.Text,
        typeOfBindingField.Text, annotationField.Text, storageField.Text, publishingHouseField.Text,
        writingYearField.Text, image);
      Glob.showSuccessMessage("Книга успешно добавлена");
      new employeeForm().Show();
      Hide();
    }
  }
}
