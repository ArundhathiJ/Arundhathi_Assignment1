// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Xml.Linq;

class My_Virtual_Pet
{


    static void Main()
    {

        Console.WriteLine("Choose your pets from the list!");
        Console.WriteLine("(1)DOG");
        Console.WriteLine("(2)CAT");
        Console.WriteLine("(3)BIRDS");

        string mypet_TYPE = Console.ReadLine();
        Console.WriteLine("Could you please enter your pets name?");
        String mypet_Name = Console.ReadLine();
        Console.WriteLine("HI {0} WELCOME TO THE PET VIRTUAL HEALTH", mypet_Name);
        int hunger = 5;
        int happiness = 5;
        int health = 5;
        while (true)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Feed " + mypet_Name);
            Console.WriteLine("2. Play " + mypet_Name);
            Console.WriteLine("3. Rest " + mypet_Name);
            Console.WriteLine("4. exit ");
            
            Console.WriteLine("enter your choice");
            Console.WriteLine("Pet Status:");
            Console.WriteLine("Hunger   : {0}/10", hunger);
            Console.WriteLine("Happiness: {0}/10", happiness);
            Console.WriteLine("Health   : {0}/10", health);


            if (hunger <= 2)
                Console.WriteLine("Warning:your is too hungry!");
            if (happiness <= 2)
                Console.WriteLine("Warning: Your pet  is unhappy!");

            if (health <= 2)
                Console.WriteLine("Warning: Your pet is  unhealthy!");


            int options = Convert.ToInt32(Console.ReadLine());

            switch(options)
            {
                case 1:
                    Console.WriteLine("-------Feeding-------");
                    hunger--;
                    health++;
                    if (hunger < 0)
                        hunger = 0;
                    Console.WriteLine("Hunger Decreased, Health is slightly Increased.");
                    break;
                    case 2:
                    Console.WriteLine("-------Playing-------");
                    happiness++;
                    hunger++;
                    if (happiness > 10)
                        happiness = 10;
                    if (hunger > 10)
                        hunger = 10;
                    Console.WriteLine("Happiness increased, hunger slightly increased.");
                    break;

                    break;
                    case 3:
                    Console.WriteLine("-------Resting-------");
                    health++;
                        happiness--;
                    if (health>10)
                        health = 10;
                    Console.WriteLine("Health increased, happiness slightly decreased.");
                    break;
            }



            
            }



        }
    }
    
