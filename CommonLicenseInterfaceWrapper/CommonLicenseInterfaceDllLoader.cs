using System;
using System.Configuration.Assemblies;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x02000008 RID: 8
	public class CommonLicenseInterfaceDllLoader
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002FD4 File Offset: 0x000011D4
		internal static void b()
		{
			int a_ = 1;
			short num = (short)1826029569;
			if (num != 0)
			{
			}
			string obj = global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.c("ﾪ", a_);
			bool flag = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				int num2;
				for (;;)
				{
					IL_4E:
					switch (num2)
					{
					case 0:
						global::System.AppDomain.CurrentDomain.AssemblyResolve += global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.a;
						global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.a(new string[]
						{
							global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.a()
						});
						num = (short)1643249665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_DF;
					case 2:
						goto IL_F7;
					case 3:
						if (!global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b)
						{
							num = (short)1150287872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF;
					}
					goto IL_64;
					IL_DF:
					num = (short)1398865922;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F7:
				goto IL_1B1;
				IL_64:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num = (short)1254096899;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4E;
			}
			finally
			{
				num = (short)582615042;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.Threading.Monitor.Exit(obj);
						num = (short)1129324412;
						short num3 = num;
						num = (short)1698897788;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_110;
						default:
							num = (short)2048327680;
							if (num != 0)
							{
							}
							num = (short)450691073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_1AE;
					case 2:
						goto IL_110;
					}
					goto IL_12C;
					IL_110:
					switch (0)
					{
					case 0:
						IL_12C:
						if (!flag)
						{
							goto IL_1B0;
						}
						num = (short)1368391680;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_1AE:
				IL_1B0:;
			}
			IL_1B1:
			num = (short)584843264;
			short num4 = num;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000031D0 File Offset: 0x000013D0
		private static string a()
		{
			int a_ = 10;
			short num = (short)1685389314;
			int num2 = (int)((global::System.IntPtr)num);
			string str;
			for (;;)
			{
				num = (short)1410362959;
				short num3 = num;
				num = (short)523857487;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1624637440;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_178;
					case 1:
						goto IL_10F;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_8A;
						}
						continue;
					case 3:
						goto IL_A5;
					}
					IL_8A:
					if (global::System.Environment.Is64BitProcess)
					{
						num = (short)1706557443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)701693953;
					if (num != 0)
					{
					}
					str = global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.c("莯肱", a_);
					global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.c = new byte[]
					{
						241,
						5,
						223,
						66,
						37,
						62,
						87,
						63,
						210,
						214,
						84,
						112,
						92,
						153,
						184,
						69
					};
					num = (short)624689153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A5:
				num = (short)1711144960;
				short num4 = num;
				str = global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.c("蚯蚱", a_);
				global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.c = new byte[]
				{
					91,
					64,
					115,
					250,
					79,
					106,
					155,
					56,
					5,
					30,
					121,
					192,
					208,
					150,
					32,
					88
				};
				num = (short)2114060288;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			IL_178:
			return global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location), str + global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.c("\udbb1삳", a_));
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003380 File Offset: 0x00001580
		private static global::System.Reflection.Assembly a(object A_0, global::System.ResolveEventArgs A_1)
		{
			int a_ = 16;
			if (!A_1.Name.Contains(global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.c("ﾻ톽궿꿁ꯃꣅ诇ꛉꗋꯍ뻏ꛑ飓뿕믗뿙닛귝觟賡菣ꯥ觧蓩跫觭闯胱꯳胵짷죹쳻", a_)))
			{
				short num = (short)877360169;
				short num2 = num;
				num = (short)450589737;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_26;
				case 1:
					break;
				default:
				{
					num = (short)1616838656;
					short num3 = num;
					break;
				}
				}
				num = (short)952827904;
				if (num != 0)
				{
				}
				num = (short)110952449;
				if (num != 0)
				{
				}
				return null;
			}
			IL_26:
			return global::System.Reflection.Assembly.LoadFrom(global::System.IO.Path.Combine(global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.a(), global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.c("ﾻ톽궿꿁ꯃꣅ诇ꛉꗋꯍ뻏ꛑ飓뿕믗뿙닛귝觟賡菣ꯥ觧蓩跫觭闯胱꯳胵짷죹쳻탽擿渁栃", a_)), global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.c, global::System.Configuration.Assemblies.AssemblyHashAlgorithm.MD5);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003478 File Offset: 0x00001678
		private static void a(params string[] A_0)
		{
			int a_ = 18;
			short num = (short)1277231105;
			if (num != 0)
			{
			}
			num = (short)1990503212;
			short num2 = num;
			num = (short)1724623660;
			switch (num2 == num)
			{
			}
			num = (short)1689255936;
			if (num != 0)
			{
			}
			num = (short)1974796288;
			short num3 = num;
			string[] second = new string[]
			{
				global::System.Environment.GetEnvironmentVariable(global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.c("﮹", a_)) ?? string.Empty
			};
			string value = string.Join(global::System.IO.Path.PathSeparator.ToString(), A_0.Concat(second).Distinct<string>());
			global::System.Environment.SetEnvironmentVariable(global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.c("﮹", a_), value);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003598 File Offset: 0x00001798
		internal static string c(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(214540253 + A_1) + (global::System.IntPtr)46 + (global::System.IntPtr)65 + (global::System.IntPtr)2 + (global::System.IntPtr)87);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
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
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}

		// Token: 0x04000015 RID: 21
		private const string a = "PATH";

		// Token: 0x04000016 RID: 22
		private static bool b;

		// Token: 0x04000017 RID: 23
		private static byte[] c;
	}
}
