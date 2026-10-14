using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using AcpBusinessLayer;
using AcpUI;
using ControlHeadGraphicView.converters;

namespace ControlHeadGraphicView
{
	// Token: 0x02000005 RID: 5
	public partial class E5GraphicView : UserControl
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x000407AC File Offset: 0x0003E9AC
		public E5GraphicView()
		{
			this.InitializeComponent();
			base.FlowDirection = FlowDirection.LeftToRight;
			base.DataContext = this;
			this.EmergencyKey_Image.Visibility = Visibility.Collapsed;
			this.UpKey_Image.Visibility = Visibility.Collapsed;
			this.DownKey_Image.Visibility = Visibility.Collapsed;
			this.PKey_Image.Visibility = Visibility.Collapsed;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00040804 File Offset: 0x0003EA04
		public override void EndInit()
		{
			short num = (short)1990766270;
			short num2 = num;
			num = (short)343191230;
			switch (num2 == num)
			{
			}
			num = (short)414580737;
			if (num != 0)
			{
			}
			num = (short)1076035584;
			short num3 = num;
			num = (short)810483712;
			if (num != 0)
			{
			}
			base.EndInit();
			this.SetMenuItems();
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000408BC File Offset: 0x0003EABC
		private void EmergencyKey_OnMouseEnter(object sender, MouseEventArgs e)
		{
			short num = (short)33554433;
			if (num != 0)
			{
			}
			num = (short)1328942483;
			short num2 = num;
			num = (short)381422995;
			switch (num2 == num)
			{
			}
			num = (short)2108817408;
			short num3 = num;
			num = (short)637861888;
			if (num != 0)
			{
			}
			this.EmergencyKey_Image.Visibility = Visibility.Visible;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00040974 File Offset: 0x0003EB74
		private void EmergencyKey_OnMouseLeave(object sender, MouseEventArgs e)
		{
			short num = (short)859132350;
			short num2 = num;
			num = (short)69161406;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1708654592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1927675904;
			if (num != 0)
			{
			}
			num = (short)1536491521;
			if (num != 0)
			{
			}
			this.EmergencyKey_Image.Visibility = Visibility.Collapsed;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00040A28 File Offset: 0x0003EC28
		private void UpKey_OnMouseEnter(object sender, MouseEventArgs e)
		{
			short num = (short)1564649137;
			short num2 = num;
			num = (short)129083057;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1129250816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)728367105;
			if (num != 0)
			{
			}
			num = (short)2029387776;
			if (num != 0)
			{
			}
			this.UpKey_Image.Visibility = Visibility.Visible;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00040ADC File Offset: 0x0003ECDC
		private void UpKey_OnMouseLeave(object sender, MouseEventArgs e)
		{
			short num = (short)1102590010;
			short num2 = num;
			num = (short)1054814266;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1679556608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)259588097;
			if (num != 0)
			{
			}
			num = (short)1026031616;
			if (num != 0)
			{
			}
			this.UpKey_Image.Visibility = Visibility.Collapsed;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00040B90 File Offset: 0x0003ED90
		private void DownKey_OnMouseEnter(object sender, MouseEventArgs e)
		{
			short num = (short)1460666369;
			if (num != 0)
			{
			}
			num = (short)1886126080;
			short num2 = num;
			num = (short)1065071673;
			short num3 = num;
			num = (short)2039854137;
			switch (num3 == num)
			{
			}
			num = (short)871563264;
			if (num != 0)
			{
			}
			this.DownKey_Image.Visibility = Visibility.Visible;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00040C44 File Offset: 0x0003EE44
		private void DownKey_OnMouseLeave(object sender, MouseEventArgs e)
		{
			short num = (short)761039126;
			short num2 = num;
			num = (short)1609074966;
			switch (num2 == num)
			{
			default:
			{
				num = (short)380698624;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2120482816;
			if (num != 0)
			{
			}
			num = (short)1002373121;
			if (num != 0)
			{
			}
			this.DownKey_Image.Visibility = Visibility.Collapsed;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00040CFC File Offset: 0x0003EEFC
		private void PKey_OnMouseEnter(object sender, MouseEventArgs e)
		{
			short num = (short)369397152;
			short num2 = num;
			num = (short)2056424864;
			switch (num2 == num)
			{
			default:
			{
				num = (short)11862016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)929169408;
			if (num != 0)
			{
			}
			num = (short)83755009;
			if (num != 0)
			{
			}
			this.PKey_Image.Visibility = Visibility.Visible;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00040DB4 File Offset: 0x0003EFB4
		private void PKey_OnMouseLeave(object sender, MouseEventArgs e)
		{
			short num = (short)198888304;
			short num2 = num;
			num = (short)447400816;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1870594048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1622933505;
			if (num != 0)
			{
			}
			num = (short)794558464;
			if (num != 0)
			{
			}
			this.PKey_Image.Visibility = Visibility.Collapsed;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00040E6C File Offset: 0x0003F06C
		public void SetMenuItems()
		{
			if (this.MenuItemsConventionalSelectedList == null)
			{
				short num;
				for (;;)
				{
					num = (short)263491507;
					short num2 = num;
					num = (short)914329523;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_41;
					}
				}
				IL_41:
				num = (short)402325504;
				short num3 = num;
				num = (short)610926592;
				if (num != 0)
				{
				}
				num = (short)457965569;
				if (num != 0)
				{
				}
				return;
			}
			Dictionary<int, Label> menuItemsLabels = new Dictionary<int, Label>
			{
				{
					0,
					this.first_menu_item_cnv
				},
				{
					1,
					this.second_menu_item_cnv
				},
				{
					2,
					this.third_menu_item_cnv
				},
				{
					3,
					this.fourth_menu_item_cnv
				},
				{
					4,
					this.fifth_menu_item_cnv
				}
			};
			this.PopulateMenuItems(0, menuItemsLabels, this.MenuItemsConventionalSelectedList);
			Dictionary<int, Label> menuItemsLabels2 = new Dictionary<int, Label>
			{
				{
					0,
					this.first_menu_item_trk
				},
				{
					1,
					this.second_menu_item_trk
				},
				{
					2,
					this.third_menu_item_trk
				},
				{
					3,
					this.fourth_menu_item_trk
				},
				{
					4,
					this.fifth_menu_item_trk
				}
			};
			this.PopulateMenuItems(0, menuItemsLabels2, this.MenuItemsTrunkingSelectedList);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00040FCC File Offset: 0x0003F1CC
		private void NavLeftRight_Click(object sender, RoutedEventArgs e)
		{
			int a_ = 0;
			short num = (short)215678976;
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
				ToggleButton toggleButton;
				Dictionary<int, Label> dictionary;
				Dictionary<int, Label> dictionary2;
				int num3;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (!this.MenuItemsConventionalSelectedList.Visible)
						{
							num = (short)529596418;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_53B;
					case 1:
						goto IL_391;
					case 2:
						goto IL_586;
					case 3:
						if (this.MenuItemsTrunkingSelectedList.Visible)
						{
							num = (short)1342046209;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_11C;
					case 4:
						num = (short)1497432085;
						num2 = (int)((IntPtr)num);
						continue;
					case 5:
						if (toggleButton.Name.Equals(O9GraphicviewMenuItemsVisibilityConverter.b("未䠬䤮䔰焲䀴䌶䴸吺匼", a_)))
						{
							num = (short)595132438;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_11C;
					case 6:
					{
						dictionary = new Dictionary<int, Label>
						{
							{
								0,
								this.first_menu_item_cnv
							},
							{
								1,
								this.second_menu_item_cnv
							},
							{
								2,
								this.third_menu_item_cnv
							},
							{
								3,
								this.fourth_menu_item_cnv
							},
							{
								4,
								this.fifth_menu_item_cnv
							}
						};
						dictionary2 = new Dictionary<int, Label>
						{
							{
								0,
								this.first_menu_item_trk
							},
							{
								1,
								this.second_menu_item_trk
							},
							{
								2,
								this.third_menu_item_trk
							},
							{
								3,
								this.fourth_menu_item_trk
							},
							{
								4,
								this.fifth_menu_item_trk
							}
						};
						int count = this.MenuItemsConventionalSelectedList.Items.Count;
						int count2 = this.MenuItemsTrunkingSelectedList.Items.Count;
						num3 = 5;
						num = (short)2061660741;
						short num4 = num;
						num = (short)41251397;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2CB;
						default:
							num = (short)1929904128;
							if (num != 0)
							{
							}
							num = (short)656998405;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						if (this.MenuItemsTrunkingSelectedList.Visible)
						{
							num = (short)829227027;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 8:
					{
						int count2;
						if ((int)dictionary2[0].Tag + num3 < count2)
						{
							num = (short)1307770900;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 9:
						if (toggleButton.Name.Equals(O9GraphicviewMenuItemsVisibilityConverter.b("礪䐬䠮夰䜲眴䈶䴸伺刼儾", a_)))
						{
							num = (short)1344339984;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 10:
						num = (short)472449027;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
						num = (short)1923022848;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
						if ((int)dictionary2[0].Tag > 0)
						{
							num = (short)1796931594;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_11C;
					case 13:
						goto IL_4E9;
					case 14:
						goto IL_34B;
					case 15:
					{
						int count;
						if ((int)dictionary[0].Tag + num3 < count)
						{
							goto IL_2CB;
						}
						goto IL_4E9;
					}
					case 16:
						num = (short)1251803151;
						num2 = (int)((IntPtr)num);
						continue;
					case 17:
						if ((int)dictionary[0].Tag > 0)
						{
							num = (short)954269696;
							short num5 = num;
							num = (short)176881665;
							if (num != 0)
							{
							}
							num = (short)1495072779;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_586;
					case 18:
						if (toggleButton != null)
						{
							num = (short)1083834374;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 19:
						goto IL_2E9;
					case 20:
						num = (short)2080964615;
						num2 = (int)((IntPtr)num);
						continue;
					case 21:
						if (!this.MenuItemsConventionalSelectedList.Visible)
						{
							num = (short)959971341;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_2E9;
					case 22:
						num = (short)971243537;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_93;
					IL_11C:
					num = (short)1325596681;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2CB:
					num = (short)2123628548;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2E9:
					int index = (int)dictionary[0].Tag + num3;
					int index2 = (int)dictionary2[0].Tag + num3;
					this.PopulateMenuItems(index, dictionary, this.MenuItemsConventionalSelectedList);
					this.PopulateMenuItems(index2, dictionary2, this.MenuItemsTrunkingSelectedList);
					num = (short)1234501646;
					num2 = (int)((IntPtr)num);
					continue;
					IL_4E9:
					num = (short)2043019272;
					num2 = (int)((IntPtr)num);
					continue;
					IL_586:
					num = (short)1799487500;
					num2 = (int)((IntPtr)num);
				}
				IL_34B:
				return;
				IL_391:
				IL_53B:
				int index3 = (int)dictionary[0].Tag - num3;
				int index4 = (int)dictionary2[0].Tag - num3;
				this.PopulateMenuItems(index3, dictionary, this.MenuItemsConventionalSelectedList);
				this.PopulateMenuItems(index4, dictionary2, this.MenuItemsTrunkingSelectedList);
				return;
				IL_93:
				toggleButton = (sender as ToggleButton);
				num = (short)2113077266;
				num2 = (int)((IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x000415AC File Offset: 0x0003F7AC
		private void PopulateMenuItems(int index, Dictionary<int, Label> menuItemsLabels, AcpListField menuItemsList)
		{
			int count = menuItemsList.Items.Count;
			short num;
			using (Dictionary<int, Label>.KeyCollection.Enumerator enumerator = menuItemsLabels.Keys.GetEnumerator())
			{
				num = (short)872742912;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					num = (short)916721254;
					short num3 = num;
					num = (short)1601900134;
					int num4;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1760690176;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_A9;
							}
							continue;
						case 1:
							goto IL_127;
						case 2:
							if (!enumerator.MoveNext())
							{
								num = (short)1183711236;
								num2 = (int)((IntPtr)num);
								continue;
							}
							num4 = enumerator.Current;
							num = (short)1911554055;
							num2 = (int)((IntPtr)num);
							continue;
						case 4:
							num = (short)808189957;
							num2 = (int)((IntPtr)num);
							continue;
						case 5:
							goto IL_1A3;
						case 7:
							if (index + num4 < count)
							{
								num = (short)64421889;
								num2 = (int)((IntPtr)num);
								continue;
							}
							menuItemsLabels[num4].Content = string.Empty;
							num = (short)1565589507;
							num2 = (int)((IntPtr)num);
							continue;
						}
						IL_ED:
						num = (short)1591148546;
						num2 = (int)((IntPtr)num);
						continue;
						IL_A9:
						goto IL_ED;
					}
					IL_127:
					menuItemsLabels[num4].Content = menuItemsList.Items[index + num4].ItemName;
					num = (short)1153433606;
					num2 = (int)((IntPtr)num);
				}
				IL_1A3:;
			}
			num = (short)593690625;
			if (num != 0)
			{
			}
			num = (short)823197696;
			short num5 = num;
			menuItemsLabels[0].Tag = index;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x000417EC File Offset: 0x0003F9EC
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x000418A4 File Offset: 0x0003FAA4
		public bool EmergencyButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)637046290;
				short num2 = num;
				num = (short)1133547026;
				switch (num2 == num)
				{
				}
				num = (short)2125004800;
				short num3 = num;
				num = (short)18612224;
				if (num != 0)
				{
				}
				num = (short)246153217;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(E5GraphicView.EmergencyButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)365806192;
				short num2 = num;
				num = (short)1538638448;
				switch (num2 == num)
				{
				}
				num = (short)259457024;
				short num3 = num;
				num = (short)1643970561;
				if (num != 0)
				{
				}
				num = (short)931659776;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.EmergencyButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0004195C File Offset: 0x0003FB5C
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00041A14 File Offset: 0x0003FC14
		public bool EmergencyButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1964321936;
				short num2 = num;
				num = (short)1936731280;
				switch (num2 == num)
				{
				}
				num = (short)253296640;
				short num3 = num;
				num = (short)702611457;
				if (num != 0)
				{
				}
				num = (short)1952776192;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(E5GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)328617816;
				short num2 = num;
				num = (short)799821656;
				switch (num2 == num)
				{
				}
				num = (short)2017984512;
				short num3 = num;
				num = (short)1355087873;
				if (num != 0)
				{
				}
				num = (short)83558400;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00041AD0 File Offset: 0x0003FCD0
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00041B8C File Offset: 0x0003FD8C
		public bool EmergencyButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1668513006;
				short num2 = num;
				num = (short)1425439982;
				switch (num2 == num)
				{
				}
				num = (short)567279616;
				short num3 = num;
				num = (short)328663041;
				if (num != 0)
				{
				}
				num = (short)1457324032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(E5GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)950380674;
				short num2 = num;
				num = (short)1455401090;
				switch (num2 == num)
				{
				}
				num = (short)1229717504;
				short num3 = num;
				num = (short)684195841;
				if (num != 0)
				{
				}
				num = (short)517996544;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00041C48 File Offset: 0x0003FE48
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x00041D04 File Offset: 0x0003FF04
		public bool EmergencyButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1503525544;
				short num2 = num;
				num = (short)993458856;
				switch (num2 == num)
				{
				}
				num = (short)1403584512;
				short num3 = num;
				num = (short)1715863552;
				if (num != 0)
				{
				}
				num = (short)743178241;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(E5GraphicView.EmergencyButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)860987919;
				short num2 = num;
				num = (short)1398907407;
				switch (num2 == num)
				{
				}
				num = (short)427819008;
				short num3 = num;
				num = (short)1329135617;
				if (num != 0)
				{
				}
				num = (short)1868496896;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.EmergencyButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00041DC0 File Offset: 0x0003FFC0
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00041E74 File Offset: 0x00040074
		public string EmergencyButtonFeatureUIValue
		{
			get
			{
				short num = (short)1650262017;
				if (num != 0)
				{
				}
				num = (short)795285607;
				short num2 = num;
				num = (short)1331894375;
				switch (num2 == num)
				{
				default:
				{
					num = (short)832569344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)298582016;
				if (num != 0)
				{
				}
				return (string)base.GetValue(E5GraphicView.EmergencyButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)679376452;
				short num2 = num;
				num = (short)237467204;
				switch (num2 == num)
				{
				}
				num = (short)1954873344;
				short num3 = num;
				num = (short)893255681;
				if (num != 0)
				{
				}
				num = (short)568262656;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.EmergencyButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00041F2C File Offset: 0x0004012C
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00041FE8 File Offset: 0x000401E8
		public AcpListField EmergencyButtonFeatureList
		{
			get
			{
				short num = (short)56604684;
				short num2 = num;
				num = (short)2088876044;
				switch (num2 == num)
				{
				}
				num = (short)997523456;
				short num3 = num;
				num = (short)504561665;
				if (num != 0)
				{
				}
				num = (short)1494417408;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(E5GraphicView.EmergencyButtonFeatureListProperty);
			}
			set
			{
				short num = (short)744924352;
				short num2 = num;
				num = (short)427336896;
				switch (num2 == num)
				{
				}
				num = (short)604307456;
				short num3 = num;
				num = (short)1593966593;
				if (num != 0)
				{
				}
				num = (short)450560000;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.EmergencyButtonFeatureListProperty, value);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0004209C File Offset: 0x0004029C
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00042158 File Offset: 0x00040358
		public bool UpButtonIsAcpValid
		{
			get
			{
				short num = (short)2064921748;
				short num2 = num;
				num = (short)509752468;
				switch (num2 == num)
				{
				}
				num = (short)842334208;
				short num3 = num;
				num = (short)1608253440;
				if (num != 0)
				{
				}
				num = (short)1423507457;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(E5GraphicView.UpButtonIsAcpValidProperty);
			}
			set
			{
				short num = (short)1547650797;
				short num2 = num;
				num = (short)1117013741;
				switch (num2 == num)
				{
				}
				num = (short)748683264;
				short num3 = num;
				num = (short)2143485952;
				if (num != 0)
				{
				}
				num = (short)1325334529;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.UpButtonIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00042210 File Offset: 0x00040410
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x000422CC File Offset: 0x000404CC
		public bool UpButtonIsAcpApplicable
		{
			get
			{
				short num = (short)1847660208;
				short num2 = num;
				num = (short)1737887408;
				switch (num2 == num)
				{
				}
				num = (short)1363345408;
				short num3 = num;
				num = (short)201850881;
				if (num != 0)
				{
				}
				num = (short)108658688;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(E5GraphicView.UpButtonIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)766771201;
				if (num != 0)
				{
				}
				num = (short)647373630;
				short num2 = num;
				num = (short)1173103422;
				switch (num2 == num)
				{
				default:
				{
					num = (short)985399296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)595787776;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.UpButtonIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00042384 File Offset: 0x00040584
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x0004243C File Offset: 0x0004063C
		public bool UpButtonIsAcpVisible
		{
			get
			{
				short num = (short)1533081752;
				short num2 = num;
				num = (short)1803286680;
				switch (num2 == num)
				{
				}
				num = (short)991887360;
				short num3 = num;
				num = (short)1991573504;
				if (num != 0)
				{
				}
				num = (short)463470593;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(E5GraphicView.UpButtonIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1717123242;
				short num2 = num;
				num = (short)1924806826;
				switch (num2 == num)
				{
				}
				num = (short)138739712;
				short num3 = num;
				num = (short)1625620481;
				if (num != 0)
				{
				}
				num = (short)157483008;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.UpButtonIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x000424F8 File Offset: 0x000406F8
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x000425B0 File Offset: 0x000407B0
		public bool UpButtonIsAcpEditable
		{
			get
			{
				short num = (short)557991533;
				short num2 = num;
				num = (short)937379437;
				switch (num2 == num)
				{
				}
				num = (short)690946048;
				short num3 = num;
				num = (short)976814080;
				if (num != 0)
				{
				}
				num = (short)192675841;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(E5GraphicView.UpButtonIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1102583931;
				short num2 = num;
				num = (short)1923094651;
				switch (num2 == num)
				{
				}
				num = (short)1546584064;
				short num3 = num;
				num = (short)859832321;
				if (num != 0)
				{
				}
				num = (short)719060992;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.UpButtonIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0004266C File Offset: 0x0004086C
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00042728 File Offset: 0x00040928
		public string UpButtonUIValue
		{
			get
			{
				short num = (short)1264096562;
				short num2 = num;
				num = (short)761763122;
				switch (num2 == num)
				{
				}
				num = (short)2024996864;
				short num3 = num;
				num = (short)1833435137;
				if (num != 0)
				{
				}
				num = (short)536608768;
				if (num != 0)
				{
				}
				return (string)base.GetValue(E5GraphicView.UpButtonUIValueProperty);
			}
			set
			{
				short num = (short)1863255641;
				short num2 = num;
				num = (short)1187382873;
				switch (num2 == num)
				{
				}
				num = (short)1085472768;
				short num3 = num;
				num = (short)286326785;
				if (num != 0)
				{
				}
				num = (short)1472659456;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.UpButtonUIValueProperty, value);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x000427E0 File Offset: 0x000409E0
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00042898 File Offset: 0x00040A98
		public AcpListField UpButtonList
		{
			get
			{
				short num = (short)1484849153;
				if (num != 0)
				{
				}
				num = (short)455487614;
				short num2 = num;
				num = (short)336343166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1225654272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)412352512;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(E5GraphicView.UpButtonListProperty);
			}
			set
			{
				short num = (short)1281220261;
				short num2 = num;
				num = (short)2070273701;
				switch (num2 == num)
				{
				}
				num = (short)1699086336;
				short num3 = num;
				num = (short)874643456;
				if (num != 0)
				{
				}
				num = (short)1272446977;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.UpButtonListProperty, value);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0004294C File Offset: 0x00040B4C
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00042A04 File Offset: 0x00040C04
		public bool DownButtonIsAcpValid
		{
			get
			{
				short num = (short)581173249;
				if (num != 0)
				{
				}
				num = (short)1358854422;
				short num2 = num;
				num = (short)1241413910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1799487488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)524353536;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(E5GraphicView.DownButtonIsAcpValidProperty);
			}
			set
			{
				short num = (short)346280784;
				short num2 = num;
				num = (short)1847186256;
				switch (num2 == num)
				{
				}
				num = (short)462487552;
				short num3 = num;
				num = (short)85000193;
				if (num != 0)
				{
				}
				num = (short)1343619072;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.DownButtonIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00042ABC File Offset: 0x00040CBC
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00042B74 File Offset: 0x00040D74
		public bool DownButtonIsAcpApplicable
		{
			get
			{
				short num = (short)1909063112;
				short num2 = num;
				num = (short)481623496;
				switch (num2 == num)
				{
				}
				num = (short)1640562688;
				short num3 = num;
				num = (short)98828289;
				if (num != 0)
				{
				}
				num = (short)702349312;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(E5GraphicView.DownButtonIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2019093433;
				short num2 = num;
				num = (short)2058480569;
				switch (num2 == num)
				{
				}
				num = (short)618987520;
				short num3 = num;
				num = (short)810680321;
				if (num != 0)
				{
				}
				num = (short)1628504064;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.DownButtonIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00042C2C File Offset: 0x00040E2C
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00042CE8 File Offset: 0x00040EE8
		public bool DownButtonIsAcpVisible
		{
			get
			{
				short num = (short)89621066;
				short num2 = num;
				num = (short)744849994;
				switch (num2 == num)
				{
				}
				num = (short)1020133376;
				short num3 = num;
				num = (short)1794441216;
				if (num != 0)
				{
				}
				num = (short)1358561281;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(E5GraphicView.DownButtonIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)760620836;
				short num2 = num;
				num = (short)1325672228;
				switch (num2 == num)
				{
				}
				num = (short)1025048576;
				short num3 = num;
				num = (short)1674772481;
				if (num != 0)
				{
				}
				num = (short)168230912;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.DownButtonIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00042DA4 File Offset: 0x00040FA4
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00042E5C File Offset: 0x0004105C
		public bool DownButtonIsAcpEditable
		{
			get
			{
				short num = (short)1803939265;
				short num2 = num;
				num = (short)1547431361;
				switch (num2 == num)
				{
				}
				num = (short)410320896;
				short num3 = num;
				num = (short)1855193089;
				if (num != 0)
				{
				}
				num = (short)1691353088;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(E5GraphicView.DownButtonIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1109524481;
				if (num != 0)
				{
				}
				num = (short)622490315;
				short num2 = num;
				num = (short)55800523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1800929280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1287258112;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.DownButtonIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00042F14 File Offset: 0x00041114
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00042FCC File Offset: 0x000411CC
		public string DownButtonUIValue
		{
			get
			{
				short num = (short)666894337;
				if (num != 0)
				{
				}
				num = (short)1305092604;
				short num2 = num;
				num = (short)429400572;
				switch (num2 == num)
				{
				default:
				{
					num = (short)533725184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)28901376;
				if (num != 0)
				{
				}
				return (string)base.GetValue(E5GraphicView.DownButtonUIValueProperty);
			}
			set
			{
				short num = (short)2000382863;
				short num2 = num;
				num = (short)2017356687;
				switch (num2 == num)
				{
				}
				num = (short)1212219392;
				short num3 = num;
				num = (short)1070268417;
				if (num != 0)
				{
				}
				num = (short)862257152;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.DownButtonUIValueProperty, value);
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00043084 File Offset: 0x00041284
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x0004313C File Offset: 0x0004133C
		public AcpListField DownButtonList
		{
			get
			{
				short num = (short)326696961;
				if (num != 0)
				{
				}
				num = (short)57619228;
				short num2 = num;
				num = (short)48640796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1655439360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1018101760;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(E5GraphicView.DownButtonListProperty);
			}
			set
			{
				short num = (short)119263975;
				short num2 = num;
				num = (short)597021415;
				switch (num2 == num)
				{
				}
				num = (short)248446976;
				short num3 = num;
				num = (short)1878327297;
				if (num != 0)
				{
				}
				num = (short)275316736;
				if (num != 0)
				{
				}
				base.SetValue(E5GraphicView.DownButtonListProperty, value);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x000431F0 File Offset: 0x000413F0
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x000432A8 File Offset: 0x000414A8
		public bool BottomButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)2122287443;
				short num2 = num;
				num = (short)662210899;
				switch (num2 == num)
				{
				}
				num = (short)302710784;
				if (num != 0)
				{
				}
				num = (short)432865281;
				if (num != 0)
				{
				}
				num = (short)1437007872;
				short num3 = num;
				return (bool)base.GetValue(E5GraphicView.BottomButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1835592244;
				short num2 = num;
				num = (short)180218420;
				switch (num2 == num)
				{
				}
				num = (short)463536129;
				if (num != 0)
				{
				}
				num = (short)453640192;
				if (num != 0)
				{
				}
				num = (short)692912128;
				short num3 = num;
				base.SetValue(E5GraphicView.BottomButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00043360 File Offset: 0x00041560
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x0004341C File Offset: 0x0004161C
		public bool BottomButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)249231553;
				short num2 = num;
				num = (short)376174785;
				switch (num2 == num)
				{
				}
				num = (short)2019098625;
				if (num != 0)
				{
				}
				num = (short)1802240000;
				if (num != 0)
				{
				}
				num = (short)435421184;
				short num3 = num;
				return (bool)base.GetValue(E5GraphicView.BottomButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)28770681;
				short num2 = num;
				num = (short)1947074937;
				switch (num2 == num)
				{
				}
				num = (short)1314914304;
				if (num != 0)
				{
				}
				num = (short)165609473;
				if (num != 0)
				{
				}
				num = (short)179765248;
				short num3 = num;
				base.SetValue(E5GraphicView.BottomButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x000434D4 File Offset: 0x000416D4
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00043594 File Offset: 0x00041794
		public bool BottomButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)587403611;
				short num2 = num;
				num = (short)1557336411;
				switch (num2 == num)
				{
				}
				num = (short)2080964608;
				if (num != 0)
				{
				}
				num = (short)898039809;
				if (num != 0)
				{
				}
				num = (short)1703346176;
				short num3 = num;
				return (bool)base.GetValue(E5GraphicView.BottomButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1072052080;
				short num2 = num;
				num = (short)853358448;
				switch (num2 == num)
				{
				}
				num = (short)95944705;
				if (num != 0)
				{
				}
				num = (short)1006632960;
				if (num != 0)
				{
				}
				num = (short)1178730496;
				short num3 = num;
				base.SetValue(E5GraphicView.BottomButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00043650 File Offset: 0x00041850
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x0004370C File Offset: 0x0004190C
		public bool BottomButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)260201660;
				short num2 = num;
				num = (short)1408064700;
				switch (num2 == num)
				{
				}
				num = (short)1890713601;
				if (num != 0)
				{
				}
				num = (short)1649147904;
				if (num != 0)
				{
				}
				num = (short)1398800384;
				short num3 = num;
				return (bool)base.GetValue(E5GraphicView.BottomButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1433811066;
				short num2 = num;
				num = (short)281163898;
				switch (num2 == num)
				{
				}
				num = (short)1375141889;
				if (num != 0)
				{
				}
				num = (short)1761148928;
				if (num != 0)
				{
				}
				num = (short)1898446848;
				short num3 = num;
				base.SetValue(E5GraphicView.BottomButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x000437C8 File Offset: 0x000419C8
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00043880 File Offset: 0x00041A80
		public string BottomButtonFeatureUIValue
		{
			get
			{
				short num = (short)2034849158;
				short num2 = num;
				num = (short)1379947910;
				switch (num2 == num)
				{
				}
				num = (short)1278607360;
				if (num != 0)
				{
				}
				num = (short)1068105729;
				if (num != 0)
				{
				}
				num = (short)1541996544;
				short num3 = num;
				return (string)base.GetValue(E5GraphicView.BottomButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1257549053;
				short num2 = num;
				num = (short)385527037;
				switch (num2 == num)
				{
				}
				num = (short)1608384513;
				if (num != 0)
				{
				}
				num = (short)428539904;
				if (num != 0)
				{
				}
				num = (short)612237312;
				short num3 = num;
				base.SetValue(E5GraphicView.BottomButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0004393C File Offset: 0x00041B3C
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x000439F8 File Offset: 0x00041BF8
		public AcpListField BottomButtonFeatureList
		{
			get
			{
				short num = (short)209482269;
				short num2 = num;
				num = (short)1610904093;
				switch (num2 == num)
				{
				}
				num = (short)1088880641;
				if (num != 0)
				{
				}
				num = (short)159186944;
				if (num != 0)
				{
				}
				num = (short)1184956416;
				short num3 = num;
				return (AcpListField)base.GetValue(E5GraphicView.BottomButtonFeatureListProperty);
			}
			set
			{
				short num = (short)295758156;
				short num2 = num;
				num = (short)355526988;
				switch (num2 == num)
				{
				}
				num = (short)21364736;
				if (num != 0)
				{
				}
				num = (short)1606352897;
				if (num != 0)
				{
				}
				num = (short)87228416;
				short num3 = num;
				base.SetValue(E5GraphicView.BottomButtonFeatureListProperty, value);
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00043AAC File Offset: 0x00041CAC
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00043B68 File Offset: 0x00041D68
		public bool BottomButtonIndexIsAcpValid
		{
			get
			{
				short num = (short)1981326728;
				short num2 = num;
				num = (short)848536968;
				switch (num2 == num)
				{
				}
				num = (short)1770192896;
				if (num != 0)
				{
				}
				num = (short)1279852545;
				if (num != 0)
				{
				}
				num = (short)1744961536;
				short num3 = num;
				return (bool)base.GetValue(E5GraphicView.BottomButtonIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)760047064;
				short num2 = num;
				num = (short)739534296;
				switch (num2 == num)
				{
				}
				num = (short)172752896;
				if (num != 0)
				{
				}
				num = (short)66650113;
				if (num != 0)
				{
				}
				num = (short)901382144;
				short num3 = num;
				base.SetValue(E5GraphicView.BottomButtonIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00043C20 File Offset: 0x00041E20
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00043CDC File Offset: 0x00041EDC
		public bool BottomButtonIndexIsAcpApplicable
		{
			get
			{
				short num = (short)125932807;
				short num2 = num;
				num = (short)1377539335;
				switch (num2 == num)
				{
				}
				num = (short)1061814272;
				if (num != 0)
				{
				}
				num = (short)775159809;
				if (num != 0)
				{
				}
				num = (short)1993015296;
				short num3 = num;
				return (bool)base.GetValue(E5GraphicView.BottomButtonIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1266810881;
				if (num != 0)
				{
				}
				num = (short)101683909;
				short num2 = num;
				num = (short)1073648325;
				switch (num2 == num)
				{
				}
				num = (short)1627455488;
				if (num != 0)
				{
				}
				num = (short)749797376;
				short num3 = num;
				base.SetValue(E5GraphicView.BottomButtonIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00043D98 File Offset: 0x00041F98
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00043E54 File Offset: 0x00042054
		public bool BottomButtonIndexIsAcpVisible
		{
			get
			{
				short num = (short)1913978881;
				if (num != 0)
				{
				}
				num = (short)675170629;
				short num2 = num;
				num = (short)872892741;
				switch (num2 == num)
				{
				}
				num = (short)1989541888;
				if (num != 0)
				{
				}
				num = (short)1188823040;
				short num3 = num;
				return (bool)base.GetValue(E5GraphicView.BottomButtonIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)774766593;
				if (num != 0)
				{
				}
				num = (short)698374602;
				short num2 = num;
				num = (short)2101303754;
				switch (num2 == num)
				{
				}
				num = (short)920387584;
				if (num != 0)
				{
				}
				num = (short)1363869696;
				short num3 = num;
				base.SetValue(E5GraphicView.BottomButtonIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00043F10 File Offset: 0x00042110
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00043FC8 File Offset: 0x000421C8
		public bool BottomButtonIndexIsAcpEditable
		{
			get
			{
				short num = (short)1270380851;
				short num2 = num;
				num = (short)48134451;
				switch (num2 == num)
				{
				}
				num = (short)756744193;
				if (num != 0)
				{
				}
				num = (short)1711144960;
				if (num != 0)
				{
				}
				num = (short)252706816;
				short num3 = num;
				return (bool)base.GetValue(E5GraphicView.BottomButtonIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1754040248;
				short num2 = num;
				num = (short)1705347000;
				switch (num2 == num)
				{
				}
				num = (short)103743489;
				if (num != 0)
				{
				}
				num = (short)1993211904;
				if (num != 0)
				{
				}
				num = (short)18939904;
				short num3 = num;
				base.SetValue(E5GraphicView.BottomButtonIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00044084 File Offset: 0x00042284
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x0004413C File Offset: 0x0004233C
		public string BottomButtonIndexUIValue
		{
			get
			{
				short num = (short)402625010;
				short num2 = num;
				num = (short)1342476786;
				switch (num2 == num)
				{
				}
				num = (short)723714049;
				if (num != 0)
				{
				}
				num = (short)593231872;
				if (num != 0)
				{
				}
				num = (short)1836777472;
				short num3 = num;
				return (string)base.GetValue(E5GraphicView.BottomButtonIndexUIValueProperty);
			}
			set
			{
				short num = (short)1735675371;
				short num2 = num;
				num = (short)1476742635;
				switch (num2 == num)
				{
				}
				num = (short)996540417;
				if (num != 0)
				{
				}
				num = (short)1608712192;
				if (num != 0)
				{
				}
				num = (short)1724907520;
				short num3 = num;
				base.SetValue(E5GraphicView.BottomButtonIndexUIValueProperty, value);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x000441F0 File Offset: 0x000423F0
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x000442A8 File Offset: 0x000424A8
		public AcpRecRefField BottomButtonIndexList
		{
			get
			{
				short num = (short)1280562753;
				short num2 = num;
				num = (short)1913771585;
				switch (num2 == num)
				{
				}
				num = (short)1094778881;
				if (num != 0)
				{
				}
				num = (short)222691328;
				if (num != 0)
				{
				}
				num = (short)1360003072;
				short num3 = num;
				return (AcpRecRefField)base.GetValue(E5GraphicView.BottomButtonIndexListProperty);
			}
			set
			{
				short num = (short)14723485;
				short num2 = num;
				num = (short)2070260125;
				switch (num2 == num)
				{
				}
				num = (short)29425665;
				if (num != 0)
				{
				}
				num = (short)1843789824;
				if (num != 0)
				{
				}
				num = (short)1810038784;
				short num3 = num;
				base.SetValue(E5GraphicView.BottomButtonIndexListProperty, value);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0004435C File Offset: 0x0004255C
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00044414 File Offset: 0x00042614
		public AcpListField MenuItemsConventionalSelectedList
		{
			get
			{
				short num = (short)99461817;
				short num2 = num;
				num = (short)619948729;
				switch (num2 == num)
				{
				}
				num = (short)841678849;
				if (num != 0)
				{
				}
				num = (short)585891840;
				if (num != 0)
				{
				}
				num = (short)1943142400;
				short num3 = num;
				return (AcpListField)base.GetValue(E5GraphicView.MenuItemsConventionalSelectedListProperty);
			}
			set
			{
				short num = (short)1026887406;
				short num2 = num;
				num = (short)158404334;
				switch (num2 == num)
				{
				}
				num = (short)807796737;
				if (num != 0)
				{
				}
				num = (short)1695612928;
				if (num != 0)
				{
				}
				num = (short)154533888;
				short num3 = num;
				base.SetValue(E5GraphicView.MenuItemsConventionalSelectedListProperty, value);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x000444CC File Offset: 0x000426CC
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0004458C File Offset: 0x0004278C
		public AcpListField MenuItemsTrunkingSelectedList
		{
			get
			{
				short num = (short)1069293508;
				short num2 = num;
				num = (short)442376132;
				switch (num2 == num)
				{
				}
				num = (short)595132417;
				if (num != 0)
				{
				}
				num = (short)1768030208;
				if (num != 0)
				{
				}
				num = (short)1908736000;
				short num3 = num;
				return (AcpListField)base.GetValue(E5GraphicView.MenuItemsTrunkingSelectedListProperty);
			}
			set
			{
				short num = (short)548401475;
				short num2 = num;
				num = (short)756281667;
				switch (num2 == num)
				{
				}
				num = (short)75890689;
				if (num != 0)
				{
				}
				num = (short)1682178048;
				if (num != 0)
				{
				}
				num = (short)1266679808;
				short num3 = num;
				base.SetValue(E5GraphicView.MenuItemsTrunkingSelectedListProperty, value);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00044640 File Offset: 0x00042840
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x000446FC File Offset: 0x000428FC
		public bool MenuItemsConventionalSelectedListVisibility
		{
			get
			{
				short num = (short)1726611457;
				if (num != 0)
				{
				}
				num = (short)1431472258;
				short num2 = num;
				num = (short)225282178;
				switch (num2 == num)
				{
				}
				num = (short)1311834112;
				if (num != 0)
				{
				}
				num = (short)1145569280;
				short num3 = num;
				return (bool)base.GetValue(E5GraphicView.MenuItemsConventionalSelectedListVisibilityProperty);
			}
			set
			{
				short num = (short)1510294849;
				short num2 = num;
				num = (short)841368897;
				switch (num2 == num)
				{
				}
				num = (short)1264844801;
				if (num != 0)
				{
				}
				num = (short)1492451328;
				if (num != 0)
				{
				}
				num = (short)778502144;
				short num3 = num;
				base.SetValue(E5GraphicView.MenuItemsConventionalSelectedListVisibilityProperty, value);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x000447B8 File Offset: 0x000429B8
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00044874 File Offset: 0x00042A74
		public bool MenuItemsTrunkingSelectedListVisibility
		{
			get
			{
				short num = (short)1865974468;
				short num2 = num;
				num = (short)1438679748;
				switch (num2 == num)
				{
				}
				num = (short)2116026369;
				if (num != 0)
				{
				}
				num = (short)39124992;
				if (num != 0)
				{
				}
				num = (short)1476198400;
				short num3 = num;
				return (bool)base.GetValue(E5GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty);
			}
			set
			{
				short num = (short)348768517;
				short num2 = num;
				num = (short)49465605;
				switch (num2 == num)
				{
				}
				num = (short)1218904065;
				if (num != 0)
				{
				}
				num = (short)2103377920;
				if (num != 0)
				{
				}
				num = (short)1647640576;
				short num3 = num;
				base.SetValue(E5GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty, value);
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000451FC File Offset: 0x000433FC
		// Note: this type is marked as 'beforefieldinit'.
		static E5GraphicView()
		{
			int a_ = 1;
			short num = (short)330039297;
			if (num != 0)
			{
			}
			num = (short)422222314;
			short num2 = num;
			num = (short)1357748714;
			switch (num2 == num)
			{
			}
			num = (short)78118912;
			if (num != 0)
			{
			}
			num = (short)1846280192;
			short num3 = num;
			E5GraphicView.EmergencyButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椫䌭唯䀱匳匵嘷夹䔻簽㔿㙁ぃ⥅♇౉⥋⽍⑏❑♓㍕ᅗ⥙ᵛ㵝ၟ㑡գ੥ŧ๩", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.EmergencyButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椫䌭唯䀱匳匵嘷夹䔻簽㔿㙁ぃ⥅♇౉⥋⽍⑏❑♓㍕ᅗ⥙ᵛ㵝ၟ⍡ᑣᙥѧͩཫ཭ቯṱᅳ", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.EmergencyButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椫䌭唯䀱匳匵嘷夹䔻簽㔿㙁ぃ⥅♇౉⥋⽍⑏❑♓㍕ᅗ⥙ᵛ㵝ၟ㑡ൣᕥŧࡩk୭", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.EmergencyButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椫䌭唯䀱匳匵嘷夹䔻簽㔿㙁ぃ⥅♇౉⥋⽍⑏❑♓㍕ᅗ⥙ᵛ㵝ၟ❡cཥᱧ୩๫ɭᕯ", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.EmergencyButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椫䌭唯䀱匳匵嘷夹䔻簽㔿㙁ぃ⥅♇౉⥋⽍⑏❑♓㍕ൗፙਜ਼㽝౟ᝡţ", a_), typeof(string), typeof(E5GraphicView));
			E5GraphicView.EmergencyButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("椫䌭唯䀱匳匵嘷夹䔻簽㔿㙁ぃ⥅♇౉⥋⽍⑏❑♓㍕ᑗ㍙⽛⩝", a_), typeof(AcpListField), typeof(E5GraphicView));
			E5GraphicView.UpButtonIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礫席爯䜱䀳䈵圷吹画䴽Ŀ⅁㑃၅⥇♉╋⩍", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.UpButtonIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礫席爯䜱䀳䈵圷吹画䴽Ŀ⅁㑃݅㡇㩉⁋❍㍏㍑㙓㩕㵗", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.UpButtonIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礫席爯䜱䀳䈵圷吹画䴽Ŀ⅁㑃၅ⅇ㥉╋ⱍ㱏㝑", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.UpButtonIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礫席爯䜱䀳䈵圷吹画䴽Ŀ⅁㑃ͅⱇ⍉㡋⽍㉏㹑ㅓ", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.UpButtonUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礫席爯䜱䀳䈵圷吹椻眽ᘿ⍁⡃㍅ⵇ", a_), typeof(string), typeof(E5GraphicView));
			E5GraphicView.UpButtonListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("礫席爯䜱䀳䈵圷吹瀻圽㌿㙁", a_), typeof(AcpListField), typeof(E5GraphicView));
			E5GraphicView.DownButtonIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("栫䄭䜯就瘳䌵䰷丹医倽िㅁՃ╅㡇᱉ⵋ≍㥏㙑", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.DownButtonIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("栫䄭䜯就瘳䌵䰷丹医倽िㅁՃ╅㡇୉㱋㹍㱏㭑㝓㝕㩗㙙㥛", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.DownButtonIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("栫䄭䜯就瘳䌵䰷丹医倽िㅁՃ╅㡇᱉╋㵍㥏け㡓㍕", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.DownButtonIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("栫䄭䜯就瘳䌵䰷丹医倽िㅁՃ╅㡇ཉ⡋❍⑏㍑㙓㩕㵗", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.DownButtonUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("栫䄭䜯就瘳䌵䰷丹医倽ᔿୁቃ❅⑇㽉⥋", a_), typeof(string), typeof(E5GraphicView));
			E5GraphicView.DownButtonListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("栫䄭䜯就瘳䌵䰷丹医倽ి⭁㝃㉅", a_), typeof(AcpListField), typeof(E5GraphicView));
			E5GraphicView.BottomButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渫䄭䐯䘱嬳嬵稷伹䠻䨽⼿ⱁɃ⍅⥇㹉㥋㱍㕏᭑❓᝕㭗⩙ਜ਼㽝౟ୡc", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.BottomButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渫䄭䐯䘱嬳嬵稷伹䠻䨽⼿ⱁɃ⍅⥇㹉㥋㱍㕏᭑❓᝕㭗⩙ᵛ⹝ၟ๡ൣե१ࡩk୭", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.BottomButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渫䄭䐯䘱嬳嬵稷伹䠻䨽⼿ⱁɃ⍅⥇㹉㥋㱍㕏᭑❓᝕㭗⩙ਜ਼㝝፟ୡ٣੥൧", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.BottomButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渫䄭䐯䘱嬳嬵稷伹䠻䨽⼿ⱁɃ⍅⥇㹉㥋㱍㕏᭑❓᝕㭗⩙ᥛ㩝य़ᙡգѥѧཀྵ", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.BottomButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渫䄭䐯䘱嬳嬵稷伹䠻䨽⼿ⱁɃ⍅⥇㹉㥋㱍㕏ݑᵓU㥗㙙⥛㭝", a_), typeof(string), typeof(E5GraphicView));
			E5GraphicView.BottomButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渫䄭䐯䘱嬳嬵稷伹䠻䨽⼿ⱁɃ⍅⥇㹉㥋㱍㕏ṑ㵓╕ⱗ", a_), typeof(AcpListField), typeof(E5GraphicView));
			E5GraphicView.BottomButtonIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渫䄭䐯䘱嬳嬵稷伹䠻䨽⼿ⱁൃ⡅ⱇ⽉㑋ݍ⍏ፑ㝓♕๗㭙せ㝝џ", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.BottomButtonIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渫䄭䐯䘱嬳嬵稷伹䠻䨽⼿ⱁൃ⡅ⱇ⽉㑋ݍ⍏ፑ㝓♕ᥗ⩙ⱛ㉝य़šգѥѧཀྵ", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.BottomButtonIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渫䄭䐯䘱嬳嬵稷伹䠻䨽⼿ⱁൃ⡅ⱇ⽉㑋ݍ⍏ፑ㝓♕๗㍙⽛㝝ɟ๡ţ", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.BottomButtonIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渫䄭䐯䘱嬳嬵稷伹䠻䨽⼿ⱁൃ⡅ⱇ⽉㑋ݍ⍏ፑ㝓♕ᵗ㹙㕛⩝şaࡣͥ", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.BottomButtonIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渫䄭䐯䘱嬳嬵稷伹䠻䨽⼿ⱁൃ⡅ⱇ⽉㑋᭍᥏ё㕓㩕ⵗ㽙", a_), typeof(string), typeof(E5GraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			E5GraphicView.BottomButtonIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渫䄭䐯䘱嬳嬵稷伹䠻䨽⼿ⱁൃ⡅ⱇ⽉㑋ɍ㥏⅑⁓", a_), typeof(AcpRecRefField), typeof(E5GraphicView), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			E5GraphicView.MenuItemsConventionalSelectedListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愫䬭帯䜱紳䈵崷圹伻紽⼿ⱁ㉃⍅♇㹉╋⅍㹏㍑㡓Օ㵗㙙㥛㵝ᑟݡc⩥ŧᥩᡫ", a_), typeof(AcpListField), typeof(E5GraphicView));
			E5GraphicView.MenuItemsTrunkingSelectedListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愫䬭帯䜱紳䈵崷圹伻樽㈿㝁⩃ⵅⅇ⑉⭋ᵍ㕏㹑ㅓ㕕ⱗ㽙㡛ቝय़ᅡၣ", a_), typeof(AcpListField), typeof(E5GraphicView));
			E5GraphicView.MenuItemsConventionalSelectedListVisibilityProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愫䬭帯䜱紳䈵崷圹伻紽⼿ⱁ㉃⍅♇㹉╋⅍㹏㍑㡓Օ㵗㙙㥛㵝ᑟݡc⩥ŧᥩᡫ㡭᥯űᵳᑵᅷᙹᕻ੽勵", a_), typeof(bool), typeof(E5GraphicView));
			E5GraphicView.MenuItemsTrunkingSelectedListVisibilityProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("愫䬭帯䜱紳䈵崷圹伻樽㈿㝁⩃ⵅⅇ⑉⭋ᵍ㕏㹑ㅓ㕕ⱗ㽙㡛ቝय़ᅡၣづŧᥩի౭᥯ṱᵳɵŷ", a_), typeof(bool), typeof(E5GraphicView));
		}

		// Token: 0x040004D5 RID: 1237
		public static DependencyProperty EmergencyButtonFeatureIsAcpValidProperty;

		// Token: 0x040004D6 RID: 1238
		public static DependencyProperty EmergencyButtonFeatureIsAcpApplicableProperty;

		// Token: 0x040004D7 RID: 1239
		public static DependencyProperty EmergencyButtonFeatureIsAcpVisibleProperty;

		// Token: 0x040004D8 RID: 1240
		public static DependencyProperty EmergencyButtonFeatureIsAcpEditableProperty;

		// Token: 0x040004D9 RID: 1241
		public static DependencyProperty EmergencyButtonFeatureUIValueProperty;

		// Token: 0x040004DA RID: 1242
		public static DependencyProperty EmergencyButtonFeatureListProperty;

		// Token: 0x040004DB RID: 1243
		public static DependencyProperty UpButtonIsAcpValidProperty;

		// Token: 0x040004DC RID: 1244
		public static DependencyProperty UpButtonIsAcpApplicableProperty;

		// Token: 0x040004DD RID: 1245
		public static DependencyProperty UpButtonIsAcpVisibleProperty;

		// Token: 0x040004DE RID: 1246
		public static DependencyProperty UpButtonIsAcpEditableProperty;

		// Token: 0x040004DF RID: 1247
		public static DependencyProperty UpButtonUIValueProperty;

		// Token: 0x040004E0 RID: 1248
		public static DependencyProperty UpButtonListProperty;

		// Token: 0x040004E1 RID: 1249
		public static DependencyProperty DownButtonIsAcpValidProperty;

		// Token: 0x040004E2 RID: 1250
		public static DependencyProperty DownButtonIsAcpApplicableProperty;

		// Token: 0x040004E3 RID: 1251
		public static DependencyProperty DownButtonIsAcpVisibleProperty;

		// Token: 0x040004E4 RID: 1252
		public static DependencyProperty DownButtonIsAcpEditableProperty;

		// Token: 0x040004E5 RID: 1253
		public static DependencyProperty DownButtonUIValueProperty;

		// Token: 0x040004E6 RID: 1254
		public static DependencyProperty DownButtonListProperty;

		// Token: 0x040004E7 RID: 1255
		public static DependencyProperty BottomButtonFeatureIsAcpValidProperty;

		// Token: 0x040004E8 RID: 1256
		public static DependencyProperty BottomButtonFeatureIsAcpApplicableProperty;

		// Token: 0x040004E9 RID: 1257
		public static DependencyProperty BottomButtonFeatureIsAcpVisibleProperty;

		// Token: 0x040004EA RID: 1258
		public static DependencyProperty BottomButtonFeatureIsAcpEditableProperty;

		// Token: 0x040004EB RID: 1259
		public static DependencyProperty BottomButtonFeatureUIValueProperty;

		// Token: 0x040004EC RID: 1260
		public static DependencyProperty BottomButtonFeatureListProperty;

		// Token: 0x040004ED RID: 1261
		public static DependencyProperty BottomButtonIndexIsAcpValidProperty;

		// Token: 0x040004EE RID: 1262
		public static DependencyProperty BottomButtonIndexIsAcpApplicableProperty;

		// Token: 0x040004EF RID: 1263
		public static DependencyProperty BottomButtonIndexIsAcpVisibleProperty;

		// Token: 0x040004F0 RID: 1264
		public static DependencyProperty BottomButtonIndexIsAcpEditableProperty;

		// Token: 0x040004F1 RID: 1265
		public static DependencyProperty BottomButtonIndexUIValueProperty;

		// Token: 0x040004F2 RID: 1266
		public static DependencyProperty BottomButtonIndexListProperty;

		// Token: 0x040004F3 RID: 1267
		public static DependencyProperty MenuItemsConventionalSelectedListProperty;

		// Token: 0x040004F4 RID: 1268
		public static DependencyProperty MenuItemsTrunkingSelectedListProperty;

		// Token: 0x040004F5 RID: 1269
		public static DependencyProperty MenuItemsConventionalSelectedListVisibilityProperty;

		// Token: 0x040004F6 RID: 1270
		public static DependencyProperty MenuItemsTrunkingSelectedListVisibilityProperty;
	}
}
