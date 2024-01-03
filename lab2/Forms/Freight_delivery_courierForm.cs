using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2.Forms
{
    public partial class Freight_delivery_courierForm : Form
    {
        public Freight_delivery_courierForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            FreightDeliveryCourierService newDelivery = new FreightDeliveryCourierService(
                IDGenerator.GenerateRandomId(16),
                DateTime.Now,
                double.Parse(textBox4.Text),
                decimal.Parse(textBox8.Text),
                textBox1.Text,
                textBox5.Text,
                checkBox1.Checked,
                textBox6.Text,
                textBox8.Text,
                textBox7.Text,
                checkBox2.Checked,
                int.Parse(textBox3.Text),
                false
            );

            var result = UserPattern.Instance.SendPackage(newDelivery);
            PostalCompany.Instance.WriteLogToFile(newDelivery);

            MessageBox.Show($"Service cost: {result}$", "Payable", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
