namespace DevInCar.Excecoes;

public class DiretorioInexistenteException : Exception {

    public DiretorioInexistenteException() {}

    public DiretorioInexistenteException(string diretorio)
    :base(String.Format($"Diretório para salvar arquivos não existe e não pode ser criado. {diretorio}")){}
}