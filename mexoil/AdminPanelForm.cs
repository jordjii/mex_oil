using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mexoil
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.FuelTransactions". При необходимости она может быть перемещена или удалена.
            this.fuelTransactionsTableAdapter.Fill(this.database1DataSet1.FuelTransactions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.BonusCards". При необходимости она может быть перемещена или удалена.
            this.bonusCardsTableAdapter.Fill(this.database1DataSet1.BonusCards);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.database1DataSet1.Customers);

        }
    }
}
