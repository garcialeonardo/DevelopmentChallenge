using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : IFormaGeometrica
    {
        private readonly decimal _lado;
        public Circulo(decimal lado) => _lado = lado;

        public decimal CalcularArea() => (decimal)Math.PI * (_lado / 2) * (_lado / 2);

        public decimal CalcularPerimetro() => (decimal)Math.PI * _lado;
    }
}