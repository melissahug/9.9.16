using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._9._16
{
    class Program
    {
        static void Main(string[] args)

        {
            //no variable is needed to be declared. 
            /*Console.WriteLine("\a");
            Console.WriteLine("\"Independence Day\"");
            Console.Write("\t" + "Melissa" + "\n" + "Hughes"); */

            /*
            string word1 = "Hello";
            string word2 = "hello";
            bool strEq2 = word1.Equals(word2,StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(strEq2);*/

            /*
            string word1 = "Hello";
            string word2 = "hello";
            Console.WriteLine("word1".CompareTo("word2"));
            */
            /*
            string word1 = "good";
            string word2 = "goods";
            Console.WriteLine("word1".CompareTo("word2"));            
            */

            /*
            string firstName = "Melissa";
            string lastName = "Hughes";
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine(fullName);

            int age = 40;
            string nameAndAge = "Name:" + fullName + "\nAge: " + age;

            Console.WriteLine(nameAndAge); */

            string pass1 = "cODEword";
            string pass2 = "CodeWord";
            string pass3 = "CodewoRD";

            if(pass1.ToUpper()=="CODEWORD"&& pass2.ToUpper()=="CODEWORD"&&pass3.ToUpper() =="CODEWORD")
            {
                Console.WriteLine("yes");
            }


         
                
                       
         }
    }

}
