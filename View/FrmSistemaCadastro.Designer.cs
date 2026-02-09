namespace GestaoCuidadores
{
    partial class FrmSistemaCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuSistemaCadastro = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            responsavelToolStripMenuItem = new ToolStripMenuItem();
            cuidadorToolStripMenuItem = new ToolStripMenuItem();
            disponibilidadeToolStripMenuItem = new ToolStripMenuItem();
            pacienteToolStripMenuItem = new ToolStripMenuItem();
            avaliaçãoToolStripMenuItem = new ToolStripMenuItem();
            atendimentoToolStripMenuItem = new ToolStripMenuItem();
            plantãoToolStripMenuItem = new ToolStripMenuItem();
            consultarPlantãoToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            btnTeste = new Button();
            menuSistemaCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // menuSistemaCadastro
            // 
            menuSistemaCadastro.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, atendimentoToolStripMenuItem, sistemaToolStripMenuItem });
            menuSistemaCadastro.Location = new Point(0, 0);
            menuSistemaCadastro.Name = "menuSistemaCadastro";
            menuSistemaCadastro.Size = new Size(800, 24);
            menuSistemaCadastro.TabIndex = 0;
            menuSistemaCadastro.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { responsavelToolStripMenuItem, cuidadorToolStripMenuItem, pacienteToolStripMenuItem, avaliaçãoToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // responsavelToolStripMenuItem
            // 
            responsavelToolStripMenuItem.Name = "responsavelToolStripMenuItem";
            responsavelToolStripMenuItem.Size = new Size(180, 22);
            responsavelToolStripMenuItem.Text = "Responsável";
            responsavelToolStripMenuItem.Click += responsavelToolStripMenuItem_Click;
            // 
            // cuidadorToolStripMenuItem
            // 
            cuidadorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disponibilidadeToolStripMenuItem });
            cuidadorToolStripMenuItem.Name = "cuidadorToolStripMenuItem";
            cuidadorToolStripMenuItem.Size = new Size(180, 22);
            cuidadorToolStripMenuItem.Text = "Cuidadores";
            cuidadorToolStripMenuItem.Click += cuidadorToolStripMenuItem_Click;
            // 
            // disponibilidadeToolStripMenuItem
            // 
            disponibilidadeToolStripMenuItem.Name = "disponibilidadeToolStripMenuItem";
            disponibilidadeToolStripMenuItem.Size = new Size(156, 22);
            disponibilidadeToolStripMenuItem.Text = "Disponibilidade";
            // 
            // pacienteToolStripMenuItem
            // 
            pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            pacienteToolStripMenuItem.Size = new Size(180, 22);
            pacienteToolStripMenuItem.Text = "Paciente";
            pacienteToolStripMenuItem.Click += pacienteToolStripMenuItem_Click;
            // 
            // avaliaçãoToolStripMenuItem
            // 
            avaliaçãoToolStripMenuItem.Name = "avaliaçãoToolStripMenuItem";
            avaliaçãoToolStripMenuItem.Size = new Size(180, 22);
            avaliaçãoToolStripMenuItem.Text = "Avaliação";
            // 
            // atendimentoToolStripMenuItem
            // 
            atendimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { plantãoToolStripMenuItem, consultarPlantãoToolStripMenuItem });
            atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            atendimentoToolStripMenuItem.Size = new Size(89, 20);
            atendimentoToolStripMenuItem.Text = "Atendimento";
            // 
            // plantãoToolStripMenuItem
            // 
            plantãoToolStripMenuItem.Name = "plantãoToolStripMenuItem";
            plantãoToolStripMenuItem.Size = new Size(198, 22);
            plantãoToolStripMenuItem.Text = "Novo Atendimento";
            // 
            // consultarPlantãoToolStripMenuItem
            // 
            consultarPlantãoToolStripMenuItem.Name = "consultarPlantãoToolStripMenuItem";
            consultarPlantãoToolStripMenuItem.Size = new Size(198, 22);
            consultarPlantãoToolStripMenuItem.Text = "Consultar Atendimento";
            consultarPlantãoToolStripMenuItem.Click += consultarPlantãoToolStripMenuItem_Click;
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(49, 20);
            sistemaToolStripMenuItem.Text = "Login";
            // 
            // btnTeste
            // 
            btnTeste.Location = new Point(648, 408);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(112, 23);
            btnTeste.TabIndex = 1;
            btnTeste.Text = "Teste de Conexão";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click;
            // 
            // FrmSistemaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 465);
            Controls.Add(btnTeste);
            Controls.Add(menuSistemaCadastro);
            MainMenuStrip = menuSistemaCadastro;
            Name = "FrmSistemaCadastro";
            Text = "Sistema de Cadastro";
            Load += FrmSistemaCadastro_Load;
            menuSistemaCadastro.ResumeLayout(false);
            menuSistemaCadastro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuSistemaCadastro;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem atendimentoToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem responsavelToolStripMenuItem;
        private ToolStripMenuItem cuidadorToolStripMenuItem;
        private ToolStripMenuItem pacienteToolStripMenuItem;
        private ToolStripMenuItem disponibilidadeToolStripMenuItem;
        private ToolStripMenuItem plantãoToolStripMenuItem;
        private ToolStripMenuItem consultarPlantãoToolStripMenuItem;
        private ToolStripMenuItem avaliaçãoToolStripMenuItem;
        private Button btnTeste;
    }
}
