namespace GestaoCuidadores.View
{
    partial class FrmAvalicao
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
            lblNomeResp = new Label();
            lblNomeCuid = new Label();
            cbxNota = new ComboBox();
            txtComentario = new TextBox();
            lblNota = new Label();
            label2 = new Label();
            cbxNomeResponsavel = new ComboBox();
            cbxNomeCuidador = new ComboBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblNomeResp
            // 
            lblNomeResp.AutoSize = true;
            lblNomeResp.Location = new Point(31, 61);
            lblNomeResp.Name = "lblNomeResp";
            lblNomeResp.Size = new Size(111, 15);
            lblNomeResp.TabIndex = 2;
            lblNomeResp.Text = "Nome Responsavel:";
            // 
            // lblNomeCuid
            // 
            lblNomeCuid.AutoSize = true;
            lblNomeCuid.Location = new Point(31, 130);
            lblNomeCuid.Name = "lblNomeCuid";
            lblNomeCuid.Size = new Size(95, 15);
            lblNomeCuid.TabIndex = 3;
            lblNomeCuid.Text = "Nome Cuidador:";
            // 
            // cbxNota
            // 
            cbxNota.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNota.FormattingEnabled = true;
            cbxNota.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbxNota.Location = new Point(31, 216);
            cbxNota.Name = "cbxNota";
            cbxNota.Size = new Size(121, 23);
            cbxNota.TabIndex = 5;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(31, 280);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(306, 148);
            txtComentario.TabIndex = 6;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(31, 198);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(101, 15);
            lblNota.TabIndex = 7;
            lblNota.Text = "Avalie o Cuidador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 262);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 8;
            label2.Text = "Deixe um comentario";
            // 
            // cbxNomeResponsavel
            // 
            cbxNomeResponsavel.DisplayMember = "nome";
            cbxNomeResponsavel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNomeResponsavel.FormattingEnabled = true;
            cbxNomeResponsavel.Location = new Point(31, 79);
            cbxNomeResponsavel.Name = "cbxNomeResponsavel";
            cbxNomeResponsavel.Size = new Size(306, 23);
            cbxNomeResponsavel.TabIndex = 9;
            cbxNomeResponsavel.ValueMember = "id";
            // 
            // cbxNomeCuidador
            // 
            cbxNomeCuidador.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNomeCuidador.FormattingEnabled = true;
            cbxNomeCuidador.Location = new Point(31, 148);
            cbxNomeCuidador.Name = "cbxNomeCuidador";
            cbxNomeCuidador.Size = new Size(306, 23);
            cbxNomeCuidador.TabIndex = 10;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(112, 453);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(113, 29);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmAvalicao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 501);
            Controls.Add(btnSalvar);
            Controls.Add(cbxNomeCuidador);
            Controls.Add(cbxNomeResponsavel);
            Controls.Add(label2);
            Controls.Add(lblNota);
            Controls.Add(txtComentario);
            Controls.Add(cbxNota);
            Controls.Add(lblNomeCuid);
            Controls.Add(lblNomeResp);
            Name = "FrmAvalicao";
            Text = "Avalição";
            Load += FrmAvalicao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNomeResp;
        private Label lblNomeCuid;
        private ComboBox cbxNota;
        private TextBox txtComentario;
        private Label lblNota;
        private Label label2;
        private ComboBox cbxNomeResponsavel;
        private ComboBox cbxNomeCuidador;
        private Button btnSalvar;
    }
}