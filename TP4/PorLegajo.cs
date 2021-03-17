namespace Metodologías.TP4
{
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
}