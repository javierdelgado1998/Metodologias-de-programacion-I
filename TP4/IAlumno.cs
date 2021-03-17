namespace Metodologías.TP4
{
    public interface IAlumno : Comparable
    {
        string mostrarCalificacion();
        void setCalificacion(int valor);
        int responderPregunta(int pregunta);
        string getNombre();
        int getCalificacion();
        int getLegajo();

        
    }
}