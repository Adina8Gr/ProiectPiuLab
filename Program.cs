using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPiuLaborator
{
    public class Camin
    {
        string numeCamin, adresa, Administrator, pretCazare;
        public Camin()
        { numeCamin=adresa=Administrator=pretCazare= string.Empty; }
    }
    
     class Program
    {
        static void Main()
        {
            Camin c1 = new Camin();
            Console.WriteLine(c1);

            Console.ReadKey();
        }
    }
   
}
