using System;

namespace ReposteriaSammy_s
{
    // clase para el inicio  
    public class Program
    {
        static void Main(String[] args)
            {
                Console.WriteLine("================================");
                Console.WriteLine("          Bienvenidos           ");
                Console.WriteLine("================================");
                Console.WriteLine("================================");
                Console.WriteLine("        Repostería Sammy's       ");
                Console.WriteLine("================================");

                //llamar datos del clinete
                Usuario usuario = new Usuario("Byron", "Santacruz ", 0987654321, "Manta ");
                usuario.imprimirUsuario();

                //llamar pregunta tipo de postres
                Menú pregunta_menu = new Menú(2);
                pregunta_menu.Mostrarmenú();
                Helados helado = new Helados(2, 12, "vainilla");
                helado.EscogerPedido();

                Pasteles pastel = new Pasteles(2, 18, "Chocolate");
                pastel.EscogerPedido();

                //Detalles de factura
                DetalledeFactura detalle = new DetalledeFactura(14, "Pastel de chocolate");
                detalle.mostrarPedido();

                //imprimir factura
                Factura  imprimir_factura = new Factura("Byron", "Santacruz ", 0987654321, "Manta ", 14);
                imprimir_factura.ImprimirValorTotal();
                
        }
        }


    }


        
            

