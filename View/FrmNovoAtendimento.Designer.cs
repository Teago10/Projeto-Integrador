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
            button1 = new Button();
            button2 = new Button();
            cbxResponsavel = new ComboBox();
            cbxPaciente = new ComboBox();
            cbxCuidador = new ComboBox();
            lblResponsavel = new Label();
            lblPaciente = new Label();
            lblCuidador = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            lblValor = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(135, 1021);
            button1.Name = "button1";
            button1.Size = new Size(225, 69);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(671, 1021);
            button2.Name = "button2";
            button2.Size = new Size(225, 69);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cbxResponsavel
            // 
            cbxResponsavel.FormattingEnabled = true;
            cbxResponsavel.Location = new Point(83, 114);
            cbxResponsavel.Name = "cbxResponsavel";
            cbxResponsavel.Size = new Size(687, 56);
            cbxResponsavel.TabIndex = 2;
            cbxResponsavel.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbxPaciente
            // 
            cbxPaciente.FormattingEnabled = true;
            cbxPaciente.Location = new Point(83, 316);
            cbxPaciente.Name = "cbxPaciente";
            cbxPaciente.Size = new Size(687, 56);
            cbxPaciente.TabIndex = 3;
            // 
            // cbxCuidador
            // 
            cbxCuidador.FormattingEnabled = true;
            cbxCuidador.Location = new Point(83, 490);
            cbxCuidador.Name = "cbxCuidador";
            cbxCuidador.Size = new Size(687, 56);
            cbxCuidador.TabIndex = 4;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Location = new Point(83, 53);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(215, 48);
            lblResponsavel.TabIndex = 5;
            lblResponsavel.Text = "Responsável";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Location = new Point(83, 253);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(153, 48);
            lblPaciente.TabIndex = 6;
            lblPaciente.Text = "Paciente";
            // 
            // lblCuidador
            // 
            lblCuidador.AutoSize = true;
            lblCuidador.Location = new Point(83, 430);
            lblCuidador.Name = "lblCuidador";
            lblCuidador.Size = new Size(165, 48);
            lblCuidador.TabIndex = 7;
            lblCuidador.Text = "Cuidador";
            lblCuidador.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(83, 660);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(687, 56);
            comboBox1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 899);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 55);
            textBox1.TabIndex = 9;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(83, 600);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(90, 48);
            lblValor.TabIndex = 10;
            lblValor.Text = "Tipo";
            // 
            // FrmNovoAtendimento
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 1175);
            Controls.Add(lblValor);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(lblCuidador);
            Controls.Add(lblPaciente);
            Controls.Add(lblResponsavel);
            Controls.Add(cbxCuidador);
            Controls.Add(cbxPaciente);
            Controls.Add(cbxResponsavel);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FrmNovoAtendimento";
            Text = "FrmNovoAtendimento";
            Load += FrmNovoAtendimento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox cbxResponsavel;
        private ComboBox cbxPaciente;
        private ComboBox cbxCuidador;
        private Label lblResponsavel;
        private Label lblPaciente;
        private Label lblCuidador;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label lblValor;
    }
}