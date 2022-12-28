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
  public partial class employeeForm : Form
  {
    DB db = new DB();

    public employeeForm()
    {
      InitializeComponent();
      var books = db.get_books();
      foreach (var book in books)
      {
        object[] row = new object[dgv.Columns.Count];
        for (int j = 0; j < dgv.Columns.Count; j++)
          row[j] = book[dgv.Columns[j].Name];
        dgv.Rows.Add(row);
      }
    }

    private void employeeForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void addBookButton_Click(object sender, EventArgs e)
    {
      new addBookForm().Show();
      Hide();
    }
  }
}
