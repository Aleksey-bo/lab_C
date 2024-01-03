using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Forms
{
    public partial class OperationsForm : Form
    {
        public OperationsForm()
        {
            InitializeComponent();
            listParcel.DataSource = UserPattern.Instance.GetUnfinishedOperations();
            listParcel.DisplayMember = "ToString";
            listParcel.ResetBindings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_set_delivery selectedDelivery = (get_set_delivery)listParcel.SelectedItem;
        }
    }
}
