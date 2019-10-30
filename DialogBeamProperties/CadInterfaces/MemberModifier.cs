using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBeamProperties.CadInterfaces
{
    public interface MemberModifier : IDisposable
    {
        void ModifyProfile(string profile);

        void ModifyRotation(double rotation);

        void ModifyClass(int color);

        void ModifyTopPosition(double positionLevelsTop);

        void ModifyBottomPosition(double positionLevelsBottom);

        void ModifyPositionRotationEnum(string positionRotationText);
    }
}