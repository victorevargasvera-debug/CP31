using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using AcpCommonResources;

namespace AcpFileHandlerLib
{
	// Token: 0x02000005 RID: 5
	public abstract class AcpFileDialog
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00003798 File Offset: 0x00001998
		protected AcpFileDialog()
		{
			int a_ = 12;
			base..ctor();
			this.c = global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꫪ臬菮퇰闲鳴鯶鳸裺헼헾⼀⤂Ⰴ笆⤈ℊ⌌┎", a_);
			this.d = string.Empty;
			this.e = string.Empty;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000037E0 File Offset: 0x000019E0
		// (set) Token: 0x06000020 RID: 32 RVA: 0x0000388C File Offset: 0x00001A8C
		public string Filter
		{
			get
			{
				short num = (short)1919726122;
				short num2 = num;
				num = (short)832811562;
				switch (num2 == num)
				{
				}
				num = (short)908525568;
				short num3 = num;
				num = (short)1485373440;
				if (num != 0)
				{
				}
				num = (short)2128478209;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)994549279;
				short num2 = num;
				num = (short)2032508447;
				switch (num2 == num)
				{
				}
				num = (short)1942487040;
				short num3 = num;
				num = (short)2021851136;
				if (num != 0)
				{
				}
				num = (short)1156710401;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000393C File Offset: 0x00001B3C
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000039EC File Offset: 0x00001BEC
		public string FileName
		{
			get
			{
				short num = (short)790645729;
				short num2 = num;
				num = (short)1791642593;
				switch (num2 == num)
				{
				}
				num = (short)1763639296;
				short num3 = num;
				num = (short)28704768;
				if (num != 0)
				{
				}
				num = (short)976027649;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)504910077;
				short num2 = num;
				num = (short)1909543165;
				switch (num2 == num)
				{
				}
				num = (short)1120141312;
				short num3 = num;
				num = (short)1651834881;
				if (num != 0)
				{
				}
				num = (short)519962624;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003AA4 File Offset: 0x00001CA4
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00003B50 File Offset: 0x00001D50
		public string DefaultExt
		{
			get
			{
				short num = (short)36145679;
				short num2 = num;
				num = (short)461146639;
				switch (num2 == num)
				{
				}
				num = (short)72220672;
				short num3 = num;
				num = (short)1485045761;
				if (num != 0)
				{
				}
				num = (short)1873674240;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1219951438;
				short num2 = num;
				num = (short)806222670;
				switch (num2 == num)
				{
				}
				num = (short)2056585216;
				short num3 = num;
				num = (short)157220865;
				if (num != 0)
				{
				}
				num = (short)995229696;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003C00 File Offset: 0x00001E00
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00003CB0 File Offset: 0x00001EB0
		public static string InitialDirectory
		{
			get
			{
				short num = (short)855475469;
				short num2 = num;
				num = (short)464094477;
				switch (num2 == num)
				{
				}
				num = (short)1319567360;
				short num3 = num;
				num = (short)1532952577;
				if (num != 0)
				{
				}
				num = (short)1750859776;
				if (num != 0)
				{
				}
				return global::AcpFileHandlerLib.AcpFileDialog.f;
			}
			set
			{
				short num = (short)608679724;
				short num2 = num;
				num = (short)665106220;
				switch (num2 == num)
				{
				}
				num = (short)1794506752;
				short num3 = num;
				num = (short)366280705;
				if (num != 0)
				{
				}
				num = (short)568786944;
				if (num != 0)
				{
				}
				global::AcpFileHandlerLib.AcpFileDialog.f = value;
			}
		}

		// Token: 0x06000027 RID: 39
		[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode = true)]
		public abstract bool? ShowDialog(global::AcpFileHandlerLib.AcpFileHeader fileHeader);

		// Token: 0x06000028 RID: 40
		[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode = true)]
		public abstract bool? ShowDialog(global::AcpFileHandlerLib.AcpFileHeader fileHeader, global::System.Windows.Window owner);

		// Token: 0x06000029 RID: 41
		public abstract bool? ShowDialog();

		// Token: 0x0600002A RID: 42
		public abstract bool? ShowDialog(global::System.Windows.Window owner);

		// Token: 0x0600002B RID: 43 RVA: 0x00003D60 File Offset: 0x00001F60
		[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode = true)]
		protected global::System.IntPtr HookProc(global::System.IntPtr hdlg, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam)
		{
			short num = (short)673906688;
			switch (num)
			{
			default:
			{
				num = (short)141754379;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpFileHandlerLib.o o;
					global::System.Drawing.Size size;
					int num5;
					int num7;
					int num9;
					global::System.IntPtr parent;
					int a_;
					int a_2;
					switch (num2)
					{
					case 0:
						goto IL_15F;
					case 1:
						if (this.i == global::AcpFileHandlerLib.b.a)
						{
							num = (short)2072641561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BD;
					case 2:
						goto IL_101;
					case 3:
						this.a.k(this.h);
						num = (short)1246494722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(32767);
						global::AcpFileHandlerLib.j.SendMessage(global::AcpFileHandlerLib.j.GetParent(hdlg), 1125U, new global::System.IntPtr(32767), stringBuilder);
						this.a.k(ref this.h, stringBuilder.ToString());
						num = (short)1917714432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						int num3 = o.c - o.a;
						size = this.a.Size;
						if (num3 < size.Width)
						{
							num = (short)1182859280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)421330961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						uint num4;
						if (num4 == 4294966694U)
						{
							num = (short)359268364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BD;
					}
					case 7:
					{
						if (msg != 78)
						{
							num = (short)1622999055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num4 = ((global::AcpFileHandlerLib.n)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::AcpFileHandlerLib.n))).a.c;
						goto IL_186;
					}
					case 8:
						if (this.i == global::AcpFileHandlerLib.b.a)
						{
							num = (short)684589059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BD;
					case 9:
						num = (short)98697223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num5 = 0;
						goto IL_202;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_B2;
						}
						continue;
					case 12:
					{
						num = (short)237764608;
						short num6 = num;
						num = (short)1718681614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num7 = size.Width;
						goto IL_5FE;
					case 14:
						if (this.i == global::AcpFileHandlerLib.b.b)
						{
							num = (short)1677721604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BD;
					case 15:
						num = (short)577110036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						num = (short)1243360419;
						short num8 = num;
						num = (short)1735928995;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_186;
						default:
							num = (short)975568896;
							if (num != 0)
							{
							}
							size = this.a.Size;
							num = (short)185008141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 17:
						num7 = o.c - o.a;
						goto IL_5FE;
					case 18:
						goto IL_3D2;
					case 19:
						num = (short)795672582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (msg == 272)
						{
							num = (short)2000945175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BD;
					case 21:
						num = (short)1313144833;
						if (num != 0)
						{
						}
						if (this.a.Width >= num9)
						{
							num = (short)1158545434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)127729686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num5 = global::System.Math.Abs((o.c - o.a - this.a.Width) / 2);
						goto IL_202;
					case 23:
					{
						this.a = new global::AcpFileHandlerLib.i(this.i);
						this.a.t(global::AcpCommonResources.AcpResources.Model_Number);
						this.a.p(global::AcpCommonResources.AcpResources.Serial_Number);
						this.a.q(global::AcpCommonResources.AcpResources.Flash_Code);
						this.a.r(global::AcpCommonResources.AcpResources.Version_Number);
						this.a.s(global::AcpCommonResources.AcpResources.File_Information);
						global::System.Drawing.Rectangle bounds = this.g.Bounds;
						o = default(global::AcpFileHandlerLib.o);
						parent = global::AcpFileHandlerLib.j.GetParent(hdlg);
						global::AcpFileHandlerLib.j.GetWindowRect(parent, ref o);
						a_ = (bounds.Right + bounds.Left - (o.c - o.a)) / 2;
						a_2 = (bounds.Bottom + bounds.Top - (o.d + this.a.Height - o.b)) / 2;
						num = (short)242941957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						uint num4;
						if (num4 != 4294966690U)
						{
							num = (short)1428553747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)240254977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						this.h.FileInfo = this.a.l();
						num = (short)1335296018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)1971453962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B2:
					if (msg != 2)
					{
						num = (short)466026505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_186:
					num = (short)2114912280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_202:
					int x = num5;
					this.a.Location = new global::System.Drawing.Point(x, o.d - o.b - 30);
					num = (short)277807112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FE:
					num9 = num7;
					int num10 = o.d - o.b;
					size = this.a.Size;
					int a_3 = num10 + size.Height + 15;
					global::AcpFileHandlerLib.j.SetWindowPos(parent, global::System.IntPtr.Zero, a_, a_2, num9, a_3, global::AcpFileHandlerLib.c.c);
					global::AcpFileHandlerLib.j.SetParent(this.a.Handle, parent);
					num = (short)869269525;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_101:
				IL_15F:
				IL_3D2:
				IL_6BD:
				return global::System.IntPtr.Zero;
			}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004430 File Offset: 0x00002630
		// Note: this type is marked as 'beforefieldinit'.
		static AcpFileDialog()
		{
			short num = (short)353206391;
			short num2 = num;
			num = (short)1377009783;
			switch (num2 == num)
			{
			}
			num = (short)1867186176;
			short num3 = num;
			num = (short)1813315584;
			if (num != 0)
			{
			}
			num = (short)99155969;
			if (num != 0)
			{
			}
			global::AcpFileHandlerLib.AcpFileDialog.f = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
		}

		// Token: 0x04000008 RID: 8
		private global::AcpFileHandlerLib.i a;

		// Token: 0x04000009 RID: 9
		internal const int b = 32767;

		// Token: 0x0400000A RID: 10
		internal string c;

		// Token: 0x0400000B RID: 11
		internal string d;

		// Token: 0x0400000C RID: 12
		internal string e;

		// Token: 0x0400000D RID: 13
		internal static string f;

		// Token: 0x0400000E RID: 14
		internal global::System.Windows.Forms.Screen g;

		// Token: 0x0400000F RID: 15
		internal global::AcpFileHandlerLib.AcpFileHeader h;

		// Token: 0x04000010 RID: 16
		internal global::AcpFileHandlerLib.b i;
	}
}
