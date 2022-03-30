using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    [DataContract]
    public class Patient
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Contact { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public string Disease{ get; set; }
    }
}
