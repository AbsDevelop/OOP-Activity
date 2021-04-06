using System;

namespace Cadastros
{
    class Program
    {
        static private Cadastros veiculo = new Cadastros();
        
        static void Main(string[] args)
        {
            int opcao;
            do{
                Console.WriteLine("Bem-vindo a Sistema Carros e Caminhões GIO\r\nO que deseja fazer?");
                Console.WriteLine("1)Cadastrar Carro\n2)Cadastrar Caminhão\n3)Consulta Por Placa\n4)Consultar Caminhão Por Marca\n5)Consultar Carro Por Cor\n6)Exibir Todos Os Carros Cadastrados\n7)Exibir Todos Os Caminhões Cadastrados\n0)Sair");                
                Console.WriteLine();
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao) 
                { 
                    case 1: CadastroCarro();
                        break;
                    case 2: CadastroCaminhao();
                        break;
                    case 3: ConsultaPlaca();
                        break;
                    case 4: ConsultaModelo();
                        break;
                    case 5: ConsultaCor();
                        break;
                    case 6: ExibirCarros();
                        break;
                    case 7: ExibirCaminhoes();
                        break;
                    case 0: Sair();
                        break;       
                }
            }while(opcao != 0);
        }

        static void CadastroCarro(){
            string modelo, marca, cor, placa, stringBagageiro;
            int ano, portas, portaMalas, quantPassageiros;
            bool bagageiro;

            Console.Write("Digite o modelo do carro: ");
            modelo = Console.ReadLine();

            Console.Write("Digite a marca do fabricante do carro: ");
            marca = Console.ReadLine();

            Console.Write("Digite a cor do carro: ");
            cor = Console.ReadLine();

            Console.Write("Digite o ano de fabricação carro: ");
            ano = int.Parse(Console.ReadLine());

            Console.Write("Digite a placa do carro: ");
            placa = Console.ReadLine();

            Console.Write("Digite a quantidade de portas do carro: ");
            portas = int.Parse(Console.ReadLine());

            Console.Write("Digite quantos litros o porta malas suporta: ");
            portaMalas = int.Parse(Console.ReadLine());

            Console.Write("O carro possui bagageiro? ");
            stringBagageiro = Console.ReadLine(); 

            Console.Write("Quantos passageiros cabem no carro? ");
            quantPassageiros = int.Parse(Console.ReadLine());

            if (stringBagageiro == "sim" || stringBagageiro == "Sim"){
                bagageiro = true;
            }
            else{
                bagageiro = false;
            }

            Console.WriteLine();

            Carro c = new Carro(modelo, marca, cor, ano, portas, placa, portaMalas, bagageiro, quantPassageiros);
            veiculo.CadastrarCarro(c);
            Console.Clear();
            CadastroCompleto();
        }

        static void CadastroCaminhao(){
            string modelo, marca, cor, placa;
            int ano, portas, numeroEixos, tamanhoMetros;
            double pesoMaxCarga;

            Console.Write("Digite o modelo do caminhão: ");
            modelo = Console.ReadLine();

            Console.Write("Digite a marca do fabricante do caminhão: ");
            marca = Console.ReadLine();

            Console.Write("Digite a cor do caminhão: ");
            cor = Console.ReadLine();

            Console.Write("Digite o ano de fabricação caminhão: ");
            ano = int.Parse(Console.ReadLine());

            Console.Write("Digite a placa do caminhão: ");
            placa = Console.ReadLine();

            Console.Write("Digite a quantidade de portas do caminhão: ");
            portas = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de eixos do caminhão: ");
            numeroEixos = int.Parse(Console.ReadLine());

            Console.Write("Digite o peso máximo que o caminhão suporta: ");
            pesoMaxCarga = double.Parse(Console.ReadLine());

            Console.Write("Qual o tamanho do caminhão em metros? ");
            tamanhoMetros = Console.ReadLine();

            Caminhao c = new Caminhao(modelo, marca, cor, ano, portas, placa, numeroEixos, pesoMaxCarga, tamanhoMetros);
            veiculo.CadastrarCaminhao(c);

            Console.Clear();
            CadastroCompleto();
        }

        static void ConsultaPlaca(){
            string placa;

            Console.Write("Digite a placa do veiculo que deseja procurar no sistema: ");
            placa = Console.ReadLine();
            Console.Clear();

            Veiculo v = veiculo.ConsultaPlacaCarroCarro(placa);

            if (v == null){
                v = veiculo.ConsultaPlacaCaminhao(placa);

                if (v == null){
                    Console.WriteLine("Veículo não encontrado!");
                }
                else{
                    Console.WriteLine(v);
                }
            }
            else{
                Console.WriteLine(v);
            }

            Console.WriteLine();
            VoltarMenu();
            Console.Clear();
        }

        static void ConsultaModelo(){
            string modelo;

            Console.Write("Digite o modelo do caminhão que deseja procurar no sistema:");
            modelo = Console.ReadLine();
            Console.Clear();

            Caminhao c = veiculo.ModeloCaminhao(modelo);

                if (c == null){
                    Console.WriteLine("Veículo não encontrado!");
                }

                else{
                    Console.WriteLine(c);
                }

            Console.WriteLine();
            VoltarMenu();
            Console.Clear();
        }

        static void ConsultaCor(){
            string cor;

            Console.Write("Digite a cor do(s) carro(s) que deseja procurar no sistema:");
            cor = Console.ReadLine();
            Console.Clear();

            Carro c = veiculo.CorCarro(cor);

                if (c == null){
                    Console.WriteLine("Veículo não encontrado!");
                }

                else{
                    Console.WriteLine(c);
                }

            Console.WriteLine();
            VoltarMenu();
            Console.Clear();
        }

        static void ExibirCarros(){
            Carro[] carro = veiculo.exibirCarros();

            for (int c = 0; c < 2; c++){
                Console.WriteLine(carro[c]);
            }

            Console.WriteLine();
            VoltarMenu();
            Console.Clear();
        }

        static void ExibirCaminhoes(){
            Caminhao[] caminhao = veiculo.exibirCaminhoes();

            for (int c = 0; c < 2; c++){
                Console.WriteLine(caminhao[c]);
            }

            Console.WriteLine();
            VoltarMenu();
            Console.Clear();
        }

        static void Sair(){
			Console.WriteLine("Tchauu (◔‿◔)\nVocê saiu do Sistema!");
        }

        static void CadastroCompleto(){
            string menu;
            Console.Write("Cadastro completo!\nPressione alguma tecla para voltar ao menu principal!");
            menu = Console.ReadLine().ToUpper();
        }
        static void VoltarMenu(){
            string menu;
            Console.Write("Pressione alguma tecla para voltar ao menu principal!");
            menu = Console.ReadLine();
        }
    }
}