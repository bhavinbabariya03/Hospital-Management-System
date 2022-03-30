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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DoctorService" in both code and config file together.
    public class DoctorService : IDoctorService
    {
        public DataSet GetDoctors()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Firstname, Lastname, Contact, Address, City, State, Age, Gender, Education, Designation, Fee FROM doctor",
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                
                da.Fill(ds, "doctor");
            }
            catch(Exception ex)
            {
                throw (ex);
            }
            return ds;

        }

        public Doctor GetDoctor(int id)
        {
            SqlConnection cnn = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT Id, Firstname, Lastname, Contact, Address, City, State, Age, Gender, Education, Designation, Fee FROM doctor WHERE Id = @id";
            SqlParameter p = new SqlParameter("@id", id);
            cmd.Parameters.Add(p);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Doctor doctor = new Doctor();

            while (reader.Read())
            {
                doctor.Id = reader.GetInt32(0);
                doctor.Firstname = reader.GetString(1);
                doctor.Lastname = reader.GetString(2);
                doctor.Contact = reader.GetString(3);
                doctor.Address = reader.GetString(4);
                doctor.City = reader.GetString(5);
                doctor.State = reader.GetString(6);
                doctor.Age = reader.GetInt32(7);
                doctor.Gender = reader.GetString(8);
                doctor.Education = reader.GetString(9);
                doctor.Designation = reader.GetString(10);
                doctor.Fee = reader.GetInt32(11);
            }
            reader.Close();
            cnn.Close();
            return doctor;
        }
        public string AddDoctor(Doctor doctor)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO doctor (Firstname, Lastname, Contact, Address, City, State, Age, Gender, Education, Designation, Fee) VALUES (@fname,@lname,@contact,@address,@city,@state,@age,@gender,@education,@designation,@fee)";
                SqlParameter p0 = new SqlParameter("@fname", doctor.Firstname);
                SqlParameter p00 = new SqlParameter("@lname", doctor.Lastname);
                SqlParameter p1 = new SqlParameter("@contact", doctor.Contact);
                SqlParameter p2 = new SqlParameter("@address", doctor.Address);
                SqlParameter p3 = new SqlParameter("@city", doctor.City);
                SqlParameter p4 = new SqlParameter("@state", doctor.State);
                SqlParameter p5 = new SqlParameter("@age", doctor.Age);
                SqlParameter p6 = new SqlParameter("@gender", doctor.Gender);
                SqlParameter p7 = new SqlParameter("@education", doctor.Education);
                SqlParameter p8 = new SqlParameter("@designation", doctor.Designation);
                SqlParameter p9 = new SqlParameter("@fee", doctor.Fee);

                cmd.Parameters.Add(p0);
                cmd.Parameters.Add(p00);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);
                cmd.Parameters.Add(p9);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (new Exception("Error on adding doctor!!"));
            }
            finally
            {
                con.Close();
            }
            return "Doctor added successfully!!";
        }

        public string UpdateDoctor(Doctor doctor)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string sqlStatement = "UPDATE doctor SET Firstname=@fname,Lastname=@lname,Contact=@contact,Address=@address,City=@city,State=@state,Age=@age,Gender=@gender,Education=@education,Designation=@designation,Fee=@fee WHERE Id=@id";
            try
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, con);

                cmd.Parameters.AddWithValue("@id", doctor.Id);
                cmd.Parameters.AddWithValue("@fname", doctor.Firstname);
                cmd.Parameters.AddWithValue("@lname", doctor.Lastname);
                cmd.Parameters.AddWithValue("@contact", doctor.Contact);
                cmd.Parameters.AddWithValue("@address", doctor.Address);
                cmd.Parameters.AddWithValue("@city", doctor.City);
                cmd.Parameters.AddWithValue("@state", doctor.State);
                cmd.Parameters.AddWithValue("@age", doctor.Age);
                cmd.Parameters.AddWithValue("@gender", doctor.Gender);
                cmd.Parameters.AddWithValue("@education", doctor.Education);
                cmd.Parameters.AddWithValue("@designation", doctor.Designation);
                cmd.Parameters.AddWithValue("@fee", doctor.Fee);
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
            return "Doctor updated successfully!!";
        }
    }
}
