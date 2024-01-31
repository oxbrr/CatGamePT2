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
    // This is what the terminal will show when skillIssue is set to true.
    Console.WriteLine("That was how many times I've tried to code. A skill issue on my part.");
}
else if (skillIssue)
{
    // This is what the terminal will show when skillIssue is set to false.
    Console.WriteLine("I goofed up that many times trying to code. But, I still was able to finish this project, which was cool.");
}

Console.WriteLine("Am I going talking too fast? Yes or no.");
string ignoreAnswer = Console.ReadLine()!;
Console.WriteLine("Eh, doesnt matter.");


// Heres a loop that I learned from the video, the For loop.
// Its pretty much just me showing how many cats I could pet in 3 seconds. So about 1 cpps (Cat pet per second)
Console.WriteLine("Check out how many cats I can pet in like, 3 seconds.");
for (int cats = 0; cats < 3; cats++)
{
    // And heres it printing out "I've just pet X cat(s). Earlier, i wanted the user to be able to input something...
    // ...but it was honestly way too annoying to add, and this is a loop regardless, which does stop.
    Console.WriteLine("I've just pet " + (cats + 1) + " cat(s).");
}