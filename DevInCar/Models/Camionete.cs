namespace DevInCar.Models;

public class Camionete : Veiculo {

    public int NumeroDePortas {get; set;}
    public double CapacidadeCacamba {get;set;}

    public string Combustivel {get;set;}
    
    public Camionete(){
        this.Combustivel = "";
    }
    public Camionete (string cor, decimal valor, string nome, int potencia, string placa, DateTime DataDeFabricacao, int numeroDePortas, double capacidadeCacamba, string combustivel)
    :base(cor, valor, nome, potencia, placa, DataDeFabricacao){
        this.NumeroDePortas = numeroDePortas;
        this.CapacidadeCacamba = capacidadeCacamba;
        this.Combustivel = combustivel;
    } 
}