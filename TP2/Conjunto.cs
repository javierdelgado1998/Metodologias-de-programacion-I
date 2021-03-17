using System.Collections.Generic;
namespace Metodologías.TP2
{
    public class Conjunto : Coleccionable,Iterable
    {
        private List<Comparable> datos = new List<Comparable>();

        public List<Comparable> getConjunto()
        {
            return this.datos;
        }
        public void agregar(Comparable elemento)
        {
            if(!this.contiene(elemento))
            {
                datos.Add(elemento);
            }
        }
        public bool contiene(Comparable elemento)
        {
            if(datos.Count>0)
            {
                for (int i = 0; i < datos.Count; i++)
                {
                    if(datos[i].sosIgual(elemento))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public int cuantos()
        {
            return datos.Count;
        }
        public Comparable minimo()
        {
            if(this.cuantos() > 0)
            {
                Comparable x = datos[0];
                for (int i = 0; i < datos.Count; i++)
                {
                    if(datos[i].sosMenor(x))
                    {
                        x = datos[i];
                    }
                }
                return x;
            }
            return null;
        }
        public Comparable maximo()
        {
            if(this.cuantos() > 0)
            {
                Comparable x = datos[0];
                for (int i = 0; i < datos.Count; i++)
                {
                    if(datos[i].sosMayor(x))
                    {
                        x = datos[i];
                    }
                }
                return x;
            }
            return null;
        }
        public Iterador crearIterador()
        {
            return new ConjuntoIterador(datos);
        }
    }
}