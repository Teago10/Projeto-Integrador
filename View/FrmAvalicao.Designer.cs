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
            txtNomeCuidador = new TextBox();
            txtNomeResponsavel = new TextBox();
            lblNomeResp = new Label();
            lblNomeCuid = new Label();
            cbxNota = new ComboBox();
            txtComentario = new TextBox();
            lblNota = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNomeCuidador
            // 
            txtNomeCuidador.Location = new Point(31, 148);
            txtNomeCuidador.Name = "txtNomeCuidador";
            txtNomeCuidador.Size = new Size(306, 23);
            txtNomeCuidador.TabIndex = 0;
            // 
            // txtNomeResponsavel
            // 
            txtNomeResponsavel.Location = new Point(31, 79);
            txtNomeResponsavel.Name = "txtNomeResponsavel";
            txtNomeResponsavel.Size = new Size(306, 23);
            txtNomeResponsavel.TabIndex = 1;
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
            cbxNota.Location = new Point(31, 230);
            cbxNota.Name = "cbxNota";
            cbxNota.Size = new Size(121, 23);
            cbxNota.TabIndex = 5;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(31, 301);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(306, 148);
            txtComentario.TabIndex = 6;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(31, 212);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(101, 15);
            lblNota.TabIndex = 7;
            lblNota.Text = "Avalie o Cuidador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 283);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 8;
            label2.Text = "Deixe um comentario";
            // 
            // FrmAvalicao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 501);
            Controls.Add(label2);
            Controls.Add(lblNota);
            Controls.Add(txtComentario);
            Controls.Add(cbxNota);
            Controls.Add(lblNomeCuid);
            Controls.Add(lblNomeResp);
            Controls.Add(txtNomeResponsavel);
            Controls.Add(txtNomeCuidador);
            Name = "FrmAvalicao";
            Text = "Avalição";
            Load += FrmAvalicao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeCuidador;
        private TextBox txtNomeResponsavel;
        private Label lblNomeResp;
        private Label lblNomeCuid;
        private ComboBox cbxNota;
        private TextBox txtComentario;
        private Label lblNota;
        private Label label2;
    }
}