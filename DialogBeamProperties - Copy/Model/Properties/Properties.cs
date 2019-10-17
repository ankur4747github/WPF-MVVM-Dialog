using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.Model
{
    public class Properties : IProperties
    {
        public string AttributesName { get; set; }
        public string AttributesProfile { get; set; }
        public string NumberingPartPrefix { get; set; }
        public string NumberingPartStartNumber { get; set; }
        public string NumberingAssemblyPrefix { get; set; }
        public string NumberingAssemblyStartNumber { get; set; }
    }
}
