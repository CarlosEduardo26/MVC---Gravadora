using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO_3C1_04.BLL;
using POO_3C1_04.DTO;

namespace POO_3C1_25
{
    public partial class Form1 : Form
    {

        BLL_Musica bllMusica = new BLL_Musica();
        DTO_Musica dtoMusica = new DTO_Musica();


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Projeto por aluno da turma 3C1: Carlos Eduardo - 04

            dtg_Musicas.DataSource = bllMusica.ListarMusicas();
            this.PreencheIdAutor();
            this.PreencheIdEditora();
        } 
        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                // Passagem dos dados da UI para o DTO
                dtoMusica.idCD = int.Parse(cbx_idCD.Text);
                dtoMusica.idGravadora = int.Parse(cbx_idGravadora.Text);
                dtoMusica.nome = txt_nome.Text.ToString();
                dtoMusica.nomeAutor = txt_nomeAutor.Text.ToString();
                dtoMusica.idMusica = int.Parse(cbx_idMusica.Text);


                bllMusica.InserirMusicas(dtoMusica);
                MessageBox.Show("Musica inserida com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtg_Musicas.DataSource = bllMusica.ListarMusicas();

                new LimpaForm(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Passagem dos dados da UI para o DTO
                dtoMusica.idCD = int.Parse(cbx_idCD.Text);
                dtoMusica.idGravadora = int.Parse(cbx_idGravadora.Text);
                dtoMusica.nome = txt_nome.Text.ToString();
                dtoMusica.nomeAutor = txt_nomeAutor.Text.ToString();
                dtoMusica.idMusica = int.Parse(cbx_idMusica.Text);


                bllMusica.AlterarMusicas(dtoMusica);
                dtg_Musicas.DataSource = bllMusica.ListarMusicas();
                MessageBox.Show("Musca alterada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                new LimpaForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Está ação irá deletar o registro sem voltas, planeja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dtoMusica.idMusica = Convert.ToInt32(cbx_idMusica.Text);
                    bllMusica.ExcluirMusicas(dtoMusica);
                    dtg_Musicas.DataSource = bllMusica.ListarMusicas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtg_Livros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbx_idMusica.Text = dtg_Musicas.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbx_idCD.Text = dtg_Musicas.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbx_idGravadora.Text = dtg_Musicas.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_nome.Text = dtg_Musicas.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_nomeAutor.Text = dtg_Musicas.Rows[e.RowIndex].Cells[4].Value.ToString();
         
            // Habilitar o botao Excluir
            this.btnDeletar.Enabled = true;
            this.btnEditar.Enabled = true;
        }

        public void PreencheIdAutor()
        {
            cbx_idCD.DataSource = bllMusica.ListarMusicas();
            // Indicar o campo que o usuario verá no combo
            cbx_idCD.DisplayMember = "idCD";
            //Indicar o campo que será gravado no banco
            cbx_idCD.ValueMember = "idCD";
        }

        public void PreencheIdEditora()
        {
            cbx_idGravadora.DataSource = bllMusica.ListarMusicas();
            // Indicar o campo que o usuario verá no combo
            cbx_idGravadora.DisplayMember = "idGravadora";
            //Indicar o campo que será gravado no banco
            cbx_idGravadora.ValueMember = "idGravadora";
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            string condicao = "nome like '%" + txt_Pesquisar.Text + "%'";

            dtg_Musicas.DataSource = bllMusica.PesquisarMusicas(condicao);
        }

        private void lbl_idlivro_Click(object sender, EventArgs e)
        {

        }

        private void lbl_numpag_Click(object sender, EventArgs e)
        {

        }

        private void lbl_idAutor_Click(object sender, EventArgs e)
        {

        }

        private void txt_Pesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_idCD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
