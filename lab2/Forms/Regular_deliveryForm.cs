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
    public partial class Regular_deliveryForm : Form
    {
        public Regular_deliveryForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void PriceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            RegularDeliveryHoldForPickup newDelivery = new RegularDeliveryHoldForPickup(
                IDGenerator.GenerateRandomId(16),
                DateTime.Now,
                double.Parse(textBoxWeight.Text),
                decimal.Parse(textBoxPrice.Text),
                textBoxNameSender.Text,
                textBoxPhoneSender.Text,
                PriceCheckBox.Checked,
                textBoxNameRecipient.Text,
                textBoxBranchNum.Text,
                false
            );

            var result = UserPattern.Instance.SendPackage(newDelivery);
            PostalCompany.Instance.WriteLogToFile(newDelivery);

            MessageBox.Show($"Service cost: {result}$", "Payable", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
