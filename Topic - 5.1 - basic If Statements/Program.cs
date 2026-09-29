namespace Topic___5._1___basic_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cats = 30, dogs = 15, people = 20;

            Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            if (people < cats)
            {
                Console.WriteLine("Too many cats! THE WORLD IS DOOMED!!!");
            }
            if (people > cats)
            {
                Console.WriteLine("Not many cats! THE WORLD IS SAVED!!!");
            }
            if(people < dogs)
            {
                Console.WriteLine("THE WORLD IS COVERED IN DROOL!!");
            }
            if(people > dogs)
            {
                Console.WriteLine("THE WORLD IS SO DRY!!");
            }
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();
            dogs += 5;
            Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats " + cats);
            if (people >= dogs)
            {
                Console.WriteLine("People are greater than or equal to dogs.");
            }
            if (people <= dogs)
            {
                Console.WriteLine("People are less than or equal to dogs.");
            }
            if (people == dogs)
            {
                Console.WriteLine("People are dogs.");
            }




        }
    }
}
