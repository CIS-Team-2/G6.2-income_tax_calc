﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/***************************************************************************************************
* CIS 123: Introduction to OOP     |    Exercise 6-2 Add a method and an event handler to the      *
* Murach's C#, 7th Edition         |         income tax calculator                                 *
* Chapter 6 Extra Exercises        |                                                               *
* Team 2 Assignment, 04MAY2022     |    Base code, form, and instructions  provided by Murach      *
* Patrick McKee & Dominique Tepper |    Modified by Team 2 for academic practice                   *                    
***************************************************************************************************/


namespace TaxCalculator
{
    public partial class frmIncomeTaxCalculator : Form
    {
        public frmIncomeTaxCalculator()
        {
            InitializeComponent();
        }
/* ************************************************************************************
 * 2. Code the declaration for a private method named CalculateTax()    |             *
 *    The method should:                                                |             *
 *                                                                      |             *
 *          A. Receive the income amount                                |             *
 *          B. Return the tax amount                                    |             *
 *                                                                      |   McKee     *
 * 3-A. Move the if-else statement in the btnCalculate_Click() event    |   &         *
 *    handler to the CalculateTax() method.                             |   Tepper    *
 *                                                                      |             *
 * 3-B. Declare a variable for the tax at the beginning of the          |             *
 *    CalculateTax() method.                                            |             *
 *                                                                      |             *
 * 3-C. Return the tax at the end of the method.                        |             *
 * ***********************************************************************************/
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(txtIncome.Text);

            decimal tax = 0m;

            if (income <= 9875)
                tax = (int)(income * .10m);
            else if (income > 9875 && income <= 40125)
                tax = 987.5m + (int)((income - 9875) * .12m);
            else if (income > 40125 && income <= 85525)
                tax = 4617.5m + (int)((income - 40125) * .22m);
            else if (income > 85525 && income <= 163300)
                tax = 14605.5m + (int)((income - 85525) * .24m);
            else if (income > 163300 && income <= 207350)
                tax = 33271.5m + (int)((income - 163300) * .32m);
            else if (income > 207351 && income <= 518400)
                tax = 47367.5m + (int)((income - 518400) * .35m);
            else if (income > 518401)
                tax = 156235m + (int)((income - 518400) * .37m);

            txtTax.Text = tax.ToString();
        }


/* ************************************************************************************
 * 4. Modify the statement in the btnCalculate_Click() event handler    |   McKee     *
 *    that declares the tax variable so it gets its value by calling    |   &         *
 *    the CalculateTax() method.                                        |   Tepper    *
 * ***********************************************************************************/



/* ************************************************************************************
 * 5. Create an event handler that clears the Income Tax Owed text box  |   McKee  &  *
 *    if the user changes the value in the Taxable Income text box.     |   Tepper    *
 * ***********************************************************************************/


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}