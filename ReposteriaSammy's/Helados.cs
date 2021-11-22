using System;
using System.Collections.Generic;
using System.Text;

namespace ReposteriaSammy_s
{
    public class Helados : Menú
    {
        private int Cantidad;
        private int Precio;
        private string Sabor;

        public Helados(int Cantidad, int Precio, string Sabor) : base (1)

        {
            this.Cantidad = Cantidad;
            this.Precio = Precio;
            this.Sabor = Sabor;
        }

        public int getCantidad()
        {

            return Cantidad;
        }
        public void setCantidad(int Cantidad)
        {
            this.Cantidad = Cantidad;
        }

        public int getPrecio()
        {

            return Precio;
        }
        public void setPrecio(int Precio)
        {
            this.Precio= Precio;
        }
        public string getSabor()
        {

            return Sabor;
        }
        public void setSabor(string Sabor)
        {
            this.Sabor = Sabor;
        }

        public void EscogerPedido()
        {
                int precio_vainilla = 0;
                int precio_fresa = 0;
                int precio_oreo = 0;
                int sabor;

                Console.WriteLine("Elija el sabor: \nVainilla-----1 \nFresa-----2 \nOreo-----3\n");
                sabor = int.Parse(Console.ReadLine());

                if (sabor == 1)
                {
                    Console.Write("Ingrese cantidad de compra: ");
                    int cantidad_vainilla = int.Parse(Console.ReadLine());

                    precio_vainilla = 4;
                    int calculo_vainilla = precio_vainilla * cantidad_vainilla;


                    Console.WriteLine("Usted esta comprando " + cantidad_vainilla + " Helados de vainilla");
                    Console.WriteLine("Con un total de: $" + calculo_vainilla);


                }
                else if (sabor == 2)
                {
                    Console.Write("Ingrese cantidad de compra: ");
                    int cantidad_fresa = int.Parse(Console.ReadLine());

                    //precio de helado de fresa
                    precio_fresa = 5;

                    //calculo helado de fresa
                    int calculo_fresa = precio_fresa * cantidad_fresa;

                    //mesaje de la compra
                    Console.WriteLine("Usted esta comprando " + cantidad_fresa + " Helados de Fresa");
                    Console.WriteLine("Con un total de: $" + calculo_fresa);


                }
                else
                {

                    Console.Write("Ingrese cantidad de compra: ");
                    int cantidad_oreo = int.Parse(Console.ReadLine());

                    //precio helado de oreo
                    precio_oreo = 7;

                    //calculo helado de fresa
                    int calculo_oreo = precio_oreo * cantidad_oreo;

                    //mesaje de la compra
                    Console.WriteLine("Usted esta comprando " + cantidad_oreo + " Helados de Oreo");
                    Console.WriteLine("Con un total de: $" + calculo_oreo);

                }
            }
    }
}