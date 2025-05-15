namespace ATBASH_cipher
{
    class Program
    {
        static void Main()
        {
            string encrypted =
                "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\n" +
                "Gsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\n" +
                "Ylnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\n" +
                "Mfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\n" +
                "Gsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\n" +
                "Dv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\n" +
                "Erxglib rh mvzi. Hgzb ivzwb.";

            string decrypted = EliDecrypt(encrypted);
            int points = CountDangerousWords(decrypted);
            PrintFinally(points, decrypted);
        }


        static int CountDangerousWords(string text)
        {
            int count = 0;
            string word = "";
            string[] dangers = { "bomb", "nukhba", "fighter", "rocket", "secret" };
            text = text.ToLower();

            foreach (char c in text + " ")
            {
                if (char.IsLetter(c))
                    word += c;
                else if (word != "")
                {
                    foreach (string d in dangers)
                        if (word == d) count++;
                    word = "";
                }
            }

            return count;
        }



        static string EliDecrypt(string strEncrypt)
        {
            Dictionary<char, string> keyLetter = new Dictionary<char, string>()
            {
                ['a'] = "z",
                ['b'] = "y",
                ['c'] = "x",
                ['d'] = "w",
                ['e'] = "v",
                ['f'] = "u",
                ['g'] = "t",
                ['h'] = "s",
                ['i'] = "r",
                ['j'] = "q",
                ['k'] = "p",
                ['l'] = "o",
                ['m'] = "n",
                ['n'] = "m",
                ['o'] = "l",
                ['p'] = "k",
                ['q'] = "j",
                ['r'] = "i",
                ['s'] = "h",
                ['t'] = "g",
                ['u'] = "f",
                ['v'] = "e",
                ['w'] = "d",
                ['x'] = "c",
                ['y'] = "b",
                ['z'] = "a"


            };
            string decryptStr = string.Empty;
            foreach (char c in strEncrypt)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsLower(c))
                    {
                        decryptStr += keyLetter[c];
                    }
                    else
                    {
                        decryptStr += keyLetter[char.ToLower(c)].ToUpper();
                    }
                }
                else
                {
                    decryptStr += c;
                }

            }
            return decryptStr;

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
                MssageFinallY = $"{warning}\n{str}\n{conter} the suspect words";
            }
            else
            {
                MssageFinallY = "No suspicious words found.";
            }
            Console.WriteLine(MssageFinallY);
        }
    }
}
