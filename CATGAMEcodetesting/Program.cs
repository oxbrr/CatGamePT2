// AI!!!
// using System.Threading; and using System; are both directives that allow me to use them in the code. Such as the Console, and Thread classes.
using System.Threading;

using System;
class Program
{
    static void Main()
    {
    // This is the intro kinda thing. Has the Console.WriteLine(), which is just me talking to the player.

    PrintWithDelay("Whats up dude.",50);
    PrintWithDelay("This coding langauge doesnt make much sense to me, for example...",50);

    // This will be updated frequently I believe. Anyway, its an Integer variable, showing off how bad I am at adapting to new code.
    
    int timesIveRestarted = 6;
    Console.WriteLine(timesIveRestarted);

    // An If and Else If statement, and a Bool Variable. I will change it to false if I can finish this project on time.

    bool skillIssue = true;
    if (skillIssue)
    {

    // This is what the terminal will show when skillIssue is set to true.

    PrintWithDelay("That was how many times I've tried to code. A skill issue on my part.",50);
    }
    else if (skillIssue)
    {

    // This is what the terminal will show when skillIssue is set to false.

    PrintWithDelay("I goofed up that many times trying to code. But, I still was able to finish this project, which was cool.",50);
    }
    // This isn't needed in the code, this is just referring to the text immediately showing up in the terminal, giving no time to read at all.
    // It also just allows for the user input, while giving the illusion of free will. We write deep messages in our code here.
    PrintWithDelay("Am I going too fast? Yes or no.",50);
    string ignoreAnswer = Console.ReadLine()!;
    PrintWithDelay("Trick question, I don't care.",20);


    // Heres a loop that I learned from the video, the For loop.
    // Its pretty much just me showing how many cats I could pet in 3 seconds. So about 1 cpps (Cat pet per second)

    PrintWithDelay("Check this out, look at how many cats I can pet in like, 3 seconds.",50);
    for (int cats = 0; cats < 3; cats++)
    {
    // And heres it printing out "I've just pet X cat(s). Earlier, i wanted the user to be able to input something...
    // ...but it was honestly way too annoying to add, and this is a loop regardless, which does stop.

    PrintWithDelay("I've just pet " + (cats + 1) + " cat(s).",20);
    }
    }

// AI!!!
// What this function does is that, it allows text to be written, not shown immediately. Its pretty much Console.writeline()...
// ...but it has a delay for each character, Thread.Sleep. And I can set it to any value in milleseconds. I could make each character appear each second...
// ...Or every 1/20th of a second.
    static void PrintWithDelay(string text, int delayPerCharacter)
    {
        foreach (char c in text) // I cant explain this one too well. This is the AI's description. "The method uses a foreach loop to iterate through each character (char c) in the input string text."
        {
            Console.Write(c);
            Thread.Sleep(delayPerCharacter);
        }
        Console.WriteLine(); // "Move to the next line after printing the entire text"
    }
    
}
