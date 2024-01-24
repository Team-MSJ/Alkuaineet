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
                string resultsFilePath = Path.Combine(Directory.GetCurrentDirectory(), date, "Tulkoset.json");
                if (!File.Exists(resultsFilePath))
                {
                    // Luo Tulokset.json jos ei jo ole olemassa
                    using (File.Create(resultsFilePath)) ;
                }

                Console.WriteLine("Sait " + grade + " oikein");
                Console.WriteLine("Sait " + (max - grade) + " väärin");
                Console.Write("Paina mitä tahansa näppäintä");
                string back = Console.ReadLine();
                Valikko();

            }

            public static void Review()
            {
                int sum = 0;
                int count = 0;
                // Lukee listalle kaikki alihakemistot
                IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("*.json", SearchOption.AllDirectories);

                foreach (var file in allFilesInAllFolders)
                {
                    string tuloksetJson = File.ReadAllText(file);
                    tuloksetData? data = JsonConvert.DeserializeObject<tuloksetData?>(tuloksetJson);
                    sum += data?.Total ?? 0;
                    count++;
                }
                Console.WriteLine("Kaikkien vastausten keskiarvo  " + (sum / count));
                // Pysäyttää ohjelman, että käyttäjä voi lukea ohjelman antaman ilmoituksen
                Console.Write("Paina mitä tahansa näppäintä");
                back = Console.ReadLine();
                Valikko();
            }
        }
    }
}
