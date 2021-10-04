using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignleTonDesignPatternEx
{
   
    class Program
    {
        static void Main(string[] args)
        {
            OurSingleTon obje = OurSingleTon.GetInstance;
            Console.WriteLine(obje.Welcome("employeeOne"));
            Console.WriteLine("After first call No of Running Instance: "
                +OurSingleTon.NoRInstance);
            OurSingleTon obj2 = OurSingleTon.GetInstance;
            
            Console.WriteLine( obj2.Welcome("sam1256"));
            Console.WriteLine("After second call No of Running Instance: " 
                + OurSingleTon.NoRInstance);
            OurSingleTon obj3 = OurSingleTon.GetInstance;
           Console.WriteLine(obj3.Welcome("mohit 1256"));
            Console.WriteLine("After third call No of Running Instance: " 
                + OurSingleTon.NoRInstance);
            Console.ReadKey();
        }
    }
}
