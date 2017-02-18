using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    enum UnitTypes { Nothing, Millimeter, Centimeter, Decimeter, Meter, Kilometer, Gramm, Kilogramm, Centner, Ton, Second, Minute, Hour }

    struct MeasureUnit
    {
        public const Double Millimeter = 0.001;
        public const Double Centimeter = 0.01;
        public const Double Decimeter = 0.1;
        public const Double Meter = 1;
        public const Double Kilometer = 1000;

        public const Double Gramm = 0.001;
        public const Double Kilogramm = 1;
        public const Double Centner = 100;
        public const Double Ton = 1000;

        public const Double Second = 1;
        public const Double Minute = 60;
        public const Double Hour = 3600;
    }
}
