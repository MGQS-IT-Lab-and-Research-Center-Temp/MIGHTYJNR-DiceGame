

// Build Dice Game
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("===Welcome to Odus Simple Dice Game===");
Console.ResetColor();
try
{
    Console.WriteLine("Enter Your Nickname: "); //{0}
    string nickname = Console.ReadLine()!;
    Console.WriteLine("Enter the number of times you want to play: "); //{1}
    int noOfPlay = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Welcome {0}! you have choosen to play {1} times." ,nickname, noOfPlay);
    bool flag = true;



    Console.WriteLine("Type 'S' to start your game:");
    string startGame = Console.ReadLine()!;

    /*Console.WriteLine($"Welcome {nickname}! \nType 'S' to start your game:");
    string startGame = Console.ReadLine()!;*/


    while (!startGame.Equals("S",StringComparison.OrdinalIgnoreCase))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid Key Word Provided!.");
        Console.ResetColor();
        Console.WriteLine("Type 'S' to start the game:");
        startGame = Console.ReadLine()!;
    }

    while (flag && !(noOfPlay <1))
    {
        Random rand =new();
        int diceOne = rand.Next(1, 7);
        int diceTwo = rand.Next(1, 7);
        int diceThree = rand.Next(1, 7);
        int originalScore = diceOne + diceTwo + diceThree;
        const int DOUBLE_POINT = 2;
        const int TRIPLE_POINT = 6;
        noOfPlay--;
        int totalPoint = originalScore;

        if (diceOne == diceTwo && diceTwo == diceThree)
        {
            totalPoint += TRIPLE_POINT;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}\nOriginal Score: {originalScore}. \nWow, You rolled a tripple! with a bonus point of {TRIPLE_POINT}. \nYou Have a total of {totalPoint} point");
            Console.ResetColor();
        }
        else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
        {
            totalPoint += DOUBLE_POINT;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}\nOriginal Score: {originalScore}. \nYou rolled a double! with a bonus point of {DOUBLE_POINT}. \nYou Have a total of {totalPoint} point");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \nYou Have a total of {totalPoint} point");
            Console.ResetColor();
        }

        if (totalPoint >=10 && totalPoint <=13)
        {
            Console.WriteLine("Congratulations! You won Yourself a BALLOON!");
        }
        else if (totalPoint >=14 && totalPoint <=16)
        {
            Console.WriteLine("Congratulations! You won Yourself an EXERCISE BOOK!");
        }
        else if (totalPoint ==17)
        {
            Console.WriteLine("Congratulations! You won Yourself a 5000mAh POWER BANK!");
        }
        else if (totalPoint >=18 && totalPoint <=20)
        {
            Console.WriteLine("Congratulations! You won Yourself a TICKET TO STV GALLERY!");
        }
        else if (totalPoint ==21)
        {
            Console.WriteLine("Congratulations it's a SPECIAL!!!, You won Yourself a Samsung A24!");
        }
        else if (totalPoint >=22 && totalPoint <=24)
        {
            Console.WriteLine("Congratulations! You won ALL GIFT!");
        }
        else
        {
            Console.WriteLine("Nice try, please try again");
        }

        if (noOfPlay <1)
        {
            Console.WriteLine($"Weldone {nickname}! your roll cycle is completed");
            break;
        }

        Console.WriteLine("==============================="); 
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"You have {noOfPlay} times left");
        Console.ResetColor();
        Console.WriteLine("===============================");
        string decision = string.Empty;
        string yes = "yes";
        string no = "no";

        do
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Would you like to continue? (YES/NO): ");
            decision = Console.ReadLine()!;
            Console.ResetColor();
        }
        while (!decision.Equals(yes, StringComparison.OrdinalIgnoreCase) && !decision.Equals(no, StringComparison.OrdinalIgnoreCase));
        flag = decision.Equals(yes, StringComparison.OrdinalIgnoreCase);
    }           
}
 catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ResetColor();
    }
