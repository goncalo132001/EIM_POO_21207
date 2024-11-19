using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoPOO
{
    internal class StockMedicamento
    {
        #region Atributos
        public Medicamento medicamento;
        int stock_medicamento;
        #endregion

        #region Metodos

        #region Construtores
        #endregion

        #region Propriedades

        //Sempre que é criado um novo medicamento,é criado um novo medicamento na loja
        public StockMedicamento(string nomeMed) 
        {
            //Cada medicamento adicionado tem validade de 7 dias
            this.medicamento = new Medicamento(nomeMed, 0 , DateTime.Today.AddDays(7), -1);
            this.stock_medicamento = 1;
        }
        #endregion

        #endregion





    }
}
