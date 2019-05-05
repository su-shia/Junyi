using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine(p.ConvertStr("junyiacademy"));
            Console.WriteLine(p.RevertStr("flipped class room is important"));
            Console.WriteLine(p.FilterNumberArray(15));

            Console.ReadLine();
        }

        public string ConvertStr(string inputStr)
        {          
            String outputStr = "";

            for(int i = inputStr.Length-1; i >= 0; i--)
            {
                outputStr += inputStr[i];
            }

            return outputStr;

        }

        public string RevertStr(string inputStr)
        {
            //f(“flipped class room is important”) == “deppilf ssalc moor si tnatropmi”
            string[] words = inputStr.Split(' ');
            String outputStr = "";

            for (int i = 0; i < words.Length; i++)
            {
                outputStr += ConvertStr(words[i]);
                if (i > 0) outputStr += " ";
            }

            return outputStr;
        }

        public int FilterNumberArray(int inputNumber)
        {
            List<int> numberList = new List<int>();
            List<int> newNumberList = new List<int>();

            for (int i = 1; i <= inputNumber; i++)
            {
                numberList.Add(i);
            }

            for (int i = 0; i < numberList.Count; i++)
            {
                int number = numberList[i];
                if(number % 3 == 0 || number % 5 == 0)
                {
                    if(number % 3 == 0 && number % 5 == 0) newNumberList.Add(number);
                }
                else
                {
                    newNumberList.Add(number);
                }
            }

            return newNumberList.Count;
        }
            
    }
}
