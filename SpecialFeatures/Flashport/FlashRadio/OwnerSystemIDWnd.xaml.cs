using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpASKLib;
using AcpSecurityLib;
using AcpUI.Common;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000DD RID: 221
	public partial class OwnerSystemIDWnd : Window
	{
		// Token: 0x06000D44 RID: 3396 RVA: 0x00003098 File Offset: 0x00001298
		internal OwnerSystemIDWnd()
		{
			this.InitializeComponent();
			base.DataContext = this;
			this.CmboOwnerSystem.Focus();
			Utility.SetDirection(this);
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00117784 File Offset: 0x00115984
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x00117834 File Offset: 0x00115A34
		internal OwnerSystemData OwnerSystemInfo
		{
			get
			{
				short num = (short)523764240;
				short num2 = num;
				num = (short)1394344464;
				switch (num2 == num)
				{
				default:
				{
					num = (short)479592448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1203044353;
				if (num != 0)
				{
				}
				num = (short)1113784320;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1343676889;
				short num2 = num;
				num = (short)764207577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1244921856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1169817601;
				if (num != 0)
				{
				}
				num = (short)1261240320;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x001178E4 File Offset: 0x00115AE4
		private void OnOK(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1344864257;
			int num2 = (int)((IntPtr)num);
			SystemKeyData systemKeyData;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					systemKeyData = (SystemKeyData)this.CmboOwnerSystem.SelectedItem;
					num = (short)7864324;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1855570913;
					short num3 = num;
					num = (short)1326236641;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12B;
					default:
					{
						num = (short)1759051776;
						if (num != 0)
						{
						}
						num = (short)462028800;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_12B;
				case 3:
					goto IL_1A2;
				case 4:
					if (this.a(systemKeyData))
					{
						num = (short)1305870339;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.a = null;
					base.DialogResult = new bool?(false);
					base.Close();
					num = (short)1133707266;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_AB:
				num = (short)1491795969;
				if (num != 0)
				{
				}
				if (this.CmboOwnerSystem.SelectedItem == null)
				{
					break;
				}
				num = (short)251658240;
				num2 = (int)((IntPtr)num);
			}
			IL_12B:
			return;
			IL_1A2:
			this.a = new OwnerSystemData(systemKeyData.SystemID, systemKeyData.Type);
			base.DialogResult = new bool?(true);
			base.Close();
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00117A98 File Offset: 0x00115C98
		private void OnCancel(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)867409301;
			short num2 = num;
			num = (short)2075172245;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1148780544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1214578688;
			if (num != 0)
			{
			}
			num = (short)1267335169;
			if (num != 0)
			{
			}
			this.a = null;
			base.DialogResult = new bool?(false);
			base.Close();
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00117B58 File Offset: 0x00115D58
		private bool a(SystemKeyData A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1738362603;
					short num3 = num2;
					num2 = (short)133779179;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1738407936;
						if (num2 != 0)
						{
						}
						num2 = (short)624885760;
						short num4 = num2;
						if (SecurityManager.IsSystemKeyLoaded(A_0.SystemID, (byte)A_0.Type, true))
						{
							num2 = (short)621150210;
							num = (int)((IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 1:
					return result;
				case 2:
					num2 = (short)171769857;
					if (num2 != 0)
					{
					}
					result = true;
					num2 = (short)1225392129;
					num = (int)((IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = false;
			num2 = (short)283443200;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040006BA RID: 1722
		private OwnerSystemData a;
	}
}
