using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Media;

namespace VisitasVidaUniversitaria
{
    public partial class Main : Form
    {
        Visitante visitante = new Visitante();
        SoundPlayer player;
        public Main()
        {
            InitializeComponent();
            player = new SoundPlayer(Properties.Resources.smb3_1_up);

            this.BackColor = Color.FromArgb(206, 32, 124);

            pbQuadrado.Image = Properties.Resources.quadrado;
            pbQuadrado.SizeMode = PictureBoxSizeMode.AutoSize;
            pbNome.Image = Properties.Resources.Nome;
            pbNome.SizeMode = PictureBoxSizeMode.AutoSize;
            pbLogo.Image = Properties.Resources.logo;
            pbLogo.SizeMode = PictureBoxSizeMode.AutoSize;

            btnSave.BackColor = Color.FromArgb(206, 32, 124);
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            visitante.email = txtEmail.Text;
            if (ValidarEmail(txtEmail.Text))
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    visitante.ProcurarRegistro();
                }
                catch
                {
                    MessageBox.Show("Algo de errado. Peça ajuda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }          
            txtNome.Text = visitante.nome;
            txtTelefone.Text = visitante.telefone;
            txtCpf.Text = visitante.cpf;
            txtRg.Text = visitante.rg;        
            txtCep.Text = visitante.cep;
            if (visitante.idade != 0)
                txtIdade.Text = visitante.idade.ToString();
            else
                txtIdade.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if (!contemLetras(txtTelefone.Text))
                {
                    if (ValidarEmail(txtEmail.Text))
                    {
                        visitante.nome = txtNome.Text;
                        visitante.email = txtEmail.Text;
                        visitante.telefone = txtTelefone.Text;
                        visitante.cpf = txtCpf.Text;
                        visitante.rg = txtRg.Text;
                        visitante.cep = txtCep.Text;

                        int num = 0;
                        if (int.TryParse(txtIdade.Text, out num))
                            visitante.idade = Convert.ToInt32(txtIdade.Text);

                        try
                        {
                            this.Cursor = Cursors.WaitCursor;
                            visitante.Salvar();

                            TocarSom();
                            LimparCampos();
                            txtEmail.Focus();
                            visitante = new Visitante();

                            Mensagem mensagem = new Mensagem();
                            mensagem.ShowDialog();
                        }
                        catch
                        {
                            MessageBox.Show("Algo de errado. Peça ajuda.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        finally
                        {
                            this.Cursor = Cursors.Default;
                        }                                                                       
                    }
                    else
                    {
                        MessageBox.Show("Digite um email válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Digite um telefone válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Preencha os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool VerificarCampos()
        {
            if (txtEmail.Text != "" && txtNome.Text != "" && txtTelefone.Text != "")
                return true;
            return false;
        }

        public void LimparCampos()
        {
            txtEmail.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            txtCep.Text = "";
            txtIdade.Text = "";
        }

        public bool contemLetras(string texto)
        {
            if (texto.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            else
                return false;
        }

        public bool ValidarEmail(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                return true;
            }
            return false;
        }

        public void TocarSom()
        {
            player.Play();
        } 

        private void TxtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void TxtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void TxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void TxtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
    }
}
