using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Reversestring
    {
        Random r = new Random();
        public void StringSwap()
        {

            Console.WriteLine("\nRandom string generator and reverser \n ----- \n");
            //Generate Random String
            int randomTxtLength = r.Next(10);
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            string randomTxt = "";

            for(int i = 0; i< randomTxtLength; i++)
            {
                randomTxt += chars[r.Next(chars.Length)];
            }
            Console.WriteLine($"Random input string is: {randomTxt}");

            string outputString = "";
            if (randomTxt.Length == 1)
            {
                Console.WriteLine($"Output string is: {randomTxt}");

            }
            else
            {
                for (int i = 0; i < randomTxt.Length; i++)
                {
                    outputString += randomTxt[randomTxt.Length - i - 1];
                }
                Console.WriteLine($"Output string is: {outputString}");
            }

            return;

        }
    }
}
