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

        static void Main(string[] args)
        {

            int[] Arr1;
            int[] Arr2;
            int[] Arr3= {};

             
            Console.WriteLine("Please enter how many numberes do you want to enter in the first array");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter how many numberes do you want to enter in the Secound one");
            int number2 = int.Parse(Console.ReadLine());
            Arr1 = new int[number1];
            Arr2 = new int[number2];
            
            
            for (int i = 0; i < Arr1.Length; i++)
            {
                Console.WriteLine("enter the " + i + " index of the first array");
                Arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < Arr2.Length; i++)
            {
                Console.WriteLine("enter the " + i + " index of the secound array");
                Arr2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < Arr1.Length; i++)
            {
                if (!Check(Arr1[i], Arr2))
                {
                    int []temp = { Arr1[i] };

                    Arr3= Arr3.Concat(temp).ToArray();

                }
            }
            for (int i = 0; i < Arr2.Length; i++)
            {
                if (!Check(Arr2[i], Arr1))
                {
                    int[] temp = { Arr2[i] };

                    Arr3= Arr3.Concat(temp).ToArray();

                }

            }
            Console.WriteLine("YOUR REQUEST");
            for (int i = 0; i < Arr3.Length; i++)
            {
                Console.WriteLine(Arr3[i]);
            }
        }
    }
}




