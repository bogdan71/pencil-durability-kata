using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PencilKata;


namespace XUnitTestProject
{
    public class PensilTests
    {
        [Fact]
        public void WriteSimpleTextTest()
        {
            //arrange
            Pencil pencil = new Pencil();
            //act
            pencil.WriteText("I am working hard.");
            //assert
            Assert.Equal("I am working hard.", pencil.ToString());
        }

        [Fact]
        public void WriteTextStringTwice()
        {
            //arrange
            Pencil pencil = new Pencil();
            //act
            pencil.WriteText("I am working hard.");
            pencil.WriteText("I am writting again.");
            //assert
            Assert.Equal("I am working hard.I am writting again.", pencil.ToString());
        }
    }
}
