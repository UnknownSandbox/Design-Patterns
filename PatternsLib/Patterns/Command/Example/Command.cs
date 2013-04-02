using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.Command.Example
{
      
    public abstract class Command
    {
        public abstract string Execute();
        public abstract string UnExecute();
    }

     
}
