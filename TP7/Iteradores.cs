using System;
using System.Collections.Generic;
namespace Metodologías.TP7
{
    public interface Iterador
    {
        public void primero();
        public void siguiente();
        public bool fin();
        public object actual();
    }
    public interface Iterable
    {
        public Iterador crearIterador();
    }
    public class PilaIterador : Iterador
    {
        private List<Comparable> elementos;
        private int indice;
        public PilaIterador(List<Comparable> e)
        {
            this.elementos = e;
            indice = elementos.Count-1;
        }
        public void primero()
        {
            indice = elementos.Count-1;
        }
        public void siguiente()
        {
            indice--;
        }
        public bool fin()
        {
            return indice < 0;
        }
        public object actual()
        {
            return elementos[indice];
        }
    }
    public class ColaIterador : Iterador
    {
        private List<Comparable> elementos;
        private int indice;
        public ColaIterador(List<Comparable> e)
        {
            this.elementos = e;
        }
        public void primero()
        {
            indice = 0;
        }
        public void siguiente()
        {
            indice++;
        }
        public bool fin()
        {
            return indice >= elementos.Count;
        }
        public object actual()
        {
            return elementos[indice];
        }
    }
}