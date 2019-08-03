using System;
using System.Collections.Generic;

namespace DataStructureOverview.Sets
{
    public class HashSetExample
    { 
        public void Run()
        {
            HashSet<int> usedCoupons =  new HashSet<int>();

            while(true)
            {
                Console.Write("Insert your coupon number:");
                string couponString = Console.ReadLine();

                if(int.TryParse(couponString, out var couponNumber))
                {
                    var isAdded = usedCoupons.Add(couponNumber);
                    var message = isAdded? "Thank you!":"This coupon was already used.";
                    Console.WriteLine(message);
                }                
            }
        }
    }
}