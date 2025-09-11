string Choice = "";

int Score = 0;

Console.WriteLine("*Hint* Only press A"); 
Console.WriteLine(" "); 
Console.WriteLine("A / B / C -- Press one these");

Choice = Console.ReadLine();
Choice = Choice.ToLower();


if (Choice == "a")
{
    Console.WriteLine("Right awnser!");
    Score += 1;
}
else if (Choice == "b")
{
    Console.WriteLine("Wrong awnser!");
    Score -= 1;
}
else if (Choice == "c")
{
    Console.WriteLine("Wrong awnser!");
    Score -= 1;
}
else
{
    Console.WriteLine(" ");
    Console.WriteLine("That's not a choice you can make");
    Console.WriteLine("Try one more time");

    Console.WriteLine("A / B / C");

    Choice = Console.ReadLine();
    Choice = Choice.ToLower();


    if (Choice == "a")
    {
        Console.WriteLine("Right awnser!");
        Score += 1;
    }
    else if (Choice == "b")
    {
        Console.WriteLine("Wrong awnser!");
        Score -= 1;
    }
    else if (Choice == "c")
    {
        Console.WriteLine("Wrong awnser!");
        Score -= 1;
    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Well since you are going to be like that I'll just give you -100 points");
        Score -= 100;
        
    }


}


Console.WriteLine(" ");
Console.WriteLine("A / B / C -- Press one again");


Choice = Console.ReadLine();
Choice = Choice.ToLower();

if (Choice == "a")
{
    Console.WriteLine("Right awnser!");
    Score += 1;
}
else if (Choice == "b")
{
    Console.WriteLine("Wrong awnser!");
    Score -= 1;
}
else if (Choice == "c")
{
    Console.WriteLine("Wrong awnser!");
    Score -= 1;
}
else
{
    if (Score < -99)
    {
        Console.WriteLine(" ");
        Console.WriteLine("So your still not playing by the rules?");
        Console.WriteLine("It's like you want me to take more of your points");
        Console.WriteLine("So i'll indulge in taking more from you");
        Console.WriteLine("-1000 Points");
        Score -= 1000;
    }
    else if (Score > -99)
    {
        Console.WriteLine(" ");
        Console.WriteLine("That's not a choice you can make");
        Console.WriteLine("Try one more time");

        Console.WriteLine("A / B / C");

        Choice = Console.ReadLine();
        Choice = Choice.ToLower();


        if (Choice == "a")
        {
            Console.WriteLine("Right awnser!");
            Score += 1;
        }
        else if (Choice == "b")
        {
            Console.WriteLine("Wrong awnser!");
            Score -= 1;
        }
        else if (Choice == "c")
        {
            Console.WriteLine("Wrong awnser!");
            Score -= 1;
        }
        else
        {
            Console.WriteLine(" ");
            Console.WriteLine("Well since you are going to be like that I'll just give you -100 points");
            Score -= 100;
        
        }
    }
}


Console.WriteLine(" ");
Console.WriteLine("A / B / C -- Now one last time");

do
{
    Choice = Console.ReadLine();
    Choice = Choice.ToLower();


    if (Choice == "a")
    {
        Console.WriteLine("Right awnser!");
        Score += 1;
    }
    else if (Choice == "b")
    {
        Console.WriteLine("Wrong awnser!");
        Score -= 1;
    }
    else if (Choice == "c")
    {
        Console.WriteLine("Wrong awnser!");
        Score -= 1;
    }
    else if (Score < -999)
    {
        Console.WriteLine("I won't allow you through this time");
        Console.WriteLine("The only way to progress now is TO ACTUALLY FOLLOW THE RULES!");
    }
    else
    {
        Console.WriteLine("Press the right key");
        Console.WriteLine("or else I'm not going to let you pass");
    }
} while (Choice != "a" && Choice != "b" && Choice != "c");

Console.WriteLine(" "); 
Console.WriteLine($"This is your Score: {Score}");

if (Score > 2)
{
    Console.WriteLine("WOW! You pressed all the right choices! You are a good listener!");
}

else if (Score == -3)
{
    Console.WriteLine("You pressed all the wrong choices... Why? All you needed to do was listen to my hint.");
    Console.WriteLine(" ");
    Console.WriteLine("I'll give you one last chance.");
    Console.WriteLine("Just Press A");

    Choice = Console.ReadLine();
    Choice = Choice.ToLower();

    if (Choice == "a")
    {
        Console.WriteLine("Good Job! You finaly followed my order!");
    }

    else if (Choice == "b")
    {
        Console.WriteLine("WHY DON'T YOU LISTEN!!!");
    }

    else if (Choice == "c")
    {
        Console.WriteLine("WHY DON'T YOU LISTEN!!!");
    }

    else
    {
        Console.WriteLine("THAT'S NOT EVEN A CHOICE ON THE BOARD!!!");
    }

}

else if (Score == -102 || Score == -101 || Score == -100 || Score == -99 || Score == -98)
{
    Console.WriteLine("What... How?");
    Console.WriteLine("You would only get -3 if you didn't get the right awnsers");
}

else if (Score < -1000)
{
    Console.WriteLine("Wow...");
    Console.WriteLine("This is the lowest score anyone hes ever gotten on my quiz...");
    Console.WriteLine("I'm impressed");
}

else
{
    Console.WriteLine("Did you not thrust me? I know you didn't listen to my hint on some of those choices.");
}


Console.ReadLine();