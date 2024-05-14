// ReSharper disable InconsistentNaming

using System;
using BitUtils;
using MathNet.Numerics;
using NIST.MathAdditions;

namespace NIST {
    public class LinearComplexityTest : NISTTest {
        private const int K = 6;
        private static readonly double[] Pis = new double[K + 1] { 0.01047, 0.03125, 0.125, 0.5, 0.25, 0.0625, 0.020833 };

        private readonly int M;
        
        public LinearComplexityTest(BitArray bitArray, int M) : base(bitArray) {
            this.M = M;
        }

        public override double CalcPValue() {
            var N = Calc_N();
            var mu = Calc_mu();
            var Ls = Calc_Ls(N);
            var Ts = Calc_Ts(Ls, mu);
            var Vs = Calc_Vs(Ts);
            var ChiSquared = Calc_ChiSquared(Vs, N);
            return Calc_PValue(ChiSquared);
        }
        
        private int Calc_N() => n / M;

        private double Calc_mu() {
            int minusOnePow = MathExtensions.Calc_MinusOnePow(M + 1);
            return M / 2.0 + (9.0 + minusOnePow) / 36.0 - (M / 3.0 + 2.0 / 9.0) / Math.Pow(2, M);
        }

        private int[] Calc_Ls(int N) {
            var BerlekampMassey = new BerlekampMassey(_bitArray, M, N);
            return BerlekampMassey.Calc_Ls();
        }

        private double[] Calc_Ts(int[] Ls, double mu) {
            var Ts = new double[Ls.Length];
            
            int minusOnePow = MathExtensions.Calc_MinusOnePow(M);
            for (var i = 0; i < Ls.Length; i++)
                Ts[i] = minusOnePow * (Ls[i] - mu) + 2.0/9.0;

            return Ts;
        }
        
        private static int[] Calc_Vs(double[] Ts) {
            var Vs = new int[K + 1];

            foreach (double Ti in Ts) {
                if (Ti <= -2.5)
                    Vs[0]++;
                else if (Ti > -2.5 && Ti <= -1.5)
                    Vs[1]++;
                else if (Ti > -1.5 && Ti <= -0.5)
                    Vs[2]++;
                else if (Ti > -0.5 && Ti <= 0.5)
                    Vs[3]++;
                else if (Ti > 0.5 && Ti <= 1.5)
                    Vs[4]++;
                else if (Ti > 1.5 && Ti <= 2.5)
                    Vs[5]++;
                else
                    Vs[6]++;
            }
            
            return Vs;
        }
        
        private static double Calc_ChiSquared(int[] Vs, int N) {
            double ChiSquared = 0;
            for (var i = 0; i < K + 1; i++) {
                ChiSquared += (Vs[i] - N * Pis[i]).Sqr() / (N * Pis[i]);
            }
            return ChiSquared;
        }
        
        private static double Calc_PValue(double ChiSquared) {
            return SpecialFunctionsExtensions.Igamc(K / 2.0, ChiSquared / 2.0);
        }

        public override string ToString() => "Linear Complexity Test";
    }

    internal class BerlekampMassey {
        private readonly BitArray _bitArray;
        private readonly int M;
        private readonly int N;
        
        private int[] B = null!, C = null!;
        private int L, m;

        internal BerlekampMassey(BitArray bitArray, int M, int N) {
            _bitArray = bitArray;
            this.M = M;
            this.N = N;
        }
        
        internal int[] Calc_Ls() {
            var Ls = new int[N];
            
            for (var i = 0; i < N; i++) {
                ResetStates();
                
                for (var j = 0; j < M; j++) {
                    int d = Calc_d(i, j);
                    
                    if (d.IsOdd()) {
                        int[] P = Create_P(j);
                        int[] T = Create_T();
                        Update_C(P);
                        Update_L(T, j);
                    }
                }
                Ls[i] = L;
            }
            
            return Ls;
        }
        
        private void ResetStates() {
            B = CreatePolynomialCoefficients();
            C = CreatePolynomialCoefficients();
            L = 0;
            m = -1;
        }
        
        private int[] CreatePolynomialCoefficients() {
            var result = new int[M];
            result[0] = 1;
            return result;
        }
        
        private int Calc_d(int i, int j) {
            int d = _bitArray[i * M + j];
            for (var k = 1; k <= L; k++)
                d += C[k] * _bitArray[i * M + j - k];
            return d;
        }
        
        private int[] Create_P(int j) {
            var P = new int[M];
            for (var k = 0; k < M; k++)
                if (B[k] == 1)
                    P[k + j - m] = 1;
            return P;
        }
        
        private int[] Create_T() {
            var T = new int[M];
            Array.Copy(C, T, M);
            return T;
        }
        
        private void Update_C(int[] P) {
            for (var k = 0; k < C.Length; k++)
                C[k] = (C[k] + P[k]) % 2;
        }
        
        private void Update_L(int[] T, int j) {
            if (L <= j / 2) {
                L = j + 1 - L;
                m = j;
                Array.Copy(T, B, B.Length);
            }
        }
    }
}
