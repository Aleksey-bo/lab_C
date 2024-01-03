using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2.Forms
{
    public partial class Regular_delivery_courier : Form
    {
        public Regular_delivery_courier()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            RegularDeliveryCourierService newDelivery = new RegularDeliveryCourierService(
                IDGenerator.GenerateRandomId(16),
                DateTime.Now,
                double.Parse(textBoxWeight.Text),
                decimal.Parse(textBoxPrice.Text),
                textBoxNameSender.Text,
                textBoxPhoneSender.Text,
                PriceCheckBox.Checked,
                textBoxNameRecipient.Text,
                textBox2.Text,
                textBox1.Text,
                false
            );

            var result = UserPattern.Instance.SendPackage(newDelivery);
            PostalCompany.Instance.WriteLogToFile(newDelivery);

            MessageBox.Show($"Service cost: {result}$", "Payable", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
