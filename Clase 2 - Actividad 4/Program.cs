namespace actividad4 {
    class Program
    {

        public static void Main(string[] args)
        {


            const double ENVIO_MENOR_20 = 2.0;
            const double ENVIO_MAYOR_20 = 3.0;
            const double ENVIO_MEDIANOCHE = 5.0;

            Console.WriteLine("Cacho y Marta Delicatessen");
            Console.WriteLine("Ingrese el Producto");
            string strProducto = Console.ReadLine();

            Console.WriteLine("Ingrese el Precio del Producto");
            double strPrecio = Convert.ToDouble(Console.ReadLine());

            //Excepcion para que solo se ingrese "si" o "no"
            bool despuesDeMedianoche = false;
            bool esEntradaValida = false;

            do
            {
                Console.WriteLine("¿Es después de medianoche? (si/no)");
                string respuesta = Console.ReadLine();

                try
                {
                    if (respuesta.Equals("si"))
                    {
                        despuesDeMedianoche = true;
                        esEntradaValida = true;
                    }
                    else if (respuesta.Equals("no"))
                    {
                        despuesDeMedianoche = false;
                        esEntradaValida = true;
                    }
                    else
                    {
                        throw new ArgumentException("Debe ingresar 'si' o 'no'");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            while (!esEntradaValida);

            //operador ternario = 'condicion ? true : false'
            double envio = strPrecio < 20 ? ENVIO_MENOR_20 : ENVIO_MAYOR_20;
            if (despuesDeMedianoche){
                envio += ENVIO_MEDIANOCHE;
            }

            double total = strPrecio + envio;

            Console.WriteLine("----- Factura -----");
            Console.WriteLine("Producto: " + strProducto);
            Console.WriteLine("Precio: $" + strPrecio);
            Console.WriteLine("Costo de envío: $" + envio);
            Console.WriteLine("Total a pagar: $" + total);

            Console.ReadLine();

        }
    }
}
