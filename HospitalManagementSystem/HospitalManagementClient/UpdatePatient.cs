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
    public partial class UpdatePatient : Form
    {
        public UpdatePatient()
        {
            InitializeComponent();
        }

        private void UpdatePatient_Load(object sender, EventArgs e)
        {
            HospitalManagementClient.PatientServiceReference.PatientServiceClient sc = new HospitalManagementClient.PatientServiceReference.PatientServiceClient("BasicHttpBinding_IPatientService");
            DataSet ds = sc.GetPatients();
            DataTable dt = ds.Tables[0];
            listBox1.DataSource = dt.DefaultView;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
            sc.Close();

            HospitalManagementClient.PatientServiceReference.PatientServiceClient proxy = new HospitalManagementClient.PatientServiceReference.PatientServiceClient("BasicHttpBinding_IPatientService");
            HospitalManagementClient.PatientServiceReference.Patient patient = proxy.GetPatient(int.Parse(listBox1.SelectedValue.ToString()));
            name.Text = patient.Name.ToString();
            contact.Text = patient.Contact.ToString();
            address.Text = patient.Address.ToString();
            city.Text = patient.City.ToString();
            state.Text = patient.State.ToString();
            age.Text = patient.Age.ToString();
            gender.Text = patient.Gender.ToString();
            disease.Text = patient.Disease.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HospitalManagementClient.PatientServiceReference.PatientServiceClient sc = new HospitalManagementClient.PatientServiceReference.PatientServiceClient("BasicHttpBinding_IPatientService");

            try
            {
                if (listBox1.SelectedValue.ToString() != null)
                {
                    int id = int.Parse(listBox1.SelectedValue.ToString());
                    HospitalManagementClient.PatientServiceReference.Patient p = new PatientServiceReference.Patient();
                    p.Id = id;
                    p.Name = name.Text;
                    p.Contact = contact.Text;
                    p.Address = address.Text;
                    p.City = city.Text;
                    p.State = state.Text;
                    p.Age = int.Parse(age.Text);
                    p.Gender = gender.Text;
                    p.Disease = disease.Text;
                  
                    string msg = sc.UpdatePatient(p);
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

        private void listBox1_Click(object sender, EventArgs e)
        {
            HospitalManagementClient.PatientServiceReference.PatientServiceClient proxy = new HospitalManagementClient.PatientServiceReference.PatientServiceClient("BasicHttpBinding_IPatientService");
            HospitalManagementClient.PatientServiceReference.Patient patient = proxy.GetPatient(int.Parse(listBox1.SelectedValue.ToString()));
            name.Text = patient.Name.ToString();
            contact.Text = patient.Contact.ToString();
            address.Text = patient.Address.ToString();
            city.Text = patient.City.ToString();
            state.Text = patient.State.ToString();
            age.Text = patient.Age.ToString();
            gender.Text = patient.Gender.ToString();
            disease.Text = patient.Disease.ToString();
        }
    }
}
