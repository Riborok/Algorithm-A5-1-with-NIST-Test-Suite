namespace BitUtils {
	public class BinaryMatrix {
		private readonly int[,] _matrix;

		public BinaryMatrix(BitArray bitArray, int quantityOfPrevMatrices, int rowCount, int columnCount) {
			_matrix = new int[rowCount, columnCount];
			for (int i = 0; i < rowCount; i++) 
				for (int j = 0; j < columnCount; j++)
					_matrix[i, j] = bitArray[quantityOfPrevMatrices * rowCount * columnCount + i * columnCount + j];
		}
		
		public int this[int row, int column] {
			get => _matrix[row, column];
			set => _matrix[row, column] = value;
		}
		
		public int RowCount => _matrix.GetLength(0);
		
		public int ColumnCount => _matrix.GetLength(1);
	}
}