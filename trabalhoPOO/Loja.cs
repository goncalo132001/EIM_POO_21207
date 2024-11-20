using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Enumerador Tipo 
using trabalhoPOO.Auxiliar;


namespace trabalhoPOO
{
    public class Loja
    {
        
        #region Atributos
        
        List<StockMedicamento> stockMedicamento = new List<StockMedicamento>();
        
        //Contacto da loja
        public string contacto;
        #endregion

        #region Metodos

        public void ListarMedicamentosDisponiveis()
        {
            Console.WriteLine("Tamanho lista: {0}", stockMedicamento.Count);
            for(int i = 0; i < stockMedicamento.Count; i++) 
            {
                    //{stockMedicamento[i].medicamento.NomeMedicamento} -> Em vez de ser .nome é .NomeMedicamento
                    // porque vai buscar à propriedade de encapsulamento do medicamento
                    Console.WriteLine($"Medicamento: {stockMedicamento[i].medicamento.NomeMedicamento}");
            }
        }
        
        
        #endregion


    }
}

