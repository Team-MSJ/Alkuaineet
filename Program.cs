using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlkuAineet
{
    public class Program
    {
        
        static int max = 5;
        static int grade = 0;
        static string answer = "";
        static List<string> elements = new List<string>();

        static void Main(string[] args)
        {
            Valikko(); 
        }

        static void Valikko()
        {
            Console.WriteLine("Valitse, haluatko");
            Console.WriteLine();
            Console.WriteLine("  P = Pelata");
            Console.WriteLine("  T = Tarkastella tuloksia");
            Console.WriteLine("  L = Lopettaa");
            string input = Console.ReadLine();
            if (input == "P")
            {
                Play();
            }
            else if (input == "T")
            {
                Review();
            }
            else if (input == "L")
            {
                return; 
            }
            else
            {
                Console.WriteLine("Valitse uudelleen");
            }
        }

        static void Play()
        {
            string resultsFilePath;
            //tyhjentää listan ennen jokaista pelikierrrosta 
            elements.Clear();
            grade = 0; 
            // Loopataan kunnes 5 vastausta on täynnä
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna alkuaine: ");
                answer = Console.ReadLine().Trim().ToLower();

                // Tarkistaa onko samaa vastausta käytetty aiemmin
                if (elements.Contains(answer))
                {
                    Console.WriteLine("Voit antaa saman alkuaineen vain kerran.");
                    i--; // Jos samaa vastausta on käytetty aiemmin, vastauskerroista miinustetaan yksi
                }
                else
                {
                    // Lisää "answer" listalle "elements"
                    elements.Add(answer);

                    // Tarkista, onko alkuaine tiedostossa "alkuaineet.txt"
                    if (File.ReadLines("alkuaineet.txt").Any(line => line.Equals(answer, StringComparison.OrdinalIgnoreCase)))
                    {
                        // Lisää yksi piste "grade"
                        grade++;
                    }
                }

                
                                    
            }
            Console.Write("Anna kuluva päivä muodossa PPKKVVVV: ");
            string date = Console.ReadLine();

            bool doesDirectoryExist = Directory.Exists(date);
            if (doesDirectoryExist)
            {
                Console.WriteLine("Hakemisto on jo olemassa.");
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), date));
            }
            
            // Tarkista onko Tulokset.json tiedostoa hakemistossa date
             resultsFilePath = Path.Combine(Directory.GetCurrentDirectory(), date, "Tulokset.json");
            if (!File.Exists(resultsFilePath))
            {
                // Luo Tulokset.json jos ei jo ole olemassa
                using (File.Create(resultsFilePath)) { }
            }
            //Lisää uuden rivin JSON tiedostoon, tähän riville tulee 'grade'muuttujan arvo
                File.AppendAllText(resultsFilePath, $"{grade}\n");

            Console.WriteLine("Sait " + grade + " oikein");
            Console.WriteLine("Sait " + (max - grade) + " väärin");
            Valikko();
        }
        static void Review()
        { 
            Valikko();
        }
    }
}


