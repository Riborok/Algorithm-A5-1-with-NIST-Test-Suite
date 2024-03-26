using System.Collections.Generic;
using System.Text;

namespace App.Managers {
	internal static class FrequencyAnalyzer {
		public static Dictionary<char, int> Analyze(byte[] bytes) {
			var freq = new Dictionary<char, int>();
			
			char[] textBuffer = Encoding.GetEncoding(1252).GetChars(bytes);
			foreach (char b in textBuffer)
				if (freq.ContainsKey(b))
					freq[b]++;
				else
					freq[b] = 1;

			return freq;
		}
	}
}