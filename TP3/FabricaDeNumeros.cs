using System;
namespace Metodologías.TP3
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios x = new GeneradorDeDatosAleatorios();
            return new Numero(x.numeroAleatorio(x.getRandom().Next()));
        }
        public override Comparable crearPorTeclado()
        {
            LectorDeDatos x = new LectorDeDatos();
            return new Numero(x.numeroPorTeclado());
        }
    }
}