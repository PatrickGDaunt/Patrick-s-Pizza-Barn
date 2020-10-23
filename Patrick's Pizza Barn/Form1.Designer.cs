namespace Patrick_s_Pizza_Barn
{
    partial class PatricksPizzaBarnForm
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
            this.PizzaSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.PizzaSizeLabel = new System.Windows.Forms.Label();
            this.LargePizzaRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumPizzaRadioButton = new System.Windows.Forms.RadioButton();
            this.SmallPizzaRadioButton = new System.Windows.Forms.RadioButton();
            this.ToppingsGroupBox = new System.Windows.Forms.GroupBox();
            this.ToppingsPriceLabel = new System.Windows.Forms.Label();
            this.ToppingsLabel1 = new System.Windows.Forms.Label();
            this.GreenPeppersCheckBox = new System.Windows.Forms.CheckBox();
            this.MushroomsCheckBox = new System.Windows.Forms.CheckBox();
            this.PineappleCheckBox = new System.Windows.Forms.CheckBox();
            this.HamCheckBox = new System.Windows.Forms.CheckBox();
            this.PepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.ContactInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressLabel = new System.Windows.Forms.Label();
            this.PaymentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ExpiryTextBox = new System.Windows.Forms.TextBox();
            this.CreditCardTextBox = new System.Windows.Forms.TextBox();
            this.CCExpiryLabel = new System.Windows.Forms.Label();
            this.CreditCardLabel = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.PizzaSizeGroupBox.SuspendLayout();
            this.ToppingsGroupBox.SuspendLayout();
            this.ContactInfoGroupBox.SuspendLayout();
            this.PaymentInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PizzaSizeGroupBox
            // 
            this.PizzaSizeGroupBox.Controls.Add(this.PizzaSizeLabel);
            this.PizzaSizeGroupBox.Controls.Add(this.LargePizzaRadioButton);
            this.PizzaSizeGroupBox.Controls.Add(this.MediumPizzaRadioButton);
            this.PizzaSizeGroupBox.Controls.Add(this.SmallPizzaRadioButton);
            this.PizzaSizeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaSizeGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PizzaSizeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.PizzaSizeGroupBox.Name = "PizzaSizeGroupBox";
            this.PizzaSizeGroupBox.Size = new System.Drawing.Size(200, 145);
            this.PizzaSizeGroupBox.TabIndex = 0;
            this.PizzaSizeGroupBox.TabStop = false;
            this.PizzaSizeGroupBox.Text = "Size";
            // 
            // PizzaSizeLabel
            // 
            this.PizzaSizeLabel.AutoSize = true;
            this.PizzaSizeLabel.Location = new System.Drawing.Point(6, 31);
            this.PizzaSizeLabel.Name = "PizzaSizeLabel";
            this.PizzaSizeLabel.Size = new System.Drawing.Size(110, 13);
            this.PizzaSizeLabel.TabIndex = 3;
            this.PizzaSizeLabel.Text = "Please choose a size.";
            // 
            // LargePizzaRadioButton
            // 
            this.LargePizzaRadioButton.AutoSize = true;
            this.LargePizzaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LargePizzaRadioButton.Location = new System.Drawing.Point(7, 106);
            this.LargePizzaRadioButton.Name = "LargePizzaRadioButton";
            this.LargePizzaRadioButton.Size = new System.Drawing.Size(186, 33);
            this.LargePizzaRadioButton.TabIndex = 2;
            this.LargePizzaRadioButton.TabStop = true;
            this.LargePizzaRadioButton.Text = "Large ($12.00)";
            this.LargePizzaRadioButton.UseVisualStyleBackColor = true;
            this.LargePizzaRadioButton.CheckedChanged += new System.EventHandler(this.LargePizzaRadioButton_CheckedChanged);
            // 
            // MediumPizzaRadioButton
            // 
            this.MediumPizzaRadioButton.AutoSize = true;
            this.MediumPizzaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MediumPizzaRadioButton.Location = new System.Drawing.Point(6, 83);
            this.MediumPizzaRadioButton.Name = "MediumPizzaRadioButton";
            this.MediumPizzaRadioButton.Size = new System.Drawing.Size(125, 21);
            this.MediumPizzaRadioButton.TabIndex = 1;
            this.MediumPizzaRadioButton.TabStop = true;
            this.MediumPizzaRadioButton.Text = "Medium ($9.00)";
            this.MediumPizzaRadioButton.UseVisualStyleBackColor = true;
            this.MediumPizzaRadioButton.CheckedChanged += new System.EventHandler(this.MediumPizzaRadioButton_CheckedChanged);
            // 
            // SmallPizzaRadioButton
            // 
            this.SmallPizzaRadioButton.AutoSize = true;
            this.SmallPizzaRadioButton.Location = new System.Drawing.Point(6, 60);
            this.SmallPizzaRadioButton.Name = "SmallPizzaRadioButton";
            this.SmallPizzaRadioButton.Size = new System.Drawing.Size(86, 17);
            this.SmallPizzaRadioButton.TabIndex = 0;
            this.SmallPizzaRadioButton.TabStop = true;
            this.SmallPizzaRadioButton.Text = "Small ($7.00)";
            this.SmallPizzaRadioButton.UseVisualStyleBackColor = true;
            this.SmallPizzaRadioButton.CheckedChanged += new System.EventHandler(this.SmallPizzaRadioButton_CheckedChanged);
            // 
            // ToppingsGroupBox
            // 
            this.ToppingsGroupBox.Controls.Add(this.ToppingsPriceLabel);
            this.ToppingsGroupBox.Controls.Add(this.ToppingsLabel1);
            this.ToppingsGroupBox.Controls.Add(this.GreenPeppersCheckBox);
            this.ToppingsGroupBox.Controls.Add(this.MushroomsCheckBox);
            this.ToppingsGroupBox.Controls.Add(this.PineappleCheckBox);
            this.ToppingsGroupBox.Controls.Add(this.HamCheckBox);
            this.ToppingsGroupBox.Controls.Add(this.PepperoniCheckBox);
            this.ToppingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingsGroupBox.Location = new System.Drawing.Point(6, 151);
            this.ToppingsGroupBox.Name = "ToppingsGroupBox";
            this.ToppingsGroupBox.Size = new System.Drawing.Size(200, 195);
            this.ToppingsGroupBox.TabIndex = 1;
            this.ToppingsGroupBox.TabStop = false;
            this.ToppingsGroupBox.Text = "Toppings";
            // 
            // ToppingsPriceLabel
            // 
            this.ToppingsPriceLabel.AutoSize = true;
            this.ToppingsPriceLabel.Location = new System.Drawing.Point(6, 37);
            this.ToppingsPriceLabel.Name = "ToppingsPriceLabel";
            this.ToppingsPriceLabel.Size = new System.Drawing.Size(101, 13);
            this.ToppingsPriceLabel.TabIndex = 6;
            this.ToppingsPriceLabel.Text = "ToppingsPriceLabel";
            // 
            // ToppingsLabel1
            // 
            this.ToppingsLabel1.AutoSize = true;
            this.ToppingsLabel1.Location = new System.Drawing.Point(6, 20);
            this.ToppingsLabel1.Name = "ToppingsLabel1";
            this.ToppingsLabel1.Size = new System.Drawing.Size(159, 13);
            this.ToppingsLabel1.TabIndex = 5;
            this.ToppingsLabel1.Text = "Please choose up to 5 toppings.";
            // 
            // GreenPeppersCheckBox
            // 
            this.GreenPeppersCheckBox.AutoSize = true;
            this.GreenPeppersCheckBox.Location = new System.Drawing.Point(6, 152);
            this.GreenPeppersCheckBox.Name = "GreenPeppersCheckBox";
            this.GreenPeppersCheckBox.Size = new System.Drawing.Size(97, 17);
            this.GreenPeppersCheckBox.TabIndex = 4;
            this.GreenPeppersCheckBox.Text = "Green Peppers";
            this.GreenPeppersCheckBox.UseVisualStyleBackColor = true;
            this.GreenPeppersCheckBox.CheckedChanged += new System.EventHandler(this.GreenPeppersCheckBox_CheckedChanged);
            // 
            // MushroomsCheckBox
            // 
            this.MushroomsCheckBox.AutoSize = true;
            this.MushroomsCheckBox.Location = new System.Drawing.Point(6, 129);
            this.MushroomsCheckBox.Name = "MushroomsCheckBox";
            this.MushroomsCheckBox.Size = new System.Drawing.Size(80, 17);
            this.MushroomsCheckBox.TabIndex = 3;
            this.MushroomsCheckBox.Text = "Mushrooms";
            this.MushroomsCheckBox.UseVisualStyleBackColor = true;
            this.MushroomsCheckBox.CheckedChanged += new System.EventHandler(this.MushroomsCheckBox_CheckedChanged);
            // 
            // PineappleCheckBox
            // 
            this.PineappleCheckBox.AutoSize = true;
            this.PineappleCheckBox.Location = new System.Drawing.Point(6, 106);
            this.PineappleCheckBox.Name = "PineappleCheckBox";
            this.PineappleCheckBox.Size = new System.Drawing.Size(73, 17);
            this.PineappleCheckBox.TabIndex = 2;
            this.PineappleCheckBox.Text = "Pineapple";
            this.PineappleCheckBox.UseVisualStyleBackColor = true;
            this.PineappleCheckBox.CheckedChanged += new System.EventHandler(this.PineappleCheckBox_CheckedChanged);
            // 
            // HamCheckBox
            // 
            this.HamCheckBox.AutoSize = true;
            this.HamCheckBox.Location = new System.Drawing.Point(6, 83);
            this.HamCheckBox.Name = "HamCheckBox";
            this.HamCheckBox.Size = new System.Drawing.Size(48, 17);
            this.HamCheckBox.TabIndex = 1;
            this.HamCheckBox.Text = "Ham";
            this.HamCheckBox.UseVisualStyleBackColor = true;
            this.HamCheckBox.CheckedChanged += new System.EventHandler(this.HamCheckBox_CheckedChanged);
            // 
            // PepperoniCheckBox
            // 
            this.PepperoniCheckBox.AutoSize = true;
            this.PepperoniCheckBox.Location = new System.Drawing.Point(6, 60);
            this.PepperoniCheckBox.Name = "PepperoniCheckBox";
            this.PepperoniCheckBox.Size = new System.Drawing.Size(74, 17);
            this.PepperoniCheckBox.TabIndex = 0;
            this.PepperoniCheckBox.Text = "Pepperoni";
            this.PepperoniCheckBox.UseVisualStyleBackColor = true;
            this.PepperoniCheckBox.CheckedChanged += new System.EventHandler(this.PepperoniCheckBox_CheckedChanged);
            // 
            // ContactInfoGroupBox
            // 
            this.ContactInfoGroupBox.Controls.Add(this.PhoneNumberTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.PhoneNumberLabel);
            this.ContactInfoGroupBox.Controls.Add(this.NameTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.DeliveryAddressTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.NameLabel);
            this.ContactInfoGroupBox.Controls.Add(this.DeliveryAddressLabel);
            this.ContactInfoGroupBox.Location = new System.Drawing.Point(207, -1);
            this.ContactInfoGroupBox.Name = "ContactInfoGroupBox";
            this.ContactInfoGroupBox.Size = new System.Drawing.Size(349, 131);
            this.ContactInfoGroupBox.TabIndex = 2;
            this.ContactInfoGroupBox.TabStop = false;
            this.ContactInfoGroupBox.Text = "Contact Information";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(130, 107);
            this.PhoneNumberTextBox.MaxLength = 12;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(72, 20);
            this.PhoneNumberTextBox.TabIndex = 5;
            this.PhoneNumberTextBox.Text = "xxx-xxx-xxxx";
            this.PhoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(10, 107);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 4;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(131, 65);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(212, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // DeliveryAddressTextBox
            // 
            this.DeliveryAddressTextBox.Location = new System.Drawing.Point(131, 13);
            this.DeliveryAddressTextBox.Multiline = true;
            this.DeliveryAddressTextBox.Name = "DeliveryAddressTextBox";
            this.DeliveryAddressTextBox.Size = new System.Drawing.Size(212, 45);
            this.DeliveryAddressTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(7, 65);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // DeliveryAddressLabel
            // 
            this.DeliveryAddressLabel.AutoSize = true;
            this.DeliveryAddressLabel.Location = new System.Drawing.Point(7, 20);
            this.DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            this.DeliveryAddressLabel.Size = new System.Drawing.Size(86, 13);
            this.DeliveryAddressLabel.TabIndex = 0;
            this.DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // PaymentInfoGroupBox
            // 
            this.PaymentInfoGroupBox.Controls.Add(this.ExpiryTextBox);
            this.PaymentInfoGroupBox.Controls.Add(this.CreditCardTextBox);
            this.PaymentInfoGroupBox.Controls.Add(this.CCExpiryLabel);
            this.PaymentInfoGroupBox.Controls.Add(this.CreditCardLabel);
            this.PaymentInfoGroupBox.Location = new System.Drawing.Point(206, 138);
            this.PaymentInfoGroupBox.Name = "PaymentInfoGroupBox";
            this.PaymentInfoGroupBox.Size = new System.Drawing.Size(349, 90);
            this.PaymentInfoGroupBox.TabIndex = 3;
            this.PaymentInfoGroupBox.TabStop = false;
            this.PaymentInfoGroupBox.Text = "Payment Information";
            // 
            // ExpiryTextBox
            // 
            this.ExpiryTextBox.Location = new System.Drawing.Point(132, 58);
            this.ExpiryTextBox.MaxLength = 5;
            this.ExpiryTextBox.Name = "ExpiryTextBox";
            this.ExpiryTextBox.Size = new System.Drawing.Size(49, 20);
            this.ExpiryTextBox.TabIndex = 3;
            this.ExpiryTextBox.Text = " MM/YY  ";
            // 
            // CreditCardTextBox
            // 
            this.CreditCardTextBox.Location = new System.Drawing.Point(131, 13);
            this.CreditCardTextBox.MaxLength = 16;
            this.CreditCardTextBox.Name = "CreditCardTextBox";
            this.CreditCardTextBox.Size = new System.Drawing.Size(212, 20);
            this.CreditCardTextBox.TabIndex = 2;
            // 
            // CCExpiryLabel
            // 
            this.CCExpiryLabel.AutoSize = true;
            this.CCExpiryLabel.Location = new System.Drawing.Point(10, 65);
            this.CCExpiryLabel.Name = "CCExpiryLabel";
            this.CCExpiryLabel.Size = new System.Drawing.Size(81, 13);
            this.CCExpiryLabel.TabIndex = 1;
            this.CCExpiryLabel.Text = "Expiry (MM/YY)";
            // 
            // CreditCardLabel
            // 
            this.CreditCardLabel.AutoSize = true;
            this.CreditCardLabel.Location = new System.Drawing.Point(7, 20);
            this.CreditCardLabel.Name = "CreditCardLabel";
            this.CreditCardLabel.Size = new System.Drawing.Size(99, 13);
            this.CreditCardLabel.TabIndex = 0;
            this.CreditCardLabel.Text = "Credit Card Number";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(335, 238);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(78, 13);
            this.TotalPrice.TabIndex = 4;
            this.TotalPrice.Text = "TotalPriceHere";
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PlaceOrderButton.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderButton.Location = new System.Drawing.Point(259, 274);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(226, 40);
            this.PlaceOrderButton.TabIndex = 5;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.UseVisualStyleBackColor = false;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // PatricksPizzaBarnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 352);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.PlaceOrderButton);
            this.Controls.Add(this.PaymentInfoGroupBox);
            this.Controls.Add(this.ContactInfoGroupBox);
            this.Controls.Add(this.ToppingsGroupBox);
            this.Controls.Add(this.PizzaSizeGroupBox);
            this.Name = "PatricksPizzaBarnForm";
            this.Text = "Patrick\'s Pizza Barn";
            this.PizzaSizeGroupBox.ResumeLayout(false);
            this.PizzaSizeGroupBox.PerformLayout();
            this.ToppingsGroupBox.ResumeLayout(false);
            this.ToppingsGroupBox.PerformLayout();
            this.ContactInfoGroupBox.ResumeLayout(false);
            this.ContactInfoGroupBox.PerformLayout();
            this.PaymentInfoGroupBox.ResumeLayout(false);
            this.PaymentInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PizzaSizeGroupBox;
        private System.Windows.Forms.Label PizzaSizeLabel;
        private System.Windows.Forms.RadioButton LargePizzaRadioButton;
        private System.Windows.Forms.RadioButton MediumPizzaRadioButton;
        private System.Windows.Forms.RadioButton SmallPizzaRadioButton;
        private System.Windows.Forms.GroupBox ToppingsGroupBox;
        private System.Windows.Forms.CheckBox GreenPeppersCheckBox;
        private System.Windows.Forms.CheckBox MushroomsCheckBox;
        private System.Windows.Forms.CheckBox PineappleCheckBox;
        private System.Windows.Forms.CheckBox HamCheckBox;
        private System.Windows.Forms.CheckBox PepperoniCheckBox;
        private System.Windows.Forms.GroupBox ContactInfoGroupBox;
        private System.Windows.Forms.GroupBox PaymentInfoGroupBox;
        private System.Windows.Forms.Label ToppingsLabel1;
        private System.Windows.Forms.Label ToppingsPriceLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DeliveryAddressTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DeliveryAddressLabel;
        private System.Windows.Forms.TextBox ExpiryTextBox;
        private System.Windows.Forms.TextBox CreditCardTextBox;
        private System.Windows.Forms.Label CCExpiryLabel;
        private System.Windows.Forms.Label CreditCardLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Label TotalPrice;
    }
}

