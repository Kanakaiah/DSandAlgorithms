using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.RajaM
{
    public class Palindrome : IRun
    {
        public Palindrome() {

        }

        public void Run() {
            Console.WriteLine("Please enter a palindrone:");
            string palindrone = Console.ReadLine();
            CheckPalindrone(palindrone);
        }

        public void CheckPalindrone(string palindrone) {
            throw new NotImplementedException("Palidrome code not implemented.");
        }
    }
}
