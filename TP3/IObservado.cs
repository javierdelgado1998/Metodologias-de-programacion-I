using System;
using System.Collections.Generic;
namespace Metodologías.TP3
{
    public interface IObservado
    {
        public void notificar();
        public void agregarObservador(IObservador o);
        public void quitarObservador(IObservador o);
    }
    public interface IObservador
    {
        public void actualizar(IObservado o);
    }
}