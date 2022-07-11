using DevInCar.Excecoes;
namespace DevInCar.Models;

public class Camionete : Veiculo {

    public int NumeroDePortas {get; set;}
    public double CapacidadeCacamba {get;set;}

    public string? Combustivel {get;set;}
    
    public Camionete(){}
    public Camionete (string cor, decimal valor, string nome, int potencia, string placa, DateTime DataDeFabricacao, int numeroDePortas, double capacidadeCacamba, string combustivel)
    :base(cor, valor, nome, potencia, placa, DataDeFabricacao){
        if(cor.ToLower() != "roxo")
            throw new CorNaoPermitidaParaCamioneteException("Cor inválida");
        this.NumeroDePortas = numeroDePortas;
        this.CapacidadeCacamba = capacidadeCacamba;
        this.Combustivel = combustivel;
    } 

    public override void AlterarInformacoes(string? cor, decimal valor){
        if(cor?.ToLower() == "roxo")
            this.Cor = cor;
        else 
            throw new CorNaoPermitidaParaCamioneteException("Cor inválida.");
        this.Valor = valor;
    }
}