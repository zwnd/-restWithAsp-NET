using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restWithAspNET.model
{
    public class person
    {
        public long? id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string adress { get; set; }
        public string gender { get; set; }
    }
}
