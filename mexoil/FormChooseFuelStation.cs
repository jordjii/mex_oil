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
    public partial class FormChooseFuelStation : Form
    {

        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

        public FormChooseFuelStation()
        {
            InitializeComponent();
        }

        private void join_station1_Click(object sender, EventArgs e)
        {
            Station1 station1 = new Station1();
            station1.Show();
        }

        private void join_station2_Click(object sender, EventArgs e)
        {
            Station2 station2 = new Station2();
            station2.Show();
        }

        private void join_station3_Click(object sender, EventArgs e)
        {
            Station3 station3 = new Station3();
            station3.Show();
        }

        private void MyProfile_Click(object sender, EventArgs e)
        {
            MyProfileForm myprofile = new MyProfileForm();
            myprofile.Show();
        }
    }
}
