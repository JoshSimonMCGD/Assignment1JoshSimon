// Josh Simon Assignment 1
// Good luck in the graveyard.

// Introduction to the player. The player is in a graveyard and is given options of how to proceed.
// There is an obvious boss who is almost always an option to fight. 
// The player needs a power lvl of over 9000 to beat the boss.

Console.WriteLine("You awaken in a graveyard under a large dead tree.");
Console.WriteLine();

// Name Input
Console.WriteLine("What is your name?");
String playername = Console.ReadLine();

// Power level Input
Console.WriteLine("What is your power level?");
int power = int.Parse(Console.ReadLine());

// Player Orientation including a string variable for playername.
Console.WriteLine();
Console.WriteLine("You come to your senses.");
Console.WriteLine("You are armed with a full set of armor and a greatsword.");
Console.WriteLine("You are in a large graveyard surrounded by a high stone wall. There is no way out.");
Console.WriteLine("There is a large clearing through an archway to your left.");
Console.WriteLine("There is a massive stone statue of a warrior wielding a scythe in the center.");
Console.WriteLine("You hear a faint whisper from the statue..... " + playername);

// First choice: farm or fight boss.
// Takes player input for 'left' 'right' or anything else and gives different options.
Console.WriteLine();
Console.WriteLine("There are a couple skeletons wandering around some graves to your right.");
Console.WriteLine();
Console.WriteLine("Do you go [left] or [right]?");
string leftright1 = Console.ReadLine();

