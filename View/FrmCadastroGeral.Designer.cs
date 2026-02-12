namespace GestaoCuidadores.View
{
    partial class FrmCadastroGeral
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
            btnEntrar = new Button();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtConfirmacaoSenha = new TextBox();
            lblConfirmacaoSenha = new Label();
            lblSenha = new Label();
            lblBemvindo = new Label();
            lblPossuiConta = new Label();
            lnkEntrar = new LinkLabel();
            lblTipoUsuario = new Label();
            cbxTipoUsuario = new ComboBox();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(112, 376);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(104, 31);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(31, 78);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(24, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(24, 151);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(280, 23);
            txtSenha.TabIndex = 4;
            // 
            // txtConfirmacaoSenha
            // 
            txtConfirmacaoSenha.Location = new Point(24, 206);
            txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            txtConfirmacaoSenha.Size = new Size(280, 23);
            txtConfirmacaoSenha.TabIndex = 5;
            // 
            // lblConfirmacaoSenha
            // 
            lblConfirmacaoSenha.AutoSize = true;
            lblConfirmacaoSenha.Location = new Point(30, 189);
            lblConfirmacaoSenha.Name = "lblConfirmacaoSenha";
            lblConfirmacaoSenha.Size = new Size(104, 15);
            lblConfirmacaoSenha.TabIndex = 6;
            lblConfirmacaoSenha.Text = "Confirme a Senha:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(30, 134);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha:";
            // 
            // lblBemvindo
            // 
            lblBemvindo.AutoSize = true;
            lblBemvindo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemvindo.Location = new Point(120, 24);
            lblBemvindo.Name = "lblBemvindo";
            lblBemvindo.Size = new Size(118, 30);
            lblBemvindo.TabIndex = 9;
            lblBemvindo.Text = "Bem vindo";
            // 
            // lblPossuiConta
            // 
            lblPossuiConta.AutoSize = true;
            lblPossuiConta.Location = new Point(96, 344);
            lblPossuiConta.Name = "lblPossuiConta";
            lblPossuiConta.Size = new Size(95, 15);
            lblPossuiConta.TabIndex = 10;
            lblPossuiConta.Text = "Já possui conta ?";
            // 
            // lnkEntrar
            // 
            lnkEntrar.AutoSize = true;
            lnkEntrar.Location = new Point(189, 344);
            lnkEntrar.Name = "lnkEntrar";
            lnkEntrar.Size = new Size(38, 15);
            lnkEntrar.TabIndex = 11;
            lnkEntrar.TabStop = true;
            lnkEntrar.Text = "Entrar";
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Location = new Point(28, 245);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(92, 15);
            lblTipoUsuario.TabIndex = 13;
            lblTipoUsuario.Text = "Tipo de Usuário:";
            // 
            // cbxTipoUsuario
            // 
            cbxTipoUsuario.FormattingEnabled = true;
            cbxTipoUsuario.Items.AddRange(new object[] { "Cuidador", "Responsável" });
            cbxTipoUsuario.Location = new Point(24, 264);
            cbxTipoUsuario.Name = "cbxTipoUsuario";
            cbxTipoUsuario.Size = new Size(280, 23);
            cbxTipoUsuario.TabIndex = 14;
            // 
            // FrmCadastroGeral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 415);
            Controls.Add(cbxTipoUsuario);
            Controls.Add(lblTipoUsuario);
            Controls.Add(lnkEntrar);
            Controls.Add(lblPossuiConta);
            Controls.Add(lblBemvindo);
            Controls.Add(lblSenha);
            Controls.Add(lblConfirmacaoSenha);
            Controls.Add(txtConfirmacaoSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(btnEntrar);
            Name = "FrmCadastroGeral";
            Text = "Tela de cadastro de Usuário";
            Load += FrmCadastroGeral_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtConfirmacaoSenha;
        private Label lblConfirmacaoSenha;
        private Label lblSenha;
        private Label lblBemvindo;
        private Label lblPossuiConta;
        private LinkLabel lnkEntrar;
        private Label lblTipoUsuario;
        private ComboBox cbxTipoUsuario;
    }
}