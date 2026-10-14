using System;
using Compression;

namespace Motorola.Common.Communication.CompressionWrapper
{
	// Token: 0x02000003 RID: 3
	public static class FastLZWrapper
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public static void DataCompress(byte[] sourceData, byte[] outData, ref uint outLen)
		{
			short num = (short)1582871239;
			short num2 = num;
			num = (short)957919943;
			switch (num2 == num)
			{
			}
			num = (short)1169489921;
			if (num != 0)
			{
			}
			num = (short)538312704;
			short num3 = num;
			num = (short)727318528;
			if (num != 0)
			{
			}
			global::Compression.CompressionWrapper.DataCompressFastLZ(sourceData, outData, ref outLen);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021D0 File Offset: 0x000003D0
		public static void DataDecompress(byte[] sourceData, byte[] outData, ref uint outLen, int maxOut)
		{
			short num = (short)334696507;
			short num2 = num;
			num = (short)340660283;
			switch (num2 == num)
			{
			}
			num = (short)816381952;
			if (num != 0)
			{
			}
			num = (short)259981312;
			short num3 = num;
			num = (short)2028273665;
			if (num != 0)
			{
			}
			global::Compression.CompressionWrapper.DataDecompressFastLZ(sourceData, outData, ref outLen, maxOut);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002284 File Offset: 0x00000484
		public static void DataDecompress(byte[] sourceData, byte[] outData, ref uint outLen)
		{
			short num = (short)1345055320;
			short num2 = num;
			num = (short)1629022808;
			switch (num2 == num)
			{
			}
			num = (short)1524760577;
			if (num != 0)
			{
			}
			num = (short)296747008;
			short num3 = num;
			num = (short)235732992;
			if (num != 0)
			{
			}
			global::Compression.CompressionWrapper.DataDecompressFastLZ(sourceData, outData, ref outLen);
		}
	}
}
