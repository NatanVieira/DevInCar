namespace DevInCar.Models;

public class Camionete : Veiculo {

    private int numeroDePortas {get{return numeroDePortas;}
                                set{numeroDePortas = value;}}
    private double capacidadeCacamba {get{return capacidadeCacamba;}
                                      set{capacidadeCacamba = value;}}

    private string combustivel {get{return combustivel;}
                                set{combustivel = value;}}
    
    public Camionete (string cor, decimal valor, string nome, int potencia, string placa, DateTime DataDeFabricacao, int numeroDePortas, double capacidadeCacamba, string combustivel)
    :base(cor, valor, nome, potencia, placa, DataDeFabricacao){
        this.numeroDePortas = numeroDePortas;
        this.capacidadeCacamba = capacidadeCacamba;
        this.combustivel = combustivel;
    } 
}