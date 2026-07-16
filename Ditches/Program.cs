/*Objectives:
Ask the user for two numbers, a width and a length. Convert these to integers.
Calculate the two total lengths, according to the formulas above.
Display both total lengths so the user can compare.*/

Console.Write("What is the width of the ditch: ");
int width = int.Parse(Console.ReadLine());

Console.Write("What is the length of the ditch: ");
int length = int.Parse(Console.ReadLine());

int total1 = width + length / 2 * width;
int total2 = length + width / 2 * length;

Console.WriteLine($"The total lengths are {total1} or {total2}");