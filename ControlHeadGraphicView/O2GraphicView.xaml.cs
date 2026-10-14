using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Shapes;
using AcpBusinessLayer;
using AcpUI;
using AcpUI.Common;
using ControlHeadGraphicView.converters;

namespace ControlHeadGraphicView
{
	// Token: 0x02000008 RID: 8
	public partial class O2GraphicView : UserControl
	{
		// Token: 0x06000699 RID: 1689 RVA: 0x0005DA1C File Offset: 0x0005BC1C
		public O2GraphicView()
		{
			base.FlowDirection = FlowDirection.LeftToRight;
			this.InitializeComponent();
			base.DataContext = this;
			base.Loaded += this.O2GraphicView_Loaded;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0005DA58 File Offset: 0x0005BC58
		private void O2GraphicView_Loaded(object sender, RoutedEventArgs e)
		{
			short num = (short)341770240;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 1:
					goto IL_129;
				case 2:
				{
					num = (short)813957121;
					if (num != 0)
					{
					}
					num = (short)1811958249;
					short num3 = num;
					num = (short)2060536297;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F9;
					default:
						goto IL_E0;
					}
					break;
				}
				case 3:
					goto IL_F9;
				}
				IL_35:
				if (this.MFKEmergencyAccess)
				{
					num = (short)1318912003;
					num2 = (int)((IntPtr)num);
					continue;
				}
				this.MFKButtonOrange.Visibility = Visibility.Hidden;
				this.MFKButton.Visibility = Visibility.Visible;
				num = (short)2012086274;
				num2 = (int)((IntPtr)num);
				continue;
				IL_F9:
				this.MFKButtonOrange.Visibility = Visibility.Visible;
				this.MFKButton.Visibility = Visibility.Hidden;
				num = (short)1081344001;
				num2 = (int)((IntPtr)num);
			}
			IL_E0:
			num = (short)1622802432;
			if (num != 0)
			{
			}
			IL_129:
			num = (short)76349440;
			short num4 = num;
			base.Loaded -= this.O2GraphicView_Loaded;
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x0005DBCC File Offset: 0x0005BDCC
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x0005DC78 File Offset: 0x0005BE78
		public bool MFKEmergencyAccess
		{
			get
			{
				short num = (short)983498753;
				if (num != 0)
				{
				}
				num = (short)1843324050;
				short num2 = num;
				num = (short)810869906;
				switch (num2 == num)
				{
				default:
				{
					num = (short)27590656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)52625408;
				if (num != 0)
				{
				}
				return this.mFKEmergencyAccess;
			}
			set
			{
				short num = (short)539235728;
				short num2 = num;
				num = (short)1386747280;
				switch (num2 == num)
				{
				}
				num = (short)1321992192;
				short num3 = num;
				num = (short)578289664;
				if (num != 0)
				{
				}
				num = (short)1395261441;
				if (num != 0)
				{
				}
				this.mFKEmergencyAccess = value;
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0005DD28 File Offset: 0x0005BF28
		private void OnFieldNameDoubleClick(object sender, RoutedEventArgs e)
		{
			short num = (short)188090145;
			short num2 = num;
			num = (short)1288046369;
			switch (num2 == num)
			{
			}
			num = (short)283246592;
			short num3 = num;
			num = (short)1863712769;
			if (num != 0)
			{
			}
			num = (short)1128660992;
			if (num != 0)
			{
			}
			Utility.GetFieldHelpText(sender);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0005DDD8 File Offset: 0x0005BFD8
		public override void EndInit()
		{
			short num = (short)241827841;
			if (num != 0)
			{
			}
			num = (short)283935984;
			short num2 = num;
			num = (short)1660585200;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1744240640;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1396244480;
			if (num != 0)
			{
			}
			base.EndInit();
			this.SetMenuItems();
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0005DE8C File Offset: 0x0005C08C
		public void SetMenuItems()
		{
			short num = (short)1630732292;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)623699744;
					short num3 = num;
					num = (short)543680288;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_209;
					default:
						num = (short)2073690112;
						if (num != 0)
						{
						}
						goto IL_27E;
					}
					break;
				}
				case 2:
					goto IL_209;
				case 3:
					goto IL_394;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 5:
				{
					this.bottom_screen_status.Content = this.MenuItemsConventionalSelectedList.Items[3].ItemName;
					num = (short)992477184;
					short num4 = num;
					num = (short)1982529538;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 6:
				{
					int count = this.MenuItemsTrunkingSelectedList.Items.Count;
					if (count >= 1)
					{
						this.bottom_screen_info_Copy.Content = this.MenuItemsTrunkingSelectedList.Items[0].ItemName;
						this.bottom_screen_info_Copy.Tag = 0;
					}
					else
					{
						this.bottom_screen_info_Copy.Content = string.Empty;
						this.bottom_screen_info_Copy.Tag = 0;
					}
					if (count >= 2)
					{
						this.bottom_screen_scan_Copy.Content = this.MenuItemsTrunkingSelectedList.Items[1].ItemName;
					}
					else
					{
						this.bottom_screen_scan_Copy.Content = string.Empty;
					}
					if (count >= 3)
					{
						this.bottom_screen_zone_Copy.Content = this.MenuItemsTrunkingSelectedList.Items[2].ItemName;
					}
					else
					{
						this.bottom_screen_zone_Copy.Content = string.Empty;
					}
					if (count >= 4)
					{
						num = (short)1338179587;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3B8;
				}
				case 7:
				{
					int count2 = this.MenuItemsConventionalSelectedList.Items.Count;
					if (count2 >= 1)
					{
						this.bottom_screen_info.Content = this.MenuItemsConventionalSelectedList.Items[0].ItemName;
						this.bottom_screen_info.Tag = 0;
					}
					else
					{
						this.bottom_screen_info.Content = string.Empty;
						this.bottom_screen_info.Tag = 0;
					}
					if (count2 >= 2)
					{
						this.bottom_screen_scan.Content = this.MenuItemsConventionalSelectedList.Items[1].ItemName;
					}
					else
					{
						this.bottom_screen_scan.Content = string.Empty;
					}
					if (count2 >= 3)
					{
						this.bottom_screen_zone.Content = this.MenuItemsConventionalSelectedList.Items[2].ItemName;
					}
					else
					{
						this.bottom_screen_zone.Content = string.Empty;
					}
					if (count2 >= 4)
					{
						num = (short)984940545;
						if (num != 0)
						{
						}
						num = (short)2088828933;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_status.Content = string.Empty;
					num = (short)2007302145;
					num2 = (int)((IntPtr)num);
					continue;
				}
				}
				IL_46:
				if (this.MenuItemsConventionalSelectedList == null)
				{
					num = (short)747765760;
					num2 = (int)((IntPtr)num);
					continue;
				}
				num = (short)423231495;
				num2 = (int)((IntPtr)num);
				continue;
				IL_27E:
				num = (short)160563206;
				num2 = (int)((IntPtr)num);
				continue;
				IL_209:
				goto IL_27E;
			}
			return;
			IL_394:
			this.bottom_screen_status_Copy.Content = this.MenuItemsTrunkingSelectedList.Items[3].ItemName;
			return;
			IL_3B8:
			this.bottom_screen_status_Copy.Content = string.Empty;
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0005E264 File Offset: 0x0005C464
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x0005E320 File Offset: 0x0005C520
		public bool EmergencyButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)1895170049;
				if (num != 0)
				{
				}
				num = (short)54066676;
				short num2 = num;
				num = (short)1182858740;
				switch (num2 == num)
				{
				default:
				{
					num = (short)893124608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1576206336;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.EmergencyButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1771983328;
				short num2 = num;
				num = (short)561336800;
				switch (num2 == num)
				{
				}
				num = (short)2134441984;
				short num3 = num;
				num = (short)1027407873;
				if (num != 0)
				{
				}
				num = (short)10944512;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.EmergencyButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0005E3DC File Offset: 0x0005C5DC
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x0005E494 File Offset: 0x0005C694
		public bool EmergencyButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1374021523;
				short num2 = num;
				num = (short)1367992211;
				switch (num2 == num)
				{
				}
				num = (short)487653376;
				short num3 = num;
				num = (short)82509824;
				if (num != 0)
				{
				}
				num = (short)756154369;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1143443382;
				short num2 = num;
				num = (short)1487114166;
				switch (num2 == num)
				{
				}
				num = (short)2076704768;
				short num3 = num;
				num = (short)1649868800;
				if (num != 0)
				{
				}
				num = (short)1095106561;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0005E554 File Offset: 0x0005C754
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x0005E610 File Offset: 0x0005C810
		public bool EmergencyButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)2132358559;
				short num2 = num;
				num = (short)195704223;
				switch (num2 == num)
				{
				}
				num = (short)1465450496;
				short num3 = num;
				num = (short)1106378753;
				if (num != 0)
				{
				}
				num = (short)655753216;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)979658366;
				short num2 = num;
				num = (short)52192894;
				switch (num2 == num)
				{
				}
				num = (short)685965312;
				short num3 = num;
				num = (short)1703215104;
				if (num != 0)
				{
				}
				num = (short)727318529;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x0005E6CC File Offset: 0x0005C8CC
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x0005E784 File Offset: 0x0005C984
		public bool EmergencyButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1468268545;
				if (num != 0)
				{
				}
				num = (short)107849718;
				short num2 = num;
				num = (short)723429366;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2103377920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)363986944;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.EmergencyButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)854230571;
				short num2 = num;
				num = (short)1467909675;
				switch (num2 == num)
				{
				}
				num = (short)1453981696;
				short num3 = num;
				num = (short)114098177;
				if (num != 0)
				{
				}
				num = (short)1982398464;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.EmergencyButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0005E840 File Offset: 0x0005CA40
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x0005E8F8 File Offset: 0x0005CAF8
		public string EmergencyButtonFeatureUIValue
		{
			get
			{
				short num = (short)1887523084;
				short num2 = num;
				num = (short)979259660;
				switch (num2 == num)
				{
				}
				num = (short)344522752;
				short num3 = num;
				num = (short)624492545;
				if (num != 0)
				{
				}
				num = (short)518258688;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O2GraphicView.EmergencyButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1369386359;
				short num2 = num;
				num = (short)685976951;
				switch (num2 == num)
				{
				}
				num = (short)1413808128;
				short num3 = num;
				num = (short)965869569;
				if (num != 0)
				{
				}
				num = (short)1197670400;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.EmergencyButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x0005E9B0 File Offset: 0x0005CBB0
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x0005EA6C File Offset: 0x0005CC6C
		public AcpListField EmergencyButtonFeatureList
		{
			get
			{
				short num = (short)1721470026;
				short num2 = num;
				num = (short)517311562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1767571456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)480116737;
				if (num != 0)
				{
				}
				num = (short)580583424;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O2GraphicView.EmergencyButtonFeatureListProperty);
			}
			set
			{
				short num = (short)1569953863;
				short num2 = num;
				num = (short)1642633287;
				switch (num2 == num)
				{
				default:
				{
					num = (short)668663808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2051866625;
				if (num != 0)
				{
				}
				num = (short)1716912128;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.EmergencyButtonFeatureListProperty, value);
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x0005EB20 File Offset: 0x0005CD20
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x0005EBD8 File Offset: 0x0005CDD8
		public AcpListField MenuItemsConventionalSelectedList
		{
			get
			{
				short num = (short)1782710273;
				if (num != 0)
				{
				}
				num = (short)823394304;
				short num2 = num;
				num = (short)294311210;
				short num3 = num;
				num = (short)163697962;
				switch (num3 == num)
				{
				}
				num = (short)95420416;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O2GraphicView.MenuItemsConventionalSelectedListProperty);
			}
			set
			{
				short num = (short)215876496;
				short num2 = num;
				num = (short)214893456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1265565696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)289210369;
				if (num != 0)
				{
				}
				num = (short)1868365824;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MenuItemsConventionalSelectedListProperty, value);
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x0005EC90 File Offset: 0x0005CE90
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x0005ED4C File Offset: 0x0005CF4C
		public AcpListField MenuItemsTrunkingSelectedList
		{
			get
			{
				short num = (short)1312888529;
				short num2 = num;
				num = (short)1983846097;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1472790528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1905459201;
				if (num != 0)
				{
				}
				num = (short)1243152384;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O2GraphicView.MenuItemsTrunkingSelectedListProperty);
			}
			set
			{
				short num = (short)1810200368;
				short num2 = num;
				num = (short)1854371632;
				switch (num2 == num)
				{
				default:
				{
					num = (short)620101632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2058616833;
				if (num != 0)
				{
				}
				num = (short)1358823424;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MenuItemsTrunkingSelectedListProperty, value);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x0005EE00 File Offset: 0x0005D000
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x0005EEBC File Offset: 0x0005D0BC
		public bool MenuItemsConventionalSelectedListVisibility
		{
			get
			{
				short num = (short)826782200;
				short num2 = num;
				num = (short)902476280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1180172288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)975241216;
				if (num != 0)
				{
				}
				num = (short)501153793;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.MenuItemsConventionalSelectedListVisibilityProperty);
			}
			set
			{
				short num = (short)23024964;
				short num2 = num;
				num = (short)417879364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1682374656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1473773568;
				if (num != 0)
				{
				}
				num = (short)676397057;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MenuItemsConventionalSelectedListVisibilityProperty, value);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0005EF74 File Offset: 0x0005D174
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x0005F02C File Offset: 0x0005D22C
		public bool MenuItemsTrunkingSelectedListVisibility
		{
			get
			{
				short num = (short)2093338181;
				short num2 = num;
				num = (short)480693829;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1676541952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1968701441;
				if (num != 0)
				{
				}
				num = (short)571473920;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty);
			}
			set
			{
				short num = (short)680984577;
				if (num != 0)
				{
				}
				num = (short)997982208;
				short num2 = num;
				num = (short)83995265;
				short num3 = num;
				num = (short)1816177281;
				switch (num3 == num)
				{
				}
				num = (short)1013579776;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty, value);
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0005F0E8 File Offset: 0x0005D2E8
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x0005F1A4 File Offset: 0x0005D3A4
		public bool UpButtonIsAcpValid
		{
			get
			{
				short num = (short)321665667;
				short num2 = num;
				num = (short)2116434563;
				switch (num2 == num)
				{
				default:
				{
					num = (short)209453056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)540082177;
				if (num != 0)
				{
				}
				num = (short)2113470464;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.UpButtonIsAcpValidProperty);
			}
			set
			{
				short num = (short)2098266113;
				if (num != 0)
				{
				}
				num = (short)200933376;
				short num2 = num;
				num = (short)621785134;
				short num3 = num;
				num = (short)459321390;
				switch (num3 == num)
				{
				}
				num = (short)1678508032;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.UpButtonIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0005F260 File Offset: 0x0005D460
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x0005F318 File Offset: 0x0005D518
		public bool UpButtonIsAcpApplicable
		{
			get
			{
				short num = (short)1811537540;
				short num2 = num;
				num = (short)1704517252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1030029312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1547370497;
				if (num != 0)
				{
				}
				num = (short)1553596416;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.UpButtonIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)678625281;
				if (num != 0)
				{
				}
				num = (short)1339555840;
				short num2 = num;
				num = (short)1983848490;
				short num3 = num;
				num = (short)536813610;
				switch (num3 == num)
				{
				}
				num = (short)733413376;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.UpButtonIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0005F3D4 File Offset: 0x0005D5D4
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x0005F48C File Offset: 0x0005D68C
		public bool UpButtonIsAcpVisible
		{
			get
			{
				short num = (short)1976696833;
				if (num != 0)
				{
				}
				num = (short)889126912;
				short num2 = num;
				num = (short)1717018820;
				short num3 = num;
				num = (short)1227268292;
				switch (num3 == num)
				{
				}
				num = (short)1546846208;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.UpButtonIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)120958646;
				short num2 = num;
				num = (short)262778550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1614741504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)90374145;
				if (num != 0)
				{
				}
				num = (short)172687360;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.UpButtonIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x0005F544 File Offset: 0x0005D744
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x0005F5FC File Offset: 0x0005D7FC
		public bool UpButtonIsAcpEditable
		{
			get
			{
				short num = (short)61284673;
				short num2 = num;
				num = (short)879305025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169752064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)388628481;
				if (num != 0)
				{
				}
				num = (short)712245248;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.UpButtonIsAcpEditableProperty);
			}
			set
			{
				short num = (short)949620637;
				short num2 = num;
				num = (short)400691101;
				switch (num2 == num)
				{
				default:
				{
					num = (short)582352896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)46989313;
				if (num != 0)
				{
				}
				num = (short)535822336;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.UpButtonIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x0005F6B4 File Offset: 0x0005D8B4
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x0005F76C File Offset: 0x0005D96C
		public string UpButtonUIValue
		{
			get
			{
				short num = (short)2077915125;
				short num2 = num;
				num = (short)29194229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1472004096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)419692545;
				if (num != 0)
				{
				}
				num = (short)943849472;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O2GraphicView.UpButtonUIValueProperty);
			}
			set
			{
				short num = (short)447831679;
				short num2 = num;
				num = (short)1559846527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)442171392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1846607872;
				if (num != 0)
				{
				}
				num = (short)1706688513;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.UpButtonUIValueProperty, value);
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x0005F824 File Offset: 0x0005DA24
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x0005F8DC File Offset: 0x0005DADC
		public AcpListField UpButtonList
		{
			get
			{
				short num = (short)1426982233;
				short num2 = num;
				num = (short)1898186073;
				switch (num2 == num)
				{
				default:
				{
					num = (short)329973760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1914044417;
				if (num != 0)
				{
				}
				num = (short)1570242560;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O2GraphicView.UpButtonListProperty);
			}
			set
			{
				short num = (short)567017473;
				if (num != 0)
				{
				}
				num = (short)472186880;
				short num2 = num;
				num = (short)1377862674;
				short num3 = num;
				num = (short)1147962386;
				switch (num3 == num)
				{
				}
				num = (short)1864171520;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.UpButtonListProperty, value);
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0005F994 File Offset: 0x0005DB94
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x0005FA4C File Offset: 0x0005DC4C
		public bool DownButtonIsAcpValid
		{
			get
			{
				short num = (short)1120323390;
				short num2 = num;
				num = (short)1820478;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2015821824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)834207745;
				if (num != 0)
				{
				}
				num = (short)1211301888;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.DownButtonIsAcpValidProperty);
			}
			set
			{
				short num = (short)1491810341;
				short num2 = num;
				num = (short)818231333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)150929408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1494614017;
				if (num != 0)
				{
				}
				num = (short)213975040;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.DownButtonIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x0005FB08 File Offset: 0x0005DD08
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x0005FBC4 File Offset: 0x0005DDC4
		public bool DownButtonIsAcpApplicable
		{
			get
			{
				short num = (short)1327919379;
				short num2 = num;
				num = (short)2125361427;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2054619136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1976631296;
				if (num != 0)
				{
				}
				num = (short)1023344641;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.DownButtonIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)399112759;
				short num2 = num;
				num = (short)1016461879;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1066598400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1013972992;
				if (num != 0)
				{
				}
				num = (short)974454785;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.DownButtonIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0005FC80 File Offset: 0x0005DE80
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x0005FD38 File Offset: 0x0005DF38
		public bool DownButtonIsAcpVisible
		{
			get
			{
				short num = (short)1860614620;
				short num2 = num;
				num = (short)802732508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2009006080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2004811776;
				if (num != 0)
				{
				}
				num = (short)1782906881;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.DownButtonIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1975189505;
				if (num != 0)
				{
				}
				num = (short)1398079488;
				short num2 = num;
				num = (short)119793329;
				short num3 = num;
				num = (short)1889527473;
				switch (num3 == num)
				{
				}
				num = (short)679477248;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.DownButtonIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x0005FDF0 File Offset: 0x0005DFF0
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x0005FEA8 File Offset: 0x0005E0A8
		public bool DownButtonIsAcpEditable
		{
			get
			{
				short num = (short)2141190595;
				short num2 = num;
				num = (short)1725954499;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2030436352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1435697153;
				if (num != 0)
				{
				}
				num = (short)1427111936;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.DownButtonIsAcpEditableProperty);
			}
			set
			{
				short num = (short)852107536;
				short num2 = num;
				num = (short)812589328;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1789788160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1502543872;
				if (num != 0)
				{
				}
				num = (short)1424424961;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.DownButtonIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0005FF60 File Offset: 0x0005E160
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x0006001C File Offset: 0x0005E21C
		public string DownButtonUIValue
		{
			get
			{
				short num = (short)368342795;
				short num2 = num;
				num = (short)2026534667;
				switch (num2 == num)
				{
				default:
				{
					num = (short)565641216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)737476608;
				if (num != 0)
				{
				}
				num = (short)718077953;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O2GraphicView.DownButtonUIValueProperty);
			}
			set
			{
				short num = (short)405729328;
				short num2 = num;
				num = (short)1272901680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)173080576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2133917697;
				if (num != 0)
				{
				}
				num = (short)561446912;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.DownButtonUIValueProperty, value);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x000600D4 File Offset: 0x0005E2D4
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x00060190 File Offset: 0x0005E390
		public AcpListField DownButtonList
		{
			get
			{
				short num = (short)1623101841;
				short num2 = num;
				num = (short)715821457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1432354816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2032926721;
				if (num != 0)
				{
				}
				num = (short)1511849984;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O2GraphicView.DownButtonListProperty);
			}
			set
			{
				short num = (short)670075776;
				short num2 = num;
				num = (short)783780736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1443037184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)557842433;
				if (num != 0)
				{
				}
				num = (short)208404480;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.DownButtonListProperty, value);
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00060244 File Offset: 0x0005E444
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x000602FC File Offset: 0x0005E4FC
		public bool MFKPressBehaviorIsAcpValid
		{
			get
			{
				short num = (short)1180036359;
				short num2 = num;
				num = (short)391441671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1873870848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1256849409;
				if (num != 0)
				{
				}
				num = (short)1749155840;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.MFKPressBehaviorIsAcpValidProperty);
			}
			set
			{
				short num = (short)1852243969;
				if (num != 0)
				{
				}
				num = (short)506724352;
				short num2 = num;
				num = (short)202581075;
				short num3 = num;
				num = (short)831988819;
				switch (num3 == num)
				{
				}
				num = (short)310640640;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MFKPressBehaviorIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x000603B8 File Offset: 0x0005E5B8
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x00060470 File Offset: 0x0005E670
		public bool MFKPressBehaviorIsAcpApplicable
		{
			get
			{
				short num = (short)511182021;
				short num2 = num;
				num = (short)259654853;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1589444608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1007878145;
				if (num != 0)
				{
				}
				num = (short)1391132672;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.MFKPressBehaviorIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1505860492;
				short num2 = num;
				num = (short)943102860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)823328768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1762328577;
				if (num != 0)
				{
				}
				num = (short)275578880;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MFKPressBehaviorIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0006052C File Offset: 0x0005E72C
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x000605E4 File Offset: 0x0005E7E4
		public bool MFKPressBehaviorIsAcpVisible
		{
			get
			{
				short num = (short)1599198823;
				short num2 = num;
				num = (short)374855271;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1354563584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1440677889;
				if (num != 0)
				{
				}
				num = (short)185794560;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.MFKPressBehaviorIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1843778233;
				short num2 = num;
				num = (short)1914819257;
				switch (num2 == num)
				{
				default:
				{
					num = (short)792133632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)342556672;
				if (num != 0)
				{
				}
				num = (short)694026241;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MFKPressBehaviorIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x000606A0 File Offset: 0x0005E8A0
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x0006075C File Offset: 0x0005E95C
		public bool MFKPressBehaviorIsAcpEditable
		{
			get
			{
				short num = (short)608907930;
				short num2 = num;
				num = (short)269300378;
				switch (num2 == num)
				{
				default:
				{
					num = (short)134938624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)514719745;
				if (num != 0)
				{
				}
				num = (short)646774784;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.MFKPressBehaviorIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1669972043;
				short num2 = num;
				num = (short)2035466315;
				switch (num2 == num)
				{
				default:
				{
					num = (short)448593920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1220542464;
				if (num != 0)
				{
				}
				num = (short)1284636673;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MFKPressBehaviorIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00060814 File Offset: 0x0005EA14
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x000608D4 File Offset: 0x0005EAD4
		public string MFKPressBehaviorUIValue
		{
			get
			{
				short num = (short)1987262684;
				short num2 = num;
				num = (short)1923430620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2023096320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1600978944;
				if (num != 0)
				{
				}
				num = (short)277151745;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O2GraphicView.MFKPressBehaviorUIValueProperty);
			}
			set
			{
				short num = (short)832045057;
				if (num != 0)
				{
				}
				num = (short)1447297024;
				short num2 = num;
				num = (short)861330030;
				short num3 = num;
				num = (short)2041698926;
				switch (num3 == num)
				{
				}
				num = (short)1329332224;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MFKPressBehaviorUIValueProperty, value);
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0006098C File Offset: 0x0005EB8C
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00060A44 File Offset: 0x0005EC44
		public AcpListField MFKPressBehaviorList
		{
			get
			{
				short num = (short)748858525;
				short num2 = num;
				num = (short)22785181;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1388576768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2141257728;
				if (num != 0)
				{
				}
				num = (short)449380353;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O2GraphicView.MFKPressBehaviorListProperty);
			}
			set
			{
				short num = (short)639913414;
				short num2 = num;
				num = (short)1210273222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2144731136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2068971520;
				if (num != 0)
				{
				}
				num = (short)323223553;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MFKPressBehaviorListProperty, value);
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00060AF8 File Offset: 0x0005ECF8
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00060BB4 File Offset: 0x0005EDB4
		public bool MFKButtonPrimaryIsAcpValid
		{
			get
			{
				short num = (short)268727132;
				short num2 = num;
				num = (short)2107077468;
				switch (num2 == num)
				{
				default:
				{
					num = (short)940572672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)732889089;
				if (num != 0)
				{
				}
				num = (short)1350762496;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.MFKButtonPrimaryIsAcpValidProperty);
			}
			set
			{
				short num = (short)1687406441;
				short num2 = num;
				num = (short)1857079145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)949026816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)977993729;
				if (num != 0)
				{
				}
				num = (short)1942487040;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MFKButtonPrimaryIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x00060C6C File Offset: 0x0005EE6C
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x00060D24 File Offset: 0x0005EF24
		public bool MFKButtonPrimaryIsAcpApplicable
		{
			get
			{
				short num = (short)780398322;
				short num2 = num;
				num = (short)659549938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2070020096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)100204544;
				if (num != 0)
				{
				}
				num = (short)128974849;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.MFKButtonPrimaryIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1270546433;
				if (num != 0)
				{
				}
				num = (short)500760576;
				short num2 = num;
				num = (short)2130282217;
				short num3 = num;
				num = (short)939362025;
				switch (num3 == num)
				{
				}
				num = (short)477757440;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MFKButtonPrimaryIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00060DE0 File Offset: 0x0005EFE0
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00060E98 File Offset: 0x0005F098
		public bool MFKButtonPrimaryIsAcpVisible
		{
			get
			{
				short num = (short)238765373;
				short num2 = num;
				num = (short)984630589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2012151808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1340342273;
				if (num != 0)
				{
				}
				num = (short)1305608192;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.MFKButtonPrimaryIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)208967768;
				short num2 = num;
				num = (short)394893400;
				switch (num2 == num)
				{
				default:
				{
					num = (short)480575488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1433468929;
				if (num != 0)
				{
				}
				num = (short)105775104;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MFKButtonPrimaryIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00060F54 File Offset: 0x0005F154
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00061010 File Offset: 0x0005F210
		public bool MFKButtonPrimaryIsAcpEditable
		{
			get
			{
				short num = (short)2111311414;
				short num2 = num;
				num = (short)409144886;
				switch (num2 == num)
				{
				default:
				{
					num = (short)957808640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1576140801;
				if (num != 0)
				{
				}
				num = (short)1634074624;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.MFKButtonPrimaryIsAcpEditableProperty);
			}
			set
			{
				short num = (short)331477644;
				short num2 = num;
				num = (short)1519186572;
				switch (num2 == num)
				{
				default:
				{
					num = (short)170262528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1986658305;
				if (num != 0)
				{
				}
				num = (short)1580072960;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MFKButtonPrimaryIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x000610C8 File Offset: 0x0005F2C8
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00061180 File Offset: 0x0005F380
		public string MFKButtonPrimaryUIValue
		{
			get
			{
				short num = (short)337248257;
				if (num != 0)
				{
				}
				num = (short)1417740288;
				short num2 = num;
				num = (short)42346526;
				short num3 = num;
				num = (short)1712269342;
				switch (num3 == num)
				{
				}
				num = (short)960692224;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O2GraphicView.MFKButtonPrimaryUIValueProperty);
			}
			set
			{
				short num = (short)2036009015;
				short num2 = num;
				num = (short)495061047;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1347682304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)486801409;
				if (num != 0)
				{
				}
				num = (short)1909391360;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MFKButtonPrimaryUIValueProperty, value);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00061234 File Offset: 0x0005F434
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x000612F0 File Offset: 0x0005F4F0
		public AcpListField MFKButtonPrimaryList
		{
			get
			{
				short num = (short)355193097;
				short num2 = num;
				num = (short)823054601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1298857984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1751252992;
				if (num != 0)
				{
				}
				num = (short)510722049;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O2GraphicView.MFKButtonPrimaryListProperty);
			}
			set
			{
				short num = (short)859872516;
				short num2 = num;
				num = (short)1340448004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1401421824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)893255680;
				if (num != 0)
				{
				}
				num = (short)1953693697;
				if (num != 0)
				{
				}
				base.SetValue(O2GraphicView.MFKButtonPrimaryListProperty, value);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x000613A8 File Offset: 0x0005F5A8
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x00061460 File Offset: 0x0005F660
		public bool MFKButtonSecondaryIsAcpValid
		{
			get
			{
				short num = (short)917607037;
				short num2 = num;
				num = (short)1169986173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)6160384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1772158977;
				if (num != 0)
				{
				}
				num = (short)267190272;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O2GraphicView.MFKButtonSecondaryIsAcpValidProperty);
			}
			set
			{
				short num = (short)545004697;
				short num2 = num;
				num = (short)999431321;
				switch (num2 == num)
				{
				}
				num = (short)328204289;
				if (num != 0)
				{
				}
				num = (short)1139671040;
				if (num != 0)
				{
				}
				num = (short)1424949248;
				short num3 = num;
				base.SetValue(O2GraphicView.MFKButtonSecondaryIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0006151C File Offset: 0x0005F71C
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x000615D8 File Offset: 0x0005F7D8
		public bool MFKButtonSecondaryIsAcpApplicable
		{
			get
			{
				short num = (short)497728851;
				short num2 = num;
				num = (short)668646739;
				switch (num2 == num)
				{
				}
				num = (short)1911881728;
				if (num != 0)
				{
				}
				num = (short)655163393;
				if (num != 0)
				{
				}
				num = (short)126812160;
				short num3 = num;
				return (bool)base.GetValue(O2GraphicView.MFKButtonSecondaryIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)890817350;
				short num2 = num;
				num = (short)161336134;
				switch (num2 == num)
				{
				}
				num = (short)343343104;
				if (num != 0)
				{
				}
				num = (short)103874561;
				if (num != 0)
				{
				}
				num = (short)86114304;
				short num3 = num;
				base.SetValue(O2GraphicView.MFKButtonSecondaryIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00061690 File Offset: 0x0005F890
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x0006174C File Offset: 0x0005F94C
		public bool MFKButtonSecondaryIsAcpVisible
		{
			get
			{
				short num = (short)552885121;
				short num2 = num;
				num = (short)55270273;
				switch (num2 == num)
				{
				}
				num = (short)1863122945;
				if (num != 0)
				{
				}
				num = (short)166461440;
				if (num != 0)
				{
				}
				num = (short)1431633920;
				short num3 = num;
				return (bool)base.GetValue(O2GraphicView.MFKButtonSecondaryIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1137225013;
				short num2 = num;
				num = (short)748399925;
				switch (num2 == num)
				{
				}
				num = (short)561577985;
				if (num != 0)
				{
				}
				num = (short)730398720;
				if (num != 0)
				{
				}
				num = (short)806092800;
				short num3 = num;
				base.SetValue(O2GraphicView.MFKButtonSecondaryIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00061804 File Offset: 0x0005FA04
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x000618BC File Offset: 0x0005FABC
		public bool MFKButtonSecondaryIsAcpEditable
		{
			get
			{
				short num = (short)1498887030;
				short num2 = num;
				num = (short)1295790966;
				switch (num2 == num)
				{
				}
				num = (short)498860033;
				if (num != 0)
				{
				}
				num = (short)651755520;
				if (num != 0)
				{
				}
				num = (short)1528233984;
				short num3 = num;
				return (bool)base.GetValue(O2GraphicView.MFKButtonSecondaryIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1049774674;
				short num2 = num;
				num = (short)1125468754;
				switch (num2 == num)
				{
				}
				num = (short)487325697;
				if (num != 0)
				{
				}
				num = (short)1487142912;
				if (num != 0)
				{
				}
				num = (short)2038431744;
				short num3 = num;
				base.SetValue(O2GraphicView.MFKButtonSecondaryIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00061974 File Offset: 0x0005FB74
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00061A2C File Offset: 0x0005FC2C
		public string MFKButtonSecondaryUIValue
		{
			get
			{
				short num = (short)870784668;
				short num2 = num;
				num = (short)1695620764;
				switch (num2 == num)
				{
				}
				num = (short)345899009;
				if (num != 0)
				{
				}
				num = (short)487653376;
				if (num != 0)
				{
				}
				num = (short)1703477248;
				short num3 = num;
				return (string)base.GetValue(O2GraphicView.MFKButtonSecondaryUIValueProperty);
			}
			set
			{
				short num = (short)1085625091;
				short num2 = num;
				num = (short)1289966339;
				switch (num2 == num)
				{
				}
				num = (short)9175041;
				if (num != 0)
				{
				}
				num = (short)1300627456;
				if (num != 0)
				{
				}
				num = (short)654508032;
				short num3 = num;
				base.SetValue(O2GraphicView.MFKButtonSecondaryUIValueProperty, value);
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00061AE0 File Offset: 0x0005FCE0
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00061B9C File Offset: 0x0005FD9C
		public AcpListField MFKButtonSecondaryList
		{
			get
			{
				short num = (short)404501283;
				short num2 = num;
				num = (short)347550499;
				switch (num2 == num)
				{
				}
				num = (short)196673537;
				if (num != 0)
				{
				}
				num = (short)1176698880;
				if (num != 0)
				{
				}
				num = (short)150274048;
				short num3 = num;
				return (AcpListField)base.GetValue(O2GraphicView.MFKButtonSecondaryListProperty);
			}
			set
			{
				short num = (short)1029405809;
				short num2 = num;
				num = (short)79723633;
				switch (num2 == num)
				{
				}
				num = (short)2123694080;
				if (num != 0)
				{
				}
				num = (short)1244725249;
				if (num != 0)
				{
				}
				num = (short)906887168;
				short num3 = num;
				base.SetValue(O2GraphicView.MFKButtonSecondaryListProperty, value);
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000624D4 File Offset: 0x000606D4
		// Note: this type is marked as 'beforefieldinit'.
		static O2GraphicView()
		{
			int a_ = 16;
			short num = (short)1218052097;
			if (num != 0)
			{
			}
			num = (short)1586837813;
			short num2 = num;
			num = (short)202127669;
			switch (num2 == num)
			{
			}
			num = (short)134610944;
			if (num != 0)
			{
			}
			num = (short)391643136;
			short num3 = num;
			O2GraphicView.EmergencyButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縺值娾㍀⑂⁄⥆⩈㉊ཌ㩎═❒㩔㥖὘㹚㱜⭞ᑠᅢd⹦ᩨ⩪๬Ὦ❰ቲᥴṶᵸ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縺值娾㍀⑂⁄⥆⩈㉊ཌ㩎═❒㩔㥖὘㹚㱜⭞ᑠᅢd⹦ᩨ⩪๬ὮばͲմ᭶ၸ᡺ᱼᵾ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縺值娾㍀⑂⁄⥆⩈㉊ཌ㩎═❒㩔㥖὘㹚㱜⭞ᑠᅢd⹦ᩨ⩪๬Ὦ❰ᩲٴṶ᭸᝺᡼", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.EmergencyButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縺值娾㍀⑂⁄⥆⩈㉊ཌ㩎═❒㩔㥖὘㹚㱜⭞ᑠᅢd⹦ᩨ⩪๬Ὦ㑰ᝲᱴͶᡸ᥺ᅼ᩾", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.EmergencyButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縺值娾㍀⑂⁄⥆⩈㉊ཌ㩎═❒㩔㥖὘㹚㱜⭞ᑠᅢd㉦⁨㵪౬ͮѰᙲ", a_), typeof(string), typeof(O2GraphicView));
			O2GraphicView.EmergencyButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縺值娾㍀⑂⁄⥆⩈㉊ཌ㩎═❒㩔㥖὘㹚㱜⭞ᑠᅢd⭦hᡪᥬ", a_), typeof(AcpListField), typeof(O2GraphicView));
			O2GraphicView.MenuItemsConventionalSelectedListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺堼儾㑀ੂㅄ≆⑈㡊์⁎㽐╒ご㥖ⵘ㉚㉜ㅞ`ར㙤ɦը๪๬᭮ᑰᝲ㥴Ṷ੸ེ", a_), typeof(AcpListField), typeof(O2GraphicView));
			O2GraphicView.MenuItemsTrunkingSelectedListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺堼儾㑀ੂㅄ≆⑈㡊᥌㵎⑐㵒㹔㹖㝘㱚๜㩞ൠ٢٤፦౨ཪⅬٮɰݲ", a_), typeof(AcpListField), typeof(O2GraphicView));
			O2GraphicView.MenuItemsConventionalSelectedListVisibilityProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺堼儾㑀ੂㅄ≆⑈㡊์⁎㽐╒ご㥖ⵘ㉚㉜ㅞ`ར㙤ɦը๪๬᭮ᑰᝲ㥴Ṷ੸ེ⭼ᙾ歷", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺堼儾㑀ੂㅄ≆⑈㡊᥌㵎⑐㵒㹔㹖㝘㱚๜㩞ൠ٢٤፦౨ཪⅬٮɰݲ⍴Ṷ੸ቺὼᙾﺆ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.UpButtonIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渺䴼紾㑀㝂ㅄ⡆❈Ɋ㹌๎㉐⍒͔㙖㕘㉚㥜", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.UpButtonIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渺䴼紾㑀㝂ㅄ⡆❈Ɋ㹌๎㉐⍒ᑔ❖⥘㝚㑜㱞`Ţ।ɦ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.UpButtonIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渺䴼紾㑀㝂ㅄ⡆❈Ɋ㹌๎㉐⍒͔㹖⩘㉚㽜㍞Ѡ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.UpButtonIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渺䴼紾㑀㝂ㅄ⡆❈Ɋ㹌๎㉐⍒ၔ㍖じ⽚㱜㵞ൠ٢", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.UpButtonUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渺䴼紾㑀㝂ㅄ⡆❈Ṋь᥎ぐ㽒⁔㉖", a_), typeof(string), typeof(O2GraphicView));
			O2GraphicView.UpButtonListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渺䴼紾㑀㝂ㅄ⡆❈݊⑌㱎═", a_), typeof(AcpListField), typeof(O2GraphicView));
			O2GraphicView.DownButtonIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("缺刼䠾⽀łい㍆㵈⑊⍌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.DownButtonIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("缺刼䠾⽀łい㍆㵈⑊⍌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.DownButtonIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("缺刼䠾⽀łい㍆㵈⑊⍌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.DownButtonIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("缺刼䠾⽀łい㍆㵈⑊⍌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.DownButtonUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("缺刼䠾⽀łい㍆㵈⑊⍌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(O2GraphicView));
			O2GraphicView.DownButtonListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("缺刼䠾⽀łい㍆㵈⑊⍌͎㡐⁒⅔", a_), typeof(AcpListField), typeof(O2GraphicView));
			O2GraphicView.MFKPressBehaviorIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾ᅀㅂ⁄㑆㩈ॊ⡌❎ぐ╒㱔㡖⭘ቚ⹜Ṟɠ።㍤٦ըɪ६", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.MFKPressBehaviorIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾ᅀㅂ⁄㑆㩈ॊ⡌❎ぐ╒㱔㡖⭘ቚ⹜Ṟɠ።⑤ᝦᥨݪѬ౮ၰᅲᥴቶ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.MFKPressBehaviorIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾ᅀㅂ⁄㑆㩈ॊ⡌❎ぐ╒㱔㡖⭘ቚ⹜Ṟɠ።㍤๦ᩨɪཬͮᑰ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.MFKPressBehaviorIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾ᅀㅂ⁄㑆㩈ॊ⡌❎ぐ╒㱔㡖⭘ቚ⹜Ṟɠ።⁤ͦhὪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.MFKPressBehaviorUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾ᅀㅂ⁄㑆㩈ॊ⡌❎ぐ╒㱔㡖⭘๚ᑜफ़`རၤɦ", a_), typeof(string), typeof(O2GraphicView));
			O2GraphicView.MFKPressBehaviorListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾ᅀㅂ⁄㑆㩈ॊ⡌❎ぐ╒㱔㡖⭘᝚㑜ⱞᕠ", a_), typeof(AcpListField), typeof(O2GraphicView));
			O2GraphicView.MFKButtonPrimaryIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾̀㙂ㅄ㍆♈╊ᵌ㵎㡐㹒㑔╖⁘ቚ⹜Ṟɠ።㍤٦ըɪ६", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.MFKButtonPrimaryIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾̀㙂ㅄ㍆♈╊ᵌ㵎㡐㹒㑔╖⁘ቚ⹜Ṟɠ።⑤ᝦᥨݪѬ౮ၰᅲᥴቶ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.MFKButtonPrimaryIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾̀㙂ㅄ㍆♈╊ᵌ㵎㡐㹒㑔╖⁘ቚ⹜Ṟɠ።㍤๦ᩨɪཬͮᑰ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.MFKButtonPrimaryIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾̀㙂ㅄ㍆♈╊ᵌ㵎㡐㹒㑔╖⁘ቚ⹜Ṟɠ።⁤ͦhὪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.MFKButtonPrimaryUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾̀㙂ㅄ㍆♈╊ᵌ㵎㡐㹒㑔╖⁘๚ᑜफ़`རၤɦ", a_), typeof(string), typeof(O2GraphicView));
			O2GraphicView.MFKButtonPrimaryListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾̀㙂ㅄ㍆♈╊ᵌ㵎㡐㹒㑔╖⁘᝚㑜ⱞᕠ", a_), typeof(AcpListField), typeof(O2GraphicView));
			O2GraphicView.MFKButtonSecondaryIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾̀㙂ㅄ㍆♈╊Ṍ⩎㉐㱒㭔㍖㡘⥚⑜ᙞበ≢٤ᝦ㽨੪Ŭٮᕰ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.MFKButtonSecondaryIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾̀㙂ㅄ㍆♈╊Ṍ⩎㉐㱒㭔㍖㡘⥚⑜ᙞበ≢٤ᝦ⡨᭪ᵬͮᡰၲᑴᕶᕸṺ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.MFKButtonSecondaryIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾̀㙂ㅄ㍆♈╊Ṍ⩎㉐㱒㭔㍖㡘⥚⑜ᙞበ≢٤ᝦ㽨ɪṬٮ፰ὲၴ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.MFKButtonSecondaryIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾̀㙂ㅄ㍆♈╊Ṍ⩎㉐㱒㭔㍖㡘⥚⑜ᙞበ≢٤ᝦⱨཪѬ᭮ၰᅲᥴቶ", a_), typeof(bool), typeof(O2GraphicView));
			O2GraphicView.MFKButtonSecondaryUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾̀㙂ㅄ㍆♈╊Ṍ⩎㉐㱒㭔㍖㡘⥚⑜ਫ਼⡠㕢Ѥ୦ᱨ๪", a_), typeof(string), typeof(O2GraphicView));
			O2GraphicView.MFKButtonSecondaryListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘺笼琾̀㙂ㅄ㍆♈╊Ṍ⩎㉐㱒㭔㍖㡘⥚⑜፞ࡠၢᅤ", a_), typeof(AcpListField), typeof(O2GraphicView));
		}

		// Token: 0x04000751 RID: 1873
		private bool mFKEmergencyAccess;

		// Token: 0x04000752 RID: 1874
		public static DependencyProperty EmergencyButtonFeatureIsAcpValidProperty;

		// Token: 0x04000753 RID: 1875
		public static DependencyProperty EmergencyButtonFeatureIsAcpApplicableProperty;

		// Token: 0x04000754 RID: 1876
		public static DependencyProperty EmergencyButtonFeatureIsAcpVisibleProperty;

		// Token: 0x04000755 RID: 1877
		public static DependencyProperty EmergencyButtonFeatureIsAcpEditableProperty;

		// Token: 0x04000756 RID: 1878
		public static DependencyProperty EmergencyButtonFeatureUIValueProperty;

		// Token: 0x04000757 RID: 1879
		public static DependencyProperty EmergencyButtonFeatureListProperty;

		// Token: 0x04000758 RID: 1880
		public static DependencyProperty MenuItemsConventionalSelectedListProperty;

		// Token: 0x04000759 RID: 1881
		public static DependencyProperty MenuItemsTrunkingSelectedListProperty;

		// Token: 0x0400075A RID: 1882
		public static DependencyProperty MenuItemsConventionalSelectedListVisibilityProperty;

		// Token: 0x0400075B RID: 1883
		public static DependencyProperty MenuItemsTrunkingSelectedListVisibilityProperty;

		// Token: 0x0400075C RID: 1884
		public static DependencyProperty UpButtonIsAcpValidProperty;

		// Token: 0x0400075D RID: 1885
		public static DependencyProperty UpButtonIsAcpApplicableProperty;

		// Token: 0x0400075E RID: 1886
		public static DependencyProperty UpButtonIsAcpVisibleProperty;

		// Token: 0x0400075F RID: 1887
		public static DependencyProperty UpButtonIsAcpEditableProperty;

		// Token: 0x04000760 RID: 1888
		public static DependencyProperty UpButtonUIValueProperty;

		// Token: 0x04000761 RID: 1889
		public static DependencyProperty UpButtonListProperty;

		// Token: 0x04000762 RID: 1890
		public static DependencyProperty DownButtonIsAcpValidProperty;

		// Token: 0x04000763 RID: 1891
		public static DependencyProperty DownButtonIsAcpApplicableProperty;

		// Token: 0x04000764 RID: 1892
		public static DependencyProperty DownButtonIsAcpVisibleProperty;

		// Token: 0x04000765 RID: 1893
		public static DependencyProperty DownButtonIsAcpEditableProperty;

		// Token: 0x04000766 RID: 1894
		public static DependencyProperty DownButtonUIValueProperty;

		// Token: 0x04000767 RID: 1895
		public static DependencyProperty DownButtonListProperty;

		// Token: 0x04000768 RID: 1896
		public static DependencyProperty MFKPressBehaviorIsAcpValidProperty;

		// Token: 0x04000769 RID: 1897
		public static DependencyProperty MFKPressBehaviorIsAcpApplicableProperty;

		// Token: 0x0400076A RID: 1898
		public static DependencyProperty MFKPressBehaviorIsAcpVisibleProperty;

		// Token: 0x0400076B RID: 1899
		public static DependencyProperty MFKPressBehaviorIsAcpEditableProperty;

		// Token: 0x0400076C RID: 1900
		public static DependencyProperty MFKPressBehaviorUIValueProperty;

		// Token: 0x0400076D RID: 1901
		public static DependencyProperty MFKPressBehaviorListProperty;

		// Token: 0x0400076E RID: 1902
		public static DependencyProperty MFKButtonPrimaryIsAcpValidProperty;

		// Token: 0x0400076F RID: 1903
		public static DependencyProperty MFKButtonPrimaryIsAcpApplicableProperty;

		// Token: 0x04000770 RID: 1904
		public static DependencyProperty MFKButtonPrimaryIsAcpVisibleProperty;

		// Token: 0x04000771 RID: 1905
		public static DependencyProperty MFKButtonPrimaryIsAcpEditableProperty;

		// Token: 0x04000772 RID: 1906
		public static DependencyProperty MFKButtonPrimaryUIValueProperty;

		// Token: 0x04000773 RID: 1907
		public static DependencyProperty MFKButtonPrimaryListProperty;

		// Token: 0x04000774 RID: 1908
		public static DependencyProperty MFKButtonSecondaryIsAcpValidProperty;

		// Token: 0x04000775 RID: 1909
		public static DependencyProperty MFKButtonSecondaryIsAcpApplicableProperty;

		// Token: 0x04000776 RID: 1910
		public static DependencyProperty MFKButtonSecondaryIsAcpVisibleProperty;

		// Token: 0x04000777 RID: 1911
		public static DependencyProperty MFKButtonSecondaryIsAcpEditableProperty;

		// Token: 0x04000778 RID: 1912
		public static DependencyProperty MFKButtonSecondaryUIValueProperty;

		// Token: 0x04000779 RID: 1913
		public static DependencyProperty MFKButtonSecondaryListProperty;
	}
}
