using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCouponCode
{
    public class Kata
    {

        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate) =>
            ((enteredCode == correctCode) && (DateTime.Parse(currentDate) < DateTime.Parse(expirationDate).AddDays(1)));
   
    }
}
