using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using AcpBusinessLayer;
using AcpUI;
using AcpUI.Common;
using ControlHeadGraphicView.converters;

namespace ControlHeadGraphicView
{
	// Token: 0x0200000B RID: 11
	public partial class O5GraphicView : UserControl
	{
		// Token: 0x060007D5 RID: 2005 RVA: 0x0007102C File Offset: 0x0006F22C
		public O5GraphicView()
		{
			this.InitializeComponent();
			base.FlowDirection = FlowDirection.LeftToRight;
			base.DataContext = this;
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00071054 File Offset: 0x0006F254
		public static FlowDirection UIFlowDirection
		{
			get
			{
				short num;
				if (!Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
				{
					num = (short)235929601;
					if (num != 0)
					{
					}
					num = (short)1463103240;
					short num2 = num;
					num = (short)2054369032;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1329528832;
						if (num != 0)
						{
						}
						return FlowDirection.LeftToRight;
					}
				}
				num = (short)203292672;
				short num3 = num;
				return FlowDirection.RightToLeft;
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00071118 File Offset: 0x0006F318
		private void OnFieldNameDoubleClick(object sender, RoutedEventArgs e)
		{
			short num = (short)519110657;
			if (num != 0)
			{
			}
			num = (short)1176698880;
			short num2 = num;
			num = (short)1827563917;
			short num3 = num;
			num = (short)344942989;
			switch (num3 == num)
			{
			}
			num = (short)267255808;
			if (num != 0)
			{
			}
			Utility.GetFieldHelpText(sender);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000711C8 File Offset: 0x0006F3C8
		public override void EndInit()
		{
			short num = (short)2064712907;
			short num2 = num;
			num = (short)1040123083;
			switch (num2 == num)
			{
			default:
			{
				num = (short)920059904;
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
			num = (short)2122055681;
			if (num != 0)
			{
			}
			base.EndInit();
			this.SetMenuItems();
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0007127C File Offset: 0x0006F47C
		public void SetMenuItems()
		{
			short num = (short)1744240649;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)2141168838;
				short num3 = num;
				num = (short)325362886;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)256507904;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_47E;
					case 1:
						this.bottom_screen_contacts.Content = this.MenuItemsConventionalSelectedList.Items[4].ItemName;
						num = (short)1416298498;
						num2 = (int)((IntPtr)num);
						continue;
					case 2:
						goto IL_270;
					case 3:
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
							this.bottom_screen_status_Copy.Content = this.MenuItemsTrunkingSelectedList.Items[3].ItemName;
						}
						else
						{
							this.bottom_screen_status_Copy.Content = string.Empty;
						}
						if (count >= 5)
						{
							num = (short)591593473;
							if (num != 0)
							{
							}
							num = (short)1250230279;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.bottom_screen_contacts_Copy.Content = string.Empty;
						num = (short)309854208;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 4:
						goto IL_270;
					case 5:
						goto IL_D0;
					case 6:
						return;
					case 7:
					{
						this.bottom_screen_contacts_Copy.Content = this.MenuItemsTrunkingSelectedList.Items[4].ItemName;
						num = (short)196214784;
						short num4 = num;
						num = (short)710344712;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 8:
						goto IL_454;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_97;
						}
						continue;
					}
					IL_97:
					if (this.MenuItemsConventionalSelectedList == null)
					{
						num = (short)1795293190;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1390411781;
					num2 = (int)((IntPtr)num);
					continue;
					IL_270:
					num = (short)2133721091;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_D0:
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
					this.bottom_screen_status.Content = this.MenuItemsConventionalSelectedList.Items[3].ItemName;
				}
				else
				{
					this.bottom_screen_status.Content = string.Empty;
				}
				if (count2 >= 5)
				{
					num = (short)1399586817;
					num2 = (int)((IntPtr)num);
				}
				else
				{
					this.bottom_screen_contacts.Content = string.Empty;
					num = (short)2117926916;
					num2 = (int)((IntPtr)num);
				}
			}
			return;
			IL_454:
			IL_47E:
			this.AdjustMenuItemStringFontSize();
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00071710 File Offset: 0x0006F910
		private void AdjustMenuItemStringFontSize()
		{
			short num = (short)1413611543;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.bottom_screen_status.Content.ToString().Length > 8)
					{
						num = (short)406847493;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_status.FontSize = 30.0;
					num = (short)2101608481;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_672;
				case 2:
					this.bottom_screen_scan.FontSize = 28.0;
					num = (short)2085027860;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					goto IL_6C1;
				case 4:
					this.bottom_screen_zone_Copy.FontSize = 28.0;
					num = (short)613548050;
					num2 = (int)((IntPtr)num);
					continue;
				case 5:
					this.bottom_screen_status.FontSize = 28.0;
					goto IL_654;
				case 6:
					this.bottom_screen_contacts.FontSize = 28.0;
					num = (short)1920008206;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					if (this.bottom_screen_zone.Content.ToString().Length > 8)
					{
						num = (short)738852898;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_zone.FontSize = 30.0;
					num = (short)284033053;
					num2 = (int)((IntPtr)num);
					continue;
				case 8:
					if (this.bottom_screen_zone_Copy.Content.ToString().Length > 8)
					{
						num = (short)237502468;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_zone_Copy.FontSize = 30.0;
					num = (short)1389953048;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
					goto IL_5A8;
				case 10:
					this.bottom_screen_info_Copy.FontSize = 28.0;
					num = (short)1799880713;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
					if (this.bottom_screen_scan.Content.ToString().Length > 8)
					{
						num = (short)259457026;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_scan.FontSize = 30.0;
					num = (short)185532428;
					num2 = (int)((IntPtr)num);
					continue;
				case 12:
					goto IL_17A;
				case 13:
				{
					if (this.bottom_screen_scan_Copy.Content.ToString().Length <= 8)
					{
						this.bottom_screen_scan_Copy.FontSize = 30.0;
						num = (short)99024897;
						if (num != 0)
						{
						}
						num = (short)1781465110;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1284167046;
					short num3 = num;
					num = (short)424662406;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_654;
					default:
						num = (short)1849622528;
						if (num != 0)
						{
						}
						num = (short)1767702553;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 14:
				{
					num = (short)303628288;
					short num4 = num;
					goto IL_2AF;
				}
				case 15:
					if (this.bottom_screen_contacts_Copy.Content.ToString().Length > 8)
					{
						num = (short)1915355167;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7D4;
				case 16:
					goto IL_6C1;
				case 17:
					this.bottom_screen_status_Copy.FontSize = 28.0;
					num = (short)915079184;
					num2 = (int)((IntPtr)num);
					continue;
				case 18:
					goto IL_1CA;
				case 19:
					if (this.bottom_screen_info_Copy.Content.ToString().Length > 8)
					{
						num = (short)98435082;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_info_Copy.FontSize = 30.0;
					num = (short)1735524388;
					num2 = (int)((IntPtr)num);
					continue;
				case 20:
					goto IL_17A;
				case 21:
					goto IL_2AF;
				case 22:
					goto IL_4B5;
				case 23:
					switch (0)
					{
					case 0:
						goto IL_BC;
					}
					continue;
				case 24:
					goto IL_1CA;
				case 25:
					this.bottom_screen_scan_Copy.FontSize = 28.0;
					num = (short)1416429594;
					num2 = (int)((IntPtr)num);
					continue;
				case 26:
					goto IL_4B5;
				case 27:
					if (this.bottom_screen_status_Copy.Content.ToString().Length > 8)
					{
						num = (short)797966353;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_status_Copy.FontSize = 30.0;
					num = (short)1569587203;
					num2 = (int)((IntPtr)num);
					continue;
				case 28:
					goto IL_502;
				case 29:
					goto IL_436;
				case 30:
					if (this.bottom_screen_contacts.Content.ToString().Length > 8)
					{
						num = (short)1443758086;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_contacts.FontSize = 30.0;
					num = (short)1124794389;
					num2 = (int)((IntPtr)num);
					continue;
				case 31:
					goto IL_70B;
				case 32:
					goto IL_436;
				case 33:
					goto IL_502;
				case 34:
					this.bottom_screen_zone.FontSize = 28.0;
					num = (short)320733216;
					num2 = (int)((IntPtr)num);
					continue;
				case 35:
					goto IL_672;
				case 36:
					goto IL_5A8;
				case 37:
					this.bottom_screen_info.FontSize = 28.0;
					num = (short)1819607041;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_BC:
				if (this.bottom_screen_info.Content.ToString().Length > 8)
				{
					num = (short)536674341;
					num2 = (int)((IntPtr)num);
					continue;
				}
				this.bottom_screen_info.FontSize = 30.0;
				num = (short)2016542755;
				num2 = (int)((IntPtr)num);
				continue;
				IL_17A:
				num = (short)1039794183;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1CA:
				num = (short)27983899;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2AF:
				num = (short)1340080147;
				num2 = (int)((IntPtr)num);
				continue;
				IL_436:
				num = (short)1294794752;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4B5:
				num = (short)362283016;
				num2 = (int)((IntPtr)num);
				continue;
				IL_502:
				num = (short)777584670;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5A8:
				num = (short)747110413;
				num2 = (int)((IntPtr)num);
				continue;
				IL_654:
				num = (short)634454044;
				num2 = (int)((IntPtr)num);
				continue;
				IL_672:
				num = (short)1208745995;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6C1:
				num = (short)228786191;
				num2 = (int)((IntPtr)num);
			}
			IL_70B:
			this.bottom_screen_contacts_Copy.FontSize = 28.0;
			return;
			IL_7D4:
			this.bottom_screen_contacts_Copy.FontSize = 30.0;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00071F08 File Offset: 0x00070108
		private void NavLeftRight_Click(object sender, RoutedEventArgs e)
		{
			int a_ = 7;
			short num = (short)217907200;
			short num2 = num;
			num = (short)1773928448;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C6;
				}
				Button button;
				for (;;)
				{
					IL_5B:
					int num4;
					int count;
					int count2;
					switch (num3)
					{
					case 0:
						num = (short)2044395524;
						num3 = (int)((IntPtr)num);
						continue;
					case 1:
						goto IL_17B;
					case 2:
						if (!this.MenuItemsConventionalSelectedList.Visible)
						{
							num = (short)1162346499;
							num3 = (int)((IntPtr)num);
							continue;
						}
						goto IL_379;
					case 3:
						goto IL_3D6;
					case 4:
						if ((int)this.bottom_screen_info.Tag + num4 < count)
						{
							num = (short)1364459538;
							num3 = (int)((IntPtr)num);
							continue;
						}
						goto IL_17B;
					case 5:
						goto IL_327;
					case 6:
						return;
					case 7:
						if (this.MenuItemsTrunkingSelectedList.Visible)
						{
							num = (short)695861263;
							num3 = (int)((IntPtr)num);
							continue;
						}
						goto IL_354;
					case 8:
						if ((int)this.bottom_screen_info_Copy.Tag + num4 < count2)
						{
							num = (short)1866334229;
							num3 = (int)((IntPtr)num);
							continue;
						}
						goto IL_354;
					case 9:
					{
						num = (short)804325058;
						short num5 = num;
						num = (short)212010690;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_327;
						default:
							num = (short)316342272;
							if (num != 0)
							{
							}
							count = this.MenuItemsConventionalSelectedList.Items.Count;
							count2 = this.MenuItemsTrunkingSelectedList.Items.Count;
							num4 = 5;
							num = (short)436600846;
							num3 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						goto IL_379;
					case 11:
						num = (short)1584988183;
						num3 = (int)((IntPtr)num);
						continue;
					case 12:
						if ((int)this.bottom_screen_info_Copy.Tag > 0)
						{
							num = (short)1137115147;
							num3 = (int)((IntPtr)num);
							continue;
						}
						goto IL_354;
					case 13:
						if (button.Name.Equals(O9GraphicviewMenuItemsVisibilityConverter.b("簱唳䀵朷根唻夽⠿㙁", a_)))
						{
							num = (short)553123840;
							num3 = (int)((IntPtr)num);
							continue;
						}
						goto IL_354;
					case 14:
						if (button.Name.Equals(O9GraphicviewMenuItemsVisibilityConverter.b("簱唳䀵朷瘹夻堽㐿", a_)))
						{
							num = (short)1478295574;
							num3 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1841496077;
						num3 = (int)((IntPtr)num);
						continue;
					case 15:
						goto IL_265;
					case 16:
						num = (short)2012217346;
						num3 = (int)((IntPtr)num);
						continue;
					case 17:
						goto IL_354;
					case 18:
						num = (short)159383557;
						num3 = (int)((IntPtr)num);
						continue;
					case 19:
						goto IL_354;
					case 20:
						if ((int)this.bottom_screen_info.Tag > 0)
						{
							num = (short)1394343952;
							num3 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3D6;
					case 21:
						num = (short)574947335;
						num3 = (int)((IntPtr)num);
						continue;
					case 22:
						num = (short)1518862356;
						num3 = (int)((IntPtr)num);
						continue;
					case 23:
						if (this.MenuItemsTrunkingSelectedList.Visible)
						{
							num = (short)1672740874;
							num3 = (int)((IntPtr)num);
							continue;
						}
						goto IL_354;
					case 24:
						if (button != null)
						{
							num = (short)1025048585;
							num3 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_C6;
					IL_17B:
					num = (short)2044329992;
					num3 = (int)((IntPtr)num);
					continue;
					IL_265:
					int index = (int)this.bottom_screen_info.Tag + num4;
					int index_trk = (int)this.bottom_screen_info_Copy.Tag + num4;
					this.navigateMenuItems(index, index_trk, count, count2, this.MenuItemsConventionalSelectedList, this.MenuItemsTrunkingSelectedList);
					num = (short)361365523;
					num3 = (int)((IntPtr)num);
					continue;
					IL_327:
					if (!this.MenuItemsConventionalSelectedList.Visible)
					{
						num = (short)699203585;
						num3 = (int)((IntPtr)num);
						continue;
					}
					goto IL_265;
					IL_354:
					this.AdjustMenuItemStringFontSize();
					num = (short)356122630;
					num3 = (int)((IntPtr)num);
					continue;
					IL_379:
					int index2 = (int)this.bottom_screen_info.Tag - num4;
					int index_trk2 = (int)this.bottom_screen_info_Copy.Tag - num4;
					this.navigateMenuItems(index2, index_trk2, count, count2, this.MenuItemsConventionalSelectedList, this.MenuItemsTrunkingSelectedList);
					num = (short)140705809;
					num3 = (int)((IntPtr)num);
					continue;
					IL_3D6:
					num = (short)193069068;
					num3 = (int)((IntPtr)num);
				}
				return;
				IL_C6:
				num = (short)1182203905;
				if (num != 0)
				{
				}
				button = (sender as Button);
				num = (short)1236402200;
				num3 = (int)((IntPtr)num);
				goto IL_5B;
			}
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00072490 File Offset: 0x00070690
		private void navigateMenuItems(int index, int index_trk, int count, int count_trk, AcpListField cnv, AcpListField trk)
		{
			short num = (short)681312299;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (index >= 0)
					{
						num = (short)819265575;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4D8;
				case 1:
					num = (short)1027997704;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_96F;
				case 3:
					goto IL_96F;
				case 4:
					goto IL_139;
				case 5:
					goto IL_32B;
				case 6:
					this.bottom_screen_zone_Copy.Content = trk.Items[index_trk + 2].ItemName;
					num = (short)423034914;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					this.bottom_screen_scan_Copy.Content = trk.Items[index_trk + 1].ItemName;
					num = (short)1254031364;
					num2 = (int)((IntPtr)num);
					continue;
				case 8:
					if (index_trk + 1 < count_trk)
					{
						num = (short)1855979527;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2D4;
				case 9:
					if (index_trk + 2 < count_trk)
					{
						num = (short)579207174;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_890;
				case 10:
					num = (short)466485249;
					if (num != 0)
					{
					}
					num = (short)1510539277;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
					this.bottom_screen_info_Copy.Content = trk.Items[index_trk].ItemName;
					num = (short)887750686;
					num2 = (int)((IntPtr)num);
					continue;
				case 12:
					goto IL_1F9;
				case 13:
					if (index + 2 < count)
					{
						num = (short)1048576042;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_74B;
				case 14:
					num = (short)399638537;
					num2 = (int)((IntPtr)num);
					continue;
				case 15:
					this.bottom_screen_status_Copy.Content = trk.Items[index_trk + 3].ItemName;
					num = (short)968491032;
					num2 = (int)((IntPtr)num);
					continue;
				case 16:
					goto IL_93F;
				case 17:
					if (index >= 0)
					{
						num = (short)504954932;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_866;
				case 18:
					goto IL_139;
				case 19:
					num = (short)745865239;
					num2 = (int)((IntPtr)num);
					continue;
				case 20:
					if (index >= 0)
					{
						num = (short)385482762;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_74B;
				case 21:
					if (index_trk >= 0)
					{
						num = (short)2034761747;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3FA;
				case 22:
					goto IL_426;
				case 23:
					if (index_trk + 4 < count_trk)
					{
						num = (short)1555431464;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3FA;
				case 24:
					goto IL_32B;
				case 25:
					num = (short)1171849242;
					num2 = (int)((IntPtr)num);
					continue;
				case 26:
					if (index_trk + 3 < count_trk)
					{
						num = (short)979763215;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3CD;
				case 27:
					if (index + 1 < count)
					{
						num = (short)1846870072;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_4D8;
				case 28:
					goto IL_421;
				case 29:
					goto IL_426;
				case 30:
				{
					num = (short)1327438663;
					short num3 = num;
					num = (short)101391175;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_376;
					default:
						num = (short)1664090112;
						if (num != 0)
						{
						}
						goto IL_7B3;
					}
					break;
				}
				case 31:
					goto IL_505;
				case 32:
					if (index >= 0)
					{
						num = (short)745340982;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5F4;
				case 33:
					if (index + 3 < count)
					{
						num = (short)4259899;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_5F4;
				case 34:
					goto IL_6D3;
				case 35:
					goto IL_8BD;
				case 36:
					num = (short)1703608378;
					num2 = (int)((IntPtr)num);
					continue;
				case 37:
					if (index + 4 < count)
					{
						num = (short)1032650805;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_866;
				case 38:
					goto IL_7B3;
				case 39:
					num = (short)1622605851;
					num2 = (int)((IntPtr)num);
					continue;
				case 40:
					this.bottom_screen_contacts_Copy.Content = trk.Items[index_trk + 4].ItemName;
					num = (short)1388183568;
					num2 = (int)((IntPtr)num);
					continue;
				case 41:
					goto IL_1F9;
				case 42:
					this.bottom_screen_zone.Content = cnv.Items[index + 2].ItemName;
					num = (short)1044381742;
					num2 = (int)((IntPtr)num);
					continue;
				case 43:
					switch (0)
					{
					case 0:
						goto IL_114;
					}
					continue;
				case 44:
					if (index < count)
					{
						num = (short)614006835;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_944;
				case 45:
					if (index_trk >= 0)
					{
						num = (short)55705636;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_366;
				case 46:
					goto IL_505;
				case 47:
					num = (short)225837100;
					num2 = (int)((IntPtr)num);
					continue;
				case 48:
					if (index_trk >= 0)
					{
						num = (short)2086797326;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_890;
				case 49:
					if (index_trk >= 0)
					{
						num = (short)1619132417;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2D4;
				case 50:
					goto IL_6D3;
				case 51:
					this.bottom_screen_info.Content = cnv.Items[index].ItemName;
					num = (short)61669379;
					num2 = (int)((IntPtr)num);
					continue;
				case 52:
					num = (short)1968635941;
					num2 = (int)((IntPtr)num);
					continue;
				case 53:
					this.bottom_screen_contacts.Content = cnv.Items[index + 4].ItemName;
					num = (short)176554019;
					num2 = (int)((IntPtr)num);
					continue;
				case 54:
					num = (short)699531297;
					num2 = (int)((IntPtr)num);
					continue;
				case 55:
					if (index_trk >= 0)
					{
						num = (short)363528217;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3CD;
				case 56:
					this.bottom_screen_scan.Content = cnv.Items[index + 1].ItemName;
					num = (short)1873018921;
					num2 = (int)((IntPtr)num);
					continue;
				case 57:
					goto IL_8BD;
				case 58:
					if (index_trk < count_trk)
					{
						num = (short)2049638411;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_366;
				case 59:
					this.bottom_screen_status.Content = cnv.Items[index + 3].ItemName;
					num = (short)454623261;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_114:
				if (index >= 0)
				{
					num = (short)282460207;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_944;
				IL_139:
				num = (short)405995568;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1F9:
				num = (short)1758068756;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2D4:
				num = (short)632684544;
				short num4 = num;
				this.bottom_screen_scan_Copy.Content = string.Empty;
				num = (short)412876818;
				num2 = (int)((IntPtr)num);
				continue;
				IL_32B:
				num = (short)129695765;
				num2 = (int)((IntPtr)num);
				continue;
				IL_376:
				num = (short)804782118;
				num2 = (int)((IntPtr)num);
				continue;
				IL_366:
				this.bottom_screen_info_Copy.Content = string.Empty;
				goto IL_376;
				IL_3CD:
				this.bottom_screen_status_Copy.Content = string.Empty;
				num = (short)716046341;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3FA:
				this.bottom_screen_contacts_Copy.Content = string.Empty;
				num = (short)1442381852;
				num2 = (int)((IntPtr)num);
				continue;
				IL_426:
				num = (short)1789919249;
				num2 = (int)((IntPtr)num);
				continue;
				IL_4D8:
				this.bottom_screen_scan.Content = string.Empty;
				num = (short)1706754060;
				num2 = (int)((IntPtr)num);
				continue;
				IL_505:
				num = (short)1672282144;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5F4:
				this.bottom_screen_status.Content = string.Empty;
				num = (short)820707350;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6D3:
				num = (short)1323630647;
				num2 = (int)((IntPtr)num);
				continue;
				IL_74B:
				this.bottom_screen_zone.Content = string.Empty;
				num = (short)2110390303;
				num2 = (int)((IntPtr)num);
				continue;
				IL_7B3:
				num = (short)829489201;
				num2 = (int)((IntPtr)num);
				continue;
				IL_866:
				this.bottom_screen_contacts.Content = string.Empty;
				num = (short)134283321;
				num2 = (int)((IntPtr)num);
				continue;
				IL_890:
				this.bottom_screen_zone_Copy.Content = string.Empty;
				num = (short)569638962;
				num2 = (int)((IntPtr)num);
				continue;
				IL_8BD:
				this.bottom_screen_info.Tag = index;
				num = (short)821624877;
				num2 = (int)((IntPtr)num);
				continue;
				IL_944:
				this.bottom_screen_info.Content = string.Empty;
				num = (short)435552258;
				num2 = (int)((IntPtr)num);
				continue;
				IL_96F:
				num = (short)1540554752;
				num2 = (int)((IntPtr)num);
			}
			IL_421:
			IL_93F:
			this.bottom_screen_info_Copy.Tag = index_trk;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00072F10 File Offset: 0x00071110
		private void StartScrollingAcpLabel(AcpLabel label, Canvas canvas, ref bool isAnimating, TranslateTransform translateTransform)
		{
			int a_ = 4;
			short num = (short)2068381697;
			int num2 = (int)((IntPtr)num);
			DoubleAnimation doubleAnimation;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5C;
				case 1:
					goto IL_1F;
				case 2:
					doubleAnimation.Completed += this.EmergencyButtonFeature_AnimationCompleted;
					num = (short)203948036;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
				{
					num = (short)15073281;
					if (num != 0)
					{
					}
					if (!(label.Name == O9GraphicviewMenuItemsVisibilityConverter.b("挮匰弲瀴娶尸䤺娼娾⽀⁂㱄Ն㱈㽊㥌⁎㽐ᕒご㙖ⵘ⹚⽜㩞㝠੢dၦ୨Ѫᕬ㥮ၰὲtቶ", a_)))
					{
						goto IL_1F8;
					}
					num = (short)1262083363;
					short num3 = num;
					num = (short)1854987555;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F;
					default:
					{
						num = (short)1823408128;
						if (num != 0)
						{
						}
						num = (short)823197696;
						short num4 = num;
						num = (short)121962498;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 4:
					goto IL_87;
				}
				goto IL_43;
				IL_1F:
				switch (0)
				{
				case 0:
					IL_43:
					if (isAnimating)
					{
						num = (short)147128320;
						num2 = (int)((IntPtr)num);
					}
					else
					{
						isAnimating = true;
						doubleAnimation = new DoubleAnimation();
						doubleAnimation.From = new double?(0.0);
						doubleAnimation.To = new double?(0.0 - label.ActualWidth);
						doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(label.ActualWidth / 160.0));
						doubleAnimation.FillBehavior = FillBehavior.Stop;
						translateTransform.BeginAnimation(TranslateTransform.XProperty, doubleAnimation);
						num = (short)1297219587;
						num2 = (int)((IntPtr)num);
					}
					break;
				}
			}
			IL_5C:
			translateTransform.BeginAnimation(TranslateTransform.XProperty, null);
			isAnimating = false;
			return;
			IL_87:
			IL_1F8:
			translateTransform.BeginAnimation(TranslateTransform.XProperty, doubleAnimation);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00073124 File Offset: 0x00071324
		private void EmergencyButtonFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)749796753;
			short num2 = num;
			num = (short)1495989649;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1092550656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1248919552;
			if (num != 0)
			{
			}
			num = (short)165347329;
			if (num != 0)
			{
			}
			this.isEmergencyButtonFeatureAnimating = false;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000731D8 File Offset: 0x000713D8
		private void ScrollingEmergencyButtonFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1718157312;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)935985152;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					case 1:
						return;
					case 2:
						this.StartScrollingAcpLabel(this.LblEmergencyButtonFeatureViewboxValue, this.EmergencyButtonFeatureCanvas, ref this.isEmergencyButtonFeatureAnimating, this.RenderTransformEmergencyButtonFeatureViewbox);
						num = (short)1497366529;
						if (num != 0)
						{
						}
						num = (short)777912321;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_59:
					num = (short)1787551682;
					short num4 = num;
					num = (short)1205657538;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)420937728;
						if (num != 0)
						{
						}
						if ((sender as AcpLabel).ActualWidth <= 300.0)
						{
							return;
						}
						num = (short)489488386;
						num2 = (int)((IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00073318 File Offset: 0x00071518
		private void MouseEnterEmergencyButtonFeatureLabel(object sender, MouseEventArgs e)
		{
			short num = (short)693640937;
			short num2 = num;
			num = (short)1020993257;
			AcpLabel acpLabel;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)68157440;
				if (num != 0)
				{
				}
				num = (short)1422196737;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= 300.0)
				{
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
				break;
			}
			num = (short)15859712;
			short num3 = num;
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000733F4 File Offset: 0x000715F4
		private void EmergencyButtonFeatureLabelChanged(object sender, SizeChangedEventArgs e)
		{
			short num = (short)984251120;
			short num2 = num;
			num = (short)1404140272;
			AcpLabel acpLabel;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)856686592;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth >= 285.0)
				{
					Canvas.SetLeft(acpLabel, 0.0);
					return;
				}
				break;
			}
			num = (short)2032926721;
			if (num != 0)
			{
			}
			num = (short)599785472;
			short num3 = num;
			Canvas.SetLeft(acpLabel, 10.0);
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x000734D8 File Offset: 0x000716D8
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00073594 File Offset: 0x00071794
		public bool EmergencyButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)1805320193;
				if (num != 0)
				{
				}
				num = (short)1091174400;
				short num2 = num;
				num = (short)1075657257;
				short num3 = num;
				num = (short)964114985;
				switch (num3 == num)
				{
				}
				num = (short)1795948544;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.EmergencyButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1886056918;
				short num2 = num;
				num = (short)1939010006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1234960384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989986816;
				if (num != 0)
				{
				}
				num = (short)1150222337;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.EmergencyButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00073650 File Offset: 0x00071850
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00073708 File Offset: 0x00071908
		public bool EmergencyButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1743986896;
				short num2 = num;
				num = (short)910827728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1087766528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)699006977;
				if (num != 0)
				{
				}
				num = (short)1525743616;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1266155521;
				if (num != 0)
				{
				}
				num = (short)103022592;
				short num2 = num;
				num = (short)1944186381;
				short num3 = num;
				num = (short)1922297357;
				switch (num3 == num)
				{
				}
				num = (short)1794179072;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000737C0 File Offset: 0x000719C0
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00073878 File Offset: 0x00071A78
		public bool EmergencyButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)160527957;
				short num2 = num;
				num = (short)2084992597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)624689152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)207945728;
				if (num != 0)
				{
				}
				num = (short)1533673473;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1096756646;
				short num2 = num;
				num = (short)1479814566;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1740898304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)477429761;
				if (num != 0)
				{
				}
				num = (short)158662656;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00073930 File Offset: 0x00071B30
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x000739EC File Offset: 0x00071BEC
		public bool EmergencyButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1987759453;
				short num2 = num;
				num = (short)2011745629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)692518912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1051590657;
				if (num != 0)
				{
				}
				num = (short)1311506432;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.EmergencyButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)925419074;
				short num2 = num;
				num = (short)568247874;
				switch (num2 == num)
				{
				default:
				{
					num = (short)803340288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1150877697;
				if (num != 0)
				{
				}
				num = (short)1087373312;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.EmergencyButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00073AA8 File Offset: 0x00071CA8
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00073B60 File Offset: 0x00071D60
		public string EmergencyButtonFeatureUIValue
		{
			get
			{
				short num = (short)870303515;
				short num2 = num;
				num = (short)1705297691;
				switch (num2 == num)
				{
				default:
				{
					num = (short)52297728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1157890049;
				if (num != 0)
				{
				}
				num = (short)626524160;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O5GraphicView.EmergencyButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1994129409;
				if (num != 0)
				{
				}
				num = (short)1554317312;
				short num2 = num;
				num = (short)1682648489;
				short num3 = num;
				num = (short)1456025001;
				switch (num3 == num)
				{
				}
				num = (short)1251147776;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.EmergencyButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00073C14 File Offset: 0x00071E14
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00073CD0 File Offset: 0x00071ED0
		public AcpListField EmergencyButtonFeatureList
		{
			get
			{
				short num = (short)1581545398;
				short num2 = num;
				num = (short)799766454;
				switch (num2 == num)
				{
				default:
				{
					num = (short)490930176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)717029377;
				if (num != 0)
				{
				}
				num = (short)203685888;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O5GraphicView.EmergencyButtonFeatureListProperty);
			}
			set
			{
				short num = (short)586771316;
				short num2 = num;
				num = (short)735144820;
				switch (num2 == num)
				{
				default:
				{
					num = (short)590872576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)861536256;
				if (num != 0)
				{
				}
				num = (short)634060801;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.EmergencyButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00073D84 File Offset: 0x00071F84
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00073E3C File Offset: 0x0007203C
		public AcpListField MenuItemsConventionalSelectedList
		{
			get
			{
				short num = (short)1322254337;
				if (num != 0)
				{
				}
				num = (short)463273984;
				short num2 = num;
				num = (short)1744682155;
				short num3 = num;
				num = (short)974306475;
				switch (num3 == num)
				{
				}
				num = (short)1218314240;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O5GraphicView.MenuItemsConventionalSelectedListProperty);
			}
			set
			{
				short num = (short)1534613841;
				short num2 = num;
				num = (short)447568209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)197853184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2069757952;
				if (num != 0)
				{
				}
				num = (short)84672513;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.MenuItemsConventionalSelectedListProperty, value);
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00073EF0 File Offset: 0x000720F0
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00073FA8 File Offset: 0x000721A8
		public AcpListField MenuItemsTrunkingSelectedList
		{
			get
			{
				short num = (short)477094503;
				short num2 = num;
				num = (short)1076879975;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1614086144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1327104001;
				if (num != 0)
				{
				}
				num = (short)857276416;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O5GraphicView.MenuItemsTrunkingSelectedListProperty);
			}
			set
			{
				short num = (short)526346276;
				short num2 = num;
				num = (short)39610404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)248905728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1018429441;
				if (num != 0)
				{
				}
				num = (short)308674560;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.MenuItemsTrunkingSelectedListProperty, value);
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0007405C File Offset: 0x0007225C
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00074118 File Offset: 0x00072318
		public bool MenuItemsConventionalSelectedListVisibility
		{
			get
			{
				short num = (short)1262682113;
				if (num != 0)
				{
				}
				num = (short)2129723392;
				short num2 = num;
				num = (short)402374791;
				short num3 = num;
				num = (short)1597751431;
				switch (num3 == num)
				{
				}
				num = (short)126418944;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.MenuItemsConventionalSelectedListVisibilityProperty);
			}
			set
			{
				short num = (short)1149612731;
				short num2 = num;
				num = (short)1390588603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1856765952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1706885121;
				if (num != 0)
				{
				}
				num = (short)2621440;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.MenuItemsConventionalSelectedListVisibilityProperty, value);
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x000741D0 File Offset: 0x000723D0
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x0007428C File Offset: 0x0007248C
		public bool MenuItemsTrunkingSelectedListVisibility
		{
			get
			{
				short num = (short)418008606;
				short num2 = num;
				num = (short)331959838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)717357056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)756744193;
				if (num != 0)
				{
				}
				num = (short)1487405056;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty);
			}
			set
			{
				short num = (short)640745473;
				if (num != 0)
				{
				}
				num = (short)843317248;
				short num2 = num;
				num = (short)705506800;
				short num3 = num;
				num = (short)2072653296;
				switch (num3 == num)
				{
				}
				num = (short)1406205952;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty, value);
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00074348 File Offset: 0x00072548
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00074404 File Offset: 0x00072604
		public bool UpButtonIsAcpValid
		{
			get
			{
				short num = (short)1311308501;
				short num2 = num;
				num = (short)89389781;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1004666880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2129133569;
				if (num != 0)
				{
				}
				num = (short)1711472640;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.UpButtonIsAcpValidProperty);
			}
			set
			{
				short num = (short)1637032303;
				short num2 = num;
				num = (short)135864687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1244725248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)307691520;
				if (num != 0)
				{
				}
				num = (short)1757544449;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.UpButtonIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x000744BC File Offset: 0x000726BC
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00074574 File Offset: 0x00072774
		public bool UpButtonIsAcpApplicable
		{
			get
			{
				short num = (short)555287825;
				short num2 = num;
				num = (short)1420690705;
				switch (num2 == num)
				{
				}
				num = (short)1796014080;
				short num3 = num;
				num = (short)1785004033;
				if (num != 0)
				{
				}
				num = (short)39124992;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.UpButtonIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1933126325;
				short num2 = num;
				num = (short)146483893;
				switch (num2 == num)
				{
				}
				num = (short)1459945472;
				short num3 = num;
				num = (short)1760821249;
				if (num != 0)
				{
				}
				num = (short)943063040;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.UpButtonIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00074630 File Offset: 0x00072830
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x000746E8 File Offset: 0x000728E8
		public bool UpButtonIsAcpVisible
		{
			get
			{
				short num = (short)1490154874;
				short num2 = num;
				num = (short)1041036666;
				switch (num2 == num)
				{
				}
				num = (short)1668677632;
				short num3 = num;
				num = (short)1262878720;
				if (num != 0)
				{
				}
				num = (short)300613633;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.UpButtonIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)271179846;
				short num2 = num;
				num = (short)2137514054;
				switch (num2 == num)
				{
				}
				num = (short)602931200;
				short num3 = num;
				num = (short)2052915201;
				if (num != 0)
				{
				}
				num = (short)664666112;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.UpButtonIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x000747A0 File Offset: 0x000729A0
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00074858 File Offset: 0x00072A58
		public bool UpButtonIsAcpEditable
		{
			get
			{
				short num = (short)1347978792;
				short num2 = num;
				num = (short)1267172904;
				switch (num2 == num)
				{
				}
				num = (short)1202716672;
				short num3 = num;
				num = (short)1223819265;
				if (num != 0)
				{
				}
				num = (short)1375404032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.UpButtonIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1484218112;
				short num2 = num;
				num = (short)829251328;
				switch (num2 == num)
				{
				}
				num = (short)332201984;
				short num3 = num;
				num = (short)686882817;
				if (num != 0)
				{
				}
				num = (short)805175296;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.UpButtonIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00074914 File Offset: 0x00072B14
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x000749CC File Offset: 0x00072BCC
		public string UpButtonUIValue
		{
			get
			{
				short num = (short)368242726;
				short num2 = num;
				num = (short)702672934;
				switch (num2 == num)
				{
				}
				num = (short)60162048;
				short num3 = num;
				num = (short)90832897;
				if (num != 0)
				{
				}
				num = (short)988086272;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O5GraphicView.UpButtonUIValueProperty);
			}
			set
			{
				short num = (short)1639417152;
				short num2 = num;
				num = (short)1364428096;
				switch (num2 == num)
				{
				}
				num = (short)438501376;
				short num3 = num;
				num = (short)1845624832;
				if (num != 0)
				{
				}
				num = (short)1723203585;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.UpButtonUIValueProperty, value);
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00074A80 File Offset: 0x00072C80
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00074B38 File Offset: 0x00072D38
		public AcpListField UpButtonList
		{
			get
			{
				short num = (short)130227297;
				short num2 = num;
				num = (short)406592609;
				switch (num2 == num)
				{
				}
				num = (short)464650240;
				short num3 = num;
				num = (short)1886912513;
				if (num != 0)
				{
				}
				num = (short)436076544;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O5GraphicView.UpButtonListProperty);
			}
			set
			{
				short num = (short)990405544;
				short num2 = num;
				num = (short)1705206696;
				switch (num2 == num)
				{
				}
				num = (short)1923612672;
				short num3 = num;
				num = (short)465305601;
				if (num != 0)
				{
				}
				num = (short)2030632960;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.UpButtonListProperty, value);
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00074BF0 File Offset: 0x00072DF0
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x00074CA8 File Offset: 0x00072EA8
		public bool DownButtonIsAcpValid
		{
			get
			{
				short num = (short)1919331596;
				short num2 = num;
				num = (short)1564912908;
				switch (num2 == num)
				{
				}
				num = (short)1590427648;
				short num3 = num;
				num = (short)1468530688;
				if (num != 0)
				{
				}
				num = (short)479133697;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.DownButtonIsAcpValidProperty);
			}
			set
			{
				short num = (short)802461697;
				short num2 = num;
				num = (short)2020448257;
				switch (num2 == num)
				{
				}
				num = (short)611647488;
				short num3 = num;
				num = (short)80478208;
				if (num != 0)
				{
				}
				num = (short)1719009281;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.DownButtonIsAcpValidProperty, value);
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00074D68 File Offset: 0x00072F68
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00074E28 File Offset: 0x00073028
		public bool DownButtonIsAcpApplicable
		{
			get
			{
				short num = (short)126717897;
				short num2 = num;
				num = (short)1689751497;
				switch (num2 == num)
				{
				}
				num = (short)1108606976;
				short num3 = num;
				num = (short)610009089;
				if (num != 0)
				{
				}
				num = (short)37158912;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.DownButtonIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)808374687;
				short num2 = num;
				num = (short)2093928863;
				switch (num2 == num)
				{
				}
				num = (short)1624178688;
				short num3 = num;
				num = (short)354353152;
				if (num != 0)
				{
				}
				num = (short)1125842945;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.DownButtonIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00074EE0 File Offset: 0x000730E0
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00074F98 File Offset: 0x00073198
		public bool DownButtonIsAcpVisible
		{
			get
			{
				short num = (short)1222617090;
				short num2 = num;
				num = (short)1144104962;
				switch (num2 == num)
				{
				}
				num = (short)683409408;
				short num3 = num;
				num = (short)602144769;
				if (num != 0)
				{
				}
				num = (short)470417408;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.DownButtonIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)846982547;
				short num2 = num;
				num = (short)1943858579;
				switch (num2 == num)
				{
				}
				num = (short)1382678528;
				short num3 = num;
				num = (short)79364097;
				if (num != 0)
				{
				}
				num = (short)1496252416;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.DownButtonIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00075054 File Offset: 0x00073254
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x0007510C File Offset: 0x0007330C
		public bool DownButtonIsAcpEditable
		{
			get
			{
				short num = (short)429654017;
				if (num != 0)
				{
				}
				num = (short)490140877;
				short num2 = num;
				num = (short)857797837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)508100608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1776418816;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O5GraphicView.DownButtonIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1564258439;
				short num2 = num;
				num = (short)343453831;
				switch (num2 == num)
				{
				}
				num = (short)2107637760;
				short num3 = num;
				num = (short)627703809;
				if (num != 0)
				{
				}
				num = (short)905183232;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.DownButtonIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x000751C8 File Offset: 0x000733C8
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00075280 File Offset: 0x00073480
		public string DownButtonUIValue
		{
			get
			{
				short num = (short)82373313;
				short num2 = num;
				num = (short)1318972097;
				switch (num2 == num)
				{
				}
				num = (short)1603993600;
				short num3 = num;
				num = (short)1768357889;
				if (num != 0)
				{
				}
				num = (short)184877056;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O5GraphicView.DownButtonUIValueProperty);
			}
			set
			{
				short num = (short)51618512;
				short num2 = num;
				num = (short)1445831376;
				switch (num2 == num)
				{
				}
				num = (short)673316864;
				short num3 = num;
				num = (short)1851326464;
				if (num != 0)
				{
				}
				num = (short)217317377;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.DownButtonUIValueProperty, value);
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00075334 File Offset: 0x00073534
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x000753EC File Offset: 0x000735EC
		public AcpListField DownButtonList
		{
			get
			{
				short num = (short)1528303489;
				short num2 = num;
				num = (short)11341697;
				switch (num2 == num)
				{
				}
				num = (short)1272709120;
				short num3 = num;
				num = (short)1396113409;
				if (num != 0)
				{
				}
				num = (short)1265238016;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O5GraphicView.DownButtonListProperty);
			}
			set
			{
				short num = (short)1547567455;
				short num2 = num;
				num = (short)2003763551;
				switch (num2 == num)
				{
				}
				num = (short)1672019968;
				short num3 = num;
				num = (short)836632577;
				if (num != 0)
				{
				}
				num = (short)472776704;
				if (num != 0)
				{
				}
				base.SetValue(O5GraphicView.DownButtonListProperty, value);
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00075B50 File Offset: 0x00073D50
		// Note: this type is marked as 'beforefieldinit'.
		static O5GraphicView()
		{
			int a_ = 11;
			short num = (short)1959782426;
			short num2 = num;
			num = (short)415229978;
			switch (num2 == num)
			{
			}
			num = (short)1897725952;
			short num3 = num;
			num = (short)1923612673;
			if (num != 0)
			{
			}
			num = (short)622723072;
			if (num != 0)
			{
			}
			O5GraphicView.EmergencyButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猵唷弹主夽┿ⱁ❃㽅ੇ㽉㡋㩍㽏㱑ቓ㍕㥗⹙⥛ⱝ՟⭡ᝣ❥୧ᩩ㩫཭ᱯ᭱ၳ", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猵唷弹主夽┿ⱁ❃㽅ੇ㽉㡋㩍㽏㱑ቓ㍕㥗⹙⥛ⱝ՟⭡ᝣ❥୧ᩩ⵫ṭoṱᵳᕵ᥷᡹ၻ᭽", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猵唷弹主夽┿ⱁ❃㽅ੇ㽉㡋㩍㽏㱑ቓ㍕㥗⹙⥛ⱝ՟⭡ᝣ❥୧ᩩ㩫ݭͯ᭱ᙳ᩵ᵷ", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.EmergencyButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猵唷弹主夽┿ⱁ❃㽅ੇ㽉㡋㩍㽏㱑ቓ㍕㥗⹙⥛ⱝ՟⭡ᝣ❥୧ᩩ⥫੭᥯ٱᕳᑵᑷό", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.EmergencyButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猵唷弹主夽┿ⱁ❃㽅ੇ㽉㡋㩍㽏㱑ቓ㍕㥗⹙⥛ⱝ՟㝡ⵣづ१٩ᥫ୭", a_), typeof(string), typeof(O5GraphicView));
			O5GraphicView.EmergencyButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猵唷弹主夽┿ⱁ❃㽅ੇ㽉㡋㩍㽏㱑ቓ㍕㥗⹙⥛ⱝ՟⹡ൣᕥᱧ", a_), typeof(AcpListField), typeof(O5GraphicView));
			O5GraphicView.MenuItemsConventionalSelectedListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("笵崷吹䤻眽㐿❁⥃㕅େ╉≋㡍㕏㱑⁓㽕㝗㑙㵛㉝㍟ݡࡣͥ୧ṩ५੭㱯᭱ݳɵ", a_), typeof(AcpListField), typeof(O5GraphicView));
			O5GraphicView.MenuItemsTrunkingSelectedListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("笵崷吹䤻眽㐿❁⥃㕅᱇㡉㥋⁍㭏㭑㩓ㅕୗ㽙せ㭝͟ᙡţɥ⑧ͩὫᩭ", a_), typeof(AcpListField), typeof(O5GraphicView));
			O5GraphicView.MenuItemsConventionalSelectedListVisibilityProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("笵崷吹䤻眽㐿❁⥃㕅େ╉≋㡍㕏㱑⁓㽕㝗㑙㵛㉝㍟ݡࡣͥ୧ṩ५੭㱯᭱ݳɵ⹷፹ཻ᝽ﲇ", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("笵崷吹䤻眽㐿❁⥃㕅᱇㡉㥋⁍㭏㭑㩓ㅕୗ㽙せ㭝͟ᙡţɥ⑧ͩὫᩭ♯᭱ݳή᩷፹ၻ᝽ﮁ", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.UpButtonIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("挵䠷砹䤻䨽㐿ⵁ⩃ཅ㭇୉⽋㹍ُ㍑㡓㽕㱗", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.UpButtonIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("挵䠷砹䤻䨽㐿ⵁ⩃ཅ㭇୉⽋㹍ᅏ≑⑓㩕ㅗ㥙㵛㱝౟ݡ", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.UpButtonIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("挵䠷砹䤻䨽㐿ⵁ⩃ཅ㭇୉⽋㹍ُ㭑❓㽕㩗㙙㥛", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.UpButtonIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("挵䠷砹䤻䨽㐿ⵁ⩃ཅ㭇୉⽋㹍ᕏ㙑㵓≕㥗㡙せ㭝", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.UpButtonUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("挵䠷砹䤻䨽㐿ⵁ⩃ፅŇ᱉ⵋ≍╏㝑", a_), typeof(string), typeof(O5GraphicView));
			O5GraphicView.UpButtonListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("挵䠷砹䤻䨽㐿ⵁ⩃੅ⅇ㥉㡋", a_), typeof(AcpListField), typeof(O5GraphicView));
			O5GraphicView.DownButtonIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("爵圷䴹刻簽㔿㙁ぃ⥅♇͉㽋ཌྷ㍏≑ɓ㝕㑗㍙㡛", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.DownButtonIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("爵圷䴹刻簽㔿㙁ぃ⥅♇͉㽋ཌྷ㍏≑ᕓ♕⡗㙙㕛㵝şaࡣͥ", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.DownButtonIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("爵圷䴹刻簽㔿㙁ぃ⥅♇͉㽋ཌྷ㍏≑ɓ㽕⭗㍙㹛㉝՟", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.DownButtonIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("爵圷䴹刻簽㔿㙁ぃ⥅♇͉㽋ཌྷ㍏≑ᅓ㉕ㅗ⹙㵛㱝౟ݡ", a_), typeof(bool), typeof(O5GraphicView));
			O5GraphicView.DownButtonUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("爵圷䴹刻簽㔿㙁ぃ⥅♇ὉՋᡍㅏ㹑⅓㍕", a_), typeof(string), typeof(O5GraphicView));
			O5GraphicView.DownButtonListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("爵圷䴹刻簽㔿㙁ぃ⥅♇ى╋㵍⑏", a_), typeof(AcpListField), typeof(O5GraphicView));
		}

		// Token: 0x040008DB RID: 2267
		private bool isEmergencyButtonFeatureAnimating;

		// Token: 0x040008DC RID: 2268
		public static DependencyProperty EmergencyButtonFeatureIsAcpValidProperty;

		// Token: 0x040008DD RID: 2269
		public static DependencyProperty EmergencyButtonFeatureIsAcpApplicableProperty;

		// Token: 0x040008DE RID: 2270
		public static DependencyProperty EmergencyButtonFeatureIsAcpVisibleProperty;

		// Token: 0x040008DF RID: 2271
		public static DependencyProperty EmergencyButtonFeatureIsAcpEditableProperty;

		// Token: 0x040008E0 RID: 2272
		public static DependencyProperty EmergencyButtonFeatureUIValueProperty;

		// Token: 0x040008E1 RID: 2273
		public static DependencyProperty EmergencyButtonFeatureListProperty;

		// Token: 0x040008E2 RID: 2274
		public static DependencyProperty MenuItemsConventionalSelectedListProperty;

		// Token: 0x040008E3 RID: 2275
		public static DependencyProperty MenuItemsTrunkingSelectedListProperty;

		// Token: 0x040008E4 RID: 2276
		public static DependencyProperty MenuItemsConventionalSelectedListVisibilityProperty;

		// Token: 0x040008E5 RID: 2277
		public static DependencyProperty MenuItemsTrunkingSelectedListVisibilityProperty;

		// Token: 0x040008E6 RID: 2278
		public static DependencyProperty UpButtonIsAcpValidProperty;

		// Token: 0x040008E7 RID: 2279
		public static DependencyProperty UpButtonIsAcpApplicableProperty;

		// Token: 0x040008E8 RID: 2280
		public static DependencyProperty UpButtonIsAcpVisibleProperty;

		// Token: 0x040008E9 RID: 2281
		public static DependencyProperty UpButtonIsAcpEditableProperty;

		// Token: 0x040008EA RID: 2282
		public static DependencyProperty UpButtonUIValueProperty;

		// Token: 0x040008EB RID: 2283
		public static DependencyProperty UpButtonListProperty;

		// Token: 0x040008EC RID: 2284
		public static DependencyProperty DownButtonIsAcpValidProperty;

		// Token: 0x040008ED RID: 2285
		public static DependencyProperty DownButtonIsAcpApplicableProperty;

		// Token: 0x040008EE RID: 2286
		public static DependencyProperty DownButtonIsAcpVisibleProperty;

		// Token: 0x040008EF RID: 2287
		public static DependencyProperty DownButtonIsAcpEditableProperty;

		// Token: 0x040008F0 RID: 2288
		public static DependencyProperty DownButtonUIValueProperty;

		// Token: 0x040008F1 RID: 2289
		public static DependencyProperty DownButtonListProperty;
	}
}
