/* 
 Objectives 
    * Create program lets user enter number of eggs gathered that day
    * use / and % and compute how many eggs each sister should get and remainder for duckbear
    * Find number that gives duckbear more than sisters
    */

Console.Write("How many eggs gathered today: ");
int numEggs = int.Parse(Console.ReadLine());
int sistersEggs = numEggs / 4;
int duckbearEggs = numEggs % 4;

Console.WriteLine($"Each sister gets {sistersEggs} and the duckbear gets {duckbearEggs}");



