namespace DevInCar.Excecoes;

public class DiretorioCriacaoException : Exception {

    public DiretorioCriacaoException(){}
    public DiretorioCriacaoException(string diretorio)
    :base(String.Format($"Não foi possível criar o diretório {diretorio}")){}
}