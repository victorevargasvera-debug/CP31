using System;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashkeyLib
{
	// Token: 0x02000102 RID: 258
	internal sealed class Crc8Generator
	{
		// Token: 0x06000E58 RID: 3672 RVA: 0x00003256 File Offset: 0x00001456
		internal Crc8Generator()
		{
			this.a = new byte[]
			{
				0,
				153,
				172,
				53,
				199,
				94,
				107,
				242
			};
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00143280 File Offset: 0x00141480
		internal byte Compute(byte[] buffer, int index, int count, byte crc8)
		{
			int a_ = 19;
			short num = (short)1199833088;
			switch (num)
			{
			default:
			{
				num = (short)1542520841;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte b;
					int num3;
					byte b2;
					switch (num2)
					{
					case 0:
						if (index < 0)
						{
							num = (short)1771962372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1442119696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_B8;
					case 2:
						b = (byte)(b >> 1 | 128);
						b ^= byte.MaxValue;
						num = (short)1678311438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return b;
					case 4:
						goto IL_27D;
					case 5:
						goto IL_3F7;
					case 6:
						if ((b & 128) > 0)
						{
							num = (short)20840450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b = (byte)(b >> 1);
						num = (short)1319108620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_2CB;
					case 8:
					{
						int num4;
						if (num3 >= num4)
						{
							num = (short)1256718339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b2 = buffer[num3];
						b2 ^= crc8;
						crc8 = b2;
						num = (short)518127631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						switch (0)
						{
						case 0:
							goto IL_9D;
						}
						continue;
					case 10:
						num = (short)1043791873;
						if (num != 0)
						{
						}
						goto IL_BD;
					case 11:
					{
						if (count > buffer.Length - index)
						{
							num = (short)110821381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b2 = 0;
						b = 0;
						int num4 = index + count;
						num3 = index;
						num = (short)78577682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_334;
					case 13:
						b2 = (byte)(b2 >> 1 | 128);
						num = (short)1418264593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_334;
					case 15:
						if ((b2 & 128) > 0)
						{
							num = (short)1072955405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b2 = (byte)(b2 >> 1);
						num = (short)967639050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (count < 0)
						{
							num = (short)1367539731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)442368011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_BD;
					case 18:
						goto IL_2CB;
					case 19:
						goto IL_1CE;
					}
					IL_9D:
					if (buffer == null)
					{
						num = (short)1003618305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1492216984;
					short num5 = num;
					num = (short)1615752344;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_334;
					default:
						num = (short)2055274496;
						if (num != 0)
						{
						}
						num = (short)1306001408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_BD:
					num = (short)768737280;
					short num6 = num;
					b2 = (byte)(b2 >> 1);
					b2 ^= crc8;
					b = b2;
					b2 = (byte)(b2 << 1);
					b2 &= 240;
					num = (short)539885574;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CB:
					num = (short)1547436040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_334:
					b &= 15;
					b2 += b;
					b = crc8;
					b &= 7;
					b ^= b2;
					b2 ^= b;
					b ^= b2;
					b2 = this.a[(int)b2];
					b ^= b2;
					crc8 = b;
					num3++;
					num = (short)2105540615;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B8:
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲙ瀞ﮝ튟", a_));
				IL_1CE:
				throw new global::System.ArgumentOutOfRangeException();
				IL_27D:
				throw new global::System.ArgumentOutOfRangeException();
				IL_3F7:
				throw new global::System.ArgumentOutOfRangeException();
			}
			}
		}

		// Token: 0x0400078D RID: 1933
		private readonly byte[] a;
	}
}
