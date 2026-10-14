using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpBusinessLayer;
using AcpUI.Common;
using AcpUI.DragDrop;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x0200001E RID: 30
	public partial class AcpMenuItems : UserControl, IAcpUICtrlBase, IAcpUIParentCtrlBase, IAcpUIChildCtrlBase, IAcpUICommon
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0001E2BC File Offset: 0x0001C4BC
		// (set) Token: 0x06000199 RID: 409 RVA: 0x0001E374 File Offset: 0x0001C574
		public bool IsAcpValid
		{
			get
			{
				short num = (short)1189347328;
				short num2 = num;
				num = (short)1882814147;
				short num3 = num;
				num = (short)1119123139;
				switch (num3 == num)
				{
				}
				num = (short)1826291713;
				if (num != 0)
				{
				}
				num = (short)607059968;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpMenuItems.IsAcpValidProperty);
			}
			set
			{
				short num = (short)1794179072;
				short num2 = num;
				num = (short)218897571;
				short num3 = num;
				num = (short)687348899;
				switch (num3 == num)
				{
				}
				num = (short)1092681729;
				if (num != 0)
				{
				}
				num = (short)2040332288;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.IsAcpValidProperty, value);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0001E430 File Offset: 0x0001C630
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0001E4E8 File Offset: 0x0001C6E8
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)624754688;
				short num2 = num;
				num = (short)273081838;
				short num3 = num;
				num = (short)1640162798;
				switch (num3 == num)
				{
				}
				num = (short)1450967041;
				if (num != 0)
				{
				}
				num = (short)1203306496;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpMenuItems.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)353632256;
				short num2 = num;
				num = (short)558833387;
				short num3 = num;
				num = (short)1373904619;
				switch (num3 == num)
				{
				}
				num = (short)342687744;
				if (num != 0)
				{
				}
				num = (short)987365377;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0001E5A4 File Offset: 0x0001C7A4
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0001E65C File Offset: 0x0001C85C
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)750911488;
				short num2 = num;
				num = (short)30217292;
				short num3 = num;
				num = (short)530846796;
				switch (num3 == num)
				{
				}
				num = (short)562167809;
				if (num != 0)
				{
				}
				num = (short)1944977408;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpMenuItems.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1389166592;
				short num2 = num;
				num = (short)2039087105;
				if (num != 0)
				{
				}
				num = (short)286240125;
				short num3 = num;
				num = (short)26127741;
				switch (num3 == num)
				{
				}
				num = (short)495779840;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0001E71C File Offset: 0x0001C91C
		// (set) Token: 0x0600019F RID: 415 RVA: 0x0001E7D4 File Offset: 0x0001C9D4
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)578224128;
				short num2 = num;
				num = (short)132532250;
				short num3 = num;
				num = (short)459491354;
				switch (num3 == num)
				{
				}
				num = (short)1029963777;
				if (num != 0)
				{
				}
				num = (short)1367801856;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpMenuItems.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)668008448;
				short num2 = num;
				num = (short)157313735;
				short num3 = num;
				num = (short)545942215;
				switch (num3 == num)
				{
				}
				num = (short)1078525952;
				if (num != 0)
				{
				}
				num = (short)995885057;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0001E88C File Offset: 0x0001CA8C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0001E948 File Offset: 0x0001CB48
		public IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)1053753344;
				short num2 = num;
				num = (short)664403969;
				if (num != 0)
				{
				}
				num = (short)54655382;
				short num3 = num;
				num = (short)428931478;
				switch (num3 == num)
				{
				}
				num = (short)269090816;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpMenuItems.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)52756480;
				short num2 = num;
				num = (short)1249291690;
				short num3 = num;
				num = (short)740863402;
				switch (num3 == num)
				{
				}
				num = (short)1009647617;
				if (num != 0)
				{
				}
				num = (short)1710948352;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0001EA00 File Offset: 0x0001CC00
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x0001EABC File Offset: 0x0001CCBC
		public IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)1249968128;
				short num2 = num;
				num = (short)1018721127;
				short num3 = num;
				num = (short)176255847;
				switch (num3 == num)
				{
				}
				num = (short)1089798145;
				if (num != 0)
				{
				}
				num = (short)643104768;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpMenuItems.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)359071744;
				short num2 = num;
				num = (short)2080243713;
				if (num != 0)
				{
				}
				num = (short)894455874;
				short num3 = num;
				num = (short)229724226;
				switch (num3 == num)
				{
				}
				num = (short)226951168;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0001EB74 File Offset: 0x0001CD74
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x0001EC2C File Offset: 0x0001CE2C
		public AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)1183449088;
				short num2 = num;
				num = (short)1153761281;
				if (num != 0)
				{
				}
				num = (short)653716242;
				short num3 = num;
				num = (short)1769204498;
				switch (num3 == num)
				{
				}
				num = (short)1782841344;
				if (num != 0)
				{
				}
				return (AcpFieldBase)base.GetValue(AcpMenuItems.MyBLObjectProperty);
			}
			set
			{
				short num = (short)1621164032;
				short num2 = num;
				num = (short)548111413;
				short num3 = num;
				num = (short)1205699637;
				switch (num3 == num)
				{
				}
				num = (short)1495662593;
				if (num != 0)
				{
				}
				num = (short)11337728;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.MyBLObjectProperty, value);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0001ECE0 File Offset: 0x0001CEE0
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x0001ED98 File Offset: 0x0001CF98
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)529268736;
				short num2 = num;
				num = (short)1868677441;
				short num3 = num;
				num = (short)1760936257;
				switch (num3 == num)
				{
				}
				num = (short)668598273;
				if (num != 0)
				{
				}
				num = (short)2069757952;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpMenuItems.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)1903493120;
				short num2 = num;
				num = (short)1834712361;
				short num3 = num;
				num = (short)202210601;
				switch (num3 == num)
				{
				}
				num = (short)1137508353;
				if (num != 0)
				{
				}
				num = (short)1568079872;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0001EE54 File Offset: 0x0001D054
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x0001EF10 File Offset: 0x0001D110
		public Expander MyExpander
		{
			get
			{
				short num = (short)614465536;
				short num2 = num;
				num = (short)7135536;
				short num3 = num;
				num = (short)1664344368;
				switch (num3 == num)
				{
				}
				num = (short)907476992;
				if (num != 0)
				{
				}
				num = (short)1341587457;
				if (num != 0)
				{
				}
				return (Expander)base.GetValue(AcpMenuItems.MyExpanderProperty);
			}
			set
			{
				short num = (short)1504837632;
				short num2 = num;
				num = (short)64067169;
				short num3 = num;
				num = (short)10327649;
				switch (num3 == num)
				{
				}
				num = (short)279707648;
				if (num != 0)
				{
				}
				num = (short)1485504513;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.MyExpanderProperty, value);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0001EFC8 File Offset: 0x0001D1C8
		// (set) Token: 0x060001AB RID: 427 RVA: 0x0001F084 File Offset: 0x0001D284
		public IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)2045837312;
				short num2 = num;
				num = (short)1523908609;
				if (num != 0)
				{
				}
				num = (short)494218842;
				short num3 = num;
				num = (short)7482970;
				switch (num3 == num)
				{
				}
				num = (short)725483520;
				if (num != 0)
				{
				}
				return (IAcpUIParentCtrlBase)base.GetValue(AcpMenuItems.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)690421760;
				short num2 = num;
				num = (short)690658259;
				short num3 = num;
				num = (short)658545619;
				switch (num3 == num)
				{
				}
				num = (short)1283194881;
				if (num != 0)
				{
				}
				num = (short)2038956032;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0001F138 File Offset: 0x0001D338
		public override void OnApplyTemplate()
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_96;
			}
			short num;
			int num3;
			Style style;
			for (;;)
			{
				IL_13:
				num = (short)2088733925;
				short num2 = num;
				num = (short)1969786085;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_96;
				default:
					num = (short)1100087296;
					if (num != 0)
					{
					}
					num = (short)452067329;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1883176960;
						short num4 = num;
						if (style != null)
						{
							num = (short)69730306;
							num3 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
					{
						Style itemContainerStyle = new Style(typeof(ListBoxItem), style);
						this.b.ItemContainerStyle = itemContainerStyle;
						this.e.ItemContainerStyle = itemContainerStyle;
						num = (short)1603469312;
						num3 = (int)((IntPtr)num);
						continue;
					}
					}
					goto IL_96;
				}
			}
			return;
			IL_96:
			base.OnApplyTemplate();
			style = (Style)base.TryFindResource(Utility.c("횖滛톜튠힢좦톨\ud9ac쪮\udcb0솴캶햸\udeba", a_));
			num = (short)918945793;
			num3 = (int)((IntPtr)num);
			goto IL_13;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0001F298 File Offset: 0x0001D498
		// (set) Token: 0x060001AE RID: 430 RVA: 0x0001F354 File Offset: 0x0001D554
		public ObservableCollection<ListItem> AvailableItemsItemsSource
		{
			get
			{
				short num = (short)1597898753;
				if (num != 0)
				{
				}
				num = (short)1170555368;
				short num2 = num;
				num = (short)4866536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)522452992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)555745280;
				if (num != 0)
				{
				}
				return (ObservableCollection<ListItem>)base.GetValue(AcpMenuItems.AvailableItemsItemsSourceProperty);
			}
			set
			{
				short num = (short)1201825624;
				short num2 = num;
				num = (short)1812555608;
				switch (num2 == num)
				{
				}
				num = (short)487849984;
				short num3 = num;
				num = (short)169082881;
				if (num != 0)
				{
				}
				num = (short)1298792448;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.AvailableItemsItemsSourceProperty, value);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0001F40C File Offset: 0x0001D60C
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0001F4C4 File Offset: 0x0001D6C4
		public string AvailableItemsSelectedValue
		{
			get
			{
				short num = (short)1253074920;
				short num2 = num;
				num = (short)533096424;
				switch (num2 == num)
				{
				}
				num = (short)619905024;
				short num3 = num;
				num = (short)2135031809;
				if (num != 0)
				{
				}
				num = (short)771227648;
				if (num != 0)
				{
				}
				return (string)base.GetValue(AcpMenuItems.AvailableItemsSelectedValueProperty);
			}
			set
			{
				short num = (short)943476124;
				short num2 = num;
				num = (short)1801407900;
				switch (num2 == num)
				{
				}
				num = (short)353894400;
				short num3 = num;
				num = (short)628686848;
				if (num != 0)
				{
				}
				num = (short)211615745;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.AvailableItemsSelectedValueProperty, value);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0001F57C File Offset: 0x0001D77C
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0001F634 File Offset: 0x0001D834
		public ObservableCollection<ListItem> SelectedItemsItemsSource
		{
			get
			{
				short num = (short)1500021765;
				short num2 = num;
				num = (short)2066187269;
				switch (num2 == num)
				{
				}
				num = (short)688652288;
				short num3 = num;
				num = (short)951386113;
				if (num != 0)
				{
				}
				num = (short)591462400;
				if (num != 0)
				{
				}
				return (ObservableCollection<ListItem>)base.GetValue(AcpMenuItems.SelectedItemsItemsSourceProperty);
			}
			set
			{
				short num = (short)1387182749;
				short num2 = num;
				num = (short)350796445;
				switch (num2 == num)
				{
				}
				num = (short)1654456320;
				short num3 = num;
				num = (short)1965293569;
				if (num != 0)
				{
				}
				num = (short)1668218880;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.SelectedItemsItemsSourceProperty, value);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0001F6E8 File Offset: 0x0001D8E8
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x0001F7A0 File Offset: 0x0001D9A0
		public string SelectedItemsSelectedValue
		{
			get
			{
				short num = (short)1997645973;
				short num2 = num;
				num = (short)1339467925;
				switch (num2 == num)
				{
				}
				num = (short)622854144;
				short num3 = num;
				num = (short)1293352961;
				if (num != 0)
				{
				}
				num = (short)421068800;
				if (num != 0)
				{
				}
				return (string)base.GetValue(AcpMenuItems.SelectedItemsSelectedValueProperty);
			}
			set
			{
				short num = (short)342851080;
				short num2 = num;
				num = (short)2012773896;
				switch (num2 == num)
				{
				}
				num = (short)257228800;
				short num3 = num;
				num = (short)1856897024;
				if (num != 0)
				{
				}
				num = (short)211091457;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.SelectedItemsSelectedValueProperty, value);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0001F854 File Offset: 0x0001DA54
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x0001F90C File Offset: 0x0001DB0C
		public int MaximumItemsAllowed
		{
			get
			{
				short num = (short)2062155777;
				if (num != 0)
				{
				}
				num = (short)627741363;
				short num2 = num;
				num = (short)1703318195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1681719296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1784414208;
				if (num != 0)
				{
				}
				return (int)base.GetValue(AcpMenuItems.MaximumItemsAllowedProperty);
			}
			set
			{
				short num = (short)654019867;
				short num2 = num;
				num = (short)580422939;
				switch (num2 == num)
				{
				}
				num = (short)1927544832;
				short num3 = num;
				num = (short)1374224385;
				if (num != 0)
				{
				}
				num = (short)788201472;
				if (num != 0)
				{
				}
				base.SetValue(AcpMenuItems.MaximumItemsAllowedProperty, value);
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0001F9CC File Offset: 0x0001DBCC
		private void BtnAddMenuItem_Click(object A_0, RoutedEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1316028421;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					num = (short)564264961;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						AcpListField acpListField;
						acpListField.AddItem(this.b.SelectedValue.ToString());
						num = (short)724566020;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
					{
						AcpListField acpListField;
						if (acpListField != null)
						{
							num = (short)20643840;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
						if (this.e.Items.Count < this.MaximumItemsAllowed)
						{
							num = (short)559415302;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						num = (short)1998990053;
						short num3 = num;
						num = (short)1041509093;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1218510848;
							if (num != 0)
							{
							}
							num = (short)1428226050;
							num2 = (int)((IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						return;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_67;
						}
						continue;
					case 6:
					{
						AcpListField acpListField = this.MyBLObject as AcpListField;
						num = (short)748355584;
						short num4 = num;
						num = (short)2117730305;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					IL_67:
					if (this.b.SelectedIndex == -1)
					{
						return;
					}
					num = (short)1068105731;
					num2 = (int)((IntPtr)num);
				}
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001FBA0 File Offset: 0x0001DDA0
		private void BtnRemoveMenuItem_Click(object A_0, RoutedEventArgs A_1)
		{
			int num;
			short num2;
			int selectedIndex;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.e.Items.Count > 1)
						{
							num2 = (short)958070785;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_1E0;
					case 1:
					{
						num2 = (short)650667273;
						short num3 = num2;
						num2 = (short)603219209;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_40;
						default:
						{
							num2 = (short)1860370432;
							if (num2 != 0)
							{
							}
							AcpListField acpListField = this.MyBLObject as AcpListField;
							num2 = (short)1383530500;
							num = (int)((IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						if (selectedIndex > 0)
						{
							num2 = (short)800325638;
							num = (int)((IntPtr)num2);
							continue;
						}
						this.e.SelectedIndex = 0;
						num2 = (short)1409286147;
						num = (int)((IntPtr)num2);
						continue;
					case 3:
						goto IL_19C;
					case 4:
					{
						AcpListField acpListField;
						if (acpListField != null)
						{
							num2 = (short)4653064;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_1E0;
					}
					case 5:
						num2 = (short)2026700800;
						num = (int)((IntPtr)num2);
						continue;
					case 6:
						goto IL_BE;
					case 7:
						if (selectedIndex != -1)
						{
							num2 = (short)249036805;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_1E0;
					case 8:
					{
						AcpListField acpListField;
						acpListField.RemoveItemAt(selectedIndex);
						num2 = (short)839057410;
						num = (int)((IntPtr)num2);
						continue;
					}
					}
					goto IL_34;
				}
				IL_BE:
				num2 = (short)1074724864;
				short num4 = num2;
				this.e.SelectedIndex = selectedIndex - 1;
				return;
				IL_19C:
				IL_1E0:
				num2 = (short)1131544577;
				if (num2 != 0)
				{
				}
				return;
			}
			}
			IL_34:
			selectedIndex = this.e.SelectedIndex;
			IL_40:
			num2 = (short)1214906375;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
		public AcpMenuItems()
		{
			this.InitializeComponent();
			new ListBoxDragDropManager<ListItem>(this.e);
			GridLength height = (GridLength)new GridLengthConverter().ConvertFrom(30.0);
			this.a.Height = height;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0001FEEC File Offset: 0x0001E0EC
		[GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		[DebuggerNonUserCode]
		internal Delegate a(Type A_0, string A_1)
		{
			short num = (short)862157459;
			short num2 = num;
			num = (short)1583643283;
			switch (num2 == num)
			{
			}
			num = (short)1275133952;
			short num3 = num;
			num = (short)1923612672;
			if (num != 0)
			{
			}
			num = (short)248250369;
			if (num != 0)
			{
			}
			return Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0002010C File Offset: 0x0001E30C
		// Note: this type is marked as 'beforefieldinit'.
		static AcpMenuItems()
		{
			int a_ = 17;
			short num = (short)709165057;
			if (num != 0)
			{
			}
			num = (short)1612247102;
			short num2 = num;
			num = (short)976744510;
			switch (num2 == num)
			{
			default:
			{
				num = (short)321978368;
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
			AcpMenuItems.IsAcpValidProperty = DependencyProperty.Register(Utility.c("\udaa8캬\udfae튲\ud9b4\udeb6\uddb8", a_), typeof(bool), typeof(AcpMenuItems), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpMenuItems.IsAcpApplicableProperty = DependencyProperty.Register(Utility.c("\udaa8캬\udfae쎲어\udbb6킸\ud8ba\udcbc\uddbe귀ꛂ", a_), typeof(bool), typeof(AcpMenuItems), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpMenuItems.IsAcpEditableProperty = DependencyProperty.Register(Utility.c("\udaa8캬\udfaeힲ\udcb4쎶\ud8b8\ud9ba톼\udabe", a_), typeof(bool), typeof(AcpMenuItems), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpMenuItems.IsAcpVisibleProperty = DependencyProperty.Register(Utility.c("\udaa8캬\udfae\udab2운\udeb6\udbb8ힺ\ud8bc", a_), typeof(bool), typeof(AcpMenuItems), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpMenuItems.MyLabelCtrlProperty = DependencyProperty.RegisterAttached(Utility.c("킨첬춮풰\udfb2쎶쮸ힺ", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpMenuItems), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpMenuItems.MyCopyButtonProperty = DependencyProperty.RegisterAttached(Utility.c("킨슬\udfae좰살쎶춸풺펼ﲾ뗀뇂꧄", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpMenuItems), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpMenuItems.MyBLObjectProperty = DependencyProperty.RegisterAttached(Utility.c("킨펰\ud9b2킴풶춸", a_), typeof(AcpFieldBase), typeof(AcpMenuItems), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpMenuItems.AreValuesEqualProperty = DependencyProperty.Register(Utility.c("\udba8캪ﮬ캮\uddb0욲킴쒶ﲸ쪺좼\udebe귀", a_), typeof(bool), typeof(AcpMenuItems), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpMenuItems.MyExpanderProperty = DependencyProperty.RegisterAttached(Utility.c("킨햬\udfae킰\uddb2톴튶쮸", a_), typeof(Expander), typeof(AcpMenuItems), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpMenuItems.MyParentCtrlProperty = DependencyProperty.RegisterAttached(Utility.c("킨ﮪ첬\uddae풰\uddb2솴춸즺톼", a_), typeof(IAcpUIParentCtrlBase), typeof(AcpMenuItems), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpMenuItems.AvailableItemsItemsSourceProperty = DependencyProperty.Register(Utility.c("\udfa8쪪쒬쎮킰톲\ud9b4튶쾺\ud8bc튾닀諂뇄ꋆ꓈룊黌ꃎꓐꇒ뛔닖", a_), typeof(ObservableCollection<ListItem>), typeof(AcpMenuItems), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpMenuItems.AvailableItemsSelectedValueProperty = DependencyProperty.Register(Utility.c("\udfa8쪪쒬쎮킰톲\ud9b4튶쾺\ud8bc튾닀郂ꃄꯆ곈꣊만꫎뗐藒듔믖곘뻚", a_), typeof(string), typeof(AcpMenuItems), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpMenuItems.SelectedItemsItemsSourceProperty = DependencyProperty.Register(Utility.c("첨잪좬첮얰횲톴ﺶ춸\udeba킼첾裀럂ꃄ꫆뫈飊ꋌ뫎ꏐ냒냔", a_), typeof(ObservableCollection<ListItem>), typeof(AcpMenuItems), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpMenuItems.SelectedItemsSelectedValueProperty = DependencyProperty.Register(Utility.c("첨잪좬첮얰횲톴ﺶ춸\udeba킼첾鋀ꛂ꧄ꋆ꫈뿊꣌ꯎ蟐닒맔ꋖ볘", a_), typeof(string), typeof(AcpMenuItems), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpMenuItems.MaximumItemsAllowedProperty = DependencyProperty.Register(Utility.c("좨펪쒬슮쒰\udeb2ﲴ쎶\udcb8횺캼ﺾ귀꿂꫄냆곈꿊", a_), typeof(int), typeof(AcpMenuItems), new FrameworkPropertyMetadata(int.MaxValue, FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x0400015F RID: 351
		public static readonly DependencyProperty IsAcpValidProperty;

		// Token: 0x04000160 RID: 352
		public static readonly DependencyProperty IsAcpApplicableProperty;

		// Token: 0x04000161 RID: 353
		public static readonly DependencyProperty IsAcpEditableProperty;

		// Token: 0x04000162 RID: 354
		public static readonly DependencyProperty IsAcpVisibleProperty;

		// Token: 0x04000163 RID: 355
		public static readonly DependencyProperty MyLabelCtrlProperty;

		// Token: 0x04000164 RID: 356
		public static readonly DependencyProperty MyCopyButtonProperty;

		// Token: 0x04000165 RID: 357
		public static readonly DependencyProperty MyBLObjectProperty;

		// Token: 0x04000166 RID: 358
		public static readonly DependencyProperty AreValuesEqualProperty;

		// Token: 0x04000167 RID: 359
		public static readonly DependencyProperty MyExpanderProperty;

		// Token: 0x04000168 RID: 360
		public static readonly DependencyProperty MyParentCtrlProperty;

		// Token: 0x04000169 RID: 361
		public static readonly DependencyProperty AvailableItemsItemsSourceProperty;

		// Token: 0x0400016A RID: 362
		public static readonly DependencyProperty AvailableItemsSelectedValueProperty;

		// Token: 0x0400016B RID: 363
		public static readonly DependencyProperty SelectedItemsItemsSourceProperty;

		// Token: 0x0400016C RID: 364
		public static readonly DependencyProperty SelectedItemsSelectedValueProperty;

		// Token: 0x0400016D RID: 365
		public static readonly DependencyProperty MaximumItemsAllowedProperty;
	}
}
