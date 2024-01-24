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
            string answer = "";

            List<string> answers = new List<string>();

            public static void Valikko()
            {
                Console.WriteLine("Valitse, haluatko");
                Console.WriteLine();
                Console.WriteLine("  P = Pelata");
                Console.WriteLine("  T = Tarkastella tuloksia");
                Console.WriteLine("  L = Lopettaa");
                string input = Console.ReadLine();
                if (input = "P")
                {
                    Play();
                }
                else if (input = "T")
                {
                    Review();
                }
                else if (input = L)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Valitse uudelleen");
                }
            }


            {

            }
            public static void Play()
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
                    
                    Console.WriteLine("Sait " + grade + " oikein");
                    Console.WriteLine("Sait " + (max - grade) + " väärin");
                    Valikko();

                }

            }

            public static void Review()
            {




                Valikko();
            }
        }
    }
}
