using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201221Svarstykles
{
    class Program
    {
        static void Main(string[] args)
        {
            int k1 = 1;
            int k2 = 0;
            int k3 = 1;
            int k4 = 1;
            int k5 = 1;
            int k6 = 1;
            int k7 = 1;
            int k8 = 1;

            if(k1+k2+k3 > k4+k5+k6)
            {
                if(k4>k5)
                {
                    Console.WriteLine(5);
                }
                else if(k4<k5)
                {
                    Console.WriteLine(4);
                }
                else
                {
                    Console.WriteLine(6);
                }
            }
            else if(k1 + k2 + k3 < k4 + k5 + k6)
            {
                if (k1 > k2)
                {
                    Console.WriteLine(2);
                }
                else if (k1 < k2)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(3);
                }
            }
            else
            {
                if(k7>k8)
                {
                    Console.WriteLine(8);
                }
                else
                {
                    Console.WriteLine(7);
                }
            }

            //if(k1 + k2+ k3 +k4> k5 + k6+ k7+k8)
            //{
            //    if(k5+k6>k7+k8)
            //    {
            //        if(k7>k8)
            //        {

            //        }
            //        else
            //        {

            //        }
            //    }
            //    else
            //    {
            //        if(k5>k6)
            //        {

            //        }
            //        else
            //        {

            //        }
            //    }
            //}
            //else
            //{
            //    if (k1 + k2 > k3 + k4)
            //    {
            //        if (k3 > k4)
            //        {
            //            //4
            //        }
            //        else
            //        {
            //            //3
            //        }
            //    }
            //    else
            //    {
            //        if (k1 > k2)
            //        {
            //            //2
            //        }
            //        else
            //        {
            //            //1
            //        }
            //    }
            //}
            Console.Read();
        }
    }
}
