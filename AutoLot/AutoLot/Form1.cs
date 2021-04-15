using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoLotDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.autoLotDataSet.Customers);
           

        }

        private void SaveCustomers_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.Update(this.autoLotDataSet.Customers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
