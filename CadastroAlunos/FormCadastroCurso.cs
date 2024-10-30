using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class FormCadastroCurso : MaterialForm
    {
        string cursosFileName = "cursos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;

        public FormCadastroCurso()
        {
            InitializeComponent();
        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(tbCodigo.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Código não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCodigo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Nome não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbNivel.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Nível não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbNivel.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbPeriodo.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Período não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbPeriodo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbDuracao.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Duração não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDuracao.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbArea.Text))
            {
                MessageBox.Show("Campo Obrigatório!\nCampo Área não preenchido", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbArea.Focus();
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

        private void Salvar()
        {
            var line = $"{tbCodigo.Text};" +
                       $"{tbNome.Text};" +
                       $"{cbNivel.Text};" +
                       $"{cbPeriodo.Text};" +
                       $"{tbDuracao.Text};" +
                       $"{cbArea.Text};";

            if (!isAlteracao) // Novo Registro
            {
                var file = new StreamWriter(cursosFileName, true);
                file.WriteLine(line);
                file.Close();
            }
            else
            {
                string[] cursos = File.ReadAllLines(cursosFileName);
                cursos[indexSelecionado] = line;
                File.WriteAllLines(cursosFileName, cursos);
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

        private void Editar()
        {
            if (lvCursos.SelectedIndices.Count > 0)
            {
                indexSelecionado = lvCursos.SelectedItems[0].Index;
                isAlteracao = true;
                var item = lvCursos.SelectedItems[0];
                tbCodigo.Text = item.SubItems[0].Text;
                tbNome.Text = item.SubItems[1].Text;
                cbNivel.Text = item.SubItems[2].Text;
                cbPeriodo.Text = item.SubItems[3].Text;
                tbDuracao.Text = item.SubItems[4].Text;
                cbArea.Text = item.SubItems[5].Text;
                tabPageControl.SelectedIndex = 0;
                tbCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum curso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void CarregaListView()
        {
            Cursor.Current = Cursors.WaitCursor;
            lvCursos.Columns.Clear();
            lvCursos.Items.Clear();
            lvCursos.Columns.Add("Código");
            lvCursos.Columns.Add("Nome");
            lvCursos.Columns.Add("Nível");
            lvCursos.Columns.Add("Período");
            lvCursos.Columns.Add("Duração");
            lvCursos.Columns.Add("Área");

            string[] cursos = File.ReadAllLines(cursosFileName);

            foreach (string curso in cursos)
            {
                var campos = curso.Split(';');
                lvCursos.Items.Add(new ListViewItem(campos));
            }
            lvCursos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Cursor.Current = Cursors.Default;
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
            tbCodigo.Focus();
        }

        private void Excluir()
        {
            List<string> cursos = File.ReadAllLines(cursosFileName).ToList();
            cursos.RemoveAt(indexSelecionado);
            File.WriteAllLines(cursosFileName, cursos);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lvCursos.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show(this, "Deseja realmente excluir o curso selecionado?", "Pergunta", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = lvCursos.SelectedItems[0].Index;
                    Excluir();
                    CarregaListView();

                }
            }
            else
            {
                MessageBox.Show("Selecione algum curso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lvCursos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void lvCursos_Enter(object sender, EventArgs e)
        {
            CarregaListView();
        }
    }
}
