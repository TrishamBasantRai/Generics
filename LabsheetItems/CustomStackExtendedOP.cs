using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsheetItems
{
    public class CustomStackExtendedOP
    {
        public static void DisplayAllInternsNameAndId(ICustomStack<IIntern> IInternStack)
        {
            while (IInternStack.Count() > 0)
            {
                Console.WriteLine(IInternStack.Pop().NameID);
            }
        }
    }
}
