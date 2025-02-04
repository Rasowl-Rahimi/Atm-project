using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        double Balance;
        double interestrate, monthlyinterestrate, loanamount, monthlypayment, totalpayment;
        int numberofyears;
        string imonthlypayment, itotalpayment;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            lbpin.Text = lbpin.Text + "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            lbpin.Text = lbpin.Text + "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            lbpin.Text = lbpin.Text + "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            lbpin.Text = lbpin.Text + "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            lbpin.Text = lbpin.Text + "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            lbpin.Text = lbpin.Text + "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            lbpin.Text = lbpin.Text + "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            lbpin.Text = lbpin.Text + "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            lbpin.Text = lbpin.Text + "9";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            lbpin.Text = lbpin.Text + "0";
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            lbpin.Text = "";
            lbbalance.Visible = false;
            lbFastCash.Visible = false;
            lbloan.Visible = false;
            lbwhitdraw.Visible = false;

            btloan.Enabled = false;
            btdeposit.Enabled = false;
            btwhitdrawal.Enabled = false;
            btbalance.Enabled = false;

            btpexit.Enabled = false;
            btploan.Enabled = false;
            btpreceipt.Enabled = false;
            btpreset.Enabled = false;

            pre.Text = "";
            ploan.Text = "";
            pyear.Text = "";
            pmonth.Text = "";
            prate.Text = "";
            ptotal.Text = "";

            btnWhitdraw.Enabled = false;
            txtbWhitdraw.Text = "";

            btn500.Enabled = false;
            btn1000.Enabled = false;
            btn2000.Enabled = false;
            btn3000.Enabled = false;
            btn5000.Enabled = false;
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit= MessageBox.Show("Confirm you want to exit","ATM",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbbalance.Visible = false;
            lbFastCash.Visible = false;
            lbloan.Visible = false;
            lbwhitdraw.Visible = false;

            btloan.Enabled= false;
            btdeposit.Enabled= false;
            btwhitdrawal.Enabled = false;
            btbalance.Enabled= false;

            btpexit.Enabled= false;
            btploan.Enabled= false;
            btpreceipt.Enabled= false;
            btpreset.Enabled= false;

            btnWhitdraw.Enabled= false;

            btn500.Enabled= false;
            btn1000.Enabled= false;
            btn2000.Enabled= false;
            btn3000.Enabled= false;
            btn5000.Enabled= false;
        }

        private void btpreceipt_Click(object sender, EventArgs e)
        {
            pre.AppendText("loan managment system calculator" + "\n");
            pre.AppendText("-----------------------------" + "\n");
            pre.AppendText("amount of loan" + "\t" +ploan.Text + "\n");
            pre.AppendText("number of years" + "\t" + pyear.Text + "\n");
            pre.AppendText("interest rate" + "\t" + "\t" + prate.Text +"\n");
            pre.AppendText("montly payment" + "\t" +"\t"+pmonth.Text +"\n");
            pre.AppendText("total payment"+"\t"+"\t"+"\t"+ptotal.Text +"\n");
            
            pre.AppendText("------thank you-------" + "\n");
        }

        private void btbalance_Click(object sender, EventArgs e)
        {
            pre.AppendText("Bank Account information" + "\n");
            pre.AppendText("-----------------------------" + "\n");
            pre.AppendText("Account current Balance" + "\t" + Balance + "\n");
            pre.AppendText("-----------------------------" + "\n");
        }

        private void btnWhitdraw_Click(object sender, EventArgs e)
        {
            int Money=int.Parse(txtbWhitdraw.Text);
            if (Balance < Money)
            {
                MessageBox.Show("insufficient Balnce", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                Balance = Balance - Money;
                MessageBox.Show("Whitdrawal Succesful" + "\n" + "your current account Balance  " + Balance, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btwhitdrawal_Click(object sender, EventArgs e)
        {
            btnWhitdraw.Enabled = true;
        }

        private void btdeposit_Click(object sender, EventArgs e)
        {
            btn500.Enabled = true;
            btn1000.Enabled = true;
            btn2000.Enabled = true;
            btn3000.Enabled = true;
            btn5000.Enabled = true;
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            if (Balance < 500)
            {
                MessageBox.Show("insufficient Balnce", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Balance = Balance - 500;
                MessageBox.Show("Whitdrawal Succesful" + "\n" + "your current account Balance  " + Balance, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            if (Balance < 1000)
            {
                MessageBox.Show("insufficient Balnce", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Balance = Balance - 1000;
                MessageBox.Show("Whitdrawal Succesful" + "\n" + "your current account Balance  " + Balance, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn2000_Click(object sender, EventArgs e)
        {
            if (Balance < 2000)
            {
                MessageBox.Show("insufficient Balnce", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Balance = Balance - 2000;
                MessageBox.Show("Whitdrawal Succesful" + "\n" + "your current account Balance  " + Balance, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn3000_Click(object sender, EventArgs e)
        {
            if (Balance < 3000)
            {
                MessageBox.Show("insufficient Balnce", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Balance = Balance - 3000;
                MessageBox.Show("Whitdrawal Succesful" + "\n" + "your current account Balance  " + Balance, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn5000_Click(object sender, EventArgs e)
        {
            if (Balance < 5000)
            {
                MessageBox.Show("insufficient Balnce", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Balance = Balance - 5000;
                MessageBox.Show("Whitdrawal Succesful" + "\n" + "your current account Balance  " + Balance, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbloan_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbFastCash_Click(object sender, EventArgs e)
        {

        }

        private void lbpin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btenter_Click(object sender, EventArgs e)
        {
            string pin1 = string.Format(lbpin.Text);
            string pin2 = string.Format(lbpin.Text);
            string pin3 = string.Format(lbpin.Text);

            if(pin1=="1234")
            {
                lbbalance.Visible = true;
                lbFastCash.Visible =true ;
                lbloan.Visible =true;
                lbwhitdraw.Visible=true;

                btloan.Enabled = true;
                btdeposit.Enabled = true;
                btwhitdrawal.Enabled = true;
                btbalance.Enabled = true;

                lbpin.Text = "";


                Balance = 10000;
            }
            else if(pin1=="8413")
            {
                lbbalance.Visible = true;
                lbFastCash.Visible = true;
                lbloan.Visible = true;
                lbwhitdraw.Visible = true;

                btloan.Enabled = true;
                btdeposit.Enabled = true;
                btwhitdrawal.Enabled = true;
                btbalance.Enabled = true;

                lbpin.Text = "";


                Balance = 50000;
            }
            else if( pin1=="8520")
            {
                lbbalance.Visible = true;
                lbFastCash.Visible = true;
                lbloan.Visible = true;
                lbwhitdraw.Visible = true;

                btloan.Enabled = true;
                btdeposit.Enabled = true;
                btwhitdrawal.Enabled = true;
                btbalance.Enabled = true;

                lbpin.Text = "";



                Balance = 8000;
            }
            else
            {
                lbpin.Text = "invalid pin";
            }
        }

        private void btloan_Click(object sender, EventArgs e)
        {
            btpexit.Enabled = true;
            btploan.Enabled = true;
            btpreceipt.Enabled = true;
            btpreset.Enabled = true;
        }

        private void btpexit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to exit", "ATM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btpreset_Click(object sender, EventArgs e)
        {
            ploan.Clear();
            pyear.Clear();
            prate.Clear();
            pmonth.Text = "";
            ptotal.Text = "";
            pre.Clear();
        }

        private void btploan_Click(object sender, EventArgs e)
        {

            interestrate = Convert.ToDouble(prate.Text);
            monthlyinterestrate = interestrate / 1200;
            numberofyears = Convert.ToInt32(pyear.Text);
            loanamount=Convert.ToDouble(ploan.Text);

            monthlypayment=loanamount*monthlyinterestrate/(1-1/Math.Pow(1+monthlyinterestrate,numberofyears+12));

            
            imonthlypayment=Convert.ToString(monthlypayment);
            imonthlypayment = String.Format("{0:C}", monthlypayment);
            pmonth.Text=(imonthlypayment);

            totalpayment = monthlypayment * numberofyears * 12;
            itotalpayment= String.Format("{0:C}", totalpayment);
            ptotal.Text=(itotalpayment);

            ploan.Text = String.Format("{0:C}", loanamount);
        }
    }
}
