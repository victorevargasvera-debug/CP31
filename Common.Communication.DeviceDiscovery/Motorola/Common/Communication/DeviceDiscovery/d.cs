using System;
using System.Drawing;
using System.Windows.Forms;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x0200002C RID: 44
	internal partial class d : Form
	{
		// Token: 0x06000111 RID: 273 RVA: 0x00013544 File Offset: 0x00011744
		public d(PnPDeviceDetectorBase A_0)
		{
			this.c = A_0;
			base.MinimizeBox = false;
			base.MaximizeBox = false;
			base.ShowInTaskbar = false;
			base.ShowIcon = false;
			base.Visible = false;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Load += this.b;
			base.Activated += this.a;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000135BC File Offset: 0x000117BC
		protected override void WndProc(ref Message m)
		{
			short num = (short)1137442820;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E1;
				case 1:
					goto IL_1D0;
				case 2:
					if (m.Msg == this.d)
					{
						num = (short)1244659713;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_143;
				case 3:
					goto IL_E1;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 5:
					num = (short)1002307585;
					if (num != 0)
					{
					}
					this.c.b(ref m);
					num = (short)1279197190;
					num2 = (int)((IntPtr)num);
					continue;
				case 6:
					return;
				case 7:
					if (this.c != null)
					{
						num = (short)861798405;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 8:
					num = (short)1489305602;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_48:
				num = (short)1460883500;
				short num3 = num;
				num = (short)2113949740;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_143:
					m.Result = new IntPtr(1);
					num = (short)900333568;
					num2 = (int)((IntPtr)num);
					continue;
				default:
					num = (short)363331584;
					if (num != 0)
					{
					}
					if (!this.b)
					{
						num = (short)376897536;
						short num4 = num;
						num = (short)1240858632;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1D0;
				}
				IL_E1:
				num = (short)105709575;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1D0:
				base.WndProc(ref m);
				num = (short)1610612739;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000137C0 File Offset: 0x000119C0
		private void b(object A_0, EventArgs A_1)
		{
			short num = (short)1942979151;
			short num2 = num;
			num = (short)1050903119;
			switch (num2 == num)
			{
			}
			num = (short)2099118081;
			if (num != 0)
			{
			}
			num = (short)1808990208;
			if (num != 0)
			{
			}
			num = (short)1930887168;
			short num3 = num;
			this.a();
			base.Size = new Size(1, 1);
			this.b = false;
			base.Visible = false;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00013888 File Offset: 0x00011A88
		private void a(object A_0, EventArgs A_1)
		{
			short num = (short)239916873;
			short num2 = num;
			num = (short)1997592393;
			switch (num2 == num)
			{
			}
			num = (short)2061369344;
			if (num != 0)
			{
			}
			num = (short)855572481;
			if (num != 0)
			{
			}
			num = (short)1133314048;
			short num3 = num;
			base.Visible = false;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00013938 File Offset: 0x00011B38
		private void a()
		{
			int a_ = 18;
			short num = (short)1629952602;
			short num2 = num;
			num = (short)1229199962;
			switch (num2 == num)
			{
			}
			num = (short)1907163137;
			if (num != 0)
			{
			}
			num = (short)20971520;
			if (num != 0)
			{
			}
			num = (short)157679616;
			short num3 = num;
			this.a = new Label();
			base.SuspendLayout();
			this.a.AutoSize = true;
			this.a.Location = new Point(13, 30);
			this.a.Name = UDPRadioProfile.b("๐㽒㑔㕖㱘㝚汜", a_);
			this.a.Size = new Size(314, 13);
			this.a.TabIndex = 0;
			this.a.Text = UDPRadioProfile.b("Ր㭒㱔⑖祘㉚⹜罞ࡠൢ፤๦ᩨɪཬͮᑰ卲፴ᡶ୸ᙺ卼彾햀ꖄ권\udf8eﾐ쎒\ud894ﺘ\udf9a쒠삢톤좦\udba8讪캬삮햰횲閴풶햸튺\udebc풾闂계ꋆ뻈軌ꃎ뗐뛒", a_);
			base.ClientSize = new Size(360, 80);
			base.Controls.Add(this.a);
			base.Name = UDPRadioProfile.b("Ő㵒Քᩖ⩘㱚᭜ぞ፠๢", a_);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400009A RID: 154
		private Label a;

		// Token: 0x0400009B RID: 155
		private bool b = true;

		// Token: 0x0400009C RID: 156
		private PnPDeviceDetectorBase c;

		// Token: 0x0400009D RID: 157
		private readonly int d = 15;
	}
}
