using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Metodologías.TP2
{

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
