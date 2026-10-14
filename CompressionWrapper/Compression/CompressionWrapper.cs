using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Compression
{
	// Token: 0x02000005 RID: 5
	public class CompressionWrapper
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000021EC File Offset: 0x000003EC
		static CompressionWrapper()
		{
			short num = (short)1306777825;
			short num2 = num;
			num = (short)248568033;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1838743552;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)61341697;
			if (num != 0)
			{
			}
			num = (short)1866334208;
			if (num != 0)
			{
			}
			global::Compression.CompressionWrapper.b = global::System.Environment.OSVersion.Platform;
			global::System.AppDomain.CurrentDomain.AssemblyResolve += global::Compression.CompressionWrapper.a;
			global::Compression.CompressionWrapper.a(new string[]
			{
				global::Compression.CompressionWrapper.a()
			});
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000022CC File Offset: 0x000004CC
		private static string a()
		{
			int a_ = 15;
			short num = (short)496173059;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1956776905;
				short num3 = num;
				num = (short)1806502857;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1157038080;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_10E;
					case 1:
						goto IL_F6;
					case 2:
						goto IL_BD;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					}
					IL_88:
					if (!global::System.Environment.Is64BitProcess)
					{
						num = (short)1543503873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)447807490;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F6:
				num = (short)1095303168;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BD:
			num = (short)852623360;
			short num4 = num;
			string text = global::<Module>.b("孬孮", a_);
			goto IL_145;
			IL_10E:
			num = (short)1264910337;
			if (num != 0)
			{
			}
			text = global::<Module>.b("幬嵮", a_);
			IL_145:
			string str = text;
			return global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location), str + global::<Module>.b("⽬ٮհ⽲", a_));
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002448 File Offset: 0x00000648
		private static global::System.Reflection.Assembly a(object A_0, global::System.ResolveEventArgs A_1)
		{
			int a_ = 3;
			if (!A_1.Name.Contains(global::<Module>.b("≠ౢࡤ੦٨ժ䍬ⱮṰṲᡴɶ᝸ቺṼṾꞈ좊", a_)))
			{
				short num = (short)1709834241;
				if (num != 0)
				{
				}
				num = (short)918640762;
				short num2 = num;
				num = (short)968448122;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)315686912;
					short num3 = num;
					num = (short)1415446528;
					if (num != 0)
					{
					}
					return null;
				}
				}
			}
			return global::System.Reflection.Assembly.LoadFrom(global::System.IO.Path.Combine(global::Compression.CompressionWrapper.a(), global::<Module>.b("≠ౢࡤ੦٨ժ䍬ⱮṰṲᡴɶ᝸ቺṼṾꞈ좊辠잢즤쮦", a_)));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002538 File Offset: 0x00000738
		private static void a(params string[] A_0)
		{
			int a_ = 15;
			short num = (short)1393229825;
			if (num != 0)
			{
			}
			num = (short)540999680;
			short num2 = num;
			num = (short)1808735460;
			short num3 = num;
			num = (short)1985289444;
			switch (num3 == num)
			{
			}
			num = (short)754122752;
			if (num != 0)
			{
			}
			string[] second = new string[]
			{
				global::System.Environment.GetEnvironmentVariable(global::<Module>.b("㵬⹮╰㭲", a_)) ?? string.Empty
			};
			string value = string.Join(global::System.IO.Path.PathSeparator.ToString(), A_0.Concat(second).Distinct<string>());
			global::System.Environment.SetEnvironmentVariable(global::<Module>.b("㵬⹮╰㭲", a_), value);
		}

		// Token: 0x0600000C RID: 12
		[global::System.Runtime.InteropServices.DllImport("Common.Communication.Compression.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "data_compress")]
		private static extern int b(byte[] A_0, int A_1, byte[] A_2, ref uint A_3);

		// Token: 0x0600000D RID: 13
		[global::System.Runtime.InteropServices.DllImport("Common.Communication.Compression.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "data_decompress")]
		private static extern int b(byte[] A_0, int A_1, byte[] A_2, ref uint A_3, int A_4);

		// Token: 0x0600000E RID: 14
		[global::System.Runtime.InteropServices.DllImport("Common.Communication.Compression.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "LZMA_Compress")]
		private static extern int b(byte[] A_0, [global::System.Runtime.CompilerServices.a] ref global::System.UIntPtr A_1, byte[] A_2, [global::System.Runtime.CompilerServices.a] global::System.UIntPtr A_3, int A_4);

		// Token: 0x0600000F RID: 15
		[global::System.Runtime.InteropServices.DllImport("Common.Communication.Compression.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "LZMA_Uncompress")]
		private static extern int b(byte[] A_0, byte[] A_1, [global::System.Runtime.CompilerServices.a] global::System.UIntPtr A_2);

		// Token: 0x06000010 RID: 16
		[global::System.Runtime.InteropServices.DllImport("Common.Communication.Compression.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "LZMA_UncompressSize")]
		[return: global::System.Runtime.CompilerServices.a]
		private static extern global::System.UIntPtr b(byte[] A_0);

		// Token: 0x06000011 RID: 17
		[global::System.Runtime.InteropServices.DllImport("Common.Communication.Compression.so", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "data_compress")]
		private static extern int a(byte[] A_0, int A_1, byte[] A_2, ref uint A_3);

		// Token: 0x06000012 RID: 18
		[global::System.Runtime.InteropServices.DllImport("Common.Communication.Compression.so", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "data_decompress")]
		private static extern int a(byte[] A_0, int A_1, byte[] A_2, ref uint A_3, int A_4);

		// Token: 0x06000013 RID: 19
		[global::System.Runtime.InteropServices.DllImport("Common.Communication.Compression.so", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "LZMA_Compress")]
		private static extern int a(byte[] A_0, [global::System.Runtime.CompilerServices.a] ref global::System.UIntPtr A_1, byte[] A_2, [global::System.Runtime.CompilerServices.a] global::System.UIntPtr A_3, int A_4);

		// Token: 0x06000014 RID: 20
		[global::System.Runtime.InteropServices.DllImport("Common.Communication.Compression.so", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "LZMA_Uncompress")]
		private static extern int a(byte[] A_0, byte[] A_1, [global::System.Runtime.CompilerServices.a] global::System.UIntPtr A_2);

		// Token: 0x06000015 RID: 21
		[global::System.Runtime.InteropServices.DllImport("Common.Communication.Compression.so", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "LZMA_UncompressSize")]
		[return: global::System.Runtime.CompilerServices.a]
		private static extern global::System.UIntPtr a(byte[] A_0);

		// Token: 0x06000016 RID: 22 RVA: 0x00002648 File Offset: 0x00000848
		public static void DataCompressFastLZ(byte[] sourceData, byte[] outData, ref uint outLen)
		{
			if (global::Compression.CompressionWrapper.b != global::System.PlatformID.Unix)
			{
				short num = (short)398544235;
				short num2 = num;
				num = (short)2130267499;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1185742849;
					if (num != 0)
					{
					}
					num = (short)333905920;
					short num3 = num;
					num = (short)2049245184;
					if (num != 0)
					{
					}
					global::Compression.CompressionWrapper.b(sourceData, sourceData.Length, outData, ref outLen);
					return;
				}
				}
			}
			global::Compression.CompressionWrapper.a(sourceData, sourceData.Length, outData, ref outLen);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002718 File Offset: 0x00000918
		public static void DataDecompressFastLZ(byte[] sourceData, byte[] outData, ref uint outLen, int maxOut)
		{
			if (global::Compression.CompressionWrapper.b != global::System.PlatformID.Unix)
			{
				short num = (short)1709164533;
				short num2 = num;
				num = (short)305448949;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1282670593;
					if (num != 0)
					{
					}
					num = (short)1310261248;
					short num3 = num;
					num = (short)1913323520;
					if (num != 0)
					{
					}
					global::Compression.CompressionWrapper.b(sourceData, sourceData.Length, outData, ref outLen, maxOut);
					return;
				}
				}
			}
			global::Compression.CompressionWrapper.a(sourceData, sourceData.Length, outData, ref outLen, maxOut);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000027E8 File Offset: 0x000009E8
		public static void DataDecompressFastLZ(byte[] sourceData, byte[] outData, ref uint outLen)
		{
			if (global::Compression.CompressionWrapper.b != global::System.PlatformID.Unix)
			{
				short num = (short)1983562727;
				short num2 = num;
				num = (short)892650471;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)562823168;
					if (num != 0)
					{
					}
					num = (short)1329594368;
					short num3 = num;
					num = (short)588906497;
					if (num != 0)
					{
					}
					global::Compression.CompressionWrapper.b(sourceData, sourceData.Length, outData, ref outLen, outData.Length);
					return;
				}
				}
			}
			global::Compression.CompressionWrapper.a(sourceData, sourceData.Length, outData, ref outLen, outData.Length);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000028BC File Offset: 0x00000ABC
		public static bool DataCompressLZMA(byte[] sourceData, byte[] outData, ref ulong outLen, int dictSize)
		{
			short num2;
			global::System.UIntPtr uintPtr;
			int num4;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_116;
					case 1:
					{
						num2 = (short)117690791;
						short num3 = num2;
						num2 = (short)26792359;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1596194816;
							if (num2 != 0)
							{
							}
							num4 = global::Compression.CompressionWrapper.a(outData, ref uintPtr, sourceData, (global::System.UIntPtr)((global::System.IntPtr)sourceData.Length), dictSize);
							num2 = (short)130875392;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_7C;
					case 3:
						if (global::Compression.CompressionWrapper.b == global::System.PlatformID.Unix)
						{
							num2 = (short)697958401;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num4 = global::Compression.CompressionWrapper.b(outData, ref uintPtr, sourceData, (global::System.UIntPtr)((global::System.IntPtr)sourceData.Length), dictSize);
						num2 = (short)685768706;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_20:
				num4 = 1;
				uintPtr = (global::System.UIntPtr)outLen;
				num2 = (short)339738627;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_7C:
			num2 = (short)1892745217;
			if (num2 != 0)
			{
			}
			IL_116:
			num2 = (short)1911685120;
			short num5 = num2;
			outLen = (ulong)uintPtr;
			return num4 == 0;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002A14 File Offset: 0x00000C14
		public static bool DataDecompressLZMA(byte[] sourceData, out byte[] outData, ref ulong outLen)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::System.UIntPtr uintPtr;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return false;
				case 1:
					if (global::Compression.CompressionWrapper.b == global::System.PlatformID.Unix)
					{
						num2 = (short)1308622859;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					uintPtr = global::Compression.CompressionWrapper.b(sourceData);
					num2 = (short)1087963138;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_232;
				case 3:
					if (global::Compression.CompressionWrapper.b == global::System.PlatformID.Unix)
					{
						num2 = (short)1205600263;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3 = global::Compression.CompressionWrapper.b(outData, sourceData, (global::System.UIntPtr)((global::System.IntPtr)sourceData.Length));
					num2 = (short)1966473224;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return false;
				case 5:
					goto IL_232;
				case 6:
					if ((int)uintPtr <= 0)
					{
						num2 = (short)790036484;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					outData = new byte[(ulong)uintPtr];
					num2 = (short)13369347;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num3 = global::Compression.CompressionWrapper.a(outData, sourceData, (global::System.UIntPtr)((global::System.IntPtr)sourceData.Length));
					num2 = (short)1710161930;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_13A;
				case 9:
				{
					num2 = (short)250221819;
					short num4 = num2;
					num2 = (short)2118391035;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E3;
					default:
						num2 = (short)2029322240;
						if (num2 != 0)
						{
						}
						if (num3 != 0)
						{
							num2 = (short)6094848;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_26A;
					}
					break;
				}
				case 10:
					goto IL_13A;
				case 11:
					goto IL_1E3;
				}
				goto IL_40;
				IL_13A:
				num2 = (short)1725956097;
				if (num2 != 0)
				{
				}
				num2 = (short)1630273545;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1E3:
				uintPtr = global::Compression.CompressionWrapper.a(sourceData);
				num2 = (short)659488773;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_232:
				num2 = (short)142475270;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_26A:
			outLen = (ulong)uintPtr;
			return true;
			IL_40:
			num3 = 1;
			outData = null;
			num2 = (short)496893952;
			short num5 = num2;
			num2 = (short)898826241;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000004 RID: 4
		private const string a = "PATH";

		// Token: 0x04000005 RID: 5
		private static readonly global::System.PlatformID b;
	}
}
