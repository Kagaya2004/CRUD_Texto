namespace ProjetoCadastro
{
    partial class FormCadastroCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCurso));
            tabPageControl = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            tbDuracao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cbArea = new ReaLTaiizor.Controls.MaterialComboBox();
            cbPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            cbNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            tbCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btCancelar = new ReaLTaiizor.Controls.MaterialButton();
            mbSalvar = new ReaLTaiizor.Controls.MaterialButton();
            tbNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            lvCursos = new ListView();
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
            tabPageControl.Size = new Size(590, 302);
            tabPageControl.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(tbDuracao);
            tabPageCadastro.Controls.Add(cbArea);
            tabPageCadastro.Controls.Add(cbPeriodo);
            tabPageCadastro.Controls.Add(cbNivel);
            tabPageCadastro.Controls.Add(tbCodigo);
            tabPageCadastro.Controls.Add(btCancelar);
            tabPageCadastro.Controls.Add(mbSalvar);
            tabPageCadastro.Controls.Add(tbNome);
            tabPageCadastro.ImageKey = "Forms - Icon.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(582, 267);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // tbDuracao
            // 
            tbDuracao.AnimateReadOnly = false;
            tbDuracao.AutoCompleteMode = AutoCompleteMode.None;
            tbDuracao.AutoCompleteSource = AutoCompleteSource.None;
            tbDuracao.BackgroundImageLayout = ImageLayout.None;
            tbDuracao.CharacterCasing = CharacterCasing.Normal;
            tbDuracao.Depth = 0;
            tbDuracao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDuracao.HideSelection = true;
            tbDuracao.Hint = "Duração (Semestres)";
            tbDuracao.LeadingIcon = null;
            tbDuracao.Location = new Point(19, 149);
            tbDuracao.MaxLength = 32767;
            tbDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDuracao.Name = "tbDuracao";
            tbDuracao.PasswordChar = '\0';
            tbDuracao.PrefixSuffixText = null;
            tbDuracao.ReadOnly = false;
            tbDuracao.RightToLeft = RightToLeft.No;
            tbDuracao.SelectedText = "";
            tbDuracao.SelectionLength = 0;
            tbDuracao.SelectionStart = 0;
            tbDuracao.ShortcutsEnabled = true;
            tbDuracao.Size = new Size(265, 48);
            tbDuracao.TabIndex = 24;
            tbDuracao.TabStop = false;
            tbDuracao.TextAlign = HorizontalAlignment.Left;
            tbDuracao.TrailingIcon = null;
            tbDuracao.UseSystemPasswordChar = false;
            // 
            // cbArea
            // 
            cbArea.AutoResize = false;
            cbArea.BackColor = Color.FromArgb(255, 255, 255);
            cbArea.Depth = 0;
            cbArea.DrawMode = DrawMode.OwnerDrawVariable;
            cbArea.DropDownHeight = 174;
            cbArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbArea.DropDownWidth = 121;
            cbArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbArea.FormattingEnabled = true;
            cbArea.Hint = "Área";
            cbArea.IntegralHeight = false;
            cbArea.ItemHeight = 43;
            cbArea.Items.AddRange(new object[] { "Licenciatura", "Informática", "Indústria", "Administração" });
            cbArea.Location = new Point(290, 149);
            cbArea.MaxDropDownItems = 4;
            cbArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(265, 49);
            cbArea.StartIndex = 0;
            cbArea.TabIndex = 23;
            // 
            // cbPeriodo
            // 
            cbPeriodo.AutoResize = false;
            cbPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            cbPeriodo.Depth = 0;
            cbPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            cbPeriodo.DropDownHeight = 174;
            cbPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPeriodo.DropDownWidth = 121;
            cbPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbPeriodo.FormattingEnabled = true;
            cbPeriodo.Hint = "Período";
            cbPeriodo.IntegralHeight = false;
            cbPeriodo.ItemHeight = 43;
            cbPeriodo.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno", "Integral" });
            cbPeriodo.Location = new Point(290, 85);
            cbPeriodo.MaxDropDownItems = 4;
            cbPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbPeriodo.Name = "cbPeriodo";
            cbPeriodo.Size = new Size(265, 49);
            cbPeriodo.StartIndex = 0;
            cbPeriodo.TabIndex = 22;
            // 
            // cbNivel
            // 
            cbNivel.AutoResize = false;
            cbNivel.BackColor = Color.FromArgb(255, 255, 255);
            cbNivel.Depth = 0;
            cbNivel.DrawMode = DrawMode.OwnerDrawVariable;
            cbNivel.DropDownHeight = 174;
            cbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNivel.DropDownWidth = 121;
            cbNivel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbNivel.FormattingEnabled = true;
            cbNivel.Hint = "Nível de Curso";
            cbNivel.IntegralHeight = false;
            cbNivel.ItemHeight = 43;
            cbNivel.Items.AddRange(new object[] { "Técnico", "Superior" });
            cbNivel.Location = new Point(17, 85);
            cbNivel.MaxDropDownItems = 4;
            cbNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbNivel.Name = "cbNivel";
            cbNivel.Size = new Size(265, 49);
            cbNivel.StartIndex = 0;
            cbNivel.TabIndex = 6;
            // 
            // tbCodigo
            // 
            tbCodigo.AnimateReadOnly = false;
            tbCodigo.AutoCompleteMode = AutoCompleteMode.None;
            tbCodigo.AutoCompleteSource = AutoCompleteSource.None;
            tbCodigo.BackgroundImageLayout = ImageLayout.None;
            tbCodigo.CharacterCasing = CharacterCasing.Normal;
            tbCodigo.Depth = 0;
            tbCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCodigo.HideSelection = true;
            tbCodigo.Hint = "Código do Curso";
            tbCodigo.LeadingIcon = null;
            tbCodigo.Location = new Point(19, 17);
            tbCodigo.MaxLength = 32767;
            tbCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbCodigo.Name = "tbCodigo";
            tbCodigo.PasswordChar = '\0';
            tbCodigo.PrefixSuffixText = null;
            tbCodigo.ReadOnly = false;
            tbCodigo.RightToLeft = RightToLeft.No;
            tbCodigo.SelectedText = "";
            tbCodigo.SelectionLength = 0;
            tbCodigo.SelectionStart = 0;
            tbCodigo.ShortcutsEnabled = true;
            tbCodigo.Size = new Size(265, 48);
            tbCodigo.TabIndex = 10;
            tbCodigo.TabStop = false;
            tbCodigo.TextAlign = HorizontalAlignment.Left;
            tbCodigo.TrailingIcon = null;
            tbCodigo.UseSystemPasswordChar = false;
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
            btCancelar.Location = new Point(375, 224);
            btCancelar.Margin = new Padding(4, 6, 4, 6);
            btCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btCancelar.Name = "btCancelar";
            btCancelar.NoAccentTextColor = Color.Empty;
            btCancelar.Size = new Size(96, 36);
            btCancelar.TabIndex = 18;
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
            mbSalvar.Location = new Point(479, 224);
            mbSalvar.Margin = new Padding(4, 6, 4, 6);
            mbSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mbSalvar.Name = "mbSalvar";
            mbSalvar.NoAccentTextColor = Color.Empty;
            mbSalvar.Size = new Size(76, 36);
            mbSalvar.TabIndex = 19;
            mbSalvar.Text = "Salvar";
            mbSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mbSalvar.UseAccentColor = false;
            mbSalvar.UseVisualStyleBackColor = true;
            mbSalvar.Click += ClickSalvar;
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
            tbNome.Location = new Point(290, 17);
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
            tbNome.Size = new Size(265, 48);
            tbNome.TabIndex = 12;
            tbNome.TabStop = false;
            tbNome.TextAlign = HorizontalAlignment.Left;
            tbNome.TrailingIcon = null;
            tbNome.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(lvCursos);
            tabPageConsulta.ImageKey = "Search - Icon.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(582, 267);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(331, 229);
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
            btnEditar.Location = new Point(403, 229);
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
            btnExcluir.Location = new Point(482, 229);
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
            // lvCursos
            // 
            lvCursos.FullRowSelect = true;
            lvCursos.Location = new Point(3, 3);
            lvCursos.Name = "lvCursos";
            lvCursos.Size = new Size(576, 213);
            lvCursos.TabIndex = 0;
            lvCursos.UseCompatibleStateImageBehavior = false;
            lvCursos.View = View.Details;
            lvCursos.Enter += lvCursos_Enter;
            lvCursos.MouseDoubleClick += lvCursos_MouseDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Forms - Icon.png");
            imageList1.Images.SetKeyName(1, "Search - Icon.png");
            // 
            // FormCadastroCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 369);
            Controls.Add(tabPageControl);
            DrawerTabControl = tabPageControl;
            Name = "FormCadastroCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Curso";
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
        private TabPage tabPageConsulta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbCodigo;
        private ReaLTaiizor.Controls.MaterialButton btCancelar;
        private ReaLTaiizor.Controls.MaterialButton mbSalvar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbNome;
        private ReaLTaiizor.Controls.MaterialComboBox cbNivel;
        private ReaLTaiizor.Controls.MaterialComboBox cbPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox cbArea;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbDuracao;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ListView lvCursos;
    }
}