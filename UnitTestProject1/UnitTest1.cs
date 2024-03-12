using System;
using GameTicTac;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Create()
        {
            FormTicTacGame form = new FormTicTacGame();
            Assert.IsNotNull(form);
        }
    }
}
