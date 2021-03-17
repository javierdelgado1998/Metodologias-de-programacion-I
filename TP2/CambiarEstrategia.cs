namespace Metodologías.TP2
{
    public class CambiarEstrategia
    {
        public void cambiarEstrategia(Iterable coleccionable, EstrategiaComparacion estrategia)
        {
            Iterador x = coleccionable.crearIterador();
            while(!x.fin())
            {
                object alu = x.actual();
                ((Alumno)alu).setEstrategia(estrategia);
                x.siguiente();
            }
        }
    }
}