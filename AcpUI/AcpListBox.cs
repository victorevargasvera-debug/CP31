using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using AcpBusinessLayer;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x02000019 RID: 25
	public class AcpListBox : global::System.Windows.Controls.ListBox, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIValueCtrlBase<string>, global::AcpUILib.IAcpUIParentCtrlBase, global::AcpUILib.IAcpUIChildCtrlBase, global::AcpUILib.IAcpUICommon
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0001A55C File Offset: 0x0001875C
		// (set) Token: 0x06000154 RID: 340 RVA: 0x0001A6B8 File Offset: 0x000188B8
		public string Value
		{
			get
			{
				short num = (short)891448012;
				short num2 = num;
				num = (short)890530508;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_11F:
					if (((global::System.Windows.Controls.ListBoxItem)base.SelectedValue).Content == null)
					{
						goto IL_14B;
					}
					num = (short)1712652289;
					num3 = (int)((global::System.IntPtr)num);
					break;
				case 1:
					goto IL_5E;
				default:
				{
					num = (short)1339228160;
					short num4 = num;
					goto IL_5E;
				}
				}
				for (;;)
				{
					IL_B9:
					switch (num3)
					{
					case 0:
						goto IL_11F;
					case 1:
						goto IL_149;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_CF;
						}
						continue;
					case 3:
						num = (short)432865280;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CF:
					if (!(base.SelectedValue is global::System.Windows.Controls.ListBoxItem))
					{
						goto IL_14B;
					}
					num = (short)176881667;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_149:
				return ((global::System.Windows.Controls.ListBoxItem)base.SelectedValue).Content.ToString();
				IL_5E:
				num = (short)1544880129;
				if (num != 0)
				{
				}
				num = (short)2080571392;
				if (num != 0)
				{
				}
				num = (short)1159725058;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_B9;
				IL_14B:
				return null;
			}
			set
			{
				short num = (short)443398935;
				short num2 = num;
				num = (short)376421143;
				switch (num2 == num)
				{
				}
				num = (short)1453981696;
				if (num != 0)
				{
				}
				num = (short)1896873984;
				short num3 = num;
				num = (short)1223819265;
				if (num != 0)
				{
				}
				base.SelectedValue = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0001A768 File Offset: 0x00018968
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0001A820 File Offset: 0x00018A20
		public bool IsAcpValid
		{
			get
			{
				short num = (short)1353609347;
				short num2 = num;
				num = (short)1797091459;
				switch (num2 == num)
				{
				}
				num = (short)220528640;
				if (num != 0)
				{
				}
				num = (short)1503133696;
				short num3 = num;
				num = (short)1233453057;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpListBox.IsAcpValidProperty);
			}
			set
			{
				short num = (short)1608607574;
				short num2 = num;
				num = (short)1127573334;
				switch (num2 == num)
				{
				}
				num = (short)350093312;
				if (num != 0)
				{
				}
				num = (short)698744832;
				short num3 = num;
				num = (short)947781633;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpListBox.IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0001A8DC File Offset: 0x00018ADC
		// (set) Token: 0x06000158 RID: 344 RVA: 0x0001A998 File Offset: 0x00018B98
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)426955062;
				short num2 = num;
				num = (short)1168494902;
				switch (num2 == num)
				{
				}
				num = (short)1655177217;
				if (num != 0)
				{
				}
				num = (short)884342784;
				short num3 = num;
				num = (short)885129216;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpListBox.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1159689867;
				short num2 = num;
				num = (short)1429698187;
				switch (num2 == num)
				{
				}
				num = (short)1772814337;
				if (num != 0)
				{
				}
				num = (short)489947136;
				short num3 = num;
				num = (short)1068302336;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpListBox.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0001AA54 File Offset: 0x00018C54
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0001AB10 File Offset: 0x00018D10
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)1954461117;
				short num2 = num;
				num = (short)1984017853;
				switch (num2 == num)
				{
				}
				num = (short)1283457024;
				if (num != 0)
				{
				}
				num = (short)1055850496;
				short num3 = num;
				num = (short)1875509249;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpListBox.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1835291599;
				short num2 = num;
				num = (short)881087439;
				switch (num2 == num)
				{
				}
				num = (short)2045509633;
				if (num != 0)
				{
				}
				num = (short)203423744;
				short num3 = num;
				num = (short)221904896;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpListBox.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0001AC80 File Offset: 0x00018E80
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)442330740;
				short num2 = num;
				num = (short)1414098548;
				switch (num2 == num)
				{
				}
				num = (short)724500481;
				if (num != 0)
				{
				}
				num = (short)122748928;
				short num3 = num;
				num = (short)1361575936;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpListBox.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1078001665;
				if (num != 0)
				{
				}
				num = (short)991876571;
				short num2 = num;
				num = (short)836228571;
				switch (num2 == num)
				{
				}
				num = (short)1893990400;
				short num3 = num;
				num = (short)1301151744;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpListBox.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0001AD3C File Offset: 0x00018F3C
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0001ADF8 File Offset: 0x00018FF8
		public global::AcpUILib.IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)129915287;
				short num2 = num;
				num = (short)185031063;
				switch (num2 == num)
				{
				}
				num = (short)591069184;
				if (num != 0)
				{
				}
				num = (short)1751515136;
				short num3 = num;
				num = (short)1885405185;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpListBox.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)1695608967;
				short num2 = num;
				num = (short)1111617671;
				switch (num2 == num)
				{
				}
				num = (short)1376714753;
				if (num != 0)
				{
				}
				num = (short)1092026368;
				short num3 = num;
				num = (short)2118582272;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpListBox.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0001AEAC File Offset: 0x000190AC
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0001AF64 File Offset: 0x00019164
		public global::AcpUILib.IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)135317362;
				short num2 = num;
				num = (short)671598450;
				switch (num2 == num)
				{
				}
				num = (short)1462370305;
				if (num != 0)
				{
				}
				num = (short)1734803456;
				short num3 = num;
				num = (short)2020802560;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpListBox.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)901783975;
				short num2 = num;
				num = (short)116072871;
				switch (num2 == num)
				{
				}
				num = (short)108527617;
				if (num != 0)
				{
				}
				num = (short)1169227776;
				short num3 = num;
				num = (short)1042415616;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpListBox.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0001B018 File Offset: 0x00019218
		// (set) Token: 0x06000162 RID: 354 RVA: 0x0001B0D4 File Offset: 0x000192D4
		public global::AcpBusinessLayer.AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)1729080742;
				short num2 = num;
				num = (short)1515367846;
				switch (num2 == num)
				{
				}
				num = (short)1762066433;
				if (num != 0)
				{
				}
				num = (short)1783955456;
				if (num != 0)
				{
				}
				num = (short)668073984;
				short num3 = num;
				return (global::AcpBusinessLayer.AcpFieldBase)base.GetValue(global::AcpUI.AcpListBox.MyBLObjectProperty);
			}
			set
			{
				short num = (short)2009806469;
				short num2 = num;
				num = (short)374290053;
				switch (num2 == num)
				{
				}
				num = (short)1312817153;
				if (num != 0)
				{
				}
				num = (short)742195200;
				if (num != 0)
				{
				}
				num = (short)1048510464;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpListBox.MyBLObjectProperty, value);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0001B18C File Offset: 0x0001938C
		// (set) Token: 0x06000164 RID: 356 RVA: 0x0001B244 File Offset: 0x00019444
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)2072051713;
				if (num != 0)
				{
				}
				num = (short)1086389456;
				short num2 = num;
				num = (short)800128208;
				switch (num2 == num)
				{
				}
				num = (short)1534394368;
				if (num != 0)
				{
				}
				num = (short)1969029120;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpListBox.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)1663451305;
				short num2 = num;
				num = (short)1744912553;
				switch (num2 == num)
				{
				}
				num = (short)1042874369;
				if (num != 0)
				{
				}
				num = (short)412745728;
				if (num != 0)
				{
				}
				num = (short)1474756608;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpListBox.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0001B300 File Offset: 0x00019500
		// (set) Token: 0x06000166 RID: 358 RVA: 0x0001B3B8 File Offset: 0x000195B8
		public global::System.Windows.Controls.Expander MyExpander
		{
			get
			{
				short num = (short)1330306647;
				short num2 = num;
				num = (short)951836247;
				switch (num2 == num)
				{
				}
				num = (short)326500353;
				if (num != 0)
				{
				}
				num = (short)1261961216;
				if (num != 0)
				{
				}
				num = (short)315490304;
				short num3 = num;
				return (global::System.Windows.Controls.Expander)base.GetValue(global::AcpUI.AcpListBox.MyExpanderProperty);
			}
			set
			{
				short num = (short)235929601;
				if (num != 0)
				{
				}
				num = (short)771724843;
				short num2 = num;
				num = (short)768185899;
				switch (num2 == num)
				{
				}
				num = (short)1785921536;
				if (num != 0)
				{
				}
				num = (short)641597440;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpListBox.MyExpanderProperty, value);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0001B46C File Offset: 0x0001966C
		// (set) Token: 0x06000168 RID: 360 RVA: 0x0001B528 File Offset: 0x00019728
		public global::AcpUILib.IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)36438017;
				if (num != 0)
				{
				}
				num = (short)2099099958;
				short num2 = num;
				num = (short)1767684406;
				switch (num2 == num)
				{
				}
				num = (short)1601699840;
				if (num != 0)
				{
				}
				num = (short)1184759808;
				short num3 = num;
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::AcpUI.AcpListBox.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)2030166390;
				short num2 = num;
				num = (short)1368187254;
				switch (num2 == num)
				{
				}
				num = (short)1743126529;
				if (num != 0)
				{
				}
				num = (short)1909063680;
				if (num != 0)
				{
				}
				num = (short)869400576;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpListBox.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0001B5DC File Offset: 0x000197DC
		public AcpListBox()
		{
			base.Loaded += this.AcpListBox_Loaded;
			base.Unloaded += this.AcpListBox_Unloaded;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0001B614 File Offset: 0x00019814
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)156071308;
				short num2 = num;
				num = (short)1664513420;
				switch (num2 == num)
				{
				}
				num = (short)1096024065;
				if (num != 0)
				{
				}
				num = (short)1464926208;
				if (num != 0)
				{
				}
			}
			finally
			{
				base.Finalize();
			}
			num = (short)874774528;
			short num3 = num;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0001B6D8 File Offset: 0x000198D8
		private void AcpListBox_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1806106625;
			if (num != 0)
			{
			}
			num = (short)260188846;
			short num2 = num;
			num = (short)2134977198;
			switch (num2 == num)
			{
			}
			num = (short)1695809536;
			if (num != 0)
			{
			}
			num = (short)2126446592;
			short num3 = num;
			base.KeyDown += this.AcpListBox_KeyDown;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0001B794 File Offset: 0x00019994
		private void AcpListBox_Unloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1288065878;
			short num2 = num;
			num = (short)269964118;
			switch (num2 == num)
			{
			}
			num = (short)553189377;
			if (num != 0)
			{
			}
			num = (short)502071296;
			if (num != 0)
			{
			}
			num = (short)746586112;
			short num3 = num;
			base.KeyDown -= this.AcpListBox_KeyDown;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0001B84C File Offset: 0x00019A4C
		private void AcpListBox_KeyDown(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)582687958;
			short num2 = num;
			num = (short)821828822;
			global::System.Windows.Controls.ListBoxItem listBoxItem;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_2F4:
				listBoxItem.Focus();
				num = (short)2137456658;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1192099840;
				if (num != 0)
				{
				}
				num = (short)116326400;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_D7;
					}
					break;
				}
				break;
			}
			global::AcpBusinessLayer.AcpListField acpListField;
			int num4;
			global::AcpUI.AcpListBox acpListBox;
			for (;;)
			{
				IL_74:
				int selectedIndex;
				int num5;
				switch (num3)
				{
				case 0:
				{
					if (acpListField != null)
					{
						num = (short)947126285;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem> observableCollection = (global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem>)base.ItemsSource;
					num = (short)432013331;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_1E3;
				case 2:
					if (selectedIndex != -1)
					{
						num = (short)1658322953;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_48E;
				case 3:
				{
					num = (short)2009595905;
					if (num != 0)
					{
					}
					global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem> observableCollection;
					if (observableCollection != null)
					{
						num = (short)755171350;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_243;
				}
				case 4:
				{
					global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem> observableCollection;
					if (num4 >= observableCollection.Count)
					{
						num = (short)1307967499;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_31A;
				}
				case 5:
					goto IL_31A;
				case 6:
				{
					global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem> observableCollection;
					if (observableCollection[num4].ItemVisibility)
					{
						num = (short)79364113;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_130;
				}
				case 7:
				{
					global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem> observableCollection;
					if (observableCollection[num4].ToString().StartsWith(A_1.Key.ToString()))
					{
						num = (short)1126105108;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_130;
				}
				case 8:
					goto IL_243;
				case 9:
					acpListBox.ScrollIntoView(base.Items[selectedIndex]);
					listBoxItem = (base.ItemContainerGenerator.ContainerFromIndex(selectedIndex) as global::System.Windows.Controls.ListBoxItem);
					num = (short)355926026;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (listBoxItem != null)
					{
						num = (short)932773903;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_48E;
				case 11:
					num4 = 0;
					num = (short)945029125;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_243;
				case 13:
				{
					global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem> observableCollection = acpListField.Items;
					num = (short)932446209;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					goto IL_2B2;
				case 15:
					goto IL_3E1;
				case 16:
				{
					global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem> observableCollection;
					if (num5 >= observableCollection.Count)
					{
						num = (short)617611272;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1179189252;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 17:
				{
					num = (short)2004484096;
					short num6 = num;
					num = (short)804454407;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 18:
					goto IL_315;
				case 19:
					goto IL_1E3;
				case 20:
					acpListBox.SelectedIndex = num4;
					num = (short)1856110604;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_2B2;
				case 22:
					num5 = 0;
					num = (short)639434773;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_D7;
				IL_130:
				num4++;
				num5++;
				num = (short)799211534;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E3:
				num = (short)498139139;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_243:
				selectedIndex = acpListBox.SelectedIndex;
				num = (short)2127298562;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B2:
				num = (short)417202192;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_31A:
				num = (short)1991901190;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_315:
			goto IL_48E;
			IL_3E1:
			goto IL_2F4;
			IL_48E:
			A_1.Handled = true;
			return;
			IL_D7:
			acpListBox = (A_0 as global::AcpUI.AcpListBox);
			int selectedIndex2 = acpListBox.SelectedIndex;
			acpListField = (this.MyBLObject as global::AcpBusinessLayer.AcpListField);
			num4 = selectedIndex2 + 1;
			num = (short)1352859648;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_74;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0001BCF0 File Offset: 0x00019EF0
		// Note: this type is marked as 'beforefieldinit'.
		static AcpListBox()
		{
			int a_ = 18;
			short num = (short)409785081;
			short num2 = num;
			num = (short)838849273;
			switch (num2 == num)
			{
			}
			num = (short)784334849;
			if (num != 0)
			{
			}
			num = (short)1347682304;
			if (num != 0)
			{
			}
			num = (short)1267728384;
			short num3 = num;
			global::AcpUI.AcpListBox.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud9a9춭삯햳\udab5톷\udeb9", a_), typeof(bool), typeof(global::AcpUI.AcpListBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpListBox.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud9a9춭삯쒳욵풷펹\udfbb\udfbdꊿ껁ꇃ", a_), typeof(bool), typeof(global::AcpUI.AcpListBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpListBox.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud9a9춭삯킳\udfb5첷\udbb9\udebb튽ꖿ", a_), typeof(bool), typeof(global::AcpUI.AcpListBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpListBox.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud9a9춭삯\uddb3억톷\ud8b9킻\udbbd", a_), typeof(bool), typeof(global::AcpUI.AcpListBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpListBox.MyLabelCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩쾭튯ힱ\ud8b3첷좹킻", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpListBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpListBox.MyCopyButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩솭삯쮱쎵첷캹펻킽莿뛁뛃꫅", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpListBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpListBox.MyBLObjectProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩ﾯ킱\udeb3펵\udbb7캹", a_), typeof(global::AcpBusinessLayer.AcpFieldBase), typeof(global::AcpUI.AcpListBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpListBox.AreValuesEqualProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud8a9즫톯\udeb1솳펵쮷ﾹ춻쮽ꆿ껁", a_), typeof(bool), typeof(global::AcpUI.AcpListBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpListBox.MyExpanderProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩횭삯펱\udab3튵\uddb7좹", a_), typeof(global::System.Windows.Controls.Expander), typeof(global::AcpUI.AcpListBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpListBox.MyParentCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩ﲫ쾭슯ힱ\udab3습﮷캹캻튽", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::AcpUI.AcpListBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x04000147 RID: 327
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x04000148 RID: 328
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x04000149 RID: 329
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x0400014A RID: 330
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x0400014B RID: 331
		public static readonly global::System.Windows.DependencyProperty MyLabelCtrlProperty;

		// Token: 0x0400014C RID: 332
		public static readonly global::System.Windows.DependencyProperty MyCopyButtonProperty;

		// Token: 0x0400014D RID: 333
		public static readonly global::System.Windows.DependencyProperty MyBLObjectProperty;

		// Token: 0x0400014E RID: 334
		public static readonly global::System.Windows.DependencyProperty AreValuesEqualProperty;

		// Token: 0x0400014F RID: 335
		public static readonly global::System.Windows.DependencyProperty MyExpanderProperty;

		// Token: 0x04000150 RID: 336
		public static readonly global::System.Windows.DependencyProperty MyParentCtrlProperty;
	}
}
