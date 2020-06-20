using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementProblem
{
    public class Volume
    {
        public enum Unit
        {
            Gallon,
            Litre,
            GallonToLitre
        }

        public double ConvertValueToInch(Unit unit, double value)
        {
            try
            {
                if (unit.Equals(Unit.GallonToLitre))
                {
                    return value * 3.78;
                }
               
                return value;
            }
            catch (Exception e)
            {
                throw new QuantityMeasurementException(QuantityMeasurementException.ExceptionType.InvalidValue, e.Message);
            }
        }
    }
}
