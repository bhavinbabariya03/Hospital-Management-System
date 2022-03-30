using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceHost sh1 = null, sh2 = null,sh3 = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            sh1 = new ServiceHost(typeof(HospitalManagementSystem.PatientService));
            sh1.Open();

            sh2 = new ServiceHost(typeof(HospitalManagementSystem.DoctorService));
            sh2.Open();

            sh3 = new ServiceHost(typeof(HospitalManagementSystem.InventoryService));
            sh3.Open();

            label1.Text = "Patient Service is Running";
            label2.Text = "Doctor Service is Running";
            label3.Text = "Inventory Service is Running";
        }
    }
}
