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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class PatientService : IPatientService
    {
        public DataSet GetPatients()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Name, Contact, Address, City, State, Age, Gender, Disease FROM patient",
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            da.Fill(ds, "patient");
            return ds;
        }

        public Patient GetPatient(int id)
        {
            SqlConnection cnn = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT Id, Name, Contact, Address, City, State, Age, Gender, Disease FROM patient WHERE Id = @id";
            SqlParameter p = new SqlParameter("@id", id);
            cmd.Parameters.Add(p);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Patient patient = new Patient();

            while (reader.Read())
            {
                patient.Id = reader.GetInt32(0);
                patient.Name = reader.GetString(1);
                patient.Contact = reader.GetString(2);
                patient.Address = reader.GetString(3);
                patient.City = reader.GetString(4);
                patient.State = reader.GetString(5);
                patient.Age = reader.GetInt32(6);
                patient.Gender = reader.GetString(7);
                patient.Disease = reader.GetString(8);
            }
            reader.Close();
            cnn.Close();
            return patient;
        }
        public string AddPatient(Patient patient)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO patient (Name, Contact, Address, City, State, Age, Gender, Disease) VALUES (@name,@contact,@address,@city,@state,@age,@gender,@disease)";
                SqlParameter p0 = new SqlParameter("@name", patient.Name);
                SqlParameter p1 = new SqlParameter("@contact", patient.Contact);
                SqlParameter p2 = new SqlParameter("@address", patient.Address);
                SqlParameter p3 = new SqlParameter("@city", patient.City);
                SqlParameter p4 = new SqlParameter("@state", patient.State);
                SqlParameter p5 = new SqlParameter("@age", patient.Age);
                SqlParameter p6 = new SqlParameter("@gender", patient.Gender);
                SqlParameter p7 = new SqlParameter("@disease", patient.Disease);

                cmd.Parameters.Add(p0);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (new Exception("Error on adding patient!!"));
            }
            finally
            {
                con.Close();
            }
            return "Patient added successfully!!";
        }

        public string UpdatePatient(Patient patient)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string sqlStatement = "UPDATE patient SET Name=@name,Contact=@contact,Address=@address,City=@city,State=@state,Age=@age,Gender=@gender,Disease=@disease WHERE Id=@id";
            try
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, con);

                cmd.Parameters.AddWithValue("@id", patient.Id);
                cmd.Parameters.AddWithValue("@name", patient.Name);
                cmd.Parameters.AddWithValue("@contact", patient.Contact);
                cmd.Parameters.AddWithValue("@address", patient.Address);
                cmd.Parameters.AddWithValue("@city", patient.City);
                cmd.Parameters.AddWithValue("@state", patient.State);
                cmd.Parameters.AddWithValue("@age", patient.Age);
                cmd.Parameters.AddWithValue("@gender", patient.Gender);
                cmd.Parameters.AddWithValue("@disease", patient.Disease);
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
            return "Patient updated successfully!!";
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
