using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoPOO
{
    public class Cliente:Pessoa
    {
        #region Atributos
        public int nConta;

        #endregion

        #region Metodos

        #region Construtores

        public Cliente(string nome,int nConta,int idade):base(nome)
        {
            this.nConta = nConta;
            this.nome = nome;
            this.idade = idade;
        }
        public Cliente()
        {
            

        }


        #endregion

        #region Propriedades
        public int NConta
        {
            get { return nConta; }
            set { nConta = value; }
        }

        #endregion


        #endregion
    }
}
