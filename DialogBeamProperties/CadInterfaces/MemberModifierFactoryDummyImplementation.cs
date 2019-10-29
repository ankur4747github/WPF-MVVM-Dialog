using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.CadInterfaces
{
    public class MemberModifierFactoryDummyImplementation : MemberModifierFactory
    {
        public MemberModifier CreateMemberModifier()
        {
            return new MemberModifierDummyImplmentation();
        }
    }
}