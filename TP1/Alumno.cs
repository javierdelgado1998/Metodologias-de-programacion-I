using System;
namespace Metodologías.TP1
{
    public class Alumno : Persona
    {
        private int legajo;
        private int promedio;
        public Alumno(string nombre, int dni, int legajo, int promedio): base(nombre,dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }
        public int getLegajo()
        {
            return legajo;
        }
        public int getPromedio()
        {
            return promedio;
        }
        public override string ToString()
        {
            return (nombre,dni,legajo,promedio).ToString();
        }
        public override bool sosIgual(Comparable c)
        {
            return this.legajo == ((Alumno)c).legajo;
        }
        public override bool sosMenor(Comparable c)
        {
            return this.legajo < ((Alumno)c).legajo;
        }
        public override bool sosMayor(Comparable c)
        {
            return this.legajo > ((Alumno)c).legajo;
        }
    }
}