namespace Metodologías.TP7
{
    public abstract class FabricaDePersonas : FabricaDeComparables
    {
        public string crearNombreDesdeArchivo()
        {
            return responsable.stringDesdeArchivo(3);
        }
        public int crearDNIDesdeArchivo()
        {
            return (int)responsable.numeroDesdeArchivo(1000);
        }
        public string crearNombreAleatorio()
        {
            return responsable.stringAleatorio(6);
        }
        public int crearDNIAleatorio()
        {
            return responsable.numeroAleatorio(1000);
        } 
        public string crearNombrePorTeclado()
        {
            return responsable.stringPorTeclado();
        }
        public int crearDNIPorTeclado()
        {
            return responsable.numeroPorTeclado();
        }    
    }
}