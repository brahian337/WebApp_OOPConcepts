using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts
{
    public class CommissionEmployee : Employee
    {
        #region Properties

        public double CommissionPercentage { get; set; }
        public decimal Sales { get; set; }

        #endregion

        public override decimal GetValueToPay()
        {
            return Sales * ((decimal)(CommissionPercentage/100));
        }
        
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Commission percentage.........{CommissionPercentage/100:P2}\n\t" +
                $"Sales.........................{Sales:C2}\n\t" + 
                $"Get value to pay..............{GetValueToPay():C2}\n\t";
        }

    }
}
