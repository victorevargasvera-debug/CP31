using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200000C RID: 12
	internal class ReedSolomon
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00005254 File Offset: 0x00003454
		public void CalculateCheckwords(int[] data, int startIndex, int checkwordsNumber, int[] p, global::Infragistics.Controls.Barcodes.GfArithmetics gf)
		{
			if (data.Length < startIndex + checkwordsNumber)
			{
				throw new global::System.ArgumentException(global::SR.GetString("EncodingError"));
			}
			for (int i = startIndex; i < startIndex + checkwordsNumber; i++)
			{
				data[i] = 0;
			}
			for (int i = 0; i < startIndex; i++)
			{
				int a = global::Infragistics.Controls.Barcodes.GfArithmetics.Sum(data[startIndex], data[i]);
				for (int j = 0; j < checkwordsNumber; j++)
				{
					data[startIndex + j] = global::Infragistics.Controls.Barcodes.GfArithmetics.Sum(data[startIndex + j + 1], gf.Product(a, p[j]));
				}
				data[startIndex + checkwordsNumber - 1] = gf.Product(a, p[checkwordsNumber - 1]);
			}
		}
	}
}
