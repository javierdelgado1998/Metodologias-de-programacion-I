using System;
using System.Collections.Generic;
namespace Metodologías.TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 14
            ImprimirElementos metodo = new ImprimirElementos();
            Coleccionable pila = new Pila();
            VendedorPauperrimo vendedorPauperrimo = new VendedorPauperrimo("Javier",41560922,500);
            vendedorPauperrimo.agregarObservador(new Seguridad());
            vendedorPauperrimo.agregarObservador(new Cliente());
            vendedorPauperrimo.agregarObservador(new Encargado());
            pila.agregar(vendedorPauperrimo);
            LlenarInformar llenarInfo = new LlenarInformar();
            llenarInfo.llenar(pila,3);
            IObservador gerente = new Gerente("Javier",41560922);
            metodo.agregarObservadores((Iterable)pila,gerente);
            metodo.jornadaDeVentas((Iterable)pila);
            ((Gerente)gerente).cerrar();

        }
    }
}
