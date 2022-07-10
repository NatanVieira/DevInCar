using DevInCar.Models;
using DevInCar.Utils;
namespace DevInCar;

public class Program {

    static void Main(string[] args)
    {
        List<Veiculo> veiculos = new List<Veiculo>();
        var escolha = "1";
        do{
            Desenho.DesenhaMenuInicial();
            escolha = System.Console.ReadLine();
            switch(escolha){
                case "1":
                    Cadastro.novoVeiculo(veiculos);
                    break;
                case "2":
                    Venda.VendaVeiculo(veiculos);
                    break;
                case "3":
                    break;
                default:
                    Desenho.FinalizaPrograma();
                    break;
            }
        }while(escolha == "1" || escolha == "2" || escolha == "3");
    }
}
