using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTicTac
{
    public partial class FormTicTacGame : Form
    {
        public FormTicTacGame()
        {
            InitializeComponent();
        }

        public void ButtonMouseEnter(Panel buttonPanel)
        {
            buttonPanel.BackColor = Color.Purple;
            Cursor = Cursors.Hand;
        }

        public void panelCloseButton_MouseEnter(object sender, EventArgs e)
        {
            ButtonMouseEnter(panelCloseButton);
        }

        public void panelCloseButton_MouseLeave(object sender, EventArgs e)
        {
            panelCloseButton.BackColor = Color.Indigo;
            Cursor = Cursors.Default;
        }

        public void panelCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void labelClose_MouseEnter(object sender, EventArgs e)
        {
            ButtonMouseEnter(panelCloseButton);
        }
    }
}
