namespace Metodologías.TP5
{
    public interface Ordenable
    {
        public void setOrdenInicio(OrdenEnAula1 ordenEnAula1);
        public void setOrdenLlegaAlumno(OrdenEnAula2 ordenEnAula1);
        public void setOrdenAulaLlena(OrdenEnAula1 ordenEnAula1);

    }
    public interface OrdenEnAula1 : OrdenEnAula2
    {
        public void ejecutar();
    }
    public interface OrdenEnAula2
    {
        public void ejecutar(Comparable comparable);
    }
    public abstract class Ordenes : OrdenEnAula1
    {
        protected Aula aula;
        public Ordenes(Aula aula)
        {
            this.aula = aula;
        }
        public abstract void ejecutar();
        public abstract void ejecutar(Comparable comparable);
    }
    public class OrdenInicio : Ordenes
    {
        public OrdenInicio(Aula aula):base(aula)
        {

        }
        public override void ejecutar()
        {
            aula.comenzar();
        }
        public override void ejecutar(Comparable comparable)
        {

        }
    }
    public class OrdenAulaLlena : Ordenes
    {
        public OrdenAulaLlena(Aula aula):base(aula)
        {

        }
        public override void ejecutar()
        {
            aula.claseLista();
        }
        public override void ejecutar(Comparable comparable)
        {
            
        }
    }
    public class OrdenLlegaAlumno : Ordenes
    {
        public OrdenLlegaAlumno(Aula aula):base(aula)
        {

        }
        public override void ejecutar(Comparable comparable)
        {
            aula.nuevoAlumno((IAlumno)comparable);
        }
        public override void ejecutar()
        {
            
        }
    }
}