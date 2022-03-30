using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementClient
{
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HospitalManagementClient.DoctorServiceReference.DoctorServiceClient sc = new HospitalManagementClient.DoctorServiceReference.DoctorServiceClient("BasicHttpBinding_IDoctorService");


                HospitalManagementClient.DoctorServiceReference.Doctor d = new DoctorServiceReference.Doctor();

                d.Firstname = fname.Text;
                d.Lastname = lname.Text;
                d.Contact = contact.Text;
                d.Address = address.Text;
                d.City = city.Text;
                d.State = state.Text;
                d.Age = int.Parse(age.Text);
                d.Gender = gender.Text;
                d.Education = education.Text;
                d.Designation = designation.Text;
                d.Fee = int.Parse(fee.Text);


                string msg = sc.AddDoctor(d);
                MessageBox.Show(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not Add Doctor");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void designation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void fee_TextChanged(object sender, EventArgs e)
        {

        }

        private void education_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void state_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
