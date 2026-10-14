using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using AcpUI.Common;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Programming
{
	// Token: 0x02000084 RID: 132
	public partial class DeviceOpStatusWindow : Window, IDisposable
	{
		// Token: 0x1700040E RID: 1038
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x000BC4AC File Offset: 0x000BA6AC
		public string StatusMsg
		{
			set
			{
				short num = (short)1350369282;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_111;
					case 1:
					{
						num = (short)826931314;
						short num3 = num;
						num = (short)1265236082;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1711013888;
							if (num != 0)
							{
							}
							break;
						}
						this.d = value;
						num = (short)1619132419;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 3:
						goto IL_131;
					}
					IL_34:
					num = (short)1775239168;
					short num4 = num;
					if (value != null)
					{
						num = (short)1810235393;
						if (num != 0)
						{
						}
						num = (short)1883111425;
						num2 = (int)((IntPtr)num);
					}
					else
					{
						this.d = "";
						num = (short)2123759616;
						num2 = (int)((IntPtr)num);
					}
				}
				IL_111:
				IL_131:
				this.statusText.Text = this.d;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x000BC600 File Offset: 0x000BA800
		internal EventWaitHandle WaitStatusThread
		{
			set
			{
				short num = (short)894951577;
				short num2 = num;
				num = (short)2095571097;
				switch (num2 == num)
				{
				}
				num = (short)2013724673;
				if (num != 0)
				{
				}
				num = (short)667811840;
				short num3 = num;
				num = (short)551878656;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x000BC6B0 File Offset: 0x000BA8B0
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x000BC760 File Offset: 0x000BA960
		internal EventWaitHandle CloseEventHandle
		{
			get
			{
				short num = (short)1125776786;
				short num2 = num;
				num = (short)910491026;
				switch (num2 == num)
				{
				}
				num = (short)991559680;
				if (num != 0)
				{
				}
				num = (short)1833566208;
				short num3 = num;
				num = (short)58130433;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1067248059;
				short num2 = num;
				num = (short)264169915;
				switch (num2 == num)
				{
				}
				num = (short)430309377;
				if (num != 0)
				{
				}
				num = (short)1299578880;
				short num3 = num;
				num = (short)1835401216;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000BC814 File Offset: 0x000BAA14
		internal DeviceOpStatusWindow()
		{
			this.InitializeComponent();
			Utility.SetDirection(this);
			base.Topmost = true;
			this.statusText.Text = "";
			this.CloseEventHandle = new EventWaitHandle(false, EventResetMode.ManualReset);
			this.statusText.Background = Brushes.OldLace;
			base.Background = Brushes.OldLace;
			base.WindowStyle = WindowStyle.SingleBorderWindow;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000BC87C File Offset: 0x000BAA7C
		internal void Run()
		{
			short num = (short)1388679521;
			short num2 = num;
			num = (short)2016776545;
			switch (num2 == num)
			{
			}
			num = (short)908722176;
			if (num != 0)
			{
			}
			num = (short)575864832;
			short num3 = num;
			num = (short)1303707649;
			if (num != 0)
			{
			}
			base.Show();
			this.c.Set();
			this.CloseEventHandle.WaitOne();
			base.Close();
			this.CloseEventHandle.Close();
			this.c.Set();
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000BC960 File Offset: 0x000BAB60
		public void Dispose()
		{
			short num = (short)1922240965;
			short num2 = num;
			num = (short)787681733;
			switch (num2 == num)
			{
			}
			num = (short)60555265;
			if (num != 0)
			{
			}
			num = (short)1372848128;
			short num3 = num;
			num = (short)1311178752;
			if (num != 0)
			{
			}
			this.a(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000BCA14 File Offset: 0x000BAC14
		private void a(bool A_0)
		{
			short num = (short)396361729;
			if (num != 0)
			{
			}
			num = (short)2131755009;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A0;
				case 1:
				{
					num = (short)1722810368;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_80;
					}
					continue;
				}
				case 2:
				{
					num = (short)1535110478;
					short num4 = num;
					num = (short)878701902;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A0;
					default:
						goto IL_F8;
					}
					break;
				}
				}
				IL_80:
				if (!this.a)
				{
					num = (short)12124160;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_110;
				IL_A0:
				this.CloseEventHandle.Set();
				num = (short)1179910146;
				num2 = (int)((IntPtr)num);
			}
			IL_F8:
			num = (short)477691904;
			if (num != 0)
			{
			}
			IL_110:
			this.a = true;
		}

		// Token: 0x040003FE RID: 1022
		private bool a;

		// Token: 0x040003FF RID: 1023
		private EventWaitHandle b;

		// Token: 0x04000400 RID: 1024
		private EventWaitHandle c;

		// Token: 0x04000401 RID: 1025
		private string d;
	}
}
