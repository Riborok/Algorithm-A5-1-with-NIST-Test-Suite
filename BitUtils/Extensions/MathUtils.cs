namespace BitUtils.Extensions {
	public static class MathUtils {
		public static int CeilInt(int value, int divisor) => value / divisor + (value % divisor == 0 ? 0 : 1);
	}
}