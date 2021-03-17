using System.Collections.Generic;
namespace Metodologías.TP2
{
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