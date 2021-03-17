using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkLibrary.UI
{
    public class Draw
    {
        public void DrawData(IEnumerable<dynamic> list)
        {
            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}
