using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.CadInterfaces
{
    public interface ColumnCreator
    {
        void CreateColumn(string profile, double rotation, double startRl, double endRl);
    }
}