
using System;
namespace Metodologías.TP6
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
        public static IAlumno crearAlumno(string nombre, int dni, int legajo, int promedio, int tipoAlumno)
        {
            switch(tipoAlumno)
            {
                case 1: return new Alumno(nombre,dni,legajo,promedio);
                case 2: return new AlumnoMuyEstudioso(nombre,dni,legajo,promedio);
                case 3:
                    IAlumno x = new Alumno(nombre,dni,legajo,promedio);
                    IAlumno dec = new NotaConLegajo(x);
                    dec = new NotaSecuencial(dec);
                    dec = new NotaConAsteriscos(dec);
                    dec = new NotaEnLetras(dec);
                    dec = new NotaConPromocion(dec);
                    return dec;
                default: return null;
            }
        }
        public override Comparable crearProxy()
        {
            return new ProxyAlumno(base.crearNombreAleatorio(),base.crearDNIAleatorio(),crearLegajoAleatorio(),crearPromedioAleatorio());
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
        public override Comparable crearProxy()
        {
            return new ProxyAlumnoEstudioso(crearNombreAleatorio(),crearDNIAleatorio(),crearLegajoAleatorio(),crearPromedioAleatorio());
        }
    }
    public class FabricaDeAlumnosCompuestos : FabricaDeAlumnos
    {
        public override Comparable crearAleatorio()
        {
            AlumnoCompuesto ac = new AlumnoCompuesto();
            for (int i = 0; i < 3; i++)
            {
                IAlumno alumno = (IAlumno)FabricaDeComparables.crearProxy(1);
                IAlumno alumnoEstudioso = (IAlumno)FabricaDeComparables.crearProxy(2);
                ac.agregarHijo(alumno);
                ac.agregarHijo(alumnoEstudioso);
            }
            ac.agregarHijo((IAlumno)FabricaDeComparables.crearProxy(2));
            return ac;
        }
        public override Comparable crearPorTeclado()
        {
            AlumnoCompuesto ac = new AlumnoCompuesto();
            for (int i = 0; i < 3; i++)
            {
                IAlumno alumno = (IAlumno)FabricaDeComparables.crearProxy(1);
                IAlumno alumnoEstudioso = (IAlumno)FabricaDeComparables.crearProxy(2);
                ac.agregarHijo(alumno);
                ac.agregarHijo(alumnoEstudioso);
            }
            ac.agregarHijo((IAlumno)FabricaDeComparables.crearProxy(2));
            return ac;
        }    
    }
}
