using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    public class Solution
    {
        public bool isValid(string s)
        {
            bool isValid = true;
            List<char> open = new List<char>();
            open.Add('{');
            open.Add('[');
            open.Add('(');

            List<char> closed = new List<char>();
            closed.Add('}');
            closed.Add(']');
            closed.Add(')');

            Stack<char> stack = new Stack<char>();
            for(int i = 0; i < s.Length; i++)
            {
                if (open.Contains(s[i]))
                {
                    stack.Push(s[i]);
                }
                else if (closed.Contains(s[i]))
                {              
                    if (stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }

                    var last = stack.Peek();
                    if ((last == '(' && s[i] == ')') || (last == '{' && s[i] == '}') || (last == '[' && s[i] == ']'))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            if(stack.Count != 0) isValid = false;

            return isValid;
        }
    }
}
