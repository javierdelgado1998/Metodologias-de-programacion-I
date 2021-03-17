namespace Metodologías.TP3
{
    public class FabricaDePersonas : FabricaDeComparables
    {
        protected GeneradorDeDatosAleatorios gx = new GeneradorDeDatosAleatorios();
        protected LectorDeDatos dx = new LectorDeDatos();
        public override Comparable crearAleatorio()
        {
            return new Persona(gx.stringAleatorio(10),gx.numeroAleatorio(100000000));
        }
        public override Comparable crearPorTeclado()
        {
            return new Persona(dx.stringPorTeclado(),dx.numeroPorTeclado());
        } 
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