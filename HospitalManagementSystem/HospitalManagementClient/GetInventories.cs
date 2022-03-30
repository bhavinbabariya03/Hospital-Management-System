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
    public partial class GetInventories : Form
    {
        public GetInventories()
        {
            InitializeComponent();
        }

        private void GetInventories_Load(object sender, EventArgs e)
        {
            HospitalManagementClient.InventoryServiceReference.InventoryServiceClient sc = new HospitalManagementClient.InventoryServiceReference.InventoryServiceClient("BasicHttpBinding_IInventoryService");
            DataSet ds = sc.GetInventories();
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
    }
}
