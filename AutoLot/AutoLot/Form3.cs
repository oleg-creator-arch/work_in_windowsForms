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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) => Application.Exit();

        private void button2_Click(object sender, EventArgs e)
        {
            // Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new Form1());
            //ShowDialog(new Form1());
            Form1 CustomersForm = new Form1();
            CustomersForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 InvetoryForm = new Form2();
            InvetoryForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 OrdersForm = new Form4();
            OrdersForm.Show();
        }
    }
}
