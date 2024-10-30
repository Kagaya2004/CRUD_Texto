namespace ProjetoCadastro
{
    partial class FormCadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAluno));
            tabPageControl = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            tbDataNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btCancelar = new ReaLTaiizor.Controls.MaterialButton();
            mbSalvar = new ReaLTaiizor.Controls.MaterialButton();
            cbEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            tbSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            lvAlunos = new ListView();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            tabPageControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageControl
            // 
            tabPageControl.Controls.Add(tabPageCadastro);
            tabPageControl.Controls.Add(tabPageConsulta);
            tabPageControl.Depth = 0;
            tabPageControl.Dock = DockStyle.Fill;
            tabPageControl.ImageList = imageList1;
            tabPageControl.Location = new Point(3, 64);
            tabPageControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabPageControl.Multiline = true;
            tabPageControl.Name = "tabPageControl";
            tabPageControl.SelectedIndex = 0;
            tabPageControl.Size = new Size(597, 464);
            tabPageControl.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(tbDataNascimento);
            tabPageCadastro.Controls.Add(tbMatricula);
            tabPageCadastro.Controls.Add(btCancelar);
            tabPageCadastro.Controls.Add(mbSalvar);
            tabPageCadastro.Controls.Add(cbEstado);
            tabPageCadastro.Controls.Add(tbSenha);
            tabPageCadastro.Controls.Add(tbCidade);
            tabPageCadastro.Controls.Add(tbEndereco);
            tabPageCadastro.Controls.Add(tbBairro);
            tabPageCadastro.Controls.Add(tbNome);
            tabPageCadastro.ImageKey = "Forms - Icon.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(589, 429);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // tbDataNascimento
            // 
            tbDataNascimento.AllowPromptAsInput = true;
            tbDataNascimento.AnimateReadOnly = false;
            tbDataNascimento.AsciiOnly = false;
            tbDataNascimento.BackgroundImageLayout = ImageLayout.None;
            tbDataNascimento.BeepOnError = false;
            tbDataNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbDataNascimento.Depth = 0;
            tbDataNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDataNascimento.HidePromptOnLeave = false;
            tbDataNascimento.HideSelection = true;
            tbDataNascimento.Hint = "Data de Nascimento";
            tbDataNascimento.InsertKeyMode = InsertKeyMode.Default;
            tbDataNascimento.LeadingIcon = null;
            tbDataNascimento.Location = new Point(305, 12);
            tbDataNascimento.Mask = "99/99/9999";
            tbDataNascimento.MaxLength = 32767;
            tbDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDataNascimento.Name = "tbDataNascimento";
            tbDataNascimento.PasswordChar = '\0';
            tbDataNascimento.PrefixSuffixText = null;
            tbDataNascimento.PromptChar = '_';
            tbDataNascimento.ReadOnly = false;
            tbDataNascimento.RejectInputOnFirstFailure = false;
            tbDataNascimento.ResetOnPrompt = true;
            tbDataNascimento.ResetOnSpace = true;
            tbDataNascimento.RightToLeft = RightToLeft.No;
            tbDataNascimento.SelectedText = "";
            tbDataNascimento.SelectionLength = 0;
            tbDataNascimento.SelectionStart = 0;
            tbDataNascimento.ShortcutsEnabled = true;
            tbDataNascimento.Size = new Size(265, 48);
            tbDataNascimento.SkipLiterals = true;
            tbDataNascimento.TabIndex = 1;
            tbDataNascimento.TabStop = false;
            tbDataNascimento.Text = "  /  /";
            tbDataNascimento.TextAlign = HorizontalAlignment.Left;
            tbDataNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbDataNascimento.TrailingIcon = null;
            tbDataNascimento.UseSystemPasswordChar = false;
            tbDataNascimento.ValidatingType = null;
            // 
            // tbMatricula
            // 
            tbMatricula.AnimateReadOnly = false;
            tbMatricula.AutoCompleteMode = AutoCompleteMode.None;
            tbMatricula.AutoCompleteSource = AutoCompleteSource.None;
            tbMatricula.BackgroundImageLayout = ImageLayout.None;
            tbMatricula.CharacterCasing = CharacterCasing.Normal;
            tbMatricula.Depth = 0;
            tbMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbMatricula.HideSelection = true;
            tbMatricula.Hint = "Matrícula";
            tbMatricula.LeadingIcon = null;
            tbMatricula.Location = new Point(20, 12);
            tbMatricula.MaxLength = 32767;
            tbMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbMatricula.Name = "tbMatricula";
            tbMatricula.PasswordChar = '\0';
            tbMatricula.PrefixSuffixText = null;
            tbMatricula.ReadOnly = false;
            tbMatricula.RightToLeft = RightToLeft.No;
            tbMatricula.SelectedText = "";
            tbMatricula.SelectionLength = 0;
            tbMatricula.SelectionStart = 0;
            tbMatricula.ShortcutsEnabled = true;
            tbMatricula.Size = new Size(265, 48);
            tbMatricula.TabIndex = 0;
            tbMatricula.TabStop = false;
            tbMatricula.TextAlign = HorizontalAlignment.Left;
            tbMatricula.TrailingIcon = null;
            tbMatricula.UseSystemPasswordChar = false;
            // 
            // btCancelar
            // 
            btCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btCancelar.Depth = 0;
            btCancelar.Font = new Font("Segoe UI", 8.25F);
            btCancelar.HighEmphasis = true;
            btCancelar.Icon = null;
            btCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btCancelar.Location = new Point(390, 392);
            btCancelar.Margin = new Padding(4, 6, 4, 6);
            btCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btCancelar.Name = "btCancelar";
            btCancelar.NoAccentTextColor = Color.Empty;
            btCancelar.Size = new Size(96, 36);
            btCancelar.TabIndex = 8;
            btCancelar.Text = "Cancelar";
            btCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btCancelar.UseAccentColor = false;
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // mbSalvar
            // 
            mbSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbSalvar.Depth = 0;
            mbSalvar.Font = new Font("Segoe UI", 8.25F);
            mbSalvar.HighEmphasis = true;
            mbSalvar.Icon = null;
            mbSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            mbSalvar.Location = new Point(494, 392);
            mbSalvar.Margin = new Padding(4, 6, 4, 6);
            mbSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mbSalvar.Name = "mbSalvar";
            mbSalvar.NoAccentTextColor = Color.Empty;
            mbSalvar.Size = new Size(76, 36);
            mbSalvar.TabIndex = 9;
            mbSalvar.Text = "Salvar";
            mbSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mbSalvar.UseAccentColor = false;
            mbSalvar.UseVisualStyleBackColor = true;
            mbSalvar.Click += ClickSalvar;
            // 
            // cbEstado
            // 
            cbEstado.AutoResize = false;
            cbEstado.BackColor = Color.FromArgb(255, 255, 255);
            cbEstado.Depth = 0;
            cbEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cbEstado.DropDownHeight = 174;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.DropDownWidth = 121;
            cbEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEstado.FormattingEnabled = true;
            cbEstado.Hint = "Estado";
            cbEstado.IntegralHeight = false;
            cbEstado.ItemHeight = 43;
            cbEstado.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PE", "PI", "RJ", "RN", "RO", "RR", "SE", "SP", "TO" });
            cbEstado.Location = new Point(449, 260);
            cbEstado.MaxDropDownItems = 4;
            cbEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(121, 49);
            cbEstado.StartIndex = 0;
            cbEstado.TabIndex = 6;
            // 
            // tbSenha
            // 
            tbSenha.AnimateReadOnly = false;
            tbSenha.AutoCompleteMode = AutoCompleteMode.None;
            tbSenha.AutoCompleteSource = AutoCompleteSource.None;
            tbSenha.BackgroundImageLayout = ImageLayout.None;
            tbSenha.CharacterCasing = CharacterCasing.Normal;
            tbSenha.Depth = 0;
            tbSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSenha.HideSelection = true;
            tbSenha.Hint = "Senha";
            tbSenha.LeadingIcon = (Image)resources.GetObject("tbSenha.LeadingIcon");
            tbSenha.Location = new Point(20, 325);
            tbSenha.MaxLength = 32767;
            tbSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.PrefixSuffixText = null;
            tbSenha.ReadOnly = false;
            tbSenha.RightToLeft = RightToLeft.No;
            tbSenha.SelectedText = "";
            tbSenha.SelectionLength = 0;
            tbSenha.SelectionStart = 0;
            tbSenha.ShortcutsEnabled = true;
            tbSenha.Size = new Size(550, 48);
            tbSenha.TabIndex = 7;
            tbSenha.TabStop = false;
            tbSenha.TextAlign = HorizontalAlignment.Left;
            tbSenha.TrailingIcon = null;
            tbSenha.UseSystemPasswordChar = false;
            // 
            // tbCidade
            // 
            tbCidade.AnimateReadOnly = false;
            tbCidade.AutoCompleteMode = AutoCompleteMode.None;
            tbCidade.AutoCompleteSource = AutoCompleteSource.None;
            tbCidade.BackgroundImageLayout = ImageLayout.None;
            tbCidade.CharacterCasing = CharacterCasing.Normal;
            tbCidade.Depth = 0;
            tbCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCidade.HideSelection = true;
            tbCidade.Hint = "Cidade";
            tbCidade.LeadingIcon = null;
            tbCidade.Location = new Point(20, 260);
            tbCidade.MaxLength = 32767;
            tbCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbCidade.Name = "tbCidade";
            tbCidade.PasswordChar = '\0';
            tbCidade.PrefixSuffixText = null;
            tbCidade.ReadOnly = false;
            tbCidade.RightToLeft = RightToLeft.No;
            tbCidade.SelectedText = "";
            tbCidade.SelectionLength = 0;
            tbCidade.SelectionStart = 0;
            tbCidade.ShortcutsEnabled = true;
            tbCidade.Size = new Size(411, 48);
            tbCidade.TabIndex = 5;
            tbCidade.TabStop = false;
            tbCidade.TextAlign = HorizontalAlignment.Left;
            tbCidade.TrailingIcon = null;
            tbCidade.UseSystemPasswordChar = false;
            // 
            // tbEndereco
            // 
            tbEndereco.AnimateReadOnly = false;
            tbEndereco.AutoCompleteMode = AutoCompleteMode.None;
            tbEndereco.AutoCompleteSource = AutoCompleteSource.None;
            tbEndereco.BackgroundImageLayout = ImageLayout.None;
            tbEndereco.CharacterCasing = CharacterCasing.Normal;
            tbEndereco.Depth = 0;
            tbEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEndereco.HideSelection = true;
            tbEndereco.Hint = "Endereço";
            tbEndereco.LeadingIcon = null;
            tbEndereco.Location = new Point(20, 129);
            tbEndereco.MaxLength = 32767;
            tbEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEndereco.Name = "tbEndereco";
            tbEndereco.PasswordChar = '\0';
            tbEndereco.PrefixSuffixText = null;
            tbEndereco.ReadOnly = false;
            tbEndereco.RightToLeft = RightToLeft.No;
            tbEndereco.SelectedText = "";
            tbEndereco.SelectionLength = 0;
            tbEndereco.SelectionStart = 0;
            tbEndereco.ShortcutsEnabled = true;
            tbEndereco.Size = new Size(550, 48);
            tbEndereco.TabIndex = 3;
            tbEndereco.TabStop = false;
            tbEndereco.TextAlign = HorizontalAlignment.Left;
            tbEndereco.TrailingIcon = null;
            tbEndereco.UseSystemPasswordChar = false;
            // 
            // tbBairro
            // 
            tbBairro.AnimateReadOnly = false;
            tbBairro.AutoCompleteMode = AutoCompleteMode.None;
            tbBairro.AutoCompleteSource = AutoCompleteSource.None;
            tbBairro.BackgroundImageLayout = ImageLayout.None;
            tbBairro.CharacterCasing = CharacterCasing.Normal;
            tbBairro.Depth = 0;
            tbBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbBairro.HideSelection = true;
            tbBairro.Hint = "Bairro";
            tbBairro.LeadingIcon = null;
            tbBairro.Location = new Point(20, 195);
            tbBairro.MaxLength = 32767;
            tbBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbBairro.Name = "tbBairro";
            tbBairro.PasswordChar = '\0';
            tbBairro.PrefixSuffixText = null;
            tbBairro.ReadOnly = false;
            tbBairro.RightToLeft = RightToLeft.No;
            tbBairro.SelectedText = "";
            tbBairro.SelectionLength = 0;
            tbBairro.SelectionStart = 0;
            tbBairro.ShortcutsEnabled = true;
            tbBairro.Size = new Size(550, 48);
            tbBairro.TabIndex = 4;
            tbBairro.TabStop = false;
            tbBairro.TextAlign = HorizontalAlignment.Left;
            tbBairro.TrailingIcon = null;
            tbBairro.UseSystemPasswordChar = false;
            // 
            // tbNome
            // 
            tbNome.AnimateReadOnly = false;
            tbNome.AutoCompleteMode = AutoCompleteMode.None;
            tbNome.AutoCompleteSource = AutoCompleteSource.None;
            tbNome.BackgroundImageLayout = ImageLayout.None;
            tbNome.CharacterCasing = CharacterCasing.Normal;
            tbNome.Depth = 0;
            tbNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbNome.HideSelection = true;
            tbNome.Hint = "Nome";
            tbNome.LeadingIcon = null;
            tbNome.Location = new Point(20, 66);
            tbNome.MaxLength = 32767;
            tbNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbNome.Name = "tbNome";
            tbNome.PasswordChar = '\0';
            tbNome.PrefixSuffixText = null;
            tbNome.ReadOnly = false;
            tbNome.RightToLeft = RightToLeft.No;
            tbNome.SelectedText = "";
            tbNome.SelectionLength = 0;
            tbNome.SelectionStart = 0;
            tbNome.ShortcutsEnabled = true;
            tbNome.Size = new Size(550, 48);
            tbNome.TabIndex = 2;
            tbNome.TabStop = false;
            tbNome.TextAlign = HorizontalAlignment.Left;
            tbNome.TrailingIcon = null;
            tbNome.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(lvAlunos);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.ImageKey = "Search - Icon.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(589, 429);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // lvAlunos
            // 
            lvAlunos.Dock = DockStyle.Fill;
            lvAlunos.FullRowSelect = true;
            lvAlunos.Location = new Point(3, 3);
            lvAlunos.Name = "lvAlunos";
            lvAlunos.Size = new Size(583, 423);
            lvAlunos.TabIndex = 4;
            lvAlunos.UseCompatibleStateImageBehavior = false;
            lvAlunos.View = View.Details;
            lvAlunos.MouseDoubleClick += lvAlunos_MouseDoubleClick;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(354, 374);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(426, 374);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(505, 374);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Forms - Icon.png");
            imageList1.Images.SetKeyName(1, "Search - Icon.png");
            // 
            // FormCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 531);
            Controls.Add(tabPageControl);
            DrawerTabControl = tabPageControl;
            Name = "FormCadastroAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alunos";
            tabPageControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabPageControl;
        private TabPage tabPageCadastro;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbCidade;
        private ReaLTaiizor.Controls.MaterialComboBox cbEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSenha;
        private ReaLTaiizor.Controls.MaterialButton btCancelar;
        private ReaLTaiizor.Controls.MaterialButton mbSalvar;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbDataNascimento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbMatricula;
        private TabPage tabPageConsulta;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ListView lvAlunos;
    }
}