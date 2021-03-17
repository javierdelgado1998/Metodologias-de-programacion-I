using System;
namespace Metodologías.TP5
{
    public class ProxyAlumno : IAlumno
    {
        protected IAlumno alumnoReal = null;
        protected string nombre;
        protected int calificacion;
        protected int legajo;
        protected int dni;
        protected int promedio;
        public ProxyAlumno(string nombre, int dni, int legajo, int promedio)
        {
            this.nombre = nombre;
            this.legajo = legajo;
            this.dni = dni;
            this.promedio = promedio;
        }
        public string mostrarCalificacion()
        {
            if(alumnoReal != null)
            {
                return alumnoReal.mostrarCalificacion();
            }
            else
            {
                return null;
            }
        }
        public void setCalificacion(int valor)
        {
            calificacion = valor;
            if(alumnoReal != null)
            {
                alumnoReal.setCalificacion(calificacion);
            }
        }
        public virtual int responderPregunta(int pregunta)
        {
            if(alumnoReal == null)
            {
                alumnoReal =  FabricaDeAlumnos.crearAlumno(nombre,dni,legajo,promedio,1);
                Console.WriteLine("Instancia de alumno real creada.");
            }
            return alumnoReal.responderPregunta(pregunta);
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public int getCalificacion()
        {
            return this.calificacion;
        }
        public int getLegajo()
        {
            return this.legajo;
        }
        public int getDNI()
        {
            return this.dni;
        }
        public int getPromedio()
        {
            return this.promedio;
        }
        public bool sosIgual(Comparable comparable)
        {
            return this.alumnoReal.sosIgual(comparable);
        }
        public bool sosMayor(Comparable comparable)
        {
            return this.alumnoReal.sosMayor(comparable);
        }
        public bool sosMenor(Comparable comparable)
        {
            return this.alumnoReal.sosMenor(comparable);
        }
    }
    //----------------------------ALUMNO ESTUDIOSO----------------------------------------------
    public class ProxyAlumnoEstudioso : ProxyAlumno
    {
        public ProxyAlumnoEstudioso(string nombre, int dni, int legajo, int promedio):base(nombre,dni,legajo,promedio)
        {

        }
        public override int responderPregunta(int pregunta)
        {
            if(alumnoReal == null)
            {
                alumnoReal = FabricaDeAlumnos.crearAlumno(nombre,dni,legajo,promedio,2);
                Console.WriteLine("Instancia de alumno estudioso real creada.");
            }
            return alumnoReal.responderPregunta(pregunta);
        }        
    }
    //-------------------------------ALUMNO DECORADO y ADAPTADO----------------------------------------
    public class ProxyAlumnoDecoradoAdaptado : ProxyAlumno
    {
        public ProxyAlumnoDecoradoAdaptado(string nombre, int dni, int legajo, int promedio):base(nombre,dni,legajo,promedio)
        {

        }
        public override int responderPregunta(int pregunta)
        {
            if(alumnoReal == null)
            {
                alumnoReal = FabricaDeAlumnos.crearAlumno(nombre,dni,legajo,promedio,3);
                Console.WriteLine("Instancia de alumno decorado y adaptado real creada.");
            }
            return alumnoReal.responderPregunta(pregunta);
        }                      
    }
}