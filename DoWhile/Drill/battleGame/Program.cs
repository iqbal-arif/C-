// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nBattle Game!\n");

int heroHealth = 10 ;
int monsterHealth = 10 ;
int heroLost = 0;
int monsterLost = 0;

Console.WriteLine($"\nHero was damaged and lost {heroLost} health and now has {heroHealth} health.");

Random battleDice = new Random();
int heroTurn = 0;
int monsterTurn = 0;
Console.WriteLine(battleTurn);

do
    {

        heroTurn = battleDice.Next(0,11);

        Console.WriteLine($"Hero Turn : {heroTurn} ::: Monster Health {monsterHealth}");
    }
    while (heroTurn <= 1 || heroTurn >= 11);
          monsterHealth -= ;

    // monsterLost = monsterLost 

Console.WriteLine($"Monster was damaged and lost {monsterLost} health and now has {monsterHealth} health.\n");