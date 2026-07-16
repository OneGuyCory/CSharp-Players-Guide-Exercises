/*Objectives
    create program that allows users to enter how many provinces, duchies, estates they have
    Add up total score, estate-1, duchy-3, province-6
    Display total points */
Console.Write("How many provinces do you have: ");
int provinces = int.Parse(Console.ReadLine()) * 6;

Console.Write("How many estates do you have: ");
int estates = int.Parse(Console.ReadLine()) * 1;

Console.Write("How many duchies do you have: ");
int duchies  = int.Parse(Console.ReadLine()) * 3;

int total = provinces + duchies + estates;

Console.Write($"Your total score is: {total}");