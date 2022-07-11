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

    public void RecuperaDadosVeiculos(List<Veiculo> veiculos){
        try{
            this.VerificaPathArmazenamento();
            using(StreamReader sr = new StreamReader(this.pathArmazenamento + "\\veiculos.csv")){
                string linha = sr.ReadLine();
                string[] dados;
                dados  = linha.Split(';');
                switch(dados[0]){
                    case "Carro":
                        Carro carro = new Carro(dados[7],
                                                Convert.ToDecimal(dados[5]),
                                                dados[3],
                                                Convert.ToInt32(dados[8]),
                                                dados[4],
                                                Convert.ToDateTime(dados[2]),
                                                Convert.ToInt32(dados[9]),
                                                Convert.ToBoolean(dados[10]));
                        if(dados[6] != "")
                            carro.VenderVeiculo(dados[6]);
                        veiculos.Add(carro);
                        break;
                    case "Camionete":
                        Camionete camionete = new Camionete(dados[7],
                                                            Convert.ToDecimal(dados[5]),
                                                            dados[3],
                                                            Convert.ToInt32(dados[8]),
                                                            dados[4],
                                                            Convert.ToDateTime(dados[2]),
                                                            Convert.ToInt32(dados[9]),
                                                            Convert.ToDouble(dados[10]),
                                                            dados[11]);
                        if(dados[6] != "")
                            camionete.VenderVeiculo(dados[6]);
                        veiculos.Add(camionete);
                        break;
                    case "Moto":
                        MotoOuTriciculo moto = new MotoOuTriciculo(dados[7],
                                                                   Convert.ToDecimal(dados[5]),
                                                                   dados[3],
                                                                   Convert.ToInt32(dados[8]),
                                                                   dados[4],
                                                                   Convert.ToDateTime(dados[2]),
                                                                   Convert.ToInt32(dados[9]));
                        if(dados[6] != "")
                            moto.VenderVeiculo(dados[6]);
                        veiculos.Add(moto);
                        break;
                }
            }
        }
        catch(Exception ex){
            System.Console.WriteLine(ex.Message);
        }
    }

    public void RecuperaDadosTransferencias(List<Transferencia> transferencias, List<Veiculo> veiculos){
        try{
            this.VerificaPathArmazenamento();
            using(StreamReader sr = new StreamReader(this.pathArmazenamento + "\\transferencias.csv")){
                var linha = sr.ReadLine();
                string[] dados = linha.Split(';');
                Transferencia transferencia = new Transferencia();
                transferencia.DataCompra = Convert.ToDateTime(dados[0]);
                transferencia.ValorCompra = Convert.ToDecimal(dados[1]);
                Veiculo veiculo = veiculos.Find(x => x.NumeroChassi == Convert.ToInt32(dados[2]));
                transferencia.VeiculoCompra = veiculo;
                transferencias.Add(transferencia);
            }
        }
        catch(Exception ex){
            System.Console.WriteLine(ex.Message);
        }
    }
}