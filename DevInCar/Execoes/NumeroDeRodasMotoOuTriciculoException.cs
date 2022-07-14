namespace DevInCar.Excecoes;

public class NumeroDeRodasMotoOuTriciculoException : Exception {

    public NumeroDeRodasMotoOuTriciculoException(){}

    public NumeroDeRodasMotoOuTriciculoException(string mensagem)
    :base($"{mensagem}"){}
}