// Build Dice Game
    Console.WriteLine("===Simple Dice Game===\nType 'Start' or 'S' to roll the die");
string startGame = Console.ReadLine()!;

while (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
 {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid Key Word Provided!.");
        Console.ResetColor();
        Console.WriteLine("Enter 'Start' or 'S' to start the game properly");
        startGame = Console.ReadLine()!;
 }

    Random rand =new();
    int diceOne = rand.Next(1, 7);
    int diceTwo = rand.Next(1, 7);
    int diceThree = rand.Next(1, 7);
    int originalScore = diceOne + diceTwo + diceThree;
    const int DOUBLE_POINT = 2;
    const int TRIPLE_POINT = 6;
    int totalPoint = originalScore;

 if (diceOne == diceTwo && diceTwo == diceThree)
 {
    totalPoint += TRIPLE_POINT;

    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \nYou rolled a tripple! You Have a total of {totalPoint} point");
 }
 else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
 {
    totalPoint += DOUBLE_POINT;

    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \nYou rolled a double! You Have a total of {totalPoint} point");
 }
 else
 {
    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \n You Have a total of {totalPoint} point");
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
    Console.WriteLine("Congratulations! You won Yourself a TICKET TO STV GALERY!");
}
else if (totalPoint ==21)
{
    Console.WriteLine("Congratulations it's a special!, You won Yourself a Samsung A24!");
}
else
{
    Console.WriteLine("Nice try, keep it");
}

Console.WriteLine("Type 'Yes' or 'No' to replay");
string Replay = Console.ReadLine()!;

while (!(Replay.Equals("Yes", StringComparison.OrdinalIgnoreCase) || Replay.Equals("No", StringComparison.OrdinalIgnoreCase)))
 {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Enter a VALID key");
    Console.ResetColor();
    Console.WriteLine("Type 'Y' or 'N' to replay");
    startGame = Console.ReadLine()!;
 }

 if (diceOne == diceTwo && diceTwo == diceThree)
 {
    totalPoint += TRIPLE_POINT;

    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \nYou rolled a tripple! You Have a total of {totalPoint} point");
 }
 else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
 {
    totalPoint += DOUBLE_POINT;

    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \nYou rolled a double! You Have a total of {totalPoint} point");
 }
 else
 {
    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}. \n You Have a total of {totalPoint} point");
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
    Console.WriteLine("Congratulations! You won Yourself a TICKET TO STV GALERY!");
}
else if (totalPoint ==21)
{
    Console.WriteLine("Congratulations it's a special!, You won Yourself a Samsung A24!");
}
else
{
    Console.WriteLine("Nice try, keep it");
}

        
            


