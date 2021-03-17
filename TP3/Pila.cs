using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Metodologías.TP3
{
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
}
