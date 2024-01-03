namespace Lab2
{
    partial class mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Form activeForm;

        /// <summary>
        ///  Clean up any resources being used.
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
            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;

            if (childForm is Forms.MaskFormFreight maskFormFreight)
            {
                maskFormFreight.ShowFreightDeliveryForm();
            }


            if (childForm is Forms.MaskRegularForm maskFormRegular)
            {
                maskFormRegular.ShowRegularDeliveryForm();
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            menuPanel = new Panel();
            OperationsButton = new Button();
            button1 = new Button();
            DeleteUserbtn = new Button();
            exit_btn = new Button();
            add_user_card = new Button();
            add_user = new Button();
            freight_delivery = new Button();
            regular_delivery = new Button();
            panelLogo = new Panel();
            nameSelect = new Panel();
            labelTitle = new Label();
            panelDesktopPane = new Panel();
            menuPanel.SuspendLayout();
            nameSelect.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.Gray;
            menuPanel.Controls.Add(OperationsButton);
            menuPanel.Controls.Add(button1);
            menuPanel.Controls.Add(DeleteUserbtn);
            menuPanel.Controls.Add(exit_btn);
            menuPanel.Controls.Add(add_user_card);
            menuPanel.Controls.Add(add_user);
            menuPanel.Controls.Add(freight_delivery);
            menuPanel.Controls.Add(regular_delivery);
            menuPanel.Controls.Add(panelLogo);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(180, 496);
            menuPanel.TabIndex = 1;
            // 
            // OperationsButton
            // 
            OperationsButton.Dock = DockStyle.Top;
            OperationsButton.FlatAppearance.BorderSize = 0;
            OperationsButton.FlatStyle = FlatStyle.Flat;
            OperationsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OperationsButton.ForeColor = SystemColors.Control;
            OperationsButton.Image = (Image)resources.GetObject("OperationsButton.Image");
            OperationsButton.ImageAlign = ContentAlignment.MiddleLeft;
            OperationsButton.Location = new Point(0, 365);
            OperationsButton.Name = "OperationsButton";
            OperationsButton.Padding = new Padding(10, 0, 0, 0);
            OperationsButton.Size = new Size(180, 50);
            OperationsButton.TabIndex = 8;
            OperationsButton.Text = "Incomplete operations";
            OperationsButton.TextAlign = ContentAlignment.MiddleLeft;
            OperationsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            OperationsButton.UseVisualStyleBackColor = true;
            OperationsButton.Click += OperationsButton_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 315);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(180, 50);
            button1.TabIndex = 7;
            button1.Text = "Taxes";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DeleteUserbtn
            // 
            DeleteUserbtn.Dock = DockStyle.Top;
            DeleteUserbtn.FlatAppearance.BorderSize = 0;
            DeleteUserbtn.FlatStyle = FlatStyle.Flat;
            DeleteUserbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteUserbtn.ForeColor = SystemColors.Control;
            DeleteUserbtn.Image = (Image)resources.GetObject("DeleteUserbtn.Image");
            DeleteUserbtn.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteUserbtn.Location = new Point(0, 265);
            DeleteUserbtn.Name = "DeleteUserbtn";
            DeleteUserbtn.Padding = new Padding(10, 0, 0, 0);
            DeleteUserbtn.Size = new Size(180, 50);
            DeleteUserbtn.TabIndex = 6;
            DeleteUserbtn.Text = "Delete user";
            DeleteUserbtn.TextAlign = ContentAlignment.MiddleLeft;
            DeleteUserbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteUserbtn.UseVisualStyleBackColor = true;
            DeleteUserbtn.Click += DeleteUserbtn_Click;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.DimGray;
            exit_btn.Dock = DockStyle.Bottom;
            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exit_btn.ForeColor = SystemColors.Control;
            exit_btn.Image = (Image)resources.GetObject("exit_btn.Image");
            exit_btn.ImageAlign = ContentAlignment.MiddleLeft;
            exit_btn.Location = new Point(0, 446);
            exit_btn.Name = "exit_btn";
            exit_btn.Padding = new Padding(10, 0, 0, 0);
            exit_btn.Size = new Size(180, 50);
            exit_btn.TabIndex = 2;
            exit_btn.Text = "Exit";
            exit_btn.TextAlign = ContentAlignment.MiddleLeft;
            exit_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // add_user_card
            // 
            add_user_card.Dock = DockStyle.Top;
            add_user_card.FlatAppearance.BorderSize = 0;
            add_user_card.FlatStyle = FlatStyle.Flat;
            add_user_card.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            add_user_card.ForeColor = SystemColors.Control;
            add_user_card.Image = (Image)resources.GetObject("add_user_card.Image");
            add_user_card.ImageAlign = ContentAlignment.MiddleLeft;
            add_user_card.Location = new Point(0, 215);
            add_user_card.Name = "add_user_card";
            add_user_card.Padding = new Padding(10, 0, 0, 0);
            add_user_card.Size = new Size(180, 50);
            add_user_card.TabIndex = 5;
            add_user_card.Text = "Add user card";
            add_user_card.TextAlign = ContentAlignment.MiddleLeft;
            add_user_card.TextImageRelation = TextImageRelation.ImageBeforeText;
            add_user_card.UseVisualStyleBackColor = true;
            add_user_card.Click += add_user_card_Click;
            // 
            // add_user
            // 
            add_user.Dock = DockStyle.Top;
            add_user.FlatAppearance.BorderSize = 0;
            add_user.FlatStyle = FlatStyle.Flat;
            add_user.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            add_user.ForeColor = SystemColors.Control;
            add_user.Image = (Image)resources.GetObject("add_user.Image");
            add_user.ImageAlign = ContentAlignment.MiddleLeft;
            add_user.Location = new Point(0, 165);
            add_user.Name = "add_user";
            add_user.Padding = new Padding(10, 0, 0, 0);
            add_user.Size = new Size(180, 50);
            add_user.TabIndex = 4;
            add_user.Text = "Add user";
            add_user.TextAlign = ContentAlignment.MiddleLeft;
            add_user.TextImageRelation = TextImageRelation.ImageBeforeText;
            add_user.UseVisualStyleBackColor = true;
            add_user.Click += add_user_Click;
            // 
            // freight_delivery
            // 
            freight_delivery.Dock = DockStyle.Top;
            freight_delivery.FlatAppearance.BorderSize = 0;
            freight_delivery.FlatStyle = FlatStyle.Flat;
            freight_delivery.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            freight_delivery.ForeColor = SystemColors.Control;
            freight_delivery.Image = (Image)resources.GetObject("freight_delivery.Image");
            freight_delivery.ImageAlign = ContentAlignment.MiddleLeft;
            freight_delivery.Location = new Point(0, 115);
            freight_delivery.Name = "freight_delivery";
            freight_delivery.Padding = new Padding(10, 0, 0, 0);
            freight_delivery.Size = new Size(180, 50);
            freight_delivery.TabIndex = 3;
            freight_delivery.Text = "Freight delivery";
            freight_delivery.TextAlign = ContentAlignment.MiddleLeft;
            freight_delivery.TextImageRelation = TextImageRelation.ImageBeforeText;
            freight_delivery.UseVisualStyleBackColor = true;
            freight_delivery.Click += freight_delivery_Click;
            // 
            // regular_delivery
            // 
            regular_delivery.Dock = DockStyle.Top;
            regular_delivery.FlatAppearance.BorderSize = 0;
            regular_delivery.FlatStyle = FlatStyle.Flat;
            regular_delivery.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            regular_delivery.ForeColor = SystemColors.Control;
            regular_delivery.Image = Properties.Resources.orders_FILL0_wght400_GRAD0_opsz24;
            regular_delivery.ImageAlign = ContentAlignment.MiddleLeft;
            regular_delivery.Location = new Point(0, 65);
            regular_delivery.Name = "regular_delivery";
            regular_delivery.Padding = new Padding(10, 0, 0, 0);
            regular_delivery.Size = new Size(180, 50);
            regular_delivery.TabIndex = 2;
            regular_delivery.Text = "Regular delivery";
            regular_delivery.TextAlign = ContentAlignment.MiddleLeft;
            regular_delivery.TextImageRelation = TextImageRelation.ImageBeforeText;
            regular_delivery.UseVisualStyleBackColor = true;
            regular_delivery.Click += regular_delivery_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.DimGray;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(180, 65);
            panelLogo.TabIndex = 2;
            // 
            // nameSelect
            // 
            nameSelect.BackColor = Color.Gray;
            nameSelect.Controls.Add(labelTitle);
            nameSelect.Dock = DockStyle.Top;
            nameSelect.Location = new Point(180, 0);
            nameSelect.Name = "nameSelect";
            nameSelect.Size = new Size(732, 65);
            nameSelect.TabIndex = 2;
            nameSelect.MouseDown += nameSelect_MouseDown;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = SystemColors.Control;
            labelTitle.Location = new Point(328, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(68, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(180, 65);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(732, 431);
            panelDesktopPane.TabIndex = 3;
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 496);
            ControlBox = false;
            Controls.Add(panelDesktopPane);
            Controls.Add(nameSelect);
            Controls.Add(menuPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainform";
            Text = "Form1";
            menuPanel.ResumeLayout(false);
            nameSelect.ResumeLayout(false);
            nameSelect.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel menuPanel;
        private Panel panelLogo;
        private Button regular_delivery;
        private Button add_user_card;
        private Button add_user;
        private Button freight_delivery;
        private Button exit_btn;
        private Panel nameSelect;
        private Label labelTitle;
        private Panel panelDesktopPane;
        private Button DeleteUserbtn;
        private Button button1;
        private Button OperationsButton;
    }
}