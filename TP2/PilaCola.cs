using System;
using System.Collections;
using System.Collections.Generic;

namespace Metodologías.TP2
{
    public abstract class PilaCola : Coleccionable
    {
        protected List<Comparable> datos;
        public void agregar(Comparable c)
		{
			datos.Add(c);
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
    }
}