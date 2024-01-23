namespace AlkuAineet
{
    using System;
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
                //loopataan kunnes 5 vastausta on täynnä
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Anna alkuaine");
                    answer = Console.ReadLine().Trim().ToLower(); // Convert the input to lowercase

                    //tarkistaa onko samaa vastausta käytetty aiemmin
                    if (elements.Contains(answer))
                    {
                        Console.Write("Voit antaa saman alkuaineen vain kerran.");
                    }
                    else
                    {
                        // Lisää "answer" listalle "elements"
                        elements.Add(answer);
                    }
                
                    // Tarkista, onko alkuaine tiedostossa "alkuaineet.txt"
                    if (File.ReadLines("alkuaineet.txt").Any(line => line.Equals(answer StringComparison.OrdinalIgnoreCase)))
                    {
                        // Lisää yksi piste "grade"
                        grade++;
                    }


                }
            }

            public static void review()
            {

            }
        }
    }
}
