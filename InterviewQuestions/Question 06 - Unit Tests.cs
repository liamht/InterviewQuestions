using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Write a new unit test class (either inside this file, or in a new one) that will test the method below.
    /// </summary>
    public class Question6
    {
        private IQuestion6Dependency _dependency;

        public Question6(IQuestion6Dependency dependency)
        {
            _dependency = dependency;
        }

        public string GetFirstSixCharactersOfDatabaseValue()
        {
            var dbValue = _dependency.GetValueFromDatabase();
            return dbValue.Substring(0, 6);
        }
    }

    public interface IQuestion6Dependency
    {
        string GetValueFromDatabase();
    }
}
