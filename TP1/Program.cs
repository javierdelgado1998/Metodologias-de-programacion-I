using System;

namespace Metodologías.TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*---------Ejercicio 18-----------------------------
            Detalle:
            -La clase informar persona, cuando pide ingresar número, verifica el número de dni y si se encuentra
            en la colección multiple, se puede modificar o hacer una clase informar alumno, por si se quiere comprobar
            si el número ingresado es un legajo o promedio que se encuentra en la colección.
            */
            Pila p = new Pila();
            Cola c = new Cola();
            LlenarAlumnos llenarAlumnos = new LlenarAlumnos();
            InformarPersona infoP = new InformarPersona();
            Console.WriteLine("\n---------------------");
            llenarAlumnos.llenarAlumnos(c);
            Console.WriteLine("\n---------------------");
            llenarAlumnos.llenarAlumnos(p);
            Console.WriteLine("\n---------------------");
            ColeccionMultiple multi = new ColeccionMultiple(p,c);
            infoP.informarPersona(multi);

                     
        }
    }
}
