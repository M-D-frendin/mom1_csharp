using myMLApp;

//program begins execution here

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("This application will try to predict if a given review is positive or negative.");
Console.WriteLine("Input review:");

//get review from console input, set color of input text for clarity
Console.ForegroundColor = ConsoleColor.DarkYellow;
string? input = Console.ReadLine();

//exit if input is empty
if (string.IsNullOrEmpty(input))
{
    return;
}

//reset color to white
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.Write("Analyzing...");

//create review object (which analyzes the review)
Review review = new Review(input);
Console.WriteLine(" Done!");
Console.WriteLine("");


//write review result to console
Console.Write("Review is determined to be: ");

if (review.IsPositive)
{
    //review is positive - write to console with green background
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("  POSITIVE  ");
} else {
    //review is negative - write to console with red background
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("  NEGATIVE  ");
}

//reset color to white
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

//get user input to allow user time to review the result before the program closes
Console.WriteLine("Press any key to close");
Console.ReadKey();
Console.Clear();