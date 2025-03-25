using SistemaDescuento.Domain.Interfeces;

namespace SistemaDescuento.Domain.Entities
{
    public class DescuentoEstudiante : IDescuento
    {
        private readonly double _descuento = 0.10;
        public double CalcularDescuento(double precio)
        {
            return precio - (precio * _descuento);
        }
    }
    
}
