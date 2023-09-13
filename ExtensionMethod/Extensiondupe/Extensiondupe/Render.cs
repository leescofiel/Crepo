using System;
using ClassLibrary1;
namespace Extensiondupes
{
   public static class Data
    {
        public static double GetData(this Class1 cs)
        {
            return cs.total*cs.mark;
        }
    }
}
