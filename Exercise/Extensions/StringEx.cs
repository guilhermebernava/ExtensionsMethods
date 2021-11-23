using System.Text.RegularExpressions;
using Exercise;

namespace System
{
    static class StringEx
    {
        public static string CheckEmail(this string thisobj)
        {
            string result = "False";
            var rg = new Regex("^[A-Z a-z 0-9]+@+[A-Z a-z]+.+com$");

            if (rg.IsMatch(thisobj))
            {
                Console.WriteLine("Email correto!");
                return thisobj;
            }
            else
            {
                throw new ExerciseExpection("Escreva o email corretamente! (*********@******.com)");
            }

            return result;
        }

        public static string CheckSenha(this string thisobj)
        {
            string result = "False";
            var rg = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[$*&@#])(?:([0-9a-zA-Z$*&@#])){8,}$");

            if (rg.IsMatch(thisobj))
            {
                Console.WriteLine("Senha Forte!");
                return thisobj;
            }
            else
            {
                throw new ExerciseExpection("Senha Fraca!! deve ter no minimo 8 digitos(1 letra maiscula, 1 numero, 1 caracter especial)");
            }
            return result;
        }
    }
}
