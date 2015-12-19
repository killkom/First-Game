using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolGameOne
{
    class Player
    {
        public int playerhealth = 20;
        public int playerattack = 5;
        public int playerweapon = 2;
        public int score = 0;
    }
    class Enemy
    {
        public int monsterhealth;
        public int monsterattack;
        public int monsterweapon;
        public int monsterstun;
        public int monstervalue;
        public int bounty;
        public string monstername;
        public Enemy(string _monstername, int _monsterhealth, int _monsterattack, int _monsterstun, int _monstervalue, int _mosnterweapon, int _bounty)
        {
            monstername = _monstername;
            monsterhealth = _monsterhealth;
            monsterattack = _monsterattack;
            monsterstun = _monsterstun;
            monstervalue = _monstervalue;
            monsterweapon = _mosnterweapon;
            bounty = _bounty;
        }

    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool Run = true;
            int random;
            string choice = "";
            while (Run == true)
            {
                Console.WriteLine("Do you wish to start a new game?(type 'new game')");
                Console.WriteLine("Do you wish to learn the rules?(type 'rules)");
                Console.WriteLine("Do you wish to exit the game?(type 'exit)");
                choice = Console.ReadLine();
                if (choice == "rules")
                {
                    Console.WriteLine("Select oponent by typing corrisponding number shown");
                    Console.WriteLine("On each turn you will be able to choose to ('1')dodge, ('2')block, ('3')attack, and ('4')strong attack");
                    Console.WriteLine("After each kill you will be rewarded with a bounty for the kill(score). Your score only counts if you kill enough enemies to survive the battle.");

                }
                else if (choice == "new game")
                {
                    while (Run == true)
                    {
                        Console.WriteLine("The battle is about to begin; the two armies are lined up and ready to be unleashed. If you are to survive on the feild of battle you must choose your oponents wisely.");
                        Console.WriteLine("You look at the other army, among them from weakest to strongest are Goblins, Orcs, and Ogres.");
                        Console.WriteLine("The trumpets sound and the charge begins.(type 'charge')");
                        choice = Console.ReadLine();
                        if (choice == "charge")
                        {
                            Player warrior = new Player();
                            int armysize = 15;

                            while (warrior.playerhealth > 0 && armysize > 0)
                            {
                                Console.WriteLine("Fight a ('1')Goblin ('2')Orc ('3')Ogre");
                                choice = Console.ReadLine();
                                if (choice == "1")
                                {
                                    Enemy monster = new Enemy("Goblin", 10, 2, 0, 1, 2, 10);
                                    while (monster.monsterhealth > 0 && warrior.playerhealth > 0)
                                    {
                                        if (monster.monsterstun == 1)
                                        {
                                            monster.monsterstun = 0;
                                            Console.WriteLine("The " + monster.monstername + " is stunned; what is your action?");
                                            choice = Console.ReadLine();
                                            if (choice == "1" || choice == "2")
                                            {
                                                Console.WriteLine("You wasted your chance");
                                            }
                                            else if (choice == "3")
                                            {
                                                monster.monsterhealth = monster.monsterhealth - warrior.playerattack;
                                                Console.WriteLine("You attack the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth);

                                            }
                                            else if (choice == "4")
                                            {
                                                monster.monsterhealth = monster.monsterhealth - (warrior.playerattack * warrior.playerweapon);
                                                Console.WriteLine("You attack the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth);

                                            }
                                        }
                                        else if (monster.monsterstun == 2)
                                        {
                                            monster.monsterstun = 0;
                                            Console.WriteLine("The " + monster.monstername + " is open for attack; what is your action?");
                                            choice = Console.ReadLine();
                                            if (choice == "1" || choice == "2")
                                            {
                                                Console.WriteLine("You wasted your chance");
                                            }
                                            else if (choice == "3")
                                            {
                                                monster.monsterhealth = monster.monsterhealth - warrior.playerattack;
                                                Console.WriteLine("You attack the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth);

                                            }
                                            else if (choice == "4")
                                            {
                                                Console.WriteLine("You were too slow for the " + monster.monstername + " and wasted you chance");
                                            }
                                        }
                                        else
                                        {

                                            random = rand.Next(0, 2);
                                            if (random == 0)
                                            {
                                                Console.WriteLine("The " + monster.monstername + " uses fast attack; what is your action?");
                                                choice = Console.ReadLine();
                                                if (choice == "1")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - monster.monsterattack;
                                                    Console.WriteLine("You are too slow for the " + monster.monstername + " and your health goes down to " + warrior.playerhealth);
                                                }
                                                else if (choice == "2")
                                                {
                                                    monster.monsterstun = 1;
                                                    Console.WriteLine("You block the attack and the " + monster.monstername + " becomes stunned.");

                                                }
                                                else if (choice == "3")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - monster.monsterattack;
                                                    monster.monsterhealth = monster.monsterhealth - warrior.playerattack;
                                                    Console.WriteLine("You take the hit and attack and the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth + ", your health goes down to " + warrior.playerhealth);

                                                }
                                                else if (choice == "4")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - monster.monsterattack;
                                                    monster.monsterhealth = monster.monsterhealth - (warrior.playerattack * warrior.playerweapon);
                                                    Console.WriteLine("You take the hit and attack and the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth + ", your health goes down to " + warrior.playerhealth);

                                                }
                                            }
                                            else if (random == 1)
                                            {
                                                Console.WriteLine("The " + monster.monstername + " uses strong attack; what is your action?");
                                                choice = Console.ReadLine();
                                                if (choice == "1")
                                                {
                                                    monster.monsterstun = 2;
                                                    Console.WriteLine("You dodge the " + monster.monstername + " strong attack and have a opening for attack");
                                                }
                                                else if (choice == "2")
                                                {
                                                    monster.monsterstun = 1;
                                                    Console.WriteLine("You block the attack and the " + monster.monstername + " becomes stunned.");

                                                }
                                                else if (choice == "3")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - (monster.monsterattack * monster.monsterweapon);
                                                    monster.monsterhealth = monster.monsterhealth - warrior.playerattack;
                                                    Console.WriteLine("You take the hit and the attack and the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth + ", your health goes down to " + warrior.playerhealth);

                                                }
                                                else if (choice == "4")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - monster.monsterattack;
                                                    monster.monsterhealth = monster.monsterhealth - (warrior.playerattack * warrior.playerweapon);
                                                    Console.WriteLine("You take the hit and the attack and the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth + ", your health goes down to " + warrior.playerhealth);

                                                }


                                            }
                                        }

                                    }
                                    if (monster.monsterhealth <= 0)
                                    {
                                        warrior.score = warrior.score + monster.bounty;
                                        armysize = armysize - monster.monstervalue;
                                        Console.WriteLine(armysize);
                                        Console.WriteLine("The " + monster.monstername + " was killed, rewarding a bountry of " + monster.bounty);
                                    }
                                }
                                else if (choice == "2")
                                {
                                    Enemy monster = new Enemy("Orc", 15, 4, 0, 2, 3, 25);
                                    while (monster.monsterhealth > 0 && warrior.playerhealth > 0)
                                    {
                                        if (monster.monsterstun == 1)
                                        {
                                            monster.monsterstun = 0;
                                            Console.WriteLine("The " + monster.monstername + " is stunned; what is your action?");
                                            choice = Console.ReadLine();
                                            if (choice == "1" || choice == "2")
                                            {
                                                Console.WriteLine("You wasted your chance");
                                            }
                                            else if (choice == "3")
                                            {
                                                monster.monsterhealth = monster.monsterhealth - warrior.playerattack;
                                                Console.WriteLine("You attack the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth);

                                            }
                                            else if (choice == "4")
                                            {
                                                monster.monsterhealth = monster.monsterhealth - (warrior.playerattack * warrior.playerweapon);
                                                Console.WriteLine("You attack the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth);

                                            }
                                        }
                                        else if (monster.monsterstun == 2)
                                        {
                                            monster.monsterstun = 0;
                                            Console.WriteLine("The " + monster.monstername + " is open for attack; what is your action?");
                                            choice = Console.ReadLine();
                                            if (choice == "1" || choice == "2")
                                            {
                                                Console.WriteLine("You wasted your chance");
                                            }
                                            else if (choice == "3")
                                            {
                                                monster.monsterhealth = monster.monsterhealth - warrior.playerattack;
                                                Console.WriteLine("You attack the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth);

                                            }
                                            else if (choice == "4")
                                            {
                                                monster.monsterhealth = monster.monsterhealth - (warrior.playerattack * warrior.playerweapon);
                                                monster.monsterstun = 1;
                                                Console.WriteLine("You attack the " + monster.monstername + " stunning it and lowering its health to " + monster.monsterhealth);
                                            }
                                        }
                                        else
                                        {

                                            random = rand.Next(0, 2);
                                            if (random == 0)
                                            {
                                                Console.WriteLine("The " + monster.monstername + " uses fast attack; what is your action?");
                                                choice = Console.ReadLine();
                                                if (choice == "1")
                                                {
                                                    monster.monsterstun = 2;
                                                    Console.WriteLine("You dodge the " + monster.monstername + " and have a opening for attack");
                                                }
                                                else if (choice == "2")
                                                {
                                                    monster.monsterstun = 1;
                                                    Console.WriteLine("You block the " + monster.monstername);

                                                }
                                                else if (choice == "3")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - monster.monsterattack;
                                                    monster.monsterhealth = monster.monsterhealth - warrior.playerattack;
                                                    Console.WriteLine("You take the hit and the attack and the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth + ", your health goes down to " + warrior.playerhealth);

                                                }
                                                else if (choice == "4")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - monster.monsterattack;
                                                    monster.monsterhealth = monster.monsterhealth - (warrior.playerattack * warrior.playerweapon);
                                                    Console.WriteLine("You take the hit and the attack and the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth + ", your health goes down to " + warrior.playerhealth);

                                                }
                                            }
                                            else if (random == 1)
                                            {
                                                Console.WriteLine("The " + monster.monstername + " uses strong attack; what is your action?");
                                                choice = Console.ReadLine();
                                                if (choice == "1")
                                                {
                                                    monster.monsterstun = 2;
                                                    Console.WriteLine("You dodge the " + monster.monstername + " strong attack and have a opening for attack");
                                                }
                                                else if (choice == "2")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - (monster.monsterattack / 2);
                                                    Console.WriteLine("You block the attack but take reduced damage, your health goes down to " + warrior.playerhealth);

                                                }
                                                else if (choice == "3")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - (monster.monsterattack * monster.monsterweapon);
                                                    monster.monsterhealth = monster.monsterhealth - warrior.playerattack;
                                                    Console.WriteLine("You take the hit and attack the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth + ", your health goes down to " + warrior.playerhealth);

                                                }
                                                else if (choice == "4")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - monster.monsterattack;
                                                    monster.monsterhealth = monster.monsterhealth - (warrior.playerattack * warrior.playerweapon);
                                                    Console.WriteLine("You take the hit and attack the " + monster.monstername + "  damaging it lowering its health to " + monster.monsterhealth + ", your health goes down to " + warrior.playerhealth);

                                                }


                                            }
                                        }

                                    }
                                    if (monster.monsterhealth <= 0)
                                    {
                                        warrior.score = warrior.score + monster.bounty;
                                        armysize = armysize - monster.monstervalue;
                                        Console.WriteLine(armysize);
                                        Console.WriteLine("The " + monster.monstername + " was killed, rewarding a bountry of " + monster.bounty);
                                    }  
                                }
                                else if (choice == "3")
                                {
                                    Enemy monster = new Enemy("Ogre", 25, 8, 0, 5, 2, 50);
                                    while (monster.monsterhealth > 0 && warrior.playerhealth > 0)
                                    {
                                        if (monster.monsterstun == 2)
                                        {
                                            monster.monsterstun = 0;
                                            Console.WriteLine("The " + monster.monstername + " is open for attack; what is your action?");
                                            choice = Console.ReadLine();
                                            if (choice == "1" || choice == "2")
                                            {
                                                Console.WriteLine("You wasted your chance");
                                            }
                                            else if (choice == "3")
                                            {
                                                monster.monsterhealth = monster.monsterhealth - warrior.playerattack;
                                                Console.WriteLine("You attack the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth);

                                            }
                                            else if (choice == "4")
                                            {
                                                monster.monsterhealth = monster.monsterhealth - (warrior.playerweapon * warrior.playerattack);
                                                Console.WriteLine("You attack the " + monster.monstername + " damaging it and lowering its health to " + monster.monsterhealth);
                                            }
                                        }
                                        else
                                        {

                                            random = rand.Next(0, 2);
                                            if (random == 0)
                                            {
                                                Console.WriteLine("The " + monster.monstername + " uses fast attack; what is your action?");
                                                choice = Console.ReadLine();
                                                if (choice == "1")
                                                {
                                                    monster.monsterstun = 2;
                                                    Console.WriteLine("You dodge the " + monster.monstername + " and have a opening for attack");
                                                }
                                                else if (choice == "2")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - (monster.monsterattack / 2);
                                                    Console.WriteLine("You block the attack but take reduced damage, your health goes down to " + warrior.playerhealth);

                                                }
                                                else if (choice == "3")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - monster.monsterattack;
                                                    monster.monsterhealth = monster.monsterhealth - warrior.playerattack;
                                                    Console.WriteLine("You take the hit and the attack and the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth + ", your health goes down to " + warrior.playerhealth);

                                                }
                                                else if (choice == "4")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - monster.monsterattack;
                                                    monster.monsterhealth = monster.monsterhealth - (warrior.playerattack * warrior.playerweapon);
                                                    Console.WriteLine("You take the hit and the attack and the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth + ", your health goes down to " + warrior.playerhealth);

                                                }
                                            }
                                            else if (random == 1)
                                            {
                                                Console.WriteLine("The " + monster.monstername + " uses strong attack; what is your action?");
                                                choice = Console.ReadLine();
                                                if (choice == "1")
                                                {
                                                    monster.monsterstun = 2;
                                                    Console.WriteLine("You dodge the " + monster.monstername + " strong attack and have a opening for attack");
                                                }
                                                else if (choice == "2")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - (monster.monsterattack * monster.monsterweapon);
                                                    Console.WriteLine("You fail toblock the attack , your health goes down to " + warrior.playerhealth);

                                                }
                                                else if (choice == "3")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - (monster.monsterattack * monster.monsterweapon);
                                                    monster.monsterhealth = monster.monsterhealth - warrior.playerattack;
                                                    Console.WriteLine("You take the hit and attack the " + monster.monstername + " damaging it lowering its health to " + monster.monsterhealth + ", your health goes down to " + warrior.playerhealth);

                                                }
                                                else if (choice == "4")
                                                {
                                                    warrior.playerhealth = warrior.playerhealth - monster.monsterattack;
                                                    monster.monsterhealth = monster.monsterhealth - (warrior.playerattack * warrior.playerweapon);
                                                    Console.WriteLine("You take the hit and attack the " + monster.monstername + "  damaging it lowering its health to " + monster.monsterhealth + ", your health goes down to " + warrior.playerhealth);

                                                }


                                            }
                                        }

                                    }
                                    if (monster.monsterhealth <= 0)
                                    {
                                        warrior.score = warrior.score + monster.bounty;
                                        armysize = armysize - monster.monstervalue;
                                        Console.WriteLine(armysize);
                                        Console.WriteLine("The " + monster.monstername + " was killed, rewarding a bountry of " + monster.bounty);
                                    }
                                }
                            
                           
                            
                            if(warrior.playerhealth<=0)
                            {
                                Console.WriteLine("you died...do you wish to exit('exit'), type anything else to continue");
                                choice =Console.ReadLine();
                                if (choice == "exit")
                                {
                                    Run = false;
                                }
                            }
                            else if(armysize<=0)
                            {
                                Console.WriteLine("you have won the battle with a bounty of " + warrior.score + " do you wish to exit('exit'), type anything else to continue");
                                if (choice == "exit")
                                {
                                    Run = false;
                                }
                            }
                            }
                        }
                        else
                        {
                            Console.WriteLine("you should 'charge' into battle");
                        }
                    }
                }
                else if (choice == "exit")
                {
                    Run = false;
                }
            }
        }
    }
}