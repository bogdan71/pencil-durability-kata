using System;
using System.Collections.Generic;
using System.Text;

namespace PencilKata
{
    public class Pencil
    {
        public string FullText = string.Empty;

        public Pencil()
        {

        }

        public void WriteText(string inputText)
        {
            FullText += inputText;
        }

        public override string ToString()
        {
            return FullText;
        }
    }
}
