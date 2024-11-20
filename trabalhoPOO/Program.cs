
using System;
using System.Collections.Generic;


namespace trabalhoPOO
{
    public class Program
    {
        static void Main()
        {
           Medicamento medicamento1 = new Medicamento("Paracetamol",Auxiliar.Enumeradores.TipoMedicamento.Analgesico,DateTime.Today.AddDays(7),3.70);

        }
    }
}
