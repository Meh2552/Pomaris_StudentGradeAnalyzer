using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomaris_StudentGradeAnalyzer
{
    public partial class frmStudentGradeAnalyzer : Form
    {
        public frmStudentGradeAnalyzer()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if ()
            {

            }
        }

        private string avrGr(double prelims, double midterms, double finals)
        {
            double avr = (prelims + midterms + finals) / 3;
            return avr.ToString("0.00");
        }

        private string avrGr(double grade1, double grade2)
        {
            double avr = (grade1 + grade2) / 2;
            return avr.ToString("0.00");
        }

        private static Boolean pass(double average)
        {
            Boolean pass = false;
            return pass = (average >= 75) ? true : false;
        }

        private void disRes(double average, string stName, string stNo, Boolean pass)
        {
            lbPassFail.Visible = true;
            lbResDesc.Visible = true;
            lbResWName.Visible = true;
            lbStNoRes.Visible = true;

            lbPassFail.Text = (pass) ? "You Passed" : "You Failed";
            lbResDesc.Text = "Your average grade is: " + average;
            lbResWName.Text = "Student: " + stName;
            lbStNoRes.Text = "Student No: " + stNo;
        }

        private void disRes(string desc)
        {
            lbPassFail.Visible = true;
            lbResDesc.Visible = true;
            lbResWName.Visible = false;
            lbStNoRes.Visible = false;

            lbPassFail.Text = "Invalid Input";
            lbResDesc.Text = desc;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxPrelims.Clear();
            tbxMidterms.Clear();
            tbxFinals.Clear();

            lbPassFail.Visible = false;
            lbResDesc.Visible = false;
            lbResWName.Visible = false;
            lbStNoRes.Visible = false;
        }

    }
}
