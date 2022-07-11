using DevInCar.Models;
using DevInCar.Excecoes;

namespace DevInCarTestes;

public class TesteCorRoxaCamionete {

    [Theory]
    [InlineData("roxo")]
    [InlineData("Roxo")]
    public void Teste_Cor_Roxa_Para_Camionete_Sucesso(string cor){
        Camionete camionete = new Camionete();
        camionete.AlterarInformacoes(cor, 200M);
    }

    [Theory]
    [InlineData("vermelha")]
    [InlineData("azul")]
    public void Teste_Cor_Roxa_Para_Camionete_Erro(string cor){
        Camionete camionete = new Camionete();
        camionete.AlterarInformacoes(cor, 200M);
    }
}