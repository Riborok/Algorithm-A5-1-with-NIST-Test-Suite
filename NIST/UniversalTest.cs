using BitUtils;
using System;
using MathNet.Numerics;

namespace NIST
{
    public class UniversalTest : NISTTest
    {
        private readonly int L;
        private readonly int Q;
        private readonly int K;

        private readonly double[] variance = { 
                0, 0, 0, 0, 0, 0, 2.954, 3.125, 3.238, 3.311, 
                3.356, 3.384, 3.401, 3.410, 3.416, 3.419, 3.421 
            };
        private readonly double[] expected = {
                0, 0, 0, 0, 0, 0, 5.2177052, 6.1962507, 7.1836656,
                8.1764248, 9.1723243, 10.170032, 11.168765,
                12.168070, 13.167693, 14.167488, 15.167379
            };

        public UniversalTest(BitArray bitArray) : base(bitArray)
        {
            this.L = 5;
            if (n >= 387840) this.L = 6;
            if (n >= 904960) this.L = 7;
            if (n >= 2068480) this.L = 8;
            if (n >= 4654080) this.L = 9;
            if (n >= 10342400) this.L = 10;
            if (n >= 22753280) this.L = 11;
            if (n >= 49643520) this.L = 12;
            if (n >= 107560960) this.L = 13;
            if (n >= 231669760) this.L = 14;
            if (n >= 496435200) this.L = 15;
            if (n >= 1059061760) this.L = 16;

            this.Q = 10 * (int)Math.Pow(2, this.L);
            this.K = (int)(Math.Floor((decimal)n / this.L) - Q);

            if (this.L < 6 || this.L > 16)
                throw new Exception("L is out of range");

            if ((double)Q < 10 * (int)Math.Pow(2, this.L))
                throw new Exception("Q is less than " + 10 * Math.Pow(2, L));
        }

        public override double CalcPValue()
        {
            double c = Calc_C();
            double sigma = Calc_Sigma(c);
            double sum = Calc_Sum();
            double phi = Calc_Phi(sum);
            double pValue = Calc_PValue(phi, sigma);

            return pValue;
        }

        private double Calc_C() => 0.7 - 0.8 / (double)this.L + (4 + 32 / (double)this.L) * Math.Pow(this.K, -3 / (double)this.L) / 15;
        
        private double Calc_Sigma(double c) => c * Math.Sqrt(this.variance[this.L] / (double)this.K);
        
        private double Calc_Phi(double sum) => (double)sum / (double)this.K;
        
        private double Calc_Sum()
        {
            double[] t = InitTable();
            double sum = ProcessBlocks(t);
            return sum;
        }

        private double[] InitTable()
        {
            int p = (int)Math.Pow(2, this.L);
            double[] t = new double[p];

            long dec;
            for (int i = 1; i <= this.Q; i++)
            {
                dec = 0;
                for (int j = 0; j < this.L; j++)
                    dec += _bitArray[(i - 1) * this.L + j] * (long)Math.Pow(2, this.L - 1 - j);
                t[dec] = i;
            }

            return t;
        }

        private double ProcessBlocks(double[] t)
        {
            double sum = 0;
            long dec;
            for (int i = this.Q + 1; i <= this.Q + this.K; i++)
            {
                dec = 0;
                for (int j = 0; j < this.L; j++)
                    dec += _bitArray[(i - 1) * this.L + j] * (long)Math.Pow(2, this.L - 1 - j);
                sum += Math.Log(i - t[dec] / Math.Log(2));
                t[dec] = i;
            }

            return sum;
        }

        private double Calc_PValue(double phi, double sigma)
        {
            double arg = Math.Abs(phi - this.expected[this.L]) / (Math.Sqrt(2) * sigma);
            return SpecialFunctions.Erfc(arg);
        }

        public override string ToString() => "Maurer’s “Universal Statistical” Test";
    }
}
