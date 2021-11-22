using System;
using System.Collections.Generic;
using System.Text;

namespace ReposteriaSammy_s
{
    public class DetalledeFactura
    {
        private int ValorPagar;
        private string Pedido;

        public DetalledeFactura(int ValorPagar, string Pedido)
        {
            this.ValorPagar = ValorPagar;
            this.Pedido = Pedido;
        }

        public Factura Factura
        {
            get => default;
            set
            {
            }
        }

        public int getValorPagar()
        {
            return ValorPagar;
        }
        public void setValorPagar(int ValorPagar)
        {
            this.ValorPagar = ValorPagar;
        }
        public string getPedido()
        {
            return Pedido;
        }
        public void setPedido(string Pedido)
        {
            this.Pedido = Pedido;
        }
        public void mostrarPedido()
        {
            Console.WriteLine("Mostrar a lista de pedido : " + getPedido());
            Console.WriteLine("Evidenciar el valor a cancelar : " + getValorPagar());
        }
    }
}