using System.Collections.Generic;
using Encryptor.FileUtils;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;

namespace Encryptor.Managers {
	internal class ExcelManager {
		private readonly string _title;
		private readonly BufferManager _bufferManager;
		private readonly FileManager _fileManager;
		
		public ExcelManager(string title, BufferManager bufferManager, FileManager fileManager) {
			_title = title;
			_bufferManager = bufferManager;
			_fileManager = fileManager;
		}

		public void Save() {
			if (_bufferManager.Buffer != null)
				_fileManager.Save(CreateXlsx(_bufferManager.Buffer));
		}

		public void SaveAs() {
			if (_bufferManager.Buffer != null)
				_fileManager.SaveAs(CreateXlsx(_bufferManager.Buffer));
		}

		private byte[] CreateXlsx(byte[] buffer) {
			using var package = new ExcelPackage();
			var frequency = FrequencyAnalyzer.Analyze(buffer);
			AddWorksheet(package, _title);
			AddDataToWorksheet(package.Workbook.Worksheets[0], frequency);
			AddChartToWorksheet(package.Workbook.Worksheets[0], 2, frequency.Count + 1);
			return package.GetAsByteArray();
		}
		
		private static void AddWorksheet(ExcelPackage package, string title) {
			var worksheet = package.Workbook.Worksheets.Add(title);
			worksheet.Cells[1, 1].Value = "Symbol";
			worksheet.Cells[1, 2].Value = "Frequency";
		}
		
		private static void AddDataToWorksheet(ExcelWorksheet worksheet, Dictionary<char, int> frequencyData)
		{
			int row = 2;
			foreach (var kvp in frequencyData) {
				worksheet.Cells[row, 1].Value = kvp.Key.ToString();
				worksheet.Cells[row, 2].Value = kvp.Value;
				row++;
			}
		}
		
		private static void AddChartToWorksheet(ExcelWorksheet worksheet, int startRow, int endRow) {
			var chart = worksheet.Drawings.AddChart("Histogram", eChartType.ColumnClustered);
			chart.Series.Add(worksheet.Cells[startRow, 2, endRow, 2], worksheet.Cells[startRow, 1, endRow, 1]);
			chart.SetPosition(0, 20, 2, 20);
			chart.SetSize(1200, 400);
		}
	}
}
