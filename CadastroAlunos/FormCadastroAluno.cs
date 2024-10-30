using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace ProjetoCadastro
{
    public partial class FormCadastroAluno : MaterialForm
    {
        string alunosFileName = "alunos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;

        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        private void Salvar()
        {
            var line = $"{tbMatricula.Text};" +
                       $"{tbDataNascimento.Text};" +
                       $"{tbNome.Text};" +
                       $"{tbEndereco.Text};" +
                       $"{tbCidade.Text};" +
                       $"{tbBairro.Text};" +
                       $"{cbEstado.Text};" +
                       $"{tbSenha.Text};";

            if (!isAlteracao) // Novo Registro
            {
                var file = new StreamWriter(alunosFileName, true);
                file.WriteLine(line);
                file.Close();
            }
            else
            {
                string[] alunos = File.ReadAllLines(alunosFileName);
                alunos[indexSelecionado] = line;
                File.WriteAllLines(alunosFileName, alunos);
            }
            LimpaCampos();
        }

        private void ClickSalvar(object sender, EventArgs e)
        {
            if (ValidaFormulario()) // Faz a Validação
            {
                Salvar(); // Chama o Método para salvar no arquivo txt
                tabPageControl.SelectedIndex = 1; // Muda para Página de Consulta
            }
        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(tbMatricula.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Matrícula não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMatricula.Focus();
                return false;
            }
            if (!DateTime.TryParse(tbDataNascimento.Text, out DateTime _))
            {
                MessageBox.Show("Data de Nascimento inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDataNascimento.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Nome não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbEndereco.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Endereço não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEndereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbCidade.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Cidade não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbEstado.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Estado não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbEstado.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbSenha.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Senha não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSenha.Focus();
                return false;
            }
            return true;
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void CarregaListView()
        {
            Cursor.Current = Cursors.WaitCursor;
            lvAlunos.Columns.Clear();
            lvAlunos.Items.Clear();
            lvAlunos.Columns.Add("Matrícula");
            lvAlunos.Columns.Add("Data Nasc.");
            lvAlunos.Columns.Add("Nome");
            lvAlunos.Columns.Add("Endereço");
            lvAlunos.Columns.Add("Cidade");
            lvAlunos.Columns.Add("Bairro");
            lvAlunos.Columns.Add("UF");

            string[] alunos = File.ReadAllLines(alunosFileName);

            foreach (string aluno in alunos)
            {
                var campos = aluno.Split(';');
                lvAlunos.Items.Add(new ListViewItem(campos));
            }
            lvAlunos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Cursor.Current = Cursors.Default;
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaListView();
        }

        private void Editar()
        {
            if (lvAlunos.SelectedIndices.Count > 0)
            {
                indexSelecionado = lvAlunos.SelectedItems[0].Index;
                isAlteracao = true;
                var item = lvAlunos.SelectedItems[0];
                tbMatricula.Text = item.SubItems[0].Text;
                tbDataNascimento.Text = item.SubItems[1].Text;
                tbNome.Text = item.SubItems[2].Text;
                tbEndereco.Text = item.SubItems[3].Text;
                tbBairro.Text = item.SubItems[4].Text;
                tbCidade.Text = item.SubItems[5].Text;
                cbEstado.Text = item.SubItems[6].Text;
                tbSenha.Text = item.SubItems[7].Text;
                tabPageControl.SelectedIndex = 0;
                tbMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lvAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Informações não salvas serão perdidas./r/n"
                                + "Deseja cancelar?", "Pergunta", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabPageControl.SelectedIndex = 1;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            tabPageControl.SelectedIndex = 0;
            tbMatricula.Focus();
        }

        private void Excluir()
        {
            List<string> alunos = File.ReadAllLines(alunosFileName).ToList();
            alunos.RemoveAt(indexSelecionado);
            File.WriteAllLines(alunosFileName, alunos);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lvAlunos.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show(this, "Deseja realmente excluir o aluno selecionado?", "Pergunta", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = lvAlunos.SelectedItems[0].Index;
                    Excluir();
                    CarregaListView();

                }
            }
            else
            {
                MessageBox.Show("Selecione algum aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
