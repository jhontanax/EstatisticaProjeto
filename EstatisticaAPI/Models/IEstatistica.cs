namespace EstatisticaAPI.Models
{
    public interface IEstatistica
    {
        double CalcularMediana(string[] valores);
        double CalcularModa(string[] valores);
        double CalcularMedia(string[] valores);
        double CalcularMaximo(string[] valores);
        double CalcularMinimo(string[] valores);
        double CalcularMediaPonderada(string[] valores);
        double CalcularDesvioPadrao(string[] valores);
    }
}