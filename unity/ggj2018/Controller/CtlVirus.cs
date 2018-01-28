using ggj2018.ENUMs;
using System;

namespace ggj2018.Controller
{
    class CtlVirus
    {
        internal static EnumVirus GetRandomVirus()
        {
            var retValue = EnumVirus.CopyVirus;

            var randomValue = new Random();
            int randomInt = randomValue.Next(0, Enum.GetNames(typeof(EnumVirus)).Length);

            retValue = (EnumVirus)randomInt;

            return retValue;
        }
    }
}