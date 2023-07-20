using System;
using System.Text;

namespace Levels.Level1.DrawStairs
{
    public static class DrawStairHelper
    {
        public static string DrawStair(int number, string name = "I")
        {
            if (number <= 0 || string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"{nameof(number)} or {nameof(name)}");
            }
            
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < number - 1; i++)
            {
                stringBuilder.Append(new string(' ', i)).Append($"{name}\n");
            }

            stringBuilder.Append(new string(' ', number - 1)).Append($"{name}");

            return stringBuilder.ToString();
        }
    }
}