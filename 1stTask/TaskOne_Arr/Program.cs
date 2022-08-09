using System;
using System.Linq;

namespace TaskOne_Arr
{
    //this Used to test Arrays
    class Program
    {
         static int[] counter ;
        static char[] character  ;

        static void dic(char []small, String big)
        {
            for (int i = 0; i < small.Length; i++)
            {
                        character[i] = char.ToUpper(small[i]);
                for (int j = 0; j < big.Length; j++)
                {
                    if (char.ToUpper(small[i]) == big.ToUpper().ToCharArray()[j])
                    {
                        counter[i] += 1;
                        
                    }
                    

                }

            }

        }
      
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter First Word");
            string Word = Console.ReadLine(); ;
            Console.WriteLine("Enter Secound Word");
            string OtherWord = Console.ReadLine(); ;
            if (OtherWord.Length> Word.Length)
            {
                counter = new int[Word.Distinct().Count()];
                character= new char[Word.Distinct().Count()];
                dic(Word.Distinct().ToArray(), OtherWord);
            }
            else
            {
                counter = new int[OtherWord.Distinct().Count()];
                character = new char[OtherWord.Distinct().Count()];
                dic(OtherWord.Distinct().ToArray(), Word);
            }

            for (int i = 0; i < counter.Length; i++)
            {
                Console.WriteLine(character[i]+": "+ counter[i]);



            }

        }
    }
}
