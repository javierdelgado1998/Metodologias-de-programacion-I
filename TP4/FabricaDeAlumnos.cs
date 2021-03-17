
using System;
namespace Metodologías.TP4
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
        public int crearPromedioAleatorio()
        {
            return base.gx.numeroAleatorio(10);
        }
        public int crearPromedioPorTeclado()
        {
            return base.dx.numeroPorTeclado();
        }
        public int crearLegajoAleatorio()
        {
            return base.gx.numeroAleatorio(100000000);
        }
        public int crearLegajoPorTeclado()
        {
            return base.dx.numeroPorTeclado();
        }
    }
    public class FabricaDeAlumnosMuyEstudiosos : FabricaDeAlumnos
    {
        public override Comparable crearAleatorio()
        {
            return new AlumnoMuyEstudioso(base.crearNombreAleatorio(),base.crearDNIAleatorio(),base.crearLegajoAleatorio(),base.crearPromedioAleatorio());
        }
        public override Comparable crearPorTeclado()
        {
            return new AlumnoMuyEstudioso(base.crearNombrePorTeclado(),base.crearDNIPorTeclado(),base.dx.numeroPorTeclado(),base.dx.numeroPorTeclado());
        }

    }
}
