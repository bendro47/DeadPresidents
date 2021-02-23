using System;
using System.Collections.Generic;
using System.Linq;

namespace DeadPresidents
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<President> presidentList = new List<President>()
            {
                new President() {PresidentName="George Washington",Age=67 },
                new President() {PresidentName="Thomas Jefferson",Age=83 },
                new President() {PresidentName="John Adams",Age=90},
                new President() {PresidentName="James Monroe",Age=73 },
                new President() {PresidentName="James Madison",Age=85 }

            };
            var x = from y in presidentList
                    where y.PresidentName != null
                    select y;
            foreach(President y in x)
            {
                Console.WriteLine(y.PresidentName + " Age of Death " + y.Age);
            }
            //LINQ
            Console.WriteLine("\nList of Those Who Died Between Ages 60 to 80");
            var t = from s in presidentList
                    where s.Age > 60 && s.Age < 80
                    select s;
            foreach (President s in t)
            {
                Console.Write(s.PresidentName);
                Console.WriteLine(" Age of Death: "+ s.Age.ToString());
            }

        }//main
    }//class
    public class President
    {
        public int PresidentID { get; set; }
        public string PresidentName { get; set; }
        public int Age { get; set; }
    }
}//program



