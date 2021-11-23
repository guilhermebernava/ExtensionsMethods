using System;

namespace Exercise
{
    internal class ExerciseExpection : Exception
    {
        public ExerciseExpection(string msg) : base(msg) { }
    }
}
