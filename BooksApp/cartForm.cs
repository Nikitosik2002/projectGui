using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksApp
{
  public partial class cartForm : Form
  {
    DB db = new DB();
    int total_sum = 0;

    public cartForm()
    {
      InitializeComponent();
      var storages = db.get_storages();
      foreach(var storage in storages)
        storageList.Items.Add(storage["address"]);
      foreach(var item in Glob.cart)
      {
        var book = db.get_books(item[0])[0];
        var sum = Convert.ToInt32(book["price"]) * item[1];
        total_sum += sum;
        cartList.Rows.Add(
          book["title"],
          book["author_name"],
          book["price"],
          item[1],
          sum
        );
      }
      totalPrice.Text = total_sum + " рублей";
      customer.Text = Glob.user["full_name"];
    }

    private void cartForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void prev_Click(object? sender, EventArgs? e)
    {
      new catalogForm().Show();
      Hide();
    }

    private void submit_Click(object sender, EventArgs e)
    {
      if (Glob.cart.Count == 0)
      {
        Glob.showWarningMessage("В вашей коризне ничего нет\nДля оформления заказа добавьте товары");
        return;
      }
      var storage = storageList.GetItemText(storageList.SelectedItem);
      if (storage == "")
      {
        Glob.showWarningMessage("Выберите магазин из которого заберете заказ");
        return;
      }
      db.add_purchase(Glob.user["id"], storage, Convert.ToString(total_sum));
      foreach(var item in Glob.cart)
        db.add_purchase_details(item[0], item[1]);
      Glob.cart.Clear();
      Glob.showSuccessMessage("Заказ успешно оформлен");
      prev_Click(null, null);
    }

    private void storageList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void cartList_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}