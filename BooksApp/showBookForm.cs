using Microsoft.VisualBasic.ApplicationServices;
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
  public partial class showBookForm : Form
  {
    String directory = "C:\\Users\\nikit\\source\\repos\\BooksApp";
    Dictionary<string, string> book;
    public showBookForm(Dictionary<string, string> book)
    {
      this.book = book;
      InitializeComponent();
      this.Text = title.Text = book["title"];
      author.Text = "Автор: " + book["author_name"];
      genre.Text = "Жанр: " + book["genre"];
      number_of_pages.Text = "Количество страниц: " + book["number_of_pages"];
      type_of_binding.Text = "Переплет: " + book["type_of_binding"];
      annotation.Text = book["annotation"];
      year_of_writing.Text = "Год написания: " + book["year_of_writing"];
      publisher_name.Text = "Издательство: " + book["publisher_name"];
      publisher_city.Text = "Город: " + book["publisher_city"];
      publisher_phone.Text = "Телефон: " + book["publisher_phone"];
      publisher_about.Text = "Описание: " + book["publisher_about"];
      price.Text = "Стоимость: " + book["price"] + " рублей";
      authorBiography.Text = book["author_biography"];
      var path = directory + "/images/" + book["photo"];
      photo.Image = Image.FromFile(path);
    }
    
    private void prev_Click(object sender, EventArgs e)
    {
      new catalogForm().Show();
      Hide();
    }

    private void addToCart_Click(object sender, EventArgs e)
    {
      var book_id = Convert.ToInt32(book["id"]);
      var cartBookIdx = Glob.cart.FindIndex(x => x[0] == book_id);
      if (cartBookIdx == -1)
        Glob.cart.Add(new List<int>() {
          { book_id },
          { 1 }
        });
      else
        Glob.cart[cartBookIdx][1] += 1;
    }
    
    private void showBookForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void number_of_pages_Click(object sender, EventArgs e)
    {

    }
  }
}
