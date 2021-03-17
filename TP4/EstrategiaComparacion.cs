namespace Metodologías.TP4
{
    public interface EstrategiaComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2);
        public bool sosMenor(Comparable c1, Comparable c2);
        public bool sosMayor(Comparable c1, Comparable c2); 
    }
}