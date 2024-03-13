using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCell
{
    [TestClass]
    public class Cell
    {
        [TestMethod]
        public void TestMethod1()
        {
            int row = 1;
            int column = 2;

            Cell cell = Cell.From(row, column); 
        }
    }
}
