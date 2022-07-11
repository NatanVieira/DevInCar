namespace DevInCar.Excecoes;

public class SalvarDadosTransferenciasException : Exception {
    
    public SalvarDadosTransferenciasException(){}

    public SalvarDadosTransferenciasException(string mensagem)
    :base(String.Format($"Não foi possível salvar os dados de transferência: {mensagem}")){}
}