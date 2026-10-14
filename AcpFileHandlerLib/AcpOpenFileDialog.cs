using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using AcpCommonResources;
using AcpExceptionLib;
using Microsoft.Win32;

namespace AcpFileHandlerLib
{
	// Token: 0x02000009 RID: 9
	public sealed class AcpOpenFileDialog : global::AcpFileHandlerLib.AcpFileDialog
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00007FCC File Offset: 0x000061CC
		public AcpOpenFileDialog()
		{
			this.b = new string[]
			{
				string.Empty
			};
			this.c = false;
			this.i = global::AcpFileHandlerLib.b.b;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00008004 File Offset: 0x00006204
		public string[] FileNames
		{
			get
			{
				short num = (short)1409115916;
				short num2 = num;
				num = (short)1921279756;
				switch (num2 == num)
				{
				}
				num = (short)1107034112;
				if (num != 0)
				{
				}
				num = (short)171573249;
				if (num != 0)
				{
				}
				num = (short)929038336;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000080B0 File Offset: 0x000062B0
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00008160 File Offset: 0x00006360
		public bool MultiSelect
		{
			get
			{
				short num = (short)1360723969;
				if (num != 0)
				{
				}
				num = (short)1165050939;
				short num2 = num;
				num = (short)584336443;
				switch (num2 == num)
				{
				}
				num = (short)1831272448;
				if (num != 0)
				{
				}
				num = (short)638779392;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)247392048;
				short num2 = num;
				num = (short)329049904;
				switch (num2 == num)
				{
				}
				num = (short)926744576;
				if (num != 0)
				{
				}
				num = (short)1845886977;
				if (num != 0)
				{
				}
				num = (short)2141913088;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00008210 File Offset: 0x00006410
		[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode = true)]
		public override bool? ShowDialog(global::AcpFileHandlerLib.AcpFileHeader fileHeader)
		{
			short num = (short)1958878031;
			short num2 = num;
			num = (short)33626959;
			switch (num2 == num)
			{
			}
			num = (short)1942683648;
			if (num != 0)
			{
			}
			num = (short)1362952193;
			if (num != 0)
			{
			}
			num = (short)2135490560;
			short num3 = num;
			return this.ShowDialog(fileHeader, null);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000082C0 File Offset: 0x000064C0
		[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode = true)]
		public override bool? ShowDialog(global::AcpFileHandlerLib.AcpFileHeader fileHeader, global::System.Windows.Window owner)
		{
			int a_ = 15;
			short num = (short)1676738560;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				int num4;
				bool value;
				global::AcpFileHandlerLib.l l;
				for (;;)
				{
					IL_30:
					global::System.Windows.Interop.WindowInteropHelper windowInteropHelper;
					global::AcpFileHandlerLib.e e;
					switch (num2)
					{
					case 0:
						if (this.c)
						{
							num = (short)795541504;
							short num3 = num;
							num = (short)2046885890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A2;
					case 1:
						windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(owner);
						num = (short)384368648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						e |= global::AcpFileHandlerLib.e.e;
						num = (short)1350238211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_3A2;
					case 4:
					{
						if (num4 == 0)
						{
							value = false;
							num = (short)1551171590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1197270613;
						short num5 = num;
						num = (short)836429397;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_23F;
						default:
							num = (short)1601110016;
							if (num != 0)
							{
							}
							num = (short)88735758;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						fileHeader.ModelNumber = this.h.ModelNumber;
						fileHeader.SerialNumber = this.h.SerialNumber;
						fileHeader.FlashCode = this.h.FlashCode;
						fileHeader.VersionNumber = this.h.VersionNumber;
						fileHeader.FileInfo = this.h.FileInfo;
						num = (short)1320157195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1B3;
					case 7:
						num = (short)523763713;
						if (num != 0)
						{
						}
						goto IL_401;
					case 8:
						goto IL_401;
					case 9:
						goto IL_39D;
					case 10:
						if (!global::AcpFileHandlerLib.j.GetOpenFileName(ref l))
						{
							num = (short)8519692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)554237967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_367;
					case 12:
						num4 = global::AcpFileHandlerLib.j.CommDlgExtendedError();
						num = (short)1260322820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (owner != null)
						{
							num = (short)1243021313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(global::System.Windows.Application.Current.MainWindow);
						num = (short)2060255239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_23F;
					case 15:
						if (fileHeader != null)
						{
							num = (short)1548615685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_367;
					}
					goto IL_77;
					IL_367:
					this.d = l.h;
					global::AcpFileHandlerLib.AcpFileDialog.InitialDirectory = global::System.IO.Path.GetDirectoryName(this.d);
					value = true;
					num = (short)1019478025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A2:
					l.n = (int)e;
					l.s = new global::AcpFileHandlerLib.k(base.HookProc);
					num = (short)594149386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_401:
					l.b = windowInteropHelper.Handle;
					this.g = global::System.Windows.Forms.Screen.FromHandle(windowInteropHelper.Handle);
					e = (global::AcpFileHandlerLib.e)8984620;
					num = (short)1365966848;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B3:
				goto IL_4E6;
				IL_23F:
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("꣭룯귱ꟳ黵韷跹ꏻ뫽槿持栃椅漇唉䨋漍礏縑", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("귭鿯蟱飳鋵雷\uddf9裻\udefd珿樁欃焅⠇氉攋戍甏㈑笓昕紗琙㰛稝䤟䌡䠣䤥伧਩īอ", a_) + num4.ToString(), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
				IL_39D:
				IL_4E6:
				return new bool?(value);
				IL_77:
				value = false;
				this.h = new global::AcpFileHandlerLib.AcpFileHeader();
				l = default(global::AcpFileHandlerLib.l);
				l.a = global::System.Runtime.InteropServices.Marshal.SizeOf<global::AcpFileHandlerLib.l>(l);
				l.d = this.c.Replace('|', '\0') + global::AcpFileHandlerLib.AcpSaveFileDialog.b("", a_);
				l.h = this.d + new string('\0', 32767 - this.d.Length);
				l.i = l.h.Length;
				string fileName = global::System.IO.Path.GetFileName(this.d);
				l.j = fileName + new string('\0', 32767 - fileName.Length);
				l.k = l.j.Length;
				l.m = global::AcpCommonResources.AcpResources.Open;
				l.q = this.e;
				l.l = global::AcpFileHandlerLib.AcpFileDialog.f;
				num = (short)377421837;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000087BC File Offset: 0x000069BC
		public override bool? ShowDialog()
		{
			short num = (short)863053876;
			short num2 = num;
			num = (short)2051156020;
			switch (num2 == num)
			{
			}
			num = (short)539361280;
			if (num != 0)
			{
			}
			num = (short)2127560705;
			if (num != 0)
			{
			}
			num = (short)1576402944;
			short num3 = num;
			return this.ShowDialog(null);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000886C File Offset: 0x00006A6C
		public override bool? ShowDialog(global::System.Windows.Window owner)
		{
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			short num;
			int num3;
			bool value;
			for (;;)
			{
				IL_0A:
				num = (short)1821769728;
				short num2 = num;
				bool? flag;
				bool flag2;
				switch (num3)
				{
				case 0:
					goto IL_178;
				case 1:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num = (short)380633094;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26A;
				case 2:
				{
					num = (short)1985605557;
					short num4 = num;
					num = (short)1655762869;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_178;
					default:
						num = (short)2079391744;
						if (num != 0)
						{
						}
						num = (short)160759809;
						if (num != 0)
						{
						}
						goto IL_E9;
					}
					break;
				}
				case 3:
					goto IL_268;
				case 4:
					if (global::System.IO.Directory.Exists(global::AcpFileHandlerLib.AcpFileDialog.f))
					{
						num = (short)1817313285;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a.InitialDirectory = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
					num = (short)227934208;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.a.InitialDirectory = global::AcpFileHandlerLib.AcpFileDialog.f;
					num = (short)139395074;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.d = this.a.FileName;
					this.b = this.a.FileNames;
					global::AcpFileHandlerLib.AcpFileDialog.InitialDirectory = global::System.IO.Path.GetDirectoryName(this.d);
					value = true;
					num = (short)655556611;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_54;
				IL_E9:
				this.a.RestoreDirectory = true;
				flag = this.a.ShowDialog(owner);
				flag2 = true;
				num = (short)103612417;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_178:
				goto IL_E9;
			}
			IL_268:
			IL_26A:
			return new bool?(value);
			IL_54:
			value = false;
			this.a = new global::Microsoft.Win32.OpenFileDialog();
			this.a.Filter = this.c;
			this.a.DefaultExt = this.e;
			this.a.FileName = base.FileName;
			this.a.Multiselect = this.c;
			num = (short)1061748740;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04000017 RID: 23
		private global::Microsoft.Win32.OpenFileDialog a;

		// Token: 0x04000018 RID: 24
		private new string[] b;

		// Token: 0x04000019 RID: 25
		private new bool c;
	}
}
