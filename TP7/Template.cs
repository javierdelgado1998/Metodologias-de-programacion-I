using System;
using System.Collections.Generic;
namespace Metodologías.TP7
{
    public abstract class JuegoDeCartas
    {
        protected Random r = new Random();
        protected Persona ganador;
        public Persona jugar(List<Persona> jugadores)
        {
            int rondas = 0;
            this.mezclarElMazo();
            this.repartirCartasIniciales();
            while(rondas <= 3)
            {
                ganador = null;
                while(!this.hayaGanador())
                {
                    this.tomarCartas(jugadores[r.Next(0,jugadores.Count)]);
                    this.descartarCartas(jugadores[r.Next(0,jugadores.Count)]);
                    this.tomarCartas(jugadores[r.Next(0,jugadores.Count)]);
                    this.descartarCartas(jugadores[r.Next(0,jugadores.Count)]);
                }
                Console.WriteLine("El ganador de esta ronda es ****{0}****",ganador.getNombre());
                rondas++;               
            }
            return ganador;
        }
        public abstract void mezclarElMazo();
        public abstract void repartirCartasIniciales();
        public abstract bool hayaGanador();
        public abstract void tomarCartas(Persona persona);
        public abstract void descartarCartas(Persona persona);
    }
    public class JuegoUno : JuegoDeCartas
    {
        public override void mezclarElMazo()
        {
            Console.WriteLine("Mezclando mazo...");
        }
        public override void repartirCartasIniciales()
        {
            Console.WriteLine("Repartiendo cartas iniciales...");
        }
        public override bool hayaGanador()
        {
            return ganador != null;
        }
        public override void tomarCartas(Persona persona)
        {
            Console.WriteLine("{0} tomo una carta",persona.getNombre());
        }
        public override void descartarCartas(Persona persona)
        {
            int cartas = r.Next(0,10);
            Console.WriteLine("{0} descarto {1} cartas",persona.getNombre(), cartas);
            if(cartas > 5)
            {
                ganador = persona;
            }            
        }
    }
}