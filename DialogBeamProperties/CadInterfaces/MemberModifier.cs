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

        void ModifyPositionRotationEnum(string positionRotationText);

        void ModifyRotation(double rotation);

        void ModifyClass(int color);

        void ModifyTopPosition(double positionLevelsTop);

        void ModifyBottomPosition(double positionLevelsBottom);

        void ModifyDepthEnum(string depthEnum);

        void ModifyDepthOffset(double depthOffset);

        void ModifyPlaneEnum(string planeEnum);

        void ModifyPlaneOffset(double planeOffset);

        void Regen();
    }
}