namespace DevInCar.Models;

public class Veiculo {

    public int NumeroChassi {get; set;}
    public DateTime DataDeFabricacao {get; set;}
    public string Nome {get; set;}
    public string Placa {get; set;}
    public decimal Valor {get; set;}
    public string Cpf {get; set;}
    public string Cor {get; set;}
    public int Potencia {get; set;}
    
    public Veiculo(){
        this.Nome = "";
        this.Placa = "";
        this.Cor = "";
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
    public void VenderVeiculo(string cpf){
        this.Cpf = cpf;
    }
    public string ListarInformacoes(){
        return $"Informações do Veículo:\nCor:{this.Cor}\nValor: {this.Valor.ToString("c")}\nNome: {this.Nome}\nPlaca: {this.Placa}\nDt. Fabricação: {this.DataDeFabricacao.ToShortDateString()}\nN. Chassi: {this.NumeroChassi}";
    }
    public void AlterarInformacoes(string cor, decimal valor){
        this.Cor = cor;
        this.Valor = valor;
    }
}