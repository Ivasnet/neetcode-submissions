public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] is '(' or '{' or '[')
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count == 0) return false;

                var last = stack.Pop();
                if ((s[i] == ')' && last == '(')
                || (s[i] == '}' && last == '{')
                || (s[i] == ']' && last == '['))
                {
                    continue;
                }

                return false;
            }
        }

        return stack.Count == 0;
    }
}
