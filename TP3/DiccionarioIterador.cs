using System.Collections.Generic;
namespace Metodologías.TP3
{
    public class DiccionarioIterador : Iterador
    {
        private Diccionario elementos;
        private int indice;
        public DiccionarioIterador(Diccionario d)
        {
            this.elementos = d;
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
            return indice >= elementos.cuantos();
        }
        public object actual()
        {
            return elementos.getDiccionario()[indice];
        }
    }
}