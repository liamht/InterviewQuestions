using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Implement lazy loading on memory heavy thing
    /// </summary>
    public class Question10
    {
        public IMemoryHeavyThing MemoryHeavyThing { get; set; }

        public Question10()
        {
            
        }

        public Question10(IMemoryHeavyThing thing)
        {
            MemoryHeavyThing = thing;
        }


        public interface IMemoryHeavyThing
        {
            
        }
    }
}
