using System;

namespace PencilKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pencil pencil = new Pencil();
            pencil.WriteText("blah blah blah");

            Console.WriteLine(pencil.ToString());

            Console.Read();
        }
    }
}
