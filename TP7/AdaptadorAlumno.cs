namespace Metodologías.TP7
{
    public class AdaptadorAlumno : Student, Comparable, IAlumno
    {
        IAlumno alumno;
        public AdaptadorAlumno(IAlumno alumno)
        {
            this.alumno= alumno;
        }
		public string getName()
        {
            return alumno.getNombre();
        }
        private IAlumno getAlumno()
        {
            return alumno;
        }
		public int yourAnswerIs(int question)
        {
            return alumno.responderPregunta(question);
        }
		public void setScore(int score)
        {
            alumno.setCalificacion(score);
        }
		public string showResult()
        {
            return alumno.mostrarCalificacion();
        }
		public bool equals(Student student)
        {
            return alumno.sosIgual(((AdaptadorAlumno)student).getAlumno());
        }
		public bool lessThan(Student student)
        {
            return alumno.sosMenor(((AdaptadorAlumno)student).getAlumno());
        }
		public bool greaterThan(Student student)
        {
            return alumno.sosMayor(((AdaptadorAlumno)student).getAlumno());
        }
        // Implemente estos metodos para poder retornar en la fabrica de students a un comparable
        public bool sosIgual(Comparable comparable)
        {
            return alumno.sosIgual((AdaptadorAlumno)comparable);
        }
        public bool sosMayor(Comparable comparable)
        {
            return alumno.sosMayor((AdaptadorAlumno)comparable);
        }
        public bool sosMenor(Comparable comparable)
        {
            return alumno.sosMenor((AdaptadorAlumno)comparable);
        }
        //-------------------------------------------------------------------------------------
        public string mostrarCalificacion()
        {
            return alumno.mostrarCalificacion();
        }
        public void setCalificacion(int valor)
        {
            alumno.setCalificacion(valor);
        }
        public int responderPregunta(int pregunta)
        {
            return alumno.responderPregunta(pregunta);
        }
        public string getNombre()
        {   
            return alumno.getNombre();
        }
        public int getCalificacion()
        {
            return alumno.getCalificacion();
        }
        public int getLegajo()
        {
            return alumno.getLegajo();
        }
    }
}