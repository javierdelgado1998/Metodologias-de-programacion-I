using System;
using System.Collections.Generic;
namespace Metodologías.TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------EJERCICIO 2------------------------
            Teacher teacher = new Teacher();
            for (int i = 0; i < 10; i++)
            {
                IAlumno s = (IAlumno)FabricaDeComparables.crearProxy(1);
                teacher.goToClass(new AdaptadorAlumno(s));
            }
            for (int i = 0; i < 10; i++)
            {
                IAlumno s = (IAlumno)FabricaDeComparables.crearProxy(2);
                teacher.goToClass(new AdaptadorAlumno(s));
            }
            IAlumno alumnoCompuesto = (IAlumno)FabricaDeComparables.crearAleatorio(4);
            teacher.goToClass(new AdaptadorAlumno(alumnoCompuesto));
            teacher.teachingAClass();
            
            /*En esta versión se implementaron los opcionales de la práctica, por lo cual el parametro recibico 
            en el metodo jugar ahora es una lista de jugadores, en el juego uno, solo jugarian 2 jugadores, porque asi
            esta implementado, pero se podria modificar para que jueguen todos los jugadores de la lista*/
            //-------------------EJERCICIO 6--------------------
            JuegoDeCartas ultimoDescarte = new JuegoUno();
            List<Persona> personas= new List<Persona>();
            personas.Add(new Persona("Javier",41560922));
            personas.Add(new Persona("Matias",123456));
            Persona ganador = ultimoDescarte.jugar(personas);
            Console.WriteLine("El ganador del juego es {0}",ganador);
        }
    }
}
