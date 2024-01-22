// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nBattle Game!\n");

int heroHealth = 10 ;
int monsterHealth = 10 ;
int heroLost = 0;
int monsterLost = 0;

Console.WriteLine($"\nHero was damaged and lost {heroLost} health and now has {heroHealth} health.");

Random battleDice = new Random();
int heroTurn = 0;
// int monsterTurn = 0;
// Console.WriteLine(battleTurn);

    do
    {

        heroTurn = battleDice.Next(0,11);

        if (monsterHealth == heroTurn)
        {

            monsterHealth --;
            monsterLost = monsterHealth;
            Console.WriteLine($"Hero Turn : {heroTurn} ::: Monster Health {monsterHealth}");
            Console.WriteLine($"Monster was damaged and lost {monsterLost} health and now has {monsterHealth} health.\n");
        }
        if (monsterLost == 9)
        break;
    }
    while (monsterHealth >= 0 || heroHealth >= 0 );

    // monsterLost = monsterLost 
