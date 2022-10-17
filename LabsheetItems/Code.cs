using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsheetItems
{
    public class Code
    {
        public Code()
        {
            /*
            CustomStack<string> stack = new CustomStack<string>();

            stack.Push("Jedi-X");
            stack.Pop();
            stack.Push("Jedi");

            stack.Push("SkillsLab");

            while (stack.Count() > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            */

            //CustomStack<Jedi> jediStack = new CustomStack<Jedi>();
            CustomStack<IIntern> jediStack = new CustomStack<IIntern>();
            jediStack.Push(new Jedi("James", 1));
            jediStack.Push(new Jedi("John", 2));
            jediStack.Push(new Jedi("Jennifer", 3));

            CustomStack<IIntern> SkillsLabStack = new CustomStack<IIntern>();
            SkillsLabStack.Push(new SkillsLab("Paul", 1));
            SkillsLabStack.Push(new SkillsLab("Pen", 2));
            SkillsLabStack.Push(new SkillsLab("Pan", 3));
            //stack.Push(100);
            //Console.WriteLine(stack.Pop());

            CustomStackExtendedOP.DisplayAllInternsNameAndId(jediStack);
            CustomStackExtendedOP.DisplayAllInternsNameAndId(SkillsLabStack);

            Console.ReadLine();
        }
    }
}
