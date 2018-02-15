using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Rewrite the GetIntValuesFromStrings method so that both foreach loops are no longer used.
    /// Instead, LINQ method syntax should be used to return the first two characters of each string inside the list as integers, 
    /// where the characters are actually representitive of numbers
    /// </summary>
    public class Question5
    {
        public List<int> GetIntValuesFromStrings(List<string> entities)
        {
            var firstCharacters = new List<string>();
            foreach (var entity in entities)
            {
                firstCharacters.Add(entity.Substring(0, 2));
            }

            var parsedEntities = new List<int>();

            foreach (var entity in firstCharacters)
            {
                int parsedValue;
                if (int.TryParse(entity, out parsedValue))
                {
                    parsedEntities.Add(parsedValue);
                }
            }
            
            return parsedEntities;
        }
    }
}
