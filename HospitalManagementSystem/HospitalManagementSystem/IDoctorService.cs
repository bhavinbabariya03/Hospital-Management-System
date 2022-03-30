using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HospitalManagementSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDoctorService" in both code and config file together.
    [ServiceContract]
    public interface IDoctorService
    {
        [OperationContract]
        DataSet GetDoctors();

        [OperationContract]
        Doctor GetDoctor(int id);

        [OperationContract]
        string AddDoctor(Doctor doctor);

        [OperationContract]
        string UpdateDoctor(Doctor doctor);
    }
}
