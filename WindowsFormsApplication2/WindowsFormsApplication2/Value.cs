using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Value
    {
        private Double val;
        private UnitTypes unitType;

        public Value(Double val, UnitTypes measureUnit)
        {
            this.val = val;
            this.unitType = measureUnit;
        }

        public Double GetVal()
        {
            return val;
        }

        public void SetVal(Double val)
        {
            this.val = val;
        }

        public UnitTypes GetUnitType()
        {
            return unitType;
        }

        public void SetUnitType(UnitTypes unitType)
        {
            this.unitType = unitType;
        }
    }
}
