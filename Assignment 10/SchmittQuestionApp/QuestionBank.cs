using System.IO;
using System.Text;
using System.Runtime.Serialization;

namespace SchmittQuestionApp
{
    internal static class QuestionBank
    {
        private const int NO_OF_ANSWERS = 4;
        private const int NO_OF_QUESTIONS = 0;

        private static string fileName = "";
        private static QuestionUnit[] questions;

        internal static string[] GetAnswers(int index)
        {
            return new string[0];
        }

        internal static string GetAnswer(int index)
        {
            return "";
        }

        internal static string GetExplanation(int index)
        {
            return "";
        }

        internal static string GetQuestion(int index)
        {
            return "";
        }

        internal static int ReadQuestionFile()
        {
            string fileText = File.ReadAllText(@"questions.bin", Encoding.UTF8);


            return 0;
        }
    }
}
