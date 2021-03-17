namespace Metodologías.TP7
{
    public abstract class Decorador : IAlumno
    {
        protected IAlumno adicional;
        public Decorador(IAlumno adicional)
        {
            this.adicional = adicional;
        }

        public virtual string mostrarCalificacion()
        {
            return adicional.mostrarCalificacion();
        }
        public virtual int getCalificacion()
        {
            return this.adicional.getCalificacion();
        }
        public virtual void setCalificacion(int valor)
        {
            if(adicional != null)
            {
                adicional.setCalificacion(valor);
            }
        }
        public virtual int responderPregunta(int pregunta)
        {
            return this.adicional.responderPregunta(pregunta);
        }
        public virtual string getNombre()
        {
            return this.adicional.getNombre();
        }
        public virtual int getLegajo()
        {
            return this.adicional.getLegajo();
        }
        public virtual bool sosIgual(Comparable comparable)
        {
            return this.adicional.sosIgual(comparable);
        }

        public virtual bool sosMenor(Comparable comparable)
        {
            return this.adicional.sosMenor(comparable);
        }

        public virtual bool sosMayor(Comparable comparable)
        {
            return this.adicional.sosMayor(comparable);
        }

    }
}