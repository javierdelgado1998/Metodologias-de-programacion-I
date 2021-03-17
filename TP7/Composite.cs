using System;
using System.Collections.Generic;
namespace Metodologías.TP7
{
    public class AlumnoCompuesto : IAlumno
    {
        List<IAlumno> hijos = new List<IAlumno>();
        public void agregarHijo(IAlumno alumno)
        {
            hijos.Add(alumno);
        }
        public string getNombre()
        {
            string nombres = null;
            foreach (IAlumno a in hijos)
            {
                nombres+= a.getNombre() + ", ";
            }
            return nombres;
        }
        public int responderPregunta(int pregunta)
        {
            int[] preguntas = new int[3] {0,0,0};
            foreach (IAlumno a in hijos)
            {
                preguntas[a.responderPregunta(pregunta)]++;                
            }
            //Console.WriteLine("pregunta {0}",pregunta);
            int notaMax = preguntas[0];
            int valorI = 0;
            for (int i = 0; i < 3; i++)
            {
                if(preguntas[i] > notaMax)
                {
                    valorI = i;
                    notaMax = preguntas[i];
                }
                //Console.WriteLine("preguntas de I {0}",preguntas[i]);
            }
            //Console.WriteLine("Valor I "+valorI);
            return valorI;
        }
        public void setCalificacion(int calificacion)
        {
            foreach (IAlumno a in hijos)
            {
                a.setCalificacion(calificacion);
            }
        }
        public string mostrarCalificacion()
        {
            int sumaNotas = 0;
            int contador = 0;
            foreach (IAlumno a in hijos)
            {
                sumaNotas+= a.getCalificacion();
                contador++;
            }            
            return this.getNombre() + (sumaNotas/contador).ToString();
        }
        public int getCalificacion()
        {
            int calificaciones = 0;
            foreach (IAlumno a in hijos)
            {
                calificaciones+= a.getCalificacion();
            }
            return calificaciones;
        }
        public int getLegajo()
        {
            int legajos = 0;
            foreach (IAlumno a in hijos)
            {
                legajos+= a.getLegajo();
            }
            return legajos;
        }
        public bool sosIgual(Comparable comparable)
        {
            foreach (IAlumno a in hijos)
            {
                if(a.sosIgual((IAlumno)comparable))
                {
                    return true;
                }
            }
            return false;
        }
        public bool sosMayor(Comparable comparable)
        {
            foreach (IAlumno a in hijos)
            {
                if(!a.sosMayor((IAlumno)comparable))
                {
                    return false;
                }
            }
            return true;
        }
        public bool sosMenor(Comparable comparable)
        {
            foreach (IAlumno a in hijos)
            {
                if(!a.sosMenor((IAlumno)comparable))
                {
                    return false;
                }
            }
            return true;
        }

    }
    public abstract class TorneoCartas
    {
        protected JuegoDeCartas juego;
        public abstract Persona ganadorJuego();

        public abstract void setJuego(JuegoDeCartas juego);

    } 
    public class Torneo : TorneoCartas
    {
        List<TorneoCartas> hijos = new List<TorneoCartas>();
        public Torneo()
        {
            this.juego = new JuegoUno();
        }
        public void agregarHijo(TorneoCartas hijo)
        {
            hijos.Add(hijo);
        }
        public override Persona ganadorJuego()
        {
            Persona ganador = hijos[0].ganadorJuego();
            Persona ganador2 = hijos[1].ganadorJuego();
            List<Persona> ganadores = new List<Persona>();
            ganadores.Add(ganador);
            ganadores.Add(ganador2);
            Persona ganadorFinal = this.juego.jugar(ganadores);
            return ganadorFinal;
        }
        public override void setJuego(JuegoDeCartas juego)
        {
            this.juego = juego;
        }

    }
    public class Jugadores : TorneoCartas
    {
        private List<Persona> jugadores;
        public Jugadores(List<Persona> jugadores)
        {
            this.jugadores = jugadores;
            this.juego = new JuegoUno();
        }
        public override Persona ganadorJuego()
        {
            return this.juego.jugar(jugadores);
        }
        public override void setJuego(JuegoDeCartas juego)
        {
            this.juego = juego;
        }
    }

}