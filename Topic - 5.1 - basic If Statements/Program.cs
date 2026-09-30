namespace Topic___5._1___basic_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dinosaur,magicWord;
            int cats = 30, dogs = 15, people = 20, age;
            double temperature;
            
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
             //Task 1
            Console.WriteLine("Whats the magic word?");
            magicWord = Console.ReadLine();
            if (magicWord == "Please")
            {
                Console.WriteLine("You're welcome in");
            }
            else
            {
                Console.WriteLine("Nope");
                Console.WriteLine("Goodbye");
            }
            

            //Task 2
            Console.WriteLine("Enter your age to see what you can't do");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            if (age < 16)
                Console.WriteLine("You can't drive");
            if (age < 18)
                Console.WriteLine("you can't vote");
            if (age < 25)
                Console.WriteLine("You can't rent a car");
            if (age >= 25)
                Console.WriteLine("You can do anything that's legal");

            //Task 3
            Console.WriteLine("Whats the freezing temperature of water");
            Double.TryParse(Console.ReadLine(), out temperature);
            if (temperature <= 0)
                Console.WriteLine("Ah yes, 0 degrees Celsius or less is correct");
            if (temperature <= 32)
                Console.WriteLine("Ah yes, 32 degrees fahrenheit or less is correct");
            if (temperature >= 273)
                Console.WriteLine("Ah yes, 273.2 degrees kelvin to be precise is correct");
            if (temperature == 273.2)
                Console.WriteLine("wow youre so precise");


        }
    }
}
