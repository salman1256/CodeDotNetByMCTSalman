using System;
namespace SignleTonDesignPatternEx
{    public sealed class OurSingleTon
    {   private static int noRInstance = 0;
        private static OurSingleTon instance = null;
        private OurSingleTon()
        {   noRInstance++;
            Console.WriteLine("Number of Running Instance "+noRInstance);
        }
        public static int NoRInstance { get { return noRInstance; } }
        public static OurSingleTon GetInstance {
            get {
                if (instance == null)
                { instance = new OurSingleTon(); }
                return instance;
                }          }
        public string Welcome(string userName)
        {       return "Welcome to SingleTon Design Pattern : \t  " + userName;      }
        }    }  
