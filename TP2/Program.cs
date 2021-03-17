using System;
namespace Metodologías.TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            InformarPersona informar = new InformarPersona();
            LlenarAlumnos llenarAlumnos = new LlenarAlumnos();
            llenarAlumnos.llenarAlumnos(pila);
            CambiarEstrategia cambiarEstrategia = new CambiarEstrategia();
            cambiarEstrategia.cambiarEstrategia(pila, new PorNombre());
            informar.informarPersona(pila);
            //----------------------------------
            cambiarEstrategia.cambiarEstrategia(pila,new PorLegajo());
            informar.informarPersona(pila);
            //-----------------------------------
            cambiarEstrategia.cambiarEstrategia(pila,new PorPromedio());
            informar.informarPersona(pila);
            //----------------------------------------
            cambiarEstrategia.cambiarEstrategia(pila,new PorDNI());
            informar.informarPersona(pila);
        }
        static void MultiplesIteradores()
        {
            Random r = new Random();
            Pila pila = new Pila();
            LlenarAlumnos llenar = new LlenarAlumnos();
            llenar.llenarAlumnos(pila);
            Iterador[] iteradores = new Iterador[3];
            bool[] fin = new bool[3];
            for (int i = 0; i < 3; i++)
            {
                iteradores[i] = pila.crearIterador();
                fin[i] = false;
            }
            while(!fin[0] && !fin[1] && !fin[2])
            {
                int ite = r.Next(0,3);
                if(!iteradores[ite].fin())
                {
                    Console.WriteLine(iteradores[ite].actual());
                    iteradores[ite].siguiente();
                }
                else
                {
                    fin[ite] = true;
                }
            }
        }
    }
}