// Boss fight if left.
if (leftright1 == "left")
{
    // Power check for boss fight. 
    Console.WriteLine();
    Console.WriteLine("You head into the clearing toward the whispering statue...");
    Console.WriteLine();
    if (power >= 9001)
    {
        //Success!! Game over.
        Console.WriteLine("As expected the satue comes alive and attacks you ");
        Console.WriteLine("For some reason you are immensely powerful and you easily block it.");
        Console.WriteLine("Your counter attack shatters the statue. You escape the graveyard.");
    }
    else if (power <= 9000)
    {
        //Failure. Player Death.
        Console.WriteLine("As you enter the clearing the statue comes alive.");
        Console.WriteLine("You are no match for it. The statue's swing goes through your armor.");
        Console.WriteLine("You are Dead...");
    }
}
// Farm if right.
else if (leftright1 == "right")
{
    // Game continues. Provides next choice. Takes player input for 'search', 'attack' or anything else,
    // and gives different options. Input variants for leftright concept go in numerical ascending order.
    Console.WriteLine();
    Console.WriteLine("You approach the skeletons and start hacking them to bits.");
    Console.WriteLine("After each one dies you feel yourself getting stronger.");
    Console.WriteLine("Your power level increases by 1000.");
    
    //Adds 1000 power.
    power += 1000;
    Console.WriteLine();
    Console.WriteLine("After searching through the bones, you find a rusty key.");
    Console.WriteLine();
    Console.WriteLine("Do you [search] for something the key can open or [attack] more wandering skeletons?");
    
    string leftright2 = Console.ReadLine();
    
    //Second choice variant outcomes: 'search' graveyard or 'attack' more mobs.
    if (leftright2 == "search")
    {
        // Next input choice down the tree. With 'enter' or 'open' or anything else. 
        Console.WriteLine();
        Console.WriteLine("You search every corner of the graveyard other than the eerie clearing");
        Console.WriteLine("You find a locked chest in the corner of the graveyard.");
        Console.WriteLine("Suddenly the statue in the clearing calls out to you longingly...." + playername + "....");
        Console.WriteLine();
        Console.WriteLine("Do you [enter] the clearing or [open] the chest?");
        
        string leftright3 = Console.ReadLine();
        
        // Boss fight.
        if (leftright3 == "enter")
        {
            // Power checker.
            Console.WriteLine();
            Console.WriteLine("You head into the clearing toward the whispering statue...");
            Console.WriteLine();
            if (power >= 9001)
            {
                //Player win.
                Console.WriteLine("As expected the satue comes alive and attacks you ");
                Console.WriteLine("For some reason you are immensely powerful and you easily block it.");
                Console.WriteLine("Your counter attack shatters the statue. You escape the graveyard.");
            }
            else if (power <= 9000)
            {
                //Player dies.
                Console.WriteLine("As you enter the clearing the statue comes alive.");
                Console.WriteLine("You are no match for it. The statue's swing goes through your armor.");
                Console.WriteLine("You are Dead...");
            }
        }
        
        // 'open' chest outcome variant.
        else if (leftright3 == "open")
        {
            //Adds 10000 power.
            //Takes in next input as 'enter' for boss fight or 'admire' or anything else.
            Console.WriteLine("You use the rusty key. It opens the chest.");
            Console.WriteLine("You swing the chest open to reveal an elegant glowing blue sword.");
            Console.WriteLine("As you pick up the sword you feel yourself getting much stronger.");
            Console.WriteLine("Your power level increases by 10000.");
            power += 10000;
            Console.WriteLine();
            Console.WriteLine("With nothing left to do, do you [enter] the clearing or [admire] your sword.");
            
            String leftright5 = Console.ReadLine();
            
            // 'enter' outcome variant. Boss fight.
            if (leftright5 == "enter")
            {
                //Power checker.
                Console.WriteLine();
                Console.WriteLine("You enter the clearing toward the whispering statue...");
                Console.WriteLine();
                if (power >= 9001)
                {
                    // Player wins.
                    Console.WriteLine("As expected the satue comes alive and attacks you ");
                    Console.WriteLine("Wielding your new sword, you are immensely powerful and easily block it.");
                    Console.WriteLine("Your counter attack slices the statue in half. You escape the graveyard.");
                }
                else if (power <= 9000)
                {
                    // Player dies.
                    Console.WriteLine("As you enter the clearing the statue comes alive.");
                    Console.WriteLine("You are no match for it. The statue's swing goes through your armor.");
                    Console.WriteLine("You are Dead...");
                }
            }
            // 'Admire' outcome variant. Ends game.
            else if (leftright5 == "admire")
            {
                Console.WriteLine("You admire your sword in awe.");
                Console.WriteLine("Suddenly you feel an unbearable sharp pain from your back.");
                Console.WriteLine("You hear a whisper from behind you.... 'I'll be taking that....'");
                Console.WriteLine("You Died.");
            }
            //Any other input other than the two provided options. Ends game.
            else
            {
                Console.WriteLine("You stand idle for too long. Skeletons swarm you and you die...");
            }
        }
        //Any other input other than the two provided options. Ends game.
        else
        {
            Console.WriteLine("You stand idle for too long. Skeletons swarm you and you die...");
        }
    }
    // 'attack' variant provided. Continues game and gives next choices.
    else if (leftright2 == "attack")
    {
        // Adds 3000 power. Takes next variant as 'fight' or 'back' or anything else.
        Console.WriteLine();
        Console.WriteLine("You keep bashing up every skeleton you see. They swing at you but miss every time.");
        Console.WriteLine("You feel yourself getting even stronger. Your power level increases by 3000.");
        power += 3000;
        Console.WriteLine("The skeletons won't stop coming. They push you back to the edge of the clearing.");
        Console.WriteLine("......" + playername + ".......");
        Console.WriteLine("Do you try to [fight] off the skeletons or [back] into the clearing");
        
        string leftright4 = Console.ReadLine();

        // 'fight' variant outcome. 
        if (leftright4 == "fight")
        {
            // Adds 6000 power and forces player into boss fight.
            Console.WriteLine("You fight off the skeletons wave after wave.");
            Console.WriteLine("You enter a battle flow state.");
            Console.WriteLine("Your power level increases by 6000");
            
            power += 6000;
            
            Console.WriteLine();
            Console.WriteLine("Now feeling confident, you enter the clearing and walk towards the whispering statue...");
            Console.WriteLine();
            
            // Boss fight power checker.
            if (power >= 9001)
            {
                // Player wins.
                Console.WriteLine("As expected the satue comes alive and attacks you ");
                Console.WriteLine("Slaying all those skeletons has made you immensely powerful and you easily block it.");
                Console.WriteLine("Your counter attack shatters the statue. You escape the graveyard.");
            }
            else if (power <= 9000)
            {
                // Player dies.
                Console.WriteLine("As you enter into the clearing the statue comes alive.");
                Console.WriteLine("You are STILL no match for it somehow.. The statue's swing goes through your armor.");
                Console.WriteLine("You are Dead...");
            }
            
        }
        // 'back' variant outcome. Boss fight.
        else if (leftright4 == "back")
        {
            // Power checker.
            Console.WriteLine();
            Console.WriteLine("You back into the clearing towards the whispering statue...");
            Console.WriteLine();
            if (power >= 9001)
            {
                // Player wins.
                Console.WriteLine("As expected the satue comes alive and attacks you ");
                Console.WriteLine("Somehow, you are immensely powerful and easily block it.");
                Console.WriteLine("Your counter attack slices the statue in half. You escape the graveyard.");
            }
            else if (power <= 9000)
            {
                // Player dies.
                Console.WriteLine("As you back into the clearing the statue comes alive.");
                Console.WriteLine("You are no match for it. The statue's swing goes through your armor.");
                Console.WriteLine("You are Dead...");
            }
        }
        //Any other input other than the two provided options. Ends game.
        else
        {
            Console.WriteLine("You stand idle for too long. Skeletons swarm you and you die...");
        }
    }
    //Any other input other than the two provided options. Ends game.
    else
    {
        Console.WriteLine("You stand idle for too long. Skeletons swarm you and you die...");
    }
}
//Any other input other than the two provided options. Ends game.
else
{
    Console.WriteLine();
    Console.WriteLine("You enter back into your slumber.");
}