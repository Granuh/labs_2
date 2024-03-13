using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        
        [TestMethod]
        public void TestButtonMouseEnter_BackColor()
        {
            FormTicTacGame form = new FormTicTacGame();
            Panel buttonPanel = new Panel();

            form.ButtonMouseEnter(buttonPanel);

            Assert.AreEqual(Color.Purple, buttonPanel.BackColor);
        }

        [TestMethod]
        public void TestCellMouseOver()
        {
            FormTicTacGame form = new FormTicTacGame();
            Panel panelCell = new Panel();
            Color expectedColor = panelCell.BackColor;

            form.CellMouseOver(panelCell);

            Assert.AreEqual(Color.Purple, panelCell.BackColor);
        }

        [TestMethod]
        public void TestCellMouseOut()
        {
            FormTicTacGame form = new FormTicTacGame();
            Panel panelCell = new Panel();
            Color expectedColor = panelCell.BackColor;

            form.CellMouseOut(panelCell);

            Assert.AreEqual(Color.Indigo, panelCell.BackColor);
        }
    }
}
