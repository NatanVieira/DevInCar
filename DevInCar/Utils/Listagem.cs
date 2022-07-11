using DevInCar.Models;
namespace DevInCar.Utils;

public static class Listagem {

    public static void listarVericulo(List<Veiculo> veiculos){
        string? escolha = "0";
        string? segundaEscolha = "0";
        do{
            Desenho.ListagemVeiculosInicial();
            escolha = System.Console.ReadLine();
            switch(escolha){
                case "1":
                    Desenho.ListagemVeiculosSecundaria("carro");
                    segundaEscolha = System.Console.ReadLine();
                    Listagem.ImprimeLista(segundaEscolha,"Carro", veiculos);
                    break;
                case "2":
                    Desenho.ListagemVeiculosSecundaria("camionete");
                    segundaEscolha = System.Console.ReadLine();
                    Listagem.ImprimeLista(segundaEscolha,"Camionete", veiculos);
                    break;
                case "3":
                    Desenho.ListagemVeiculosSecundaria("moto/triciculo");
                    segundaEscolha = System.Console.ReadLine();
                    Listagem.ImprimeLista(segundaEscolha,"MotoOuTriciculo", veiculos);
                    break;
                case "4":
                    Desenho.ListagemVeiculosSecundaria("todos");
                    segundaEscolha = System.Console.ReadLine();
                    Listagem.ImprimeLista(segundaEscolha,"todos", veiculos);
                    break;
                case "0":
                    break;
                default:
                    Desenho.OpcaoInvalida();
                    Listagem.listarVericulo(veiculos);
                    break;
            }
        }while(escolha == "1" || escolha == "2" || escolha == "3" || escolha == "4");
    }

    public static void ImprimeLista(string? escolha, string tipo, List<Veiculo> veiculos){
        switch(escolha){
            case "1":
                Listagem.ImprimeDisponiveis(tipo, veiculos);
                break;
            case "2":
                Listagem.ImprimeVendidos(tipo, veiculos);
                break;
            case "3":
                Listagem.ImprimeVendidoMaiorPreco(tipo, veiculos);
                break;
            case "4":
                Listagem.ImprimeVendidoMenorPreco(tipo, veiculos);
                break;
            case "5":
                Listagem.ImprimeTodos(tipo, veiculos);
                break;
            default:
                break;
        }
    }

    public static void ImprimeDisponiveis(string tipo, List<Veiculo> veiculos){
        List<Veiculo> veiculosListagem = tipo != "todos" ? veiculos.FindAll(x => x.GetType().Name == tipo && x.Cpf == "0") : veiculos.FindAll(X => X.Cpf == "0");
        if(veiculosListagem.Count > 0){
            Desenho.ListagemVeiculos(veiculosListagem);
        }
        else
            Desenho.ListagemSemDados();
    }
    public static void ImprimeVendidos(string tipo, List<Veiculo> veiculos){
        List<Veiculo> veiculosListagem = tipo != "todos" ? veiculos.FindAll(x => x.GetType().Name == tipo && x.Cpf != "0") : veiculos.FindAll(x => x.Cpf != "0");
        if(veiculosListagem.Count > 0){
            Desenho.ListagemVeiculos(veiculosListagem);
        }
        else
            Desenho.ListagemSemDados();
    }

    public static void ImprimeVendidoMaiorPreco(string tipo, List<Veiculo> veiculos){
        List<Veiculo> veiculosListagem = tipo != "todos" ? veiculos.FindAll(x => x.GetType().Name == tipo && x.Cpf != "0") : veiculos.FindAll(x => x.Cpf != "0");
        Veiculo veiculoMaiorPreco = new Veiculo();
        veiculoMaiorPreco.Valor = 0M;
        if(veiculosListagem.Count > 0){
            veiculosListagem.ForEach(veiculo => {
               veiculoMaiorPreco = veiculo.Valor >= veiculoMaiorPreco.Valor ? veiculo : veiculoMaiorPreco; 
            });
            veiculosListagem.Clear();
            veiculosListagem.Add(veiculoMaiorPreco);
            Desenho.ListagemVeiculos(veiculosListagem);
        }
        else
            Desenho.ListagemSemDados();
    }

    public static void ImprimeVendidoMenorPreco(string tipo, List<Veiculo> veiculos){
        List<Veiculo> veiculosListagem = tipo != "todos" ? veiculos.FindAll(x => x.GetType().Name == tipo && x.Cpf != "0") : veiculos.FindAll(x => x.Cpf != "0");
        Veiculo veiculoMenorPreco = new Veiculo();
        veiculoMenorPreco.Valor = 100000000000M;
        if(veiculosListagem.Count > 0){
            veiculosListagem.ForEach(veiculo => {
                veiculoMenorPreco = veiculo.Valor <= veiculoMenorPreco.Valor ? veiculo : veiculoMenorPreco;
            });
            veiculosListagem.Clear();
            veiculosListagem.Add(veiculoMenorPreco);
            Desenho.ListagemVeiculos(veiculosListagem);
        }
        else
            Desenho.ListagemSemDados();
    }

    public static void ImprimeTodos(string tipo, List<Veiculo> veiculos){
        List<Veiculo> veiculosListagem = tipo != "todos" ? veiculos.FindAll(x => x.GetType().Name == tipo) : veiculos;
        if(veiculosListagem.Count > 0){
            Desenho.ListagemVeiculos(veiculosListagem);
        }
        else
            Desenho.ListagemSemDados();
    }
}