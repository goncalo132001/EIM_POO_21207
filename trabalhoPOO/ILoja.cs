using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace trabalhoPOO
{
    public abstract class ILoja
    {
        public abstract void AdicionarCliente(Cliente cliente);
        public abstract void AdicionarMedicamento(Medicamento medicamento, int stock);
        public abstract void RemoverMedicamento(Medicamento medicamento, int quantidade);
        public abstract void ListarMedicamentos();


    }
}
