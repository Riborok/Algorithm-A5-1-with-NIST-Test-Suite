namespace BitUtils {
	public static class BinaryMatrixRankCalculator {
		public static int CalcRank(BinaryMatrix matrix) {
			ConvertToRowEchelonForm(matrix, out int rank);
			return rank;
		}
		
		private static void ConvertToRowEchelonForm(BinaryMatrix matrix, out int rank) {
			rank = 0;
			int row = 0, col = 0;
			while (row < matrix.RowCount && col < matrix.ColumnCount) {
				int pivotRow = FindPivotRow(matrix, col, row);
				if (pivotRow != -1) {
					rank++;
					if (pivotRow != row)
						SwapRows(matrix, row, pivotRow);
					EliminateRow(matrix, row, col);
					row++;
				}
				col++;
			}
		}
		
		private static int FindPivotRow(BinaryMatrix matrix, int pivotCol, int startRow) {
			for (int i = startRow; i < matrix.RowCount; i++)
				if (matrix[i, pivotCol] == 1)
					return i;
			return -1;
		}
		
		private static void SwapRows(BinaryMatrix matrix, int row1, int row2) {
			for (int j = 0; j < matrix.ColumnCount; j++)
				(matrix[row1, j], matrix[row2, j]) = (matrix[row2, j], matrix[row1, j]);
		}
		
		private static void EliminateRow(BinaryMatrix matrix, int row, int pivotCol) {
			for (int i = row + 1; i < matrix.RowCount; i++)
				if (matrix[i, pivotCol] == 1)
					for (int j = pivotCol; j < matrix.ColumnCount; j++)
						matrix[i, j] ^= matrix[row, j];
		}
	}
}