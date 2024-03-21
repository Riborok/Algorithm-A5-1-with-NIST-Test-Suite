﻿namespace Algorithm5A_1.BitUtils.Extensions {
	public static class ULongExtensions {
		public static ulong GetBit(this ulong value, int num) => (value >> num) & 1;
	}
}