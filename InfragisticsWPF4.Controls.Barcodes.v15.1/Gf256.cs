using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200000A RID: 10
	public class Gf256 : global::Infragistics.Controls.Barcodes.GfArithmetics
	{
		// Token: 0x06000037 RID: 55 RVA: 0x0000514C File Offset: 0x0000334C
		public Gf256(int primePolynom) : base(256)
		{
			base.CreateLogArrays(primePolynom);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005160 File Offset: 0x00003360
		internal int CalculatePolynomialAt(int[] polynomialCoefficients, int point)
		{
			if (polynomialCoefficients.Length == 0)
			{
				return 0;
			}
			if (point == 0)
			{
				return polynomialCoefficients[0];
			}
			int num = polynomialCoefficients.Length - 1;
			int num2 = 0;
			if (point == 1)
			{
				for (int i = 0; i <= num; i++)
				{
					num2 = global::Infragistics.Controls.Barcodes.GfArithmetics.Sum(num2, polynomialCoefficients[i]);
				}
				return num2;
			}
			num2 = polynomialCoefficients[0];
			for (int j = 1; j <= num; j++)
			{
				num2 = global::Infragistics.Controls.Barcodes.GfArithmetics.Sum(base.Product(point, num2), polynomialCoefficients[j]);
			}
			return num2;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000051C4 File Offset: 0x000033C4
		internal int[] MultiplyByMonomial(int[] coefficients, int degree, int monomialCoef)
		{
			if (degree < 0)
			{
				return null;
			}
			if (monomialCoef == 0)
			{
				return new int[1];
			}
			int num = coefficients.Length;
			int[] array = new int[num + degree];
			for (int i = 0; i < num; i++)
			{
				array[i] = base.Product(coefficients[i], monomialCoef);
			}
			return array;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000520C File Offset: 0x0000340C
		internal static int[] GetMonomialCoefficients(int degree, int coefficient)
		{
			if (degree < 0)
			{
				return null;
			}
			if (coefficient == 0)
			{
				return new int[1];
			}
			int[] array = new int[degree + 1];
			array[0] = coefficient;
			return array;
		}

		// Token: 0x0400002E RID: 46
		public const int GfNumber = 256;

		// Token: 0x0400002F RID: 47
		public const int N = 255;
	}
}
