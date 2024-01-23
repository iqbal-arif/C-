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
// Console.WriteLine(battleTurn);

    do
    {

        heroTurn = battleDice.Next(0,11);

            Console.WriteLine($"Hero Turn : {heroTurn}");
            Console.WriteLine($"Current MonsterHealth : {monsterHealth}");
        
        if (monsterHealth == heroTurn)
        {

            monsterHealth --;
            monsterLost ++;
            Console.WriteLine($"Hero Turn : {heroTurn} ::: Monster Health {monsterHealth}");
            Console.WriteLine($"Monster was damaged and lost {monsterLost} health and now has {monsterHealth} health.\n");
            if (monsterHealth <= 0)
            break;
            Console.WriteLine("Monster Wins");

        }
        if (monsterHealth >= 0)
        {
            monsterTurn = battleDice.Next(0,11);
            Console.WriteLine($"Monster Turn : {monsterTurn}");
            Console.WriteLine($"Current HeroHealth : {heroHealth}");

            heroHealth --;
            heroLost ++;
            Console.WriteLine($"Monster Turn : {monsterTurn} ::: Hero Health {heroHealth}");
            Console.WriteLine($"Hero was damaged and lost {heroLost} health and now has {heroHealth} health.\n");
            if (heroHealth <= 0)
            break;
            Console.WriteLine("Hero Wins");

        }

        
    }
    while (monsterHealth >= 0 || heroHealth >= 0 );

    // monsterLost = monsterLost 
