using System.Text;

namespace SchmittQuestionApp
{
    /// <summary>
    /// A data class storing information about questions
    /// </summary>
    internal class QuestionUnit
    {
        private string[] answers;
        private string answer;
        private string explanation;
        private string question;

        internal string[] Answers { get { return answers; } }
        internal string Answer { get { return answer; } }
        internal string Explanation { get { return explanation; } }
        internal string Question { get { return question; } }

        /// <summary>
        /// Constructs a new QuestionUnit
        /// </summary>
        /// <param name="answers">All availible answers for this question (includes correct answer)</param>
        /// <param name="answer">The correct answer for this question</param>
        /// <param name="explanation">The explanation for this question</param>
        /// <param name="question">The question text</param>
        internal QuestionUnit(string[] answers, string answer, string explanation, string question)
        {
            this.answers = answers;
            this.answer = answer;
            this.explanation = explanation;
            this.question = question;
        }

        /// <summary>
        /// Overrriden ToString() method for debugging
        /// </summary>
        /// <returns>A string representation of this object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Question: " + question);
            sb.AppendLine("Answer: " + answer);
            sb.AppendLine("Explanation: " + explanation);
            sb.Append("Answers: ");
            
            foreach(string ans in answers)
            {
                sb.Append(ans);
                sb.Append(" | ");
            }

            return sb.ToString();
        }
    }
}
