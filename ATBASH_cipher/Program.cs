using System.Net.Mail;

namespace ATBASH_cipher
{
    class Program
    {
        static void Main()
        {
        }

        static void PrintFinally(int conter, string str)
        {
            string warning = "";
            if (conter > 0 && conter <= 5)
            {
                warning = "WARNING";
            }
            else if (conter > 5 && conter < 11)
            {
                warning = "DANGER";
            }
            else if (conter >= 11 && conter < 15)
            {
                warning = "ULTRA ALTERT";
            }
            string MssageFinallY = "";

            if (conter > 0)
            {
                MssageFinallY = $"{warning}\n{str}\n{conter}the suspect words";
            }
            else
            {
                MssageFinallY = "No suspicious words found.";
            }
            Console.WriteLine(MssageFinallY);
        }
    }
}
