using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    [DataContract]
    public class Inventory
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Inventory_Name { get; set; }

        [DataMember]
        public int Quantity { get; set; }

    }
}
