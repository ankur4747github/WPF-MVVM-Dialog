using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DialogBeamProperties.Model.Properties;

namespace DialogBeamProperties.CadInterfaces
{
    public class ColumnValuesGetterImplementation : ColumnValuesGetter
    {
        public ColumnProperties GetColumnProperties()
        {
            ColumnProperties propColumn = (new StandardColumnPropertiesFactory()).CreateStandardProperties("EFG", 0, 0, 1000, 0, "TOP", "MIDDLE", 0, "MIDDLE", 0, "Looks nice", "Steel", "hello world");
            return propColumn;
        }
    }
}