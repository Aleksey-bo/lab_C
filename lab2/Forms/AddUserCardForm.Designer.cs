namespace Lab2.Forms
{
    partial class AddUserCardForm
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
            textBoxName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 35);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Name and surname";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(45, 53);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(227, 23);
            textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 115);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 199);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "Phone";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(45, 133);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(227, 23);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(45, 217);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(227, 23);
            textBoxPhone.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(489, 360);
            button1.Name = "button1";
            button1.Size = new Size(102, 40);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(597, 360);
            button2.Name = "button2";
            button2.Size = new Size(102, 40);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // AddUserCardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 412);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "AddUserCardForm";
            Text = "Add User Card";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private Label label2;
        private Label label3;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private Button button1;
        private Button button2;
    }
}