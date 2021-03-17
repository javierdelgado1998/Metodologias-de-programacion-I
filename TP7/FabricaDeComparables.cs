namespace Metodologías.TP7
{
    public abstract class FabricaDeComparables : IFabricaDeComparables
    {
        protected static Manejador responsable;
        public static Comparable crearAleatorio(int opcion)
        {
            Manejador m = new LectorDeArchivos(null);
            m = GeneradorDeDatosAleatorios.getInstance(m);
            responsable = LectorDeDatos.getInstance(m);
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
            Manejador m = new LectorDeArchivos(null);
            m = GeneradorDeDatosAleatorios.getInstance(m);
            responsable = LectorDeDatos.getInstance(m);
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
        public static Comparable crearPorArchivo(int opcion)
        {
            Manejador m = new LectorDeArchivos(null);
            m = GeneradorDeDatosAleatorios.getInstance(m);
            responsable = LectorDeDatos.getInstance(m);
            FabricaDeComparables fabrica = null;
            switch(opcion)
            {
                case 1: fabrica = new FabricaDeAlumnos();break;
                case 2: fabrica = new FabricaDeAlumnosMuyEstudiosos();break;
                case 3: fabrica = new StudentsFactory();break;
                case 4: fabrica = new FabricaDeAlumnosCompuestos();break;
                default: fabrica = null;break;
            }
            return fabrica.crearPorArchivo();       
        }
        public static Comparable crearProxy(int opcionFabrica,int opcionDatos)
        {
            Manejador m = new LectorDeArchivos(null);
            m = GeneradorDeDatosAleatorios.getInstance(m);
            responsable = LectorDeDatos.getInstance(m);
            FabricaDeComparables fabrica = null;
            switch(opcionFabrica)
            {
                case 1: fabrica = new FabricaDeAlumnos();break;
                case 2: fabrica = new FabricaDeAlumnosMuyEstudiosos();break;
                case 3: fabrica = new StudentsFactory();break;
                //case 4: fabrica = new FabricaDeAlumnosCompuestos();break;
                default: fabrica = null;break;
            }
            return fabrica.crearProxy(opcionDatos);            
        }
        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
        public abstract Comparable crearPorArchivo();
        public abstract Comparable crearProxy(int opcion);
    }
    public interface IFabricaDeComparables
    {
        public Comparable crearAleatorio();
        public Comparable crearPorTeclado();
        public Comparable crearPorArchivo();
        public Comparable crearProxy(int opcion);
    }
}