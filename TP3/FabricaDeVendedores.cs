namespace Metodologías.TP3
{
    public class FabricaDeVendedores : FabricaDePersonas
    {
        public override Comparable crearAleatorio()
        {
            return new Vendedor(base.crearNombreAleatorio(),base.crearDNIAleatorio(),base.gx.numeroAleatorio(100000000));
        }
        public override Comparable crearPorTeclado()
        {
            return new Vendedor(base.crearNombrePorTeclado(),base.crearDNIPorTeclado(),base.dx.numeroPorTeclado());
        }       
    }
}