namespace Metodologías.TP4
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
                default: fabrica = null;break;
            }
            return fabrica.crearPorTeclado();
        }
        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
    }
}