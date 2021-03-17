namespace Metodologías.TP7
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
        public override Comparable crearProxy(int opcion)
        {
            Comparable s;
            switch(opcion)
            {
                case 1:
                    s = new AdaptadorAlumno(new ProxyAlumnoDecoradoAdaptado(crearNombreAleatorio(),crearDNIAleatorio(),crearLegajoAleatorio(),crearPromedioAleatorio()));
                    return s;
                case 2:
                    s = new AdaptadorAlumno(new ProxyAlumnoDecoradoAdaptado(crearNombrePorTeclado(),crearDNIPorTeclado(),crearLegajoPorTeclado(),crearPromedioPorTeclado()));
                    return s;
                case 3:
                    s = new AdaptadorAlumno(new ProxyAlumnoDecoradoAdaptado(crearNombreDesdeArchivo(),crearDNIDesdeArchivo(),crearLegajoDesdeArchivo(),crearPromedioDesdeArchivo()));
                    return s;
                default:
                    return null;
            }
        }  

    }
}