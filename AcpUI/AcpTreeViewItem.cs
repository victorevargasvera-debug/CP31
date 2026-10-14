using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x02000039 RID: 57
	public class AcpTreeViewItem : global::System.Windows.Controls.TreeViewItem
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0003EDAC File Offset: 0x0003CFAC
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0003EE58 File Offset: 0x0003D058
		public int RecsetId
		{
			get
			{
				short num = (short)2029118673;
				short num2 = num;
				num = (short)569828561;
				switch (num2 == num)
				{
				default:
				{
					num = (short)472907776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)436207616;
				if (num != 0)
				{
				}
				num = (short)1604714497;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1124700846;
				short num2 = num;
				num = (short)1771803310;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2051538944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1069154305;
				if (num != 0)
				{
				}
				num = (short)1985413120;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0003EF08 File Offset: 0x0003D108
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0003EFB8 File Offset: 0x0003D1B8
		public int NodeId
		{
			get
			{
				short num = (short)1616318070;
				short num2 = num;
				num = (short)1964379766;
				switch (num2 == num)
				{
				default:
				{
					num = (short)916979712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1631846400;
				if (num != 0)
				{
				}
				num = (short)1090453505;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1018483962;
				short num2 = num;
				num = (short)599250170;
				switch (num2 == num)
				{
				default:
				{
					num = (short)872546304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)612630529;
				if (num != 0)
				{
				}
				num = (short)1631059968;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0003F064 File Offset: 0x0003D264
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0003F114 File Offset: 0x0003D314
		public string ReferenceKey
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)291048176;
				short num2 = num;
				num = (short)1846741744;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1298464768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1522466817;
				if (num != 0)
				{
				}
				num = (short)2015821824;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)976364220;
				short num2 = num;
				num = (short)190522044;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1929707520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)758906881;
				if (num != 0)
				{
				}
				num = (short)1136787456;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0003F1C8 File Offset: 0x0003D3C8
		// (set) Token: 0x0600039F RID: 927 RVA: 0x0003F280 File Offset: 0x0003D480
		public bool ShowDiffIcon
		{
			get
			{
				short num = (short)1920456183;
				short num2 = num;
				num = (short)1146279415;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2106851328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1376976896;
				if (num != 0)
				{
				}
				num = (short)836501505;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTreeViewItem.ShowDiffIconProperty);
			}
			set
			{
				short num = (short)174916153;
				short num2 = num;
				num = (short)922092089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1314193408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1027407873;
				if (num != 0)
				{
				}
				num = (short)1273626624;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTreeViewItem.ShowDiffIconProperty, value);
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0003F340 File Offset: 0x0003D540
		public AcpTreeViewItem()
		{
			base.MouseLeftButtonUp += this.AcpTreeViewItem_MouseLeftButtonUp;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0003F374 File Offset: 0x0003D574
		private void AcpTreeViewItem_MouseLeftButtonUp(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num;
			int num3;
			global::AcpUI.AcpTreeViewItem acpTreeViewItem;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					num = (short)1554471989;
					short num2 = num;
					num = (short)1617255477;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_70;
					default:
						num = (short)473432064;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_116;
						case 1:
							acpTreeViewItem.IsSelected = true;
							num = (short)1968701440;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (!acpTreeViewItem.IsSelected)
							{
								num = (short)668139520;
								short num4 = num;
								num = (short)408027137;
								if (num != 0)
								{
								}
								num = (short)990445569;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_118;
						}
						goto IL_69;
					}
				}
				IL_116:
				IL_118:
				global::AcpUI.AcpTreeView acpTreeView = (global::AcpUI.AcpTreeView)this.a(acpTreeViewItem, typeof(global::AcpUI.AcpTreeView));
				acpTreeView.NavigateToContentPage(acpTreeView);
				A_1.Handled = true;
				return;
			}
			}
			IL_69:
			acpTreeViewItem = (A_0 as global::AcpUI.AcpTreeViewItem);
			IL_70:
			num = (short)306839554;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0003F4BC File Offset: 0x0003D6BC
		private global::System.Windows.DependencyObject a(object A_0, global::System.Type A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Windows.DependencyObject dependencyObject;
			short num2;
			global::System.Windows.DependencyObject reference;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (dependencyObject.GetType().IsSubclassOf(A_1))
					{
						num2 = (short)850395139;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F6;
				case 1:
					num2 = (short)1456013312;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_117;
				case 3:
				{
					num2 = (short)1143711370;
					short num3 = num2;
					num2 = (short)50374282;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_117;
					default:
						goto IL_DE;
					}
					break;
				}
				case 4:
					goto IL_F6;
				}
				goto IL_24;
				IL_F6:
				dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(reference);
				reference = dependencyObject;
				num2 = (short)1262092290;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_117:
				num2 = (short)1487470593;
				if (num2 != 0)
				{
				}
				if (dependencyObject == null)
				{
					return dependencyObject;
				}
				num2 = (short)1294532609;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_DE:
			num2 = (short)802160640;
			if (num2 != 0)
			{
			}
			return dependencyObject;
			IL_24:
			num2 = (short)1410793472;
			short num4 = num2;
			reference = (global::System.Windows.DependencyObject)A_0;
			dependencyObject = null;
			num2 = (short)1002635268;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0003F628 File Offset: 0x0003D828
		// Note: this type is marked as 'beforefieldinit'.
		static AcpTreeViewItem()
		{
			int a_ = 3;
			short num = (short)402653185;
			if (num != 0)
			{
			}
			num = (short)1528365056;
			short num2 = num;
			num = (short)2108601739;
			short num3 = num;
			num = (short)301708683;
			switch (num3 == num)
			{
			}
			num = (short)2137522176;
			if (num != 0)
			{
			}
			global::AcpUI.AcpTreeViewItem.ShowDiffIconProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("쪘쪢쎤솦좪슬솮", a_), typeof(bool), typeof(global::AcpUI.AcpTreeViewItem), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x04000227 RID: 551
		private int a = -1;

		// Token: 0x04000228 RID: 552
		private int b = -1;

		// Token: 0x04000229 RID: 553
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x0400022A RID: 554
		public static readonly global::System.Windows.DependencyProperty ShowDiffIconProperty;
	}
}
