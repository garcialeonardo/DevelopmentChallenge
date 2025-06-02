using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrapecioRectangulo : IFormaGeometrica
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;

        public TrapecioRectangulo(decimal baseMayor, decimal baseMenor, decimal altura) {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
        }

        public decimal CalcularArea() => (_baseMayor + _baseMenor) * _altura / 2;

        public decimal CalcularPerimetro() {
            double diferenciaBases = (double)(_baseMayor - _baseMenor);
            decimal ladoRestante = (decimal)(Math.Sqrt(Math.Pow(diferenciaBases, 2) + Math.Pow((double)(_altura), 2)));
            return _baseMayor + _baseMenor + _altura + ladoRestante;
        }
    }
}