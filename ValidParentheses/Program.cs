// See https://aka.ms/new-console-template for more information

using ValidParentheses;

string input = "{[]}";
Solution solution = new Solution();
var valid = solution.isValid(input);
Console.WriteLine(valid);
