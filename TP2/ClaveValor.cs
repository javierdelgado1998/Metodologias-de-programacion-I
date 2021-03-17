using System;
using System.Collections;
using System.Collections.Generic;
namespace Metodologías.TP2
{
    public class ClaveValor : Comparable
    {
        private Comparable clave;
        private Object valor;
        public ClaveValor(Comparable clave, Object valor)
        {
            this.clave = clave;
            this.valor = valor;
        }
        public Comparable getClave()
        {
            return clave;
        }
        public Object getValor()
        {
            return valor;
        }
        public void setValor(Object valor)
        {
            this.valor = valor;
        }
        public bool sosIgual(Comparable c)
        {
            return this.clave.sosIgual(((ClaveValor)c).getClave());
        }
        public bool sosMayor(Comparable c)
        {
            return this.clave.sosMayor(((ClaveValor)c).getClave());
        }
        public bool sosMenor(Comparable c)
        {
            return this.clave.sosMenor(((ClaveValor)c).getClave());
        }
        public override string ToString()
        {
            return (clave,valor).ToString();
        }
    }
}