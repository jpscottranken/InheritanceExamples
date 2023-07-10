using LetterLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 *	LB1 Letters
 *	
 *	Create a GUI application for a letter delivery service:
 *	
 *	●	Letters cost 50 cents to send.
 *	
 *	●	Certified letters cost an additional 15 cents
 *		to send, but include a tracking number.
 *
 *	●	The user can send up to 20 letters.
 *
 *	●	Every time a letter is sent it will be added
 *		to the top of the transaction log.
 *
 *	●	If the letter does not include a tracking number
 *		then instantiate a Letter object.
 *
 *	●	If the letter includes a tracking number then
 *		instantiate a CertifiedLetter object.
 */


namespace LB1_Letters
{
    public partial class frmLetters : Form
    {
        public frmLetters()
        {
            InitializeComponent();
        }

        //  Global constant
        const int TOTALLETTERS = 10;

        //  Global variables
        List<Letter> letters             = new List<Letter>(TOTALLETTERS);
        List<CertifiedLetter> certified  = new List<CertifiedLetter>(TOTALLETTERS);
        string[] sentLetters             = new string[TOTALLETTERS];
        int numElements                  = 0;
        DateTime sentDate; 

        private void frmLetters_Load(object sender, EventArgs e)
        {
            lblAdditionalFee.Visible = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //  Validate recipient textbox was not empty
            bool keepGoing = IsValidRecipient();

            //  There was a value in the recipient textbox
            if (keepGoing)
            {
                //  Validate there is a value in the SentDate textbox
                keepGoing = IsValidSentDate();
            }
            else
            {
                //  Nothing in recipient textbox
                return;
            }

            //  There was a valid date in the
            //  Sent Date textbox
            if (keepGoing)
            {
               
                keepGoing = IsThereATrackingNumber();
            }
            else
            { 
                return;
            }

            //  There was a tracking number so
            //  instantiate a CertifiedLetter object
            if (keepGoing)
            {
                InstantiateACertifiedLetterObject();
            }
            //  There was NOT a tracking number so
            //  instantiate a Letter object
            else
            {
                InstantiateALetterObject();
            }
        }

        //  Validate that Recipient textbox not empty
        private bool IsValidRecipient()
        {
            bool retVal = true;

            if (txtRecipient.Text.Trim() == "")
            {
                //  Nothing in the recipient textbox
                ShowMessage("Recipient Name Cannot Be Empty",
                            "RECIPIENT FIELD EMPTY!");
                txtRecipient.Focus();
                retVal = false;
            }

            return retVal;
        }

        //  Validate that Sent Date textbox not empty
        //  and that the textbox holds a valid date
        private bool IsValidSentDate()
        {
            bool retVal = true;
            bool result;

            if (txtSentDate.Text.Trim() == "")
            {
                //  Nothing in the sent date textbox
                ShowMessage("Sent Date Cannot Be Empty",
                            "SENT DATE FIELD EMPTY!");
                txtSentDate.Focus();
                retVal = false;
            }

            //  There was something in the Sent Date
            //  textbox. Verify it holds a date.
            result = DateTime.TryParse(txtSentDate.Text,
                                        out sentDate);

            //  Check for non-date value in the
            //  Sent Date textbox
            if (!result)
            {
                ShowMessage("Invalid Sent Date Entry",
                            "SENT DATE FIELD CONTENTS INVALID!");
                txtSentDate.Text =  "";
                txtSentDate.Focus();
                retVal = false;
            }

            return retVal;
        }

        //  Validate that TrackingNumber textbox not empty
        private bool IsThereATrackingNumber()
        {
            bool retVal = true;

            if (txtTrackingNumber.Text.Trim() == "")
            {
                retVal = false;
            }

            return retVal;
        }

        //  We have validated that:
        //
        //  1.  The recipient textbox was NOT empty.
        //  2.  The sent date textbox was NOT empty.
        //  3.  The sent date textbox holds a valid date.
        //  4.  The tracking number textbox was NOT empty.
        private void InstantiateACertifiedLetterObject()
        {
            lblAdditionalFee.Visible = true;

            //  Make sure that there is "room" for
            //  a new certified letter object.
            if (numElements < TOTALLETTERS)
            {
                //  Instantiate a new CertifiedLetter object
                CertifiedLetter cl = new CertifiedLetter(
                                 txtRecipient.Text,
                                 sentDate,
                                 txtTrackingNumber.Text);

                //  Add the new object to the CertifiedLetter list
                certified.Add(cl);

                //  Add the object info to the
                //  txtLetterHistory textbox.
                txtLetterHistory.Text += cl.ToString() + "\r\n";

                EitherLetterType();
                ClearAll();
            }
            else
            {
                ShowMessage("No More Room For Letters In The List",
                            "LIST IS FILLED!");
                lblAdditionalFee.Visible= false;
            }
        }

        //  The tracking number textbox WAS empty.
        private void InstantiateALetterObject()
        {
            lblAdditionalFee.Visible = false;

            //  Make sure that there is "room" for
            //  a new letter object.
            if (numElements < TOTALLETTERS)
            {
                //  Instantiate a new Letter object
                Letter l = new Letter(
                                 txtRecipient.Text,
                                 sentDate);

                //  Add the new object to the Letter list
                letters.Add(l);

                //  Add the object info to the
                //  txtLetterHistory textbox.
                txtLetterHistory.Text += l.ToString() + "\r\n";

                EitherLetterType();
                ClearAll();
            }
            else
            {
                ShowMessage("No More Room For Letters In The List",
                            "LIST IS FILLED!");
                lblAdditionalFee.Visible = false;
            }
        }

        private void EitherLetterType()
        {
            //  Add info to the string array
            sentLetters = txtLetterHistory.Text.Split('\n');

            //  Make the Certified Label visible
            lblAdditionalFee.Visible = true;

            //  Add 1 to total number of elements
            ++numElements;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtRecipient.Text        = "";
            txtSentDate.Text         = "";
            txtTrackingNumber.Text   = "";
            lblAdditionalFee.Visible = false;
            txtRecipient.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

        private void exitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit The Program?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);  
        }
    }
}
