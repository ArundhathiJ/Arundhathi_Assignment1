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





            
            }



        }
    }
    
