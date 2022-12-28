using Npgsql;
using System.Text;
using System.Security.Cryptography;
using Microsoft.VisualBasic.Logging;
using System.Windows.Forms.VisualStyles;

namespace BooksApp
{
  internal class DB
  {
    NpgsqlConnection con;

    public DB()
    {
      this.con = new NpgsqlConnection("Server=localhost;Username=postgres;Password=20022002;Database=kursovaya3");
    }

    public List<Dictionary<string, string>> get_publishing_houses()
    {
      this.con.Open();
      List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
      string commandText = $"SELECT * FROM publishing_house";
      using (NpgsqlCommand command = new NpgsqlCommand(commandText, this.con))
      {
        NpgsqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
          var i = 0;
          var row = new Dictionary<string, string>();
          String[] columns = { "id", "publisher_name", "city", "phone_number", "about_editor" };
          foreach (String column in columns)
            row.Add(column, reader[i++].ToString());
          rows.Add(row);
        }
        this.con.Close();
        return rows;
      }
    }

    public List<Dictionary<string, string>> get_authors()
    {
      this.con.Open();
      List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
      string commandText = $"SELECT * FROM authors";
      using (NpgsqlCommand command = new NpgsqlCommand(commandText, this.con))
      {
        NpgsqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
          var i = 0;
          var row = new Dictionary<string, string>();
          String[] columns = { "id", "full_name", "biogrpaphy" };
          foreach (String column in columns)
            row.Add(column, reader[i++].ToString());
          rows.Add(row);
        }
        this.con.Close();
        return rows;
      }
    }

    public void add_book(String title, String author, String genre, String price, String pages, String binding,
      String anotation, String storage, String publishing_house, String year_of_writting, String photo)
    {
      this.con.Open();
      string commandText = $"CALL add_book(@title, @author, @genre, @price, @pages, @binding, @annotation, @storage," +
        $"@publishing_house, @year_of_writting, @photo)";
      using (NpgsqlCommand command = new NpgsqlCommand(commandText, this.con))
      {
        command.Parameters.AddWithValue("title", title);
        command.Parameters.AddWithValue("author", author);
        command.Parameters.AddWithValue("genre", genre);
        command.Parameters.AddWithValue("price", Convert.ToInt32(price));
        command.Parameters.AddWithValue("pages", Convert.ToInt32(pages));
        command.Parameters.AddWithValue("binding", binding);
        command.Parameters.AddWithValue("annotation", anotation);
        command.Parameters.AddWithValue("storage", storage);
        command.Parameters.AddWithValue("publishing_house", publishing_house);
        command.Parameters.AddWithValue("year_of_writting", Convert.ToInt32(year_of_writting));
        command.Parameters.AddWithValue("photo", photo);
        NpgsqlDataReader reader = command.ExecuteReader();
        this.con.Close();
      }
    }

    public void register_user(string full_name, string phone, string email, string age, string login, string pswd)
    {
      this.con.Open();
      string commandText = $"CALL register_user(@full_name, @phone, @email, @age, @login, @pswd)";
      using (NpgsqlCommand command = new NpgsqlCommand(commandText, this.con))
      {
        command.Parameters.AddWithValue("full_name", full_name);
        command.Parameters.AddWithValue("phone", phone);
        command.Parameters.AddWithValue("email", email);
        command.Parameters.AddWithValue("age", Convert.ToInt32(age));
        command.Parameters.AddWithValue("login", login);
        command.Parameters.AddWithValue("pswd", pswd);
        NpgsqlDataReader reader = command.ExecuteReader();
        this.con.Close();
      }
    }

    public void add_purchase(string client_id, string storage, string total_price)
    {
      this.con.Open();
      List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
      string commandText = $"CALL add_purchase(@client_id, @storage, @total_price)";
      using (NpgsqlCommand command = new NpgsqlCommand(commandText, this.con))
      {
        command.Parameters.AddWithValue("client_id", Convert.ToInt32(client_id));
        command.Parameters.AddWithValue("storage", storage);
        command.Parameters.AddWithValue("total_price", Convert.ToInt32(total_price));
        NpgsqlDataReader reader = command.ExecuteReader();
        this.con.Close();
      }
    }
    
    public List<Dictionary<string, string>> get_client_orders(string client_id)
    {
      this.con.Open();
      List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
      string commandText = $"SELECT * FROM get_client_orders(@client_id)";
      using (NpgsqlCommand command = new NpgsqlCommand(commandText, this.con))
      {
        command.Parameters.AddWithValue("client_id", Convert.ToInt32(client_id));
        NpgsqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
          var i = 0;
          var row = new Dictionary<string, string>();
          String[] columns = { "id", "client_id", "storage_id", "date_of_purchase", "purchase_price", "order_status",
          "storage_name", "storage_address" };
          foreach (String column in columns)
            row.Add(column, reader[i++].ToString());
          rows.Add(row);
        }
        this.con.Close();
        return rows;
      }
    }

    public Dictionary<string, string> get_min_price()
    {
      this.con.Open();
      string commandText = $"SELECT * FROM get_min_price()";
      using (NpgsqlCommand command = new NpgsqlCommand(commandText, this.con))
      {
        var row = new Dictionary<string, string>();
        NpgsqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
          var i = 0;
          String[] columns = { "get_min_price" };
          foreach (String column in columns)
            row.Add(column, reader[i++].ToString());
        }
        this.con.Close();
        return row;
      }
    }

    public void add_purchase_details(int book_id, int count)
    {
      this.con.Open();
      string commandText = $"CALL add_purchase_details(@book_id, @count)";
      using (NpgsqlCommand command = new NpgsqlCommand(commandText, this.con))
      {
        command.Parameters.AddWithValue("book_id", book_id);  
        command.Parameters.AddWithValue("count", count);
        NpgsqlDataReader reader = command.ExecuteReader();
        this.con.Close();
      }
    }

    public List<Dictionary<string, string>> get_storages()
    {
      this.con.Open();
      List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
      string commandText = $"SELECT * FROM storage";
      using (NpgsqlCommand command = new NpgsqlCommand(commandText, this.con))
      {
        NpgsqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
          var i = 0;
          var row = new Dictionary<string, string>();
          String[] columns = { "id", "address", "name" };
          foreach (String column in columns)
            row.Add(column, reader[i++].ToString());
          rows.Add(row);
        }
        this.con.Close();
        return rows;
      }
    }

    public List<Dictionary<string, string>> get_books(int book_id = -1)
    {
      this.con.Open();
      List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
      string commandText = $"SELECT * FROM get_books(@id)";
      using (NpgsqlCommand command = new NpgsqlCommand(commandText, this.con))
      {
        command.Parameters.AddWithValue("id", book_id);
        NpgsqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
          var i = 0;
          var row = new Dictionary<string, string>();
          String[] columns = { "id", "title", "author_id", "genre", "price", "number_of_pages", "type_of_binding",
          "annotation", "storage_id", "publishing_house_id", "year_of_writing", "photo", "publisher_name", "publisher_city",
          "publisher_phone", "publisher_about", "storage_address", "storage_name", "author_name", "author_biography" };
          foreach (String column in columns)
            row.Add(column, reader[i++].ToString());
          rows.Add(row);
        }
        this.con.Close();
        return rows;
      }
    }
    
    public Dictionary<string, string> get_employee_by_login(String login)
    {
      this.con.Open();
      string commandText = $"SELECT * FROM employees WHERE login = @id";
      using (NpgsqlCommand command = new NpgsqlCommand(commandText, this.con))
      {
        var row = new Dictionary<string, string>();
        command.Parameters.AddWithValue("id", login);
        NpgsqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
          var i = 0;
          String[] columns = { "seller_code", "full_name", "phone_number", "e_mail_address", "date_of_employment",
          "post_code_id", "storage_id", "login", "password" };
          foreach (String column in columns)
            row.Add(column, reader[i++].ToString());
        }
        this.con.Close();
        return row;
      }
    }

    public Dictionary<string, string> get_user_by_login(String login)
    {
      this.con.Open();
      var row = new Dictionary<string, string>();
      string commandText = $"SELECT * from clients where login = @login"; /*защита от инъекции инициализация в 251 строке*/
      using (NpgsqlCommand command = new NpgsqlCommand(commandText, this.con))
      {
        command.Parameters.AddWithValue("login", login);
        NpgsqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
          var i = 0;
          String[] columns = { "id", "full_name", "phone_number", "e_mail_address", "age", "login", "password" };
          foreach (String column in columns)
            row.Add(column, reader[i++].ToString());
        }
        this.con.Close();
        return row;
      }
    }

    public string sha256(string plainText)
    { 
      using (SHA256 sha256Hash = SHA256.Create())
      {
        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainText));
        StringBuilder stringbuilder = new StringBuilder();
        for (int i = 0; i < bytes.Length; i++)
          stringbuilder.Append(bytes[i].ToString("x2"));
        return stringbuilder.ToString();
      }
    }
  }
}
