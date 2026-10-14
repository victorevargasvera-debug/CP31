using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using Motorola.Common.Cryptography.Autofac;
using Motorola.Common.Cryptography.Exceptions;

namespace Motorola.Common.Cryptography.Configuration.PortBinding
{
	// Token: 0x0200001D RID: 29
	public class PortBindingConfiguration : global::Motorola.Common.Cryptography.Configuration.PortBinding.IPortBindingConfiguration
	{
		// Token: 0x06000041 RID: 65 RVA: 0x000046C0 File Offset: 0x000028C0
		public void SetCertificateBinding(global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, global::System.Net.IPEndPoint ep)
		{
			int a_ = 9;
			short num = (short)536824300;
			short num2 = num;
			num = (short)539445740;
			switch (num2 == num)
			{
			}
			num = (short)1441857536;
			short num3 = num;
			num = (short)695205889;
			if (num != 0)
			{
			}
			num = (short)1591607296;
			if (num != 0)
			{
			}
			this.a(ep);
			string text = this.a(ep.Address);
			this.a(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("ㅞѠᝢᙤས", a_), string.Format(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("㝞ᕠᝢᕤ䝦ࡨཪ६佮ɰrᥴᑶᱸॺॼ彾ﮈﾊ낌ꆐ꾔ꢘ붜ﲞ쒠톢톤쾦좨\ud8aa얬銮쪰膲좴鞶\ud8b8쮺춼횾ꗀﻂ뻄觊냌", a_), new object[]
			{
				text,
				ep.Port,
				certificate.Thumbprint,
				this.b
			}), false);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000047DC File Offset: 0x000029DC
		private void a(global::System.Net.IPEndPoint A_0)
		{
			int a_ = 9;
			short num = (short)753664001;
			if (num != 0)
			{
			}
			num = (short)928533560;
			short num2 = num;
			num = (short)980438072;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1289682944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)696320000;
			if (num != 0)
			{
			}
			string arg = this.a(A_0.Address);
			this.a(string.Format(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("㝞ᕠᝢᕤ䝦൨๪Ŭ੮հᙲ啴Ѷ੸᝺Ṽ᩾ꖄ麗ﮊﶎ꺒Ꞗꆚ꺞\udca0", a_), arg, A_0.Port), true);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000048C0 File Offset: 0x00002AC0
		private string a(global::System.Net.IPAddress A_0)
		{
			int a_ = 12;
			while (A_0.AddressFamily != global::System.Net.Sockets.AddressFamily.InterNetworkV6)
			{
				short num = (short)2002259059;
				short num2 = num;
				num = (short)291179635;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)335872000;
					short num3 = num;
					num = (short)456065024;
					if (num != 0)
					{
					}
					num = (short)954269697;
					if (num != 0)
					{
					}
					return A_0.ToString();
				}
				}
			}
			return string.Format(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("㥡ὣ噥ᕧ㝩", a_), A_0);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000499C File Offset: 0x00002B9C
		private void a(string A_0, bool A_1 = false)
		{
			int a_ = 4;
			short num = (short)924428262;
			short num2 = num;
			num = (short)802727910;
			switch (num2 == num)
			{
			}
			num = (short)2081816576;
			short num3 = num;
			num = (short)1645740033;
			if (num != 0)
			{
			}
			num = (short)1574436864;
			if (num != 0)
			{
			}
			this.a(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("㑙㥛⩝፟੡", a_), A_0, A_1);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004A68 File Offset: 0x00002C68
		private void a(string A_0, string A_1, bool A_2 = false)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_CD;
			}
			short num;
			int num4;
			global::System.Diagnostics.Process process;
			for (;;)
			{
				IL_13:
				num = (short)1526136832;
				short num2 = num;
				num = (short)1168959453;
				short num3 = num;
				num = (short)153544669;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_CD;
				default:
					num = (short)743112704;
					if (num != 0)
					{
					}
					num = (short)1795096577;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (process.ExitCode != 0)
						{
							num = (short)1476657153;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_166;
					case 2:
						goto IL_128;
					case 3:
						if (process == null)
						{
							num = (short)2067595266;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						process.WaitForExit((int)this.a.TotalMilliseconds);
						num = (short)2052521988;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!A_2)
						{
							num = (short)49545221;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						num = (short)1112670208;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CD;
				}
			}
			IL_128:
			throw new global::Motorola.Common.Cryptography.Exceptions.PortBindingException(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("ᥙ㵛そ๟ൡၣ䙥᭧ṩ൫ᱭѯ剱ᩳ፵ཷ婹౻౽ﮇ낉겋", a_) + A_0);
			IL_166:
			string text = process.StandardOutput.ReadToEnd() + global::System.Environment.NewLine + process.StandardError.ReadToEnd();
			text = text.Trim(new char[]
			{
				'\r',
				'\n'
			});
			throw new global::Motorola.Common.Cryptography.Exceptions.PortBindingException(string.Concat(new string[]
			{
				global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("ᥙ㵛そ๟ൡၣ䙥൧ቩ५൭կٱᅳ噵᭷ᕹᅻ፽벅ꢇ", a_),
				A_0,
				global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("穙", a_),
				A_1,
				global::System.Environment.NewLine,
				string.Format(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("Ὑ⑛㝝ᑟ䉡ݣ॥౧ཀྵ噫乭୯䉱ॳ൵䥷ݹ", a_), process.ExitCode, global::System.Environment.NewLine),
				global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("Ὑ⹛ⱝཟၡ䑣୥൧ᥩὫ཭ᝯ᝱乳噵", a_),
				text
			}));
			IL_CD:
			process = global::System.Diagnostics.Process.Start(new global::System.Diagnostics.ProcessStartInfo(A_0, A_1)
			{
				UseShellExecute = false,
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true
			});
			num = (short)783941635;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004D00 File Offset: 0x00002F00
		public PortBindingConfiguration()
		{
			int a_ = 11;
			this.a = global::System.TimeSpan.FromSeconds(30.0);
			this.b = global::System.Guid.Parse(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("᩠兢⍤剦偨奪ⱬ孮䥰干㙴䍶佸䵺偼䭾얀놂놄ꪆ놈뎊첌뚎벐ꆒ횔ꎖ궘\udf9a\ud99cꮞ醠钦馨횪", a_));
			base..ctor();
		}

		// Token: 0x0400001A RID: 26
		private readonly global::System.TimeSpan a;

		// Token: 0x0400001B RID: 27
		private readonly global::System.Guid b;
	}
}
