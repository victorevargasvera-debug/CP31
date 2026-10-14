using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace PreEmptive.SoS.Runtime
{
	// Token: 0x0200009C RID: 156
	public sealed class Verifier
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x000FE620 File Offset: 0x000FC820
		private Verifier()
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000FE634 File Offset: 0x000FC834
		public static bool Verify(global::System.IntPtr baseAddress, string startstr, string endstr, string hashstr)
		{
			short num = (short)455868416;
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
				bool flag;
				byte[] array;
				int num4;
				int num5;
				byte[] array2;
				byte[] value;
				byte[] sourceArray;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						num = (short)1296105473;
						if (num != 0)
						{
						}
						try
						{
							global::System.IntPtr startAt;
							long totalSize;
							global::System.IO.Stream stream = new global::PreEmptive.SoS.Runtime.FixedLengthStream(new global::PreEmptive.SoS.Runtime.AnyMemoryStream(startAt), totalSize);
							global::System.Security.Cryptography.SHA1 sha = new global::System.Security.Cryptography.SHA1CryptoServiceProvider();
							byte[] b = sha.ComputeHash(stream);
							flag &= global::PreEmptive.SoS.Runtime.Verifier.ArrayCompare(array, b);
							goto IL_8C;
						}
						finally
						{
							num = (short)475725824;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.IO.Stream stream;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1F9;
									}
									continue;
								case 1:
									goto IL_233;
								case 2:
									stream.Close();
									num = (short)1440481281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1F9;
								IL_1FD:
								num = (short)157351938;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_233:
								num = (short)1544097598;
								short num3 = num;
								num = (short)1553534782;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1FD;
								default:
									goto IL_269;
								}
								IL_1F9:
								if (stream != null)
								{
									goto IL_1FD;
								}
								goto IL_233;
							}
							IL_269:
							num = (short)2028142592;
							if (num != 0)
							{
							}
						}
						return flag;
						IL_8C:
						num4++;
						num = (short)1983840260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return flag;
					case 2:
						goto IL_154;
					case 3:
					{
						if (num4 >= num5)
						{
							num = (short)1216872449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)5505024;
						short num6 = num;
						long num7 = global::System.BitConverter.ToInt64(array2, num4 * 8);
						long num8 = global::System.BitConverter.ToInt64(value, num4 * 8);
						global::System.Array.Copy(sourceArray, num4 * 20, array, 0, 20);
						long totalSize = num8 - num7;
						global::System.IntPtr startAt = global::PreEmptive.SoS.Runtime.Verifier.Increment(baseAddress, num7);
						global::System.IO.Stream stream = null;
						num = (short)272433152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_154;
					}
					goto IL_44;
					IL_154:
					num = (short)1297940483;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_44:
				array2 = global::PreEmptive.SoS.Runtime.Verifier.Decode(startstr);
				value = global::PreEmptive.SoS.Runtime.Verifier.Decode(endstr);
				sourceArray = global::PreEmptive.SoS.Runtime.Verifier.Decode(hashstr);
				array = new byte[20];
				num5 = array2.Length / 8;
				flag = (num5 > 0);
				num4 = 0;
				num = (short)679018498;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000FE8D4 File Offset: 0x000FCAD4
		public static bool ArrayCompare(byte[] b1, byte[] b2)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num3;
			int num4;
			int num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_E9;
				case 1:
				{
					int num2;
					if (b1[num2] != b2[num2])
					{
						num3 = (short)82903044;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num2++;
					num3 = (short)384696327;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 2:
				{
					if (num4 != num5)
					{
						num3 = (short)2124349445;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					int num2 = 0;
					num3 = (short)1021575168;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 3:
				{
					num3 = (short)585957376;
					short num6 = num3;
					num3 = (short)1768535747;
					short num7 = num3;
					num3 = (short)1074902723;
					switch ((num7 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E9;
					default:
						goto IL_19B;
					}
					break;
				}
				case 4:
					return false;
				case 5:
					goto IL_68;
				case 6:
				{
					int num2;
					if (num2 >= num4)
					{
						num3 = (short)1499594755;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)619839489;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 7:
					goto IL_E9;
				}
				goto IL_30;
				IL_E9:
				num3 = (short)1454047238;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_68:
			num3 = (short)346292225;
			if (num3 != 0)
			{
			}
			return false;
			IL_19B:
			num3 = (short)655949824;
			if (num3 != 0)
			{
			}
			return true;
			IL_30:
			num4 = b1.Length;
			num5 = b2.Length;
			num3 = (short)33751042;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000FEA94 File Offset: 0x000FCC94
		public static global::System.IntPtr FindMyAddress(global::System.Reflection.Assembly asm)
		{
			short num = (short)1325332705;
			short num2 = num;
			num = (short)1417345249;
			global::System.IntPtr result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)840892416;
				if (num != 0)
				{
				}
				num = (short)1474297857;
				if (num != 0)
				{
				}
				global::System.Reflection.Module[] loadedModules = asm.GetLoadedModules();
				result = global::System.IntPtr.Zero;
				try
				{
					num = (short)823263233;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_108;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_B4;
							}
							continue;
						case 2:
							goto IL_F3;
						case 3:
						{
							global::System.Reflection.Module m = loadedModules[0];
							result = global::System.Runtime.InteropServices.Marshal.GetHINSTANCE(m);
							num = (short)230490114;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_B4:
						if (loadedModules.Length != 0)
						{
							num = (short)864747523;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_F3:
						num = (short)1424424960;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_108:;
				}
				catch
				{
				}
				break;
			}
			}
			num = (short)1140916224;
			short num4 = num;
			return result;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000FEBE8 File Offset: 0x000FCDE8
		public static void DefaultNotificationHandler(bool tampered)
		{
			short num = (short)318177280;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
				{
					num = (short)2132410369;
					if (num != 0)
					{
					}
					num = (short)923371348;
					short num3 = num;
					num = (short)1434814292;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1022689280;
						if (num != 0)
						{
						}
						global::System.Environment.Exit(0);
						num = (short)901316610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				IL_30:
				if (!tampered)
				{
					break;
				}
				num = (short)1150746624;
				short num4 = num;
				num = (short)1984036865;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000FED00 File Offset: 0x000FCF00
		private static byte[] Decode(string s)
		{
			short num = (short)2088697856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				byte[] array;
				for (;;)
				{
					IL_27:
					num = (short)1114963968;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_104;
					case 1:
						goto IL_104;
					case 2:
						goto IL_11C;
					case 3:
						return array;
					}
					goto IL_66;
					IL_104:
					num = (short)1125580802;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_66:
				char[] array2 = s.ToCharArray();
				array = new byte[array2.Length * 2];
				int num4 = 0;
				num = (short)1363859734;
				short num5 = num;
				num = (short)289790230;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_11C:
					if (num4 >= array2.Length)
					{
						num = (short)1540489219;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_27;
					}
					char value = array2[num4];
					byte[] bytes = global::System.BitConverter.GetBytes(value);
					global::System.Array.Copy(bytes, 0, array, num4 * 2, 2);
					num4++;
					num = (short)1183383552;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				default:
					num = (short)1008467969;
					if (num != 0)
					{
					}
					num = (short)6225920;
					if (num != 0)
					{
					}
					num = (short)1184235521;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				break;
			}
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x000FEE84 File Offset: 0x000FD084
		private static global::System.IntPtr Increment(global::System.IntPtr ptr, long count)
		{
			short num = (short)1093009409;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_127;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_10F;
				case 3:
					goto IL_106;
				}
				IL_34:
				if (!global::PreEmptive.SoS.Runtime.Verifier.arch64)
				{
					num = (short)2136080384;
					short num3 = num;
					num = (short)1381105666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1459163710;
				short num4 = num;
				num = (short)1335104062;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1425145857;
					if (num != 0)
					{
					}
					num = (short)1792278528;
					if (num != 0)
					{
					}
					num = (short)1831010307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_10F:
				num = (short)1221984256;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_106:
			long num5 = ptr.ToInt64();
			goto IL_131;
			IL_127:
			num5 = (long)ptr.ToInt32();
			IL_131:
			long num6 = num5 + count;
			return global::System.Runtime.InteropServices.Marshal.ReadIntPtr(num6, 0);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000FEFD4 File Offset: 0x000FD1D4
		// Note: this type is marked as 'beforefieldinit'.
		static Verifier()
		{
			short num = (short)648838736;
			short num2 = num;
			num = (short)2011201104;
			switch (num2 == num)
			{
			}
			num = (short)1846870017;
			if (num != 0)
			{
			}
			num = (short)1218183168;
			if (num != 0)
			{
			}
			num = (short)530841600;
			short num3 = num;
			global::PreEmptive.SoS.Runtime.Verifier.arch64 = (global::System.IntPtr.Size == 8);
		}

		// Token: 0x040003B5 RID: 949
		private static bool arch64;

		// Token: 0x040003B6 RID: 950
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
