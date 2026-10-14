using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ACPVoiceCompressionLibWrapper
{
	// Token: 0x02000003 RID: 3
	public static class ACPVoiceCompression
	{
		// Token: 0x06000005 RID: 5
		[global::System.Runtime.InteropServices.DllImport("ACPVoiceCompressionLib.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, EntryPoint = "DeflateMain_FileInterface")]
		private static extern int b(int A_0, string A_1, string A_2);

		// Token: 0x06000006 RID: 6
		[global::System.Runtime.InteropServices.DllImport("ACPVoiceCompressionLib.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "DeflateMain_MemoryInterface")]
		private static extern int b(int A_0, byte[] A_1, int A_2, byte[] A_3, int A_4, ref int A_5);

		// Token: 0x06000007 RID: 7
		[global::System.Runtime.InteropServices.DllImport("ACPVoiceCompressionLib.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, EntryPoint = "InflateMain_FileInterface")]
		private static extern int b(string A_0, string A_1);

		// Token: 0x06000008 RID: 8
		[global::System.Runtime.InteropServices.DllImport("ACPVoiceCompressionLib.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "InflateMain_MemoryInterface")]
		private static extern int b(byte[] A_0, int A_1, byte[] A_2, int A_3, ref int A_4);

		// Token: 0x06000009 RID: 9
		[global::System.Runtime.InteropServices.DllImport("ACPVoiceCompressionLib.so", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Ansi, EntryPoint = "DeflateMain_FileInterface")]
		private static extern int a(int A_0, string A_1, string A_2);

		// Token: 0x0600000A RID: 10
		[global::System.Runtime.InteropServices.DllImport("ACPVoiceCompressionLib.so", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "DeflateMain_MemoryInterface")]
		private static extern int a(int A_0, byte[] A_1, int A_2, byte[] A_3, int A_4, ref int A_5);

		// Token: 0x0600000B RID: 11
		[global::System.Runtime.InteropServices.DllImport("ACPVoiceCompressionLib.so", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = global::System.Runtime.InteropServices.CharSet.Ansi, EntryPoint = "InflateMain_FileInterface")]
		private static extern int a(string A_0, string A_1);

		// Token: 0x0600000C RID: 12
		[global::System.Runtime.InteropServices.DllImport("ACPVoiceCompressionLib.so", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "InflateMain_MemoryInterface")]
		private static extern int a(byte[] A_0, int A_1, byte[] A_2, int A_3, ref int A_4);

		// Token: 0x0600000D RID: 13 RVA: 0x00002198 File Offset: 0x00000398
		static ACPVoiceCompression()
		{
			short num = (short)1546256384;
			short num2 = num;
			num = (short)1824080121;
			short num3 = num;
			num = (short)563233017;
			switch (num3 == num)
			{
			}
			num = (short)1243676673;
			if (num != 0)
			{
			}
			num = (short)1981087744;
			if (num != 0)
			{
			}
			global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.b = global::System.Environment.OSVersion.Platform;
			global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.a(new string[]
			{
				global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.a()
			});
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002264 File Offset: 0x00000464
		private static void a(params string[] A_0)
		{
			int a_ = 4;
			short num = (short)1735983104;
			short num2 = num;
			num = (short)1036011657;
			short num3 = num;
			num = (short)1268009097;
			switch (num3 == num)
			{
			}
			num = (short)1948844032;
			if (num != 0)
			{
			}
			num = (short)944046081;
			if (num != 0)
			{
			}
			string[] second = new string[]
			{
				global::System.Environment.GetEnvironmentVariable(global::<Module>.b("眦栨缪攬", a_)) ?? string.Empty
			};
			string value = string.Join(global::System.IO.Path.PathSeparator.ToString(), A_0.Concat(second).Distinct<string>());
			global::System.Environment.SetEnvironmentVariable(global::<Module>.b("眦栨缪攬", a_), value);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002374 File Offset: 0x00000574
		private static string a()
		{
			int a_ = 14;
			short num = (short)1106837505;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11C;
				case 1:
				{
					num = (short)1272284582;
					short num3 = num;
					num = (short)2131461542;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11C;
					default:
						num = (short)1696333825;
						if (num != 0)
						{
						}
						num = (short)417660928;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B0;
						}
						continue;
					}
					break;
				}
				case 2:
					goto IL_135;
				case 3:
					goto IL_10C;
				}
				IL_B0:
				if (!global::System.Environment.Is64BitProcess)
				{
					num = (short)967901184;
					short num4 = num;
					num = (short)143130624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1642790915;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_11C:
				num = (short)2136473602;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10C:
			string text = global::<Module>.b("ܰܲ", a_);
			goto IL_145;
			IL_135:
			text = global::<Module>.b("ȰĲ", a_);
			IL_145:
			string str = text;
			return global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location), str + global::<Module>.b("猰娲䄴欶", a_));
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000024F0 File Offset: 0x000006F0
		public static int DeflateMain_FileInterface(int mode, string speech_file, string bitstream_file)
		{
			short num;
			while (global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.b == global::System.PlatformID.Unix)
			{
				num = (short)2065505384;
				short num2 = num;
				num = (short)1028791400;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2138832897;
					if (num != 0)
					{
					}
					num = (short)149094400;
					if (num != 0)
					{
					}
					return global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.a(mode, speech_file, bitstream_file);
				}
			}
			num = (short)35258368;
			short num3 = num;
			return global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.b(mode, speech_file, bitstream_file);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000025B4 File Offset: 0x000007B4
		public static int DeflateMain_MemoryInterface(int mode, byte[] speech_stream, byte[] bitstream_stream, ref int bitstream_length)
		{
			short num;
			while (global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.b == global::System.PlatformID.Unix)
			{
				num = (short)304751469;
				short num2 = num;
				num = (short)1454842733;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2084700160;
					if (num != 0)
					{
					}
					return global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.a(mode, speech_stream, speech_stream.Length, bitstream_stream, bitstream_stream.Length, ref bitstream_length);
				}
			}
			num = (short)1983053825;
			if (num != 0)
			{
			}
			num = (short)1773797376;
			short num3 = num;
			return global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.b(mode, speech_stream, speech_stream.Length, bitstream_stream, bitstream_stream.Length, ref bitstream_length);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002684 File Offset: 0x00000884
		public static int InflateMain_FileInterface(string bitstream_file, string speech_file)
		{
			short num;
			while (global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.b == global::System.PlatformID.Unix)
			{
				num = (short)2063638745;
				short num2 = num;
				num = (short)1711513817;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1377566721;
					if (num != 0)
					{
					}
					num = (short)288948224;
					if (num != 0)
					{
					}
					return global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.a(bitstream_file, speech_file);
				}
			}
			num = (short)1764950016;
			short num3 = num;
			return global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.b(bitstream_file, speech_file);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002744 File Offset: 0x00000944
		public static int InflateMain_MemoryInterface(byte[] bitstream_stream, byte[] speech_stream, ref int speech_stream_length)
		{
			short num;
			while (global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.b == global::System.PlatformID.Unix)
			{
				num = (short)336658433;
				if (num != 0)
				{
				}
				num = (short)1996311687;
				short num2 = num;
				num = (short)1100303495;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)780992512;
					if (num != 0)
					{
					}
					return global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.a(bitstream_stream, bitstream_stream.Length, speech_stream, speech_stream.Length, ref speech_stream_length);
				}
			}
			num = (short)759431168;
			short num3 = num;
			return global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.b(bitstream_stream, bitstream_stream.Length, speech_stream, speech_stream.Length, ref speech_stream_length);
		}

		// Token: 0x04000003 RID: 3
		private const string a = "PATH";

		// Token: 0x04000004 RID: 4
		private static readonly global::System.PlatformID b;
	}
}
