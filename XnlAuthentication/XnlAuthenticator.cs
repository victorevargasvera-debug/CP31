using System;
using System.Linq;

namespace XnlAuthentication
{
	// Token: 0x02000005 RID: 5
	public static class XnlAuthenticator
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000212C File Offset: 0x0000032C
		public static byte[] EncryptAuthKey(byte[] unencrypted)
		{
			short num = (short)288817153;
			if (num != 0)
			{
			}
			num = (short)880826030;
			short num2 = num;
			num = (short)317609646;
			switch (num2 == num)
			{
			default:
			{
				num = (short)705298432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2135818240;
			if (num != 0)
			{
			}
			global::XnlAuthentication.XnlAuthenticator.b(unencrypted);
			uint[] a_ = global::XnlAuthentication.XnlAuthenticator.a(unencrypted);
			uint[] a_2 = global::XnlAuthentication.XnlAuthenticator.a();
			uint[] array = global::XnlAuthentication.XnlAuthenticator.b(a_, a_2);
			byte[] bytes = global::System.BitConverter.GetBytes(array[0]);
			byte[] bytes2 = global::System.BitConverter.GetBytes(array[1]);
			global::System.Array.Reverse(bytes);
			global::System.Array.Reverse(bytes2);
			return global::XnlAuthentication.XnlAuthenticator.a(bytes, bytes2);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002214 File Offset: 0x00000414
		public static byte[] DecryptAuthKey(byte[] encrypted)
		{
			short num = (short)1731366347;
			short num2 = num;
			num = (short)799837643;
			switch (num2 == num)
			{
			}
			num = (short)856293376;
			short num3 = num;
			num = (short)357498880;
			if (num != 0)
			{
			}
			num = (short)2147090433;
			if (num != 0)
			{
			}
			global::XnlAuthentication.XnlAuthenticator.b(encrypted);
			uint[] a_ = global::XnlAuthentication.XnlAuthenticator.a(encrypted);
			uint[] a_2 = global::XnlAuthentication.XnlAuthenticator.a();
			uint[] array = global::XnlAuthentication.XnlAuthenticator.a(a_, a_2);
			byte[] bytes = global::System.BitConverter.GetBytes(array[0]);
			byte[] bytes2 = global::System.BitConverter.GetBytes(array[1]);
			global::System.Array.Reverse(bytes);
			global::System.Array.Reverse(bytes2);
			return global::XnlAuthentication.XnlAuthenticator.a(bytes, bytes2);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022FC File Offset: 0x000004FC
		public static bool ValidateEncryptedAuthKey(byte[] authenticationValue, byte[] privateValue)
		{
			short num = (short)2000235190;
			short num2 = num;
			num = (short)1151740598;
			switch (num2 == num)
			{
			}
			num = (short)1336803328;
			short num3 = num;
			num = (short)857145345;
			if (num != 0)
			{
			}
			num = (short)614137856;
			if (num != 0)
			{
			}
			global::XnlAuthentication.XnlAuthenticator.b(authenticationValue);
			return global::XnlAuthentication.XnlAuthenticator.EncryptAuthKey(privateValue).SequenceEqual(authenticationValue);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000023BC File Offset: 0x000005BC
		private static uint[] a()
		{
			short num = (short)1921581056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_40;
				}
				int num3;
				uint[] array;
				byte[][] array2;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (num3 >= 4)
						{
							goto IL_18C;
						}
						array[num3] = (uint)global::System.BitConverter.ToInt32(array2[num3], 0);
						num3++;
						num = (short)1707802625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_170;
					case 2:
						return array;
					case 3:
					{
						num = (short)237168331;
						short num4 = num;
						num = (short)1105061579;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18C;
						default:
							num = (short)745013248;
							if (num != 0)
							{
							}
							goto IL_170;
						}
						break;
					}
					}
					goto IL_40;
					IL_170:
					num = (short)990314496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18C:
					num = (short)445120514;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_40:
				byte[] source = new byte[]
				{
					29,
					48,
					150,
					90,
					85,
					170,
					242,
					12,
					198,
					108,
					147,
					191,
					91,
					205,
					94,
					189
				};
				array2 = new byte[][]
				{
					source.Skip(0).Take(4).ToArray<byte>(),
					source.Skip(4).Take(4).ToArray<byte>(),
					source.Skip(8).Take(4).ToArray<byte>(),
					source.Skip(12).Take(4).ToArray<byte>()
				};
				array = new uint[4];
				num3 = 0;
				num = (short)89128961;
				if (num != 0)
				{
				}
				num = (short)2007040000;
				short num5 = num;
				num = (short)102367235;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000259C File Offset: 0x0000079C
		private static void b(byte[] A_0)
		{
			int a_ = 9;
			short num = (short)1042612227;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_6C;
				case 1:
					goto IL_144;
				case 2:
				{
					num = (short)184221697;
					if (num != 0)
					{
					}
					num = (short)1759819770;
					short num3 = num;
					num = (short)916764666;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6C;
					default:
						num = (short)102563840;
						if (num != 0)
						{
						}
						if (A_0.GetLength(0) != 8)
						{
							num = (short)1289158657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				}
				IL_3E:
				if (A_0 != null)
				{
					num = (short)41287680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_6C:
				num = (short)1416822784;
				short num4 = num;
				num = (short)726663170;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_58:
			throw new global::System.ArgumentException(global::XnlAuthentication.XnlAuthenticator.c("좀ﶈꮊﶎ랖ﺚ햠쮢薤쪦\udca8\ud8aa\ud9ac辮펰횲閴辶馸\ud9ba쒼쮾꓀냂ꯆꛈꗊ꫌", a_));
			IL_144:
			goto IL_58;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000026F4 File Offset: 0x000008F4
		private static uint[] a(byte[] A_0)
		{
			short num = (short)1456372231;
			short num2 = num;
			num = (short)1999862279;
			switch (num2 == num)
			{
			}
			num = (short)698679296;
			short num3 = num;
			num = (short)467206144;
			if (num != 0)
			{
			}
			num = (short)2044526593;
			if (num != 0)
			{
			}
			byte[] array = A_0.Take(A_0.Length / 2).ToArray<byte>();
			byte[] array2 = A_0.Skip(A_0.Length / 2).ToArray<byte>();
			global::System.Array.Reverse(array);
			global::System.Array.Reverse(array2);
			return new uint[]
			{
				global::System.BitConverter.ToUInt32(array, 0),
				global::System.BitConverter.ToUInt32(array2, 0)
			};
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000027E4 File Offset: 0x000009E4
		private static uint[] b(uint[] A_0, uint[] A_1)
		{
			short num = (short)865009664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3F;
				}
				uint num3;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_12C;
					case 1:
						if (num3 >= 32U)
						{
							num = (short)1688207360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12E;
					case 2:
						goto IL_F4;
					case 3:
						goto IL_F4;
					}
					goto IL_3F;
					IL_F4:
					num = (short)179765249;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12C:
				uint num4;
				A_0[0] = num4;
				uint num5;
				A_0[1] = num5;
				return A_0;
				IL_12E:
				uint num6;
				uint num7;
				num6 += num7;
				uint num8;
				uint num9;
				num4 += ((num5 << 4) + num8 ^ num5 + num6 ^ (num5 >> 5) + num9);
				uint num10;
				uint num11;
				num5 += ((num4 << 4) + num10 ^ num4 + num6 ^ (num4 >> 5) + num11);
				num3 += 1U;
				goto IL_15F;
				IL_3F:
				num = (short)781254657;
				if (num != 0)
				{
				}
				num4 = A_0[0];
				num5 = A_0[1];
				num6 = 0U;
				num7 = 2030745457U;
				num8 = A_1[0];
				num9 = A_1[1];
				num10 = A_1[2];
				num11 = A_1[3];
				num3 = 0U;
				num = (short)2057438996;
				short num12 = num;
				num = (short)245303060;
				switch ((num12 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_15F:
					num = (short)1889861632;
					short num13 = num;
					num = (short)1444413442;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				default:
					num = (short)1546125312;
					if (num != 0)
					{
					}
					num = (short)2025259011;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				break;
			}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000029A4 File Offset: 0x00000BA4
		private static uint[] a(uint[] A_0, uint[] A_1)
		{
			short num = (short)122224640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				uint num3;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_12C;
					case 1:
						if (num3 >= 32U)
						{
							num = (short)1519452160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12E;
					case 2:
						goto IL_F6;
					case 3:
						goto IL_F6;
					}
					goto IL_3E;
					IL_F6:
					num = (short)531038209;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12C:
				uint num4;
				A_0[0] = num4;
				uint num5;
				A_0[1] = num5;
				return A_0;
				IL_12E:
				uint num6;
				uint num7;
				uint num8;
				num5 -= ((num4 << 4) + num6 ^ num4 + num7 ^ (num4 >> 5) + num8);
				uint num9;
				uint num10;
				num4 -= ((num5 << 4) + num9 ^ num5 + num7 ^ (num5 >> 5) + num10);
				uint num11;
				num7 -= num11;
				num3 += 1U;
				goto IL_162;
				IL_3E:
				num4 = A_0[0];
				num5 = A_0[1];
				num11 = 2030745457U;
				num7 = 32U * num11;
				num9 = A_1[0];
				num10 = A_1[1];
				num6 = A_1[2];
				num8 = A_1[3];
				num3 = 0U;
				num = (short)1357485921;
				short num12 = num;
				num = (short)1467717473;
				switch ((num12 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_162:
					num = (short)1685454848;
					short num13 = num;
					num = (short)667811842;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				default:
					num = (short)2145648641;
					if (num != 0)
					{
					}
					num = (short)2136145920;
					if (num != 0)
					{
					}
					num = (short)663617539;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				break;
			}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002B64 File Offset: 0x00000D64
		private static byte[] a(byte[] A_0, byte[] A_1)
		{
			short num = (short)1033895937;
			if (num != 0)
			{
			}
			num = (short)2070575661;
			short num2 = num;
			num = (short)1692629549;
			switch (num2 == num)
			{
			}
			num = (short)2146631680;
			if (num != 0)
			{
			}
			num = (short)1992425472;
			short num3 = num;
			int num4 = A_0.Length;
			global::System.Array.Resize<byte>(ref A_0, num4 + A_1.Length);
			global::System.Array.Copy(A_1, 0, A_0, num4, A_1.Length);
			return A_0;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002C28 File Offset: 0x00000E28
		internal static string c(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1113427836 + A_1) + (global::System.IntPtr)48 + (global::System.IntPtr)25 + (global::System.IntPtr)81 + (global::System.IntPtr)44 + (global::System.IntPtr)53);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}
	}
}
