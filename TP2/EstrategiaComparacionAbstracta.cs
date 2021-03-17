namespace Metodologías.TP2
{
    public abstract class EstrategiaComparacionAbstracta : EstrategiaComparacion
    {
        public abstract bool sosIgual(Comparable c1, Comparable c2);
        public abstract bool sosMenor(Comparable c1, Comparable c2);
        public abstract bool sosMayor(Comparable c1, Comparable c2); 
    }
}