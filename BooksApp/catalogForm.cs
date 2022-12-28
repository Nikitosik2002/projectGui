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
  public partial class catalogForm : Form
  {
    DB db = new DB();

    public catalogForm()
    {
      InitializeComponent();
      var books = db.get_books();
      foreach(var book in books)
      {
        object[] row = new object[dgv.Columns.Count];
        for (int j = 0; j < dgv.Columns.Count; j++)
          row[j] = book[dgv.Columns[j].Name];
        dgv.Rows.Add(row);
      }
      lowPrice.Text = "Самая дешевая книга у нас стоит всего: " + 
        db.get_min_price()["get_min_price"] + " рублей";
    }

    private void catalogForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var book_id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);
      var book = db.get_books(book_id);
      new showBookForm(book[0]).Show();
      Hide();
    }

    private void cartButton_Click(object sender, EventArgs e)
    {
      new cartForm().Show();
      Hide();
    }

    private void ordersButton_Click(object sender, EventArgs e)
    {
      new ordersForm().Show();
      Hide();
    }
  }
}
