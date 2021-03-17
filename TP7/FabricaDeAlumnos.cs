
using System;
namespace Metodologías.TP7
{
    public class FabricaDeAlumnos : FabricaDePersonas
    {
        public override Comparable crearAleatorio()
        {
            return new Alumno(base.crearNombreAleatorio(),base.crearDNIAleatorio(),this.crearLegajoAleatorio(),this.crearPromedioAleatorio());
        }
        public override Comparable crearPorTeclado()
        {
            return new Alumno(base.crearNombrePorTeclado(),base.crearDNIPorTeclado(),this.crearLegajoPorTeclado(),this.crearPromedioPorTeclado());
        }
        public override Comparable crearPorArchivo()
        {
            return new Alumno(base.crearNombreDesdeArchivo(),base.crearDNIDesdeArchivo(),this.crearLegajoDesdeArchivo(),this.crearPromedioDesdeArchivo());
        }
        public int crearPromedioAleatorio()
        {
            return responsable.numeroAleatorio(10);
        }
        public int crearPromedioPorTeclado()
        {
            return responsable.numeroPorTeclado();
        }
        public int crearLegajoAleatorio()
        {
            return responsable.numeroAleatorio(1000);
        }
        public int crearLegajoPorTeclado()
        {
            return responsable.numeroPorTeclado();
        }
        public int crearLegajoDesdeArchivo()
        {
            return (int)responsable.numeroDesdeArchivo(1000);
        }
        public int crearPromedioDesdeArchivo()
        {
            return (int)responsable.numeroDesdeArchivo(10);
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
        public override Comparable crearProxy(int opcion)
        {
            switch(opcion)
            {
                case 1:
                    return new ProxyAlumno(base.crearNombreAleatorio(),base.crearDNIAleatorio(),crearLegajoAleatorio(),crearPromedioAleatorio());
                case 2:
                    return new ProxyAlumno(base.crearNombrePorTeclado(),base.crearDNIPorTeclado(),crearLegajoPorTeclado(),crearPromedioPorTeclado());
                case 3:
                    return new ProxyAlumno(base.crearNombreDesdeArchivo(),base.crearDNIDesdeArchivo(),crearLegajoDesdeArchivo(),crearPromedioDesdeArchivo());
                default:
                    return null;
            }
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
            return new AlumnoMuyEstudioso(base.crearNombrePorTeclado(),base.crearDNIPorTeclado(),base.crearLegajoPorTeclado(),base.crearPromedioPorTeclado());
        }
        public override Comparable crearPorArchivo()
        {
            return new AlumnoMuyEstudioso(base.crearNombreDesdeArchivo(),base.crearDNIDesdeArchivo(),base.crearLegajoDesdeArchivo(),base.crearPromedioDesdeArchivo());
        }
        public override Comparable crearProxy(int opcion)
        {
            switch(opcion)
            {
                case 1:
                    return new ProxyAlumnoEstudioso(base.crearNombreAleatorio(),base.crearDNIAleatorio(),crearLegajoAleatorio(),crearPromedioAleatorio());
                case 2:
                    return new ProxyAlumnoEstudioso(base.crearNombrePorTeclado(),base.crearDNIPorTeclado(),crearLegajoPorTeclado(),crearPromedioPorTeclado());
                case 3:
                    return new ProxyAlumnoEstudioso(base.crearNombreDesdeArchivo(),base.crearDNIDesdeArchivo(),crearLegajoDesdeArchivo(),crearPromedioDesdeArchivo());
                default:
                    return null;
            }
        }
    }
    public class FabricaDeAlumnosCompuestos : FabricaDeAlumnos
    {
        public override Comparable crearAleatorio()
        {
            AlumnoCompuesto ac = new AlumnoCompuesto();
            for (int i = 0; i < 3; i++)
            {
                IAlumno alumno = (IAlumno)FabricaDeComparables.crearProxy(1,1);
                IAlumno alumnoEstudioso = (IAlumno)FabricaDeComparables.crearProxy(2,1);
                ac.agregarHijo(alumno);
                ac.agregarHijo(alumnoEstudioso);
            }
            return ac;
        }
        public override Comparable crearPorTeclado()
        {
            AlumnoCompuesto ac = new AlumnoCompuesto();
            for (int i = 0; i < 3; i++)
            {
                IAlumno alumno = (IAlumno)FabricaDeComparables.crearProxy(1,2);
                IAlumno alumnoEstudioso = (IAlumno)FabricaDeComparables.crearProxy(2,2);
                ac.agregarHijo(alumno);
                ac.agregarHijo(alumnoEstudioso);
            }
            return ac;
        }
        public override Comparable crearPorArchivo()
        {
            AlumnoCompuesto ac = new AlumnoCompuesto();
            for (int i = 0; i < 3; i++)
            {
                IAlumno alumno = (IAlumno)FabricaDeComparables.crearProxy(1,3);
                IAlumno alumnoEstudioso = (IAlumno)FabricaDeComparables.crearProxy(2,3);
                ac.agregarHijo(alumno);
                ac.agregarHijo(alumnoEstudioso);
            }
            return ac;           
        }    
    }
}
