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
    public partial class UpdateDoctor : Form
    {
        public UpdateDoctor()
        {
            InitializeComponent();
        }

        private void UpdateDoctor_Load(object sender, EventArgs e)
        {
            HospitalManagementClient.DoctorServiceReference.DoctorServiceClient sc = new HospitalManagementClient.DoctorServiceReference.DoctorServiceClient("BasicHttpBinding_IDoctorService");
            DataSet ds = sc.GetDoctors();
            DataTable dt = ds.Tables[0];
            listBox1.DataSource = dt.DefaultView;
            listBox1.DisplayMember = "Firstname";
            listBox1.ValueMember = "Id";
            sc.Close();

            HospitalManagementClient.DoctorServiceReference.DoctorServiceClient proxy = new HospitalManagementClient.DoctorServiceReference.DoctorServiceClient("BasicHttpBinding_IDoctorService");
            HospitalManagementClient.DoctorServiceReference.Doctor doctor = proxy.GetDoctor(int.Parse(listBox1.SelectedValue.ToString()));
            fname.Text = doctor.Firstname.ToString();
            lname.Text = doctor.Lastname.ToString();
            contact.Text = doctor.Contact.ToString();
            address.Text = doctor.Address.ToString();
            city.Text = doctor.City.ToString();
            state.Text = doctor.State.ToString();
            age.Text = doctor.Age.ToString();
            gender.Text = doctor.Gender.ToString();
            education.Text = doctor.Education.ToString();
            designation.Text = doctor.Designation.ToString();
            fee.Text = doctor.Fee.ToString();
        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            HospitalManagementClient.DoctorServiceReference.DoctorServiceClient proxy = new HospitalManagementClient.DoctorServiceReference.DoctorServiceClient("BasicHttpBinding_IDoctorService");
            HospitalManagementClient.DoctorServiceReference.Doctor doctor = proxy.GetDoctor(int.Parse(listBox1.SelectedValue.ToString()));
            fname.Text = doctor.Firstname.ToString();
            lname.Text = doctor.Lastname.ToString();
            contact.Text = doctor.Contact.ToString();
            address.Text = doctor.Address.ToString();
            city.Text = doctor.City.ToString();
            state.Text = doctor.State.ToString();
            age.Text = doctor.Age.ToString();
            gender.Text = doctor.Gender.ToString();
            education.Text = doctor.Education.ToString();
            designation.Text = doctor.Designation.ToString();
            fee.Text = doctor.Fee.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HospitalManagementClient.DoctorServiceReference.DoctorServiceClient sc = new HospitalManagementClient.DoctorServiceReference.DoctorServiceClient("BasicHttpBinding_IDoctorService");

            try
            {
                if (listBox1.SelectedValue.ToString() != null)
                {
                    int id = int.Parse(listBox1.SelectedValue.ToString());
                    HospitalManagementClient.DoctorServiceReference.Doctor d = new DoctorServiceReference.Doctor();
                    d.Id = id;
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

                    string msg = sc.UpdateDoctor(d);
                    MessageBox.Show(msg);
                    this.OnLoad(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sc.Close();
            }
        }
    }
}
