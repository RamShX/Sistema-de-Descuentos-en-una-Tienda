using SistemaDescuento.Domain.Interfeces;

namespace SistemaDescuento.Domain.Entities
{
    class DescuentoPremiun : IDescuento
    {
        private readonly double _descuento = 0.15;
        public double CalcularDescuento(double precio)
        {
            return precio - (precio * _descuento);
        }
    }
}
