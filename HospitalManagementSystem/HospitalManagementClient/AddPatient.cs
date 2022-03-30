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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HospitalManagementClient.PatientServiceReference.PatientServiceClient sc = new HospitalManagementClient.PatientServiceReference.PatientServiceClient("BasicHttpBinding_IPatientService");

                HospitalManagementClient.PatientServiceReference.Patient p = new PatientServiceReference.Patient();
                p.Name = name.Text;
                p.Contact = contact.Text;
                p.Address = address.Text;
                p.City = city.Text;
                p.State = state.Text;
                p.Age = int.Parse(age.Text);
                p.Gender = gender.Text;
                p.Disease = disease.Text;


                string msg = sc.AddPatient(p);
                MessageBox.Show(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not Add a Patient");
            }
        }
    }
}
