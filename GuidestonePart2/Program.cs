/* 
 Objectives
    * Create program takes two user numbers, converts to floating point type
    * Compute and display distance to that point using provided equation
    * Check multiple numbers
 */

Console.Write("Input a number for x: ");
double numX = Math.Pow(double.Parse(Console.ReadLine()), 2);

Console.Write("Input a number for y: ");
double numY = Math.Pow(double.Parse(Console.ReadLine()), 2);

double distance = Math.Sqrt(numX + numY);
Console.Write(distance);