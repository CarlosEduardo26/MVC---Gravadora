using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POO_3C1_04.DTO
{
    class DTO_Musica
    {

        //Projeto por aluno da turma 3C1: Carlos Eduardo - 04

        // Atributos
        private int idEditora;

        // Métodos
        public int idMusica { get => idMusica; set => idMusica = value; }
        public int idGravadora { get => idGravadora; set => idGravadora = value; }
        public int idCD { get => idCD; set => idCD = value; }
        public string nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("Preencha o nome da musica.");
                }
            }
            get { return this.nome; }

        }
        public string nomeAutor
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeAutor = value;
                }
                else
                {
                    throw new Exception("Preencha o nome do Autor.");
                }
            }
            get { return this.nomeAutor; }

        }
    }
}