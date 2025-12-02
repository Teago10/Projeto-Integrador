namespace GestaoCuidadores.View
{
    partial class FrmCadastroCuidador
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
            grbDadosCuidador = new GroupBox();
            lblQualificacao = new Label();
            cbxQualificacao = new ComboBox();
            lblCPF = new Label();
            txtCPF = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            grbDadosEndereco = new GroupBox();
            lblComplemento = new Label();
            txtComplemento = new TextBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            cbxEstado = new ComboBox();
            lblEstado = new Label();
            lblCidade = new Label();
            txtCidade = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            lblRua = new Label();
            txtRua = new TextBox();
            txtCEP = new TextBox();
            lblCEP = new Label();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnNovo = new Button();
            btnEditar = new Button();
            dgvListaCuidador = new DataGridView();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            grbListaCuidador = new GroupBox();
            grbDadosCuidador.SuspendLayout();
            grbDadosEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaCuidador).BeginInit();
            grbListaCuidador.SuspendLayout();
            SuspendLayout();
            // 
            // grbDadosCuidador
            // 
            grbDadosCuidador.Controls.Add(lblQualificacao);
            grbDadosCuidador.Controls.Add(cbxQualificacao);
            grbDadosCuidador.Controls.Add(lblCPF);
            grbDadosCuidador.Controls.Add(txtCPF);
            grbDadosCuidador.Controls.Add(lblTelefone);
            grbDadosCuidador.Controls.Add(txtTelefone);
            grbDadosCuidador.Controls.Add(lblEmail);
            grbDadosCuidador.Controls.Add(txtEmail);
            grbDadosCuidador.Controls.Add(lblNome);
            grbDadosCuidador.Controls.Add(txtNome);
            grbDadosCuidador.Controls.Add(txtCodigo);
            grbDadosCuidador.Controls.Add(lblCodigo);
            grbDadosCuidador.Location = new Point(8, 8);
            grbDadosCuidador.Name = "grbDadosCuidador";
            grbDadosCuidador.Size = new Size(784, 136);
            grbDadosCuidador.TabIndex = 0;
            grbDadosCuidador.TabStop = false;
            grbDadosCuidador.Text = "Dados do Cuidadores";
            // 
            // lblQualificacao
            // 
            lblQualificacao.AutoSize = true;
            lblQualificacao.Location = new Point(409, 72);
            lblQualificacao.Name = "lblQualificacao";
            lblQualificacao.Size = new Size(73, 15);
            lblQualificacao.TabIndex = 15;
            lblQualificacao.Text = "Qualificação";
            // 
            // cbxQualificacao
            // 
            cbxQualificacao.FormattingEnabled = true;
            cbxQualificacao.Items.AddRange(new object[] { "Enfermeiro(a) Geriátrico(a)", "Enfermeiro(a)", "Cuidadores de Idosos", "Médico", "Técnico de Infermagem", "Auxiliar de Enfermagem", "Cuidadores infantil (para pacientes com deficiência)" });
            cbxQualificacao.Location = new Point(408, 88);
            cbxQualificacao.Name = "cbxQualificacao";
            cbxQualificacao.Size = new Size(304, 23);
            cbxQualificacao.TabIndex = 14;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(209, 72);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 13;
            lblCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(208, 88);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(170, 23);
            txtCPF.TabIndex = 12;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(16, 72);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 11;
            lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(14, 88);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(170, 23);
            txtTelefone.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(491, 17);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(488, 33);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(289, 23);
            txtEmail.TabIndex = 8;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(134, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(133, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(339, 23);
            txtNome.TabIndex = 6;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(14, 35);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 5;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(14, 19);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "Código";
            // 
            // grbDadosEndereco
            // 
            grbDadosEndereco.Controls.Add(lblComplemento);
            grbDadosEndereco.Controls.Add(txtComplemento);
            grbDadosEndereco.Controls.Add(lblNumero);
            grbDadosEndereco.Controls.Add(txtNumero);
            grbDadosEndereco.Controls.Add(cbxEstado);
            grbDadosEndereco.Controls.Add(lblEstado);
            grbDadosEndereco.Controls.Add(lblCidade);
            grbDadosEndereco.Controls.Add(txtCidade);
            grbDadosEndereco.Controls.Add(lblBairro);
            grbDadosEndereco.Controls.Add(txtBairro);
            grbDadosEndereco.Controls.Add(lblRua);
            grbDadosEndereco.Controls.Add(txtRua);
            grbDadosEndereco.Controls.Add(txtCEP);
            grbDadosEndereco.Controls.Add(lblCEP);
            grbDadosEndereco.Location = new Point(8, 144);
            grbDadosEndereco.Name = "grbDadosEndereco";
            grbDadosEndereco.Size = new Size(784, 160);
            grbDadosEndereco.TabIndex = 1;
            grbDadosEndereco.TabStop = false;
            grbDadosEndereco.Text = "Dados do Endereço";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(137, 64);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 20;
            lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(136, 80);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(224, 23);
            txtComplemento.TabIndex = 19;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(8, 64);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 18;
            lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(8, 80);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(120, 23);
            txtNumero.TabIndex = 17;
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MS", "MT", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxEstado.Location = new Point(8, 128);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(128, 23);
            cbxEstado.TabIndex = 16;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(8, 111);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(366, 64);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 11;
            lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(366, 80);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(298, 23);
            txtCidade.TabIndex = 10;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(491, 18);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 9;
            lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(489, 33);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(224, 23);
            txtBairro.TabIndex = 8;
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(177, 18);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(27, 15);
            lblRua.TabIndex = 7;
            lblRua.Text = "Rua";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(176, 33);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(307, 23);
            txtRua.TabIndex = 6;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(8, 33);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(160, 23);
            txtCEP.TabIndex = 5;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(8, 18);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(28, 15);
            lblCEP.TabIndex = 4;
            lblCEP.Text = "CEP";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(128, 312);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(104, 24);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(352, 312);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(104, 24);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(14, 312);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(104, 24);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(240, 312);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(104, 24);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // dgvListaCuidador
            // 
            dgvListaCuidador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCuidador.Location = new Point(8, 16);
            dgvListaCuidador.Name = "dgvListaCuidador";
            dgvListaCuidador.Size = new Size(765, 144);
            dgvListaCuidador.TabIndex = 6;
            dgvListaCuidador.CellContentClick += dgvListaCuidador_CellContentClick;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(472, 312);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(208, 23);
            txtPesquisar.TabIndex = 20;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(688, 312);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(104, 24);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // grbListaCuidador
            // 
            grbListaCuidador.Controls.Add(dgvListaCuidador);
            grbListaCuidador.Location = new Point(8, 345);
            grbListaCuidador.Name = "grbListaCuidador";
            grbListaCuidador.Size = new Size(784, 167);
            grbListaCuidador.TabIndex = 22;
            grbListaCuidador.TabStop = false;
            grbListaCuidador.Text = "Lista de Cuidadores";
            // 
            // FrmCadastroCuidador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 518);
            Controls.Add(grbListaCuidador);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(grbDadosEndereco);
            Controls.Add(grbDadosCuidador);
            Name = "FrmCadastroCuidador";
            Text = "Cadastro Cuidadores";
            Load += FrmCadastroCuidador_Load;
            grbDadosCuidador.ResumeLayout(false);
            grbDadosCuidador.PerformLayout();
            grbDadosEndereco.ResumeLayout(false);
            grbDadosEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaCuidador).EndInit();
            grbListaCuidador.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosCuidador;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtTelefone;
        private Label lblCPF;
        private TextBox txtCPF;
        private Label lblTelefone;
        private Label lblQualificacao;
        private ComboBox cbxQualificacao;
        private GroupBox grbDadosEndereco;
        private Label lblEstado;
        private Label lblCidade;
        private TextBox txtCidade;
        private Label lblBairro;
        private TextBox txtBairro;
        private Label lblRua;
        private TextBox txtRua;
        private TextBox txtCEP;
        private Label lblCEP;
        private ComboBox cbxEstado;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnNovo;
        private Button btnEditar;
        private DataGridView dgvListaCuidador;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private GroupBox grbListaCuidador;
    }
}