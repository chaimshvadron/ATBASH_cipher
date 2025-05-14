namespace ATBASH_cipher
{
    class Program
    {
        static void Main()
        {
            string message = "A secret report surfaced this morning detailing a planned attack by the nukhba unit. The secret document outlined how multiple fighter squads would enter the city under disguise. One fighter was caught near the central station carrying parts of a homemade bomb. Another bomb was found hidden in a vehicle parked near the embassy. Intelligence agents noted that the nukhba fighters are likely to use advanced rocket systems during the assault. In recent weeks, rocket after rocket has been launched from hidden sites, overwhelming local defenses. The defense minister confirmed that rocket fragments found near the border matched those used in previous nukhba operations. Secret communication between fighters hinted at further use of bomb traps in civilian areas. Authorities believe at least one more fighter is still at large. Security experts are urging all residents to report any suspicious activity, especially near areas where rocket attacks have occurred. The prime minister mentioned the word 'secret' at least five times in his briefing, emphasizing the importance of preventing information leaks. So far, four fighters have been arrested and several bomb-making materials seized. Intelligence continues to monitor known nukhba channels for hints of another coordinated rocket launch.";
            Console.WriteLine(CountDangerousWords(message));
        }

        static int CountDangerousWords(string deciphered)
        {
            int count = 0;
            string[] decipheredWord = deciphered.Split(" ");
            string[] dangerousWords = new string[] {"bomb", "nukhba", "fighter", "rocket", "secret" };
            foreach (string word in dangerousWords)
            {
                foreach (string item in decipheredWord)
                {
                    if (item.ToLower() == word)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
