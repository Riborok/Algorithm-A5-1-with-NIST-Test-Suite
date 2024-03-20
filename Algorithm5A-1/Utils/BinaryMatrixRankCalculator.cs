namespace Algorithm5A_1.Utils {
	public static class BinaryMatrixRankCalculator {
		public static int CalculateRank(int[,] matrix) {
			int rowCount = matrix.GetLength(0);
			int colCount = matrix.GetLength(1);
			
			int rank = 0;
			ConvertToRowEchelonForm(matrix, rowCount, colCount, ref rank);

			return rank;
		}
		
		private static void ConvertToRowEchelonForm(int[,] matrix, int rowCount, int colCount, ref int rank) {
			int row = 0;
			int col = 0;
			while (row < rowCount && col < colCount) {
				int pivotRow = FindPivotRow(matrix, col, row, rowCount);
				if (pivotRow != -1) {
					rank++;
					if (pivotRow != row)
						SwapRows(matrix, row, pivotRow, colCount);
					EliminateRow(matrix, row, col, rowCount, colCount);
					row++;
				}
				col++;
			}
		}
		
		private static int FindPivotRow(int[,] matrix, int pivotCol, int startRow, int rowCount) {
			for (int i = startRow; i < rowCount; i++)
				if (matrix[i, pivotCol] == 1)
					return i;
			return -1;
		}
		
		private static void SwapRows(int[,] matrix, int row1, int row2, int colCount) {
			for (int j = 0; j < colCount; j++)
				(matrix[row1, j], matrix[row2, j]) = (matrix[row2, j], matrix[row1, j]);
		}
		
		private static void EliminateRow(int[,] matrix, int row, int pivotCol, int rowCount, int colCount) {
			for (int i = row + 1; i < rowCount; i++)
				if (matrix[i, pivotCol] == 1)
					for (int j = pivotCol; j < colCount; j++)
						matrix[i, j] ^= matrix[row, j];
		}
	}
}