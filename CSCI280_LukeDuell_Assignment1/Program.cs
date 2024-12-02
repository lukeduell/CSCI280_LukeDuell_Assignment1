/* Luke Duell
 * Instructor: Professor Hanoudi
 * CSCI 280
 * Assignment 1
 * Description: This program takes in the users selection for binary numbers
 *              and selects the operation and the result of the operation is
 *              output.
 */

using System;

class WritetoConsole
{
    static void Main()
    {
        int binay_1 = 0, binay_2 = 0;
        string binay_1_user, binay_2_user;

        Console.WriteLine("Enter first binary integer");
        binay_1_user = Console.ReadLine();
        binay_1 = int.Parse(binay_1_user);

        Console.WriteLine("Enter second binary integer");
        binay_2_user = Console.ReadLine();
        binay_2 = int.Parse(binay_2_user);

    here:
        Console.WriteLine("Enter X to do XOR, O to do OR, or A to do AND");
        int choice = Console.Read();
        if(choice == 'X')
        {
            int result = binay_1 ^ binay_2;
            Console.WriteLine($"\nRESULT: {result}");
        }
        else if (choice == 'O')
        {
            int result = binay_1 | binay_2;
            Console.WriteLine($"\nRESULT: {result}");
        }
        else if (choice == 'A')
        {
            int result = binay_1 & binay_2;
            Console.WriteLine($"\nRESULT: {result}");
        }
        else
        {
            goto here;
        }
    }
}

