using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x0200027F RID: 639
	public abstract class LZWDecompresser
	{
		// Token: 0x0600112A RID: 4394 RVA: 0x00033FBF File Offset: 0x000321BF
		protected LZWDecompresser(bool maskMeansCompressed, int codeLengthIncrease, bool positionIsBigEndian)
		{
			this.maskMeansCompressed = maskMeansCompressed;
			this.codeLengthIncrease = codeLengthIncrease;
			this.positionIsBigEndian = positionIsBigEndian;
		}

		// Token: 0x0600112B RID: 4395
		protected abstract int populateDictionary(byte[] dict);

		// Token: 0x0600112C RID: 4396
		protected abstract int adjustDictionaryOffset(int offset);

		// Token: 0x0600112D RID: 4397 RVA: 0x00033FDC File Offset: 0x000321DC
		public byte[] decompress(global::System.IO.Stream src)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				this.decompress(src, memoryStream);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0003401C File Offset: 0x0003221C
		public void decompress(global::System.IO.Stream src, global::System.IO.Stream res)
		{
			byte[] array = new byte[4096];
			int num = this.populateDictionary(array);
			byte[] array2 = new byte[16 + this.codeLengthIncrease];
			int num2;
			while ((num2 = src.ReadByte()) != -1)
			{
				for (int i = 1; i < 256; i <<= 1)
				{
					if ((num2 & i) > 0 ^ this.maskMeansCompressed)
					{
						int b;
						if ((b = src.ReadByte()) != -1)
						{
							array[num & 4095] = global::NPOI.Util.LZWDecompresser.fromInt(b);
							num++;
							res.WriteByte(global::NPOI.Util.LZWDecompresser.fromInt(b));
						}
					}
					else
					{
						int num3 = src.ReadByte();
						int num4 = src.ReadByte();
						if (num3 == -1 || num4 == -1)
						{
							break;
						}
						int num5 = (num4 & 15) + this.codeLengthIncrease;
						int num6;
						if (this.positionIsBigEndian)
						{
							num6 = (num3 << 4) + (num4 >> 4);
						}
						else
						{
							num6 = num3 + ((num4 & 240) << 4);
						}
						num6 = this.adjustDictionaryOffset(num6);
						for (int j = 0; j < num5; j++)
						{
							array2[j] = array[num6 + j & 4095];
							array[num + j & 4095] = array2[j];
						}
						res.Write(array2, 0, num5);
						num += num5;
					}
				}
			}
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00034159 File Offset: 0x00032359
		public static byte fromInt(int b)
		{
			if (b < 128)
			{
				return (byte)b;
			}
			return (byte)(b - 256);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0003416E File Offset: 0x0003236E
		public static int fromByte(byte b)
		{
			if (b >= 0)
			{
				return (int)b;
			}
			return (int)b + 256;
		}

		// Token: 0x0400074E RID: 1870
		private bool maskMeansCompressed;

		// Token: 0x0400074F RID: 1871
		private int codeLengthIncrease;

		// Token: 0x04000750 RID: 1872
		private bool positionIsBigEndian;
	}
}
