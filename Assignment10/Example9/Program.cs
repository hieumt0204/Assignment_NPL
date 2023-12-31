﻿public class Program
{
    /*
     * Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.
        Test Data :
        The members of the list are :
        55 200 740 76 230 482 95
         :
        The numbers greater than 80 are :
        200
        740
        230
        482
        95
     */
    static void Main(string[] args)
    {

        int[] numbers = { 55, 200, 740, 76, 230, 482, 95 };
        var result = numbers.Where(x => x > 80);
        Console.WriteLine("The number > 80");
        foreach(var item in result)
        {
            Console.WriteLine(item);
        }
    }
}