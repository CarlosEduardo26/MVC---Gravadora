using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using POO_3C1_04.DAL;
using POO_3C1_04.DTO;

namespace POO_3C1_04.BLL
{
    class BLL_Musica
    {

        private DAL_Musica DaoMusica = new DAL_Musica();

        //Projeto por aluno da turma 3C1: Carlos Eduardo - 04

        public DataTable PesquisarMusicas(string condicao)
        {
            string sql = string.Format($@"select * from tbl_musica where " + condicao);
            return DaoMusica.executarConsulta(sql);
        }

        public DataTable ListarMusicas()
        {
            string sql = string.Format($@"select * from tbl_musica");
            return DaoMusica.executarConsulta(sql);
        }

        public void InserirMusicas(DTO_Musica ObjMusica)
        {
            string sql = string.Format($@"INSERT INTO tbl_musica VALUES (NULL,'{ObjMusica.idMusica}',
                                                                          '{ObjMusica.nome}',
                                                                          '{ObjMusica.nomeAutor}',
                                                                          '{ObjMusica.idGravadora}',
                                                                           '{ObjMusica.idCD}');");
            DaoMusica.executarComando(sql);

        }

        public void AlterarMusicas(DTO_Musica ObjMusica)
        {
            string sql = string.Format($@"UPDATE tbl_musica set idMusica = '{ObjMusica.idMusica}',
                                                               nome = '{ObjMusica.nome}',
                                                               nomeMusica = '{ObjMusica.nomeAutor}',
                                                               idGravadora ='{ObjMusica.idGravadora}',
                                                               idCD ='{ObjMusica.idCD}'
                                                 where idMusica = '{ObjMusica.idMusica}';");
            DaoMusica.executarComando(sql);

        }

        public void ExcluirMusicas(DTO_Musica ObjMusica)
        {
            string sql = string.Format($@"DELETE FROM tbl_musica where idMusica = {ObjMusica.idMusica};");
            DaoMusica.executarComando(sql);
        }



    }
}
