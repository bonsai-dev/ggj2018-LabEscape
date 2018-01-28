using ggj2018.ENUMs;
using System;
using System.ComponentModel;
using System.Reflection;

namespace ggj2018.Controller
{
    class CtlTalking
    {
        internal static string GetRandomPlayerInfectionText()
        {
            var retValue = string.Empty;

            var randomValue = new Random();
            int randomInt = randomValue.Next(0, Enum.GetNames(typeof(EnumPlayerInfectionText)).Length);

            retValue = GetEnumDescription((EnumPlayerInfectionText)randomInt);

            return retValue;
        }

        public static string GetEnumDescription(EnumPlayerInfectionText enumVirus)
        {
            FieldInfo fi = enumVirus.GetType().GetField(enumVirus.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])
                fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return enumVirus.ToString();
        }
    }
}
