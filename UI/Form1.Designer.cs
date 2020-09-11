namespace POO_3C1_25
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.dtg_Musicas = new System.Windows.Forms.DataGridView();
            this.lbl_idMusica = new System.Windows.Forms.Label();
            this.lbl_idCD = new System.Windows.Forms.Label();
            this.lbl_idGravadora = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.cbx_idCD = new System.Windows.Forms.ComboBox();
            this.cbx_idGravadora = new System.Windows.Forms.ComboBox();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.lbl_Pesquisa = new System.Windows.Forms.Label();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.txt_nomeAutor = new System.Windows.Forms.TextBox();
            this.lbl_nomeAutor = new System.Windows.Forms.Label();
            this.cbx_idMusica = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Musicas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(274, 64);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(274, 104);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(274, 148);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(100, 23);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // dtg_Musicas
            // 
            this.dtg_Musicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Musicas.Location = new System.Drawing.Point(12, 202);
            this.dtg_Musicas.Name = "dtg_Musicas";
            this.dtg_Musicas.Size = new System.Drawing.Size(585, 184);
            this.dtg_Musicas.TabIndex = 4;
            this.dtg_Musicas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Livros_CellContentClick);
            // 
            // lbl_idMusica
            // 
            this.lbl_idMusica.AutoSize = true;
            this.lbl_idMusica.Location = new System.Drawing.Point(12, 48);
            this.lbl_idMusica.Name = "lbl_idMusica";
            this.lbl_idMusica.Size = new System.Drawing.Size(59, 13);
            this.lbl_idMusica.TabIndex = 5;
            this.lbl_idMusica.Text = "Id - Musica";
            this.lbl_idMusica.Click += new System.EventHandler(this.lbl_idlivro_Click);
            // 
            // lbl_idCD
            // 
            this.lbl_idCD.AutoSize = true;
            this.lbl_idCD.Location = new System.Drawing.Point(12, 90);
            this.lbl_idCD.Name = "lbl_idCD";
            this.lbl_idCD.Size = new System.Drawing.Size(40, 13);
            this.lbl_idCD.TabIndex = 7;
            this.lbl_idCD.Text = "Id - CD";
            this.lbl_idCD.Click += new System.EventHandler(this.lbl_idAutor_Click);
            // 
            // lbl_idGravadora
            // 
            this.lbl_idGravadora.AutoSize = true;
            this.lbl_idGravadora.Location = new System.Drawing.Point(12, 132);
            this.lbl_idGravadora.Name = "lbl_idGravadora";
            this.lbl_idGravadora.Size = new System.Drawing.Size(75, 13);
            this.lbl_idGravadora.TabIndex = 8;
            this.lbl_idGravadora.Text = "Id - Gravadora";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(141, 48);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 11;
            this.lbl_nome.Text = "Nome";
            this.lbl_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(144, 64);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 12;
            // 
            // cbx_idCD
            // 
            this.cbx_idCD.FormattingEnabled = true;
            this.cbx_idCD.Location = new System.Drawing.Point(12, 103);
            this.cbx_idCD.Name = "cbx_idCD";
            this.cbx_idCD.Size = new System.Drawing.Size(100, 21);
            this.cbx_idCD.TabIndex = 20;
            this.cbx_idCD.SelectedIndexChanged += new System.EventHandler(this.cbx_idCD_SelectedIndexChanged);
            // 
            // cbx_idGravadora
            // 
            this.cbx_idGravadora.FormattingEnabled = true;
            this.cbx_idGravadora.Location = new System.Drawing.Point(12, 148);
            this.cbx_idGravadora.Name = "cbx_idGravadora";
            this.cbx_idGravadora.Size = new System.Drawing.Size(100, 21);
            this.cbx_idGravadora.TabIndex = 21;
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Location = new System.Drawing.Point(12, 25);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(232, 20);
            this.txt_Pesquisar.TabIndex = 23;
            this.txt_Pesquisar.TextChanged += new System.EventHandler(this.txt_Pesquisar_TextChanged);
            // 
            // lbl_Pesquisa
            // 
            this.lbl_Pesquisa.AutoSize = true;
            this.lbl_Pesquisa.Location = new System.Drawing.Point(12, 9);
            this.lbl_Pesquisa.Name = "lbl_Pesquisa";
            this.lbl_Pesquisa.Size = new System.Drawing.Size(56, 13);
            this.lbl_Pesquisa.TabIndex = 24;
            this.lbl_Pesquisa.Text = "Pesquisar:";
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(274, 25);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(100, 23);
            this.btn_Pesquisar.TabIndex = 25;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // txt_nomeAutor
            // 
            this.txt_nomeAutor.Location = new System.Drawing.Point(144, 107);
            this.txt_nomeAutor.Name = "txt_nomeAutor";
            this.txt_nomeAutor.Size = new System.Drawing.Size(100, 20);
            this.txt_nomeAutor.TabIndex = 26;
            // 
            // lbl_nomeAutor
            // 
            this.lbl_nomeAutor.AutoSize = true;
            this.lbl_nomeAutor.Location = new System.Drawing.Point(141, 91);
            this.lbl_nomeAutor.Name = "lbl_nomeAutor";
            this.lbl_nomeAutor.Size = new System.Drawing.Size(78, 13);
            this.lbl_nomeAutor.TabIndex = 27;
            this.lbl_nomeAutor.Text = "Nome do Autor";
            this.lbl_nomeAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx_idMusica
            // 
            this.cbx_idMusica.FormattingEnabled = true;
            this.cbx_idMusica.Location = new System.Drawing.Point(12, 63);
            this.cbx_idMusica.Name = "cbx_idMusica";
            this.cbx_idMusica.Size = new System.Drawing.Size(100, 21);
            this.cbx_idMusica.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 398);
            this.Controls.Add(this.cbx_idMusica);
            this.Controls.Add(this.lbl_nomeAutor);
            this.Controls.Add(this.txt_nomeAutor);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.lbl_Pesquisa);
            this.Controls.Add(this.txt_Pesquisar);
            this.Controls.Add(this.cbx_idGravadora);
            this.Controls.Add(this.cbx_idCD);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_idGravadora);
            this.Controls.Add(this.lbl_idCD);
            this.Controls.Add(this.lbl_idMusica);
            this.Controls.Add(this.dtg_Musicas);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gravadora - Carlos Eduardo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Musicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridView dtg_Musicas;
        private System.Windows.Forms.Label lbl_idMusica;
        private System.Windows.Forms.Label lbl_idCD;
        private System.Windows.Forms.Label lbl_idGravadora;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ComboBox cbx_idCD;
        private System.Windows.Forms.ComboBox cbx_idGravadora;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.Label lbl_Pesquisa;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox txt_nomeAutor;
        private System.Windows.Forms.Label lbl_nomeAutor;
        private System.Windows.Forms.ComboBox cbx_idMusica;
    }
}

