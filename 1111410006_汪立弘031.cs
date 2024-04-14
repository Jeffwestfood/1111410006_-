using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = { "hello", "world" };
        char x = 'o';
        
        var result = words.Select((word, index) => word.Contains(x) ? index : -1).Where(i => i != -1);
        
        Console.WriteLine(string.Join(",", result));
    }
}