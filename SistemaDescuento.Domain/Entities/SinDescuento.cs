using SistemaDescuento.Domain.Interfeces;

namespace SistemaDescuento.Domain.Entities
{
    public class SinDescuento : IDescuento
    {
        public double CalcularDescuento(double precio)
        {
            return precio;
        }
    }
}
