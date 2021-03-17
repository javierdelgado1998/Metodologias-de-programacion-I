namespace Metodologías.TP1
{
    public class Persona : Comparable
    {
        protected string nombre;
        protected int dni;
        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        public Persona(int dni)
        {
            this.dni = dni;
        }
        public string getNombre()
        {
            return nombre;
        }
        public int getDNI()
        {
            return dni;
        }
        public virtual bool sosIgual(Comparable c)
        {
            return this.dni == ((Persona)c).dni;
        }
        public virtual bool sosMenor(Comparable c)
        {
            return this.dni < ((Persona)c).dni;
        }
        public virtual bool sosMayor(Comparable c)
        {
            return this.dni > ((Persona)c).dni;
        }
        public override string ToString()
        {
            return (nombre,dni).ToString();
        }
    }
}