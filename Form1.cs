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
      
        public Form1()
        {
            InitializeComponent();
            Size = new Size(800, 600);
            PnlNav.Height = BtnGeral.Height;
            PnlNav.Top = BtnGeral.Top;
            PnlNav.Left = BtnGeral.Left;
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Titulo.Text = clickedButton.Text;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
