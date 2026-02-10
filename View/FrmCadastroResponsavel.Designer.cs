namespace GestaoCuidadores.View
{
    partial class FrmCadastroResponsavel
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
            btnExcluir = new Button();
            grbListaCuidador = new GroupBox();
            dgvListaResponsavel = new DataGridView();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            btnEditar = new Button();
            btnNovo = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
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
            grbDadosCuidador = new GroupBox();
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
            grbListaCuidador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaResponsavel).BeginInit();
            grbDadosEndereco.SuspendLayout();
            grbDadosCuidador.SuspendLayout();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(386, 299);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(88, 32);
            btnExcluir.TabIndex = 32;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // grbListaCuidador
            // 
            grbListaCuidador.Controls.Add(dgvListaResponsavel);
            grbListaCuidador.Location = new Point(8, 332);
            grbListaCuidador.Name = "grbListaCuidador";
            grbListaCuidador.Size = new Size(784, 167);
            grbListaCuidador.TabIndex = 31;
            grbListaCuidador.TabStop = false;
            grbListaCuidador.Text = "Lista de Cuidadores";
            // 
            // dgvListaResponsavel
            // 
            dgvListaResponsavel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaResponsavel.Location = new Point(8, 16);
            dgvListaResponsavel.Name = "dgvListaResponsavel";
            dgvListaResponsavel.Size = new Size(765, 144);
            dgvListaResponsavel.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(696, 299);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(96, 32);
            btnPesquisar.TabIndex = 30;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(480, 303);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(208, 23);
            txtPesquisar.TabIndex = 29;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(197, 299);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 32);
            btnEditar.TabIndex = 28;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(8, 299);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(90, 32);
            btnNovo.TabIndex = 27;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(292, 299);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 32);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Location = new Point(104, 299);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 32);
            btnSalvar.TabIndex = 25;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
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
            grbDadosEndereco.Location = new Point(8, 131);
            grbDadosEndereco.Name = "grbDadosEndereco";
            grbDadosEndereco.Size = new Size(784, 160);
            grbDadosEndereco.TabIndex = 24;
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
            txtComplemento.ReadOnly = true;
            txtComplemento.Size = new Size(224, 23);
            txtComplemento.TabIndex = 11;
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
            txtNumero.ReadOnly = true;
            txtNumero.Size = new Size(120, 23);
            txtNumero.TabIndex = 10;
            // 
            // cbxEstado
            // 
            cbxEstado.Enabled = false;
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MS", "MT", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxEstado.Location = new Point(8, 128);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(128, 23);
            cbxEstado.TabIndex = 13;
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
            txtCidade.ReadOnly = true;
            txtCidade.Size = new Size(298, 23);
            txtCidade.TabIndex = 12;
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
            txtBairro.ReadOnly = true;
            txtBairro.Size = new Size(224, 23);
            txtBairro.TabIndex = 9;
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
            txtRua.ReadOnly = true;
            txtRua.Size = new Size(307, 23);
            txtRua.TabIndex = 8;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(8, 33);
            txtCEP.Name = "txtCEP";
            txtCEP.ReadOnly = true;
            txtCEP.Size = new Size(160, 23);
            txtCEP.TabIndex = 7;
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
            // grbDadosCuidador
            // 
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
            grbDadosCuidador.Location = new Point(10, 3);
            grbDadosCuidador.Name = "grbDadosCuidador";
            grbDadosCuidador.Size = new Size(784, 120);
            grbDadosCuidador.TabIndex = 33;
            grbDadosCuidador.TabStop = false;
            grbDadosCuidador.Text = "Dados do Cuidadores";
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
            txtCPF.ReadOnly = true;
            txtCPF.Size = new Size(170, 23);
            txtCPF.TabIndex = 5;
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
            txtTelefone.ReadOnly = true;
            txtTelefone.Size = new Size(170, 23);
            txtTelefone.TabIndex = 4;
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
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(289, 23);
            txtEmail.TabIndex = 3;
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
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(339, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(14, 35);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
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
            // FrmCadastroResponsavel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 500);
            Controls.Add(grbDadosCuidador);
            Controls.Add(btnExcluir);
            Controls.Add(grbListaCuidador);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(grbDadosEndereco);
            Name = "FrmCadastroResponsavel";
            Text = "Cadastro do Responsavel";
            Load += FrmCadastroResponsavel_Load;
            grbListaCuidador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaResponsavel).EndInit();
            grbDadosEndereco.ResumeLayout(false);
            grbDadosEndereco.PerformLayout();
            grbDadosCuidador.ResumeLayout(false);
            grbDadosCuidador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private GroupBox grbListaCuidador;
        private DataGridView dgvListaResponsavel;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private Button btnEditar;
        private Button btnNovo;
        private Button btnCancelar;
        private Button btnSalvar;
        private GroupBox grbDadosEndereco;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private Label lblNumero;
        private TextBox txtNumero;
        private ComboBox cbxEstado;
        private Label lblEstado;
        private Label lblCidade;
        private TextBox txtCidade;
        private Label lblBairro;
        private TextBox txtBairro;
        private Label lblRua;
        private TextBox txtRua;
        private TextBox txtCEP;
        private Label lblCEP;
        private GroupBox grbDadosCuidador;
        private Label lblCPF;
        private TextBox txtCPF;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label lblCodigo;
    }
}