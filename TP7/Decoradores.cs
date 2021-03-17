namespace Metodologías.TP7
{
    public class NotaConLegajo : Decorador
    {
        public NotaConLegajo(IAlumno adicional):base(adicional)
        {
            
        }
        public override string mostrarCalificacion()
        {
            string s = base.mostrarCalificacion();
            int index = s.IndexOf(" ");
            string modified = s.Insert(index," ("+adicional.getLegajo()+")");
            return modified;
        }
    }
    public class NotaConAsteriscos : Decorador
    {
        public NotaConAsteriscos(IAlumno adicional):base(adicional)
        {
            
        }
        public override string mostrarCalificacion()
        {
            string s = "***********************************************";
            s += ("\n* "+base.mostrarCalificacion()+" *");
            s += "\n***********************************************";
            return s;
        }
    }
    public class NotaConPromocion : Decorador
    {
        public NotaConPromocion(IAlumno adicional):base(adicional)
        {
            
        }
        public override string mostrarCalificacion()
        {
            int nota = adicional.getCalificacion();
            string s = base.mostrarCalificacion();
            int index = s.LastIndexOf(")");
            string aux = null;
            if(nota >= 7)
            {
                aux = "PROMOCIÓN";
            }
            else
            {
                if(nota >= 4 && nota <7)
                {
                    aux = "APROBADO";
                }
                else
                {
                    aux = "DESAPROBADO";
                }
            }
            string modified = s.Insert(index+1,"("+aux+")");
            return modified;
        }
    }
    public class NotaEnLetras : Decorador
    {
        private string[] letras = new string[]{"CERO","UNO","DOS","TRES","CUATRO","CINCO","SEIS","SIETE","OCHO","NUEVE","DIEZ"};
        public NotaEnLetras(IAlumno adicional):base(adicional)
        {
            
        }
        public override string mostrarCalificacion()
        {
            string s = base.mostrarCalificacion();
            int index = s.LastIndexOf(adicional.getCalificacion().ToString());
            string modified = s.Insert(index+2, "("+letras[adicional.getCalificacion()]+")");
            return modified;
        }
    }
    public class NotaSecuencial : Decorador
    {
        static int contador = 1;
        public NotaSecuencial(IAlumno adicional):base(adicional)
        {

        }
        public override string mostrarCalificacion()
        {
            string s = base.mostrarCalificacion();
            string modified = s.Insert(0,contador.ToString()+")");
            contador++;
            return modified;
        }
    }
    public class NotaEnIngles : Decorador
    {
        public NotaEnIngles(IAlumno adicional):base(adicional)
        {

        } 
        public override string mostrarCalificacion()
        {
            string[] nota = new string[] {"zero","one","two","three","four","five","six","seven","eight","nine","ten"};
            string s = base.mostrarCalificacion();
            string modified = s + nota[adicional.getCalificacion()];
            return modified;
        }       
    }

}