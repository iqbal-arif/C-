// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nBattle Game!\n");

/*
 * 
 * Code challenge - write code to implement the game rules

    Here are the rules for the battle game that you need to implement in your code project:

   1 You must use either the do-while statement or the while statement as an outer game loop.
   2 The hero and the monster will start with 10 health points.
   3 All attacks will be a value between 1 and 10.
   4 The hero will attack first.
   5 Print the amount of health the monster lost and their remaining health.
   6 If the monster's health is greater than 0, it can attack the hero.
   7 Print the amount of health the hero lost and their remaining health.
   8 Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
   9 Print the winner.

   A. Ensure that you have an empty Program.cs file open in Visual Studio Code.

    If necessary, open Visual Studio Code, and then complete the following steps to prepare a Program.cs file in the Editor:

       a. On the File menu, select Open Folder.

       b. Use the Open Folder dialog to navigate to, and then open, the CsharpProjects folder.

       c. In the Visual Studio Code EXPLORER panel, select Program.cs.

       d. On the Visual Studio Code Selection menu, select Select All, and then press the Delete key.

  B.  Write your game code that implements each rule.

  C.  Run your application and verify that your output meets the requirements.
 * 
 * 
 */

int heroHealth = 10 ;
int monsterHealth = 10 ;
int heroLost = 0;
int monsterLost = 0;


Random battleDice = new Random();
int heroTurn = 0;
int monsterTurn = 0;

do
{
        heroTurn = battleDice.Next(0,11);
        Console.WriteLine($"Hero Turn : {heroTurn} ::MH::{monsterHealth}:ML:{monsterLost}");
        if( monsterHealth == heroTurn)
            {
                monsterHealth--;
                monsterLost++;
                //break;
            }
    
            Console.WriteLine($"Monster was damaged and lost {monsterLost} health and now has {monsterHealth} health.\n");

        monsterTurn = battleDice.Next(0,11);
        Console.WriteLine($"Monster Turn : {monsterTurn} ::HH::{heroHealth}:HL:{heroLost}");
       
        if( monsterHealth == monsterTurn)
            {
                heroHealth--;
                heroLost++;
               // break;
            }

         Console.WriteLine($"Hero was damaged and lost {heroLost} health and now has {heroHealth} health.\n");

        if (heroHealth == 0)
      //  Console.WriteLine("Monsters WINS!!!");
        break;
        
        if(monsterHealth == 0)
      //  Console.WriteLine("Hero WINS!!!");
        break;



} while (true );

        if ( monsterHealth == 0)
            {
                Console.WriteLine($"{monsterHealth}  Hero WINS!!!");

            }
        else if ( heroHealth == 0 ) 
            {
                Console.WriteLine($"{heroHealth}  Monster WINS!!!");
            }
        Console.ReadLine();

/*
 * Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!
 * 
 * 
 * 
 */