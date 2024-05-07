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
    public partial class MyProfileForm : Form
    {


        public MyProfileForm()
        {
            InitializeComponent();
        }

          

        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

        public static string usernameID = string.Empty;

        private int GetBonusPointsForCustomerFromDatabase(int customerID)
        {
            int bonusPoints = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT BonusPoints FROM BonusCards WHERE CustomerID = @CustomerID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bonusPoints = Convert.ToInt32(reader["BonusPoints"]);
                        }
                    }
                }
            }

            return bonusPoints;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MyProfileForm_MouseUp(object sender, MouseEventArgs e)
        {
            RefreshInformation();
        }

        void RefreshInformation ()
        {
            ur_id_label.Text = usernameID;
            textBoxBonusPoints.Text = GetBonusPointsForCustomerFromDatabase(int.Parse(usernameID)).ToString();
        }
    }
}