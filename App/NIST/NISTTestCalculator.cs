// ReSharper disable InconsistentNaming
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitUtils;
using NIST;

namespace App.NIST {
	public class NISTTestCalculator {
		private readonly Control _errorMsgControl;

		public NISTTestCalculator(Control errorMsgControl) => _errorMsgControl = errorMsgControl;

		public double?[] CalcTestResults(byte[] bytes, int length, int blockSz, int matrixM, int matrixQ) {
			var bitArr = new BitArray(bytes, length);
			var tasks = new[] {
				Task.Run(() => TryGetResult(new FrequencyTest(bitArr))),
				Task.Run(() => TryGetResult(new BlockFrequencyTest(bitArr, blockSz))),
				Task.Run(() => TryGetResult(new RunsTest(bitArr))),
				Task.Run(() => TryGetResult(new LongestRunOfOnesTest(bitArr))),
				Task.Run(() => TryGetResult(new RankTest(bitArr, matrixM, matrixQ))),
				Task.Run(() => TryGetResult(new DiscreteFourierTransformTest(bitArr)))
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
					_errorMsgControl.Text += exception.Message + Environment.NewLine;
				});
				return null;
			}
		}
	}
}