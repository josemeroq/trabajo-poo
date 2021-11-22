using System;
using System.Collections.Generic;
using System.Text;

namespace ReposteriaSammy_s
{
    public class Menú
    {
        private int tipo_postre = 0;
        public void Mostrarmenú()
        {
            int tipo_postre;
            Console.Write("Escoja la su postre: \nHELADOS------ 1 \nPASTELES------2 \n");
            tipo_postre = int.Parse(Console.ReadLine());

            //pregunta si es para helado
            if (tipo_postre == 1)
            {
                Console.WriteLine("Helados");
            }
            //pregunta si es para pastel
            else
            {
                Console.WriteLine("Pasteles");
            }
        }
        public Menú(int tipo_postre) 
           {
                this.tipo_postre = tipo_postre;
           }
        public int gettipo_postre()
            {
            return tipo_postre;
            }
        public void settipo_postre(int tipo_postre)
        {
            this.tipo_postre = tipo_postre;
        } 
    }
}