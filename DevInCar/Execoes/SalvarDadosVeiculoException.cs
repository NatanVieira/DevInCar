namespace DevInCar.Excecoes;

public class SalvarDadosVeiculoException : Exception {
    public SalvarDadosVeiculoException(){}

    public SalvarDadosVeiculoException(string mensagem)
    :base(String.Format($"Não foi possível salvar os dados dos veículos: {mensagem}")){}
}