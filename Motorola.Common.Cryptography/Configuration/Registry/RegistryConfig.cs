using System;
using System.Runtime.CompilerServices;
using Microsoft.Win32;
using Motorola.Common.Cryptography.Autofac;

namespace Motorola.Common.Cryptography.Configuration.Registry
{
	// Token: 0x0200002E RID: 46
	public class RegistryConfig : global::Motorola.Common.Cryptography.Configuration.Registry.IRegistryConfig
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00006850 File Offset: 0x00004A50
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000693C File Offset: 0x00004B3C
		public global::Motorola.Common.Cryptography.CertificateType? SelectedCertificateType
		{
			get
			{
				int a_ = 0;
				string text = this.b<string>(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("ᕕ㵗⡙⡛㝝ٟୡݣݥᱧཀྵ㡫᝭o᝱", a_));
				if (string.IsNullOrEmpty(text))
				{
					short num = (short)1452240157;
					short num2 = num;
					num = (short)127560989;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_28;
					case 1:
						break;
					default:
					{
						num = (short)1201537024;
						short num3 = num;
						break;
					}
					}
					num = (short)1852964865;
					if (num != 0)
					{
					}
					num = (short)634912768;
					if (num != 0)
					{
					}
					return null;
				}
				IL_28:
				return new global::Motorola.Common.Cryptography.CertificateType?(this.d[text]);
			}
			set
			{
				int a_ = 3;
				if (value != null)
				{
					short num = (short)956809478;
					short num2 = num;
					num = (short)1657127174;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					case 1:
						break;
					default:
					{
						num = (short)805765120;
						short num3 = num;
						break;
					}
					}
					num = (short)1695744000;
					if (num != 0)
					{
					}
					num = (short)1280835585;
					if (num != 0)
					{
					}
					string a_2 = this.d.b(value.Value);
					this.a<string>(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("ᩘ㹚⽜⭞ࡠբ౤ѦࡨὪ࡬㭮ࡰͲၴ", a_), a_2);
					return;
				}
				IL_14:
				this.a(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("ᩘ㹚⽜⭞ࡠբ౤ѦࡨὪ࡬㭮ࡰͲၴ", a_));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00006A38 File Offset: 0x00004C38
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00006B24 File Offset: 0x00004D24
		public bool? WereSha1CertificatesRemoved
		{
			get
			{
				int a_ = 10;
				int? num = this.b<int?>(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("㍟⩡╣坥⭧ཀྵṫᩭ᥯ᑱᵳᕵ᥷๹᥻ൽ퉿ﺇ", a_));
				if (num != null)
				{
					short num2 = (short)261685249;
					if (num2 != 0)
					{
					}
				}
				else
				{
					short num2 = (short)985923584;
					short num3 = num2;
					num2 = (short)1982434829;
					short num4 = num2;
					num2 = (short)2002357773;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1236336640;
						if (num2 != 0)
						{
						}
						return null;
					}
				}
				return new bool?(num.Value != 0);
			}
			set
			{
				int a_ = 7;
				short num = (short)1308884993;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!value.Value)
						{
							num = (short)814415874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)591003652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 2:
						num = (short)1791426563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_7A;
					case 4:
						goto IL_185;
					case 5:
					{
						num = (short)743151096;
						short num3 = num;
						num = (short)1025086968;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_F0;
						}
						break;
					}
					}
					IL_45:
					if (value == null)
					{
						num = (short)1920991237;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1635713024;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_7A:
				int num4 = 0;
				goto IL_188;
				IL_F0:
				num = (short)481886208;
				short num5 = num;
				num = (short)1983774721;
				if (num != 0)
				{
				}
				num = (short)1428750336;
				if (num != 0)
				{
				}
				this.a(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("๜᝞⁠剢♤ɦ᭨ὪѬ८ᡰၲᑴͶᱸࡺ⽼᩾", a_));
				return;
				IL_185:
				num4 = 1;
				IL_188:
				int a_2 = num4;
				this.a<int>(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("๜᝞⁠剢♤ɦ᭨ὪѬ८ᡰၲᑴͶᱸࡺ⽼᩾", a_), a_2);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00006CD0 File Offset: 0x00004ED0
		private a b<a>(string A_0)
		{
			short num = (short)628118719;
			short num2 = num;
			num = (short)2038060223;
			switch (num2 == num)
			{
			}
			num = (short)927006720;
			short num3 = num;
			num = (short)1764818945;
			if (num != 0)
			{
			}
			num = (short)348454912;
			if (num != 0)
			{
			}
			global::Motorola.Common.Cryptography.Configuration.Registry.RegistryConfig<a>.a a = new global::Motorola.Common.Cryptography.Configuration.Registry.RegistryConfig<a>.a();
			a.b = A_0;
			a.a = default(a);
			this.WithCpsSubkey(new global::System.Action<global::Microsoft.Win32.RegistryKey>(a.c), false);
			return a.a;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00006DAC File Offset: 0x00004FAC
		private void a(string A_0)
		{
			short num = (short)1931147837;
			short num2 = num;
			num = (short)759822909;
			switch (num2 == num)
			{
			}
			num = (short)960561152;
			short num3 = num;
			num = (short)1286995969;
			if (num != 0)
			{
			}
			num = (short)1359544320;
			if (num != 0)
			{
			}
			global::Motorola.Common.Cryptography.Configuration.Registry.RegistryConfig.b b = new global::Motorola.Common.Cryptography.Configuration.Registry.RegistryConfig.b();
			b.a = A_0;
			this.WithCpsSubkey(new global::System.Action<global::Microsoft.Win32.RegistryKey>(b.b), true);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00006E74 File Offset: 0x00005074
		private void a<a>(string A_0, a A_1)
		{
			short num = (short)310694285;
			short num2 = num;
			num = (short)1242878349;
			switch (num2 == num)
			{
			}
			num = (short)64028672;
			short num3 = num;
			num = (short)1886388225;
			if (num != 0)
			{
			}
			num = (short)1444085760;
			if (num != 0)
			{
			}
			global::Motorola.Common.Cryptography.Configuration.Registry.RegistryConfig<a>.c c = new global::Motorola.Common.Cryptography.Configuration.Registry.RegistryConfig<a>.c();
			c.a = A_0;
			c.b = A_1;
			this.WithCpsSubkey(new global::System.Action<global::Microsoft.Win32.RegistryKey>(c.c), true);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00006F44 File Offset: 0x00005144
		public void WithCpsSubkey(global::System.Action<global::Microsoft.Win32.RegistryKey> action, bool writable = false)
		{
			int a_ = 12;
			short num = (short)1827340289;
			if (num != 0)
			{
			}
			num = (short)2038497280;
			short num2 = num;
			global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.RegistryKey.OpenBaseKey(global::Microsoft.Win32.RegistryHive.LocalMachine, global::Microsoft.Win32.RegistryView.Registry32);
			try
			{
				global::Microsoft.Win32.RegistryKey registryKey2 = registryKey.OpenSubKey(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("ㅡ⭣⁥㱧㵩⵫㱭㕯⹱㥳᥵౷ᕹ๻ᅽ\ud883얅ﺏ톑쒓얕", a_), writable);
				try
				{
					action(registryKey2);
				}
				finally
				{
					num = (short)1573912578;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							num = (short)668389830;
							short num4 = num;
							num = (short)890556870;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)938344448;
								if (num != 0)
								{
								}
								((global::System.IDisposable)registryKey2).Dispose();
								break;
							}
							num = (short)2034040833;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_146;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_C0;
							}
							continue;
						}
						IL_C0:
						if (registryKey2 == null)
						{
							break;
						}
						num = (short)1648951296;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_146:;
				}
			}
			finally
			{
				num = (short)726401026;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						((global::System.IDisposable)registryKey).Dispose();
						num = (short)690814977;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1AF;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_179;
						}
						continue;
					}
					IL_179:
					if (registryKey == null)
					{
						break;
					}
					num = (short)835584000;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1AF:;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00007120 File Offset: 0x00005320
		public RegistryConfig()
		{
			int a_ = 1;
			this.d = new global::Motorola.Common.Cryptography.Configuration.Registry.a<string, global::Motorola.Common.Cryptography.CertificateType>
			{
				{
					global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("іᅘᩚ汜", a_),
					global::Motorola.Common.Cryptography.CertificateType.Sha1Rsa
				},
				{
					global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("іᅘᩚ潜橞坠", a_),
					global::Motorola.Common.Cryptography.CertificateType.Sha256Rsa
				}
			};
			base..ctor();
		}

		// Token: 0x04000029 RID: 41
		private const string a = "SOFTWARE\\Motorola\\CommonCPS";

		// Token: 0x0400002A RID: 42
		private const string b = "CertificateType";

		// Token: 0x0400002B RID: 43
		private const string c = "SHA1CertificatesRemoved";

		// Token: 0x0400002C RID: 44
		private readonly global::Motorola.Common.Cryptography.Configuration.Registry.a<string, global::Motorola.Common.Cryptography.CertificateType> d;

		// Token: 0x0200002F RID: 47
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a<a>
		{
			// Token: 0x06000085 RID: 133 RVA: 0x00007188 File Offset: 0x00005388
			internal void c(global::Microsoft.Win32.RegistryKey A_0)
			{
				short num = (short)36962305;
				if (num != 0)
				{
				}
				num = (short)1461224126;
				short num2 = num;
				num = (short)1361871550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)541261824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)593362944;
				if (num != 0)
				{
				}
				this.a = (a)((object)((A_0 != null) ? A_0.GetValue(this.b) : null));
			}

			// Token: 0x0400002D RID: 45
			public a a;

			// Token: 0x0400002E RID: 46
			public string b;
		}

		// Token: 0x02000030 RID: 48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x06000087 RID: 135 RVA: 0x00007268 File Offset: 0x00005468
			internal void b(global::Microsoft.Win32.RegistryKey A_0)
			{
				short num = (short)1439477295;
				short num2 = num;
				num = (short)696823343;
				switch (num2 == num)
				{
				}
				num = (short)213647360;
				short num3 = num;
				num = (short)2119499777;
				if (num != 0)
				{
				}
				num = (short)119734272;
				if (num != 0)
				{
				}
				A_0.DeleteValue(this.a, false);
			}

			// Token: 0x0400002F RID: 47
			public string a;
		}

		// Token: 0x02000031 RID: 49
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c<a>
		{
			// Token: 0x06000089 RID: 137 RVA: 0x00007330 File Offset: 0x00005530
			internal void c(global::Microsoft.Win32.RegistryKey A_0)
			{
				short num = (short)671219714;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)195695559;
						short num3 = num;
						num = (short)977736647;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)243728385;
							if (num != 0)
							{
							}
							num = (short)2126970880;
							if (num != 0)
							{
							}
							A_0.SetValue(this.a, this.b);
							break;
						}
						num = (short)1850736640;
						short num4 = num;
						num = (short)735838209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (A_0 == null)
					{
						break;
					}
					num = (short)1952120832;
					num2 = (int)((global::System.IntPtr)num);
				}
			}

			// Token: 0x04000030 RID: 48
			public string a;

			// Token: 0x04000031 RID: 49
			public a b;
		}
	}
}
