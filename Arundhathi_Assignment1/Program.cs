// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class My_Virtual_Pet
{
    static void Main()
    {

        Console.WriteLine("Choose your pets from the list!");
        Console.WriteLine("(1)DOG");
        Console.WriteLine("(2)CAT");
        Console.WriteLine("(3)BIRDS");

        string mypet_TYPE = Console.ReadLine();
        Console.WriteLine("Could you please enter your pets name?", mypet_TYPE);
        String mypet_Nmae = Console.ReadLine();
        Console.WriteLine("HI {0} WELCOME TO THE PET VIRTUAL HEALTH", mypet_Nmae);
    }
}