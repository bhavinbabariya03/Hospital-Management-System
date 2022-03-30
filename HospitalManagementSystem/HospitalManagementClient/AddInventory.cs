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
    public partial class AddInventory : Form
    {
        public AddInventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HospitalManagementClient.InventoryServiceReference.InventoryServiceClient sc = new HospitalManagementClient.InventoryServiceReference.InventoryServiceClient("BasicHttpBinding_IInventoryService");

                HospitalManagementClient.InventoryServiceReference.Inventory inv = new InventoryServiceReference.Inventory();

                inv.Inventory_Name = inv_name.Text;
                inv.Quantity = int.Parse(quantity.Text);
                
                string msg = sc.AddInventory(inv);
                MessageBox.Show(msg);

                Console.WriteLine(inv.Inventory_Name + " " + inv.Quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not Add Inventory");
            }
        }
    }
}
