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
    public partial class GetDoctors : Form
    {
        public GetDoctors()
        {
            InitializeComponent();
        }

        private void GetDoctors_Load(object sender, EventArgs e)
        {
            HospitalManagementClient.DoctorServiceReference.DoctorServiceClient sc = new HospitalManagementClient.DoctorServiceReference.DoctorServiceClient("BasicHttpBinding_IDoctorService");
            DataSet ds = sc.GetDoctors();
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
    }
}
