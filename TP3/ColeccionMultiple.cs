namespace Metodologías.TP3
{
    public class ColeccionMultiple: Coleccionable
    {
        private Pila pil;
        private Cola col;
        public ColeccionMultiple(Pila pil, Cola col)
        {
            this.pil = pil;
            this.col= col;
        }
        public int cuantos()
        {
            return (pil.cuantos()+col.cuantos());
        }
		public Comparable minimo()
		{
            Comparable minC = col.minimo();
            Comparable minP = pil.minimo();
            if (minC.sosMenor(minP))
            {
                return minC;
            }
            return minP;
		}
		public Comparable maximo()
		{
            Comparable maxC = col.maximo();
            Comparable maxP = pil.maximo();
            if (maxC.sosMayor(maxP))
            {
                return maxC;
            }
            return maxP;
		}
        public void agregar(Comparable c)
        {

        }
        public bool contiene(Comparable c)
        {
            if(pil.contiene(c) || col.contiene(c))
            {
                return true;
            }
            return false;
        }
    }
}