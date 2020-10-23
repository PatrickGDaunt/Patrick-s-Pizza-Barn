using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patrick_s_Pizza_Barn
{
    public partial class PatricksPizzaBarnForm : Form
    {
        // Declare class variables
        private const double smallPizzaPrice = 7.00;
        private const double mediumPizzaPrice = 9.00;
        private const double largePizzaPrice = 12.00;
        private double pizzaPrice = 0;
        private string pizzaSize;
        string[] expiryDateArray = new string[5];
        string expiryDateString;
        bool formValidation = true;
        string[] phoneNumberArray = new string[12];
        string phoneNumberString;
        //
        // Class methods
        // Method determines pizza toppings price based on pizza size and adds to total
        public double PizzaToppings(string pizzaSize)
        {
            if (pizzaSize == "Large")
            {
                pizzaPrice += 1.00;
            }
            else if (pizzaSize == "Medium")
            {
                pizzaPrice += 0.75;
            }
            else
            {
                pizzaPrice += 0.50;
            }
            TotalPrice.Text = String.Format("Total: {0}", pizzaPrice.ToString("C2"));
            return pizzaPrice;
        }

        // Method removes toppings price from total
        public double RemovePizzaToppings(string pizzaSize)
        {
            if (pizzaSize == "Large")
            {
                pizzaPrice -= 1.00;
            }
            else if (pizzaSize == "Medium")
            {
                pizzaPrice -= 0.75;
            }
            else
            {
                pizzaPrice -= 0.50;
            }
            TotalPrice.Text = String.Format("Total: {0}", pizzaPrice.ToString("C2"));
            return pizzaPrice;
        }
        
        // Method to clear check boxes
        public void ClearToppings()
        {
            PepperoniCheckBox.Checked = false;
            HamCheckBox.Checked = false;
            PineappleCheckBox.Checked = false;
            MushroomsCheckBox.Checked = false;
            GreenPeppersCheckBox.Checked = false;
        }
        
        // Method to send price update to the TotalPriceLabel
        public void TotalPriceUpdate()
        {
            TotalPrice.Text = String.Format("Total: {0}", pizzaPrice.ToString("C2"));
        }

        // Method to validate DeliveryAddressTextBox
        public void ValidateDeliveryAddress()
        {
            if (String.IsNullOrEmpty(DeliveryAddressTextBox.Text))
            {
                NullAdress();
                formValidation = false;
            }
            else
            {
                formValidation = true;
            }
        }            

        // Method to display error message for null DeliveryAdressTextBox
        public void NullAdress()
        {
            string message = "Please enter a valid delivery address.";
            string caption = "Error!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        // Method to validate NameTextBox
        public void ValidateName()
        {
            if (String.IsNullOrEmpty(NameTextBox.Text))
            {
                NullName();
                formValidation = false;
            }
            else
            {
                formValidation = true;
            }
        }

        // Method to display an error message for null NameTextBox
        public void NullName()
        {
            string message = "Please enter a valid contact name.";
            string caption = "Error!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        // Method to validate PhoneNumberTextBox
        public void ValidatePhoneNumber()
        {
            if (String.IsNullOrEmpty(PhoneNumberTextBox.Text))
            {
                InvalidPhoneNumber();
                formValidation = false;
            }
            else
            {
                try
                {
                    phoneNumberString = PhoneNumberTextBox.Text;
                    for (int x = 0; x < PhoneNumberTextBox.Text.Length; x++)
                    {
                        phoneNumberArray[x] = Convert.ToString(phoneNumberString[x]);
                    }
                    int phoneNumberArrayIndex0 = Convert.ToInt32(phoneNumberArray[0]);
                    int phoneNumberArrayIndex1 = Convert.ToInt32(phoneNumberArray[1]);
                    int phoneNumberArrayIndex2 = Convert.ToInt32(phoneNumberArray[2]);
                    int phoneNumberArrayIndex4 = Convert.ToInt32(phoneNumberArray[4]);
                    int phoneNumberArrayIndex5 = Convert.ToInt32(phoneNumberArray[5]);
                    int phoneNumberArrayIndex6 = Convert.ToInt32(phoneNumberArray[6]);
                    int phoneNumberArrayIndex8 = Convert.ToInt32(phoneNumberArray[8]);
                    int phoneNumberArrayIndex9 = Convert.ToInt32(phoneNumberArray[9]);
                    int phoneNumberArrayIndex10 = Convert.ToInt32(phoneNumberArray[10]);
                    int phoneNumberArrayIndex11 = Convert.ToInt32(phoneNumberArray[11]);

                    if (phoneNumberArray[3] != "-")
                    {
                        InvalidPhoneNumber();
                        formValidation = false;
                    }
                    else if (phoneNumberArray[7] != "-")
                    {
                        InvalidPhoneNumber();
                        formValidation = false;
                    }
                }
                catch (Exception e)
                {
                    InvalidPhoneNumber();
                    formValidation = false;
                }
            }            
        }

        // Method to display an error message for an invalid phone number
        public void InvalidPhoneNumber()
        {
            string message = "Invalid contact phone number.";
            string caption = "Error!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }
              
        // Method to validate CreditCardTextBox
        public void ValidateCreditCardNumber()
        {
            if (CreditCardTextBox.Text.Length != 16)
            {
                InvalidCreditCardNumber();
                formValidation = false;
            }
            else
            {
                try
                {
                    int creditCardInt = Convert.ToInt32(CreditCardTextBox.Text);
                }
                catch (Exception e)
                {
                    InvalidCreditCardNumber();
                    formValidation = false;
                }
            }            
        }

        // Method to display an error message for an invalid credit card number
        public void InvalidCreditCardNumber()
        {
            string message = "Invalid credit card number.";
            string caption = "Error!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        // Method to validate ExpiryDateTextBox
        public void ValidateExpiryDate()
        {
            if (ExpiryTextBox.Text.Length != 5)
            {
                InvalidExpiryDate();
                formValidation = false;
            }
            else
            {
                try
                {
                    expiryDateString = ExpiryTextBox.Text;
                    for (int x = 0; x < expiryDateString.Length; x++)
                    {
                        expiryDateArray[x] = Convert.ToString(expiryDateString[x]);
                    }
                    int expiryDateArrayIndex0 = Convert.ToInt32(expiryDateArray[0]);
                    int expiryDateArrayIndex1 = Convert.ToInt32(expiryDateArray[1]);
                    int expiryDateArrayIndex3 = Convert.ToInt32(expiryDateArray[3]);
                    int expiryDateArrayIndex4 = Convert.ToInt32(expiryDateArray[4]);
                    if (expiryDateArrayIndex0 < 0 || expiryDateArrayIndex0 > 1)
                    {
                        InvalidExpiryDate();
                        formValidation = false;
                    }
                    else if (expiryDateArray[2] != "/")
                    {
                        InvalidExpiryDate();
                        formValidation = false;
                    }
                }
                catch (Exception e)
                {
                    InvalidExpiryDate();
                    formValidation = false;
                }
            }
        }

        // Method to display an error message for an invalid expiry date
        public void InvalidExpiryDate()
        {
            string message = "Invalid date entry. Please enter valid date in the MM/YY format.";
            string caption = "Error!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        // Method to clear form
        public void ClearForm()
        {
            ClearToppings();
            DeliveryAddressTextBox.Text = String.Empty;
            NameTextBox.Text = String.Empty;
            PhoneNumberTextBox.Text = String.Empty;
            CreditCardTextBox.Text = String.Empty;
            ExpiryTextBox.Text = String.Empty;
        }

        // Method to show successful order placed
        public void SuccessfulOrderPlacedMessage()
        {
            string message = String.Format("Thank you, {0}!\nYour order has been placed.",
                NameTextBox.Text);
            string caption = "Patrick's Pizza Barn";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }
        //
        //
        //
        public PatricksPizzaBarnForm()
        {
            InitializeComponent();
        }
        //
        //
        // Pizza size radio buttons
        private void SmallPizzaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SmallPizzaRadioButton.Checked)
            {
                pizzaSize = "Small";
                ToppingsPriceLabel.Text = String.Format("Add $0.50 for each topping.");
                ClearToppings();
                pizzaPrice = smallPizzaPrice;
                TotalPriceUpdate();
            } 
            else
            {
                pizzaPrice -= smallPizzaPrice;
            }     
        }
        private void MediumPizzaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MediumPizzaRadioButton.Checked)
            {                
                pizzaSize = "Medium";
                ToppingsPriceLabel.Text = String.Format("Add $0.75 for each topping.");                
                ClearToppings();
                pizzaPrice = mediumPizzaPrice;
                TotalPriceUpdate();
            }
            else
            {
                pizzaPrice -= mediumPizzaPrice;
            }
        }
        private void LargePizzaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LargePizzaRadioButton.Checked)
            {                
                pizzaSize = "Large";
                ToppingsPriceLabel.Text = String.Format("Add $1.00 for each topping.");             
                ClearToppings();
                pizzaPrice = largePizzaPrice;
                TotalPriceUpdate();
            }
            else
            {
                pizzaPrice -= largePizzaPrice;
            }
        }
        //
        //
        // Toppings check boxes
        private void PepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PepperoniCheckBox.Checked)
            {
                PizzaToppings(pizzaSize);
                
            }
            else
            {
                RemovePizzaToppings(pizzaSize);
            }     
        }
        private void HamCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HamCheckBox.Checked)
            {
                PizzaToppings(pizzaSize);
            }
            else
            {
                RemovePizzaToppings(pizzaSize);
            }
        }
        private void PineappleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PineappleCheckBox.Checked)
            {
                PizzaToppings(pizzaSize);
            }
            else
            {
                RemovePizzaToppings(pizzaSize);
            }
        }
        private void MushroomsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MushroomsCheckBox.Checked)
            {
                PizzaToppings(pizzaSize);
            }
            else
            {
                RemovePizzaToppings(pizzaSize);
            }
        }
        private void GreenPeppersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GreenPeppersCheckBox.Checked)
            {
                PizzaToppings(pizzaSize);
            }
            else
            {
                RemovePizzaToppings(pizzaSize);
            }
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            ValidateDeliveryAddress();
            ValidateName();
            ValidatePhoneNumber();
            ValidateCreditCardNumber();
            ValidateExpiryDate();
            if (formValidation == true)
            {
                SuccessfulOrderPlacedMessage();
                ClearForm();
            }                        
        }
    }
}
