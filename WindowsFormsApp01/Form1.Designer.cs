namespace WindowsFormsApp01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelCargo = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.TextBox();
            this.UsuarioAlteracao = new System.Windows.Forms.TextBox();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.LabelAtivo = new System.Windows.Forms.Label();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(121, 353);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(138, 38);
            this.BtnAdicionar.TabIndex = 0;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(288, 353);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(126, 38);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(118, 106);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(16, 13);
            this.LabelId.TabIndex = 2;
            this.LabelId.Text = "*Id será gerado automaticamente.";
            // 
            // LabelCargo
            // 
            this.LabelCargo.AutoSize = true;
            this.LabelCargo.Location = new System.Drawing.Point(114, 161);
            this.LabelCargo.Name = "LabelCargo";
            this.LabelCargo.Size = new System.Drawing.Size(35, 13);
            this.LabelCargo.TabIndex = 3;
            this.LabelCargo.Text = "Cargo";
            // 
            // Cargo
            // 
            this.Cargo.Location = new System.Drawing.Point(117, 177);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(297, 20);
            this.Cargo.TabIndex = 6;
            // 
            // UsuarioAlteracao
            // 
            this.UsuarioAlteracao.Location = new System.Drawing.Point(117, 243);
            this.UsuarioAlteracao.Name = "UsuarioAlteracao";
            this.UsuarioAlteracao.Size = new System.Drawing.Size(297, 20);
            this.UsuarioAlteracao.TabIndex = 8;
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Location = new System.Drawing.Point(114, 226);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(91, 13);
            this.LabelUsuario.TabIndex = 9;
            this.LabelUsuario.Text = "Usuário Alteração";
            // 
            // LabelAtivo
            // 
            this.LabelAtivo.AutoSize = true;
            this.LabelAtivo.Location = new System.Drawing.Point(118, 291);
            this.LabelAtivo.Name = "LabelAtivo";
            this.LabelAtivo.Size = new System.Drawing.Size(31, 13);
            this.LabelAtivo.TabIndex = 10;
            this.LabelAtivo.Text = "Ativo";
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Location = new System.Drawing.Point(155, 291);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(165, 17);
            this.CheckBox.TabIndex = 12;
            this.CheckBox.Text = "TRUE: seleciona check e FALSE: deixar em branco.";
            this.CheckBox.UseVisualStyleBackColor = true;
            this.CheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.LabelAtivo);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.UsuarioAlteracao);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.LabelCargo);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAdicionar);
            this.Name = "Form1";
            this.Text = "Tabela Cargo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Label LabelCargo;
        private System.Windows.Forms.TextBox Cargo;
        private System.Windows.Forms.TextBox UsuarioAlteracao;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Label LabelAtivo;
        private System.Windows.Forms.CheckBox CheckBox;
    }
}

