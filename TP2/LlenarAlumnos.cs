using System;
namespace Metodologías.TP2
{
    public class LlenarAlumnos
    {
        public void llenarAlumnos(Coleccionable c)
        {
            Random r = new Random();
            string[] nombres = new string[]{"Javier","Rodrigo","Ivan","Samuel","Enzo","Cristian","Ariel","Pepe"};
            for (int i = 0; i < 20; i++)
            {

                Alumno x = new Alumno((nombres[r.Next(0,nombres.Length-1)]),(r.Next(1,100)),(r.Next(1,100)),(r.Next(1,10)));
                //x.setEstrategia(new PorPromedio());
                Console.Write(x.ToString()+ " ");
                c.agregar(x);
            }   
        }
    }
}