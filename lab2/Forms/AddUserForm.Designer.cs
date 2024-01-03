namespace Lab2.Forms
{
    partial class AddUserForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 37);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Name and surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 106);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 23);
            textBox2.TabIndex = 3;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(495, 352);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(102, 40);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(603, 352);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(102, 40);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 404);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUserForm";
            Text = "Add User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button SaveButton;
        private Button CancelButton;
    }
}