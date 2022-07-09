namespace DevInCar.Models;

public class Carro : Veiculo {

    private int numeroDePortas {get{return numeroDePortas;}
                                set{numeroDePortas = value;}}

    private bool flex {get{return flex;}
                       set{flex = value;}}

    public Carro (string cor, decimal valor, string nome, int potencia, string placa, DateTime dataDeFabricacao, int numeroDePortas, bool flex)
    :base(cor, valor, nome, potencia, placa, dataDeFabricacao){
        this.numeroDePortas = numeroDePortas;
        this.flex = flex;
    }
}