using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MackinawCPS.InitializationScreen
{
	// Token: 0x02000078 RID: 120
	public class GradientPanel : global::System.Windows.Forms.Panel
	{
		// Token: 0x06000536 RID: 1334 RVA: 0x000E6D08 File Offset: 0x000E4F08
		public GradientPanel()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000E6D24 File Offset: 0x000E4F24
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs pe)
		{
			short num = (short)2023700981;
			short num2 = num;
			num = (short)1484077557;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1341652992;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1692860417;
			if (num != 0)
			{
			}
			num = (short)1786183680;
			if (num != 0)
			{
			}
			base.OnPaint(pe);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000E6DD4 File Offset: 0x000E4FD4
		protected override void OnPaintBackground(global::System.Windows.Forms.PaintEventArgs e)
		{
			base.OnPaintBackground(e);
			global::System.Drawing.Drawing2D.LinearGradientBrush linearGradientBrush = null;
			short num;
			try
			{
				linearGradientBrush = new global::System.Drawing.Drawing2D.LinearGradientBrush(new global::System.Drawing.Rectangle(new global::System.Drawing.Point(0, 0), base.Size), global::System.Drawing.Color.FromArgb(0, 255, 255, 255), global::System.Drawing.Color.FromArgb(255, 0, 0, 0), global::System.Drawing.Drawing2D.LinearGradientMode.Vertical);
				e.Graphics.FillRectangle(linearGradientBrush, new global::System.Drawing.Rectangle(new global::System.Drawing.Point(0, 0), base.Size));
			}
			finally
			{
				num = (short)1170210817;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_11D;
					case 1:
						goto IL_7D;
					case 2:
					{
						linearGradientBrush.Dispose();
						num = (short)2063501933;
						short num3 = num;
						num = (short)1423936109;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D;
						default:
							num = (short)874905600;
							if (num != 0)
							{
							}
							num = (short)1135083520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_99;
					IL_7D:
					switch (0)
					{
					case 0:
						IL_99:
						if (linearGradientBrush == null)
						{
							goto IL_11F;
						}
						num = (short)1302724610;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_11D:
				IL_11F:
				num = (short)410058753;
				if (num != 0)
				{
				}
			}
			num = (short)223084544;
			short num4 = num;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x000E6F64 File Offset: 0x000E5164
		protected override void Dispose(bool disposing)
		{
			short num = (short)405733376;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
					goto IL_14B;
				case 2:
					if (this.components != null)
					{
						num = (short)83558401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_150;
				case 3:
				{
					num = (short)1548863628;
					short num3 = num;
					num = (short)658098316;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14B;
					default:
					{
						num = (short)1083572224;
						short num4 = num;
						num = (short)1855258624;
						if (num != 0)
						{
						}
						num = (short)1128792066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 4:
					goto IL_74;
				}
				IL_39:
				if (disposing)
				{
					num = (short)541458435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_150;
				IL_14B:
				this.components.Dispose();
				num = (short)1212743684;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_74:
			num = (short)2059796481;
			if (num != 0)
			{
			}
			IL_150:
			base.Dispose(disposing);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000E70C8 File Offset: 0x000E52C8
		private void InitializeComponent()
		{
			short num = (short)1662124032;
			short num2 = num;
			num = (short)1113511257;
			short num3 = num;
			num = (short)1031853401;
			switch (num3 == num)
			{
			}
			num = (short)172818433;
			if (num != 0)
			{
			}
			num = (short)1259405312;
			if (num != 0)
			{
			}
			this.components = new global::System.ComponentModel.Container();
		}

		// Token: 0x04000304 RID: 772
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000305 RID: 773
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
