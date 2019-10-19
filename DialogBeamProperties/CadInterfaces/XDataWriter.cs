using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.CadInterfaces
{
    public interface XDataWriter
    {
        void WriteXDataToLine(string profile, double rotation);     
    }
}
