namespace Metodologías.TP3
{
    public abstract class FabricaDeColeccionables : IFabricaDeColeccionables
    {
        public static Coleccionable crearPorTeclado(int opcion)
        {
            FabricaDeColeccionables fabrica = null;
            switch(opcion)
            {
                case 1: fabrica = new FabricaDeCola();break;
                case 2: fabrica = new FabricaDePila();break;
                case 3: fabrica = new FabricaDeMultiple();break;
                case 4: fabrica = new FabricaDeConjunto();break;
                case 5: fabrica = new FabricaDeDiccionario();break;
                default: fabrica = null;break;
            }
            return fabrica.crear();
        }
        public abstract Coleccionable crear();
    }

    public interface IFabricaDeColeccionables
    {
        public Coleccionable crear();
    }

    public class FabricaDeCola : FabricaDeColeccionables
    {
        public override Coleccionable crear()
        {
            return new Cola();
        }
    }
    public class FabricaDePila : FabricaDeColeccionables
    {
        public override Coleccionable crear()
        {
            return new Pila();
        }
    }
    public class FabricaDeMultiple : FabricaDeColeccionables
    {
        public override Coleccionable crear()
        {
            return new ColeccionMultiple(new Pila(),new Cola());
        }
    }
    public class FabricaDeConjunto: FabricaDeColeccionables
    {
        public override Coleccionable crear()
        {
            return new Conjunto();
        }
    }
    public class FabricaDeDiccionario: FabricaDeColeccionables
    {
        public override Coleccionable crear()
        {
            return new Diccionario();
        }
    }

}