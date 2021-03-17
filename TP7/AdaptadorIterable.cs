namespace Metodologías.TP7
{
    public class AdaptadorIterable : Collection
    {
      Coleccionable coleccionable;
      public AdaptadorIterable(Coleccionable coleccionable)
      {
        this.coleccionable = coleccionable;
      }
		  public IteratorOfStudent getIterator()
      {
        AdaptadorIterador ad = new AdaptadorIterador(((Iterable)coleccionable).crearIterador());
        return ad;
      }
		  public void addStudent(Student student)
      {
        coleccionable.agregar((AdaptadorAlumno)student);
      }
		  public void sort()
      {
        coleccionable.ordenar();
      }
    }
    public class AdaptadorIterador : IteratorOfStudent
    {
      Iterador coleccionable;
      public AdaptadorIterador(Iterador coleccionable)
      {
        this.coleccionable = coleccionable;
      }
		  public void beginning()
      {
        coleccionable.primero();
      }
		  public bool end()
      {
        return coleccionable.fin();
      }
		  public Student current()
      {
        return (Student)coleccionable.actual();
      }
		  public void next()
      {
        coleccionable.siguiente();
      }
    }
}