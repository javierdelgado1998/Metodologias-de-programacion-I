namespace Metodologías.TP4
{
    public class PorCalificacion : EstrategiaComparacionAbstracta
    {
        public override bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getCalificacion() == ((IAlumno)c2).getCalificacion();
        }
        public override bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getCalificacion() < ((IAlumno)c2).getCalificacion();
        }
        public override bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getCalificacion() > ((IAlumno)c2).getCalificacion();
        }              
    }
}