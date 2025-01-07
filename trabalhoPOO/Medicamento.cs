using System;


namespace trabalhoPOO
{
    public class Medicamento
    {

        #region Atributos

        private string nome;
        private Auxiliar.Enumeradores.TipoMedicamento tipo; 
        private DateTime dataValidade;
        public int preco;

        #endregion

        #region Metodos

        #region Construtores

        public Medicamento(string nomeMed, Auxiliar.Enumeradores.TipoMedicamento t, DateTime dv, int preco)
        {
            this.nome = nomeMed;
            tipo = t;
            dataValidade = dv;
            this.preco = preco;
        }
        public Medicamento()
        {
            this.nome = "Inválido";
        }

        #endregion

        #region Propriedades

        //Encapsulamento

        public string NomeMedicamento
        {
            get { return nome; }
            set { nome = value; }
        }

        public Auxiliar.Enumeradores.TipoMedicamento TipoMed
        {      
            get { return tipo; }
            set { tipo = value; }
        }

        public DateTime DataValidade
        { 
           get { return dataValidade; } 
           set { dataValidade = value; } 
        }

        #endregion
        #region Overrides

        //Rescreve métodos
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override string ToString()
        {
            return nome.ToString();
        }

        
        #endregion

        #endregion


    }
}
