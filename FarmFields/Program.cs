Console.Write("What is the length of the field: ");
int length = int.Parse(Console.ReadLine());

Console.Write("What is the width of the field: ");
int width  = int.Parse(Console.ReadLine());

int area = length * width;
Console.WriteLine($"The area of the field is {area}");