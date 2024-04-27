using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string gender = " ";
        string LastName;
        string FirstName;
        string MiddleName;
        string programs;
        string DateOfBirth;
        string NameOfStudent;



        private void Form1_Load(object sender, EventArgs e)
        {

            for (int day = 1; day <= 31; day++)
            {

                comboBox1.Items.Add(day);

            }

            ArrayList months = new ArrayList()
            {
                "January" , "Febuary" , "March" , "April" , "May" , "June" , "July" , "August" , "September" ,
                "October" , "November" , "December"
            };

           foreach (string  month in months)
            {
                comboBox2.Items.Add(month);
            }
            

            for (int year = 1990; year <= 2024; year++)
            {

                comboBox3.Items.Add(year);
            }

            ArrayList courses = new ArrayList()
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            foreach (string course in courses)
            {
                comboBox4.Items.Add(course);
            }    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.jpg)|.jpg| PNG files(.png)|.png| All Files (.)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK);
            }



        }
        public void studentInfo(string studentName, string genders, string birthDate, string program)
        {
            string LastName = textBox1.Text;
            string FirstName = textBox3.Text;
            string MiddleName = textBox2.Text;
            string gender;
            string prgrams;
            string DateOfBirth;
            string NameOfStudent = LastName + FirstName + MiddleName;

            if (male.Checked)
            {
                MessageBox.Show("Student Name: " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text
                    + "\nGender: Male\nDate of Birth: " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text + "\nProgram: " + comboBox4.Text);
            }
            else if (female.Checked)
            {
                MessageBox.Show("Student Name: " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text
                    + "\nGender: Female\nDate of Birth: " + comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text + "\nProgram: " + comboBox4.Text);
            }

            



        }
        public void studentInfo(string StudentName, string program)
        {
            string FirstName = textBox3.Text;
            string MiddleName = textBox2.Text;
            string LastName = textBox1.Text;
            string programs = comboBox4.Text;
            string NameOfStudent = LastName + " " + FirstName + " "+ MiddleName;
            string fullName = "Student Name: " + NameOfStudent;
            string course = "Program: " + programs;

            MessageBox.Show("Student Name: " + NameOfStudent + " " + programs);



        }
        public void studentInfo(string LName, string FName, string program)
        {
            string programs = comboBox4.Text;
            string FirstName = textBox3.Text;
            string LastName = textBox1.Text;
            string StudentName = "Student Name: " + textBox1.Text + " " + textBox3.Text;
            string course = "Program: " + programs;

            MessageBox.Show("Student Name: " + " " + programs);


        }

        private void button1_Click(object sender, EventArgs e)

        {

            string gender = " ";
            string LastName = textBox1.Text;
            string FirstName = textBox3.Text;
            string MiddleName = textBox2.Text;
            string programs = comboBox4.Text;
            string DateOfBirth = comboBox1.Text + "/ " + comboBox2.Text + "/" + comboBox3.Text; ;
            string NameOfStudent = LastName + ", " + FirstName + " " + MiddleName;

            if (male.Checked)
            {
                gender = male.Text;
            }
            else if (female.Checked)
            {
                gender = female.Text;
            }

            if ((LastName != null && FirstName != null && MiddleName != null) && gender != " " && DateOfBirth != null && programs != null)
            {
                studentInfo(NameOfStudent, gender, DateOfBirth, programs);

            }
            else if ((LastName != null && FirstName != null && MiddleName != null) && gender == null && DateOfBirth == null && programs != null)
            {
                studentInfo(NameOfStudent, programs);



            }
            else if ((LastName != null && FirstName != null) && MiddleName == null && gender == null && DateOfBirth == null && programs != null)
            {
                studentInfo(LastName, FirstName, programs);



            }


        }

        
    }
}
