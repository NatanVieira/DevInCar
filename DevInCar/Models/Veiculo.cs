namespace DevInCar.Models;

public class Veiculo {

    public int NumeroChassi {get; set;}
    public DateTime DataDeFabricacao {get; set;}
    public string? Nome {get; set;}
    public string? Placa {get; set;}
    public decimal Valor {get; set;}
    public string? Cpf {get; set;}
    public string? Cor {get; set;}
    public int Potencia {get; set;}
    
    public Veiculo(){
        this.Valor = 0M;
        this.NumeroChassi = new Random().Next();
        this.Cpf = "0";
    }
    public Veiculo (string cor, decimal valor, string nome, int potencia, string placa, DateTime dataDeFabricacao){
        this.Cor = cor;
        this.Valor = valor;
        this.Nome = nome;
        this.Potencia = potencia;
        this.Placa = placa;
        this.DataDeFabricacao = dataDeFabricacao;
        this.Cpf = "0";
        this.NumeroChassi = new Random().Next();
    }
    public void VenderVeiculo(string? cpf){
        this.Cpf = cpf;
    }
    public string ListarInformacoes() => @$"Informações do Veículo:
Cor: {this.Cor}
Valor: {this.Valor.ToString("c")}
Nome: {this.Nome}
Placa: {this.Placa}
Dt. Fabricação: {this.DataDeFabricacao.ToShortDateString()}
N. Chassi: {this.NumeroChassi}";
    public virtual void AlterarInformacoes(string? cor, decimal valor){
        this.Cor = cor;
        this.Valor = valor;
    }
}