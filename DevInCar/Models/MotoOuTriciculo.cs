namespace DevInCar.Models;

public class MotoOuTriciculo : Veiculo {

    private int numeroDeRodas {get{return numeroDeRodas;}
                               set{numeroDeRodas = value;}}

    public MotoOuTriciculo(string cor, decimal valor, string nome,int potencia, string placa, DateTime dataDeFabricacao, int numeroDeRodas)
    :base(cor, valor, nome, potencia, placa, dataDeFabricacao){
      this.numeroDeRodas = numeroDeRodas;
    }
    
}