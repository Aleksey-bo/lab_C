namespace Lab2.Forms
{
    partial class Regular_deliveryForm
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
            labelNameSender = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxNameSender = new TextBox();
            textBoxNameRecipient = new TextBox();
            textBoxPhoneSender = new TextBox();
            textBoxBranchNum = new TextBox();
            textBoxWeight = new TextBox();
            textBoxPrice = new TextBox();
            PriceCheckBox = new CheckBox();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 174);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Parcel weight";
            label1.Click += label1_Click;
            // 
            // labelNameSender
            // 
            labelNameSender.AutoSize = true;
            labelNameSender.Location = new Point(29, 36);
            labelNameSender.Name = "labelNameSender";
            labelNameSender.Size = new Size(157, 15);
            labelNameSender.TabIndex = 1;
            labelNameSender.Text = "Name and surname (sender)";
            labelNameSender.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 36);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 2;
            label3.Text = "Name and surname (recipient)";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 174);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 3;
            label4.Text = "Price to be paid";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 97);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone number (sender)";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 97);
            label6.Name = "label6";
            label6.Size = new Size(141, 15);
            label6.TabIndex = 5;
            label6.Text = "Recipient branch number";
            label6.Click += label6_Click;
            // 
            // textBoxNameSender
            // 
            textBoxNameSender.Location = new Point(31, 54);
            textBoxNameSender.Name = "textBoxNameSender";
            textBoxNameSender.Size = new Size(296, 23);
            textBoxNameSender.TabIndex = 6;
            // 
            // textBoxNameRecipient
            // 
            textBoxNameRecipient.Location = new Point(364, 54);
            textBoxNameRecipient.Name = "textBoxNameRecipient";
            textBoxNameRecipient.Size = new Size(296, 23);
            textBoxNameRecipient.TabIndex = 7;
            // 
            // textBoxPhoneSender
            // 
            textBoxPhoneSender.Location = new Point(29, 115);
            textBoxPhoneSender.Name = "textBoxPhoneSender";
            textBoxPhoneSender.Size = new Size(296, 23);
            textBoxPhoneSender.TabIndex = 8;
            // 
            // textBoxBranchNum
            // 
            textBoxBranchNum.Location = new Point(364, 115);
            textBoxBranchNum.Name = "textBoxBranchNum";
            textBoxBranchNum.Size = new Size(296, 23);
            textBoxBranchNum.TabIndex = 9;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(29, 192);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(296, 23);
            textBoxWeight.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(365, 192);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(296, 23);
            textBoxPrice.TabIndex = 11;
            // 
            // PriceCheckBox
            // 
            PriceCheckBox.AutoSize = true;
            PriceCheckBox.Location = new Point(31, 252);
            PriceCheckBox.Name = "PriceCheckBox";
            PriceCheckBox.Size = new Size(108, 19);
            PriceCheckBox.TabIndex = 12;
            PriceCheckBox.Text = "Price to be paid";
            PriceCheckBox.UseVisualStyleBackColor = true;
            PriceCheckBox.CheckedChanged += PriceCheckBox_CheckedChanged;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(496, 319);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(102, 40);
            SaveButton.TabIndex = 13;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(604, 319);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(102, 40);
            CancelButton.TabIndex = 14;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // Regular_deliveryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 366);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(PriceCheckBox);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxWeight);
            Controls.Add(textBoxBranchNum);
            Controls.Add(textBoxPhoneSender);
            Controls.Add(textBoxNameRecipient);
            Controls.Add(textBoxNameSender);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelNameSender);
            Controls.Add(label1);
            Name = "Regular_deliveryForm";
            Text = "Regular_deliveryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelNameSender;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxNameSender;
        private TextBox textBoxNameRecipient;
        private TextBox textBoxPhoneSender;
        private TextBox textBoxBranchNum;
        private TextBox textBoxWeight;
        private TextBox textBoxPrice;
        private CheckBox PriceCheckBox;
        private Button SaveButton;
        private Button CancelButton;
    }
}