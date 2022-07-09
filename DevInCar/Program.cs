using DevInCar.Models;
namespace DevInCar;

public class Program {

    static void Main(string[] args)
    {
        Veiculo v = new Veiculo("Azul",100.0M,"Opala",128,"AAA0000",DateTime.Now);

        System.Console.WriteLine(v.ListarInformacoes());
    }
}
