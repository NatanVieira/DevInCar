using DevInCar.Excecoes;
namespace DevInCar.Models;

public class MotoOuTriciculo : Veiculo {

    public int numeroDeRodas;
    public MotoOuTriciculo(){
        
    }

    public MotoOuTriciculo(string cor, decimal valor, string nome,int potencia, string placa, DateTime dataDeFabricacao, int numeroDeRodas)
    :base(cor, valor, nome, potencia, placa, dataDeFabricacao){
      this.NumeroDeRodas = numeroDeRodas;
    }

    public override void FormataInformacoes()
    {
        base.FormataInformacoes();
    }
    public override string ListarInformacoes() => @$"Informações do Veículo:
Cor: {this.Cor}
Valor: {this.Valor.ToString("c")}
Nome: {this.Nome}
Placa: {this.Placa}
Dt. Fabricação: {this.DataDeFabricacao.ToShortDateString()}
N. Chassi: {this.NumeroChassi}
TIPO: {this.DevolveTipoDeVeiculo()}";

    private string DevolveTipoDeVeiculo() => this.NumeroDeRodas == 2 ? "MOTO" : "TRICICULO";

    public int NumeroDeRodas {get{return numeroDeRodas;} 
                              set {if(value >= 2 && value <= 3)
                                       numeroDeRodas = value;
                                   else
                                       throw new NumeroDeRodasMotoOuTriciculoException("Número de rodas inválido");}}
}