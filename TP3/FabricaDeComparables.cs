namespace Metodologías.TP3
{
    public abstract class FabricaDeComparables : IFabricaDeComparables
    {
        public static Comparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch(opcion)
            {
                case 1: fabrica = new FabricaDeNumeros();break;
                case 2: fabrica = new FabricaDeAlumnos();break;
                case 3: fabrica = new FabricaDeVendedores();break;
                default: fabrica = null;break;
            }
            return fabrica.crearAleatorio();
        }
        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch(opcion)
            {
                case 1: fabrica = new FabricaDeNumeros();break;
                case 2: fabrica = new FabricaDeAlumnos();break;
                case 3: fabrica = new FabricaDeVendedores();break;
                default: fabrica = null;break;
            }
            return fabrica.crearPorTeclado();
        }
        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
    }
}