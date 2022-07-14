using DevInCar.Models;
namespace DevInCar.Utils;

public static class Venda {

    public static void VendaVeiculo(List<Veiculo> veiculos, List<Transferencia> transferencias){
        Desenho.VendaVeiculoCabecalho();
        Console.Write("Placa do veículo: ");
        string? placaVeiculoVenda = Console.ReadLine();
        placaVeiculoVenda = placaVeiculoVenda?.ToUpper();
        Veiculo? veiculo = veiculos.Find(x => x.Placa == placaVeiculoVenda);
        if(veiculo != null){
            if(veiculo.Cpf == "0"){
                try{
                    Transferencia transferencia = new Transferencia();
                    Desenho.VendaVeiculoCabecalho();
                    Console.Write("CPF do comprador: ");
                    veiculo.VenderVeiculo(Console.ReadLine());
                    Desenho.VendaVeiculoCabecalho();
                    Console.Write("Valor de venda:");
                    transferencia.ValorCompra = Convert.ToDecimal(Console.ReadLine());
                    transferencia.DataCompra = DateTime.Now;
                    transferencia.VeiculoCompra = veiculo;
                    transferencias.Add(transferencia);
                    Desenho.VendaVeiculoComSucesso(veiculo.Nome);
                }
                catch(Exception ex){
                    Desenho.ErroAoVender($"{veiculo.Nome},{ex.Message}");
                }
            }
            else
                Desenho.VeiculoJaVendido(veiculo.Nome);
        }
        else
            Desenho.VeiculoInexistente();
    }
}