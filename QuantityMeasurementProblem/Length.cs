using System;

namespace QuantityMeasurementProblem
{
    public class Length
    {
        public enum Unit { FEET, INCH, YARD }

        private Unit unit;
        private double value;
        private double FeetToInch = 12.0;
        private double InchToFeet = 12.0;
        private double FeetToYard = 3.0;
        private double YardToInch = 36.0;
        private double InchToYard = 36.0;
        private double YardToFeet = 3.0;

        public Length(Unit unit,double value)
        {
            this.unit = unit;
            this.value = value;
        }

        public bool Compare(Length that)
        {
            if (this.unit.Equals(that.unit))
            {
                return this.Equals(that);
            }
            if (this.unit.Equals(Unit.FEET) && that.unit.Equals(Unit.INCH))
            {
                return that.value.CompareTo(this.value*FeetToInch) == 0;
            }
            if (this.unit.Equals(Unit.INCH) && that.unit.Equals(Unit.FEET))
            {
                return that.value.CompareTo(this.value / InchToFeet) == 0;
            }
            if (this.unit.Equals(Unit.FEET) && that.unit.Equals(Unit.YARD))
            {
                return that.value.CompareTo(this.value / FeetToYard) == 0;
            }
            if (this.unit.Equals(Unit.YARD) && that.unit.Equals(Unit.INCH))
            {
                return that.value.CompareTo(this.value * YardToInch) == 0;
            }
            if (this.unit.Equals(Unit.INCH) && that.unit.Equals(Unit.YARD))
            {
                return that.value.CompareTo(this.value / InchToYard) == 0;
            }
            if (this.unit.Equals(Unit.YARD) && that.unit.Equals(Unit.FEET))
            {
                return that.value.CompareTo(this.value * YardToFeet) == 0;
            }

            return false;
        }

        public override bool Equals(object o)
        {
            // It checks for the Object
            if (this == o)
            {
                return true;
            }

            // It checks for object if null or object type is not equal then return false
            if (o == null || !this.GetType().Equals(o.GetType()))
            {
                return false;
            }

            Length length = (Length)o;
            return value.CompareTo(length.value) == 0 & unit == length.unit;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(value);
        }
      
    }
}
