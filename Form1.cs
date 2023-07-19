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
using GBM.Forms;

namespace GBM
{
    public partial class Form1 : Form
    {
        private Form activeForm = null; // Variável para armazenar o formulário ativo
        
        public Form1()
        {
            InitializeComponent();
            Size = new Size(950, 600);
            PnlNav.Height = Home.Height;
            PnlNav.Top = Home.Top;
            PnlNav.Left = Home.Left;
            OpenChildForm(new FormHome()); 
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close(); // Fecha o formulário ativo anterior
            }

            // Configurações do formulário filho
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Adiciona o formulário filho ao Panel
            panelDesktop.Controls.Clear(); // Remove qualquer controle existente no Panel
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            activeForm = childForm; // Atualiza o formulário ativo
            childForm.BringToFront();
            childForm.Show(); // Exibe o formulário
        }


        private void Form1_Load(object sender, EventArgs e)
        {
     
            Cbox1.SelectedIndex = 0;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;    
            Titulo.Text = clickedButton.Text;
            PnlNav.Height = clickedButton.Height;
            PnlNav.Top = clickedButton.Top;
            PnlNav.Left = clickedButton.Left;
            clickedButton.BackColor = Color.FromArgb(46, 51, 73);

            string formName = "Form" + clickedButton.Name; // Obtém o nome do formulário com base no nome do botão
            SelectChildForm(formName);
        }


        private void SelectChildForm(string formName)
        {
            Dictionary<string, Form> meusFormularios = new Dictionary<string, Form>
            {
                { "FormHome", new FormHome() },
                { "FormApartados", new FormApartados() },
                { "FormPortofer", new FormPortofer()},
                { "FormToT", new FormToT()},
                // Adicione outros formulários correspondentes aqui
            };
            Form form = meusFormularios[formName];
            OpenChildForm(form);
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
