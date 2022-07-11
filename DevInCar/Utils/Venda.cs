using DevInCar.Models;
namespace DevInCar.Utils;

public static class Venda {

    public static void VendaVeiculo(List<Veiculo> veiculos){
        Desenho.VendaVeiculoCabecalho();
        System.Console.Write("Nome do veículo: ");
        string nomeVeiculoVenda = System.Console.ReadLine();
        Veiculo veiculo = veiculos.Find(x => x.Nome == nomeVeiculoVenda);
        if(veiculo != null){
            if(veiculo.Cpf == "0"){
                try{
                    Desenho.VendaVeiculoCabecalho();
                    System.Console.Write("CPF do comprador: ");
                    veiculo.Cpf = System.Console.ReadLine();
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