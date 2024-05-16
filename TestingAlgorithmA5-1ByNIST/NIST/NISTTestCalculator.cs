// ReSharper disable InconsistentNaming
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitUtils;
using NIST;

namespace TestingAlgorithmA5_1ByNIST.NIST {
	public class NISTTestCalculator {
		private readonly Control _errorMsgControl;

		public NISTTestCalculator(Control errorMsgControl) => _errorMsgControl = errorMsgControl;

		public double?[] CalcTestResults(byte[] bytes, NISTParams nistParams) {
			var bitArr = new BitArray(bytes, nistParams.length);
			var tasks = new[] {
				Task.Run(() => TryGetResult(new FrequencyTest(bitArr))),
				Task.Run(() => TryGetResult(new BlockFrequencyTest(bitArr, nistParams.blockFreqSz))),
				Task.Run(() => TryGetResult(new RunsTest(bitArr))),
				Task.Run(() => TryGetResult(new LongestRunOfOnesTest(bitArr))),
				Task.Run(() => TryGetResult(new RankTest(bitArr, nistParams.matrixM, nistParams.matrixQ))),
				Task.Run(() => TryGetResult(new DiscreteFourierTransformTest(bitArr))),
				Task.Run(() => TryGetResult(new LinearComplexityTest(bitArr, nistParams.blockComplSz))),
				Task.Run(() => TryGetResult(new UniversalTest(bitArr)))
			};
			Task.WhenAll(tasks).Wait();
			return tasks.Select(t => t.Result).ToArray();
		}

		private double? TryGetResult(NISTTest nistTest) {
			try {
				return nistTest.CalcPValue();
			}
			catch (ArgumentException exception) {
				_errorMsgControl.BeginInvoke((MethodInvoker)delegate {
					_errorMsgControl.Text += $@"{nistTest}: {exception.Message}{Environment.NewLine}{Environment.NewLine}";
				});
				return null;
			}
			catch (OutOfMemoryException) {
				_errorMsgControl.BeginInvoke((MethodInvoker)delegate {
					_errorMsgControl.Text += $@"{nistTest}: Out of memory error occurred.{Environment.NewLine}{Environment.NewLine}";
				});
				return null;
			}
		}
	}
}
