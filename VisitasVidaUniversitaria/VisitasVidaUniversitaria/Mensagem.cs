using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitasVidaUniversitaria
{
    public partial class Mensagem : Form
    {
        public Mensagem()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(206, 32, 124);

            pbQuadrado.Image = Properties.Resources.quadrado;
            pbQuadrado.SizeMode = PictureBoxSizeMode.AutoSize;
            pbMensagem.Image = Properties.Resources.mensagem;
            pbMensagem.SizeMode = PictureBoxSizeMode.AutoSize;

            button1.BackColor = Color.FromArgb(206, 32, 124);
        }

        private void Mensagem_Load(object sender, EventArgs e)
        {
            pbMensagem.Left = this.Width / 2 - pbMensagem.Width / 2;
            pbMensagem.Top = this.Height / 2 - pbMensagem.Height / 2;

            timer1.Start();
            timer1.Interval = 10000;

            button1.Left = this.Width / 2 - button1.Width / 2;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
