using System;

namespace QuantityMeasurementProblem
{
    public class Length
    {
        public enum Unit 
        { 
            Feet, 
            Inch, 
            Yard, 
            CentiMeter,
            FeetToInch, 
            YardToInch,
            CentiMeterToInch
        }

        public Length() 
        {
        }

        public double ConvertValueToInch(Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Unit.FeetToInch))
                {
                    return value * 12.0;
                }
                else if (unit.Equals(Unit.YardToInch))
                {
                    return value * 36.0;
                }
                else if (unit.Equals(Unit.CentiMeterToInch))
                {
                    return value / 2.5;
                }
                return value;
            }
            catch (Exception e)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.InvalidValue, e.Message);
            }
        }

        public double AddTWoLengths(double firstInchValue, double secondInchValue)
        {
            return firstInchValue + secondInchValue;
        }
    }
}
