using ProjetoCadastro;
using ReaLTaiizor.Forms;

namespace CadastroAlunos
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void CadastrarAluno(object sender, EventArgs e)
        {
            FormCadastroAluno formAluno = new FormCadastroAluno();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void FecharForm(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }

        }

        private void CadastrarCurso(object sender, EventArgs e)
        {
            FormCadastroCurso formCurso = new FormCadastroCurso();
            formCurso.MdiParent = this;
            formCurso.Show();
        }
    }
}