// /*
// // Build Dice Game
//     Console.WriteLine("===Simple Dice Game===\nType 'Start' or 'S' to roll the die");
// string startGame = Console.ReadLine()!;

// while (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
//  {
//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.WriteLine("Invalid Key Word Provided!.");
//         Console.ResetColor();
//         Console.WriteLine("Enter 'Start' or 'S' to start the game properly");
//         startGame = Console.ReadLine()!;
//  }

//     Random rand =new();
//     int diceOne = rand.Next(1, 7);
//     int diceTwo = rand.Next(1, 7);
//     int diceThree = rand.Next(1, 7);
//     int originalScore = diceOne + diceTwo + diceThree;
//     const int DOUBLE_POINT = 2;
//     const int TRIPLE_POINT = 6;
//     int totalPoint = originalScore;

//  if (diceOne == diceTwo && diceTwo == diceThree)
//  {
//     totalPoint += TRIPLE_POINT;

//     Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \nYou rolled a tripple! You Have a total of {totalPoint} point");
//  }
//  else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
//  {
//     totalPoint += DOUBLE_POINT;

//     Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \nYou rolled a double! You Have a total of {totalPoint} point");
//  }
//  else
//  {
//     Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \n You Have a total of {totalPoint} point");
//  }

// if (totalPoint >=10 && totalPoint <=13)
// {
//     Console.WriteLine("Congratulations! You won Yourself a BALLOON!");
// }
// else if (totalPoint >=14 && totalPoint <=16)
// {
//     Console.WriteLine("Congratulations! You won Yourself an EXERCISE BOOK!");
// }
// else if (totalPoint ==17)
// {
//     Console.WriteLine("Congratulations! You won Yourself a 5000mAh POWER BANK!");
// }
// else if (totalPoint >=18 && totalPoint <=20)
// {
//     Console.WriteLine("Congratulations! You won Yourself a TICKET TO STV GALERY!");
// }
// else if (totalPoint ==21)
// {
//     Console.WriteLine("Congratulations it's a special!, You won Yourself a Samsung A24!");
// }
// else
// {
//     Console.WriteLine("Nice try, keep it");
// }

// Console.WriteLine("Type 'Yes' or 'Y' to replay ");

// string Replay = Console.ReadLine()!;
// while ((Replay.Equals("Yes", StringComparison.OrdinalIgnoreCase) || Replay.Equals("Y", StringComparison.OrdinalIgnoreCase)))
// {
//    Console.WriteLine("Let's Start Again"); 
// Console.WriteLine("Enter 'Start' or 'S' to RESTART the game.");
//     startGame = Console.ReadLine()!;
//     while (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))

//  if (diceOne == diceTwo && diceTwo == diceThree)
//  {
//     totalPoint += TRIPLE_POINT;

//     Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \nYou rolled a tripple! You Have a total of {totalPoint} point");
//  }
//  else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
//  {
//     totalPoint += DOUBLE_POINT;

//     Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \nYou rolled a double! You Have a total of {totalPoint} point");
//  }
//  else
//  {
//     Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \n You Have a total of {totalPoint} point");
//  }

// if (totalPoint >=10 && totalPoint <=13)
// {
//     Console.WriteLine("Congratulations! You won Yourself a BALLOON!");
// }
// else if (totalPoint >=14 && totalPoint <=16)
// {
//     Console.WriteLine("Congratulations! You won Yourself an EXERCISE BOOK!");
// }
// else if (totalPoint ==17)
// {
//     Console.WriteLine("Congratulations! You won Yourself a 5000mAh POWER BANK!");
// }
// else if (totalPoint >=18 && totalPoint <=20)
// {
//     Console.WriteLine("Congratulations! You won Yourself a TICKET TO STV GALERY!");
// }
// else if (totalPoint ==21)
// {
//     Console.WriteLine("Congratulations it's a special!, You won Yourself a Samsung A24!");
// }
// else
// {
//     Console.WriteLine("Nice try, keep it");
// }

        
            


// }
// */