using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Refactor the code below so that the nested if statements are reduced as much as possible.
    /// </summary>
    public class Question4
    {
        private ISuccessChecker _initializationChecker;
        private ISuccessChecker _nullChecker;
        private ISuccessChecker _dataEntryValidation;
        private ISuccessChecker _databaseValiator;

        private Question4(ISuccessChecker initializationChecker, ISuccessChecker nullChecker,
            ISuccessChecker dataEntryChecker, ISuccessChecker databaseValidator)
        {
            _initializationChecker = initializationChecker;
            _nullChecker = nullChecker;
            _dataEntryValidation = dataEntryChecker;
            _databaseValiator = databaseValidator;
        }

        public string GetResult()
        {
            string resultToReturnToUser = string.Empty;

            if (_initializationChecker.DidSucceed())
            {
                if (_nullChecker.DidSucceed())
                {
                    if (_dataEntryValidation.DidSucceed())
                    {
                        if (_databaseValiator.DidSucceed())
                        {
                            resultToReturnToUser = "validated";
                        }
                        else
                        {
                            resultToReturnToUser = "Could not validate database";
                        }
                    }
                    else
                    {
                        resultToReturnToUser = "Could not validate data entry";
                    }
                }
                else
                {
                    resultToReturnToUser = "Could not validate nulls";
                }
            }
            else
            {
                resultToReturnToUser = "Entry did not pass initial validation";
            }

            return resultToReturnToUser;
        }

        private interface ISuccessChecker
        {
            bool DidSucceed();
        }
    }
}
