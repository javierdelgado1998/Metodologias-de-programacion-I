using System;
namespace Metodologías.TP6
{
    public class Aula
    {
        Teacher teacher;
        public void comenzar()
        {
            Console.WriteLine("¡¡¡Comenzamos!!!");
            teacher = new Teacher();
        }
        public void nuevoAlumno(IAlumno alumno)
        {
            teacher.goToClass(new AdaptadorAlumno(alumno));
        }
        public void claseLista()
        {
            teacher.teachingAClass();
        }
    }

}