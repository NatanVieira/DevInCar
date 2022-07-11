namespace DevInCar.Excecoes;

public class PlacaRepetidaException : Exception {

    public PlacaRepetidaException(){}

    public PlacaRepetidaException(string mensagem)
    :base(String.Format($"{mensagem}")){}
}