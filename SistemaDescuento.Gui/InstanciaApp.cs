
using SistemaDescuento.Domain.Context;
using SistemaDescuento.Domain.Entities;
using SistemaDescuento.Domain.Interfeces;

namespace SistemaDescuento.Gui
{
    public class InstanciaApp
    {
        public void Funcionalidad()
        {

            bool exit = true;
            while (exit)
            {
                Console.Clear();
                Console.Write("Ingrese el precio del producto: ");
                if (!double.TryParse(Console.ReadLine(), out double precio) || precio < 0)
                {
                    Console.WriteLine("El valor ingresado no es valido");
                    continue;
                }

                Console.WriteLine("");
                Console.WriteLine("[1] Estudiante ");
                Console.WriteLine("[2] Cliente Premium ");
                Console.WriteLine("[3] Cliente Regular");
                Console.WriteLine("[4] salir");
                Console.Write("Seleccione el tipo de cliente:  ");
                if (!int.TryParse(Console.ReadLine(), out int tipoCliente) || tipoCliente < 1 || tipoCliente > 4)
                {
                    Console.WriteLine("El valor ingresado no es valido");
                    continue;
                }

                if (tipoCliente == 4)
                {
                    exit = false;
                    continue;
                }

                IDescuento descuentoCliente = null;
                Producto productoCliente = null;
                switch (tipoCliente)
                {
                    case 1:
                        descuentoCliente = new DescuentoEstudiante();
                        productoCliente = new Producto(descuentoCliente);

                        break;
                    case 2:
                        descuentoCliente = new DescuentoPremiun();
                        productoCliente = new Producto(descuentoCliente);
                        break;
                    case 3:
                        descuentoCliente = new SinDescuento();
                        productoCliente = new Producto(descuentoCliente);
                        break;
                    default:
                        break;
                }

                if (productoCliente != null)
                {
                    Console.WriteLine($"El precio con descuento es: {productoCliente.AplicarDescuento(precio)}");
                }

                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}
