using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace mexoil
{
    public partial class Form1 : Form
    {
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private bool IsUsernameTaken(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Customers WHERE FirstName = @FirstName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", username);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = TextUsername.Text;
            string password = TextPassword.Text;

            if (IsUsernameTaken(username))
            {
                MessageBox.Show("Это имя пользователя уже занято. Пожалуйста, выберите другое.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Пароль должен быть не менее 6 символов.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Customers (CustomerID, FirstName, LastName, Phone, Email, Passwordd) VALUES (@CustomerID, @FirstName, @LastName, @Phone, @Email, @Passwordd);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int customerID = int.Parse(ReturnLastIdOfTable("Customers")) + 1;

                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@FirstName", username);
                    command.Parameters.AddWithValue("@LastName", "");
                    command.Parameters.AddWithValue("@Phone", "");
                    command.Parameters.AddWithValue("@Email", "");
                    command.Parameters.AddWithValue("@Passwordd", password);

                    command.ExecuteNonQuery();

                    CreateBonusCard(customerID); // Добавление бонусной карты после успешной регистрации
                }
            }
        }

        public string ReturnLastIdOfTable(string tableName)
        {
            string lastIndexCommand = $"SELECT TOP 1 CustomerID FROM {tableName} ORDER BY CustomerID DESC;";
            string commandResult;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(lastIndexCommand, connection))
                {
                    commandResult = command.ExecuteScalar().ToString();
                }
            }
            return commandResult;
        }

        private int GetCustomerID(string username)
        {
            int customerID = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT CustomerID FROM Customers WHERE FirstName = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    var result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        customerID = Convert.ToInt32(result);
                    }
                }
            }

            return customerID;
        }

        private bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Customers WHERE FirstName = @Username AND Passwordd = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void CreateBonusCard(int customerID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO BonusCards (CustomerID, BonusPoints) VALUES (@CustomerID, @BonusPoints); SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@BonusPoints", 100);

                    int cardID = Convert.ToInt32(command.ExecuteScalar()); // Получаем только что вставленный CardID
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) /*login button*/
        {
            string username = TextUsername.Text;
            string password = TextPassword.Text;


            if (username == "admin" && password == "adminadmin")
            {
                MessageBox.Show("Добро пожаловать, администратор!");
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }

            if (AuthenticateUser(username, password))
            {
                int customerID = GetCustomerID(username);
                MyProfileForm.usernameID = customerID.ToString();

                MessageBox.Show("Добро пожаловать, " + username + "!");
                FormChooseFuelStation formChooseFuel = new FormChooseFuelStation();
                formChooseFuel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль. Пожалуйста, попробуйте снова.");
            }
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminPanelForm = new AdminPanelForm();
            adminPanelForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}