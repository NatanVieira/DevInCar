using DevInCar.Excecoes;
using DevInCar.Models;
namespace DevInCar.Utils;
public static class Cadastro {

    public static void novoVeiculo(List<Veiculo> veiculos){
        Desenho.CadastroNovoVeiculoInicial();
        var escolha = Console.ReadLine();
        if(escolha == "1" || escolha == "2" || escolha == "3" || escolha == "0"){
            switch(escolha){
                case "1":
                    try{
                        Carro novoCarro = new Carro();
                        Cadastro.InfoBasicaVeiculo(novoCarro, "carro");
                        Cadastro.NovoCarro(novoCarro,"carro");
                        VerificaPlacaRepetida(novoCarro, veiculos);
                        veiculos.Add(novoCarro);
                        Desenho.VeiculoCadastradoComSucesso("carro");
                    }
                    catch(PlacaRepetidaException ex){
                        Desenho.ErroAoCadastrar(ex.Message);
                    }
                    catch(Exception ex){
                        Desenho.ErroAoCadastrar($"Dados de tipo inválido, {ex.Message}");
                    }
                    break;
                case "2":
                    try{
                        Camionete novaCamionete = new Camionete();
                        Cadastro.InfoBasicaVeiculo(novaCamionete, "camionete");
                        Cadastro.NovaCamionete(novaCamionete,"camionete");
                        VerificaPlacaRepetida(novaCamionete, veiculos);
                        veiculos.Add(novaCamionete);
                        Desenho.VeiculoCadastradoComSucesso("camionete");
                    }
                    catch(CorNaoPermitidaParaCamioneteException ex){
                        Desenho.ErroAoCadastrar(ex.Message);
                    }
                    catch(PlacaRepetidaException ex){
                        Desenho.ErroAoCadastrar(ex.Message);
                    }
                    catch(Exception ex){
                        Desenho.ErroAoCadastrar($"Dados de tipo inválido, {ex.Message}");
                    }
                    break;
                case "3":
                    try{
                        MotoOuTriciculo novaMoto = new MotoOuTriciculo();
                        Cadastro.InfoBasicaVeiculo(novaMoto, "moto");
                        Cadastro.NovaMotoOuTriciculo(novaMoto,"moto");
                        VerificaPlacaRepetida(novaMoto, veiculos);
                        veiculos.Add(novaMoto);
                        Desenho.VeiculoCadastradoComSucesso("moto ou triciculo");
                    }
                    catch(PlacaRepetidaException ex){
                        Desenho.ErroAoCadastrar(ex.Message);
                    }
                    catch(Exception ex){
                        Desenho.ErroAoCadastrar($"Dados de tipo inválido, {ex.Message}");
                    }
                    break;
                case "0":
                    break;
            }
        }
        else {
            Desenho.OpcaoInvalida();
            Cadastro.novoVeiculo(veiculos);
        }
    }

    public static void InfoBasicaVeiculo(Veiculo veiculo, string tipoVeiculo){
        Desenho.CadastroInfosCabecalho(tipoVeiculo);
        Console.Write("Nome: ");
        veiculo.Nome = Console.ReadLine();
        Desenho.CadastroInfosCabecalho(tipoVeiculo);
        Console.Write("Cor: ");
        string? cor = Console.ReadLine();
        Desenho.CadastroInfosCabecalho(tipoVeiculo);
        Console.Write("Valor: ");
        decimal valor = Convert.ToDecimal(Console.ReadLine());
        veiculo.AlterarInformacoes(cor, valor);
        Desenho.CadastroInfosCabecalho(tipoVeiculo);
        Console.Write("Placa: ");
        veiculo.Placa = Console.ReadLine();
        Desenho.CadastroInfosCabecalho(tipoVeiculo);
        Console.Write("Potência: ");
        veiculo.Potencia = Convert.ToInt32(Console.ReadLine());
        Desenho.CadastroInfosCabecalho(tipoVeiculo);
        Console.Write("Data de Fabricação (dd/MM/AAAA): ");
        veiculo.DataDeFabricacao = Convert.ToDateTime(Console.ReadLine());
    }
    public static void NovoCarro(Carro carro,string tipoVeiculo){
        Desenho.CadastroInfosCabecalho(tipoVeiculo);
        Console.Write("Flex?[s/n]: ");
        carro.Flex = Console.ReadLine() == "s" ? true : false;
        Desenho.CadastroInfosCabecalho(tipoVeiculo);
        Console.Write("Número de portas: ");
        carro.NumeroDePortas = Convert.ToInt32(Console.ReadLine());
    }

    public static void NovaMotoOuTriciculo(MotoOuTriciculo moto, string tipoVeiculo){
        Desenho.CadastroInfosCabecalho(tipoVeiculo);
        Console.Write("Número de rodas: ");
        moto.NumeroDeRodas= Convert.ToInt32(Console.ReadLine());
    }

    public static void NovaCamionete(Camionete camionete, string tipoVeiculo){
        Desenho.CadastroInfosCabecalho(tipoVeiculo);
        Console.Write("Combustivel: ");
        camionete.Combustivel = Console.ReadLine();
        Desenho.CadastroInfosCabecalho(tipoVeiculo);
        Console.Write("Número de portas: ");
        camionete.NumeroDePortas = Convert.ToInt32(Console.ReadLine());
        Desenho.CadastroInfosCabecalho(tipoVeiculo);
        Console.Write("Capacidade da caçamba em litros: ");
        camionete.CapacidadeCacamba = Convert.ToDouble(Console.ReadLine());
    }

    private static void VerificaPlacaRepetida(Veiculo veiculo, List<Veiculo> veiculos){
        Veiculo? veiculoAuxiliar = veiculos.Find(x => x.Placa == veiculo.Placa);
        if(veiculoAuxiliar != null)
            throw new PlacaRepetidaException($"Placa já está registrada para o veículo: {veiculoAuxiliar.Nome}");
    }
}