using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Use LINQ method syntax to handle the for loop in the example below
    /// </summary>
    public class Question5
    {
        public List<int> GetIntValuesFromStrings(List<string> entities)
        {
            foreach (var entity in entities)
            {
                entities[entity.IndexOf(entity)] = entity.Substring(0, 2);
            }

            var parsedEntities = new List<int>();

            foreach (var entity in entities)
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
