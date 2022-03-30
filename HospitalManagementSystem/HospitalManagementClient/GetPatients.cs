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
    public partial class GetPatients : Form
    {
        public GetPatients()
        {
            InitializeComponent();
        }

        private void GetPatients_Load(object sender, EventArgs e)
        {
            HospitalManagementClient.PatientServiceReference.PatientServiceClient sc = new HospitalManagementClient.PatientServiceReference.PatientServiceClient("BasicHttpBinding_IPatientService");
            DataSet ds = sc.GetPatients();
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
    }
}
