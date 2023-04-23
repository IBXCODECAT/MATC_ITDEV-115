using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace SchmittQuestionApp
{
    internal static class QuestionBank
    {

        private const string FILENAME = @"questions.bin";
        private const string REGEX_ANS_PATTERN = @"::a=(.*?)\n";
        private const string QUESTION_START_MARKER = "::q=";
        private const string EXPLANATION_START_MARKER = "::e=";
        private const string END_MARKER = ":";
        private const int NO_OF_ANSWERS = 4;
        private const int NO_OF_QUESTIONS = 4;

        private static QuestionUnit[] questions;

        internal static string[] GetAnswers(int index)
        {
            return questions[index].Answers;
        }

        internal static string GetAnswer(int index)
        {
            return questions[index].Answer;
        }

        internal static string GetExplanation(int index)
        {
            return questions[index].Explanation;
        }

        internal static string GetQuestion(int index)
        {
            return questions[index].Question;
        }

        internal static int ReadQuestionFile()
        {
            //Text from the file will be stored here
            string data = string.Empty;
            
            //A dictionary of answers for the questions
            Dictionary<string, string> AnswerDictionary = new Dictionary<string, string>();

            //Read the file's contents into data
            try
            {
                data = File.ReadAllText(FILENAME, Encoding.UTF8);
                //Console.WriteLine(data);                
            }
            catch
            {
                Console.WriteLine("The file 'questions.bin' could not be found!");
                return 0;
            }

            //Read our quewstion data and store in a string[]
            #region Read_Questions
            int currentIndex_q = 0;
            List<string> question_strings_list = new List<string>();

            while (currentIndex_q < data.Length)
            {
                int startIndex_q = data.IndexOf(QUESTION_START_MARKER, currentIndex_q);
                if (startIndex_q == -1)
                {
                    break;
                }

                int endIndex = data.IndexOf(END_MARKER, startIndex_q + QUESTION_START_MARKER.Length);
                if (endIndex == -1)
                {
                    throw new FormatException($"No matching end marker found for start marker at index {startIndex_q}");
                }

                string extractedString = data.Substring(startIndex_q + QUESTION_START_MARKER.Length, endIndex - startIndex_q - QUESTION_START_MARKER.Length);
                if (extractedString.Length < 1)
                {
                    throw new FormatException($"Extracted string between start marker at index {startIndex_q} and end marker at index {endIndex} is empty");
                }

                int nestedStartIndex = data.IndexOf(QUESTION_START_MARKER, startIndex_q + QUESTION_START_MARKER.Length);
                if (nestedStartIndex != -1 && nestedStartIndex < endIndex)
                {
                    throw new FormatException($"Nested start marker found at index {nestedStartIndex}, which is inside the substring extracted between start marker at index {startIndex_q} and end marker at index {endIndex}");
                }

                currentIndex_q = endIndex + END_MARKER.Length;
                question_strings_list.Add(extractedString);
            }
            #endregion Read_Questions

            //Read our explanation data and store in a string[]
            #region Read_Explanation
            int currentIndex_e = 0;
            List<string> explanation_list = new List<string>();

            while (currentIndex_e < data.Length)
            {
                int startIndex_e = data.IndexOf(EXPLANATION_START_MARKER, currentIndex_e);
                if (startIndex_e == -1)
                {
                    break;
                }

                int endIndex = data.IndexOf(END_MARKER, startIndex_e + EXPLANATION_START_MARKER.Length);
                if (endIndex == -1)
                {
                    throw new FormatException($"No matching end marker found for start marker at index {startIndex_e}");
                }

                string extractedString = data.Substring(startIndex_e + EXPLANATION_START_MARKER.Length, endIndex - startIndex_e - EXPLANATION_START_MARKER.Length);
                if (extractedString.Length < 1)
                {
                    throw new FormatException($"Extracted string between start marker at index {startIndex_e} and end marker at index {endIndex} is empty");
                }

                int nestedStartIndex = data.IndexOf(EXPLANATION_START_MARKER, startIndex_e + EXPLANATION_START_MARKER.Length);
                if (nestedStartIndex != -1 && nestedStartIndex < endIndex)
                {
                    throw new FormatException($"Nested start marker found at index {nestedStartIndex}, which is inside the substring extracted between start marker at index {startIndex_e} and end marker at index {endIndex}");
                }

                currentIndex_e = endIndex + END_MARKER.Length;
                explanation_list.Add(extractedString);
            }
            #endregion Read_Explanation

            #region Read_AllAnswers

            //Use the following REGEX to split the string into various answer entries
            
            MatchCollection matches = Regex.Matches(data, REGEX_ANS_PATTERN);
            string[] entries = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                entries[i] = matches[i].Groups[1].Value;
            }

            //Answers are stored like this answername=ansewrtext
            //Create a dictionary and store teh key-value pairs for the answers
            foreach (string entry in entries)
            {
                string[] parts = entry.Split('=');
                AnswerDictionary.Add(parts[0], parts[1]);
            }
            foreach (KeyValuePair<string, string> pair in AnswerDictionary)
            {
                //Test the output
                //Console.WriteLine(pair.Key + ": " + pair.Value);
            }

            #endregion Read_AllAnswers


            //Create a list of question units
            List<QuestionUnit> question_unit_list = new List<QuestionUnit>();

            //For every question we have, create a question unit and add it to a questions list
            for (int i = 0; i < NO_OF_QUESTIONS; i++)
            {
                string correctAnswer = null;
                string[] questionAnswers = new string[NO_OF_ANSWERS];

                for (int n = 0; n < NO_OF_ANSWERS; n++)
                {
                    string answer = null;

                    /*
                     * Answers are stored in the following format q#_correct/incorrect_#
                     * 
                     * Here we attempt to get a value from the dictionary (this would be the correct answer
                     * If this succeeds answer will no longer be equal to null, therefore we can set our correct
                     * answer. If this does not succeed the answer is incorrect.
                     */
                    AnswerDictionary.TryGetValue($"q{i}_correct_{n}", out answer);

                    //If we could not get the answer from the dictionary the answer we pulled is an incorrect answer
                    if (answer == null)
                    {
                        AnswerDictionary.TryGetValue($"q{i}_incorrect_{n - 1}", out answer);
                    }
                    else
                    {
                        correctAnswer = answer;
                    }

                    //Push our answer onto the questionAnswers array.
                    questionAnswers[n] = answer;
                }

                //Here we update our list of question units to contain the questions we read. the explanation and question strings
                //are from lists that we got from parsing the file previously.

                question_unit_list.Clear();
                question_unit_list.Add(new QuestionUnit(questionAnswers, correctAnswer, explanation_list[i], question_strings_list[i]));
            }

            //Set the questions we created to the questions variable in this class
            questions = question_unit_list.ToArray();

            //DEBUG
            //foreach(QuestionUnit unit in questions) Console.WriteLine(unit.ToString());

            return 0;
        }
    }
}
