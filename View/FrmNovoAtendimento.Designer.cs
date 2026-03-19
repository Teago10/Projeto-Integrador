namespace GestaoCuidadores.View
{
    partial class FrmNovoAtendimento
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
            btnSalvar = new Button();
            btnCancelar = new Button();
            cbxPaciente = new ComboBox();
            cbxCuidador = new ComboBox();
            lblResponsavel = new Label();
            lblPaciente = new Label();
            lblCuidador = new Label();
            comboBox1 = new ComboBox();
            lblValor = new Label();
            txtResponsavel = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(29, 365);
            btnSalvar.Margin = new Padding(1);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 32);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(224, 365);
            btnCancelar.Margin = new Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 32);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbxPaciente
            // 
            cbxPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPaciente.FormattingEnabled = true;
            cbxPaciente.Location = new Point(29, 101);
            cbxPaciente.Margin = new Padding(1);
            cbxPaciente.Name = "cbxPaciente";
            cbxPaciente.Size = new Size(285, 23);
            cbxPaciente.TabIndex = 3;
            cbxPaciente.SelectedIndexChanged += cbxPaciente_SelectedIndexChanged;
            // 
            // cbxCuidador
            // 
            cbxCuidador.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCuidador.FormattingEnabled = true;
            cbxCuidador.Location = new Point(29, 169);
            cbxCuidador.Margin = new Padding(1);
            cbxCuidador.Name = "cbxCuidador";
            cbxCuidador.Size = new Size(285, 23);
            cbxCuidador.TabIndex = 4;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Location = new Point(29, 24);
            lblResponsavel.Margin = new Padding(1, 0, 1, 0);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(72, 15);
            lblResponsavel.TabIndex = 5;
            lblResponsavel.Text = "Responsável";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Location = new Point(29, 81);
            lblPaciente.Margin = new Padding(1, 0, 1, 0);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(52, 15);
            lblPaciente.TabIndex = 6;
            lblPaciente.Text = "Paciente";
            // 
            // lblCuidador
            // 
            lblCuidador.AutoSize = true;
            lblCuidador.Location = new Point(29, 150);
            lblCuidador.Margin = new Padding(1, 0, 1, 0);
            lblCuidador.Name = "lblCuidador";
            lblCuidador.Size = new Size(56, 15);
            lblCuidador.TabIndex = 7;
            lblCuidador.Text = "Cuidador";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Diurno", "", "", "Noturno", "", "", "12h", "", "", "24h" });
            comboBox1.Location = new Point(29, 227);
            comboBox1.Margin = new Padding(1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 23);
            comboBox1.TabIndex = 8;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(29, 209);
            lblValor.Margin = new Padding(1, 0, 1, 0);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(31, 15);
            lblValor.TabIndex = 10;
            lblValor.Text = "Tipo";
            // 
            // txtResponsavel
            // 
            txtResponsavel.Location = new Point(29, 42);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(285, 23);
            txtResponsavel.TabIndex = 11;
            // 
            // FrmNovoAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 430);
            Controls.Add(txtResponsavel);
            Controls.Add(lblValor);
            Controls.Add(comboBox1);
            Controls.Add(lblCuidador);
            Controls.Add(lblPaciente);
            Controls.Add(lblResponsavel);
            Controls.Add(cbxCuidador);
            Controls.Add(cbxPaciente);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Margin = new Padding(1);
            Name = "FrmNovoAtendimento";
            Text = "Novo Atendimento";
            Load += FrmNovoAtendimento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnCancelar;
        private ComboBox cbxPaciente;
        private ComboBox cbxCuidador;
        private Label lblResponsavel;
        private Label lblPaciente;
        private Label lblCuidador;
        private ComboBox comboBox1;
        private Label lblValor;
        private TextBox txtResponsavel;
    }
}