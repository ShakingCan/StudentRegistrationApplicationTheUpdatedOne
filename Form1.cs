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

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            string ln = lastnamebox.Text;
            string fn = firstnamebox.Text;
            string mn = middlenamebox.Text;
            String c = comboBox1.SelectedItem.ToString();
            String gender = "";
            if (malebtn.Checked)
            {
                gender = malebtn.Text;
            }
            else
            {
                gender = femalebtn.Text;
            }
            String birthday = daybox.Text + "/" + monthbox.Text + "/" + yearbox.Text;

            MessageBox.Show("Name: " + ln + ", " + fn + " " + mn + "\nGender: " + gender + "\nBirthday: " + birthday+ "\nProgram"+ c);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           



           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList course = new ArrayList();
            course.Add("Bachelor of Science in Computer Science");
            course.Add("Bachelor of Science in Information Technology");
            course.Add("Bachelor of Science in Information Systems");
            course.Add("Bachelor of Science in Computer Engineering");
            foreach (String cose in course)
            {
                comboBox1.Items.Add(cose);
            }
            ArrayList months = new ArrayList();
months.Add("January");
months.Add("February");
months.Add("March");
months.Add("April");
months.Add("May");
months.Add("June");
months.Add("July");
months.Add("August");
months.Add("September");
months.Add("October");
months.Add("November");
months.Add("December");
foreach (String month in months)
{
    monthbox.Items.Add(month);
}


            
        }

      
    }
}
