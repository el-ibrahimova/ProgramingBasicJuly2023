using System;
using System.Runtime.InteropServices;
using System.Text;

namespace _04.CinemaVoucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int voucherAmount = int.Parse(Console.ReadLine());
            string purchase = Console.ReadLine();

            double price = 0;


            for (int i = 0; i <purchase.Length; i++)
            {
                
                if (purchase.Length > 8)
                {
                    price = 2;
                }
                else if (purchase.Length < 8)
                {
                    price = 1;
                }
                voucherAmount -= price;
            }
                                   
           
        }
    }
}
