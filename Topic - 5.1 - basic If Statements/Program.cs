namespace Topic___5._1___basic_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dinosaur,magicWord;
            int cats = 30, dogs = 15, people = 20;
            /*
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
            
            Console.WriteLine("What famous dinosaur has three horns");
            dinosaur = Console.ReadLine();
            if (dinosaur.ToLower() == "triceratops")
            {
                Console.WriteLine("YOU ARE CORRECT! WAY TOO GO!!");
            }
            */
            //Task 1
            Console.WriteLine("Whats the magic word?");
            magicWord = Console.ReadLine();
            if (magicWord == "Please")
            {
                Console.WriteLine("You're welcome");
            }
            else
            {
                Console.WriteLine("Nope");
                Console.WriteLine("Goodbye");
            }


        }
    }
}
