using System;
using System.Collections.Generic;

namespace NIST.Extensions {
	internal static class ArrayExtensions {
		public static double LastEl(this double[] array) => array[array.Length - 1];

		public static int SumWith(this int[] array, int startIndex) {
			int sum = 0;
			for (int i = startIndex; i < array.Length; i++)
				sum += array[i];
			return sum;
		}

		public static double SumTo(this List<double> array, int exclusiveEndIndex) {
			double sum = 0;
			for (int i = 0; i < exclusiveEndIndex; i++)
				sum += array[i];
			return sum;
		}
        
		public static void Clear(this Array array) => Array.Clear(array, 0, array.Length);
	}
}