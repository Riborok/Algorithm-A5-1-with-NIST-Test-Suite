using System;
using System.Drawing;
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
					tbDefLROTest, tbDefRankTest, tbDefDFTTest, 
					tbDefLinearComplexityTest, tbDefUniversalTest
				}, 
				new Control[] {
					tbDefR1, tbDefR2, tbDefR3
				}, 
				tbDefGeneratedKey, color, "Default Initialization"
			);
		}
		
		private NISTControls CreateImprovedNistControls(Color color) {
			return new NISTControls(
				new Control[] { 
					tbImprovedFreqTest, tbImprovedBlockFreqTest, tbImprovedRunsTest, 
					tbImprovedLROTest, tbImprovedRankTest, tbImprovedDFTTest, 
					tbImprovedLinearComplexityTest, tbImprovedUniversalTest
				}, 
				new Control[] {
					tbImprovedR1, tbImprovedR2, tbImprovedR3
				},
				tbImprovedGeneratedKey, color, "Improved Initialization"
			);
		}

		private void butRunTests_Click(object sender, EventArgs e) {
			ProcessRunTests();
		}
		
		private void ProcessRunTests() {
			tbErrors.Text = string.Empty;
			if (TryGetTestParams(out var nistParams) && TryGetKey(out ulong key) && TryGetFrame(out ulong frame)) {
				NISTTestResultsDisplayer.CreateOutputFolderIfNotExists();
				
				var task1 = Task.Run(() => {
					_defA51.InitV1WithFrame(key, frame);
					ProcessAndDisplayTests(_defA51, _defNistControls, nistParams);
				});
				var task2 = Task.Run(() => {
					_improvedA51.InitV2WithFrame(key, frame);
					ProcessAndDisplayTests(_improvedA51, _improvedNistControls, nistParams);
				});
				Task.WhenAll(task1, task2).Wait();
			}
		}

		private bool TryGetKey(out ulong key) {
			bool isValid = ulong.TryParse(tbKey.Text, out key);
			if (!isValid)
				tbErrors.Text += $@"Invalid key format. Enter a valid {Bits.InQword}-bit unsigned integer value.{Environment.NewLine}{Environment.NewLine}";
			return isValid;
		}
		
		private bool TryGetFrame(out ulong frame) {
			bool isValid = ulong.TryParse(tbFrame.Text, out frame);
			if (!isValid || frame >= (1 << A5_1.FrameBitCount))
				tbErrors.Text += $@"Invalid frame format. Enter a valid {A5_1.FrameBitCount}-bit unsigned integer value.{Environment.NewLine}{Environment.NewLine}";
			return isValid;
		}
		
		private bool TryGetTestParams(out NISTParams nistParams) {
			bool isValid = true;
			isValid &= ValidateInput(tbFreqBlockSz.Text, lbFreqBlockSz.Text, out nistParams.blockFreqSz);
			isValid &= ValidateInput(tbComplBlockSz.Text, lbComplBlockSz.Text, out nistParams.blockComplSz);
			isValid &= ValidateInput(tbMatrixM.Text, lbMatrixM.Text, out nistParams.matrixM);
			isValid &= ValidateInput(tbMatrixQ.Text, lbMatrixQ.Text, out nistParams.matrixQ);
			isValid &= ValidateInput(tbKeyLength.Text, lbKeyLength.Text, out nistParams.length);
			return isValid;
		}
        
		private bool ValidateInput(string input, string fieldName, out int value) {
			if (!int.TryParse(input, out value) || value <= 0) {
				tbErrors.Text += $@"Invalid {fieldName} format. Enter a valid integer value greater than zero.{Environment.NewLine}{Environment.NewLine}";
				return false;
			}
			return true;
		}

		private void ProcessAndDisplayTests(A5_1 a51, NISTControls nistControls, 
				in NISTParams nistParams) {
			NISTTestResultsDisplayer.DisplayA51Registers(a51, nistControls);
			byte[] a51Key = a51.GenerateBytes(MathUtils.CeilInt(nistParams.length, Bits.InByte));
			NISTTestResultsDisplayer.DisplayAndSaveGeneratedKey(a51Key, nistParams.length, nistControls);
			RunTests(a51Key, nistControls, nistParams);
		}

		private void RunTests(byte[] buffer, NISTControls nistControls, 
				in NISTParams nistParams) {
			var testResults = _testCalculator.CalcTestResults(buffer, nistParams);
			_resultsDisplayer.DisplayResults(nistControls.TestControls, testResults);
		}

		private void DisplayFrame(ulong frame) {
			tbFrame.Text = frame.ToString();
		}
	}
}
