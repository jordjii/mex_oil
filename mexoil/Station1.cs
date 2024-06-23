using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace mexoil
{
    public partial class Station1 : Form
    {
        private int purchaseID;
        private int transactionID;
        private int stationID;
        private int customerID;

        public Station1()
        {
            InitializeComponent();
        }

        public Station1(int purchaseID, int transactionID, int stationID, int customerID)
        {
            InitializeComponent();
            this.purchaseID = purchaseID;
            this.transactionID = transactionID;
            this.stationID = stationID;
            this.customerID = customerID;
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (ChooseFuelType.SelectedItem != null)
            {
                string fuelType = ChooseFuelType.SelectedItem.ToString();

                // Проверяем, что введено количество в поле textBox1
                if (decimal.TryParse(Liters.Text, out decimal quantity))
                {
                    GasolinePurchaseManager purchaseManager = new GasolinePurchaseManager();
                    string username = "username_here"; // Предположим, у вас есть способ получить имя пользователя
                    decimal pricePerLiter = purchaseManager.GetPricePerLiterFromFuelType(fuelType);  // Получаем цену за литр
                    decimal totalAmount = pricePerLiter * quantity;  // Вычисляем общую сумму

                    // Display the total amount in the TextBox
                    totalAmountTextBox.Text = totalAmount.ToString("C");  // Assuming you want to display the total amount as currency
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.");
                }
            }
            else
            {
                MessageBox.Show("Please select a fuel type before making a purchase.");
            }
        }


        private int GenerateTransactionID()
        {
            return new Random().Next(1000, 9999);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Действия при нажатии на label1
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminPanelForm = new AdminPanelForm();
            adminPanelForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        public class GasolinePurchaseManager
        {
            const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            public void ProcessGasolinePurchase(int purchaseID, int transactionID, int customerID, string fuelType, decimal quantity, string username)
            {
                int retrievedCustomerID = (GetCustomerID("penis"));

                int stationID = GetStationID("sperma");

                decimal pricePerLiter = GetPricePerLiterFromFuelType(fuelType);

                decimal totalAmount = pricePerLiter * quantity;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Purchases SET PricePerLiter = @PricePerLiter, TotalAmount = @TotalAmount WHERE PurchaseID = @PurchaseID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PricePerLiter", pricePerLiter);
                        command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        command.Parameters.AddWithValue("@PurchaseID", purchaseID);

                        command.ExecuteNonQuery();
                    }

                    // вычитаем количество приобретенного топлива из резерва заправочной станции
                    string updateFuelBankQuery = "UPDATE Stations SET FuelBank = FuelBank - @Quantity WHERE StationID = @StationID";
                    using (SqlCommand updateFuelBankCommand = new SqlCommand(updateFuelBankQuery, connection))
                    {
                        updateFuelBankCommand.Parameters.AddWithValue("@Quantity", quantity);
                        updateFuelBankCommand.Parameters.AddWithValue("@StationID", stationID);
                        updateFuelBankCommand.Parameters.AddWithValue("@FuelBank", 200);
                        updateFuelBankCommand.ExecuteNonQuery();
                    }

                    string insertTransactionQuery = "INSERT INTO FuelTransactions (TransactionID, StationID, CustomerID, FuelType, Quantity, TransactionDateTime) VALUES (@TransactionID, @StationID, @CustomerID, @FuelType, @Quantity, @TransactionDateTime)";
                    using (SqlCommand insertTransactionCommand = new SqlCommand(insertTransactionQuery, connection))
                    {
                        insertTransactionCommand.Parameters.AddWithValue("@TransactionID", transactionID);
                        insertTransactionCommand.Parameters.AddWithValue("@StationID", stationID);
                        insertTransactionCommand.Parameters.AddWithValue("@CustomerID", retrievedCustomerID);
                        insertTransactionCommand.Parameters.AddWithValue("@FuelType", fuelType);
                        insertTransactionCommand.Parameters.AddWithValue("@Quantity", quantity);
                        insertTransactionCommand.Parameters.AddWithValue("@TransactionDateTime", DateTime.Now);
                        insertTransactionCommand.ExecuteNonQuery();
                    }
                }
            }

            static int GetCustomerID(string username)
            {
                int customerID = 0;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT CustomerID FROM Customers WHERE FirstName = @FirstName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", username);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            customerID = Convert.ToInt32(result);
                        }
                    }
                }
                return customerID;
            }

            static int GetStationID(string stationName)
            {
                int stationID = 0;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT StationID FROM Stations WHERE StationName = @StationName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StationName", stationName);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            stationID = Convert.ToInt32(result);
                        }
                    }
                }
                return stationID;
            }

            public decimal GetPricePerLiterFromFuelType(string fuelType)
            {
                decimal pricePerLiter = 0;

                // Логика для определения цены за литр на основе выбранного типа топлива
                switch (fuelType)
                {
                    case "92":
                        pricePerLiter = 45.50m;  // Пример цены за литр топлива '92'
                        break;
                    case "95":
                        pricePerLiter = 50.75m;  // Пример цены за литр топлива '95'
                        break;
                    case "98":
                        pricePerLiter = 99.30m;  // Пример цены за литр топлива '98'
                        break;
                    case "Diesel":
                        pricePerLiter = 70.90m;  // Пример цены за литр дизельного топлива
                        break;
                    default:
                        // Обработка случая, когда тип топлива отсутствует в списке
                        // Можно установить стандартное значение или обработать ошибку
                        break;
                }

                return pricePerLiter;
            }
        }

        private void MyProfile_Click(object sender, EventArgs e)
        {
            MyProfileForm myprofile = new MyProfileForm();
            myprofile.Show();
        }


        void InsertFuelTransaction()
        {
            const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            string query = "INSERT INTO FuelTransactions (FuelType, Quantity, TransactionDateTime, StationID, ColumnID) " +
                           "VALUES (@FuelType, @Quantity, @TransactionDateTime, @StationID, @ColumnID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (int.TryParse(ChooseColumn.SelectedItem?.ToString(), out int columnID))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FuelType", ChooseFuelType.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Quantity", decimal.Parse(Liters.Text));
                        command.Parameters.AddWithValue("@TransactionDateTime", DateTime.Now);
                        command.Parameters.AddWithValue("@StationID", 1);
                        command.Parameters.AddWithValue("@ColumnID", 1);

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows Inserted: {rowsAffected}");
                    }
                }
            }
        }

        public void PayViaBonusCard_Click(object sender, EventArgs e)
        {
            if (ChooseFuelType.SelectedItem != null)
            {
                InsertFuelTransaction();

                string fuelType = ChooseFuelType.SelectedItem.ToString();

                if (decimal.TryParse(Liters.Text, out decimal quantity))
                {
                    GasolinePurchaseManager purchaseManager = new GasolinePurchaseManager();
                    string username = "здесь_имя_пользователя"; // Предположим, у вас есть способ получить имя пользователя

                    decimal pricePerLiter = purchaseManager.GetPricePerLiterFromFuelType(fuelType);
                    decimal totalAmount = pricePerLiter * quantity;

                    // бонусные баллы для текущего пользователя
                    int bonusPointsToDeduct = Convert.ToInt32(totalAmount); // 1 бонус = 1 валютная единица
                    int customerID = int.Parse(MyProfileForm.usernameID); 

                    MyProfileForm myProfileForm = new MyProfileForm();
                    int remainingBonusPoints = myProfileForm.GetBonusPointsForCustomerFromDatabase(customerID); // Получаем текущее количество бонусных баллов
                    Console.WriteLine($"Fuel type selected: {fuelType}");
                    Console.WriteLine($"Quantity entered: {quantity}");
                    Console.WriteLine($"Price per liter: {pricePerLiter}");
                    Console.WriteLine($"Total amount to pay: {totalAmount}");
                    Console.WriteLine($"Customer ID: {customerID}");
                    Console.WriteLine($"Remaining bonus points: {remainingBonusPoints}");
                    Console.WriteLine($"Bonus points to deduct: {bonusPointsToDeduct}");
                    // Проверяем, достаточно ли баллов для списания
                    if (remainingBonusPoints >= bonusPointsToDeduct)
                    {
                        // Вычитаем бонусные баллы из общего баланса
                        int newBonusPointsBalance = remainingBonusPoints - bonusPointsToDeduct;

                        // Обновляем бонусные баллы в базе данных
                        UpdateBonusPointsInDatabase(customerID, newBonusPointsBalance);

                        // Выводим сообщение об успешной операции списания бонусных баллов
                        MessageBox.Show($"You have successfully paid using {bonusPointsToDeduct} bonus points! 😊");
                    }
                    else
                    {
                        // Выводим сообщение, что у пользователя недостаточно бонусных баллов
                        MessageBox.Show("Insufficient bonus points. Please use a different payment method. 😞");
                    }
                }
            }
        }
        public void UpdateBonusPointsInDatabase(int customerID, int newBonusPointsBalance)
        {
            const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Обновляем количество бонусных баллов для указанного пользователя
                string updateQuery = "UPDATE BonusCards SET BonusPoints = @NewBonusPointsBalance WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@NewBonusPointsBalance", newBonusPointsBalance);
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void pictureBoxStation1_Click(object sender, EventArgs e)
        {

        }
    }
}