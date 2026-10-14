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
using ControlHeadGraphicView.acpcontrol;
using ControlHeadGraphicView.converters;

namespace ControlHeadGraphicView
{
	// Token: 0x0200000D RID: 13
	public partial class O9GraphicView : UserControl
	{
		// Token: 0x0600089A RID: 2202 RVA: 0x0007E668 File Offset: 0x0007C868
		public O9GraphicView()
		{
			base.FlowDirection = FlowDirection.LeftToRight;
			this.InitializeComponent();
			base.DataContext = this;
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x0007E690 File Offset: 0x0007C890
		public static FlowDirection UIFlowDirection
		{
			get
			{
				short num = (short)13172736;
				short num2 = num;
				num = (short)1171456001;
				if (num != 0)
				{
				}
				num = (short)2052794638;
				short num3 = num;
				num = (short)1206987022;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1513357312;
					if (num != 0)
					{
					}
					if (!Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
					{
						return FlowDirection.LeftToRight;
					}
					break;
				}
				return FlowDirection.RightToLeft;
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0007E758 File Offset: 0x0007C958
		private void ShowAll(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1592852481;
			if (num != 0)
			{
			}
			num = (short)1520500736;
			short num2 = num;
			num = (short)1016233498;
			short num3 = num;
			num = (short)2120711706;
			switch (num3 == num)
			{
			}
			num = (short)747372544;
			if (num != 0)
			{
			}
			this.ShowAllButton.IsChecked = !this.ShowAllButton.IsChecked;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0007E840 File Offset: 0x0007CA40
		private void Pursuit_knob_Click(object sender, RoutedEventArgs e)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_5D;
			}
			int num;
			short num2;
			ToggleButton toggleButton;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					RotateTransform rotateTransform;
					if (rotateTransform != null)
					{
						num2 = (short)786759692;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				}
				case 1:
					if (toggleButton.Name.Equals(O9GraphicviewMenuItemsVisibilityConverter.b("缮䐰䄲䘴䈶倸伺缼䨾㕀㝂⩄⥆筈", a_)))
					{
						num2 = (short)1505493008;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)408748034;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					if (toggleButton.Name.Equals(O9GraphicviewMenuItemsVisibilityConverter.b("缮䐰䄲䘴䈶倸伺缼䨾㕀㝂⩄⥆穈", a_)))
					{
						num2 = (short)145555471;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_165;
				case 3:
					goto IL_165;
				case 4:
				{
					RotateTransform rotateTransform = new RotateTransform(0.0);
					num2 = (short)1230241799;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 5:
				{
					num2 = (short)1711734785;
					if (num2 != 0)
					{
					}
					RotateTransform rotateTransform = null;
					num2 = (short)365363210;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 6:
				{
					RotateTransform rotateTransform = new RotateTransform(-35.0);
					num2 = (short)512032781;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_165;
				case 8:
					if (toggleButton != null)
					{
						num2 = (short)1187053568;
						short num3 = num2;
						num2 = (short)1324744709;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 9:
					goto IL_165;
				case 10:
					if (toggleButton.Name.Equals(O9GraphicviewMenuItemsVisibilityConverter.b("缮䐰䄲䘴䈶倸伺缼䨾㕀㝂⩄⥆祈", a_)))
					{
						goto IL_221;
					}
					num2 = (short)1449787406;
					num = (int)((IntPtr)num2);
					continue;
				case 11:
					return;
				case 12:
				{
					num2 = (short)794449843;
					short num4 = num2;
					num2 = (short)1466128307;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_221;
					default:
					{
						num2 = (short)1828782080;
						if (num2 != 0)
						{
						}
						RotateTransform rotateTransform;
						this.Pursuit_Knob.RenderTransform = rotateTransform;
						num2 = (short)1759117323;
						num = (int)((IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 13:
					goto IL_165;
				case 14:
					if (toggleButton.Name.Equals(O9GraphicviewMenuItemsVisibilityConverter.b("缮䐰䄲䘴䈶倸伺缼䨾㕀㝂⩄⥆硈", a_)))
					{
						num2 = (short)1402994692;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)19595265;
					num = (int)((IntPtr)num2);
					continue;
				case 15:
				{
					RotateTransform rotateTransform = new RotateTransform(70.0);
					num2 = (short)280100873;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 16:
				{
					RotateTransform rotateTransform = new RotateTransform(35.0);
					num2 = (short)1266089987;
					num = (int)((IntPtr)num2);
					continue;
				}
				}
				goto IL_5D;
				IL_165:
				num2 = (short)164560896;
				num = (int)((IntPtr)num2);
				continue;
				IL_221:
				num2 = (short)748355590;
				num = (int)((IntPtr)num2);
			}
			return;
			IL_5D:
			toggleButton = (sender as ToggleButton);
			num2 = (short)2077425672;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0007EBD0 File Offset: 0x0007CDD0
		private void OnFieldNameDoubleClick(object sender, RoutedEventArgs e)
		{
			short num = (short)354963413;
			short num2 = num;
			num = (short)1776439253;
			switch (num2 == num)
			{
			}
			num = (short)1814691840;
			short num3 = num;
			num = (short)1117454336;
			if (num != 0)
			{
			}
			num = (short)1357053953;
			if (num != 0)
			{
			}
			Utility.GetFieldHelpText(sender);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0007EC84 File Offset: 0x0007CE84
		public override void EndInit()
		{
			short num = (short)65102655;
			short num2 = num;
			num = (short)313484095;
			switch (num2 == num)
			{
			}
			num = (short)595329024;
			short num3 = num;
			num = (short)1835597824;
			if (num != 0)
			{
			}
			num = (short)1296695297;
			if (num != 0)
			{
			}
			base.EndInit();
			this.SetMenuItems();
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0007ED38 File Offset: 0x0007CF38
		public void SetMenuItems()
		{
			short num = (short)1603862535;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_418;
				case 2:
					this.bottom_screen_contacts_Copy.Content = this.MenuItemsTrunkingSelectedList.Items[4].ItemName;
					num = (short)662044673;
					if (num != 0)
					{
					}
					num = (short)1965359105;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					goto IL_441;
				case 4:
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
						num = (short)2085355522;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_contacts_Copy.Content = string.Empty;
					num = (short)528285699;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 5:
					goto IL_266;
				case 6:
					goto IL_266;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 8:
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
						this.bottom_screen_status.Content = this.MenuItemsConventionalSelectedList.Items[3].ItemName;
					}
					else
					{
						this.bottom_screen_status.Content = string.Empty;
					}
					if (count2 >= 5)
					{
						num = (short)388956169;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_contacts.Content = string.Empty;
					num = (short)844349268;
					short num3 = num;
					num = (short)553631572;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B8;
					default:
						num = (short)1408696320;
						if (num != 0)
						{
						}
						num = (short)1652621318;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					goto IL_1B8;
				}
				IL_4D:
				if (this.MenuItemsConventionalSelectedList == null)
				{
					num = (short)5177344;
					num2 = (int)((IntPtr)num);
					continue;
				}
				num = (short)1320353800;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1B8:
				this.bottom_screen_contacts.Content = this.MenuItemsConventionalSelectedList.Items[4].ItemName;
				num = (short)694484997;
				num2 = (int)((IntPtr)num);
				continue;
				IL_266:
				num = (short)1836187652;
				num2 = (int)((IntPtr)num);
			}
			return;
			IL_418:
			goto IL_46B;
			IL_441:
			num = (short)1576927232;
			short num4 = num;
			IL_46B:
			this.AdjustMenuItemStringFontSize();
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0007F1B8 File Offset: 0x0007D3B8
		private void AdjustMenuItemStringFontSize()
		{
			short num = (short)1999568925;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_289;
				case 1:
					goto IL_577;
				case 2:
					if (this.bottom_screen_scan_Copy.Content.ToString().Length > 8)
					{
						num = (short)176357381;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_scan_Copy.FontSize = 11.0;
					num = (short)1503789071;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					if (this.bottom_screen_status_Copy.Content.ToString().Length > 8)
					{
						num = (short)1804009502;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_status_Copy.FontSize = 11.0;
					num = (short)1433010189;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					goto IL_673;
				case 5:
					this.bottom_screen_scan_Copy.FontSize = 9.0;
					num = (short)1508245516;
					num2 = (int)((IntPtr)num);
					continue;
				case 6:
					if (this.bottom_screen_info_Copy.Content.ToString().Length > 8)
					{
						num = (short)503119909;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_info_Copy.FontSize = 11.0;
					num = (short)1620508692;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					this.bottom_screen_zone_Copy.FontSize = 9.0;
					num = (short)1780219940;
					num2 = (int)((IntPtr)num);
					continue;
				case 8:
					if (this.bottom_screen_status.Content.ToString().Length > 8)
					{
						num = (short)659685402;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_status.FontSize = 11.0;
					num = (short)601227265;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
					goto IL_159;
				case 10:
					this.bottom_screen_zone.FontSize = 9.0;
					num = (short)1736245259;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
					goto IL_47F;
				case 12:
					goto IL_527;
				case 13:
					goto IL_6C1;
				case 14:
					goto IL_47F;
				case 15:
					goto IL_527;
				case 16:
					goto IL_6C1;
				case 17:
					if (this.bottom_screen_contacts_Copy.Content.ToString().Length > 8)
					{
						num = (short)2065170457;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7D5;
				case 18:
					this.bottom_screen_info.FontSize = 9.0;
					num = (short)2039676949;
					num2 = (int)((IntPtr)num);
					continue;
				case 19:
					goto IL_159;
				case 20:
					goto IL_5F3;
				case 21:
				{
					num = (short)1900718234;
					short num3 = num;
					num = (short)1202038938;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A5;
					default:
						num = (short)508362752;
						if (num != 0)
						{
						}
						goto IL_673;
					}
					break;
				}
				case 22:
					if (this.bottom_screen_zone.Content.ToString().Length > 8)
					{
						num = (short)1942880266;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_zone.FontSize = 11.0;
					num = (short)660275214;
					num2 = (int)((IntPtr)num);
					continue;
				case 23:
					goto IL_577;
				case 24:
					if (this.bottom_screen_scan.Content.ToString().Length > 8)
					{
						goto IL_6A5;
					}
					num = (short)257228801;
					if (num != 0)
					{
					}
					this.bottom_screen_scan.FontSize = 11.0;
					num = (short)1539244051;
					num2 = (int)((IntPtr)num);
					continue;
				case 25:
					goto IL_70A;
				case 26:
					this.bottom_screen_status.FontSize = 9.0;
					num = (short)550436887;
					num2 = (int)((IntPtr)num);
					continue;
				case 27:
				{
					if (this.bottom_screen_zone_Copy.Content.ToString().Length > 8)
					{
						num = (short)682098695;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_zone_Copy.FontSize = 11.0;
					num = (short)831062016;
					short num4 = num;
					num = (short)648937500;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 28:
					goto IL_1A7;
				case 29:
					switch (0)
					{
					case 0:
						goto IL_BE;
					}
					continue;
				case 30:
					this.bottom_screen_status_Copy.FontSize = 9.0;
					num = (short)1082458128;
					num2 = (int)((IntPtr)num);
					continue;
				case 31:
					goto IL_289;
				case 32:
					this.bottom_screen_scan.FontSize = 9.0;
					num = (short)2099642377;
					num2 = (int)((IntPtr)num);
					continue;
				case 33:
					if (this.bottom_screen_contacts.Content.ToString().Length > 8)
					{
						num = (short)1152778274;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.bottom_screen_contacts.FontSize = 11.0;
					num = (short)1365180416;
					num2 = (int)((IntPtr)num);
					continue;
				case 34:
					this.bottom_screen_contacts.FontSize = 9.0;
					num = (short)154271775;
					num2 = (int)((IntPtr)num);
					continue;
				case 35:
					goto IL_5F3;
				case 36:
					goto IL_1A7;
				case 37:
					this.bottom_screen_info_Copy.FontSize = 9.0;
					num = (short)143392803;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_BE:
				if (this.bottom_screen_info.Content.ToString().Length > 8)
				{
					num = (short)469303314;
					num2 = (int)((IntPtr)num);
					continue;
				}
				this.bottom_screen_info.FontSize = 11.0;
				num = (short)698023940;
				num2 = (int)((IntPtr)num);
				continue;
				IL_159:
				num = (short)489095190;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1A7:
				num = (short)928120835;
				num2 = (int)((IntPtr)num);
				continue;
				IL_289:
				num = (short)2032992262;
				num2 = (int)((IntPtr)num);
				continue;
				IL_47F:
				num = (short)1962409992;
				num2 = (int)((IntPtr)num);
				continue;
				IL_527:
				num = (short)1264451611;
				num2 = (int)((IntPtr)num);
				continue;
				IL_577:
				num = (short)711065633;
				num2 = (int)((IntPtr)num);
				continue;
				IL_5F3:
				num = (short)908263426;
				num2 = (int)((IntPtr)num);
				continue;
				IL_673:
				num = (short)1631977496;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6A5:
				num = (short)1307115552;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6C1:
				num = (short)415760401;
				num2 = (int)((IntPtr)num);
			}
			IL_70A:
			this.bottom_screen_contacts_Copy.FontSize = 9.0;
			return;
			IL_7D5:
			this.bottom_screen_contacts_Copy.FontSize = 11.0;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0007F9B0 File Offset: 0x0007DBB0
		private void NavLeftRight_Click(object sender, RoutedEventArgs e)
		{
			int a_ = 8;
			short num = (short)1001783296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9B;
				}
				Button button;
				for (;;)
				{
					IL_30:
					int count;
					int count2;
					int num4;
					switch (num2)
					{
					case 0:
					{
						num = (short)616038400;
						short num3 = num;
						count = this.MenuItemsConventionalSelectedList.Items.Count;
						count2 = this.MenuItemsTrunkingSelectedList.Items.Count;
						num4 = 5;
						num = (short)2036269076;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
						if ((int)this.bottom_screen_info.Tag > 0)
						{
							num = (short)1507341;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_3A7;
					case 2:
						num = (short)1821704211;
						num2 = (int)((IntPtr)num);
						continue;
					case 3:
						if (this.MenuItemsTrunkingSelectedList.Visible)
						{
							num = (short)1009057815;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2B5;
					case 4:
						goto IL_1C5;
					case 5:
						goto IL_31D;
					case 6:
						goto IL_2B5;
					case 7:
						if (this.MenuItemsTrunkingSelectedList.Visible)
						{
							num = (short)226689028;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2B5;
					case 8:
						if (!this.MenuItemsConventionalSelectedList.Visible)
						{
							num = (short)1314783256;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_349;
					case 9:
						num = (short)334561281;
						num2 = (int)((IntPtr)num);
						continue;
					case 10:
						num = (short)901906435;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
						num = (short)1821114375;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
						goto IL_2B5;
					case 13:
						num = (short)1871052808;
						num2 = (int)((IntPtr)num);
						continue;
					case 14:
						goto IL_DD;
					case 15:
						if (!this.MenuItemsConventionalSelectedList.Visible)
						{
							num = (short)1059651598;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1C5;
					case 16:
						if (button != null)
						{
							num = (short)1356529664;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 17:
						if (button.Name.Equals(O9GraphicviewMenuItemsVisibilityConverter.b("紲吴䄶昸䤺吼堾⥀㝂", a_)))
						{
							num = (short)2060976130;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2B5;
					case 18:
						IL_482:
						num = (short)244580367;
						num2 = (int)((IntPtr)num);
						continue;
					case 19:
						if ((int)this.bottom_screen_info.Tag + num4 < count)
						{
							num = (short)2016346130;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_DD;
					case 20:
						if (button.Name.Equals(O9GraphicviewMenuItemsVisibilityConverter.b("紲吴䄶昸场堼夾㕀", a_)))
						{
							num = (short)1232732169;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)107413521;
						num2 = (int)((IntPtr)num);
						continue;
					case 21:
						if ((int)this.bottom_screen_info_Copy.Tag > 0)
						{
							num = (short)1264779274;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2B5;
					case 22:
						if ((int)this.bottom_screen_info_Copy.Tag + num4 < count2)
						{
							num = (short)328990731;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2B5;
					case 23:
						goto IL_349;
					case 24:
						goto IL_3A7;
					}
					goto IL_9B;
					IL_DD:
					num = (short)541589526;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1C5:
					int index = (int)this.bottom_screen_info.Tag + num4;
					int index_trk = (int)this.bottom_screen_info_Copy.Tag + num4;
					this.navigateMenuItems(index, index_trk, count, count2, this.MenuItemsConventionalSelectedList, this.MenuItemsTrunkingSelectedList);
					num = (short)831324166;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2B5:
					this.AdjustMenuItemStringFontSize();
					num = (short)323649037;
					short num5 = num;
					num = (short)365919757;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_482;
					default:
						num = (short)60227584;
						if (num != 0)
						{
						}
						num = (short)1254490117;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_349:
					int index2 = (int)this.bottom_screen_info.Tag - num4;
					int index_trk2 = (int)this.bottom_screen_info_Copy.Tag - num4;
					this.navigateMenuItems(index2, index_trk2, count, count2, this.MenuItemsConventionalSelectedList, this.MenuItemsTrunkingSelectedList);
					num = (short)1805451276;
					num2 = (int)((IntPtr)num);
					continue;
					IL_3A7:
					num = (short)108724245;
					num2 = (int)((IntPtr)num);
				}
				IL_31D:
				num = (short)1333526529;
				if (num != 0)
				{
				}
				return;
				IL_9B:
				button = (sender as Button);
				num = (short)612040720;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0007FF2C File Offset: 0x0007E12C
		private void navigateMenuItems(int index, int index_trk, int count, int count_trk, AcpListField cnv, AcpListField trk)
		{
			short num = (short)6815770;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (index >= 0)
					{
						num = (short)580321299;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6E1;
				case 1:
					goto IL_851;
				case 2:
					if (index >= 0)
					{
						num = (short)504102929;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7FA;
				case 3:
					num = (short)142213157;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1396176660;
					short num3 = num;
					num = (short)675739412;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_25E;
					default:
						num = (short)402980864;
						if (num != 0)
						{
						}
						if (index_trk >= 0)
						{
							num = (short)1877475341;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2CB;
					}
					break;
				}
				case 5:
					if (index_trk >= 0)
					{
						num = (short)1126760502;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_824;
				case 6:
					goto IL_25E;
				case 7:
					goto IL_497;
				case 8:
					if (index_trk < count_trk)
					{
						num = (short)973471767;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_2CB;
				case 9:
					this.bottom_screen_zone_Copy.Content = trk.Items[index_trk + 2].ItemName;
					num = (short)1445986316;
					num2 = (int)((IntPtr)num);
					continue;
				case 10:
					if (index_trk + 1 < count_trk)
					{
						num = (short)36044816;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_263;
				case 11:
					if (index + 2 < count)
					{
						num = (short)1785790512;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_6E1;
				case 12:
					goto IL_669;
				case 13:
					num = (short)179503105;
					if (num != 0)
					{
					}
					num = (short)239403016;
					num2 = (int)((IntPtr)num);
					continue;
				case 14:
					goto IL_942;
				case 15:
					goto IL_38F;
				case 16:
					this.bottom_screen_scan_Copy.Content = trk.Items[index_trk + 1].ItemName;
					num = (short)1191313426;
					num2 = (int)((IntPtr)num);
					continue;
				case 17:
					num = (short)1012138037;
					num2 = (int)((IntPtr)num);
					continue;
				case 18:
					goto IL_138;
				case 19:
				{
					num = (short)1868103680;
					short num4 = num;
					num = (short)1725104139;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 20:
					this.bottom_screen_info.Content = cnv.Items[index].ItemName;
					num = (short)91619379;
					num2 = (int)((IntPtr)num);
					continue;
				case 21:
					this.bottom_screen_status_Copy.Content = trk.Items[index_trk + 3].ItemName;
					num = (short)747241527;
					num2 = (int)((IntPtr)num);
					continue;
				case 22:
					goto IL_290;
				case 23:
					this.bottom_screen_info_Copy.Content = trk.Items[index_trk].ItemName;
					num = (short)862650414;
					num2 = (int)((IntPtr)num);
					continue;
				case 24:
					if (index_trk >= 0)
					{
						num = (short)2055798812;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_335;
				case 25:
					if (index >= 0)
					{
						num = (short)114753579;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_46B;
				case 26:
					switch (0)
					{
					case 0:
						goto IL_114;
					}
					continue;
				case 27:
					this.bottom_screen_contacts_Copy.Content = trk.Items[index_trk + 4].ItemName;
					num = (short)891093006;
					num2 = (int)((IntPtr)num);
					continue;
				case 28:
					num = (short)1057226787;
					num2 = (int)((IntPtr)num);
					continue;
				case 29:
					goto IL_38A;
				case 30:
					this.bottom_screen_contacts.Content = cnv.Items[index + 4].ItemName;
					num = (short)1010040833;
					num2 = (int)((IntPtr)num);
					continue;
				case 31:
					num = (short)931528742;
					num2 = (int)((IntPtr)num);
					continue;
				case 32:
					if (index_trk + 2 < count_trk)
					{
						num = (short)261685257;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_824;
				case 33:
					goto IL_1AD;
				case 34:
					goto IL_1AD;
				case 35:
					if (index_trk + 3 < count_trk)
					{
						num = (short)1217658901;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_335;
				case 36:
					if (index_trk >= 0)
					{
						num = (short)1110704131;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_363;
				case 37:
					if (index_trk + 4 < count_trk)
					{
						num = (short)680394779;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_363;
				case 38:
					if (index < count)
					{
						num = (short)1450508308;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_947;
				case 39:
					num = (short)485949497;
					num2 = (int)((IntPtr)num);
					continue;
				case 40:
					this.bottom_screen_status.Content = cnv.Items[index + 3].ItemName;
					num = (short)418578474;
					num2 = (int)((IntPtr)num);
					continue;
				case 41:
					goto IL_851;
				case 42:
					goto IL_38F;
				case 43:
					num = (short)2140340283;
					num2 = (int)((IntPtr)num);
					continue;
				case 44:
					if (index >= 0)
					{
						num = (short)1574895655;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_587;
				case 45:
					goto IL_669;
				case 46:
					goto IL_748;
				case 47:
					goto IL_138;
				case 48:
					this.bottom_screen_zone.Content = cnv.Items[index + 2].ItemName;
					num = (short)2083848199;
					num2 = (int)((IntPtr)num);
					continue;
				case 49:
					num = (short)1430650890;
					num2 = (int)((IntPtr)num);
					continue;
				case 50:
					goto IL_748;
				case 51:
					goto IL_972;
				case 52:
					goto IL_497;
				case 53:
					if (index + 4 < count)
					{
						num = (short)681508894;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_7FA;
				case 54:
					num = (short)1929117728;
					num2 = (int)((IntPtr)num);
					continue;
				case 55:
					goto IL_290;
				case 56:
					goto IL_972;
				case 57:
					if (index + 3 < count)
					{
						num = (short)1945501736;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_587;
				case 58:
					if (index_trk >= 0)
					{
						num = (short)1325400113;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_263;
				case 59:
					if (index + 1 < count)
					{
						num = (short)367984646;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_46B;
				}
				IL_114:
				if (index >= 0)
				{
					num = (short)1921253407;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_947;
				IL_138:
				num = (short)985464837;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1AD:
				num = (short)275841024;
				num2 = (int)((IntPtr)num);
				continue;
				IL_25E:
				this.bottom_screen_scan.Content = cnv.Items[index + 1].ItemName;
				num = (short)1145896994;
				num2 = (int)((IntPtr)num);
				continue;
				IL_263:
				this.bottom_screen_scan_Copy.Content = string.Empty;
				num = (short)29032495;
				num2 = (int)((IntPtr)num);
				continue;
				IL_290:
				num = (short)825294884;
				num2 = (int)((IntPtr)num);
				continue;
				IL_2CB:
				this.bottom_screen_info_Copy.Content = string.Empty;
				num = (short)2091384882;
				num2 = (int)((IntPtr)num);
				continue;
				IL_335:
				this.bottom_screen_status_Copy.Content = string.Empty;
				num = (short)226689046;
				num2 = (int)((IntPtr)num);
				continue;
				IL_363:
				this.bottom_screen_contacts_Copy.Content = string.Empty;
				num = (short)1210908701;
				num2 = (int)((IntPtr)num);
				continue;
				IL_38F:
				num = (short)291569666;
				num2 = (int)((IntPtr)num);
				continue;
				IL_46B:
				this.bottom_screen_scan.Content = string.Empty;
				num = (short)668467233;
				num2 = (int)((IntPtr)num);
				continue;
				IL_497:
				num = (short)1661534252;
				num2 = (int)((IntPtr)num);
				continue;
				IL_587:
				this.bottom_screen_status.Content = string.Empty;
				num = (short)1831075855;
				num2 = (int)((IntPtr)num);
				continue;
				IL_669:
				num = (short)489816088;
				num2 = (int)((IntPtr)num);
				continue;
				IL_6E1:
				this.bottom_screen_zone.Content = string.Empty;
				num = (short)1631715380;
				num2 = (int)((IntPtr)num);
				continue;
				IL_748:
				num = (short)1854603322;
				num2 = (int)((IntPtr)num);
				continue;
				IL_7FA:
				this.bottom_screen_contacts.Content = string.Empty;
				num = (short)1070333993;
				num2 = (int)((IntPtr)num);
				continue;
				IL_824:
				this.bottom_screen_zone_Copy.Content = string.Empty;
				num = (short)201130029;
				num2 = (int)((IntPtr)num);
				continue;
				IL_851:
				this.bottom_screen_info.Tag = index;
				num = (short)949288964;
				num2 = (int)((IntPtr)num);
				continue;
				IL_947:
				this.bottom_screen_info.Content = string.Empty;
				num = (short)278331448;
				num2 = (int)((IntPtr)num);
				continue;
				IL_972:
				num = (short)46858265;
				num2 = (int)((IntPtr)num);
			}
			IL_38A:
			IL_942:
			this.bottom_screen_info_Copy.Tag = index_trk;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000809B0 File Offset: 0x0007EBB0
		private void StartScrollingAcpLabel(AcpLabel label, Canvas canvas, ref bool isAnimating, TranslateTransform translateTransform)
		{
			int a_ = 2;
			short num = (short)648675357;
			int num2 = (int)((IntPtr)num);
			DoubleAnimation doubleAnimation;
			for (;;)
			{
				string name;
				uint num3;
				switch (num2)
				{
				case 0:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰缲尴倶儸伺弼帾㍀ᝂ⩄㝆H╊⥌⩎⥐Ւ㱔㉖⹘㥚㉜❞㝠ɢ।ቦ౨", a_)))
					{
						num = (short)944832627;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LightbarTopIndex_AnimationCompleted;
					num = (short)1092944077;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ煄ņⱈ⩊㥌㩎⍐㙒͔㹖㱘ⱚ㽜ぞᥠ㕢Ѥ୦ᱨ๪", a_)))
					{
						num = (short)1136525323;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton4Feature_AnimationCompleted;
					num = (short)415891631;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					if (num3 != 1910612056U)
					{
						num = (short)1079050554;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)959381770;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					num = (short)1728184627;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					goto IL_FC3;
				case 5:
					goto IL_216D;
				case 6:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰挲䀴䔶䨸为吼䬾̀㙂ㅄ㍆♈╊経ॎ㑐㉒⅔≖⭘㹚ଡ଼㙞Ѡᑢݤࡦᅨ㵪౬ͮѰᙲ", a_)))
					{
						num = (short)1063583934;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.PursuitButton0Feature_AnimationCompleted;
					num = (short)855179330;
					num2 = (int)((IntPtr)num);
					continue;
				case 7:
					num = (short)17105051;
					num2 = (int)((IntPtr)num);
					continue;
				case 8:
					goto IL_2C8D;
				case 9:
					goto IL_6D9;
				case 10:
					if (num3 <= 3432414671U)
					{
						num = (short)1711145219;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)183500920;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
					num = (short)2055799089;
					num2 = (int)((IntPtr)num);
					continue;
				case 12:
					if (num3 <= 3590791178U)
					{
						num = (short)1277755560;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2117665074;
					num2 = (int)((IntPtr)num);
					continue;
				case 13:
					if (num3 != 745265719U)
					{
						num = (short)382206251;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1880752227;
					num2 = (int)((IntPtr)num);
					continue;
				case 14:
					num = (short)1035993323;
					num2 = (int)((IntPtr)num);
					continue;
				case 15:
					num = (short)1660944686;
					num2 = (int)((IntPtr)num);
					continue;
				case 16:
				{
					num = (short)1355808768;
					short num4 = num;
					num = (short)447938774;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 17:
					goto IL_1E9C;
				case 18:
					num = (short)478150707;
					num2 = (int)((IntPtr)num);
					continue;
				case 19:
					num = (short)588382500;
					num2 = (int)((IntPtr)num);
					continue;
				case 20:
					num = (short)1244725327;
					num2 = (int)((IntPtr)num);
					continue;
				case 21:
					if (num3 <= 1971983983U)
					{
						num = (short)1280049205;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2140799257;
					num2 = (int)((IntPtr)num);
					continue;
				case 22:
					num = (short)1313472743;
					num2 = (int)((IntPtr)num);
					continue;
				case 23:
					if (num3 != 326409825U)
					{
						num = (short)1169948817;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)693960892;
					num2 = (int)((IntPtr)num);
					continue;
				case 24:
					num = (short)1837891868;
					num2 = (int)((IntPtr)num);
					continue;
				case 25:
					if (num3 != 3367594130U)
					{
						num = (short)1532493876;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1664090243;
					num2 = (int)((IntPtr)num);
					continue;
				case 26:
					if (num3 != 3174116218U)
					{
						num = (short)121045254;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1569980416;
					num2 = (int)((IntPtr)num);
					continue;
				case 27:
					num = (short)285540444;
					num2 = (int)((IntPtr)num);
					continue;
				case 28:
					if (num3 <= 2610146627U)
					{
						num = (short)1241972857;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)961282145;
					num2 = (int)((IntPtr)num);
					continue;
				case 29:
					switch (0)
					{
					case 0:
						goto IL_525;
					}
					continue;
				case 30:
					num = (short)1176764641;
					num2 = (int)((IntPtr)num);
					continue;
				case 31:
					num = (short)1546256632;
					num2 = (int)((IntPtr)num);
					continue;
				case 32:
					goto IL_1150;
				case 33:
					num = (short)1574764576;
					num2 = (int)((IntPtr)num);
					continue;
				case 34:
					goto IL_1A5D;
				case 35:
					goto IL_1D9B;
				case 36:
					num = (short)1394344153;
					num2 = (int)((IntPtr)num);
					continue;
				case 37:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰焲娴䌶䴸吺值紾㑀㝂ㅄ⡆❈祊ьⅎ㕐㙒ⵔŖじ㹚⩜㵞๠᭢㍤٦ըṪ࡬", a_)))
					{
						num = (short)208601207;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.BottomButton2Index_AnimationCompleted;
					num = (short)1428947178;
					num2 = (int)((IntPtr)num);
					continue;
				case 38:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ睄ๆ❈⽊⡌㝎ݐ㩒ご⁖㭘㑚╜फ़`རၤɦ", a_)))
					{
						num = (short)1991180516;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton2Index_AnimationCompleted;
					num = (short)658767939;
					num2 = (int)((IntPtr)num);
					continue;
				case 39:
					num = (short)35389679;
					num2 = (int)((IntPtr)num);
					continue;
				case 40:
					if (num3 != 3185023926U)
					{
						num = (short)1573781750;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1957363784;
					num2 = (int)((IntPtr)num);
					continue;
				case 41:
					if (num3 != 932203011U)
					{
						num = (short)416677986;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1277690050;
					num2 = (int)((IntPtr)num);
					continue;
				case 42:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ癄ņⱈ⩊㥌㩎⍐㙒͔㹖㱘ⱚ㽜ぞᥠ㕢Ѥ୦ᱨ๪", a_)))
					{
						num = (short)1255932124;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton3Feature_AnimationCompleted;
					num = (short)1749352580;
					num2 = (int)((IntPtr)num);
					continue;
				case 43:
					if (num3 != 2371847106U)
					{
						num = (short)1771045102;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2040201492;
					num2 = (int)((IntPtr)num);
					continue;
				case 44:
					num = (short)1237319781;
					num2 = (int)((IntPtr)num);
					continue;
				case 45:
					num = (short)1694695645;
					num2 = (int)((IntPtr)num);
					continue;
				case 46:
					goto IL_1C3C;
				case 47:
					goto IL_1A40;
				case 48:
					num = (short)1968570574;
					num2 = (int)((IntPtr)num);
					continue;
				case 49:
					goto IL_2B5B;
				case 50:
					num = (short)1535901912;
					num2 = (int)((IntPtr)num);
					continue;
				case 51:
					if (num3 != 1985212218U)
					{
						num = (short)862584910;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1015218369;
					num2 = (int)((IntPtr)num);
					continue;
				case 52:
					num = (short)491585777;
					num2 = (int)((IntPtr)num);
					continue;
				case 53:
					num = (short)729481310;
					num2 = (int)((IntPtr)num);
					continue;
				case 54:
					goto IL_2121;
				case 55:
					goto IL_2CAB;
				case 56:
					num = (short)1014497418;
					num2 = (int)((IntPtr)num);
					continue;
				case 57:
					goto IL_25E3;
				case 58:
					if (num3 != 3590791178U)
					{
						num = (short)770572556;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1167982886;
					num2 = (int)((IntPtr)num);
					continue;
				case 59:
					goto IL_1116;
				case 60:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰焲娴䌶䴸吺值紾㑀㝂ㅄ⡆❈罊ьⅎ㕐㙒ⵔŖじ㹚⩜㵞๠᭢㍤٦ըṪ࡬", a_)))
					{
						num = (short)1350631510;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.BottomButton4Index_AnimationCompleted;
					num = (short)1420951599;
					num2 = (int)((IntPtr)num);
					continue;
				case 61:
					num = (short)1462436109;
					num2 = (int)((IntPtr)num);
					continue;
				case 62:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ睄ᵆ♈╊⡌᥎㡐㙒≔㕖㙘⍚ଡ଼㹞ൠᙢd", a_)))
					{
						num = (short)122486829;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton2Zone_AnimationCompleted;
					num = (short)195625132;
					num2 = (int)((IntPtr)num);
					continue;
				case 63:
					goto IL_3009;
				case 64:
					goto IL_1059;
				case 65:
					if (num3 != 3329100824U)
					{
						num = (short)1360134163;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1866793130;
					num2 = (int)((IntPtr)num);
					continue;
				case 66:
					goto IL_311E;
				case 67:
					goto IL_2681;
				case 68:
					num = (short)888340712;
					num2 = (int)((IntPtr)num);
					continue;
				case 69:
					goto IL_1F05;
				case 70:
					num = (short)1054212303;
					num2 = (int)((IntPtr)num);
					continue;
				case 71:
					if (num3 <= 1170682229U)
					{
						num = (short)1389166845;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1831207072;
					num2 = (int)((IntPtr)num);
					continue;
				case 72:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ灄ๆ❈⽊⡌㝎ݐ㩒ご⁖㭘㑚╜फ़`རၤɦ", a_)))
					{
						num = (short)894173407;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton5Index_AnimationCompleted;
					num = (short)1971913013;
					num2 = (int)((IntPtr)num);
					continue;
				case 73:
					num = (short)1451491440;
					num2 = (int)((IntPtr)num);
					continue;
				case 74:
					num = (short)2053832797;
					num2 = (int)((IntPtr)num);
					continue;
				case 75:
					goto IL_1B42;
				case 76:
					if (num3 != 3060458544U)
					{
						num = (short)1781596230;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1869414715;
					num2 = (int)((IntPtr)num);
					continue;
				case 77:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰焲娴䌶䴸吺值紾㑀㝂ㅄ⡆❈穊ୌ⩎ぐ❒⁔╖㱘൚㑜㩞ᙠŢ੤ὦ㽨੪Ŭᩮᑰ", a_)))
					{
						num = (short)548012185;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.BottomButton1Feature_AnimationCompleted;
					num = (short)1582563374;
					num2 = (int)((IntPtr)num);
					continue;
				case 78:
					num = (short)634585349;
					num2 = (int)((IntPtr)num);
					continue;
				case 79:
					goto IL_2717;
				case 80:
					if (num3 != 1093295298U)
					{
						num = (short)485032123;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1163984938;
					num2 = (int)((IntPtr)num);
					continue;
				case 81:
					num = (short)1431765275;
					num2 = (int)((IntPtr)num);
					continue;
				case 82:
					goto IL_2577;
				case 83:
					num = (short)1665400881;
					num2 = (int)((IntPtr)num);
					continue;
				case 84:
					if (num3 <= 1310669812U)
					{
						num = (short)1801257179;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1735852053;
					num2 = (int)((IntPtr)num);
					continue;
				case 85:
					goto IL_1487;
				case 86:
					num = (short)585433201;
					num2 = (int)((IntPtr)num);
					continue;
				case 87:
					goto IL_1A12;
				case 88:
					num = (short)2001666103;
					num2 = (int)((IntPtr)num);
					continue;
				case 89:
					goto IL_1134;
				case 90:
					goto IL_2952;
				case 91:
					num = (short)1745551537;
					num2 = (int)((IntPtr)num);
					continue;
				case 92:
					goto IL_2EE2;
				case 93:
					if (num3 != 4167851202U)
					{
						num = (short)2097479716;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1185808541;
					num2 = (int)((IntPtr)num);
					continue;
				case 94:
					if (num3 <= 1757984584U)
					{
						num = (short)622002278;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1487798420;
					num2 = (int)((IntPtr)num);
					continue;
				case 95:
					num = (short)1358299212;
					num2 = (int)((IntPtr)num);
					continue;
				case 96:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰焲娴䌶䴸吺值紾㑀㝂ㅄ⡆❈硊ୌ⩎ぐ❒⁔╖㱘൚㑜㩞ᙠŢ੤ὦ㽨੪Ŭᩮᑰ", a_)))
					{
						num = (short)893321440;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.BottomButton3Feature_AnimationCompleted;
					num = (short)477036713;
					num2 = (int)((IntPtr)num);
					continue;
				case 97:
					if (num3 <= 3329100824U)
					{
						num = (short)1939210467;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)635633676;
					num2 = (int)((IntPtr)num);
					continue;
				case 98:
					num = (short)1629159487;
					num2 = (int)((IntPtr)num);
					continue;
				case 99:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ癄цⅈ⩊⍌ⅎ㑐㽒͔㹖㱘ⱚ㽜ぞᥠ㕢Ѥ୦ᱨ๪", a_)))
					{
						num = (short)521076862;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton3Channel_AnimationCompleted;
					num = (short)207159479;
					num2 = (int)((IntPtr)num);
					continue;
				case 100:
					goto IL_2A89;
				case 101:
					goto IL_1633;
				case 102:
					num = (short)1925972091;
					num2 = (int)((IntPtr)num);
					continue;
				case 103:
					num = (short)1944780905;
					num2 = (int)((IntPtr)num);
					continue;
				case 104:
					num = (short)761987248;
					num2 = (int)((IntPtr)num);
					continue;
				case 105:
					if (num3 != 2962054517U)
					{
						num = (short)1268711541;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)468189385;
					num2 = (int)((IntPtr)num);
					continue;
				case 106:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ癄ᵆ♈╊⡌᥎㡐㙒≔㕖㙘⍚ଡ଼㹞ൠᙢd", a_)))
					{
						num = (short)593690627;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton3Zone_AnimationCompleted;
					num = (short)1825243440;
					num2 = (int)((IntPtr)num);
					continue;
				case 107:
					goto IL_128C;
				case 108:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰挲䀴䔶䨸为吼䬾̀㙂ㅄ㍆♈╊罌َ㽐㝒ご⽖མ㉚㡜⡞͠ౢᵤㅦࡨݪᡬ੮", a_)))
					{
						num = (short)572784673;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.PursuitButton2Index_AnimationCompleted;
					num = (short)753991843;
					num2 = (int)((IntPtr)num);
					continue;
				case 109:
					num = (short)1640169639;
					num2 = (int)((IntPtr)num);
					continue;
				case 110:
					num = (short)423297026;
					num2 = (int)((IntPtr)num);
					continue;
				case 111:
					num = (short)560005256;
					num2 = (int)((IntPtr)num);
					continue;
				case 112:
					goto IL_1370;
				case 113:
					goto IL_11F5;
				case 114:
					num = (short)69075069;
					num2 = (int)((IntPtr)num);
					continue;
				case 115:
					num = (short)1627193491;
					num2 = (int)((IntPtr)num);
					continue;
				case 116:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ煄ๆ❈⽊⡌㝎ݐ㩒ご⁖㭘㑚╜फ़`རၤɦ", a_)))
					{
						num = (short)1776746687;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton4Index_AnimationCompleted;
					num = (short)598737038;
					num2 = (int)((IntPtr)num);
					continue;
				case 117:
					num = (short)992149647;
					num2 = (int)((IntPtr)num);
					continue;
				case 118:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰焲娴䌶䴸吺值紾㑀㝂ㅄ⡆❈繊ୌ⩎ぐ❒⁔╖㱘൚㑜㩞ᙠŢ੤ὦ㽨੪Ŭᩮᑰ", a_)))
					{
						num = (short)467009586;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.BottomButton5Feature_AnimationCompleted;
					num = (short)187498675;
					num2 = (int)((IntPtr)num);
					continue;
				case 119:
					num = (short)722796613;
					num2 = (int)((IntPtr)num);
					continue;
				case 120:
					if (num3 != 3448739866U)
					{
						num = (short)2003304684;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2069168205;
					num2 = (int)((IntPtr)num);
					continue;
				case 121:
					num = (short)2140078164;
					num2 = (int)((IntPtr)num);
					continue;
				case 122:
					if (num3 != 1147453100U)
					{
						num = (short)316801280;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)996212917;
					num2 = (int)((IntPtr)num);
					continue;
				case 123:
					if (num3 != 1709643054U)
					{
						num = (short)575602839;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1291845909;
					num2 = (int)((IntPtr)num);
					continue;
				case 124:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰挲䀴䔶䨸为吼䬾̀㙂ㅄ㍆♈╊籌َ㽐㝒ご⽖མ㉚㡜⡞͠ౢᵤㅦࡨݪᡬ੮", a_)))
					{
						num = (short)1737752596;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.PursuitButton1Index_AnimationCompleted;
					num = (short)672661579;
					num2 = (int)((IntPtr)num);
					continue;
				case 125:
					if (num3 <= 549778748U)
					{
						num = (short)837746817;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)161808558;
					num2 = (int)((IntPtr)num);
					continue;
				case 126:
					num = (short)680460446;
					num2 = (int)((IntPtr)num);
					continue;
				case 127:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰缲尴倶儸伺弼帾㍀ᝂ⩄㝆ࡈ⡊㥌♎㹐㵒͔㹖㱘ⱚ㽜ぞᥠ㕢Ѥ୦ᱨ๪䵬", a_)))
					{
						num = (short)1756561659;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LightbarTopFeature_AnimationCompleted;
					num = (short)1381105699;
					num2 = (int)((IntPtr)num);
					continue;
				case 128:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ煄цⅈ⩊⍌ⅎ㑐㽒͔㹖㱘ⱚ㽜ぞᥠ㕢Ѥ୦ᱨ๪", a_)))
					{
						num = (short)442892395;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton4Channel_AnimationCompleted;
					num = (short)1666646265;
					num2 = (int)((IntPtr)num);
					continue;
				case 129:
					num = (short)1922629655;
					num2 = (int)((IntPtr)num);
					continue;
				case 130:
					goto IL_2A6C;
				case 131:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰挲䀴䔶䨸为吼䬾̀㙂ㅄ㍆♈╊罌ॎ㑐㉒⅔≖⭘㹚ଡ଼㙞Ѡᑢݤࡦᅨ㵪౬ͮѰᙲ", a_)))
					{
						num = (short)1942945944;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.PursuitButton2Feature_AnimationCompleted;
					num = (short)192348299;
					num2 = (int)((IntPtr)num);
					continue;
				case 132:
					goto IL_7EA;
				case 133:
					goto IL_1240;
				case 134:
					if (num3 != 549778748U)
					{
						num = (short)742981659;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1751711750;
					num2 = (int)((IntPtr)num);
					continue;
				case 135:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ癄ๆ❈⽊⡌㝎ݐ㩒ご⁖㭘㑚╜फ़`རၤɦ", a_)))
					{
						num = (short)638124242;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton3Index_AnimationCompleted;
					num = (short)1558577169;
					num2 = (int)((IntPtr)num);
					continue;
				case 136:
					if (num3 != 3031846324U)
					{
						num = (short)1411579999;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1429930119;
					num2 = (int)((IntPtr)num);
					continue;
				case 137:
					if (num3 != 2883606084U)
					{
						num = (short)1330380903;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)911343724;
					num2 = (int)((IntPtr)num);
					continue;
				case 138:
					goto IL_10AF;
				case 139:
					goto IL_1F34;
				case 140:
					num = (short)991625281;
					num2 = (int)((IntPtr)num);
					continue;
				case 141:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰挲䀴䔶䨸为吼䬾̀㙂ㅄ㍆♈╊繌َ㽐㝒ご⽖མ㉚㡜⡞͠ౢᵤㅦࡨݪᡬ੮", a_)))
					{
						num = (short)55705616;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.PursuitButton3Index_AnimationCompleted;
					num = (short)1640628446;
					num2 = (int)((IntPtr)num);
					continue;
				case 142:
					goto IL_24CE;
				case 143:
					goto IL_27E9;
				case 144:
					if (num3 <= 3060458544U)
					{
						num = (short)471269398;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1422524701;
					num2 = (int)((IntPtr)num);
					continue;
				case 145:
					num = (short)2050883718;
					num2 = (int)((IntPtr)num);
					continue;
				case 146:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰焲娴䌶䴸吺值紾㑀㝂ㅄ⡆❈穊ьⅎ㕐㙒ⵔŖじ㹚⩜㵞๠᭢㍤٦ըṪ࡬", a_)))
					{
						num = (short)669909232;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.BottomButton1Index_AnimationCompleted;
					num = (short)1582498036;
					num2 = (int)((IntPtr)num);
					continue;
				case 147:
					goto IL_1A79;
				case 148:
					if (num3 != 1764207263U)
					{
						num = (short)272826478;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1193148679;
					num2 = (int)((IntPtr)num);
					continue;
				case 149:
					goto IL_2C71;
				case 150:
					num = (short)377290816;
					num2 = (int)((IntPtr)num);
					continue;
				case 151:
					num = (short)497221935;
					num2 = (int)((IntPtr)num);
					continue;
				case 152:
					num = (short)1242497303;
					num2 = (int)((IntPtr)num);
					continue;
				case 153:
					num = (short)1074856095;
					num2 = (int)((IntPtr)num);
					continue;
				case 154:
					if (num3 != 1971983983U)
					{
						num = (short)1669595347;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)821690594;
					num2 = (int)((IntPtr)num);
					continue;
				case 155:
					if (num3 != 3668371065U)
					{
						num = (short)1995636760;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)743899307;
					num2 = (int)((IntPtr)num);
					continue;
				case 156:
					if (num3 != 3176469887U)
					{
						num = (short)273154109;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)292683892;
					num2 = (int)((IntPtr)num);
					continue;
				case 157:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰焲娴䌶䴸吺值紾㑀㝂ㅄ⡆❈硊ьⅎ㕐㙒ⵔŖじ㹚⩜㵞๠᭢㍤٦ըṪ࡬", a_)))
					{
						num = (short)396886258;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1408040961;
					if (num != 0)
					{
					}
					doubleAnimation.Completed += this.BottomButton3Index_AnimationCompleted;
					num = (short)537329962;
					num2 = (int)((IntPtr)num);
					continue;
				case 158:
					goto IL_116C;
				case 159:
					goto IL_14A4;
				case 160:
					if (num3 != 1177573254U)
					{
						num = (short)868417833;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)467599487;
					num2 = (int)((IntPtr)num);
					continue;
				case 161:
					if (num3 != 2226598404U)
					{
						num = (short)1276575991;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)916652160;
					num2 = (int)((IntPtr)num);
					continue;
				case 162:
					goto IL_1FBF;
				case 163:
					goto IL_98E;
				case 164:
					num = (short)765788415;
					num2 = (int)((IntPtr)num);
					continue;
				case 165:
					num = (short)69730500;
					num2 = (int)((IntPtr)num);
					continue;
				case 166:
					goto IL_1FED;
				case 167:
					goto IL_9D9;
				case 168:
					num = (short)770244618;
					num2 = (int)((IntPtr)num);
					continue;
				case 169:
					goto IL_2103;
				case 170:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ灄ņⱈ⩊㥌㩎⍐㙒͔㹖㱘ⱚ㽜ぞᥠ㕢Ѥ୦ᱨ๪", a_)))
					{
						num = (short)1690173715;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton5Feature_AnimationCompleted;
					num = (short)770048282;
					num2 = (int)((IntPtr)num);
					continue;
				case 171:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ灄цⅈ⩊⍌ⅎ㑐㽒͔㹖㱘ⱚ㽜ぞᥠ㕢Ѥ୦ᱨ๪", a_)))
					{
						num = (short)2142830683;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton5Channel_AnimationCompleted;
					num = (short)734331151;
					num2 = (int)((IntPtr)num);
					continue;
				case 172:
					goto IL_9BD;
				case 173:
					num = (short)64487524;
					num2 = (int)((IntPtr)num);
					continue;
				case 174:
					if (num3 != 647830812U)
					{
						num = (short)1731330320;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1275396242;
					num2 = (int)((IntPtr)num);
					continue;
				case 175:
					goto IL_2613;
				case 176:
					goto IL_2189;
				case 177:
					goto IL_164F;
				case 178:
					goto IL_DC0;
				case 179:
					goto IL_2D56;
				case 180:
					num = (short)1380384905;
					num2 = (int)((IntPtr)num);
					continue;
				case 181:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ瑄ņⱈ⩊㥌㩎⍐㙒͔㹖㱘ⱚ㽜ぞᥠ㕢Ѥ୦ᱨ๪", a_)))
					{
						num = (short)1715142724;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton1Feature_AnimationCompleted;
					num = (short)1081868470;
					num2 = (int)((IntPtr)num);
					continue;
				case 182:
					goto IL_2D84;
				case 183:
					goto IL_61D;
				case 184:
					goto IL_3187;
				case 185:
					goto IL_29FD;
				case 186:
					goto IL_100D;
				case 187:
					num = (short)511901818;
					num2 = (int)((IntPtr)num);
					continue;
				case 188:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰焲娴䌶䴸吺值紾㑀㝂ㅄ⡆❈祊ୌ⩎ぐ❒⁔╖㱘൚㑜㩞ᙠŢ੤ὦ㽨੪Ŭᩮᑰ", a_)))
					{
						num = (short)380043581;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.BottomButton2Feature_AnimationCompleted;
					num = (short)1649213669;
					num2 = (int)((IntPtr)num);
					continue;
				case 189:
					num = (short)1310654554;
					num2 = (int)((IntPtr)num);
					continue;
				case 190:
					num = (short)1945108567;
					num2 = (int)((IntPtr)num);
					continue;
				case 191:
					num = (short)1009582288;
					num2 = (int)((IntPtr)num);
					continue;
				case 192:
					goto IL_12C4;
				case 193:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ瑄ᵆ♈╊⡌᥎㡐㙒≔㕖㙘⍚ଡ଼㹞ൠᙢd", a_)))
					{
						num = (short)948830420;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton1Zone_AnimationCompleted;
					num = (short)1820000529;
					num2 = (int)((IntPtr)num);
					continue;
				case 194:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰焲娴䌶䴸吺值紾㑀㝂ㅄ⡆❈罊ୌ⩎ぐ❒⁔╖㱘൚㑜㩞ᙠŢ੤ὦ㽨੪Ŭᩮᑰ", a_)))
					{
						num = (short)731775228;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.BottomButton4Feature_AnimationCompleted;
					num = (short)1698496642;
					num2 = (int)((IntPtr)num);
					continue;
				case 195:
					if (num3 != 3206859935U)
					{
						num = (short)507707532;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1042350391;
					num2 = (int)((IntPtr)num);
					continue;
				case 196:
					goto IL_1E52;
				case 197:
					goto IL_2D28;
				case 198:
					goto IL_2E6B;
				case 199:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰瘲場制䬸尺堼儾≀㩂݄㉆㵈㽊≌ⅎᝐ㙒㑔⍖ⱘ⥚㡜फ़ࡠ٢ቤզ٨፪㭬๮ᵰٲၴ", a_)))
					{
						num = (short)1158217759;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.EmergencyButtonFeature_AnimationCompleted;
					num = (short)2060648453;
					num2 = (int)((IntPtr)num);
					continue;
				case 200:
					goto IL_560;
				case 201:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ煄ᵆ♈╊⡌᥎㡐㙒≔㕖㙘⍚ଡ଼㹞ൠᙢd", a_)))
					{
						num = (short)781189208;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton4Zone_AnimationCompleted;
					num = (short)1140523286;
					num2 = (int)((IntPtr)num);
					continue;
				case 202:
					goto IL_3065;
				case 203:
					if (num3 <= 932203011U)
					{
						num = (short)235602034;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1488060487;
					num2 = (int)((IntPtr)num);
					continue;
				case 204:
					if (num3 != 1310669812U)
					{
						num = (short)2053374025;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)653852984;
					num2 = (int)((IntPtr)num);
					continue;
				case 205:
					goto IL_1224;
				case 206:
					goto IL_1CF4;
				case 207:
					goto IL_95F;
				case 208:
					goto IL_1F90;
				case 209:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ瑄цⅈ⩊⍌ⅎ㑐㽒͔㹖㱘ⱚ㽜ぞᥠ㕢Ѥ୦ᱨ๪", a_)))
					{
						num = (short)1243676836;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton1Channel_AnimationCompleted;
					num = (short)1722941642;
					num2 = (int)((IntPtr)num);
					continue;
				case 210:
					num = (short)1553334490;
					num2 = (int)((IntPtr)num);
					continue;
				case 211:
				{
					num = (short)309542766;
					short num5 = num;
					num = (short)741228398;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_128C;
					default:
						num = (short)1964965888;
						if (num != 0)
						{
						}
						num = (short)1949368379;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 212:
					num = (short)382402846;
					num2 = (int)((IntPtr)num);
					continue;
				case 213:
					if (num3 != 3001859194U)
					{
						num = (short)1441136751;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2017263917;
					num2 = (int)((IntPtr)num);
					continue;
				case 214:
					goto IL_12A8;
				case 215:
					num = (short)16777349;
					num2 = (int)((IntPtr)num);
					continue;
				case 216:
					goto IL_2E87;
				case 217:
					goto IL_D06;
				case 218:
					goto IL_1DB9;
				case 219:
					num = (short)564265163;
					num2 = (int)((IntPtr)num);
					continue;
				case 220:
					num = (short)2084634632;
					num2 = (int)((IntPtr)num);
					continue;
				case 221:
					goto IL_1D6D;
				case 222:
					goto IL_3037;
				case 223:
					num = (short)104333496;
					num2 = (int)((IntPtr)num);
					continue;
				case 224:
					num = (short)870973474;
					num2 = (int)((IntPtr)num);
					continue;
				case 225:
					goto IL_807;
				case 226:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰挲䀴䔶䨸为吼䬾̀㙂ㅄ㍆♈╊繌ॎ㑐㉒⅔≖⭘㹚ଡ଼㙞Ѡᑢݤࡦᅨ㵪౬ͮѰᙲ", a_)))
					{
						num = (short)371982606;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.PursuitButton3Feature_AnimationCompleted;
					num = (short)629342265;
					num2 = (int)((IntPtr)num);
					continue;
				case 227:
					num = (short)1123025040;
					num2 = (int)((IntPtr)num);
					continue;
				case 228:
					num = (short)850919506;
					num2 = (int)((IntPtr)num);
					continue;
				case 229:
					goto IL_20D4;
				case 230:
					goto IL_1093;
				case 231:
					if (num3 <= 2962054517U)
					{
						num = (short)104399028;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)92471509;
					num2 = (int)((IntPtr)num);
					continue;
				case 232:
					goto IL_1D11;
				case 233:
					goto IL_544;
				case 234:
					goto IL_103D;
				case 235:
					if (num3 != 3647057211U)
					{
						num = (short)175243271;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1350303781;
					num2 = (int)((IntPtr)num);
					continue;
				case 236:
					num = (short)1463353604;
					num2 = (int)((IntPtr)num);
					continue;
				case 237:
					num = (short)1375994060;
					num2 = (int)((IntPtr)num);
					continue;
				case 238:
					num = (short)1513619744;
					num2 = (int)((IntPtr)num);
					continue;
				case 239:
					if (num3 != 3167296484U)
					{
						num = (short)274268424;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1521877088;
					num2 = (int)((IntPtr)num);
					continue;
				case 240:
					num = (short)1502937398;
					num2 = (int)((IntPtr)num);
					continue;
				case 241:
					if (num3 != 3432414671U)
					{
						num = (short)1012662585;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1016070206;
					num2 = (int)((IntPtr)num);
					continue;
				case 242:
					num = (short)1806434591;
					num2 = (int)((IntPtr)num);
					continue;
				case 243:
					if (num3 != 3966815669U)
					{
						num = (short)508035087;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1787887617;
					num2 = (int)((IntPtr)num);
					continue;
				case 244:
					goto IL_D36;
				case 245:
					goto IL_28F6;
				case 246:
					num = (short)644284611;
					num2 = (int)((IntPtr)num);
					continue;
				case 247:
					num = (short)1140654388;
					num2 = (int)((IntPtr)num);
					continue;
				case 248:
					goto IL_1E6E;
				case 249:
					goto IL_AEC;
				case 250:
					goto IL_2AC2;
				case 251:
					num = (short)27656384;
					num2 = (int)((IntPtr)num);
					continue;
				case 252:
					num = (short)1828651208;
					num2 = (int)((IntPtr)num);
					continue;
				case 253:
					num = (short)185860176;
					num2 = (int)((IntPtr)num);
					continue;
				case 254:
					num = (short)1106379045;
					num2 = (int)((IntPtr)num);
					continue;
				case 255:
					goto IL_1189;
				case 256:
					num = (short)2006253842;
					num2 = (int)((IntPtr)num);
					continue;
				case 257:
					num = (short)1343291417;
					num2 = (int)((IntPtr)num);
					continue;
				case 258:
					num = (short)1108410529;
					num2 = (int)((IntPtr)num);
					continue;
				case 259:
					num = (short)1120403747;
					num2 = (int)((IntPtr)num);
					continue;
				case 260:
					if (num3 != 3456410005U)
					{
						num = (short)115015945;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1106247889;
					num2 = (int)((IntPtr)num);
					continue;
				case 261:
					if (num3 != 2168115414U)
					{
						num = (short)533790978;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)707395702;
					num2 = (int)((IntPtr)num);
					continue;
				case 262:
					num = (short)375980188;
					num2 = (int)((IntPtr)num);
					continue;
				case 263:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ睄ņⱈ⩊㥌㩎⍐㙒͔㹖㱘ⱚ㽜ぞᥠ㕢Ѥ୦ᱨ๪", a_)))
					{
						num = (short)79495251;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton2Feature_AnimationCompleted;
					num = (short)1223164070;
					num2 = (int)((IntPtr)num);
					continue;
				case 264:
					num = (short)31916058;
					num2 = (int)((IntPtr)num);
					continue;
				case 265:
					num = (short)620953658;
					num2 = (int)((IntPtr)num);
					continue;
				case 266:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰焲娴䌶䴸吺值紾㑀㝂ㅄ⡆❈繊ьⅎ㕐㙒ⵔŖじ㹚⩜㵞๠᭢㍤٦ըṪ࡬", a_)))
					{
						num = (short)447283256;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.BottomButton5Index_AnimationCompleted;
					num = (short)2062090437;
					num2 = (int)((IntPtr)num);
					continue;
				case 267:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰缲尴倶儸伺弼帾㍀ᅂⱄ⁆ⅈ㽊ьⅎ㕐㙒ⵔŖじ㹚⩜㵞๠᭢㍤٦ըṪ࡬", a_)))
					{
						num = (short)1022885969;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LightbarRightIndex_AnimationCompleted;
					num = (short)1592262665;
					num2 = (int)((IntPtr)num);
					continue;
				case 268:
					num = (short)932446262;
					num2 = (int)((IntPtr)num);
					continue;
				case 269:
					goto IL_B85;
				case 270:
					num = (short)1317863674;
					num2 = (int)((IntPtr)num);
					continue;
				case 271:
					goto IL_2817;
				case 272:
					num = (short)1486618637;
					num2 = (int)((IntPtr)num);
					continue;
				case 273:
					goto IL_2E4E;
				case 274:
					if (num3 != 1170682229U)
					{
						num = (short)1987182640;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1656619046;
					num2 = (int)((IntPtr)num);
					continue;
				case 275:
					num = (short)1958608985;
					num2 = (int)((IntPtr)num);
					continue;
				case 276:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ睄цⅈ⩊⍌ⅎ㑐㽒͔㹖㱘ⱚ㽜ぞᥠ㕢Ѥ୦ᱨ๪", a_)))
					{
						num = (short)1206911085;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton2Channel_AnimationCompleted;
					num = (short)1905918252;
					num2 = (int)((IntPtr)num);
					continue;
				case 277:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ灄ᵆ♈╊⡌᥎㡐㙒≔㕖㙘⍚ଡ଼㹞ൠᙢd", a_)))
					{
						num = (short)509345822;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton5Zone_AnimationCompleted;
					num = (short)65732612;
					num2 = (int)((IntPtr)num);
					continue;
				case 278:
					goto IL_1866;
				case 279:
					goto IL_A3F;
				case 280:
					if (num3 != 1301014169U)
					{
						num = (short)1156579565;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)716439841;
					num2 = (int)((IntPtr)num);
					continue;
				case 281:
					if (num3 <= 2226598404U)
					{
						num = (short)1011482642;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)665124907;
					num2 = (int)((IntPtr)num);
					continue;
				case 282:
					goto IL_2C14;
				case 283:
					goto IL_1077;
				case 284:
					if (num3 != 3680996761U)
					{
						num = (short)1914110247;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1818492988;
					num2 = (int)((IntPtr)num);
					continue;
				case 285:
					if (num3 <= 3176469887U)
					{
						num = (short)893452327;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1314914344;
					num2 = (int)((IntPtr)num);
					continue;
				case 286:
					goto IL_2AA6;
				case 287:
					goto IL_18CE;
				case 288:
					if (num3 != 2437686763U)
					{
						num = (short)1175847166;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)2037252295;
					num2 = (int)((IntPtr)num);
					continue;
				case 289:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰挲䀴䔶䨸为吼䬾̀㙂ㅄ㍆♈╊籌ॎ㑐㉒⅔≖⭘㹚ଡ଼㙞Ѡᑢݤࡦᅨ㵪౬ͮѰᙲ", a_)))
					{
						num = (short)1296957736;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.PursuitButton1Feature_AnimationCompleted;
					num = (short)1803157794;
					num2 = (int)((IntPtr)num);
					continue;
				case 290:
					goto IL_22D4;
				case 291:
					if (num3 != 3363432645U)
					{
						num = (short)1832124673;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)359137421;
					num2 = (int)((IntPtr)num);
					continue;
				case 292:
					goto IL_2058;
				case 293:
					if (num3 != 2610146627U)
					{
						num = (short)209780886;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1467875452;
					num2 = (int)((IntPtr)num);
					continue;
				case 294:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰挲䀴䔶䨸为吼䬾̀㙂ㅄ㍆♈╊経َ㽐㝒ご⽖མ㉚㡜⡞͠ౢᵤㅦࡨݪᡬ੮", a_)))
					{
						num = (short)1245118508;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.PursuitButton0Index_AnimationCompleted;
					num = (short)1929183394;
					num2 = (int)((IntPtr)num);
					continue;
				case 295:
					num = (short)1862467814;
					num2 = (int)((IntPtr)num);
					continue;
				case 296:
					num = (short)812319036;
					num2 = (int)((IntPtr)num);
					continue;
				case 297:
					num = (short)2101543192;
					num2 = (int)((IntPtr)num);
					continue;
				case 298:
					goto IL_7BC;
				case 299:
					num = (short)880345129;
					num2 = (int)((IntPtr)num);
					continue;
				case 300:
					goto IL_2886;
				case 301:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰朲娴䜶笸为䤼䬾⹀ⵂ瑄ๆ❈⽊⡌㝎ݐ㩒ご⁖㭘㑚╜फ़`རၤɦ", a_)))
					{
						num = (short)1017839831;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.TopButton1Index_AnimationCompleted;
					num = (short)1983381690;
					num2 = (int)((IntPtr)num);
					continue;
				case 302:
					if (num3 != 4130057657U)
					{
						num = (short)1119486026;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)624689419;
					num2 = (int)((IntPtr)num);
					continue;
				case 303:
					if (num3 != 1757984584U)
					{
						num = (short)380764325;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1753874538;
					num2 = (int)((IntPtr)num);
					continue;
				case 304:
					goto IL_1794;
				case 305:
					goto IL_FDF;
				case 306:
					if (num3 <= 3680996761U)
					{
						num = (short)1330118670;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1309081843;
					num2 = (int)((IntPtr)num);
					continue;
				case 307:
					goto IL_213F;
				case 308:
					goto IL_D52;
				case 309:
					goto IL_29CD;
				case 310:
					goto IL_27CD;
				case 311:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰缲尴倶儸伺弼帾㍀ᅂⱄ⁆ⅈ㽊ౌⱎ═㩒㩔㥖མ㉚㡜⡞͠ౢᵤㅦࡨݪᡬ੮", a_)))
					{
						num = (short)1208090728;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LightbarRightFeature_AnimationCompleted;
					num = (short)2059403449;
					num2 = (int)((IntPtr)num);
					continue;
				case 312:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰缲尴倶儸伺弼帾㍀ག⁄ⅆ㵈Ɋ⍌⭎㑐⭒͔㹖㱘ⱚ㽜ぞᥠ㕢Ѥ୦ᱨ๪", a_)))
					{
						num = (short)40304813;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LightbarLeftIndex_AnimationCompleted;
					num = (short)624754866;
					num2 = (int)((IntPtr)num);
					continue;
				case 313:
					num = (short)466485446;
					num2 = (int)((IntPtr)num);
					continue;
				case 314:
					num = (short)1628307610;
					num2 = (int)((IntPtr)num);
					continue;
				case 315:
					if (!(name == O9GraphicviewMenuItemsVisibilityConverter.b("愬䴮崰缲尴倶儸伺弼帾㍀ག⁄ⅆ㵈੊⹌㭎㡐㱒㭔Ŗじ㹚⩜㵞๠᭢㍤٦ըṪ࡬", a_)))
					{
						num = (short)233046205;
						num2 = (int)((IntPtr)num);
						continue;
					}
					doubleAnimation.Completed += this.LightbarLeftFeature_AnimationCompleted;
					num = (short)1098776821;
					num2 = (int)((IntPtr)num);
					continue;
				case 316:
					goto IL_17FA;
				case 317:
					num = (short)1094778965;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_525:
				if (isAnimating)
				{
					num = (short)2000683241;
					num2 = (int)((IntPtr)num);
					continue;
				}
				isAnimating = true;
				doubleAnimation = new DoubleAnimation();
				doubleAnimation.From = new double?(0.0);
				doubleAnimation.To = new double?(0.0 - label.ActualWidth);
				doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(label.ActualWidth / 45.0));
				doubleAnimation.FillBehavior = FillBehavior.Stop;
				translateTransform.BeginAnimation(TranslateTransform.XProperty, doubleAnimation);
				name = label.Name;
				num3 = <PrivateImplementationDetails>.ComputeStringHash(name);
				num = (short)1423769628;
				num2 = (int)((IntPtr)num);
				continue;
				IL_128C:
				num = (short)941621397;
				num2 = (int)((IntPtr)num);
			}
			IL_544:
			translateTransform.BeginAnimation(TranslateTransform.XProperty, null);
			isAnimating = false;
			return;
			IL_560:
			IL_61D:
			IL_6D9:
			IL_7BC:
			IL_7EA:
			IL_807:
			IL_95F:
			IL_98E:
			IL_9BD:
			IL_9D9:
			IL_A3F:
			IL_AEC:
			IL_B85:
			IL_D06:
			IL_D36:
			IL_D52:
			IL_DC0:
			IL_FC3:
			IL_FDF:
			IL_100D:
			IL_103D:
			IL_1059:
			IL_1077:
			IL_1093:
			IL_10AF:
			IL_1116:
			IL_1134:
			IL_1150:
			IL_116C:
			IL_1189:
			IL_11F5:
			IL_1224:
			IL_1240:
			IL_12A8:
			IL_12C4:
			IL_1370:
			IL_1487:
			IL_14A4:
			IL_1633:
			IL_164F:
			IL_1794:
			IL_17FA:
			IL_1866:
			IL_18CE:
			IL_1A12:
			IL_1A40:
			IL_1A5D:
			IL_1A79:
			IL_1B42:
			IL_1C3C:
			IL_1CF4:
			IL_1D11:
			IL_1D6D:
			IL_1D9B:
			IL_1DB9:
			IL_1E52:
			IL_1E6E:
			IL_1E9C:
			IL_1F05:
			IL_1F34:
			IL_1F90:
			IL_1FBF:
			IL_1FED:
			IL_2058:
			IL_20D4:
			IL_2103:
			IL_2121:
			IL_213F:
			IL_216D:
			IL_2189:
			IL_22D4:
			IL_24CE:
			IL_2577:
			IL_25E3:
			IL_2613:
			IL_2681:
			IL_2717:
			IL_27CD:
			IL_27E9:
			IL_2817:
			IL_2886:
			IL_28F6:
			IL_2952:
			IL_29CD:
			IL_29FD:
			IL_2A6C:
			IL_2A89:
			IL_2AA6:
			IL_2AC2:
			IL_2B5B:
			IL_2C14:
			IL_2C71:
			IL_2C8D:
			IL_2CAB:
			IL_2D28:
			IL_2D56:
			IL_2D84:
			IL_2E4E:
			IL_2E6B:
			IL_2E87:
			IL_2EE2:
			IL_3009:
			IL_3037:
			IL_3065:
			IL_311E:
			IL_3187:
			translateTransform.BeginAnimation(TranslateTransform.XProperty, doubleAnimation);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00083B98 File Offset: 0x00081D98
		private void PursuitButton0Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)814310715;
			short num2 = num;
			num = (short)1171809595;
			switch (num2 == num)
			{
			}
			num = (short)383188993;
			if (num != 0)
			{
			}
			num = (short)1296498688;
			if (num != 0)
			{
			}
			num = (short)2115436544;
			short num3 = num;
			this.isPursuitButton0IndexAnimating = false;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00083C48 File Offset: 0x00081E48
		private void ScrollingPursuitButton0IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1321907015;
			short num2 = num;
			num = (short)780841799;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AF:
				switch (0)
				{
				case 0:
					goto IL_CB;
				}
				break;
			default:
			{
				num = (short)1732116480;
				short num3 = num;
				num = (short)428408832;
				if (num != 0)
				{
				}
				num = (short)73662465;
				if (num != 0)
				{
				}
				num = (short)1452736512;
				num4 = (int)((IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				IL_B9:
				switch (num4)
				{
				case 0:
					goto IL_AF;
				case 1:
					goto IL_129;
				case 2:
					this.StartScrollingAcpLabel(this.LblPursuitButton0IndexViewboxValue, this.PursuitButton0IndexCanvas, ref this.isPursuitButton0IndexAnimating, this.RenderTransformPursuitButton0IndexViewbox);
					num = (short)1056505857;
					num4 = (int)((IntPtr)num);
					continue;
				}
				goto IL_CB;
			}
			IL_129:
			return;
			IL_CB:
			if ((sender as AcpLabel).ActualWidth > 112.06)
			{
				num = (short)94568450;
				num4 = (int)((IntPtr)num);
				goto IL_B9;
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00083D80 File Offset: 0x00081F80
		private void MouseEnterPursuitButtonIndexLabel(object sender, MouseEventArgs e)
		{
			short num;
			AcpLabel acpLabel;
			for (;;)
			{
				num = (short)1642725376;
				short num2 = num;
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= 112.06)
				{
					goto IL_9A;
				}
				num = (short)265885413;
				short num3 = num;
				num = (short)1414797029;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_77;
				}
			}
			IL_77:
			num = (short)1538719744;
			if (num != 0)
			{
			}
			acpLabel.Cursor = Cursors.Hand;
			return;
			IL_9A:
			num = (short)81854465;
			if (num != 0)
			{
			}
			acpLabel.Cursor = Cursors.Arrow;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00083E5C File Offset: 0x0008205C
		private void PursuitButtonIndexLabelChanged(object sender, SizeChangedEventArgs e)
		{
			short num;
			AcpLabel acpLabel;
			for (;;)
			{
				num = (short)1974992896;
				short num2 = num;
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth >= 100.06)
				{
					goto IL_C7;
				}
				num = (short)300711542;
				short num3 = num;
				num = (short)1046052470;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7A;
				}
			}
			IL_7A:
			num = (short)2100822017;
			if (num != 0)
			{
			}
			num = (short)70647808;
			if (num != 0)
			{
			}
			Canvas.SetLeft(acpLabel, 10.0);
			return;
			IL_C7:
			Canvas.SetLeft(acpLabel, -4.0);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00083F40 File Offset: 0x00082140
		private void PursuitButton1Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1264723785;
			short num2 = num;
			num = (short)1290872649;
			switch (num2 == num)
			{
			}
			num = (short)403570689;
			if (num != 0)
			{
			}
			num = (short)128516096;
			if (num != 0)
			{
			}
			num = (short)1116340224;
			short num3 = num;
			this.isPursuitButton1IndexAnimating = false;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00083FEC File Offset: 0x000821EC
		private void ScrollingPursuitButton1IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)614814475;
			short num2 = num;
			num = (short)1817203467;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_89:
				switch (0)
				{
				case 0:
					goto IL_CB;
				}
				break;
			default:
			{
				num = (short)1132920832;
				short num3 = num;
				num = (short)1690697728;
				if (num != 0)
				{
				}
				num = (short)1555496960;
				num4 = (int)((IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				IL_93:
				num = (short)1880162305;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					goto IL_89;
				case 1:
					goto IL_12D;
				case 2:
					this.StartScrollingAcpLabel(this.LblPursuitButton1IndexViewboxValue, this.PursuitButton1IndexCanvas, ref this.isPursuitButton1IndexAnimating, this.RenderTransformPursuitButton1IndexViewbox);
					num = (short)1670774785;
					num4 = (int)((IntPtr)num);
					continue;
				}
				goto IL_CB;
			}
			IL_12D:
			return;
			IL_CB:
			if ((sender as AcpLabel).ActualWidth > 112.06)
			{
				num = (short)1891500034;
				num4 = (int)((IntPtr)num);
				goto IL_93;
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00084128 File Offset: 0x00082328
		private void PursuitButton2Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)2093526461;
			short num2 = num;
			num = (short)1865264573;
			switch (num2 == num)
			{
			}
			num = (short)1592262657;
			if (num != 0)
			{
			}
			num = (short)68222976;
			if (num != 0)
			{
			}
			num = (short)2142175232;
			short num3 = num;
			this.isPursuitButton2IndexAnimating = false;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000841D8 File Offset: 0x000823D8
		private void ScrollingPursuitButton2IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1207772749;
			short num2 = num;
			num = (short)1581131341;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_86:
				num = (short)1738145793;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_C9;
				}
				break;
			default:
			{
				num = (short)1034944512;
				short num3 = num;
				num = (short)2001797120;
				if (num != 0)
				{
				}
				num = (short)777650176;
				num4 = (int)((IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				IL_B7:
				switch (num4)
				{
				case 0:
					goto IL_86;
				case 1:
					goto IL_129;
				case 2:
					this.StartScrollingAcpLabel(this.LblPursuitButton2IndexViewboxValue, this.PursuitButton2IndexCanvas, ref this.isPursuitButton2IndexAnimating, this.RenderTransformPursuitButton2IndexViewbox);
					num = (short)401735681;
					num4 = (int)((IntPtr)num);
					continue;
				}
				goto IL_C9;
			}
			IL_129:
			return;
			IL_C9:
			if ((sender as AcpLabel).ActualWidth > 112.06)
			{
				num = (short)433848322;
				num4 = (int)((IntPtr)num);
				goto IL_B7;
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00084310 File Offset: 0x00082510
		private void PursuitButton3Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1985740801;
			if (num != 0)
			{
			}
			num = (short)1363710594;
			short num2 = num;
			num = (short)1762693762;
			switch (num2 == num)
			{
			}
			num = (short)1819672576;
			if (num != 0)
			{
			}
			num = (short)1001783296;
			short num3 = num;
			this.isPursuitButton3IndexAnimating = false;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x000843C0 File Offset: 0x000825C0
		private void ScrollingPursuitButton3IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1641692503;
			short num2 = num;
			num = (short)1508719959;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B0:
				switch (0)
				{
				case 0:
					goto IL_CC;
				}
				break;
			default:
			{
				num = (short)1613955072;
				short num3 = num;
				num = (short)1490288640;
				if (num != 0)
				{
				}
				num = (short)264962049;
				if (num != 0)
				{
				}
				num = (short)1995309056;
				num4 = (int)((IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				IL_BA:
				switch (num4)
				{
				case 0:
					goto IL_B0;
				case 1:
					goto IL_12B;
				case 2:
					this.StartScrollingAcpLabel(this.LblPursuitButton3IndexViewboxValue, this.PursuitButton3IndexCanvas, ref this.isPursuitButton3IndexAnimating, this.RenderTransformPursuitButton3IndexViewbox);
					num = (short)376897537;
					num4 = (int)((IntPtr)num);
					continue;
				}
				goto IL_CC;
			}
			IL_12B:
			return;
			IL_CC:
			if ((sender as AcpLabel).ActualWidth > 112.06)
			{
				num = (short)735051778;
				num4 = (int)((IntPtr)num);
				goto IL_BA;
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000844FC File Offset: 0x000826FC
		private void PursuitButton0Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1557223350;
			short num2 = num;
			num = (short)1260869558;
			switch (num2 == num)
			{
			}
			num = (short)1187840001;
			if (num != 0)
			{
			}
			num = (short)1822425088;
			if (num != 0)
			{
			}
			num = (short)1615593472;
			short num3 = num;
			this.isPursuitButton0FeatureAnimating = false;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000845AC File Offset: 0x000827AC
		private void ScrollingPursuitButton0FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)800849921;
			if (num != 0)
			{
			}
			num = (short)1584866618;
			short num2 = num;
			num = (short)1256334650;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B1:
				switch (0)
				{
				case 0:
					goto IL_CD;
				}
				break;
			case 1:
				goto IL_88;
			default:
			{
				num = (short)1914109952;
				short num3 = num;
				goto IL_88;
			}
			}
			int num4;
			for (;;)
			{
				IL_BB:
				switch (num4)
				{
				case 0:
					goto IL_B1;
				case 1:
					goto IL_12C;
				case 2:
					this.StartScrollingAcpLabel(this.LblPursuitButton0FeatureViewboxValue, this.PursuitButton0FeatureCanvas, ref this.isPursuitButton0FeatureAnimating, this.RenderTransformPursuitButton0FeatureViewbox);
					num = (short)810680321;
					num4 = (int)((IntPtr)num);
					continue;
				}
				goto IL_CD;
			}
			IL_12C:
			return;
			IL_88:
			num = (short)2113208320;
			if (num != 0)
			{
			}
			num = (short)1313931264;
			num4 = (int)((IntPtr)num);
			goto IL_BB;
			IL_CD:
			if ((sender as AcpLabel).ActualWidth > 130.06)
			{
				num = (short)714145794;
				num4 = (int)((IntPtr)num);
				goto IL_BB;
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000846E8 File Offset: 0x000828E8
		private void MouseEnterPursuitButtonFeatureLabel(object sender, MouseEventArgs e)
		{
			short num;
			AcpLabel acpLabel;
			for (;;)
			{
				num = (short)345112576;
				short num2 = num;
				num = (short)914161665;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= 130.06)
				{
					goto IL_C4;
				}
				num = (short)1333148684;
				short num3 = num;
				num = (short)1299201036;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_9F;
				}
			}
			IL_9F:
			num = (short)422576128;
			if (num != 0)
			{
			}
			acpLabel.Cursor = Cursors.Hand;
			return;
			IL_C4:
			acpLabel.Cursor = Cursors.Arrow;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000847C4 File Offset: 0x000829C4
		private void PursuitButtonFeatureLabelChanged(object sender, SizeChangedEventArgs e)
		{
			short num;
			AcpLabel acpLabel;
			for (;;)
			{
				num = (short)30539776;
				short num2 = num;
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth >= 120.06)
				{
					goto IL_CB;
				}
				num = (short)1991042181;
				short num3 = num;
				num = (short)51963013;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7B;
				}
			}
			IL_7B:
			num = (short)15138817;
			if (num != 0)
			{
			}
			num = (short)1340342272;
			if (num != 0)
			{
			}
			Canvas.SetLeft(acpLabel, 10.0);
			return;
			IL_CB:
			Canvas.SetLeft(acpLabel, 0.0);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000848AC File Offset: 0x00082AAC
		private void PursuitButton1Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)542128697;
			short num2 = num;
			num = (short)1767520825;
			switch (num2 == num)
			{
			}
			num = (short)1897594880;
			if (num != 0)
			{
			}
			num = (short)1706622977;
			if (num != 0)
			{
			}
			num = (short)926744576;
			short num3 = num;
			this.isPursuitButton1FeatureAnimating = false;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0008495C File Offset: 0x00082B5C
		private void ScrollingPursuitButton1FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1032566078;
			short num2 = num;
			num = (short)834712894;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B0:
				switch (0)
				{
				case 0:
					goto IL_CC;
				}
				break;
			default:
			{
				num = (short)1412169728;
				short num3 = num;
				num = (short)499122177;
				if (num != 0)
				{
				}
				num = (short)2137718784;
				if (num != 0)
				{
				}
				num = (short)1660747776;
				num4 = (int)((IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				IL_BA:
				switch (num4)
				{
				case 0:
					goto IL_B0;
				case 1:
					goto IL_12C;
				case 2:
					this.StartScrollingAcpLabel(this.LblPursuitButton1FeatureViewboxValue, this.PursuitButton1FeatureCanvas, ref this.isPursuitButton1FeatureAnimating, this.RenderTransformPursuitButton1FeatureViewbox);
					num = (short)1949630465;
					num4 = (int)((IntPtr)num);
					continue;
				}
				goto IL_CC;
			}
			IL_12C:
			return;
			IL_CC:
			if ((sender as AcpLabel).ActualWidth > 130.06)
			{
				num = (short)2134114306;
				num4 = (int)((IntPtr)num);
				goto IL_BA;
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00084A98 File Offset: 0x00082C98
		private void PursuitButton2Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)461780910;
			short num2 = num;
			num = (short)537606062;
			switch (num2 == num)
			{
			}
			num = (short)1429536769;
			if (num != 0)
			{
			}
			num = (short)210436096;
			if (num != 0)
			{
			}
			num = (short)1651441664;
			short num3 = num;
			this.isPursuitButton2FeatureAnimating = false;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00084B4C File Offset: 0x00082D4C
		private void ScrollingPursuitButton2FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1385292944;
			short num2 = num;
			num = (short)1537467536;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_8A:
				switch (0)
				{
				case 0:
					goto IL_A6;
				}
				break;
			default:
			{
				num = (short)1700331520;
				short num3 = num;
				num = (short)707854336;
				if (num != 0)
				{
				}
				num = (short)891879424;
				num4 = (int)((IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				IL_94:
				switch (num4)
				{
				case 0:
					goto IL_8A;
				case 1:
					goto IL_106;
				case 2:
					this.StartScrollingAcpLabel(this.LblPursuitButton2FeatureViewboxValue, this.PursuitButton2FeatureCanvas, ref this.isPursuitButton2FeatureAnimating, this.RenderTransformPursuitButton2FeatureViewbox);
					num = (short)1534328833;
					num4 = (int)((IntPtr)num);
					continue;
				}
				goto IL_A6;
			}
			IL_106:
			num = (short)243466241;
			if (num != 0)
			{
			}
			return;
			IL_A6:
			if ((sender as AcpLabel).ActualWidth > 130.06)
			{
				num = (short)854851586;
				num4 = (int)((IntPtr)num);
				goto IL_94;
			}
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00084C8C File Offset: 0x00082E8C
		private void PursuitButton3Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)649763260;
			short num2 = num;
			num = (short)441751996;
			switch (num2 == num)
			{
			}
			num = (short)1325334529;
			if (num != 0)
			{
			}
			num = (short)615448576;
			if (num != 0)
			{
			}
			num = (short)1319895040;
			short num3 = num;
			this.isPursuitButton3FeatureAnimating = false;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00084D40 File Offset: 0x00082F40
		private void ScrollingPursuitButton3FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1295810044;
			short num2 = num;
			num = (short)295075324;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_89:
				switch (0)
				{
				case 0:
					goto IL_A5;
				}
				break;
			default:
			{
				num = (short)1741881344;
				short num3 = num;
				num = (short)1558970368;
				if (num != 0)
				{
				}
				num = (short)66912256;
				num4 = (int)((IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				IL_93:
				switch (num4)
				{
				case 0:
					goto IL_89;
				case 1:
					goto IL_105;
				case 2:
					this.StartScrollingAcpLabel(this.LblPursuitButton3FeatureViewboxValue, this.PursuitButton3FeatureCanvas, ref this.isPursuitButton3FeatureAnimating, this.RenderTransformPursuitButton3FeatureViewbox);
					num = (short)858390529;
					num4 = (int)((IntPtr)num);
					continue;
				}
				goto IL_A5;
			}
			IL_105:
			num = (short)1288765441;
			if (num != 0)
			{
			}
			return;
			IL_A5:
			if ((sender as AcpLabel).ActualWidth > 130.06)
			{
				num = (short)1944715266;
				num4 = (int)((IntPtr)num);
				goto IL_93;
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00084E7C File Offset: 0x0008307C
		private void EmergencyButtonFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)386072576;
			short num2 = num;
			num = (short)459650943;
			short num3 = num;
			num = (short)2128066431;
			switch (num3 == num)
			{
			}
			num = (short)39124992;
			if (num != 0)
			{
			}
			num = (short)1248591873;
			if (num != 0)
			{
			}
			this.isEmergencyButtonFeatureAnimating = false;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00084F30 File Offset: 0x00083130
		private void ScrollingEmergencyButtonFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)290507573;
			short num2 = num;
			num = (short)1588644661;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B2:
				switch (0)
				{
				case 0:
					goto IL_CE;
				}
				break;
			case 1:
				goto IL_61;
			default:
			{
				num = (short)1565917184;
				short num3 = num;
				goto IL_61;
			}
			}
			int num4;
			for (;;)
			{
				IL_BC:
				switch (num4)
				{
				case 0:
					this.StartScrollingAcpLabel(this.LblEmergencyButtonFeatureViewboxValue, this.EmergencyButtonFeatureCanvas, ref this.isEmergencyButtonFeatureAnimating, this.RenderTransforEmmergencyButtonFeatureViewbox);
					num = (short)1424687106;
					num4 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_B2;
				case 2:
					goto IL_12C;
				}
				goto IL_CE;
			}
			IL_12C:
			return;
			IL_61:
			num = (short)465436673;
			if (num != 0)
			{
			}
			num = (short)965804032;
			if (num != 0)
			{
			}
			num = (short)1298333697;
			num4 = (int)((IntPtr)num);
			goto IL_BC;
			IL_CE:
			if ((sender as AcpLabel).ActualWidth > 65.0)
			{
				num = (short)723845120;
				num4 = (int)((IntPtr)num);
				goto IL_BC;
			}
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0008506C File Offset: 0x0008326C
		private void MouseEnterEmergencyButtonFeatureLabel(object sender, MouseEventArgs e)
		{
			short num = (short)1212940288;
			short num2 = num;
			num = (short)446490195;
			short num3 = num;
			num = (short)1167582803;
			AcpLabel acpLabel;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)816775169;
				if (num != 0)
				{
				}
				num = (short)1256849408;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= 65.0)
				{
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
				break;
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00085144 File Offset: 0x00083344
		private void EmergencyButtonFeatureLabelChanged(object sender, SizeChangedEventArgs e)
		{
			short num = (short)1464270848;
			short num2 = num;
			num = (short)77172586;
			short num3 = num;
			num = (short)304516970;
			AcpLabel acpLabel;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1797652481;
				if (num != 0)
				{
				}
				num = (short)156303360;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth >= 50.0)
				{
					Canvas.SetLeft(acpLabel, 0.0);
					return;
				}
				break;
			}
			Canvas.SetLeft(acpLabel, 10.0);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0008522C File Offset: 0x0008342C
		private void MouseEnterBottomButtonIndexLabel(object sender, MouseEventArgs e)
		{
			short num = (short)15007744;
			short num2 = num;
			num = (short)415708785;
			short num3 = num;
			num = (short)1034040945;
			AcpLabel acpLabel;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1762394113;
				if (num != 0)
				{
				}
				num = (short)1592721408;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= 112.06)
				{
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
				break;
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00085304 File Offset: 0x00083504
		private void BottomButtonIndexLabelChanged(object sender, SizeChangedEventArgs e)
		{
			short num = (short)1578762240;
			short num2 = num;
			num = (short)1831626982;
			short num3 = num;
			num = (short)1864329446;
			AcpLabel acpLabel;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)865271808;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth >= 100.06)
				{
					Canvas.SetLeft(acpLabel, -4.0);
					return;
				}
				num = (short)580124673;
				if (num != 0)
				{
				}
				break;
			}
			Canvas.SetLeft(acpLabel, 10.0);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000853E8 File Offset: 0x000835E8
		private void BottomButton1Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)975044608;
			short num2 = num;
			num = (short)1949320466;
			short num3 = num;
			num = (short)767444242;
			switch (num3 == num)
			{
			}
			num = (short)936050689;
			if (num != 0)
			{
			}
			num = (short)200474624;
			if (num != 0)
			{
			}
			this.isBottomButton1IndexAnimating = false;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0008549C File Offset: 0x0008369C
		private void ScrollingBottomButton1IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1423471279;
			short num2 = num;
			num = (short)969765551;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_86:
				switch (0)
				{
				case 0:
					goto IL_A2;
				}
				break;
			case 1:
				goto IL_5D;
			default:
			{
				num = (short)527826944;
				short num3 = num;
				goto IL_5D;
			}
			}
			int num4;
			for (;;)
			{
				IL_90:
				switch (num4)
				{
				case 0:
					this.StartScrollingAcpLabel(this.LblBottomButton1IndexViewboxValue, this.BottomButton1IndexCanvas, ref this.isBottomButton1IndexAnimating, this.RenderTransformBottomButton1IndexViewbox);
					num = (short)579469314;
					num4 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_86;
				case 2:
					goto IL_100;
				}
				goto IL_A2;
			}
			IL_100:
			num = (short)147062785;
			if (num != 0)
			{
			}
			return;
			IL_5D:
			num = (short)1279393792;
			if (num != 0)
			{
			}
			num = (short)802422785;
			num4 = (int)((IntPtr)num);
			goto IL_90;
			IL_A2:
			if ((sender as AcpLabel).ActualWidth > 112.06)
			{
				num = (short)751894528;
				num4 = (int)((IntPtr)num);
				goto IL_90;
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x000855D4 File Offset: 0x000837D4
		private void BottomButton2Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)811794432;
			short num2 = num;
			num = (short)1559589433;
			short num3 = num;
			num = (short)1066234425;
			switch (num3 == num)
			{
			}
			num = (short)1967849473;
			if (num != 0)
			{
			}
			num = (short)1348206592;
			if (num != 0)
			{
			}
			this.isBottomButton2IndexAnimating = false;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00085684 File Offset: 0x00083884
		private void ScrollingBottomButton2IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)743875283;
			short num2 = num;
			num = (short)1182507731;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_89:
				num = (short)1663172609;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_CC;
				}
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)437977088;
				short num3 = num;
				goto IL_5F;
			}
			}
			int num4;
			for (;;)
			{
				IL_BA:
				switch (num4)
				{
				case 0:
					this.StartScrollingAcpLabel(this.LblBottomButton2IndexViewboxValue, this.BottomButton2IndexCanvas, ref this.isBottomButton2IndexAnimating, this.RenderTransformBottomButton2IndexViewbox);
					num = (short)1627848706;
					num4 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_89;
				case 2:
					goto IL_12B;
				}
				goto IL_CC;
			}
			IL_12B:
			return;
			IL_5F:
			num = (short)2066022400;
			if (num != 0)
			{
			}
			num = (short)592183297;
			num4 = (int)((IntPtr)num);
			goto IL_BA;
			IL_CC:
			if ((sender as AcpLabel).ActualWidth > 112.06)
			{
				num = (short)242876416;
				num4 = (int)((IntPtr)num);
				goto IL_BA;
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000857C0 File Offset: 0x000839C0
		private void BottomButton3Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1352990720;
			short num2 = num;
			num = (short)1659531935;
			short num3 = num;
			num = (short)1796567711;
			switch (num3 == num)
			{
			}
			num = (short)1727332353;
			if (num != 0)
			{
			}
			num = (short)1297350656;
			if (num != 0)
			{
			}
			this.isBottomButton3IndexAnimating = false;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00085870 File Offset: 0x00083A70
		private void ScrollingBottomButton3IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)764472089;
			short num2 = num;
			num = (short)2032003865;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B1:
				switch (0)
				{
				case 0:
					goto IL_CD;
				}
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)218824704;
				short num3 = num;
				goto IL_5F;
			}
			}
			int num4;
			for (;;)
			{
				IL_BB:
				switch (num4)
				{
				case 0:
					this.StartScrollingAcpLabel(this.LblBottomButton3IndexViewboxValue, this.BottomButton3IndexCanvas, ref this.isBottomButton3IndexAnimating, this.RenderTransformBottomButton3IndexViewbox);
					num = (short)1261371394;
					num4 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_B1;
				case 2:
					goto IL_12D;
				}
				goto IL_CD;
			}
			IL_12D:
			return;
			IL_5F:
			num = (short)1462829057;
			if (num != 0)
			{
			}
			num = (short)22478848;
			if (num != 0)
			{
			}
			num = (short)1810563073;
			num4 = (int)((IntPtr)num);
			goto IL_BB;
			IL_CD:
			if ((sender as AcpLabel).ActualWidth > 112.06)
			{
				num = (short)513343488;
				num4 = (int)((IntPtr)num);
				goto IL_BB;
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x000859AC File Offset: 0x00083BAC
		private void BottomButton4Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)310509568;
			short num2 = num;
			num = (short)948043777;
			if (num != 0)
			{
			}
			num = (short)555372335;
			short num3 = num;
			num = (short)1552240431;
			switch (num3 == num)
			{
			}
			num = (short)1884160000;
			if (num != 0)
			{
			}
			this.isBottomButton4IndexAnimating = false;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00085A5C File Offset: 0x00083C5C
		private void ScrollingBottomButton4IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1538772275;
			short num2 = num;
			num = (short)1416744243;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_88:
				num = (short)1406533633;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_CA;
				}
				break;
			case 1:
				goto IL_5C;
			default:
			{
				num = (short)1224474624;
				short num3 = num;
				goto IL_5C;
			}
			}
			int num4;
			for (;;)
			{
				IL_B8:
				switch (num4)
				{
				case 0:
					this.StartScrollingAcpLabel(this.LblBottomButton4IndexViewboxValue, this.BottomButton4IndexCanvas, ref this.isBottomButton4IndexAnimating, this.RenderTransformBottomButton4IndexViewbox);
					num = (short)906100738;
					num4 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_88;
				case 2:
					goto IL_12C;
				}
				goto IL_CA;
			}
			IL_12C:
			return;
			IL_5C:
			num = (short)100466688;
			if (num != 0)
			{
			}
			num = (short)2118975489;
			num4 = (int)((IntPtr)num);
			goto IL_B8;
			IL_CA:
			if ((sender as AcpLabel).ActualWidth > 112.06)
			{
				num = (short)869662720;
				num4 = (int)((IntPtr)num);
				goto IL_B8;
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00085B98 File Offset: 0x00083D98
		private void BottomButton5Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)2002321408;
			short num2 = num;
			num = (short)567994842;
			short num3 = num;
			num = (short)1415047642;
			switch (num3 == num)
			{
			}
			num = (short)1647378432;
			if (num != 0)
			{
			}
			num = (short)2099970049;
			if (num != 0)
			{
			}
			this.isBottomButton5IndexAnimating = false;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00085C4C File Offset: 0x00083E4C
		private void ScrollingBottomButton5IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)177276656;
			short num2 = num;
			num = (short)293603056;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_87:
				switch (0)
				{
				case 0:
					goto IL_A3;
				}
				break;
			case 1:
				goto IL_5D;
			default:
			{
				num = (short)1145962496;
				short num3 = num;
				goto IL_5D;
			}
			}
			int num4;
			for (;;)
			{
				IL_91:
				switch (num4)
				{
				case 0:
					this.StartScrollingAcpLabel(this.LblBottomButton5IndexViewboxValue, this.BottomButton5IndexCanvas, ref this.isBottomButton5IndexAnimating, this.RenderTransformBottomButton5IndexViewbox);
					num = (short)320471042;
					num4 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_87;
				case 2:
					goto IL_102;
				}
				goto IL_A3;
			}
			IL_102:
			num = (short)1292107777;
			if (num != 0)
			{
			}
			return;
			IL_5D:
			num = (short)2007433216;
			if (num != 0)
			{
			}
			num = (short)682360833;
			num4 = (int)((IntPtr)num);
			goto IL_91;
			IL_A3:
			if ((sender as AcpLabel).ActualWidth > 112.06)
			{
				num = (short)1296302080;
				num4 = (int)((IntPtr)num);
				goto IL_91;
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00085D84 File Offset: 0x00083F84
		private void MouseEnterBottomButtonFeatureLabel(object sender, MouseEventArgs e)
		{
			short num = (short)1848508416;
			short num2 = num;
			num = (short)863691830;
			short num3 = num;
			num = (short)1489822774;
			AcpLabel acpLabel;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1094123520;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= 81.0)
				{
					num = (short)1775763457;
					if (num != 0)
					{
					}
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
				break;
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00085E5C File Offset: 0x0008405C
		private void BottomButtonFeatureLabelChanged(object sender, SizeChangedEventArgs e)
		{
			short num = (short)1066795008;
			short num2 = num;
			num = (short)1004791194;
			short num3 = num;
			num = (short)341370266;
			AcpLabel acpLabel;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)488308736;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth >= 75.0)
				{
					Canvas.SetLeft(acpLabel, 0.0);
					return;
				}
				num = (short)282460161;
				if (num != 0)
				{
				}
				break;
			}
			Canvas.SetLeft(acpLabel, 10.0);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00085F40 File Offset: 0x00084140
		private void BottomButton1Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)305004544;
			short num2 = num;
			num = (short)362794176;
			short num3 = num;
			num = (short)43175104;
			switch (num3 == num)
			{
			}
			num = (short)150077441;
			if (num != 0)
			{
			}
			num = (short)732954624;
			if (num != 0)
			{
			}
			this.isBottomButton1FeatureAnimating = false;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00085FF4 File Offset: 0x000841F4
		private void ScrollingBottomButton1FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)567265766;
			short num2 = num;
			num = (short)292800998;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_89:
				switch (0)
				{
				case 0:
					goto IL_A5;
				}
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)572981248;
				short num3 = num;
				goto IL_5F;
			}
			}
			int num4;
			for (;;)
			{
				IL_93:
				switch (num4)
				{
				case 0:
					this.StartScrollingAcpLabel(this.LblBottomButton1FeatureViewboxValue, this.BottomButton1FeatureCanvas, ref this.isBottomButton1FeatureAnimating, this.RenderTransformBottomButton1FeatureViewbox);
					num = (short)116064257;
					if (num != 0)
					{
					}
					num = (short)1837039618;
					num4 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_89;
				case 2:
					goto IL_131;
				}
				goto IL_A5;
			}
			IL_131:
			return;
			IL_5F:
			num = (short)1450704896;
			if (num != 0)
			{
			}
			num = (short)32440321;
			num4 = (int)((IntPtr)num);
			goto IL_93;
			IL_A5:
			if ((sender as AcpLabel).ActualWidth > 81.0)
			{
				num = (short)1809776640;
				num4 = (int)((IntPtr)num);
				goto IL_93;
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00086134 File Offset: 0x00084334
		private void BottomButton2Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)541589504;
			short num2 = num;
			num = (short)1168847993;
			short num3 = num;
			num = (short)1186149497;
			switch (num3 == num)
			{
			}
			num = (short)921960449;
			if (num != 0)
			{
			}
			num = (short)241303552;
			if (num != 0)
			{
			}
			this.isBottomButton2FeatureAnimating = false;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x000861E4 File Offset: 0x000843E4
		private void ScrollingBottomButton2FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1880295896;
			short num2 = num;
			num = (short)1338444248;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_89:
				switch (0)
				{
				case 0:
					goto IL_CE;
				}
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)1130102784;
				short num3 = num;
				goto IL_5F;
			}
			}
			int num4;
			for (;;)
			{
				IL_93:
				num = (short)586350593;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					this.StartScrollingAcpLabel(this.LblBottomButton2FeatureViewboxValue, this.BottomButton2FeatureCanvas, ref this.isBottomButton2FeatureAnimating, this.RenderTransformBottomButton2FeatureViewbox);
					num = (short)872087554;
					num4 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_89;
				case 2:
					goto IL_12F;
				}
				goto IL_CE;
			}
			IL_12F:
			return;
			IL_5F:
			num = (short)277807104;
			if (num != 0)
			{
			}
			num = (short)731643905;
			num4 = (int)((IntPtr)num);
			goto IL_93;
			IL_CE:
			if ((sender as AcpLabel).ActualWidth > 81.0)
			{
				num = (short)1308033024;
				num4 = (int)((IntPtr)num);
				goto IL_93;
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00086324 File Offset: 0x00084524
		private void BottomButton3Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1370357760;
			short num2 = num;
			num = (short)665714689;
			if (num != 0)
			{
			}
			num = (short)1725466382;
			short num3 = num;
			num = (short)502826766;
			switch (num3 == num)
			{
			}
			num = (short)305856512;
			if (num != 0)
			{
			}
			this.isBottomButton3FeatureAnimating = false;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000863D4 File Offset: 0x000845D4
		private void ScrollingBottomButton3FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)544360458;
			short num2 = num;
			num = (short)2128234506;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_89:
				switch (0)
				{
				case 0:
					goto IL_A5;
				}
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)17694720;
				short num3 = num;
				goto IL_5F;
			}
			}
			int num4;
			for (;;)
			{
				IL_93:
				switch (num4)
				{
				case 0:
					num = (short)1733820417;
					if (num != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblBottomButton3FeatureViewboxValue, this.BottomButton3FeatureCanvas, ref this.isBottomButton3FeatureAnimating, this.RenderTransformBottomButton3FeatureViewbox);
					num = (short)204341250;
					num4 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_89;
				case 2:
					goto IL_130;
				}
				goto IL_A5;
			}
			IL_130:
			return;
			IL_5F:
			num = (short)1217986560;
			if (num != 0)
			{
			}
			num = (short)1700528129;
			num4 = (int)((IntPtr)num);
			goto IL_93;
			IL_A5:
			if ((sender as AcpLabel).ActualWidth > 81.0)
			{
				num = (short)772210688;
				num4 = (int)((IntPtr)num);
				goto IL_93;
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00086514 File Offset: 0x00084714
		private void BottomButton4Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)2140930048;
			short num2 = num;
			num = (short)1954825882;
			short num3 = num;
			num = (short)29247130;
			switch (num3 == num)
			{
			}
			num = (short)1026621441;
			if (num != 0)
			{
			}
			num = (short)1706885120;
			if (num != 0)
			{
			}
			this.isBottomButton4FeatureAnimating = false;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000865C4 File Offset: 0x000847C4
		private void ScrollingBottomButton4FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)881591251;
			short num2 = num;
			num = (short)1239286739;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_89:
				switch (0)
				{
				case 0:
					goto IL_A5;
				}
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)84934656;
				short num3 = num;
				goto IL_5F;
			}
			}
			int num4;
			for (;;)
			{
				IL_93:
				switch (num4)
				{
				case 0:
					this.StartScrollingAcpLabel(this.LblBottomButton4FeatureViewboxValue, this.BottomButton4FeatureCanvas, ref this.isBottomButton4FeatureAnimating, this.RenderTransformBottomButton4FeatureViewbox);
					num = (short)434044930;
					num4 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_89;
				case 2:
					goto IL_105;
				}
				goto IL_A5;
			}
			IL_105:
			goto IL_107;
			IL_5F:
			num = (short)1111556096;
			if (num != 0)
			{
			}
			num = (short)641335297;
			num4 = (int)((IntPtr)num);
			goto IL_93;
			IL_A5:
			if ((sender as AcpLabel).ActualWidth > 81.0)
			{
				num = (short)1430126592;
				num4 = (int)((IntPtr)num);
				goto IL_93;
			}
			IL_107:
			num = (short)1512046593;
			if (num != 0)
			{
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00086700 File Offset: 0x00084900
		private void BottomButton5Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)788660224;
			short num2 = num;
			num = (short)1150304781;
			short num3 = num;
			num = (short)1479885325;
			switch (num3 == num)
			{
			}
			num = (short)1189871616;
			if (num != 0)
			{
			}
			num = (short)2096300033;
			if (num != 0)
			{
			}
			this.isBottomButton5FeatureAnimating = false;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000867B0 File Offset: 0x000849B0
		private void ScrollingBottomButton5FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1400468269;
			short num2 = num;
			num = (short)841118509;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_85:
				switch (0)
				{
				case 0:
					goto IL_A1;
				}
				break;
			case 1:
				goto IL_5C;
			default:
			{
				num = (short)1911422976;
				short num3 = num;
				goto IL_5C;
			}
			}
			int num4;
			for (;;)
			{
				IL_8F:
				switch (num4)
				{
				case 0:
					num = (short)91619329;
					if (num != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblBottomButton5FeatureViewboxValue, this.BottomButton5FeatureCanvas, ref this.isBottomButton5FeatureAnimating, this.RenderTransformBottomButton5FeatureViewbox);
					num = (short)535101442;
					num4 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_85;
				case 2:
					goto IL_12A;
				}
				goto IL_A1;
			}
			IL_12A:
			return;
			IL_5C:
			num = (short)1706622976;
			if (num != 0)
			{
			}
			num = (short)203751425;
			num4 = (int)((IntPtr)num);
			goto IL_8F;
			IL_A1:
			if ((sender as AcpLabel).ActualWidth > 81.0)
			{
				num = (short)2033319936;
				num4 = (int)((IntPtr)num);
				goto IL_8F;
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000868EC File Offset: 0x00084AEC
		private void MouseEnterTopButtonZoneLabel(object sender, MouseEventArgs e)
		{
			short num = (short)363134976;
			short num2 = num;
			num = (short)1881740700;
			short num3 = num;
			num = (short)1853560220;
			AcpLabel acpLabel;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)656998400;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= 134.07)
				{
					num = (short)2031550465;
					if (num != 0)
					{
					}
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
				break;
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000869C8 File Offset: 0x00084BC8
		private void MouseEnterTopButtonChannelLabel(object sender, MouseEventArgs e)
		{
			short num = (short)360513536;
			short num2 = num;
			num = (short)1999547905;
			short num3 = num;
			num = (short)1993649665;
			AcpLabel acpLabel;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2138898432;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= 116.06)
				{
					acpLabel.Cursor = Cursors.Arrow;
					return;
				}
				num = (short)724238337;
				if (num != 0)
				{
				}
				break;
			}
			acpLabel.Cursor = Cursors.Hand;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00086AA0 File Offset: 0x00084CA0
		private void TopButtonZoneLabelChanged(object sender, SizeChangedEventArgs e)
		{
			short num = (short)359792640;
			short num2 = num;
			num = (short)755599269;
			short num3 = num;
			num = (short)1611106213;
			AcpLabel acpLabel;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)575078401;
				if (num != 0)
				{
				}
				num = (short)1776877568;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth >= 122.06)
				{
					Canvas.SetLeft(acpLabel, -4.0);
					return;
				}
				break;
			}
			Canvas.SetLeft(acpLabel, 10.0);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00086B80 File Offset: 0x00084D80
		private void TopButtonChannelLabelChanged(object sender, SizeChangedEventArgs e)
		{
			short num = (short)1373765632;
			short num2 = num;
			num = (short)1075168265;
			short num3 = num;
			num = (short)439600137;
			AcpLabel acpLabel;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1174208512;
				if (num != 0)
				{
				}
				num = (short)829423617;
				if (num != 0)
				{
				}
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth >= 104.05)
				{
					Canvas.SetLeft(acpLabel, -4.0);
					return;
				}
				break;
			}
			Canvas.SetLeft(acpLabel, 10.0);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00086C60 File Offset: 0x00084E60
		private void TopButton1Zone_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1790377984;
			short num2 = num;
			num = (short)1700848720;
			short num3 = num;
			num = (short)726328400;
			switch (num3 == num)
			{
			}
			num = (short)1993670656;
			if (num != 0)
			{
			}
			num = (short)893124609;
			if (num != 0)
			{
			}
			this.isTopButton1ZoneAnimating = false;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00086D14 File Offset: 0x00084F14
		private void TopButton1Channel_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)262275072;
			short num2 = num;
			num = (short)1845524759;
			short num3 = num;
			num = (short)2119923991;
			switch (num3 == num)
			{
			}
			num = (short)2095710208;
			if (num != 0)
			{
			}
			num = (short)15794177;
			if (num != 0)
			{
			}
			this.isTopButton1ChannelAnimating = false;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00086DC4 File Offset: 0x00084FC4
		private void TopButton2Zone_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)528416768;
			short num2 = num;
			num = (short)1376159727;
			short num3 = num;
			num = (short)1600227311;
			switch (num3 == num)
			{
			}
			num = (short)1695416321;
			if (num != 0)
			{
			}
			num = (short)1279590400;
			if (num != 0)
			{
			}
			this.isTopButton2ZoneAnimating = false;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00086E78 File Offset: 0x00085078
		private void TopButton2Channel_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)369164288;
			short num2 = num;
			num = (short)40409606;
			short num3 = num;
			num = (short)2079365638;
			switch (num3 == num)
			{
			}
			num = (short)476577793;
			if (num != 0)
			{
			}
			num = (short)947519488;
			if (num != 0)
			{
			}
			this.isTopButton2ChannelAnimating = false;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00086F28 File Offset: 0x00085128
		private void TopButton3Zone_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)622460928;
			short num2 = num;
			num = (short)578342132;
			short num3 = num;
			num = (short)573426932;
			switch (num3 == num)
			{
			}
			num = (short)2115371008;
			if (num != 0)
			{
			}
			num = (short)386072577;
			if (num != 0)
			{
			}
			this.isTopButton3ZoneAnimating = false;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00086FDC File Offset: 0x000851DC
		private void TopButton3Channel_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)929073019;
			short num2 = num;
			num = (short)1540261755;
			switch (num2 == num)
			{
			default:
			{
				num = (short)255459328;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)121962497;
			if (num != 0)
			{
			}
			num = (short)130023424;
			if (num != 0)
			{
			}
			this.isTopButton3ChannelAnimating = false;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0008708C File Offset: 0x0008528C
		private void TopButton4Zone_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)431226881;
			if (num != 0)
			{
			}
			num = (short)425263104;
			short num2 = num;
			num = (short)837502981;
			short num3 = num;
			num = (short)237848581;
			switch (num3 == num)
			{
			}
			num = (short)1407582208;
			if (num != 0)
			{
			}
			this.isTopButton4ZoneAnimating = false;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00087138 File Offset: 0x00085338
		private void TopButton4Channel_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)2137177698;
			short num2 = num;
			num = (short)140885602;
			switch (num2 == num)
			{
			default:
			{
				num = (short)539033600;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1076953089;
			if (num != 0)
			{
			}
			num = (short)420085760;
			if (num != 0)
			{
			}
			this.isTopButton4ChannelAnimating = false;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x000871EC File Offset: 0x000853EC
		private void TopButton5Zone_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)2074086904;
			short num2 = num;
			num = (short)1393757688;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1283981312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1199308800;
			if (num != 0)
			{
			}
			num = (short)125763585;
			if (num != 0)
			{
			}
			this.isTopButton5ZoneAnimating = false;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x000872A0 File Offset: 0x000854A0
		private void TopButton5Channel_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)301021965;
			short num2 = num;
			num = (short)1760770829;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1835532288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1457192961;
			if (num != 0)
			{
			}
			num = (short)333709312;
			if (num != 0)
			{
			}
			this.isTopButton5ChannelAnimating = false;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00087350 File Offset: 0x00085550
		private void ScrollingTopButton1ZoneLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1755512832;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1288811540;
					short num3 = num;
					num = (short)1849144340;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)582811649;
						if (num != 0)
						{
						}
						num = (short)1661861888;
						short num4 = num;
						num = (short)179175424;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_CD;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton1ZoneViewboxValue, this.TopButton1ZoneCanvas, ref this.isTopButton1ZoneAnimating, this.RenderTransformTopButton1ZoneViewbox);
					num = (short)785121282;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					return;
				}
				IL_CD:
				if ((sender as AcpLabel).ActualWidth <= 134.07)
				{
					break;
				}
				num = (short)489357313;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0008748C File Offset: 0x0008568C
		private void ScrollingTopButton1ChannelLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1257308160;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1757081518;
					short num3 = num;
					num = (short)141291438;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)339542016;
						if (num != 0)
						{
						}
						num = (short)1872166912;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A9;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					num = (short)268959745;
					if (num != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblTopButton1ChannelViewboxValue, this.TopButton1ChannelCanvas, ref this.isTopButton1ChannelAnimating, this.RenderTransformTopButton1ChannelViewbox);
					num = (short)148635650;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					return;
				}
				IL_A9:
				if ((sender as AcpLabel).ActualWidth <= 116.06)
				{
					break;
				}
				num = (short)497811457;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000875CC File Offset: 0x000857CC
		private void ScrollingTopButton2ZoneLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1762000896;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2028980919;
					short num3 = num;
					num = (short)1907870391;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1035927552;
						if (num != 0)
						{
						}
						num = (short)166985728;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					num = (short)666566657;
					if (num != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblTopButton2ZoneViewboxValue, this.TopButton2ZoneCanvas, ref this.isTopButton2ZoneAnimating, this.RenderTransformTopButton2ZoneViewbox);
					num = (short)1729691650;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					return;
				}
				IL_A3:
				if ((sender as AcpLabel).ActualWidth <= 134.07)
				{
					break;
				}
				num = (short)1688731649;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00087708 File Offset: 0x00085908
		private void ScrollingTopButton2ChannelLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1887436800;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)602762396;
					short num3 = num;
					num = (short)555052188;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1230176256;
						if (num != 0)
						{
						}
						num = (short)1800404992;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A8;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton2ChannelViewboxValue, this.TopButton2ChannelCanvas, ref this.isTopButton2ChannelAnimating, this.RenderTransformTopButton2ChannelViewbox);
					num = (short)1890385922;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					return;
				}
				IL_A8:
				num = (short)651886593;
				if (num != 0)
				{
				}
				if ((sender as AcpLabel).ActualWidth <= 116.06)
				{
					break;
				}
				num = (short)1579614209;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00087848 File Offset: 0x00085A48
		private void ScrollingTopButton3ZoneLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)912195584;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)776525323;
					short num3 = num;
					num = (short)1351472651;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)188416000;
						if (num != 0)
						{
						}
						num = (short)320864256;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton3ZoneViewboxValue, this.TopButton3ZoneCanvas, ref this.isTopButton3ZoneAnimating, this.RenderTransformTopButton3ZoneViewbox);
					num = (short)439681026;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_102;
				}
				IL_A3:
				if ((sender as AcpLabel).ActualWidth <= 134.07)
				{
					break;
				}
				num = (short)1391460353;
				num2 = (int)((IntPtr)num);
			}
			IL_102:
			num = (short)1703346177;
			if (num != 0)
			{
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00087980 File Offset: 0x00085B80
		private void ScrollingTopButton3ChannelLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)704905216;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)751070936;
					short num3 = num;
					num = (short)2120117976;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2128740352;
						if (num != 0)
						{
						}
						num = (short)18808832;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					num = (short)1754791937;
					if (num != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblTopButton3ChannelViewboxValue, this.TopButton3ChannelCanvas, ref this.isTopButton3ChannelAnimating, this.RenderTransformTopButton3ChannelViewbox);
					num = (short)1923612674;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					return;
				}
				IL_A7:
				if ((sender as AcpLabel).ActualWidth <= 116.06)
				{
					break;
				}
				num = (short)371261441;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00087AC0 File Offset: 0x00085CC0
		private void ScrollingTopButton4ZoneLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)2023882752;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2000353963;
					short num3 = num;
					num = (short)1426586283;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)163315712;
						if (num != 0)
						{
						}
						num = (short)347144192;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton4ZoneViewboxValue, this.TopButton4ZoneCanvas, ref this.isTopButton4ZoneAnimating, this.RenderTransformTopButton4ZoneViewbox);
					num = (short)712966146;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					return;
				}
				IL_A7:
				num = (short)288817153;
				if (num != 0)
				{
				}
				if ((sender as AcpLabel).ActualWidth <= 134.07)
				{
					break;
				}
				num = (short)805830657;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00087C00 File Offset: 0x00085E00
		private void ScrollingTopButton4ChannelLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1116864512;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1825125192;
					short num3 = num;
					num = (short)1720464200;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)838270976;
						if (num != 0)
						{
						}
						num = (short)39190528;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton4ChannelViewboxValue, this.TopButton4ChannelCanvas, ref this.isTopButton4ChannelAnimating, this.RenderTransformTopButton4ChannelViewbox);
					num = (short)2006974466;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_105;
				}
				IL_A7:
				if ((sender as AcpLabel).ActualWidth <= 116.06)
				{
					return;
				}
				num = (short)381288449;
				num2 = (int)((IntPtr)num);
			}
			IL_105:
			num = (short)1932722177;
			if (num != 0)
			{
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00087D3C File Offset: 0x00085F3C
		private void ScrollingTopButton5ZoneLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)74645504;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)88592647;
					short num3 = num;
					num = (short)1460719879;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1825439745;
						if (num != 0)
						{
						}
						num = (short)1583349760;
						short num4 = num;
						num = (short)1882849280;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D2;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton5ZoneViewboxValue, this.TopButton5ZoneCanvas, ref this.isTopButton5ZoneAnimating, this.RenderTransformTopButton5ZoneViewbox);
					num = (short)2009464834;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					return;
				}
				IL_D2:
				if ((sender as AcpLabel).ActualWidth <= 134.07)
				{
					break;
				}
				num = (short)1455489025;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00087E7C File Offset: 0x0008607C
		private void ScrollingTopButton5ChannelLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1087307776;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1109217812;
					short num3 = num;
					num = (short)486232596;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1091371008;
						if (num != 0)
						{
						}
						num = (short)1500577792;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton5ChannelViewboxValue, this.TopButton5ChannelCanvas, ref this.isTopButton5ChannelAnimating, this.RenderTransformTopButton5ChannelViewbox);
					num = (short)766640130;
					num2 = (int)((IntPtr)num);
					continue;
				case 2:
					goto IL_101;
				}
				IL_A3:
				if ((sender as AcpLabel).ActualWidth <= 116.06)
				{
					break;
				}
				num = (short)1752498177;
				num2 = (int)((IntPtr)num);
			}
			IL_101:
			num = (short)1250951169;
			if (num != 0)
			{
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00087FB8 File Offset: 0x000861B8
		private void MouseEnterTopButtonIndexLabel(object sender, MouseEventArgs e)
		{
			AcpLabel acpLabel;
			short num;
			for (;;)
			{
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth <= 130.07)
				{
					goto IL_C4;
				}
				num = (short)812652496;
				short num2 = num;
				num = (short)744560592;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_50;
				}
			}
			IL_50:
			num = (short)1710292993;
			if (num != 0)
			{
			}
			num = (short)1358233600;
			short num3 = num;
			num = (short)948240384;
			if (num != 0)
			{
			}
			acpLabel.Cursor = Cursors.Hand;
			return;
			IL_C4:
			acpLabel.Cursor = Cursors.Arrow;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00088094 File Offset: 0x00086294
		private void TopButtonIndexLabelChanged(object sender, SizeChangedEventArgs e)
		{
			AcpLabel acpLabel;
			short num;
			for (;;)
			{
				acpLabel = (sender as AcpLabel);
				if (acpLabel.ActualWidth >= 118.06)
				{
					goto IL_C8;
				}
				num = (short)747818965;
				short num2 = num;
				num = (short)949866453;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_4F;
				}
			}
			IL_4F:
			num = (short)1956839424;
			if (num != 0)
			{
			}
			num = (short)2115895296;
			short num3 = num;
			num = (short)1974796289;
			if (num != 0)
			{
			}
			Canvas.SetLeft(acpLabel, 10.0);
			return;
			IL_C8:
			Canvas.SetLeft(acpLabel, -4.0);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00088178 File Offset: 0x00086378
		private void TopButton1Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1438337411;
			short num2 = num;
			num = (short)1376733571;
			switch (num2 == num)
			{
			default:
			{
				num = (short)210305024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)722599937;
			if (num != 0)
			{
			}
			num = (short)1498677248;
			if (num != 0)
			{
			}
			this.isTopButton1IndexAnimating = false;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00088228 File Offset: 0x00086428
		private void ScrollingTopButton1IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)848560130;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E7;
				case 1:
					num = (short)2132082689;
					if (num != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblTopButton1IndexViewboxValue, this.TopButton1IndexCanvas, ref this.isTopButton1IndexAnimating, this.RenderTransformTopButton1IndexViewbox);
					goto IL_CE;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if ((sender as AcpLabel).ActualWidth > 130.07)
				{
					num = (short)1874395136;
					short num3 = num;
					num = (short)658178049;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_E7;
				IL_CE:
				num = (short)965083136;
				num2 = (int)((IntPtr)num);
				continue;
				IL_E7:
				num = (short)193572262;
				short num4 = num;
				num = (short)1372958118;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_CE;
				default:
					goto IL_11B;
				}
			}
			IL_11B:
			num = (short)1326514176;
			if (num != 0)
			{
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00088368 File Offset: 0x00086568
		private void TopButton2Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)783696935;
			short num2 = num;
			num = (short)2070365223;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2036334592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)888864769;
			if (num != 0)
			{
			}
			num = (short)1238827008;
			if (num != 0)
			{
			}
			this.isTopButton2IndexAnimating = false;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00088418 File Offset: 0x00086618
		private void ScrollingTopButton2IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1356726274;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_BC;
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton2IndexViewboxValue, this.TopButton2IndexCanvas, ref this.isTopButton2IndexAnimating, this.RenderTransformTopButton2IndexViewbox);
					goto IL_A3;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if ((sender as AcpLabel).ActualWidth > 130.07)
				{
					num = (short)495648768;
					short num3 = num;
					num = (short)1014824961;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_BC;
				IL_A3:
				num = (short)693698560;
				num2 = (int)((IntPtr)num);
				continue;
				IL_BC:
				num = (short)73072641;
				if (num != 0)
				{
				}
				num = (short)307011144;
				short num4 = num;
				num = (short)398237256;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A3;
				default:
					goto IL_119;
				}
			}
			IL_119:
			num = (short)2140012544;
			if (num != 0)
			{
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00088554 File Offset: 0x00086754
		private void TopButton3Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)860178639;
			short num2 = num;
			num = (short)1228687567;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1483800576;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)611647488;
			if (num != 0)
			{
			}
			num = (short)1093992449;
			if (num != 0)
			{
			}
			this.isTopButton3IndexAnimating = false;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00088604 File Offset: 0x00086804
		private void ScrollingTopButton3IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1100152834;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E8;
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton3IndexViewboxValue, this.TopButton3IndexCanvas, ref this.isTopButton3IndexAnimating, this.RenderTransformTopButton3IndexViewbox);
					goto IL_CD;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)322633729;
				if (num != 0)
				{
				}
				num = (short)2029780992;
				short num3 = num;
				if ((sender as AcpLabel).ActualWidth > 130.07)
				{
					num = (short)1274675201;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_E8;
				IL_CD:
				num = (short)1187184640;
				num2 = (int)((IntPtr)num);
				continue;
				IL_E8:
				num = (short)1645359774;
				short num4 = num;
				num = (short)3617438;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_CD;
				default:
					goto IL_11D;
				}
			}
			IL_11D:
			num = (short)1394737152;
			if (num != 0)
			{
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00088744 File Offset: 0x00086944
		private void TopButton4Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)207300313;
			short num2 = num;
			num = (short)1418077913;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2033844224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1775763456;
			if (num != 0)
			{
			}
			num = (short)1575747585;
			if (num != 0)
			{
			}
			this.isTopButton4IndexAnimating = false;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000887F0 File Offset: 0x000869F0
		private void ScrollingTopButton4IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1301610498;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C1;
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton4IndexViewboxValue, this.TopButton4IndexCanvas, ref this.isTopButton4IndexAnimating, this.RenderTransformTopButton4IndexViewbox);
					goto IL_A7;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				if ((sender as AcpLabel).ActualWidth > 130.07)
				{
					num = (short)1308426240;
					short num3 = num;
					num = (short)264175617;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_C1;
				IL_A7:
				num = (short)397279232;
				num2 = (int)((IntPtr)num);
				continue;
				IL_C1:
				num = (short)1282068964;
				short num4 = num;
				num = (short)1589236196;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A7;
				default:
					goto IL_F6;
				}
			}
			IL_F6:
			num = (short)1974927361;
			if (num != 0)
			{
			}
			num = (short)79495168;
			if (num != 0)
			{
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00088930 File Offset: 0x00086B30
		private void TopButton5Index_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1164640257;
			if (num != 0)
			{
			}
			num = (short)36634624;
			short num2 = num;
			num = (short)1916558611;
			short num3 = num;
			num = (short)2070109459;
			switch (num3 == num)
			{
			}
			num = (short)1248854016;
			if (num != 0)
			{
			}
			this.isTopButton5IndexAnimating = false;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x000889E0 File Offset: 0x00086BE0
		private void ScrollingTopButton5IndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)476839938;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E9;
				case 1:
					num = (short)674627585;
					if (num != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblTopButton5IndexViewboxValue, this.TopButton5IndexCanvas, ref this.isTopButton5IndexAnimating, this.RenderTransformTopButton5IndexViewbox);
					goto IL_CF;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if ((sender as AcpLabel).ActualWidth > 130.07)
				{
					num = (short)2102984704;
					short num3 = num;
					num = (short)396492801;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_E9;
				IL_CF:
				num = (short)1868693504;
				num2 = (int)((IntPtr)num);
				continue;
				IL_E9:
				num = (short)3851320;
				short num4 = num;
				num = (short)1615512632;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_CF;
				default:
					goto IL_11E;
				}
			}
			IL_11E:
			num = (short)1787166720;
			if (num != 0)
			{
			}
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00088B20 File Offset: 0x00086D20
		private void MouseEnterTopButtonFeatureLabel(object sender, MouseEventArgs e)
		{
			short num = (short)1248329728;
			short num2 = num;
			AcpLabel acpLabel = sender as AcpLabel;
			if (acpLabel.ActualWidth > 106.5)
			{
				num = (short)2019098625;
				if (num != 0)
				{
				}
				num = (short)671292205;
				short num3 = num;
				num = (short)1403788077;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)908853248;
					if (num != 0)
					{
					}
					acpLabel.Cursor = Cursors.Hand;
					return;
				}
			}
			acpLabel.Cursor = Cursors.Arrow;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00088C00 File Offset: 0x00086E00
		private void TopButtonFeatureLabelChanged(object sender, SizeChangedEventArgs e)
		{
			short num = (short)559546368;
			short num2 = num;
			AcpLabel acpLabel = sender as AcpLabel;
			if (acpLabel.ActualWidth < 118.06)
			{
				num = (short)720940694;
				short num3 = num;
				num = (short)1929555606;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)940769280;
					if (num != 0)
					{
					}
					Canvas.SetLeft(acpLabel, 10.0);
					return;
				}
			}
			num = (short)1300103169;
			if (num != 0)
			{
			}
			Canvas.SetLeft(acpLabel, 0.0);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00088CE0 File Offset: 0x00086EE0
		private void TopButton1Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1737688777;
			short num2 = num;
			num = (short)2129331913;
			switch (num2 == num)
			{
			default:
			{
				num = (short)917635072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2025848833;
			if (num != 0)
			{
			}
			num = (short)1438711808;
			if (num != 0)
			{
			}
			this.isTopButton1FeatureAnimating = false;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00088D90 File Offset: 0x00086F90
		private void ScrollingTopButton1FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)541786114;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E6;
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton1FeatureViewboxValue, this.TopButton1FeatureCanvas, ref this.isTopButton1FeatureAnimating, this.RenderTransformTopButton1FeatureViewbox);
					goto IL_CC;
				case 2:
					num = (short)896729089;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				IL_58:
				num = (short)1726218240;
				short num3 = num;
				if ((sender as AcpLabel).ActualWidth > 106.5)
				{
					num = (short)541720577;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_E6;
				IL_CC:
				num = (short)216072192;
				num2 = (int)((IntPtr)num);
				continue;
				IL_E6:
				num = (short)1572722200;
				short num4 = num;
				num = (short)1056167448;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_CC;
				default:
					goto IL_11A;
				}
			}
			IL_11A:
			num = (short)226754560;
			if (num != 0)
			{
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00088ECC File Offset: 0x000870CC
		private void TopButton2Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)536429892;
			short num2 = num;
			num = (short)31868228;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1951596544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1474691073;
			if (num != 0)
			{
			}
			num = (short)1827209216;
			if (num != 0)
			{
			}
			this.isTopButton2FeatureAnimating = false;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00088F80 File Offset: 0x00087180
		private void ScrollingTopButton2FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1039204354;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1401290753;
					if (num != 0)
					{
					}
					goto IL_E7;
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton2FeatureViewboxValue, this.TopButton2FeatureCanvas, ref this.isTopButton2FeatureAnimating, this.RenderTransformTopButton2FeatureViewbox);
					goto IL_A7;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if ((sender as AcpLabel).ActualWidth > 106.5)
				{
					num = (short)2143027200;
					short num3 = num;
					num = (short)218038273;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_E7;
				IL_A7:
				num = (short)1923284992;
				num2 = (int)((IntPtr)num);
				continue;
				IL_E7:
				num = (short)531124180;
				short num4 = num;
				num = (short)944656340;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A7;
				default:
					goto IL_11D;
				}
			}
			IL_11D:
			num = (short)1891434496;
			if (num != 0)
			{
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000890C4 File Offset: 0x000872C4
		private void TopButton3Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1670381569;
			if (num != 0)
			{
			}
			num = (short)975634432;
			short num2 = num;
			num = (short)775240188;
			short num3 = num;
			num = (short)1606433276;
			switch (num3 == num)
			{
			}
			num = (short)1346764800;
			if (num != 0)
			{
			}
			this.isTopButton3FeatureAnimating = false;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00089178 File Offset: 0x00087378
		private void ScrollingTopButton3FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1580924930;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E8;
				case 1:
					num = (short)1076625409;
					if (num != 0)
					{
					}
					this.StartScrollingAcpLabel(this.LblTopButton3FeatureViewboxValue, this.TopButton3FeatureCanvas, ref this.isTopButton3FeatureAnimating, this.RenderTransformTopButton3FeatureViewbox);
					goto IL_CE;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if ((sender as AcpLabel).ActualWidth > 106.5)
				{
					num = (short)665321472;
					short num3 = num;
					num = (short)1922433025;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_E8;
				IL_CE:
				num = (short)1747451904;
				num2 = (int)((IntPtr)num);
				continue;
				IL_E8:
				num = (short)1489001659;
				short num4 = num;
				num = (short)1898273979;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_CE;
				default:
					goto IL_11D;
				}
			}
			IL_11D:
			num = (short)713818112;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x000892B8 File Offset: 0x000874B8
		private void TopButton4Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)604282261;
			short num2 = num;
			num = (short)340696469;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1706426368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)150732801;
			if (num != 0)
			{
			}
			num = (short)508952576;
			if (num != 0)
			{
			}
			this.isTopButton4FeatureAnimating = false;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0008936C File Offset: 0x0008756C
		private void ScrollingTopButton4FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1510277122;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_BE;
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton4FeatureViewboxValue, this.TopButton4FeatureCanvas, ref this.isTopButton4FeatureAnimating, this.RenderTransformTopButton4FeatureViewbox);
					goto IL_A4;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if ((sender as AcpLabel).ActualWidth > 106.5)
				{
					num = (short)401145856;
					short num3 = num;
					num = (short)69730305;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_BE;
				IL_A4:
				num = (short)111017984;
				num2 = (int)((IntPtr)num);
				continue;
				IL_BE:
				num = (short)344854109;
				short num4 = num;
				num = (short)1058541149;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A4;
				default:
					goto IL_F3;
				}
			}
			IL_F3:
			num = (short)1809907713;
			if (num != 0)
			{
			}
			num = (short)100925440;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000894AC File Offset: 0x000876AC
		private void TopButton5Feature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)658750445;
			short num2 = num;
			num = (short)1948695533;
			switch (num2 == num)
			{
			default:
			{
				num = (short)695205888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)755564544;
			if (num != 0)
			{
			}
			num = (short)373751809;
			if (num != 0)
			{
			}
			this.isTopButton5FeatureAnimating = false;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0008955C File Offset: 0x0008775C
		private void ScrollingTopButton5FeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1226637314;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EA;
				case 1:
					this.StartScrollingAcpLabel(this.LblTopButton5FeatureViewboxValue, this.TopButton5FeatureCanvas, ref this.isTopButton5FeatureAnimating, this.RenderTransformTopButton5FeatureViewbox);
					goto IL_D1;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if ((sender as AcpLabel).ActualWidth > 106.5)
				{
					num = (short)1139933184;
					short num3 = num;
					num = (short)284033025;
					if (num != 0)
					{
					}
					num = (short)1763311617;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_EA;
				IL_D1:
				num = (short)442433536;
				num2 = (int)((IntPtr)num);
				continue;
				IL_EA:
				num = (short)2052258155;
				short num4 = num;
				num = (short)113113451;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D1;
				default:
					goto IL_120;
				}
			}
			IL_120:
			num = (short)192217088;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000896A0 File Offset: 0x000878A0
		private void LightbarLeftIndex_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)521819588;
			short num2 = num;
			num = (short)648631748;
			switch (num2 == num)
			{
			default:
			{
				num = (short)877330432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1376780289;
			if (num != 0)
			{
			}
			num = (short)363200512;
			if (num != 0)
			{
			}
			this.isLightbarLeftIndexAnimating = false;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00089754 File Offset: 0x00087954
		private void ScrollingLightbarLeftIndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1986134018;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_ED;
				case 1:
					this.StartScrollingAcpLabel(this.LblLightbarLeftIndexViewboxValue, this.LightbarLeftIndexCanvas, ref this.isLightbarLeftIndexAnimating, this.RenderTransformLightbarLeftIndexViewbox);
					goto IL_D3;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if ((sender as AcpLabel).ActualWidth > 94.05)
				{
					num = (short)179175424;
					short num3 = num;
					num = (short)399769601;
					if (num != 0)
					{
					}
					num = (short)744423425;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_ED;
				IL_D3:
				num = (short)521535488;
				num2 = (int)((IntPtr)num);
				continue;
				IL_ED:
				num = (short)161388383;
				short num4 = num;
				num = (short)1316198239;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D3;
				default:
					goto IL_122;
				}
			}
			IL_122:
			num = (short)826408960;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0008989C File Offset: 0x00087A9C
		private void MouseEnterLightbarIndexLabel(object sender, MouseEventArgs e)
		{
			short num = (short)612761600;
			short num2 = num;
			num = (short)1692532737;
			if (num != 0)
			{
			}
			AcpLabel acpLabel = sender as AcpLabel;
			if (acpLabel.ActualWidth > 94.05)
			{
				num = (short)2111339858;
				short num3 = num;
				num = (short)650214738;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1491861504;
					if (num != 0)
					{
					}
					acpLabel.Cursor = Cursors.Hand;
					return;
				}
			}
			acpLabel.Cursor = Cursors.Arrow;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00089974 File Offset: 0x00087B74
		private void LightbarIndexLabelChanged(object sender, SizeChangedEventArgs e)
		{
			short num = (short)1573126144;
			short num2 = num;
			AcpLabel acpLabel = sender as AcpLabel;
			if (acpLabel.ActualWidth < 82.05)
			{
				num = (short)1513291777;
				if (num != 0)
				{
				}
				num = (short)1537333757;
				short num3 = num;
				num = (short)740940285;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1993146368;
					if (num != 0)
					{
					}
					Canvas.SetLeft(acpLabel, 10.0);
					return;
				}
			}
			Canvas.SetLeft(acpLabel, -4.0);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00089A58 File Offset: 0x00087C58
		private void LightbarRightIndex_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1351953864;
			short num2 = num;
			num = (short)393489864;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1962278912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)383451136;
			if (num != 0)
			{
			}
			num = (short)377028609;
			if (num != 0)
			{
			}
			this.isLightbarRightIndexAnimating = false;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00089B08 File Offset: 0x00087D08
		private void ScrollingLightbarRightIndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)93323266;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EB;
				case 1:
					this.StartScrollingAcpLabel(this.LblLightbarRightIndexViewboxValue, this.LightbarRightIndexCanvas, ref this.isLightbarRightIndexAnimating, this.RenderTransformLightbarRightIndexViewbox);
					goto IL_D2;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)582483969;
				if (num != 0)
				{
				}
				num = (short)855572480;
				short num3 = num;
				if ((sender as AcpLabel).ActualWidth > 94.05)
				{
					num = (short)1894121473;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_EB;
				IL_D2:
				num = (short)1628831744;
				num2 = (int)((IntPtr)num);
				continue;
				IL_EB:
				num = (short)260100916;
				short num4 = num;
				num = (short)151114548;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D2;
				default:
					goto IL_120;
				}
			}
			IL_120:
			num = (short)254214144;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00089C4C File Offset: 0x00087E4C
		private void LightbarTopIndex_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)785907713;
			if (num != 0)
			{
			}
			num = (short)771227648;
			short num2 = num;
			num = (short)2037545090;
			short num3 = num;
			num = (short)839547010;
			switch (num3 == num)
			{
			}
			num = (short)980811776;
			if (num != 0)
			{
			}
			this.isLightbarTopIndexAnimating = false;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00089CFC File Offset: 0x00087EFC
		private void ScrollingLightbarTopIndexLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)2101673986;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_BD;
				case 1:
					this.StartScrollingAcpLabel(this.LblLightbarTopIndexViewboxValue, this.LightbarTopIndexCanvas, ref this.isLightbarTopIndexAnimating, this.RenderTransformLightbarTopIndexViewbox);
					goto IL_A4;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if ((sender as AcpLabel).ActualWidth > 94.05)
				{
					num = (short)492765184;
					short num3 = num;
					num = (short)2122842113;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_BD;
				IL_A4:
				num = (short)1574371328;
				num2 = (int)((IntPtr)num);
				continue;
				IL_BD:
				num = (short)1005249108;
				short num4 = num;
				num = (short)47112788;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A4;
				default:
					goto IL_F2;
				}
			}
			IL_F2:
			num = (short)1622212608;
			if (num != 0)
			{
			}
			num = (short)1859911681;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00089E38 File Offset: 0x00088038
		private void LightbarLeftFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)1683152121;
			short num2 = num;
			num = (short)604036345;
			switch (num2 == num)
			{
			default:
			{
				num = (short)94306304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)20578305;
			if (num != 0)
			{
			}
			num = (short)1291452416;
			if (num != 0)
			{
			}
			this.isLightbarLeftFeatureAnimating = false;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00089EF0 File Offset: 0x000880F0
		private void ScrollingLightbarLeftFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num = (short)1233780738;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)997916673;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_EA;
				case 1:
					this.StartScrollingAcpLabel(this.LblLightbarLeftActionViewboxValue, this.LightbarLeftFeatureCanvas, ref this.isLightbarLeftFeatureAnimating, this.RenderTransformLightbarLeftFeatureViewbox);
					goto IL_D1;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				}
				IL_5A:
				num = (short)1922564096;
				short num3 = num;
				if ((sender as AcpLabel).ActualWidth > 72.0)
				{
					num = (short)1594753025;
					num2 = (int)((IntPtr)num);
					continue;
				}
				goto IL_EA;
				IL_D1:
				num = (short)1245184;
				num2 = (int)((IntPtr)num);
				continue;
				IL_EA:
				num = (short)161101201;
				short num4 = num;
				num = (short)102249873;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D1;
				default:
					goto IL_11E;
				}
			}
			IL_11E:
			num = (short)1788280832;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0008A034 File Offset: 0x00088234
		private void MouseEnterLightbarFeatureLabel(object sender, MouseEventArgs e)
		{
			short num = (short)560726016;
			short num2 = num;
			num = (short)1765212161;
			if (num != 0)
			{
			}
			AcpLabel acpLabel = sender as AcpLabel;
			if (acpLabel.ActualWidth > 72.0)
			{
				num = (short)1422044217;
				short num3 = num;
				num = (short)1111862329;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1804992512;
					if (num != 0)
					{
					}
					acpLabel.Cursor = Cursors.Hand;
					return;
				}
			}
			acpLabel.Cursor = Cursors.Arrow;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0008A114 File Offset: 0x00088314
		private void LightbarFeatureLabelChanged(object sender, SizeChangedEventArgs e)
		{
			short num = (short)40763392;
			short num2 = num;
			AcpLabel acpLabel = sender as AcpLabel;
			if (acpLabel.ActualWidth < 58.0)
			{
				num = (short)1377370113;
				if (num != 0)
				{
				}
				num = (short)391517306;
				short num3 = num;
				num = (short)582161530;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)881197056;
					if (num != 0)
					{
					}
					Canvas.SetLeft(acpLabel, 10.0);
					return;
				}
			}
			Canvas.SetLeft(acpLabel, 0.0);
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0008A1F8 File Offset: 0x000883F8
		private void LightbarRightFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)962473876;
			short num2 = num;
			num = (short)1505308564;
			switch (num2 == num)
			{
			}
			num = (short)282918912;
			if (num != 0)
			{
			}
			num = (short)1949171712;
			short num3 = num;
			num = (short)2013396993;
			if (num != 0)
			{
			}
			this.isLightbarRightFeatureAnimating = false;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0008A2AC File Offset: 0x000884AC
		private void ScrollingLightbarRightFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num;
			for (;;)
			{
				num = (short)597950465;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_92;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						this.StartScrollingAcpLabel(this.LblLightbarRightActionViewboxValue, this.LightbarRightFeatureCanvas, ref this.isLightbarRightFeatureAnimating, this.RenderTransformLightbarRightFeatureViewbox);
						num = (short)426180608;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_31:
					if ((sender as AcpLabel).ActualWidth <= 72.0)
					{
						return;
					}
					num = (short)939589634;
					num2 = (int)((IntPtr)num);
				}
				IL_92:
				num = (short)1229904456;
				short num3 = num;
				num = (short)75946568;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_C6;
				}
			}
			IL_C6:
			num = (short)1280638977;
			if (num != 0)
			{
			}
			num = (short)663683072;
			if (num != 0)
			{
			}
			num = (short)776273920;
			short num4 = num;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0008A3E8 File Offset: 0x000885E8
		private void LightbarTopFeature_AnimationCompleted(object sender, EventArgs e)
		{
			short num = (short)2043740161;
			if (num != 0)
			{
			}
			num = (short)623990238;
			short num2 = num;
			num = (short)608064990;
			switch (num2 == num)
			{
			}
			num = (short)325582848;
			short num3 = num;
			num = (short)326762496;
			if (num != 0)
			{
			}
			this.isLightbarTopFeatureAnimating = false;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0008A498 File Offset: 0x00088698
		private void ScrollingLightbarTopFeatureLabel(object sender, MouseButtonEventArgs e)
		{
			short num;
			for (;;)
			{
				num = (short)1755447297;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_BC;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						this.StartScrollingAcpLabel(this.LblLightbarTopActionViewboxValue, this.LightbarTopFeatureCanvas, ref this.isLightbarTopFeatureAnimating, this.RenderTransformLightbarTopFeatureViewbox);
						num = (short)383582208;
						num2 = (int)((IntPtr)num);
						continue;
					}
					IL_30:
					num = (short)1096941569;
					if (num != 0)
					{
					}
					if ((sender as AcpLabel).ActualWidth <= 72.0)
					{
						return;
					}
					num = (short)1408565250;
					num2 = (int)((IntPtr)num);
				}
				IL_BC:
				num = (short)90713771;
				short num3 = num;
				num = (short)814886571;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_F0;
				}
			}
			IL_F0:
			num = (short)38010880;
			if (num != 0)
			{
			}
			num = (short)1311899648;
			short num4 = num;
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0008A5D8 File Offset: 0x000887D8
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x0008A690 File Offset: 0x00088890
		public bool BottomButton1FeatureIsAcpValid
		{
			get
			{
				short num = (short)1136475819;
				short num2 = num;
				num = (short)1797471915;
				switch (num2 == num)
				{
				}
				num = (short)456196096;
				if (num != 0)
				{
				}
				num = (short)1829568512;
				short num3 = num;
				num = (short)1345519617;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton1FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)820516198;
				short num2 = num;
				num = (short)522982758;
				switch (num2 == num)
				{
				}
				num = (short)1977876480;
				if (num != 0)
				{
				}
				num = (short)1170014208;
				short num3 = num;
				num = (short)472317953;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton1FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0008A74C File Offset: 0x0008894C
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x0008A804 File Offset: 0x00088A04
		public bool BottomButton1FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1060214665;
				short num2 = num;
				num = (short)1041995657;
				switch (num2 == num)
				{
				}
				num = (short)829816832;
				if (num != 0)
				{
				}
				num = (short)403111936;
				short num3 = num;
				num = (short)1350893569;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton1FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1769225236;
				short num2 = num;
				num = (short)715013140;
				switch (num2 == num)
				{
				}
				num = (short)1565655041;
				if (num != 0)
				{
				}
				num = (short)75956224;
				short num3 = num;
				num = (short)1405812736;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton1FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0008A8BC File Offset: 0x00088ABC
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x0008A974 File Offset: 0x00088B74
		public bool BottomButton1FeatureIsAcpVisible
		{
			get
			{
				short num = (short)905502202;
				short num2 = num;
				num = (short)918347258;
				switch (num2 == num)
				{
				}
				num = (short)1299054593;
				if (num != 0)
				{
				}
				num = (short)1580269568;
				short num3 = num;
				num = (short)1070530560;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton1FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1425731547;
				short num2 = num;
				num = (short)914354139;
				switch (num2 == num)
				{
				}
				num = (short)1636761600;
				if (num != 0)
				{
				}
				num = (short)1617166336;
				short num3 = num;
				num = (short)2078015489;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton1FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0008AA30 File Offset: 0x00088C30
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x0008AAE8 File Offset: 0x00088CE8
		public bool BottomButton1FeatureIsAcpEditable
		{
			get
			{
				short num = (short)2042942593;
				short num2 = num;
				num = (short)1957942401;
				switch (num2 == num)
				{
				}
				num = (short)1555890177;
				if (num != 0)
				{
				}
				num = (short)185729024;
				short num3 = num;
				num = (short)60686336;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton1FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)741415968;
				short num2 = num;
				num = (short)1123949600;
				switch (num2 == num)
				{
				}
				num = (short)1728118785;
				if (num != 0)
				{
				}
				num = (short)1117585408;
				short num3 = num;
				num = (short)885719040;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton1FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0008ABA0 File Offset: 0x00088DA0
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x0008AC5C File Offset: 0x00088E5C
		public string BottomButton1FeatureUIValue
		{
			get
			{
				short num = (short)1076520403;
				short num2 = num;
				num = (short)1104569811;
				switch (num2 == num)
				{
				}
				num = (short)1572077569;
				if (num != 0)
				{
				}
				num = (short)180551680;
				short num3 = num;
				num = (short)154140672;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.BottomButton1FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1984954355;
				short num2 = num;
				num = (short)98762739;
				switch (num2 == num)
				{
				}
				num = (short)166068224;
				if (num != 0)
				{
				}
				num = (short)1514340352;
				short num3 = num;
				num = (short)2135293953;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton1FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0008AD10 File Offset: 0x00088F10
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x0008ADCC File Offset: 0x00088FCC
		public AcpListField BottomButton1FeatureList
		{
			get
			{
				short num = (short)44771732;
				short num2 = num;
				num = (short)2081040788;
				switch (num2 == num)
				{
				}
				num = (short)948109313;
				if (num != 0)
				{
				}
				num = (short)1787494400;
				short num3 = num;
				num = (short)2145386496;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.BottomButton1FeatureListProperty);
			}
			set
			{
				short num = (short)1498458838;
				short num2 = num;
				num = (short)397060822;
				switch (num2 == num)
				{
				}
				num = (short)1128726528;
				if (num != 0)
				{
				}
				num = (short)954793984;
				short num3 = num;
				num = (short)1682243585;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton1FeatureListProperty, value);
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0008AE80 File Offset: 0x00089080
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x0008AF38 File Offset: 0x00089138
		public bool BottomButton1IndexIsAcpValid
		{
			get
			{
				short num = (short)603781452;
				short num2 = num;
				num = (short)967637324;
				switch (num2 == num)
				{
				}
				num = (short)251133952;
				if (num != 0)
				{
				}
				num = (short)94896128;
				short num3 = num;
				num = (short)1620508673;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton1IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)2047898700;
				short num2 = num;
				num = (short)1823241292;
				switch (num2 == num)
				{
				}
				num = (short)1809973248;
				if (num != 0)
				{
				}
				num = (short)1859321856;
				short num3 = num;
				num = (short)1799618561;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton1IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0008AFF4 File Offset: 0x000891F4
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x0008B0AC File Offset: 0x000892AC
		public bool BottomButton1IndexIsAcpApplicable
		{
			get
			{
				short num = (short)578860158;
				short num2 = num;
				num = (short)988918910;
				switch (num2 == num)
				{
				}
				num = (short)35520513;
				if (num != 0)
				{
				}
				num = (short)735576064;
				short num3 = num;
				num = (short)934936576;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton1IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)81856882;
				short num2 = num;
				num = (short)293800306;
				switch (num2 == num)
				{
				}
				num = (short)1235222528;
				if (num != 0)
				{
				}
				num = (short)325976064;
				short num3 = num;
				num = (short)1721368577;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton1IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0008B164 File Offset: 0x00089364
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x0008B220 File Offset: 0x00089420
		public bool BottomButton1IndexIsAcpVisible
		{
			get
			{
				short num = (short)453181441;
				if (num != 0)
				{
				}
				num = (short)1655903208;
				short num2 = num;
				num = (short)84939752;
				switch (num2 == num)
				{
				}
				num = (short)563019776;
				short num3 = num;
				num = (short)2019950592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton1IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)491933719;
				short num2 = num;
				num = (short)374493207;
				switch (num2 == num)
				{
				}
				num = (short)262668288;
				if (num != 0)
				{
				}
				num = (short)121569280;
				short num3 = num;
				num = (short)681705473;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton1IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0008B2D8 File Offset: 0x000894D8
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x0008B390 File Offset: 0x00089590
		public bool BottomButton1IndexIsAcpEditable
		{
			get
			{
				short num = (short)1382963170;
				short num2 = num;
				num = (short)1273780194;
				switch (num2 == num)
				{
				}
				num = (short)1819148289;
				if (num != 0)
				{
				}
				num = (short)603652096;
				short num3 = num;
				num = (short)1097138176;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton1IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2132126920;
				short num2 = num;
				num = (short)153529544;
				switch (num2 == num)
				{
				}
				num = (short)964427776;
				if (num != 0)
				{
				}
				num = (short)430440448;
				short num3 = num;
				num = (short)817233921;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton1IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0008B44C File Offset: 0x0008964C
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0008B508 File Offset: 0x00089708
		public string BottomButton1IndexUIValue
		{
			get
			{
				short num = (short)842408181;
				short num2 = num;
				num = (short)1704141045;
				switch (num2 == num)
				{
				}
				num = (short)1694302209;
				if (num != 0)
				{
				}
				num = (short)802422784;
				short num3 = num;
				num = (short)1114505216;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.BottomButton1IndexUIValueProperty);
			}
			set
			{
				short num = (short)1149726417;
				short num2 = num;
				num = (short)920088273;
				switch (num2 == num)
				{
				}
				num = (short)521404417;
				if (num != 0)
				{
				}
				num = (short)1465319424;
				short num3 = num;
				num = (short)66584576;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton1IndexUIValueProperty, value);
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0008B5BC File Offset: 0x000897BC
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x0008B678 File Offset: 0x00089878
		public AcpRecRefField BottomButton1IndexList
		{
			get
			{
				short num = (short)1440482518;
				short num2 = num;
				num = (short)947258582;
				switch (num2 == num)
				{
				}
				num = (short)595001345;
				if (num != 0)
				{
				}
				num = (short)351010816;
				short num3 = num;
				num = (short)864026624;
				if (num != 0)
				{
				}
				return (AcpRecRefField)base.GetValue(O9GraphicView.BottomButton1IndexListProperty);
			}
			set
			{
				short num = (short)1787515812;
				short num2 = num;
				num = (short)1102533540;
				switch (num2 == num)
				{
				}
				num = (short)1526857729;
				if (num != 0)
				{
				}
				num = (short)91095040;
				short num3 = num;
				num = (short)706805760;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton1IndexListProperty, value);
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0008B730 File Offset: 0x00089930
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x0008B7EC File Offset: 0x000899EC
		public bool BottomButton2FeatureIsAcpValid
		{
			get
			{
				short num = (short)1430411617;
				short num2 = num;
				num = (short)1280006497;
				switch (num2 == num)
				{
				}
				num = (short)417267713;
				if (num != 0)
				{
				}
				num = (short)648740864;
				short num3 = num;
				num = (short)1952251904;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton2FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1192755201;
				if (num != 0)
				{
				}
				num = (short)317815486;
				short num2 = num;
				num = (short)1905228478;
				switch (num2 == num)
				{
				}
				num = (short)1031274496;
				short num3 = num;
				num = (short)1462501376;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton2FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0008B8A4 File Offset: 0x00089AA4
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x0008B95C File Offset: 0x00089B5C
		public bool BottomButton2FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)531556158;
				short num2 = num;
				num = (short)1870653246;
				switch (num2 == num)
				{
				}
				num = (short)2094530560;
				if (num != 0)
				{
				}
				num = (short)1199308800;
				short num3 = num;
				num = (short)995229697;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton2FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)254935041;
				if (num != 0)
				{
				}
				num = (short)1365566876;
				short num2 = num;
				num = (short)778102172;
				switch (num2 == num)
				{
				}
				num = (short)2071265280;
				short num3 = num;
				num = (short)2025324544;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton2FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x0008BA14 File Offset: 0x00089C14
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x0008BACC File Offset: 0x00089CCC
		public bool BottomButton2FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1604190812;
				short num2 = num;
				num = (short)1034682972;
				switch (num2 == num)
				{
				}
				num = (short)2114650112;
				if (num != 0)
				{
				}
				num = (short)1568538624;
				short num3 = num;
				num = (short)316407809;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton2FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)384368641;
				if (num != 0)
				{
				}
				num = (short)1372123726;
				short num2 = num;
				num = (short)2486862;
				switch (num2 == num)
				{
				}
				num = (short)1637482496;
				short num3 = num;
				num = (short)1677590528;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton2FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0008BB88 File Offset: 0x00089D88
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x0008BC40 File Offset: 0x00089E40
		public bool BottomButton2FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1865721475;
				short num2 = num;
				num = (short)1399039619;
				switch (num2 == num)
				{
				}
				num = (short)1060569089;
				if (num != 0)
				{
				}
				num = (short)1366491136;
				short num3 = num;
				num = (short)218759168;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton2FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)21392123;
				short num2 = num;
				num = (short)1325558523;
				switch (num2 == num)
				{
				}
				num = (short)379977729;
				if (num != 0)
				{
				}
				num = (short)645726208;
				short num3 = num;
				num = (short)480706560;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton2FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0008BCFC File Offset: 0x00089EFC
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x0008BDB4 File Offset: 0x00089FB4
		public string BottomButton2FeatureUIValue
		{
			get
			{
				short num = (short)2086926837;
				short num2 = num;
				num = (short)32438773;
				switch (num2 == num)
				{
				}
				num = (short)152371201;
				if (num != 0)
				{
				}
				num = (short)739442688;
				short num3 = num;
				num = (short)324861952;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.BottomButton2FeatureUIValueProperty);
			}
			set
			{
				short num = (short)563546960;
				short num2 = num;
				num = (short)1138953040;
				switch (num2 == num)
				{
				}
				num = (short)1617887232;
				if (num != 0)
				{
				}
				num = (short)977076224;
				short num3 = num;
				num = (short)1067057153;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton2FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0008BE68 File Offset: 0x0008A068
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x0008BF24 File Offset: 0x0008A124
		public AcpListField BottomButton2FeatureList
		{
			get
			{
				short num = (short)503324175;
				short num2 = num;
				num = (short)1772887567;
				switch (num2 == num)
				{
				}
				num = (short)688979969;
				if (num != 0)
				{
				}
				num = (short)1553465344;
				short num3 = num;
				num = (short)1892286464;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.BottomButton2FeatureListProperty);
			}
			set
			{
				short num = (short)1703708718;
				short num2 = num;
				num = (short)762742830;
				switch (num2 == num)
				{
				}
				num = (short)1519190016;
				if (num != 0)
				{
				}
				num = (short)185270272;
				short num3 = num;
				num = (short)46006273;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton2FeatureListProperty, value);
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x0008BFD8 File Offset: 0x0008A1D8
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x0008C094 File Offset: 0x0008A294
		public bool BottomButton2IndexIsAcpValid
		{
			get
			{
				short num = (short)2098755284;
				short num2 = num;
				num = (short)2064348884;
				switch (num2 == num)
				{
				}
				num = (short)883163136;
				if (num != 0)
				{
				}
				num = (short)2005925888;
				short num3 = num;
				num = (short)160169985;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton2IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)778338265;
				short num2 = num;
				num = (short)109871065;
				switch (num2 == num)
				{
				}
				num = (short)861667329;
				if (num != 0)
				{
				}
				num = (short)1440088064;
				short num3 = num;
				num = (short)1061552128;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton2IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0008C150 File Offset: 0x0008A350
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x0008C20C File Offset: 0x0008A40C
		public bool BottomButton2IndexIsAcpApplicable
		{
			get
			{
				short num = (short)2081882113;
				if (num != 0)
				{
				}
				num = (short)1318394736;
				short num2 = num;
				num = (short)231414640;
				switch (num2 == num)
				{
				}
				num = (short)953942016;
				short num3 = num;
				num = (short)102957056;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton2IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1985701352;
				short num2 = num;
				num = (short)1384539624;
				switch (num2 == num)
				{
				}
				num = (short)1188560897;
				if (num != 0)
				{
				}
				num = (short)781254656;
				short num3 = num;
				num = (short)906100736;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton2IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0008C2C4 File Offset: 0x0008A4C4
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x0008C37C File Offset: 0x0008A57C
		public bool BottomButton2IndexIsAcpVisible
		{
			get
			{
				short num = (short)478331614;
				short num2 = num;
				num = (short)870433502;
				switch (num2 == num)
				{
				}
				num = (short)2082930688;
				if (num != 0)
				{
				}
				num = (short)1301020672;
				short num3 = num;
				num = (short)62849025;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton2IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1451385137;
				short num2 = num;
				num = (short)1734959409;
				switch (num2 == num)
				{
				}
				num = (short)122093569;
				if (num != 0)
				{
				}
				num = (short)1072889856;
				short num3 = num;
				num = (short)999620608;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton2IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0008C434 File Offset: 0x0008A634
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x0008C4EC File Offset: 0x0008A6EC
		public bool BottomButton2IndexIsAcpEditable
		{
			get
			{
				short num = (short)1190491178;
				short num2 = num;
				num = (short)1614640170;
				switch (num2 == num)
				{
				}
				num = (short)950534144;
				if (num != 0)
				{
				}
				num = (short)2078081024;
				short num3 = num;
				num = (short)63307777;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton2IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)792592385;
				if (num != 0)
				{
				}
				num = (short)10235348;
				short num2 = num;
				num = (short)924462548;
				switch (num2 == num)
				{
				}
				num = (short)893714432;
				short num3 = num;
				num = (short)1787756544;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton2IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0008C5A8 File Offset: 0x0008A7A8
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x0008C660 File Offset: 0x0008A860
		public string BottomButton2IndexUIValue
		{
			get
			{
				short num = (short)1121954207;
				short num2 = num;
				num = (short)446933407;
				switch (num2 == num)
				{
				}
				num = (short)2021392384;
				if (num != 0)
				{
				}
				num = (short)1221591040;
				short num3 = num;
				num = (short)1372454913;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.BottomButton2IndexUIValueProperty);
			}
			set
			{
				short num = (short)1664404908;
				short num2 = num;
				num = (short)1702415788;
				switch (num2 == num)
				{
				}
				num = (short)1369702401;
				if (num != 0)
				{
				}
				num = (short)477888512;
				short num3 = num;
				num = (short)1473052672;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton2IndexUIValueProperty, value);
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0008C718 File Offset: 0x0008A918
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x0008C7D0 File Offset: 0x0008A9D0
		public AcpListField BottomButton2IndexList
		{
			get
			{
				short num = (short)1970143233;
				if (num != 0)
				{
				}
				num = (short)1688070408;
				short num2 = num;
				num = (short)466217224;
				switch (num2 == num)
				{
				}
				num = (short)1746599936;
				short num3 = num;
				num = (short)1102381056;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.BottomButton2IndexListProperty);
			}
			set
			{
				short num = (short)1930258605;
				short num2 = num;
				num = (short)1303734445;
				switch (num2 == num)
				{
				}
				num = (short)1404633088;
				if (num != 0)
				{
				}
				num = (short)1600913409;
				if (num != 0)
				{
				}
				num = (short)374996992;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton2IndexListProperty, value);
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x0008C884 File Offset: 0x0008AA84
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x0008C940 File Offset: 0x0008AB40
		public bool BottomButton3FeatureIsAcpValid
		{
			get
			{
				short num = (short)1073447186;
				short num2 = num;
				num = (short)1757249810;
				switch (num2 == num)
				{
				}
				num = (short)822870016;
				if (num != 0)
				{
				}
				num = (short)15400961;
				if (num != 0)
				{
				}
				num = (short)669581312;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton3FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1653711559;
				short num2 = num;
				num = (short)337814215;
				switch (num2 == num)
				{
				}
				num = (short)1120010241;
				if (num != 0)
				{
				}
				num = (short)454885376;
				if (num != 0)
				{
				}
				num = (short)1244856320;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton3FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x0008C9F8 File Offset: 0x0008ABF8
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x0008CAB0 File Offset: 0x0008ACB0
		public bool BottomButton3FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)752025601;
				if (num != 0)
				{
				}
				num = (short)588906642;
				short num2 = num;
				num = (short)1833435282;
				switch (num2 == num)
				{
				}
				num = (short)1223491584;
				if (num != 0)
				{
				}
				num = (short)1789001728;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton3FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)273801084;
				short num2 = num;
				num = (short)2079842172;
				switch (num2 == num)
				{
				}
				num = (short)443940864;
				if (num != 0)
				{
				}
				num = (short)1125384193;
				if (num != 0)
				{
				}
				num = (short)473432064;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton3FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0008CB6C File Offset: 0x0008AD6C
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x0008CC28 File Offset: 0x0008AE28
		public bool BottomButton3FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1578664550;
				short num2 = num;
				num = (short)325354086;
				switch (num2 == num)
				{
				}
				num = (short)1371930625;
				if (num != 0)
				{
				}
				num = (short)1341194240;
				if (num != 0)
				{
				}
				num = (short)1246494720;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton3FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1945676054;
				short num2 = num;
				num = (short)1594272022;
				switch (num2 == num)
				{
				}
				num = (short)1112342529;
				if (num != 0)
				{
				}
				num = (short)50331648;
				if (num != 0)
				{
				}
				num = (short)1023213568;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton3FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0008CCE4 File Offset: 0x0008AEE4
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x0008CD9C File Offset: 0x0008AF9C
		public bool BottomButton3FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1540361653;
				short num2 = num;
				num = (short)2004356533;
				switch (num2 == num)
				{
				}
				num = (short)744554497;
				if (num != 0)
				{
				}
				num = (short)445513728;
				if (num != 0)
				{
				}
				num = (short)2110193664;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton3FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1144901593;
				short num2 = num;
				num = (short)1486409689;
				switch (num2 == num)
				{
				}
				num = (short)28639233;
				if (num != 0)
				{
				}
				num = (short)302776320;
				if (num != 0)
				{
				}
				num = (short)1137508352;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton3FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0008CE5C File Offset: 0x0008B05C
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x0008CF18 File Offset: 0x0008B118
		public string BottomButton3FeatureUIValue
		{
			get
			{
				short num = (short)516034704;
				short num2 = num;
				num = (short)209522832;
				switch (num2 == num)
				{
				}
				num = (short)123142145;
				if (num != 0)
				{
				}
				num = (short)1206648832;
				if (num != 0)
				{
				}
				num = (short)652148736;
				short num3 = num;
				return (string)base.GetValue(O9GraphicView.BottomButton3FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1762345956;
				short num2 = num;
				num = (short)132465636;
				switch (num2 == num)
				{
				}
				num = (short)1529937921;
				if (num != 0)
				{
				}
				num = (short)519307264;
				if (num != 0)
				{
				}
				num = (short)2115829760;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton3FeatureUIValueProperty, value);
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0008CFCC File Offset: 0x0008B1CC
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x0008D088 File Offset: 0x0008B288
		public AcpListField BottomButton3FeatureList
		{
			get
			{
				short num = (short)1536877235;
				short num2 = num;
				num = (short)382198451;
				switch (num2 == num)
				{
				}
				num = (short)731119617;
				if (num != 0)
				{
				}
				num = (short)1979711488;
				if (num != 0)
				{
				}
				num = (short)1422524416;
				short num3 = num;
				return (AcpListField)base.GetValue(O9GraphicView.BottomButton3FeatureListProperty);
			}
			set
			{
				short num = (short)1614111547;
				short num2 = num;
				num = (short)1123967803;
				switch (num2 == num)
				{
				}
				num = (short)892010497;
				if (num != 0)
				{
				}
				num = (short)109838336;
				if (num != 0)
				{
				}
				num = (short)1710686208;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton3FeatureListProperty, value);
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x0008D13C File Offset: 0x0008B33C
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x0008D1F4 File Offset: 0x0008B3F4
		public bool BottomButton3IndexIsAcpValid
		{
			get
			{
				short num = (short)2021591196;
				short num2 = num;
				num = (short)1113458844;
				switch (num2 == num)
				{
				}
				num = (short)1776680960;
				if (num != 0)
				{
				}
				num = (short)974192641;
				if (num != 0)
				{
				}
				num = (short)1792409600;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton3IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1675423460;
				short num2 = num;
				num = (short)1223028452;
				switch (num2 == num)
				{
				}
				num = (short)1730347009;
				if (num != 0)
				{
				}
				num = (short)848691200;
				if (num != 0)
				{
				}
				num = (short)2019950592;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton3IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0008D2B0 File Offset: 0x0008B4B0
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x0008D368 File Offset: 0x0008B568
		public bool BottomButton3IndexIsAcpApplicable
		{
			get
			{
				short num = (short)917051844;
				short num2 = num;
				num = (short)727062980;
				switch (num2 == num)
				{
				}
				num = (short)2105999360;
				if (num != 0)
				{
				}
				num = (short)123469825;
				if (num != 0)
				{
				}
				num = (short)836501504;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton3IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1346007941;
				short num2 = num;
				num = (short)946369413;
				switch (num2 == num)
				{
				}
				num = (short)1521876993;
				if (num != 0)
				{
				}
				num = (short)1353383936;
				if (num != 0)
				{
				}
				num = (short)2065170432;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton3IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0008D420 File Offset: 0x0008B620
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x0008D4DC File Offset: 0x0008B6DC
		public bool BottomButton3IndexIsAcpVisible
		{
			get
			{
				short num = (short)1281775983;
				short num2 = num;
				num = (short)1211586927;
				switch (num2 == num)
				{
				}
				num = (short)162463745;
				if (num != 0)
				{
				}
				num = (short)922746880;
				if (num != 0)
				{
				}
				num = (short)1466630144;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton3IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2100936345;
				short num2 = num;
				num = (short)648330905;
				switch (num2 == num)
				{
				}
				num = (short)2069692416;
				if (num != 0)
				{
				}
				num = (short)265224193;
				if (num != 0)
				{
				}
				num = (short)395051008;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton3IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0008D598 File Offset: 0x0008B798
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x0008D654 File Offset: 0x0008B854
		public bool BottomButton3IndexIsAcpEditable
		{
			get
			{
				short num = (short)23441633;
				short num2 = num;
				num = (short)1511829729;
				switch (num2 == num)
				{
				}
				num = (short)1940783105;
				if (num != 0)
				{
				}
				num = (short)386400256;
				if (num != 0)
				{
				}
				num = (short)764018688;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton3IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1305608193;
				if (num != 0)
				{
				}
				num = (short)410054139;
				short num2 = num;
				num = (short)469167611;
				switch (num2 == num)
				{
				}
				num = (short)793640960;
				if (num != 0)
				{
				}
				num = (short)548208640;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton3IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0008D70C File Offset: 0x0008B90C
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x0008D7C4 File Offset: 0x0008B9C4
		public string BottomButton3IndexUIValue
		{
			get
			{
				short num = (short)1580815932;
				short num2 = num;
				num = (short)636835388;
				switch (num2 == num)
				{
				}
				num = (short)337510401;
				if (num != 0)
				{
				}
				num = (short)751828992;
				if (num != 0)
				{
				}
				num = (short)846921728;
				short num3 = num;
				return (string)base.GetValue(O9GraphicView.BottomButton3IndexUIValueProperty);
			}
			set
			{
				short num = (short)2100440143;
				short num2 = num;
				num = (short)108145743;
				switch (num2 == num)
				{
				}
				num = (short)246677505;
				if (num != 0)
				{
				}
				num = (short)397017088;
				if (num != 0)
				{
				}
				num = (short)2044592128;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton3IndexUIValueProperty, value);
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0008D878 File Offset: 0x0008BA78
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x0008D930 File Offset: 0x0008BB30
		public AcpListField BottomButton3IndexList
		{
			get
			{
				short num = (short)117609117;
				short num2 = num;
				num = (short)613585565;
				switch (num2 == num)
				{
				}
				num = (short)508428288;
				if (num != 0)
				{
				}
				num = (short)686424065;
				if (num != 0)
				{
				}
				num = (short)1539440640;
				short num3 = num;
				return (AcpListField)base.GetValue(O9GraphicView.BottomButton3IndexListProperty);
			}
			set
			{
				short num = (short)2004587535;
				short num2 = num;
				num = (short)1948685327;
				switch (num2 == num)
				{
				}
				num = (short)423493633;
				if (num != 0)
				{
				}
				num = (short)1669660672;
				if (num != 0)
				{
				}
				num = (short)1483407360;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton3IndexListProperty, value);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0008D9E4 File Offset: 0x0008BBE4
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x0008DA9C File Offset: 0x0008BC9C
		public bool BottomButton4FeatureIsAcpValid
		{
			get
			{
				short num = (short)847656102;
				short num2 = num;
				num = (short)460797094;
				switch (num2 == num)
				{
				}
				num = (short)1069350912;
				if (num != 0)
				{
				}
				num = (short)301793281;
				if (num != 0)
				{
				}
				num = (short)1109983232;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton4FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)491385338;
				short num2 = num;
				num = (short)1319629306;
				switch (num2 == num)
				{
				}
				num = (short)232849409;
				if (num != 0)
				{
				}
				num = (short)459145216;
				if (num != 0)
				{
				}
				num = (short)913702912;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton4FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0008DB58 File Offset: 0x0008BD58
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x0008DC14 File Offset: 0x0008BE14
		public bool BottomButton4FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1553924097;
				if (num != 0)
				{
				}
				num = (short)1874586089;
				short num2 = num;
				num = (short)1621551593;
				switch (num2 == num)
				{
				}
				num = (short)2080833536;
				if (num != 0)
				{
				}
				num = (short)1246691328;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton4FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)165461956;
				short num2 = num;
				num = (short)1536475076;
				switch (num2 == num)
				{
				}
				num = (short)1639120897;
				if (num != 0)
				{
				}
				num = (short)384565248;
				if (num != 0)
				{
				}
				num = (short)276430848;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton4FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0008DCD0 File Offset: 0x0008BED0
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x0008DD88 File Offset: 0x0008BF88
		public bool BottomButton4FeatureIsAcpVisible
		{
			get
			{
				short num = (short)2146630311;
				short num2 = num;
				num = (short)1710815911;
				switch (num2 == num)
				{
				}
				num = (short)388628480;
				if (num != 0)
				{
				}
				num = (short)1511194625;
				if (num != 0)
				{
				}
				num = (short)1472004096;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton4FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1215289089;
				short num2 = num;
				num = (short)39180033;
				switch (num2 == num)
				{
				}
				num = (short)905969665;
				if (num != 0)
				{
				}
				num = (short)595066880;
				if (num != 0)
				{
				}
				num = (short)1608187904;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton4FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0008DE40 File Offset: 0x0008C040
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x0008DEFC File Offset: 0x0008C0FC
		public bool BottomButton4FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1592306181;
				short num2 = num;
				num = (short)131115525;
				switch (num2 == num)
				{
				}
				num = (short)58589185;
				if (num != 0)
				{
				}
				num = (short)22413312;
				if (num != 0)
				{
				}
				num = (short)1184759808;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton4FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1548848053;
				short num2 = num;
				num = (short)884902837;
				switch (num2 == num)
				{
				}
				num = (short)1949106177;
				if (num != 0)
				{
				}
				num = (short)1769668608;
				if (num != 0)
				{
				}
				num = (short)732037120;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton4FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0008DFB4 File Offset: 0x0008C1B4
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x0008E070 File Offset: 0x0008C270
		public string BottomButton4FeatureUIValue
		{
			get
			{
				short num = (short)66752950;
				short num2 = num;
				num = (short)1687392694;
				switch (num2 == num)
				{
				}
				num = (short)27787264;
				if (num != 0)
				{
				}
				num = (short)374079489;
				if (num != 0)
				{
				}
				num = (short)809107456;
				short num3 = num;
				return (string)base.GetValue(O9GraphicView.BottomButton4FeatureUIValueProperty);
			}
			set
			{
				short num = (short)691994625;
				if (num != 0)
				{
				}
				num = (short)1308524177;
				short num2 = num;
				num = (short)919699089;
				switch (num2 == num)
				{
				}
				num = (short)690094080;
				if (num != 0)
				{
				}
				num = (short)2000420864;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton4FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0008E128 File Offset: 0x0008C328
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x0008E1E0 File Offset: 0x0008C3E0
		public AcpListField BottomButton4FeatureList
		{
			get
			{
				short num = (short)88302729;
				short num2 = num;
				num = (short)1682990217;
				switch (num2 == num)
				{
				}
				num = (short)1660616705;
				if (num != 0)
				{
				}
				num = (short)1955201024;
				if (num != 0)
				{
				}
				num = (short)286523392;
				short num3 = num;
				return (AcpListField)base.GetValue(O9GraphicView.BottomButton4FeatureListProperty);
			}
			set
			{
				short num = (short)1384865685;
				short num2 = num;
				num = (short)1007378325;
				switch (num2 == num)
				{
				}
				num = (short)1272446977;
				if (num != 0)
				{
				}
				num = (short)526712832;
				if (num != 0)
				{
				}
				num = (short)289144832;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton4FeatureListProperty, value);
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0008E294 File Offset: 0x0008C494
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x0008E34C File Offset: 0x0008C54C
		public bool BottomButton4IndexIsAcpValid
		{
			get
			{
				short num = (short)126480827;
				short num2 = num;
				num = (short)352973243;
				switch (num2 == num)
				{
				}
				num = (short)23068672;
				if (num != 0)
				{
				}
				num = (short)1928658945;
				if (num != 0)
				{
				}
				num = (short)795148288;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton4IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1657128711;
				short num2 = num;
				num = (short)940164871;
				switch (num2 == num)
				{
				}
				num = (short)369295361;
				if (num != 0)
				{
				}
				num = (short)797442048;
				if (num != 0)
				{
				}
				num = (short)1683685376;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton4IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x0008E408 File Offset: 0x0008C608
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x0008E4C0 File Offset: 0x0008C6C0
		public bool BottomButton4IndexIsAcpApplicable
		{
			get
			{
				short num = (short)386132117;
				short num2 = num;
				num = (short)999418005;
				switch (num2 == num)
				{
				}
				num = (short)560857088;
				if (num != 0)
				{
				}
				num = (short)1170014209;
				if (num != 0)
				{
				}
				num = (short)195428352;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton4IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1106858206;
				short num2 = num;
				num = (short)1922453726;
				switch (num2 == num)
				{
				}
				num = (short)1015808001;
				if (num != 0)
				{
				}
				num = (short)1589248000;
				if (num != 0)
				{
				}
				num = (short)287506432;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton4IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x0008E578 File Offset: 0x0008C778
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x0008E630 File Offset: 0x0008C830
		public bool BottomButton4IndexIsAcpVisible
		{
			get
			{
				short num = (short)1662778778;
				short num2 = num;
				num = (short)2080963994;
				switch (num2 == num)
				{
				}
				num = (short)1813381121;
				if (num != 0)
				{
				}
				num = (short)586874880;
				if (num != 0)
				{
				}
				num = (short)456589312;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton4IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1087065654;
				short num2 = num;
				num = (short)1789677110;
				switch (num2 == num)
				{
				}
				num = (short)261488641;
				if (num != 0)
				{
				}
				num = (short)2036989952;
				if (num != 0)
				{
				}
				num = (short)1982529536;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton4IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x0008E6E8 File Offset: 0x0008C8E8
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x0008E7A4 File Offset: 0x0008C9A4
		public bool BottomButton4IndexIsAcpEditable
		{
			get
			{
				short num = (short)1045854110;
				short num2 = num;
				num = (short)1591244702;
				switch (num2 == num)
				{
				}
				num = (short)1114374145;
				if (num != 0)
				{
				}
				num = (short)252772352;
				if (num != 0)
				{
				}
				num = (short)1271463936;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.BottomButton4IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)88617711;
				short num2 = num;
				num = (short)1238971119;
				switch (num2 == num)
				{
				}
				num = (short)1297678337;
				if (num != 0)
				{
				}
				num = (short)1312751616;
				if (num != 0)
				{
				}
				num = (short)580190208;
				short num3 = num;
				base.SetValue(O9GraphicView.BottomButton4IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x0008E860 File Offset: 0x0008CA60
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x0008E91C File Offset: 0x0008CB1C
		public string BottomButton4IndexUIValue
		{
			get
			{
				short num = (short)1820106021;
				short num2 = num;
				num = (short)1801166117;
				switch (num2 == num)
				{
				}
				num = (short)983236608;
				short num3 = num;
				num = (short)19595265;
				if (num != 0)
				{
				}
				num = (short)1482883072;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.BottomButton4IndexUIValueProperty);
			}
			set
			{
				short num = (short)2041559092;
				short num2 = num;
				num = (short)1775941684;
				switch (num2 == num)
				{
				}
				num = (short)553713664;
				short num3 = num;
				num = (short)1364656128;
				if (num != 0)
				{
				}
				num = (short)1928462337;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton4IndexUIValueProperty, value);
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x0008E9D4 File Offset: 0x0008CBD4
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x0008EA8C File Offset: 0x0008CC8C
		public AcpListField BottomButton4IndexList
		{
			get
			{
				short num = (short)454188363;
				short num2 = num;
				num = (short)97606987;
				switch (num2 == num)
				{
				}
				num = (short)1689976832;
				short num3 = num;
				num = (short)1761083393;
				if (num != 0)
				{
				}
				num = (short)1352466432;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.BottomButton4IndexListProperty);
			}
			set
			{
				short num = (short)1069929465;
				short num2 = num;
				num = (short)276091897;
				switch (num2 == num)
				{
				}
				num = (short)1882193920;
				short num3 = num;
				num = (short)500367361;
				if (num != 0)
				{
				}
				num = (short)1945305088;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton4IndexListProperty, value);
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x0008EB44 File Offset: 0x0008CD44
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x0008EBFC File Offset: 0x0008CDFC
		public bool BottomButton5FeatureIsAcpValid
		{
			get
			{
				short num = (short)95766381;
				short num2 = num;
				num = (short)836323181;
				switch (num2 == num)
				{
				}
				num = (short)1681784832;
				short num3 = num;
				num = (short)1824522241;
				if (num != 0)
				{
				}
				num = (short)962134016;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton5FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)908918948;
				short num2 = num;
				num = (short)419430564;
				switch (num2 == num)
				{
				}
				num = (short)201261056;
				short num3 = num;
				num = (short)1475215361;
				if (num != 0)
				{
				}
				num = (short)711852032;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton5FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x0008ECB4 File Offset: 0x0008CEB4
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x0008ED6C File Offset: 0x0008CF6C
		public bool BottomButton5FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1506006117;
				short num2 = num;
				num = (short)504288357;
				switch (num2 == num)
				{
				}
				num = (short)1597374464;
				short num3 = num;
				num = (short)97779713;
				if (num != 0)
				{
				}
				num = (short)141164544;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton5FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)862382854;
				short num2 = num;
				num = (short)1760029446;
				switch (num2 == num)
				{
				}
				num = (short)145686528;
				short num3 = num;
				num = (short)362348544;
				if (num != 0)
				{
				}
				num = (short)617545729;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton5FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0008EE28 File Offset: 0x0008D028
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x0008EEE0 File Offset: 0x0008D0E0
		public bool BottomButton5FeatureIsAcpVisible
		{
			get
			{
				short num = (short)384179403;
				short num2 = num;
				num = (short)425532619;
				switch (num2 == num)
				{
				}
				num = (short)1902968832;
				short num3 = num;
				num = (short)1048051713;
				if (num != 0)
				{
				}
				num = (short)964755456;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton5FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)512490252;
				short num2 = num;
				num = (short)829553420;
				switch (num2 == num)
				{
				}
				num = (short)2137128960;
				short num3 = num;
				num = (short)2100690944;
				if (num != 0)
				{
				}
				num = (short)151519233;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton5FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x0008EF98 File Offset: 0x0008D198
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x0008F050 File Offset: 0x0008D250
		public bool BottomButton5FeatureIsAcpEditable
		{
			get
			{
				short num = (short)790106736;
				short num2 = num;
				num = (short)1847005808;
				switch (num2 == num)
				{
				}
				num = (short)2061565952;
				short num3 = num;
				num = (short)1026621441;
				if (num != 0)
				{
				}
				num = (short)1046872064;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton5FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)794951681;
				if (num != 0)
				{
				}
				num = (short)1058428098;
				short num2 = num;
				num = (short)2115523778;
				switch (num2 == num)
				{
				default:
				{
					num = (short)63504384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)43581440;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton5FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x0008F10C File Offset: 0x0008D30C
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x0008F1C4 File Offset: 0x0008D3C4
		public string BottomButton5FeatureUIValue
		{
			get
			{
				short num = (short)610144297;
				short num2 = num;
				num = (short)1483411497;
				switch (num2 == num)
				{
				}
				num = (short)1483276288;
				short num3 = num;
				num = (short)400097281;
				if (num != 0)
				{
				}
				num = (short)588382208;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.BottomButton5FeatureUIValueProperty);
			}
			set
			{
				short num = (short)2026400899;
				short num2 = num;
				num = (short)1897229443;
				switch (num2 == num)
				{
				}
				num = (short)649592832;
				short num3 = num;
				num = (short)700776448;
				if (num != 0)
				{
				}
				num = (short)21364737;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton5FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x0008F278 File Offset: 0x0008D478
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x0008F330 File Offset: 0x0008D530
		public AcpListField BottomButton5FeatureList
		{
			get
			{
				short num = (short)1423551189;
				short num2 = num;
				num = (short)177384149;
				switch (num2 == num)
				{
				}
				num = (short)795475968;
				short num3 = num;
				num = (short)1049755648;
				if (num != 0)
				{
				}
				num = (short)2069889025;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.BottomButton5FeatureListProperty);
			}
			set
			{
				short num = (short)1175556204;
				short num2 = num;
				num = (short)2121306220;
				switch (num2 == num)
				{
				}
				num = (short)584450048;
				short num3 = num;
				num = (short)1611726848;
				if (num != 0)
				{
				}
				num = (short)1403453441;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton5FeatureListProperty, value);
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0008F3E4 File Offset: 0x0008D5E4
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x0008F4A0 File Offset: 0x0008D6A0
		public bool BottomButton5IndexIsAcpValid
		{
			get
			{
				short num = (short)1857863468;
				short num2 = num;
				num = (short)123387692;
				switch (num2 == num)
				{
				}
				num = (short)2110062592;
				short num3 = num;
				num = (short)111804417;
				if (num != 0)
				{
				}
				num = (short)1679884288;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton5IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)290082289;
				short num2 = num;
				num = (short)863325681;
				switch (num2 == num)
				{
				}
				num = (short)375062528;
				short num3 = num;
				num = (short)1201209345;
				if (num != 0)
				{
				}
				num = (short)1850933248;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton5IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0008F55C File Offset: 0x0008D75C
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x0008F618 File Offset: 0x0008D818
		public bool BottomButton5IndexIsAcpApplicable
		{
			get
			{
				short num = (short)989582641;
				short num2 = num;
				num = (short)76993841;
				switch (num2 == num)
				{
				}
				num = (short)1576140800;
				short num3 = num;
				num = (short)1691680769;
				if (num != 0)
				{
				}
				num = (short)1027538944;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton5IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)132659599;
				short num2 = num;
				num = (short)240990607;
				switch (num2 == num)
				{
				}
				num = (short)401145856;
				short num3 = num;
				num = (short)462356481;
				if (num != 0)
				{
				}
				num = (short)87949312;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton5IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x0008F6D4 File Offset: 0x0008D8D4
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x0008F78C File Offset: 0x0008D98C
		public bool BottomButton5IndexIsAcpVisible
		{
			get
			{
				short num = (short)1978571231;
				short num2 = num;
				num = (short)1437899231;
				switch (num2 == num)
				{
				}
				num = (short)763166720;
				short num3 = num;
				num = (short)172294145;
				if (num != 0)
				{
				}
				num = (short)1998585856;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton5IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)9197309;
				short num2 = num;
				num = (short)1198675709;
				switch (num2 == num)
				{
				}
				num = (short)1059782656;
				short num3 = num;
				num = (short)420675584;
				if (num != 0)
				{
				}
				num = (short)119930881;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton5IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0008F844 File Offset: 0x0008DA44
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x0008F8FC File Offset: 0x0008DAFC
		public bool BottomButton5IndexIsAcpEditable
		{
			get
			{
				short num = (short)1637405061;
				short num2 = num;
				num = (short)1333776773;
				switch (num2 == num)
				{
				}
				num = (short)1235156992;
				short num3 = num;
				num = (short)1769013249;
				if (num != 0)
				{
				}
				num = (short)365166592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.BottomButton5IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)638224907;
				short num2 = num;
				num = (short)410225163;
				switch (num2 == num)
				{
				}
				num = (short)2072772608;
				short num3 = num;
				num = (short)929824768;
				if (num != 0)
				{
				}
				num = (short)1255276545;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton5IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0008F9B8 File Offset: 0x0008DBB8
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x0008FA74 File Offset: 0x0008DC74
		public string BottomButton5IndexUIValue
		{
			get
			{
				short num = (short)878807642;
				short num2 = num;
				num = (short)1762495066;
				switch (num2 == num)
				{
				}
				num = (short)1700855808;
				short num3 = num;
				num = (short)1158610945;
				if (num != 0)
				{
				}
				num = (short)805109760;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.BottomButton5IndexUIValueProperty);
			}
			set
			{
				short num = (short)1474935342;
				short num2 = num;
				num = (short)1200208430;
				switch (num2 == num)
				{
				}
				num = (short)216793088;
				short num3 = num;
				num = (short)428998657;
				if (num != 0)
				{
				}
				num = (short)2042363904;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton5IndexUIValueProperty, value);
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0008FB28 File Offset: 0x0008DD28
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x0008FBE4 File Offset: 0x0008DDE4
		public AcpListField BottomButton5IndexList
		{
			get
			{
				short num = (short)345670089;
				short num2 = num;
				num = (short)123503049;
				switch (num2 == num)
				{
				}
				num = (short)1557397504;
				short num3 = num;
				num = (short)2079522817;
				if (num != 0)
				{
				}
				num = (short)922484736;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.BottomButton5IndexListProperty);
			}
			set
			{
				short num = (short)2097255015;
				short num2 = num;
				num = (short)92705383;
				switch (num2 == num)
				{
				}
				num = (short)852819968;
				short num3 = num;
				num = (short)1054736384;
				if (num != 0)
				{
				}
				num = (short)1822752769;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.BottomButton5IndexListProperty, value);
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0008FC98 File Offset: 0x0008DE98
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x0008FD54 File Offset: 0x0008DF54
		public string TopButton1LabelLine1Value
		{
			get
			{
				short num = (short)127598593;
				if (num != 0)
				{
				}
				num = (short)1875564036;
				short num2 = num;
				num = (short)1080940036;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2035023872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2004418560;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton1LabelLine1ValueProperty);
			}
			set
			{
				short num = (short)1848991746;
				short num2 = num;
				num = (short)1213292546;
				switch (num2 == num)
				{
				}
				num = (short)705626112;
				short num3 = num;
				num = (short)909770753;
				if (num != 0)
				{
				}
				num = (short)1468137472;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1LabelLine1ValueProperty, value);
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0008FE0C File Offset: 0x0008E00C
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x0008FEC4 File Offset: 0x0008E0C4
		public bool TopButton1LabelLine1IsAcpValid
		{
			get
			{
				short num = (short)1633284192;
				short num2 = num;
				num = (short)1486549088;
				switch (num2 == num)
				{
				}
				num = (short)1859190784;
				short num3 = num;
				num = (short)392101888;
				if (num != 0)
				{
				}
				num = (short)956563457;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1LabelLine1IsAcpValidProperty);
			}
			set
			{
				short num = (short)544344070;
				short num2 = num;
				num = (short)941688838;
				switch (num2 == num)
				{
				}
				num = (short)1111818240;
				short num3 = num;
				num = (short)604110848;
				if (num != 0)
				{
				}
				num = (short)136904705;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1LabelLine1IsAcpValidProperty, value);
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0008FF7C File Offset: 0x0008E17C
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x00090038 File Offset: 0x0008E238
		public bool TopButton1LabelLine1IsAcpApplicable
		{
			get
			{
				short num = (short)1797895345;
				short num2 = num;
				num = (short)1086043313;
				switch (num2 == num)
				{
				}
				num = (short)564396032;
				short num3 = num;
				num = (short)757923841;
				if (num != 0)
				{
				}
				num = (short)376111104;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1LabelLine1IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1531822;
				short num2 = num;
				num = (short)909008814;
				switch (num2 == num)
				{
				}
				num = (short)578355200;
				short num3 = num;
				num = (short)771555329;
				if (num != 0)
				{
				}
				num = (short)1843331072;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1LabelLine1IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x000900F0 File Offset: 0x0008E2F0
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x000901AC File Offset: 0x0008E3AC
		public bool TopButton1LabelLine1IsAcpVisible
		{
			get
			{
				short num = (short)1343616745;
				short num2 = num;
				num = (short)1241052905;
				switch (num2 == num)
				{
				}
				num = (short)1856372736;
				short num3 = num;
				num = (short)970129409;
				if (num != 0)
				{
				}
				num = (short)687538176;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1LabelLine1IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)939196417;
				if (num != 0)
				{
				}
				num = (short)35683441;
				short num2 = num;
				num = (short)687045745;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1159200768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)343408640;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1LabelLine1IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x00090268 File Offset: 0x0008E468
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x00090320 File Offset: 0x0008E520
		public bool TopButton1LabelLine1IsAcpEditable
		{
			get
			{
				short num = (short)2138346670;
				short num2 = num;
				num = (short)2092405934;
				switch (num2 == num)
				{
				}
				num = (short)805306368;
				short num3 = num;
				num = (short)1988624385;
				if (num != 0)
				{
				}
				num = (short)1675362304;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1LabelLine1IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1018500592;
				short num2 = num;
				num = (short)1741100528;
				switch (num2 == num)
				{
				}
				num = (short)1132068864;
				short num3 = num;
				num = (short)1766916097;
				if (num != 0)
				{
				}
				num = (short)1667563520;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1LabelLine1IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x000903DC File Offset: 0x0008E5DC
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x00090498 File Offset: 0x0008E698
		public AcpTextBox TopButton1LabelLine1Text
		{
			get
			{
				short num = (short)1435400278;
				short num2 = num;
				num = (short)1465546838;
				switch (num2 == num)
				{
				}
				num = (short)1733361664;
				short num3 = num;
				num = (short)1348206593;
				if (num != 0)
				{
				}
				num = (short)1015021568;
				if (num != 0)
				{
				}
				return (AcpTextBox)base.GetValue(O9GraphicView.TopButton1LabelLine1TextProperty);
			}
			set
			{
				short num = (short)832502275;
				short num2 = num;
				num = (short)1940060675;
				switch (num2 == num)
				{
				}
				num = (short)351404032;
				short num3 = num;
				num = (short)830537729;
				if (num != 0)
				{
				}
				num = (short)108068864;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1LabelLine1TextProperty, value);
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0009054C File Offset: 0x0008E74C
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x00090608 File Offset: 0x0008E808
		public string TopButton1LabelLine2Value
		{
			get
			{
				short num = (short)1415447195;
				short num2 = num;
				num = (short)1716716187;
				switch (num2 == num)
				{
				}
				num = (short)1156120576;
				short num3 = num;
				num = (short)991756289;
				if (num != 0)
				{
				}
				num = (short)1482096640;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton1LabelLine2ValueProperty);
			}
			set
			{
				short num = (short)1880473343;
				short num2 = num;
				num = (short)1786625791;
				switch (num2 == num)
				{
				}
				num = (short)74579968;
				short num3 = num;
				num = (short)321978368;
				if (num != 0)
				{
				}
				num = (short)1179975681;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1LabelLine2ValueProperty, value);
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x000906BC File Offset: 0x0008E8BC
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x00090774 File Offset: 0x0008E974
		public bool TopButton1LabelLine2IsAcpValid
		{
			get
			{
				short num = (short)1118269161;
				short num2 = num;
				num = (short)246312681;
				switch (num2 == num)
				{
				}
				num = (short)1225195520;
				short num3 = num;
				num = (short)1531183104;
				if (num != 0)
				{
				}
				num = (short)2124939265;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1LabelLine2IsAcpValidProperty);
			}
			set
			{
				short num = (short)629145601;
				if (num != 0)
				{
				}
				num = (short)971019945;
				short num2 = num;
				num = (short)1174640297;
				switch (num2 == num)
				{
				default:
				{
					num = (short)500498432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)335937536;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1LabelLine2IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0009082C File Offset: 0x0008EA2C
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x000908E8 File Offset: 0x0008EAE8
		public bool TopButton1LabelLine2IsAcpApplicable
		{
			get
			{
				short num = (short)2015783968;
				short num2 = num;
				num = (short)1613589536;
				switch (num2 == num)
				{
				}
				num = (short)1841692672;
				short num3 = num;
				num = (short)1106968577;
				if (num != 0)
				{
				}
				num = (short)2136670208;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1LabelLine2IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1390280705;
				if (num != 0)
				{
				}
				num = (short)1659178951;
				short num2 = num;
				num = (short)344133575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)669515776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)653590528;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1LabelLine2IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x000909A0 File Offset: 0x0008EBA0
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x00090A5C File Offset: 0x0008EC5C
		public bool TopButton1LabelLine2IsAcpVisible
		{
			get
			{
				short num = (short)1344884588;
				short num2 = num;
				num = (short)1160204140;
				switch (num2 == num)
				{
				}
				num = (short)1617756160;
				short num3 = num;
				num = (short)1121910785;
				if (num != 0)
				{
				}
				num = (short)464650240;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1LabelLine2IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2128512312;
				short num2 = num;
				num = (short)1103922488;
				switch (num2 == num)
				{
				}
				num = (short)173342720;
				short num3 = num;
				num = (short)1314193409;
				if (num != 0)
				{
				}
				num = (short)1403846656;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1LabelLine2IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00090B1C File Offset: 0x0008ED1C
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x00090BD4 File Offset: 0x0008EDD4
		public bool TopButton1LabelLine2IsAcpEditable
		{
			get
			{
				short num = (short)1676418098;
				short num2 = num;
				num = (short)1362435122;
				switch (num2 == num)
				{
				}
				num = (short)1162280960;
				short num3 = num;
				num = (short)265682945;
				if (num != 0)
				{
				}
				num = (short)1297678336;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1LabelLine2IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1981372457;
				short num2 = num;
				num = (short)1157716009;
				switch (num2 == num)
				{
				}
				num = (short)971440128;
				short num3 = num;
				num = (short)1149108224;
				if (num != 0)
				{
				}
				num = (short)1889599489;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1LabelLine2IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x00090C8C File Offset: 0x0008EE8C
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x00090D48 File Offset: 0x0008EF48
		public AcpTextBox TopButton1LabelLine2Text
		{
			get
			{
				short num = (short)13275569;
				short num2 = num;
				num = (short)124621233;
				switch (num2 == num)
				{
				}
				num = (short)546045952;
				short num3 = num;
				num = (short)1851981824;
				if (num != 0)
				{
				}
				num = (short)314703873;
				if (num != 0)
				{
				}
				return (AcpTextBox)base.GetValue(O9GraphicView.TopButton1LabelLine2TextProperty);
			}
			set
			{
				short num = (short)837070761;
				short num2 = num;
				num = (short)415608745;
				switch (num2 == num)
				{
				}
				num = (short)922091520;
				short num3 = num;
				num = (short)1485897728;
				if (num != 0)
				{
				}
				num = (short)122945537;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1LabelLine2TextProperty, value);
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00090DFC File Offset: 0x0008EFFC
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x00090EB4 File Offset: 0x0008F0B4
		public string TopButton2LabelLine1Value
		{
			get
			{
				short num = (short)702021633;
				if (num != 0)
				{
				}
				num = (short)1006401796;
				short num2 = num;
				num = (short)2104260868;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1728839680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1614675968;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton2LabelLine1ValueProperty);
			}
			set
			{
				short num = (short)777993743;
				short num2 = num;
				num = (short)579878415;
				switch (num2 == num)
				{
				}
				num = (short)646184960;
				short num3 = num;
				num = (short)1061683200;
				if (num != 0)
				{
				}
				num = (short)971833345;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2LabelLine1ValueProperty, value);
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00090F6C File Offset: 0x0008F16C
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x00091028 File Offset: 0x0008F228
		public bool TopButton2LabelLine1IsAcpValid
		{
			get
			{
				short num = (short)927399936;
				short num2 = num;
				num = (short)846371087;
				short num3 = num;
				num = (short)2132777231;
				switch (num3 == num)
				{
				}
				num = (short)740556800;
				if (num != 0)
				{
				}
				num = (short)132186113;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2LabelLine1IsAcpValidProperty);
			}
			set
			{
				short num = (short)1955332096;
				short num2 = num;
				num = (short)1079133735;
				short num3 = num;
				num = (short)1804879399;
				switch (num3 == num)
				{
				}
				num = (short)2010578945;
				if (num != 0)
				{
				}
				num = (short)1811021824;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2LabelLine1IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x000910E0 File Offset: 0x0008F2E0
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x00091198 File Offset: 0x0008F398
		public bool TopButton2LabelLine1IsAcpApplicable
		{
			get
			{
				short num = (short)1228013568;
				short num2 = num;
				num = (short)771024559;
				short num3 = num;
				num = (short)302704303;
				switch (num3 == num)
				{
				}
				num = (short)1195180033;
				if (num != 0)
				{
				}
				num = (short)1919877120;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2LabelLine1IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)791085056;
				short num2 = num;
				num = (short)552129343;
				short num3 = num;
				num = (short)1157550911;
				switch (num3 == num)
				{
				}
				num = (short)411631617;
				if (num != 0)
				{
				}
				num = (short)1067515904;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2LabelLine1IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00091250 File Offset: 0x0008F450
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x00091308 File Offset: 0x0008F508
		public bool TopButton2LabelLine1IsAcpVisible
		{
			get
			{
				short num = (short)1144324096;
				short num2 = num;
				num = (short)1121929630;
				short num3 = num;
				num = (short)1958037918;
				switch (num3 == num)
				{
				}
				num = (short)756875265;
				if (num != 0)
				{
				}
				num = (short)934084608;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2LabelLine1IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)190119936;
				short num2 = num;
				num = (short)573934911;
				short num3 = num;
				num = (short)303467839;
				switch (num3 == num)
				{
				}
				num = (short)442302465;
				if (num != 0)
				{
				}
				num = (short)357695488;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2LabelLine1IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x000913C0 File Offset: 0x0008F5C0
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x00091478 File Offset: 0x0008F678
		public bool TopButton2LabelLine1IsAcpEditable
		{
			get
			{
				short num = (short)1550974976;
				short num2 = num;
				num = (short)1477213914;
				short num3 = num;
				num = (short)305364698;
				switch (num3 == num)
				{
				}
				num = (short)1335951361;
				if (num != 0)
				{
				}
				num = (short)1643708416;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2LabelLine1IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1733427200;
				short num2 = num;
				num = (short)719143421;
				short num3 = num;
				num = (short)1944535549;
				switch (num3 == num)
				{
				}
				num = (short)1697972225;
				if (num != 0)
				{
				}
				num = (short)854392832;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2LabelLine1IsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00091534 File Offset: 0x0008F734
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x000915EC File Offset: 0x0008F7EC
		public AcpTextBox TopButton2LabelLine1Text
		{
			get
			{
				short num = (short)1582301184;
				short num2 = num;
				num = (short)435164417;
				short num3 = num;
				num = (short)301733121;
				switch (num3 == num)
				{
				}
				num = (short)1912537088;
				if (num != 0)
				{
				}
				num = (short)2055143425;
				if (num != 0)
				{
				}
				return (AcpTextBox)base.GetValue(O9GraphicView.TopButton2LabelLine1TextProperty);
			}
			set
			{
				short num = (short)408748032;
				short num2 = num;
				num = (short)1488567496;
				short num3 = num;
				num = (short)60341448;
				switch (num3 == num)
				{
				}
				num = (short)2111438849;
				if (num != 0)
				{
				}
				num = (short)818216960;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2LabelLine1TextProperty, value);
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x000916A4 File Offset: 0x0008F8A4
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00091764 File Offset: 0x0008F964
		public string TopButton2LabelLine2Value
		{
			get
			{
				short num = (short)1805320192;
				short num2 = num;
				num = (short)1838940161;
				if (num != 0)
				{
				}
				num = (short)854461100;
				short num3 = num;
				num = (short)1503529644;
				switch (num3 == num)
				{
				}
				num = (short)858193920;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton2LabelLine2ValueProperty);
			}
			set
			{
				short num = (short)1577975808;
				short num2 = num;
				num = (short)997853802;
				short num3 = num;
				num = (short)138742378;
				switch (num3 == num)
				{
				}
				num = (short)1811546113;
				if (num != 0)
				{
				}
				num = (short)1018691584;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2LabelLine2ValueProperty, value);
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00091818 File Offset: 0x0008FA18
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x000918D0 File Offset: 0x0008FAD0
		public bool TopButton2LabelLine2IsAcpValid
		{
			get
			{
				short num = (short)1489567744;
				short num2 = num;
				num = (short)367501329;
				short num3 = num;
				num = (short)1400086545;
				switch (num3 == num)
				{
				}
				num = (short)780337153;
				if (num != 0)
				{
				}
				num = (short)687865856;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2LabelLine2IsAcpValidProperty);
			}
			set
			{
				short num = (short)1101201408;
				short num2 = num;
				num = (short)1579659387;
				short num3 = num;
				num = (short)1826336891;
				switch (num3 == num)
				{
				}
				num = (short)1446969345;
				if (num != 0)
				{
				}
				num = (short)790757376;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2LabelLine2IsAcpValidProperty, value);
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0009198C File Offset: 0x0008FB8C
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00091A48 File Offset: 0x0008FC48
		public bool TopButton2LabelLine2IsAcpApplicable
		{
			get
			{
				short num = (short)1620639744;
				short num2 = num;
				num = (short)1795782042;
				short num3 = num;
				num = (short)1020949914;
				switch (num3 == num)
				{
				}
				num = (short)1954938881;
				if (num != 0)
				{
				}
				num = (short)2139029504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2LabelLine2IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)676790272;
				short num2 = num;
				num = (short)1327967843;
				short num3 = num;
				num = (short)723660387;
				switch (num3 == num)
				{
				}
				num = (short)1118896128;
				if (num != 0)
				{
				}
				num = (short)334495745;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2LabelLine2IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00091B04 File Offset: 0x0008FD04
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00091BBC File Offset: 0x0008FDBC
		public bool TopButton2LabelLine2IsAcpVisible
		{
			get
			{
				short num = (short)1320943616;
				short num2 = num;
				num = (short)1185283005;
				short num3 = num;
				num = (short)1010432957;
				switch (num3 == num)
				{
				}
				num = (short)1891041280;
				if (num != 0)
				{
				}
				num = (short)1398210561;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2LabelLine2IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)242614272;
				short num2 = num;
				num = (short)2005182780;
				short num3 = num;
				num = (short)1085778236;
				switch (num3 == num)
				{
				}
				num = (short)848560129;
				if (num != 0)
				{
				}
				num = (short)1119354880;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2LabelLine2IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00091C78 File Offset: 0x0008FE78
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x00091D30 File Offset: 0x0008FF30
		public bool TopButton2LabelLine2IsAcpEditable
		{
			get
			{
				short num = (short)224460800;
				short num2 = num;
				num = (short)606852507;
				short num3 = num;
				num = (short)1374147995;
				switch (num3 == num)
				{
				}
				num = (short)882245632;
				if (num != 0)
				{
				}
				num = (short)415105025;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2LabelLine2IsAcpEditableProperty);
			}
			set
			{
				short num = (short)180027392;
				short num2 = num;
				num = (short)1957550894;
				short num3 = num;
				num = (short)952425262;
				switch (num3 == num)
				{
				}
				num = (short)562298880;
				if (num != 0)
				{
				}
				num = (short)1008009217;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2LabelLine2IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00091DE8 File Offset: 0x0008FFE8
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00091EA0 File Offset: 0x000900A0
		public AcpTextBox TopButton2LabelLine2Text
		{
			get
			{
				short num = (short)1005060096;
				short num2 = num;
				num = (short)1634481907;
				short num3 = num;
				num = (short)1514878707;
				switch (num3 == num)
				{
				}
				num = (short)183697408;
				if (num != 0)
				{
				}
				num = (short)997064705;
				if (num != 0)
				{
				}
				return (AcpTextBox)base.GetValue(O9GraphicView.TopButton2LabelLine2TextProperty);
			}
			set
			{
				short num = (short)474021888;
				short num2 = num;
				num = (short)177855200;
				short num3 = num;
				num = (short)219863776;
				switch (num3 == num)
				{
				}
				num = (short)750583808;
				if (num != 0)
				{
				}
				num = (short)71565313;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2LabelLine2TextProperty, value);
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x00091F54 File Offset: 0x00090154
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x00092010 File Offset: 0x00090210
		public string TopButton3LabelLine1Value
		{
			get
			{
				short num = (short)1083965440;
				short num2 = num;
				num = (short)2046820353;
				if (num != 0)
				{
				}
				num = (short)2110777364;
				short num3 = num;
				num = (short)1711335444;
				switch (num3 == num)
				{
				}
				num = (short)1417871360;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton3LabelLine1ValueProperty);
			}
			set
			{
				short num = (short)132513792;
				short num2 = num;
				num = (short)2014067419;
				short num3 = num;
				num = (short)1179663067;
				switch (num3 == num)
				{
				}
				num = (short)309985281;
				if (num != 0)
				{
				}
				num = (short)727580672;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3LabelLine1ValueProperty, value);
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x000920C4 File Offset: 0x000902C4
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x0009217C File Offset: 0x0009037C
		public bool TopButton3LabelLine1IsAcpValid
		{
			get
			{
				short num = (short)2071068672;
				short num2 = num;
				num = (short)1668161003;
				short num3 = num;
				num = (short)688332267;
				switch (num3 == num)
				{
				}
				num = (short)790953985;
				if (num != 0)
				{
				}
				num = (short)1823277056;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3LabelLine1IsAcpValidProperty);
			}
			set
			{
				short num = (short)750190592;
				short num2 = num;
				num = (short)901120001;
				if (num != 0)
				{
				}
				num = (short)1878948499;
				short num3 = num;
				num = (short)336886419;
				switch (num3 == num)
				{
				}
				num = (short)254672896;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3LabelLine1IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00092238 File Offset: 0x00090438
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x000922F4 File Offset: 0x000904F4
		public bool TopButton3LabelLine1IsAcpApplicable
		{
			get
			{
				short num = (short)2080702464;
				short num2 = num;
				num = (short)114622465;
				if (num != 0)
				{
				}
				num = (short)551381698;
				short num3 = num;
				num = (short)1491888834;
				switch (num3 == num)
				{
				}
				num = (short)1876361216;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3LabelLine1IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)281411584;
				short num2 = num;
				num = (short)1375600641;
				if (num != 0)
				{
				}
				num = (short)964492433;
				short num3 = num;
				num = (short)1027144849;
				switch (num3 == num)
				{
				}
				num = (short)552599552;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3LabelLine1IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x000923B0 File Offset: 0x000905B0
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x00092468 File Offset: 0x00090668
		public bool TopButton3LabelLine1IsAcpVisible
		{
			get
			{
				short num = (short)1037238272;
				short num2 = num;
				num = (short)923366965;
				short num3 = num;
				num = (short)1866298933;
				switch (num3 == num)
				{
				}
				num = (short)1522204673;
				if (num != 0)
				{
				}
				num = (short)1763573760;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3LabelLine1IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1657929728;
				short num2 = num;
				num = (short)53378523;
				short num3 = num;
				num = (short)1900838363;
				switch (num3 == num)
				{
				}
				num = (short)522452993;
				if (num != 0)
				{
				}
				num = (short)688521216;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3LabelLine1IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00092524 File Offset: 0x00090724
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x000925E0 File Offset: 0x000907E0
		public bool TopButton3LabelLine1IsAcpEditable
		{
			get
			{
				short num = (short)753467392;
				short num2 = num;
				num = (short)162975312;
				short num3 = num;
				num = (short)71683664;
				switch (num3 == num)
				{
				}
				num = (short)953745409;
				if (num != 0)
				{
				}
				num = (short)361037824;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3LabelLine1IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1782579200;
				short num2 = num;
				num = (short)226295809;
				if (num != 0)
				{
				}
				num = (short)1473003703;
				short num3 = num;
				num = (short)815808695;
				switch (num3 == num)
				{
				}
				num = (short)597032960;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3LabelLine1IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00092698 File Offset: 0x00090898
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x00092750 File Offset: 0x00090950
		public AcpTextBox TopButton3LabelLine1Text
		{
			get
			{
				short num = (short)751632384;
				short num2 = num;
				num = (short)1014927106;
				short num3 = num;
				num = (short)1276940034;
				switch (num3 == num)
				{
				}
				num = (short)769916928;
				if (num != 0)
				{
				}
				num = (short)1757413377;
				if (num != 0)
				{
				}
				return (AcpTextBox)base.GetValue(O9GraphicView.TopButton3LabelLine1TextProperty);
			}
			set
			{
				short num = (short)1199964160;
				short num2 = num;
				num = (short)1662875298;
				short num3 = num;
				num = (short)1996450;
				switch (num3 == num)
				{
				}
				num = (short)2010513408;
				if (num != 0)
				{
				}
				num = (short)255590401;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3LabelLine1TextProperty, value);
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00092808 File Offset: 0x00090A08
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x000928C0 File Offset: 0x00090AC0
		public string TopButton3LabelLine2Value
		{
			get
			{
				short num = (short)882180096;
				short num2 = num;
				num = (short)996329118;
				short num3 = num;
				num = (short)2066400926;
				switch (num3 == num)
				{
				}
				num = (short)1405550593;
				if (num != 0)
				{
				}
				num = (short)1996226560;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton3LabelLine2ValueProperty);
			}
			set
			{
				short num = (short)289669120;
				short num2 = num;
				num = (short)1111490561;
				if (num != 0)
				{
				}
				num = (short)391819457;
				short num3 = num;
				num = (short)2040312001;
				switch (num3 == num)
				{
				}
				num = (short)1638268928;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3LabelLine2ValueProperty, value);
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00092974 File Offset: 0x00090B74
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x00092A30 File Offset: 0x00090C30
		public bool TopButton3LabelLine2IsAcpValid
		{
			get
			{
				short num = (short)1812529152;
				short num2 = num;
				num = (short)1860408770;
				short num3 = num;
				num = (short)1565562306;
				switch (num3 == num)
				{
				}
				num = (short)294191105;
				if (num != 0)
				{
				}
				num = (short)432472064;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3LabelLine2IsAcpValidProperty);
			}
			set
			{
				short num = (short)16384000;
				short num2 = num;
				num = (short)203407726;
				short num3 = num;
				num = (short)1877918062;
				switch (num3 == num)
				{
				}
				num = (short)1655767041;
				if (num != 0)
				{
				}
				num = (short)1863516160;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3LabelLine2IsAcpValidProperty, value);
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00092AEC File Offset: 0x00090CEC
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x00092BA4 File Offset: 0x00090DA4
		public bool TopButton3LabelLine2IsAcpApplicable
		{
			get
			{
				short num = (short)1367015424;
				short num2 = num;
				num = (short)1397279826;
				short num3 = num;
				num = (short)851102802;
				switch (num3 == num)
				{
				}
				num = (short)220594177;
				if (num != 0)
				{
				}
				num = (short)1269694464;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3LabelLine2IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)485621760;
				short num2 = num;
				num = (short)1507328001;
				if (num != 0)
				{
				}
				num = (short)1335290646;
				short num3 = num;
				num = (short)366275350;
				switch (num3 == num)
				{
				}
				num = (short)622198784;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3LabelLine2IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00092C5C File Offset: 0x00090E5C
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x00092D14 File Offset: 0x00090F14
		public bool TopButton3LabelLine2IsAcpVisible
		{
			get
			{
				short num = (short)1266155520;
				short num2 = num;
				num = (short)1403060225;
				if (num != 0)
				{
				}
				num = (short)1910405928;
				short num3 = num;
				num = (short)983923496;
				switch (num3 == num)
				{
				}
				num = (short)1107034112;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3LabelLine2IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)895156224;
				short num2 = num;
				num = (short)408469662;
				short num3 = num;
				num = (short)1150992542;
				switch (num3 == num)
				{
				}
				num = (short)727777280;
				if (num != 0)
				{
				}
				num = (short)1306984449;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3LabelLine2IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00092DD0 File Offset: 0x00090FD0
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x00092E8C File Offset: 0x0009108C
		public bool TopButton3LabelLine2IsAcpEditable
		{
			get
			{
				short num = (short)1403191296;
				short num2 = num;
				num = (short)1989017601;
				if (num != 0)
				{
				}
				num = (short)1457498621;
				short num3 = num;
				num = (short)1060088317;
				switch (num3 == num)
				{
				}
				num = (short)1798766592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3LabelLine2IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1993998336;
				short num2 = num;
				num = (short)1868673569;
				short num3 = num;
				num = (short)624013857;
				switch (num3 == num)
				{
				}
				num = (short)1708392449;
				if (num != 0)
				{
				}
				num = (short)18743296;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3LabelLine2IsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x00092F48 File Offset: 0x00091148
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x00093004 File Offset: 0x00091204
		public AcpTextBox TopButton3LabelLine2Text
		{
			get
			{
				short num = (short)936050688;
				short num2 = num;
				num = (short)1825082365;
				short num3 = num;
				num = (short)547785725;
				switch (num3 == num)
				{
				}
				num = (short)1259405312;
				if (num != 0)
				{
				}
				num = (short)2006777857;
				if (num != 0)
				{
				}
				return (AcpTextBox)base.GetValue(O9GraphicView.TopButton3LabelLine2TextProperty);
			}
			set
			{
				short num = (short)964034561;
				if (num != 0)
				{
				}
				num = (short)830038454;
				short num2 = num;
				num = (short)233529782;
				switch (num2 == num)
				{
				}
				num = (short)1305804800;
				short num3 = num;
				num = (short)1270939648;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3LabelLine2TextProperty, value);
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x000930BC File Offset: 0x000912BC
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x00093178 File Offset: 0x00091378
		public string TopButton4LabelLine1Value
		{
			get
			{
				short num = (short)1759014837;
				short num2 = num;
				num = (short)24801205;
				switch (num2 == num)
				{
				}
				num = (short)331218945;
				if (num != 0)
				{
				}
				num = (short)323616768;
				short num3 = num;
				num = (short)444792832;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton4LabelLine1ValueProperty);
			}
			set
			{
				short num = (short)506568433;
				short num2 = num;
				num = (short)975806193;
				switch (num2 == num)
				{
				}
				num = (short)1444806656;
				if (num != 0)
				{
				}
				num = (short)616890368;
				short num3 = num;
				num = (short)2080112641;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4LabelLine1ValueProperty, value);
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0009322C File Offset: 0x0009142C
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x000932E4 File Offset: 0x000914E4
		public bool TopButton4LabelLine1IsAcpValid
		{
			get
			{
				short num = (short)772935581;
				short num2 = num;
				num = (short)1092685725;
				switch (num2 == num)
				{
				}
				num = (short)1327300609;
				if (num != 0)
				{
				}
				num = (short)1306591232;
				short num3 = num;
				num = (short)1957494784;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4LabelLine1IsAcpValidProperty);
			}
			set
			{
				short num = (short)330165710;
				short num2 = num;
				num = (short)1689120206;
				switch (num2 == num)
				{
				}
				num = (short)2050949120;
				if (num != 0)
				{
				}
				num = (short)1706950656;
				short num3 = num;
				num = (short)2000617473;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4LabelLine1IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0009339C File Offset: 0x0009159C
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x00093454 File Offset: 0x00091654
		public bool TopButton4LabelLine1IsAcpApplicable
		{
			get
			{
				short num = (short)348085355;
				short num2 = num;
				num = (short)1532058731;
				switch (num2 == num)
				{
				}
				num = (short)1904148481;
				if (num != 0)
				{
				}
				num = (short)690356224;
				short num3 = num;
				num = (short)1324548096;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4LabelLine1IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1567352949;
				short num2 = num;
				num = (short)872671349;
				switch (num2 == num)
				{
				}
				num = (short)1812529153;
				if (num != 0)
				{
				}
				num = (short)1308753920;
				short num3 = num;
				num = (short)1743716352;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4LabelLine1IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0009350C File Offset: 0x0009170C
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x000935C8 File Offset: 0x000917C8
		public bool TopButton4LabelLine1IsAcpVisible
		{
			get
			{
				short num = (short)1401477646;
				short num2 = num;
				num = (short)1540151822;
				switch (num2 == num)
				{
				}
				num = (short)1584726016;
				if (num != 0)
				{
				}
				num = (short)1658847232;
				short num3 = num;
				num = (short)1042874369;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4LabelLine1IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1664221185;
				if (num != 0)
				{
				}
				num = (short)1560387029;
				short num2 = num;
				num = (short)1616027093;
				switch (num2 == num)
				{
				}
				num = (short)1268776960;
				short num3 = num;
				num = (short)941555712;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4LabelLine1IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x00093684 File Offset: 0x00091884
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x00093740 File Offset: 0x00091940
		public bool TopButton4LabelLine1IsAcpEditable
		{
			get
			{
				short num = (short)1695745820;
				short num2 = num;
				num = (short)1426917148;
				switch (num2 == num)
				{
				}
				num = (short)633733120;
				if (num != 0)
				{
				}
				num = (short)1182203904;
				short num3 = num;
				num = (short)1183318017;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4LabelLine1IsAcpEditableProperty);
			}
			set
			{
				short num = (short)793296431;
				short num2 = num;
				num = (short)190496303;
				switch (num2 == num)
				{
				}
				num = (short)1660223488;
				if (num != 0)
				{
				}
				num = (short)334692352;
				short num3 = num;
				num = (short)1306722305;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4LabelLine1IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x000937FC File Offset: 0x000919FC
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x000938B4 File Offset: 0x00091AB4
		public AcpTextBox TopButton4LabelLine1Text
		{
			get
			{
				short num = (short)1661337601;
				if (num != 0)
				{
				}
				num = (short)212295187;
				short num2 = num;
				num = (short)1920622099;
				switch (num2 == num)
				{
				}
				num = (short)1177092096;
				short num3 = num;
				num = (short)708902912;
				if (num != 0)
				{
				}
				return (AcpTextBox)base.GetValue(O9GraphicView.TopButton4LabelLine1TextProperty);
			}
			set
			{
				short num = (short)1575988179;
				short num2 = num;
				num = (short)968338387;
				switch (num2 == num)
				{
				}
				num = (short)236781569;
				if (num != 0)
				{
				}
				num = (short)623247360;
				short num3 = num;
				num = (short)1456144384;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4LabelLine1TextProperty, value);
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x0009396C File Offset: 0x00091B6C
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00093A24 File Offset: 0x00091C24
		public string TopButton4LabelLine2Value
		{
			get
			{
				short num = (short)620475732;
				short num2 = num;
				num = (short)1833284948;
				switch (num2 == num)
				{
				}
				num = (short)2019885057;
				if (num != 0)
				{
				}
				num = (short)126156800;
				short num3 = num;
				num = (short)887160832;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton4LabelLine2ValueProperty);
			}
			set
			{
				short num = (short)505479169;
				if (num != 0)
				{
				}
				num = (short)295685898;
				short num2 = num;
				num = (short)1164365578;
				switch (num2 == num)
				{
				}
				num = (short)1749876736;
				short num3 = num;
				num = (short)1570570240;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4LabelLine2ValueProperty, value);
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00093AD8 File Offset: 0x00091CD8
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00093B90 File Offset: 0x00091D90
		public bool TopButton4LabelLine2IsAcpValid
		{
			get
			{
				short num = (short)2066162300;
				short num2 = num;
				num = (short)841687676;
				switch (num2 == num)
				{
				}
				num = (short)1461059585;
				if (num != 0)
				{
				}
				num = (short)740884480;
				short num3 = num;
				num = (short)220332032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4LabelLine2IsAcpValidProperty);
			}
			set
			{
				short num = (short)1538523137;
				if (num != 0)
				{
				}
				num = (short)880116297;
				short num2 = num;
				num = (short)784040521;
				switch (num2 == num)
				{
				}
				num = (short)339935232;
				short num3 = num;
				num = (short)1162280960;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4LabelLine2IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00093C48 File Offset: 0x00091E48
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x00093D00 File Offset: 0x00091F00
		public bool TopButton4LabelLine2IsAcpApplicable
		{
			get
			{
				short num = (short)1286851527;
				short num2 = num;
				num = (short)218942407;
				switch (num2 == num)
				{
				}
				num = (short)2136932353;
				if (num != 0)
				{
				}
				num = (short)1356005376;
				short num3 = num;
				num = (short)572850176;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4LabelLine2IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1545901862;
				short num2 = num;
				num = (short)896505638;
				switch (num2 == num)
				{
				}
				num = (short)1693384705;
				if (num != 0)
				{
				}
				num = (short)192086016;
				short num3 = num;
				num = (short)2024800256;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4LabelLine2IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00093DBC File Offset: 0x00091FBC
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x00093E78 File Offset: 0x00092078
		public bool TopButton4LabelLine2IsAcpVisible
		{
			get
			{
				short num = (short)1853947905;
				if (num != 0)
				{
				}
				num = (short)1346498168;
				short num2 = num;
				num = (short)47181432;
				switch (num2 == num)
				{
				}
				num = (short)1977221120;
				short num3 = num;
				num = (short)1473052672;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4LabelLine2IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)911657460;
				short num2 = num;
				num = (short)1104857588;
				switch (num2 == num)
				{
				}
				num = (short)268369920;
				if (num != 0)
				{
				}
				num = (short)63373312;
				short num3 = num;
				num = (short)1018560513;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4LabelLine2IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00093F30 File Offset: 0x00092130
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00093FEC File Offset: 0x000921EC
		public bool TopButton4LabelLine2IsAcpEditable
		{
			get
			{
				short num = (short)2091023207;
				short num2 = num;
				num = (short)1913027431;
				switch (num2 == num)
				{
				}
				num = (short)1979252737;
				if (num != 0)
				{
				}
				num = (short)680394752;
				short num3 = num;
				num = (short)2023948288;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4LabelLine2IsAcpEditableProperty);
			}
			set
			{
				short num = (short)204286319;
				short num2 = num;
				num = (short)617097583;
				switch (num2 == num)
				{
				}
				num = (short)1446969344;
				if (num != 0)
				{
				}
				num = (short)1321664512;
				short num3 = num;
				num = (short)1629159425;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4LabelLine2IsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x000940A4 File Offset: 0x000922A4
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00094160 File Offset: 0x00092360
		public AcpTextBox TopButton4LabelLine2Text
		{
			get
			{
				short num = (short)788326876;
				short num2 = num;
				num = (short)769976796;
				switch (num2 == num)
				{
				}
				num = (short)602931200;
				if (num != 0)
				{
				}
				num = (short)664272896;
				short num3 = num;
				num = (short)142147585;
				if (num != 0)
				{
				}
				return (AcpTextBox)base.GetValue(O9GraphicView.TopButton4LabelLine2TextProperty);
			}
			set
			{
				short num = (short)42321113;
				short num2 = num;
				num = (short)1830208729;
				switch (num2 == num)
				{
				}
				num = (short)122880001;
				if (num != 0)
				{
				}
				num = (short)541851648;
				short num3 = num;
				num = (short)856489984;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4LabelLine2TextProperty, value);
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00094218 File Offset: 0x00092418
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x000942D0 File Offset: 0x000924D0
		public string TopButton5LabelLine1Value
		{
			get
			{
				short num = (short)1362139296;
				short num2 = num;
				num = (short)1738840224;
				switch (num2 == num)
				{
				}
				num = (short)188022785;
				if (num != 0)
				{
				}
				num = (short)1549271040;
				short num3 = num;
				num = (short)1489502208;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton5LabelLine1ValueProperty);
			}
			set
			{
				short num = (short)468335183;
				short num2 = num;
				num = (short)1987983951;
				switch (num2 == num)
				{
				}
				num = (short)1470562305;
				if (num != 0)
				{
				}
				num = (short)1365442560;
				short num3 = num;
				num = (short)1980301312;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5LabelLine1ValueProperty, value);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00094384 File Offset: 0x00092584
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00094440 File Offset: 0x00092640
		public bool TopButton5LabelLine1IsAcpValid
		{
			get
			{
				short num = (short)756875265;
				if (num != 0)
				{
				}
				num = (short)996400361;
				short num2 = num;
				num = (short)1394138345;
				switch (num2 == num)
				{
				}
				num = (short)1073872896;
				short num3 = num;
				num = (short)987430912;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5LabelLine1IsAcpValidProperty);
			}
			set
			{
				short num = (short)92334724;
				short num2 = num;
				num = (short)61074052;
				switch (num2 == num)
				{
				}
				num = (short)894828544;
				if (num != 0)
				{
				}
				num = (short)1466499072;
				short num3 = num;
				num = (short)789250049;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5LabelLine1IsAcpValidProperty, value);
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x000944F8 File Offset: 0x000926F8
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x000945B4 File Offset: 0x000927B4
		public bool TopButton5LabelLine1IsAcpApplicable
		{
			get
			{
				short num = (short)2125815814;
				short num2 = num;
				num = (short)1004494854;
				switch (num2 == num)
				{
				}
				num = (short)1561133056;
				if (num != 0)
				{
				}
				num = (short)279838720;
				short num3 = num;
				num = (short)754384897;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5LabelLine1IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1055487572;
				short num2 = num;
				num = (short)1950578260;
				switch (num2 == num)
				{
				}
				num = (short)928055296;
				if (num != 0)
				{
				}
				num = (short)1242628096;
				short num3 = num;
				num = (short)1077870593;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5LabelLine1IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0009466C File Offset: 0x0009286C
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x00094728 File Offset: 0x00092928
		public bool TopButton5LabelLine1IsAcpVisible
		{
			get
			{
				short num = (short)2101227747;
				short num2 = num;
				num = (short)809906403;
				switch (num2 == num)
				{
				}
				num = (short)94830592;
				if (num != 0)
				{
				}
				num = (short)541655040;
				short num3 = num;
				num = (short)217841665;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5LabelLine1IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)614741490;
				short num2 = num;
				num = (short)136984050;
				switch (num2 == num)
				{
				}
				num = (short)1353777153;
				if (num != 0)
				{
				}
				num = (short)1426391040;
				short num3 = num;
				num = (short)791085056;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5LabelLine1IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x000947E4 File Offset: 0x000929E4
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x0009489C File Offset: 0x00092A9C
		public bool TopButton5LabelLine1IsAcpEditable
		{
			get
			{
				short num = (short)1949282014;
				short num2 = num;
				num = (short)351776478;
				switch (num2 == num)
				{
				}
				num = (short)534446081;
				if (num != 0)
				{
				}
				num = (short)1394016256;
				short num3 = num;
				num = (short)1639579648;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5LabelLine1IsAcpEditableProperty);
			}
			set
			{
				short num = (short)2030632961;
				if (num != 0)
				{
				}
				num = (short)2010430517;
				short num2 = num;
				num = (short)1578613813;
				switch (num2 == num)
				{
				}
				num = (short)583204864;
				short num3 = num;
				num = (short)2076246016;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5LabelLine1IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0009495C File Offset: 0x00092B5C
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00094A18 File Offset: 0x00092C18
		public AcpTextBox TopButton5LabelLine1Text
		{
			get
			{
				short num = (short)1256983261;
				short num2 = num;
				num = (short)433326813;
				switch (num2 == num)
				{
				}
				num = (short)75104257;
				if (num != 0)
				{
				}
				num = (short)954269696;
				short num3 = num;
				num = (short)1171783680;
				if (num != 0)
				{
				}
				return (AcpTextBox)base.GetValue(O9GraphicView.TopButton5LabelLine1TextProperty);
			}
			set
			{
				short num = (short)658309121;
				if (num != 0)
				{
				}
				num = (short)1431358417;
				short num2 = num;
				num = (short)2117192657;
				switch (num2 == num)
				{
				}
				num = (short)1278869504;
				short num3 = num;
				num = (short)119930880;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5LabelLine1TextProperty, value);
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00094ACC File Offset: 0x00092CCC
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00094B84 File Offset: 0x00092D84
		public string TopButton5LabelLine2Value
		{
			get
			{
				short num = (short)1850862835;
				short num2 = num;
				num = (short)410971379;
				switch (num2 == num)
				{
				}
				num = (short)1777074177;
				if (num != 0)
				{
				}
				num = (short)801701888;
				short num3 = num;
				num = (short)19070976;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton5LabelLine2ValueProperty);
			}
			set
			{
				short num = (short)286885990;
				short num2 = num;
				num = (short)917604454;
				switch (num2 == num)
				{
				}
				num = (short)381091841;
				if (num != 0)
				{
				}
				num = (short)1289420800;
				short num3 = num;
				num = (short)1044774912;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5LabelLine2ValueProperty, value);
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00094C3C File Offset: 0x00092E3C
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00094CF8 File Offset: 0x00092EF8
		public bool TopButton5LabelLine2IsAcpValid
		{
			get
			{
				short num = (short)1214325104;
				short num2 = num;
				num = (short)475996528;
				switch (num2 == num)
				{
				}
				num = (short)872480768;
				if (num != 0)
				{
				}
				num = (short)859504640;
				short num3 = num;
				num = (short)1562902529;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5LabelLine2IsAcpValidProperty);
			}
			set
			{
				short num = (short)815916506;
				short num2 = num;
				num = (short)285992410;
				switch (num2 == num)
				{
				}
				num = (short)1148780544;
				if (num != 0)
				{
				}
				num = (short)1753808896;
				short num3 = num;
				num = (short)1598291969;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5LabelLine2IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00094DB4 File Offset: 0x00092FB4
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00094E70 File Offset: 0x00093070
		public bool TopButton5LabelLine2IsAcpApplicable
		{
			get
			{
				short num = (short)1899259561;
				short num2 = num;
				num = (short)1726310057;
				switch (num2 == num)
				{
				}
				num = (short)670892033;
				if (num != 0)
				{
				}
				num = (short)1613496320;
				short num3 = num;
				num = (short)428277760;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5LabelLine2IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1898115372;
				short num2 = num;
				num = (short)1373368620;
				switch (num2 == num)
				{
				}
				num = (short)328531968;
				if (num != 0)
				{
				}
				num = (short)1366687744;
				short num3 = num;
				num = (short)1407778817;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5LabelLine2IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00094F28 File Offset: 0x00093128
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x00094FE0 File Offset: 0x000931E0
		public bool TopButton5LabelLine2IsAcpVisible
		{
			get
			{
				short num = (short)989949829;
				short num2 = num;
				num = (short)1558867845;
				switch (num2 == num)
				{
				}
				num = (short)1678311424;
				if (num != 0)
				{
				}
				num = (short)431292416;
				short num3 = num;
				num = (short)1296302081;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5LabelLine2IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)933628015;
				short num2 = num;
				num = (short)84084847;
				switch (num2 == num)
				{
				}
				num = (short)89128961;
				if (num != 0)
				{
				}
				num = (short)1147928576;
				short num3 = num;
				num = (short)418447360;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5LabelLine2IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0009509C File Offset: 0x0009329C
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00095154 File Offset: 0x00093354
		public bool TopButton5LabelLine2IsAcpEditable
		{
			get
			{
				short num = (short)1493258925;
				short num2 = num;
				num = (short)1015108269;
				switch (num2 == num)
				{
				}
				num = (short)1767964672;
				if (num != 0)
				{
				}
				num = (short)115802112;
				short num3 = num;
				num = (short)2135359489;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5LabelLine2IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1673718254;
				short num2 = num;
				num = (short)641001966;
				switch (num2 == num)
				{
				}
				num = (short)596115457;
				if (num != 0)
				{
				}
				num = (short)990838784;
				short num3 = num;
				num = (short)109772800;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5LabelLine2IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0009520C File Offset: 0x0009340C
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x000952C4 File Offset: 0x000934C4
		public AcpTextBox TopButton5LabelLine2Text
		{
			get
			{
				short num = (short)44695553;
				if (num != 0)
				{
				}
				num = (short)155192346;
				short num2 = num;
				num = (short)1783761946;
				switch (num2 == num)
				{
				}
				num = (short)1869086720;
				short num3 = num;
				num = (short)1252327424;
				if (num != 0)
				{
				}
				return (AcpTextBox)base.GetValue(O9GraphicView.TopButton5LabelLine2TextProperty);
			}
			set
			{
				short num = (short)561380679;
				short num2 = num;
				num = (short)922025287;
				switch (num2 == num)
				{
				}
				num = (short)1741684737;
				if (num != 0)
				{
				}
				num = (short)1946746880;
				short num3 = num;
				num = (short)740360192;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5LabelLine2TextProperty, value);
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0009537C File Offset: 0x0009357C
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x00095434 File Offset: 0x00093634
		public bool TopButton1FeatureIsAcpValid
		{
			get
			{
				short num = (short)1566361753;
				short num2 = num;
				num = (short)973981849;
				switch (num2 == num)
				{
				}
				num = (short)1403125761;
				if (num != 0)
				{
				}
				num = (short)8650752;
				short num3 = num;
				num = (short)79691776;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)612759774;
				short num2 = num;
				num = (short)893253854;
				switch (num2 == num)
				{
				}
				num = (short)1097465856;
				if (num != 0)
				{
				}
				num = (short)566493184;
				short num3 = num;
				num = (short)319553537;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x000954F0 File Offset: 0x000936F0
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x000955A8 File Offset: 0x000937A8
		public bool TopButton1FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)490534102;
				short num2 = num;
				num = (short)767751382;
				switch (num2 == num)
				{
				}
				num = (short)1249312769;
				if (num != 0)
				{
				}
				num = (short)629407744;
				short num3 = num;
				num = (short)2029453312;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1915032279;
				short num2 = num;
				num = (short)227414743;
				switch (num2 == num)
				{
				}
				num = (short)1841233921;
				if (num != 0)
				{
				}
				num = (short)2138505216;
				short num3 = num;
				num = (short)1516240896;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00095664 File Offset: 0x00093864
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x0009571C File Offset: 0x0009391C
		public bool TopButton1FeatureIsAcpVisible
		{
			get
			{
				short num = (short)693289896;
				short num2 = num;
				num = (short)809943976;
				switch (num2 == num)
				{
				}
				num = (short)578224129;
				if (num != 0)
				{
				}
				num = (short)1554644992;
				short num3 = num;
				num = (short)2133196800;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)371900936;
				short num2 = num;
				num = (short)1398522376;
				switch (num2 == num)
				{
				}
				num = (short)850460672;
				if (num != 0)
				{
				}
				num = (short)2007826432;
				short num3 = num;
				num = (short)1620377601;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x000957D8 File Offset: 0x000939D8
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x00095894 File Offset: 0x00093A94
		public bool TopButton1FeatureIsAcpEditable
		{
			get
			{
				short num = (short)302573134;
				short num2 = num;
				num = (short)592504398;
				switch (num2 == num)
				{
				}
				num = (short)749993985;
				if (num != 0)
				{
				}
				num = (short)1465778176;
				short num3 = num;
				num = (short)429064192;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1574848070;
				short num2 = num;
				num = (short)1060783686;
				switch (num2 == num)
				{
				}
				num = (short)1282342913;
				if (num != 0)
				{
				}
				num = (short)508297216;
				short num3 = num;
				num = (short)530382848;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00095950 File Offset: 0x00093B50
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00095A08 File Offset: 0x00093C08
		public string TopButton1FeatureUIValue
		{
			get
			{
				short num = (short)1666954516;
				short num2 = num;
				num = (short)830584084;
				switch (num2 == num)
				{
				}
				num = (short)520355840;
				if (num != 0)
				{
				}
				num = (short)2083979264;
				short num3 = num;
				num = (short)1827078145;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton1FeatureUIValueProperty);
			}
			set
			{
				short num = (short)33095681;
				if (num != 0)
				{
				}
				num = (short)637881028;
				short num2 = num;
				num = (short)790842052;
				switch (num2 == num)
				{
				}
				num = (short)501481472;
				short num3 = num;
				num = (short)1580335104;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1FeatureUIValueProperty, value);
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00095ABC File Offset: 0x00093CBC
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00095B74 File Offset: 0x00093D74
		public AcpListField TopButton1FeatureList
		{
			get
			{
				short num = (short)2042058029;
				short num2 = num;
				num = (short)1824216365;
				switch (num2 == num)
				{
				}
				num = (short)1385103361;
				if (num != 0)
				{
				}
				num = (short)443809792;
				short num3 = num;
				num = (short)1493565440;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.TopButton1FeatureListProperty);
			}
			set
			{
				short num = (short)1658593820;
				short num2 = num;
				num = (short)1692869148;
				switch (num2 == num)
				{
				}
				num = (short)741670912;
				if (num != 0)
				{
				}
				num = (short)721879040;
				short num3 = num;
				num = (short)96993281;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1FeatureListProperty, value);
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00095C28 File Offset: 0x00093E28
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00095CE4 File Offset: 0x00093EE4
		public bool TopButton1IndexIsAcpValid
		{
			get
			{
				short num = (short)1956187019;
				short num2 = num;
				num = (short)28773259;
				switch (num2 == num)
				{
				}
				num = (short)1507393537;
				if (num != 0)
				{
				}
				num = (short)1504116736;
				short num3 = num;
				num = (short)350420992;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1148387329;
				if (num != 0)
				{
				}
				num = (short)1632628617;
				short num2 = num;
				num = (short)708571017;
				switch (num2 == num)
				{
				}
				num = (short)521011200;
				short num3 = num;
				num = (short)1653211136;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00095DA0 File Offset: 0x00093FA0
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00095E5C File Offset: 0x0009405C
		public bool TopButton1IndexIsAcpApplicable
		{
			get
			{
				short num = (short)1949842895;
				short num2 = num;
				num = (short)1887976911;
				switch (num2 == num)
				{
				}
				num = (short)257556481;
				if (num != 0)
				{
				}
				num = (short)1686175744;
				short num3 = num;
				num = (short)1144651776;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)742363335;
				short num2 = num;
				num = (short)2023067847;
				switch (num2 == num)
				{
				}
				num = (short)2050818048;
				if (num != 0)
				{
				}
				num = (short)1096810496;
				short num3 = num;
				num = (short)187695105;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00095F18 File Offset: 0x00094118
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x00095FD0 File Offset: 0x000941D0
		public bool TopButton1IndexIsAcpVisible
		{
			get
			{
				short num = (short)718209025;
				if (num != 0)
				{
				}
				num = (short)1923059019;
				short num2 = num;
				num = (short)833785163;
				switch (num2 == num)
				{
				}
				num = (short)899874816;
				short num3 = num;
				num = (short)295370752;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1894000673;
				short num2 = num;
				num = (short)960047137;
				switch (num2 == num)
				{
				}
				num = (short)1288634369;
				if (num != 0)
				{
				}
				num = (short)2097152000;
				short num3 = num;
				num = (short)1782841344;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00096088 File Offset: 0x00094288
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00096140 File Offset: 0x00094340
		public bool TopButton1IndexIsAcpEditable
		{
			get
			{
				short num = (short)1265695989;
				short num2 = num;
				num = (short)544275701;
				switch (num2 == num)
				{
				}
				num = (short)1743323136;
				if (num != 0)
				{
				}
				num = (short)797573120;
				short num3 = num;
				num = (short)1870397441;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)721811742;
				short num2 = num;
				num = (short)112261406;
				switch (num2 == num)
				{
				}
				num = (short)1367932929;
				if (num != 0)
				{
				}
				num = (short)1565589504;
				short num3 = num;
				num = (short)529596416;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x000961F8 File Offset: 0x000943F8
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x000962B4 File Offset: 0x000944B4
		public string TopButton1IndexUIValue
		{
			get
			{
				short num = (short)191415340;
				short num2 = num;
				num = (short)364823596;
				switch (num2 == num)
				{
				}
				num = (short)516620289;
				if (num != 0)
				{
				}
				num = (short)1865744384;
				short num3 = num;
				num = (short)1716322304;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton1IndexUIValueProperty);
			}
			set
			{
				short num = (short)1876514475;
				short num2 = num;
				num = (short)71521963;
				switch (num2 == num)
				{
				}
				num = (short)2115567617;
				if (num != 0)
				{
				}
				num = (short)1194459136;
				short num3 = num;
				num = (short)837287936;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1IndexUIValueProperty, value);
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0009636C File Offset: 0x0009456C
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00096428 File Offset: 0x00094628
		public AcpListField TopButton1IndexList
		{
			get
			{
				short num = (short)1438422357;
				short num2 = num;
				num = (short)237016405;
				switch (num2 == num)
				{
				}
				num = (short)459276289;
				if (num != 0)
				{
				}
				num = (short)1176895488;
				short num3 = num;
				num = (short)407240704;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.TopButton1IndexListProperty);
			}
			set
			{
				short num = (short)1980580705;
				short num2 = num;
				num = (short)1986937697;
				switch (num2 == num)
				{
				}
				num = (short)963313665;
				if (num != 0)
				{
				}
				num = (short)1209925632;
				short num3 = num;
				num = (short)2019033088;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1IndexListProperty, value);
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x000964E0 File Offset: 0x000946E0
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00096598 File Offset: 0x00094798
		public bool TopButton2FeatureIsAcpValid
		{
			get
			{
				short num = (short)199587254;
				short num2 = num;
				num = (short)1266709942;
				switch (num2 == num)
				{
				}
				num = (short)203948033;
				if (num != 0)
				{
				}
				num = (short)750321664;
				short num3 = num;
				num = (short)1290010624;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1410859009;
				if (num != 0)
				{
				}
				num = (short)887097501;
				short num2 = num;
				num = (short)1832781981;
				switch (num2 == num)
				{
				}
				num = (short)715587584;
				short num3 = num;
				num = (short)1666580480;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00096654 File Offset: 0x00094854
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x00096710 File Offset: 0x00094910
		public bool TopButton2FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)635331403;
				short num2 = num;
				num = (short)1854628683;
				switch (num2 == num)
				{
				}
				num = (short)1888419840;
				if (num != 0)
				{
				}
				num = (short)1651638272;
				short num3 = num;
				num = (short)1057685505;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2144438842;
				short num2 = num;
				num = (short)1846905402;
				switch (num2 == num)
				{
				}
				num = (short)1461059584;
				if (num != 0)
				{
				}
				num = (short)263192576;
				short num3 = num;
				num = (short)1070596097;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x000967CC File Offset: 0x000949CC
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x00096888 File Offset: 0x00094A88
		public bool TopButton2FeatureIsAcpVisible
		{
			get
			{
				short num = (short)72268265;
				short num2 = num;
				num = (short)1258535401;
				switch (num2 == num)
				{
				}
				num = (short)1626472448;
				if (num != 0)
				{
				}
				num = (short)1914634240;
				short num3 = num;
				num = (short)1342636033;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1303896429;
				short num2 = num;
				num = (short)1031725421;
				switch (num2 == num)
				{
				}
				num = (short)1234042881;
				if (num != 0)
				{
				}
				num = (short)619839488;
				short num3 = num;
				num = (short)148045824;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00096944 File Offset: 0x00094B44
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x000969FC File Offset: 0x00094BFC
		public bool TopButton2FeatureIsAcpEditable
		{
			get
			{
				short num = (short)684225068;
				short num2 = num;
				num = (short)40399404;
				switch (num2 == num)
				{
				}
				num = (short)2143879169;
				if (num != 0)
				{
				}
				num = (short)95092736;
				short num3 = num;
				num = (short)833159168;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1711517362;
				short num2 = num;
				num = (short)1721347762;
				switch (num2 == num)
				{
				}
				num = (short)611123200;
				if (num != 0)
				{
				}
				num = (short)252444672;
				short num3 = num;
				num = (short)565772289;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00096AB8 File Offset: 0x00094CB8
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x00096B74 File Offset: 0x00094D74
		public string TopButton2FeatureUIValue
		{
			get
			{
				short num = (short)1921199668;
				short num2 = num;
				num = (short)2006003252;
				switch (num2 == num)
				{
				}
				num = (short)1775566849;
				if (num != 0)
				{
				}
				num = (short)1848442880;
				short num3 = num;
				num = (short)1574830080;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton2FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1349050274;
				short num2 = num;
				num = (short)897441698;
				switch (num2 == num)
				{
				}
				num = (short)1118306305;
				if (num != 0)
				{
				}
				num = (short)788463616;
				short num3 = num;
				num = (short)1666449408;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2FeatureUIValueProperty, value);
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00096C2C File Offset: 0x00094E2C
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x00096CE8 File Offset: 0x00094EE8
		public AcpListField TopButton2FeatureList
		{
			get
			{
				short num = (short)1291714561;
				if (num != 0)
				{
				}
				num = (short)1443963370;
				short num2 = num;
				num = (short)1236410858;
				switch (num2 == num)
				{
				}
				num = (short)680787968;
				short num3 = num;
				num = (short)496304128;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.TopButton2FeatureListProperty);
			}
			set
			{
				short num = (short)2143708967;
				short num2 = num;
				num = (short)398878503;
				switch (num2 == num)
				{
				}
				num = (short)314769408;
				if (num != 0)
				{
				}
				num = (short)451608576;
				short num3 = num;
				num = (short)18612225;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2FeatureListProperty, value);
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00096DA0 File Offset: 0x00094FA0
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x00096E5C File Offset: 0x0009505C
		public bool TopButton2IndexIsAcpValid
		{
			get
			{
				short num = (short)652247422;
				short num2 = num;
				num = (short)70025598;
				switch (num2 == num)
				{
				}
				num = (short)1745420289;
				if (num != 0)
				{
				}
				num = (short)1132134400;
				short num3 = num;
				num = (short)1910439936;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)579280396;
				short num2 = num;
				num = (short)1472142860;
				switch (num2 == num)
				{
				}
				num = (short)59899905;
				if (num != 0)
				{
				}
				num = (short)798621696;
				short num3 = num;
				num = (short)1385824256;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00096F1C File Offset: 0x0009511C
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x00096FD8 File Offset: 0x000951D8
		public bool TopButton2IndexIsAcpApplicable
		{
			get
			{
				short num = (short)1215787594;
				short num2 = num;
				num = (short)2051568202;
				switch (num2 == num)
				{
				}
				num = (short)1246953473;
				if (num != 0)
				{
				}
				num = (short)546373632;
				short num3 = num;
				num = (short)486408192;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1465380053;
				short num2 = num;
				num = (short)888204501;
				switch (num2 == num)
				{
				}
				num = (short)2031353857;
				if (num != 0)
				{
				}
				num = (short)203751424;
				short num3 = num;
				num = (short)887422976;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00097090 File Offset: 0x00095290
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x00097148 File Offset: 0x00095348
		public bool TopButton2IndexIsAcpVisible
		{
			get
			{
				short num = (short)963433958;
				short num2 = num;
				num = (short)1694422502;
				switch (num2 == num)
				{
				}
				num = (short)1068433409;
				if (num != 0)
				{
				}
				num = (short)1660223488;
				short num3 = num;
				num = (short)1758789632;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1485635585;
				if (num != 0)
				{
				}
				num = (short)631948439;
				short num2 = num;
				num = (short)1713685655;
				switch (num2 == num)
				{
				}
				num = (short)418381824;
				short num3 = num;
				num = (short)185335808;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00097200 File Offset: 0x00095400
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x000972B8 File Offset: 0x000954B8
		public bool TopButton2IndexIsAcpEditable
		{
			get
			{
				short num = (short)2097682108;
				short num2 = num;
				num = (short)1963005628;
				switch (num2 == num)
				{
				}
				num = (short)920256513;
				if (num != 0)
				{
				}
				num = (short)78118912;
				short num3 = num;
				num = (short)45416448;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1731306031;
				short num2 = num;
				num = (short)490316335;
				switch (num2 == num)
				{
				}
				num = (short)1098711041;
				if (num != 0)
				{
				}
				num = (short)1613889536;
				short num3 = num;
				num = (short)328073216;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00097374 File Offset: 0x00095574
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00097430 File Offset: 0x00095630
		public string TopButton2IndexUIValue
		{
			get
			{
				short num = (short)1429078017;
				if (num != 0)
				{
				}
				num = (short)969028409;
				short num2 = num;
				num = (short)813118265;
				switch (num2 == num)
				{
				}
				num = (short)1853947904;
				short num3 = num;
				num = (short)1292828672;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton2IndexUIValueProperty);
			}
			set
			{
				short num = (short)620101633;
				if (num != 0)
				{
				}
				num = (short)393281363;
				short num2 = num;
				num = (short)695926611;
				switch (num2 == num)
				{
				}
				num = (short)320471040;
				short num3 = num;
				num = (short)959709184;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2IndexUIValueProperty, value);
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x000974E8 File Offset: 0x000956E8
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x000975A0 File Offset: 0x000957A0
		public AcpListField TopButton2IndexList
		{
			get
			{
				short num = (short)732617295;
				short num2 = num;
				num = (short)469686863;
				switch (num2 == num)
				{
				}
				num = (short)1089601537;
				if (num != 0)
				{
				}
				num = (short)428998656;
				if (num != 0)
				{
				}
				num = (short)1659502592;
				short num3 = num;
				return (AcpListField)base.GetValue(O9GraphicView.TopButton2IndexListProperty);
			}
			set
			{
				short num = (short)99483649;
				if (num != 0)
				{
				}
				num = (short)969111327;
				short num2 = num;
				num = (short)1399420703;
				switch (num2 == num)
				{
				}
				num = (short)1261699072;
				if (num != 0)
				{
				}
				num = (short)1363542016;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton2IndexListProperty, value);
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00097654 File Offset: 0x00095854
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00097710 File Offset: 0x00095910
		public bool TopButton3FeatureIsAcpValid
		{
			get
			{
				short num = (short)2084156253;
				short num2 = num;
				num = (short)2137961309;
				switch (num2 == num)
				{
				}
				num = (short)2071658497;
				if (num != 0)
				{
				}
				num = (short)796524544;
				if (num != 0)
				{
				}
				num = (short)743440384;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton3FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1189019649;
				if (num != 0)
				{
				}
				num = (short)1906958014;
				short num2 = num;
				num = (short)1732173502;
				switch (num2 == num)
				{
				}
				num = (short)123011072;
				if (num != 0)
				{
				}
				num = (short)1186004992;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton3FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x000977CC File Offset: 0x000959CC
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00097880 File Offset: 0x00095A80
		public bool TopButton3FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)256473891;
				short num2 = num;
				num = (short)174816035;
				switch (num2 == num)
				{
				}
				num = (short)1522073601;
				if (num != 0)
				{
				}
				num = (short)243400704;
				if (num != 0)
				{
				}
				num = (short)613548032;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton3FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1098328716;
				short num2 = num;
				num = (short)698100364;
				switch (num2 == num)
				{
				}
				num = (short)1884815361;
				if (num != 0)
				{
				}
				num = (short)1764491264;
				if (num != 0)
				{
				}
				num = (short)1830682624;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton3FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0009793C File Offset: 0x00095B3C
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x000979F4 File Offset: 0x00095BF4
		public bool TopButton3FeatureIsAcpVisible
		{
			get
			{
				short num = (short)823192824;
				short num2 = num;
				num = (short)638774520;
				switch (num2 == num)
				{
				}
				num = (short)1638268929;
				if (num != 0)
				{
				}
				num = (short)251330560;
				if (num != 0)
				{
				}
				num = (short)323354624;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton3FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)426709755;
				short num2 = num;
				num = (short)493884155;
				switch (num2 == num)
				{
				}
				num = (short)1647968257;
				if (num != 0)
				{
				}
				num = (short)1960706048;
				if (num != 0)
				{
				}
				num = (short)1578434560;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton3FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00097AAC File Offset: 0x00095CAC
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00097B64 File Offset: 0x00095D64
		public bool TopButton3FeatureIsAcpEditable
		{
			get
			{
				short num = (short)861470721;
				if (num != 0)
				{
				}
				num = (short)693516570;
				short num2 = num;
				num = (short)1884109082;
				switch (num2 == num)
				{
				}
				num = (short)927793152;
				if (num != 0)
				{
				}
				num = (short)1463025664;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton3FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)521957870;
				short num2 = num;
				num = (short)2094363118;
				switch (num2 == num)
				{
				}
				num = (short)494600193;
				if (num != 0)
				{
				}
				num = (short)672464896;
				if (num != 0)
				{
				}
				num = (short)1978662912;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton3FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00097C20 File Offset: 0x00095E20
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00097CDC File Offset: 0x00095EDC
		public string TopButton3FeatureUIValue
		{
			get
			{
				short num = (short)1992123272;
				short num2 = num;
				num = (short)2057096;
				switch (num2 == num)
				{
				}
				num = (short)1633288193;
				if (num != 0)
				{
				}
				num = (short)551157760;
				if (num != 0)
				{
				}
				num = (short)1573453824;
				short num3 = num;
				return (string)base.GetValue(O9GraphicView.TopButton3FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1929294197;
				short num2 = num;
				num = (short)698986869;
				switch (num2 == num)
				{
				}
				num = (short)2068971520;
				if (num != 0)
				{
				}
				num = (short)2041577473;
				if (num != 0)
				{
				}
				num = (short)909836288;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton3FeatureUIValueProperty, value);
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00097D90 File Offset: 0x00095F90
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x00097E48 File Offset: 0x00096048
		public AcpListField TopButton3FeatureList
		{
			get
			{
				short num = (short)1507564832;
				short num2 = num;
				num = (short)247438624;
				switch (num2 == num)
				{
				}
				num = (short)1855782912;
				if (num != 0)
				{
				}
				num = (short)447021057;
				if (num != 0)
				{
				}
				num = (short)1534394368;
				short num3 = num;
				return (AcpListField)base.GetValue(O9GraphicView.TopButton3FeatureListProperty);
			}
			set
			{
				short num = (short)955104011;
				short num2 = num;
				num = (short)1353759499;
				switch (num2 == num)
				{
				}
				num = (short)1753939969;
				if (num != 0)
				{
				}
				num = (short)928514048;
				if (num != 0)
				{
				}
				num = (short)438566912;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton3FeatureListProperty, value);
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00097EFC File Offset: 0x000960FC
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00097FB4 File Offset: 0x000961B4
		public bool TopButton3IndexIsAcpValid
		{
			get
			{
				short num = (short)1082547900;
				short num2 = num;
				num = (short)772103868;
				switch (num2 == num)
				{
				}
				num = (short)1859452929;
				if (num != 0)
				{
				}
				num = (short)1028128768;
				if (num != 0)
				{
				}
				num = (short)574619648;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton3IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)2032426003;
				short num2 = num;
				num = (short)1015831571;
				switch (num2 == num)
				{
				}
				num = (short)1276248065;
				if (num != 0)
				{
				}
				num = (short)927793152;
				if (num != 0)
				{
				}
				num = (short)2132017152;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton3IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00098070 File Offset: 0x00096270
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00098128 File Offset: 0x00096328
		public bool TopButton3IndexIsAcpApplicable
		{
			get
			{
				short num = (short)176000093;
				short num2 = num;
				num = (short)1875676253;
				switch (num2 == num)
				{
				}
				num = (short)1289158657;
				if (num != 0)
				{
				}
				num = (short)1195638784;
				if (num != 0)
				{
				}
				num = (short)465764352;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton3IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)112579495;
				short num2 = num;
				num = (short)1596838823;
				switch (num2 == num)
				{
				}
				num = (short)2063663105;
				if (num != 0)
				{
				}
				num = (short)207028224;
				if (num != 0)
				{
				}
				num = (short)1324154880;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton3IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x000981E0 File Offset: 0x000963E0
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00098298 File Offset: 0x00096498
		public bool TopButton3IndexIsAcpVisible
		{
			get
			{
				short num = (short)1963382936;
				short num2 = num;
				num = (short)64739480;
				switch (num2 == num)
				{
				}
				num = (short)370343937;
				if (num != 0)
				{
				}
				num = (short)875560960;
				if (num != 0)
				{
				}
				num = (short)1283129344;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton3IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)799516283;
				short num2 = num;
				num = (short)579380859;
				switch (num2 == num)
				{
				}
				num = (short)428998657;
				if (num != 0)
				{
				}
				num = (short)172621824;
				if (num != 0)
				{
				}
				num = (short)1013186560;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton3IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00098350 File Offset: 0x00096550
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x0009840C File Offset: 0x0009660C
		public bool TopButton3IndexIsAcpEditable
		{
			get
			{
				short num = (short)2106782695;
				short num2 = num;
				num = (short)378008551;
				switch (num2 == num)
				{
				}
				num = (short)1290403841;
				if (num != 0)
				{
				}
				num = (short)2050490368;
				if (num != 0)
				{
				}
				num = (short)1583939584;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton3IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)599141353;
				short num2 = num;
				num = (short)2120625129;
				switch (num2 == num)
				{
				}
				num = (short)292749313;
				if (num != 0)
				{
				}
				num = (short)1970274304;
				if (num != 0)
				{
				}
				num = (short)532742144;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton3IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x000984C8 File Offset: 0x000966C8
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x00098584 File Offset: 0x00096784
		public string TopButton3IndexUIValue
		{
			get
			{
				short num = (short)1751056385;
				if (num != 0)
				{
				}
				num = (short)473681311;
				short num2 = num;
				num = (short)690867615;
				switch (num2 == num)
				{
				}
				num = (short)1876688896;
				if (num != 0)
				{
				}
				num = (short)374865920;
				short num3 = num;
				return (string)base.GetValue(O9GraphicView.TopButton3IndexUIValueProperty);
			}
			set
			{
				short num = (short)1900140199;
				short num2 = num;
				num = (short)1789515431;
				switch (num2 == num)
				{
				}
				num = (short)1892548609;
				if (num != 0)
				{
				}
				num = (short)1667432448;
				if (num != 0)
				{
				}
				num = (short)219938816;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton3IndexUIValueProperty, value);
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00098638 File Offset: 0x00096838
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x000986F4 File Offset: 0x000968F4
		public AcpListField TopButton3IndexList
		{
			get
			{
				short num = (short)1475612489;
				short num2 = num;
				num = (short)837291849;
				switch (num2 == num)
				{
				}
				num = (short)1063190529;
				if (num != 0)
				{
				}
				num = (short)1755316224;
				if (num != 0)
				{
				}
				num = (short)867500032;
				short num3 = num;
				return (AcpListField)base.GetValue(O9GraphicView.TopButton3IndexListProperty);
			}
			set
			{
				short num = (short)578973503;
				short num2 = num;
				num = (short)1506373439;
				switch (num2 == num)
				{
				}
				num = (short)430702593;
				if (num != 0)
				{
				}
				num = (short)10747904;
				if (num != 0)
				{
				}
				num = (short)999161856;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton3IndexListProperty, value);
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x000987AC File Offset: 0x000969AC
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00098864 File Offset: 0x00096A64
		public bool TopButton4FeatureIsAcpValid
		{
			get
			{
				short num = (short)445756887;
				short num2 = num;
				num = (short)1848423895;
				switch (num2 == num)
				{
				}
				num = (short)459735041;
				if (num != 0)
				{
				}
				num = (short)624623616;
				if (num != 0)
				{
				}
				num = (short)721879040;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton4FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)637341728;
				short num2 = num;
				num = (short)903024672;
				switch (num2 == num)
				{
				}
				num = (short)2115108865;
				if (num != 0)
				{
				}
				num = (short)1944256512;
				if (num != 0)
				{
				}
				num = (short)1135673344;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00098920 File Offset: 0x00096B20
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x000989D8 File Offset: 0x00096BD8
		public bool TopButton4FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)502211383;
				short num2 = num;
				num = (short)1866081079;
				switch (num2 == num)
				{
				}
				num = (short)1515520001;
				if (num != 0)
				{
				}
				num = (short)680329216;
				if (num != 0)
				{
				}
				num = (short)100204544;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton4FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1489960853;
				short num2 = num;
				num = (short)913309589;
				switch (num2 == num)
				{
				}
				num = (short)1911488513;
				if (num != 0)
				{
				}
				num = (short)1618870272;
				if (num != 0)
				{
				}
				num = (short)1563033600;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00098A98 File Offset: 0x00096C98
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x00098B4C File Offset: 0x00096D4C
		public bool TopButton4FeatureIsAcpVisible
		{
			get
			{
				short num = (short)2034892801;
				if (num != 0)
				{
				}
				num = (short)2043035630;
				short num2 = num;
				num = (short)102711278;
				switch (num2 == num)
				{
				}
				num = (short)1861091328;
				if (num != 0)
				{
				}
				num = (short)1350041600;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton4FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1038086950;
				short num2 = num;
				num = (short)1346564902;
				switch (num2 == num)
				{
				}
				num = (short)1135738881;
				if (num != 0)
				{
				}
				num = (short)681574400;
				if (num != 0)
				{
				}
				num = (short)49217536;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00098C04 File Offset: 0x00096E04
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00098CC0 File Offset: 0x00096EC0
		public bool TopButton4FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1400639528;
				short num2 = num;
				num = (short)1438978088;
				switch (num2 == num)
				{
				}
				num = (short)2100559873;
				if (num != 0)
				{
				}
				num = (short)609353728;
				if (num != 0)
				{
				}
				num = (short)893845504;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton4FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1809282658;
				short num2 = num;
				num = (short)173504098;
				switch (num2 == num)
				{
				}
				num = (short)1735393281;
				if (num != 0)
				{
				}
				num = (short)593035264;
				if (num != 0)
				{
				}
				num = (short)1348009984;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00098D78 File Offset: 0x00096F78
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00098E30 File Offset: 0x00097030
		public string TopButton4FeatureUIValue
		{
			get
			{
				short num = (short)1395797582;
				short num2 = num;
				num = (short)613297742;
				switch (num2 == num)
				{
				}
				num = (short)1134428161;
				if (num != 0)
				{
				}
				num = (short)1435697152;
				if (num != 0)
				{
				}
				num = (short)883032064;
				short num3 = num;
				return (string)base.GetValue(O9GraphicView.TopButton4FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1314253868;
				short num2 = num;
				num = (short)1420553260;
				switch (num2 == num)
				{
				}
				num = (short)277282817;
				if (num != 0)
				{
				}
				num = (short)1456996352;
				if (num != 0)
				{
				}
				num = (short)1525809152;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4FeatureUIValueProperty, value);
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00098EE8 File Offset: 0x000970E8
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00098FA0 File Offset: 0x000971A0
		public AcpListField TopButton4FeatureList
		{
			get
			{
				short num = (short)1107558401;
				if (num != 0)
				{
				}
				num = (short)1819989725;
				short num2 = num;
				num = (short)1469306589;
				switch (num2 == num)
				{
				}
				num = (short)1984233472;
				if (num != 0)
				{
				}
				num = (short)107806720;
				short num3 = num;
				return (AcpListField)base.GetValue(O9GraphicView.TopButton4FeatureListProperty);
			}
			set
			{
				short num = (short)754244395;
				short num2 = num;
				num = (short)220060459;
				switch (num2 == num)
				{
				}
				num = (short)115867648;
				if (num != 0)
				{
				}
				num = (short)1132396545;
				if (num != 0)
				{
				}
				num = (short)1095892992;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4FeatureListProperty, value);
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00099058 File Offset: 0x00097258
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00099110 File Offset: 0x00097310
		public bool TopButton4IndexIsAcpValid
		{
			get
			{
				short num = (short)2090821193;
				short num2 = num;
				num = (short)1338402377;
				switch (num2 == num)
				{
				}
				num = (short)1273430017;
				if (num != 0)
				{
				}
				num = (short)509607936;
				if (num != 0)
				{
				}
				num = (short)1348599808;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton4IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)407193503;
				short num2 = num;
				num = (short)355944351;
				switch (num2 == num)
				{
				}
				num = (short)826408961;
				if (num != 0)
				{
				}
				num = (short)2058616832;
				if (num != 0)
				{
				}
				num = (short)1314193408;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x000991CC File Offset: 0x000973CC
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00099284 File Offset: 0x00097484
		public bool TopButton4IndexIsAcpApplicable
		{
			get
			{
				short num = (short)1505673657;
				short num2 = num;
				num = (short)1913438649;
				switch (num2 == num)
				{
				}
				num = (short)1015545857;
				if (num != 0)
				{
				}
				num = (short)480247808;
				if (num != 0)
				{
				}
				num = (short)805699584;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton4IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1150163768;
				short num2 = num;
				num = (short)383130424;
				switch (num2 == num)
				{
				}
				num = (short)1210449921;
				if (num != 0)
				{
				}
				num = (short)1742536704;
				if (num != 0)
				{
				}
				num = (short)1792147456;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00099340 File Offset: 0x00097540
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x000993F8 File Offset: 0x000975F8
		public bool TopButton4IndexIsAcpVisible
		{
			get
			{
				short num = (short)963094151;
				short num2 = num;
				num = (short)1928046215;
				switch (num2 == num)
				{
				}
				num = (short)776601601;
				if (num != 0)
				{
				}
				num = (short)1749942272;
				if (num != 0)
				{
				}
				num = (short)249823232;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton4IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1035513852;
				short num2 = num;
				num = (short)473935868;
				switch (num2 == num)
				{
				}
				num = (short)1003028481;
				if (num != 0)
				{
				}
				num = (short)1703804928;
				if (num != 0)
				{
				}
				num = (short)756547584;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x000994B4 File Offset: 0x000976B4
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x00099570 File Offset: 0x00097770
		public bool TopButton4IndexIsAcpEditable
		{
			get
			{
				short num = (short)95749022;
				short num2 = num;
				num = (short)1632109470;
				switch (num2 == num)
				{
				}
				num = (short)18874369;
				if (num != 0)
				{
				}
				num = (short)294387712;
				if (num != 0)
				{
				}
				num = (short)2140798976;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton4IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1323814921;
				short num2 = num;
				num = (short)799002633;
				switch (num2 == num)
				{
				}
				num = (short)1064828929;
				if (num != 0)
				{
				}
				num = (short)1552220160;
				if (num != 0)
				{
				}
				num = (short)51118080;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0009962C File Offset: 0x0009782C
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x000996E4 File Offset: 0x000978E4
		public string TopButton4IndexUIValue
		{
			get
			{
				short num = (short)214532331;
				short num2 = num;
				num = (short)1651736811;
				switch (num2 == num)
				{
				}
				num = (short)1749942273;
				if (num != 0)
				{
				}
				num = (short)43581440;
				if (num != 0)
				{
				}
				num = (short)1401094144;
				short num3 = num;
				return (string)base.GetValue(O9GraphicView.TopButton4IndexUIValueProperty);
			}
			set
			{
				short num = (short)1870378814;
				short num2 = num;
				num = (short)1332721470;
				switch (num2 == num)
				{
				}
				num = (short)913768448;
				if (num != 0)
				{
				}
				num = (short)1674903553;
				if (num != 0)
				{
				}
				num = (short)1111752704;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4IndexUIValueProperty, value);
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00099798 File Offset: 0x00097998
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x00099854 File Offset: 0x00097A54
		public AcpListField TopButton4IndexList
		{
			get
			{
				short num = (short)781815320;
				short num2 = num;
				num = (short)7966232;
				switch (num2 == num)
				{
				}
				num = (short)1483538433;
				if (num != 0)
				{
				}
				num = (short)366280704;
				if (num != 0)
				{
				}
				num = (short)320274432;
				short num3 = num;
				return (AcpListField)base.GetValue(O9GraphicView.TopButton4IndexListProperty);
			}
			set
			{
				short num = (short)1593442305;
				if (num != 0)
				{
				}
				num = (short)436173266;
				short num2 = num;
				num = (short)1027373522;
				switch (num2 == num)
				{
				}
				num = (short)1759969280;
				if (num != 0)
				{
				}
				num = (short)1825439744;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4IndexListProperty, value);
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0009990C File Offset: 0x00097B0C
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x000999C4 File Offset: 0x00097BC4
		public bool TopButton5FeatureIsAcpValid
		{
			get
			{
				short num = (short)1019820090;
				short num2 = num;
				num = (short)207108154;
				switch (num2 == num)
				{
				}
				num = (short)394592257;
				if (num != 0)
				{
				}
				num = (short)886702080;
				if (num != 0)
				{
				}
				num = (short)1630273536;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton5FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1899643669;
				short num2 = num;
				num = (short)1882735381;
				switch (num2 == num)
				{
				}
				num = (short)1876033536;
				if (num != 0)
				{
				}
				num = (short)1730805761;
				if (num != 0)
				{
				}
				num = (short)1487405056;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton5FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00099A80 File Offset: 0x00097C80
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x00099B38 File Offset: 0x00097D38
		public bool TopButton5FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1610612737;
				if (num != 0)
				{
				}
				num = (short)480496022;
				short num2 = num;
				num = (short)1801767318;
				switch (num2 == num)
				{
				}
				num = (short)958595072;
				if (num != 0)
				{
				}
				num = (short)1458438144;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton5FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)406555837;
				short num2 = num;
				num = (short)700812477;
				switch (num2 == num)
				{
				}
				num = (short)863961089;
				if (num != 0)
				{
				}
				num = (short)662437888;
				if (num != 0)
				{
				}
				num = (short)1078263808;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton5FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00099BF0 File Offset: 0x00097DF0
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x00099CA8 File Offset: 0x00097EA8
		public bool TopButton5FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1271139180;
				short num2 = num;
				num = (short)623250284;
				switch (num2 == num)
				{
				}
				num = (short)899940353;
				if (num != 0)
				{
				}
				num = (short)1169162240;
				if (num != 0)
				{
				}
				num = (short)1445199872;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton5FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1609302017;
				if (num != 0)
				{
				}
				num = (short)151301734;
				short num2 = num;
				num = (short)2095230566;
				switch (num2 == num)
				{
				}
				num = (short)1221197824;
				if (num != 0)
				{
				}
				num = (short)1767571456;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton5FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00099D64 File Offset: 0x00097F64
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x00099E20 File Offset: 0x00098020
		public bool TopButton5FeatureIsAcpEditable
		{
			get
			{
				short num = (short)9895937;
				if (num != 0)
				{
				}
				num = (short)148679040;
				short num2 = num;
				num = (short)1908386176;
				switch (num2 == num)
				{
				}
				num = (short)820772864;
				if (num != 0)
				{
				}
				num = (short)29097984;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton5FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1416551605;
				short num2 = num;
				num = (short)196795573;
				switch (num2 == num)
				{
				}
				num = (short)491847681;
				if (num != 0)
				{
				}
				num = (short)2108293120;
				if (num != 0)
				{
				}
				num = (short)126550016;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton5FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00099EDC File Offset: 0x000980DC
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x00099F98 File Offset: 0x00098198
		public string TopButton5FeatureUIValue
		{
			get
			{
				short num = (short)275959668;
				short num2 = num;
				num = (short)1138806644;
				switch (num2 == num)
				{
				}
				num = (short)1848770561;
				if (num != 0)
				{
				}
				num = (short)262340608;
				if (num != 0)
				{
				}
				num = (short)88866816;
				short num3 = num;
				return (string)base.GetValue(O9GraphicView.TopButton5FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1915882467;
				short num2 = num;
				num = (short)990383075;
				switch (num2 == num)
				{
				}
				num = (short)1492123649;
				if (num != 0)
				{
				}
				num = (short)543424512;
				if (num != 0)
				{
				}
				num = (short)825098240;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton5FeatureUIValueProperty, value);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x0009A050 File Offset: 0x00098250
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x0009A10C File Offset: 0x0009830C
		public AcpListField TopButton5FeatureList
		{
			get
			{
				short num = (short)1766749365;
				short num2 = num;
				num = (short)914781365;
				switch (num2 == num)
				{
				}
				num = (short)463011840;
				if (num != 0)
				{
				}
				num = (short)1971322881;
				if (num != 0)
				{
				}
				num = (short)1020788736;
				short num3 = num;
				return (AcpListField)base.GetValue(O9GraphicView.TopButton5FeatureListProperty);
			}
			set
			{
				short num = (short)1248582872;
				short num2 = num;
				num = (short)1665916120;
				switch (num2 == num)
				{
				}
				num = (short)1987772416;
				if (num != 0)
				{
				}
				num = (short)188743681;
				if (num != 0)
				{
				}
				num = (short)692256768;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton5FeatureListProperty, value);
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x0009A1C4 File Offset: 0x000983C4
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x0009A27C File Offset: 0x0009847C
		public bool TopButton5IndexIsAcpValid
		{
			get
			{
				short num = (short)618463233;
				if (num != 0)
				{
				}
				num = (short)958853059;
				short num2 = num;
				num = (short)1560801219;
				switch (num2 == num)
				{
				}
				num = (short)1271136256;
				if (num != 0)
				{
				}
				num = (short)252706816;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton5IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)31996293;
				short num2 = num;
				num = (short)1787771269;
				switch (num2 == num)
				{
				}
				num = (short)2133458945;
				if (num != 0)
				{
				}
				num = (short)1541537792;
				if (num != 0)
				{
				}
				num = (short)214040576;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton5IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0009A338 File Offset: 0x00098538
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x0009A3F0 File Offset: 0x000985F0
		public bool TopButton5IndexIsAcpApplicable
		{
			get
			{
				short num = (short)1503801855;
				short num2 = num;
				num = (short)628371967;
				switch (num2 == num)
				{
				}
				num = (short)1904541697;
				if (num != 0)
				{
				}
				num = (short)235601920;
				if (num != 0)
				{
				}
				num = (short)1733885952;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton5IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1267662849;
				if (num != 0)
				{
				}
				num = (short)1682665570;
				short num2 = num;
				num = (short)2061856866;
				switch (num2 == num)
				{
				}
				num = (short)1809121280;
				if (num != 0)
				{
				}
				num = (short)1575682048;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton5IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0009A4AC File Offset: 0x000986AC
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x0009A564 File Offset: 0x00098764
		public bool TopButton5IndexIsAcpVisible
		{
			get
			{
				short num = (short)269328717;
				short num2 = num;
				num = (short)840671565;
				switch (num2 == num)
				{
				}
				num = (short)1496580097;
				if (num != 0)
				{
				}
				num = (short)1866530816;
				if (num != 0)
				{
				}
				num = (short)1621098496;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton5IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1052976830;
				short num2 = num;
				num = (short)628369086;
				switch (num2 == num)
				{
				}
				num = (short)1123024897;
				if (num != 0)
				{
				}
				num = (short)245563392;
				if (num != 0)
				{
				}
				num = (short)40042496;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton5IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0009A620 File Offset: 0x00098820
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x0009A6E0 File Offset: 0x000988E0
		public bool TopButton5IndexIsAcpEditable
		{
			get
			{
				short num = (short)82742461;
				short num2 = num;
				num = (short)548244669;
				switch (num2 == num)
				{
				}
				num = (short)132972544;
				if (num != 0)
				{
				}
				num = (short)1387069441;
				if (num != 0)
				{
				}
				num = (short)501350400;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton5IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2031121040;
				short num2 = num;
				num = (short)297038480;
				switch (num2 == num)
				{
				}
				num = (short)511574017;
				if (num != 0)
				{
				}
				num = (short)1160314880;
				if (num != 0)
				{
				}
				num = (short)1875705856;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton5IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x0009A79C File Offset: 0x0009899C
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x0009A858 File Offset: 0x00098A58
		public string TopButton5IndexUIValue
		{
			get
			{
				short num = (short)840074550;
				short num2 = num;
				num = (short)1929545014;
				switch (num2 == num)
				{
				}
				num = (short)164560897;
				if (num != 0)
				{
				}
				num = (short)1920466944;
				if (num != 0)
				{
				}
				num = (short)1174405120;
				short num3 = num;
				return (string)base.GetValue(O9GraphicView.TopButton5IndexUIValueProperty);
			}
			set
			{
				short num = (short)1080471857;
				short num2 = num;
				num = (short)1042854193;
				switch (num2 == num)
				{
				}
				num = (short)258211841;
				if (num != 0)
				{
				}
				num = (short)424083456;
				if (num != 0)
				{
				}
				num = (short)943194112;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton5IndexUIValueProperty, value);
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0009A910 File Offset: 0x00098B10
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x0009A9C8 File Offset: 0x00098BC8
		public AcpListField TopButton5IndexList
		{
			get
			{
				short num = (short)794914141;
				short num2 = num;
				num = (short)728264029;
				switch (num2 == num)
				{
				}
				num = (short)2019360768;
				if (num != 0)
				{
				}
				num = (short)1976958977;
				if (num != 0)
				{
				}
				num = (short)711983104;
				short num3 = num;
				return (AcpListField)base.GetValue(O9GraphicView.TopButton5IndexListProperty);
			}
			set
			{
				short num = (short)467992577;
				if (num != 0)
				{
				}
				num = (short)1280872696;
				short num2 = num;
				num = (short)2100465912;
				switch (num2 == num)
				{
				}
				num = (short)36110336;
				if (num != 0)
				{
				}
				num = (short)305987584;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton5IndexListProperty, value);
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0009AA80 File Offset: 0x00098C80
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x0009AB38 File Offset: 0x00098D38
		public bool TopButton1StsMsgIndexIsAcpValid
		{
			get
			{
				short num = (short)1491068098;
				short num2 = num;
				num = (short)2041177282;
				switch (num2 == num)
				{
				}
				num = (short)675872769;
				if (num != 0)
				{
				}
				num = (short)1683095552;
				if (num != 0)
				{
				}
				num = (short)708378624;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton1StsMsgIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1201799169;
				if (num != 0)
				{
				}
				num = (short)955308206;
				short num2 = num;
				num = (short)843438254;
				switch (num2 == num)
				{
				}
				num = (short)1106313216;
				if (num != 0)
				{
				}
				num = (short)574554112;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton1StsMsgIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0009ABF4 File Offset: 0x00098DF4
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x0009ACB0 File Offset: 0x00098EB0
		public bool TopButton1StsMsgIndexIsAcpApplicable
		{
			get
			{
				short num = (short)76318049;
				short num2 = num;
				num = (short)1402897761;
				switch (num2 == num)
				{
				}
				num = (short)1864040448;
				if (num != 0)
				{
				}
				num = (short)879951873;
				if (num != 0)
				{
				}
				num = (short)848232448;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton1StsMsgIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)668671394;
				short num2 = num;
				num = (short)180493730;
				switch (num2 == num)
				{
				}
				num = (short)109117441;
				if (num != 0)
				{
				}
				num = (short)1333002240;
				if (num != 0)
				{
				}
				num = (short)941948928;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton1StsMsgIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0009AD6C File Offset: 0x00098F6C
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x0009AE24 File Offset: 0x00099024
		public bool TopButton1StsMsgIndexIsAcpVisible
		{
			get
			{
				short num = (short)1771754248;
				short num2 = num;
				num = (short)1367724808;
				switch (num2 == num)
				{
				}
				num = (short)1033175040;
				if (num != 0)
				{
				}
				num = (short)558694401;
				if (num != 0)
				{
				}
				num = (short)54198272;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton1StsMsgIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1157644096;
				short num2 = num;
				num = (short)1845903168;
				switch (num2 == num)
				{
				}
				num = (short)1703542784;
				if (num != 0)
				{
				}
				num = (short)1160839169;
				if (num != 0)
				{
				}
				num = (short)208994304;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton1StsMsgIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0009AEDC File Offset: 0x000990DC
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x0009AF94 File Offset: 0x00099194
		public bool TopButton1StsMsgIndexIsAcpEditable
		{
			get
			{
				short num = (short)528744449;
				if (num != 0)
				{
				}
				num = (short)859958868;
				short num2 = num;
				num = (short)1312550484;
				switch (num2 == num)
				{
				}
				num = (short)1432748032;
				if (num != 0)
				{
				}
				num = (short)1697185792;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton1StsMsgIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1448476312;
				short num2 = num;
				num = (short)1016921752;
				switch (num2 == num)
				{
				}
				num = (short)1172045825;
				if (num != 0)
				{
				}
				num = (short)526974976;
				if (num != 0)
				{
				}
				num = (short)37552128;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton1StsMsgIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0009B050 File Offset: 0x00099250
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x0009B10C File Offset: 0x0009930C
		public string TopButton1StsMsgIndexUIValue
		{
			get
			{
				short num = (short)1170440711;
				short num2 = num;
				num = (short)1165722119;
				switch (num2 == num)
				{
				}
				num = (short)1214578689;
				if (num != 0)
				{
				}
				num = (short)262668288;
				if (num != 0)
				{
				}
				num = (short)388956160;
				short num3 = num;
				return (string)base.GetValue(O9GraphicView.TopButton1StsMsgIndexUIValueProperty);
			}
			set
			{
				short num = (short)1425516901;
				short num2 = num;
				num = (short)1852156261;
				switch (num2 == num)
				{
				}
				num = (short)1782382593;
				if (num != 0)
				{
				}
				num = (short)713818112;
				if (num != 0)
				{
				}
				num = (short)1404436480;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton1StsMsgIndexUIValueProperty, value);
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0009B1C0 File Offset: 0x000993C0
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x0009B27C File Offset: 0x0009947C
		public AcpRangeField<int, string> TopButton1StsMsgIndexRange
		{
			get
			{
				short num = (short)1233846273;
				if (num != 0)
				{
				}
				num = (short)925550427;
				short num2 = num;
				num = (short)624019291;
				switch (num2 == num)
				{
				}
				num = (short)1000275968;
				if (num != 0)
				{
				}
				num = (short)1699348480;
				short num3 = num;
				return (AcpRangeField<int, string>)base.GetValue(O9GraphicView.TopButton1StsMsgIndexRangeProperty);
			}
			set
			{
				short num = (short)260177113;
				short num2 = num;
				num = (short)1520958681;
				switch (num2 == num)
				{
				}
				num = (short)460128257;
				if (num != 0)
				{
				}
				num = (short)1550188544;
				if (num != 0)
				{
				}
				num = (short)1187708928;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton1StsMsgIndexRangeProperty, value);
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0009B334 File Offset: 0x00099534
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x0009B3EC File Offset: 0x000995EC
		public bool TopButton2StsMsgIndexIsAcpValid
		{
			get
			{
				short num = (short)1058941328;
				short num2 = num;
				num = (short)696002960;
				switch (num2 == num)
				{
				}
				num = (short)1548681217;
				if (num != 0)
				{
				}
				num = (short)275185664;
				if (num != 0)
				{
				}
				num = (short)856031232;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton2StsMsgIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1854275585;
				if (num != 0)
				{
				}
				num = (short)1485013866;
				short num2 = num;
				num = (short)1161659242;
				switch (num2 == num)
				{
				}
				num = (short)829161472;
				if (num != 0)
				{
				}
				num = (short)970260480;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton2StsMsgIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x0009B4A4 File Offset: 0x000996A4
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x0009B560 File Offset: 0x00099760
		public bool TopButton2StsMsgIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1593966593;
				if (num != 0)
				{
				}
				num = (short)732719862;
				short num2 = num;
				num = (short)1406364406;
				switch (num2 == num)
				{
				}
				num = (short)155123712;
				if (num != 0)
				{
				}
				num = (short)242089984;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton2StsMsgIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)982417383;
				short num2 = num;
				num = (short)2106359783;
				switch (num2 == num)
				{
				}
				num = (short)357892097;
				if (num != 0)
				{
				}
				num = (short)1301479424;
				if (num != 0)
				{
				}
				num = (short)108199936;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton2StsMsgIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0009B618 File Offset: 0x00099818
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x0009B6D4 File Offset: 0x000998D4
		public bool TopButton2StsMsgIndexIsAcpVisible
		{
			get
			{
				short num = (short)528630443;
				short num2 = num;
				num = (short)1041711787;
				switch (num2 == num)
				{
				}
				num = (short)1406664705;
				if (num != 0)
				{
				}
				num = (short)905773056;
				if (num != 0)
				{
				}
				num = (short)1512177664;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton2StsMsgIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)696449575;
				short num2 = num;
				num = (short)111933991;
				switch (num2 == num)
				{
				}
				num = (short)435027969;
				if (num != 0)
				{
				}
				num = (short)81330176;
				if (num != 0)
				{
				}
				num = (short)476643328;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton2StsMsgIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0009B78C File Offset: 0x0009998C
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x0009B844 File Offset: 0x00099A44
		public bool TopButton2StsMsgIndexIsAcpEditable
		{
			get
			{
				short num = (short)95030198;
				short num2 = num;
				num = (short)1140067254;
				switch (num2 == num)
				{
				}
				num = (short)819855361;
				if (num != 0)
				{
				}
				num = (short)1391263744;
				if (num != 0)
				{
				}
				num = (short)2042888192;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton2StsMsgIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1143364198;
				short num2 = num;
				num = (short)1205951078;
				switch (num2 == num)
				{
				}
				num = (short)40894465;
				if (num != 0)
				{
				}
				num = (short)559939584;
				if (num != 0)
				{
				}
				num = (short)1718026240;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton2StsMsgIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0009B8FC File Offset: 0x00099AFC
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x0009B9B8 File Offset: 0x00099BB8
		public string TopButton2StsMsgIndexUIValue
		{
			get
			{
				short num = (short)1948504810;
				short num2 = num;
				num = (short)138597098;
				switch (num2 == num)
				{
				}
				num = (short)354025473;
				if (num != 0)
				{
				}
				num = (short)160825344;
				if (num != 0)
				{
				}
				num = (short)1661992960;
				short num3 = num;
				return (string)base.GetValue(O9GraphicView.TopButton2StsMsgIndexUIValueProperty);
			}
			set
			{
				short num = (short)789243104;
				short num2 = num;
				num = (short)81192160;
				switch (num2 == num)
				{
				}
				num = (short)1122959361;
				if (num != 0)
				{
				}
				num = (short)366477312;
				if (num != 0)
				{
				}
				num = (short)1076887552;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton2StsMsgIndexUIValueProperty, value);
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0009BA70 File Offset: 0x00099C70
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x0009BB28 File Offset: 0x00099D28
		public AcpRangeField<int, string> TopButton2StsMsgIndexRange
		{
			get
			{
				short num = (short)454044532;
				short num2 = num;
				num = (short)1666001780;
				switch (num2 == num)
				{
				}
				num = (short)332398593;
				if (num != 0)
				{
				}
				num = (short)1999699968;
				if (num != 0)
				{
				}
				num = (short)2143158272;
				short num3 = num;
				return (AcpRangeField<int, string>)base.GetValue(O9GraphicView.TopButton2StsMsgIndexRangeProperty);
			}
			set
			{
				short num = (short)1785659393;
				if (num != 0)
				{
				}
				num = (short)129199362;
				short num2 = num;
				num = (short)1100246274;
				switch (num2 == num)
				{
				}
				num = (short)449183744;
				if (num != 0)
				{
				}
				num = (short)1381171200;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton2StsMsgIndexRangeProperty, value);
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0009BBE0 File Offset: 0x00099DE0
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x0009BC98 File Offset: 0x00099E98
		public bool TopButton3StsMsgIndexIsAcpValid
		{
			get
			{
				short num = (short)894729724;
				short num2 = num;
				num = (short)909671932;
				switch (num2 == num)
				{
				}
				num = (short)1740242945;
				if (num != 0)
				{
				}
				num = (short)843186176;
				if (num != 0)
				{
				}
				num = (short)1393360896;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton3StsMsgIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1873908540;
				short num2 = num;
				num = (short)759796540;
				switch (num2 == num)
				{
				}
				num = (short)1243676673;
				if (num != 0)
				{
				}
				num = (short)1665466368;
				if (num != 0)
				{
				}
				num = (short)1884160000;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton3StsMsgIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0009BD50 File Offset: 0x00099F50
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x0009BE08 File Offset: 0x0009A008
		public bool TopButton3StsMsgIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1403203260;
				short num2 = num;
				num = (short)1792618172;
				switch (num2 == num)
				{
				}
				num = (short)1627717633;
				if (num != 0)
				{
				}
				num = (short)2134376448;
				if (num != 0)
				{
				}
				num = (short)337117184;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton3StsMsgIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2071658496;
				short num2 = num;
				num = (short)1482817537;
				if (num != 0)
				{
				}
				num = (short)2079676972;
				short num3 = num;
				num = (short)675895852;
				switch (num3 == num)
				{
				}
				num = (short)126025728;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3StsMsgIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0009BEC4 File Offset: 0x0009A0C4
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x0009BF7C File Offset: 0x0009A17C
		public bool TopButton3StsMsgIndexIsAcpVisible
		{
			get
			{
				short num = (short)1742274560;
				short num2 = num;
				num = (short)1269235713;
				if (num != 0)
				{
				}
				num = (short)2001021569;
				short num3 = num;
				num = (short)784804481;
				switch (num3 == num)
				{
				}
				num = (short)83165184;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3StsMsgIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)123994112;
				short num2 = num;
				num = (short)468130695;
				short num3 = num;
				num = (short)833035143;
				switch (num3 == num)
				{
				}
				num = (short)713162752;
				if (num != 0)
				{
				}
				num = (short)1977876481;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3StsMsgIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0009C034 File Offset: 0x0009A234
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x0009C0F0 File Offset: 0x0009A2F0
		public bool TopButton3StsMsgIndexIsAcpEditable
		{
			get
			{
				short num = (short)232194048;
				short num2 = num;
				num = (short)47117468;
				short num3 = num;
				num = (short)64681116;
				switch (num3 == num)
				{
				}
				num = (short)1327235073;
				if (num != 0)
				{
				}
				num = (short)192544768;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3StsMsgIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1583153152;
				short num2 = num;
				num = (short)1627883272;
				short num3 = num;
				num = (short)1748010760;
				switch (num3 == num)
				{
				}
				num = 1;
				if (num != 0)
				{
				}
				num = (short)766705664;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3StsMsgIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0009C1AC File Offset: 0x0009A3AC
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x0009C268 File Offset: 0x0009A468
		public string TopButton3StsMsgIndexUIValue
		{
			get
			{
				short num = (short)959315968;
				short num2 = num;
				num = (short)656605185;
				if (num != 0)
				{
				}
				num = (short)1756681655;
				short num3 = num;
				num = (short)1385813431;
				switch (num3 == num)
				{
				}
				num = (short)2096562176;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton3StsMsgIndexUIValueProperty);
			}
			set
			{
				short num = (short)22151168;
				short num2 = num;
				num = (short)1614938113;
				if (num != 0)
				{
				}
				num = (short)511195294;
				short num3 = num;
				num = (short)1972320414;
				switch (num3 == num)
				{
				}
				num = (short)1594294272;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3StsMsgIndexUIValueProperty, value);
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0009C31C File Offset: 0x0009A51C
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x0009C3D4 File Offset: 0x0009A5D4
		public AcpRangeField<int, string> TopButton3StsMsgIndexRange
		{
			get
			{
				short num = (short)403111936;
				short num2 = num;
				num = (short)516204539;
				short num3 = num;
				num = (short)825010171;
				switch (num3 == num)
				{
				}
				num = (short)488308737;
				if (num != 0)
				{
				}
				num = (short)1631322112;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, string>)base.GetValue(O9GraphicView.TopButton3StsMsgIndexRangeProperty);
			}
			set
			{
				short num = (short)1846673408;
				short num2 = num;
				num = (short)248787645;
				short num3 = num;
				num = (short)1774465725;
				switch (num3 == num)
				{
				}
				num = (short)345440257;
				if (num != 0)
				{
				}
				num = (short)1815412736;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3StsMsgIndexRangeProperty, value);
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0009C48C File Offset: 0x0009A68C
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x0009C544 File Offset: 0x0009A744
		public bool TopButton4StsMsgIndexIsAcpValid
		{
			get
			{
				short num = (short)1429929984;
				short num2 = num;
				num = (short)704905217;
				if (num != 0)
				{
				}
				num = (short)374417668;
				short num3 = num;
				num = (short)1822632196;
				switch (num3 == num)
				{
				}
				num = (short)763428864;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4StsMsgIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)462553088;
				short num2 = num;
				num = (short)210209757;
				short num3 = num;
				num = (short)1800637405;
				switch (num3 == num)
				{
				}
				num = (short)878968832;
				if (num != 0)
				{
				}
				num = (short)996081665;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4StsMsgIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0009C600 File Offset: 0x0009A800
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0009C6B8 File Offset: 0x0009A8B8
		public bool TopButton4StsMsgIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1664745472;
				short num2 = num;
				num = (short)1095371180;
				short num3 = num;
				num = (short)1382156716;
				switch (num3 == num)
				{
				}
				num = (short)870711297;
				if (num != 0)
				{
				}
				num = (short)1958477824;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4StsMsgIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)257228800;
				short num2 = num;
				num = (short)1166839860;
				short num3 = num;
				num = (short)1431736372;
				switch (num3 == num)
				{
				}
				num = (short)1218707456;
				if (num != 0)
				{
				}
				num = (short)52494337;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4StsMsgIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0009C770 File Offset: 0x0009A970
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x0009C828 File Offset: 0x0009AA28
		public bool TopButton4StsMsgIndexIsAcpVisible
		{
			get
			{
				short num = (short)810287104;
				short num2 = num;
				num = (short)358817167;
				short num3 = num;
				num = (short)47652239;
				switch (num3 == num)
				{
				}
				num = (short)1238892545;
				if (num != 0)
				{
				}
				num = (short)580583424;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4StsMsgIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)277741568;
				short num2 = num;
				num = (short)1541764636;
				short num3 = num;
				num = (short)183465500;
				switch (num3 == num)
				{
				}
				num = (short)1320484865;
				if (num != 0)
				{
				}
				num = (short)1243676672;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4StsMsgIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0009C8E0 File Offset: 0x0009AAE0
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x0009C998 File Offset: 0x0009AB98
		public bool TopButton4StsMsgIndexIsAcpEditable
		{
			get
			{
				short num = (short)107675648;
				short num2 = num;
				num = (short)550263504;
				short num3 = num;
				num = (short)1025465040;
				switch (num3 == num)
				{
				}
				num = (short)1393623040;
				if (num != 0)
				{
				}
				num = (short)1716912129;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4StsMsgIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)147914752;
				short num2 = num;
				num = (short)654984798;
				short num3 = num;
				num = (short)2089109086;
				switch (num3 == num)
				{
				}
				num = (short)722534401;
				if (num != 0)
				{
				}
				num = (short)2008940544;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4StsMsgIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0009CA50 File Offset: 0x0009AC50
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x0009CB08 File Offset: 0x0009AD08
		public string TopButton4StsMsgIndexUIValue
		{
			get
			{
				short num = (short)1056636928;
				short num2 = num;
				num = (short)623669802;
				short num3 = num;
				num = (short)2048619050;
				switch (num3 == num)
				{
				}
				num = (short)1358495745;
				if (num != 0)
				{
				}
				num = (short)1922826240;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton4StsMsgIndexUIValueProperty);
			}
			set
			{
				short num = (short)655556608;
				short num2 = num;
				num = (short)247805221;
				short num3 = num;
				num = (short)215889189;
				switch (num3 == num)
				{
				}
				num = (short)184745985;
				if (num != 0)
				{
				}
				num = (short)1929248768;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4StsMsgIndexUIValueProperty, value);
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0009CBBC File Offset: 0x0009ADBC
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0009CC74 File Offset: 0x0009AE74
		public AcpRangeField<int, string> TopButton4StsMsgIndexRange
		{
			get
			{
				short num = (short)1875378176;
				short num2 = num;
				num = (short)2146125522;
				short num3 = num;
				num = (short)1277314770;
				switch (num3 == num)
				{
				}
				num = (short)1259601920;
				if (num != 0)
				{
				}
				num = (short)1510670337;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, string>)base.GetValue(O9GraphicView.TopButton4StsMsgIndexRangeProperty);
			}
			set
			{
				short num = (short)1662189568;
				short num2 = num;
				num = (short)1929190882;
				short num3 = num;
				num = (short)182525410;
				switch (num3 == num)
				{
				}
				num = (short)929431553;
				if (num != 0)
				{
				}
				num = (short)641662976;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4StsMsgIndexRangeProperty, value);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0009CD28 File Offset: 0x0009AF28
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0009CDE4 File Offset: 0x0009AFE4
		public bool TopButton5StsMsgIndexIsAcpValid
		{
			get
			{
				short num = (short)1217396736;
				short num2 = num;
				num = (short)857455560;
				short num3 = num;
				num = (short)1282325448;
				switch (num3 == num)
				{
				}
				num = (short)586940417;
				if (num != 0)
				{
				}
				num = (short)2060779520;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5StsMsgIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1339359232;
				short num2 = num;
				num = (short)1736772821;
				short num3 = num;
				num = (short)1198329045;
				switch (num3 == num)
				{
				}
				num = (short)1516961793;
				if (num != 0)
				{
				}
				num = (short)1960574976;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5StsMsgIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0009CEA0 File Offset: 0x0009B0A0
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x0009CF5C File Offset: 0x0009B15C
		public bool TopButton5StsMsgIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1905655808;
				short num2 = num;
				num = (short)651833317;
				short num3 = num;
				num = (short)1952067557;
				switch (num3 == num)
				{
				}
				num = (short)1845428224;
				if (num != 0)
				{
				}
				num = (short)1758265345;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5StsMsgIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1573847040;
				short num2 = num;
				num = (short)1697352463;
				short num3 = num;
				num = (short)1099795215;
				switch (num3 == num)
				{
				}
				num = (short)832241664;
				if (num != 0)
				{
				}
				num = (short)579928065;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5StsMsgIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0009D01C File Offset: 0x0009B21C
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0009D0D4 File Offset: 0x0009B2D4
		public bool TopButton5StsMsgIndexIsAcpVisible
		{
			get
			{
				short num = (short)243859456;
				short num2 = num;
				num = (short)1723704698;
				short num3 = num;
				num = (short)1216914810;
				switch (num3 == num)
				{
				}
				num = (short)1240465409;
				if (num != 0)
				{
				}
				num = (short)230096896;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5StsMsgIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)878575616;
				short num2 = num;
				num = (short)548016887;
				short num3 = num;
				num = (short)1003754231;
				switch (num3 == num)
				{
				}
				num = (short)1504772097;
				if (num != 0)
				{
				}
				num = (short)426901504;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5StsMsgIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0009D190 File Offset: 0x0009B390
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0009D250 File Offset: 0x0009B450
		public bool TopButton5StsMsgIndexIsAcpEditable
		{
			get
			{
				short num = (short)1337589760;
				short num2 = num;
				num = (short)1011727885;
				short num3 = num;
				num = (short)1438367245;
				switch (num3 == num)
				{
				}
				num = (short)464650241;
				if (num != 0)
				{
				}
				num = (short)495517696;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5StsMsgIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1628504064;
				short num2 = num;
				num = (short)914620385;
				short num3 = num;
				num = (short)1116012513;
				switch (num3 == num)
				{
				}
				num = (short)440270848;
				if (num != 0)
				{
				}
				num = (short)206766081;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5StsMsgIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0009D30C File Offset: 0x0009B50C
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0009D3C8 File Offset: 0x0009B5C8
		public string TopButton5StsMsgIndexUIValue
		{
			get
			{
				short num = (short)2095972352;
				short num2 = num;
				num = (short)1543941433;
				short num3 = num;
				num = (short)1939254585;
				switch (num3 == num)
				{
				}
				num = (short)1842020353;
				if (num != 0)
				{
				}
				num = (short)1659568128;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton5StsMsgIndexUIValueProperty);
			}
			set
			{
				short num = (short)1400242176;
				short num2 = num;
				num = (short)316872799;
				short num3 = num;
				num = (short)1749031007;
				switch (num3 == num)
				{
				}
				num = (short)231145472;
				if (num != 0)
				{
				}
				num = (short)567672833;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5StsMsgIndexUIValueProperty, value);
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0009D47C File Offset: 0x0009B67C
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0009D534 File Offset: 0x0009B734
		public AcpRangeField<int, string> TopButton5StsMsgIndexRange
		{
			get
			{
				short num = (short)106037248;
				short num2 = num;
				num = (short)1719312293;
				short num3 = num;
				num = (short)1752211365;
				switch (num3 == num)
				{
				}
				num = (short)1642987520;
				if (num != 0)
				{
				}
				num = (short)2093481985;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, string>)base.GetValue(O9GraphicView.TopButton5StsMsgIndexRangeProperty);
			}
			set
			{
				short num = (short)1001652224;
				short num2 = num;
				num = (short)1404518348;
				short num3 = num;
				num = (short)118177740;
				switch (num3 == num)
				{
				}
				num = (short)384630785;
				if (num != 0)
				{
				}
				num = (short)701038592;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5StsMsgIndexRangeProperty, value);
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0009D5E8 File Offset: 0x0009B7E8
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x0009D6A0 File Offset: 0x0009B8A0
		public bool TopButton1ZoneIsAcpValid
		{
			get
			{
				short num = (short)286392320;
				short num2 = num;
				num = (short)605950083;
				short num3 = num;
				num = (short)128323715;
				switch (num3 == num)
				{
				}
				num = (short)530317313;
				if (num != 0)
				{
				}
				num = (short)1517355008;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)249430016;
				short num2 = num;
				num = (short)365925415;
				short num3 = num;
				num = (short)1853527079;
				switch (num3 == num)
				{
				}
				num = (short)707461120;
				if (num != 0)
				{
				}
				num = (short)1255079937;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0009D758 File Offset: 0x0009B958
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x0009D810 File Offset: 0x0009BA10
		public bool TopButton1ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)851443712;
				short num2 = num;
				num = (short)1051841559;
				short num3 = num;
				num = (short)1786172439;
				switch (num3 == num)
				{
				}
				num = (short)1748697089;
				if (num != 0)
				{
				}
				num = (short)1346240512;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1304494080;
				short num2 = num;
				num = (short)1518036608;
				short num3 = num;
				num = (short)1620665984;
				switch (num3 == num)
				{
				}
				num = (short)788660225;
				if (num != 0)
				{
				}
				num = (short)266731520;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0009D8CC File Offset: 0x0009BACC
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x0009D984 File Offset: 0x0009BB84
		public bool TopButton1ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1924399104;
				short num2 = num;
				num = (short)1541977288;
				short num3 = num;
				num = (short)448705736;
				switch (num3 == num)
				{
				}
				num = (short)1483341824;
				if (num != 0)
				{
				}
				num = (short)275972097;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)708116480;
				short num2 = num;
				num = (short)797327442;
				short num3 = num;
				num = (short)285818962;
				switch (num3 == num)
				{
				}
				num = (short)311558145;
				if (num != 0)
				{
				}
				num = (short)1226899456;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0009DA40 File Offset: 0x0009BC40
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x0009DAF8 File Offset: 0x0009BCF8
		public bool TopButton1ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1424883712;
				short num2 = num;
				num = (short)868155393;
				if (num != 0)
				{
				}
				num = (short)2009736993;
				short num3 = num;
				num = (short)1999775521;
				switch (num3 == num)
				{
				}
				num = (short)327942144;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)308805632;
				short num2 = num;
				num = (short)293269745;
				short num3 = num;
				num = (short)240840945;
				switch (num3 == num)
				{
				}
				num = (short)564789249;
				if (num != 0)
				{
				}
				num = (short)1782185984;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0009DBB8 File Offset: 0x0009BDB8
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x0009DC6C File Offset: 0x0009BE6C
		public string TopButton1ZoneUIValue
		{
			get
			{
				short num = (short)227466095;
				short num2 = num;
				num = (short)1810226031;
				switch (num2 == num)
				{
				}
				num = (short)1945960448;
				short num3 = num;
				num = (short)1117323264;
				if (num != 0)
				{
				}
				num = (short)1980497921;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton1ZoneUIValueProperty);
			}
			set
			{
				short num = (short)684472376;
				short num2 = num;
				num = (short)268777528;
				switch (num2 == num)
				{
				}
				num = (short)1934163968;
				short num3 = num;
				num = (short)2033909760;
				if (num != 0)
				{
				}
				num = (short)1835728897;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1ZoneUIValueProperty, value);
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0009DD24 File Offset: 0x0009BF24
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x0009DDE0 File Offset: 0x0009BFE0
		public AcpListField TopButton1ZoneList
		{
			get
			{
				short num = (short)1223513827;
				short num2 = num;
				num = (short)141907683;
				switch (num2 == num)
				{
				}
				num = (short)942538752;
				short num3 = num;
				num = (short)1018232833;
				if (num != 0)
				{
				}
				num = (short)911474688;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.TopButton1ZoneListProperty);
			}
			set
			{
				short num = (short)1355527885;
				short num2 = num;
				num = (short)1769912013;
				switch (num2 == num)
				{
				}
				num = (short)1231618048;
				short num3 = num;
				num = (short)108134400;
				if (num != 0)
				{
				}
				num = (short)510328833;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1ZoneListProperty, value);
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0009DE98 File Offset: 0x0009C098
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x0009DF54 File Offset: 0x0009C154
		public bool TopButton2ZoneIsAcpValid
		{
			get
			{
				short num = (short)603193345;
				if (num != 0)
				{
				}
				num = (short)1868099706;
				short num2 = num;
				num = (short)1207562362;
				switch (num2 == num)
				{
				default:
				{
					num = (short)477364224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)468516864;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)1499691906;
				short num2 = num;
				num = (short)631536514;
				switch (num2 == num)
				{
				}
				num = (short)1932394496;
				short num3 = num;
				num = (short)668336129;
				if (num != 0)
				{
				}
				num = (short)1564868608;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0009E010 File Offset: 0x0009C210
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x0009E0C8 File Offset: 0x0009C2C8
		public bool TopButton2ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)611713025;
				if (num != 0)
				{
				}
				num = (short)571423958;
				short num2 = num;
				num = (short)492059862;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1359347712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)420610048;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)933953537;
				if (num != 0)
				{
				}
				num = (short)1029790926;
				short num2 = num;
				num = (short)1086545102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1639448576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2081161216;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0009E188 File Offset: 0x0009C388
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x0009E240 File Offset: 0x0009C440
		public bool TopButton2ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1446480400;
				short num2 = num;
				num = (short)1043499536;
				switch (num2 == num)
				{
				}
				num = (short)905052160;
				short num3 = num;
				num = (short)755499009;
				if (num != 0)
				{
				}
				num = (short)402456576;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1679163393;
				if (num != 0)
				{
				}
				num = (short)1696458005;
				short num2 = num;
				num = (short)2014373141;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2109014016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1268383744;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0009E2FC File Offset: 0x0009C4FC
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x0009E3B4 File Offset: 0x0009C5B4
		public bool TopButton2ZoneIsAcpEditable
		{
			get
			{
				short num = (short)203029207;
				short num2 = num;
				num = (short)628685527;
				switch (num2 == num)
				{
				}
				num = (short)2118909952;
				short num3 = num;
				num = (short)469762049;
				if (num != 0)
				{
				}
				num = (short)1102643200;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)662718679;
				short num2 = num;
				num = (short)1931888855;
				switch (num2 == num)
				{
				}
				num = (short)1237909504;
				short num3 = num;
				num = (short)1241579521;
				if (num != 0)
				{
				}
				num = (short)1887895552;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0009E470 File Offset: 0x0009C670
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x0009E528 File Offset: 0x0009C728
		public string TopButton2ZoneUIValue
		{
			get
			{
				short num = (short)363285610;
				short num2 = num;
				num = (short)900156522;
				switch (num2 == num)
				{
				}
				num = (short)1463091200;
				short num3 = num;
				num = (short)482541569;
				if (num != 0)
				{
				}
				num = (short)1688666112;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton2ZoneUIValueProperty);
			}
			set
			{
				short num = (short)717099225;
				short num2 = num;
				num = (short)69341401;
				switch (num2 == num)
				{
				}
				num = (short)887554048;
				short num3 = num;
				num = (short)1967587329;
				if (num != 0)
				{
				}
				num = (short)2123890688;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2ZoneUIValueProperty, value);
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0009E5E0 File Offset: 0x0009C7E0
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x0009E69C File Offset: 0x0009C89C
		public AcpListField TopButton2ZoneList
		{
			get
			{
				short num = (short)1477353060;
				short num2 = num;
				num = (short)1295425124;
				switch (num2 == num)
				{
				}
				num = (short)1412104192;
				short num3 = num;
				num = (short)888864769;
				if (num != 0)
				{
				}
				num = (short)1940586496;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.TopButton2ZoneListProperty);
			}
			set
			{
				short num = (short)2073304491;
				short num2 = num;
				num = (short)433724843;
				switch (num2 == num)
				{
				}
				num = (short)1775239168;
				short num3 = num;
				num = (short)923467777;
				if (num != 0)
				{
				}
				num = (short)875495424;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2ZoneListProperty, value);
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0009E754 File Offset: 0x0009C954
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x0009E80C File Offset: 0x0009CA0C
		public bool TopButton3ZoneIsAcpValid
		{
			get
			{
				short num = (short)1835396002;
				short num2 = num;
				num = (short)633924514;
				switch (num2 == num)
				{
				}
				num = (short)284622848;
				short num3 = num;
				num = (short)3801088;
				if (num != 0)
				{
				}
				num = (short)1018822657;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)503540109;
				short num2 = num;
				num = (short)2137418125;
				switch (num2 == num)
				{
				}
				num = (short)797966336;
				short num3 = num;
				num = (short)420020224;
				if (num != 0)
				{
				}
				num = (short)1648164865;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0009E8C8 File Offset: 0x0009CAC8
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x0009E980 File Offset: 0x0009CB80
		public bool TopButton3ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)256172430;
				short num2 = num;
				num = (short)815194510;
				switch (num2 == num)
				{
				}
				num = (short)272039936;
				short num3 = num;
				num = (short)934871041;
				if (num != 0)
				{
				}
				num = (short)1775108096;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)820298432;
				short num2 = num;
				num = (short)423084736;
				switch (num2 == num)
				{
				}
				num = (short)6946816;
				short num3 = num;
				num = (short)34865152;
				if (num != 0)
				{
				}
				num = (short)826408961;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0009EA38 File Offset: 0x0009CC38
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x0009EAF0 File Offset: 0x0009CCF0
		public bool TopButton3ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1204714128;
				short num2 = num;
				num = (short)55409296;
				switch (num2 == num)
				{
				}
				num = (short)2078539776;
				short num3 = num;
				num = (short)1409024001;
				if (num != 0)
				{
				}
				num = (short)1567358976;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)525903897;
				short num2 = num;
				num = (short)1849141273;
				switch (num2 == num)
				{
				}
				num = (short)592904192;
				short num3 = num;
				num = (short)1063124993;
				if (num != 0)
				{
				}
				num = (short)1104674816;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0009EBAC File Offset: 0x0009CDAC
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x0009EC64 File Offset: 0x0009CE64
		public bool TopButton3ZoneIsAcpEditable
		{
			get
			{
				short num = (short)81364355;
				short num2 = num;
				num = (short)652641667;
				switch (num2 == num)
				{
				}
				num = (short)301203456;
				short num3 = num;
				num = (short)1441923072;
				if (num != 0)
				{
				}
				num = (short)1853816833;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)146145281;
				if (num != 0)
				{
				}
				num = (short)746328228;
				short num2 = num;
				num = (short)1681461412;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1884487680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)884801536;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0009ED20 File Offset: 0x0009CF20
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x0009EDD8 File Offset: 0x0009CFD8
		public string TopButton3ZoneUIValue
		{
			get
			{
				short num = (short)1786244151;
				short num2 = num;
				num = (short)275246135;
				switch (num2 == num)
				{
				}
				num = (short)713490432;
				short num3 = num;
				num = (short)1832976384;
				if (num != 0)
				{
				}
				num = (short)1933180929;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton3ZoneUIValueProperty);
			}
			set
			{
				short num = (short)597150176;
				short num2 = num;
				num = (short)1753663968;
				switch (num2 == num)
				{
				}
				num = (short)1400242176;
				short num3 = num;
				num = (short)551288833;
				if (num != 0)
				{
				}
				num = (short)620036096;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3ZoneUIValueProperty, value);
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0009EE90 File Offset: 0x0009D090
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x0009EF4C File Offset: 0x0009D14C
		public AcpListField TopButton3ZoneList
		{
			get
			{
				short num = (short)1087864752;
				short num2 = num;
				num = (short)1142259632;
				switch (num2 == num)
				{
				}
				num = (short)1724776448;
				short num3 = num;
				num = (short)843776001;
				if (num != 0)
				{
				}
				num = (short)538902528;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.TopButton3ZoneListProperty);
			}
			set
			{
				short num = (short)784304487;
				short num2 = num;
				num = (short)637438311;
				switch (num2 == num)
				{
				}
				num = (short)1152974848;
				short num3 = num;
				num = (short)407175169;
				if (num != 0)
				{
				}
				num = (short)2083651584;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3ZoneListProperty, value);
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0009F004 File Offset: 0x0009D204
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x0009F0C0 File Offset: 0x0009D2C0
		public bool TopButton4ZoneIsAcpValid
		{
			get
			{
				short num = (short)846897669;
				short num2 = num;
				num = (short)722575877;
				switch (num2 == num)
				{
				}
				num = (short)1632239616;
				if (num != 0)
				{
				}
				num = (short)946798593;
				if (num != 0)
				{
				}
				num = (short)1718222848;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton4ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)851440720;
				short num2 = num;
				num = (short)1045754960;
				switch (num2 == num)
				{
				}
				num = (short)1391788033;
				if (num != 0)
				{
				}
				num = (short)1478492160;
				if (num != 0)
				{
				}
				num = (short)2000420864;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0009F178 File Offset: 0x0009D378
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x0009F22C File Offset: 0x0009D42C
		public bool TopButton4ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)982487446;
				short num2 = num;
				num = (short)1857982870;
				switch (num2 == num)
				{
				}
				num = (short)940834817;
				if (num != 0)
				{
				}
				num = (short)888406016;
				if (num != 0)
				{
				}
				num = (short)1943339008;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.TopButton4ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1515270615;
				short num2 = num;
				num = (short)1889087959;
				switch (num2 == num)
				{
				}
				num = (short)1357447169;
				if (num != 0)
				{
				}
				num = (short)317194240;
				if (num != 0)
				{
				}
				num = (short)979042304;
				short num3 = num;
				base.SetValue(O9GraphicView.TopButton4ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0009F2E8 File Offset: 0x0009D4E8
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x0009F3A4 File Offset: 0x0009D5A4
		public bool TopButton4ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1444085761;
				if (num != 0)
				{
				}
				num = (short)367070724;
				short num2 = num;
				num = (short)1900219908;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1224343552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)829423616;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1740920288;
				short num2 = num;
				num = (short)250697184;
				switch (num2 == num)
				{
				}
				num = (short)1898905600;
				short num3 = num;
				num = (short)1494220801;
				if (num != 0)
				{
				}
				num = (short)600702976;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0009F460 File Offset: 0x0009D660
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x0009F51C File Offset: 0x0009D71C
		public bool TopButton4ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1492009587;
				short num2 = num;
				num = (short)394281587;
				switch (num2 == num)
				{
				}
				num = (short)703201280;
				short num3 = num;
				num = (short)1929510913;
				if (num != 0)
				{
				}
				num = (short)1521680384;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)339575695;
				short num2 = num;
				num = (short)1663271823;
				switch (num2 == num)
				{
				}
				num = (short)1608450048;
				short num3 = num;
				num = (short)809631745;
				if (num != 0)
				{
				}
				num = (short)925171712;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0009F5D8 File Offset: 0x0009D7D8
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x0009F690 File Offset: 0x0009D890
		public string TopButton4ZoneUIValue
		{
			get
			{
				short num = (short)869531649;
				if (num != 0)
				{
				}
				num = (short)1057273329;
				short num2 = num;
				num = (short)1789048305;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1306001408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)125501440;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton4ZoneUIValueProperty);
			}
			set
			{
				short num = (short)689635329;
				if (num != 0)
				{
				}
				num = (short)1768978711;
				short num2 = num;
				num = (short)1496873239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)653983744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)195362816;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4ZoneUIValueProperty, value);
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0009F744 File Offset: 0x0009D944
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0009F800 File Offset: 0x0009DA00
		public AcpListField TopButton4ZoneList
		{
			get
			{
				short num = (short)1844288148;
				short num2 = num;
				num = (short)774937236;
				switch (num2 == num)
				{
				}
				num = (short)1576468480;
				short num3 = num;
				num = (short)1660878848;
				if (num != 0)
				{
				}
				num = (short)1668874241;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.TopButton4ZoneListProperty);
			}
			set
			{
				short num = (short)802892280;
				short num2 = num;
				num = (short)1677404664;
				switch (num2 == num)
				{
				}
				num = (short)1069154304;
				short num3 = num;
				num = (short)1536557057;
				if (num != 0)
				{
				}
				num = (short)462618624;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4ZoneListProperty, value);
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0009F8B8 File Offset: 0x0009DAB8
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x0009F978 File Offset: 0x0009DB78
		public bool TopButton5ZoneIsAcpValid
		{
			get
			{
				short num = (short)2004014624;
				short num2 = num;
				num = (short)2057164320;
				switch (num2 == num)
				{
				}
				num = (short)2003763200;
				short num3 = num;
				num = (short)54329345;
				if (num != 0)
				{
				}
				num = (short)1731395584;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)377446719;
				short num2 = num;
				num = (short)1943232831;
				switch (num2 == num)
				{
				}
				num = (short)128122880;
				short num3 = num;
				num = (short)502792193;
				if (num != 0)
				{
				}
				num = (short)916127744;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0009FA34 File Offset: 0x0009DC34
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x0009FAF0 File Offset: 0x0009DCF0
		public bool TopButton5ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)1679914448;
				short num2 = num;
				num = (short)1636595152;
				switch (num2 == num)
				{
				}
				num = (short)170590208;
				short num3 = num;
				num = (short)985202689;
				if (num != 0)
				{
				}
				num = (short)1685520384;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)431605795;
				short num2 = num;
				num = (short)846055459;
				switch (num2 == num)
				{
				}
				num = (short)602275840;
				short num3 = num;
				num = (short)1093206017;
				if (num != 0)
				{
				}
				num = (short)48562176;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x0009FBA8 File Offset: 0x0009DDA8
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x0009FC60 File Offset: 0x0009DE60
		public bool TopButton5ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1981160839;
				short num2 = num;
				num = (short)1935875463;
				switch (num2 == num)
				{
				}
				num = (short)1994981376;
				short num3 = num;
				num = (short)2031550465;
				if (num != 0)
				{
				}
				num = (short)1469186048;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)973887182;
				short num2 = num;
				num = (short)626349774;
				switch (num2 == num)
				{
				}
				num = (short)766705664;
				short num3 = num;
				num = (short)1337458688;
				if (num != 0)
				{
				}
				num = (short)1590099969;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x0009FD1C File Offset: 0x0009DF1C
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x0009FDD4 File Offset: 0x0009DFD4
		public bool TopButton5ZoneIsAcpEditable
		{
			get
			{
				short num = (short)2023813985;
				short num2 = num;
				num = (short)1775629153;
				switch (num2 == num)
				{
				}
				num = (short)806486016;
				short num3 = num;
				num = (short)1458569217;
				if (num != 0)
				{
				}
				num = (short)1039728640;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1688141738;
				short num2 = num;
				num = (short)1605959594;
				switch (num2 == num)
				{
				}
				num = (short)1574895616;
				short num3 = num;
				num = (short)598081537;
				if (num != 0)
				{
				}
				num = (short)142278656;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0009FE90 File Offset: 0x0009E090
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x0009FF4C File Offset: 0x0009E14C
		public string TopButton5ZoneUIValue
		{
			get
			{
				short num = (short)177862083;
				short num2 = num;
				num = (short)1698035139;
				switch (num2 == num)
				{
				}
				num = (short)526974976;
				short num3 = num;
				num = (short)1476722689;
				if (num != 0)
				{
				}
				num = (short)1404960768;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton5ZoneUIValueProperty);
			}
			set
			{
				short num = (short)1531819627;
				short num2 = num;
				num = (short)1952691819;
				switch (num2 == num)
				{
				}
				num = (short)2131755008;
				short num3 = num;
				num = (short)930349056;
				if (num != 0)
				{
				}
				num = (short)507117569;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5ZoneUIValueProperty, value);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x000A0000 File Offset: 0x0009E200
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x000A00BC File Offset: 0x0009E2BC
		public AcpListField TopButton5ZoneList
		{
			get
			{
				short num = (short)2040756957;
				short num2 = num;
				num = (short)1829731037;
				switch (num2 == num)
				{
				}
				num = (short)25034752;
				short num3 = num;
				num = (short)234160129;
				if (num != 0)
				{
				}
				num = (short)39649280;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.TopButton5ZoneListProperty);
			}
			set
			{
				short num = (short)778980155;
				short num2 = num;
				num = (short)288967483;
				switch (num2 == num)
				{
				}
				num = (short)1920270336;
				short num3 = num;
				num = (short)394133505;
				if (num != 0)
				{
				}
				num = (short)28311552;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5ZoneListProperty, value);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x000A0170 File Offset: 0x0009E370
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x000A0228 File Offset: 0x0009E428
		public bool TopButton1ChannelIsAcpValid
		{
			get
			{
				short num = (short)390749892;
				short num2 = num;
				num = (short)2096651972;
				switch (num2 == num)
				{
				}
				num = (short)1246887936;
				short num3 = num;
				num = (short)1420361728;
				if (num != 0)
				{
				}
				num = (short)1160511489;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)1578656864;
				short num2 = num;
				num = (short)756376672;
				switch (num2 == num)
				{
				}
				num = (short)1855979520;
				short num3 = num;
				num = (short)890896385;
				if (num != 0)
				{
				}
				num = (short)1960837120;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x000A02E0 File Offset: 0x0009E4E0
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x000A0398 File Offset: 0x0009E598
		public bool TopButton1ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)998864481;
				short num2 = num;
				num = (short)887322209;
				switch (num2 == num)
				{
				}
				num = (short)1955266560;
				short num3 = num;
				num = (short)1275789312;
				if (num != 0)
				{
				}
				num = (short)604504065;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)102118229;
				short num2 = num;
				num = (short)1991979861;
				switch (num2 == num)
				{
				}
				num = (short)256966656;
				short num3 = num;
				num = (short)881262593;
				if (num != 0)
				{
				}
				num = (short)1981022208;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x000A0454 File Offset: 0x0009E654
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x000A050C File Offset: 0x0009E70C
		public bool TopButton1ChannelIsAcpVisible
		{
			get
			{
				short num = (short)196457140;
				short num2 = num;
				num = (short)1226158772;
				switch (num2 == num)
				{
				}
				num = (short)1423900672;
				short num3 = num;
				num = (short)1491075072;
				if (num != 0)
				{
				}
				num = (short)482476033;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1559643710;
				short num2 = num;
				num = (short)715212350;
				switch (num2 == num)
				{
				}
				num = (short)1446707200;
				short num3 = num;
				num = (short)1402863617;
				if (num != 0)
				{
				}
				num = (short)1312686080;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x000A05C8 File Offset: 0x0009E7C8
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x000A0680 File Offset: 0x0009E880
		public bool TopButton1ChannelIsAcpEditable
		{
			get
			{
				short num = (short)801898497;
				if (num != 0)
				{
				}
				num = (short)1079102101;
				short num2 = num;
				num = (short)1265158805;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1256456192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1126498304;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton1ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1286022810;
				short num2 = num;
				num = (short)1116743322;
				switch (num2 == num)
				{
				}
				num = (short)1852702720;
				short num3 = num;
				num = (short)1407844353;
				if (num != 0)
				{
				}
				num = (short)1235550208;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x000A0738 File Offset: 0x0009E938
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x000A07F0 File Offset: 0x0009E9F0
		public string TopButton1ChannelUIValue
		{
			get
			{
				short num = (short)1321597905;
				short num2 = num;
				num = (short)1229323217;
				switch (num2 == num)
				{
				}
				num = (short)1163264000;
				short num3 = num;
				num = (short)1532231681;
				if (num != 0)
				{
				}
				num = (short)1646854144;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton1ChannelUIValueProperty);
			}
			set
			{
				short num = (short)1291957103;
				short num2 = num;
				num = (short)2140451695;
				switch (num2 == num)
				{
				}
				num = (short)272629760;
				short num3 = num;
				num = (short)2134310913;
				if (num != 0)
				{
				}
				num = (short)163905536;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1ChannelUIValueProperty, value);
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x000A08A8 File Offset: 0x0009EAA8
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x000A0964 File Offset: 0x0009EB64
		public AcpListField TopButton1ChannelList
		{
			get
			{
				short num = (short)1860501505;
				if (num != 0)
				{
				}
				num = (short)932690633;
				short num2 = num;
				num = (short)19249865;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1985282048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)46202880;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.TopButton1ChannelListProperty);
			}
			set
			{
				short num = (short)2091357631;
				short num2 = num;
				num = (short)229021119;
				switch (num2 == num)
				{
				}
				num = (short)412745728;
				short num3 = num;
				num = (short)253362177;
				if (num != 0)
				{
				}
				num = (short)1639907328;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton1ChannelListProperty, value);
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x000A0A18 File Offset: 0x0009EC18
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x000A0AD4 File Offset: 0x0009ECD4
		public bool TopButton2ChannelIsAcpValid
		{
			get
			{
				short num = (short)886068095;
				short num2 = num;
				num = (short)190403455;
				switch (num2 == num)
				{
				}
				num = (short)2106392576;
				short num3 = num;
				num = (short)1570111489;
				if (num != 0)
				{
				}
				num = (short)1595015168;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)1370867967;
				short num2 = num;
				num = (short)189843711;
				switch (num2 == num)
				{
				}
				num = (short)1501298688;
				short num3 = num;
				num = (short)1759707137;
				if (num != 0)
				{
				}
				num = (short)1071120384;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x000A0B90 File Offset: 0x0009ED90
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x000A0C48 File Offset: 0x0009EE48
		public bool TopButton2ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)1514617554;
				short num2 = num;
				num = (short)471022290;
				switch (num2 == num)
				{
				}
				num = (short)1924923392;
				short num3 = num;
				num = (short)683802625;
				if (num != 0)
				{
				}
				num = (short)1667956736;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1769993866;
				short num2 = num;
				num = (short)1023735434;
				switch (num2 == num)
				{
				}
				num = (short)1865547776;
				short num3 = num;
				num = (short)1535574016;
				if (num != 0)
				{
				}
				num = (short)63307777;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x000A0D04 File Offset: 0x0009EF04
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x000A0DBC File Offset: 0x0009EFBC
		public bool TopButton2ChannelIsAcpVisible
		{
			get
			{
				short num = (short)1698614886;
				short num2 = num;
				num = (short)225758822;
				switch (num2 == num)
				{
				}
				num = (short)1010171904;
				short num3 = num;
				num = (short)1217855488;
				if (num != 0)
				{
				}
				num = (short)818479105;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)690297556;
				short num2 = num;
				num = (short)1636178644;
				switch (num2 == num)
				{
				}
				num = (short)1147273216;
				short num3 = num;
				num = (short)1505165312;
				if (num != 0)
				{
				}
				num = (short)1326776321;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x000A0E78 File Offset: 0x0009F078
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x000A0F30 File Offset: 0x0009F130
		public bool TopButton2ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1384802233;
				short num2 = num;
				num = (short)1127835577;
				switch (num2 == num)
				{
				}
				num = (short)76742656;
				short num3 = num;
				num = (short)514523137;
				if (num != 0)
				{
				}
				num = (short)924844032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton2ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1213559435;
				short num2 = num;
				num = (short)1830122123;
				switch (num2 == num)
				{
				}
				num = (short)1430650880;
				short num3 = num;
				num = (short)1255735297;
				if (num != 0)
				{
				}
				num = (short)1853292544;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x000A0FEC File Offset: 0x0009F1EC
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x000A10A4 File Offset: 0x0009F2A4
		public string TopButton2ChannelUIValue
		{
			get
			{
				short num = (short)1693437688;
				short num2 = num;
				num = (short)1286065912;
				switch (num2 == num)
				{
				}
				num = (short)460455936;
				short num3 = num;
				num = (short)1853751296;
				if (num != 0)
				{
				}
				num = (short)34144257;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton2ChannelUIValueProperty);
			}
			set
			{
				short num = (short)174962581;
				short num2 = num;
				num = (short)845199253;
				switch (num2 == num)
				{
				}
				num = (short)386859008;
				short num3 = num;
				num = (short)191496192;
				if (num != 0)
				{
				}
				num = (short)1366163457;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2ChannelUIValueProperty, value);
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x000A1160 File Offset: 0x0009F360
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x000A1218 File Offset: 0x0009F418
		public AcpListField TopButton2ChannelList
		{
			get
			{
				short num = (short)375123103;
				short num2 = num;
				num = (short)980741279;
				switch (num2 == num)
				{
				}
				num = (short)1019543552;
				short num3 = num;
				num = (short)2111635457;
				if (num != 0)
				{
				}
				num = (short)2115895296;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.TopButton2ChannelListProperty);
			}
			set
			{
				short num = (short)1682381137;
				short num2 = num;
				num = (short)129046865;
				switch (num2 == num)
				{
				}
				num = (short)253165568;
				if (num != 0)
				{
				}
				num = (short)528547840;
				short num3 = num;
				num = (short)2099445761;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton2ChannelListProperty, value);
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x000A12D0 File Offset: 0x0009F4D0
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x000A138C File Offset: 0x0009F58C
		public bool TopButton3ChannelIsAcpValid
		{
			get
			{
				short num = (short)1792802817;
				if (num != 0)
				{
				}
				num = (short)1676030537;
				short num2 = num;
				num = (short)978399817;
				switch (num2 == num)
				{
				}
				num = (short)356581376;
				short num3 = num;
				num = (short)1605828608;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)346930527;
				short num2 = num;
				num = (short)1741667679;
				switch (num2 == num)
				{
				}
				num = (short)1096351745;
				if (num != 0)
				{
				}
				num = (short)1735720960;
				short num3 = num;
				num = (short)334626816;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x000A144C File Offset: 0x0009F64C
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x000A1504 File Offset: 0x0009F704
		public bool TopButton3ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)1849684764;
				short num2 = num;
				num = (short)1600647964;
				switch (num2 == num)
				{
				}
				num = (short)1407582209;
				if (num != 0)
				{
				}
				num = (short)77332480;
				short num3 = num;
				num = (short)1119289344;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1811125609;
				short num2 = num;
				num = (short)714052969;
				switch (num2 == num)
				{
				}
				num = (short)229048320;
				if (num != 0)
				{
				}
				num = (short)1654718464;
				short num3 = num;
				num = (short)1824325633;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x000A15C0 File Offset: 0x0009F7C0
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x000A167C File Offset: 0x0009F87C
		public bool TopButton3ChannelIsAcpVisible
		{
			get
			{
				short num = (short)570676862;
				short num2 = num;
				num = (short)1817826942;
				switch (num2 == num)
				{
				}
				num = (short)2022637569;
				if (num != 0)
				{
				}
				num = (short)326696960;
				short num3 = num;
				num = (short)889716736;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)644644870;
				short num2 = num;
				num = (short)513900550;
				switch (num2 == num)
				{
				}
				num = (short)109379584;
				if (num != 0)
				{
				}
				num = (short)869662720;
				short num3 = num;
				num = (short)2032861185;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x000A1734 File Offset: 0x0009F934
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x000A17EC File Offset: 0x0009F9EC
		public bool TopButton3ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1928106916;
				short num2 = num;
				num = (short)1149473700;
				switch (num2 == num)
				{
				}
				num = (short)1990262785;
				if (num != 0)
				{
				}
				num = (short)721092608;
				short num3 = num;
				num = (short)1652686848;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton3ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1861938073;
				short num2 = num;
				num = (short)1766779801;
				switch (num2 == num)
				{
				}
				num = (short)1365311489;
				if (num != 0)
				{
				}
				num = (short)1697710080;
				short num3 = num;
				num = (short)1384841216;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x000A18A8 File Offset: 0x0009FAA8
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x000A1960 File Offset: 0x0009FB60
		public string TopButton3ChannelUIValue
		{
			get
			{
				short num = (short)1049065843;
				short num2 = num;
				num = (short)102857075;
				switch (num2 == num)
				{
				}
				num = (short)998703104;
				if (num != 0)
				{
				}
				num = (short)96927744;
				short num3 = num;
				num = (short)1063452673;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton3ChannelUIValueProperty);
			}
			set
			{
				short num = (short)164644442;
				short num2 = num;
				num = (short)352863834;
				switch (num2 == num)
				{
				}
				num = (short)2141126657;
				if (num != 0)
				{
				}
				num = (short)1051459584;
				short num3 = num;
				num = (short)1834156032;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3ChannelUIValueProperty, value);
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x000A1A14 File Offset: 0x0009FC14
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x000A1AD0 File Offset: 0x0009FCD0
		public AcpListField TopButton3ChannelList
		{
			get
			{
				short num = (short)688968467;
				short num2 = num;
				num = (short)1086837523;
				switch (num2 == num)
				{
				}
				num = (short)1485766657;
				if (num != 0)
				{
				}
				num = (short)805306368;
				short num3 = num;
				num = (short)714473472;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.TopButton3ChannelListProperty);
			}
			set
			{
				short num = (short)694528419;
				short num2 = num;
				num = (short)2037426595;
				switch (num2 == num)
				{
				}
				num = (short)2009661441;
				if (num != 0)
				{
				}
				num = (short)904200192;
				short num3 = num;
				num = (short)1872166912;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton3ChannelListProperty, value);
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x000A1B84 File Offset: 0x0009FD84
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x000A1C40 File Offset: 0x0009FE40
		public bool TopButton4ChannelIsAcpValid
		{
			get
			{
				short num = (short)2146885503;
				short num2 = num;
				num = (short)109895551;
				switch (num2 == num)
				{
				}
				num = (short)2135228416;
				if (num != 0)
				{
				}
				num = (short)1550516224;
				short num3 = num;
				num = (short)1595801601;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)1903890205;
				short num2 = num;
				num = (short)1537281821;
				switch (num2 == num)
				{
				}
				num = (short)21364736;
				if (num != 0)
				{
				}
				num = (short)614465536;
				short num3 = num;
				num = (short)1005453313;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x000A1CF8 File Offset: 0x0009FEF8
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x000A1DB0 File Offset: 0x0009FFB0
		public bool TopButton4ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)642502874;
				short num2 = num;
				num = (short)251187418;
				switch (num2 == num)
				{
				}
				num = (short)1118044161;
				if (num != 0)
				{
				}
				num = (short)1143472128;
				short num3 = num;
				num = (short)246153216;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1569615794;
				short num2 = num;
				num = (short)835678130;
				switch (num2 == num)
				{
				}
				num = (short)780533760;
				if (num != 0)
				{
				}
				num = (short)2004221952;
				short num3 = num;
				num = (short)1557200897;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x000A1E6C File Offset: 0x000A006C
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x000A1F24 File Offset: 0x000A0124
		public bool TopButton4ChannelIsAcpVisible
		{
			get
			{
				short num = (short)1352335361;
				if (num != 0)
				{
				}
				num = (short)20098689;
				short num2 = num;
				num = (short)1979559553;
				switch (num2 == num)
				{
				}
				num = (short)218759168;
				short num3 = num;
				num = (short)722599936;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)982908929;
				if (num != 0)
				{
				}
				num = (short)843740153;
				short num2 = num;
				num = (short)543912953;
				switch (num2 == num)
				{
				}
				num = (short)351469568;
				short num3 = num;
				num = (short)245170176;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x000A1FDC File Offset: 0x000A01DC
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x000A2094 File Offset: 0x000A0294
		public bool TopButton4ChannelIsAcpEditable
		{
			get
			{
				short num = (short)822554151;
				short num2 = num;
				num = (short)465645095;
				switch (num2 == num)
				{
				}
				num = (short)1508573185;
				if (num != 0)
				{
				}
				num = (short)83689472;
				short num3 = num;
				num = (short)487063552;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton4ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)780477105;
				short num2 = num;
				num = (short)1785995953;
				switch (num2 == num)
				{
				}
				num = (short)324206592;
				if (num != 0)
				{
				}
				num = (short)857014272;
				short num3 = num;
				num = (short)1931935745;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x000A2150 File Offset: 0x000A0350
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x000A220C File Offset: 0x000A040C
		public string TopButton4ChannelUIValue
		{
			get
			{
				short num = (short)1144563318;
				short num2 = num;
				num = (short)439985782;
				switch (num2 == num)
				{
				}
				num = (short)554106881;
				if (num != 0)
				{
				}
				num = (short)861470720;
				short num3 = num;
				num = (short)1693712384;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton4ChannelUIValueProperty);
			}
			set
			{
				short num = (short)532217857;
				if (num != 0)
				{
				}
				num = (short)996204560;
				short num2 = num;
				num = (short)1112268816;
				switch (num2 == num)
				{
				}
				num = (short)349765632;
				short num3 = num;
				num = (short)491782144;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4ChannelUIValueProperty, value);
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x000A22C8 File Offset: 0x000A04C8
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x000A2384 File Offset: 0x000A0584
		public AcpListField TopButton4ChannelList
		{
			get
			{
				short num = (short)1268842497;
				if (num != 0)
				{
				}
				num = (short)900887716;
				short num2 = num;
				num = (short)1731884196;
				switch (num2 == num)
				{
				}
				num = (short)1864761344;
				short num3 = num;
				num = (short)1820917760;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.TopButton4ChannelListProperty);
			}
			set
			{
				short num = (short)1081365639;
				short num2 = num;
				num = (short)354702471;
				switch (num2 == num)
				{
				}
				num = (short)127467521;
				if (num != 0)
				{
				}
				num = (short)810352640;
				short num3 = num;
				num = (short)2056257536;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton4ChannelListProperty, value);
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x000A2438 File Offset: 0x000A0638
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x000A24F0 File Offset: 0x000A06F0
		public bool TopButton5ChannelIsAcpValid
		{
			get
			{
				short num = (short)1232280572;
				short num2 = num;
				num = (short)2145065980;
				switch (num2 == num)
				{
				}
				num = (short)196476929;
				if (num != 0)
				{
				}
				num = (short)614793216;
				short num3 = num;
				num = (short)1565720576;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)1083309271;
				short num2 = num;
				num = (short)176291031;
				switch (num2 == num)
				{
				}
				num = (short)250871808;
				if (num != 0)
				{
				}
				num = (short)1967849472;
				short num3 = num;
				num = (short)1846018049;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x000A25AC File Offset: 0x000A07AC
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x000A2668 File Offset: 0x000A0868
		public bool TopButton5ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)224080195;
				short num2 = num;
				num = (short)502083907;
				switch (num2 == num)
				{
				}
				num = (short)1317273601;
				if (num != 0)
				{
				}
				num = (short)1272578048;
				short num3 = num;
				num = (short)295239680;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)635624174;
				short num2 = num;
				num = (short)1221384942;
				switch (num2 == num)
				{
				}
				num = (short)1229258753;
				if (num != 0)
				{
				}
				num = (short)2085683200;
				short num3 = num;
				num = (short)1407385600;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x000A2720 File Offset: 0x000A0920
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x000A27D8 File Offset: 0x000A09D8
		public bool TopButton5ChannelIsAcpVisible
		{
			get
			{
				short num = (short)213995186;
				short num2 = num;
				num = (short)490229426;
				switch (num2 == num)
				{
				}
				num = (short)786694145;
				if (num != 0)
				{
				}
				num = (short)2004746240;
				short num3 = num;
				num = (short)796065792;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1368524881;
				short num2 = num;
				num = (short)674957393;
				switch (num2 == num)
				{
				}
				num = (short)742850560;
				if (num != 0)
				{
				}
				num = (short)369819648;
				short num3 = num;
				num = (short)1147011073;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x000A2890 File Offset: 0x000A0A90
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x000A294C File Offset: 0x000A0B4C
		public bool TopButton5ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1437432899;
				short num2 = num;
				num = (short)68451395;
				switch (num2 == num)
				{
				}
				num = (short)2129133569;
				if (num != 0)
				{
				}
				num = (short)663945216;
				short num3 = num;
				num = (short)741605376;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.TopButton5ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1966473217;
				if (num != 0)
				{
				}
				num = (short)418883374;
				short num2 = num;
				num = (short)2060625710;
				switch (num2 == num)
				{
				}
				num = (short)271319040;
				short num3 = num;
				num = (short)811401216;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x000A2A08 File Offset: 0x000A0C08
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x000A2AC0 File Offset: 0x000A0CC0
		public string TopButton5ChannelUIValue
		{
			get
			{
				short num = (short)1988589504;
				short num2 = num;
				num = (short)1234401216;
				switch (num2 == num)
				{
				}
				num = (short)1263337472;
				if (num != 0)
				{
				}
				num = (short)1611726848;
				short num3 = num;
				num = (short)286195713;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.TopButton5ChannelUIValueProperty);
			}
			set
			{
				short num = (short)1035164943;
				short num2 = num;
				num = (short)1289772303;
				switch (num2 == num)
				{
				}
				num = (short)426377216;
				if (num != 0)
				{
				}
				num = (short)396361728;
				short num3 = num;
				num = (short)1523253249;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5ChannelUIValueProperty, value);
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x000A2B78 File Offset: 0x000A0D78
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x000A2C34 File Offset: 0x000A0E34
		public AcpListField TopButton5ChannelList
		{
			get
			{
				short num = (short)1109786892;
				short num2 = num;
				num = (short)1469972748;
				switch (num2 == num)
				{
				}
				num = (short)1823080449;
				if (num != 0)
				{
				}
				num = (short)1123090432;
				short num3 = num;
				num = (short)160432128;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.TopButton5ChannelListProperty);
			}
			set
			{
				short num = (short)45282645;
				short num2 = num;
				num = (short)608171349;
				switch (num2 == num)
				{
				}
				num = (short)2049900544;
				if (num != 0)
				{
				}
				num = (short)1754726400;
				short num3 = num;
				num = (short)796983297;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.TopButton5ChannelListProperty, value);
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x000A2CEC File Offset: 0x000A0EEC
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x000A2DA8 File Offset: 0x000A0FA8
		public bool LightBarTopIndexIsAcpValid
		{
			get
			{
				short num = (short)1704743714;
				short num2 = num;
				num = (short)2088522530;
				switch (num2 == num)
				{
				}
				num = (short)1762983937;
				if (num != 0)
				{
				}
				num = (short)1126891520;
				short num3 = num;
				num = (short)2107179008;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarTopIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1150091265;
				if (num != 0)
				{
				}
				num = (short)1471100204;
				short num2 = num;
				num = (short)1679242540;
				switch (num2 == num)
				{
				}
				num = (short)1349058560;
				short num3 = num;
				num = (short)316669952;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarTopIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x000A2E60 File Offset: 0x000A1060
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x000A2F1C File Offset: 0x000A111C
		public bool LightBarTopIndexIsAcpApplicable
		{
			get
			{
				short num = (short)363134977;
				if (num != 0)
				{
				}
				num = (short)2072268827;
				short num2 = num;
				num = (short)609636379;
				switch (num2 == num)
				{
				}
				num = (short)1718419456;
				short num3 = num;
				num = (short)1103757312;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarTopIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)136739786;
				short num2 = num;
				num = (short)1766882250;
				switch (num2 == num)
				{
				}
				num = (short)24707073;
				if (num != 0)
				{
				}
				num = (short)1114832896;
				short num3 = num;
				num = (short)812056576;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarTopIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x000A2FD8 File Offset: 0x000A11D8
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x000A3090 File Offset: 0x000A1290
		public bool LightBarTopIndexIsAcpVisible
		{
			get
			{
				short num = (short)645341130;
				short num2 = num;
				num = (short)1114185674;
				switch (num2 == num)
				{
				}
				num = (short)1901920256;
				if (num != 0)
				{
				}
				num = (short)1923547136;
				short num3 = num;
				num = (short)923664385;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarTopIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)145608495;
				short num2 = num;
				num = (short)361418543;
				switch (num2 == num)
				{
				}
				num = (short)1285357568;
				if (num != 0)
				{
				}
				num = (short)1462370304;
				short num3 = num;
				num = (short)686555137;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarTopIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x000A314C File Offset: 0x000A134C
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x000A3204 File Offset: 0x000A1404
		public bool LightBarTopIndexIsAcpEditable
		{
			get
			{
				short num = (short)1832524876;
				short num2 = num;
				num = (short)385752140;
				switch (num2 == num)
				{
				}
				num = (short)399835137;
				if (num != 0)
				{
				}
				num = (short)2098659328;
				short num3 = num;
				num = (short)480378880;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarTopIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)511249701;
				short num2 = num;
				num = (short)771558693;
				switch (num2 == num)
				{
				}
				num = (short)1059651585;
				if (num != 0)
				{
				}
				num = (short)250478592;
				short num3 = num;
				num = (short)1842479104;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarTopIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x000A32BC File Offset: 0x000A14BC
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x000A3378 File Offset: 0x000A1578
		public string LightBarTopIndexUIValue
		{
			get
			{
				short num = (short)928841729;
				if (num != 0)
				{
				}
				num = (short)1814754796;
				short num2 = num;
				num = (short)156956140;
				switch (num2 == num)
				{
				}
				num = (short)1657274368;
				short num3 = num;
				num = (short)1890320384;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.LightBarTopIndexUIValueProperty);
			}
			set
			{
				short num = (short)1580634415;
				short num2 = num;
				num = (short)2122158383;
				switch (num2 == num)
				{
				}
				num = (short)1305804801;
				if (num != 0)
				{
				}
				num = (short)701235200;
				short num3 = num;
				num = (short)2114519040;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarTopIndexUIValueProperty, value);
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x000A342C File Offset: 0x000A162C
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x000A34E4 File Offset: 0x000A16E4
		public AcpListField LightBarTopIndexList
		{
			get
			{
				short num = (short)1700140811;
				short num2 = num;
				num = (short)512825099;
				switch (num2 == num)
				{
				}
				num = (short)879034368;
				if (num != 0)
				{
				}
				num = (short)1344339968;
				short num3 = num;
				num = (short)433520641;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.LightBarTopIndexListProperty);
			}
			set
			{
				short num = (short)300465992;
				short num2 = num;
				num = (short)960216904;
				switch (num2 == num)
				{
				}
				num = (short)1396375552;
				if (num != 0)
				{
				}
				num = (short)904855552;
				short num3 = num;
				num = (short)703201281;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarTopIndexListProperty, value);
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x000A35A0 File Offset: 0x000A17A0
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x000A3658 File Offset: 0x000A1858
		public bool LightBarLeftIndexIsAcpValid
		{
			get
			{
				short num = (short)938691065;
				short num2 = num;
				num = (short)2073315833;
				switch (num2 == num)
				{
				}
				num = (short)1927479297;
				if (num != 0)
				{
				}
				num = (short)938737664;
				short num3 = num;
				num = (short)327352320;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarLeftIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1642919942;
				short num2 = num;
				num = (short)1100478470;
				switch (num2 == num)
				{
				}
				num = (short)207028225;
				if (num != 0)
				{
				}
				num = (short)772669440;
				short num3 = num;
				num = (short)1818427392;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarLeftIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x000A3714 File Offset: 0x000A1914
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x000A37D0 File Offset: 0x000A19D0
		public bool LightBarLeftIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1356383242;
				short num2 = num;
				num = (short)254919690;
				switch (num2 == num)
				{
				}
				num = (short)1324679169;
				if (num != 0)
				{
				}
				num = (short)990183424;
				short num3 = num;
				num = (short)1004601344;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarLeftIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)12606206;
				short num2 = num;
				num = (short)945773310;
				switch (num2 == num)
				{
				}
				num = (short)452263936;
				if (num != 0)
				{
				}
				num = (short)1178533888;
				short num3 = num;
				num = (short)2048786433;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarLeftIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x000A388C File Offset: 0x000A1A8C
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x000A3944 File Offset: 0x000A1B44
		public bool LightBarLeftIndexIsAcpVisible
		{
			get
			{
				short num = (short)1006143854;
				short num2 = num;
				num = (short)444172654;
				switch (num2 == num)
				{
				}
				num = (short)1092878337;
				if (num != 0)
				{
				}
				num = (short)1899692032;
				short num3 = num;
				num = (short)77266944;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarLeftIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)800442862;
				short num2 = num;
				num = (short)531679726;
				switch (num2 == num)
				{
				}
				num = (short)1931673601;
				if (num != 0)
				{
				}
				num = (short)1326120960;
				short num3 = num;
				num = (short)1655111680;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarLeftIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x000A3A00 File Offset: 0x000A1C00
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x000A3ABC File Offset: 0x000A1CBC
		public bool LightBarLeftIndexIsAcpEditable
		{
			get
			{
				short num = (short)1787785947;
				short num2 = num;
				num = (short)697070299;
				switch (num2 == num)
				{
				}
				num = (short)954859521;
				if (num != 0)
				{
				}
				num = (short)972750848;
				short num3 = num;
				num = (short)328859648;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarLeftIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1331560449;
				if (num != 0)
				{
				}
				num = (short)1344885304;
				short num2 = num;
				num = (short)254431800;
				switch (num2 == num)
				{
				}
				num = (short)1938161664;
				short num3 = num;
				num = (short)10813440;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarLeftIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x000A3B78 File Offset: 0x000A1D78
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x000A3C30 File Offset: 0x000A1E30
		public string LightBarLeftIndexUIValue
		{
			get
			{
				short num = (short)1054277633;
				if (num != 0)
				{
				}
				num = (short)2132887739;
				short num2 = num;
				num = (short)1660897467;
				switch (num2 == num)
				{
				}
				num = (short)1161887744;
				short num3 = num;
				num = (short)895221760;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.LightBarLeftIndexUIValueProperty);
			}
			set
			{
				short num = (short)1727635092;
				short num2 = num;
				num = (short)484417172;
				switch (num2 == num)
				{
				}
				num = (short)887881729;
				if (num != 0)
				{
				}
				num = (short)1231814656;
				short num3 = num;
				num = (short)1430126592;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarLeftIndexUIValueProperty, value);
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x000A3CE8 File Offset: 0x000A1EE8
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x000A3DA4 File Offset: 0x000A1FA4
		public AcpListField LightBarLeftIndexList
		{
			get
			{
				short num = (short)103119213;
				short num2 = num;
				num = (short)144406893;
				switch (num2 == num)
				{
				}
				num = (short)1642725377;
				if (num != 0)
				{
				}
				num = (short)955973632;
				short num3 = num;
				num = (short)1142423552;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.LightBarLeftIndexListProperty);
			}
			set
			{
				short num = (short)1390598566;
				short num2 = num;
				num = (short)1497160102;
				switch (num2 == num)
				{
				}
				num = (short)629342208;
				if (num != 0)
				{
				}
				num = (short)195756032;
				short num3 = num;
				num = (short)1238564865;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarLeftIndexListProperty, value);
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000A3E5C File Offset: 0x000A205C
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x000A3F18 File Offset: 0x000A2118
		public bool LightBarRightIndexIsAcpValid
		{
			get
			{
				short num = (short)1616465602;
				short num2 = num;
				num = (short)1175998146;
				switch (num2 == num)
				{
				}
				num = (short)185991169;
				if (num != 0)
				{
				}
				num = (short)401539072;
				short num3 = num;
				num = (short)1207238656;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarRightIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1681195009;
				if (num != 0)
				{
				}
				num = (short)150452405;
				short num2 = num;
				num = (short)1041807541;
				switch (num2 == num)
				{
				}
				num = (short)518979584;
				short num3 = num;
				num = (short)440598528;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarRightIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x000A3FD4 File Offset: 0x000A21D4
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x000A408C File Offset: 0x000A228C
		public bool LightBarRightIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1746050278;
				short num2 = num;
				num = (short)746691814;
				switch (num2 == num)
				{
				}
				num = (short)668073984;
				if (num != 0)
				{
				}
				num = (short)1519779840;
				short num3 = num;
				num = (short)967245825;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarRightIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1431204129;
				short num2 = num;
				num = (short)1096970529;
				switch (num2 == num)
				{
				}
				num = (short)2061828096;
				if (num != 0)
				{
				}
				num = (short)1509228544;
				short num3 = num;
				num = (short)572850177;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarRightIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x000A4148 File Offset: 0x000A2348
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x000A4200 File Offset: 0x000A2400
		public bool LightBarRightIndexIsAcpVisible
		{
			get
			{
				short num = (short)1107427329;
				if (num != 0)
				{
				}
				num = (short)89508374;
				short num2 = num;
				num = (short)1827129878;
				switch (num2 == num)
				{
				}
				num = (short)1707409408;
				short num3 = num;
				num = (short)1307115520;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarRightIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)994651109;
				short num2 = num;
				num = (short)418196453;
				switch (num2 == num)
				{
				}
				num = (short)788987905;
				if (num != 0)
				{
				}
				num = (short)110886912;
				short num3 = num;
				num = (short)1184759808;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarRightIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x000A42BC File Offset: 0x000A24BC
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x000A4374 File Offset: 0x000A2574
		public bool LightBarRightIndexIsAcpEditable
		{
			get
			{
				short num = (short)884027874;
				short num2 = num;
				num = (short)2055614946;
				switch (num2 == num)
				{
				}
				num = (short)960102400;
				if (num != 0)
				{
				}
				num = (short)496304128;
				short num3 = num;
				num = (short)2131558401;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarRightIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1172766721;
				if (num != 0)
				{
				}
				num = (short)108823151;
				short num2 = num;
				num = (short)773685871;
				switch (num2 == num)
				{
				}
				num = (short)1325400064;
				short num3 = num;
				num = (short)699138048;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarRightIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x000A4430 File Offset: 0x000A2630
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x000A44E8 File Offset: 0x000A26E8
		public string LightBarRightIndexUIValue
		{
			get
			{
				short num = (short)747703825;
				short num2 = num;
				num = (short)1955859985;
				switch (num2 == num)
				{
				}
				num = (short)319488001;
				if (num != 0)
				{
				}
				num = (short)412483584;
				short num3 = num;
				num = (short)1889337344;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.LightBarRightIndexUIValueProperty);
			}
			set
			{
				short num = (short)1610865541;
				short num2 = num;
				num = (short)615766917;
				switch (num2 == num)
				{
				}
				num = (short)699990016;
				if (num != 0)
				{
				}
				num = (short)387710976;
				short num3 = num;
				num = (short)1515388929;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarRightIndexUIValueProperty, value);
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x000A45A0 File Offset: 0x000A27A0
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x000A4658 File Offset: 0x000A2858
		public AcpListField LightBarRightIndexList
		{
			get
			{
				short num = (short)268311696;
				short num2 = num;
				num = (short)602545296;
				switch (num2 == num)
				{
				}
				num = (short)1059323905;
				if (num != 0)
				{
				}
				num = (short)1294991360;
				short num3 = num;
				num = (short)1156251648;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.LightBarRightIndexListProperty);
			}
			set
			{
				short num = (short)79495169;
				if (num != 0)
				{
				}
				num = (short)775190868;
				short num2 = num;
				num = (short)671054164;
				switch (num2 == num)
				{
				}
				num = (short)1477902336;
				short num3 = num;
				num = (short)1780744192;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarRightIndexListProperty, value);
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x000A470C File Offset: 0x000A290C
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x000A47C4 File Offset: 0x000A29C4
		public bool LightBarTopActionIsAcpValid
		{
			get
			{
				short num = (short)440860673;
				if (num != 0)
				{
				}
				num = (short)1220158430;
				short num2 = num;
				num = (short)1297097694;
				switch (num2 == num)
				{
				}
				num = (short)759431168;
				short num3 = num;
				num = (short)1909915648;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarTopActionIsAcpValidProperty);
			}
			set
			{
				short num = (short)1387377244;
				short num2 = num;
				num = (short)1162523228;
				switch (num2 == num)
				{
				}
				num = (short)1678180352;
				if (num != 0)
				{
				}
				num = (short)1810759680;
				short num3 = num;
				num = (short)572784641;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarTopActionIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x000A4884 File Offset: 0x000A2A84
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x000A4940 File Offset: 0x000A2B40
		public bool LightBarTopActionIsAcpApplicable
		{
			get
			{
				short num = (short)347865830;
				short num2 = num;
				num = (short)1415512806;
				switch (num2 == num)
				{
				}
				num = (short)1108606976;
				if (num != 0)
				{
				}
				num = (short)620429312;
				short num3 = num;
				num = (short)1707147265;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarTopActionIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)789305158;
				short num2 = num;
				num = (short)402315078;
				switch (num2 == num)
				{
				}
				num = (short)1715863553;
				if (num != 0)
				{
				}
				num = (short)2139160576;
				short num3 = num;
				num = (short)1369440256;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarTopActionIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x000A49F8 File Offset: 0x000A2BF8
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x000A4AB0 File Offset: 0x000A2CB0
		public bool LightBarTopActionIsAcpVisible
		{
			get
			{
				short num = (short)1662436292;
				short num2 = num;
				num = (short)1259455428;
				switch (num2 == num)
				{
				}
				num = (short)1898446849;
				if (num != 0)
				{
				}
				num = (short)1491664896;
				short num3 = num;
				num = (short)1177354240;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarTopActionIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)72378238;
				short num2 = num;
				num = (short)1747806078;
				switch (num2 == num)
				{
				}
				num = (short)1421672448;
				if (num != 0)
				{
				}
				num = (short)594411520;
				short num3 = num;
				num = (short)1446379521;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarTopActionIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000A4B68 File Offset: 0x000A2D68
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x000A4C24 File Offset: 0x000A2E24
		public bool LightBarTopActionIsAcpEditable
		{
			get
			{
				short num = (short)1407016603;
				short num2 = num;
				num = (short)5529243;
				switch (num2 == num)
				{
				}
				num = (short)94240769;
				if (num != 0)
				{
				}
				num = (short)15597568;
				short num3 = num;
				num = (short)114556928;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarTopActionIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1246101505;
				if (num != 0)
				{
				}
				num = (short)1134529228;
				short num2 = num;
				num = (short)1499368140;
				switch (num2 == num)
				{
				}
				num = (short)531300352;
				short num3 = num;
				num = (short)2135752704;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarTopActionIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x000A4CDC File Offset: 0x000A2EDC
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x000A4D94 File Offset: 0x000A2F94
		public string LightBarTopActionUIValue
		{
			get
			{
				short num = (short)2129257932;
				short num2 = num;
				num = (short)2030495180;
				switch (num2 == num)
				{
				}
				num = (short)452001792;
				if (num != 0)
				{
				}
				num = (short)643432448;
				short num3 = num;
				num = (short)213254145;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.LightBarTopActionUIValueProperty);
			}
			set
			{
				short num = (short)997683706;
				short num2 = num;
				num = (short)1067020794;
				switch (num2 == num)
				{
				}
				num = (short)72286209;
				if (num != 0)
				{
				}
				num = (short)477298688;
				short num3 = num;
				num = (short)109838336;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarTopActionUIValueProperty, value);
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x000A4E48 File Offset: 0x000A3048
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x000A4F00 File Offset: 0x000A3100
		public AcpListField LightBarTopActionList
		{
			get
			{
				short num = (short)1120075777;
				if (num != 0)
				{
				}
				num = (short)1827246324;
				short num2 = num;
				num = (short)1611501812;
				switch (num2 == num)
				{
				}
				num = (short)1250885632;
				short num3 = num;
				num = (short)774242304;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.LightBarTopActionListProperty);
			}
			set
			{
				short num = (short)1643861675;
				short num2 = num;
				num = (short)1222727339;
				switch (num2 == num)
				{
				}
				num = (short)738852864;
				if (num != 0)
				{
				}
				num = (short)1271988224;
				short num3 = num;
				num = (short)287375361;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarTopActionListProperty, value);
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x000A4FB8 File Offset: 0x000A31B8
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x000A5070 File Offset: 0x000A3270
		public bool LightBarLeftActionIsAcpValid
		{
			get
			{
				short num = (short)1130251335;
				short num2 = num;
				num = (short)1554465863;
				switch (num2 == num)
				{
				}
				num = (short)2051670017;
				if (num != 0)
				{
				}
				num = (short)49676288;
				short num3 = num;
				num = (short)2051407872;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarLeftActionIsAcpValidProperty);
			}
			set
			{
				short num = (short)1628315972;
				short num2 = num;
				num = (short)921903428;
				switch (num2 == num)
				{
				}
				num = (short)451608577;
				if (num != 0)
				{
				}
				num = (short)529006592;
				short num3 = num;
				num = (short)2055012352;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarLeftActionIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000A5128 File Offset: 0x000A3328
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x000A51E0 File Offset: 0x000A33E0
		public bool LightBarLeftActionIsAcpApplicable
		{
			get
			{
				short num = (short)887168448;
				short num2 = num;
				num = (short)748887488;
				switch (num2 == num)
				{
				}
				num = (short)561774593;
				if (num != 0)
				{
				}
				num = (short)45285376;
				short num3 = num;
				num = (short)445186048;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarLeftActionIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)902606290;
				short num2 = num;
				num = (short)923119058;
				switch (num2 == num)
				{
				}
				num = (short)57081857;
				if (num != 0)
				{
				}
				num = (short)1629356032;
				short num3 = num;
				num = (short)221446144;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarLeftActionIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x000A529C File Offset: 0x000A349C
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x000A5354 File Offset: 0x000A3554
		public bool LightBarLeftActionIsAcpVisible
		{
			get
			{
				short num = (short)187820596;
				short num2 = num;
				num = (short)821946932;
				switch (num2 == num)
				{
				}
				num = (short)517472257;
				if (num != 0)
				{
				}
				num = (short)110886912;
				short num3 = num;
				num = (short)387842048;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarLeftActionIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)228962004;
				short num2 = num;
				num = (short)1531227860;
				switch (num2 == num)
				{
				}
				num = (short)1443561473;
				if (num != 0)
				{
				}
				num = (short)1602945024;
				short num3 = num;
				num = (short)483000320;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarLeftActionIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x000A5410 File Offset: 0x000A3610
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x000A54CC File Offset: 0x000A36CC
		public bool LightBarLeftActionIsAcpEditable
		{
			get
			{
				short num = (short)1846979737;
				short num2 = num;
				num = (short)20688025;
				switch (num2 == num)
				{
				}
				num = (short)239665152;
				if (num != 0)
				{
				}
				num = (short)1454768128;
				short num3 = num;
				num = (short)571408385;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarLeftActionIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2062726285;
				short num2 = num;
				num = (short)652915853;
				switch (num2 == num)
				{
				}
				num = (short)183500801;
				if (num != 0)
				{
				}
				num = (short)11403264;
				short num3 = num;
				num = (short)1246560256;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarLeftActionIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x000A5588 File Offset: 0x000A3788
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x000A5640 File Offset: 0x000A3840
		public string LightBarLeftActionUIValue
		{
			get
			{
				short num = (short)793689023;
				short num2 = num;
				num = (short)1148107711;
				switch (num2 == num)
				{
				}
				num = (short)1444610049;
				if (num != 0)
				{
				}
				num = (short)1985413120;
				short num3 = num;
				num = (short)1507852288;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.LightBarLeftActionUIValueProperty);
			}
			set
			{
				short num = (short)765984769;
				if (num != 0)
				{
				}
				num = (short)484275829;
				short num2 = num;
				num = (short)1408202357;
				switch (num2 == num)
				{
				}
				num = (short)1798766592;
				short num3 = num;
				num = (short)1703084032;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarLeftActionUIValueProperty, value);
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x000A56F4 File Offset: 0x000A38F4
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x000A57B0 File Offset: 0x000A39B0
		public AcpListField LightBarLeftActionList
		{
			get
			{
				short num = (short)1440427272;
				short num2 = num;
				num = (short)1687891208;
				switch (num2 == num)
				{
				}
				num = (short)1605566464;
				if (num != 0)
				{
				}
				num = (short)381878272;
				short num3 = num;
				num = (short)238354433;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.LightBarLeftActionListProperty);
			}
			set
			{
				short num = (short)1762486036;
				short num2 = num;
				num = (short)2147313428;
				switch (num2 == num)
				{
				}
				num = (short)1226178560;
				if (num != 0)
				{
				}
				num = (short)819855360;
				short num3 = num;
				num = (short)1531707393;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarLeftActionListProperty, value);
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x000A5864 File Offset: 0x000A3A64
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x000A5920 File Offset: 0x000A3B20
		public bool LightBarRightActionIsAcpValid
		{
			get
			{
				short num = (short)1635057665;
				if (num != 0)
				{
				}
				num = (short)892809800;
				short num2 = num;
				num = (short)1218785864;
				switch (num2 == num)
				{
				}
				num = (short)1070661632;
				short num3 = num;
				num = (short)1319567360;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarRightActionIsAcpValidProperty);
			}
			set
			{
				short num = (short)593799979;
				short num2 = num;
				num = (short)1636150059;
				switch (num2 == num)
				{
				}
				num = (short)464977920;
				if (num != 0)
				{
				}
				num = (short)350748672;
				short num3 = num;
				num = (short)471597057;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarRightActionIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x000A59DC File Offset: 0x000A3BDC
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x000A5A94 File Offset: 0x000A3C94
		public bool LightBarRightActionIsAcpApplicable
		{
			get
			{
				short num = (short)521273345;
				if (num != 0)
				{
				}
				num = (short)1202209550;
				short num2 = num;
				num = (short)1921860366;
				switch (num2 == num)
				{
				}
				num = (short)414515200;
				short num3 = num;
				num = (short)107347968;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarRightActionIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)466864647;
				short num2 = num;
				num = (short)571263495;
				switch (num2 == num)
				{
				}
				num = (short)1777139712;
				if (num != 0)
				{
				}
				num = (short)1186791424;
				short num3 = num;
				num = (short)1338966017;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarRightActionIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x000A5B50 File Offset: 0x000A3D50
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x000A5C08 File Offset: 0x000A3E08
		public bool LightBarRightActionIsAcpVisible
		{
			get
			{
				short num = (short)765157196;
				short num2 = num;
				num = (short)494624588;
				switch (num2 == num)
				{
				}
				num = (short)164757505;
				if (num != 0)
				{
				}
				num = (short)726204416;
				short num3 = num;
				num = (short)614793216;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarRightActionIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)852399259;
				short num2 = num;
				num = (short)999330971;
				switch (num2 == num)
				{
				}
				num = (short)1527185408;
				if (num != 0)
				{
				}
				num = (short)877395968;
				short num3 = num;
				num = (short)1020788737;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarRightActionIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x000A5CC4 File Offset: 0x000A3EC4
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x000A5D84 File Offset: 0x000A3F84
		public bool LightBarRightActionIsAcpEditable
		{
			get
			{
				short num = (short)1507176759;
				short num2 = num;
				num = (short)1006154039;
				switch (num2 == num)
				{
				}
				num = (short)299827201;
				if (num != 0)
				{
				}
				num = (short)1395654656;
				short num3 = num;
				num = (short)2037972992;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.LightBarRightActionIsAcpEditableProperty);
			}
			set
			{
				short num = (short)634678900;
				short num2 = num;
				num = (short)2040360564;
				switch (num2 == num)
				{
				}
				num = (short)1348730881;
				if (num != 0)
				{
				}
				num = (short)535363584;
				short num3 = num;
				num = (short)1217462272;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarRightActionIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x000A5E3C File Offset: 0x000A403C
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x000A5EF8 File Offset: 0x000A40F8
		public string LightBarRightActionUIValue
		{
			get
			{
				short num = (short)606273537;
				if (num != 0)
				{
				}
				num = (short)419945334;
				short num2 = num;
				num = (short)1515838326;
				switch (num2 == num)
				{
				}
				num = (short)241238016;
				short num3 = num;
				num = (short)1913126912;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.LightBarRightActionUIValueProperty);
			}
			set
			{
				short num = (short)1762413237;
				short num2 = num;
				num = (short)1174555317;
				switch (num2 == num)
				{
				}
				num = (short)623640577;
				if (num != 0)
				{
				}
				num = (short)176095232;
				short num3 = num;
				num = (short)1119682560;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarRightActionUIValueProperty, value);
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x000A5FAC File Offset: 0x000A41AC
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x000A6068 File Offset: 0x000A4268
		public AcpListField LightBarRightActionList
		{
			get
			{
				short num = (short)1127429920;
				short num2 = num;
				num = (short)1350842144;
				switch (num2 == num)
				{
				}
				num = (short)1355546625;
				if (num != 0)
				{
				}
				num = (short)1079705600;
				short num3 = num;
				num = (short)868417536;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.LightBarRightActionListProperty);
			}
			set
			{
				short num = (short)261281553;
				short num2 = num;
				num = (short)151050001;
				switch (num2 == num)
				{
				}
				num = (short)926220289;
				if (num != 0)
				{
				}
				num = (short)1197146112;
				short num3 = num;
				num = (short)1791688704;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.LightBarRightActionListProperty, value);
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x000A6120 File Offset: 0x000A4320
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x000A61DC File Offset: 0x000A43DC
		public bool DataButtonCnvIsAcpValid
		{
			get
			{
				short num = (short)1247266568;
				short num2 = num;
				num = (short)169920264;
				switch (num2 == num)
				{
				}
				num = (short)1743912960;
				if (num != 0)
				{
				}
				num = (short)1519386624;
				short num3 = num;
				num = (short)1031143425;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonCnvIsAcpValidProperty);
			}
			set
			{
				short num = (short)2027133844;
				short num2 = num;
				num = (short)1084922772;
				switch (num2 == num)
				{
				}
				num = (short)1599864832;
				short num3 = num;
				num = (short)805175296;
				if (num != 0)
				{
				}
				num = (short)1145831425;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonCnvIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x000A629C File Offset: 0x000A449C
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x000A6358 File Offset: 0x000A4558
		public bool DataButtonCnvIsAcpApplicable
		{
			get
			{
				short num = (short)1169198708;
				short num2 = num;
				num = (short)77762164;
				switch (num2 == num)
				{
				}
				num = (short)1389035520;
				short num3 = num;
				num = (short)1880621057;
				if (num != 0)
				{
				}
				num = (short)1667039232;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonCnvIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1940258817;
				if (num != 0)
				{
				}
				num = (short)590078269;
				short num2 = num;
				num = (short)140042557;
				switch (num2 == num)
				{
				default:
				{
					num = (short)443416576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1923481600;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonCnvIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x000A6414 File Offset: 0x000A4614
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x000A64D0 File Offset: 0x000A46D0
		public bool DataButtonCnvIsAcpVisible
		{
			get
			{
				short num = (short)937115641;
				short num2 = num;
				num = (short)1428504569;
				switch (num2 == num)
				{
				}
				num = (short)447545344;
				short num3 = num;
				num = (short)418185217;
				if (num != 0)
				{
				}
				num = (short)127926272;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonCnvIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1569910432;
				short num2 = num;
				num = (short)362147488;
				switch (num2 == num)
				{
				}
				num = (short)821362688;
				short num3 = num;
				num = (short)1310982145;
				if (num != 0)
				{
				}
				num = (short)1690632192;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonCnvIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x000A6588 File Offset: 0x000A4788
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x000A6640 File Offset: 0x000A4840
		public bool DataButtonCnvIsAcpEditable
		{
			get
			{
				short num = (short)1197998081;
				if (num != 0)
				{
				}
				num = (short)1450308570;
				short num2 = num;
				num = (short)1114371034;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1665990656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1051459584;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonCnvIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1838406855;
				short num2 = num;
				num = (short)1730600135;
				switch (num2 == num)
				{
				}
				num = (short)2065104896;
				short num3 = num;
				num = (short)1776746496;
				if (num != 0)
				{
				}
				num = (short)314376193;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonCnvIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x000A66FC File Offset: 0x000A48FC
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x000A67B8 File Offset: 0x000A49B8
		public string DataButtonCnvUIValue
		{
			get
			{
				short num = (short)467730433;
				if (num != 0)
				{
				}
				num = (short)827074497;
				short num2 = num;
				num = (short)46999489;
				switch (num2 == num)
				{
				default:
				{
					num = (short)197918720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)173342720;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.DataButtonCnvUIValueProperty);
			}
			set
			{
				short num = (short)2102001665;
				if (num != 0)
				{
				}
				num = (short)1670334011;
				short num2 = num;
				num = (short)161826363;
				switch (num2 == num)
				{
				default:
				{
					num = (short)546635776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)493027328;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonCnvUIValueProperty, value);
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x000A6870 File Offset: 0x000A4A70
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x000A692C File Offset: 0x000A4B2C
		public AcpListField DataButtonCnvList
		{
			get
			{
				short num = (short)1741565145;
				short num2 = num;
				num = (short)133442777;
				switch (num2 == num)
				{
				}
				num = (short)1343356928;
				short num3 = num;
				num = (short)834076673;
				if (num != 0)
				{
				}
				num = (short)1103888384;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.DataButtonCnvListProperty);
			}
			set
			{
				short num = (short)1290512594;
				short num2 = num;
				num = (short)296265938;
				switch (num2 == num)
				{
				}
				num = (short)1131151360;
				short num3 = num;
				num = (short)871825409;
				if (num != 0)
				{
				}
				num = (short)975306752;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonCnvListProperty, value);
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x000A69E4 File Offset: 0x000A4BE4
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x000A6AA0 File Offset: 0x000A4CA0
		public bool DataButtonCnvIndexIsAcpValid
		{
			get
			{
				short num = (short)1269960228;
				short num2 = num;
				num = (short)2108821028;
				switch (num2 == num)
				{
				}
				num = (short)274530304;
				short num3 = num;
				num = (short)1771372545;
				if (num != 0)
				{
				}
				num = (short)716636160;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonCnvIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)174949392;
				short num2 = num;
				num = (short)393053200;
				switch (num2 == num)
				{
				}
				num = (short)1809448960;
				short num3 = num;
				num = (short)141688833;
				if (num != 0)
				{
				}
				num = (short)1194459136;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonCnvIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x000A6B58 File Offset: 0x000A4D58
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x000A6C10 File Offset: 0x000A4E10
		public bool DataButtonCnvIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1445566522;
				short num2 = num;
				num = (short)1874434106;
				switch (num2 == num)
				{
				}
				num = (short)743505920;
				short num3 = num;
				num = (short)1564803073;
				if (num != 0)
				{
				}
				num = (short)711000064;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonCnvIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1569939260;
				short num2 = num;
				num = (short)1096245052;
				switch (num2 == num)
				{
				}
				num = (short)1893597184;
				short num3 = num;
				num = (short)224591873;
				if (num != 0)
				{
				}
				num = (short)1642987520;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonCnvIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x000A6CCC File Offset: 0x000A4ECC
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x000A6D84 File Offset: 0x000A4F84
		public bool DataButtonCnvIndexIsAcpVisible
		{
			get
			{
				short num = (short)2066624235;
				short num2 = num;
				num = (short)603598571;
				switch (num2 == num)
				{
				}
				num = (short)419627008;
				short num3 = num;
				num = (short)48758785;
				if (num != 0)
				{
				}
				num = (short)2029387776;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonCnvIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)890595331;
				short num2 = num;
				num = (short)1215784963;
				switch (num2 == num)
				{
				}
				num = (short)120717312;
				short num3 = num;
				num = (short)90505217;
				if (num != 0)
				{
				}
				num = (short)1972109312;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonCnvIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x000A6E40 File Offset: 0x000A5040
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x000A6EF8 File Offset: 0x000A50F8
		public bool DataButtonCnvIndexIsAcpEditable
		{
			get
			{
				short num = (short)2088942997;
				short num2 = num;
				num = (short)865254805;
				switch (num2 == num)
				{
				}
				num = (short)1838481408;
				short num3 = num;
				num = (short)1718288385;
				if (num != 0)
				{
				}
				num = (short)759693312;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonCnvIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1819651433;
				short num2 = num;
				num = (short)1057271145;
				switch (num2 == num)
				{
				}
				num = (short)1874198528;
				short num3 = num;
				num = (short)1238106112;
				if (num != 0)
				{
				}
				num = (short)1266810881;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonCnvIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x000A6FB0 File Offset: 0x000A51B0
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x000A7068 File Offset: 0x000A5268
		public string DataButtonCnvIndexUIValue
		{
			get
			{
				short num = (short)563381588;
				short num2 = num;
				num = (short)2009695572;
				switch (num2 == num)
				{
				}
				num = (short)380370944;
				short num3 = num;
				num = (short)1698037760;
				if (num != 0)
				{
				}
				num = (short)183304193;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.DataButtonCnvIndexUIValueProperty);
			}
			set
			{
				short num = (short)1996594129;
				short num2 = num;
				num = (short)1684904913;
				switch (num2 == num)
				{
				}
				num = (short)674955264;
				short num3 = num;
				num = (short)1355350016;
				if (num != 0)
				{
				}
				num = (short)1564475393;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonCnvIndexUIValueProperty, value);
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x000A711C File Offset: 0x000A531C
		// (set) Token: 0x06000B90 RID: 2960 RVA: 0x000A71DC File Offset: 0x000A53DC
		public AcpListField DataButtonCnvIndexList
		{
			get
			{
				short num = (short)1392026877;
				short num2 = num;
				num = (short)160015613;
				switch (num2 == num)
				{
				}
				num = (short)742326272;
				short num3 = num;
				num = (short)2099314689;
				if (num != 0)
				{
				}
				num = (short)359596032;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.DataButtonCnvIndexListProperty);
			}
			set
			{
				short num = (short)703731864;
				short num2 = num;
				num = (short)14817432;
				switch (num2 == num)
				{
				}
				num = (short)1129709568;
				short num3 = num;
				num = (short)100597760;
				if (num != 0)
				{
				}
				num = (short)1008074753;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonCnvIndexListProperty, value);
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x000A7294 File Offset: 0x000A5494
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x000A734C File Offset: 0x000A554C
		public bool DataButtonTrkIsAcpValid
		{
			get
			{
				short num = (short)318383215;
				short num2 = num;
				num = (short)1650205807;
				switch (num2 == num)
				{
				}
				num = (short)1001062400;
				short num3 = num;
				num = (short)197459968;
				if (num != 0)
				{
				}
				num = (short)869793793;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonTrkIsAcpValidProperty);
			}
			set
			{
				short num = (short)622171284;
				short num2 = num;
				num = (short)252351636;
				switch (num2 == num)
				{
				}
				num = (short)17891328;
				short num3 = num;
				num = (short)1842020353;
				if (num != 0)
				{
				}
				num = (short)1942487040;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonTrkIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x000A7408 File Offset: 0x000A5608
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x000A74C0 File Offset: 0x000A56C0
		public bool DataButtonTrkIsAcpApplicable
		{
			get
			{
				short num = (short)848374656;
				short num2 = num;
				num = (short)771304320;
				switch (num2 == num)
				{
				}
				num = (short)923664384;
				short num3 = num;
				num = (short)1411514369;
				if (num != 0)
				{
				}
				num = (short)2115633152;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonTrkIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1032016177;
				short num2 = num;
				num = (short)1370640689;
				switch (num2 == num)
				{
				}
				num = (short)1226506240;
				short num3 = num;
				num = (short)529465344;
				if (num != 0)
				{
				}
				num = (short)850264065;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonTrkIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x000A757C File Offset: 0x000A577C
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x000A763C File Offset: 0x000A583C
		public bool DataButtonTrkIsAcpVisible
		{
			get
			{
				short num = (short)177471489;
				if (num != 0)
				{
				}
				num = (short)1494204611;
				short num2 = num;
				num = (short)1284423875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)826081280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1299054592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonTrkIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)839262848;
				short num2 = num;
				num = (short)560145024;
				switch (num2 == num)
				{
				}
				num = (short)1086390272;
				short num3 = num;
				num = (short)1772486657;
				if (num != 0)
				{
				}
				num = (short)235995136;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonTrkIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x000A76F8 File Offset: 0x000A58F8
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x000A77B0 File Offset: 0x000A59B0
		public bool DataButtonTrkIsAcpEditable
		{
			get
			{
				short num = (short)48724789;
				short num2 = num;
				num = (short)373324597;
				switch (num2 == num)
				{
				}
				num = (short)1648427008;
				short num3 = num;
				num = (short)1661730817;
				if (num != 0)
				{
				}
				num = (short)1700593664;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonTrkIsAcpEditableProperty);
			}
			set
			{
				short num = (short)916126097;
				short num2 = num;
				num = (short)1681717649;
				switch (num2 == num)
				{
				}
				num = (short)1479344128;
				short num3 = num;
				num = (short)310771712;
				if (num != 0)
				{
				}
				num = (short)738656257;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonTrkIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x000A7870 File Offset: 0x000A5A70
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x000A792C File Offset: 0x000A5B2C
		public string DataButtonTrkUIValue
		{
			get
			{
				short num = (short)1480780323;
				short num2 = num;
				num = (short)698739235;
				switch (num2 == num)
				{
				}
				num = (short)3407872;
				short num3 = num;
				num = (short)1004535808;
				if (num != 0)
				{
				}
				num = (short)1618870273;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.DataButtonTrkUIValueProperty);
			}
			set
			{
				short num = (short)1372800687;
				short num2 = num;
				num = (short)26101423;
				switch (num2 == num)
				{
				}
				num = (short)190382080;
				short num3 = num;
				num = (short)1970929664;
				if (num != 0)
				{
				}
				num = (short)1293156353;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonTrkUIValueProperty, value);
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x000A79E4 File Offset: 0x000A5BE4
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x000A7AA0 File Offset: 0x000A5CA0
		public AcpListField DataButtonTrkList
		{
			get
			{
				short num = (short)827647690;
				short num2 = num;
				num = (short)58975946;
				switch (num2 == num)
				{
				}
				num = (short)345374720;
				short num3 = num;
				num = (short)83689473;
				if (num != 0)
				{
				}
				num = (short)357040128;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.DataButtonTrkListProperty);
			}
			set
			{
				short num = (short)1547652767;
				short num2 = num;
				num = (short)1288064671;
				switch (num2 == num)
				{
				}
				num = (short)1034616832;
				short num3 = num;
				num = (short)1876230145;
				if (num != 0)
				{
				}
				num = (short)1996947456;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonTrkListProperty, value);
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x000A7B58 File Offset: 0x000A5D58
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x000A7C10 File Offset: 0x000A5E10
		public bool DataButtonTrkIndexIsAcpValid
		{
			get
			{
				short num = (short)170139744;
				short num2 = num;
				num = (short)710090848;
				switch (num2 == num)
				{
				}
				num = (short)747503616;
				short num3 = num;
				num = (short)1471217665;
				if (num != 0)
				{
				}
				num = (short)1682374656;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonTrkIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1697368924;
				short num2 = num;
				num = (short)1038076764;
				switch (num2 == num)
				{
				}
				num = (short)1414922240;
				short num3 = num;
				num = (short)1224605697;
				if (num != 0)
				{
				}
				num = (short)196804608;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonTrkIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x000A7CC8 File Offset: 0x000A5EC8
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x000A7D80 File Offset: 0x000A5F80
		public bool DataButtonTrkIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1260942484;
				short num2 = num;
				num = (short)2097837204;
				switch (num2 == num)
				{
				}
				num = (short)552599552;
				short num3 = num;
				num = (short)185991168;
				if (num != 0)
				{
				}
				num = (short)47448065;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonTrkIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)741199135;
				short num2 = num;
				num = (short)408210719;
				switch (num2 == num)
				{
				}
				num = (short)1954349056;
				short num3 = num;
				num = (short)50069505;
				if (num != 0)
				{
				}
				num = (short)1914044416;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonTrkIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x000A7E3C File Offset: 0x000A603C
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x000A7EF8 File Offset: 0x000A60F8
		public bool DataButtonTrkIndexIsAcpVisible
		{
			get
			{
				short num = (short)1886519297;
				if (num != 0)
				{
				}
				num = (short)1324909210;
				short num2 = num;
				num = (short)566198938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)610467840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1714946048;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonTrkIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)540737537;
				if (num != 0)
				{
				}
				num = (short)382619712;
				short num2 = num;
				num = (short)2083082304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)289734656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)234029056;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonTrkIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x000A7FB4 File Offset: 0x000A61B4
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x000A806C File Offset: 0x000A626C
		public bool DataButtonTrkIndexIsAcpEditable
		{
			get
			{
				short num = (short)1909866323;
				short num2 = num;
				num = (short)1917730643;
				switch (num2 == num)
				{
				}
				num = (short)1445462016;
				short num3 = num;
				num = (short)762707968;
				if (num != 0)
				{
				}
				num = (short)870252545;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DataButtonTrkIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1103364097;
				if (num != 0)
				{
				}
				num = (short)1033169933;
				short num2 = num;
				num = (short)328395789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2002321408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1100546048;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonTrkIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x000A8128 File Offset: 0x000A6328
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x000A81E0 File Offset: 0x000A63E0
		public string DataButtonTrkIndexUIValue
		{
			get
			{
				short num = (short)460488273;
				short num2 = num;
				num = (short)1677360721;
				switch (num2 == num)
				{
				}
				num = (short)50528256;
				short num3 = num;
				num = (short)679804929;
				if (num != 0)
				{
				}
				num = (short)367460352;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.DataButtonTrkIndexUIValueProperty);
			}
			set
			{
				short num = (short)134781500;
				short num2 = num;
				num = (short)1898420796;
				switch (num2 == num)
				{
				}
				num = (short)257556480;
				short num3 = num;
				num = (short)1692598273;
				if (num != 0)
				{
				}
				num = (short)2111504384;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonTrkIndexUIValueProperty, value);
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x000A8298 File Offset: 0x000A6498
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x000A8350 File Offset: 0x000A6550
		public AcpListField DataButtonTrkIndexList
		{
			get
			{
				short num = (short)172669922;
				short num2 = num;
				num = (short)974633954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1180106752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1402863617;
				if (num != 0)
				{
				}
				num = (short)1621032960;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.DataButtonTrkIndexListProperty);
			}
			set
			{
				short num = (short)1966791484;
				short num2 = num;
				num = (short)695851836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1275920384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)199819264;
				if (num != 0)
				{
				}
				num = (short)1786445825;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DataButtonTrkIndexListProperty, value);
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x000A8404 File Offset: 0x000A6604
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x000A84C0 File Offset: 0x000A66C0
		public bool EmergencyButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)2044722272;
				short num2 = num;
				num = (short)397540448;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1916338176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)541786113;
				if (num != 0)
				{
				}
				num = (short)2132148224;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.EmergencyButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)256901121;
				if (num != 0)
				{
				}
				num = (short)1716649984;
				short num2 = num;
				num = (short)970347002;
				short num3 = num;
				num = (short)1280922106;
				switch (num3 == num)
				{
				}
				num = (short)1953955840;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.EmergencyButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x000A857C File Offset: 0x000A677C
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x000A8634 File Offset: 0x000A6834
		public bool EmergencyButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)279265160;
				short num2 = num;
				num = (short)1275346824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)554237952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2031419393;
				if (num != 0)
				{
				}
				num = (short)578027520;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)845181810;
				short num2 = num;
				num = (short)678982514;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1084358656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1781727232;
				if (num != 0)
				{
				}
				num = (short)1059127297;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x000A86F0 File Offset: 0x000A68F0
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x000A87A8 File Offset: 0x000A69A8
		public bool EmergencyButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)2032766240;
				short num2 = num;
				num = (short)805604640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)120913920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1845559297;
				if (num != 0)
				{
				}
				num = (short)1690435584;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2131200439;
				short num2 = num;
				num = (short)265193911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1835008000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)669057024;
				if (num != 0)
				{
				}
				num = (short)1063714817;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x000A8860 File Offset: 0x000A6A60
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x000A891C File Offset: 0x000A6B1C
		public bool EmergencyButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)257577405;
				short num2 = num;
				num = (short)1014321597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1252327424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)338362368;
				if (num != 0)
				{
				}
				num = (short)871694337;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.EmergencyButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)268774198;
				short num2 = num;
				num = (short)811412278;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1428881408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1337655296;
				if (num != 0)
				{
				}
				num = (short)1461714945;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.EmergencyButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x000A89D4 File Offset: 0x000A6BD4
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x000A8A8C File Offset: 0x000A6C8C
		public string EmergencyButtonFeatureUIValue
		{
			get
			{
				short num = (short)56161943;
				short num2 = num;
				num = (short)1428223639;
				switch (num2 == num)
				{
				default:
				{
					num = (short)960757760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)197918721;
				if (num != 0)
				{
				}
				num = (short)436797440;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.EmergencyButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)645428699;
				short num2 = num;
				num = (short)502756827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)752877568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1988165632;
				if (num != 0)
				{
				}
				num = (short)319946753;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.EmergencyButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x000A8B44 File Offset: 0x000A6D44
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x000A8C00 File Offset: 0x000A6E00
		public AcpListField EmergencyButtonFeatureList
		{
			get
			{
				short num = (short)1508293837;
				short num2 = num;
				num = (short)483179725;
				switch (num2 == num)
				{
				default:
				{
					num = (short)655687680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)99549185;
				if (num != 0)
				{
				}
				num = (short)617218048;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.EmergencyButtonFeatureListProperty);
			}
			set
			{
				short num = (short)1749396324;
				short num2 = num;
				num = (short)577153892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)694943744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)199098368;
				if (num != 0)
				{
				}
				num = (short)724434945;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.EmergencyButtonFeatureListProperty, value);
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x000A8CB4 File Offset: 0x000A6EB4
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x000A8D6C File Offset: 0x000A6F6C
		public bool PursuitButton0FeatureIsAcpValid
		{
			get
			{
				short num = (short)401392416;
				short num2 = num;
				num = (short)581092128;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1255276544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)791281664;
				if (num != 0)
				{
				}
				num = (short)2106064897;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton0FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)773104297;
				short num2 = num;
				num = (short)1859166889;
				switch (num2 == num)
				{
				default:
				{
					num = (short)732561408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)463732737;
				if (num != 0)
				{
				}
				num = (short)758906880;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton0FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x000A8E28 File Offset: 0x000A7028
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x000A8EE4 File Offset: 0x000A70E4
		public bool PursuitButton0FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1448025092;
				short num2 = num;
				num = (short)386014212;
				switch (num2 == num)
				{
				default:
				{
					num = (short)365363200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2078081024;
				if (num != 0)
				{
				}
				num = (short)985333761;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton0FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)89851201;
				short num2 = num;
				num = (short)1349125441;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1973026816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1110966273;
				if (num != 0)
				{
				}
				num = (short)1939931136;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton0FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x000A8FA0 File Offset: 0x000A71A0
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x000A905C File Offset: 0x000A725C
		public bool PursuitButton0FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1100466950;
				short num2 = num;
				num = (short)1033292550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1569062912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)127467521;
				if (num != 0)
				{
				}
				num = (short)777125888;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton0FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1825780552;
				short num2 = num;
				num = (short)1415394120;
				switch (num2 == num)
				{
				default:
				{
					num = (short)370278400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1557463041;
				if (num != 0)
				{
				}
				num = (short)914817024;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton0FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x000A9114 File Offset: 0x000A7314
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x000A91D0 File Offset: 0x000A73D0
		public bool PursuitButton0FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1047838382;
				short num2 = num;
				num = (short)804044462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1507328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)439877632;
				if (num != 0)
				{
				}
				num = (short)481230849;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton0FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1440466805;
				short num2 = num;
				num = (short)1381091189;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1925382144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1333067776;
				if (num != 0)
				{
				}
				num = (short)1829175297;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton0FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x000A928C File Offset: 0x000A748C
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x000A9344 File Offset: 0x000A7544
		public string PursuitButton0FeatureUIValue
		{
			get
			{
				short num = (short)286891333;
				short num2 = num;
				num = (short)596155717;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1147994112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)589561857;
				if (num != 0)
				{
				}
				num = (short)633864192;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.PursuitButton0FeatureUIValueProperty);
			}
			set
			{
				short num = (short)299977115;
				short num2 = num;
				num = (short)2077051291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)207683584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)500563968;
				if (num != 0)
				{
				}
				num = (short)192282625;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton0FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x000A93FC File Offset: 0x000A75FC
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x000A94B4 File Offset: 0x000A76B4
		public AcpListField PursuitButton0FeatureList
		{
			get
			{
				short num = (short)1855799004;
				short num2 = num;
				num = (short)916602588;
				switch (num2 == num)
				{
				default:
				{
					num = (short)307036160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1911816192;
				if (num != 0)
				{
				}
				num = (short)1219362817;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.PursuitButton0FeatureListProperty);
			}
			set
			{
				short num = (short)310797199;
				short num2 = num;
				num = (short)63136655;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2081947648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1027014657;
				if (num != 0)
				{
				}
				num = (short)1856765952;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton0FeatureListProperty, value);
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x000A956C File Offset: 0x000A776C
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x000A9624 File Offset: 0x000A7824
		public bool PursuitButton0IndexIsAcpValid
		{
			get
			{
				short num = (short)744092527;
				short num2 = num;
				num = (short)2097017711;
				switch (num2 == num)
				{
				default:
				{
					num = (short)601489408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1256587265;
				if (num != 0)
				{
				}
				num = (short)1778778112;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton0IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)868155393;
				if (num != 0)
				{
				}
				num = (short)1587281920;
				short num2 = num;
				num = (short)2089021557;
				short num3 = num;
				num = (short)183103605;
				switch (num3 == num)
				{
				}
				num = (short)1344405504;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton0IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x000A96E0 File Offset: 0x000A78E0
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x000A9798 File Offset: 0x000A7998
		public bool PursuitButton0IndexIsAcpApplicable
		{
			get
			{
				short num = (short)428878542;
				short num2 = num;
				num = (short)988818126;
				switch (num2 == num)
				{
				default:
				{
					num = (short)300023808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)439418880;
				if (num != 0)
				{
				}
				num = (short)472449025;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton0IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1399600403;
				short num2 = num;
				num = (short)939734291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1760100352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)293732352;
				if (num != 0)
				{
				}
				num = (short)1994391553;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton0IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x000A9850 File Offset: 0x000A7A50
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x000A9908 File Offset: 0x000A7B08
		public bool PursuitButton0IndexIsAcpVisible
		{
			get
			{
				short num = (short)1644036097;
				if (num != 0)
				{
				}
				num = (short)296747008;
				short num2 = num;
				num = (short)632446078;
				short num3 = num;
				num = (short)565206142;
				switch (num3 == num)
				{
				}
				num = (short)337248256;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton0IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)878819567;
				short num2 = num;
				num = (short)203667695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)904200192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1792344065;
				if (num != 0)
				{
				}
				num = (short)1884684288;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton0IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x000A99C4 File Offset: 0x000A7BC4
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x000A9A7C File Offset: 0x000A7C7C
		public bool PursuitButton0IndexIsAcpEditable
		{
			get
			{
				short num = (short)1753520710;
				short num2 = num;
				num = (short)1445894726;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1401946112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1856438273;
				if (num != 0)
				{
				}
				num = (short)991363072;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton0IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1853721138;
				short num2 = num;
				num = (short)184388146;
				switch (num2 == num)
				{
				default:
				{
					num = (short)454819840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)681181185;
				if (num != 0)
				{
				}
				num = (short)1487667200;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton0IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x000A9B34 File Offset: 0x000A7D34
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x000A9BF0 File Offset: 0x000A7DF0
		public string PursuitButton0IndexUIValue
		{
			get
			{
				short num = (short)1726011570;
				short num2 = num;
				num = (short)2094454962;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1731919872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)428277761;
				if (num != 0)
				{
				}
				num = (short)1606418432;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.PursuitButton0IndexUIValueProperty);
			}
			set
			{
				short num = (short)943083587;
				short num2 = num;
				num = (short)545411139;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2094399488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)605224961;
				if (num != 0)
				{
				}
				num = (short)1914634240;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton0IndexUIValueProperty, value);
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x000A9CA4 File Offset: 0x000A7EA4
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x000A9D5C File Offset: 0x000A7F5C
		public AcpListField PursuitButton0IndexList
		{
			get
			{
				short num = (short)866473168;
				short num2 = num;
				num = (short)1446204624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)971046912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)715915265;
				if (num != 0)
				{
				}
				num = (short)922353664;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.PursuitButton0IndexListProperty);
			}
			set
			{
				short num = (short)819462145;
				if (num != 0)
				{
				}
				num = (short)147849216;
				short num2 = num;
				num = (short)444100296;
				short num3 = num;
				num = (short)1705340616;
				switch (num3 == num)
				{
				}
				num = (short)2112749568;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton0IndexListProperty, value);
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x000A9E10 File Offset: 0x000A8010
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x000A9EC8 File Offset: 0x000A80C8
		public bool PursuitButton1FeatureIsAcpValid
		{
			get
			{
				short num = (short)2085937911;
				short num2 = num;
				num = (short)2104353527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)655032320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)785973249;
				if (num != 0)
				{
				}
				num = (short)119013376;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton1FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1463224258;
				short num2 = num;
				num = (short)105449410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)793903104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1370554368;
				if (num != 0)
				{
				}
				num = (short)1652883457;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton1FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x000A9F84 File Offset: 0x000A8184
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x000AA03C File Offset: 0x000A823C
		public bool PursuitButton1FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1353673840;
				short num2 = num;
				num = (short)280718448;
				switch (num2 == num)
				{
				default:
				{
					num = (short)546045952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)260571137;
				if (num != 0)
				{
				}
				num = (short)1512701952;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton1FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)505610241;
				if (num != 0)
				{
				}
				num = (short)1862074368;
				short num2 = num;
				num = (short)1950769260;
				short num3 = num;
				num = (short)1840930924;
				switch (num3 == num)
				{
				}
				num = (short)1932591104;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton1FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x000AA0F8 File Offset: 0x000A82F8
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x000AA1B4 File Offset: 0x000A83B4
		public bool PursuitButton1FeatureIsAcpVisible
		{
			get
			{
				short num = (short)365232129;
				if (num != 0)
				{
				}
				num = (short)162725888;
				short num2 = num;
				num = (short)985003250;
				short num3 = num;
				num = (short)1276179698;
				switch (num3 == num)
				{
				}
				num = (short)817496064;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton1FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1412348819;
				short num2 = num;
				num = (short)1943845779;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1668612096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1286733825;
				if (num != 0)
				{
				}
				num = (short)1083572224;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton1FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x000AA270 File Offset: 0x000A8470
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x000AA328 File Offset: 0x000A8528
		public bool PursuitButton1FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1680300040;
				short num2 = num;
				num = (short)1075992584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1292894208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)55443457;
				if (num != 0)
				{
				}
				num = (short)217907200;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton1FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1551805060;
				short num2 = num;
				num = (short)649570948;
				switch (num2 == num)
				{
				default:
				{
					num = (short)756547584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1908932608;
				if (num != 0)
				{
				}
				num = (short)1904082945;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton1FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x000AA3E0 File Offset: 0x000A85E0
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x000AA498 File Offset: 0x000A8698
		public string PursuitButton1FeatureUIValue
		{
			get
			{
				short num = (short)788598414;
				short num2 = num;
				num = (short)1874923150;
				switch (num2 == num)
				{
				default:
				{
					num = (short)866516992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2092761089;
				if (num != 0)
				{
				}
				num = (short)548798464;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.PursuitButton1FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1466681648;
				short num2 = num;
				num = (short)1642580272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1410727936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)422182913;
				if (num != 0)
				{
				}
				num = (short)916062208;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton1FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x000AA550 File Offset: 0x000A8750
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x000AA608 File Offset: 0x000A8808
		public AcpListField PursuitButton1FeatureList
		{
			get
			{
				short num = (short)2008287743;
				short num2 = num;
				num = (short)1244858879;
				switch (num2 == num)
				{
				default:
				{
					num = (short)799604736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)890765313;
				if (num != 0)
				{
				}
				num = (short)1301020672;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.PursuitButton1FeatureListProperty);
			}
			set
			{
				short num = (short)302899185;
				short num2 = num;
				num = (short)939188209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954990592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)26673152;
				if (num != 0)
				{
				}
				num = (short)1719664641;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton1FeatureListProperty, value);
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x000AA6BC File Offset: 0x000A88BC
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x000AA774 File Offset: 0x000A8974
		public bool PursuitButton1IndexIsAcpValid
		{
			get
			{
				short num = (short)1815622716;
				short num2 = num;
				num = (short)1271936060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)211615744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1239482369;
				if (num != 0)
				{
				}
				num = (short)831717376;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton1IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1985690130;
				short num2 = num;
				num = (short)1524447762;
				switch (num2 == num)
				{
				default:
				{
					num = (short)351207424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2027618305;
				if (num != 0)
				{
				}
				num = (short)1883176960;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton1IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x000AA830 File Offset: 0x000A8A30
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x000AA8E8 File Offset: 0x000A8AE8
		public bool PursuitButton1IndexIsAcpApplicable
		{
			get
			{
				short num = (short)146743559;
				short num2 = num;
				num = (short)842735879;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2060124160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)755761153;
				if (num != 0)
				{
				}
				num = (short)1414987776;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton1IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1833519881;
				short num2 = num;
				num = (short)775310089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)547487744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)751763456;
				if (num != 0)
				{
				}
				num = (short)604307457;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton1IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x000AA9A4 File Offset: 0x000A8BA4
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x000AAA60 File Offset: 0x000A8C60
		public bool PursuitButton1IndexIsAcpVisible
		{
			get
			{
				short num = (short)1034738573;
				short num2 = num;
				num = (short)1939528589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1379205120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1203175425;
				if (num != 0)
				{
				}
				num = (short)1613365248;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton1IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1162015853;
				short num2 = num;
				num = (short)534443117;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2008940544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1631911937;
				if (num != 0)
				{
				}
				num = (short)362479616;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton1IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x000AAB1C File Offset: 0x000A8D1C
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x000AABD4 File Offset: 0x000A8DD4
		public bool PursuitButton1IndexIsAcpEditable
		{
			get
			{
				short num = (short)166608374;
				short num2 = num;
				num = (short)623656438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1598750720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)302514176;
				if (num != 0)
				{
				}
				num = (short)727908353;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton1IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1874637509;
				short num2 = num;
				num = (short)1821291205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)705232896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)742916097;
				if (num != 0)
				{
				}
				num = (short)351404032;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton1IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x000AAC90 File Offset: 0x000A8E90
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x000AAD48 File Offset: 0x000A8F48
		public string PursuitButton1IndexUIValue
		{
			get
			{
				short num = (short)843387678;
				short num2 = num;
				num = (short)221975326;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1288830976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)715587585;
				if (num != 0)
				{
				}
				num = (short)1551761408;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.PursuitButton1IndexUIValueProperty);
			}
			set
			{
				short num = (short)1183767545;
				short num2 = num;
				num = (short)1027529721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1466892288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1647771649;
				if (num != 0)
				{
				}
				num = (short)558432256;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton1IndexUIValueProperty, value);
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x000AADFC File Offset: 0x000A8FFC
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x000AAEB4 File Offset: 0x000A90B4
		public AcpListField PursuitButton1IndexList
		{
			get
			{
				short num = (short)1314816003;
				short num2 = num;
				num = (short)819167235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1030094848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1469972481;
				if (num != 0)
				{
				}
				num = (short)543883264;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.PursuitButton1IndexListProperty);
			}
			set
			{
				short num = (short)1712430250;
				short num2 = num;
				num = (short)1592499370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1251606528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)982843393;
				if (num != 0)
				{
				}
				num = (short)2106785792;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton1IndexListProperty, value);
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x000AAF6C File Offset: 0x000A916C
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x000AB028 File Offset: 0x000A9228
		public bool PursuitButton2FeatureIsAcpValid
		{
			get
			{
				short num = (short)952721129;
				short num2 = num;
				num = (short)1854299881;
				switch (num2 == num)
				{
				default:
				{
					num = (short)870842368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)403374080;
				if (num != 0)
				{
				}
				num = (short)627572737;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton2FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)592125097;
				short num2 = num;
				num = (short)1755520169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1623654400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2088566784;
				if (num != 0)
				{
				}
				num = (short)2081685505;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton2FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x000AB0E4 File Offset: 0x000A92E4
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x000AB1A0 File Offset: 0x000A93A0
		public bool PursuitButton2FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1273679544;
				short num2 = num;
				num = (short)1458491064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)664731648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)98762753;
				if (num != 0)
				{
				}
				num = (short)1768030208;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton2FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)439172519;
				short num2 = num;
				num = (short)2041265575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1394475008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)720044033;
				if (num != 0)
				{
				}
				num = (short)2032402432;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton2FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x000AB258 File Offset: 0x000A9458
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x000AB310 File Offset: 0x000A9510
		public bool PursuitButton2FeatureIsAcpVisible
		{
			get
			{
				short num = (short)820435860;
				short num2 = num;
				num = (short)581491604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)414056448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)870580225;
				if (num != 0)
				{
				}
				num = (short)904527872;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton2FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)238957211;
				short num2 = num;
				num = (short)1514746523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)60882944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1374748672;
				if (num != 0)
				{
				}
				num = (short)227147777;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton2FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x000AB3CC File Offset: 0x000A95CC
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x000AB484 File Offset: 0x000A9684
		public bool PursuitButton2FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1823199921;
				short num2 = num;
				num = (short)2125189809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1238827008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)270991361;
				if (num != 0)
				{
				}
				num = (short)1597374464;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton2FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2002678492;
				short num2 = num;
				num = (short)827486940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1363804160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1301872641;
				if (num != 0)
				{
				}
				num = (short)172883968;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton2FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x000AB540 File Offset: 0x000A9740
		// (set) Token: 0x06000BEE RID: 3054 RVA: 0x000AB5FC File Offset: 0x000A97FC
		public string PursuitButton2FeatureUIValue
		{
			get
			{
				short num = (short)896159192;
				short num2 = num;
				num = (short)1896631768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1120993280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)416088065;
				if (num != 0)
				{
				}
				num = (short)453902336;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.PursuitButton2FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1074507068;
				short num2 = num;
				num = (short)855813436;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1060896768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)434831361;
				if (num != 0)
				{
				}
				num = (short)1362558976;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton2FeatureUIValueProperty, value);
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x000AB6B0 File Offset: 0x000A98B0
		// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x000AB768 File Offset: 0x000A9968
		public AcpListField PursuitButton2FeatureList
		{
			get
			{
				short num = (short)1752956929;
				if (num != 0)
				{
				}
				num = (short)1767833600;
				short num2 = num;
				num = (short)540353097;
				short num3 = num;
				num = (short)1147740745;
				switch (num3 == num)
				{
				}
				num = (short)834994176;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.PursuitButton2FeatureListProperty);
			}
			set
			{
				short num = (short)1720042307;
				short num2 = num;
				num = (short)1428800323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)221904896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)436666369;
				if (num != 0)
				{
				}
				num = (short)632422400;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton2FeatureListProperty, value);
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x000AB820 File Offset: 0x000A9A20
		// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x000AB8DC File Offset: 0x000A9ADC
		public bool PursuitButton2IndexIsAcpValid
		{
			get
			{
				short num = (short)2136393431;
				short num2 = num;
				num = (short)1031915223;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1575419904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)527958016;
				if (num != 0)
				{
				}
				num = (short)223215617;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton2IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1967283778;
				short num2 = num;
				num = (short)422927938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)80412672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)55115776;
				if (num != 0)
				{
				}
				num = (short)324403201;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton2IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x000AB998 File Offset: 0x000A9B98
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x000ABA54 File Offset: 0x000A9C54
		public bool PursuitButton2IndexIsAcpApplicable
		{
			get
			{
				short num = (short)1125438083;
				short num2 = num;
				num = (short)1258148483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)318767104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)40239105;
				if (num != 0)
				{
				}
				num = (short)1151205376;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton2IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2074599858;
				short num2 = num;
				num = (short)342679986;
				switch (num2 == num)
				{
				default:
				{
					num = (short)93847552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1039597569;
				if (num != 0)
				{
				}
				num = (short)256245760;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton2IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x000ABB10 File Offset: 0x000A9D10
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x000ABBC8 File Offset: 0x000A9DC8
		public bool PursuitButton2IndexIsAcpVisible
		{
			get
			{
				short num = (short)1368191378;
				short num2 = num;
				num = (short)191951250;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1259536384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1795883009;
				if (num != 0)
				{
				}
				num = (short)867041280;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton2IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)670405720;
				short num2 = num;
				num = (short)1911657560;
				switch (num2 == num)
				{
				default:
				{
					num = (short)762052608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1016070144;
				if (num != 0)
				{
				}
				num = (short)239468545;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton2IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x000ABC84 File Offset: 0x000A9E84
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x000ABD40 File Offset: 0x000A9F40
		public bool PursuitButton2IndexIsAcpEditable
		{
			get
			{
				short num = (short)41243904;
				short num2 = num;
				num = (short)1906201856;
				switch (num2 == num)
				{
				default:
				{
					num = (short)421593088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1358495745;
				if (num != 0)
				{
				}
				num = (short)2071920640;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton2IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)186449921;
				if (num != 0)
				{
				}
				num = (short)621674496;
				short num2 = num;
				num = (short)58403391;
				short num3 = num;
				num = (short)1200826943;
				switch (num3 == num)
				{
				}
				num = (short)30081024;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton2IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x000ABDF8 File Offset: 0x000A9FF8
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x000ABEB4 File Offset: 0x000AA0B4
		public string PursuitButton2IndexUIValue
		{
			get
			{
				short num = (short)1996154486;
				short num2 = num;
				num = (short)1920919158;
				switch (num2 == num)
				{
				default:
				{
					num = (short)357171200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1715077121;
				if (num != 0)
				{
				}
				num = (short)1484324864;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.PursuitButton2IndexUIValueProperty);
			}
			set
			{
				short num = (short)529530881;
				if (num != 0)
				{
				}
				num = (short)1269497856;
				short num2 = num;
				num = (short)306203356;
				short num3 = num;
				num = (short)882199260;
				switch (num3 == num)
				{
				}
				num = (short)750977024;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton2IndexUIValueProperty, value);
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x000ABF6C File Offset: 0x000AA16C
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x000AC024 File Offset: 0x000AA224
		public AcpListField PursuitButton2IndexList
		{
			get
			{
				short num = (short)1626734807;
				short num2 = num;
				num = (short)829423831;
				switch (num2 == num)
				{
				default:
				{
					num = (short)599982080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)577830913;
				if (num != 0)
				{
				}
				num = (short)1986985984;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.PursuitButton2IndexListProperty);
			}
			set
			{
				short num = (short)1751261803;
				short num2 = num;
				num = (short)1829118571;
				switch (num2 == num)
				{
				default:
				{
					num = (short)919273472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1350500353;
				if (num != 0)
				{
				}
				num = (short)1360265216;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton2IndexListProperty, value);
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x000AC0D8 File Offset: 0x000AA2D8
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x000AC190 File Offset: 0x000AA390
		public bool PursuitButton3FeatureIsAcpValid
		{
			get
			{
				short num = (short)1654429672;
				short num2 = num;
				num = (short)1822267368;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1667301376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1492582400;
				if (num != 0)
				{
				}
				num = (short)1725956097;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton3FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)799821629;
				short num2 = num;
				num = (short)1301696317;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1258422272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2116681729;
				if (num != 0)
				{
				}
				num = (short)630063104;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton3FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x000AC24C File Offset: 0x000AA44C
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x000AC308 File Offset: 0x000AA508
		public bool PursuitButton3FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)526036644;
				short num2 = num;
				num = (short)641773220;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1593180160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1286209536;
				if (num != 0)
				{
				}
				num = (short)502726657;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton3FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2111759429;
				short num2 = num;
				num = (short)1549526085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)655360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1773010944;
				if (num != 0)
				{
				}
				num = (short)2105081857;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton3FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x000AC3C0 File Offset: 0x000AA5C0
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x000AC47C File Offset: 0x000AA67C
		public bool PursuitButton3FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1720259148;
				short num2 = num;
				num = (short)1833964108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)713162752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1548091393;
				if (num != 0)
				{
				}
				num = (short)2007105536;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton3FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)88646154;
				short num2 = num;
				num = (short)989962762;
				switch (num2 == num)
				{
				default:
				{
					num = (short)42008576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)239796225;
				if (num != 0)
				{
				}
				num = (short)1142947840;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton3FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x000AC534 File Offset: 0x000AA734
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x000AC5F0 File Offset: 0x000AA7F0
		public bool PursuitButton3FeatureIsAcpEditable
		{
			get
			{
				short num = (short)2095733674;
				short num2 = num;
				num = (short)422271914;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1923284992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1845231616;
				if (num != 0)
				{
				}
				num = (short)1627586561;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton3FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1917978366;
				short num2 = num;
				num = (short)413927166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)502398976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1734475777;
				if (num != 0)
				{
				}
				num = (short)1854210048;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton3FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x000AC6A8 File Offset: 0x000AA8A8
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x000AC764 File Offset: 0x000AA964
		public string PursuitButton3FeatureUIValue
		{
			get
			{
				short num = (short)1117423551;
				short num2 = num;
				num = (short)358844351;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2100297728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1258291201;
				if (num != 0)
				{
				}
				num = (short)2096300032;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.PursuitButton3FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1644154822;
				short num2 = num;
				num = (short)1666109382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1165099008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1381695489;
				if (num != 0)
				{
				}
				num = (short)1374027776;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton3FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x000AC818 File Offset: 0x000AAA18
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x000AC8D4 File Offset: 0x000AAAD4
		public AcpListField PursuitButton3FeatureList
		{
			get
			{
				short num = (short)1817641346;
				short num2 = num;
				num = (short)1367605634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1539047424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)702152705;
				if (num != 0)
				{
				}
				num = (short)1602420736;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.PursuitButton3FeatureListProperty);
			}
			set
			{
				short num = (short)2145966152;
				short num2 = num;
				num = (short)1815861320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2043740160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1583677441;
				if (num != 0)
				{
				}
				num = (short)841547776;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton3FeatureListProperty, value);
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x000AC988 File Offset: 0x000AAB88
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x000ACA40 File Offset: 0x000AAC40
		public bool PursuitButton3IndexIsAcpValid
		{
			get
			{
				short num = (short)886177793;
				if (num != 0)
				{
				}
				num = (short)1511784448;
				short num2 = num;
				num = (short)5500123;
				short num3 = num;
				num = (short)1552018651;
				switch (num3 == num)
				{
				}
				num = (short)488046592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton3IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1696537184;
				short num2 = num;
				num = (short)815864416;
				switch (num2 == num)
				{
				default:
				{
					num = (short)256311296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)624033792;
				if (num != 0)
				{
				}
				num = (short)2142961665;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton3IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x000ACAFC File Offset: 0x000AACFC
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x000ACBB8 File Offset: 0x000AADB8
		public bool PursuitButton3IndexIsAcpApplicable
		{
			get
			{
				short num = (short)2107952879;
				short num2 = num;
				num = (short)1860620015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)909770752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1054867457;
				if (num != 0)
				{
				}
				num = (short)1963524096;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton3IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1877072883;
				short num2 = num;
				num = (short)1211948019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1516044288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)102563841;
				if (num != 0)
				{
				}
				num = (short)732758016;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton3IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x000ACC74 File Offset: 0x000AAE74
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x000ACD30 File Offset: 0x000AAF30
		public bool PursuitButton3IndexIsAcpVisible
		{
			get
			{
				short num = (short)700645376;
				short num2 = num;
				num = (short)1283716734;
				short num3 = num;
				num = (short)57079422;
				switch (num3 == num)
				{
				}
				num = (short)935002113;
				if (num != 0)
				{
				}
				num = (short)1513488384;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton3IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1043660800;
				short num2 = num;
				num = (short)830838562;
				short num3 = num;
				num = (short)691967778;
				switch (num3 == num)
				{
				}
				num = (short)401670144;
				if (num != 0)
				{
				}
				num = (short)121765889;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton3IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x000ACDEC File Offset: 0x000AAFEC
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x000ACEA4 File Offset: 0x000AB0A4
		public bool PursuitButton3IndexIsAcpEditable
		{
			get
			{
				short num = (short)19529728;
				short num2 = num;
				num = (short)375362072;
				short num3 = num;
				num = (short)1641452056;
				switch (num3 == num)
				{
				}
				num = (short)381353985;
				if (num != 0)
				{
				}
				num = (short)475004928;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PursuitButton3IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)862912512;
				short num2 = num;
				num = (short)302221055;
				short num3 = num;
				num = (short)791054079;
				switch (num3 == num)
				{
				}
				num = (short)606863361;
				if (num != 0)
				{
				}
				num = (short)929824768;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton3IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x000ACF5C File Offset: 0x000AB15C
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x000AD018 File Offset: 0x000AB218
		public string PursuitButton3IndexUIValue
		{
			get
			{
				short num = (short)1308688384;
				short num2 = num;
				num = (short)1741297608;
				short num3 = num;
				num = (short)1025382344;
				switch (num3 == num)
				{
				}
				num = (short)1851129857;
				if (num != 0)
				{
				}
				num = (short)170459136;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.PursuitButton3IndexUIValueProperty);
			}
			set
			{
				short num = (short)1127546880;
				short num2 = num;
				num = (short)1534001153;
				if (num != 0)
				{
				}
				num = (short)253189572;
				short num3 = num;
				num = (short)1365138884;
				switch (num3 == num)
				{
				}
				num = (short)1018626048;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton3IndexUIValueProperty, value);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x000AD0D0 File Offset: 0x000AB2D0
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x000AD188 File Offset: 0x000AB388
		public AcpListField PursuitButton3IndexList
		{
			get
			{
				short num = (short)531431424;
				short num2 = num;
				num = (short)832930865;
				short num3 = num;
				num = (short)903775281;
				switch (num3 == num)
				{
				}
				num = (short)2038169600;
				if (num != 0)
				{
				}
				num = (short)1653997569;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.PursuitButton3IndexListProperty);
			}
			set
			{
				short num = (short)7274496;
				short num2 = num;
				num = (short)1922661707;
				short num3 = num;
				num = (short)785677643;
				switch (num3 == num)
				{
				}
				num = (short)67239936;
				if (num != 0)
				{
				}
				num = (short)1983512577;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PursuitButton3IndexListProperty, value);
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x000AD23C File Offset: 0x000AB43C
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x000AD2F8 File Offset: 0x000AB4F8
		public AcpListField MenuItemsConventionalSelectedList
		{
			get
			{
				short num = (short)1360920576;
				short num2 = num;
				num = (short)503063017;
				short num3 = num;
				num = (short)1009918441;
				switch (num3 == num)
				{
				}
				num = (short)1566113792;
				if (num != 0)
				{
				}
				num = (short)620429313;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.MenuItemsConventionalSelectedListProperty);
			}
			set
			{
				short num = (short)29818880;
				short num2 = num;
				num = (short)1128750148;
				short num3 = num;
				num = (short)1434672196;
				switch (num3 == num)
				{
				}
				num = (short)1346306049;
				if (num != 0)
				{
				}
				num = (short)1674182656;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.MenuItemsConventionalSelectedListProperty, value);
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x000AD3B0 File Offset: 0x000AB5B0
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x000AD468 File Offset: 0x000AB668
		public AcpListField MenuItemsTrunkingSelectedList
		{
			get
			{
				short num = (short)1734017024;
				short num2 = num;
				num = (short)1805304114;
				short num3 = num;
				num = (short)455852338;
				switch (num3 == num)
				{
				}
				num = (short)1991180288;
				if (num != 0)
				{
				}
				num = (short)126746625;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.MenuItemsTrunkingSelectedListProperty);
			}
			set
			{
				short num = (short)1205600256;
				short num2 = num;
				num = (short)1816493766;
				short num3 = num;
				num = (short)2109112006;
				switch (num3 == num)
				{
				}
				num = (short)397213697;
				if (num != 0)
				{
				}
				num = (short)206700544;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.MenuItemsTrunkingSelectedListProperty, value);
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x000AD51C File Offset: 0x000AB71C
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x000AD5D8 File Offset: 0x000AB7D8
		public bool MenuItemsConventionalSelectedListVisibility
		{
			get
			{
				short num = (short)273678336;
				short num2 = num;
				num = (short)1785890552;
				short num3 = num;
				num = (short)402163448;
				switch (num3 == num)
				{
				}
				num = (short)1075773441;
				if (num != 0)
				{
				}
				num = (short)1079508992;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.MenuItemsConventionalSelectedListVisibilityProperty);
			}
			set
			{
				short num = (short)284229632;
				short num2 = num;
				num = (short)2142328259;
				short num3 = num;
				num = (short)522278339;
				switch (num3 == num)
				{
				}
				num = (short)1248460801;
				if (num != 0)
				{
				}
				num = (short)341901312;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.MenuItemsConventionalSelectedListVisibilityProperty, value);
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x000AD690 File Offset: 0x000AB890
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x000AD74C File Offset: 0x000AB94C
		public bool MenuItemsTrunkingSelectedListVisibility
		{
			get
			{
				short num = (short)1321336832;
				short num2 = num;
				num = (short)355382836;
				short num3 = num;
				num = (short)732083764;
				switch (num3 == num)
				{
				}
				num = (short)1790836737;
				if (num != 0)
				{
				}
				num = (short)1275199488;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty);
			}
			set
			{
				short num = (short)1461649408;
				short num2 = num;
				num = (short)1214911500;
				short num3 = num;
				num = (short)136320012;
				switch (num3 == num)
				{
				}
				num = (short)2014445569;
				if (num != 0)
				{
				}
				num = (short)580452352;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty, value);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x000AD808 File Offset: 0x000ABA08
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x000AD8C4 File Offset: 0x000ABAC4
		public bool UpButtonIsAcpValid
		{
			get
			{
				short num = (short)1747648512;
				short num2 = num;
				num = (short)1012269057;
				if (num != 0)
				{
				}
				num = (short)1260461009;
				short num3 = num;
				num = (short)907090897;
				switch (num3 == num)
				{
				}
				num = (short)944963584;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.UpButtonIsAcpValidProperty);
			}
			set
			{
				short num = (short)160497664;
				short num2 = num;
				num = (short)111848524;
				short num3 = num;
				num = (short)1263447116;
				switch (num3 == num)
				{
				}
				num = (short)1592852481;
				if (num != 0)
				{
				}
				num = (short)1304231936;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.UpButtonIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x000AD980 File Offset: 0x000ABB80
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x000ADA38 File Offset: 0x000ABC38
		public bool UpButtonIsAcpApplicable
		{
			get
			{
				short num = (short)595656704;
				short num2 = num;
				num = (short)991143358;
				short num3 = num;
				num = (short)907453886;
				switch (num3 == num)
				{
				}
				num = (short)1860042752;
				if (num != 0)
				{
				}
				num = (short)634650625;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.UpButtonIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1015939072;
				short num2 = num;
				num = (short)1656851543;
				short num3 = num;
				num = (short)1222741079;
				switch (num3 == num)
				{
				}
				num = (short)1320419328;
				if (num != 0)
				{
				}
				num = (short)1705377793;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.UpButtonIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x000ADAF0 File Offset: 0x000ABCF0
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x000ADBAC File Offset: 0x000ABDAC
		public bool UpButtonIsAcpVisible
		{
			get
			{
				short num = (short)1527840768;
				short num2 = num;
				num = (short)659457014;
				short num3 = num;
				num = (short)2044953590;
				switch (num3 == num)
				{
				}
				num = (short)160104449;
				if (num != 0)
				{
				}
				num = (short)984416256;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.UpButtonIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)523304960;
				short num2 = num;
				num = (short)856616556;
				short num3 = num;
				num = (short)357166700;
				switch (num3 == num)
				{
				}
				num = (short)2093940736;
				if (num != 0)
				{
				}
				num = (short)252116993;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.UpButtonIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x000ADC68 File Offset: 0x000ABE68
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x000ADD20 File Offset: 0x000ABF20
		public bool UpButtonIsAcpEditable
		{
			get
			{
				short num = (short)617152512;
				short num2 = num;
				num = (short)1749835919;
				short num3 = num;
				num = (short)1785356431;
				switch (num3 == num)
				{
				}
				num = (short)1470824448;
				if (num != 0)
				{
				}
				num = (short)1655701505;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.UpButtonIsAcpEditableProperty);
			}
			set
			{
				short num = (short)988020736;
				short num2 = num;
				num = (short)394657793;
				if (num != 0)
				{
				}
				num = (short)439593934;
				short num3 = num;
				num = (short)1947446222;
				switch (num3 == num)
				{
				}
				num = (short)805502976;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.UpButtonIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x000ADDDC File Offset: 0x000ABFDC
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x000ADE98 File Offset: 0x000AC098
		public string UpButtonUIValue
		{
			get
			{
				short num = (short)387186688;
				short num2 = num;
				num = (short)1489850769;
				short num3 = num;
				num = (short)421286289;
				switch (num3 == num)
				{
				}
				num = (short)1904607232;
				if (num != 0)
				{
				}
				num = (short)732692481;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.UpButtonUIValueProperty);
			}
			set
			{
				short num = (short)1572143104;
				short num2 = num;
				num = (short)588323659;
				short num3 = num;
				num = (short)551885643;
				switch (num3 == num)
				{
				}
				num = (short)2075590657;
				if (num != 0)
				{
				}
				num = (short)929169408;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.UpButtonUIValueProperty, value);
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x000ADF4C File Offset: 0x000AC14C
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x000AE008 File Offset: 0x000AC208
		public AcpListField UpButtonList
		{
			get
			{
				short num = (short)1555890176;
				short num2 = num;
				num = (short)1205418883;
				short num3 = num;
				num = (short)1715813251;
				switch (num3 == num)
				{
				}
				num = (short)1422327809;
				if (num != 0)
				{
				}
				num = (short)929693696;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.UpButtonListProperty);
			}
			set
			{
				short num = (short)778108928;
				short num2 = num;
				num = (short)882505489;
				short num3 = num;
				num = (short)1763637009;
				switch (num3 == num)
				{
				}
				num = (short)1506934785;
				if (num != 0)
				{
				}
				num = (short)124846080;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.UpButtonListProperty, value);
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x000AE0C0 File Offset: 0x000AC2C0
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x000AE17C File Offset: 0x000AC37C
		public bool DownButtonIsAcpValid
		{
			get
			{
				short num = (short)48300032;
				short num2 = num;
				num = (short)1204116671;
				short num3 = num;
				num = (short)86006975;
				switch (num3 == num)
				{
				}
				num = (short)2100232193;
				if (num != 0)
				{
				}
				num = (short)1561919488;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DownButtonIsAcpValidProperty);
			}
			set
			{
				short num = (short)1380581376;
				short num2 = num;
				num = (short)671939130;
				short num3 = num;
				num = (short)272300602;
				switch (num3 == num)
				{
				}
				num = (short)1987248129;
				if (num != 0)
				{
				}
				num = (short)946143232;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DownButtonIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x000AE238 File Offset: 0x000AC438
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x000AE2F0 File Offset: 0x000AC4F0
		public bool DownButtonIsAcpApplicable
		{
			get
			{
				short num = (short)103415808;
				short num2 = num;
				num = (short)922350806;
				short num3 = num;
				num = (short)293795030;
				switch (num3 == num)
				{
				}
				num = (short)1767964673;
				if (num != 0)
				{
				}
				num = (short)1076101120;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DownButtonIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1086717952;
				short num2 = num;
				num = (short)1611323186;
				short num3 = num;
				num = (short)702338866;
				switch (num3 == num)
				{
				}
				num = (short)811728897;
				if (num != 0)
				{
				}
				num = (short)795344896;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DownButtonIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x000AE3A8 File Offset: 0x000AC5A8
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x000AE460 File Offset: 0x000AC660
		public bool DownButtonIsAcpVisible
		{
			get
			{
				short num = (short)856293376;
				short num2 = num;
				num = (short)727106920;
				short num3 = num;
				num = (short)2046477672;
				switch (num3 == num)
				{
				}
				num = (short)348061697;
				if (num != 0)
				{
				}
				num = (short)1374420992;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DownButtonIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1597702144;
				short num2 = num;
				num = (short)1623685389;
				short num3 = num;
				num = (short)1766095117;
				switch (num3 == num)
				{
				}
				num = (short)1985478656;
				if (num != 0)
				{
				}
				num = (short)297074689;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DownButtonIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x000AE518 File Offset: 0x000AC718
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x000AE5D0 File Offset: 0x000AC7D0
		public bool DownButtonIsAcpEditable
		{
			get
			{
				short num = (short)1652031488;
				short num2 = num;
				num = (short)1031680961;
				short num3 = num;
				num = (short)518927297;
				switch (num3 == num)
				{
				}
				num = (short)161742849;
				if (num != 0)
				{
				}
				num = (short)519307264;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.DownButtonIsAcpEditableProperty);
			}
			set
			{
				short num = (short)788135936;
				short num2 = num;
				num = (short)464211795;
				short num3 = num;
				num = (short)372723539;
				switch (num3 == num)
				{
				}
				num = (short)647561217;
				if (num != 0)
				{
				}
				num = (short)276234240;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DownButtonIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x000AE688 File Offset: 0x000AC888
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x000AE740 File Offset: 0x000AC940
		public string DownButtonUIValue
		{
			get
			{
				short num = (short)264306688;
				short num2 = num;
				num = (short)321435843;
				short num3 = num;
				num = (short)2087434435;
				switch (num3 == num)
				{
				}
				num = (short)1674379264;
				if (num != 0)
				{
				}
				num = (short)677904385;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.DownButtonUIValueProperty);
			}
			set
			{
				short num = (short)1303838720;
				short num2 = num;
				num = (short)1296529879;
				short num3 = num;
				num = (short)1549629911;
				switch (num3 == num)
				{
				}
				num = (short)1613692929;
				if (num != 0)
				{
				}
				num = (short)1051983872;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DownButtonUIValueProperty, value);
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x000AE7F8 File Offset: 0x000AC9F8
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x000AE8B0 File Offset: 0x000ACAB0
		public AcpListField DownButtonList
		{
			get
			{
				short num = (short)1434583040;
				short num2 = num;
				num = (short)602406913;
				if (num != 0)
				{
				}
				num = (short)92539554;
				short num3 = num;
				num = (short)1985546914;
				switch (num3 == num)
				{
				}
				num = (short)277610496;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.DownButtonListProperty);
			}
			set
			{
				short num = (short)159449088;
				short num2 = num;
				num = (short)388774436;
				short num3 = num;
				num = (short)1318205988;
				switch (num3 == num)
				{
				}
				num = (short)1250295808;
				if (num != 0)
				{
				}
				num = (short)992477185;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.DownButtonListProperty, value);
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x000AE964 File Offset: 0x000ACB64
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x000AEA1C File Offset: 0x000ACC1C
		public bool AirhornButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)907149312;
				short num2 = num;
				num = (short)1144834827;
				short num3 = num;
				num = (short)507104011;
				switch (num3 == num)
				{
				}
				num = (short)990773249;
				if (num != 0)
				{
				}
				num = (short)817299456;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.AirhornButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)2119434240;
				short num2 = num;
				num = (short)1947677017;
				short num3 = num;
				num = (short)1622815065;
				switch (num3 == num)
				{
				}
				num = (short)580780032;
				if (num != 0)
				{
				}
				num = (short)47120385;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.AirhornButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x000AEAD8 File Offset: 0x000ACCD8
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x000AEB90 File Offset: 0x000ACD90
		public bool AirhornButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1968832512;
				short num2 = num;
				num = (short)1152696923;
				short num3 = num;
				num = (short)2046280283;
				switch (num3 == num)
				{
				}
				num = (short)1258160128;
				if (num != 0)
				{
				}
				num = (short)898367489;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.AirhornButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1273888768;
				short num2 = num;
				num = (short)146454024;
				short num3 = num;
				num = (short)241612296;
				switch (num3 == num)
				{
				}
				num = (short)421593089;
				if (num != 0)
				{
				}
				num = (short)359596032;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.AirhornButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x000AEC48 File Offset: 0x000ACE48
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x000AED00 File Offset: 0x000ACF00
		public bool AirhornButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1450180608;
				short num2 = num;
				num = (short)1772413143;
				short num3 = num;
				num = (short)1626398935;
				switch (num3 == num)
				{
				}
				num = (short)1129250817;
				if (num != 0)
				{
				}
				num = (short)798883840;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.AirhornButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2056388608;
				short num2 = num;
				num = (short)1733549284;
				short num3 = num;
				num = (short)1072618724;
				switch (num3 == num)
				{
				}
				num = (short)870711297;
				if (num != 0)
				{
				}
				num = (short)384499712;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.AirhornButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x000AEDC0 File Offset: 0x000ACFC0
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x000AEE7C File Offset: 0x000AD07C
		public bool AirhornButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)274399232;
				short num2 = num;
				num = (short)902594565;
				short num3 = num;
				num = (short)1313439749;
				switch (num3 == num)
				{
				}
				num = (short)561577985;
				if (num != 0)
				{
				}
				num = (short)906493952;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.AirhornButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)494534656;
				short num2 = num;
				num = (short)1327706619;
				short num3 = num;
				num = (short)545010171;
				switch (num3 == num)
				{
				}
				num = (short)1251606528;
				if (num != 0)
				{
				}
				num = (short)464060417;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.AirhornButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x000AEF38 File Offset: 0x000AD138
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x000AEFF4 File Offset: 0x000AD1F4
		public string AirhornButtonFeatureUIValue
		{
			get
			{
				short num = (short)1810300928;
				short num2 = num;
				num = (short)1114642833;
				short num3 = num;
				num = (short)2120554897;
				switch (num3 == num)
				{
				}
				num = (short)1568145408;
				if (num != 0)
				{
				}
				num = (short)696188929;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.AirhornButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)756678656;
				short num2 = num;
				num = (short)869526901;
				short num3 = num;
				num = (short)1909976437;
				switch (num3 == num)
				{
				}
				num = (short)784793601;
				if (num != 0)
				{
				}
				num = (short)1550581760;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.AirhornButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x000AF0AC File Offset: 0x000AD2AC
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x000AF164 File Offset: 0x000AD364
		public AcpListField AirhornButtonFeatureList
		{
			get
			{
				short num = (short)433389568;
				short num2 = num;
				num = (short)1065991287;
				short num3 = num;
				num = (short)1574091895;
				switch (num3 == num)
				{
				}
				num = (short)214433793;
				if (num != 0)
				{
				}
				num = (short)1021050880;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.AirhornButtonFeatureListProperty);
			}
			set
			{
				short num = (short)757858304;
				short num2 = num;
				num = (short)968704143;
				short num3 = num;
				num = (short)1386889359;
				switch (num3 == num)
				{
				}
				num = (short)374079488;
				if (num != 0)
				{
				}
				num = (short)1507786753;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.AirhornButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x000AF21C File Offset: 0x000AD41C
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x000AF2D8 File Offset: 0x000AD4D8
		public bool ManualButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)809762816;
				short num2 = num;
				num = (short)1460303009;
				short num3 = num;
				num = (short)1395094689;
				switch (num3 == num)
				{
				}
				num = (short)2145910784;
				if (num != 0)
				{
				}
				num = (short)519569409;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.ManualButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1658667672;
				short num2 = num;
				num = (short)2063155864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)549453824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262406145;
				if (num != 0)
				{
				}
				num = (short)1148583936;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.ManualButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x000AF394 File Offset: 0x000AD594
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x000AF44C File Offset: 0x000AD64C
		public bool ManualButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1941067773;
				short num2 = num;
				num = (short)1678268413;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2015559680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)37879809;
				if (num != 0)
				{
				}
				num = (short)94765056;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.ManualButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)351406097;
				short num2 = num;
				num = (short)2010253329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)291831808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2014838784;
				if (num != 0)
				{
				}
				num = (short)1984561153;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.ManualButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x000AF508 File Offset: 0x000AD708
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x000AF5C0 File Offset: 0x000AD7C0
		public bool ManualButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)481820673;
				if (num != 0)
				{
				}
				num = (short)768475136;
				short num2 = num;
				num = (short)2124494483;
				short num3 = num;
				num = (short)1190737555;
				switch (num3 == num)
				{
				}
				num = (short)1182007296;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.ManualButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)992011850;
				short num2 = num;
				num = (short)1718085194;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2025586688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1390739457;
				if (num != 0)
				{
				}
				num = (short)863502336;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.ManualButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x000AF678 File Offset: 0x000AD878
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x000AF730 File Offset: 0x000AD930
		public bool ManualButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)590689646;
				short num2 = num;
				num = (short)688862574;
				switch (num2 == num)
				{
				default:
				{
					num = (short)837877760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)434634753;
				if (num != 0)
				{
				}
				num = (short)872742912;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.ManualButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)445186049;
				if (num != 0)
				{
				}
				num = (short)465698816;
				short num2 = num;
				num = (short)494730365;
				short num3 = num;
				num = (short)979041405;
				switch (num3 == num)
				{
				}
				num = (short)588775424;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.ManualButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x000AF7EC File Offset: 0x000AD9EC
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x000AF8A4 File Offset: 0x000ADAA4
		public string ManualButtonFeatureUIValue
		{
			get
			{
				short num = (short)616309312;
				short num2 = num;
				num = (short)1933320768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)533266432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1755840513;
				if (num != 0)
				{
				}
				num = (short)987299840;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.ManualButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1907658016;
				short num2 = num;
				num = (short)646221088;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2090860544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)626327553;
				if (num != 0)
				{
				}
				num = (short)988020736;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.ManualButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x000AF95C File Offset: 0x000ADB5C
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x000AFA18 File Offset: 0x000ADC18
		public AcpListField ManualButtonFeatureList
		{
			get
			{
				short num = (short)1328087041;
				if (num != 0)
				{
				}
				num = (short)1151401984;
				short num2 = num;
				num = (short)1101078667;
				short num3 = num;
				num = (short)1494229131;
				switch (num3 == num)
				{
				}
				num = (short)1295908864;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.ManualButtonFeatureListProperty);
			}
			set
			{
				short num = (short)164767663;
				short num2 = num;
				num = (short)1062217647;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1706360832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1382416385;
				if (num != 0)
				{
				}
				num = (short)2008416256;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.ManualButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x000AFAD0 File Offset: 0x000ADCD0
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x000AFB8C File Offset: 0x000ADD8C
		public bool WailButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)918710126;
				short num2 = num;
				num = (short)1479239534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1306853376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)302186496;
				if (num != 0)
				{
				}
				num = (short)1378942977;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.WailButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1849163777;
				if (num != 0)
				{
				}
				num = (short)1176567808;
				short num2 = num;
				num = (short)1622731264;
				short num3 = num;
				num = (short)670362112;
				switch (num3 == num)
				{
				}
				num = (short)646774784;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.WailButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x000AFC44 File Offset: 0x000ADE44
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x000AFD00 File Offset: 0x000ADF00
		public bool WailButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1732753757;
				short num2 = num;
				num = (short)1334425949;
				switch (num2 == num)
				{
				default:
				{
					num = (short)716177408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1252261889;
				if (num != 0)
				{
				}
				num = (short)635830272;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.WailButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)63966699;
				short num2 = num;
				num = (short)996871659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1925644288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1539899393;
				if (num != 0)
				{
				}
				num = (short)48758784;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.WailButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x000AFDBC File Offset: 0x000ADFBC
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x000AFE78 File Offset: 0x000AE078
		public bool WailButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)276701698;
				short num2 = num;
				num = (short)881861122;
				switch (num2 == num)
				{
				default:
				{
					num = (short)364118016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)625016832;
				if (num != 0)
				{
				}
				num = (short)1287847937;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.WailButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1707697888;
				short num2 = num;
				num = (short)953837280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1078525952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1205010432;
				if (num != 0)
				{
				}
				num = (short)1845428225;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.WailButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x000AFF34 File Offset: 0x000AE134
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x000AFFF0 File Offset: 0x000AE1F0
		public bool WailButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1361337161;
				short num2 = num;
				num = (short)2043894601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)178257920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)648609792;
				if (num != 0)
				{
				}
				num = (short)1032192001;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.WailButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1828626937;
				short num2 = num;
				num = (short)819175929;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954466304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1962737664;
				if (num != 0)
				{
				}
				num = (short)247857153;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.WailButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x000B00AC File Offset: 0x000AE2AC
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x000B0164 File Offset: 0x000AE364
		public string WailButtonFeatureUIValue
		{
			get
			{
				short num = (short)895156225;
				if (num != 0)
				{
				}
				num = (short)523304960;
				short num2 = num;
				num = (short)214737321;
				short num3 = num;
				num = (short)348103081;
				switch (num3 == num)
				{
				}
				num = (short)155844608;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.WailButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1906573313;
				if (num != 0)
				{
				}
				num = (short)649461760;
				short num2 = num;
				num = (short)844196762;
				short num3 = num;
				num = (short)350645146;
				switch (num3 == num)
				{
				}
				num = (short)1685258240;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.WailButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x000B021C File Offset: 0x000AE41C
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x000B02D4 File Offset: 0x000AE4D4
		public AcpListField WailButtonFeatureList
		{
			get
			{
				short num = (short)6209867;
				short num2 = num;
				num = (short)589545803;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1938882560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)67436545;
				if (num != 0)
				{
				}
				num = (short)1795162112;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.WailButtonFeatureListProperty);
			}
			set
			{
				short num = (short)1601786524;
				short num2 = num;
				num = (short)168120988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1536884736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1891893249;
				if (num != 0)
				{
				}
				num = (short)1968439296;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.WailButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x000B0388 File Offset: 0x000AE588
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x000B0440 File Offset: 0x000AE640
		public bool YelpButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)1392258065;
				short num2 = num;
				num = (short)1510681617;
				switch (num2 == num)
				{
				default:
				{
					num = (short)680656896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1209270272;
				if (num != 0)
				{
				}
				num = (short)392495105;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.YelpButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)2040834695;
				short num2 = num;
				num = (short)437103239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)463929344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)397082625;
				if (num != 0)
				{
				}
				num = (short)1287913472;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.YelpButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x000B04FC File Offset: 0x000AE6FC
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x000B05B8 File Offset: 0x000AE7B8
		public bool YelpButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1341770486;
				short num2 = num;
				num = (short)853134070;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1607925760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1548550145;
				if (num != 0)
				{
				}
				num = (short)796852224;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.YelpButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)690123949;
				short num2 = num;
				num = (short)1814066349;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1060306944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)183959553;
				if (num != 0)
				{
				}
				num = (short)1330839552;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.YelpButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x000B0670 File Offset: 0x000AE870
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x000B072C File Offset: 0x000AE92C
		public bool YelpButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1715011585;
				if (num != 0)
				{
				}
				num = (short)605618176;
				short num2 = num;
				num = (short)1546754886;
				short num3 = num;
				num = (short)828808006;
				switch (num3 == num)
				{
				}
				num = (short)1406074880;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.YelpButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)523897223;
				short num2 = num;
				num = (short)1367476615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1432551424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1403781121;
				if (num != 0)
				{
				}
				num = (short)834666496;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.YelpButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x000B07E8 File Offset: 0x000AE9E8
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x000B08A0 File Offset: 0x000AEAA0
		public bool YelpButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)2085674367;
				short num2 = num;
				num = (short)282844543;
				switch (num2 == num)
				{
				default:
				{
					num = (short)624427008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)42401792;
				if (num != 0)
				{
				}
				num = (short)301989889;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.YelpButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1257832449;
				if (num != 0)
				{
				}
				num = (short)1325662208;
				short num2 = num;
				num = (short)1715171145;
				short num3 = num;
				num = (short)733900617;
				switch (num3 == num)
				{
				}
				num = (short)289275904;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.YelpButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x000B0958 File Offset: 0x000AEB58
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x000B0A10 File Offset: 0x000AEC10
		public string YelpButtonFeatureUIValue
		{
			get
			{
				short num = (short)1270218753;
				if (num != 0)
				{
				}
				num = (short)251592704;
				short num2 = num;
				num = (short)1577795011;
				short num3 = num;
				num = (short)882326979;
				switch (num3 == num)
				{
				}
				num = (short)112066560;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.YelpButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1735701575;
				short num2 = num;
				num = (short)137999431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2063925248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1312751617;
				if (num != 0)
				{
				}
				num = (short)910229504;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.YelpButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x000B0AC8 File Offset: 0x000AECC8
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x000B0B80 File Offset: 0x000AED80
		public AcpListField YelpButtonFeatureList
		{
			get
			{
				short num = (short)1834902160;
				short num2 = num;
				num = (short)1948017296;
				switch (num2 == num)
				{
				default:
				{
					num = (short)58195968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1620901888;
				if (num != 0)
				{
				}
				num = (short)649658369;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.YelpButtonFeatureListProperty);
			}
			set
			{
				short num = (short)2077197007;
				short num2 = num;
				num = (short)1647870671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)307560448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)297926657;
				if (num != 0)
				{
				}
				num = (short)1401028608;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.YelpButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x000B0C34 File Offset: 0x000AEE34
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x000B0CEC File Offset: 0x000AEEEC
		public bool HiloButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)1668292879;
				short num2 = num;
				num = (short)1727406351;
				switch (num2 == num)
				{
				default:
				{
					num = (short)671809536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1180958721;
				if (num != 0)
				{
				}
				num = (short)1649606656;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.HiloButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)914369455;
				short num2 = num;
				num = (short)611593135;
				switch (num2 == num)
				{
				default:
				{
					num = (short)720371712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1015414784;
				if (num != 0)
				{
				}
				num = (short)1503395841;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.HiloButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x000B0DAC File Offset: 0x000AEFAC
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x000B0E64 File Offset: 0x000AF064
		public bool HiloButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)917838016;
				short num2 = num;
				num = (short)1290279104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)184156160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)844300289;
				if (num != 0)
				{
				}
				num = (short)1199505408;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.HiloButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1991758457;
				short num2 = num;
				num = (short)906416761;
				switch (num2 == num)
				{
				default:
				{
					num = (short)843776000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1307181057;
				if (num != 0)
				{
				}
				num = (short)601948160;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.HiloButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x000B0F20 File Offset: 0x000AF120
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x000B0FD8 File Offset: 0x000AF1D8
		public bool HiloButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1230390377;
				short num2 = num;
				num = (short)1179272297;
				switch (num2 == num)
				{
				default:
				{
					num = (short)732889088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1700921345;
				if (num != 0)
				{
				}
				num = (short)116260864;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.HiloButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1149570597;
				short num2 = num;
				num = (short)1496321573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1558773760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)32636928;
				if (num != 0)
				{
				}
				num = (short)1205665793;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.HiloButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x000B1094 File Offset: 0x000AF294
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x000B114C File Offset: 0x000AF34C
		public bool HiloButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)150667265;
				if (num != 0)
				{
				}
				num = (short)185925632;
				short num2 = num;
				num = (short)221386723;
				short num3 = num;
				num = (short)2090538979;
				switch (num3 == num)
				{
				}
				num = (short)534773760;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.HiloButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)700841985;
				if (num != 0)
				{
				}
				num = (short)1449328640;
				short num2 = num;
				num = (short)2002009579;
				short num3 = num;
				num = (short)540818923;
				switch (num3 == num)
				{
				}
				num = (short)53018624;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.HiloButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x000B1204 File Offset: 0x000AF404
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x000B12C0 File Offset: 0x000AF4C0
		public string HiloButtonFeatureUIValue
		{
			get
			{
				short num = (short)745214157;
				short num2 = num;
				num = (short)1816072397;
				switch (num2 == num)
				{
				default:
				{
					num = (short)436862976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1512964096;
				if (num != 0)
				{
				}
				num = (short)832176129;
				if (num != 0)
				{
				}
				return (string)base.GetValue(O9GraphicView.HiloButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1349032619;
				short num2 = num;
				num = (short)1234934443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1738276864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1316487169;
				if (num != 0)
				{
				}
				num = (short)1899495424;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.HiloButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x000B1378 File Offset: 0x000AF578
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x000B1430 File Offset: 0x000AF630
		public AcpListField HiloButtonFeatureList
		{
			get
			{
				short num = (short)580079258;
				short num2 = num;
				num = (short)395660954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)995557376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1940193281;
				if (num != 0)
				{
				}
				num = (short)846725120;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(O9GraphicView.HiloButtonFeatureListProperty);
			}
			set
			{
				short num = (short)1362294486;
				short num2 = num;
				num = (short)1129445078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2083520512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1920073729;
				if (num != 0)
				{
				}
				num = (short)110297088;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.HiloButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x000B14EC File Offset: 0x000AF6EC
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x000B15A8 File Offset: 0x000AF7A8
		public bool PAButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)1658921862;
				short num2 = num;
				num = (short)2054562694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)925499392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)166002688;
				if (num != 0)
				{
				}
				num = (short)1352073217;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PAButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)264532505;
				short num2 = num;
				num = (short)492270105;
				switch (num2 == num)
				{
				default:
				{
					num = (short)963903488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1542586368;
				if (num != 0)
				{
				}
				num = (short)1201995777;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PAButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000B1664 File Offset: 0x000AF864
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x000B1720 File Offset: 0x000AF920
		public bool PAButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)580194297;
				short num2 = num;
				num = (short)311103481;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1306656768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)208601088;
				if (num != 0)
				{
				}
				num = (short)1778450433;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(O9GraphicView.PAButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)88257201;
				short num2 = num;
				num = (short)1147777713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)469434368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1176436736;
				if (num != 0)
				{
				}
				num = (short)1178533889;
				if (num != 0)
				{
				}
				base.SetValue(O9GraphicView.PAButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x000B17D8 File Offset: 0x000AF9D8
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x000B1894 File Offset: 0x000AFA94
		public bool PAButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1351782956;
				short num2 = num;
				num = (short)17535532;
				switch (num2 == num)
				{
				}
				num = (short)616955904;
				if (num != 0)
				{
				}
				num = (short)79036417;
				if (num != 0)
				{
				}
				num = (short)1987248128;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.PAButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)969939581;
				short num2 = num;
				num = (short)631708285;
				switch (num2 == num)
				{
				}
				num = (short)1241186305;
				if (num != 0)
				{
				}
				num = (short)801701888;
				if (num != 0)
				{
				}
				num = (short)591003648;
				short num3 = num;
				base.SetValue(O9GraphicView.PAButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000B1950 File Offset: 0x000AFB50
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x000B1A08 File Offset: 0x000AFC08
		public bool PAButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)848469733;
				short num2 = num;
				num = (short)1271045861;
				switch (num2 == num)
				{
				}
				num = (short)1855455232;
				if (num != 0)
				{
				}
				num = (short)621412353;
				if (num != 0)
				{
				}
				num = (short)1401356288;
				short num3 = num;
				return (bool)base.GetValue(O9GraphicView.PAButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1343490311;
				short num2 = num;
				num = (short)2117273863;
				switch (num2 == num)
				{
				}
				num = (short)724303872;
				if (num != 0)
				{
				}
				num = (short)1074528257;
				if (num != 0)
				{
				}
				num = (short)1574764544;
				short num3 = num;
				base.SetValue(O9GraphicView.PAButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x000B1AC4 File Offset: 0x000AFCC4
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x000B1B7C File Offset: 0x000AFD7C
		public string PAButtonFeatureUIValue
		{
			get
			{
				short num = (short)1634304332;
				short num2 = num;
				num = (short)1003782476;
				switch (num2 == num)
				{
				}
				num = (short)1059127296;
				if (num != 0)
				{
				}
				num = (short)1336672257;
				if (num != 0)
				{
				}
				num = (short)547487744;
				short num3 = num;
				return (string)base.GetValue(O9GraphicView.PAButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)677512544;
				short num2 = num;
				num = (short)933168480;
				switch (num2 == num)
				{
				}
				num = (short)1707868160;
				if (num != 0)
				{
				}
				num = (short)1426128897;
				if (num != 0)
				{
				}
				num = (short)1275920384;
				short num3 = num;
				base.SetValue(O9GraphicView.PAButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x000B1C34 File Offset: 0x000AFE34
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x000B1CF0 File Offset: 0x000AFEF0
		public AcpListField PAButtonFeatureList
		{
			get
			{
				short num = (short)894360575;
				short num2 = num;
				num = (short)593681407;
				switch (num2 == num)
				{
				}
				num = (short)1159790592;
				if (num != 0)
				{
				}
				num = (short)2146500609;
				if (num != 0)
				{
				}
				num = (short)1472856064;
				short num3 = num;
				return (AcpListField)base.GetValue(O9GraphicView.PAButtonFeatureListProperty);
			}
			set
			{
				short num = (short)847547404;
				short num2 = num;
				num = (short)703695884;
				switch (num2 == num)
				{
				}
				num = (short)1658650625;
				if (num != 0)
				{
				}
				num = (short)862650368;
				if (num != 0)
				{
				}
				num = (short)620363776;
				short num3 = num;
				base.SetValue(O9GraphicView.PAButtonFeatureListProperty, value);
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000B63B8 File Offset: 0x000B45B8
		// Note: this type is marked as 'beforefieldinit'.
		static O9GraphicView()
		{
			int a_ = 6;
			short num = (short)1911554048;
			short num2 = num;
			num = (short)262733825;
			if (num != 0)
			{
			}
			num = (short)731191480;
			short num3 = num;
			num = (short)1450645688;
			switch (num3 == num)
			{
			}
			num = (short)1120141312;
			if (num != 0)
			{
			}
			O9GraphicView.BottomButton1FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆硈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton1FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆硈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton1FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆硈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton1FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆硈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton1FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆硈ൊ⡌⹎═♒❔㉖ౘቚଡ଼㹞ൠᙢd", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.BottomButton1FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆硈ൊ⡌⹎═♒❔㉖ᕘ㉚⹜⭞", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.BottomButton1IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆硈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़`ར౤ͦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton1IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆硈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜṞᅠ።।๦੨੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton1IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆硈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़ࡠၢ౤զը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton1IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆硈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜᩞՠ੢ᅤ٦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton1IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆硈Ɋ⍌⭎㑐⭒TṖམ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			O9GraphicView.BottomButton1IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆硈Ɋ⍌⭎㑐⭒ᥔ㹖⩘⽚", a_), typeof(AcpRecRefField), typeof(O9GraphicView), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			O9GraphicView.BottomButton2FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆筈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton2FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆筈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton2FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆筈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton2FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆筈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton2FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆筈ൊ⡌⹎═♒❔㉖ౘቚଡ଼㹞ൠᙢd", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.BottomButton2FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆筈ൊ⡌⹎═♒❔㉖ᕘ㉚⹜⭞", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.BottomButton2IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆筈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़`ར౤ͦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton2IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆筈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜṞᅠ።।๦੨੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton2IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆筈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़ࡠၢ౤զը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton2IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆筈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜᩞՠ੢ᅤ٦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton2IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆筈Ɋ⍌⭎㑐⭒TṖམ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.BottomButton2IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆筈Ɋ⍌⭎㑐⭒ᥔ㹖⩘⽚", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.BottomButton3FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆穈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton3FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆穈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton3FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆穈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton3FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆穈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton3FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆穈ൊ⡌⹎═♒❔㉖ౘቚଡ଼㹞ൠᙢd", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.BottomButton3FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆穈ൊ⡌⹎═♒❔㉖ᕘ㉚⹜⭞", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.BottomButton3IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆穈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़`ར౤ͦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton3IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆穈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜṞᅠ።।๦੨੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton3IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆穈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़ࡠၢ౤զը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton3IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆穈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜᩞՠ੢ᅤ٦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton3IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆穈Ɋ⍌⭎㑐⭒TṖམ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.BottomButton3IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆穈Ɋ⍌⭎㑐⭒ᥔ㹖⩘⽚", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.BottomButton4FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆絈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton4FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆絈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton4FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆絈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton4FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆絈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton4FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆絈ൊ⡌⹎═♒❔㉖ౘቚଡ଼㹞ൠᙢd", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.BottomButton4FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆絈ൊ⡌⹎═♒❔㉖ᕘ㉚⹜⭞", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.BottomButton4IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆絈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़`ར౤ͦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton4IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆絈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜṞᅠ።।๦੨੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton4IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆絈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़ࡠၢ౤զը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton4IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆絈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜᩞՠ੢ᅤ٦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton4IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆絈Ɋ⍌⭎㑐⭒TṖམ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.BottomButton4IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆絈Ɋ⍌⭎㑐⭒ᥔ㹖⩘⽚", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.BottomButton5FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆籈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton5FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆籈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton5FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆籈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton5FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆籈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton5FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆籈ൊ⡌⹎═♒❔㉖ౘቚଡ଼㹞ൠᙢd", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.BottomButton5FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆籈ൊ⡌⹎═♒❔㉖ᕘ㉚⹜⭞", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.BottomButton5IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆籈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़`ར౤ͦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton5IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆籈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜṞᅠ።।๦੨੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton5IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆籈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़ࡠၢ౤զը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton5IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆籈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜᩞՠ੢ᅤ٦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.BottomButton5IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆籈Ɋ⍌⭎㑐⭒TṖམ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.BottomButton5IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("猰尲䄴䌶嘸嘺缼䨾㕀㝂⩄⥆籈Ɋ⍌⭎㑐⭒ᥔ㹖⩘⽚", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton1LabelLine1ValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ॄ♆⭈⹊⅌͎㡐㵒ご晖མ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton1LabelLine1IsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1LabelLine1IsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1LabelLine1IsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1LabelLine1IsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1LabelLine1TextProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ॄ♆⭈⹊⅌͎㡐㵒ご晖൘㹚╜⭞", a_), typeof(AcpTextBox), typeof(O9GraphicView));
			O9GraphicView.TopButton1LabelLine2ValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ॄ♆⭈⹊⅌͎㡐㵒ご敖མ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton1LabelLine2IsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1LabelLine2IsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1LabelLine2IsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1LabelLine2IsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1LabelLine2TextProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ॄ♆⭈⹊⅌͎㡐㵒ご敖൘㹚╜⭞", a_), typeof(AcpTextBox), typeof(O9GraphicView));
			O9GraphicView.TopButton2LabelLine1ValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ॄ♆⭈⹊⅌͎㡐㵒ご晖མ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton2LabelLine1IsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2LabelLine1IsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2LabelLine1IsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2LabelLine1IsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2LabelLine1TextProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ॄ♆⭈⹊⅌͎㡐㵒ご晖൘㹚╜⭞", a_), typeof(AcpTextBox), typeof(O9GraphicView));
			O9GraphicView.TopButton2LabelLine2ValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ॄ♆⭈⹊⅌͎㡐㵒ご敖མ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton2LabelLine2IsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2LabelLine2IsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2LabelLine2IsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2LabelLine2IsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2LabelLine2TextProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ॄ♆⭈⹊⅌͎㡐㵒ご敖൘㹚╜⭞", a_), typeof(AcpTextBox), typeof(O9GraphicView));
			O9GraphicView.TopButton3LabelLine1ValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ॄ♆⭈⹊⅌͎㡐㵒ご晖མ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton3LabelLine1IsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3LabelLine1IsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3LabelLine1IsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3LabelLine1IsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3LabelLine1TextProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ॄ♆⭈⹊⅌͎㡐㵒ご晖൘㹚╜⭞", a_), typeof(AcpTextBox), typeof(O9GraphicView));
			O9GraphicView.TopButton3LabelLine2ValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ॄ♆⭈⹊⅌͎㡐㵒ご敖མ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton3LabelLine2IsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3LabelLine2IsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3LabelLine2IsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3LabelLine2IsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3LabelLine2TextProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ॄ♆⭈⹊⅌͎㡐㵒ご敖൘㹚╜⭞", a_), typeof(AcpTextBox), typeof(O9GraphicView));
			O9GraphicView.TopButton4LabelLine1ValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ॄ♆⭈⹊⅌͎㡐㵒ご晖མ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton4LabelLine1IsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4LabelLine1IsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4LabelLine1IsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4LabelLine1IsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4LabelLine1TextProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ॄ♆⭈⹊⅌͎㡐㵒ご晖൘㹚╜⭞", a_), typeof(AcpTextBox), typeof(O9GraphicView));
			O9GraphicView.TopButton4LabelLine2ValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ॄ♆⭈⹊⅌͎㡐㵒ご敖མ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton4LabelLine2IsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4LabelLine2IsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4LabelLine2IsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4LabelLine2IsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4LabelLine2TextProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ॄ♆⭈⹊⅌͎㡐㵒ご敖൘㹚╜⭞", a_), typeof(AcpTextBox), typeof(O9GraphicView));
			O9GraphicView.TopButton5LabelLine1ValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ॄ♆⭈⹊⅌͎㡐㵒ご晖མ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton5LabelLine1IsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5LabelLine1IsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5LabelLine1IsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5LabelLine1IsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ॄ♆⭈⹊⅌͎㡐㵒ご晖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5LabelLine1TextProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ॄ♆⭈⹊⅌͎㡐㵒ご晖൘㹚╜⭞", a_), typeof(AcpTextBox), typeof(O9GraphicView));
			O9GraphicView.TopButton5LabelLine2ValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ॄ♆⭈⹊⅌͎㡐㵒ご敖མ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton5LabelLine2IsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5LabelLine2IsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5LabelLine2IsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5LabelLine2IsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ॄ♆⭈⹊⅌͎㡐㵒ご敖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5LabelLine2TextProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ॄ♆⭈⹊⅌͎㡐㵒ご敖൘㹚╜⭞", a_), typeof(AcpTextBox), typeof(O9GraphicView));
			O9GraphicView.TopButton1FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton1FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton1IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton1IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ౄ⥆ⵈ⹊㕌͎㡐⁒⅔", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton2FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton2FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton2IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton2IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ౄ⥆ⵈ⹊㕌͎㡐⁒⅔", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton3FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton3FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton3IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton3IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ౄ⥆ⵈ⹊㕌͎㡐⁒⅔", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton4FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton4FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton4IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton4IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ౄ⥆ⵈ⹊㕌͎㡐⁒⅔", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton5FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton5FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton5IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton5IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ౄ⥆ⵈ⹊㕌͎㡐⁒⅔", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton1StsMsgIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።㍤٦ըɪ६", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1StsMsgIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።⑤ᝦᥨݪѬ౮ၰᅲᥴቶ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1StsMsgIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።㍤๦ᩨɪཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1StsMsgIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።⁤ͦhὪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1StsMsgIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘๚ᑜफ़`རၤɦ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton1StsMsgIndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ग़㱜ㅞ٠٢", a_), typeof(AcpRangeField<int, string>), typeof(O9GraphicView));
			O9GraphicView.TopButton2StsMsgIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።㍤٦ըɪ६", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2StsMsgIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።⑤ᝦᥨݪѬ౮ၰᅲᥴቶ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2StsMsgIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።㍤๦ᩨɪཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2StsMsgIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።⁤ͦhὪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2StsMsgIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘๚ᑜफ़`རၤɦ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton2StsMsgIndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ग़㱜ㅞ٠٢", a_), typeof(AcpRangeField<int, string>), typeof(O9GraphicView));
			O9GraphicView.TopButton3StsMsgIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።㍤٦ըɪ६", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3StsMsgIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።⑤ᝦᥨݪѬ౮ၰᅲᥴቶ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3StsMsgIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።㍤๦ᩨɪཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3StsMsgIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።⁤ͦhὪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3StsMsgIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘๚ᑜफ़`རၤɦ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton3StsMsgIndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ग़㱜ㅞ٠٢", a_), typeof(AcpRangeField<int, string>), typeof(O9GraphicView));
			O9GraphicView.TopButton4StsMsgIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።㍤٦ըɪ६", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4StsMsgIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።⑤ᝦᥨݪѬ౮ၰᅲᥴቶ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4StsMsgIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።㍤๦ᩨɪཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4StsMsgIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።⁤ͦhὪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4StsMsgIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘๚ᑜफ़`རၤɦ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton4StsMsgIndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ग़㱜ㅞ٠٢", a_), typeof(AcpRangeField<int, string>), typeof(O9GraphicView));
			O9GraphicView.TopButton5StsMsgIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።㍤٦ըɪ६", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5StsMsgIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።⑤ᝦᥨݪѬ౮ၰᅲᥴቶ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5StsMsgIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።㍤๦ᩨɪཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5StsMsgIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ቚ⹜Ṟɠ።⁤ͦhὪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5StsMsgIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘๚ᑜफ़`རၤɦ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton5StsMsgIndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ᙄ㍆㩈ي㹌⡎ᡐ㵒ㅔ㉖⅘ग़㱜ㅞ٠٢", a_), typeof(AcpRangeField<int, string>), typeof(O9GraphicView));
			O9GraphicView.TopButton1ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton1ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton2ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton2ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton3ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton3ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton4ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton4ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton5ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton5ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton1ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton1ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton1ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀牂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton2ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton2ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton2ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀煂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton3ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton3ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton3ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀灂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton4ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton4ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton4ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀睂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.TopButton5ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.TopButton5ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.TopButton5ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("攰尲䔴甶䰸伺䤼倾⽀療ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.LightBarTopIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ᕀⱂ㕄ๆ❈⽊⡌㝎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarTopIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ᕀⱂ㕄ๆ❈⽊⡌㝎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarTopIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ᕀⱂ㕄ๆ❈⽊⡌㝎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarTopIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ᕀⱂ㕄ๆ❈⽊⡌㝎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarTopIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ᕀⱂ㕄ๆ❈⽊⡌㝎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.LightBarTopIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ᕀⱂ㕄ๆ❈⽊⡌㝎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.LightBarLeftIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ീ♂⍄㍆H╊⥌⩎⥐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarLeftIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ീ♂⍄㍆H╊⥌⩎⥐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarLeftIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ീ♂⍄㍆H╊⥌⩎⥐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarLeftIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ീ♂⍄㍆H╊⥌⩎⥐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarLeftIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ീ♂⍄㍆H╊⥌⩎⥐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.LightBarLeftIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ീ♂⍄㍆H╊⥌⩎⥐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.LightBarRightIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ፀ⩂≄⽆㵈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़`ར౤ͦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarRightIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ፀ⩂≄⽆㵈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜṞᅠ።।๦੨੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarRightIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ፀ⩂≄⽆㵈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़ࡠၢ౤զը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarRightIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ፀ⩂≄⽆㵈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜᩞՠ੢ᅤ٦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarRightIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ፀ⩂≄⽆㵈Ɋ⍌⭎㑐⭒TṖམ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.LightBarRightIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ፀ⩂≄⽆㵈Ɋ⍌⭎㑐⭒ᥔ㹖⩘⽚", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.LightBarTopActionIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ᕀⱂ㕄ن⩈㽊⑌⁎㽐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarTopActionIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ᕀⱂ㕄ن⩈㽊⑌⁎㽐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarTopActionIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ᕀⱂ㕄ن⩈㽊⑌⁎㽐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarTopActionIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ᕀⱂ㕄ن⩈㽊⑌⁎㽐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarTopActionUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ᕀⱂ㕄ن⩈㽊⑌⁎㽐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.LightBarTopActionListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ᕀⱂ㕄ن⩈㽊⑌⁎㽐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.LightBarLeftActionIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ീ♂⍄㍆ࡈ⡊㥌♎㹐㵒᱔⑖ᡘ㡚ⵜफ़`ར౤ͦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarLeftActionIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ീ♂⍄㍆ࡈ⡊㥌♎㹐㵒᱔⑖ᡘ㡚ⵜṞᅠ።।๦੨੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarLeftActionIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ീ♂⍄㍆ࡈ⡊㥌♎㹐㵒᱔⑖ᡘ㡚ⵜफ़ࡠၢ౤զը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarLeftActionIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ീ♂⍄㍆ࡈ⡊㥌♎㹐㵒᱔⑖ᡘ㡚ⵜᩞՠ੢ᅤ٦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarLeftActionUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ീ♂⍄㍆ࡈ⡊㥌♎㹐㵒TṖམ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.LightBarLeftActionListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ീ♂⍄㍆ࡈ⡊㥌♎㹐㵒ᥔ㹖⩘⽚", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.LightBarRightActionIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ፀ⩂≄⽆㵈੊⹌㭎㡐㱒㭔Ṗ⩘ᩚ㹜⽞㝠ɢ।๦൨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarRightActionIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ፀ⩂≄⽆㵈੊⹌㭎㡐㱒㭔Ṗ⩘ᩚ㹜⽞⁠።ᕤ୦hࡪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarRightActionIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ፀ⩂≄⽆㵈੊⹌㭎㡐㱒㭔Ṗ⩘ᩚ㹜⽞㝠੢ᙤ๦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarRightActionIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ፀ⩂≄⽆㵈੊⹌㭎㡐㱒㭔Ṗ⩘ᩚ㹜⽞①ݢ౤፦ࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.LightBarRightActionUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ፀ⩂≄⽆㵈੊⹌㭎㡐㱒㭔ɖၘ൚㱜㍞ᑠ٢", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.LightBarRightActionListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("細娲刴弶䴸示尼䴾ፀ⩂≄⽆㵈੊⹌㭎㡐㱒㭔᭖じ⡚⥜", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.DataButtonCnvIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂل⥆㽈Ɋ㹌๎㉐⍒͔㙖㕘㉚㥜", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonCnvIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂل⥆㽈Ɋ㹌๎㉐⍒ᑔ❖⥘㝚㑜㱞`Ţ।ɦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonCnvIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂل⥆㽈Ɋ㹌๎㉐⍒͔㹖⩘㉚㽜㍞Ѡ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonCnvIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂل⥆㽈Ɋ㹌๎㉐⍒ၔ㍖じ⽚㱜㵞ൠ٢", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonCnvUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂل⥆㽈Ṋь᥎ぐ㽒⁔㉖", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.DataButtonCnvListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂل⥆㽈݊⑌㱎═", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.DataButtonCnvIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂل⥆㽈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़`ར౤ͦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonCnvIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂل⥆㽈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜṞᅠ።।๦੨੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonCnvIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂل⥆㽈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़ࡠၢ౤զը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonCnvIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂل⥆㽈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜᩞՠ੢ᅤ٦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonCnvIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂل⥆㽈Ɋ⍌⭎㑐⭒TṖམ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.DataButtonCnvIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂل⥆㽈Ɋ⍌⭎㑐⭒ᥔ㹖⩘⽚", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.DataButtonTrkIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂᅄ㕆≈Ɋ㹌๎㉐⍒͔㙖㕘㉚㥜", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonTrkIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂᅄ㕆≈Ɋ㹌๎㉐⍒ᑔ❖⥘㝚㑜㱞`Ţ।ɦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonTrkIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂᅄ㕆≈Ɋ㹌๎㉐⍒͔㹖⩘㉚㽜㍞Ѡ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonTrkIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂᅄ㕆≈Ɋ㹌๎㉐⍒ၔ㍖じ⽚㱜㵞ൠ٢", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonTrkUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂᅄ㕆≈Ṋь᥎ぐ㽒⁔㉖", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.DataButtonTrkListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂᅄ㕆≈݊⑌㱎═", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.DataButtonTrkIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂᅄ㕆≈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़`ར౤ͦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonTrkIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂᅄ㕆≈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜṞᅠ።।๦੨੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonTrkIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂᅄ㕆≈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜफ़ࡠၢ౤զը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonTrkIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂᅄ㕆≈Ɋ⍌⭎㑐⭒᱔⑖ᡘ㡚ⵜᩞՠ੢ᅤ٦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DataButtonTrkIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂᅄ㕆≈Ɋ⍌⭎㑐⭒TṖམ㩚ㅜ⩞Ѡ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.DataButtonTrkIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田刲䄴嘶笸为䤼䬾⹀ⵂᅄ㕆≈Ɋ⍌⭎㑐⭒ᥔ㹖⩘⽚", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.EmergencyButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("琰帲倴䔶常帺匼尾㡀łい㍆㵈⑊⍌ॎ㑐㉒⅔≖⭘㹚ᑜⱞ⁠bᕤㅦࡨݪѬ୮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("琰帲倴䔶常帺匼尾㡀łい㍆㵈⑊⍌ॎ㑐㉒⅔≖⭘㹚ᑜⱞ⁠bᕤ♦ᥨ᭪Ŭٮተቲ᝴᭶ᱸ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("琰帲倴䔶常帺匼尾㡀łい㍆㵈⑊⍌ॎ㑐㉒⅔≖⭘㹚ᑜⱞ⁠bᕤㅦhᡪѬ൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.EmergencyButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("琰帲倴䔶常帺匼尾㡀łい㍆㵈⑊⍌ॎ㑐㉒⅔≖⭘㹚ᑜⱞ⁠bᕤ≦൨ɪᥬ๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.EmergencyButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("琰帲倴䔶常帺匼尾㡀łい㍆㵈⑊⍌ॎ㑐㉒⅔≖⭘㹚࡜ᙞ㝠ɢ।ቦ౨", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.EmergencyButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("琰帲倴䔶常帺匼尾㡀łい㍆㵈⑊⍌ॎ㑐㉒⅔≖⭘㹚ᅜ㙞በᝢ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.PursuitButton0FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈筊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።㍤٦ըɪ६", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton0FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈筊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።⑤ᝦᥨݪѬ౮ၰᅲᥴቶ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton0FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈筊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።㍤๦ᩨɪཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton0FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈筊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።⁤ͦhὪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton0FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈筊ୌ⩎ぐ❒⁔╖㱘๚ᑜफ़`རၤɦ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.PursuitButton0FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈筊ୌ⩎ぐ❒⁔╖㱘᝚㑜ⱞᕠ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.PursuitButton0IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈筊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞㝠ɢ।๦൨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton0IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈筊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞⁠።ᕤ୦hࡪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton0IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈筊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞㝠੢ᙤ๦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton0IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈筊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞①ݢ౤፦ࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton0IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈筊ьⅎ㕐㙒ⵔɖၘ൚㱜㍞ᑠ٢", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.PursuitButton0IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈筊ьⅎ㕐㙒ⵔ᭖じ⡚⥜", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.PursuitButton1FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈穊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።㍤٦ըɪ६", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton1FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈穊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።⑤ᝦᥨݪѬ౮ၰᅲᥴቶ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton1FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈穊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።㍤๦ᩨɪཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton1FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈穊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።⁤ͦhὪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton1FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈穊ୌ⩎ぐ❒⁔╖㱘๚ᑜफ़`རၤɦ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.PursuitButton1FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈穊ୌ⩎ぐ❒⁔╖㱘᝚㑜ⱞᕠ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.PursuitButton1IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈穊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞㝠ɢ।๦൨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton1IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈穊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞⁠።ᕤ୦hࡪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton1IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈穊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞㝠੢ᙤ๦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton1IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈穊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞①ݢ౤፦ࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton1IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈穊ьⅎ㕐㙒ⵔɖၘ൚㱜㍞ᑠ٢", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.PursuitButton1IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈穊ьⅎ㕐㙒ⵔ᭖じ⡚⥜", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.PursuitButton2FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈祊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።㍤٦ըɪ६", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton2FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈祊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።⑤ᝦᥨݪѬ౮ၰᅲᥴቶ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton2FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈祊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።㍤๦ᩨɪཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton2FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈祊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።⁤ͦhὪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton2FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈祊ୌ⩎ぐ❒⁔╖㱘๚ᑜफ़`རၤɦ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.PursuitButton2FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈祊ୌ⩎ぐ❒⁔╖㱘᝚㑜ⱞᕠ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.PursuitButton2IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈祊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞㝠ɢ।๦൨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton2IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈祊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞⁠።ᕤ୦hࡪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton2IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈祊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞㝠੢ᙤ๦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton2IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈祊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞①ݢ౤፦ࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton2IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈祊ьⅎ㕐㙒ⵔɖၘ൚㱜㍞ᑠ٢", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.PursuitButton2IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈祊ьⅎ㕐㙒ⵔ᭖じ⡚⥜", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.PursuitButton3FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈硊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።㍤٦ըɪ६", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton3FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈硊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።⑤ᝦᥨݪѬ౮ၰᅲᥴቶ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton3FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈硊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።㍤๦ᩨɪཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton3FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈硊ୌ⩎ぐ❒⁔╖㱘ቚ⹜Ṟɠ።⁤ͦhὪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton3FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈硊ୌ⩎ぐ❒⁔╖㱘๚ᑜफ़`རၤɦ", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.PursuitButton3FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈硊ୌ⩎ぐ❒⁔╖㱘᝚㑜ⱞᕠ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.PursuitButton3IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈硊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞㝠ɢ।๦൨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton3IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈硊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞⁠።ᕤ୦hࡪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton3IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈硊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞㝠੢ᙤ๦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton3IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈硊ьⅎ㕐㙒ⵔṖ⩘ᩚ㹜⽞①ݢ౤፦ࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PursuitButton3IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈硊ьⅎ㕐㙒ⵔɖၘ൚㱜㍞ᑠ٢", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.PursuitButton3IndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰䘲䜴䐶䰸刺䤼紾㑀㝂ㅄ⡆❈硊ьⅎ㕐㙒ⵔ᭖じ⡚⥜", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.MenuItemsConventionalSelectedListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("簰嘲嬴䈶瀸伺堼刾㉀B⩄⥆㽈⹊⍌㭎㡐㱒㭔㙖㕘࡚㡜㍞Ѡbᅤɦ൨❪Ѭᱮհ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.MenuItemsTrunkingSelectedListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("簰嘲嬴䈶瀸伺堼刾㉀ᝂ㝄㉆❈⁊⑌ⅎ㙐Rご㭖㱘㡚⥜㩞ՠ⽢౤ᑦᵨ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.MenuItemsConventionalSelectedListVisibilityProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("簰嘲嬴䈶瀸伺堼刾㉀B⩄⥆㽈⹊⍌㭎㡐㱒㭔㙖㕘࡚㡜㍞Ѡbᅤɦ൨❪Ѭᱮհ╲ᱴѶၸ᥺ᑼ፾ﲄ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("簰嘲嬴䈶瀸伺堼刾㉀ᝂ㝄㉆❈⁊⑌ⅎ㙐Rご㭖㱘㡚⥜㩞ՠ⽢౤ᑦᵨ㵪Ѭᱮᡰᅲᱴ᭶ၸེѼ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.UpButtonIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("搰䌲眴䈶䴸伺刼儾ࡀあф⑆㥈ᵊⱌ⍎㡐㝒", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.UpButtonIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("搰䌲眴䈶䴸伺刼儾ࡀあф⑆㥈੊㵌㽎㵐㩒㙔㙖㭘㝚㡜", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.UpButtonIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("搰䌲眴䈶䴸伺刼儾ࡀあф⑆㥈ᵊ⑌㱎㡐ㅒ㥔㉖", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.UpButtonIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("搰䌲眴䈶䴸伺刼儾ࡀあф⑆㥈๊⥌♎═㉒㝔㭖㱘", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.UpButtonUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("搰䌲眴䈶䴸伺刼儾ᑀੂፄ♆╈㹊⡌", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.UpButtonListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("搰䌲眴䈶䴸伺刼儾ീ⩂㙄㍆", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.DownButtonIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田尲䈴夶笸为䤼䬾⹀ⵂౄ㑆ࡈ⡊㵌᥎ぐ㽒㱔㍖", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DownButtonIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田尲䈴夶笸为䤼䬾⹀ⵂౄ㑆ࡈ⡊㵌๎⅐⍒㥔㹖㩘㩚㽜㍞Ѡ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DownButtonIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田尲䈴夶笸为䤼䬾⹀ⵂౄ㑆ࡈ⡊㵌᥎㡐⁒㱔㕖㕘㹚", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DownButtonIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田尲䈴夶笸为䤼䬾⹀ⵂౄ㑆ࡈ⡊㵌੎㕐㩒⅔㙖㭘㝚㡜", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.DownButtonUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田尲䈴夶笸为䤼䬾⹀ⵂ၄ๆὈ⩊⅌㩎㑐", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.DownButtonListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("田尲䈴夶笸为䤼䬾⹀ⵂॄ⹆㩈㽊", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.AirhornButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀰娲䜴弶嘸䤺匼紾㑀㝂ㅄ⡆❈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.AirhornButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀰娲䜴弶嘸䤺匼紾㑀㝂ㅄ⡆❈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.AirhornButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀰娲䜴弶嘸䤺匼紾㑀㝂ㅄ⡆❈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.AirhornButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀰娲䜴弶嘸䤺匼紾㑀㝂ㅄ⡆❈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.AirhornButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀰娲䜴弶嘸䤺匼紾㑀㝂ㅄ⡆❈ൊ⡌⹎═♒❔㉖ౘቚଡ଼㹞ൠᙢd", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.AirhornButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀰娲䜴弶嘸䤺匼紾㑀㝂ㅄ⡆❈ൊ⡌⹎═♒❔㉖ᕘ㉚⹜⭞", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.ManualButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("簰刲嬴䈶堸场缼䨾㕀㝂⩄⥆཈⹊ⱌ㭎⑐⅒ごṖ⩘ᩚ㹜⽞㝠ɢ।๦൨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.ManualButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("簰刲嬴䈶堸场缼䨾㕀㝂⩄⥆཈⹊ⱌ㭎⑐⅒ごṖ⩘ᩚ㹜⽞⁠።ᕤ୦hࡪ౬൮ᵰᙲ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.ManualButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("簰刲嬴䈶堸场缼䨾㕀㝂⩄⥆཈⹊ⱌ㭎⑐⅒ごṖ⩘ᩚ㹜⽞㝠੢ᙤ๦୨ݪ࡬", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.ManualButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("簰刲嬴䈶堸场缼䨾㕀㝂⩄⥆཈⹊ⱌ㭎⑐⅒ごṖ⩘ᩚ㹜⽞①ݢ౤፦ࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.ManualButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("簰刲嬴䈶堸场缼䨾㕀㝂⩄⥆཈⹊ⱌ㭎⑐⅒ごɖၘ൚㱜㍞ᑠ٢", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.ManualButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("簰刲嬴䈶堸场缼䨾㕀㝂⩄⥆཈⹊ⱌ㭎⑐⅒ご᭖じ⡚⥜", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.WailButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("昰刲尴嬶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.WailButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("昰刲尴嬶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.WailButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("昰刲尴嬶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.WailButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("昰刲尴嬶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.WailButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("昰刲尴嬶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.WailButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("昰刲尴嬶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.YelpButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("栰嘲头䜶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.YelpButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("栰嘲头䜶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.YelpButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("栰嘲头䜶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.YelpButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("栰嘲头䜶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.YelpButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("栰嘲头䜶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.YelpButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("栰嘲头䜶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.HiloButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礰娲头堶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.HiloButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礰娲头堶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.HiloButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礰娲头堶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.HiloButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礰娲头堶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.HiloButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礰娲头堶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.HiloButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礰娲头堶笸为䤼䬾⹀ⵂ̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(O9GraphicView));
			O9GraphicView.PAButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰爲眴䈶䴸伺刼儾݀♂⑄㍆㱈㥊⡌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PAButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰爲眴䈶䴸伺刼儾݀♂⑄㍆㱈㥊⡌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PAButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰爲眴䈶䴸伺刼儾݀♂⑄㍆㱈㥊⡌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PAButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰爲眴䈶䴸伺刼儾݀♂⑄㍆㱈㥊⡌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(O9GraphicView));
			O9GraphicView.PAButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰爲眴䈶䴸伺刼儾݀♂⑄㍆㱈㥊⡌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(O9GraphicView));
			O9GraphicView.PAButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愰爲眴䈶䴸伺刼儾݀♂⑄㍆㱈㥊⡌͎㡐⁒⅔", a_), typeof(AcpListField), typeof(O9GraphicView));
		}

		// Token: 0x040009D4 RID: 2516
		private bool isPursuitButton0IndexAnimating;

		// Token: 0x040009D5 RID: 2517
		private bool isPursuitButton1IndexAnimating;

		// Token: 0x040009D6 RID: 2518
		private bool isPursuitButton2IndexAnimating;

		// Token: 0x040009D7 RID: 2519
		private bool isPursuitButton3IndexAnimating;

		// Token: 0x040009D8 RID: 2520
		private bool isPursuitButton0FeatureAnimating;

		// Token: 0x040009D9 RID: 2521
		private bool isPursuitButton1FeatureAnimating;

		// Token: 0x040009DA RID: 2522
		private bool isPursuitButton2FeatureAnimating;

		// Token: 0x040009DB RID: 2523
		private bool isPursuitButton3FeatureAnimating;

		// Token: 0x040009DC RID: 2524
		private bool isEmergencyButtonFeatureAnimating;

		// Token: 0x040009DD RID: 2525
		private bool isBottomButton1IndexAnimating;

		// Token: 0x040009DE RID: 2526
		private bool isBottomButton2IndexAnimating;

		// Token: 0x040009DF RID: 2527
		private bool isBottomButton3IndexAnimating;

		// Token: 0x040009E0 RID: 2528
		private bool isBottomButton4IndexAnimating;

		// Token: 0x040009E1 RID: 2529
		private bool isBottomButton5IndexAnimating;

		// Token: 0x040009E2 RID: 2530
		private bool isBottomButton1FeatureAnimating;

		// Token: 0x040009E3 RID: 2531
		private bool isBottomButton2FeatureAnimating;

		// Token: 0x040009E4 RID: 2532
		private bool isBottomButton3FeatureAnimating;

		// Token: 0x040009E5 RID: 2533
		private bool isBottomButton4FeatureAnimating;

		// Token: 0x040009E6 RID: 2534
		private bool isBottomButton5FeatureAnimating;

		// Token: 0x040009E7 RID: 2535
		private bool isTopButton1ZoneAnimating;

		// Token: 0x040009E8 RID: 2536
		private bool isTopButton1ChannelAnimating;

		// Token: 0x040009E9 RID: 2537
		private bool isTopButton2ZoneAnimating;

		// Token: 0x040009EA RID: 2538
		private bool isTopButton2ChannelAnimating;

		// Token: 0x040009EB RID: 2539
		private bool isTopButton3ZoneAnimating;

		// Token: 0x040009EC RID: 2540
		private bool isTopButton3ChannelAnimating;

		// Token: 0x040009ED RID: 2541
		private bool isTopButton4ZoneAnimating;

		// Token: 0x040009EE RID: 2542
		private bool isTopButton4ChannelAnimating;

		// Token: 0x040009EF RID: 2543
		private bool isTopButton5ZoneAnimating;

		// Token: 0x040009F0 RID: 2544
		private bool isTopButton5ChannelAnimating;

		// Token: 0x040009F1 RID: 2545
		private bool isTopButton1IndexAnimating;

		// Token: 0x040009F2 RID: 2546
		private bool isTopButton2IndexAnimating;

		// Token: 0x040009F3 RID: 2547
		private bool isTopButton3IndexAnimating;

		// Token: 0x040009F4 RID: 2548
		private bool isTopButton4IndexAnimating;

		// Token: 0x040009F5 RID: 2549
		private bool isTopButton5IndexAnimating;

		// Token: 0x040009F6 RID: 2550
		private bool isTopButton1FeatureAnimating;

		// Token: 0x040009F7 RID: 2551
		private bool isTopButton2FeatureAnimating;

		// Token: 0x040009F8 RID: 2552
		private bool isTopButton3FeatureAnimating;

		// Token: 0x040009F9 RID: 2553
		private bool isTopButton4FeatureAnimating;

		// Token: 0x040009FA RID: 2554
		private bool isTopButton5FeatureAnimating;

		// Token: 0x040009FB RID: 2555
		private bool isLightbarLeftIndexAnimating;

		// Token: 0x040009FC RID: 2556
		private bool isLightbarRightIndexAnimating;

		// Token: 0x040009FD RID: 2557
		private bool isLightbarTopIndexAnimating;

		// Token: 0x040009FE RID: 2558
		private bool isLightbarLeftFeatureAnimating;

		// Token: 0x040009FF RID: 2559
		private bool isLightbarRightFeatureAnimating;

		// Token: 0x04000A00 RID: 2560
		private bool isLightbarTopFeatureAnimating;

		// Token: 0x04000A01 RID: 2561
		public static DependencyProperty BottomButton1FeatureIsAcpValidProperty;

		// Token: 0x04000A02 RID: 2562
		public static DependencyProperty BottomButton1FeatureIsAcpApplicableProperty;

		// Token: 0x04000A03 RID: 2563
		public static DependencyProperty BottomButton1FeatureIsAcpVisibleProperty;

		// Token: 0x04000A04 RID: 2564
		public static DependencyProperty BottomButton1FeatureIsAcpEditableProperty;

		// Token: 0x04000A05 RID: 2565
		public static DependencyProperty BottomButton1FeatureUIValueProperty;

		// Token: 0x04000A06 RID: 2566
		public static DependencyProperty BottomButton1FeatureListProperty;

		// Token: 0x04000A07 RID: 2567
		public static DependencyProperty BottomButton1IndexIsAcpValidProperty;

		// Token: 0x04000A08 RID: 2568
		public static DependencyProperty BottomButton1IndexIsAcpApplicableProperty;

		// Token: 0x04000A09 RID: 2569
		public static DependencyProperty BottomButton1IndexIsAcpVisibleProperty;

		// Token: 0x04000A0A RID: 2570
		public static DependencyProperty BottomButton1IndexIsAcpEditableProperty;

		// Token: 0x04000A0B RID: 2571
		public static DependencyProperty BottomButton1IndexUIValueProperty;

		// Token: 0x04000A0C RID: 2572
		public static DependencyProperty BottomButton1IndexListProperty;

		// Token: 0x04000A0D RID: 2573
		public static DependencyProperty BottomButton2FeatureIsAcpValidProperty;

		// Token: 0x04000A0E RID: 2574
		public static DependencyProperty BottomButton2FeatureIsAcpApplicableProperty;

		// Token: 0x04000A0F RID: 2575
		public static DependencyProperty BottomButton2FeatureIsAcpVisibleProperty;

		// Token: 0x04000A10 RID: 2576
		public static DependencyProperty BottomButton2FeatureIsAcpEditableProperty;

		// Token: 0x04000A11 RID: 2577
		public static DependencyProperty BottomButton2FeatureUIValueProperty;

		// Token: 0x04000A12 RID: 2578
		public static DependencyProperty BottomButton2FeatureListProperty;

		// Token: 0x04000A13 RID: 2579
		public static DependencyProperty BottomButton2IndexIsAcpValidProperty;

		// Token: 0x04000A14 RID: 2580
		public static DependencyProperty BottomButton2IndexIsAcpApplicableProperty;

		// Token: 0x04000A15 RID: 2581
		public static DependencyProperty BottomButton2IndexIsAcpVisibleProperty;

		// Token: 0x04000A16 RID: 2582
		public static DependencyProperty BottomButton2IndexIsAcpEditableProperty;

		// Token: 0x04000A17 RID: 2583
		public static DependencyProperty BottomButton2IndexUIValueProperty;

		// Token: 0x04000A18 RID: 2584
		public static DependencyProperty BottomButton2IndexListProperty;

		// Token: 0x04000A19 RID: 2585
		public static DependencyProperty BottomButton3FeatureIsAcpValidProperty;

		// Token: 0x04000A1A RID: 2586
		public static DependencyProperty BottomButton3FeatureIsAcpApplicableProperty;

		// Token: 0x04000A1B RID: 2587
		public static DependencyProperty BottomButton3FeatureIsAcpVisibleProperty;

		// Token: 0x04000A1C RID: 2588
		public static DependencyProperty BottomButton3FeatureIsAcpEditableProperty;

		// Token: 0x04000A1D RID: 2589
		public static DependencyProperty BottomButton3FeatureUIValueProperty;

		// Token: 0x04000A1E RID: 2590
		public static DependencyProperty BottomButton3FeatureListProperty;

		// Token: 0x04000A1F RID: 2591
		public static DependencyProperty BottomButton3IndexIsAcpValidProperty;

		// Token: 0x04000A20 RID: 2592
		public static DependencyProperty BottomButton3IndexIsAcpApplicableProperty;

		// Token: 0x04000A21 RID: 2593
		public static DependencyProperty BottomButton3IndexIsAcpVisibleProperty;

		// Token: 0x04000A22 RID: 2594
		public static DependencyProperty BottomButton3IndexIsAcpEditableProperty;

		// Token: 0x04000A23 RID: 2595
		public static DependencyProperty BottomButton3IndexUIValueProperty;

		// Token: 0x04000A24 RID: 2596
		public static DependencyProperty BottomButton3IndexListProperty;

		// Token: 0x04000A25 RID: 2597
		public static DependencyProperty BottomButton4FeatureIsAcpValidProperty;

		// Token: 0x04000A26 RID: 2598
		public static DependencyProperty BottomButton4FeatureIsAcpApplicableProperty;

		// Token: 0x04000A27 RID: 2599
		public static DependencyProperty BottomButton4FeatureIsAcpVisibleProperty;

		// Token: 0x04000A28 RID: 2600
		public static DependencyProperty BottomButton4FeatureIsAcpEditableProperty;

		// Token: 0x04000A29 RID: 2601
		public static DependencyProperty BottomButton4FeatureUIValueProperty;

		// Token: 0x04000A2A RID: 2602
		public static DependencyProperty BottomButton4FeatureListProperty;

		// Token: 0x04000A2B RID: 2603
		public static DependencyProperty BottomButton4IndexIsAcpValidProperty;

		// Token: 0x04000A2C RID: 2604
		public static DependencyProperty BottomButton4IndexIsAcpApplicableProperty;

		// Token: 0x04000A2D RID: 2605
		public static DependencyProperty BottomButton4IndexIsAcpVisibleProperty;

		// Token: 0x04000A2E RID: 2606
		public static DependencyProperty BottomButton4IndexIsAcpEditableProperty;

		// Token: 0x04000A2F RID: 2607
		public static DependencyProperty BottomButton4IndexUIValueProperty;

		// Token: 0x04000A30 RID: 2608
		public static DependencyProperty BottomButton4IndexListProperty;

		// Token: 0x04000A31 RID: 2609
		public static DependencyProperty BottomButton5FeatureIsAcpValidProperty;

		// Token: 0x04000A32 RID: 2610
		public static DependencyProperty BottomButton5FeatureIsAcpApplicableProperty;

		// Token: 0x04000A33 RID: 2611
		public static DependencyProperty BottomButton5FeatureIsAcpVisibleProperty;

		// Token: 0x04000A34 RID: 2612
		public static DependencyProperty BottomButton5FeatureIsAcpEditableProperty;

		// Token: 0x04000A35 RID: 2613
		public static DependencyProperty BottomButton5FeatureUIValueProperty;

		// Token: 0x04000A36 RID: 2614
		public static DependencyProperty BottomButton5FeatureListProperty;

		// Token: 0x04000A37 RID: 2615
		public static DependencyProperty BottomButton5IndexIsAcpValidProperty;

		// Token: 0x04000A38 RID: 2616
		public static DependencyProperty BottomButton5IndexIsAcpApplicableProperty;

		// Token: 0x04000A39 RID: 2617
		public static DependencyProperty BottomButton5IndexIsAcpVisibleProperty;

		// Token: 0x04000A3A RID: 2618
		public static DependencyProperty BottomButton5IndexIsAcpEditableProperty;

		// Token: 0x04000A3B RID: 2619
		public static DependencyProperty BottomButton5IndexUIValueProperty;

		// Token: 0x04000A3C RID: 2620
		public static DependencyProperty BottomButton5IndexListProperty;

		// Token: 0x04000A3D RID: 2621
		public static DependencyProperty TopButton1LabelLine1ValueProperty;

		// Token: 0x04000A3E RID: 2622
		public static DependencyProperty TopButton1LabelLine1IsAcpValidProperty;

		// Token: 0x04000A3F RID: 2623
		public static DependencyProperty TopButton1LabelLine1IsAcpApplicableProperty;

		// Token: 0x04000A40 RID: 2624
		public static DependencyProperty TopButton1LabelLine1IsAcpVisibleProperty;

		// Token: 0x04000A41 RID: 2625
		public static DependencyProperty TopButton1LabelLine1IsAcpEditableProperty;

		// Token: 0x04000A42 RID: 2626
		public static DependencyProperty TopButton1LabelLine1TextProperty;

		// Token: 0x04000A43 RID: 2627
		public static DependencyProperty TopButton1LabelLine2ValueProperty;

		// Token: 0x04000A44 RID: 2628
		public static DependencyProperty TopButton1LabelLine2IsAcpValidProperty;

		// Token: 0x04000A45 RID: 2629
		public static DependencyProperty TopButton1LabelLine2IsAcpApplicableProperty;

		// Token: 0x04000A46 RID: 2630
		public static DependencyProperty TopButton1LabelLine2IsAcpVisibleProperty;

		// Token: 0x04000A47 RID: 2631
		public static DependencyProperty TopButton1LabelLine2IsAcpEditableProperty;

		// Token: 0x04000A48 RID: 2632
		public static DependencyProperty TopButton1LabelLine2TextProperty;

		// Token: 0x04000A49 RID: 2633
		public static DependencyProperty TopButton2LabelLine1ValueProperty;

		// Token: 0x04000A4A RID: 2634
		public static DependencyProperty TopButton2LabelLine1IsAcpValidProperty;

		// Token: 0x04000A4B RID: 2635
		public static DependencyProperty TopButton2LabelLine1IsAcpApplicableProperty;

		// Token: 0x04000A4C RID: 2636
		public static DependencyProperty TopButton2LabelLine1IsAcpVisibleProperty;

		// Token: 0x04000A4D RID: 2637
		public static DependencyProperty TopButton2LabelLine1IsAcpEditableProperty;

		// Token: 0x04000A4E RID: 2638
		public static DependencyProperty TopButton2LabelLine1TextProperty;

		// Token: 0x04000A4F RID: 2639
		public static DependencyProperty TopButton2LabelLine2ValueProperty;

		// Token: 0x04000A50 RID: 2640
		public static DependencyProperty TopButton2LabelLine2IsAcpValidProperty;

		// Token: 0x04000A51 RID: 2641
		public static DependencyProperty TopButton2LabelLine2IsAcpApplicableProperty;

		// Token: 0x04000A52 RID: 2642
		public static DependencyProperty TopButton2LabelLine2IsAcpVisibleProperty;

		// Token: 0x04000A53 RID: 2643
		public static DependencyProperty TopButton2LabelLine2IsAcpEditableProperty;

		// Token: 0x04000A54 RID: 2644
		public static DependencyProperty TopButton2LabelLine2TextProperty;

		// Token: 0x04000A55 RID: 2645
		public static DependencyProperty TopButton3LabelLine1ValueProperty;

		// Token: 0x04000A56 RID: 2646
		public static DependencyProperty TopButton3LabelLine1IsAcpValidProperty;

		// Token: 0x04000A57 RID: 2647
		public static DependencyProperty TopButton3LabelLine1IsAcpApplicableProperty;

		// Token: 0x04000A58 RID: 2648
		public static DependencyProperty TopButton3LabelLine1IsAcpVisibleProperty;

		// Token: 0x04000A59 RID: 2649
		public static DependencyProperty TopButton3LabelLine1IsAcpEditableProperty;

		// Token: 0x04000A5A RID: 2650
		public static DependencyProperty TopButton3LabelLine1TextProperty;

		// Token: 0x04000A5B RID: 2651
		public static DependencyProperty TopButton3LabelLine2ValueProperty;

		// Token: 0x04000A5C RID: 2652
		public static DependencyProperty TopButton3LabelLine2IsAcpValidProperty;

		// Token: 0x04000A5D RID: 2653
		public static DependencyProperty TopButton3LabelLine2IsAcpApplicableProperty;

		// Token: 0x04000A5E RID: 2654
		public static DependencyProperty TopButton3LabelLine2IsAcpVisibleProperty;

		// Token: 0x04000A5F RID: 2655
		public static DependencyProperty TopButton3LabelLine2IsAcpEditableProperty;

		// Token: 0x04000A60 RID: 2656
		public static DependencyProperty TopButton3LabelLine2TextProperty;

		// Token: 0x04000A61 RID: 2657
		public static DependencyProperty TopButton4LabelLine1ValueProperty;

		// Token: 0x04000A62 RID: 2658
		public static DependencyProperty TopButton4LabelLine1IsAcpValidProperty;

		// Token: 0x04000A63 RID: 2659
		public static DependencyProperty TopButton4LabelLine1IsAcpApplicableProperty;

		// Token: 0x04000A64 RID: 2660
		public static DependencyProperty TopButton4LabelLine1IsAcpVisibleProperty;

		// Token: 0x04000A65 RID: 2661
		public static DependencyProperty TopButton4LabelLine1IsAcpEditableProperty;

		// Token: 0x04000A66 RID: 2662
		public static DependencyProperty TopButton4LabelLine1TextProperty;

		// Token: 0x04000A67 RID: 2663
		public static DependencyProperty TopButton4LabelLine2ValueProperty;

		// Token: 0x04000A68 RID: 2664
		public static DependencyProperty TopButton4LabelLine2IsAcpValidProperty;

		// Token: 0x04000A69 RID: 2665
		public static DependencyProperty TopButton4LabelLine2IsAcpApplicableProperty;

		// Token: 0x04000A6A RID: 2666
		public static DependencyProperty TopButton4LabelLine2IsAcpVisibleProperty;

		// Token: 0x04000A6B RID: 2667
		public static DependencyProperty TopButton4LabelLine2IsAcpEditableProperty;

		// Token: 0x04000A6C RID: 2668
		public static DependencyProperty TopButton4LabelLine2TextProperty;

		// Token: 0x04000A6D RID: 2669
		public static DependencyProperty TopButton5LabelLine1ValueProperty;

		// Token: 0x04000A6E RID: 2670
		public static DependencyProperty TopButton5LabelLine1IsAcpValidProperty;

		// Token: 0x04000A6F RID: 2671
		public static DependencyProperty TopButton5LabelLine1IsAcpApplicableProperty;

		// Token: 0x04000A70 RID: 2672
		public static DependencyProperty TopButton5LabelLine1IsAcpVisibleProperty;

		// Token: 0x04000A71 RID: 2673
		public static DependencyProperty TopButton5LabelLine1IsAcpEditableProperty;

		// Token: 0x04000A72 RID: 2674
		public static DependencyProperty TopButton5LabelLine1TextProperty;

		// Token: 0x04000A73 RID: 2675
		public static DependencyProperty TopButton5LabelLine2ValueProperty;

		// Token: 0x04000A74 RID: 2676
		public static DependencyProperty TopButton5LabelLine2IsAcpValidProperty;

		// Token: 0x04000A75 RID: 2677
		public static DependencyProperty TopButton5LabelLine2IsAcpApplicableProperty;

		// Token: 0x04000A76 RID: 2678
		public static DependencyProperty TopButton5LabelLine2IsAcpVisibleProperty;

		// Token: 0x04000A77 RID: 2679
		public static DependencyProperty TopButton5LabelLine2IsAcpEditableProperty;

		// Token: 0x04000A78 RID: 2680
		public static DependencyProperty TopButton5LabelLine2TextProperty;

		// Token: 0x04000A79 RID: 2681
		public static DependencyProperty TopButton1FeatureIsAcpValidProperty;

		// Token: 0x04000A7A RID: 2682
		public static DependencyProperty TopButton1FeatureIsAcpApplicableProperty;

		// Token: 0x04000A7B RID: 2683
		public static DependencyProperty TopButton1FeatureIsAcpVisibleProperty;

		// Token: 0x04000A7C RID: 2684
		public static DependencyProperty TopButton1FeatureIsAcpEditableProperty;

		// Token: 0x04000A7D RID: 2685
		public static DependencyProperty TopButton1FeatureUIValueProperty;

		// Token: 0x04000A7E RID: 2686
		public static DependencyProperty TopButton1FeatureListProperty;

		// Token: 0x04000A7F RID: 2687
		public static DependencyProperty TopButton1IndexIsAcpValidProperty;

		// Token: 0x04000A80 RID: 2688
		public static DependencyProperty TopButton1IndexIsAcpApplicableProperty;

		// Token: 0x04000A81 RID: 2689
		public static DependencyProperty TopButton1IndexIsAcpVisibleProperty;

		// Token: 0x04000A82 RID: 2690
		public static DependencyProperty TopButton1IndexIsAcpEditableProperty;

		// Token: 0x04000A83 RID: 2691
		public static DependencyProperty TopButton1IndexUIValueProperty;

		// Token: 0x04000A84 RID: 2692
		public static DependencyProperty TopButton1IndexListProperty;

		// Token: 0x04000A85 RID: 2693
		public static DependencyProperty TopButton2FeatureIsAcpValidProperty;

		// Token: 0x04000A86 RID: 2694
		public static DependencyProperty TopButton2FeatureIsAcpApplicableProperty;

		// Token: 0x04000A87 RID: 2695
		public static DependencyProperty TopButton2FeatureIsAcpVisibleProperty;

		// Token: 0x04000A88 RID: 2696
		public static DependencyProperty TopButton2FeatureIsAcpEditableProperty;

		// Token: 0x04000A89 RID: 2697
		public static DependencyProperty TopButton2FeatureUIValueProperty;

		// Token: 0x04000A8A RID: 2698
		public static DependencyProperty TopButton2FeatureListProperty;

		// Token: 0x04000A8B RID: 2699
		public static DependencyProperty TopButton2IndexIsAcpValidProperty;

		// Token: 0x04000A8C RID: 2700
		public static DependencyProperty TopButton2IndexIsAcpApplicableProperty;

		// Token: 0x04000A8D RID: 2701
		public static DependencyProperty TopButton2IndexIsAcpVisibleProperty;

		// Token: 0x04000A8E RID: 2702
		public static DependencyProperty TopButton2IndexIsAcpEditableProperty;

		// Token: 0x04000A8F RID: 2703
		public static DependencyProperty TopButton2IndexUIValueProperty;

		// Token: 0x04000A90 RID: 2704
		public static DependencyProperty TopButton2IndexListProperty;

		// Token: 0x04000A91 RID: 2705
		public static DependencyProperty TopButton3FeatureIsAcpValidProperty;

		// Token: 0x04000A92 RID: 2706
		public static DependencyProperty TopButton3FeatureIsAcpApplicableProperty;

		// Token: 0x04000A93 RID: 2707
		public static DependencyProperty TopButton3FeatureIsAcpVisibleProperty;

		// Token: 0x04000A94 RID: 2708
		public static DependencyProperty TopButton3FeatureIsAcpEditableProperty;

		// Token: 0x04000A95 RID: 2709
		public static DependencyProperty TopButton3FeatureUIValueProperty;

		// Token: 0x04000A96 RID: 2710
		public static DependencyProperty TopButton3FeatureListProperty;

		// Token: 0x04000A97 RID: 2711
		public static DependencyProperty TopButton3IndexIsAcpValidProperty;

		// Token: 0x04000A98 RID: 2712
		public static DependencyProperty TopButton3IndexIsAcpApplicableProperty;

		// Token: 0x04000A99 RID: 2713
		public static DependencyProperty TopButton3IndexIsAcpVisibleProperty;

		// Token: 0x04000A9A RID: 2714
		public static DependencyProperty TopButton3IndexIsAcpEditableProperty;

		// Token: 0x04000A9B RID: 2715
		public static DependencyProperty TopButton3IndexUIValueProperty;

		// Token: 0x04000A9C RID: 2716
		public static DependencyProperty TopButton3IndexListProperty;

		// Token: 0x04000A9D RID: 2717
		public static DependencyProperty TopButton4FeatureIsAcpValidProperty;

		// Token: 0x04000A9E RID: 2718
		public static DependencyProperty TopButton4FeatureIsAcpApplicableProperty;

		// Token: 0x04000A9F RID: 2719
		public static DependencyProperty TopButton4FeatureIsAcpVisibleProperty;

		// Token: 0x04000AA0 RID: 2720
		public static DependencyProperty TopButton4FeatureIsAcpEditableProperty;

		// Token: 0x04000AA1 RID: 2721
		public static DependencyProperty TopButton4FeatureUIValueProperty;

		// Token: 0x04000AA2 RID: 2722
		public static DependencyProperty TopButton4FeatureListProperty;

		// Token: 0x04000AA3 RID: 2723
		public static DependencyProperty TopButton4IndexIsAcpValidProperty;

		// Token: 0x04000AA4 RID: 2724
		public static DependencyProperty TopButton4IndexIsAcpApplicableProperty;

		// Token: 0x04000AA5 RID: 2725
		public static DependencyProperty TopButton4IndexIsAcpVisibleProperty;

		// Token: 0x04000AA6 RID: 2726
		public static DependencyProperty TopButton4IndexIsAcpEditableProperty;

		// Token: 0x04000AA7 RID: 2727
		public static DependencyProperty TopButton4IndexUIValueProperty;

		// Token: 0x04000AA8 RID: 2728
		public static DependencyProperty TopButton4IndexListProperty;

		// Token: 0x04000AA9 RID: 2729
		public static DependencyProperty TopButton5FeatureIsAcpValidProperty;

		// Token: 0x04000AAA RID: 2730
		public static DependencyProperty TopButton5FeatureIsAcpApplicableProperty;

		// Token: 0x04000AAB RID: 2731
		public static DependencyProperty TopButton5FeatureIsAcpVisibleProperty;

		// Token: 0x04000AAC RID: 2732
		public static DependencyProperty TopButton5FeatureIsAcpEditableProperty;

		// Token: 0x04000AAD RID: 2733
		public static DependencyProperty TopButton5FeatureUIValueProperty;

		// Token: 0x04000AAE RID: 2734
		public static DependencyProperty TopButton5FeatureListProperty;

		// Token: 0x04000AAF RID: 2735
		public static DependencyProperty TopButton5IndexIsAcpValidProperty;

		// Token: 0x04000AB0 RID: 2736
		public static DependencyProperty TopButton5IndexIsAcpApplicableProperty;

		// Token: 0x04000AB1 RID: 2737
		public static DependencyProperty TopButton5IndexIsAcpVisibleProperty;

		// Token: 0x04000AB2 RID: 2738
		public static DependencyProperty TopButton5IndexIsAcpEditableProperty;

		// Token: 0x04000AB3 RID: 2739
		public static DependencyProperty TopButton5IndexUIValueProperty;

		// Token: 0x04000AB4 RID: 2740
		public static DependencyProperty TopButton5IndexListProperty;

		// Token: 0x04000AB5 RID: 2741
		public static DependencyProperty TopButton1StsMsgIndexIsAcpValidProperty;

		// Token: 0x04000AB6 RID: 2742
		public static DependencyProperty TopButton1StsMsgIndexIsAcpApplicableProperty;

		// Token: 0x04000AB7 RID: 2743
		public static DependencyProperty TopButton1StsMsgIndexIsAcpVisibleProperty;

		// Token: 0x04000AB8 RID: 2744
		public static DependencyProperty TopButton1StsMsgIndexIsAcpEditableProperty;

		// Token: 0x04000AB9 RID: 2745
		public static DependencyProperty TopButton1StsMsgIndexUIValueProperty;

		// Token: 0x04000ABA RID: 2746
		public static DependencyProperty TopButton1StsMsgIndexRangeProperty;

		// Token: 0x04000ABB RID: 2747
		public static DependencyProperty TopButton2StsMsgIndexIsAcpValidProperty;

		// Token: 0x04000ABC RID: 2748
		public static DependencyProperty TopButton2StsMsgIndexIsAcpApplicableProperty;

		// Token: 0x04000ABD RID: 2749
		public static DependencyProperty TopButton2StsMsgIndexIsAcpVisibleProperty;

		// Token: 0x04000ABE RID: 2750
		public static DependencyProperty TopButton2StsMsgIndexIsAcpEditableProperty;

		// Token: 0x04000ABF RID: 2751
		public static DependencyProperty TopButton2StsMsgIndexUIValueProperty;

		// Token: 0x04000AC0 RID: 2752
		public static DependencyProperty TopButton2StsMsgIndexRangeProperty;

		// Token: 0x04000AC1 RID: 2753
		public static DependencyProperty TopButton3StsMsgIndexIsAcpValidProperty;

		// Token: 0x04000AC2 RID: 2754
		public static DependencyProperty TopButton3StsMsgIndexIsAcpApplicableProperty;

		// Token: 0x04000AC3 RID: 2755
		public static DependencyProperty TopButton3StsMsgIndexIsAcpVisibleProperty;

		// Token: 0x04000AC4 RID: 2756
		public static DependencyProperty TopButton3StsMsgIndexIsAcpEditableProperty;

		// Token: 0x04000AC5 RID: 2757
		public static DependencyProperty TopButton3StsMsgIndexUIValueProperty;

		// Token: 0x04000AC6 RID: 2758
		public static DependencyProperty TopButton3StsMsgIndexRangeProperty;

		// Token: 0x04000AC7 RID: 2759
		public static DependencyProperty TopButton4StsMsgIndexIsAcpValidProperty;

		// Token: 0x04000AC8 RID: 2760
		public static DependencyProperty TopButton4StsMsgIndexIsAcpApplicableProperty;

		// Token: 0x04000AC9 RID: 2761
		public static DependencyProperty TopButton4StsMsgIndexIsAcpVisibleProperty;

		// Token: 0x04000ACA RID: 2762
		public static DependencyProperty TopButton4StsMsgIndexIsAcpEditableProperty;

		// Token: 0x04000ACB RID: 2763
		public static DependencyProperty TopButton4StsMsgIndexUIValueProperty;

		// Token: 0x04000ACC RID: 2764
		public static DependencyProperty TopButton4StsMsgIndexRangeProperty;

		// Token: 0x04000ACD RID: 2765
		public static DependencyProperty TopButton5StsMsgIndexIsAcpValidProperty;

		// Token: 0x04000ACE RID: 2766
		public static DependencyProperty TopButton5StsMsgIndexIsAcpApplicableProperty;

		// Token: 0x04000ACF RID: 2767
		public static DependencyProperty TopButton5StsMsgIndexIsAcpVisibleProperty;

		// Token: 0x04000AD0 RID: 2768
		public static DependencyProperty TopButton5StsMsgIndexIsAcpEditableProperty;

		// Token: 0x04000AD1 RID: 2769
		public static DependencyProperty TopButton5StsMsgIndexUIValueProperty;

		// Token: 0x04000AD2 RID: 2770
		public static DependencyProperty TopButton5StsMsgIndexRangeProperty;

		// Token: 0x04000AD3 RID: 2771
		public static DependencyProperty TopButton1ZoneIsAcpValidProperty;

		// Token: 0x04000AD4 RID: 2772
		public static DependencyProperty TopButton1ZoneIsAcpApplicableProperty;

		// Token: 0x04000AD5 RID: 2773
		public static DependencyProperty TopButton1ZoneIsAcpVisibleProperty;

		// Token: 0x04000AD6 RID: 2774
		public static DependencyProperty TopButton1ZoneIsAcpEditableProperty;

		// Token: 0x04000AD7 RID: 2775
		public static DependencyProperty TopButton1ZoneUIValueProperty;

		// Token: 0x04000AD8 RID: 2776
		public static DependencyProperty TopButton1ZoneListProperty;

		// Token: 0x04000AD9 RID: 2777
		public static DependencyProperty TopButton2ZoneIsAcpValidProperty;

		// Token: 0x04000ADA RID: 2778
		public static DependencyProperty TopButton2ZoneIsAcpApplicableProperty;

		// Token: 0x04000ADB RID: 2779
		public static DependencyProperty TopButton2ZoneIsAcpVisibleProperty;

		// Token: 0x04000ADC RID: 2780
		public static DependencyProperty TopButton2ZoneIsAcpEditableProperty;

		// Token: 0x04000ADD RID: 2781
		public static DependencyProperty TopButton2ZoneUIValueProperty;

		// Token: 0x04000ADE RID: 2782
		public static DependencyProperty TopButton2ZoneListProperty;

		// Token: 0x04000ADF RID: 2783
		public static DependencyProperty TopButton3ZoneIsAcpValidProperty;

		// Token: 0x04000AE0 RID: 2784
		public static DependencyProperty TopButton3ZoneIsAcpApplicableProperty;

		// Token: 0x04000AE1 RID: 2785
		public static DependencyProperty TopButton3ZoneIsAcpVisibleProperty;

		// Token: 0x04000AE2 RID: 2786
		public static DependencyProperty TopButton3ZoneIsAcpEditableProperty;

		// Token: 0x04000AE3 RID: 2787
		public static DependencyProperty TopButton3ZoneUIValueProperty;

		// Token: 0x04000AE4 RID: 2788
		public static DependencyProperty TopButton3ZoneListProperty;

		// Token: 0x04000AE5 RID: 2789
		public static DependencyProperty TopButton4ZoneIsAcpValidProperty;

		// Token: 0x04000AE6 RID: 2790
		public static DependencyProperty TopButton4ZoneIsAcpApplicableProperty;

		// Token: 0x04000AE7 RID: 2791
		public static DependencyProperty TopButton4ZoneIsAcpVisibleProperty;

		// Token: 0x04000AE8 RID: 2792
		public static DependencyProperty TopButton4ZoneIsAcpEditableProperty;

		// Token: 0x04000AE9 RID: 2793
		public static DependencyProperty TopButton4ZoneUIValueProperty;

		// Token: 0x04000AEA RID: 2794
		public static DependencyProperty TopButton4ZoneListProperty;

		// Token: 0x04000AEB RID: 2795
		public static DependencyProperty TopButton5ZoneIsAcpValidProperty;

		// Token: 0x04000AEC RID: 2796
		public static DependencyProperty TopButton5ZoneIsAcpApplicableProperty;

		// Token: 0x04000AED RID: 2797
		public static DependencyProperty TopButton5ZoneIsAcpVisibleProperty;

		// Token: 0x04000AEE RID: 2798
		public static DependencyProperty TopButton5ZoneIsAcpEditableProperty;

		// Token: 0x04000AEF RID: 2799
		public static DependencyProperty TopButton5ZoneUIValueProperty;

		// Token: 0x04000AF0 RID: 2800
		public static DependencyProperty TopButton5ZoneListProperty;

		// Token: 0x04000AF1 RID: 2801
		public static DependencyProperty TopButton1ChannelIsAcpValidProperty;

		// Token: 0x04000AF2 RID: 2802
		public static DependencyProperty TopButton1ChannelIsAcpApplicableProperty;

		// Token: 0x04000AF3 RID: 2803
		public static DependencyProperty TopButton1ChannelIsAcpVisibleProperty;

		// Token: 0x04000AF4 RID: 2804
		public static DependencyProperty TopButton1ChannelIsAcpEditableProperty;

		// Token: 0x04000AF5 RID: 2805
		public static DependencyProperty TopButton1ChannelUIValueProperty;

		// Token: 0x04000AF6 RID: 2806
		public static DependencyProperty TopButton1ChannelListProperty;

		// Token: 0x04000AF7 RID: 2807
		public static DependencyProperty TopButton2ChannelIsAcpValidProperty;

		// Token: 0x04000AF8 RID: 2808
		public static DependencyProperty TopButton2ChannelIsAcpApplicableProperty;

		// Token: 0x04000AF9 RID: 2809
		public static DependencyProperty TopButton2ChannelIsAcpVisibleProperty;

		// Token: 0x04000AFA RID: 2810
		public static DependencyProperty TopButton2ChannelIsAcpEditableProperty;

		// Token: 0x04000AFB RID: 2811
		public static DependencyProperty TopButton2ChannelUIValueProperty;

		// Token: 0x04000AFC RID: 2812
		public static DependencyProperty TopButton2ChannelListProperty;

		// Token: 0x04000AFD RID: 2813
		public static DependencyProperty TopButton3ChannelIsAcpValidProperty;

		// Token: 0x04000AFE RID: 2814
		public static DependencyProperty TopButton3ChannelIsAcpApplicableProperty;

		// Token: 0x04000AFF RID: 2815
		public static DependencyProperty TopButton3ChannelIsAcpVisibleProperty;

		// Token: 0x04000B00 RID: 2816
		public static DependencyProperty TopButton3ChannelIsAcpEditableProperty;

		// Token: 0x04000B01 RID: 2817
		public static DependencyProperty TopButton3ChannelUIValueProperty;

		// Token: 0x04000B02 RID: 2818
		public static DependencyProperty TopButton3ChannelListProperty;

		// Token: 0x04000B03 RID: 2819
		public static DependencyProperty TopButton4ChannelIsAcpValidProperty;

		// Token: 0x04000B04 RID: 2820
		public static DependencyProperty TopButton4ChannelIsAcpApplicableProperty;

		// Token: 0x04000B05 RID: 2821
		public static DependencyProperty TopButton4ChannelIsAcpVisibleProperty;

		// Token: 0x04000B06 RID: 2822
		public static DependencyProperty TopButton4ChannelIsAcpEditableProperty;

		// Token: 0x04000B07 RID: 2823
		public static DependencyProperty TopButton4ChannelUIValueProperty;

		// Token: 0x04000B08 RID: 2824
		public static DependencyProperty TopButton4ChannelListProperty;

		// Token: 0x04000B09 RID: 2825
		public static DependencyProperty TopButton5ChannelIsAcpValidProperty;

		// Token: 0x04000B0A RID: 2826
		public static DependencyProperty TopButton5ChannelIsAcpApplicableProperty;

		// Token: 0x04000B0B RID: 2827
		public static DependencyProperty TopButton5ChannelIsAcpVisibleProperty;

		// Token: 0x04000B0C RID: 2828
		public static DependencyProperty TopButton5ChannelIsAcpEditableProperty;

		// Token: 0x04000B0D RID: 2829
		public static DependencyProperty TopButton5ChannelUIValueProperty;

		// Token: 0x04000B0E RID: 2830
		public static DependencyProperty TopButton5ChannelListProperty;

		// Token: 0x04000B0F RID: 2831
		public static DependencyProperty LightBarTopIndexIsAcpValidProperty;

		// Token: 0x04000B10 RID: 2832
		public static DependencyProperty LightBarTopIndexIsAcpApplicableProperty;

		// Token: 0x04000B11 RID: 2833
		public static DependencyProperty LightBarTopIndexIsAcpVisibleProperty;

		// Token: 0x04000B12 RID: 2834
		public static DependencyProperty LightBarTopIndexIsAcpEditableProperty;

		// Token: 0x04000B13 RID: 2835
		public static DependencyProperty LightBarTopIndexUIValueProperty;

		// Token: 0x04000B14 RID: 2836
		public static DependencyProperty LightBarTopIndexListProperty;

		// Token: 0x04000B15 RID: 2837
		public static DependencyProperty LightBarLeftIndexIsAcpValidProperty;

		// Token: 0x04000B16 RID: 2838
		public static DependencyProperty LightBarLeftIndexIsAcpApplicableProperty;

		// Token: 0x04000B17 RID: 2839
		public static DependencyProperty LightBarLeftIndexIsAcpVisibleProperty;

		// Token: 0x04000B18 RID: 2840
		public static DependencyProperty LightBarLeftIndexIsAcpEditableProperty;

		// Token: 0x04000B19 RID: 2841
		public static DependencyProperty LightBarLeftIndexUIValueProperty;

		// Token: 0x04000B1A RID: 2842
		public static DependencyProperty LightBarLeftIndexListProperty;

		// Token: 0x04000B1B RID: 2843
		public static DependencyProperty LightBarRightIndexIsAcpValidProperty;

		// Token: 0x04000B1C RID: 2844
		public static DependencyProperty LightBarRightIndexIsAcpApplicableProperty;

		// Token: 0x04000B1D RID: 2845
		public static DependencyProperty LightBarRightIndexIsAcpVisibleProperty;

		// Token: 0x04000B1E RID: 2846
		public static DependencyProperty LightBarRightIndexIsAcpEditableProperty;

		// Token: 0x04000B1F RID: 2847
		public static DependencyProperty LightBarRightIndexUIValueProperty;

		// Token: 0x04000B20 RID: 2848
		public static DependencyProperty LightBarRightIndexListProperty;

		// Token: 0x04000B21 RID: 2849
		public static DependencyProperty LightBarTopActionIsAcpValidProperty;

		// Token: 0x04000B22 RID: 2850
		public static DependencyProperty LightBarTopActionIsAcpApplicableProperty;

		// Token: 0x04000B23 RID: 2851
		public static DependencyProperty LightBarTopActionIsAcpVisibleProperty;

		// Token: 0x04000B24 RID: 2852
		public static DependencyProperty LightBarTopActionIsAcpEditableProperty;

		// Token: 0x04000B25 RID: 2853
		public static DependencyProperty LightBarTopActionUIValueProperty;

		// Token: 0x04000B26 RID: 2854
		public static DependencyProperty LightBarTopActionListProperty;

		// Token: 0x04000B27 RID: 2855
		public static DependencyProperty LightBarLeftActionIsAcpValidProperty;

		// Token: 0x04000B28 RID: 2856
		public static DependencyProperty LightBarLeftActionIsAcpApplicableProperty;

		// Token: 0x04000B29 RID: 2857
		public static DependencyProperty LightBarLeftActionIsAcpVisibleProperty;

		// Token: 0x04000B2A RID: 2858
		public static DependencyProperty LightBarLeftActionIsAcpEditableProperty;

		// Token: 0x04000B2B RID: 2859
		public static DependencyProperty LightBarLeftActionUIValueProperty;

		// Token: 0x04000B2C RID: 2860
		public static DependencyProperty LightBarLeftActionListProperty;

		// Token: 0x04000B2D RID: 2861
		public static DependencyProperty LightBarRightActionIsAcpValidProperty;

		// Token: 0x04000B2E RID: 2862
		public static DependencyProperty LightBarRightActionIsAcpApplicableProperty;

		// Token: 0x04000B2F RID: 2863
		public static DependencyProperty LightBarRightActionIsAcpVisibleProperty;

		// Token: 0x04000B30 RID: 2864
		public static DependencyProperty LightBarRightActionIsAcpEditableProperty;

		// Token: 0x04000B31 RID: 2865
		public static DependencyProperty LightBarRightActionUIValueProperty;

		// Token: 0x04000B32 RID: 2866
		public static DependencyProperty LightBarRightActionListProperty;

		// Token: 0x04000B33 RID: 2867
		public static DependencyProperty DataButtonCnvIsAcpValidProperty;

		// Token: 0x04000B34 RID: 2868
		public static DependencyProperty DataButtonCnvIsAcpApplicableProperty;

		// Token: 0x04000B35 RID: 2869
		public static DependencyProperty DataButtonCnvIsAcpVisibleProperty;

		// Token: 0x04000B36 RID: 2870
		public static DependencyProperty DataButtonCnvIsAcpEditableProperty;

		// Token: 0x04000B37 RID: 2871
		public static DependencyProperty DataButtonCnvUIValueProperty;

		// Token: 0x04000B38 RID: 2872
		public static DependencyProperty DataButtonCnvListProperty;

		// Token: 0x04000B39 RID: 2873
		public static DependencyProperty DataButtonCnvIndexIsAcpValidProperty;

		// Token: 0x04000B3A RID: 2874
		public static DependencyProperty DataButtonCnvIndexIsAcpApplicableProperty;

		// Token: 0x04000B3B RID: 2875
		public static DependencyProperty DataButtonCnvIndexIsAcpVisibleProperty;

		// Token: 0x04000B3C RID: 2876
		public static DependencyProperty DataButtonCnvIndexIsAcpEditableProperty;

		// Token: 0x04000B3D RID: 2877
		public static DependencyProperty DataButtonCnvIndexUIValueProperty;

		// Token: 0x04000B3E RID: 2878
		public static DependencyProperty DataButtonCnvIndexListProperty;

		// Token: 0x04000B3F RID: 2879
		public static DependencyProperty DataButtonTrkIsAcpValidProperty;

		// Token: 0x04000B40 RID: 2880
		public static DependencyProperty DataButtonTrkIsAcpApplicableProperty;

		// Token: 0x04000B41 RID: 2881
		public static DependencyProperty DataButtonTrkIsAcpVisibleProperty;

		// Token: 0x04000B42 RID: 2882
		public static DependencyProperty DataButtonTrkIsAcpEditableProperty;

		// Token: 0x04000B43 RID: 2883
		public static DependencyProperty DataButtonTrkUIValueProperty;

		// Token: 0x04000B44 RID: 2884
		public static DependencyProperty DataButtonTrkListProperty;

		// Token: 0x04000B45 RID: 2885
		public static DependencyProperty DataButtonTrkIndexIsAcpValidProperty;

		// Token: 0x04000B46 RID: 2886
		public static DependencyProperty DataButtonTrkIndexIsAcpApplicableProperty;

		// Token: 0x04000B47 RID: 2887
		public static DependencyProperty DataButtonTrkIndexIsAcpVisibleProperty;

		// Token: 0x04000B48 RID: 2888
		public static DependencyProperty DataButtonTrkIndexIsAcpEditableProperty;

		// Token: 0x04000B49 RID: 2889
		public static DependencyProperty DataButtonTrkIndexUIValueProperty;

		// Token: 0x04000B4A RID: 2890
		public static DependencyProperty DataButtonTrkIndexListProperty;

		// Token: 0x04000B4B RID: 2891
		public static DependencyProperty EmergencyButtonFeatureIsAcpValidProperty;

		// Token: 0x04000B4C RID: 2892
		public static DependencyProperty EmergencyButtonFeatureIsAcpApplicableProperty;

		// Token: 0x04000B4D RID: 2893
		public static DependencyProperty EmergencyButtonFeatureIsAcpVisibleProperty;

		// Token: 0x04000B4E RID: 2894
		public static DependencyProperty EmergencyButtonFeatureIsAcpEditableProperty;

		// Token: 0x04000B4F RID: 2895
		public static DependencyProperty EmergencyButtonFeatureUIValueProperty;

		// Token: 0x04000B50 RID: 2896
		public static DependencyProperty EmergencyButtonFeatureListProperty;

		// Token: 0x04000B51 RID: 2897
		public static DependencyProperty PursuitButton0FeatureIsAcpValidProperty;

		// Token: 0x04000B52 RID: 2898
		public static DependencyProperty PursuitButton0FeatureIsAcpApplicableProperty;

		// Token: 0x04000B53 RID: 2899
		public static DependencyProperty PursuitButton0FeatureIsAcpVisibleProperty;

		// Token: 0x04000B54 RID: 2900
		public static DependencyProperty PursuitButton0FeatureIsAcpEditableProperty;

		// Token: 0x04000B55 RID: 2901
		public static DependencyProperty PursuitButton0FeatureUIValueProperty;

		// Token: 0x04000B56 RID: 2902
		public static DependencyProperty PursuitButton0FeatureListProperty;

		// Token: 0x04000B57 RID: 2903
		public static DependencyProperty PursuitButton0IndexIsAcpValidProperty;

		// Token: 0x04000B58 RID: 2904
		public static DependencyProperty PursuitButton0IndexIsAcpApplicableProperty;

		// Token: 0x04000B59 RID: 2905
		public static DependencyProperty PursuitButton0IndexIsAcpVisibleProperty;

		// Token: 0x04000B5A RID: 2906
		public static DependencyProperty PursuitButton0IndexIsAcpEditableProperty;

		// Token: 0x04000B5B RID: 2907
		public static DependencyProperty PursuitButton0IndexUIValueProperty;

		// Token: 0x04000B5C RID: 2908
		public static DependencyProperty PursuitButton0IndexListProperty;

		// Token: 0x04000B5D RID: 2909
		public static DependencyProperty PursuitButton1FeatureIsAcpValidProperty;

		// Token: 0x04000B5E RID: 2910
		public static DependencyProperty PursuitButton1FeatureIsAcpApplicableProperty;

		// Token: 0x04000B5F RID: 2911
		public static DependencyProperty PursuitButton1FeatureIsAcpVisibleProperty;

		// Token: 0x04000B60 RID: 2912
		public static DependencyProperty PursuitButton1FeatureIsAcpEditableProperty;

		// Token: 0x04000B61 RID: 2913
		public static DependencyProperty PursuitButton1FeatureUIValueProperty;

		// Token: 0x04000B62 RID: 2914
		public static DependencyProperty PursuitButton1FeatureListProperty;

		// Token: 0x04000B63 RID: 2915
		public static DependencyProperty PursuitButton1IndexIsAcpValidProperty;

		// Token: 0x04000B64 RID: 2916
		public static DependencyProperty PursuitButton1IndexIsAcpApplicableProperty;

		// Token: 0x04000B65 RID: 2917
		public static DependencyProperty PursuitButton1IndexIsAcpVisibleProperty;

		// Token: 0x04000B66 RID: 2918
		public static DependencyProperty PursuitButton1IndexIsAcpEditableProperty;

		// Token: 0x04000B67 RID: 2919
		public static DependencyProperty PursuitButton1IndexUIValueProperty;

		// Token: 0x04000B68 RID: 2920
		public static DependencyProperty PursuitButton1IndexListProperty;

		// Token: 0x04000B69 RID: 2921
		public static DependencyProperty PursuitButton2FeatureIsAcpValidProperty;

		// Token: 0x04000B6A RID: 2922
		public static DependencyProperty PursuitButton2FeatureIsAcpApplicableProperty;

		// Token: 0x04000B6B RID: 2923
		public static DependencyProperty PursuitButton2FeatureIsAcpVisibleProperty;

		// Token: 0x04000B6C RID: 2924
		public static DependencyProperty PursuitButton2FeatureIsAcpEditableProperty;

		// Token: 0x04000B6D RID: 2925
		public static DependencyProperty PursuitButton2FeatureUIValueProperty;

		// Token: 0x04000B6E RID: 2926
		public static DependencyProperty PursuitButton2FeatureListProperty;

		// Token: 0x04000B6F RID: 2927
		public static DependencyProperty PursuitButton2IndexIsAcpValidProperty;

		// Token: 0x04000B70 RID: 2928
		public static DependencyProperty PursuitButton2IndexIsAcpApplicableProperty;

		// Token: 0x04000B71 RID: 2929
		public static DependencyProperty PursuitButton2IndexIsAcpVisibleProperty;

		// Token: 0x04000B72 RID: 2930
		public static DependencyProperty PursuitButton2IndexIsAcpEditableProperty;

		// Token: 0x04000B73 RID: 2931
		public static DependencyProperty PursuitButton2IndexUIValueProperty;

		// Token: 0x04000B74 RID: 2932
		public static DependencyProperty PursuitButton2IndexListProperty;

		// Token: 0x04000B75 RID: 2933
		public static DependencyProperty PursuitButton3FeatureIsAcpValidProperty;

		// Token: 0x04000B76 RID: 2934
		public static DependencyProperty PursuitButton3FeatureIsAcpApplicableProperty;

		// Token: 0x04000B77 RID: 2935
		public static DependencyProperty PursuitButton3FeatureIsAcpVisibleProperty;

		// Token: 0x04000B78 RID: 2936
		public static DependencyProperty PursuitButton3FeatureIsAcpEditableProperty;

		// Token: 0x04000B79 RID: 2937
		public static DependencyProperty PursuitButton3FeatureUIValueProperty;

		// Token: 0x04000B7A RID: 2938
		public static DependencyProperty PursuitButton3FeatureListProperty;

		// Token: 0x04000B7B RID: 2939
		public static DependencyProperty PursuitButton3IndexIsAcpValidProperty;

		// Token: 0x04000B7C RID: 2940
		public static DependencyProperty PursuitButton3IndexIsAcpApplicableProperty;

		// Token: 0x04000B7D RID: 2941
		public static DependencyProperty PursuitButton3IndexIsAcpVisibleProperty;

		// Token: 0x04000B7E RID: 2942
		public static DependencyProperty PursuitButton3IndexIsAcpEditableProperty;

		// Token: 0x04000B7F RID: 2943
		public static DependencyProperty PursuitButton3IndexUIValueProperty;

		// Token: 0x04000B80 RID: 2944
		public static DependencyProperty PursuitButton3IndexListProperty;

		// Token: 0x04000B81 RID: 2945
		public static DependencyProperty MenuItemsConventionalSelectedListProperty;

		// Token: 0x04000B82 RID: 2946
		public static DependencyProperty MenuItemsTrunkingSelectedListProperty;

		// Token: 0x04000B83 RID: 2947
		public static DependencyProperty MenuItemsConventionalSelectedListVisibilityProperty;

		// Token: 0x04000B84 RID: 2948
		public static DependencyProperty MenuItemsTrunkingSelectedListVisibilityProperty;

		// Token: 0x04000B85 RID: 2949
		public static DependencyProperty UpButtonIsAcpValidProperty;

		// Token: 0x04000B86 RID: 2950
		public static DependencyProperty UpButtonIsAcpApplicableProperty;

		// Token: 0x04000B87 RID: 2951
		public static DependencyProperty UpButtonIsAcpVisibleProperty;

		// Token: 0x04000B88 RID: 2952
		public static DependencyProperty UpButtonIsAcpEditableProperty;

		// Token: 0x04000B89 RID: 2953
		public static DependencyProperty UpButtonUIValueProperty;

		// Token: 0x04000B8A RID: 2954
		public static DependencyProperty UpButtonListProperty;

		// Token: 0x04000B8B RID: 2955
		public static DependencyProperty DownButtonIsAcpValidProperty;

		// Token: 0x04000B8C RID: 2956
		public static DependencyProperty DownButtonIsAcpApplicableProperty;

		// Token: 0x04000B8D RID: 2957
		public static DependencyProperty DownButtonIsAcpVisibleProperty;

		// Token: 0x04000B8E RID: 2958
		public static DependencyProperty DownButtonIsAcpEditableProperty;

		// Token: 0x04000B8F RID: 2959
		public static DependencyProperty DownButtonUIValueProperty;

		// Token: 0x04000B90 RID: 2960
		public static DependencyProperty DownButtonListProperty;

		// Token: 0x04000B91 RID: 2961
		public static DependencyProperty AirhornButtonFeatureIsAcpValidProperty;

		// Token: 0x04000B92 RID: 2962
		public static DependencyProperty AirhornButtonFeatureIsAcpApplicableProperty;

		// Token: 0x04000B93 RID: 2963
		public static DependencyProperty AirhornButtonFeatureIsAcpVisibleProperty;

		// Token: 0x04000B94 RID: 2964
		public static DependencyProperty AirhornButtonFeatureIsAcpEditableProperty;

		// Token: 0x04000B95 RID: 2965
		public static DependencyProperty AirhornButtonFeatureUIValueProperty;

		// Token: 0x04000B96 RID: 2966
		public static DependencyProperty AirhornButtonFeatureListProperty;

		// Token: 0x04000B97 RID: 2967
		public static DependencyProperty ManualButtonFeatureIsAcpValidProperty;

		// Token: 0x04000B98 RID: 2968
		public static DependencyProperty ManualButtonFeatureIsAcpApplicableProperty;

		// Token: 0x04000B99 RID: 2969
		public static DependencyProperty ManualButtonFeatureIsAcpVisibleProperty;

		// Token: 0x04000B9A RID: 2970
		public static DependencyProperty ManualButtonFeatureIsAcpEditableProperty;

		// Token: 0x04000B9B RID: 2971
		public static DependencyProperty ManualButtonFeatureUIValueProperty;

		// Token: 0x04000B9C RID: 2972
		public static DependencyProperty ManualButtonFeatureListProperty;

		// Token: 0x04000B9D RID: 2973
		public static DependencyProperty WailButtonFeatureIsAcpValidProperty;

		// Token: 0x04000B9E RID: 2974
		public static DependencyProperty WailButtonFeatureIsAcpApplicableProperty;

		// Token: 0x04000B9F RID: 2975
		public static DependencyProperty WailButtonFeatureIsAcpVisibleProperty;

		// Token: 0x04000BA0 RID: 2976
		public static DependencyProperty WailButtonFeatureIsAcpEditableProperty;

		// Token: 0x04000BA1 RID: 2977
		public static DependencyProperty WailButtonFeatureUIValueProperty;

		// Token: 0x04000BA2 RID: 2978
		public static DependencyProperty WailButtonFeatureListProperty;

		// Token: 0x04000BA3 RID: 2979
		public static DependencyProperty YelpButtonFeatureIsAcpValidProperty;

		// Token: 0x04000BA4 RID: 2980
		public static DependencyProperty YelpButtonFeatureIsAcpApplicableProperty;

		// Token: 0x04000BA5 RID: 2981
		public static DependencyProperty YelpButtonFeatureIsAcpVisibleProperty;

		// Token: 0x04000BA6 RID: 2982
		public static DependencyProperty YelpButtonFeatureIsAcpEditableProperty;

		// Token: 0x04000BA7 RID: 2983
		public static DependencyProperty YelpButtonFeatureUIValueProperty;

		// Token: 0x04000BA8 RID: 2984
		public static DependencyProperty YelpButtonFeatureListProperty;

		// Token: 0x04000BA9 RID: 2985
		public static DependencyProperty HiloButtonFeatureIsAcpValidProperty;

		// Token: 0x04000BAA RID: 2986
		public static DependencyProperty HiloButtonFeatureIsAcpApplicableProperty;

		// Token: 0x04000BAB RID: 2987
		public static DependencyProperty HiloButtonFeatureIsAcpVisibleProperty;

		// Token: 0x04000BAC RID: 2988
		public static DependencyProperty HiloButtonFeatureIsAcpEditableProperty;

		// Token: 0x04000BAD RID: 2989
		public static DependencyProperty HiloButtonFeatureUIValueProperty;

		// Token: 0x04000BAE RID: 2990
		public static DependencyProperty HiloButtonFeatureListProperty;

		// Token: 0x04000BAF RID: 2991
		public static DependencyProperty PAButtonFeatureIsAcpValidProperty;

		// Token: 0x04000BB0 RID: 2992
		public static DependencyProperty PAButtonFeatureIsAcpApplicableProperty;

		// Token: 0x04000BB1 RID: 2993
		public static DependencyProperty PAButtonFeatureIsAcpVisibleProperty;

		// Token: 0x04000BB2 RID: 2994
		public static DependencyProperty PAButtonFeatureIsAcpEditableProperty;

		// Token: 0x04000BB3 RID: 2995
		public static DependencyProperty PAButtonFeatureUIValueProperty;

		// Token: 0x04000BB4 RID: 2996
		public static DependencyProperty PAButtonFeatureListProperty;
	}
}
