using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000009 RID: 9
	public class GfArithmetics
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00004D5C File Offset: 0x00002F5C
		public GfArithmetics(int gf)
		{
			this.GfInstance = gf;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00004D6B File Offset: 0x00002F6B
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00004D73 File Offset: 0x00002F73
		public int GfInstance { get; set; }

		// Token: 0x06000029 RID: 41 RVA: 0x00004D7C File Offset: 0x00002F7C
		public void CreateLogArrays(int primePolynom)
		{
			this.log = new int[this.GfInstance];
			this.aLog = new int[this.GfInstance];
			this.log[0] = 1 - this.GfInstance;
			this.aLog[0] = 1;
			for (int i = 1; i < this.GfInstance; i++)
			{
				this.aLog[i] = this.aLog[i - 1] * 2;
				if (this.aLog[i] >= this.GfInstance)
				{
					this.aLog[i] ^= primePolynom;
				}
				this.log[this.aLog[i]] = i;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004E22 File Offset: 0x00003022
		public static int Sum(int a, int b)
		{
			return a ^ b;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004E28 File Offset: 0x00003028
		public static int[] Sum(int[] aCoefficients, int[] bCoefficients)
		{
			int[] array = aCoefficients;
			int[] array2 = bCoefficients;
			if (array.Length > array2.Length)
			{
				int[] array3 = array;
				array = array2;
				array2 = array3;
			}
			int[] array4 = new int[array2.Length];
			int num = array2.Length - array.Length;
			global::System.Array.Copy(array2, 0, array4, 0, num);
			for (int i = num; i < array2.Length; i++)
			{
				array4[i] = global::Infragistics.Controls.Barcodes.GfArithmetics.Sum(array[i - num], array2[i]);
			}
			return global::Infragistics.Controls.Barcodes.GfArithmetics.RemoveLeadingZeros(array4);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004E91 File Offset: 0x00003091
		public static byte Sum(byte a, byte b)
		{
			return a ^ b;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004E98 File Offset: 0x00003098
		public static byte[] CalculateSumOfBits(byte[] xa, byte[] xb)
		{
			byte[] array;
			byte[] array2;
			if (xa.Length > xb.Length)
			{
				array = new byte[xa.Length];
				global::System.Array.Copy(xa, 0, array, 0, xa.Length);
				array2 = new byte[xb.Length];
				global::System.Array.Copy(xb, 0, array2, 0, xb.Length);
			}
			else
			{
				array = new byte[xb.Length];
				global::System.Array.Copy(xb, 0, array, 0, xb.Length);
				array2 = new byte[xa.Length];
				global::System.Array.Copy(xa, 0, array2, 0, xa.Length);
			}
			int num = array.Length;
			int num2 = array2.Length;
			byte[] array3 = new byte[num];
			for (int i = 0; i < num; i++)
			{
				if (i < num2)
				{
					array3[i] = global::Infragistics.Controls.Barcodes.GfArithmetics.Sum(array[i], array2[i]);
				}
				else
				{
					array3[i] = array[i];
				}
			}
			return array3;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004F47 File Offset: 0x00003147
		public static int Difference(int a, int b)
		{
			return global::Infragistics.Controls.Barcodes.GfArithmetics.Sum(a, b);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004F50 File Offset: 0x00003150
		public int Product(int a, int b)
		{
			if (a == 0 || b == 0)
			{
				return 0;
			}
			return this.aLog[(this.log[a] + this.log[b]) % (this.GfInstance - 1)];
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004F7C File Offset: 0x0000317C
		public int[] Product(int[] aCoefficients, int[] bCoefficients)
		{
			if (aCoefficients.Length < 1 || bCoefficients.Length < 1)
			{
				return null;
			}
			if ((aCoefficients.Length == 1 && aCoefficients[0] == 0) || (bCoefficients.Length == 1 && bCoefficients[0] == 0))
			{
				return new int[1];
			}
			int num = aCoefficients.Length;
			int num2 = bCoefficients.Length;
			int[] array = new int[num + num2 - 1];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					array[i + j] = global::Infragistics.Controls.Barcodes.GfArithmetics.Sum(array[i + j], this.Product(aCoefficients[i], bCoefficients[j]));
				}
			}
			return array;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005008 File Offset: 0x00003208
		public int[] Product(int[] coefficients, int scalar)
		{
			if (scalar == 0)
			{
				return new int[1];
			}
			if (scalar == 1)
			{
				return coefficients;
			}
			int num = coefficients.Length;
			int[] array = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = this.Product(coefficients[i], scalar);
			}
			return array;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000504C File Offset: 0x0000324C
		public int Quotient(int a, int b)
		{
			if (b == 0)
			{
				return 1 - this.GfInstance;
			}
			if (a == 0)
			{
				return 0;
			}
			return this.aLog[(this.log[a] - this.log[b] + (this.GfInstance - 1)) % (this.GfInstance - 1)];
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005089 File Offset: 0x00003289
		internal int Inverse(int a)
		{
			if (a == 0)
			{
				throw new global::System.ArithmeticException();
			}
			return this.aLog[255 - this.log[a]];
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000050A9 File Offset: 0x000032A9
		internal int GetALog(int index)
		{
			if (this.aLog.Length < index || index < 0)
			{
				throw new global::System.ArgumentException("Invalid index!");
			}
			return this.aLog[index];
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000050CD File Offset: 0x000032CD
		internal int GetLog(int index)
		{
			if (this.log.Length < index || index < 0)
			{
				throw new global::System.ArgumentException("Invalid index!");
			}
			return this.log[index];
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000050F4 File Offset: 0x000032F4
		private static int[] RemoveLeadingZeros(int[] coefficients)
		{
			int[] array = coefficients;
			int num = coefficients.Length - 1;
			if (num > 0 && coefficients[0] == 0)
			{
				int num2 = 1;
				while (num2 <= num && coefficients[num2] == 0)
				{
					num2++;
				}
				if (num2 == num + 1)
				{
					int[] array2 = new int[1];
					array = array2;
				}
				else
				{
					array = new int[num + 1 - num2];
					global::System.Array.Copy(coefficients, num2, array, 0, array.Length);
				}
			}
			return array;
		}

		// Token: 0x0400002B RID: 43
		private int[] log;

		// Token: 0x0400002C RID: 44
		private int[] aLog;
	}
}
