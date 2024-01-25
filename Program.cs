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
            Console.WriteLine("\nValitse, haluatko");
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
                Valikko();
            }
        }

        static void Play()
        {
            //resets the list and grade
            elements.Clear();
            grade = 0;
            // Loop until 5 answers are given
            for (int i = 0; i < max; i++)
            {
                Console.Write("Anna alkuaine: ");
                answer = Console.ReadLine()?.Trim().ToLower() ?? ""; // Handle possible null input

                // Check if the same answer has been used before
                if (elements.Contains(answer))
                {
                    Console.WriteLine("Voit antaa saman alkuaineen vain kerran.");
                    i--; // If the same answer has been used before, decrement the answer count
                }
                else
                {
                    elements.Add(answer);

                    // Check if the element is in the file "alkuaineet.txt"
                    if (File.ReadLines("alkuaineet.txt").Any(line => line.Equals(answer, StringComparison.OrdinalIgnoreCase)))
                    {
                        grade++;
                    }
                }
            }

            Console.Write("\nHakemiston perustamista varten anna kuluva päivä muodossa PPKKVVVV: ");
            string date = Console.ReadLine();

            // Check if the directory exists
            if (!Directory.Exists(date))
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), date));
            }

            // Check if "Tulokset.json" exists in the directory
            string resultsFilePath = Path.Combine(Directory.GetCurrentDirectory(), date, "Tulokset.json");
            if (!File.Exists(resultsFilePath))
            {
                // Create "Tulokset.json" if it doesn't exist
                using (File.Create(resultsFilePath)) { }
            }

            // Add a new line to "Tulokset.json" with the value of the 'grade' variable
            File.AppendAllText(resultsFilePath, $"{grade}\n");

            Console.WriteLine("Sait " + grade + " oikein");
            Console.WriteLine("Sait " + (max - grade) + " väärin");
            Valikko();

        }

        public class tuloksetData
        {
            public int Total { get; set; }
            public int count { get; set; }
        }
        static void Review()
        {
            int sum = 0;
            int count = 0;

            string[] allFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.json", SearchOption.AllDirectories);

            foreach (var file in allFiles)
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(file);

                // Process each line (assuming each line contains a single score)
                foreach (var line in lines)
                {
                    // Try parsing the line as an integer
                    if (int.TryParse(line, out int score))
                    {
                        // Update the sum and count
                        sum += score;
                        count++;
                    }

                }
            }

            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine($"Kaikkien vastausten keskiarvo: {average:F2}");
            }
            else
            {
                Console.WriteLine("Ei vastauksia laskettavaksi.");
            }

            Console.Write("Paina mitä tahansa näppäintä");
            Console.ReadLine();

            Valikko();
        }
    }

}
