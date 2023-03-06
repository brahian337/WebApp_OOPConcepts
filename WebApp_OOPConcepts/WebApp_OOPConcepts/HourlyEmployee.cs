using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public float Hours { get; set; }
        public decimal HoursValue { get; set; }

        #endregion

        public override decimal GetValueToPay()
        {
            return HoursValue * (decimal)Hours;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Hours...............{Hours}\n\t" +
                $"Value per hour......{HoursValue:C2}\n\t" +
                $"Get value to pay....{GetValueToPay():C2}";
        }

    }
}
