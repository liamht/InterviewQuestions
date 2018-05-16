using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Implement lazy loading on memory heavy thing, do not use the Lazy<IMemoryHeavyThing> class
    /// </summary>
    public class Question10
    {
        public IMemoryHeavyThing MemoryHeavyThing { get; set; }

        public Question10()
        {
            
        }

        public interface IMemoryHeavyThing
        {
            
        }
    }
}
