namespace Algorithm5A_1.Extensions {
	public static class BoolExtensions {
		public static uint ToUInt64(this bool value) => value ? 1u : 0u;
	}
}