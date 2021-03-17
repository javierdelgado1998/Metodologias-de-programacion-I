using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Metodologías.TP1
{
	public class Pila : PilaCola
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
	}
}
