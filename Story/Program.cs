using System;

Console.WriteLine("Welcome To Your Nightmare");
Console.WriteLine();
Console.WriteLine("Press Enter To Continue");
Console.ReadLine();
Console.Clear();

Console.WriteLine("You are in a Colosseum and you have two weapons of choice against a Lion.");
Console.WriteLine("You Can Choose between a Gun and a Shield, What do you Choose.");
string answer1 = Console.ReadLine().ToLower();
Console.Clear();

if (answer1 == "gun")
{
    Console.WriteLine("You Picked the Gun, the Lion is out of his cage and runs towards you. You draw the Gun and you close your eyes and shoots the Lion repeatedly. You are out of ammo and the Lion Rips you apart Limb by Limb.");
    Console.WriteLine();
    Console.WriteLine("Press Enter to Exit");
    Console.ReadLine();
    Environment.Exit(0);

}
else if (answer1 == "shield")
{
    Console.WriteLine("You Choose the Shield, the Lion is out of his cage and runs towards you. You block the Lions attack and run towards the cage. You get inside the cage.");
    Console.WriteLine();
    Console.WriteLine("Press Enter to Continue.");
}
else
{
    Console.WriteLine("The Lion attacked you when you where defenseless and ripped your arms and legs of your body and left you for dead.");
    Console.WriteLine();
    Console.WriteLine("Press Enter to Exit");
    Console.ReadLine();
    Environment.Exit(0);
}
Console.ReadLine();
Console.Clear();

Console.WriteLine("You survived the attack and succeded to not die");
Console.WriteLine("You have know two Choices, you can Escape or Pray.");
string answer2 = Console.ReadLine().ToLower();
Console.Clear();


if (answer2 == "escape")
{
    Console.WriteLine("You took the reasonable answer and try to escape the colosseum. You see one guard standing infront of the cage and you decide to go behinde and strangle the guard until he is dead.");
    Console.WriteLine("You see the keys in the guards pocket and takes them, you unlock the cage and you walk out of there like nothing happend.");
    Console.WriteLine();
    Console.WriteLine("Press Enter to Continue.");
    Console.ReadLine();
}
else if (answer2 == "pray")
{
    Console.WriteLine("You choosed the dumb choice, you get killed by the Lion like a idiot. You fool.");
    Console.WriteLine();
    Console.WriteLine("Press Enter to Exit.");
    Console.ReadLine();
    Environment.Exit(0);
}
else
{
    Console.WriteLine("You did not choose a answer the Lion breaks the shield and rips your limbs of your body and eats you.");
    Console.WriteLine();
    Console.WriteLine("Press Enter to Exit.");
    Console.ReadLine();
    Environment.Exit(0);
}
Console.Clear();

Console.WriteLine("Mission Accomplished");
Console.WriteLine(     "Agent 47");
Console.WriteLine();
Console.WriteLine("Write the right word to Exit.");
string answer3 = Console.ReadLine().ToLower();
Console.Clear();


if (answer3 == "hitman")
{
    Environment.Exit(0);
}
else 
{
    Console.WriteLine("Your answer was wrong.");
}
Console.ReadLine();
