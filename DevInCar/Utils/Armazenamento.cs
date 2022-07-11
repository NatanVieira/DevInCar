using DevInCar.Models;

namespace DevInCar.Utils;

public class Armazenamento {
    private string pathArmazenamento = @"C:\DevInCar";
    public void ArmazenaVeiculos(List<Veiculo> veiculos){
        try{
            this.VerificaPathArmazenamento();
            using (StreamWriter sw = new StreamWriter(this.pathArmazenamento + "\\veiculos.csv")){
                veiculos.ForEach(veiculo => {
                    switch(veiculo.GetType().Name){
                        case "Carro":
                            Carro carro = (Carro)veiculo;
                            sw.WriteLine($"Carro;{carro.NumeroChassi.ToString()};{carro.DataDeFabricacao.ToShortDateString()};{carro.Nome};{carro.Placa};{carro.Valor.ToString()};{carro.Cpf};{carro.Cor};{carro.Potencia.ToString()};{carro.NumeroDePortas.ToString()};{carro.Flex.ToString()};");
                            break;
                        case "MotoOuTriciculo":
                             MotoOuTriciculo moto = (MotoOuTriciculo)veiculo;
                            sw.WriteLine($"Camionete;{moto.NumeroChassi.ToString()};{moto.DataDeFabricacao.ToShortDateString()};{moto.Nome};{moto.Placa};{moto.Valor.ToString()};{moto.Cpf};{moto.Cor};{moto.Potencia.ToString()};{moto.NumeroDeRodas.ToString()};");                           
                            break;
                        case "Camionete":
                            Camionete camionete = (Camionete)veiculo;
                            sw.WriteLine($"Camionete;{camionete.NumeroChassi.ToString()};{camionete.DataDeFabricacao.ToShortDateString()};{camionete.Nome};{camionete.Placa};{camionete.Valor.ToString()};{camionete.Cpf};{camionete.Cor};{camionete.Potencia.ToString()};{camionete.NumeroDePortas.ToString()};{camionete.Combustivel};{camionete.CapacidadeCacamba.ToString()};");
                            break;
                    }
                });
            }
        }
        catch(Exception ex){
            System.Console.WriteLine("Erro ao salvar veiculos");
        }
    }

    public void ArmazenaTransferencias(List<Transferencia> transferencias){
        try{
            this.VerificaPathArmazenamento();
            using (StreamWriter sw = new StreamWriter(this.pathArmazenamento + "\\transferencias.csv")){
                transferencias.ForEach(transferencia => {
                    sw.WriteLine($"{transferencia.DataCompra.ToShortDateString()};{transferencia.ValorCompra.ToString()};{transferencia.VeiculoCompra.NumeroChassi.ToString()};");
                });
            }
        }
        catch(Exception ex){
            System.Console.WriteLine("Erro ao salvar transferencias");
        }
    }

    private void VerificaPathArmazenamento(){
        if(!Directory.Exists(this.pathArmazenamento))
            this.CriaPathArmazenamento();
    }
    private void CriaPathArmazenamento(){
        Directory.CreateDirectory(this.pathArmazenamento);
    }
}