namespace BitUtils.Extensions {
	public static class ByteExtensions {
		public static int GetBit(this byte value, int num) => (value >> num) & 1;
	}
}