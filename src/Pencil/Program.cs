using System;

namespace PencilKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pencil pencil = new Pencil();
            pencil.WriteText("blah blah blah");
            pencil.WriteText("more more more");

            Console.WriteLine(pencil.ToString());

            Console.Read();
        }
    }
}
