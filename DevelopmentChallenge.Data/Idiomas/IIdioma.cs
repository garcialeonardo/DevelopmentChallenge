namespace DevelopmentChallenge.Data.Classes
{
    public interface IIdioma
    {
        string Header();
        string HeaderSinFormas();
        string Linea(int totalFormaEspecifica, string formaEspecifica, decimal perimetroFormaEspecifica, decimal areaFormaEspecifica);
        string LineaTotal(int totalFormas, decimal perimetroTotal, decimal areaTotal);
        string Traducir(string forma, int cantidad);
    }
}
