using System;
using Compression;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CompressionWrapper
{
	// Token: 0x02000004 RID: 4
	public static class LZMAWrapper
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002334 File Offset: 0x00000534
		public static void DataCompress(byte[] sourceData, byte[] outData, ref ulong outLen, int dictSize)
		{
			while (!global::Compression.CompressionWrapper.DataCompressLZMA(sourceData, outData, ref outLen, dictSize))
			{
				short num = (short)200779179;
				short num2 = num;
				num = (short)906601899;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1165950976;
					short num3 = num;
					num = (short)1570439168;
					if (num != 0)
					{
					}
					num = (short)562429953;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_Compression_LZMA_Compress_Failed);
				}
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000023F4 File Offset: 0x000005F4
		public static void DataDecompress(byte[] sourceData, out byte[] outData, ref ulong outLen)
		{
			while (!global::Compression.CompressionWrapper.DataDecompressLZMA(sourceData, out outData, ref outLen))
			{
				short num = (short)467599361;
				if (num != 0)
				{
				}
				num = (short)169241098;
				short num2 = num;
				num = (short)597256714;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)410320896;
					short num3 = num;
					break;
				}
				}
				num = (short)522911744;
				if (num != 0)
				{
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_Compression_LZMA_Decompress_Failed);
			}
		}
	}
}
