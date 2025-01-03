
using System;
using System.Collections.Generic;


namespace trabalhoPOO
{
    public class Program
    {
        static void Main()
        {


            #region setup

            Loja loja = new Loja("Loja A");

            Medicamento medicamento1 = new Medicamento("Paracetamol", Auxiliar.Enumeradores.TipoMedicamento.Analgesico, DateTime.Today.AddDays(7), 3.70);
            Medicamento medicamento2 = new Medicamento("Mebocaina", Auxiliar.Enumeradores.TipoMedicamento.AntiInflamatorio, DateTime.Today.AddDays(7), 5.60);
            Medicamento medicamento3 = new Medicamento("", Auxiliar.Enumeradores.TipoMedicamento.AntiHistaminico, DateTime.Today.AddDays(7), 2.20);


            Cliente cliente1 = new Cliente("Gonçalo", 1, 24);
            Cliente cliente2 = new Cliente("Mariana", 2, 23);
            Cliente cliente3 = new Cliente("Nuno", 3, 25);

            loja.AdicionarCliente(cliente1);
            loja.AdicionarCliente(cliente2);
            loja.AdicionarCliente(cliente3);

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
                                                //fazer algo
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
                                    // 2- Comprar medicamento.
                                    // 2- Listar medicamentos.

                                    switch (choice2)
                                    {
                                        case 0:
                                            {
                                                break;
                                            }
                                        case 1:
                                            {
                                                //fazer algo
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


                        // inserir mais cases



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
            Console.WriteLine(" 2: Comprar medicamento.");
            Console.WriteLine(" 3: Listar medicamentos.");
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


    }
}
