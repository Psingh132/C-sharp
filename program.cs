using System;

namespace FirstProgram
{
    class program{
        static void Main(string[] args){
        
            Console.WriteLine("Enter a number between 1 and 10: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            if(inputNumber>0 && inputNumber<=10){
                Console.WriteLine("Valid");
            }
            else
            Console.WriteLine("Invalid");
        }
    }
}