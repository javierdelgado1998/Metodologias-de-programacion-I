using System;

namespace Metodologías.TP7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Teacher teacher = new Teacher();
            for (int i = 0; i < 5; i++)
            {
                IAlumno x = (IAlumno)FabricaDeComparables.crearProxy(1,1);
                teacher.goToClass(new AdaptadorAlumno(x));
            }
            for (int i = 0; i < 2; i++)
            {
                IAlumno x = (IAlumno)FabricaDeComparables.crearProxy(2,2);
                teacher.goToClass(new AdaptadorAlumno(x));
            }
            IAlumno s = (IAlumno)FabricaDeComparables.crearPorArchivo(4);
            teacher.goToClass(new AdaptadorAlumno(s));
            teacher.teachingAClass();*/

            Teacher teacher = new Teacher();
            Cola c = new Cola();
            AdaptadorIterable adaptador = new AdaptadorIterable(c);
            teacher.setStudents(adaptador);
            for (int i = 0; i < 5; i++)
            {
                IAlumno x = (IAlumno)FabricaDeComparables.crearProxy(1,1);
                teacher.goToClass(new AdaptadorAlumno(x));
            }
            for (int i = 0; i < 2; i++)
            {
                IAlumno x = (IAlumno)FabricaDeComparables.crearProxy(2,2);
                teacher.goToClass(new AdaptadorAlumno(x));
            }
            teacher.teachingAClass();

        }
    }
}
