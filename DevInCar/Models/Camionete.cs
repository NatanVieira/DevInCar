namespace DevInCar.Models;

public class Camionete : Veiculo {

    private int numeroDePortas;
    private double capacidadeCacamba;

    private string combustivel;
    
    public Camionete(){
        this.combustivel = "";
    }
    public Camionete (string cor, decimal valor, string nome, int potencia, string placa, DateTime DataDeFabricacao, int numeroDePortas, double capacidadeCacamba, string combustivel)
    :base(cor, valor, nome, potencia, placa, DataDeFabricacao){
        this.numeroDePortas = numeroDePortas;
        this.capacidadeCacamba = capacidadeCacamba;
        this.combustivel = combustivel;
    } 

    public int NumeroDePortas {get{return numeroDePortas;}
                               set{numeroDePortas = value;}}
    public double CapacidadeCacamba {get{return capacidadeCacamba;}
                                     set{capacidadeCacamba = value;}}
    public string Combustivel {get{return combustivel;}
                               set{combustivel = value;}}
}