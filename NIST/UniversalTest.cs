// ReSharper disable InconsistentNaming
using BitUtils;
using System;
using MathNet.Numerics;

namespace NIST {
    public class UniversalTest : NISTTest {
        private readonly double[] variance = { 
                0, 0, 0, 0, 0, 0, 2.954, 3.125, 3.238, 3.311, 
                3.356, 3.384, 3.401, 3.410, 3.416, 3.419, 3.421 
        };
        
        private readonly double[] expected = {
                0, 0, 0, 0, 0, 0, 5.2177052, 6.1962507, 7.1836656,
                8.1764248, 9.1723243, 10.170032, 11.168765,
                12.168070, 13.167693, 14.167488, 15.167379
        };

        private UniversalTestParameters utp;
        
        public UniversalTest(BitArray bitArray) : base(bitArray) {
        }

        public override double CalcPValue() {
            utp = new UniversalTestParameters(n);
            if (utp.L < 6)
                throw new ArgumentException($"The amount of bits must be at least {UniversalTestParameters.Min_n}, but n is only {n}.");
            if (utp.Q < 10 * Math.Pow(2, utp.L)) 
                throw new ArgumentException($"Q is less than {10 * Math.Pow(2, utp.L)}");
            
            double c = Calc_C();
            double sigma = Calc_Sigma(c);
            double sum = Calc_Sum();
            double phi = Calc_Phi(sum);
            double pValue = Calc_PValue(phi, sigma);

            return pValue;
        }

        private double Calc_C() {
            return 0.7 - 0.8 / utp.L + (4 + 32 / (double)utp.L) * Math.Pow(utp.K, -3 / (double)utp.L) / 15;
        }

        private double Calc_Sigma(double c) {
            return c * Math.Sqrt(variance[utp.L] / utp.K);
        }

        private double Calc_Phi(double sum) => sum / utp.K;
        
        private double Calc_Sum() {
            double[] t = InitTable();
            double sum = ProcessBlocks(t);
            return sum;
        }

        private double[] InitTable()
        {
            var p = (int)Math.Pow(2, utp.L);
            var t = new double[p];

            long dec;
            for (var i = 1; i <= utp.Q; i++)
            {
                dec = 0;
                for (var j = 0; j < utp.L; j++)
                    dec += _bitArray[(i - 1) * utp.L + j] * (long)Math.Pow(2, utp.L - 1 - j);
                t[dec] = i;
            }

            return t;
        }

        private double ProcessBlocks(double[] t)
        {
            double sum = 0;
            long dec;
            for (int i = utp.Q + 1; i <= utp.Q + utp.K; i++)
            {
                dec = 0;
                for (var j = 0; j < utp.L; j++)
                    dec += _bitArray[(i - 1) * utp.L + j] * (long)Math.Pow(2, utp.L - 1 - j);
                sum += Math.Log(i - t[dec] / Math.Log(2, 2), 2);
                t[dec] = i;
            }

            return sum;
        }

        private double Calc_PValue(double phi, double sigma)
        {
            double arg = Math.Abs(phi - expected[utp.L]) / (Math.Sqrt(2) * sigma);
            return SpecialFunctions.Erfc(arg);
        }

        public override string ToString() => "Maurer’s “Universal Statistical” Test";

        private readonly struct UniversalTestParameters {
            internal const int Min_n = 387840;
            
            internal readonly int L;
            internal readonly int Q;
            internal readonly int K;

            internal UniversalTestParameters(int n) {
                L = 5;
                if (n >= 1059061760) 
                    L = 16;
                else if (n >= 496435200) 
                    L = 15;
                else if (n >= 231669760) 
                    L = 14;
                else if (n >= 107560960) 
                    L = 13;
                else if (n >= 49643520) 
                    L = 12;
                else if (n >= 22753280)
                    L = 11;
                else if (n >= 10342400) 
                    L = 10;
                else if (n >= 4654080) 
                    L = 9;
                else if (n >= 2068480) 
                    L = 8;
                else if (n >= 904960) 
                    L = 7;
                else if (n >= Min_n) 
                    L = 6;
            
                Q = 10 * (int)Math.Pow(2, L);
                K = n / L - Q;
            }
        }
    }
}
