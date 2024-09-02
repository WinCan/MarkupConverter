using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkupConverter
{
    public class TestClass
    {
        static int i=0;
        public int TestMethod()
        {
            for (i++; i % 3 != 0; i++) ;
            return i;
        }
    }
}
