/////Game RPG by LinkClink ver 0.1 beta test
using System;
using System.Threading;
namespace Gra_RPG_1
{
    class Program
    {
        ///person // maximum life 1000 // maximun attack 2000 //maximun armor 500 // maximum gold 5000
         string[] persona = { "BERSERK", "MAGE", };
         int[] attack = { 700,1100};
         int[] armor =  { 200,110};
         int[] life =   { 650,400};
         int[] luck =   { 25,30};
         int start_gold = 1000;
        ///person//////
        ////
        //////////////hero////
        string h_name;        
        string h_persona;     
        int h_attack;         
        int h_armor;          
        int h_life;           
        int h_luck;          
        int h_gold;           
        //////////////////////
        ////
        //////////////global fun
         int i;
         String option_global;
         int option_p_global;
         static Program fun_pr_global = new Program();
         float local_chance, chance=100;
         Random rand_ch = new Random();
         float ch_rand;
         int chance_ok;
         int ch_res;
        /// ////////////////
        /// 
        string[] monsters_names = { "GOBLIN", "WOLF", "DRAGON","HUMAN" };
        int[] m_attack = { 200,110,1700,180};
        int[] m_armor =  { 50,40,400,70};
        int[] m_life =   { 110,80,800,150};
        ////////////////locations
        string[] forest_l = {"______________________________________________",
                             "                               //|\\         *|",
                             "    |        |                ///|\\\\   |    |",
                             "   (|)     //|\\        |      //|\\   //|\\  |",
                             "  //|\\   ///|\\      //|\\   ///|\\\\ //|\\  |",
                             " ///|\\    //|\\     ///|\\    //|\\   //|\\  |",
                             "____|____|___|___|______|___|____|_______|____|", };
        //////////////////////////////////////
        static void Main(string[] args)
        {   ///Static fun

            String option_global;
            int option_p_gloabal;
            //set color menu
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            ///
            Console.WriteLine("  ______________________ \n" +
                              " |********Menu**********|\n" +
                              " |******1.NEW GAME******|\n" +
                              " |******2.CONTINUE******|\n" +
                              " |******3.DEVELOPER*****|\n" +
                              " |******4.EXIT**********|\n"+
                              "  ---------------------- " );
            option_global = Console.ReadLine();
            option_p_gloabal = Convert.ToInt32(option_global);
            switch(option_p_gloabal)
            {
                case 1:
                    {
                        fun_pr_global.loading();
                        fun_pr_global.character_choice();

                    break;
                    }
                case 2:
                    {
                       
                        break;
                    }
                case 3:
                    {
                        fun_pr_global.loading();
                        fun_pr_global.develop();
                        break;
                    }
                case 4:
                    {
                        fun_pr_global.loading();
                        fun_pr_global.exit(); 

                        break;
                    }
                default: fun_pr_global.exit(); ; break;



            }

            Console.ReadKey();


        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public  void exit()
            {

            System.Environment.Exit(1);
             
            }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void character_choice()
        { 
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Please selected your persone:\n");
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("--"+i+"--");
                Console.WriteLine("Class:" + persona[i]);
                Console.WriteLine("Life:" + life[i] );
                Console.WriteLine("Attack:" + attack[i]);
                Console.WriteLine("Armor:" + armor[i]);
                Console.WriteLine("Luck:" + luck[i] + "\n");
            }

            option_global = Console.ReadLine();
            option_p_global = Convert.ToInt32(option_global);
            Console.WriteLine("Please write your name::");
            h_name = Console.ReadLine();
            
                    h_persona = persona[option_p_global];
                    h_attack = attack[option_p_global];
                    h_armor = armor[option_p_global];
                    h_life = life[option_p_global];
                    h_luck = luck[option_p_global];
                    h_gold = start_gold;
          
               
                fun_pr_global.print_stats(h_name,h_persona,h_attack,h_armor,h_life,h_luck,h_gold);
                fun_pr_global.game(h_name, h_persona, h_attack, h_armor, h_life, h_luck,h_gold);
            
        }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      public void print_stats(string h_name,string h_persona,int h_attack,int h_armor,int h_life,int h_luck,int h_gold)
        {
            Console.Clear();
            Console.WriteLine("Name:" + h_name);
            Console.WriteLine("Class:" + h_persona);
            Console.WriteLine("Life:" + h_life);
            Console.WriteLine("Attack:" + h_attack);
            Console.WriteLine("Armor:" + h_armor);
            Console.WriteLine("Luck:" + h_luck);
            Console.WriteLine("Coins:" + h_gold + "\n");
            fun_pr_global.loading();

        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      
        public void develop()
        {   
            Console.WriteLine("This is beta test version game RPG_1\n" +
                              "LinkClink)");
            Thread.Sleep(2000);
            System.Environment.Exit(1);

        }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void loading()
        {
            Random rand_lo = new Random();
            Console.WriteLine("");
            for(i=0;i<10;i++)
            {
                int ck = rand_lo.Next(100, 400);
                Thread.Sleep(ck);
                Console.Write(".");
            }
            Console.WriteLine("");
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
     public void game(string h_name, string h_persona, int h_attack, int h_armor, int h_life, int h_luck,int h_gold)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            
            Console.Clear();
            Console.WriteLine(" Hi, this is your story here,\n" +
                              " you can fight with different monsters to find friends and in the end to defeat the head boss,\n " +
                              "good luck.\n\n"+
                               " PRESS START:");

            option_global = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(" Hello "+ h_persona+ " '"+ h_name + "' I greet you on your road to begin with, \n" +
                                                          " you will go to the castle of the chalk to give him news from your forest.\n\n"
                                                          +" PRESS START:");

            option_global = Console.ReadLine();

            Console.WriteLine("Going");
            fun_pr_global.loading();

            Console.Clear();

            local_chance = 1.1F; //_%%%%%_//
            chance = (chance - h_luck) * local_chance;

            Console.WriteLine(" On my way I saw a house. I know he had not been here before.\n" +
                              " TO COME IN?\n 1-YES 2-NO  Possible People and Goblins "+ chance+"% (chance)\n");

            option_global = Console.ReadLine();

            if(option_global=="1") //location HOUSE ///////////////////////////////////////////////////////////////////////////////
            {   //
                Console.WriteLine(" '"+h_name+"' Well who is here???");
                Thread.Sleep(2000);
                ch_res = chance_f(chance);
                if (ch_res == 1)
                {
                    local_chance = 1.04F; //_%%%%%_//   goblin-human 30-70
                    chance = (chance - h_luck) * local_chance;

                    ch_res = chance_f(chance);

                    if (ch_res == 1)
                    {

                        Console.WriteLine(" '" + monsters_names[3] + "' Oh, who are you? that you forgot here, old witch..\n" +
                                          " 1-Hi i just dropped by to see   2-Better get out of here.");

                        option_global = Console.ReadLine();

                        if (option_global == "1")
                        {
                            Console.WriteLine(" '" + h_name + "' Hi i just dropped by to see");
                            Console.WriteLine(" '" + monsters_names[3] + "' Haha, I think you could give me 200 gold and go quietly.\n" +
                                              " 1-Give money and leave  2-Send fucking");

                            option_global = Console.ReadLine();

                            if (option_global == "1")
                            {
                                Console.WriteLine(" '" + h_name + "' Okay keep money ");

                                Thread.Sleep(2000);

                                h_gold -= 200;
                                Console.WriteLine(" GOLD-200=" + h_gold);
                            }
                            else Console.WriteLine("Figth");
                        }
                        else
                        {
                            Console.WriteLine(" '" + h_name + "' Send fucking.");
                            Console.WriteLine(" '" + monsters_names[3] + "' I think you think too highly of yourself." +
                                              " Give me 100 gold and get out of here" +
                                              " 1-Okay keep money  2-Let's fight");

                            option_global = Console.ReadLine();

                            if (option_global == "1")
                            {
                                Console.WriteLine("'" + h_name + "' Okay keep money");
                                Console.WriteLine(" Okay keep money ");

                                Thread.Sleep(2000);

                                h_gold -= 100;
                                Console.WriteLine(" GOLD-100=" + h_gold);
                            }
                            else Console.WriteLine("Fight");

                        }


                    }
                    else Console.WriteLine("Goblin");




                }
                else
                {
                    Console.WriteLine(" '" + h_name + "' Okay maybe I alone\n " +
                                      " 1-To search the house?  2-Get out ");

                    option_global = Console.ReadLine();
                    if (option_global == "1")
                    {
                        Console.WriteLine(" '" + h_name + "' Ok ok I found 50 gold");
                        Thread.Sleep(2000);

                        h_gold += 50;
                        Console.WriteLine(" GOLD+50=" + h_gold);
                        Console.WriteLine(" '" + h_name + "' I'm leaving");
                    }
                    else Console.WriteLine(" '" + h_name + "' I'm leaving");
                }

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////          
            }
            else Console.WriteLine(" Well i will go further");


            



        }
       public int  chance_f(float chance)
        {   
            ch_rand = rand_ch.Next(0, 100);
            if (ch_rand <= chance)
            {
                chance_ok = 1;
            }
            else
            {
                chance_ok = 0;
                
            }
            return chance_ok;
        }
        /*
        public int figth_f(int winner)
        {


        }*/
    }
    
}
