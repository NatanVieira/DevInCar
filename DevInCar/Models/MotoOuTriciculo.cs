namespace DevInCar.Models;

public class MotoOuTriciculo : Veiculo {

    public int NumeroDeRodas {get; set;}
    public MotoOuTriciculo(){
        
    }

    public MotoOuTriciculo(string cor, decimal valor, string nome,int potencia, string placa, DateTime dataDeFabricacao, int numeroDeRodas)
    :base(cor, valor, nome, potencia, placa, dataDeFabricacao){
      this.NumeroDeRodas = numeroDeRodas;
    }
  
}