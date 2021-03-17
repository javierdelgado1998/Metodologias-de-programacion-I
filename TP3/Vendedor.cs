using System;
using System.Collections.Generic;
namespace Metodologías.TP3
{
    public class Vendedor : Persona, IObservado
    {
        private int sueldoBasico;
        private float bonus;
        private float ultimoMonto;
        private List<IObservador> observadores = new List<IObservador>();
        public Vendedor(string nombre,int dni, int sueldoBasico): base(nombre,dni)
        {
            this.sueldoBasico = sueldoBasico;
            this.bonus = 1;
        }
        public void venta(float monto)
        {
            Console.WriteLine("Ventas: "+monto);
            ultimoMonto = monto;
            this.notificar();
        }
        public void aumentaBonus()
        {
            bonus += 0.1F;
        }
        public override bool sosIgual(Comparable c)
        {
            return this.bonus == ((Vendedor)c).bonus;
        }
        public override bool sosMayor(Comparable c)
        {
            return this.bonus > ((Vendedor)c).bonus;
        }
        public override bool sosMenor(Comparable c)
        {
            return this.bonus < ((Vendedor)c).bonus;
        }
        public override string ToString()
        {
            return(nombre,dni,sueldoBasico,bonus).ToString();
        }
        public void notificar()
        {
            foreach (IObservador o in observadores)
            {
                o.actualizar(this);
            }
        }
        public void agregarObservador(IObservador o)
        {
            observadores.Add(o);
        }
        public void quitarObservador(IObservador o)
        {
            observadores.Remove(o);
        }
        public float getUltimoMonto()
        {
            return ultimoMonto;
        }
        public float getBonus()
        {
            return this.bonus;
        }

    }
    public class VendedorPauperrimo : Vendedor
    {
        public VendedorPauperrimo(string nombre,int dni, int sueldoBasico): base(nombre,dni,sueldoBasico)
        {

        }
        public void robar()
        {
            Console.WriteLine("Estoy robando...");
        }
        public void descansar()
        {
            Console.WriteLine("Estoy descansando...");
        }
        public void  molestarALosCompañeros()
        {
            Console.WriteLine("Estoy molestando a mis compañeros...");
        }
    }
    public class Seguridad : IObservador
    {
        public void reaccionar()
        {
            Console.WriteLine("Seguridad reaccionando...");
        }
        public void actualizar(IObservado o)
        {
            float monto = ((VendedorPauperrimo)o).getUltimoMonto();
            if(monto < 500)
            {
                this.reaccionar();
            }
        }
    }
    public class Cliente : IObservador
    {
        public void reaccionar()
        {
            Console.WriteLine("Cliente reaccionando...");
        }
        public void actualizar(IObservado o)
        {
            float monto = ((VendedorPauperrimo)o).getUltimoMonto();
            if(monto > 4000)
            {
                this.reaccionar();
            }
        }
    }
    public class Encargado : IObservador
    {
        public void reaccionar()
        {
            Console.WriteLine("Encargado reaccionando...");
        }
        public void actualizar(IObservado o)
        {
            float monto = ((VendedorPauperrimo)o).getUltimoMonto();
            if(monto >= 500 && monto <= 4000)
            {
                this.reaccionar();
            }
        }
    }
}