namespace Metodologías.TP1
{
    public class Numero : Comparable
    {
        private int dato;
        public Numero (int dato)
        {
            this.dato = dato;
        }

        public int getNumero()
        {
            return dato;
        }
        public bool sosIgual(Comparable c)
        {
            return this.dato == ((Numero)c).dato;
        }
        public bool sosMenor(Comparable c)
        {
            return this.dato < ((Numero)c).dato;
        }
        public bool sosMayor(Comparable c)
        {
            return this.dato > ((Numero)c).dato;
        }

        public override string ToString()
        {
            return dato.ToString();
        }
    }
}