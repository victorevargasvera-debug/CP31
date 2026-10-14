using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace PbtSrec
{
	// Token: 0x02000003 RID: 3
	public class PbtSrecWrapper
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000021A8 File Offset: 0x000003A8
		static PbtSrecWrapper()
		{
			short num = (short)1183014192;
			short num2 = num;
			num = (short)381050160;
			switch (num2 == num)
			{
			}
			num = (short)486473729;
			if (num != 0)
			{
			}
			num = (short)2108489728;
			if (num != 0)
			{
			}
			num = (short)698351616;
			short num3 = num;
			global::PbtSrec.PbtSrecWrapper.b = global::System.Environment.OSVersion.Platform;
			global::System.AppDomain.CurrentDomain.AssemblyResolve += global::PbtSrec.PbtSrecWrapper.a;
			global::PbtSrec.PbtSrecWrapper.a(new string[]
			{
				global::PbtSrec.PbtSrecWrapper.a()
			});
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002288 File Offset: 0x00000488
		private static string a()
		{
			int a_ = 14;
			short num = (short)606797824;
			short num2 = num;
			num = (short)2014380033;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)2127413440;
					short num4 = num;
					num = (short)244236480;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_11B;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 2:
					num = (short)504037377;
					if (num != 0)
					{
					}
					num = (short)73859072;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_C0;
				}
				IL_66:
				if (!global::System.Environment.Is64BitProcess)
				{
					num = (short)798228482;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1437270019;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_C0:
			string text = global::<Module>.b("㈃㈅", a_);
			goto IL_141;
			IL_11B:
			num = (short)877395968;
			if (num != 0)
			{
			}
			text = global::<Module>.b("㜃㐅", a_);
			IL_141:
			string str = text;
			return global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location), str + global::<Module>.b("䘃漅簇嘉", a_));
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002400 File Offset: 0x00000600
		private static global::System.Reflection.Assembly a(object A_0, global::System.ResolveEventArgs A_1)
		{
			int a_ = 10;
			short num;
			while (!A_1.Name.Contains(global::<Module>.b("烿态瀃甅稇漉漋", a_)))
			{
				num = (short)97796383;
				short num2 = num;
				num = (short)180109599;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)8454144;
					if (num != 0)
					{
					}
					num = (short)974913537;
					if (num != 0)
					{
					}
					return null;
				}
			}
			num = (short)96600064;
			short num3 = num;
			return global::System.Reflection.Assembly.LoadFrom(global::System.IO.Path.Combine(global::PbtSrec.PbtSrecWrapper.a(), global::<Module>.b("烿态瀃甅稇漉漋‍琏縑砓", a_)));
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000024EC File Offset: 0x000006EC
		private static void a(params string[] A_0)
		{
			int a_ = 16;
			short num = (short)1941766144;
			short num2 = num;
			num = (short)786432001;
			if (num != 0)
			{
			}
			num = (short)1778872330;
			short num3 = num;
			num = (short)2019586058;
			switch (num3 == num)
			{
			}
			num = (short)407044096;
			if (num != 0)
			{
			}
			string[] second = new string[]
			{
				global::System.Environment.GetEnvironmentVariable(global::<Module>.b("嘅䤇帉䐋", a_)) ?? string.Empty
			};
			string value = string.Join(global::System.IO.Path.PathSeparator.ToString(), A_0.Concat(second).Distinct<string>());
			global::System.Environment.SetEnvironmentVariable(global::<Module>.b("嘅䤇帉䐋", a_), value);
		}

		// Token: 0x06000009 RID: 9
		[global::System.Runtime.InteropServices.DllImport("pbtsrec.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "PbtStart")]
		private static extern int b(string A_0, string A_1, uint A_2);

		// Token: 0x0600000A RID: 10
		[global::System.Runtime.InteropServices.DllImport("pbtsrec.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "PbtStartSA")]
		private static extern int b(string A_0, string A_1, out global::System.IntPtr A_2, uint A_3);

		// Token: 0x0600000B RID: 11
		[global::System.Runtime.InteropServices.DllImport("pbtsrec.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ReleaseBuffer")]
		private static extern int b(global::System.IntPtr A_0);

		// Token: 0x0600000C RID: 12
		[global::System.Runtime.InteropServices.DllImport("pbtsrec.so", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "PbtStart")]
		private static extern int a(string A_0, string A_1, uint A_2);

		// Token: 0x0600000D RID: 13
		[global::System.Runtime.InteropServices.DllImport("pbtsrec.so", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "PbtStartSA")]
		private static extern int a(string A_0, string A_1, out global::System.IntPtr A_2, uint A_3);

		// Token: 0x0600000E RID: 14
		[global::System.Runtime.InteropServices.DllImport("pbtsrec.so", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ReleaseBuffer")]
		private static extern int a(global::System.IntPtr A_0);

		// Token: 0x0600000F RID: 15 RVA: 0x000025FC File Offset: 0x000007FC
		public static int PBTMain2(string Configfile, string cDataFile, uint ishVersion)
		{
			short num;
			while (global::PbtSrec.PbtSrecWrapper.b != global::System.PlatformID.Unix)
			{
				num = (short)1321865282;
				short num2 = num;
				num = (short)1475678274;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2075656193;
					if (num != 0)
					{
					}
					num = (short)369098752;
					if (num != 0)
					{
					}
					return global::PbtSrec.PbtSrecWrapper.b(Configfile, cDataFile, ishVersion);
				}
			}
			num = (short)1467940864;
			short num3 = num;
			return global::PbtSrec.PbtSrecWrapper.a(Configfile, cDataFile, ishVersion);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000026C0 File Offset: 0x000008C0
		public static int PBTMainSA2(string Configfile, string data, out string srecOutput, uint ishVersion)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				global::System.IntPtr intPtr;
				switch (num)
				{
				case 0:
					if (global::PbtSrec.PbtSrecWrapper.b == global::System.PlatformID.Unix)
					{
						num2 = (short)225443846;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3 = global::PbtSrec.PbtSrecWrapper.b(Configfile, data, out intPtr, ishVersion);
					num2 = (short)238419975;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_247;
				case 2:
				{
					string text = global::System.Runtime.InteropServices.Marshal.PtrToStringAnsi(intPtr);
					srecOutput = ((text != null) ? text.Trim() : null);
					num2 = (short)784138243;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					if (global::PbtSrec.PbtSrecWrapper.b == global::System.PlatformID.Unix)
					{
						num2 = (short)1350565889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3 = global::PbtSrec.PbtSrecWrapper.b(intPtr);
					num2 = (short)1868411979;
					short num4 = num2;
					num2 = (short)280474699;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_247;
					case 1:
						break;
					default:
					{
						num2 = (short)291438592;
						short num5 = num2;
						break;
					}
					}
					num2 = (short)1100349441;
					if (num2 != 0)
					{
					}
					num2 = (short)1919811584;
					if (num2 != 0)
					{
					}
					num2 = (short)1413808136;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					return num3;
				case 5:
					if (num3 == 0)
					{
						num2 = (short)712769546;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return num3;
				case 6:
					num3 = global::PbtSrec.PbtSrecWrapper.a(Configfile, data, out intPtr, ishVersion);
					num2 = (short)331743241;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_1D2;
				case 8:
					return num3;
				case 9:
					goto IL_1D2;
				case 10:
					num2 = (short)2009202690;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3C;
				IL_1D2:
				num2 = (short)65601541;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_247:
				num3 = global::PbtSrec.PbtSrecWrapper.a(intPtr);
				num2 = (short)737411076;
				num = (int)((global::System.IntPtr)num2);
			}
			return num3;
			IL_3C:
			srecOutput = null;
			num2 = (short)1725169664;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000003 RID: 3
		private const string a = "PATH";

		// Token: 0x04000004 RID: 4
		private static readonly global::System.PlatformID b;
	}
}
