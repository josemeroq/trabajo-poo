using System;
using System.Collections.Generic;
using System.Text;

namespace ReposteriaSammy_s
{
    public class Usuario
    {
        private string Nombres;
        private string Apellidos;
        private int Telefono;
        private string Dirección;

        public Usuario(string Nombres, string Apellidos, int Telefono, string Dirección)
        {
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Telefono = Telefono;
            this.Dirección = Dirección;
        }
        public string getNombres()
        {

            return Nombres;
        }
        public void setNombres(string Nombres)
        {
            this.Nombres = Nombres;
        }
        public string getApellidos()
        {

            return Apellidos;
        }
        public void setApellidos(string Apellidos )
        {
            this.Apellidos = Apellidos;
        }
        public int getTelefono()
        {

            return Telefono;
        }
        public void setTelefono(int Telefono)
        {
            this.Telefono = Telefono;
        }
        public string getDirección()
        {

            return Dirección;
        }
        public void setDireccion(string Dirección)
        {
            this.Dirección = Dirección;
        }
        public void imprimirUsuario()
        {
            {
                Console.Write("Ingrese los nombres del cliente: ");
                Nombres = Console.ReadLine();

                Console.Write("Ingrese los apellidos del cliente: ");
                Apellidos = Console.ReadLine();

                Console.Write("Ingrese el telefono del cliente: ");
                Telefono = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la direccion del cliente: ");
                Dirección = Console.ReadLine();
            }
        }

    }
}
