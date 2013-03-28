using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.LazyLoad.Example
{
    public sealed class BigObject: LazyInit<BigObject>
    {
        private string _text = "Not created";

        public BigObject()
        {
            System.Threading.Thread.Sleep(3000);
            _text = "Created";
        }

        public String GetTextAfterCreating()
        {
            return _text;
        }
    }

}
