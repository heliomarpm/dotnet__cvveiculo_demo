using CVVeiculo.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;

class Program
{
    static readonly List<Veiculo> estoqueVeiculos = new();
    static readonly List<Veiculo> veiculosVendidos = new();

    static readonly ConsoleColor defaultColor = ConsoleColor.White;

    static void Main()
    {
        while (true)
        {
            showMenu();
            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    ComprarVeiculo();
                    break;
                case "2":
                    EstoqueDeVeiculos();
                    break;
                case "3":
                    VenderVeiculo();
                    break;
                case "4":
                    RelatorioVendas();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void showMenu()
    {
        Console.ForegroundColor = defaultColor;
        Console.WriteLine("\n### Menu ###");
        Console.WriteLine("1. Comprar Veículo");
        Console.WriteLine("2. Estoque de Veículos");
        Console.WriteLine("3. Vender Veículo");
        Console.WriteLine("4. Relatório de Vendas");
        Console.WriteLine("5. Sair");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"{Environment.NewLine}Escolha uma opção: ");
        Console.ForegroundColor= defaultColor; 
    }

    static void ComprarVeiculo()
    {
        Console.Write("Informe a MARCA do veículo: ");
        string marca = Console.ReadLine();

        Console.Write("Informe o MODELO do veículo: ");
        string modelo = Console.ReadLine();

        Console.Write("Informe a COR do veículo: ");
        string cor = Console.ReadLine();

        Console.Write("Informe o ANO de Fabricação do veículo: ");
        int anoFabricacao = int.Parse(Console.ReadLine());

        Console.Write("Informe o PREÇO do veículo: ");
        decimal preco = decimal.Parse(Console.ReadLine());

        Veiculo veiculo = new(marca, modelo, cor, anoFabricacao, preco);
        estoqueVeiculos.Add(veiculo);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Veículo COMPRADO com sucesso!"); 
    }

    static void EstoqueDeVeiculos()
    {
        Console.WriteLine("\n### Veículos Disponíveis ###");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        int index = 0;
        foreach (var veiculo in estoqueVeiculos)
        {
            Console.WriteLine($"{index++} - {veiculo}");
        }
    }

    static void VenderVeiculo()
    {
        EstoqueDeVeiculos();
        Console.ForegroundColor = defaultColor;
        Console.Write("Informe o código do veículo que deseja vender: ");
        int indice = int.Parse(Console.ReadLine());

        if (indice >= 0 && indice < estoqueVeiculos.Count)
        {
            Veiculo veiculoComprado = estoqueVeiculos[indice];
            veiculosVendidos.Add(veiculoComprado);
            estoqueVeiculos.RemoveAt(indice);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Veículo VENDIDO com sucesso!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Índice inválido. Tente novamente.");
        }
    }

    static void RelatorioVendas()
    {
        Console.WriteLine("\n### Veículos Vendidos ###");
        Console.ForegroundColor= ConsoleColor.DarkCyan;
        foreach (var veiculo in veiculosVendidos)
        {
            Console.WriteLine(veiculo);
        }
    }
}

