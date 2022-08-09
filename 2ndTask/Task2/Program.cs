using System;
using System.Linq;

namespace Task2
{
    class Program
    {


   
        public static bool Check(int num, int[] arr2)
        {
            bool isArrayEqual = false;
            
            for (int i = 0; i < arr2.Length; i++)
            {

                if (num == arr2[i])
                {
                    isArrayEqual = true;
                }
            

            }


            return isArrayEqual;
        }
        public static bool Checkint(String S)
        {
       
            int numericValue;

    
                bool i2 = int.TryParse(S, out numericValue);
            
            

            return i2;

        }
        static void Main(string[] args)
        {

            int[] Arr1;
            int[] Arr2;
            int[] Arr3= {};
            int number1=0;
            int number2=0;
            String s;
            while (true)
            {

            Console.WriteLine("Please enter how many numberes do you want to enter in the first array");
            s = Console.ReadLine();
            if (Checkint(s))
            {
             number1 = int.Parse(s);
                    break;
            }
            else
            {
                Console.WriteLine("Please enter number not charater");
            }
            }
            while (true)
            {
                Console.WriteLine("Please enter how many numberes do you want to enter in the Secound one");
                s = Console.ReadLine();
                if (Checkint(s))
                {
                    number2 = int.Parse(s);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter number not charater");
                }
            }
            Arr1 = new int[number1];
            Arr2 = new int[number2];
            int i = 0;
            while (i < Arr1.Length)
            {
                Console.WriteLine("enter the " + i + " index of the first array");
                s = Console.ReadLine();
                if (Checkint(s))
                {

                    Arr1[i] = int.Parse(s);
                    i = i + 1;
                }
                else
                {

                    Console.WriteLine("Please enter number not charater");
                }

            }
            i = 0;
            while (i < Arr2.Length)
            {

                Console.WriteLine("enter the " + i + " index of the secound array");
                s = Console.ReadLine();
                if (Checkint(s))
                {

                    Arr2[i] = int.Parse(s);
                    i = i + 1;
                }
                else
                {

                    Console.WriteLine("Please enter number not charater");
                }

            }

            
            for ( i = 0; i < Arr1.Length; i++)
            {
                if (!Check(Arr1[i], Arr2))
                {
                    int []temp = { Arr1[i] };

                    Arr3= Arr3.Concat(temp).ToArray();

                }
            }
            for ( i = 0; i < Arr2.Length; i++)
            {
                if (!Check(Arr2[i], Arr1))
                {
                    int[] temp = { Arr2[i] };

                    Arr3= Arr3.Concat(temp).ToArray();

                }

            }
            Console.WriteLine("YOUR REQUEST");
            for ( i = 0; i < Arr3.Length; i++)
            {
                Console.WriteLine(Arr3[i]);
            }
        }
    }
}




