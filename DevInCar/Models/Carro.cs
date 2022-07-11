namespace DevInCar.Models;

public class Carro : Veiculo {

    public int NumeroDePortas {get;set;}
    public bool Flex {get; set;}
    public Carro(){}
    public Carro (string cor, decimal valor, string nome, int potencia, string placa, DateTime dataDeFabricacao, int numeroDePortas, bool flex)
    :base(cor, valor, nome, potencia, placa, dataDeFabricacao){
        this.NumeroDePortas = numeroDePortas;
        this.Flex = flex;
    }
}