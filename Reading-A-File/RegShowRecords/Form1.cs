using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegShowRecords
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
         {
                "BS Information Technology","BS Computer Science","BS Computer Engineering"," BS Computer Informatnio"
         };
            for (int i = 0; i < 4; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }
            string[] ListOfGender = new string[]
            {
                "Male","Female",
            };
            for (int x = 0; x < 3; x++)
            {
             
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            string getStudentNo, getProgram, getFullName, getAge, getGender, getBirthday, getContactNo;
            getStudentNo = "Student No.: " + txtStudentNo.Text;
            getProgram = "Program: " + cbProgram.Text;
            getFullName = "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMI.Text;
            getAge = "Age: " + txtAge.Text;
            getGender = "Gender: " + cbGender.Text;
            getBirthday = "Birthday: " + dateTimePicker1.Text;
            getContactNo = "Contact No.: " + txtContactNo.Text;

            string[] information = { getStudentNo, getProgram, getFullName, getAge, getGender, getBirthday, getContactNo };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                foreach (string s in information)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudentRecords studentRecords = new FrmStudentRecords();
            studentRecords.ShowDialog();
        }
    }
}