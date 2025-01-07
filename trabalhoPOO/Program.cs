
using System;
using System.Collections.Generic;
using System.Linq;


namespace trabalhoPOO
{
    public class Program
    {
        static void Main()
        {


            #region setup

            Loja loja = new Loja("Loja A");

            Medicamento medicamento1 = new Medicamento("Paracetamol", Auxiliar.Enumeradores.TipoMedicamento.Analgesico, DateTime.Today.AddDays(7), 3);
            Medicamento medicamento2 = new Medicamento("Mebocaina", Auxiliar.Enumeradores.TipoMedicamento.AntiInflamatorio, DateTime.Today.AddDays(7), 5);
            Medicamento medicamento3 = new Medicamento("TelFast", Auxiliar.Enumeradores.TipoMedicamento.AntiHistaminico, DateTime.Today.AddDays(7), 2);

            Cliente cliente1 = new Cliente("Gonçalo", 1, 24);
            Cliente cliente2 = new Cliente("Mariana", 2, 23);
            Cliente cliente3 = new Cliente("Nuno", 3, 25);

            loja.AdicionarCliente(cliente1);
            loja.AdicionarCliente(cliente2);
            loja.AdicionarCliente(cliente3);

            loja.AdicionarMedicamento(medicamento1, 9);
            loja.AdicionarMedicamento(medicamento2, 3);
            loja.AdicionarMedicamento(medicamento3, 6);

            #endregion
            bool exit = false;
            do
            {
                DisplayMenuPrincipal();

                // obter input to utilizador.
                string userInput = Console.ReadLine();

                // converter em int
                if (int.TryParse(userInput, out int choice))
                {
                    // 0- Sair.
                    // 1- Opcoes de loja.
                    // 2- Opcoes de clientes.
                    // 3- Opcoes de medicamentos.

                    switch (choice)
                    {
                        case 0:
                            {
                                Console.WriteLine("A sair do programa. Clique em qualquer tecla.");
                                exit = true;
                                break;
                            }
                        case 1:
                            {
                                // obter input to utilizador.
                                DisplayMenuLoja();
                                string userInput2 = Console.ReadLine();

                                // converter em int
                                if (int.TryParse(userInput2, out int choice2))
                                {
                                    //Opcoes de loja
                                    // 0- Sair.
                                    // 1- Criar loja.
                                    // 2- Listar clientes.
                                    // 3- Listar stock.


                                    switch (choice2)
                                    {
                                        case 0:
                                            {
                                                break;
                                            }
                                        case 1:
                                            {
                                                AdicionarLoja();
                                                break;
                                            }
                                        case 2:
                                            {
                                                loja.ListarClientes();
                                                Console.ReadKey();
                                                break;
                                            }
                                        case 3:
                                            {
                                                loja.ListarMedicamentos();
                                                Console.ReadKey();
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Escolha inválida. Prima qualquer tecla para voltar ao menu principal.");
                                                Console.ReadKey();
                                                break;
                                            }
                                    }
                                }

                                break;
                            }
                        case 2:
                            {
                                // obter input to utilizador.
                                DisplayMenuClientes();
                                string userInput2 = Console.ReadLine();

                                // converter em int
                                if (int.TryParse(userInput2, out int choice2))
                                {
                                    //Opcoes de cliente
                                    // 0- Sair.
                                    // 1- Adiconar clientes.
                                    // 2- Remover cliente.


                                    switch (choice2)
                                    {
                                        case 0:
                                            {
                                                break;
                                            }
                                        case 1:
                                            {
                                                Cliente temp = AdicionarCliente();
                                                if (temp.Nome.Equals("Inválido"))
                                                {
                                                    Console.WriteLine("Dados inválidos");
                                                }
                                                else
                                                {
                                                    loja.AdicionarCliente(temp);
                                                    loja.listaClientes.LastOrDefault().NConta = loja.listaClientes.Count;
                                                }
                                                Console.ReadKey();
                                                break;
                                            }
                                        case 2:
                                            {
                                                RemoverCliente(loja);
                                                Console.ReadKey();
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Escolha inválida. Prima qualquer tecla para voltar ao menu principal.");
                                                Console.ReadKey();
                                                break;
                                            }
                                    }
                                }

                                break;
                            }
                        case 3:
                            {
                                // obter input to utilizador.
                                DisplayMenuMedicamentos();
                                string userInput2 = Console.ReadLine();

                                // converter em int
                                if (int.TryParse(userInput2, out int choice2))
                                {
                                    //Opcoes de cliente
                                    // 0- Sair.
                                    // 1- Adiconar medicamento.
                                    // 2- Remover medicamento.

                                    switch (choice2)
                                    {
                                        case 0:
                                            {
                                                break;
                                            }
                                        case 1:
                                            {
                                                Medicamento temp = AdicionarMedicamento();
                                                if (temp.NomeMedicamento.Equals("Inválido"))
                                                {
                                                    Console.WriteLine("Dados inválidos");
                                                }
                                                else
                                                {
                                                    


                                                    Console.Write("Stock: ");
                                                    if (int.TryParse(Console.ReadLine(), out int stock))
                                                    {
                                                        loja.AdicionarMedicamento(temp, stock);
                                                        Console.WriteLine("Medicamento adicionado.");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Dados invalidos.");
                                                    }
                                                        
                                                }
                                                Console.ReadKey();
                                                break;
                                            }
                                        case 2:
                                            {
                                                RemoverMedicamento(loja);
                                                Console.ReadKey();
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Escolha inválida. Prima qualquer tecla para voltar ao menu principal.");
                                                Console.ReadKey();
                                                break;
                                            }
                                    }
                                }

                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Escolha inválida. Prima qualquer tecla.");
                                Console.ReadKey();
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Input inválido.");
                }
            } while (!exit);
            Console.ReadKey();
        }

        #region Menus
        static void DisplayMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine(" 0: Sair.");
            Console.WriteLine(" 1: Menu Loja");
            Console.WriteLine(" 2: Menu Clientes");
            Console.WriteLine(" 3: Menu Medicamentos");
            Console.Write("Escolha: ");
        }
        static void DisplayMenuLoja()
        {
            Console.Clear();
            Console.WriteLine("Selecionou opções de loja.");
            Console.WriteLine("Menu:");
            Console.WriteLine(" 0: Sair.");
            Console.WriteLine(" 1: Adicionar Loja");
            Console.WriteLine(" 2: Listar Clientes.");
            Console.WriteLine(" 3: Listar Stock.");
            Console.Write("Escolha: ");
        }
        static void DisplayMenuClientes()
        {
            Console.Clear();
            Console.WriteLine("Selecionou opções de cliente.");
            Console.WriteLine("Menu:");
            Console.WriteLine(" 0: Sair.");
            Console.WriteLine(" 1: Adicionar cliente.");
            Console.WriteLine(" 2: Remover cliente.");
            Console.Write("Escolha: ");
        }
        static void DisplayMenuMedicamentos()
        {
            Console.Clear();
            Console.WriteLine("Selecionou opções de medicamentos.");
            Console.WriteLine("Menu:");
            Console.WriteLine(" 0: Sair.");
            Console.WriteLine(" 1: Adicionar medicamento.");
            Console.WriteLine(" 2: Remover medicamento.");
            Console.Write("Escolha: ");
        }
        #endregion

        static void AdicionarLoja()
        {

            Console.Clear();
            Console.WriteLine("Insira os detalhes da nova Loja:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Loja temp = new Loja(nome);
        }

        static Cliente AdicionarCliente()
        {
            Cliente cliente1 = new Cliente();
            Console.Clear();
            Console.WriteLine("Insira os detalhes do novo cliente:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            if (int.TryParse(Console.ReadLine(), out int idade))
            {

                Console.WriteLine("Cliente adicionado. Prima qualquer tecla para voltar ao menu principal.");
            }
            else
            {
                Console.WriteLine("Dados inválidos. Prima qualquer tecla para voltar ao menu principal.");
            }

            if (cliente1.Nome.Equals("Inválido"))
            {
                return new Cliente(nome, -1, idade);
            }

            Console.ReadKey();

            return cliente1;
        }

        static void RemoverCliente(Loja loja)
        {
            Console.Clear();
            Console.WriteLine("Insira o nome do cliente a remover:");

            string nome = Console.ReadLine();
            Console.WriteLine($"O cliente {nome} foi removido com susesso.");
            loja.RemoverClientePorNome(nome);

        }

        static Medicamento AdicionarMedicamento()
        {
            Medicamento medicamento1 = new Medicamento();
            Console.Clear();
            Console.WriteLine("Insira os detalhes do novo medicamento");
            

            Console.Write("Nome: ");
            string nomeMed = Console.ReadLine();

            Console.WriteLine("Insira o tipo\n1- Analgesico,\n2- AntiInflamatorio,\n3- Antibiotico,\n4- AntiHistaminico");
            
            Console.Write("Tipo: ");
            if (int.TryParse(Console.ReadLine(), out int tipo))
            {
                Console.Write("Preço: ");
                if (int.TryParse(Console.ReadLine(), out int preco))
                {
                    if (tipo == 1)
                    {
                        Medicamento medicamento = new Medicamento(nomeMed, Auxiliar.Enumeradores.TipoMedicamento.Analgesico, DateTime.Today.AddDays(7), preco);
                        Console.ReadKey();
                        return medicamento;
                    }
                    else if (tipo == 2)
                    {
                        Medicamento medicamento = new Medicamento(nomeMed, Auxiliar.Enumeradores.TipoMedicamento.AntiInflamatorio, DateTime.Today.AddDays(7), preco);
                        Console.ReadKey();
                        return medicamento;
                    }
                    else if (tipo == 3)
                    {
                        Medicamento medicamento = new Medicamento(nomeMed, Auxiliar.Enumeradores.TipoMedicamento.Antibiotico, DateTime.Today.AddDays(7), preco);
                        Console.ReadKey();
                        return medicamento;
                    }
                    else if (tipo == 4) 
                    {
                        Medicamento medicamento = new Medicamento(nomeMed, Auxiliar.Enumeradores.TipoMedicamento.AntiHistaminico, DateTime.Today.AddDays(7), preco);
                        Console.ReadKey();
                        return medicamento;
                    }
                    else
                    {
                        Console.WriteLine("Dados inválidos. Prima qualquer tecla para voltar ao menu principal.");
                    }

                }
                else
                {
                    Console.WriteLine("Dados inválidos. Prima qualquer tecla para voltar ao menu principal.");
                }
            }
            else
            {
                Console.WriteLine("Dados inválidos. Prima qualquer tecla para voltar ao menu principal.");
            }
            return medicamento1;
        }

        static void RemoverMedicamento(Loja loja)
        {
            Console.Clear();
            Console.WriteLine("Insira o nome do medicamento a remover:");

            string nome = Console.ReadLine();

            loja.RemoverMedicamentoPorNome(nome);

        }
    }
}
