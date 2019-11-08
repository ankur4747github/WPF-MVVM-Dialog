using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DialogBeamProperties.Model;
using DialogBeamProperties.Model.Properties;

namespace DialogBeamProperties.CadInterfaces
{
    public class BeamValuesGetterDummyImplementation : BeamValuesGetter
    {
        public BeamProperties GetBeamProperties()
        {
            return (new StandardBeamPropertiesFactory()).CreateStandardProperties("", 0, 0, "", "", 0, "", 0);
        }
    }
}