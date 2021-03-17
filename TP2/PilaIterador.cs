using System.Collections.Generic;
namespace Metodologías.TP2
{
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
}