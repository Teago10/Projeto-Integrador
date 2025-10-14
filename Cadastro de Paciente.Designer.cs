namespace GestaoCuidadores
{
    partial class Cadastro_de_Paciente
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
            cbxestados = new ComboBox();
            lblNome = new Label();
            txtNome = new TextBox();
            grbCadastrodepaciente = new GroupBox();
            lblusa_fraldas = new Label();
            pnlusafraldas = new Panel();
            rdbsim = new RadioButton();
            rdbnao = new RadioButton();
            txtDatadeNascimento = new TextBox();
            txtComorbidade = new TextBox();
            txtcondicaofisica = new TextBox();
            txtMedicacao = new TextBox();
            txthorariomedicacao = new TextBox();
            lblDatadeNascimento = new Label();
            lblComorbidade = new Label();
            lblcondicaofisica = new Label();
            lblmedicacao = new Label();
            lblhorariomedicacao = new Label();
            txtrua = new TextBox();
            txtnumero = new TextBox();
            lblnumero = new Label();
            lblrua = new Label();
            lblcomplemento = new Label();
            grbEnderecoPaciente = new GroupBox();
            lblcep = new Label();
            txtcep = new TextBox();
            lblestados = new Label();
            lblcidade = new Label();
            txtcidade = new TextBox();
            lblbairro = new Label();
            txtcomplemento = new TextBox();
            txtbairro = new TextBox();
            btnsalvar = new Button();
            btneditar = new Button();
            btnexcluir = new Button();
            dgvlistadepaciente = new DataGridView();
            btnnovo = new Button();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            grblistadepaciente = new GroupBox();
            grbCadastrodepaciente.SuspendLayout();
            pnlusafraldas.SuspendLayout();
            grbEnderecoPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlistadepaciente).BeginInit();
            grblistadepaciente.SuspendLayout();
            SuspendLayout();
            // 
            // cbxestados
            // 
            cbxestados.FormattingEnabled = true;
            cbxestados.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MS", "MT", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxestados.Location = new Point(424, 96);
            cbxestados.Name = "cbxestados";
            cbxestados.Size = new Size(121, 23);
            cbxestados.TabIndex = 0;
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
            // grbCadastrodepaciente
            // 
            grbCadastrodepaciente.Controls.Add(lblusa_fraldas);
            grbCadastrodepaciente.Controls.Add(pnlusafraldas);
            grbCadastrodepaciente.Controls.Add(txtDatadeNascimento);
            grbCadastrodepaciente.Controls.Add(txtComorbidade);
            grbCadastrodepaciente.Controls.Add(txtcondicaofisica);
            grbCadastrodepaciente.Controls.Add(txtMedicacao);
            grbCadastrodepaciente.Controls.Add(txthorariomedicacao);
            grbCadastrodepaciente.Controls.Add(lblDatadeNascimento);
            grbCadastrodepaciente.Controls.Add(lblComorbidade);
            grbCadastrodepaciente.Controls.Add(lblcondicaofisica);
            grbCadastrodepaciente.Controls.Add(lblmedicacao);
            grbCadastrodepaciente.Controls.Add(lblhorariomedicacao);
            grbCadastrodepaciente.Controls.Add(lblNome);
            grbCadastrodepaciente.Controls.Add(txtNome);
            grbCadastrodepaciente.Location = new Point(8, 16);
            grbCadastrodepaciente.Name = "grbCadastrodepaciente";
            grbCadastrodepaciente.Size = new Size(752, 136);
            grbCadastrodepaciente.TabIndex = 3;
            grbCadastrodepaciente.TabStop = false;
            grbCadastrodepaciente.Text = "Cadastro de pacientes";
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
            // pnlusafraldas
            // 
            pnlusafraldas.Controls.Add(rdbsim);
            pnlusafraldas.Controls.Add(rdbnao);
            pnlusafraldas.Location = new Point(208, 80);
            pnlusafraldas.Name = "pnlusafraldas";
            pnlusafraldas.Size = new Size(112, 32);
            pnlusafraldas.TabIndex = 21;
            // 
            // rdbsim
            // 
            rdbsim.AutoSize = true;
            rdbsim.Location = new Point(8, 8);
            rdbsim.Name = "rdbsim";
            rdbsim.Size = new Size(45, 19);
            rdbsim.TabIndex = 18;
            rdbsim.TabStop = true;
            rdbsim.Text = "Sim";
            rdbsim.UseVisualStyleBackColor = true;
            // 
            // rdbnao
            // 
            rdbnao.AutoSize = true;
            rdbnao.Location = new Point(64, 8);
            rdbnao.Name = "rdbnao";
            rdbnao.Size = new Size(47, 19);
            rdbnao.TabIndex = 19;
            rdbnao.TabStop = true;
            rdbnao.Text = "Não";
            rdbnao.UseVisualStyleBackColor = true;
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
            // txtcondicaofisica
            // 
            txtcondicaofisica.Location = new Point(16, 88);
            txtcondicaofisica.Name = "txtcondicaofisica";
            txtcondicaofisica.Size = new Size(184, 23);
            txtcondicaofisica.TabIndex = 15;
            // 
            // txtMedicacao
            // 
            txtMedicacao.Location = new Point(336, 88);
            txtMedicacao.Name = "txtMedicacao";
            txtMedicacao.Size = new Size(232, 23);
            txtMedicacao.TabIndex = 12;
            // 
            // txthorariomedicacao
            // 
            txthorariomedicacao.Location = new Point(584, 88);
            txthorariomedicacao.Name = "txthorariomedicacao";
            txthorariomedicacao.Size = new Size(136, 23);
            txthorariomedicacao.TabIndex = 11;
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
            // lblcondicaofisica
            // 
            lblcondicaofisica.AutoSize = true;
            lblcondicaofisica.Location = new Point(16, 72);
            lblcondicaofisica.Name = "lblcondicaofisica";
            lblcondicaofisica.Size = new Size(90, 15);
            lblcondicaofisica.TabIndex = 8;
            lblcondicaofisica.Text = "Condição Fisica";
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
            // lblhorariomedicacao
            // 
            lblhorariomedicacao.AutoSize = true;
            lblhorariomedicacao.Location = new Point(584, 72);
            lblhorariomedicacao.Name = "lblhorariomedicacao";
            lblhorariomedicacao.Size = new Size(108, 15);
            lblhorariomedicacao.TabIndex = 5;
            lblhorariomedicacao.Text = "Horario Medicação";
            // 
            // txtrua
            // 
            txtrua.Location = new Point(16, 48);
            txtrua.Name = "txtrua";
            txtrua.Size = new Size(264, 23);
            txtrua.TabIndex = 14;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(296, 48);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(80, 23);
            txtnumero.TabIndex = 13;
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(296, 32);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(51, 15);
            lblnumero.TabIndex = 7;
            lblnumero.Text = "Numero";
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
            // lblcomplemento
            // 
            lblcomplemento.AutoSize = true;
            lblcomplemento.Location = new Point(400, 32);
            lblcomplemento.Name = "lblcomplemento";
            lblcomplemento.Size = new Size(84, 15);
            lblcomplemento.TabIndex = 3;
            lblcomplemento.Text = "Complemento";
            // 
            // grbEnderecoPaciente
            // 
            grbEnderecoPaciente.Controls.Add(lblcep);
            grbEnderecoPaciente.Controls.Add(txtcep);
            grbEnderecoPaciente.Controls.Add(lblestados);
            grbEnderecoPaciente.Controls.Add(lblcidade);
            grbEnderecoPaciente.Controls.Add(txtcidade);
            grbEnderecoPaciente.Controls.Add(lblbairro);
            grbEnderecoPaciente.Controls.Add(txtcomplemento);
            grbEnderecoPaciente.Controls.Add(txtnumero);
            grbEnderecoPaciente.Controls.Add(txtbairro);
            grbEnderecoPaciente.Controls.Add(lblnumero);
            grbEnderecoPaciente.Controls.Add(txtrua);
            grbEnderecoPaciente.Controls.Add(lblrua);
            grbEnderecoPaciente.Controls.Add(lblcomplemento);
            grbEnderecoPaciente.Controls.Add(cbxestados);
            grbEnderecoPaciente.Location = new Point(16, 176);
            grbEnderecoPaciente.Name = "grbEnderecoPaciente";
            grbEnderecoPaciente.Size = new Size(744, 144);
            grbEnderecoPaciente.TabIndex = 15;
            grbEnderecoPaciente.TabStop = false;
            grbEnderecoPaciente.Text = "Endereço Paciente";
            // 
            // lblcep
            // 
            lblcep.AutoSize = true;
            lblcep.Location = new Point(560, 80);
            lblcep.Name = "lblcep";
            lblcep.Size = new Size(28, 15);
            lblcep.TabIndex = 22;
            lblcep.Text = "CEP";
            // 
            // txtcep
            // 
            txtcep.Location = new Point(560, 96);
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(120, 23);
            txtcep.TabIndex = 21;
            // 
            // lblestados
            // 
            lblestados.AutoSize = true;
            lblestados.Location = new Point(424, 80);
            lblestados.Name = "lblestados";
            lblestados.Size = new Size(47, 15);
            lblestados.TabIndex = 20;
            lblestados.Text = "Estados";
            // 
            // lblcidade
            // 
            lblcidade.AutoSize = true;
            lblcidade.Location = new Point(248, 80);
            lblcidade.Name = "lblcidade";
            lblcidade.Size = new Size(44, 15);
            lblcidade.TabIndex = 19;
            lblcidade.Text = "Cidade";
            // 
            // txtcidade
            // 
            txtcidade.Location = new Point(248, 96);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(160, 23);
            txtcidade.TabIndex = 15;
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
            // txtcomplemento
            // 
            txtcomplemento.Location = new Point(400, 48);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.Size = new Size(256, 23);
            txtcomplemento.TabIndex = 17;
            // 
            // txtbairro
            // 
            txtbairro.Location = new Point(16, 96);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(216, 23);
            txtbairro.TabIndex = 16;
            // 
            // btnsalvar
            // 
            btnsalvar.Location = new Point(16, 328);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(112, 23);
            btnsalvar.TabIndex = 16;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(136, 328);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(112, 23);
            btneditar.TabIndex = 17;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(256, 328);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(112, 23);
            btnexcluir.TabIndex = 18;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            // 
            // dgvlistadepaciente
            // 
            dgvlistadepaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlistadepaciente.Location = new Point(8, 24);
            dgvlistadepaciente.Name = "dgvlistadepaciente";
            dgvlistadepaciente.Size = new Size(718, 125);
            dgvlistadepaciente.TabIndex = 19;
            // 
            // btnnovo
            // 
            btnnovo.Location = new Point(376, 328);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(112, 23);
            btnnovo.TabIndex = 20;
            btnnovo.Text = "Novo";
            btnnovo.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(496, 328);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(112, 23);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(608, 328);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(152, 23);
            txtPesquisar.TabIndex = 23;
            // 
            // grblistadepaciente
            // 
            grblistadepaciente.Controls.Add(dgvlistadepaciente);
            grblistadepaciente.Location = new Point(16, 368);
            grblistadepaciente.Name = "grblistadepaciente";
            grblistadepaciente.Size = new Size(744, 160);
            grblistadepaciente.TabIndex = 24;
            grblistadepaciente.TabStop = false;
            grblistadepaciente.Text = "Lista de Paciente";
            // 
            // Cadastro_de_Paciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 537);
            Controls.Add(grblistadepaciente);
            Controls.Add(txtPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnnovo);
            Controls.Add(btnexcluir);
            Controls.Add(btneditar);
            Controls.Add(btnsalvar);
            Controls.Add(grbEnderecoPaciente);
            Controls.Add(grbCadastrodepaciente);
            Name = "Cadastro_de_Paciente";
            Text = "Cadastro_de_Paciente";
            Load += Cadastro_de_Paciente_Load;
            grbCadastrodepaciente.ResumeLayout(false);
            grbCadastrodepaciente.PerformLayout();
            pnlusafraldas.ResumeLayout(false);
            pnlusafraldas.PerformLayout();
            grbEnderecoPaciente.ResumeLayout(false);
            grbEnderecoPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlistadepaciente).EndInit();
            grblistadepaciente.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxestados;
        private Label lblNome;
        private TextBox txtNome;
        private GroupBox grbCadastrodepaciente;
        private TextBox txtDatadeNascimento;
        private TextBox txtComorbidade;
        private TextBox txtcondicaofisica;
        private TextBox txtrua;
        private TextBox txtnumero;
        private TextBox txtMedicacao;
        private TextBox txthorariomedicacao;
        private Label lblDatadeNascimento;
        private Label lblComorbidade;
        private Label lblcondicaofisica;
        private Label lblnumero;
        private Label lblmedicacao;
        private Label lblhorariomedicacao;
        private Label lblrua;
        private Label lblcomplemento;
        private RadioButton rdbnao;
        private RadioButton rdbsim;
        private Panel pnlusafraldas;
        private Label lblusa_fraldas;
        private GroupBox grbEnderecoPaciente;
        private Label lblestados;
        private Label lblcidade;
        private Label lblbairro;
        private TextBox txtcomplemento;
        private TextBox txtbairro;
        private TextBox txtcidade;
        private Label lblcep;
        private TextBox txtcep;
        private Button btnsalvar;
        private Button btneditar;
        private Button btnexcluir;
        private DataGridView dgvlistadepaciente;
        private Button btnnovo;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private GroupBox grblistadepaciente;
    }
}