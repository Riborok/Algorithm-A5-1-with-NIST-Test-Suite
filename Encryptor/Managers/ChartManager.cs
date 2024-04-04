using System.Windows.Forms.DataVisualization.Charting;

namespace Encryptor.Managers {
	internal class ChartManager {
		private readonly Chart _chart;
		private readonly string _title;
		
		public ChartManager(Chart chart, string title) {
			_chart = chart;
			_title = title;
		}

		public void PlotHistogram(byte[] bytes) {
			ClearChart();
			Series series = CreateSeries();
			AddDataPoints(series, bytes);
			AddSeriesToChart(series);
		}

		public void ClearChart() {
			_chart.Series.Clear();
			_chart.Titles.Clear();
		}

		private static Series CreateSeries() {
			Series series = new Series { ChartType = SeriesChartType.Column };
			series.IsVisibleInLegend = false;
			return series;
		}

		private static void AddDataPoints(Series series, byte[] bytes) {
			var freq = FrequencyAnalyzer.Analyze(bytes);
			foreach (var kvp in freq)
				series.Points.AddXY(kvp.Key.ToString(), kvp.Value);
		}

		private void AddSeriesToChart(Series series) {
			_chart.Series.Add(series);
			_chart.Titles.Add($"{_title} - Unique Symbols: {series.Points.Count}");
		}
	}
}
