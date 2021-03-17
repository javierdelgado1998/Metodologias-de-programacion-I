using System.Collections.Generic;
using System;
namespace Metodologías.TP3
{
    public class Gerente : Persona, IObservador
    {
        Coleccionable mejores = new Cola();
        public Gerente(string nombre,int dni):base(nombre,dni)
        {

        }
        public void cerrar()
        {
            ImprimirElementos imprimirElementos = new ImprimirElementos();
            imprimirElementos.imprimirMejores((Iterable)mejores);
        }
        public void venta(float monto, Comparable vendedor)
        {
            if(monto > 5000)
            {
                if(!mejores.contiene(vendedor))
                {
                    mejores.agregar(vendedor);
                }
                ((Vendedor)vendedor).aumentaBonus();
            }
        }
        public void actualizar(IObservado o)
        {
            float monto = ((Vendedor)o).getUltimoMonto();
            this.venta(monto,(Comparable)o);
        }
    }
}