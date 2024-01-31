// See https://aka.ms/new-console-template for more information

// This is the intro kinda thing. Has the Console.WriteLine(), which is just me talking to the player.

Console.WriteLine("Whats up dude.");
Console.WriteLine("This coding langauge doesnt make much sense to me, for example...");

// This will be updated frequently I believe. Anyway, its an Integer variable, showing off how bad I am at adapting to new code.
int timesIveRestarted = 5;
Console.WriteLine(timesIveRestarted);

// An If and Else If statement, and a Bool Variable. I will change it to false if I can finish this project on time.
bool skillIssue = true;

if (skillIssue)
{
    Console.WriteLine("That was how many times I've tried to code. A skill issue.");
}
else if (skillIssue)
{
    Console.WriteLine("I goofed up that many times trying to code. But, I still was able to finish this project, which was cool.");
}

Console.WriteLine("Am I going talking too fast? Yes or no.");
string ignoreAnswer = Console.ReadLine()!;
Console.WriteLine("Eh, doesnt matter.");


/*With for loops, you can initialize a variable in the parentheses. But it can only be used
within that loop*/
Console.WriteLine("Check out how many cats I can pet in like, 3 seconds.");
for (int cats = 0; cats < 3; cats++)
{
    // For every jumping jack, keep track and print the results
    Console.WriteLine("I've just pet " + (cats + 1) + " cat(s).");
}
