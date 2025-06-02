/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class ReporteService
    {
        public static string Imprimir(List<IFormaGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
                return idioma.HeaderSinFormas();

            sb.Append(idioma.Header());

            var resumen = formas
                .GroupBy(f => f.GetType())
                .Select(g =>
                {
                    var first = g.First();
                    var cantidad = g.Count();
                    var area = g.Sum(f => f.CalcularArea());
                    var perimetro = g.Sum(f => f.CalcularPerimetro());
                    return idioma.Linea(cantidad, first.GetType().Name, perimetro, area);
                });

            foreach (var linea in resumen)
                sb.Append(linea);

            var totalFormas = formas.Count;
            var areaTotal = formas.Sum(f => f.CalcularArea());
            var perimetroTotal = formas.Sum(f => f.CalcularPerimetro());

            sb.Append(idioma.LineaTotal(totalFormas, perimetroTotal, areaTotal));

            return sb.ToString();
        }
    }
}
