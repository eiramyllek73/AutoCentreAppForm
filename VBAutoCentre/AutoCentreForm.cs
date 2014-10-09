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
        private CheckBox selectedCheckBox = null;
        decimal carSalesDecimal = 0, accessoriesDecimal = 0,
            subTotalDecimal = 0, totalDecimal = 0, tradeDecimal = 0, amountDueDecimal = 0;

        //module level constants
        const decimal salesTaxRateDecimal = 0.15m;
        const decimal stereoSystemDecimal = 425.76m;
        const decimal leatherDecimal = 987.41m;
        const decimal computerNavDecimal = 1741.23m;
        const decimal standardDecimal = 0;
        const decimal pearlDecimal = 345.72m;
        const decimal customDecimal = 599.99m;

        public AutoCentreForm()
        {
            InitializeComponent();
        }

        private void AutoCentreForm_Load(object sender, EventArgs e)
        {
            //Have the user's attention point toward entering the car sales price first
            //Standard option is checked as it's included in the price
            standardFinishRadioButton.Checked = true;
            carSalesTextBox.Select();
            carSalesTextBox.Focus();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            selectedCheckBox = (CheckBox)sender;
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

            decimal priceDecimal, taxDecimal;

            //catch if the use does not provide an input
            try
            {
                //convert/cast text to numeric properties before calculations can be made 
                priceDecimal = decimal.Parse(carSalesTextBox.Text
                    + accessoriesTextBox.Text + subTotalTextBox.Text
                    + salesTaxTextBox.Text + totalTextBox.Text
                    + tradeTextBox.Text + amountDueTextBox.Text);

                if (carSalesDecimal > 0)
                {
                    if (selectedCheckBox != null)
                    {
                        switch (selectedCheckBox.Name)
                        {
                            case "stereoCheckBox":
                                priceDecimal = stereoSystemDecimal;
                                break;
                            case "leatherCheckBox":
                                priceDecimal = leatherDecimal;
                                break;
                            case "computerNavCheckBox":
                                priceDecimal = computerNavDecimal;
                                break;
                        }
                        if (selectedRadioButton != null)
                        {
                            switch (selectedRadioButton.Name)
                            {
                                case "standardRadioButton":
                                    priceDecimal = standardDecimal;
                                    break;
                                case "pearlRadioButton":
                                    priceDecimal = pearlDecimal;
                                    break;
                                case "customDetailRadioButton":
                                    priceDecimal = customDecimal;
                                    break;
                            }
                        }
                        //calculate the amounts

                        //total of Accessories and Finish
                        accessoriesDecimal =
                            stereoSystemDecimal
                            + leatherDecimal
                            + computerNavDecimal
                            + standardDecimal
                            + pearlDecimal
                            + customDecimal;

                        //Subtotal
                        subTotalDecimal = carSalesDecimal + accessoriesDecimal;

                        //Add Tax to Subtotal
                        taxDecimal = subTotalDecimal * salesTaxRateDecimal;

                        //Total before Trade-in deduction
                        taxDecimal = subTotalDecimal * salesTaxRateDecimal
                            + subTotalDecimal;
                        //Calculate Amount Due - subtract Trade-in Allowance if any
                        amountDueDecimal = totalDecimal - tradeDecimal;

                        //format and display
                        carSalesTextBox.Text = carSalesDecimal.ToString("c");
                        accessoriesTextBox.Text = accessoriesDecimal.ToString("c");
                        subTotalTextBox.Text = subTotalDecimal.ToString("c");
                        salesTaxTextBox.Text = taxDecimal.ToString("c");
                        totalTextBox.Text = taxDecimal.ToString("c");
                        tradeTextBox.Text = tradeDecimal.ToString("c");
                        amountDueTextBox.Text = amountDueDecimal.ToString("c");

                        //set other controls
                        clearButton.Enabled = true;
                        exitButton.Enabled = true;
                    }
                }

                else
                {
                    MessageBox.Show("There must be a valid price listed in the Car Sales Price box.",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    carSalesPriceLabel.Select();
                    carSalesTextBox.Focus();
                }
            }
            catch (FormatException carSalesFE)
            {
                if (carSalesTextBox.Text == "")
                {
                    MessageBox.Show("There must be a valid price listed in the Car Sales Price box.",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    carSalesPriceLabel.Select();
                    carSalesTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Price must be a positive number.",
                       "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    carSalesPriceLabel.Select();
                    carSalesTextBox.Focus();
                }
            }
            catch (OverflowException carSalesOE)
            {
                MessageBox.Show("Price value out of range.",
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

            if(responseDialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                clearButton_Click(sender, e);
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
                standardFinishRadioButton.Checked = false;
                pearlFinishRadioButton.Checked = false;
                customDetailRadioButton.Checked = false;
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit the program
            this.Close();
        }

    }
}
