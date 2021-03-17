namespace Metodologías.TP3
{
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
}