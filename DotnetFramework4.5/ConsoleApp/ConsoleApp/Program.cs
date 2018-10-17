using MoreLinq.Extensions;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            byte[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Span<byte> span1 = new Span<byte>(arr);
            var span2 = span1.Slice(1, 2);
            span2[0] = 10;
            arr.ForEach(x =>
            {
                Console.Write(x);
                Console.Write("\t");
            });
        }
    }
}