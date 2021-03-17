
using System;
namespace Metodologías.TP3
{
    public class FabricaDeAlumnos : FabricaDePersonas
    {
        public override Comparable crearAleatorio()
        {
            return new Alumno(base.crearNombreAleatorio(),base.crearDNIAleatorio(),base.gx.numeroAleatorio(100000000),base.gx.numeroAleatorio(10));
        }
        public override Comparable crearPorTeclado()
        {
            return new Alumno(base.crearNombrePorTeclado(),base.crearDNIPorTeclado(),base.dx.numeroPorTeclado(),base.dx.numeroPorTeclado());
        }
    }
}
