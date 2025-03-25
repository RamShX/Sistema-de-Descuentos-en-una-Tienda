using SistemaDescuento.Domain.Interfeces;

namespace SistemaDescuento.Domain.Entities
{
    class SinDescuento : IDescuento
    {
        public double CalcularDescuento(double precio)
        {
            return precio;
        }
    }
}
