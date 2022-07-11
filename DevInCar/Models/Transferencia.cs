namespace DevInCar.Models;

public class Transferencia {

    public decimal ValorCompra {get; set;}
    public DateTime DataCompra {get; set;}
    public Veiculo VeiculoCompra {get; set;}

    public Transferencia(){}
    public Transferencia (decimal valorCompra, DateTime dataCompra, Veiculo veiculo){
        this.ValorCompra = valorCompra;
        this.DataCompra = dataCompra;
        this.VeiculoCompra = veiculo;
    }
}