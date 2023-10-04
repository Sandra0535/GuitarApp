using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    public enum GuitarType
    {
        ACOUSTIC,
        ELECTRIC
    }
    public static class GuitarTypeExtensions
    {
        public static string ToFriendlyString(this GuitarType guitarType)
        {
            switch (guitarType)
            {
                case GuitarType.ACOUSTIC:
                    return "acoustic";
                case GuitarType.ELECTRIC:
                    return "electric";
                default:
                    throw new InvalidOperationException("Unknown guitar type.");
            }
        }
    }

    public enum Builder
    {
        FENDER,
        MARTIN,
        GIBSON,
        COLLINS,
        OLSON,
        RYAN,
        PRS,
        ANY

    }
    public static class BuilderExtensions
    {
        public static string ToFriendlyString(this Builder BuilderType)
        {
            switch (BuilderType)
            {
                case Builder.FENDER:
                    return "Fender";
                case Builder.MARTIN:
                    return "Martin";
                case Builder.GIBSON:
                    return "Gibson";
                case Builder.COLLINS:
                    return "Collins";
                case Builder.OLSON:
                    return "Olson";
                case Builder.RYAN:
                    return "Ryan";
                case Builder.PRS:
                    return "Prs";
                case Builder.ANY:
                    return "Any";
                default:
                    throw new InvalidOperationException("Unknown guitar type.");
            }
        }
    }
    public enum Wood
    {
        INDIAN_ROSEWOOD,
        BRAZILIAN_ROSEWOOD,
        MAHAGONY,
        MAPLE,
        COCOBOLO,
        CEDAR,
        ADIRONDACK,
        ALDER,
        SITKA
    }
    public static class WoodExtensions
    {
        public static string ToFriendlyString(this Wood WoodType)
        {
            switch (WoodType)
            {
                case Wood.INDIAN_ROSEWOOD:
                    return "acoustic";
                case Wood.BRAZILIAN_ROSEWOOD:
                    return "electric";
                case Wood.MAHAGONY:
                    return "acoustic";
                case Wood.MAPLE:
                    return "acoustic";
                case Wood.COCOBOLO:
                    return "acoustic";
                case Wood.CEDAR:
                    return "acoustic";
                case Wood.ADIRONDACK:
                    return "acoustic";
                case Wood.ALDER:
                    return "acoustic";
                case Wood.SITKA:
                    return "acoustic";
                default:
                    throw new InvalidOperationException("Unknown guitar type.");
            }
        }
    }
}
