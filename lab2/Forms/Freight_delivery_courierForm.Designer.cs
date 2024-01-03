namespace Lab2.Forms
{
    partial class Freight_delivery_courierForm
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
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 0;
            label1.Text = "Name and surname (sender)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(171, 15);
            label2.TabIndex = 1;
            label2.Text = "Name and surname (recepient)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 2;
            label3.Text = "The number of loaders";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 195);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 3;
            label4.Text = "Price to be paid";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 9);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone number (sender)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(302, 70);
            label6.Name = "label6";
            label6.Size = new Size(146, 15);
            label6.TabIndex = 5;
            label6.Text = "Phone number (recepient)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(302, 130);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 6;
            label7.Text = "Resepient address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 195);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 7;
            label8.Text = "Parcel weight";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 213);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(227, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(302, 27);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(230, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(302, 88);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(230, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(302, 148);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(230, 23);
            textBox7.TabIndex = 14;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(302, 213);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(230, 23);
            textBox8.TabIndex = 15;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 267);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Price to be paid";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 292);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(108, 19);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "Spacial packing";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(493, 326);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(102, 40);
            SaveButton.TabIndex = 18;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(601, 326);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(102, 40);
            CancelButton.TabIndex = 19;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // Freight_delivery_courierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Freight_delivery_courierForm";
            Text = "Freight_delivery_courierForm";
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
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button SaveButton;
        private Button CancelButton;
    }
}