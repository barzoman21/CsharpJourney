Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
{
    if((roll1 == roll2) && (roll2 == roll3))
{
    total +=6;
    Console.WriteLine($"You rolled triples! +6 BONUS TO TOTAL. New total ${total}");
}
  else
  {
    total += 2;
    Console.WriteLine($"You rolled doubles! +2 bonus to total. New total {total}.");
  }
}


if (total >= 16)
{
    Console.WriteLine("DAMN SON! You broke the odds.");
}
else if (total >= 10)
{
    Console.WriteLine("Not bad son.");
}
else if (total == 7)
{
    Console.WriteLine("777 Make a wish");
}
else
{
    Console.WriteLine("Have a glass of water");
}



// string message = "The quick brown fox jums over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }
