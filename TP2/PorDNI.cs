namespace Metodologías.TP2
{
    public class PorDNI : EstrategiaComparacionAbstracta
    {
        public override bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getDNI() == ((Alumno)c2).getDNI();
        }
        public override bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getDNI() < ((Alumno)c2).getDNI();
        }
        public override bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getDNI() > ((Alumno)c2).getDNI();
        }       
    }
}