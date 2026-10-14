using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000005 RID: 5
	internal class Bch
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002DA8 File Offset: 0x00000FA8
		public static int GetBchCode(int data, int polynom)
		{
			int mostSignificantBitSet = global::Infragistics.Controls.Barcodes.Bch.GetMostSignificantBitSet(polynom);
			data <<= mostSignificantBitSet - 1;
			while (global::Infragistics.Controls.Barcodes.Bch.GetMostSignificantBitSet(data) >= mostSignificantBitSet)
			{
				data ^= polynom << global::Infragistics.Controls.Barcodes.Bch.GetMostSignificantBitSet(data) - mostSignificantBitSet;
			}
			return data;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002DE4 File Offset: 0x00000FE4
		private static int GetMostSignificantBitSet(int data)
		{
			uint num = (uint)data;
			int num2 = 0;
			while (num != 0U)
			{
				num >>= 1;
				num2++;
			}
			return num2;
		}
	}
}
