namespace DevInCar.Models;

public class Carro : Veiculo {

    public int NumeroDePortas {get;set;}
    public bool Flex {get;set;}
    public Carro(){}
    public Carro (string cor, decimal valor, string nome, int potencia, string placa, DateTime dataDeFabricacao, int numeroDePortas, bool flex)
    :base(cor, valor, nome, potencia, placa, dataDeFabricacao){
        this.NumeroDePortas = numeroDePortas;
        this.Flex = flex;
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
Num. Portas: {this.NumeroDePortas}
Combustivel: {this.DevolveDescricaoCombustivel()}";

    private string DevolveDescricaoCombustivel() => this.Flex ? "FLEX" : "GASOLINA";
}