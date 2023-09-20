// Build Dice Game
Console.WriteLine("===Simple Dice Game===\nType 'Start' or 'S' to roll the die");

string startGame = Console.ReadLine()!;

if (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
 
 {
    Console.WriteLine("Enter 'Start' or 'S' to start the game properly");
    return;
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

if (totalPoint >=14 && totalPoint <=16)
{
    Console.WriteLine("Congratulations! You won Yourself an EXERCISE BOOK!");
}

if (totalPoint ==17)
{
    Console.WriteLine("Congratulations! You won Yourself a 5000mAh POWER BANK!");
}
if (totalPoint >=18 && totalPoint <=20)
{
    Console.WriteLine("Congratulations! You won Yourself a TICKET TO STV GALERY!");
}
if (totalPoint ==21)
{
    Console.WriteLine("Congratulations it's a special!, You won Yourself a Samsung A24!");
}
