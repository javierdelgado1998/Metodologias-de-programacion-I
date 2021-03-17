namespace Metodologías.TP6
{
    public abstract class EstrategiaComparacionAbstracta : EstrategiaComparacion
    {
        public abstract bool sosIgual(Comparable c1, Comparable c2);
        public abstract bool sosMenor(Comparable c1, Comparable c2);
        public abstract bool sosMayor(Comparable c1, Comparable c2); 
    }
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
    public class PorLegajo : EstrategiaComparacionAbstracta
    {
        public override bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getLegajo() == ((IAlumno)c2).getLegajo();
        }
        public override bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getLegajo() < ((IAlumno)c2).getLegajo();
        }
        public override bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getLegajo() > ((IAlumno)c2).getLegajo();
        }              
    }
    public class PorPromedio : EstrategiaComparacionAbstracta
    {
        public override bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getPromedio() == ((Alumno)c2).getPromedio();
        }
        public override bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getPromedio() < ((Alumno)c2).getPromedio();
        }
        public override bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getPromedio() > ((Alumno)c2).getPromedio();
        }       
    }
    public interface EstrategiaComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2);
        public bool sosMenor(Comparable c1, Comparable c2);
        public bool sosMayor(Comparable c1, Comparable c2); 
    }
}