using System;
public struct Distance
{
    public int feet;
    public int inches;
     } 

class Program
{
    static void Main()
    {
        
        Console.Write("Enter first lengh ");
        Console.Write("\n Enter foot ");
        int firstFoot = int.Parse(Console.ReadLine());
        Console.Write("Enter inch ");
        int firstInch = int.Parse(Console.ReadLine());

        Console.Write("Enter secons lengh ");
        Console.Write("\n Enter foot ");
        int secondFoot = int.Parse(Console.ReadLine());
        Console.Write("Enter inch ");
        int secondInch = int.Parse(Console.ReadLine());

        int middleFoot = firstFoot + secondFoot;
        int middleInch = firstInch + secondInch;

        int resultInch = middleInch % 12;
        int resultFoot = middleFoot + middleInch / 12;
        Console.WriteLine("Result is " + resultFoot + "\'" + resultInch + "\"");                       }
}