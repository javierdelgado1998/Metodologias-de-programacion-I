using System;
namespace Metodologías.TP7
{
    public class Alumno : Persona, IAlumno
    {
        protected int legajo;
        protected int promedio;
        protected EstrategiaComparacion estrategia;
        protected int calificacion;
        public Alumno(string nombre, int dni, int legajo, int promedio): base(nombre,dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            this.estrategia = new PorCalificacion();
        }
        public int getLegajo()
        {
            return legajo;
        }
        public int getPromedio()
        {
            return promedio;
        }
        public void setCalificacion(int cali)
        {
            this.calificacion = cali;
        }
        public int getCalificacion()
        {
            return this.calificacion;
        }
        public override string ToString()
        {
            return (nombre,dni,legajo,promedio).ToString();
        }
        public void setEstrategia(EstrategiaComparacion e)
        {
            this.estrategia = e;
        }
        public override bool sosIgual(Comparable c)
        {
            return estrategia.sosIgual(this, c);
        }
        public override bool sosMenor(Comparable c)
        {
            return estrategia.sosMenor(this, c);
        }
        public override bool sosMayor(Comparable c)
        {
            return estrategia.sosMayor(this, c);
        }
        public virtual int responderPregunta(int pregunta)
        {
            Random r = new Random();
            return r.Next(1,3);
        }
        public string mostrarCalificacion()
        {
            return (nombre+" "+calificacion);
        }

    }
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, int promedio): base(nombre,dni, legajo, promedio)
        {
            
        }
        public override int responderPregunta(int pregunta)
        {
            return pregunta%3;
        }
    }
    //-------------------------------------INTERFACES-------------------------------
    public interface IAlumno : Comparable
    {
        string mostrarCalificacion();
        void setCalificacion(int valor);
        int responderPregunta(int pregunta);
        string getNombre();
        int getCalificacion();
        int getLegajo();

        
    }
}