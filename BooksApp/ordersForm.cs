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
  public partial class ordersForm : Form
  {
    DB db = new DB();

    public ordersForm()
    {
      InitializeComponent();
      var orders = db.get_client_orders(Glob.user["id"]);
      foreach (var order in orders)
      {
        dgv.Rows.Add(order["id"], order["date_of_purchase"], order["storage_address"], order["purchase_price"], order["order_status"]);
      }
    }

    private void prev_Click(object sender, EventArgs e)
    {
      new catalogForm().Show();
      Hide();
    }

    private void ordersForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
