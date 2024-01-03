namespace Lab2.Forms
{
    partial class Freight_deliveryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            checkBoxPrice = new CheckBox();
            checkBoxPackage = new CheckBox();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 0;
            label1.Text = "Name and surname (sender)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 28);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 1;
            label2.Text = "Phone numder (sender)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 96);
            label3.Name = "label3";
            label3.Size = new Size(171, 15);
            label3.TabIndex = 2;
            label3.Text = "Name and surname (recepient)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 96);
            label4.Name = "label4";
            label4.Size = new Size(144, 15);
            label4.TabIndex = 3;
            label4.Text = "Recepient branch number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 170);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 4;
            label5.Text = "Parcel weight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(315, 170);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 5;
            label6.Text = "Price to be paid";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(315, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(24, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(315, 118);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(24, 188);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(206, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(315, 188);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(231, 23);
            textBox6.TabIndex = 11;
            // 
            // checkBoxPrice
            // 
            checkBoxPrice.AutoSize = true;
            checkBoxPrice.Location = new Point(24, 238);
            checkBoxPrice.Name = "checkBoxPrice";
            checkBoxPrice.Size = new Size(108, 19);
            checkBoxPrice.TabIndex = 12;
            checkBoxPrice.Text = "Price to be paid";
            checkBoxPrice.UseVisualStyleBackColor = true;
            // 
            // checkBoxPackage
            // 
            checkBoxPackage.AutoSize = true;
            checkBoxPackage.Location = new Point(24, 263);
            checkBoxPackage.Name = "checkBoxPackage";
            checkBoxPackage.Size = new Size(108, 19);
            checkBoxPackage.TabIndex = 13;
            checkBoxPackage.Text = "Spacial packing";
            checkBoxPackage.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(478, 302);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(102, 40);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(586, 302);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(102, 40);
            CancelButton.TabIndex = 15;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // Freight_deliveryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 360);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(checkBoxPackage);
            Controls.Add(checkBoxPrice);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Freight_deliveryForm";
            Text = "Freight delivery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private CheckBox checkBoxPrice;
        private CheckBox checkBoxPackage;
        private Button SaveButton;
        private Button CancelButton;
    }
}