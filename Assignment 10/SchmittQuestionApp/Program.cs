﻿using System;

namespace SchmittQuestionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuestionBank.ReadQuestionFile();
            Console.ReadKey();
        }
    }
}