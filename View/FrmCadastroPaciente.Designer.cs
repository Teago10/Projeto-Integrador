namespace GestaoCuidadores
{
    partial class FrmCadastroPaciente
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
            cbxEstados = new ComboBox();
            lblNome = new Label();
            txtNome = new TextBox();
            grbCadastrodePaciente = new GroupBox();
            lblusa_fraldas = new Label();
            pnlUsaFraldas = new Panel();
            rdbSim = new RadioButton();
            rdbNao = new RadioButton();
            txtDatadeNascimento = new TextBox();
            txtComorbidade = new TextBox();
            txtCondicaoFisica = new TextBox();
            txtMedicacao = new TextBox();
            txtHorarioMedicacao = new TextBox();
            lblDatadeNascimento = new Label();
            lblComorbidade = new Label();
            lblCondicaoFisica = new Label();
            lblmedicacao = new Label();
            lblHorarioMedicacao = new Label();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            lblNumero = new Label();
            lblrua = new Label();
            lblComplemento = new Label();
            grbEnderecoPaciente = new GroupBox();
            lblCEP = new Label();
            txtCEP = new TextBox();
            lblEstados = new Label();
            lblCidade = new Label();
            txtCidade = new TextBox();
            lblbairro = new Label();
            txtComplemento = new TextBox();
            txtbairro = new TextBox();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dgvListaPacientes = new DataGridView();
            btnNovo = new Button();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            grbListadePaciente = new GroupBox();
            btnCancelar = new Button();
            grbCadastrodePaciente.SuspendLayout();
            pnlUsaFraldas.SuspendLayout();
            grbEnderecoPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaPacientes).BeginInit();
            grbListadePaciente.SuspendLayout();
            SuspendLayout();
            // 
            // cbxEstados
            // 
            cbxEstados.FormattingEnabled = true;
            cbxEstados.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MS", "MT", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxEstados.Location = new Point(424, 96);
            cbxEstados.Name = "cbxEstados";
            cbxEstados.Size = new Size(121, 23);
            cbxEstados.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(16, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(16, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(264, 23);
            txtNome.TabIndex = 2;
            // 
            // grbCadastrodePaciente
            // 
            grbCadastrodePaciente.Controls.Add(lblusa_fraldas);
            grbCadastrodePaciente.Controls.Add(pnlUsaFraldas);
            grbCadastrodePaciente.Controls.Add(txtDatadeNascimento);
            grbCadastrodePaciente.Controls.Add(txtComorbidade);
            grbCadastrodePaciente.Controls.Add(txtCondicaoFisica);
            grbCadastrodePaciente.Controls.Add(txtMedicacao);
            grbCadastrodePaciente.Controls.Add(txtHorarioMedicacao);
            grbCadastrodePaciente.Controls.Add(lblDatadeNascimento);
            grbCadastrodePaciente.Controls.Add(lblComorbidade);
            grbCadastrodePaciente.Controls.Add(lblCondicaoFisica);
            grbCadastrodePaciente.Controls.Add(lblmedicacao);
            grbCadastrodePaciente.Controls.Add(lblHorarioMedicacao);
            grbCadastrodePaciente.Controls.Add(lblNome);
            grbCadastrodePaciente.Controls.Add(txtNome);
            grbCadastrodePaciente.Location = new Point(8, 16);
            grbCadastrodePaciente.Name = "grbCadastrodePaciente";
            grbCadastrodePaciente.Size = new Size(752, 136);
            grbCadastrodePaciente.TabIndex = 3;
            grbCadastrodePaciente.TabStop = false;
            grbCadastrodePaciente.Text = "Cadastro de pacientes";
            // 
            // lblusa_fraldas
            // 
            lblusa_fraldas.AutoSize = true;
            lblusa_fraldas.Location = new Point(216, 72);
            lblusa_fraldas.Name = "lblusa_fraldas";
            lblusa_fraldas.Size = new Size(59, 15);
            lblusa_fraldas.TabIndex = 22;
            lblusa_fraldas.Text = "Usa fralda";
            lblusa_fraldas.Click += label1_Click;
            // 
            // pnlUsaFraldas
            // 
            pnlUsaFraldas.Controls.Add(rdbSim);
            pnlUsaFraldas.Controls.Add(rdbNao);
            pnlUsaFraldas.Location = new Point(208, 80);
            pnlUsaFraldas.Name = "pnlUsaFraldas";
            pnlUsaFraldas.Size = new Size(112, 32);
            pnlUsaFraldas.TabIndex = 21;
            // 
            // rdbSim
            // 
            rdbSim.AutoSize = true;
            rdbSim.Location = new Point(8, 8);
            rdbSim.Name = "rdbSim";
            rdbSim.Size = new Size(45, 19);
            rdbSim.TabIndex = 18;
            rdbSim.TabStop = true;
            rdbSim.Text = "Sim";
            rdbSim.UseVisualStyleBackColor = true;
            // 
            // rdbNao
            // 
            rdbNao.AutoSize = true;
            rdbNao.Location = new Point(64, 8);
            rdbNao.Name = "rdbNao";
            rdbNao.Size = new Size(47, 19);
            rdbNao.TabIndex = 19;
            rdbNao.TabStop = true;
            rdbNao.Text = "Não";
            rdbNao.UseVisualStyleBackColor = true;
            // 
            // txtDatadeNascimento
            // 
            txtDatadeNascimento.Location = new Point(304, 40);
            txtDatadeNascimento.Name = "txtDatadeNascimento";
            txtDatadeNascimento.Size = new Size(136, 23);
            txtDatadeNascimento.TabIndex = 17;
            // 
            // txtComorbidade
            // 
            txtComorbidade.Location = new Point(456, 40);
            txtComorbidade.Name = "txtComorbidade";
            txtComorbidade.Size = new Size(264, 23);
            txtComorbidade.TabIndex = 16;
            // 
            // txtCondicaoFisica
            // 
            txtCondicaoFisica.Location = new Point(16, 88);
            txtCondicaoFisica.Name = "txtCondicaoFisica";
            txtCondicaoFisica.Size = new Size(184, 23);
            txtCondicaoFisica.TabIndex = 15;
            // 
            // txtMedicacao
            // 
            txtMedicacao.Location = new Point(336, 88);
            txtMedicacao.Name = "txtMedicacao";
            txtMedicacao.Size = new Size(232, 23);
            txtMedicacao.TabIndex = 12;
            // 
            // txtHorarioMedicacao
            // 
            txtHorarioMedicacao.Location = new Point(584, 88);
            txtHorarioMedicacao.Name = "txtHorarioMedicacao";
            txtHorarioMedicacao.Size = new Size(136, 23);
            txtHorarioMedicacao.TabIndex = 11;
            // 
            // lblDatadeNascimento
            // 
            lblDatadeNascimento.AutoSize = true;
            lblDatadeNascimento.Location = new Point(304, 24);
            lblDatadeNascimento.Name = "lblDatadeNascimento";
            lblDatadeNascimento.Size = new Size(114, 15);
            lblDatadeNascimento.TabIndex = 10;
            lblDatadeNascimento.Text = "Data de Nascimento";
            // 
            // lblComorbidade
            // 
            lblComorbidade.AutoSize = true;
            lblComorbidade.Location = new Point(456, 24);
            lblComorbidade.Name = "lblComorbidade";
            lblComorbidade.Size = new Size(80, 15);
            lblComorbidade.TabIndex = 9;
            lblComorbidade.Text = "Comorbidade";
            // 
            // lblCondicaoFisica
            // 
            lblCondicaoFisica.AutoSize = true;
            lblCondicaoFisica.Location = new Point(16, 72);
            lblCondicaoFisica.Name = "lblCondicaoFisica";
            lblCondicaoFisica.Size = new Size(90, 15);
            lblCondicaoFisica.TabIndex = 8;
            lblCondicaoFisica.Text = "Condição Fisica";
            // 
            // lblmedicacao
            // 
            lblmedicacao.AutoSize = true;
            lblmedicacao.Location = new Point(336, 72);
            lblmedicacao.Name = "lblmedicacao";
            lblmedicacao.Size = new Size(65, 15);
            lblmedicacao.TabIndex = 6;
            lblmedicacao.Text = "Medicação";
            // 
            // lblHorarioMedicacao
            // 
            lblHorarioMedicacao.AutoSize = true;
            lblHorarioMedicacao.Location = new Point(584, 72);
            lblHorarioMedicacao.Name = "lblHorarioMedicacao";
            lblHorarioMedicacao.Size = new Size(108, 15);
            lblHorarioMedicacao.TabIndex = 5;
            lblHorarioMedicacao.Text = "Horario Medicação";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(16, 48);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(264, 23);
            txtRua.TabIndex = 14;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(296, 48);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(80, 23);
            txtNumero.TabIndex = 13;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(296, 32);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 7;
            lblNumero.Text = "Numero";
            // 
            // lblrua
            // 
            lblrua.AutoSize = true;
            lblrua.Location = new Point(16, 32);
            lblrua.Name = "lblrua";
            lblrua.Size = new Size(27, 15);
            lblrua.TabIndex = 4;
            lblrua.Text = "Rua";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(400, 32);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 3;
            lblComplemento.Text = "Complemento";
            // 
            // grbEnderecoPaciente
            // 
            grbEnderecoPaciente.Controls.Add(lblCEP);
            grbEnderecoPaciente.Controls.Add(txtCEP);
            grbEnderecoPaciente.Controls.Add(lblEstados);
            grbEnderecoPaciente.Controls.Add(lblCidade);
            grbEnderecoPaciente.Controls.Add(txtCidade);
            grbEnderecoPaciente.Controls.Add(lblbairro);
            grbEnderecoPaciente.Controls.Add(txtComplemento);
            grbEnderecoPaciente.Controls.Add(txtNumero);
            grbEnderecoPaciente.Controls.Add(txtbairro);
            grbEnderecoPaciente.Controls.Add(lblNumero);
            grbEnderecoPaciente.Controls.Add(txtRua);
            grbEnderecoPaciente.Controls.Add(lblrua);
            grbEnderecoPaciente.Controls.Add(lblComplemento);
            grbEnderecoPaciente.Controls.Add(cbxEstados);
            grbEnderecoPaciente.Location = new Point(16, 176);
            grbEnderecoPaciente.Name = "grbEnderecoPaciente";
            grbEnderecoPaciente.Size = new Size(744, 144);
            grbEnderecoPaciente.TabIndex = 15;
            grbEnderecoPaciente.TabStop = false;
            grbEnderecoPaciente.Text = "Endereço Paciente";
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(560, 80);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(28, 15);
            lblCEP.TabIndex = 22;
            lblCEP.Text = "CEP";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(560, 96);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(120, 23);
            txtCEP.TabIndex = 21;
            // 
            // lblEstados
            // 
            lblEstados.AutoSize = true;
            lblEstados.Location = new Point(424, 80);
            lblEstados.Name = "lblEstados";
            lblEstados.Size = new Size(47, 15);
            lblEstados.TabIndex = 20;
            lblEstados.Text = "Estados";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(248, 80);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 19;
            lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(248, 96);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(160, 23);
            txtCidade.TabIndex = 15;
            // 
            // lblbairro
            // 
            lblbairro.AutoSize = true;
            lblbairro.Location = new Point(16, 80);
            lblbairro.Name = "lblbairro";
            lblbairro.Size = new Size(38, 15);
            lblbairro.TabIndex = 18;
            lblbairro.Text = "Bairro";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(400, 48);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(256, 23);
            txtComplemento.TabIndex = 17;
            // 
            // txtbairro
            // 
            txtbairro.Location = new Point(16, 96);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(216, 23);
            txtbairro.TabIndex = 16;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(118, 328);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(93, 34);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(213, 328);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(93, 34);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(402, 328);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(97, 34);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvListaPacientes
            // 
            dgvListaPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaPacientes.Location = new Point(8, 24);
            dgvListaPacientes.Name = "dgvListaPacientes";
            dgvListaPacientes.Size = new Size(718, 125);
            dgvListaPacientes.TabIndex = 19;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(16, 328);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(99, 34);
            btnNovo.TabIndex = 20;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(670, 328);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(92, 34);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(500, 334);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(166, 23);
            txtPesquisar.TabIndex = 23;
            // 
            // grbListadePaciente
            // 
            grbListadePaciente.Controls.Add(dgvListaPacientes);
            grbListadePaciente.Location = new Point(16, 368);
            grbListadePaciente.Name = "grbListadePaciente";
            grbListadePaciente.Size = new Size(744, 160);
            grbListadePaciente.TabIndex = 24;
            grbListadePaciente.TabStop = false;
            grbListadePaciente.Text = "Lista de Paciente";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(308, 328);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 34);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 537);
            Controls.Add(btnCancelar);
            Controls.Add(grbListadePaciente);
            Controls.Add(txtPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(grbEnderecoPaciente);
            Controls.Add(grbCadastrodePaciente);
            Name = "FrmCadastroPaciente";
            Text = "Cadastro de Paciente";
            Load += Cadastro_de_Paciente_Load;
            grbCadastrodePaciente.ResumeLayout(false);
            grbCadastrodePaciente.PerformLayout();
            pnlUsaFraldas.ResumeLayout(false);
            pnlUsaFraldas.PerformLayout();
            grbEnderecoPaciente.ResumeLayout(false);
            grbEnderecoPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaPacientes).EndInit();
            grbListadePaciente.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxEstados;
        private Label lblNome;
        private TextBox txtNome;
        private GroupBox grbCadastrodePaciente;
        private TextBox txtDatadeNascimento;
        private TextBox txtComorbidade;
        private TextBox txtCondicaoFisica;
        private TextBox txtRua;
        private TextBox txtNumero;
        private TextBox txtMedicacao;
        private TextBox txtHorarioMedicacao;
        private Label lblDatadeNascimento;
        private Label lblComorbidade;
        private Label lblCondicaoFisica;
        private Label lblNumero;
        private Label lblmedicacao;
        private Label lblHorarioMedicacao;
        private Label lblrua;
        private Label lblComplemento;
        private RadioButton rdbNao;
        private RadioButton rdbSim;
        private Panel pnlUsaFraldas;
        private Label lblusa_fraldas;
        private GroupBox grbEnderecoPaciente;
        private Label lblEstados;
        private Label lblCidade;
        private Label lblbairro;
        private TextBox txtComplemento;
        private TextBox txtbairro;
        private TextBox txtCidade;
        private Label lblCEP;
        private TextBox txtCEP;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dgvListaPacientes;
        private Button btnNovo;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private GroupBox grbListadePaciente;
        private Button btnCancelar;
    }
}