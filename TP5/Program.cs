using System;

namespace Metodologías.TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------EJERCICIO 10-------------------------------
            LlenarInformar metodos = new LlenarInformar();
            Pila pila = new Pila();
            Aula aula = new Aula();
            pila.setOrdenInicio(new OrdenInicio(aula));
            pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
            metodos.llenar(pila,2);
            metodos.llenar(pila,1);
        }
    }
}
