using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Pomaris_StudentGradeAnalyzer
{
    public partial class frmStudentGradeAnalyzer : Form
    {
        public frmStudentGradeAnalyzer()
        {
            InitializeComponent();
        }

        ArrayList grades = new ArrayList();
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // Checks if Textboxes are empty
            if (tbxStName.Text.Equals("") || tbxStNo.Text.Equals(""))
            {
                disRes("Invalid student");
                return;
            }

            string stName = "", stNo = "";
            grades.Clear();

            // Checks if inputted grades are numbers
            try
            {
                if (!tbxPrelims.Text.Equals("")) grades.Add(Convert.ToDouble(tbxPrelims.Text));
                if (!tbxMidterms.Text.Equals("")) grades.Add(Convert.ToDouble(tbxMidterms.Text));
                if (!tbxFinals.Text.Equals("")) grades.Add(Convert.ToDouble(tbxFinals.Text));
                stName = tbxStName.Text;
                stNo = tbxStNo.Text;
            }

            catch (FormatException)
            {
                disRes("Invalid grades");
                return;
            }

            //checks if inputted grades are 0-100
             foreach (double grade in grades)
            {
                if (grade < 0 || grade > 100)
                {
                    disRes("Invalid grades");
                    return;
                }
            }

            double avr = 0;
            Boolean passed = false;
            if (grades.Count == 3)
            {
                string avrStr = avrGr((double)grades[0], (double)grades[1], (double)grades[2]);
                passed = pass(Convert.ToDouble(avrStr));
                disRes(avrStr, stName, stNo, passed);
            }

            else if (grades.Count == 2)
            {
                string avrStr = avrGr((double)grades[0], (double)grades[1]);
                passed = pass(Convert.ToDouble(avrStr));
                disRes(avrStr, stName, stNo, passed);
            }

            else 
            {
                disRes("Invalid grades");
                return;
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

        private void disRes(string average, string stName, string stNo, Boolean pass)
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
            tbxStName.Clear();
            tbxStNo.Clear();

            lbPassFail.Visible = false;
            lbResDesc.Visible = false;
            lbResWName.Visible = false;
            lbStNoRes.Visible = false;

            tbxStNo.Select();
        }

    }
}
