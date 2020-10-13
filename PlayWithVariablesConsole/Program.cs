using System;

namespace PlayWithVariablesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            int age;
            char HandIWriteWith;
            bool isAlive;
            double fromVariable;
            decimal randomNumber;

            firstName = "Khem";
            age = 37;
            HandIWriteWith = 'R';
            isAlive = true;
            fromVariable = 1.59;
            randomNumber = 9.13M;

            Console.WriteLine($"My first name is {firstName}, my age is {age} years old, I write with my {HandIWriteWith} hand, it is {isAlive} I'm alive, I paid {fromVariable} for coffee, this is how much I paid for lottery tickets {randomNumber}");


        }
    }
}
