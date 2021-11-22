using System;
using System.Collections.Generic;
using System.Text;

namespace ReposteriaSammy_s
{
    public class Factura : Usuario
    {
        private int ValorPagar;
        
        public Factura (string Nombres, string Apellidos, int Telefono, string Dirección, int ValorPagar) :
            base (Nombres, Apellidos, Telefono, Dirección)
        {
            this.ValorPagar = ValorPagar;
        }

        public int getValorPagar()
        {
            return ValorPagar;
        }
        public void setValorPagar(int ValorPagar)
        {
            this.ValorPagar = ValorPagar;
        }
        public void ImprimirValorTotal()
        {
            Console.WriteLine("///////////////////////////////////////////////////////////////");
            Console.WriteLine("                              FACTURA                          ");
            Console.WriteLine("///////////////////////////////////////////////////////////////\n");


            Console.WriteLine("Nombre: " + getNombres());
            Console.WriteLine("Apellidos: " + getApellidos());
            Console.WriteLine("Telefono: " + getTelefono());
            Console.WriteLine("Direccion: " + getDirección());

            Console.ReadKey();
        }
    }
    }
