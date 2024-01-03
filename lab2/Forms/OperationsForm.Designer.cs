namespace Lab2.Forms
{
    partial class OperationsForm
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
            listParcel = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listParcel
            // 
            listParcel.FormattingEnabled = true;
            listParcel.HorizontalScrollbar = true;
            listParcel.ItemHeight = 15;
            listParcel.Location = new Point(12, 12);
            listParcel.Name = "listParcel";
            listParcel.Size = new Size(706, 334);
            listParcel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(616, 366);
            button1.Name = "button1";
            button1.Size = new Size(102, 40);
            button1.TabIndex = 1;
            button1.Text = "Pick Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OperationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listParcel);
            Name = "OperationsForm";
            Text = "OperationsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listParcel;
        private Button button1;
    }
}