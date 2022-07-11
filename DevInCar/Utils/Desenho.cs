using DevInCar.Models;
namespace DevInCar.Utils;

public static class Desenho {

    public static void DesenhaMenuInicial(){
        System.Console.Clear();
        System.Console.WriteLine("|============== DEV IN CAR ==============|");
        System.Console.WriteLine("| 1 - Cadastrar novo carro               |");
        System.Console.WriteLine("| 2 - Vender um carro                    |");
        System.Console.WriteLine("| 3 - Listar carros                      |");
        System.Console.WriteLine("|                                        |");
        System.Console.WriteLine("|                                        |");
        System.Console.WriteLine("| Pressione qualquer tecla para sair     |");
        System.Console.WriteLine("|========================================|");
    }

    public static void FinalizaPrograma(){
        System.Console.Clear();
        System.Console.WriteLine("Finalizando programa ...");
    }

    public static void CadastroNovoVeiculoInicial(){
        System.Console.Clear();
        System.Console.WriteLine("Para cadastrar um novo veículo preencha as informações abaixo:");
        System.Console.WriteLine("Tipo de veiculo: ");
        System.Console.WriteLine("1 - Carro");
        System.Console.WriteLine("2 - Camionete");
        System.Console.WriteLine("3 - Moto/Triciculo");
        System.Console.WriteLine("0 - Voltar ao menu inicial");
    }

    public static void OpcaoInvalida(){
        System.Console.Clear();
        System.Console.WriteLine("Opção inválida, tente novamente...");
        Thread.Sleep(1000);
    }

    public static void CadastroInfosCabecalho(string? tipoVeiculo){
        System.Console.Clear();
        if(tipoVeiculo?.ToLower() == "carro")
            System.Console.WriteLine("Cadastro de novo carro");
        else
            System.Console.WriteLine($"Cadastro de nova {tipoVeiculo}");
    }

    public static void VeiculoCadastradoComSucesso(string? tipoVeiculo){
        System.Console.Clear();
        if(tipoVeiculo?.ToLower() == "carro")
            System.Console.WriteLine("Carro cadastrado com sucesso.");
        else
            System.Console.WriteLine($"{tipoVeiculo} cadastro com sucesso.");
        Thread.Sleep(1000);
    }
    public static void ErroAoCadastrar(string? mensagem){
        System.Console.Clear();
        System.Console.WriteLine($"Erro ao cadastrar!!! {mensagem}. Tente novamente.");
        Thread.Sleep(1000);
    }

    public static void VendaVeiculoCabecalho(){
        System.Console.Clear();
        System.Console.WriteLine("Venda de veiculo");
    }
    
    public static void VeiculoInexistente(){
        System.Console.Clear();
        System.Console.WriteLine("Veículo inexistente, escolha outro...");
        Thread.Sleep(1000);
    }

    public static void ErroAoVender(string? nomeVeiculo){
        System.Console.Clear();
        System.Console.WriteLine("Erro ao cadastrar venda de carro, tente novamente...");
        Thread.Sleep(1000);
    }

    public static void VendaVeiculoComSucesso(string? nomeVeiculo){
        System.Console.Clear();
        System.Console.WriteLine($"{nomeVeiculo} vendido com sucesso!!");
        Thread.Sleep(1000);
    }

    public static void VeiculoJaVendido(string? nomeVeiculo){
        System.Console.Clear();
        System.Console.WriteLine($"{nomeVeiculo} já foi vendido, escolha outro veículo.");
        Thread.Sleep(1000);
    }

    public static void ListagemVeiculosInicial(){
        System.Console.Clear();
        System.Console.WriteLine("Escolha o tipo de veículo da listagem:");
        System.Console.WriteLine("1 - Carros");
        System.Console.WriteLine("2 - Camionetes");
        System.Console.WriteLine("3 - Motos/Triciculos");
        System.Console.WriteLine("4 - Todos");
        System.Console.WriteLine("0 - Voltar ao menu inicial");
    }

    public static void ListagemVeiculosSecundaria(string? tipoVeiculo){
        if(tipoVeiculo == "todos")
            tipoVeiculo = "veiculo";
        System.Console.Clear();
        System.Console.WriteLine("Escolha o tipo de listagem que deseja:");
        System.Console.WriteLine($"1 - {tipoVeiculo}(s) disponiveis");
        System.Console.WriteLine($"2 - {tipoVeiculo}(s) vendidos");
        System.Console.WriteLine($"3 - {tipoVeiculo} vendido com maior preço");
        System.Console.WriteLine($"4 - {tipoVeiculo} vendido com menor preço");
        System.Console.WriteLine($"5 - Todos");
    }

    public static void ListagemSemDados(){
        System.Console.Clear();
        System.Console.WriteLine("Não há dados para mostrar...");
        Thread.Sleep(1000);
    }

    public static void ListagemVeiculos(List<Veiculo> veiculos){
        System.Console.Clear();
        System.Console.WriteLine("Listagem de veiculos:");
        veiculos.ForEach(veiculo => {
            System.Console.WriteLine("---------------------");
            System.Console.WriteLine(veiculo.ListarInformacoes());
            System.Console.WriteLine("---------------------");
        });
        System.Console.WriteLine("Aperte qualquer tecla para voltar ao menu...");
        System.Console.ReadLine();
    }
}