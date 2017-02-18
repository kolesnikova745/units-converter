using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication2
{
    class Converter
    {
        public Value Convert(Value value, UnitTypes unitTypeToConvert)
        {
            if (value.GetUnitType().Equals(unitTypeToConvert))
            {
                return value;
            }

            switch (unitTypeToConvert)
            {
                case UnitTypes.Millimeter:
                case UnitTypes.Centimeter:         
                case UnitTypes.Decimeter:                   
                case UnitTypes.Kilometer:
                case UnitTypes.Meter:
                    return ConvertLength(value, unitTypeToConvert);
                case UnitTypes.Gramm:
                case UnitTypes.Kilogramm:
                case UnitTypes.Centner:
                case UnitTypes.Ton:
                    return ConvertMass(value, unitTypeToConvert);
                case UnitTypes.Second:
                case UnitTypes.Minute:
                case UnitTypes.Hour:
                    return ConvertTime(value, unitTypeToConvert);
            }

            return value;           
        }

        public Boolean save(String path, Value convertingValue, Value convertedValue)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("{0} {1};{2} {3}", convertingValue.GetVal().ToString(), convertingValue.GetUnitType().ToString(),
                    convertedValue.GetVal().ToString(), convertedValue.GetUnitType().ToString());
            }
                       
            return true;
        }

        private Value ConvertLength(Value value, UnitTypes unitTypeToConvert)
        {
            double valueInMeters = ToMeters(value);

            switch (unitTypeToConvert)
            {
                case UnitTypes.Millimeter:
                    value.SetVal(valueInMeters / MeasureUnit.Millimeter);
                    break;
                case UnitTypes.Centimeter:
                    value.SetVal(valueInMeters / MeasureUnit.Centimeter);
                    break;
                case UnitTypes.Decimeter:
                     value.SetVal(valueInMeters / MeasureUnit.Decimeter);
                     break;
                case UnitTypes.Kilometer:
                     value.SetVal(valueInMeters / MeasureUnit.Kilometer);
                     break;
                default:
                     value.SetVal(valueInMeters);
                     break;
            }

            return value;
        }

        private Value ConvertTime(Value value, UnitTypes unitTypeToConvert)
        {
            double valueInSeconds = ToSeconds(value);

            switch (unitTypeToConvert)
            {
                case UnitTypes.Minute:
                    value.SetVal(valueInSeconds / MeasureUnit.Minute);
                    break;
                case UnitTypes.Hour:
                    value.SetVal(valueInSeconds / MeasureUnit.Hour);
                    break;               
                default:
                    value.SetVal(valueInSeconds);
                    break;
            }

            return value;
        }

        private Value ConvertMass(Value value, UnitTypes unitTypeToConvert)
        {
            double valueInKilogramm = ToKilogramms(value);

            switch (unitTypeToConvert)
            {
                case UnitTypes.Gramm:
                    value.SetVal(valueInKilogramm / MeasureUnit.Gramm);
                    break;
                case UnitTypes.Centner:
                    value.SetVal(valueInKilogramm / MeasureUnit.Centner);
                    break;
                case UnitTypes.Ton:
                    value.SetVal(valueInKilogramm / MeasureUnit.Ton);
                    break;
                default:
                    value.SetVal(valueInKilogramm);
                    break;
            }

            return value;
        }

        private Double ToMeters(Value value)
        {
            switch (value.GetUnitType())
            {
                case UnitTypes.Millimeter:
                    return value.GetVal() * MeasureUnit.Millimeter;
                case UnitTypes.Centimeter:
                    return value.GetVal() * MeasureUnit.Centimeter;
                case UnitTypes.Decimeter:
                    return value.GetVal() * MeasureUnit.Decimeter;
                case UnitTypes.Kilometer:
                    return value.GetVal() * MeasureUnit.Kilometer;
                default:
                    return value.GetVal();
            }
        }

        private Double ToKilogramms(Value value)
        {
            switch (value.GetUnitType())
            {
                case UnitTypes.Gramm:
                    return value.GetVal() * MeasureUnit.Gramm;
                case UnitTypes.Centner:
                    return value.GetVal() * MeasureUnit.Centner;
                case UnitTypes.Ton:
                    return value.GetVal() * MeasureUnit.Ton;
                default:
                    return value.GetVal();
            }
        }

        private Double ToSeconds(Value value)
        {
            switch (value.GetUnitType())
            {
                case UnitTypes.Minute:
                    return value.GetVal() * MeasureUnit.Minute;
                case UnitTypes.Hour:
                    return value.GetVal() * MeasureUnit.Hour;             
                default:
                    return value.GetVal();
            }
        }


    }
}
