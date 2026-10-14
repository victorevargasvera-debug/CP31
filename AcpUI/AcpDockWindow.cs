using System;
using System.Windows.Input;
using System.Windows.Threading;
using DevComponents.WpfDock;

namespace AcpUI
{
	// Token: 0x02000013 RID: 19
	public class AcpDockWindow : global::DevComponents.WpfDock.DockWindow
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00015C40 File Offset: 0x00013E40
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00015CF4 File Offset: 0x00013EF4
		internal bool IsAutoRiseEnabled
		{
			get
			{
				short num = (short)1867428631;
				short num2 = num;
				num = (short)1537258263;
				switch (num2 == num)
				{
				}
				num = (short)1780023296;
				short num3 = num;
				num = (short)1663303680;
				if (num != 0)
				{
				}
				num = (short)1675689985;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)370278401;
				if (num != 0)
				{
				}
				num = (short)1286978852;
				short num2 = num;
				num = (short)1434959140;
				switch (num2 == num)
				{
				default:
				{
					num = (short)487325696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)182976512;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00015DA4 File Offset: 0x00013FA4
		public void StartTimer(int durationInMillSec)
		{
			short num = (short)877361856;
			short num2 = num;
			num = (short)2041477824;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)446103552;
				if (num != 0)
				{
				}
				num = (short)538509313;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					this.a = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.Normal);
					this.a.Tick += this.OnPopupTimeOut;
					num = (short)1189609474;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_7E;
					}
					continue;
				case 2:
					goto IL_151;
				case 3:
					goto IL_114;
				}
				IL_7E:
				num = (short)1352138753;
				if (num != 0)
				{
				}
				num = (short)1468465152;
				short num4 = num;
				if (this.a == null)
				{
					num = (short)2068316160;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					this.a.Stop();
					num = (short)1815412739;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_114:
			IL_151:
			this.a.Interval = global::System.TimeSpan.FromMilliseconds((double)durationInMillSec);
			this.a.Start();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00015F24 File Offset: 0x00014124
		internal void b()
		{
			short num = (short)157876224;
			short num2 = num;
			num = (short)1126105088;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)1318652271;
					short num4 = num;
					num = (short)1748371823;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B2;
					default:
						num = (short)1933443072;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					}
					break;
				}
				case 1:
					this.a.Stop();
					this.a.Tick -= this.OnPopupTimeOut;
					this.a = null;
					num = (short)766705666;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_108;
				}
				goto IL_A7;
				IL_B2:
				num = (short)1678835713;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_A7:
				if (this.a != null)
				{
					goto IL_B2;
				}
				return;
			}
			IL_108:
			num = (short)1633550337;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00016064 File Offset: 0x00014264
		private void OnPopupTimeOut(object A_0, global::System.EventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			int num;
			short num2;
			global::DevComponents.WpfDock.DockSite dockSite;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					this.b();
					base.AutoHideOpen = false;
					num2 = (short)105512976;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					IL_6F:
					if (dockSite != null)
					{
						num2 = (short)209125379;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)1258553344;
					short num3 = num2;
					if (!base.IsMouseOver)
					{
						num2 = (short)1478164484;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C3;
				}
				case 3:
					num2 = (short)57475083;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1357316097;
					if (num2 != 0)
					{
					}
					num2 = (short)1866989574;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (dockSite.ActiveDockWindow.Name != base.Name)
					{
						num2 = (short)1537015822;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C3;
				case 6:
					if (base.AutoHideOpen)
					{
						num2 = (short)2008285193;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C3;
				case 7:
					if (dockSite.ActiveDockWindow != null)
					{
						num2 = (short)62062607;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C3;
				case 8:
					goto IL_192;
				case 9:
					num2 = (short)349175821;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)19988487;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (base.AutoHidePopupWnd == null)
					{
						num2 = (short)1667432456;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)539492364;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (dockSite.ActiveDockWindow != null)
					{
						num2 = (short)138608650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_194;
				case 13:
					if (!base.IsMouseWithinAutoHidePopup())
					{
						num2 = (short)656539648;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2C3;
				case 14:
					goto IL_194;
				case 15:
					num2 = (short)1305739269;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_2C3;
				}
				goto IL_54;
				IL_194:
				num2 = (short)132513794;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2C3:
				num2 = (short)370691837;
				short num4 = num2;
				num2 = (short)2027179773;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_6F;
				default:
					goto IL_2F9;
				}
			}
			return;
			IL_192:
			return;
			IL_2F9:
			num2 = (short)1357905920;
			if (num2 != 0)
			{
			}
			return;
			IL_54:
			dockSite = base.GetDockSite();
			num2 = (short)1557856257;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00016384 File Offset: 0x00014584
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					global::DevComponents.WpfDock.DockSite dockSite;
					if (dockSite.ActiveDockWindow != null)
					{
						num2 = (short)2119958531;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10A;
				}
				case 1:
					num2 = (short)1029505028;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					global::DevComponents.WpfDock.DockSite dockSite;
					if (dockSite.ActiveDockWindow != null)
					{
						num2 = (short)1656356874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_241;
				}
				case 3:
					num2 = (short)525402114;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!base.AutoHideOpen)
					{
						num2 = (short)292880392;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_241;
				case 5:
					if (base.IsAutoHide)
					{
						num2 = (short)1118830592;
						short num3 = num2;
						num2 = (short)834207745;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_241;
				case 6:
					goto IL_10A;
				case 7:
				{
					global::DevComponents.WpfDock.DockSite dockSite;
					if (dockSite.ActiveDockWindow.Name != base.Name)
					{
						num2 = (short)1031143430;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_241;
				}
				case 8:
					this.StartTimer(5000);
					num2 = (short)1271332873;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_1F4;
				case 10:
					goto IL_1AA;
				}
				goto IL_3C;
				IL_10A:
				num2 = (short)496041989;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1F4:
			IL_241:
			base.OnMouseEnter(e);
			return;
			IL_3C:
			num2 = (short)255887689;
			short num4 = num2;
			num2 = (short)1146718537;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1AA:
				num2 = (short)1872232449;
				if (num2 != 0)
				{
				}
				num2 = (short)116195335;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)236847104;
				if (num2 != 0)
				{
				}
				global::DevComponents.WpfDock.DockSite dockSite = base.GetDockSite();
				num2 = (short)1431175168;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0400012B RID: 299
		private global::System.Windows.Threading.DispatcherTimer a;

		// Token: 0x0400012C RID: 300
		private bool b = true;
	}
}
