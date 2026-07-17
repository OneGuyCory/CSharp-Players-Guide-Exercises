/*  
 Objectives
    Create program to compute area of a circle using floating point type
 */

Console.Write("What is the radius of the circle: ");
double radius = double.Parse(Console.ReadLine());

double area = Math.PI * radius *  radius;

Console.WriteLine(area);