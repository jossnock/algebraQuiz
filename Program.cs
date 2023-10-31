// Change console appearance
Console.Title="VeryCoolConsole";
Console.ForegroundColor=ConsoleColor.Green;


Console.WriteLine("For the following problems, solve for x:");
Console.WriteLine();


Console.WriteLine("x = 2 * 3");
double answer01 = Convert.ToDouble(Console.ReadLine());
int marks = 0;

if (answer01==6){
    Console.WriteLine("Correct!");
    marks+=1;
}
else{
    Console.WriteLine("Incorrect.");
}
Console.WriteLine();
Console.WriteLine("Next problem:");


Console.WriteLine("2x + 3 = 9");
double answer02 = Convert.ToDouble(Console.ReadLine());
if (answer02==3){
    Console.WriteLine("Correct!");
    marks+=1;
}
else{
    Console.WriteLine("Incorrect.");
}
Console.WriteLine();
Console.WriteLine("Next problem:");


Console.WriteLine("x + (20 * 3) = 61");
double answer03 = Convert.ToDouble(Console.ReadLine());
if (answer03==1){
    Console.WriteLine("Correct!");
    marks+=1;
}
else{
    Console.WriteLine("Incorrect.");
}
Console.WriteLine();

Console.WriteLine($"Your total score is {marks}/3");


// Wait before closing
Console.ReadKey();