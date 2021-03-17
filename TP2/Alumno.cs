using System;
namespace Metodologías.TP2
{
    public class Alumno : Persona
    {
        private int legajo;
        private int promedio;
        private EstrategiaComparacion estrategia;
        public Alumno(string nombre, int dni, int legajo, int promedio): base(nombre,dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            this.estrategia = new PorLegajo();
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
    }
}