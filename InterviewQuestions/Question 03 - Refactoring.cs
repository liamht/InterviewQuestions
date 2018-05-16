using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Refactor the code below to make it more object oriented and remove the switch statement.
    /// The likely result of this will end up with a boolean property on the service class
    /// 
    /// You are permitted to write as many additional classes, methods or code as you see necessary.
    /// </summary>
    public class Question3
    {
        private Service _service;

        private Question3(Service service)
        {
            _service = service;
        }

        public string GetString(string theInput)
        {
            string response = _service.AskForPermission();
            switch (response)
            {
                case "FAIL":
                    return "error";
                case "OK":
                    return String.Format("{0} {1}", theInput, theInput);
                default:
                    return null;
            }
        }

        private class Service
        {
            internal string AskForPermission()
            {
                throw new NotImplementedException();
            }
        }
    }
}
