using DialogBeamProperties.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.CadInterfaces
{
    public interface BeamValuesGetter
    {
        BeamProperties GetBeamProperties();
    }
}