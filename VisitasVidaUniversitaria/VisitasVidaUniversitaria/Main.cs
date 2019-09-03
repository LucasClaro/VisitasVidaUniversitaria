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
            visitante.ProcurarRegistro();
            txtNome.Text = visitante.nome;
            txtTelefone.Text = visitante.telefone;
            txtCpf.Text = visitante.cpf;
            txtRg.Text = visitante.rg;        
            txtCep.Text = visitante.cep;
            if(visitante.idade != 0)
                txtIdade.Text = visitante.idade.ToString();
        }
    }
}
