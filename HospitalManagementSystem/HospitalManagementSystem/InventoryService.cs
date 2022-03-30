using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HospitalManagementSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in both code and config file together.
    public class InventoryService : IInventoryService
    {
        public DataSet GetInventories()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Inventory_Name, Quantity FROM inventory",
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            da.Fill(ds, "inventory");
            return ds;
        }

        public Inventory GetInventory(int id)
        {
            SqlConnection cnn = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            Inventory inv = new Inventory();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "SELECT Id, Inventory_Name, Quantity FROM inventory WHERE Id = @id";
                SqlParameter p = new SqlParameter("@id", id);
                cmd.Parameters.Add(p);
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    inv.Id = reader.GetInt32(0);
                    inv.Inventory_Name = reader.GetString(1);
                    /*inv.Quantity = reader.GetInt32(2);*/
                    inv.Quantity = int.Parse(reader.GetString(2));
                }
                reader.Close();
                return inv;
            }
            catch(Exception ex)
            {
                throw (new Exception("Error on getting inventory!!"));
            }
            finally
            {
                cnn.Close();
            }
            
        }
        public string AddInventory(Inventory inv)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO inventory (Inventory_Name, Quantity) VALUES (@inv_name,@quantity)";
                SqlParameter p0 = new SqlParameter("@inv_name", inv.Inventory_Name);
                SqlParameter p1 = new SqlParameter("@quantity", inv.Quantity);

                cmd.Parameters.Add(p0);
                cmd.Parameters.Add(p1);
                
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (new Exception("Error on adding inventory!!"));
            }
            finally
            {
                con.Close();
            }
            return "Inventory added successfully!!";
        }

        public string UpdateInventory(Inventory inv)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
            string sqlStatement = "UPDATE inventory SET Inventory_Name=@inv_name,Quantity=@quantity WHERE Id=@id";
            try
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, con);

                cmd.Parameters.AddWithValue("@id", inv.Id);
                cmd.Parameters.AddWithValue("@inv_name", inv.Inventory_Name);
                cmd.Parameters.AddWithValue("@quantity", inv.Quantity);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                con.Close();
            }
            return "Inventory updated successfully!!";
        }

        public string DeleteInventory(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            string sqlStatement = "DELETE FROM inventory WHERE Id= @id";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlStatement, con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error on deleting product");
            }
            finally
            {
                con.Close();
            }
            return "Inventory Deleted Successfully";
        }
    }
}
