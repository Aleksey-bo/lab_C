namespace Lab2.Forms
{
    partial class Regular_delivery_courier
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
            labelNameSender = new Label();
            textBoxNameSender = new TextBox();
            label3 = new Label();
            textBoxNameRecipient = new TextBox();
            label5 = new Label();
            textBoxPhoneSender = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            textBoxWeight = new TextBox();
            label6 = new Label();
            textBoxPrice = new TextBox();
            PriceCheckBox = new CheckBox();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // labelNameSender
            // 
            labelNameSender.AutoSize = true;
            labelNameSender.Location = new Point(25, 24);
            labelNameSender.Name = "labelNameSender";
            labelNameSender.Size = new Size(157, 15);
            labelNameSender.TabIndex = 2;
            labelNameSender.Text = "Name and surname (sender)";
            // 
            // textBoxNameSender
            // 
            textBoxNameSender.Location = new Point(25, 42);
            textBoxNameSender.Name = "textBoxNameSender";
            textBoxNameSender.Size = new Size(296, 23);
            textBoxNameSender.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 24);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 8;
            label3.Text = "Name and surname (recipient)";
            // 
            // textBoxNameRecipient
            // 
            textBoxNameRecipient.Location = new Point(385, 42);
            textBoxNameRecipient.Name = "textBoxNameRecipient";
            textBoxNameRecipient.Size = new Size(296, 23);
            textBoxNameRecipient.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 84);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 10;
            label5.Text = "Phone number (sender)";
            // 
            // textBoxPhoneSender
            // 
            textBoxPhoneSender.Location = new Point(25, 102);
            textBoxPhoneSender.Name = "textBoxPhoneSender";
            textBoxPhoneSender.Size = new Size(296, 23);
            textBoxPhoneSender.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(385, 149);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 12;
            label1.Text = "Recipient address";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(385, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 23);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(385, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 23);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 84);
            label2.Name = "label2";
            label2.Size = new Size(143, 15);
            label2.TabIndex = 15;
            label2.Text = "Phone number (recipient)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 212);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 16;
            label4.Text = "Parcel weight";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(25, 237);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(296, 23);
            textBoxWeight.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(385, 212);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 18;
            label6.Text = "Price to be paid";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(385, 237);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(296, 23);
            textBoxPrice.TabIndex = 19;
            // 
            // PriceCheckBox
            // 
            PriceCheckBox.AutoSize = true;
            PriceCheckBox.Location = new Point(25, 277);
            PriceCheckBox.Name = "PriceCheckBox";
            PriceCheckBox.Size = new Size(108, 19);
            PriceCheckBox.TabIndex = 20;
            PriceCheckBox.Text = "Price to be paid";
            PriceCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(495, 318);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(102, 40);
            SaveButton.TabIndex = 21;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(603, 318);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(102, 40);
            CancelButton.TabIndex = 22;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // Regular_delivery_courier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 399);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(PriceCheckBox);
            Controls.Add(textBoxPrice);
            Controls.Add(label6);
            Controls.Add(textBoxWeight);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBoxPhoneSender);
            Controls.Add(label5);
            Controls.Add(textBoxNameRecipient);
            Controls.Add(label3);
            Controls.Add(textBoxNameSender);
            Controls.Add(labelNameSender);
            Name = "Regular_delivery_courier";
            Text = "Regular_delivery_courier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNameSender;
        private TextBox textBoxNameSender;
        private Label label3;
        private TextBox textBoxNameRecipient;
        private Label label5;
        private TextBox textBoxPhoneSender;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label4;
        private TextBox textBoxWeight;
        private Label label6;
        private TextBox textBoxPrice;
        private CheckBox PriceCheckBox;
        private Button SaveButton;
        private Button CancelButton;
    }
}