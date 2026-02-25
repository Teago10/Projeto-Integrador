namespace GestaoCuidadores.View
{
    partial class FrmLogin
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
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblSenha = new Label();
            lblBemvindo = new Label();
            txtSenha = new TextBox();
            lblNaoPossuiConta = new Label();
            lnkCadastrar = new LinkLabel();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(104, 208);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(107, 31);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(64, 66);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 23);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "admin@sistema.com";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(17, 68);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(17, 120);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            // 
            // lblBemvindo
            // 
            lblBemvindo.AutoSize = true;
            lblBemvindo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemvindo.Location = new Point(112, 16);
            lblBemvindo.Name = "lblBemvindo";
            lblBemvindo.Size = new Size(86, 20);
            lblBemvindo.TabIndex = 4;
            lblBemvindo.Text = "Bem-vindo";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(64, 117);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(225, 23);
            txtSenha.TabIndex = 5;
            txtSenha.Text = "admin123";
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblNaoPossuiConta
            // 
            lblNaoPossuiConta.AutoSize = true;
            lblNaoPossuiConta.Location = new Point(62, 184);
            lblNaoPossuiConta.Name = "lblNaoPossuiConta";
            lblNaoPossuiConta.Size = new Size(107, 15);
            lblNaoPossuiConta.TabIndex = 6;
            lblNaoPossuiConta.Text = "Não possui conta ?";
            // 
            // lnkCadastrar
            // 
            lnkCadastrar.AutoSize = true;
            lnkCadastrar.Location = new Point(168, 184);
            lnkCadastrar.Name = "lnkCadastrar";
            lnkCadastrar.Size = new Size(57, 15);
            lnkCadastrar.TabIndex = 7;
            lnkCadastrar.TabStop = true;
            lnkCadastrar.Text = "Cadastrar";
            lnkCadastrar.LinkClicked += lnkCadastrar_LinkClicked;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 249);
            Controls.Add(lnkCadastrar);
            Controls.Add(lblNaoPossuiConta);
            Controls.Add(txtSenha);
            Controls.Add(lblBemvindo);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnEntrar);
            Name = "FrmLogin";
            Text = "Tela de Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblSenha;
        private Label lblBemvindo;
        private TextBox txtSenha;
        private Label lblNaoPossuiConta;
        private LinkLabel lnkCadastrar;
    }
}