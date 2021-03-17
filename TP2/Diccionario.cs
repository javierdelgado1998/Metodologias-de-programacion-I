using System;
using System.Collections.Generic;
namespace Metodologías.TP2
{
    public class Diccionario : Coleccionable,Iterable
    {
        private Conjunto c;
        Comparable clave = new Numero(0);
        public Diccionario()
        {
            c = new Conjunto();
        }
        public void agregar(Comparable valor)
        {
            ClaveValor a = new ClaveValor(clave,valor);
            bool existe = false;
            for (int i = 0; i < c.getConjunto().Count; i++)
            {
                if(c.getConjunto()[i].sosIgual(a))
                {
                    existe = true;
                    ((ClaveValor)c.getConjunto()[i]).setValor(a.getValor());
                    break;
                }
            }
            if(!existe)
            {
                c.agregar(a);
                int x = ((Numero)clave).getNumero()+1;
                clave = new Numero(x);
            }
        }
        public object valorDe(Comparable clave)
        {
            for (int i = 0; i < c.getConjunto().Count; i++)
            {
                if(((ClaveValor)c.getConjunto()[i]).sosIgual(clave))
                {
                    return ((ClaveValor)c.getConjunto()[i]);
                }
            }
            return null;
        }
        public int cuantos()
        {
            return c.cuantos();
        }
        public bool contiene(Comparable co)
        {
            return c.contiene(co);
        }
        public Comparable minimo()
        {
            return c.minimo();
        }
        public Comparable maximo()
        {
            return c.maximo();
        }
        public List<Comparable> getDiccionario()
        {
            return this.c.getConjunto();
        }
        public Iterador crearIterador()
        {
            return new DiccionarioIterador(this);
        }
        // Como la forma de recorrido no varias, otra opción podria ser esta
        /*public Iterador crearIterador()
        {
            return c.crearIterador();
        }*/
    }
}