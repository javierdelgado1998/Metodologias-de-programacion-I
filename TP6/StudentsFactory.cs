namespace Metodologías.TP6
{
    public class StudentsFactory : FabricaDeAlumnos
    {
        public override Comparable crearAleatorio()
        {
            IAlumno x = (Alumno)base.crearAleatorio();
            IAlumno dec = new NotaConLegajo(x);
            dec = new NotaSecuencial(dec);
            dec = new NotaConAsteriscos(dec);
            dec = new NotaEnLetras(dec);
            dec = new NotaConPromocion(dec);
            Comparable s = new AdaptadorAlumno(dec);
            return s;
        }
        public override Comparable crearPorTeclado()
        {
            IAlumno x = (Alumno)base.crearPorTeclado();
            IAlumno dec = new NotaConLegajo(x);
            dec = new NotaSecuencial(dec);
            dec = new NotaConAsteriscos(dec);
            dec = new NotaEnLetras(dec);
            dec = new NotaConPromocion(dec);
            Comparable s = new AdaptadorAlumno(dec);
            return s;
        }
        public override Comparable crearProxy()
        {
            Comparable s = new AdaptadorAlumno(new ProxyAlumnoDecoradoAdaptado(crearNombreAleatorio(),crearDNIAleatorio(),crearLegajoAleatorio(),crearPromedioAleatorio()));
            return s;
        }  

    }
}