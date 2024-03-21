namespace BitUtils.Extensions {
	public static class UIntExtensions {
		public static uint GetBit(this uint value, int num) => (value >> num) & 1;
	}
}