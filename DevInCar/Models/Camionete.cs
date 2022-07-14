using DevInCar.Excecoes;
namespace DevInCar.Models;

public class Camionete : Veiculo {

    public int NumeroDePortas {get;set;}
    public double CapacidadeCacamba {get;set;}

    public bool Diesel {get;set;}
    
    public Camionete(){}
    public Camionete (string cor, decimal valor, string nome, int potencia, string placa, DateTime DataDeFabricacao, int numeroDePortas, double capacidadeCacamba, bool diesel)
    :base(cor, valor, nome, potencia, placa, DataDeFabricacao){
        if(cor != "ROXO" && cor != "ROXA")
            throw new CorNaoPermitidaParaCamioneteException("Cor inválida");
        this.NumeroDePortas = numeroDePortas;
        this.CapacidadeCacamba = capacidadeCacamba;
        this.Diesel = diesel;
    } 

    public override void AlterarInformacoes(string? cor, decimal valor){
        if(cor == "ROXO" || cor == "ROXA")
            this.Cor = cor;
        else 
            throw new CorNaoPermitidaParaCamioneteException("Cor inválida.");
        this.Valor = valor;
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
Combustivel: {this.DevolveDescricaoCombustivel()}
Num. Portas: {this.NumeroDePortas}
Capacidade da caçamba: {this.CapacidadeCacamba}";

    private string DevolveDescricaoCombustivel() => this.Diesel ? "DIESEL" : "GASOLINA";
}