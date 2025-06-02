using DevelopmentChallenge.Data.Classes;

public class IdiomaIngles : IIdioma
{
    public string Header() => "<h1>Shapes report</h1>";
    public string HeaderSinFormas() => "<h1>Empty list of shapes!</h1>";
    public string Linea(int totalFormaEspecifica, string formaEspecifica, decimal perimetroFormaEspecifica, decimal areaFormaEspecifica) =>
        $"{totalFormaEspecifica} {Traducir(formaEspecifica, totalFormaEspecifica)} | Perimeter {perimetroFormaEspecifica:#.##} | Area {areaFormaEspecifica:#.##} <br/>";
    public string LineaTotal(int totalFormas, decimal perimetroTotal, decimal areaTotal) =>
        $"TOTAL:<br/>{totalFormas} shapes | Perimeter {perimetroTotal:#.##} | Area {areaTotal:#.##}";
    public string Traducir(string forma, int cantidad)
    {
        switch (forma)
        {
            case "Cuadrado":
                return cantidad == 1 ? "Square" : "Squares";
            case "Circulo":
                return cantidad == 1 ? "Circle" : "Circles";
            case "TrianguloEquilatero":
                return cantidad == 1 ? "Equilateral Triangle" : "Equilateral Triangles";
            case "TrapecioRectangulo":
                return cantidad == 1 ? "Rectangular Trapezoid" : "Rectangular Trapezoids";
            default:
                return "";
        }
    }
}