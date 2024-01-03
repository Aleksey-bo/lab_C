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
    public partial class TaxesForm : Form
    {
        public TaxesForm()
        {
            InitializeComponent();
            InitializePictureBox();
        }

        private PictureBox pictureBox;

        private void InitializePictureBox()
        {
            pictureBox = new PictureBox();
            pictureBox.Location = new Point(10, 10);
            pictureBox.Size = new Size(200, 300);
            pictureBox.Paint += DrawingPanel_Paint;

            Controls.Add(pictureBox);
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            int height = 10; 
            string[] arr = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Font font = new Font("Arial", 12, FontStyle.Regular);
            Brush brush = new SolidBrush(Color.Black);
            var taxArray = PostalCompany.Instance.UpdateTaxArray();

            for (int i = 0; i < arr.Length; i++)
            {
                e.Graphics.DrawString($"{arr[i]}: {taxArray[i]}$", font, brush, new Point(10, height));
                height += 20;
            }

            font.Dispose();
            brush.Dispose();
        }
    }
}
