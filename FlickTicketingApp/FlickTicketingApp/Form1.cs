using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlickTicketingApp
{
    
    public partial class Form1 : Form
    {
        // Variables used through the application
        double runningTotal = 0;
        double overallTotal = 0;
        int numberOfTicketsAdded = 0;
        int numberOfFreeTickets = 0;
        int numberOfTicketsToPayFor = 0;
        double moneySavedBasedOnOffers = 0;
        bool ifConcessionHasJustBeenSelected = false;
        bool ifStandardHasJustBeenSelected = false;
        string currentDay = "Thursday";

        public Form1()
        {
            InitializeComponent();
            // Update name of form
            this.Text = "Flick Ticket Application";
        }

        // If Standard Radiobutton is checked
        private void standardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // If standard radio button has been checked and concession radio button is not checked 
            // (and statement not required as the radio buttons are in a panel, however, good practise)
            if(standardRadioButton.Checked && !concessionRadioButton.Checked)
            {
                // Add £7.90 to the running total
                updateRunningTotal(7.90);
            }

            // Set the bool for the standard radio button to true
            ifStandardHasJustBeenSelected = true;

            // If concession ticket type has previously been selected then
            if (ifConcessionHasJustBeenSelected)
            {
                // Remove £5.40 from the running total
                updateRunningTotal(-5.40);
                // Reset boolean to false
                ifConcessionHasJustBeenSelected = false;
            }
        }

        // If Concession Radiobutton has been checked
        private void concessionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // If standard radio button is not checked and concession radio button is checked 
            if (!standardRadioButton.Checked && concessionRadioButton.Checked)
            {
                // Add £7.90 to the running total
                updateRunningTotal(5.40);
            }

            // Set the bool for the concession radio button to true
            ifConcessionHasJustBeenSelected = true;

            // If standard ticket type has previously been selected then
            if (ifStandardHasJustBeenSelected)
            {
                // Remove £-7.90 from the running total
                updateRunningTotal(-7.90);
                // Reset boolean to false               
                ifStandardHasJustBeenSelected = false;
            }
        }

        // Function which is used to add a value to the overall total - also updates the overall total label
        private void updateOverallTotal(double value)
        {
            // Plus equal (runningTotal = runningTotal + value) the value passed in to the running total
            overallTotal += value;
            // Update the label wi
            overallTotalLabel.Text = "Overall Total: £" + overallTotal.ToString();
        }

        // Function which is used to add a value to the running total - also updates the running total label
        private void updateRunningTotal(double value)
        {
            // Plus equal (runningTotal = runningTotal + value) the value passed in to the running total
            runningTotal += value;
            // Update the label wi
            totalLabel.Text = "Running Total: £" + runningTotal.ToString();
        }

        // If Add Ticket is pressed
        private void addTicketButton_Click(object sender, EventArgs e)
        {
            // If neither Standard or Concession Radio Buttons have been pressed then produce error
            if (!standardRadioButton.Checked && !concessionRadioButton.Checked)
            {
                MessageBox.Show("Please select a ticket type before continuing!", "Error");
            }
            // Else continue as normal
            else
            {
                // If ticket type is standard
                if (standardRadioButton.Checked)
                {
                    // Add £7.90 to the total
                    updateOverallTotal(7.90);
                }
                // Else ticket type must be concession
                else
                {
                    // Add £5.40 to the total
                    updateOverallTotal(5.40);
                }

                // If extra IMAX is selected
                if (imaxCheckBox.Checked)
                {
                    // Add £1.50 to the total
                    updateOverallTotal(1.50);
                }

                // If extra Real3D is selected
                if (realCheckBox.Checked)
                {
                    // Add £0.90 to the total
                    updateOverallTotal(0.90);
                }

                // Add to totally ticket count
                numberOfTicketsAdded += 1;
                numberOfTicketsLabel.Text = "Number of Tickets: " + numberOfTicketsAdded.ToString();

                // Check all current offers
                // Only offer is three for one thursdays
                if (currentDay == "Thursday")
                {
                    // Display messagebox notifying the user of the offer
                    MessageBox.Show("As the current day is Thursday, you are applicable for the Three for One Thursday special offer. As you are due to pay for one ticket, you will get an additional two free.", "Special Offer");
                    // Add and display number of free tickets due to the offer
                    numberOfFreeTickets += 2;
                    noOfFreeTicketsLabel.Text = "Offer (free) Tickets: " + numberOfFreeTickets.ToString();
                    // Add and display total number of tickets
                    numberOfTicketsAdded += 2;
                    numberOfTicketsLabel.Text = "Number of Tickets: " + numberOfTicketsAdded.ToString();
                    // Add and display the number of tickets to be paid for
                    numberOfTicketsToPayFor += 1;
                    noTicketsToPayForLabel.Text = "Number of Tickets to pay for: " + numberOfTicketsToPayFor.ToString();
                    // Calculate the money saved based on the offer
                    // If ticket type is standard
                    if (standardRadioButton.Checked)
                    {
                        // Add the value to two standard tickets
                        moneySavedBasedOnOffers += (7.90 * 2);
                    }
                    // Else ticket type must be concession
                    else
                    {
                        // Add the value of two concession tickets
                        moneySavedBasedOnOffers += (5.40 * 2);
                    }
                    // Update money saved label
                    totalSavingsLabel.Text = "Total Savings: £" + moneySavedBasedOnOffers.ToString();

                    // Clear current options in radio/check boxes
                    concessionRadioButton.Checked = false;
                    standardRadioButton.Checked = false;
                    imaxCheckBox.Checked = false;
                    realCheckBox.Checked = false;

                    // Reset running total to zero
                    runningTotal = 0.0;
                    totalLabel.Text = "Running Total: £0.0";
                }
                // Reset important booleans as if not reset running total would go negative
                ifStandardHasJustBeenSelected = false;
                ifConcessionHasJustBeenSelected = false;
            }
        }

        // If IMAX check box is pressed
        private void imaxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If IMAX check box is checked then
            if(imaxCheckBox.Checked)
            {
                // Add £1.50 to the running total
                updateRunningTotal(1.50);
            }
            // Else if IMAX check box is not checked then
            else
            {
                // Remove £1.50 from the running total
                updateRunningTotal(-1.50);
            }
        }

        // If Real3D check box is checked
        private void realCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If Real3D check box is checked then
            if (realCheckBox.Checked)
            {
                // Add £0.90 to the running total
                updateRunningTotal(0.90);
            }
            // Else if Real3D check box is not checked then
            else
            {
                // Remove £0.90 from the running total
                updateRunningTotal(-0.90);
            }
        }

        // If total button is pressed
        private void totalButton_Click(object sender, EventArgs e)
        {
            // If number of tickets to be paid for is less than one (ie 0)
            if (numberOfTicketsToPayFor < 1)
            {
                // Messagebox explaining the user hasnt added a ticket and has nothing to pay for
                MessageBox.Show("You have not yet added a ticket therefore have not been charged");
            }
            else
            {
                // Messagebox showing overall total, tickets to pay for, free tickets and saving
                if (MessageBox.Show("Your final total is £" + overallTotal + ".You are required to pay for " + numberOfTicketsToPayFor + " tickets will gaining " + numberOfFreeTickets + " free tickets which saves you £" + moneySavedBasedOnOffers + "!", "Pay and Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // If user pressed ok - exit application
                    System.Windows.Forms.Application.Exit();
                }
            }
        }
    }
}
