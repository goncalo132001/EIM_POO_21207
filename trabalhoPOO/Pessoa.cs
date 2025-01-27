﻿namespace trabalhoPOO
{
    public class Pessoa
    {
        #region Atributos
        private string nome;
        private int idade;

        public Pessoa(string nome)
        {
            this.nome = nome;
        }
        #endregion

        #region Metodos

        #region Construtores

        public Pessoa(int idade=10,string nome="Inválido")
        {
            this.nome = nome;
            this.idade = idade;
        }

        #endregion

        #region Propriedades

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        public int Idade
        {
            get { return idade; }   
            set => idade = value;
        }
        #endregion


    }
}
