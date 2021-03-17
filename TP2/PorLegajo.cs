namespace Metodologías.TP2
{
    public class PorLegajo : EstrategiaComparacionAbstracta
    {
        public override bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getLegajo() == ((Alumno)c2).getLegajo();
        }
        public override bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getLegajo() < ((Alumno)c2).getLegajo();
        }
        public override bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getLegajo() > ((Alumno)c2).getLegajo();
        }              
    }
}