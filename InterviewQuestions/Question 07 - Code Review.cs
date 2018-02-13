//Question 7 - Code review the code below. Write any comments / suggestions in code comments next to the affected line.
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace InterviewQuestions
{
    public class Question7
    {
        public string defaultAnswer;
        private List<string> AvaliableAnswers { get; set; }


        public Question7(List<string> avaliableAnswers)
        {
            defaultAnswer = GetDefaultAnswer(avaliableAnswers);
        }

        public string GetDefaultAnswer(List<string> avaliableAnswers)
        {
            try
            {
                // we shouldn't have more than one avaliable answer NORMALLY, so lets try and get one.
                return avaliableAnswers.Single();
            }
            catch (Exception e)
            {
                if (avaliableAnswers.Count == 0)
                {
                    return "There are no answers avaliable";
                }
                else
                {
                    // there were multiple answers. Inform the user
                    return "There are more than 1 answers to this question";
                }
            }
        }

        public void DisplayAnswersToUser()
        {
            foreach (var answer in AvaliableAnswers)
            {
                var currentItemPosition = AvaliableAnswers.IndexOf(answer) + 1;
                Console.WriteLine(currentItemPosition + " - " + answer);
            }
        }
    }
}
