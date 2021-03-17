namespace Metodologías.TP5
{
    public abstract class FabricaDePersonas : FabricaDeComparables
    {
        protected GeneradorDeDatosAleatorios gx = new GeneradorDeDatosAleatorios();
        protected LectorDeDatos dx = new LectorDeDatos();
        public abstract override Comparable crearProxy();
        public string crearNombreAleatorio()
        {
            return gx.stringAleatorio(10);
        }
        public int crearDNIAleatorio()
        {
            return gx.numeroAleatorio(100000000);
        } 
        public string crearNombrePorTeclado()
        {
            return dx.stringPorTeclado();
        }
        public int crearDNIPorTeclado()
        {
            return dx.numeroPorTeclado();
        }    
    }
}