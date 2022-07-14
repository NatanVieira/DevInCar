using DevInCar.Models;
namespace DevInCar.Utils;

public static class Desenho {

    public static void DesenhaMenuInicial(){
        Console.Clear();
        Console.WriteLine("|============== DEV IN CAR ==============|");
        Console.WriteLine("| 1 - Cadastrar novo carro               |");
        Console.WriteLine("| 2 - Vender um carro                    |");
        Console.WriteLine("| 3 - Listar carros                      |");
        Console.WriteLine("|                                        |");
        Console.WriteLine("|                                        |");
        Console.WriteLine("| Pressione qualquer tecla para sair     |");
        Console.WriteLine("|========================================|");
    }

    public static void FinalizaPrograma(){
        Console.Clear();
        Console.WriteLine("Finalizando programa ...");
    }

    public static void CadastroNovoVeiculoInicial(){
        Console.Clear();
        Console.WriteLine("Para cadastrar um novo veículo preencha as informações abaixo:");
        Console.WriteLine("Tipo de veiculo: ");
        Console.WriteLine("1 - Carro");
        Console.WriteLine("2 - Camionete");
        Console.WriteLine("3 - Moto/Triciculo");
        Console.WriteLine("0 - Voltar ao menu inicial");
    }

    public static void OpcaoInvalida(){
        Console.Clear();
        Console.WriteLine("Opção inválida, tente novamente...");
        Thread.Sleep(1000);
    }

    public static void CadastroInfosCabecalho(string? tipoVeiculo){
        Console.Clear();
        if(tipoVeiculo?.ToLower() == "carro")
            Console.WriteLine("Cadastro de novo carro");
        else
            Console.WriteLine($"Cadastro de nova {tipoVeiculo}");
    }

    public static void VeiculoCadastradoComSucesso(string? tipoVeiculo){
        Console.Clear();
        if(tipoVeiculo?.ToLower() == "carro")
            Console.WriteLine("Carro cadastrado com sucesso.");
        else
            Console.WriteLine($"{tipoVeiculo} cadastro com sucesso.");
        Thread.Sleep(1000);
    }
    public static void ErroAoCadastrar(string? mensagem){
        Console.Clear();
        Console.WriteLine($"Erro ao cadastrar!!! {mensagem}. Tente novamente.");
        Thread.Sleep(1000);
    }

    public static void VendaVeiculoCabecalho(){
        Console.Clear();
        Console.WriteLine("Venda de veiculo");
    }
    
    public static void VeiculoInexistente(){
        Console.Clear();
        Console.WriteLine("Veículo inexistente, escolha outro...");
        Thread.Sleep(1000);
    }

    public static void ErroAoVender(string? nomeVeiculo){
        Console.Clear();
        Console.WriteLine("Erro ao cadastrar venda de carro, tente novamente...");
        Thread.Sleep(1000);
    }

    public static void VendaVeiculoComSucesso(string? nomeVeiculo){
        Console.Clear();
        Console.WriteLine($"{nomeVeiculo} vendido com sucesso!!");
        Thread.Sleep(1000);
    }

    public static void VeiculoJaVendido(string? nomeVeiculo){
        Console.Clear();
        Console.WriteLine($"{nomeVeiculo} já foi vendido, escolha outro veículo.");
        Thread.Sleep(1000);
    }

    public static void ListagemVeiculosInicial(){
        Console.Clear();
        Console.WriteLine("Escolha o tipo de veículo da listagem:");
        Console.WriteLine("1 - Carros");
        Console.WriteLine("2 - Camionetes");
        Console.WriteLine("3 - Motos/Triciculos");
        Console.WriteLine("4 - Todos");
        Console.WriteLine("0 - Voltar ao menu inicial");
    }

    public static void ListagemVeiculosSecundaria(string? tipoVeiculo){
        if(tipoVeiculo == "todos")
            tipoVeiculo = "veiculo";
        Console.Clear();
        Console.WriteLine("Escolha o tipo de listagem que deseja:");
        Console.WriteLine($"1 - {tipoVeiculo}(s) disponiveis");
        Console.WriteLine($"2 - {tipoVeiculo}(s) vendidos");
        Console.WriteLine($"3 - {tipoVeiculo} vendido com maior preço");
        Console.WriteLine($"4 - {tipoVeiculo} vendido com menor preço");
        Console.WriteLine($"5 - Todos");
    }

    public static void ListagemSemDados(){
        Console.Clear();
        Console.WriteLine("Não há dados para mostrar...");
        Thread.Sleep(1000);
    }

    public static void ListagemVeiculos(List<Veiculo> veiculos){
        Console.Clear();
        Console.WriteLine("Listagem de veiculos:");
        veiculos.ForEach(veiculo => {
            Console.WriteLine("---------------------");
            Console.WriteLine(veiculo.ListarInformacoes());
            Console.WriteLine("---------------------");
        });
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu...");
        Console.ReadLine();
    }
}