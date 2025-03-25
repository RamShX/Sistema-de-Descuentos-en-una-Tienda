
using SistemaDescuento.Domain.Interfeces;

namespace SistemaDescuento.Domain.Context
{
    public class Producto
    {
        private readonly IDescuento _descuento;
        public Producto(IDescuento descuento)
        {
            _descuento = descuento;
        }

        public double AplicarDescuento(double precio)
        {
            return _descuento.CalcularDescuento(precio);
        }
    }
}
