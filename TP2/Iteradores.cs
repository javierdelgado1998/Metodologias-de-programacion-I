using System;
namespace Metodologías.TP2
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
}