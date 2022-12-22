using System.ComponentModel;

namespace TheCouponCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Kata.CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"));
        }
    }
}

//The Coupon Code
//Story
//Your online store likes to give out coupons for special occasions. Some customers try to cheat the system by entering invalid codes or using expired coupons.

//Task
//Your mission:
//Write a function called checkCoupon which verifies that a coupon code is valid and not expired.

//A coupon is no more valid on the day AFTER the expiration date. All dates will be passed as strings in this format: "MONTH DATE, YEAR".