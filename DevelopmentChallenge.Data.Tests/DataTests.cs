using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ReporteService.Imprimir(new List<IFormaGeometrica>(), new IdiomaCastellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                ReporteService.Imprimir(new List<IFormaGeometrica>(), new IdiomaIngles()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                ReporteService.Imprimir(new List<IFormaGeometrica>(), new IdiomaItaliano()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };

            var resumen = ReporteService.Imprimir(cuadrados, new IdiomaCastellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Perimetro 20 | Area 25 <br/>TOTAL:<br/>1 formas | Perimetro 20 | Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = ReporteService.Imprimir(cuadrados, new IdiomaIngles());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Perimeter 36 | Area 35 <br/>TOTAL:<br/>3 shapes | Perimeter 36 | Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioRectangulo()
        {
            var trapecios = new List<IFormaGeometrica> { new TrapecioRectangulo(7,4,5) };

            var resumen = ReporteService.Imprimir(trapecios, new IdiomaItaliano());

            Assert.AreEqual("<h1>Rapporto sulle forme</h1>1 Trapezio Rettangolare | Perimetro 21,83 | Area 27,5 <br/>TOTAL:<br/>1 forme | Perimetro 21,83 | Area 27,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapecioRectangulo()
        {
            var trapecios = new List<IFormaGeometrica>
            {
                new TrapecioRectangulo(7,4,5),
                new TrapecioRectangulo(3,2,2),
                new TrapecioRectangulo(9,8,6)
            };

            var resumen = ReporteService.Imprimir(trapecios, new IdiomaItaliano());

            Assert.AreEqual("<h1>Rapporto sulle forme</h1>3 Trapezi Rettangolari | Perimetro 60,15 | Area 83,5 <br/>TOTAL:<br/>3 forme | Perimetro 60,15 | Area 83,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReporteService.Imprimir(formas, new IdiomaIngles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Perimeter 28 | Area 29 <br/>2 Circles | Perimeter 18,06 | Area 13,01 <br/>3 Equilateral Triangles | Perimeter 51,6 | Area 49,64 <br/>TOTAL:<br/>7 shapes | Perimeter 97,66 | Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ReporteService.Imprimir(formas, new IdiomaCastellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Perimetro 28 | Area 29 <br/>2 Círculos | Perimetro 18,06 | Area 13,01 <br/>3 Triángulos Equilateros | Perimetro 51,6 | Area 49,64 <br/>TOTAL:<br/>7 formas | Perimetro 97,66 | Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConTodosLosTiposEnItaliano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new TrapecioRectangulo(7,4,5),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new TrapecioRectangulo(3,2,2),
            };

            var resumen = ReporteService.Imprimir(formas, new IdiomaItaliano());

            Assert.AreEqual(
                "<h1>Rapporto sulle forme</h1>2 Piazze | Perimetro 28 | Area 29 <br/>2 Cerchi | Perimetro 18,06 | Area 13,01 <br/>3 Triangoli Equilateri | Perimetro 51,6 | Area 49,64 <br/>2 Trapezi Rettangolari | Perimetro 31,07 | Area 32,5 <br/>TOTAL:<br/>9 forme | Perimetro 128,73 | Area 124,15",
                resumen);
        }
    }
}

