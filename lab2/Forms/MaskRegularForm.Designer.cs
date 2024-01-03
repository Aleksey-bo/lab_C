namespace Lab2.Forms
{
    partial class MaskRegularForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Form activeForm;

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

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForms.Controls.Add(childForm);
            panelForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            panelForms = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(198, 33);
            button1.TabIndex = 1;
            button1.Text = "Delivery to the department";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(216, 12);
            button2.Name = "button2";
            button2.Size = new Size(137, 33);
            button2.TabIndex = 2;
            button2.Text = "Courier delivery";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panelForms
            // 
            panelForms.Location = new Point(12, 51);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(780, 387);
            panelForms.TabIndex = 3;
            // 
            // MaskRegularForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForms);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MaskRegularForm";
            Text = "MaskRegularForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panelForms;
    }
}