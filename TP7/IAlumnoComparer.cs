using System;
using System.Collections.Generic;
namespace Metodologías.TP7
{
	internal class IAlumnoComparer : IComparer<Comparable>
	{
		public int Compare(Comparable s1, Comparable s2)
		{
			if(s1.sosIgual(s2))
				return 0;
			else
			if(s1.sosMenor(s2))
				return 1;
			else
				return -1;
		}
	}
}
