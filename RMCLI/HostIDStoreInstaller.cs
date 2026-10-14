using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics.CodeAnalysis;

namespace commonLicensing
{
	// Token: 0x0200000C RID: 12
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1405:ComVisibleTypeBaseTypesShouldBeComVisible")]
	[global::System.ComponentModel.RunInstaller(true)]
	public class HostIDStoreInstaller : global::System.Configuration.Install.Installer
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000093AC File Offset: 0x000075AC
		public HostIDStoreInstaller()
		{
			this.a();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000093C8 File Offset: 0x000075C8
		public override void Install(global::System.Collections.IDictionary stateSaver)
		{
			int a_ = 17;
			base.Install(stateSaver);
			string text = base.Context.Parameters[global::commonLicensing.HostIDStoreInstaller.b("튡풣쪥솧즩춫\udaad\ud9af\uddb1\udab3솷쪹\ud9bb꾿냁蟃諅蓇苉꧋ꋍꃏ럑ꛓ", a_)];
			short num;
			try
			{
				num = (short)681050116;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						global::commonLicensing.HostIDStoreEncrypt.setHostIDStoreLoc(text);
						global::commonLicensing.HostIDStoreEncrypt.createHostIDStore();
						num = (short)1960312833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_126;
					case 2:
						goto IL_124;
					case 3:
						goto IL_13F;
					case 4:
					{
						num = (short)397838714;
						short num3 = num;
						num = (short)1075546490;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_124;
						default:
							num = (short)69140480;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_B4;
							}
							continue;
						}
						break;
					}
					}
					IL_B4:
					if (text != null)
					{
						num = (short)74448896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					base.Context.LogMessage(global::commonLicensing.HostIDStoreInstaller.b("튡풣쪥솧즩춫\udaad\ud9af\uddb1\udab3隵쎹첻\udbbd鋁ꗃ듅꧇Ꟊ꧋뫍뗏ꃑ닕럗뿙꿛ﻝ軟跡郣웥迧迩飫컭胯鏱蟳藵鷷黹\udcfb韽滿∁戃琅朇有Ⰻ服縏愑怓眕琗瘙㈛", a_));
					num = (short)1649934338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_126:
					num = (short)703791107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_124:
					goto IL_126;
				}
				IL_13F:;
			}
			catch
			{
			}
			num = (short)976420864;
			short num4 = num;
			num = (short)1998651393;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00009588 File Offset: 0x00007788
		public override void Commit(global::System.Collections.IDictionary savedState)
		{
			short num = (short)1403703280;
			short num2 = num;
			num = (short)1302253552;
			switch (num2 == num)
			{
			default:
			{
				num = (short)159383552;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2115043329;
			if (num != 0)
			{
			}
			num = (short)1857552384;
			if (num != 0)
			{
			}
			base.Commit(savedState);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00009638 File Offset: 0x00007838
		public override void Rollback(global::System.Collections.IDictionary savedState)
		{
			short num = (short)1174780356;
			short num2 = num;
			num = (short)1421392324;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1914568704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)441253889;
			if (num != 0)
			{
			}
			num = (short)587333632;
			if (num != 0)
			{
			}
			base.Rollback(savedState);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000096EC File Offset: 0x000078EC
		public override void Uninstall(global::System.Collections.IDictionary savedState)
		{
			short num = (short)384498779;
			short num2 = num;
			num = (short)1187707995;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1672609792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)941359105;
			if (num != 0)
			{
			}
			num = (short)604176384;
			if (num != 0)
			{
			}
			base.Uninstall(savedState);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000979C File Offset: 0x0000799C
		protected override void Dispose(bool disposing)
		{
			short num = (short)1315110916;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)680656898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_EA;
				case 2:
					if (this.a != null)
					{
						goto IL_10C;
					}
					goto IL_150;
				case 3:
				{
					num = (short)1574633473;
					if (num != 0)
					{
					}
					this.a.Dispose();
					num = (short)1055522816;
					short num3 = num;
					num = (short)951713793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)1380548302;
					short num4 = num;
					num = (short)554794702;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10C;
					default:
						num = (short)1536622592;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					}
					break;
				}
				}
				IL_84:
				if (disposing)
				{
					num = (short)1901002752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_10C:
				num = (short)1839857667;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EA:
			IL_150:
			base.Dispose(disposing);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00009900 File Offset: 0x00007B00
		private void a()
		{
			short num = (short)1128022218;
			short num2 = num;
			num = (short)627785930;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1318584320;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1635713025;
			if (num != 0)
			{
			}
			num = (short)1460273152;
			if (num != 0)
			{
			}
			this.a = new global::System.ComponentModel.Container();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000099B4 File Offset: 0x00007BB4
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(2009663748 + A_1) + (global::System.IntPtr)43 + (global::System.IntPtr)2 + (global::System.IntPtr)93);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
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
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x04000033 RID: 51
		private global::System.ComponentModel.IContainer a;
	}
}
