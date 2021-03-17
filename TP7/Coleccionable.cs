namespace Metodologías.TP7
{
    public interface Coleccionable : Ordenable
    {
        public int cuantos();
        public Comparable minimo();
        public Comparable maximo();
        public void agregar(Comparable c);
        public bool contiene(Comparable c);

        public void ordenar();
    }
}