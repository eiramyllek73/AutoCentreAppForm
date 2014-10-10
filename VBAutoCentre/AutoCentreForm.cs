//Name:  Kelly Mcalpine - 200269425
//Date:  October 10 2014
//Purpose:  To create a form that calculates the outstanding balance due
//for the purchase of a vehicle (which includes price, accessories, 
//exterior finish options selected and a trade-in value if any, 
//that are inputted by the user). 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBAutoCentre
{
    public partial class AutoCentreForm : Form
    {
        //module level variables - 
        //objects default to null and numbers default to 0
        private RadioButton selectedRadioButton = null;
        decimal carSalesDecimal = 0, accessoriesDecimal = 0,
            subTotalDecimal = 0, totalDecimal = 0, tradeDecimal = 0, amountDueDecimal = 0;

        //module level constants
        const decimal SALES_TAX_RATE_Decimal = 0.15m;
        const decimal STEREO_SYSTEM_Decimal = 425.76m;
        const decimal LEATHER_Decimal = 987.41m;
        const decimal COMPUTER_NAV_Decimal = 1741.23m;
        const decimal STANDARD_Decimal = 0;
        const decimal PEARL_Decimal = 345.72m;
        const decimal CUSTOM_Decimal = 599.99m;

        public AutoCentreForm()
        {
            InitializeComponent();
        }

        private void AutoCentreForm_Load(object sender, EventArgs e)
        {
            //Have the user's attention point toward entering the car sales price first
            //Standard option is checked as it's included in the price
            standardFinishRadioButton.Checked = true;
            accessoriesTextBox.Text = "0.00";
            carSalesTextBox.Text = "0.00";
            tradeTextBox.Text = "0.00";
            carSalesTextBox.Select();
            carSalesTextBox.Focus();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadioButton = (RadioButton)sender;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Calculate the amount due for the car purchase after
            //all options are selected, trade-in allowance (if any) 
            // then Sales Tax applied

            decimal taxDecimal;

            //catch if the user does not provide an input in the car sales text box, 
            //as well as if the input is invalid or out of range
            try
            {
                //convert/cast car sales text to numeric properties 
                carSalesDecimal = decimal.Parse(carSalesTextBox.Text);

                if (carSalesDecimal > 0)
                {
                    //catch if the user does not provide an input in the trade-in allowance text box, 
                    //as well as if the input is invalid or out of range
                    try
                    {
                        //convert/cast trade-in allowance text to numeric properties
                        tradeDecimal = decimal.Parse(tradeTextBox.Text);
                        if (tradeDecimal >= 0)
                        {
                            //add the total cost of accessories selected
                            if (stereoCheckBox.Checked)
                            {
                                accessoriesDecimal = accessoriesDecimal + STEREO_SYSTEM_Decimal;
                            }
                            if (leatherCheckBox.Checked)
                            {
                                accessoriesDecimal = accessoriesDecimal + LEATHER_Decimal;
                            }
                            if (computerNavCheckBox.Checked)
                            {
                                accessoriesDecimal = accessoriesDecimal + COMPUTER_NAV_Decimal;
                            }

                            //add the total cost of accessories from above code to the finish selected
                            switch (selectedRadioButton.Name)
                            {
                                case "standardFinishRadioButton":
                                    accessoriesDecimal += STANDARD_Decimal;
                                    break;
                                case "pearlFinishRadioButton":
                                    accessoriesDecimal += PEARL_Decimal;
                                    break;
                                case "customDetailRadioButton":
                                    accessoriesDecimal += CUSTOM_Decimal;
                                    break;
                            }

                            //calculate the amounts

                            //Subtotal
                            subTotalDecimal = carSalesDecimal + accessoriesDecimal;

                            //Add Tax to Subtotal
                            taxDecimal = subTotalDecimal * SALES_TAX_RATE_Decimal;

                            //Total before Trade-in deduction
                            totalDecimal = subTotalDecimal + taxDecimal;

                            //Calculate Amount Due - subtract Trade-in Allowance if any
                            amountDueDecimal = totalDecimal - tradeDecimal;

                            //format and display all textbox outputs with currency
                            accessoriesTextBox.Text = accessoriesDecimal.ToString("c");
                            subTotalTextBox.Text = subTotalDecimal.ToString("c");
                            salesTaxTextBox.Text = taxDecimal.ToString("c");
                            totalTextBox.Text = totalDecimal.ToString("c");
                            amountDueTextBox.Text = amountDueDecimal.ToString("c");
                        }

                        else
                        {
                            MessageBox.Show("A positive number must be entered into the Trade-in Allowance box." + 
                                "If there is no trade-in allowance applicable, please input a 0.",
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tradeTextBox.Select();
                            tradeTextBox.Focus();
                        }
                    }
                    catch (FormatException tradeFE)
                    {
                        MessageBox.Show("A positive number must be entered into the Trade-in Allowance box." +
                                "If there is no trade-in allowance applicable, please input a 0.",
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tradeTextBox.Select();
                        tradeTextBox.Focus();
                    }
                    catch (OverflowException tradeOE)
                    {
                        MessageBox.Show("Price value is out of range.",
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        carSalesPriceLabel.Select();
                        carSalesTextBox.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:  " + ex.Message, 
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("A positive number must be entered into the Car Sales Price box.",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    carSalesTextBox.Select();
                    carSalesTextBox.Focus();
                }
            }
            catch (FormatException carSalesFE)
            {
                MessageBox.Show("A positive number must be entered into the Car Sales Price box.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                carSalesPriceLabel.Select();
                carSalesTextBox.Focus();
            }
            catch (OverflowException carSalesOE)
            {
                MessageBox.Show("Price value is out of range.",
                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                carSalesPriceLabel.Select();
                carSalesTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the current details on the form to start again
            //after confriming with the user
            DialogResult responseDialogResult;
            responseDialogResult = MessageBox.Show("Are you sure you want to clear the current form?",
                "Clear Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (responseDialogResult == DialogResult.Yes)
            {
                carSalesTextBox.Clear();
                accessoriesTextBox.Clear();
                subTotalTextBox.Clear();
                salesTaxTextBox.Clear();
                totalTextBox.Clear();
                tradeTextBox.Clear();
                amountDueTextBox.Clear();
                stereoCheckBox.Checked = false;
                leatherCheckBox.Checked = false;
                computerNavCheckBox.Checked = false;
                standardFinishRadioButton.Checked = true;
                pearlFinishRadioButton.Checked = false;
                customDetailRadioButton.Checked = false;
                carSalesTextBox.Text = "0.00";
                tradeTextBox.Text = "0.00";
                carSalesTextBox.Select();
                carSalesTextBox.Focus();
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit the program
            this.Close();
        }

    }
}
