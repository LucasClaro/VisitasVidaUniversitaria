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
    public partial class Main : Form
    {
        Visitante visitante = new Visitante();
        public Main()
        {
            InitializeComponent();
        }

        private void BtnTestConexao_Click(object sender, EventArgs e)
        {
            Conexao.Conectar();
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            visitante.email = txtEmail.Text;
            visitante = visitante.ProcurarRegistro();
        }
    }
}
