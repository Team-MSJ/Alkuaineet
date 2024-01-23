namespace AlkuAineet
{
    using System;
    using System.IO 
    using newtonsoft.json 
    public class Program
    {

        public static void Main(string[] args)
        {
            int max = 5;
            int grade = 0;
            string answer;

            List<string> answers = new List<string>();

            Console.WriteLine("Valitse, haluatko");
            Console.WriteLine("P = Pelata");
            Console.WriteLine("T = Tarkastella tuloksia");
            input = Console.ReadLine();
            if (input = "P")
            {
                play();
            }
            else if (input = "T")
            {
                review();
            }
            else
            {
                Console.WriteLine("Valitse uudelleen");
            }
            {

            }
            public static void play()
            {

            }

            public static void review()
            {

            }
        }
    }
}
