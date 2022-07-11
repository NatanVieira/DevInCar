namespace DevInCar.Excecoes;

public class CorNaoPermitidaParaCamioneteException : Exception {

    public CorNaoPermitidaParaCamioneteException(){}

    public CorNaoPermitidaParaCamioneteException(string mensagem)
    :base (String.Format("Camionete só permite a cor Roxa")){}
}