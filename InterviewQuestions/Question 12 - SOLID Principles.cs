using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Following SOLID principles. Create a new ideology so that the answers to the Question13 class can be fetched from a source that is not a file.
    /// Upon completion, Change the Question13 class so that the Answers retreived are fetched from a different location to the one specified in the FileRetreivers CONST value
    /// </summary>
    public class Question13
    {
        private List<QuestionAnswer> _answers { get; set; }

        private Question13(IAnswerRetreiver retreiver)
        {
            _answers = retreiver.GetAnswers();
        }

        public Question13()
        {
            _answers = new FileRetreiver().GetAnswers();
        }

        #region question code dependencies

        private class FileRetreiver : IAnswerRetreiver
        {
            private const string ANSWER_FILE_LOCATION = "C:/AnswerFiles/Answers.answerfile";

            public List<QuestionAnswer> GetAnswers()
            {
                if (File.Exists(ANSWER_FILE_LOCATION))
                {
                    return File.ReadAllLines(ANSWER_FILE_LOCATION).Select(val => new QuestionAnswer(val)).ToList();
                }

                throw new FileNotFoundException("Could not load file containing answers");
            }
        }

        private interface IAnswerRetreiver
        {
            List<QuestionAnswer> GetAnswers();
        }

        private class QuestionAnswer
        {
            public string Value { get; set; }

            public QuestionAnswer(string val)
            {
                Value = val;
            }
        }
        #endregion
    }
}
