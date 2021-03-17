using System;

namespace Metodologías.TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------EJERCICIO 8-----------------------------
            Teacher teacher = new Teacher();
            for (int i = 0; i < 10; i++)
            {
                IAlumno s = (Alumno)FabricaDeComparables.crearAleatorio(1);
                IAlumno dec = new NotaConLegajo(s);
                dec = new NotaSecuencial(dec);
                dec = new NotaConAsteriscos(dec);
                dec = new NotaEnLetras(dec);
                dec = new NotaConPromocion(dec);
                dec = new NotaEnIngles(dec);
                teacher.goToClass(new AdaptadorAlumno(dec));
            }
            for (int i = 0; i < 10; i++)
            {
                IAlumno s = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(2);
                IAlumno dec = new NotaConLegajo(s);
                dec = new NotaSecuencial(dec);
                dec = new NotaConAsteriscos(dec);
                dec = new NotaEnLetras(dec);
                dec = new NotaConPromocion(dec);
                dec = new NotaEnIngles(dec);
                teacher.goToClass(new AdaptadorAlumno(dec));
            }
            teacher.teachingAClass();
        }
    }
}
