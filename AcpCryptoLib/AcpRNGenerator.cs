using System;
using System.Security.Cryptography;

namespace AcpCryptoLib
{
	// Token: 0x02000013 RID: 19
	internal class AcpRNGenerator
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00006874 File Offset: 0x00004A74
		internal AcpRNGenerator()
		{
			long ticks = global::System.DateTime.Now.Ticks;
			this.a = (int)(ticks % 65536L);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00006954 File Offset: 0x00004B54
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000068A4 File Offset: 0x00004AA4
		internal int SNetRandomValue
		{
			get
			{
				short num = (short)632416785;
				short num2 = num;
				num = (short)842656273;
				switch (num2 == num)
				{
				}
				num = (short)873725952;
				short num3 = num;
				num = (short)527761409;
				if (num != 0)
				{
				}
				num = (short)577044480;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1815257376;
				short num2 = num;
				num = (short)198877472;
				switch (num2 == num)
				{
				}
				num = (short)1940783104;
				short num3 = num;
				num = (short)1074266113;
				if (num != 0)
				{
				}
				num = (short)1295384576;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00006A04 File Offset: 0x00004C04
		internal int NextSNetRandomValue
		{
			get
			{
				short num = (short)831056241;
				short num2 = num;
				num = (short)1799350641;
				switch (num2 == num)
				{
				}
				num = (short)1775435776;
				short num3 = num;
				num = (short)865665025;
				if (num != 0)
				{
				}
				num = (short)1792671744;
				if (num != 0)
				{
				}
				this.a = (this.a * 25173 + 13849) % 256;
				return this.a;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00006AD4 File Offset: 0x00004CD4
		internal static byte[] GenerateRandomBytes(int minLength, int maxLength)
		{
			short num = (short)117303103;
			short num2 = num;
			num = (short)588703551;
			switch (num2 == num)
			{
			}
			num = (short)825425920;
			short num3 = num;
			num = (short)1090584576;
			if (num != 0)
			{
			}
			num = (short)175112193;
			if (num != 0)
			{
			}
			byte[] array = new byte[global::AcpCryptoLib.AcpRNGenerator.GenerateRandomNumber(minLength, maxLength)];
			global::System.Security.Cryptography.RandomNumberGenerator.Create().GetNonZeroBytes(array);
			return array;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006B98 File Offset: 0x00004D98
		internal static int GenerateRandomNumber(int minValue, int maxValue)
		{
			short num = (short)1467757356;
			short num2 = num;
			num = (short)1000551212;
			switch (num2 == num)
			{
			}
			num = (short)1596129280;
			short num3 = num;
			num = (short)87556097;
			if (num != 0)
			{
			}
			num = (short)835977216;
			if (num != 0)
			{
			}
			byte[] array = new byte[4];
			global::System.Security.Cryptography.RandomNumberGenerator.Create().GetBytes(array);
			return new global::System.Random((int)(array[0] & 127) << 24 | (int)array[1] << 16 | (int)array[2] << 8 | (int)array[3]).Next(minValue, maxValue + 1);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006C7C File Offset: 0x00004E7C
		internal static byte[] GenerateSalt(int minLen, int maxLen)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (minLen == maxLen)
					{
						num2 = (short)1055326215;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3 = global::AcpCryptoLib.AcpRNGenerator.GenerateRandomNumber(minLen, maxLen);
					num2 = (short)1843200005;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1974362425;
					short num4 = num2;
					num2 = (short)529228089;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_263;
					default:
						num2 = (short)139526144;
						if (num2 != 0)
						{
						}
						num2 = (short)1722351620;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_149;
				case 3:
					goto IL_EF;
				case 4:
					if (maxLen < 4)
					{
						num2 = (short)1423376390;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)715653129;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_22F;
				case 6:
					goto IL_1D0;
				case 7:
					num3 = minLen;
					num2 = (short)1457979394;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (minLen >= 4)
					{
						num2 = (short)1295908865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11C;
				case 9:
					if (minLen > maxLen)
					{
						goto IL_263;
					}
					num2 = (short)899088394;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (maxLen > 128)
					{
						num2 = (short)2062221315;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2059534336;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_27A;
				}
				goto IL_49;
				IL_263:
				num2 = (short)1163264011;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_EF:
			num2 = (short)2142699520;
			short num5 = num2;
			num2 = (short)85196801;
			if (num2 != 0)
			{
			}
			throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("䬁樃瀅椇昉攋樍』缑甓渕㠗嘙礛瀝䜟嘡䰣", a_));
			IL_11C:
			throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("䬁樃瀅椇昉攋樍』缑紓砕㠗嘙礛瀝䜟嘡䰣", a_));
			IL_149:
			goto IL_27C;
			IL_1D0:
			goto IL_11C;
			IL_22F:
			goto IL_27C;
			IL_27A:
			throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("企洃栅⠇䘉椋怍眏昑簓㘕笗笙爛瀝伟嘡У䐥䴧਩䬫尭唯匱䀳匵䨷ᨹ焻弽㠿⭁⥃㍅╇橉K⭍㹏㕑⁓㹕", a_));
			IL_27C:
			byte[] array = new byte[num3];
			global::System.Security.Cryptography.RandomNumberGenerator.Create().GetNonZeroBytes(array);
			array[0] = (byte)((int)(array[0] & 252) | (num3 & 3));
			array[1] = (byte)((int)(array[1] & 243) | (num3 & 12));
			array[2] = (byte)((int)(array[2] & 207) | (num3 & 48));
			array[3] = (byte)((int)(array[3] & 63) | (num3 & 192));
			return array;
			IL_49:
			num3 = 0;
			num2 = (short)406781960;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006F60 File Offset: 0x00005160
		internal static int GetSaltLength(byte[] saltedData)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
				{
					int result = (int)((saltedData[0] & 3) | (saltedData[1] & 12) | (saltedData[2] & 48) | (saltedData[3] & 192));
					num2 = (short)247922690;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)1014300672;
					short num3 = num2;
					if (saltedData != null)
					{
						num2 = (short)2003501056;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F6;
				}
				case 2:
				{
					int result;
					return result;
				}
				}
				goto IL_25;
			}
			IL_F6:
			throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("䄇搉程漍簏笑瀓㘕尗笙栛缝", a_));
			IL_25:
			num2 = (short)1274454301;
			short num4 = num2;
			num2 = (short)1390911773;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_13;
			default:
			{
				num2 = (short)1565458433;
				if (num2 != 0)
				{
				}
				num2 = (short)1202520064;
				if (num2 != 0)
				{
				}
				int result = 0;
				num2 = (short)1166475265;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x04000021 RID: 33
		private int a;
	}
}
