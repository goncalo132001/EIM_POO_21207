using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoPOO
{
    public class Cliente
    {
        #region Atributos
        private string nome;
        private string morada;
        #endregion

        #region Metodos

        #region Construtores

        public Cliente(string nome)
        {
            this.nome = nome;
        }

        #endregion

        #region Propriedades

        public string Nome 
        { 
            get { return nome; }
            set { nome = value; }
        }
        #endregion


        #endregion
    }
}
