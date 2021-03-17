namespace Metodologías.TP6
{
    public abstract class FabricaDeComparables : IFabricaDeComparables
    {
        public static Comparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch(opcion)
            {
                case 1: fabrica = new FabricaDeAlumnos();break;
                case 2: fabrica = new FabricaDeAlumnosMuyEstudiosos();break;
                case 3: fabrica = new StudentsFactory();break;
                case 4: fabrica = new FabricaDeAlumnosCompuestos();break;
                default: fabrica = null;break;
            }
            return fabrica.crearAleatorio();
        }
        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch(opcion)
            {
                case 1: fabrica = new FabricaDeAlumnos();break;
                case 2: fabrica = new FabricaDeAlumnosMuyEstudiosos();break;
                case 3: fabrica = new StudentsFactory();break;
                case 4: fabrica = new FabricaDeAlumnosCompuestos();break;
                default: fabrica = null;break;
            }
            return fabrica.crearPorTeclado();
        }
        public static Comparable crearProxy(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch(opcion)
            {
                case 1: fabrica = new FabricaDeAlumnos();break;
                case 2: fabrica = new FabricaDeAlumnosMuyEstudiosos();break;
                case 3: fabrica = new StudentsFactory();break;
                //case 4: fabrica = new FabricaDeAlumnosCompuestos();break;
                default: fabrica = null;break;
            }
            return fabrica.crearProxy();            
        }
        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
        public abstract Comparable crearProxy();
    }
    public interface IFabricaDeComparables
    {
        public Comparable crearAleatorio();
        public Comparable crearPorTeclado();
        
        public Comparable crearProxy();
    }
}