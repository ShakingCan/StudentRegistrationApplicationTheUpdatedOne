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

           





            showresult(fn, ln, c);
            showresult(fn, mn,  ln, c);
            showresult(fn, mn, ln,gender,birthday, c);

        }

        public void showresult(String firstname, String lastname, String course)
        {
            MessageBox.Show("Name: " + firstname + " " + lastname + "\n" + course); 
        }
        public void showresult(String firstname, String middlename, String lastname, String course)
        {
            MessageBox.Show("Name: " + firstname + " "+ middlename+" " + lastname + "\n" + course);
        }
        public void showresult(String firstname, String middlename,String lastname,  String gender,String dateofbirth, String course)
        {
            MessageBox.Show("Name: " + firstname + " " + middlename + " " + lastname +"\nGender:"+gender+"\nDate of Birth:"+dateofbirth+ "\nCourse:" + course);
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

       

        private void browsebutton_Click(object sender, EventArgs e)
        {
          

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Access Databases (*.mdb)|*.mdb|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                }

                pictureBox1.ImageLocation = openFileDialog.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void femalebtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}

