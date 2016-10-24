using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.RajaM
{
    public class ReverseANumber : IRun
    {
        public void Run() {
            Console.WriteLine("Please enter the number you want to reverse:");
            int givenNumber = Int32.Parse(Console.ReadLine());
            ReverseNumber(givenNumber);
        }

        public void ReverseNumber(int givenNumber)
        {
            throw new NotImplementedException("ReverseANumber code not implemented.");
        }
    }
}
