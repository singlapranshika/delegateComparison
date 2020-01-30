using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delgateComparison
{
    class Cities
    {
       
       
        
        public static int  CompareByName(string x,string y)
        {
            return x.CompareTo(y);

        }
        public static void Display(List<string> list)
        {
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            List<string> City = new List<string>();
            City.Add("Hyderbad");
            City.Add("delhi");
            City.Add("shimla");
            City.Add("chandigarh");
            Display(City);
            City.Sort(CompareByName);
            Display(City);
        }
    }
}
