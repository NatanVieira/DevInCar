﻿using DevInCar.Models;
using DevInCar.Utils;
namespace DevInCar;

public class Program {

    static void Main(string[] args)
    {
        List<Veiculo> veiculos = new List<Veiculo>();
        List<Transferencia> transferencias = new List<Transferencia>();

        Armazenamento armazenamento = new Armazenamento();
        var escolha = "1";
        armazenamento.RecuperaDadosVeiculos(veiculos);
        armazenamento.RecuperaDadosTransferencias(transferencias, veiculos);
        do{
            Desenho.DesenhaMenuInicial();
            escolha = Console.ReadLine();
            switch(escolha){
                case "1":
                    Cadastro.novoVeiculo(veiculos);
                    break;
                case "2":
                    Venda.VendaVeiculo(veiculos, transferencias);
                    break;
                case "3":
                    Listagem.listarVericulo(veiculos);
                    break;
                default:
                    armazenamento.ArmazenaVeiculos(veiculos);
                    armazenamento.ArmazenaTransferencias(transferencias);
                    Desenho.FinalizaPrograma();
                    veiculos.Clear();
                    transferencias.Clear();
                    break;
            }
        }while(escolha == "1" || escolha == "2" || escolha == "3");
    }
}
