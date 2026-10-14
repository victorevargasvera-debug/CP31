using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using AcpCommonLib;
using AcpExceptionLib;

namespace AcpFileHandlerLib
{
	// Token: 0x02000012 RID: 18
	internal class i : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00009A08 File Offset: 0x00007C08
		public i(global::AcpFileHandlerLib.b A_0)
		{
			int a_ = 16;
			base..ctor();
			this.k();
			this.a = new global::AcpFileHandlerLib.AcpFileHandler();
			if (A_0 == global::AcpFileHandlerLib.b.b)
			{
				this.m.ReadOnly = true;
			}
			else if (A_0 == global::AcpFileHandlerLib.b.a)
			{
				this.m.Enabled = true;
			}
			if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
			{
				this.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
				if (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName == global::AcpFileHandlerLib.AcpSaveFileDialog.b("軮菰", a_))
				{
					global::System.Threading.Thread.CurrentThread.CurrentUICulture.NumberFormat.DigitSubstitution = global::System.Globalization.DigitShapes.None;
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00009AB8 File Offset: 0x00007CB8
		public string l()
		{
			short num = (short)1303007256;
			short num2 = num;
			num = (short)560353304;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2091515904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1961033728;
			if (num != 0)
			{
			}
			num = (short)1358954497;
			if (num != 0)
			{
			}
			return this.m.Text;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00009B6C File Offset: 0x00007D6C
		public void k(string A_0)
		{
			short num = (short)2064971463;
			short num2 = num;
			num = (short)711259847;
			switch (num2 == num)
			{
			default:
			{
				num = (short)854327296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1719926785;
			if (num != 0)
			{
			}
			num = (short)1115160576;
			if (num != 0)
			{
			}
			this.m.Text = A_0;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00009C20 File Offset: 0x00007E20
		public void l(string A_0)
		{
			short num = (short)421742248;
			short num2 = num;
			num = (short)754927272;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1794572288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)129171457;
			if (num != 0)
			{
			}
			num = (short)1573453824;
			if (num != 0)
			{
			}
			this.g.Text = A_0;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00009CD8 File Offset: 0x00007ED8
		public void m(string A_0)
		{
			short num = (short)1861812225;
			if (num != 0)
			{
			}
			num = (short)1594621952;
			short num2 = num;
			num = (short)696601434;
			short num3 = num;
			num = (short)1568492378;
			switch (num3 == num)
			{
			}
			num = (short)1677262848;
			if (num != 0)
			{
			}
			this.h.Text = A_0;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00009D90 File Offset: 0x00007F90
		public void n(string A_0)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2139272470;
					short num3 = num2;
					num2 = (short)1093842198;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_15E;
					}
					break;
				}
				case 1:
					if (!text.StartsWith(global::AcpFileHandlerLib.AcpSaveFileDialog.b("藬諮", a_)))
					{
						num2 = (short)540409856;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_178;
				case 2:
					num2 = (short)20119553;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!text.StartsWith(global::AcpFileHandlerLib.AcpSaveFileDialog.b("賬鷮", a_)))
					{
						num2 = (short)994377729;
						if (num2 != 0)
						{
						}
						num2 = (short)1555890178;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_178;
				}
				goto IL_29;
			}
			IL_15E:
			num2 = (short)1423048704;
			if (num2 != 0)
			{
			}
			this.i.Text = A_0;
			return;
			IL_178:
			this.i.Text = global::AcpCommonLib.Utility.reverseConverter(A_0);
			return;
			IL_29:
			num2 = (short)1263992832;
			short num4 = num2;
			text = global::System.Threading.Thread.CurrentThread.CurrentCulture.Name.ToLower();
			num2 = (short)853016579;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00009F28 File Offset: 0x00008128
		public void o(string A_0)
		{
			short num = (short)630456321;
			if (num != 0)
			{
			}
			num = (short)1132396544;
			short num2 = num;
			num = (short)1346802802;
			short num3 = num;
			num = (short)1567986802;
			switch (num3 == num)
			{
			}
			num = (short)1417740288;
			if (num != 0)
			{
			}
			this.j.Text = A_0;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00009FE4 File Offset: 0x000081E4
		public void p(string A_0)
		{
			short num = (short)2149752;
			short num2 = num;
			num = (short)577621368;
			switch (num2 == num)
			{
			default:
			{
				num = (short)291962880;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)520290304;
			if (num != 0)
			{
			}
			num = (short)910032897;
			if (num != 0)
			{
			}
			this.c.Text = A_0;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000A09C File Offset: 0x0000829C
		public void q(string A_0)
		{
			short num = (short)571489026;
			short num2 = num;
			num = (short)1923562242;
			switch (num2 == num)
			{
			default:
			{
				num = (short)397541376;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)981401600;
			if (num != 0)
			{
			}
			num = (short)949223425;
			if (num != 0)
			{
			}
			this.d.Text = A_0;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000A154 File Offset: 0x00008354
		public void r(string A_0)
		{
			short num = (short)1274978512;
			short num2 = num;
			num = (short)1025482960;
			switch (num2 == num)
			{
			default:
			{
				num = (short)451870720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)759169025;
			if (num != 0)
			{
			}
			num = (short)469630976;
			if (num != 0)
			{
			}
			this.e.Text = A_0;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000A20C File Offset: 0x0000840C
		public void s(string A_0)
		{
			short num = (short)1724860113;
			short num2 = num;
			num = (short)30688977;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1183711232;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)364183553;
			if (num != 0)
			{
			}
			num = (short)2078015488;
			if (num != 0)
			{
			}
			this.f.Text = A_0;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000A2C4 File Offset: 0x000084C4
		public void t(string A_0)
		{
			short num = (short)1086413760;
			short num2 = num;
			num = (short)2138790848;
			switch (num2 == num)
			{
			default:
			{
				num = (short)944570368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)145948673;
			if (num != 0)
			{
			}
			num = (short)1031143424;
			if (num != 0)
			{
			}
			this.k.Text = A_0;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000A378 File Offset: 0x00008578
		public void k(ref global::AcpFileHandlerLib.AcpFileHeader A_0, string A_1)
		{
			short num = (short)370868226;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E2;
				case 1:
					goto IL_97;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)1102519427;
				short num3 = num;
				num = (short)1988304003;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1425866752;
					if (num != 0)
					{
					}
					if (global::System.IO.File.Exists(A_1))
					{
						num = (short)424935425;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1160445952;
						short num4 = num;
						this.m();
						num = (short)880934912;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_97:
			try
			{
				A_0 = this.a.ReadHeader(A_1);
				this.k(A_0);
			}
			catch (global::AcpExceptionLib.AcpException)
			{
				this.m();
			}
			return;
			IL_E2:
			num = (short)1162084353;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000A4C4 File Offset: 0x000086C4
		internal void k(global::AcpFileHandlerLib.AcpFileHeader A_0)
		{
			short num = (short)1097203713;
			if (num != 0)
			{
			}
			num = (short)1953103872;
			short num2 = num;
			num = (short)2044424689;
			short num3 = num;
			num = (short)872903153;
			switch (num3 == num)
			{
			}
			num = (short)394788864;
			if (num != 0)
			{
			}
			this.l(A_0.ModelNumber);
			this.m(A_0.SerialNumber);
			this.n(A_0.FlashCode);
			this.o(A_0.VersionNumber);
			this.k(A_0.FileInfo);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000A5A8 File Offset: 0x000087A8
		internal void m()
		{
			short num = (short)1779330177;
			short num2 = num;
			num = (short)1019833473;
			switch (num2 == num)
			{
			default:
			{
				num = (short)599654400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1763442689;
			if (num != 0)
			{
			}
			num = (short)769064960;
			if (num != 0)
			{
			}
			this.l(string.Empty);
			this.m(string.Empty);
			this.n(string.Empty);
			this.o(string.Empty);
			this.k(string.Empty);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000A688 File Offset: 0x00008888
		protected override void Dispose(bool disposing)
		{
			short num = (short)1090387972;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1821573121;
					if (num != 0)
					{
					}
					num = (short)689194886;
					short num3 = num;
					num = (short)884688774;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14C;
					default:
						num = (short)109903872;
						if (num != 0)
						{
						}
						num = (short)787939330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_14C;
				case 2:
					if (this.b != null)
					{
						num = (short)282853377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_151;
				case 3:
					goto IL_C5;
				case 4:
				{
					num = (short)1009123328;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				}
				}
				IL_64:
				if (disposing)
				{
					num = (short)806748160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_14C:
				this.b.Dispose();
				num = (short)293011459;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C5:
			IL_151:
			base.Dispose(disposing);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000A7F0 File Offset: 0x000089F0
		private void k()
		{
			int a_ = 4;
			short num = (short)260577948;
			short num2 = num;
			num = (short)1483741852;
			switch (num2 == num)
			{
			}
			num = (short)513081344;
			if (num != 0)
			{
			}
			num = (short)1520566272;
			short num3 = num;
			num = (short)1959526401;
			if (num != 0)
			{
			}
			this.c = new global::System.Windows.Forms.Label();
			this.d = new global::System.Windows.Forms.Label();
			this.e = new global::System.Windows.Forms.Label();
			this.f = new global::System.Windows.Forms.Label();
			this.g = new global::System.Windows.Forms.TextBox();
			this.h = new global::System.Windows.Forms.TextBox();
			this.i = new global::System.Windows.Forms.TextBox();
			this.j = new global::System.Windows.Forms.TextBox();
			this.k = new global::System.Windows.Forms.Label();
			this.l = new global::System.Windows.Forms.Panel();
			this.n = new global::System.Windows.Forms.TableLayoutPanel();
			this.m = new global::System.Windows.Forms.TextBox();
			this.o = new global::System.Windows.Forms.TableLayoutPanel();
			this.l.SuspendLayout();
			this.n.SuspendLayout();
			this.o.SuspendLayout();
			base.SuspendLayout();
			this.c.AutoSize = true;
			this.c.Location = new global::System.Drawing.Point(256, 0);
			this.c.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("郢胤闦胨諪臬ꇮ蓰黲韴鋶诸럺鳼鷾搀漂", a_);
			this.c.Size = new global::System.Drawing.Size(79, 13);
			this.c.TabIndex = 1;
			this.c.Text = global::AcpFileHandlerLib.AcpSaveFileDialog.b("냢胤闦胨諪臬냮뿰蛲飴闶鳸觺쟼", a_);
			this.d.AutoSize = true;
			this.d.Location = new global::System.Drawing.Point(3, 29);
			this.d.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("藢觤蛦髨菪껬胮闰雲맴零鯸黺釼", a_);
			this.d.Size = new global::System.Drawing.Size(66, 13);
			this.d.TabIndex = 2;
			this.d.Text = global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꗢ觤蛦髨菪달곮黰韲郴췶", a_);
			this.e.AutoSize = true;
			this.e.Location = new global::System.Drawing.Point(256, 29);
			this.e.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("闢胤闦髨苪苬臮뿰蛲飴闶鳸觺뇼黾挀昂椄", a_);
			this.e.Size = new global::System.Drawing.Size(88, 13);
			this.e.TabIndex = 3;
			this.e.Text = global::AcpFileHandlerLib.AcpSaveFileDialog.b("뗢胤闦髨苪苬臮껰뷲胴髶鯸黺迼엾", a_);
			this.f.AutoSize = true;
			this.f.Location = new global::System.Drawing.Point(3, 0);
			this.f.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("藢賤详賨ꋪ菬觮黰臲飴零跸鋺鋼釾䴀戂朄戆攈", a_);
			this.f.Size = new global::System.Drawing.Size(84, 13);
			this.f.TabIndex = 4;
			this.f.Text = global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꗢ賤详賨듪ꓬ臮韰鳲蟴髶飸迺铼郾漀㤂", a_);
			this.g.Enabled = false;
			this.g.Location = new global::System.Drawing.Point(106, 3);
			this.g.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("転諤菦賨蟪ꏬ髮鳰釲郴藶그菺觼뷾渀笂", a_);
			this.g.Size = new global::System.Drawing.Size(142, 20);
			this.g.TabIndex = 5;
			this.h.Enabled = false;
			this.h.Location = new global::System.Drawing.Point(356, 3);
			this.h.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("郢胤闦胨諪臬ꇮ蓰黲韴鋶诸꿺藼课䌀氂約", a_);
			this.h.Size = new global::System.Drawing.Size(142, 20);
			this.h.TabIndex = 6;
			this.i.Enabled = false;
			this.i.Location = new global::System.Drawing.Point(106, 32);
			this.i.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("藢觤蛦髨菪껬胮闰雲ꇴ迶跸맺鋼蟾", a_);
			this.i.Size = new global::System.Drawing.Size(142, 20);
			this.i.TabIndex = 7;
			this.j.Enabled = false;
			this.j.Location = new global::System.Drawing.Point(356, 32);
			this.j.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("闢胤闦髨苪苬臮뿰蛲飴闶鳸觺ꧼ蟾甀䄂樄缆", a_);
			this.j.Size = new global::System.Drawing.Size(142, 20);
			this.j.TabIndex = 8;
			this.k.AutoSize = true;
			this.k.Location = new global::System.Drawing.Point(3, 0);
			this.k.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("転諤菦賨蟪ꏬ髮鳰釲郴藶뗸髺鿼髾洀", a_);
			this.k.Size = new global::System.Drawing.Size(82, 13);
			this.k.TabIndex = 0;
			this.k.Text = global::AcpFileHandlerLib.AcpSaveFileDialog.b("껢諤菦賨蟪달ꇮ蓰黲韴鋶诸쇺", a_);
			this.l.Controls.Add(this.n);
			this.l.Controls.Add(this.o);
			this.l.Location = new global::System.Drawing.Point(0, 0);
			this.l.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("鏢蓤触賨蟪\udcec", a_);
			this.l.Size = new global::System.Drawing.Size(512, 142);
			this.l.TabIndex = 10;
			this.n.ColumnCount = 2;
			this.n.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 20.23576f));
			this.n.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 79.76424f));
			this.n.Controls.Add(this.f, 0, 0);
			this.n.Controls.Add(this.m, 1, 0);
			this.n.Location = new global::System.Drawing.Point(1, 67);
			this.n.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("韢蓤藦藨軪ꇬ軮裰鳲胴菶꧸髺鏼髾洀㄂", a_);
			this.n.RowCount = 1;
			this.n.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.n.Size = new global::System.Drawing.Size(509, 72);
			this.n.TabIndex = 11;
			this.m.Location = new global::System.Drawing.Point(105, 3);
			this.m.Multiline = true;
			this.m.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("藢賤详賨ꋪ菬觮黰ꟲ跴菶미铺藼", a_);
			this.m.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.m.Size = new global::System.Drawing.Size(392, 64);
			this.m.TabIndex = 9;
			this.o.ColumnCount = 4;
			this.o.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 40.76923f));
			this.o.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 59.23077f));
			this.o.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 100f));
			this.o.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 156f));
			this.o.Controls.Add(this.k, 0, 0);
			this.o.Controls.Add(this.g, 1, 0);
			this.o.Controls.Add(this.c, 2, 0);
			this.o.Controls.Add(this.h, 3, 0);
			this.o.Controls.Add(this.e, 2, 1);
			this.o.Controls.Add(this.d, 0, 1);
			this.o.Controls.Add(this.i, 1, 1);
			this.o.Controls.Add(this.j, 3, 1);
			this.o.Location = new global::System.Drawing.Point(0, 4);
			this.o.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("韢蓤藦藨軪ꇬ軮裰鳲胴菶꧸髺鏼髾洀㈂", a_);
			this.o.RowCount = 2;
			this.o.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50.74627f));
			this.o.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 49.25373f));
			this.o.Size = new global::System.Drawing.Size(510, 58);
			this.o.TabIndex = 10;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.l);
			base.Name = global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꯢ胤蛦跨軪鿬꯮郰蟲铴듶雸闺觼跾渀漂", a_);
			base.Size = new global::System.Drawing.Size(516, 138);
			this.l.ResumeLayout(false);
			this.n.ResumeLayout(false);
			this.n.PerformLayout();
			this.o.ResumeLayout(false);
			this.o.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400012A RID: 298
		private global::AcpFileHandlerLib.IAcpFileHandler a;

		// Token: 0x0400012B RID: 299
		private global::System.ComponentModel.IContainer b;

		// Token: 0x0400012C RID: 300
		private global::System.Windows.Forms.Label c;

		// Token: 0x0400012D RID: 301
		private global::System.Windows.Forms.Label d;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.Label e;

		// Token: 0x0400012F RID: 303
		private global::System.Windows.Forms.Label f;

		// Token: 0x04000130 RID: 304
		private global::System.Windows.Forms.TextBox g;

		// Token: 0x04000131 RID: 305
		private global::System.Windows.Forms.TextBox h;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Forms.TextBox i;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Forms.TextBox j;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Forms.Label k;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.Panel l;

		// Token: 0x04000136 RID: 310
		private global::System.Windows.Forms.TextBox m;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.TableLayoutPanel n;

		// Token: 0x04000138 RID: 312
		private global::System.Windows.Forms.TableLayoutPanel o;
	}
}
