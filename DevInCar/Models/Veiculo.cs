namespace DevInCar.Models;

public class Veiculo {

    private int numeroChassi;
    private DateTime dataDeFabricacao;

    private string nome;
    private string placa;
    private decimal valor;
    private string cpf;

    private string cor;
    private int potencia;
    
    public Veiculo(){
        this.nome = "";
        this.placa = "";
        this.cor = "";
        this.valor = 0M;
        this.numeroChassi = new Random().Next();
        this.cpf = "0";
    }
    public Veiculo (string cor, decimal valor, string nome, int potencia, string placa, DateTime dataDeFabricacao){
        this.cor = cor;
        this.valor = valor;
        this.nome = nome;
        this.potencia = potencia;
        this.placa = placa;
        this.dataDeFabricacao = dataDeFabricacao;
        this.cpf = "0";
        this.numeroChassi = new Random().Next();
    }
    public void VenderVeiculo(string cpf){
        this.cpf = cpf;
    }
    public string ListarInformacoes(){
        return $"Informações do Veículo:\nCor:{this.cor}\nValor: {this.valor.ToString("c")}\nNome: {this.nome}\nPlaca: {this.placa}\nDt. Fabricação: {this.dataDeFabricacao.ToShortDateString()}\nN. Chassi: {this.numeroChassi}";
    }
    public void AlterarInformacoes(string cor, decimal valor){
        this.cor = cor;
        this.valor = valor;
    }
    public string Nome {get{return nome;}
                        set{nome = value;}}
    public DateTime DataDeFabricacao {get{return dataDeFabricacao;}
                                      set{dataDeFabricacao = value;}}
    public string Placa {get{return placa;}
                         set{placa = value;}}
    public decimal Valor {get{return valor;}
                          set{valor = value;}}
    public string Cpf {get{return cpf;}
                       set{cpf = value;}}
    public string Cor {get{return cor;}
                       set{cor = value;}}
    public int Potencia {get{return potencia;}
                        set{potencia = value;}}
}