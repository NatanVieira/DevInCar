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

    public static void CadastroInfosCabecalho(string tipoVeiculo){
        System.Console.Clear();
        if(tipoVeiculo.ToLower() == "carro")
            System.Console.WriteLine("Cadastro de novo carro");
        else
            System.Console.WriteLine($"Cadastro de nova {tipoVeiculo}");
    }

    public static void VeiculoCadastradoComSucesso(string tipoVeiculo){
        System.Console.Clear();
        if(tipoVeiculo.ToLower() == "carro")
            System.Console.WriteLine("Carro cadastrado com sucesso.");
        else
            System.Console.WriteLine($"{tipoVeiculo} cadastro com sucesso.");
        Thread.Sleep(1000);
    }
    public static void ErroAoCadastrar(string mensagem){
        System.Console.Clear();
        System.Console.WriteLine($"Erro ao cadastrar!!! {mensagem}. Tente novamente.");
        Thread.Sleep(1000);
    }
}