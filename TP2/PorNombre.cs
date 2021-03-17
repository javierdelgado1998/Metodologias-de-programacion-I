using System;
namespace Metodologías.TP2
{
    public class PorNombre : EstrategiaComparacionAbstracta
    {
        public override bool sosIgual(Comparable c1, Comparable c2)
        {
            return (((Alumno)c1).getNombre()).CompareTo(((Alumno)c2).getNombre()) == 0;
        }
        public override bool sosMenor(Comparable c1, Comparable c2)
        {
            return (((Alumno)c1).getNombre()).CompareTo(((Alumno)c2).getNombre()) == -1;
        }
        public override bool sosMayor(Comparable c1, Comparable c2)
        {
            return (((Alumno)c1).getNombre()).CompareTo(((Alumno)c2).getNombre()) == 1;
        }
    }
}