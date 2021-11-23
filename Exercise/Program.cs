using System;
using System.Collections.Generic;
using Exercise.Services;


namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowScreenServices show = new ShowScreenServices();
            show.ShowAndSave();
        }
    }
}
