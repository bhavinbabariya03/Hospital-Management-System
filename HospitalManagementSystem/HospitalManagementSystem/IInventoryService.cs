using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HospitalManagementSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IInventoryService
    {
        [OperationContract]
        DataSet GetInventories();

        [OperationContract]
        Inventory GetInventory(int id);

        [OperationContract]
        string AddInventory(Inventory inventory);

        [OperationContract]
        string UpdateInventory(Inventory inventory);

        [OperationContract]
        string DeleteInventory(int id);
    }
}
