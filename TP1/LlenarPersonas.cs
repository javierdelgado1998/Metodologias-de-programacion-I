using System;
namespace Metodologías.TP1
{
    public class LlenarPersonas
    {
        public void llenarPersonas(Coleccionable c)
        {
            Random r = new Random();
            string[] nombres = new string[]{"Javier","Rodrigo","Ivan","Samuel","Enzo","Cristian","Ariel","Pepe"};
            for (int i = 0; i < 20; i++)
            {
                Comparable x = new Persona((nombres[r.Next(0,nombres.Length-1)]),(r.Next(1,100)));
                Console.Write(x.ToString()+ " ");
                c.agregar(x);
            }
        }
    }
}