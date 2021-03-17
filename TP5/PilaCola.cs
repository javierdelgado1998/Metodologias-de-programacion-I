using System;
using System.Collections;
using System.Collections.Generic;

namespace Metodologías.TP5
{
    public abstract class PilaCola : Coleccionable
    {
		OrdenEnAula1 ordenInicio = null;
		OrdenEnAula2 ordenLlegaAlumno = null;
		OrdenEnAula1 ordenAulaLlena = null;

        protected List<Comparable> datos;
        public void agregar(Comparable c)
		{
			if(datos.Count == 0 && ordenInicio != null)
			{
				ordenInicio.ejecutar();
			}
			if(ordenLlegaAlumno != null)
			{
				ordenLlegaAlumno.ejecutar(c);
			}

			datos.Add(c);
			
			if(ordenAulaLlena != null && datos.Count == 40)
			{
				ordenAulaLlena.ejecutar();
			}

		}
        public abstract Comparable sacar();
		public Comparable minimo()
		{
			if(this.cuantos() > 0)
			{
				Comparable min = datos[0];
				for (int i = 0; i < datos.Count; i++)
				{
					if(datos[i].sosMenor(min))
					{
						min = datos[i];
					}
				}
				return min;				
			}
			else
			{
				return null;
			}
		}
		public Comparable maximo()
		{
			if(this.cuantos() > 0)
			{
				Comparable mayor = datos[0];
				for (int i = 0; i < datos.Count; i++)
				{
					if(datos[i].sosMayor(mayor))
					{
						mayor = datos[i];
					}
				}
				return mayor;				
			}
			else
			{
				return null;
			}
		}
		public int cuantos()
		{
			return datos.Count;
		}
		public bool contiene(Comparable c)
		{
			for (int i = 0; i < datos.Count; i++)
			{
				if(c.sosIgual(datos[i]))
				{
					return true;
				}
			}
			return false;
		}
        public void setOrdenInicio(OrdenEnAula1 ordenEnAula1)
		{
			ordenInicio = ordenEnAula1;
		}
        public void setOrdenLlegaAlumno(OrdenEnAula2 ordenEnAula1)
		{
			ordenLlegaAlumno = ordenEnAula1;
		}
        public void setOrdenAulaLlena(OrdenEnAula1 ordenEnAula1)
		{
			ordenAulaLlena = ordenEnAula1;
		}
    }
	public class Pila : PilaCola,Iterable
	{
		public Pila()
		{
			this.datos = new List<Comparable>();
		}
		public override Comparable sacar()
		{
			Comparable aux = datos[0];
			datos.RemoveAt(0);
			return aux;
		}
		public Iterador crearIterador()
		{
			return new PilaIterador(this.datos);
		}
	}
	public class Cola : PilaCola,Iterable
	{
		public Cola()
		{
			this.datos = new List<Comparable>();
		}
		public override Comparable sacar()
		{
			Comparable aux = datos[datos.Count-1];
			datos.RemoveAt((datos.Count-1));
			return aux;
		}
		public Iterador crearIterador()
		{
			return new ColaIterador(this.datos);
		}

	}
}