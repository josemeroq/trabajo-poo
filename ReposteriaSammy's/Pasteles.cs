using System;
using System.Collections.Generic;
using System.Text;

namespace ReposteriaSammy_s
{
    public class Pasteles : Menú
    {
        private int Cantidad;
        private int Precio;
        private string Sabor;
        public Pasteles (int Cantidad, int Precio, string Sabor) : base(2)

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
            this.Precio = Precio;
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
            int precio_chocolate = 0;
            int precio_fresa = 0;
            int precio_vainilla = 0;
            int sabor;

            Console.Clear();
            Console.WriteLine("Elija el sabor: \nChocolate-----1 \nFresa-----2 \nVainilla-----3");
            sabor = int.Parse(Console.ReadLine());

            //si es chocolate
            if (sabor == 1)
            {

                Console.Write("Ingrese cantidad de compra: ");
                int cantidad_chocolate = int.Parse(Console.ReadLine());

                precio_chocolate = 4;
                int calculo_chocolate = precio_chocolate * cantidad_chocolate;


                Console.WriteLine("Usted esta comprando " + cantidad_chocolate + " Pasteles de Chocolate");
                Console.WriteLine("Con un total de: $" + calculo_chocolate);


            }
            //si es fresa
            else if (sabor == 2)
            {
                Console.Write("Ingrese cantidad de compra: ");
                int cantidad_fresa = int.Parse(Console.ReadLine());

                //precio de pastel de fresa
                precio_fresa = 5;

                //calculo pastel de fresa
                int calculo_fresa = precio_fresa * cantidad_fresa;

                //mesaje de la compra
                Console.WriteLine("Usted esta comprando " + cantidad_fresa + " Pasteles de Fresa");
                Console.WriteLine("Con un total de: $" + calculo_fresa);


            }
            //si es vainilla
            else
            {

                Console.Write("Ingrese cantidad de compra: ");
                int cantidad_vainilla = int.Parse(Console.ReadLine());

                //precio Pastel de vainilla
                precio_vainilla = 7;

                //calculo Pastel de vainilla
                int calculo_oreo = precio_vainilla * cantidad_vainilla;

                //mesaje de la compra
                Console.WriteLine("Usted esta comprando " + cantidad_vainilla + " Pasteles de Vainilla");
                Console.WriteLine("Con un total de: $" + calculo_oreo);


            }
        }
    }
}