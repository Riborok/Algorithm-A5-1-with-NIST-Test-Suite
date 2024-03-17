namespace Algorithm5A_1.Extensions {
	public static class UIntExtensions {
		public static uint ToBit(this uint value) => (value != 0).ToUInt64();
	}
}