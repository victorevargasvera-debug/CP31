using System;
using System.Security.Cryptography;
using System.Text;

namespace AcpCryptoLib
{
	// Token: 0x0200001A RID: 26
	public class HashUtil
	{
		// Token: 0x0600006A RID: 106 RVA: 0x0000B174 File Offset: 0x00009374
		private static byte[] a()
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			int num2;
			byte[] bytes;
			short num3;
			byte[] array;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (num2 >= bytes.Length)
					{
						num3 = (short)1277952000;
						short num4 = num3;
						num3 = (short)740687875;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_10E;
				case 1:
					goto IL_63;
				case 2:
					goto IL_63;
				case 3:
				{
					num3 = (short)1280536376;
					short num5 = num3;
					num3 = (short)1203138360;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10E;
					default:
						goto IL_F6;
					}
					break;
				}
				}
				goto IL_29;
				IL_63:
				num3 = (short)1074266112;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_10E:
				array[num2] = (bytes[num2] | 2);
				num2++;
				num3 = (short)1810300929;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_F6:
			num3 = (short)836370432;
			if (num3 != 0)
			{
			}
			num3 = (short)764018689;
			if (num3 != 0)
			{
			}
			return new global::System.Security.Cryptography.Rfc2898DeriveBytes(bytes, array, 1000).GetBytes(64);
			IL_29:
			bytes = global::System.Text.Encoding.UTF8.GetBytes(global::AcpCryptoLib.XmlEncryptionUtil.b("⬑倓唕ⴗⴙ堛☝ᔟ怡ᘣ攥ἧḩᬫᠭ瘯਱ళص稷̹฻ܽ̿فŃ瑅穇ࡉཋ罍ፏᝑ浓潕᱗ᡙ浛ᵝ呟啡╣幥⹧幩⽫彭䑯䭱びふ㥷䱹㡻䩽썿뒁떃삅뾇몉좋뾍꒏", a_));
			array = new byte[bytes.Length];
			num2 = 0;
			num3 = (short)671416322;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000B2F4 File Offset: 0x000094F4
		public static string Hash(string inData)
		{
			int a_ = 16;
			short num = (short)55050240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				string text;
				byte[] key;
				for (;;)
				{
					IL_31:
					global::System.Security.Cryptography.HMACSHA256 hmacsha;
					byte[] bytes;
					switch (num2)
					{
					case 0:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_FF;
							}
							int num3;
							int num4;
							byte[] array;
							for (;;)
							{
								IL_E4:
								switch (num2)
								{
								case 0:
									goto IL_1BC;
								case 1:
									goto IL_128;
								case 2:
									if (num3 >= num4)
									{
										num = (short)534118404;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									text += string.Format(global::AcpCryptoLib.XmlEncryptionUtil.b("琎ℐ⤒洔┖搘", a_), array[num4 - 1 - num3]);
									num3++;
									num = (short)917635073;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_128;
								case 4:
									num = (short)1185677312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_FF;
								IL_128:
								num = (short)1179713538;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1BC:
							return text;
							IL_FF:
							array = hmacsha.ComputeHash(bytes);
							num4 = array.Length;
							num3 = 0;
							num = (short)2041118723;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_E4;
						}
						finally
						{
							num = (short)252837889;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_22C;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1F3;
									}
									continue;
								case 2:
									((global::System.IDisposable)hmacsha).Dispose();
									num = (short)610336768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1F3:
								if (hmacsha != null)
								{
									num = (short)711524354;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_22C:
								num = (short)1442316160;
								short num5 = num;
								num = (short)1364066176;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1F3;
								default:
									goto IL_261;
								}
							}
							IL_261:
							num = (short)783220736;
							if (num != 0)
							{
							}
						}
						goto IL_278;
					case 1:
						if (!string.IsNullOrEmpty(inData))
						{
							num = (short)2057437186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 2:
					{
						num = (short)1785200641;
						if (num != 0)
						{
						}
						num = (short)10420224;
						short num6 = num;
						goto IL_278;
					}
					}
					goto IL_44;
					IL_278:
					bytes = global::System.Text.Encoding.UTF8.GetBytes(inData);
					hmacsha = new global::System.Security.Cryptography.HMACSHA256(key);
					num = (short)704970752;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				IL_44:
				text = null;
				key = global::AcpCryptoLib.HashUtil.a();
				num = (short)1852375041;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}
	}
}
