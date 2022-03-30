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
    public partial class DeleteInventory : Form
    {
        public DeleteInventory()
        {
            InitializeComponent();
        }

        private void DeleteInventory_Load(object sender, EventArgs e)
        {
            HospitalManagementClient.InventoryServiceReference.InventoryServiceClient sc = new HospitalManagementClient.InventoryServiceReference.InventoryServiceClient("BasicHttpBinding_IInventoryService");
            DataSet ds = sc.GetInventories();
            DataTable dt = ds.Tables[0];
            listBox1.DataSource = dt.DefaultView;
            listBox1.DisplayMember = "Inventory_Name";
            listBox1.ValueMember = "Id";
            sc.Close();

            HospitalManagementClient.InventoryServiceReference.InventoryServiceClient proxy = new HospitalManagementClient.InventoryServiceReference.InventoryServiceClient("BasicHttpBinding_IInventoryService");
            HospitalManagementClient.InventoryServiceReference.Inventory inv = proxy.GetInventory(int.Parse(listBox1.SelectedValue.ToString()));
            /* HospitalManagementClient.InventoryServiceReference.Inventory inv = proxy.GetInventory(1);*/

            inv_name.Text = inv.Inventory_Name.ToString();
            quantity.Text = inv.Quantity.ToString();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            HospitalManagementClient.InventoryServiceReference.InventoryServiceClient proxy = new HospitalManagementClient.InventoryServiceReference.InventoryServiceClient("BasicHttpBinding_IInventoryService");
            HospitalManagementClient.InventoryServiceReference.Inventory inv = proxy.GetInventory(int.Parse(listBox1.SelectedValue.ToString()));
            /* HospitalManagementClient.InventoryServiceReference.Inventory inv = proxy.GetInventory(1);*/

            inv_name.Text = inv.Inventory_Name.ToString();
            quantity.Text = inv.Quantity.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HospitalManagementClient.InventoryServiceReference.InventoryServiceClient sc = new HospitalManagementClient.InventoryServiceReference.InventoryServiceClient("BasicHttpBinding_IInventoryService");

            try
            {
                if (listBox1.SelectedValue.ToString() != null)
                {
                    int id = int.Parse(listBox1.SelectedValue.ToString());
                    
                    string msg = sc.DeleteInventory(id);
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
