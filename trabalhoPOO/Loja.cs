using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Enumerador Tipo 
using trabalhoPOO.Auxiliar;


namespace trabalhoPOO
{
    public class Loja : ILoja
    {
        
        #region Atributos
        
        private List<StockMedicamento> stockMedicamento = new List<StockMedicamento>();
        public List<Cliente> listaClientes = new List<Cliente>();
        private string nome;
        
        //Contacto da loja
        public string contacto;
        #endregion

        #region Metodos

        #region Construtor
        public Loja(string nome)
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

        public override void AdicionarCliente(Cliente cliente)
        {
            this.listaClientes.Add(cliente);
            Console.WriteLine($"Cliente {cliente.Nome} foi adicionado à loja.");
        }

        public override void AdicionarMedicamento(Medicamento medicamento, int stock=5)
        {
            this.stockMedicamento.Add(new StockMedicamento(medicamento, stock));
            Console.WriteLine($"Medicamento {medicamento.NomeMedicamento} adicionado ao stock.");
        }

        public override void RemoverMedicamento(Medicamento medicamento, int quantidade)
        {
            foreach (var med in stockMedicamento)
            {
                if (med.medicamento.NomeMedicamento == medicamento.NomeMedicamento)
                {
                    if (med.stockMed < quantidade)
                    {
                        throw new InvalidOperationException("quantidade invalida");
                    }

                    med.stockMed -= quantidade;
                    Console.WriteLine("Operação realizada com sucesso.");
                    return;
                }
            }

            throw new KeyNotFoundException($"O medicamento {medicamento.NomeMedicamento} não foi encontrado no stock.");
        }

        public override void ListarMedicamentos()
        {
            foreach (var med in stockMedicamento)
            {
                Console.WriteLine($"{med.medicamento.NomeMedicamento} tem {med.stockMed} em stock");
            }
        }

        public void RemoverClientePorNome(string nomeCliente)
        {
            this.listaClientes.RemoveAll(n => n.Nome.Equals(nomeCliente));
        }

        public void ListarClientes()
        {
            Console.WriteLine($"Clientes da loja {this.nome}:");

            foreach (var cli in listaClientes)
            {
                Console.WriteLine($"{cli.Nome}, nº cliente: {cli.NConta}");
            }
        }

        public void RemoverMedicamentoPorNome(string nomeMed)
        {
            this.stockMedicamento.RemoveAll(n => n.medicamento.NomeMedicamento.Equals(nomeMed));
        }

        #endregion


    }
}

