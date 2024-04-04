using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgorithmA5_1;
using BitUtils;
using BitUtils.Extensions;
using TestingAlgorithmA5_1ByNIST.NIST;

namespace TestingAlgorithmA5_1ByNIST {
	public partial class MainForm : Form {
		private readonly A5_1 _defA51 = new A5_1();
		private readonly A5_1 _improvedA51 = new A5_1();
		
		private readonly NISTControls _defNistControls;
		private readonly NISTControls _improvedNistControls;
	
		private readonly NISTTestCalculator _testCalculator;
		private readonly NISTTestResultsDisplayer _resultsDisplayer = new NISTTestResultsDisplayer(
			"Error", 6, 
			Color.LightSalmon, Color.LightCoral, Color.LightGreen);
		
		public MainForm() {
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			
			_testCalculator = new NISTTestCalculator(tbErrors);
			_defNistControls = CreateDefNistControls(Color.White);
			_improvedNistControls = CreateImprovedNistControls(Color.White);
		}
		
		private NISTControls CreateDefNistControls(Color color) {
			return new NISTControls(
				new Control[] { 
					tbDefFreqTest, tbDefBlockFreqTest, tbDefRunsTest, 
					tbDefLROTest, tbDefRankTest, tbDefDFTTest
				}, 
				new Control[] {
					tbDefR1, tbDefR2, tbDefR3
				}, 
				tbDefGeneratedKey, color
			);
		}
		
		private NISTControls CreateImprovedNistControls(Color color) {
			return new NISTControls(
				new Control[] { 
					tbImprovedFreqTest, tbImprovedBlockFreqTest, tbImprovedRunsTest, 
					tbImprovedLROTest, tbImprovedRankTest, tbImprovedDFTTest
				}, 
				new Control[] {
					tbImprovedR1, tbImprovedR2, tbImprovedR3
				},
				tbImprovedGeneratedKey, color
			);
		}

		private void butRunTests_Click(object sender, EventArgs e) {
			ProcessRunTests();
		}
		
		private void ProcessRunTests() {
			tbErrors.Text = string.Empty;
			if (TryGetTestParams(out int blockSz, out int matrixM, out int matrixQ, out int length) && TryGetKey(out ulong key)) {
				Task task1 = Task.Run(() => {
					_defA51.InitV1(key);
					ProcessAndDisplayTests(_defA51, _defNistControls, blockSz, matrixM, matrixQ, length);
				});
				Task task2 = Task.Run(() => {
					_improvedA51.InitV2(key);
					ProcessAndDisplayTests(_improvedA51, _improvedNistControls, blockSz, matrixM, matrixQ, length);
				});
				Task.WhenAll(task1, task2).Wait();
			}
		}

		private bool TryGetKey(out ulong key) {
			bool isValid = ulong.TryParse(tbKey.Text, out key);
			if (!isValid)
				tbErrors.Text += @"Invalid key format. Enter a valid 64-bit unsigned integer value." + Environment.NewLine;
			return isValid;
		}
		
		private bool TryGetTestParams(out int blockSz, out int matrixM, out int matrixQ, out int length) {
			bool isValid = true;
			isValid &= ValidateInput(tbBlockSz.Text, "Block Size", out blockSz);
			isValid &= ValidateInput(tbMatrixM.Text, "Matrix M", out matrixM);
			isValid &= ValidateInput(tbMatrixQ.Text, "Matrix Q", out matrixQ);
			isValid &= ValidateInput(tbKeyLength.Text, "Key Length", out length);
			return isValid;
		}
        
		private bool ValidateInput(string input, string fieldName, out int value) {
			if (!int.TryParse(input, out value)) {
				tbErrors.Text += $@"Invalid {fieldName} format. Enter a valid integer value.{Environment.NewLine}";
				return false;
			}
			return true;
		}

		private void ProcessAndDisplayTests(A5_1 a51, NISTControls nistControls, 
				int blockSz, int matrixM, int matrixQ, int length) {
			NISTTestResultsDisplayer.DisplayA51Registers(a51, nistControls);
			byte[] a51Key = a51.GenerateBytes(MathUtils.CeilInt(length, Bits.InByte));
			NISTTestResultsDisplayer.DisplayGeneratedKey(a51Key, nistControls);
			RunTests(a51Key, nistControls, blockSz, matrixM, matrixQ, length);
		}

		private void RunTests(byte[] buffer, NISTControls nistControls, 
				int blockSz, int matrixM, int matrixQ, int length) {
			var testResults = _testCalculator.CalcTestResults(buffer, 
				length, blockSz, matrixM, matrixQ);
			_resultsDisplayer.DisplayResults(nistControls.TestControls, testResults);
		}
	}
}
