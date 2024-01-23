namespace AlkuAineet
{
    using System;
    public class Program
    {

        public static void Main(string[] args)
        {
            int max = 5;
            int grade = 0;
            string answer = "";

            List<string> answers = new List<string>();

            Console.WriteLine("Valitse, haluatko");
            Console.WriteLine("P = Pelata");
            Console.WriteLine("T = Tarkastella tuloksia");
            string input = Console.ReadLine();
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



                Console.Write("Anna kuluva päivä muodossa PPKKVVVV: ");
                string date = Console.ReadLine;

                bool doesDirectoryExist = Directory.Exists(date);
                if (true)
                {
                    break;
                }
                else
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), date));
                }


            }

            public static void review()
            {

            }
        }
    }
}
