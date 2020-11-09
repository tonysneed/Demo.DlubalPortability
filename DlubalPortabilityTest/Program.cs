using System;
using Dlubal.RSTAB8;

namespace DlubalPortabilityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var comment = new Comment
            {
                Text = "Hello World!"
            };
            Console.WriteLine(comment.Text);
        }
    }
}
