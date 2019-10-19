using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.CadInterfaces
{
    public class XDataWriterDummyImplementation : XDataWriter
    {
        public void WriteXDataToLine(string profile, double rotation)
        {
            // does nothing.
            // a simple impelementation to ensure your code compiles.
        }
    }
}
