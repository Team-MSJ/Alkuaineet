namespace AlkuAineet
{
    using System;
    using System.IO;
    using Newtonsoft.json;

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

            public static void Play()
            {
                //loopataan kunnes 5 vastausta on täynnä
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Anna alkuaine");
                    answer = Console.ReadLine().Trim().ToLower(); //Muuntaa vastauksen pienaakkosiksi

                    //tarkistaa onko samaa vastausta käytetty aiemmin
                    if (elements.Contains(answer))
                    {
                        Console.Write("Voit antaa saman alkuaineen vain kerran.");
                        i--; //jos samaa vastausta on käytetty aiemmin, vastauskerroista miinustetaan yksi
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

                // Tarkista onko Tulokset.json tiedostoa hakemistossa date
                string resultsFilePath = Path.Combine(Directory.GetCurrentDirectory(), date,"Tulkoset.json");
                if (!File.Exists(resultsFilePath))
                {
                    // Luo Tulokset.json jos ei jo ole olemassa
                    using (File.Create(resultsFilePath));
                }
                //Lisää uuden rivin JSON tiedostoon, tähän riville tulee 'grade'muuttujan arvo
                File.AppendAllText(resultsFilePath, $"{grade}\n");
                          
                Console.WriteLine("Sait " + grade + " oikein");
                Console.WriteLine("Sait " + (max - grade) + " väärin");
                Valikko();               

            }

            public static void Review()
            {




                Valikko();
            }
        }
    }
}
