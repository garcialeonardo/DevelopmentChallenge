using DevelopmentChallenge.Data.Classes;

public class IdiomaItaliano : IIdioma
{
    public string Header() => "<h1>Rapporto sulle forme</h1>";
    public string HeaderSinFormas() => "<h1>Elenco vuoto di forme!</h1>";
    public string Linea(int totalFormaEspecifica, string formaEspecifica, decimal perimetroFormaEspecifica, decimal areaFormaEspecifica) =>
        $"{totalFormaEspecifica} {Traducir(formaEspecifica, totalFormaEspecifica)} | Perimetro {perimetroFormaEspecifica:#.##} | Area {areaFormaEspecifica:#.##} <br/>";
    public string LineaTotal(int totalFormas, decimal perimetroTotal, decimal areaTotal) =>
        $"TOTAL:<br/>{totalFormas} forme | Perimetro {perimetroTotal:#.##} | Area {areaTotal:#.##}";
    public string Traducir(string forma, int cantidad)
    {
        switch (forma)
        {
            case "Cuadrado":
                return cantidad == 1 ? "Piazza" : "Piazze";
            case "Circulo":
                return cantidad == 1 ? "Cerchio" : "Cerchi";
            case "TrianguloEquilatero":
                return cantidad == 1 ? "Triangolo Equilatero" : "Triangoli Equilateri";
            case "TrapecioRectangulo":
                return cantidad == 1 ? "Trapezio Rettangolare" : "Trapezi Rettangolari";
            default:
                return "";
        }
    }
}