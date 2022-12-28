
namespace BooksApp
{
  public static class Glob
  {
    public static List<List<int>> cart = new List<List<int>>();
    public static Dictionary<string, string>? user;

    public static void showWarningMessage(string text)
    {
      MessageBox.Show(text, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static void showSuccessMessage(string text)
    {
      MessageBox.Show(text, "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }

  public partial class authForm : Form
  {
    DB db = new DB();

    public authForm()
    {
      InitializeComponent();
    }

    private void submit_Click(object sender, EventArgs e)
    {
      errorLabel.Text = "";
      if (loginField.Text.Length <= 2) errorLabel.Text = "Логин должен быть более 2 символов";
      else if (pswdField.Text.Length <= 4) errorLabel.Text = "Пароль должен быть более 4 символов";
      var employee = db.get_employee_by_login(loginField.Text);
      if(employee.Count > 0 && employee["password"].CompareTo(db.sha256(pswdField.Text)) == 0)
      {
        Glob.user = employee;
        new employeeForm().Show();
        Hide();
        return;
      }
      var user = db.get_user_by_login(loginField.Text);
      if (user.Count == 0 || db.sha256(pswdField.Text).CompareTo(user["password"]) != 0)
        errorLabel.Text = "Логин или пароль введен неверно";
      if (errorLabel.Text.Length > 0) return;
      Glob.user = user;
      new catalogForm().Show();
      Hide();
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
      //loginField.Text = db.sha256("");
      new registerForm().Show();
      Hide();
    }
  }
}