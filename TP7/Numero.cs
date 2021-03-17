using System;
using System.Collections.Generic;
namespace Metodologías.TP7
{
    public class Numero : Comparable, IObservado
    {
        private int dato;
        private List<IObservador> observadores = new List<IObservador>();
        public Numero (int dato)
        {
            this.dato = dato;
        }

        public int getNumero()
        {
            return dato;
        }
        public void setNumero(int numero)
        {
            this.dato = numero;
            this.notificar();
        }
        public bool sosIgual(Comparable c)
        {
            return this.dato == ((Numero)c).dato;
        }
        public bool sosMenor(Comparable c)
        {
            return this.dato < ((Numero)c).dato;
        }
        public bool sosMayor(Comparable c)
        {
            return this.dato > ((Numero)c).dato;
        }

        public override string ToString()
        {
            return dato.ToString();
        }
        public void notificar()
        {
            foreach (IObservador o in observadores)
            {
                o.actualizar(this);
            }
        }
        public void agregarObservador(IObservador o)
        {
            observadores.Add(o);
        }
        public void quitarObservador(IObservador o)
        {
            observadores.Remove(o);
        }
    }
}