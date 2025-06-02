using DevelopmentChallenge.Data.Classes;

public class IdiomaCastellano : IIdioma
{
    public string Header() => "<h1>Reporte de Formas</h1>";
    public string HeaderSinFormas() => "<h1>Lista vacía de formas!</h1>";
    public string Linea(int totalFormaEspecifica, string formaEspecifica, decimal perimetroFormaEspecifica, decimal areaFormaEspecifica) =>
        $"{totalFormaEspecifica} {Traducir(formaEspecifica, totalFormaEspecifica)} | Perimetro {perimetroFormaEspecifica:#.##} | Area {areaFormaEspecifica:#.##} <br/>";
    public string LineaTotal(int totalFormas, decimal perimetroTotal, decimal areaTotal) =>
        $"TOTAL:<br/>{totalFormas} formas | Perimetro {perimetroTotal:#.##} | Area {areaTotal:#.##}";
    public string Traducir(string forma, int cantidad)
    {
        switch (forma)
        {
            case "Cuadrado":
                return cantidad == 1 ? "Cuadrado" : "Cuadrados";
            case "Circulo":
                return cantidad == 1 ? "Círculo" : "Círculos";
            case "TrianguloEquilatero":
                return cantidad == 1 ? "Triángulo Equilatero" : "Triángulos Equilateros";
            case "TrapecioRectangulo":
                return cantidad == 1 ? "Trapecio Rectángulo" : "Trapecios Rectángulos";
            default:
                return "";
        }
    }
}