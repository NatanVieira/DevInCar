using DevInCar.Models;
namespace DevInCar.Utils;

public static class Venda {

    public static void VendaVeiculo(List<Veiculo> veiculos, List<Transferencia> transferencias){
        Desenho.VendaVeiculoCabecalho();
        System.Console.Write("Nome do veículo: ");
        string nomeVeiculoVenda = System.Console.ReadLine();
        Veiculo veiculo = veiculos.Find(x => x.Nome == nomeVeiculoVenda);
        if(veiculo != null){
            if(veiculo.Cpf == "0"){
                try{
                    Transferencia transferencia = new Transferencia();
                    Desenho.VendaVeiculoCabecalho();
                    System.Console.Write("CPF do comprador: ");
                    veiculo.VenderVeiculo(System.Console.ReadLine());
                    Desenho.VendaVeiculoCabecalho();
                    System.Console.Write("Valor de venda:");
                    transferencia.ValorCompra = Convert.ToDecimal(System.Console.ReadLine());
                    transferencia.DataCompra = DateTime.Now;
                    transferencia.VeiculoCompra = veiculo;
                    transferencias.Add(transferencia);
                    Desenho.VendaVeiculoComSucesso(veiculo.Nome);
                }
                catch(Exception ex){
                    Desenho.ErroAoVender(veiculo.Nome);
                }
            }
            else
                Desenho.VeiculoJaVendido(veiculo.Nome);
        }
        else
            Desenho.VeiculoInexistente();
    }
}