using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GBM
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeighEllipse
            
        );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            PnlNav.Height = BtnGeral.Height;
            PnlNav.Top = BtnGeral.Top;
            PnlNav.Left = BtnGeral.Left;
            BtnGeral.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            PnlNav.Height = clickedButton.Height;
            PnlNav.Top = clickedButton.Top;
            PnlNav.Left = clickedButton.Left;
            clickedButton.BackColor = Color.FromArgb(46, 51, 73);
        }

       

        private void Btn_Leave(object sender, EventArgs e)
        {
            Button LeavedButton = (Button)sender;
            LeavedButton.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
