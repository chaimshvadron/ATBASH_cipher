namespace ATBASH_cipher
{
    class Program()
    {
        static void Main()
        {
            Console.WriteLine(EliDecrypt("Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb." +
                "\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo." +
                "\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh." +
                "\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm." +
                "\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt." +
                "\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg." +
                "\nErxglib rh mvzi. Hgzb ivzwb."));
        }
        static string EliDecrypt(string strEncrypt)
        {
            Dictionary<char,string> keyLetter = new Dictionary<char,string>()
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
    }
}
