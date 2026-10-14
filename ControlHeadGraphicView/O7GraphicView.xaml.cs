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
	// Token: 0x0200000C RID: 12
	public partial class O7GraphicView : UserControl
	{
		// Token: 0x06000811 RID: 2065 RVA: 0x00075FC8 File Offset: 0x000741C8
		public O7GraphicView()
		{
			base.FlowDirection = FlowDirection.LeftToRight;
			this.InitializeComponent();
			base.DataContext = this;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00075FF0 File Offset: 0x000741F0
		private void OnFieldNameDoubleClick(object sender, RoutedEventArgs e)
		{
			short num = (short)1633812481;
			if (num != 0)
			{
			}
			num = (short)476740660;
			short num2 = num;
			num = (short)2104261684;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1363410944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1165885440;
			if (num != 0)
			{
			}
			Utility.GetFieldHelpText(sender);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x000760A0 File Offset: 0x000742A0
		public override void EndInit()
		{
			short num = (short)2125538394;
			short num2 = num;
			num = (short)1755194458;
			switch (num2 == num)
			{
			}
			num = (short)77463552;
			short num3 = num;
			num = (short)1687945217;
			if (num != 0)
			{
			}
			num = (short)1108082688;
			if (num != 0)
			{
			}
			base.EndInit();
			this.SetMenuItems();
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00076154 File Offset: 0x00074354
		public void SetMenuItems()
		{
			short num = (short)1747189765;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_254;
				case 1:
				{
					int count = this.MenuItemsConventionalSelectedList.Items.Count;
					if (count >= 1)
					{
						this.bottom_screen_info.Content = this.MenuItemsConventionalSelectedList.Items[0].ItemName;
						this.bottom_screen_info.Tag = 0;
					}
					else
					{
						this.bottom_screen_info.Content = string.Empty;
						this.bottom_screen_info.Tag = 0;
					}
					if (count >= 2)
					{
						this.bottom_screen_scan.Content = this.MenuItemsConventionalSelectedList.Items[1].ItemName;
					}
					else
					{
						this.bottom_screen_scan.Content = string.Empty;
					}
					if (count >= 3)
					{
						this.bottom_screen_zone.Content = this.MenuItemsConventionalSelectedList.Items[2].ItemName;
					}
					else
					{
						this.bottom_screen_zone.Content = string.Empty;
					}
					if (count >= 4)
					{
						num = (short)1442578438;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_status.Content = string.Empty;
					num = (short)273154048;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 2:
					return;
				case 3:
				{
					num = (short)151191552;
					short num3 = num;
					goto IL_254;
				}
				case 4:
				{
					int count2 = this.MenuItemsTrunkingSelectedList.Items.Count;
					if (count2 >= 1)
					{
						this.bottom_screen_info_Copy.Content = this.MenuItemsTrunkingSelectedList.Items[0].ItemName;
						this.bottom_screen_info_Copy.Tag = 0;
					}
					else
					{
						this.bottom_screen_info_Copy.Content = string.Empty;
						this.bottom_screen_info_Copy.Tag = 0;
					}
					if (count2 >= 2)
					{
						this.bottom_screen_scan_Copy.Content = this.MenuItemsTrunkingSelectedList.Items[1].ItemName;
					}
					else
					{
						this.bottom_screen_scan_Copy.Content = string.Empty;
					}
					if (count2 >= 3)
					{
						this.bottom_screen_zone_Copy.Content = this.MenuItemsTrunkingSelectedList.Items[2].ItemName;
					}
					else
					{
						this.bottom_screen_zone_Copy.Content = string.Empty;
					}
					if (count2 >= 4)
					{
						num = (short)1377959943;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3B5;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 6:
					this.bottom_screen_status.Content = this.MenuItemsConventionalSelectedList.Items[3].ItemName;
					num = (short)1481179139;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					goto IL_368;
				}
				IL_44:
				if (this.MenuItemsConventionalSelectedList == null)
				{
					num = (short)373096450;
					num2 = (int)((IntPtr)num);
					continue;
				}
				num = (short)759280419;
				short num4 = num;
				num = (short)903590691;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3B5;
				default:
					num = (short)1478295552;
					if (num != 0)
					{
					}
					num = (short)1120993281;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_254:
				num = (short)628031492;
				num2 = (int)((IntPtr)num);
			}
			return;
			IL_368:
			num = (short)1952972801;
			if (num != 0)
			{
			}
			this.bottom_screen_status_Copy.Content = this.MenuItemsTrunkingSelectedList.Items[3].ItemName;
			return;
			IL_3B5:
			this.bottom_screen_status_Copy.Content = string.Empty;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00076528 File Offset: 0x00074728
		private void NavLeftRight_Click(object sender, RoutedEventArgs e)
		{
			int a_ = 11;
			short num = (short)1780154368;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				int count;
				int count2;
				int num3;
				ToggleButton toggleButton;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if ((int)this.bottom_screen_info_Copy.Tag > 0)
						{
							num = (short)613613572;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 1:
						num = (short)777322516;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						num = (short)1085014023;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						count = this.MenuItemsConventionalSelectedList.Items.Count;
						count2 = this.MenuItemsTrunkingSelectedList.Items.Count;
						num3 = 4;
						num = (short)1797062678;
						num2 = (int)((IntPtr)num);
						continue;
					case 4:
					{
						num = (short)88939676;
						short num4 = num;
						num = (short)1355160732;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1AF;
						default:
							num = (short)1960574976;
							if (num != 0)
							{
							}
							num = (short)76218378;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_2E5;
					case 6:
						if (toggleButton != null)
						{
							num = (short)1970208771;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 7:
						if (!this.MenuItemsConventionalSelectedList.Visible)
						{
							num = (short)1328545808;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_44F;
					case 8:
						num = (short)2055274507;
						num2 = (int)((IntPtr)num);
						continue;
					case 9:
						if (toggleButton.Name.Equals(O9GraphicviewMenuItemsVisibilityConverter.b("搵儷崹吻䨽ȿ㝁ぃ㉅❇⑉", a_)))
						{
							num = (short)173146125;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 10:
						if (this.MenuItemsTrunkingSelectedList.Visible)
						{
							num = (short)984219667;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 11:
						if (!this.MenuItemsConventionalSelectedList.Visible)
						{
							num = (short)1247215630;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2E5;
					case 12:
					{
						num = (short)250216448;
						short num5 = num;
						if (this.MenuItemsTrunkingSelectedList.Visible)
						{
							num = (short)771883013;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 13:
						num = (short)1607139346;
						num2 = (int)((IntPtr)num);
						continue;
					case 14:
						goto IL_400;
					case 15:
						goto IL_33D;
					case 16:
						goto IL_1AF;
					case 17:
						num = (short)422379532;
						num2 = (int)((IntPtr)num);
						continue;
					case 18:
						if ((int)this.bottom_screen_info.Tag + num3 < count)
						{
							num = (short)1706033160;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_400;
					case 19:
						goto IL_382;
					case 20:
						if ((int)this.bottom_screen_info.Tag > 0)
						{
							num = (short)21889025;
							if (num != 0)
							{
							}
							num = (short)1125777410;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_490;
					case 21:
						if ((int)this.bottom_screen_info_Copy.Tag + num3 < count2)
						{
							num = (short)1009844241;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 22:
						if (toggleButton.Name.Equals(O9GraphicviewMenuItemsVisibilityConverter.b("稵崷尹䠻簽㔿㙁ぃ⥅♇", a_)))
						{
							num = (short)389742593;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1704198153;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_93;
					IL_2E5:
					int index = (int)this.bottom_screen_info.Tag + num3;
					int index_trk = (int)this.bottom_screen_info_Copy.Tag + num3;
					this.navigateMenuItems(index, index_trk, count, count2, this.MenuItemsConventionalSelectedList, this.MenuItemsTrunkingSelectedList);
					num = (short)1455554575;
					num2 = (int)((IntPtr)num);
					continue;
					IL_400:
					num = (short)384172053;
					num2 = (int)((IntPtr)num);
					continue;
					IL_490:
					num = (short)447610880;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1AF:
					goto IL_490;
				}
				IL_33D:
				return;
				IL_382:
				IL_44F:
				int index2 = (int)this.bottom_screen_info.Tag - num3;
				int index_trk2 = (int)this.bottom_screen_info_Copy.Tag - num3;
				this.navigateMenuItems(index2, index_trk2, count, count2, this.MenuItemsConventionalSelectedList, this.MenuItemsTrunkingSelectedList);
				return;
				IL_93:
				toggleButton = (sender as ToggleButton);
				num = (short)30212102;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00076A5C File Offset: 0x00074C5C
		private void navigateMenuItems(int index, int index_trk, int count, int count_trk, AcpListField cnv, AcpListField trk)
		{
			short num = (short)552665113;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1348599817;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					this.bottom_screen_status_Copy.Content = trk.Items[index_trk + 3].ItemName;
					num = (short)1603207208;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_34C;
				case 3:
					this.bottom_screen_zone_Copy.Content = trk.Items[index_trk + 2].ItemName;
					num = (short)213516301;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					num = (short)1420951562;
					num2 = (int)((IntPtr)num);
					continue;
				case 5:
					goto IL_727;
				case 6:
					goto IL_5EF;
				case 7:
					goto IL_5EF;
				case 8:
					if (index_trk >= 0)
					{
						num = (short)55640107;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_515;
				case 9:
					if (index_trk + 1 < count_trk)
					{
						num = (short)1689255972;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_773;
				case 10:
					if (index + 3 < count)
					{
						num = (short)1633091604;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6FC;
				case 11:
					if (index >= 0)
					{
						num = (short)1279852582;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_62A;
				case 12:
					goto IL_542;
				case 13:
					num = (short)642842625;
					if (num != 0)
					{
					}
					goto IL_389;
				case 14:
					this.bottom_screen_scan.Content = cnv.Items[index + 1].ItemName;
					num = (short)1456930846;
					num2 = (int)((IntPtr)num);
					continue;
				case 15:
					goto IL_5B5;
				case 16:
					this.bottom_screen_info_Copy.Content = trk.Items[index_trk].ItemName;
					num = (short)1221656583;
					num2 = (int)((IntPtr)num);
					continue;
				case 17:
					if (index >= 0)
					{
						num = (short)1092878364;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1C8;
				case 18:
					if (index >= 0)
					{
						num = (short)1180434436;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6FC;
				case 19:
					if (index_trk >= 0)
					{
						num = (short)1829568539;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_800;
				case 20:
					this.bottom_screen_status.Content = cnv.Items[index + 3].ItemName;
					num = (short)740163589;
					num2 = (int)((IntPtr)num);
					continue;
				case 21:
					if (index + 2 < count)
					{
						num = (short)506003482;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_62A;
				case 22:
					num = (short)1576861735;
					num2 = (int)((IntPtr)num);
					continue;
				case 23:
					goto IL_542;
				case 24:
					goto IL_257;
				case 25:
					switch (0)
					{
					case 0:
						goto IL_E4;
					}
					continue;
				case 26:
					this.bottom_screen_zone.Content = cnv.Items[index + 2].ItemName;
					num = (short)1518993445;
					num2 = (int)((IntPtr)num);
					continue;
				case 27:
					num = (short)1589706787;
					num2 = (int)((IntPtr)num);
					continue;
				case 28:
					num = (short)1545338922;
					num2 = (int)((IntPtr)num);
					continue;
				case 29:
					if (index_trk >= 0)
					{
						num = (short)1295777792;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_773;
				case 30:
					goto IL_34C;
				case 31:
					num = (short)1568276513;
					num2 = (int)((IntPtr)num);
					continue;
				case 32:
					goto IL_389;
				case 33:
					if (index < count)
					{
						num = (short)213975085;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_656;
				case 34:
					goto IL_3A0;
				case 35:
					if (index_trk < count_trk)
					{
						num = (short)2073821200;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_800;
				case 36:
				{
					num = (short)1864518358;
					short num3 = num;
					num = (short)2029341398;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A0;
					default:
						num = (short)1982201856;
						if (num != 0)
						{
						}
						this.bottom_screen_scan_Copy.Content = trk.Items[index_trk + 1].ItemName;
						num = (short)1387855895;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 37:
					goto IL_5B5;
				case 38:
					num = (short)979697685;
					num2 = (int)((IntPtr)num);
					continue;
				case 39:
					if (index_trk + 3 < count_trk)
					{
						num = (short)1008140289;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3C0;
				case 40:
					goto IL_862;
				case 41:
					goto IL_3E7;
				case 42:
					if (index + 1 < count)
					{
						num = (short)1333985294;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1C8;
				case 43:
					num = (short)1602158639;
					num2 = (int)((IntPtr)num);
					continue;
				case 44:
					goto IL_257;
				case 45:
					this.bottom_screen_info.Content = cnv.Items[index].ItemName;
					num = (short)717226008;
					num2 = (int)((IntPtr)num);
					continue;
				case 46:
					goto IL_727;
				case 47:
					if (index_trk + 2 < count_trk)
					{
						num = (short)35061763;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_515;
				}
				IL_E4:
				if (index >= 0)
				{
					num = (short)1344471071;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_656;
				IL_1C8:
				this.bottom_screen_scan.Content = string.Empty;
				num = (short)1797128194;
				num2 = (int)((IntPtr)num);
				continue;
				IL_257:
				num = (short)414056465;
				num2 = (int)((IntPtr)num);
				continue;
				IL_34C:
				num = (short)1256390667;
				num2 = (int)((IntPtr)num);
				continue;
				IL_389:
				num = (short)1315045410;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3A0:
				if (index_trk >= 0)
				{
					num = (short)500891670;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_3C0:
				this.bottom_screen_status_Copy.Content = string.Empty;
				num = (short)409141289;
				num2 = (int)((IntPtr)num);
				continue;
				IL_515:
				this.bottom_screen_zone_Copy.Content = string.Empty;
				num = (short)1231945760;
				num2 = (int)((IntPtr)num);
				continue;
				IL_542:
				num = (short)1461059592;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5B5:
				num = (short)771751954;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5EF:
				num = (short)1466302493;
				num2 = (int)((IntPtr)num);
				continue;
				IL_62A:
				this.bottom_screen_zone.Content = string.Empty;
				num = (short)935591951;
				num2 = (int)((IntPtr)num);
				continue;
				IL_656:
				this.bottom_screen_info.Content = string.Empty;
				num = (short)1466105900;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6FC:
				this.bottom_screen_status.Content = string.Empty;
				num = (short)1835204654;
				num2 = (int)((IntPtr)num);
				continue;
				IL_727:
				this.bottom_screen_info.Tag = index;
				num = (short)902430739;
				num2 = (int)((IntPtr)num);
				continue;
				IL_773:
				num = (short)715390976;
				short num4 = num;
				this.bottom_screen_scan_Copy.Content = string.Empty;
				num = (short)1505361932;
				num2 = (int)((IntPtr)num);
				continue;
				IL_800:
				this.bottom_screen_info_Copy.Content = string.Empty;
				num = (short)2073952262;
				num2 = (int)((IntPtr)num);
			}
			IL_3E7:
			IL_862:
			this.bottom_screen_info_Copy.Tag = index_trk;
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x000772E0 File Offset: 0x000754E0
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00077398 File Offset: 0x00075598
		public bool EmergencyButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)965869568;
				short num2 = num;
				num = (short)1413452196;
				short num3 = num;
				num = (short)1423282596;
				switch (num3 == num)
				{
				}
				num = (short)280035329;
				if (num != 0)
				{
				}
				num = (short)1844314112;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.EmergencyButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1698496512;
				short num2 = num;
				num = (short)680128760;
				short num3 = num;
				num = (short)641724664;
				switch (num3 == num)
				{
				}
				num = (short)87687169;
				if (num != 0)
				{
				}
				num = (short)871825408;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.EmergencyButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00077454 File Offset: 0x00075654
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x0007750C File Offset: 0x0007570C
		public bool EmergencyButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1918763008;
				short num2 = num;
				num = (short)891781146;
				short num3 = num;
				num = (short)140804122;
				switch (num3 == num)
				{
				}
				num = (short)1646264321;
				if (num != 0)
				{
				}
				num = (short)2068971520;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1389166592;
				short num2 = num;
				num = (short)92412090;
				short num3 = num;
				num = (short)203888826;
				switch (num3 == num)
				{
				}
				num = (short)1640824833;
				if (num != 0)
				{
				}
				num = (short)2114387968;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x000775C8 File Offset: 0x000757C8
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00077684 File Offset: 0x00075884
		public bool EmergencyButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1621753856;
				short num2 = num;
				num = (short)2050157765;
				short num3 = num;
				num = (short)1957555397;
				switch (num3 == num)
				{
				}
				num = (short)78446593;
				if (num != 0)
				{
				}
				num = (short)388431872;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)219807744;
				short num2 = num;
				num = (short)2120218138;
				short num3 = num;
				num = (short)664598042;
				switch (num3 == num)
				{
				}
				num = (short)1530527744;
				if (num != 0)
				{
				}
				num = (short)215285761;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x0007773C File Offset: 0x0007593C
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x000777F4 File Offset: 0x000759F4
		public bool EmergencyButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)593035264;
				short num2 = num;
				num = (short)424148993;
				if (num != 0)
				{
				}
				num = (short)344586386;
				short num3 = num;
				num = (short)341047442;
				switch (num3 == num)
				{
				}
				num = (short)1589641216;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.EmergencyButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1688928256;
				short num2 = num;
				num = (short)1856149006;
				short num3 = num;
				num = (short)265655822;
				switch (num3 == num)
				{
				}
				num = (short)1562050561;
				if (num != 0)
				{
				}
				num = (short)1676607488;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.EmergencyButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x000778B0 File Offset: 0x00075AB0
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x0007796C File Offset: 0x00075B6C
		public string EmergencyButtonFeatureUIValue
		{
			get
			{
				short num = (short)312147968;
				short num2 = num;
				num = (short)556859393;
				if (num != 0)
				{
				}
				num = (short)319989630;
				short num3 = num;
				num = (short)134915966;
				switch (num3 == num)
				{
				}
				num = (short)410648576;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O7GraphicView.EmergencyButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)498139136;
				short num2 = num;
				num = (short)437087836;
				short num3 = num;
				num = (short)1157852764;
				switch (num3 == num)
				{
				}
				num = (short)1954545664;
				if (num != 0)
				{
				}
				num = (short)254279681;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.EmergencyButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00077A24 File Offset: 0x00075C24
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00077ADC File Offset: 0x00075CDC
		public AcpListField EmergencyButtonFeatureList
		{
			get
			{
				short num = (short)1459290112;
				short num2 = num;
				num = (short)1484969499;
				short num3 = num;
				num = (short)131913243;
				switch (num3 == num)
				{
				}
				num = (short)2949120;
				if (num != 0)
				{
				}
				num = (short)2127429633;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O7GraphicView.EmergencyButtonFeatureListProperty);
			}
			set
			{
				short num = (short)131268608;
				short num2 = num;
				num = (short)1917796826;
				short num3 = num;
				num = (short)29508058;
				switch (num3 == num)
				{
				}
				num = (short)1102643201;
				if (num != 0)
				{
				}
				num = (short)476708864;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.EmergencyButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00077B94 File Offset: 0x00075D94
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00077C4C File Offset: 0x00075E4C
		public AcpListField MenuItemsConventionalSelectedList
		{
			get
			{
				short num = (short)642908160;
				short num2 = num;
				num = (short)1471418695;
				short num3 = num;
				num = (short)1164120391;
				switch (num3 == num)
				{
				}
				num = (short)597295104;
				if (num != 0)
				{
				}
				num = (short)764739585;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O7GraphicView.MenuItemsConventionalSelectedListProperty);
			}
			set
			{
				short num = (short)346488832;
				short num2 = num;
				num = (short)437523469;
				short num3 = num;
				num = (short)1398608909;
				switch (num3 == num)
				{
				}
				num = (short)892403713;
				if (num != 0)
				{
				}
				num = (short)2037121024;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MenuItemsConventionalSelectedListProperty, value);
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00077D00 File Offset: 0x00075F00
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00077DB8 File Offset: 0x00075FB8
		public AcpListField MenuItemsTrunkingSelectedList
		{
			get
			{
				short num = (short)1473118208;
				short num2 = num;
				num = (short)617266792;
				short num3 = num;
				num = (short)1680260712;
				switch (num3 == num)
				{
				}
				num = (short)95879168;
				if (num != 0)
				{
				}
				num = (short)1998258177;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O7GraphicView.MenuItemsTrunkingSelectedListProperty);
			}
			set
			{
				short num = (short)1363673088;
				short num2 = num;
				num = (short)705560577;
				if (num != 0)
				{
				}
				num = (short)1344087209;
				short num3 = num;
				num = (short)281289897;
				switch (num3 == num)
				{
				}
				num = (short)192544768;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MenuItemsTrunkingSelectedListProperty, value);
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00077E70 File Offset: 0x00076070
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00077F2C File Offset: 0x0007612C
		public bool MenuItemsConventionalSelectedListVisibility
		{
			get
			{
				short num = (short)1817247744;
				short num2 = num;
				num = (short)559597960;
				short num3 = num;
				num = (short)1573767560;
				switch (num3 == num)
				{
				}
				num = (short)527237121;
				if (num != 0)
				{
				}
				num = (short)29229056;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MenuItemsConventionalSelectedListVisibilityProperty);
			}
			set
			{
				short num = (short)1953103872;
				short num2 = num;
				num = (short)1088884936;
				short num3 = num;
				num = (short)180424904;
				switch (num3 == num)
				{
				}
				num = (short)1920729089;
				if (num != 0)
				{
				}
				num = (short)2073952256;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MenuItemsConventionalSelectedListVisibilityProperty, value);
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00077FE8 File Offset: 0x000761E8
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x000780A4 File Offset: 0x000762A4
		public bool MenuItemsTrunkingSelectedListVisibility
		{
			get
			{
				short num = (short)912064512;
				short num2 = num;
				num = (short)1989001250;
				short num3 = num;
				num = (short)1790361634;
				switch (num3 == num)
				{
				}
				num = (short)515244032;
				if (num != 0)
				{
				}
				num = (short)672661505;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty);
			}
			set
			{
				short num = (short)542364403;
				short num2 = num;
				num = (short)809554675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)993329152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)312475648;
				if (num != 0)
				{
				}
				num = (short)1251672065;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty, value);
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00078160 File Offset: 0x00076360
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x0007821C File Offset: 0x0007641C
		public bool UpButtonIsAcpValid
		{
			get
			{
				short num = (short)1769061869;
				short num2 = num;
				num = (short)2023734765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)810876928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1895563265;
				if (num != 0)
				{
				}
				num = (short)692715520;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.UpButtonIsAcpValidProperty);
			}
			set
			{
				short num = (short)805739926;
				short num2 = num;
				num = (short)567319958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)530448384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1250099201;
				if (num != 0)
				{
				}
				num = (short)188940288;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.UpButtonIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x000782D8 File Offset: 0x000764D8
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00078394 File Offset: 0x00076594
		public bool UpButtonIsAcpApplicable
		{
			get
			{
				short num = (short)1672561454;
				short num2 = num;
				num = (short)1386300206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2039676928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1252851713;
				if (num != 0)
				{
				}
				num = (short)1342242816;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.UpButtonIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1905285124;
				short num2 = num;
				num = (short)1242126340;
				switch (num2 == num)
				{
				default:
				{
					num = (short)921239552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)935395328;
				if (num != 0)
				{
				}
				num = (short)1393623041;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.UpButtonIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00078450 File Offset: 0x00076650
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x0007850C File Offset: 0x0007670C
		public bool UpButtonIsAcpVisible
		{
			get
			{
				short num = (short)401740270;
				short num2 = num;
				num = (short)865210862;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1417478144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)163774465;
				if (num != 0)
				{
				}
				num = (short)1392771072;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.UpButtonIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1805058993;
				short num2 = num;
				num = (short)1211433905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2107572224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2036793345;
				if (num != 0)
				{
				}
				num = (short)304283648;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.UpButtonIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x000785C8 File Offset: 0x000767C8
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x00078684 File Offset: 0x00076884
		public bool UpButtonIsAcpEditable
		{
			get
			{
				short num = (short)1791047902;
				short num2 = num;
				num = (short)935344350;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1150877696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1143078912;
				if (num != 0)
				{
				}
				num = (short)548864001;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.UpButtonIsAcpEditableProperty);
			}
			set
			{
				short num = (short)895376419;
				short num2 = num;
				num = (short)1740725283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)861011968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1583546368;
				if (num != 0)
				{
				}
				num = (short)1372192769;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.UpButtonIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x00078740 File Offset: 0x00076940
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x000787FC File Offset: 0x000769FC
		public string UpButtonUIValue
		{
			get
			{
				short num = (short)1375139884;
				short num2 = num;
				num = (short)498202668;
				switch (num2 == num)
				{
				default:
				{
					num = (short)279642112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1896087552;
				if (num != 0)
				{
				}
				num = (short)326893569;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O7GraphicView.UpButtonUIValueProperty);
			}
			set
			{
				short num = (short)1988758003;
				short num2 = num;
				num = (short)1116801523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)869531648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)360185857;
				if (num != 0)
				{
				}
				num = (short)2074607616;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.UpButtonUIValueProperty, value);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x000788B0 File Offset: 0x00076AB0
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x0007896C File Offset: 0x00076B6C
		public AcpListField UpButtonList
		{
			get
			{
				short num = (short)877869734;
				short num2 = num;
				num = (short)1108490918;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1223426048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)387055616;
				if (num != 0)
				{
				}
				num = (short)967770113;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O7GraphicView.UpButtonListProperty);
			}
			set
			{
				short num = (short)894582019;
				short num2 = num;
				num = (short)1059667203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)960954368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1957429248;
				if (num != 0)
				{
				}
				num = (short)472383489;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.UpButtonListProperty, value);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00078A24 File Offset: 0x00076C24
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00078ADC File Offset: 0x00076CDC
		public bool DownButtonIsAcpValid
		{
			get
			{
				short num = (short)473065636;
				short num2 = num;
				num = (short)1444243620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)668205056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)474218497;
				if (num != 0)
				{
				}
				num = (short)9895936;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DownButtonIsAcpValidProperty);
			}
			set
			{
				short num = (short)839045514;
				short num2 = num;
				num = (short)1852756362;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1063059456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1587609601;
				if (num != 0)
				{
				}
				num = (short)16384000;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DownButtonIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00078B98 File Offset: 0x00076D98
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00078C50 File Offset: 0x00076E50
		public bool DownButtonIsAcpApplicable
		{
			get
			{
				short num = (short)827773444;
				short num2 = num;
				num = (short)834916868;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1270153216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1246887937;
				if (num != 0)
				{
				}
				num = (short)1938096128;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DownButtonIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1369750548;
				short num2 = num;
				num = (short)622509076;
				switch (num2 == num)
				{
				default:
				{
					num = (short)797114368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1531510785;
				if (num != 0)
				{
				}
				num = (short)1601765376;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DownButtonIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00078D0C File Offset: 0x00076F0C
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00078DC8 File Offset: 0x00076FC8
		public bool DownButtonIsAcpVisible
		{
			get
			{
				short num = (short)393091047;
				short num2 = num;
				num = (short)1836586983;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1745879040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1565655041;
				if (num != 0)
				{
				}
				num = (short)2036924416;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DownButtonIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1729787663;
				short num2 = num;
				num = (short)587953935;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521221632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1420558337;
				if (num != 0)
				{
				}
				num = (short)944177152;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DownButtonIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00078E84 File Offset: 0x00077084
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00078F3C File Offset: 0x0007713C
		public bool DownButtonIsAcpEditable
		{
			get
			{
				short num = (short)1039394010;
				short num2 = num;
				num = (short)1402201306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)835059712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)654966785;
				if (num != 0)
				{
				}
				num = (short)5373952;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DownButtonIsAcpEditableProperty);
			}
			set
			{
				short num = (short)685289959;
				short num2 = num;
				num = (short)1028108775;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1113653248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1336410113;
				if (num != 0)
				{
				}
				num = (short)1524891648;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DownButtonIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00078FF8 File Offset: 0x000771F8
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x000790B4 File Offset: 0x000772B4
		public string DownButtonUIValue
		{
			get
			{
				short num = (short)1010889984;
				short num2 = num;
				num = (short)54916352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1569652736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)919732225;
				if (num != 0)
				{
				}
				num = (short)1642266624;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O7GraphicView.DownButtonUIValueProperty);
			}
			set
			{
				short num = (short)1384341183;
				short num2 = num;
				num = (short)809000639;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1720385536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)788004864;
				if (num != 0)
				{
				}
				num = (short)1306394625;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DownButtonUIValueProperty, value);
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0007916C File Offset: 0x0007736C
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00079228 File Offset: 0x00077428
		public AcpListField DownButtonList
		{
			get
			{
				short num = (short)1387727113;
				short num2 = num;
				num = (short)1544685833;
				switch (num2 == num)
				{
				default:
				{
					num = (short)802422784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1781596161;
				if (num != 0)
				{
				}
				num = (short)1849360384;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O7GraphicView.DownButtonListProperty);
			}
			set
			{
				short num = (short)73890917;
				short num2 = num;
				num = (short)850164837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2106327040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)554172416;
				if (num != 0)
				{
				}
				num = (short)549519361;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DownButtonListProperty, value);
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x000792E0 File Offset: 0x000774E0
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00079398 File Offset: 0x00077598
		public bool MFKPressBehaviorIsAcpValid
		{
			get
			{
				short num = (short)948554932;
				short num2 = num;
				num = (short)831966388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)79167488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1704722432;
				if (num != 0)
				{
				}
				num = (short)1412169729;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MFKPressBehaviorIsAcpValidProperty);
			}
			set
			{
				short num = (short)1844104614;
				short num2 = num;
				num = (short)1719192998;
				switch (num2 == num)
				{
				default:
				{
					num = (short)373555200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1885995008;
				if (num != 0)
				{
				}
				num = (short)260308993;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKPressBehaviorIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00079450 File Offset: 0x00077650
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x0007950C File Offset: 0x0007770C
		public bool MFKPressBehaviorIsAcpApplicable
		{
			get
			{
				short num = (short)886304791;
				short num2 = num;
				num = (short)3665943;
				switch (num2 == num)
				{
				default:
				{
					num = (short)294191104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1430519809;
				if (num != 0)
				{
				}
				num = (short)325058560;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MFKPressBehaviorIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2118573513;
				short num2 = num;
				num = (short)352640457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1420099584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1765015553;
				if (num != 0)
				{
				}
				num = (short)2123956224;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKPressBehaviorIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x000795C4 File Offset: 0x000777C4
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x00079680 File Offset: 0x00077880
		public bool MFKPressBehaviorIsAcpVisible
		{
			get
			{
				short num = (short)1886584833;
				if (num != 0)
				{
				}
				num = (short)1386479616;
				short num2 = num;
				num = (short)46717678;
				short num3 = num;
				num = (short)927062766;
				switch (num3 == num)
				{
				}
				num = (short)2011561984;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MFKPressBehaviorIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)800768880;
				short num2 = num;
				num = (short)1446560624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1354694656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)842530817;
				if (num != 0)
				{
				}
				num = (short)1449328640;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKPressBehaviorIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00079738 File Offset: 0x00077938
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x000797F0 File Offset: 0x000779F0
		public bool MFKPressBehaviorIsAcpEditable
		{
			get
			{
				short num = (short)1731179180;
				short num2 = num;
				num = (short)1311421100;
				switch (num2 == num)
				{
				default:
				{
					num = (short)544014336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1779367936;
				if (num != 0)
				{
				}
				num = (short)1996095489;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MFKPressBehaviorIsAcpEditableProperty);
			}
			set
			{
				short num = (short)647697298;
				short num2 = num;
				num = (short)687215506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1084162048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1877278720;
				if (num != 0)
				{
				}
				num = (short)1110048769;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKPressBehaviorIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x000798A8 File Offset: 0x00077AA8
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00079964 File Offset: 0x00077B64
		public string MFKPressBehaviorUIValue
		{
			get
			{
				short num = (short)1280635649;
				short num2 = num;
				num = (short)1323496193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1224540160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)946012160;
				if (num != 0)
				{
				}
				num = (short)1834876929;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O7GraphicView.MFKPressBehaviorUIValueProperty);
			}
			set
			{
				short num = (short)915949992;
				short num2 = num;
				num = (short)973949352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)740753408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)48234496;
				if (num != 0)
				{
				}
				num = (short)1069481985;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKPressBehaviorUIValueProperty, value);
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00079A18 File Offset: 0x00077C18
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00079AD0 File Offset: 0x00077CD0
		public AcpListField MFKPressBehaviorList
		{
			get
			{
				short num = (short)403737833;
				short num2 = num;
				num = (short)308710633;
				switch (num2 == num)
				{
				default:
				{
					num = (short)801832960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1473052673;
				if (num != 0)
				{
				}
				num = (short)1264648192;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O7GraphicView.MFKPressBehaviorListProperty);
			}
			set
			{
				short num = (short)1578038285;
				short num2 = num;
				num = (short)1849619469;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1112211456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1513029633;
				if (num != 0)
				{
				}
				num = (short)1266810880;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKPressBehaviorListProperty, value);
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00079B84 File Offset: 0x00077D84
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00079C40 File Offset: 0x00077E40
		public bool MFKButtonPrimaryIsAcpValid
		{
			get
			{
				short num = (short)1177333193;
				short num2 = num;
				num = (short)2139008457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1783103488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2060582913;
				if (num != 0)
				{
				}
				num = (short)1656487936;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MFKButtonPrimaryIsAcpValidProperty);
			}
			set
			{
				short num = (short)1017260053;
				short num2 = num;
				num = (short)2015569941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2013003776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1751711745;
				if (num != 0)
				{
				}
				num = (short)1759444992;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKButtonPrimaryIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00079CF8 File Offset: 0x00077EF8
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00079DB0 File Offset: 0x00077FB0
		public bool MFKButtonPrimaryIsAcpApplicable
		{
			get
			{
				short num = (short)1541539532;
				short num2 = num;
				num = (short)416614092;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1615921152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1359544321;
				if (num != 0)
				{
				}
				num = (short)1402601472;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MFKButtonPrimaryIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2021189907;
				short num2 = num;
				num = (short)858646803;
				switch (num2 == num)
				{
				default:
				{
					num = (short)673185792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1968373760;
				if (num != 0)
				{
				}
				num = (short)204275713;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKButtonPrimaryIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00079E6C File Offset: 0x0007806C
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x00079F28 File Offset: 0x00078128
		public bool MFKButtonPrimaryIsAcpVisible
		{
			get
			{
				short num = (short)1509735740;
				short num2 = num;
				num = (short)1230290236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2053832704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1244266496;
				if (num != 0)
				{
				}
				num = (short)1089929217;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MFKButtonPrimaryIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)965214209;
				if (num != 0)
				{
				}
				num = (short)367525888;
				short num2 = num;
				num = (short)1813879919;
				short num3 = num;
				num = (short)344235119;
				switch (num3 == num)
				{
				}
				num = (short)126812160;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKButtonPrimaryIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00079FE4 File Offset: 0x000781E4
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x0007A0A0 File Offset: 0x000782A0
		public bool MFKButtonPrimaryIsAcpEditable
		{
			get
			{
				short num = (short)471637474;
				short num2 = num;
				num = (short)1441045986;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521549312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1343946753;
				if (num != 0)
				{
				}
				num = (short)1594949632;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MFKButtonPrimaryIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1908252042;
				short num2 = num;
				num = (short)893033866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)646840320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)575733761;
				if (num != 0)
				{
				}
				num = (short)447217664;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKButtonPrimaryIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0007A158 File Offset: 0x00078358
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x0007A214 File Offset: 0x00078414
		public string MFKButtonPrimaryUIValue
		{
			get
			{
				short num = (short)1680618422;
				short num2 = num;
				num = (short)442577846;
				switch (num2 == num)
				{
				default:
				{
					num = (short)922222592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)380502017;
				if (num != 0)
				{
				}
				num = (short)1303969792;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O7GraphicView.MFKButtonPrimaryUIValueProperty);
			}
			set
			{
				short num = (short)418512897;
				if (num != 0)
				{
				}
				num = (short)1520762880;
				short num2 = num;
				num = (short)656120088;
				short num3 = num;
				num = (short)1826199832;
				switch (num3 == num)
				{
				}
				num = (short)931135488;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKButtonPrimaryUIValueProperty, value);
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0007A2CC File Offset: 0x000784CC
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x0007A388 File Offset: 0x00078588
		public AcpListField MFKButtonPrimaryList
		{
			get
			{
				short num = (short)1665980725;
				short num2 = num;
				num = (short)313841973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1811021824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)310968320;
				if (num != 0)
				{
				}
				num = (short)2062090241;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O7GraphicView.MFKButtonPrimaryListProperty);
			}
			set
			{
				short num = (short)80756669;
				short num2 = num;
				num = (short)2052865981;
				switch (num2 == num)
				{
				default:
				{
					num = (short)770048000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)453509121;
				if (num != 0)
				{
				}
				num = (short)1382612992;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKButtonPrimaryListProperty, value);
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0007A440 File Offset: 0x00078640
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x0007A4FC File Offset: 0x000786FC
		public bool MFKButtonSecondaryIsAcpValid
		{
			get
			{
				short num = (short)508969480;
				short num2 = num;
				num = (short)1562133000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)259260416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1975844865;
				if (num != 0)
				{
				}
				num = (short)2130837504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MFKButtonSecondaryIsAcpValidProperty);
			}
			set
			{
				short num = (short)32178176;
				short num2 = num;
				num = (short)2069955156;
				short num3 = num;
				num = (short)273547860;
				switch (num3 == num)
				{
				}
				num = (short)1605632001;
				if (num != 0)
				{
				}
				num = (short)288817152;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKButtonSecondaryIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x0007A5B4 File Offset: 0x000787B4
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x0007A66C File Offset: 0x0007886C
		public bool MFKButtonSecondaryIsAcpApplicable
		{
			get
			{
				short num = (short)281935872;
				short num2 = num;
				num = (short)1870990530;
				short num3 = num;
				num = (short)548998338;
				switch (num3 == num)
				{
				}
				num = (short)814678017;
				if (num != 0)
				{
				}
				num = (short)1602879488;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MFKButtonSecondaryIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1349320704;
				short num2 = num;
				num = (short)636310137;
				short num3 = num;
				num = (short)1242255993;
				switch (num3 == num)
				{
				}
				num = (short)2071396352;
				if (num != 0)
				{
				}
				num = (short)1127743489;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKButtonSecondaryIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0007A724 File Offset: 0x00078924
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x0007A7E0 File Offset: 0x000789E0
		public bool MFKButtonSecondaryIsAcpVisible
		{
			get
			{
				short num = (short)1051459584;
				short num2 = num;
				num = (short)1585654765;
				short num3 = num;
				num = (short)1927949293;
				switch (num3 == num)
				{
				}
				num = (short)600375297;
				if (num != 0)
				{
				}
				num = (short)369557504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MFKButtonSecondaryIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1343488000;
				short num2 = num;
				num = (short)1183452731;
				short num3 = num;
				num = (short)1730481723;
				switch (num3 == num)
				{
				}
				num = (short)1397686273;
				if (num != 0)
				{
				}
				num = (short)1347485696;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKButtonSecondaryIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0007A89C File Offset: 0x00078A9C
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x0007A958 File Offset: 0x00078B58
		public bool MFKButtonSecondaryIsAcpEditable
		{
			get
			{
				short num = (short)1193279488;
				short num2 = num;
				num = (short)1048042995;
				short num3 = num;
				num = (short)1609948659;
				switch (num3 == num)
				{
				}
				num = (short)247398401;
				if (num != 0)
				{
				}
				num = (short)2060713984;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.MFKButtonSecondaryIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1325203456;
				short num2 = num;
				num = (short)999120686;
				short num3 = num;
				num = (short)999644974;
				switch (num3 == num)
				{
				}
				num = (short)1692991488;
				if (num != 0)
				{
				}
				num = (short)1222770689;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKButtonSecondaryIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x0007AA10 File Offset: 0x00078C10
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x0007AACC File Offset: 0x00078CCC
		public string MFKButtonSecondaryUIValue
		{
			get
			{
				short num = (short)570163200;
				short num2 = num;
				num = (short)1866503309;
				short num3 = num;
				num = (short)940676237;
				switch (num3 == num)
				{
				}
				num = (short)713555968;
				if (num != 0)
				{
				}
				num = (short)153157633;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O7GraphicView.MFKButtonSecondaryUIValueProperty);
			}
			set
			{
				short num = (short)756809728;
				short num2 = num;
				num = (short)100517577;
				short num3 = num;
				num = (short)1948108489;
				switch (num3 == num)
				{
				}
				num = (short)559218689;
				if (num != 0)
				{
				}
				num = (short)2122252288;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKButtonSecondaryUIValueProperty, value);
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x0007AB80 File Offset: 0x00078D80
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x0007AC3C File Offset: 0x00078E3C
		public AcpListField MFKButtonSecondaryList
		{
			get
			{
				short num = (short)1631256576;
				short num2 = num;
				num = (short)1150061392;
				short num3 = num;
				num = (short)920619856;
				switch (num3 == num)
				{
				}
				num = (short)1587806208;
				if (num != 0)
				{
				}
				num = (short)79429633;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O7GraphicView.MFKButtonSecondaryListProperty);
			}
			set
			{
				short num = (short)2141061120;
				short num2 = num;
				num = (short)315311175;
				short num3 = num;
				num = (short)143803463;
				switch (num3 == num)
				{
				}
				num = (short)2023030784;
				if (num != 0)
				{
				}
				num = (short)141426689;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.MFKButtonSecondaryListProperty, value);
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0007ACF4 File Offset: 0x00078EF4
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x0007ADAC File Offset: 0x00078FAC
		public bool DataButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)1562050560;
				short num2 = num;
				num = (short)1860440985;
				short num3 = num;
				num = (short)917509017;
				switch (num3 == num)
				{
				}
				num = (short)1187446784;
				if (num != 0)
				{
				}
				num = (short)1734737921;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)1168769024;
				short num2 = num;
				num = (short)346774292;
				short num3 = num;
				num = (short)379935508;
				switch (num3 == num)
				{
				}
				num = (short)379846657;
				if (num != 0)
				{
				}
				num = (short)744161280;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x0007AE68 File Offset: 0x00079068
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x0007AF20 File Offset: 0x00079120
		public bool DataButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)1580990464;
				short num2 = num;
				num = (short)395608372;
				short num3 = num;
				num = (short)1202422068;
				switch (num3 == num)
				{
				}
				num = (short)472580096;
				if (num != 0)
				{
				}
				num = (short)249954305;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)770768896;
				short num2 = num;
				num = (short)699217083;
				short num3 = num;
				num = (short)927413435;
				switch (num3 == num)
				{
				}
				num = (short)1624244225;
				if (num != 0)
				{
				}
				num = (short)584712192;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0007AFDC File Offset: 0x000791DC
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x0007B098 File Offset: 0x00079298
		public bool DataButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)1849688064;
				short num2 = num;
				num = (short)1311921991;
				short num3 = num;
				num = (short)19224391;
				switch (num3 == num)
				{
				}
				num = (short)662503425;
				if (num != 0)
				{
				}
				num = (short)1774125056;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1796210688;
				short num2 = num;
				num = (short)238954259;
				short num3 = num;
				num = (short)2062624531;
				switch (num3 == num)
				{
				}
				num = (short)463732736;
				if (num != 0)
				{
				}
				num = (short)898433025;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0007B150 File Offset: 0x00079350
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x0007B208 File Offset: 0x00079408
		public bool DataButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)359727104;
				short num2 = num;
				num = (short)1953057282;
				short num3 = num;
				num = (short)1715882498;
				switch (num3 == num)
				{
				}
				num = (short)1868890112;
				if (num != 0)
				{
				}
				num = (short)703201281;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)850395136;
				short num2 = num;
				num = (short)603594492;
				short num3 = num;
				num = (short)1689132796;
				switch (num3 == num)
				{
				}
				num = (short)1577123841;
				if (num != 0)
				{
				}
				num = (short)928514048;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0007B2C0 File Offset: 0x000794C0
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x0007B378 File Offset: 0x00079578
		public string DataButtonCnvUIValue
		{
			get
			{
				short num = (short)217382912;
				short num2 = num;
				num = (short)1491485857;
				short num3 = num;
				num = (short)1123173537;
				switch (num3 == num)
				{
				}
				num = (short)634257409;
				if (num != 0)
				{
				}
				num = (short)2140733440;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O7GraphicView.DataButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)2015428608;
				short num2 = num;
				num = (short)1085070839;
				short num3 = num;
				num = (short)1499651575;
				switch (num3 == num)
				{
				}
				num = (short)904069121;
				if (num != 0)
				{
				}
				num = (short)359923712;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0007B42C File Offset: 0x0007962C
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x0007B4E8 File Offset: 0x000796E8
		public AcpListField DataButtonCnvList
		{
			get
			{
				short num = (short)1969815552;
				short num2 = num;
				num = (short)1101594625;
				if (num != 0)
				{
				}
				num = (short)1825115722;
				short num3 = num;
				num = (short)1000607306;
				switch (num3 == num)
				{
				}
				num = (short)1391329280;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O7GraphicView.DataButtonCnvListProperty);
			}
			set
			{
				short num = (short)1993998336;
				short num2 = num;
				num = (short)915800065;
				if (num != 0)
				{
				}
				num = (short)1943859153;
				short num3 = num;
				num = (short)1530392529;
				switch (num3 == num)
				{
				}
				num = (short)934477824;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonCnvListProperty, value);
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x0007B59C File Offset: 0x0007979C
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x0007B654 File Offset: 0x00079854
		public bool DataButtonCnvIndexIsAcpValid
		{
			get
			{
				short num = (short)1349844992;
				short num2 = num;
				num = (short)1363112002;
				short num3 = num;
				num = (short)1202352194;
				switch (num3 == num)
				{
				}
				num = (short)654442496;
				if (num != 0)
				{
				}
				num = (short)210239489;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonCnvIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)772472832;
				short num2 = num;
				num = (short)95353799;
				short num3 = num;
				num = (short)1399258055;
				switch (num3 == num)
				{
				}
				num = (short)1794768897;
				if (num != 0)
				{
				}
				num = (short)1858469888;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonCnvIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0007B710 File Offset: 0x00079910
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x0007B7CC File Offset: 0x000799CC
		public bool DataButtonCnvIndexIsAcpApplicable
		{
			get
			{
				short num = (short)99090432;
				short num2 = num;
				num = (short)643626154;
				short num3 = num;
				num = (short)1379071146;
				switch (num3 == num)
				{
				}
				num = (short)2027749377;
				if (num != 0)
				{
				}
				num = (short)2083323904;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonCnvIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)84672512;
				short num2 = num;
				num = (short)965171345;
				short num3 = num;
				num = (short)264263825;
				switch (num3 == num)
				{
				}
				num = (short)1609629697;
				if (num != 0)
				{
				}
				num = (short)1320157184;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonCnvIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0007B888 File Offset: 0x00079A88
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x0007B940 File Offset: 0x00079B40
		public bool DataButtonCnvIndexIsAcpVisible
		{
			get
			{
				short num = (short)1798701056;
				short num2 = num;
				num = (short)482853085;
				short num3 = num;
				num = (short)1457897693;
				switch (num3 == num)
				{
				}
				num = (short)1859256321;
				if (num != 0)
				{
				}
				num = (short)1584070656;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonCnvIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1778057216;
				short num2 = num;
				num = (short)1346071422;
				short num3 = num;
				num = (short)1440377726;
				switch (num3 == num)
				{
				}
				num = (short)377487360;
				if (num != 0)
				{
				}
				num = (short)600375297;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonCnvIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x0007B9FC File Offset: 0x00079BFC
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x0007BAB4 File Offset: 0x00079CB4
		public bool DataButtonCnvIndexIsAcpEditable
		{
			get
			{
				short num = (short)1848705024;
				short num2 = num;
				num = (short)1070876847;
				short num3 = num;
				num = (short)558450863;
				switch (num3 == num)
				{
				}
				num = (short)1162936321;
				if (num != 0)
				{
				}
				num = (short)321323008;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonCnvIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)108658688;
				short num2 = num;
				num = (short)1667576732;
				short num3 = num;
				num = (short)162870172;
				switch (num3 == num)
				{
				}
				num = (short)1263861760;
				if (num != 0)
				{
				}
				num = (short)158269441;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonCnvIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x0007BB70 File Offset: 0x00079D70
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x0007BC28 File Offset: 0x00079E28
		public string DataButtonCnvIndexUIValue
		{
			get
			{
				short num = (short)1271791616;
				short num2 = num;
				num = (short)1890451457;
				if (num != 0)
				{
				}
				num = (short)1102115953;
				short num3 = num;
				num = (short)943125617;
				switch (num3 == num)
				{
				}
				num = (short)1099497472;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O7GraphicView.DataButtonCnvIndexUIValueProperty);
			}
			set
			{
				short num = (short)431292416;
				short num2 = num;
				num = (short)680243290;
				short num3 = num;
				num = (short)2059776090;
				switch (num3 == num)
				{
				}
				num = (short)2096103424;
				if (num != 0)
				{
				}
				num = (short)154075137;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonCnvIndexUIValueProperty, value);
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x0007BCE0 File Offset: 0x00079EE0
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x0007BD9C File Offset: 0x00079F9C
		public AcpListField DataButtonCnvIndexList
		{
			get
			{
				short num = (short)1325727744;
				short num2 = num;
				num = (short)780311488;
				short num3 = num;
				num = (short)2028051392;
				switch (num3 == num)
				{
				}
				num = (short)177995776;
				if (num != 0)
				{
				}
				num = (short)631439361;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O7GraphicView.DataButtonCnvIndexListProperty);
			}
			set
			{
				short num = (short)279248896;
				short num2 = num;
				num = (short)1455347866;
				short num3 = num;
				num = (short)970840218;
				switch (num3 == num)
				{
				}
				num = (short)1897005057;
				if (num != 0)
				{
				}
				num = (short)756547584;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonCnvIndexListProperty, value);
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x0007BE54 File Offset: 0x0007A054
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x0007BF0C File Offset: 0x0007A10C
		public bool DataButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)830799872;
				short num2 = num;
				num = (short)997832366;
				short num3 = num;
				num = (short)1848948398;
				switch (num3 == num)
				{
				}
				num = (short)1912078336;
				if (num != 0)
				{
				}
				num = (short)158597121;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)2115502080;
				short num2 = num;
				num = (short)749690931;
				short num3 = num;
				num = (short)109862963;
				switch (num3 == num)
				{
				}
				num = (short)1883701248;
				if (num != 0)
				{
				}
				num = (short)804192257;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x0007BFC8 File Offset: 0x0007A1C8
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x0007C080 File Offset: 0x0007A280
		public bool DataButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)1985478656;
				short num2 = num;
				num = (short)773777317;
				short num3 = num;
				num = (short)343926693;
				switch (num3 == num)
				{
				}
				num = (short)264699905;
				if (num != 0)
				{
				}
				num = (short)1917779968;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1511456768;
				short num2 = num;
				num = (short)1434903750;
				short num3 = num;
				num = (short)2121196742;
				switch (num3 == num)
				{
				}
				num = (short)1240662017;
				if (num != 0)
				{
				}
				num = (short)1665728512;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0007C13C File Offset: 0x0007A33C
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x0007C1F4 File Offset: 0x0007A3F4
		public bool DataButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)1268908032;
				short num2 = num;
				num = (short)1822190516;
				short num3 = num;
				num = (short)1766681524;
				switch (num3 == num)
				{
				}
				num = (short)1418133505;
				if (num != 0)
				{
				}
				num = (short)340787200;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)640548864;
				short num2 = num;
				num = (short)774647227;
				short num3 = num;
				num = (short)1906126267;
				switch (num3 == num)
				{
				}
				num = (short)865337344;
				if (num != 0)
				{
				}
				num = (short)552206337;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0007C2B0 File Offset: 0x0007A4B0
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x0007C370 File Offset: 0x0007A570
		public bool DataButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)1911881728;
				short num2 = num;
				num = (short)890855296;
				short num3 = num;
				num = (short)1942314880;
				switch (num3 == num)
				{
				}
				num = (short)392560641;
				if (num != 0)
				{
				}
				num = (short)263323648;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2124414976;
				short num2 = num;
				num = (short)1401415424;
				short num3 = num;
				num = (short)1718609664;
				switch (num3 == num)
				{
				}
				num = (short)646971392;
				if (num != 0)
				{
				}
				num = (short)2087518209;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x0007C42C File Offset: 0x0007A62C
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x0007C4E8 File Offset: 0x0007A6E8
		public string DataButtonTrkUIValue
		{
			get
			{
				short num = (short)1451163648;
				short num2 = num;
				num = (short)896244933;
				short num3 = num;
				num = (short)1742642373;
				switch (num3 == num)
				{
				}
				num = (short)778305537;
				if (num != 0)
				{
				}
				num = (short)303890432;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O7GraphicView.DataButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)813826048;
				short num2 = num;
				num = (short)1662370437;
				short num3 = num;
				num = (short)1931526789;
				switch (num3 == num)
				{
				}
				num = (short)397869057;
				if (num != 0)
				{
				}
				num = (short)437911552;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x0007C59C File Offset: 0x0007A79C
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x0007C654 File Offset: 0x0007A854
		public AcpListField DataButtonTrkList
		{
			get
			{
				short num = (short)513212416;
				short num2 = num;
				num = (short)1058537473;
				if (num != 0)
				{
				}
				num = (short)142464377;
				short num3 = num;
				num = (short)2016269689;
				switch (num3 == num)
				{
				}
				num = (short)631439360;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O7GraphicView.DataButtonTrkListProperty);
			}
			set
			{
				short num = (short)893386752;
				short num2 = num;
				num = (short)1560044071;
				short num3 = num;
				num = (short)1231708711;
				switch (num3 == num)
				{
				}
				num = (short)1957953537;
				if (num != 0)
				{
				}
				num = (short)276168704;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonTrkListProperty, value);
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x0007C708 File Offset: 0x0007A908
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x0007C7C4 File Offset: 0x0007A9C4
		public bool DataButtonTrkIndexIsAcpValid
		{
			get
			{
				short num = (short)312541184;
				short num2 = num;
				num = (short)1072300033;
				if (num != 0)
				{
				}
				num = (short)2084182842;
				short num3 = num;
				num = (short)76356410;
				switch (num3 == num)
				{
				}
				num = (short)525926400;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonTrkIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)653721600;
				short num2 = num;
				num = (short)1285908774;
				short num3 = num;
				num = (short)945383718;
				switch (num3 == num)
				{
				}
				num = (short)271843328;
				if (num != 0)
				{
				}
				num = (short)193134593;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonTrkIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x0007C880 File Offset: 0x0007AA80
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x0007C93C File Offset: 0x0007AB3C
		public bool DataButtonTrkIndexIsAcpApplicable
		{
			get
			{
				short num = (short)16384000;
				short num2 = num;
				num = (short)2055554627;
				short num3 = num;
				num = (short)1762018883;
				switch (num3 == num)
				{
				}
				num = (short)497483776;
				if (num != 0)
				{
				}
				num = (short)109772801;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonTrkIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)373882880;
				short num2 = num;
				num = (short)460983458;
				short num3 = num;
				num = (short)1054805154;
				switch (num3 == num)
				{
				}
				num = (short)1847328769;
				if (num != 0)
				{
				}
				num = (short)31129600;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonTrkIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x0007C9F8 File Offset: 0x0007ABF8
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x0007CAB0 File Offset: 0x0007ACB0
		public bool DataButtonTrkIndexIsAcpVisible
		{
			get
			{
				short num = (short)1952120832;
				short num2 = num;
				num = (short)1000951574;
				short num3 = num;
				num = (short)1118981910;
				switch (num3 == num)
				{
				}
				num = (short)1053294593;
				if (num != 0)
				{
				}
				num = (short)1643380736;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonTrkIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1480196096;
				short num2 = num;
				num = (short)1387969080;
				short num3 = num;
				num = (short)88062520;
				switch (num3 == num)
				{
				}
				num = (short)1652883457;
				if (num != 0)
				{
				}
				num = (short)1200160768;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonTrkIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x0007CB68 File Offset: 0x0007AD68
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x0007CC24 File Offset: 0x0007AE24
		public bool DataButtonTrkIndexIsAcpEditable
		{
			get
			{
				short num = (short)1980366848;
				short num2 = num;
				num = (short)1669266204;
				short num3 = num;
				num = (short)1845951260;
				switch (num3 == num)
				{
				}
				num = (short)2126577664;
				if (num != 0)
				{
				}
				num = (short)1231880193;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O7GraphicView.DataButtonTrkIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)787480576;
				short num2 = num;
				num = (short)1010171905;
				if (num != 0)
				{
				}
				num = (short)224879633;
				short num3 = num;
				num = (short)1917084689;
				switch (num3 == num)
				{
				}
				num = (short)851771392;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonTrkIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x0007CCE0 File Offset: 0x0007AEE0
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x0007CD98 File Offset: 0x0007AF98
		public string DataButtonTrkIndexUIValue
		{
			get
			{
				short num = (short)225574912;
				short num2 = num;
				num = (short)1123021834;
				short num3 = num;
				num = (short)900854794;
				switch (num3 == num)
				{
				}
				num = (short)1075445761;
				if (num != 0)
				{
				}
				num = (short)113639424;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O7GraphicView.DataButtonTrkIndexUIValueProperty);
			}
			set
			{
				short num = (short)1293352960;
				short num2 = num;
				num = (short)46275825;
				short num3 = num;
				num = (short)1481907441;
				switch (num3 == num)
				{
				}
				num = (short)978518017;
				if (num != 0)
				{
				}
				num = (short)772145152;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonTrkIndexUIValueProperty, value);
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x0007CE4C File Offset: 0x0007B04C
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x0007CF04 File Offset: 0x0007B104
		public AcpListField DataButtonTrkIndexList
		{
			get
			{
				short num = (short)2001855030;
				short num2 = num;
				num = (short)758637110;
				switch (num2 == num)
				{
				default:
				{
					num = (short)737345536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1826881536;
				if (num != 0)
				{
				}
				num = (short)1136132097;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O7GraphicView.DataButtonTrkIndexListProperty);
			}
			set
			{
				short num = (short)199176230;
				short num2 = num;
				num = (short)806367270;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1902772224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)124715008;
				if (num != 0)
				{
				}
				num = (short)242286593;
				if (num != 0)
				{
				}
				base.SetValue(O7GraphicView.DataButtonTrkIndexListProperty, value);
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0007DAB4 File Offset: 0x0007BCB4
		// Note: this type is marked as 'beforefieldinit'.
		static O7GraphicView()
		{
			int a_ = 8;
			short num = (short)417242704;
			short num2 = num;
			num = (short)693542480;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1776812032;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)663748609;
			if (num != 0)
			{
			}
			num = (short)332857344;
			if (num != 0)
			{
			}
			O7GraphicView.EmergencyButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘲場制䬸尺堼儾≀㩂݄㉆㵈㽊≌ⅎᝐ㙒㑔⍖ⱘ⥚㡜ᙞበ≢٤ᝦ㽨੪Ŭٮᕰ", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘲場制䬸尺堼儾≀㩂݄㉆㵈㽊≌ⅎᝐ㙒㑔⍖ⱘ⥚㡜ᙞበ≢٤ᝦ⡨᭪ᵬͮᡰၲᑴᕶᕸṺ", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘲場制䬸尺堼儾≀㩂݄㉆㵈㽊≌ⅎᝐ㙒㑔⍖ⱘ⥚㡜ᙞበ≢٤ᝦ㽨ɪṬٮ፰ὲၴ", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.EmergencyButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘲場制䬸尺堼儾≀㩂݄㉆㵈㽊≌ⅎᝐ㙒㑔⍖ⱘ⥚㡜ᙞበ≢٤ᝦⱨཪѬ᭮ၰᅲᥴቶ", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.EmergencyButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘲場制䬸尺堼儾≀㩂݄㉆㵈㽊≌ⅎᝐ㙒㑔⍖ⱘ⥚㡜ਫ਼⡠㕢Ѥ୦ᱨ๪", a_), typeof(string), typeof(O7GraphicView));
			O7GraphicView.EmergencyButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瘲場制䬸尺堼儾≀㩂݄㉆㵈㽊≌ⅎᝐ㙒㑔⍖ⱘ⥚㡜፞ࡠၢᅤ", a_), typeof(AcpListField), typeof(O7GraphicView));
			O7GraphicView.MenuItemsConventionalSelectedListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲倴夶䰸爺䤼娾ⱀあل⡆❈㵊⡌ⅎ═㩒㩔㥖㡘㝚๜㩞ൠ٢٤፦౨ཪⅬٮɰݲ", a_), typeof(AcpListField), typeof(O7GraphicView));
			O7GraphicView.MenuItemsTrunkingSelectedListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲倴夶䰸爺䤼娾ⱀあᅄ㕆㱈╊♌♎㽐㑒ٔ㉖㕘㹚㹜⭞Ѡݢ⥤๦ᩨὪ", a_), typeof(AcpListField), typeof(O7GraphicView));
			O7GraphicView.MenuItemsConventionalSelectedListVisibilityProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲倴夶䰸爺䤼娾ⱀあل⡆❈㵊⡌ⅎ═㩒㩔㥖㡘㝚๜㩞ൠ٢٤፦౨ཪⅬٮɰݲ⍴Ṷ੸ቺὼᙾﺆ", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲倴夶䰸爺䤼娾ⱀあᅄ㕆㱈╊♌♎㽐㑒ٔ㉖㕘㹚㹜⭞Ѡݢ⥤๦ᩨὪ㭬ٮɰᩲ᝴Ṷᕸቺॼپ", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.UpButtonIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("昲䔴甶䰸伺䤼倾⽀ੂ㙄ن⩈㭊ᭌ⹎㵐㩒ㅔ", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.UpButtonIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("昲䔴甶䰸伺䤼倾⽀ੂ㙄ن⩈㭊ౌ㽎⅐㽒㱔㑖㡘㥚ㅜ㩞", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.UpButtonIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("昲䔴甶䰸伺䤼倾⽀ੂ㙄ن⩈㭊ᭌ♎≐㩒㝔㭖㱘", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.UpButtonIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("昲䔴甶䰸伺䤼倾⽀ੂ㙄ن⩈㭊ࡌ⭎㡐❒㑔㕖㕘㹚", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.UpButtonUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("昲䔴甶䰸伺䤼倾⽀ᙂౄᅆ⡈❊㡌⩎", a_), typeof(string), typeof(O7GraphicView));
			O7GraphicView.UpButtonListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("昲䔴甶䰸伺䤼倾⽀གⱄ㑆㵈", a_), typeof(AcpListField), typeof(O7GraphicView));
			O7GraphicView.DownButtonIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲娴䀶圸示䠼䬾㕀ⱂ⭄ๆ㩈੊⹌㽎ݐ㉒㥔㹖㵘", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DownButtonIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲娴䀶圸示䠼䬾㕀ⱂ⭄ๆ㩈੊⹌㽎ၐ⍒╔㭖じ㡚㱜㵞ൠ٢", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DownButtonIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲娴䀶圸示䠼䬾㕀ⱂ⭄ๆ㩈੊⹌㽎ݐ㩒♔㹖㭘㝚㡜", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DownButtonIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲娴䀶圸示䠼䬾㕀ⱂ⭄ๆ㩈੊⹌㽎ᑐ㝒㱔⍖㡘㥚ㅜ㩞", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DownButtonUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲娴䀶圸示䠼䬾㕀ⱂ⭄ቆHᵊⱌ⍎⑐㙒", a_), typeof(string), typeof(O7GraphicView));
			O7GraphicView.DownButtonListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲娴䀶圸示䠼䬾㕀ⱂ⭄୆⁈㡊㥌", a_), typeof(AcpListField), typeof(O7GraphicView));
			O7GraphicView.MFKPressBehaviorIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶椸䤺堼䰾㉀ł⁄⽆⡈㵊⑌⁎⍐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.MFKPressBehaviorIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶椸䤺堼䰾㉀ł⁄⽆⡈㵊⑌⁎⍐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.MFKPressBehaviorIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶椸䤺堼䰾㉀ł⁄⽆⡈㵊⑌⁎⍐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.MFKPressBehaviorIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶椸䤺堼䰾㉀ł⁄⽆⡈㵊⑌⁎⍐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.MFKPressBehaviorUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶椸䤺堼䰾㉀ł⁄⽆⡈㵊⑌⁎⍐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O7GraphicView));
			O7GraphicView.MFKPressBehaviorListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶椸䤺堼䰾㉀ł⁄⽆⡈㵊⑌⁎⍐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O7GraphicView));
			O7GraphicView.MFKButtonPrimaryIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶笸为䤼䬾⹀ⵂᕄ㕆⁈♊ⱌ㵎⡐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.MFKButtonPrimaryIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶笸为䤼䬾⹀ⵂᕄ㕆⁈♊ⱌ㵎⡐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.MFKButtonPrimaryIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶笸为䤼䬾⹀ⵂᕄ㕆⁈♊ⱌ㵎⡐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.MFKButtonPrimaryIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶笸为䤼䬾⹀ⵂᕄ㕆⁈♊ⱌ㵎⡐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.MFKButtonPrimaryUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶笸为䤼䬾⹀ⵂᕄ㕆⁈♊ⱌ㵎⡐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O7GraphicView));
			O7GraphicView.MFKButtonPrimaryListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶笸为䤼䬾⹀ⵂᕄ㕆⁈♊ⱌ㵎⡐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O7GraphicView));
			O7GraphicView.MFKButtonSecondaryIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶笸为䤼䬾⹀ⵂᙄ≆⩈⑊⍌⭎ぐ⅒ⱔṖ⩘ᩚ㹜⽞㝠ɢ।๦൨", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.MFKButtonSecondaryIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶笸为䤼䬾⹀ⵂᙄ≆⩈⑊⍌⭎ぐ⅒ⱔṖ⩘ᩚ㹜⽞⁠።ᕤ୦hࡪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.MFKButtonSecondaryIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶笸为䤼䬾⹀ⵂᙄ≆⩈⑊⍌⭎ぐ⅒ⱔṖ⩘ᩚ㹜⽞㝠੢ᙤ๦୨ݪ࡬", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.MFKButtonSecondaryIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶笸为䤼䬾⹀ⵂᙄ≆⩈⑊⍌⭎ぐ⅒ⱔṖ⩘ᩚ㹜⽞①ݢ౤፦ࡨ४Ŭ੮", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.MFKButtonSecondaryUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶笸为䤼䬾⹀ⵂᙄ≆⩈⑊⍌⭎ぐ⅒ⱔɖၘ൚㱜㍞ᑠ٢", a_), typeof(string), typeof(O7GraphicView));
			O7GraphicView.MFKButtonSecondaryListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("縲猴簶笸为䤼䬾⹀ⵂᙄ≆⩈⑊⍌⭎ぐ⅒ⱔ᭖じ⡚⥜", a_), typeof(AcpListField), typeof(O7GraphicView));
			O7GraphicView.DataButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ц❈㵊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ц❈㵊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ц❈㵊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ц❈㵊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ц❈㵊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(O7GraphicView));
			O7GraphicView.DataButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ц❈㵊Ō♎≐❒", a_), typeof(AcpListField), typeof(O7GraphicView));
			O7GraphicView.DataButtonCnvIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ц❈㵊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞㝠ɢ।๦൨", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonCnvIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ц❈㵊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞⁠።ᕤ୦hࡪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonCnvIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ц❈㵊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞㝠੢ᙤ๦୨ݪ࡬", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonCnvIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ц❈㵊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞①ݢ౤፦ࡨ४Ŭ੮", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonCnvIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ц❈㵊ьⅎ㕐㙒ⵔɖၘ൚㱜㍞ᑠ٢", a_), typeof(string), typeof(O7GraphicView));
			O7GraphicView.DataButtonCnvIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ц❈㵊ьⅎ㕐㙒ⵔ᭖じ⡚⥜", a_), typeof(AcpListField), typeof(O7GraphicView));
			O7GraphicView.DataButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ፆ㭈⁊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ፆ㭈⁊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ፆ㭈⁊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ፆ㭈⁊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ፆ㭈⁊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(O7GraphicView));
			O7GraphicView.DataButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ፆ㭈⁊Ō♎≐❒", a_), typeof(AcpListField), typeof(O7GraphicView));
			O7GraphicView.DataButtonTrkIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ፆ㭈⁊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞㝠ɢ।๦൨", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonTrkIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ፆ㭈⁊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞⁠።ᕤ୦hࡪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonTrkIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ፆ㭈⁊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞㝠੢ᙤ๦୨ݪ࡬", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonTrkIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ፆ㭈⁊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞①ݢ౤፦ࡨ४Ŭ੮", a_), typeof(bool), typeof(O7GraphicView));
			O7GraphicView.DataButtonTrkIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ፆ㭈⁊ьⅎ㕐㙒ⵔɖၘ൚㱜㍞ᑠ٢", a_), typeof(string), typeof(O7GraphicView));
			O7GraphicView.DataButtonTrkIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("眲吴䌶堸示䠼䬾㕀ⱂ⭄ፆ㭈⁊ьⅎ㕐㙒ⵔ᭖じ⡚⥜", a_), typeof(AcpListField), typeof(O7GraphicView));
		}

		// Token: 0x0400092A RID: 2346
		public static DependencyProperty EmergencyButtonFeatureIsAcpValidProperty;

		// Token: 0x0400092B RID: 2347
		public static DependencyProperty EmergencyButtonFeatureIsAcpApplicableProperty;

		// Token: 0x0400092C RID: 2348
		public static DependencyProperty EmergencyButtonFeatureIsAcpVisibleProperty;

		// Token: 0x0400092D RID: 2349
		public static DependencyProperty EmergencyButtonFeatureIsAcpEditableProperty;

		// Token: 0x0400092E RID: 2350
		public static DependencyProperty EmergencyButtonFeatureUIValueProperty;

		// Token: 0x0400092F RID: 2351
		public static DependencyProperty EmergencyButtonFeatureListProperty;

		// Token: 0x04000930 RID: 2352
		public static DependencyProperty MenuItemsConventionalSelectedListProperty;

		// Token: 0x04000931 RID: 2353
		public static DependencyProperty MenuItemsTrunkingSelectedListProperty;

		// Token: 0x04000932 RID: 2354
		public static DependencyProperty MenuItemsConventionalSelectedListVisibilityProperty;

		// Token: 0x04000933 RID: 2355
		public static DependencyProperty MenuItemsTrunkingSelectedListVisibilityProperty;

		// Token: 0x04000934 RID: 2356
		public static DependencyProperty UpButtonIsAcpValidProperty;

		// Token: 0x04000935 RID: 2357
		public static DependencyProperty UpButtonIsAcpApplicableProperty;

		// Token: 0x04000936 RID: 2358
		public static DependencyProperty UpButtonIsAcpVisibleProperty;

		// Token: 0x04000937 RID: 2359
		public static DependencyProperty UpButtonIsAcpEditableProperty;

		// Token: 0x04000938 RID: 2360
		public static DependencyProperty UpButtonUIValueProperty;

		// Token: 0x04000939 RID: 2361
		public static DependencyProperty UpButtonListProperty;

		// Token: 0x0400093A RID: 2362
		public static DependencyProperty DownButtonIsAcpValidProperty;

		// Token: 0x0400093B RID: 2363
		public static DependencyProperty DownButtonIsAcpApplicableProperty;

		// Token: 0x0400093C RID: 2364
		public static DependencyProperty DownButtonIsAcpVisibleProperty;

		// Token: 0x0400093D RID: 2365
		public static DependencyProperty DownButtonIsAcpEditableProperty;

		// Token: 0x0400093E RID: 2366
		public static DependencyProperty DownButtonUIValueProperty;

		// Token: 0x0400093F RID: 2367
		public static DependencyProperty DownButtonListProperty;

		// Token: 0x04000940 RID: 2368
		public static DependencyProperty MFKPressBehaviorIsAcpValidProperty;

		// Token: 0x04000941 RID: 2369
		public static DependencyProperty MFKPressBehaviorIsAcpApplicableProperty;

		// Token: 0x04000942 RID: 2370
		public static DependencyProperty MFKPressBehaviorIsAcpVisibleProperty;

		// Token: 0x04000943 RID: 2371
		public static DependencyProperty MFKPressBehaviorIsAcpEditableProperty;

		// Token: 0x04000944 RID: 2372
		public static DependencyProperty MFKPressBehaviorUIValueProperty;

		// Token: 0x04000945 RID: 2373
		public static DependencyProperty MFKPressBehaviorListProperty;

		// Token: 0x04000946 RID: 2374
		public static DependencyProperty MFKButtonPrimaryIsAcpValidProperty;

		// Token: 0x04000947 RID: 2375
		public static DependencyProperty MFKButtonPrimaryIsAcpApplicableProperty;

		// Token: 0x04000948 RID: 2376
		public static DependencyProperty MFKButtonPrimaryIsAcpVisibleProperty;

		// Token: 0x04000949 RID: 2377
		public static DependencyProperty MFKButtonPrimaryIsAcpEditableProperty;

		// Token: 0x0400094A RID: 2378
		public static DependencyProperty MFKButtonPrimaryUIValueProperty;

		// Token: 0x0400094B RID: 2379
		public static DependencyProperty MFKButtonPrimaryListProperty;

		// Token: 0x0400094C RID: 2380
		public static DependencyProperty MFKButtonSecondaryIsAcpValidProperty;

		// Token: 0x0400094D RID: 2381
		public static DependencyProperty MFKButtonSecondaryIsAcpApplicableProperty;

		// Token: 0x0400094E RID: 2382
		public static DependencyProperty MFKButtonSecondaryIsAcpVisibleProperty;

		// Token: 0x0400094F RID: 2383
		public static DependencyProperty MFKButtonSecondaryIsAcpEditableProperty;

		// Token: 0x04000950 RID: 2384
		public static DependencyProperty MFKButtonSecondaryUIValueProperty;

		// Token: 0x04000951 RID: 2385
		public static DependencyProperty MFKButtonSecondaryListProperty;

		// Token: 0x04000952 RID: 2386
		public static DependencyProperty DataButtonCnvIsAcpValidProperty;

		// Token: 0x04000953 RID: 2387
		public static DependencyProperty DataButtonCnvIsAcpApplicableProperty;

		// Token: 0x04000954 RID: 2388
		public static DependencyProperty DataButtonCnvIsAcpVisibleProperty;

		// Token: 0x04000955 RID: 2389
		public static DependencyProperty DataButtonCnvIsAcpEditableProperty;

		// Token: 0x04000956 RID: 2390
		public static DependencyProperty DataButtonCnvUIValueProperty;

		// Token: 0x04000957 RID: 2391
		public static DependencyProperty DataButtonCnvListProperty;

		// Token: 0x04000958 RID: 2392
		public static DependencyProperty DataButtonCnvIndexIsAcpValidProperty;

		// Token: 0x04000959 RID: 2393
		public static DependencyProperty DataButtonCnvIndexIsAcpApplicableProperty;

		// Token: 0x0400095A RID: 2394
		public static DependencyProperty DataButtonCnvIndexIsAcpVisibleProperty;

		// Token: 0x0400095B RID: 2395
		public static DependencyProperty DataButtonCnvIndexIsAcpEditableProperty;

		// Token: 0x0400095C RID: 2396
		public static DependencyProperty DataButtonCnvIndexUIValueProperty;

		// Token: 0x0400095D RID: 2397
		public static DependencyProperty DataButtonCnvIndexListProperty;

		// Token: 0x0400095E RID: 2398
		public static DependencyProperty DataButtonTrkIsAcpValidProperty;

		// Token: 0x0400095F RID: 2399
		public static DependencyProperty DataButtonTrkIsAcpApplicableProperty;

		// Token: 0x04000960 RID: 2400
		public static DependencyProperty DataButtonTrkIsAcpVisibleProperty;

		// Token: 0x04000961 RID: 2401
		public static DependencyProperty DataButtonTrkIsAcpEditableProperty;

		// Token: 0x04000962 RID: 2402
		public static DependencyProperty DataButtonTrkUIValueProperty;

		// Token: 0x04000963 RID: 2403
		public static DependencyProperty DataButtonTrkListProperty;

		// Token: 0x04000964 RID: 2404
		public static DependencyProperty DataButtonTrkIndexIsAcpValidProperty;

		// Token: 0x04000965 RID: 2405
		public static DependencyProperty DataButtonTrkIndexIsAcpApplicableProperty;

		// Token: 0x04000966 RID: 2406
		public static DependencyProperty DataButtonTrkIndexIsAcpVisibleProperty;

		// Token: 0x04000967 RID: 2407
		public static DependencyProperty DataButtonTrkIndexIsAcpEditableProperty;

		// Token: 0x04000968 RID: 2408
		public static DependencyProperty DataButtonTrkIndexUIValueProperty;

		// Token: 0x04000969 RID: 2409
		public static DependencyProperty DataButtonTrkIndexListProperty;
	}
}
