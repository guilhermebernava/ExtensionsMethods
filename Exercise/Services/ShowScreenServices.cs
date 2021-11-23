using System;
using System.Collections.Generic;
using Exercise.Intrefaces;
using System.IO;
using Exercise.Entities;

namespace Exercise.Services
{
    internal class ShowScreenServices : IShowScreen
    {
        public void ShowAndSave()
        {
            List<Person> persons = new List<Person>();
            while (true)
            {
                try
                {
                    string targetPath = @"C:\Users\guilh\OneDrive\Documentos\Exercises\Exercise\ExtensionsMethods";

                    Console.Write("Entre a quantidade de Emails e Senhas que queira cadastrar: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Escreva um email (xxxxx@xxx.com): ");
                        string email = Console.ReadLine();
                        email.CheckEmail();
                        Console.WriteLine("Escreva uma senha(Aaaaaaa@): ");
                        string senha = Console.ReadLine();
                        senha.CheckSenha();
                        var p = new Person(email,senha);
                        persons.Add(p);
                    }


                    using (StreamWriter sw = new StreamWriter(Path.Combine(targetPath, "Exercise.txt")))
                    {
                        foreach (Person p in persons)
                        {
                            sw.WriteLine(p); 
                        }
                    }
                    Console.WriteLine("Seus Dados foram salvos em um arquivo .txt!!");
                    break;
                }
                catch (ExerciseExpection e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
