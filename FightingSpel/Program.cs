


int player1Hp = 100;
int player2Hp = 100;

string player1name = "Kagura bachi";
string player2name = "Neo Kagura Bachi";

Random generator = new Random();

while (player1Hp > 0 && player2Hp > 0)
{
    Console.WriteLine("\n New Round");
    Console.WriteLine($"{player1name}: {player1Hp}  {player2name}: {player2Hp}\n");

    int damage1 = generator.Next(20);
    player2Hp -= damage1;
    player2Hp = Math.Max(0, player2Hp);
    Console.WriteLine($"{player1name} just kagura bachi'd all over the place!\n {player1name} did {damage1} damage on {player2name}!!");

    int damage2 = generator.Next(20);
    player1Hp -= damage2;
    player1Hp = Math.Max(0, player1Hp);
    Console.WriteLine($"{player2name} used their bachi beam!!!\n {player2name} did {damage2} damage on {player1name}!!");
}

Console.WriteLine("\n Round end");

if (player1Hp == 0 && player2Hp == 0)
{
    Console.WriteLine("Draw!");
}
else if (player1Hp == 0)
{
    Console.WriteLine($"{player2name} won!");
}
else
{
    Console.WriteLine($"{player2name} won!");
}
Console.WriteLine($"\n {player1name}: {player1Hp}  {player2name}: {player2Hp}");
Console.WriteLine("Press any key to exit");
Console.ReadKey();