using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonResources;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x0200000F RID: 15
	public class AcpComboBox : global::System.Windows.Controls.ComboBox, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIValueCtrlBase<string>, global::AcpUILib.IAcpUIParentCtrlBase, global::AcpUILib.IAcpUIChildCtrlBase, global::AcpUILib.IAcpUICommon
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00010EE8 File Offset: 0x0000F0E8
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00010FA0 File Offset: 0x0000F1A0
		public string Value
		{
			get
			{
				short num = (short)1889073460;
				short num2 = num;
				num = (short)200014132;
				switch (num2 == num)
				{
				}
				num = (short)1888616448;
				short num3 = num;
				num = (short)184025089;
				if (num != 0)
				{
				}
				num = (short)1780350976;
				if (num != 0)
				{
				}
				return (string)base.SelectedValue;
			}
			set
			{
				short num = (short)302572643;
				short num2 = num;
				num = (short)1178788963;
				switch (num2 == num)
				{
				}
				num = (short)2056192000;
				short num3 = num;
				num = (short)1373896705;
				if (num != 0)
				{
				}
				num = (short)162332672;
				if (num != 0)
				{
				}
				base.SelectedValue = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00011050 File Offset: 0x0000F250
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0001110C File Offset: 0x0000F30C
		public bool IsAcpValid
		{
			get
			{
				short num = (short)75916080;
				short num2 = num;
				num = (short)1731224368;
				switch (num2 == num)
				{
				}
				num = (short)1987969024;
				short num3 = num;
				num = (short)1078132737;
				if (num != 0)
				{
				}
				num = (short)10944512;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpComboBox.IsAcpValidProperty);
			}
			set
			{
				short num = (short)2055471105;
				if (num != 0)
				{
				}
				num = (short)2092862765;
				short num2 = num;
				num = (short)187141421;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1124925440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)966197248;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpComboBox.IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000111C4 File Offset: 0x0000F3C4
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0001127C File Offset: 0x0000F47C
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)1307066919;
				short num2 = num;
				num = (short)247153191;
				switch (num2 == num)
				{
				}
				num = (short)1509949440;
				short num3 = num;
				num = (short)1485832193;
				if (num != 0)
				{
				}
				num = (short)800129024;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpComboBox.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1332448496;
				short num2 = num;
				num = (short)566463728;
				switch (num2 == num)
				{
				}
				num = (short)2117337088;
				short num3 = num;
				num = (short)1700921345;
				if (num != 0)
				{
				}
				num = (short)950534144;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpComboBox.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00011334 File Offset: 0x0000F534
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000113EC File Offset: 0x0000F5EC
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)1733179515;
				short num2 = num;
				num = (short)1946302587;
				switch (num2 == num)
				{
				}
				num = (short)1657143296;
				short num3 = num;
				num = (short)336855041;
				if (num != 0)
				{
				}
				num = (short)989331456;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpComboBox.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1718913656;
				short num2 = num;
				num = (short)647137912;
				switch (num2 == num)
				{
				}
				num = (short)219086848;
				short num3 = num;
				num = (short)195100673;
				if (num != 0)
				{
				}
				num = (short)1818951680;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpComboBox.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000114A8 File Offset: 0x0000F6A8
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00011560 File Offset: 0x0000F760
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)633508328;
				short num2 = num;
				num = (short)1490391528;
				switch (num2 == num)
				{
				}
				num = (short)912195584;
				short num3 = num;
				num = (short)1866268673;
				if (num != 0)
				{
				}
				num = (short)1614348288;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpComboBox.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1600368237;
				short num2 = num;
				num = (short)1132965485;
				switch (num2 == num)
				{
				}
				num = (short)1845624832;
				short num3 = num;
				num = (short)66191360;
				if (num != 0)
				{
				}
				num = (short)174522369;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpComboBox.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00011618 File Offset: 0x0000F818
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000116CC File Offset: 0x0000F8CC
		public global::AcpUILib.IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)1333936556;
				short num2 = num;
				num = (short)1304773036;
				switch (num2 == num)
				{
				}
				num = (short)1028456448;
				short num3 = num;
				num = (short)1844183040;
				if (num != 0)
				{
				}
				num = (short)1794441217;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpComboBox.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)1533804545;
				if (num != 0)
				{
				}
				num = (short)2035095183;
				short num2 = num;
				num = (short)331028111;
				switch (num2 == num)
				{
				default:
				{
					num = (short)970653696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)52559872;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpComboBox.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00011780 File Offset: 0x0000F980
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00011838 File Offset: 0x0000FA38
		public global::AcpUILib.IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)952373465;
				short num2 = num;
				num = (short)1659244761;
				switch (num2 == num)
				{
				}
				num = (short)2023555072;
				short num3 = num;
				num = (short)997261313;
				if (num != 0)
				{
				}
				num = (short)245891072;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpComboBox.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)1135738881;
				if (num != 0)
				{
				}
				num = (short)174629304;
				short num2 = num;
				num = (short)920494520;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1511129088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)224722944;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpComboBox.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000118EC File Offset: 0x0000FAEC
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000119A8 File Offset: 0x0000FBA8
		public global::AcpBusinessLayer.AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)1043734535;
				short num2 = num;
				num = (short)963780615;
				switch (num2 == num)
				{
				}
				num = (short)451084288;
				short num3 = num;
				num = (short)233570305;
				if (num != 0)
				{
				}
				num = (short)1866530816;
				if (num != 0)
				{
				}
				return (global::AcpBusinessLayer.AcpFieldBase)base.GetValue(global::AcpUI.AcpComboBox.MyBLObjectProperty);
			}
			set
			{
				short num = (short)1719458608;
				short num2 = num;
				num = (short)1234819888;
				switch (num2 == num)
				{
				}
				num = (short)1222246400;
				short num3 = num;
				num = (short)1531707393;
				if (num != 0)
				{
				}
				num = (short)1523384320;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpComboBox.MyBLObjectProperty, value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00011A60 File Offset: 0x0000FC60
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00011B1C File Offset: 0x0000FD1C
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)232297444;
				short num2 = num;
				num = (short)673092580;
				switch (num2 == num)
				{
				}
				num = (short)1114963968;
				short num3 = num;
				num = (short)700645377;
				if (num != 0)
				{
				}
				num = (short)2030501888;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpComboBox.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)424017022;
				short num2 = num;
				num = (short)1199373438;
				switch (num2 == num)
				{
				}
				num = (short)1767899136;
				short num3 = num;
				num = (short)2032074752;
				if (num != 0)
				{
				}
				num = (short)1565982721;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpComboBox.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00011BD4 File Offset: 0x0000FDD4
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00011C8C File Offset: 0x0000FE8C
		public global::System.Windows.Controls.Expander MyExpander
		{
			get
			{
				short num = (short)103899275;
				short num2 = num;
				num = (short)889741451;
				switch (num2 == num)
				{
				}
				num = (short)773718016;
				short num3 = num;
				num = (short)1568342016;
				if (num != 0)
				{
				}
				num = (short)1107361793;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Expander)base.GetValue(global::AcpUI.AcpComboBox.MyExpanderProperty);
			}
			set
			{
				short num = (short)783254123;
				short num2 = num;
				num = (short)874480235;
				switch (num2 == num)
				{
				}
				num = (short)577241088;
				short num3 = num;
				num = (short)1822425088;
				if (num != 0)
				{
				}
				num = (short)1494482945;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpComboBox.MyExpanderProperty, value);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00011D40 File Offset: 0x0000FF40
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00011DF8 File Offset: 0x0000FFF8
		public global::AcpUILib.IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)1529348097;
				if (num != 0)
				{
				}
				num = (short)686299559;
				short num2 = num;
				num = (short)1491343783;
				switch (num2 == num)
				{
				default:
				{
					num = (short)71630848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)209387520;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::AcpUI.AcpComboBox.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)863523345;
				short num2 = num;
				num = (short)263344657;
				switch (num2 == num)
				{
				}
				num = (short)618528768;
				short num3 = num;
				num = (short)1437466624;
				if (num != 0)
				{
				}
				num = (short)2044788737;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpComboBox.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00011EB0 File Offset: 0x000100B0
		protected override void OnMouseRightButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1997209600;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				global::AcpUI.AcpComboBox acpComboBox;
				for (;;)
				{
					IL_27:
					bool isEnabled;
					global::System.Windows.Controls.MenuItem menuItem;
					switch (num2)
					{
					case 0:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField = acpComboBox.MyBLObject as global::AcpBusinessLayer.AcpRecRefField;
						num = (short)1024458763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						isEnabled = false;
						num = (short)902823948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
						if (acpRecRefField2.PrependValues != null)
						{
							num = (short)1942487047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_360;
					}
					case 3:
						if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1426456590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E4;
					case 4:
						isEnabled = false;
						num = (short)1836187661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)1778712576;
						short num3 = num;
						try
						{
							num = (short)838664193;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2F1;
								case 1:
								{
									num = (short)563002141;
									short num4 = num;
									num = (short)241220381;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)629735424;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_242;
										}
										continue;
									}
									break;
								}
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<int> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1900609542;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1409679365;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									isEnabled = false;
									num = (short)732954628;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
									global::System.Collections.Generic.IEnumerator<int> enumerator;
									if (enumerator.Current == acpRecRefField2.Value)
									{
										num = (short)1548484611;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)1239875584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_29D:
								num = (short)1030946818;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_242:
								goto IL_29D;
							}
							IL_2F1:;
						}
						finally
						{
							num = (short)819593217;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<int> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1368064002;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_326;
									}
									continue;
								case 2:
									goto IL_35D;
								}
								IL_326:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1338376192;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_35D:;
						}
						goto IL_360;
					}
					case 6:
						goto IL_381;
					case 7:
					{
						num = (short)1681653761;
						if (num != 0)
						{
						}
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
						global::System.Collections.Generic.IEnumerator<int> enumerator = acpRecRefField2.PrependValues.GetEnumerator();
						num = (short)1411645445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
						if (acpRecRefField2.Value == -1)
						{
							num = (short)2005336068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1466630146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)2143551491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (acpComboBox != null)
						{
							num = (short)1634140160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E4;
					case 11:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
						if (acpRecRefField != null)
						{
							num = (short)1303511049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E4;
					}
					case 12:
						goto IL_360;
					case 13:
						goto IL_360;
					case 14:
					{
						global::System.Windows.Controls.ContextMenu contextMenu = new global::System.Windows.Controls.ContextMenu();
						menuItem = new global::System.Windows.Controls.MenuItem();
						menuItem.Header = global::AcpCommonResources.AcpResources.GoToItem_Id;
						menuItem.Click += this.OnContextMenuItemGoto;
						contextMenu.Items.Add(menuItem);
						base.ContextMenu = contextMenu;
						isEnabled = true;
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField2 = acpRecRefField;
						num = (short)1082916879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
						if (acpRecRefField2.UIValue == acpRecRefField2.InvalidText)
						{
							num = (short)857997313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1928331272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6E;
					IL_360:
					menuItem.IsEnabled = isEnabled;
					num = (short)412418054;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_381:
				IL_4E4:
				base.OnMouseRightButtonUp(e);
				return;
				IL_6E:
				acpComboBox = (global::AcpUI.AcpComboBox)e.Source;
				num = (short)902955018;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000123C4 File Offset: 0x000105C4
		protected virtual void OnContextMenuItemGoto(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)272957440;
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
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				global::System.Windows.Controls.MenuItem menuItem;
				for (;;)
				{
					IL_27:
					num = (short)1407516672;
					short num3 = num;
					switch (num2)
					{
					case 0:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						global::AcpCommonLib.IAcpField keyField = featureNode.KeyField;
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset.IsEmbeddedRecset && recordset.Contains(featureNode))
						{
							featureNode = (recordset.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode);
							recordset = (featureNode.Parent as global::AcpBusinessLayer.Recordset);
						}
						global::AcpCommonLib.FieldInfo a_ = new global::AcpCommonLib.FieldInfo(keyField);
						num = (short)1751646209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset.Contains(featureNode))
						{
							num = (short)481230858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
						goto IL_D6;
					case 3:
						num = (short)1670184961;
						if (num != 0)
						{
						}
						if (acpRecRefField != null)
						{
							num = (short)1799487499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						num = (short)86638604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						global::AcpBusinessLayer.Recordset recordset = featureNode.Parent as global::AcpBusinessLayer.Recordset;
						num = (short)1399586816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return;
					case 7:
					{
						global::AcpUI.AcpComboBox acpComboBox;
						acpRecRefField = (global::AcpBusinessLayer.AcpRecRefField)acpComboBox.MyBLObject;
						num = (short)1210908674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode != null)
						{
							goto IL_255;
						}
						return;
					}
					case 9:
					{
						global::AcpUI.AcpComboBox acpComboBox;
						if (acpComboBox != null)
						{
							num = (short)1333395460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
					}
					case 10:
					{
						global::AcpCommonLib.FieldInfo a_;
						global::AcpUI.Common.Utility.a(sender, a_);
						num = (short)1262419974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::AcpBusinessLayer.FeatureNode featureNode = acpRecRefField.ReferencedNode;
						num = (short)649265160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::AcpUI.AcpComboBox acpComboBox;
						if (acpComboBox.MyBLObject != null)
						{
							num = (short)1178599431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
					}
					case 13:
						if (menuItem != null)
						{
							num = (short)1550909454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
					case 14:
					{
						global::AcpUI.AcpComboBox acpComboBox = (global::AcpUI.AcpComboBox)((global::System.Windows.Controls.ContextMenu)menuItem.Parent).PlacementTarget;
						num = (short)196526609;
						short num4 = num;
						num = (short)1821098513;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_255;
						default:
							num = (short)947912704;
							if (num != 0)
							{
							}
							num = (short)1572470793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_93;
					IL_D6:
					num = (short)1679622147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_255:
					num = (short)1617297413;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_93:
				acpRecRefField = null;
				menuItem = (sender as global::System.Windows.Controls.MenuItem);
				num = (short)1795751949;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0001272C File Offset: 0x0001092C
		public AcpComboBox()
		{
			base.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00012748 File Offset: 0x00010948
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1309069988;
				short num2 = num;
				num = (short)373346980;
				switch (num2 == num)
				{
				}
				num = (short)877068288;
				if (num != 0)
				{
				}
			}
			finally
			{
				num = (short)1428291585;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)1367080960;
			short num3 = num;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00012808 File Offset: 0x00010A08
		protected override void OnDropDownOpened(global::System.EventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField acpListField;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)951450706;
					short num3 = num2;
					num2 = (short)88341586;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)898039808;
						if (num2 != 0)
						{
						}
						acpListField.CalculateItemsValidity();
						num2 = (short)1844379649;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_119;
				case 2:
					if (acpListField != null)
					{
						num2 = (short)100859904;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11B;
				}
				goto IL_1C;
			}
			IL_119:
			IL_11B:
			base.OnDropDownOpened(e);
			return;
			IL_1C:
			num2 = (short)1908736001;
			if (num2 != 0)
			{
			}
			acpListField = (this.MyBLObject as global::AcpBusinessLayer.AcpListField);
			num2 = (short)1952448512;
			short num4 = num2;
			num2 = (short)1361903618;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00012938 File Offset: 0x00010B38
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)514719744;
			switch (num)
			{
			default:
			{
				num = (short)1954349089;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num4;
					global::AcpBusinessLayer.AcpListField acpListField;
					int num5;
					string text;
					switch (num2)
					{
					case 0:
						if (e.Key == global::System.Windows.Input.Key.End)
						{
							num = (short)309133372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4E;
					case 1:
					{
						int num3;
						if (num3 < 0)
						{
							num = (short)783351832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1370161205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (e.Key >= global::System.Windows.Input.Key.D0)
						{
							num = (short)1323106320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C0C;
					case 3:
						goto IL_387;
					case 4:
						num = (short)57212991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_B66;
					case 6:
						if (num4 >= acpListField.Items.Count)
						{
							num = (short)90701896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)368312364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (acpListField.Items[num5].ToString().ToUpper().StartsWith(text))
						{
							num = (short)1397948471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AD;
					case 8:
					{
						int num6;
						if (num6 >= acpListField.Items.Count)
						{
							num = (short)2125856835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1812660258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1964048435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)349765675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_4D9;
					case 12:
						text = text.Substring(6);
						num = (short)1811546129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						int num7;
						int num8;
						if (num7 < num8)
						{
							num = (short)1767374869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)630128663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_C0C;
					case 15:
					{
						int num3;
						base.SelectedIndex = num3;
						num = (short)1080819743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num = (short)519045138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_301;
					case 18:
						if (e.Key <= global::System.Windows.Input.Key.D9)
						{
							num = (short)1365442599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C0C;
					case 19:
						num = (short)1794637831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						int num6 = 0;
						num = (short)1345257524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						num = (short)1640693792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_2A8;
					case 23:
					{
						int num7;
						if (acpListField.Items[num7].ItemVisibility)
						{
							num = (short)977862701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1230700544;
						short num9 = num;
						num7--;
						num = (short)1528889390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_B9F;
					case 25:
						goto IL_419;
					case 26:
						goto IL_195;
					case 27:
						goto IL_B15;
					case 28:
						goto IL_B1A;
					case 29:
						if (acpListField.Items[num5].ItemVisibility)
						{
							num = (short)886767635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AD;
					case 30:
					{
						int num10;
						base.SelectedIndex = num10;
						num = (short)55377970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_98C;
					case 32:
						goto IL_414;
					case 33:
						switch (0)
						{
						case 0:
							goto IL_16C;
						}
						continue;
					case 34:
					{
						int num6;
						if (acpListField.Items[num6].ItemVisibility)
						{
							num = (short)1892352065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6++;
						num = (short)699072561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
					{
						int num10;
						int num11;
						if (num10 > num11)
						{
							num = (short)1851260970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1525153850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						goto IL_C07;
					case 37:
						num = (short)1123876930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_671;
					case 39:
						text = text.Substring(1);
						num = (short)1930756110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						goto IL_671;
					case 41:
						num5 = 0;
						num = (short)592642076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						num = (short)1513553991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (e.Key <= global::System.Windows.Input.Key.NumPad9)
						{
							num = (short)1850605580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_301;
					case 44:
						if (num5 >= acpListField.Items.Count)
						{
							num = (short)250609705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B1A;
					case 45:
					{
						int num7;
						base.SelectedIndex = num7;
						num = (short)776273942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
					{
						num = (short)1563105584;
						short num12 = num;
						num = (short)515119408;
						switch ((num12 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BE7;
						default:
							num = (short)42139648;
							if (num != 0)
							{
							}
							goto IL_419;
						}
						break;
					}
					case 47:
						goto IL_B66;
					case 48:
						goto IL_195;
					case 49:
						goto IL_A6D;
					case 50:
						goto IL_6D1;
					case 51:
						if (e.Key > global::System.Windows.Input.Key.Z)
						{
							num = (short)1092747275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51E;
					case 52:
						goto IL_A6D;
					case 53:
					{
						int num3;
						if (acpListField.Items[num3].ItemVisibility)
						{
							num = (short)2050162703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3--;
						num = (short)237371397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
						if (e.Key == global::System.Windows.Input.Key.Home)
						{
							num = (short)2078015508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1865416704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						goto IL_BE7;
					case 56:
						goto IL_66C;
					case 57:
						goto IL_190;
					case 58:
					{
						int num10;
						if (acpListField.Items[num10].ItemVisibility)
						{
							num = (short)468385822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num10++;
						num = (short)276037670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						if (e.Key >= global::System.Windows.Input.Key.NumPad0)
						{
							num = (short)1823866884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BA4;
					case 60:
					{
						int num3 = acpListField.Items.Count - 1;
						num = (short)993656879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 61:
					{
						int num10 = base.SelectedIndex + 1;
						int num11 = acpListField.Items.Count - 1;
						num = (short)1340932136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						if (e.Key >= global::System.Windows.Input.Key.D0)
						{
							num = (short)1951268873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D9;
					case 63:
						if (e.Key <= global::System.Windows.Input.Key.NumPad9)
						{
							num = (short)1848049734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BA4;
					case 64:
						if (acpListField != null)
						{
							num = (short)1701969957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4E;
					case 65:
					{
						int num6;
						base.SelectedIndex = num6;
						num = (short)358940728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 66:
						if (e.Key == global::System.Windows.Input.Key.Up)
						{
							num = (short)433913925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1653145673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						num = (short)617611267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						if (e.Key >= global::System.Windows.Input.Key.NumPad0)
						{
							num = (short)427163658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_301;
					case 69:
					{
						int num7 = base.SelectedIndex - 1;
						int num8 = 0;
						num = (short)24248345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 70:
						goto IL_51E;
					case 71:
						goto IL_5E9;
					case 72:
						num = (short)1201602587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						if (e.Key == global::System.Windows.Input.Key.Down)
						{
							num = (short)1528299581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)295370814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_16C:
					if (e.Key == global::System.Windows.Input.Key.Tab)
					{
						num = (short)1036648505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num5 = base.SelectedIndex + 1;
					acpListField = (this.MyBLObject as global::AcpBusinessLayer.AcpListField);
					num = (short)1099563072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_195:
					num = (short)2090467334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AD:
					num5++;
					num4++;
					num = (short)1789263898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_301:
					num4 = 0;
					num = (short)222101552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_419:
					num = (short)1228800013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D9:
					num = (short)834011195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51E:
					text = e.Key.ToString();
					num = (short)1759641602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_671:
					num = (short)664731683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A6D:
					num = (short)206831624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B1A:
					num = (short)548208669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B66:
					num = (short)274137089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BA4:
					num = (short)1202061366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BE7:
					base.SelectedIndex = num5;
					num = (short)2133852196;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C0C:
					num = (short)1076166724;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_190:
				base.OnKeyDown(e);
				return;
				IL_2A8:
				IL_387:
				IL_414:
				goto IL_C4E;
				IL_5E9:
				num = (short)208142337;
				if (num != 0)
				{
				}
				IL_66C:
				IL_6D1:
				IL_98C:
				IL_B15:
				IL_B9F:
				IL_C07:
				IL_C4E:
				e.Handled = true;
				return;
			}
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0001359C File Offset: 0x0001179C
		// Note: this type is marked as 'beforefieldinit'.
		static AcpComboBox()
		{
			int a_ = 9;
			short num = (short)795938321;
			short num2 = num;
			num = (short)313986577;
			switch (num2 == num)
			{
			}
			num = (short)7667713;
			if (num != 0)
			{
			}
			num = (short)545783808;
			short num3 = num;
			num = (short)1708589056;
			if (num != 0)
			{
			}
			global::AcpUI.AcpComboBox.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("횞튠욤힦ﾨ쪪솬욮햰", a_), typeof(bool), typeof(global::AcpUI.AcpComboBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpComboBox.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("횞튠욤힦\udbaa\uddac쎮\ud8b0킲풴햶햸\udeba", a_), typeof(bool), typeof(global::AcpUI.AcpComboBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpComboBox.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("횞튠욤힦쾪쒬\udbae킰톲\ud9b4튶", a_), typeof(bool), typeof(global::AcpUI.AcpComboBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpComboBox.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("횞튠욤힦ﾨ슪\udeac욮펰\udfb2킴", a_), typeof(bool), typeof(global::AcpUI.AcpComboBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpComboBox.MyLabelCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("튞\ud8a0쒤얦첨잪\udbae쎰\udfb2", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpComboBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpComboBox.MyCopyButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("튞\ud8a0쪤힦킨\ud8ac\udbae얰\udcb2\udbb4춸즺톼", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpComboBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpComboBox.MyBLObjectProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("튞\ud8a0쮨솪좬첮얰", a_), typeof(global::AcpBusinessLayer.AcpFieldBase), typeof(global::AcpUI.AcpComboBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpComboBox.AreValuesEqualProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ude9e펠욢욦얨\udeaa좬\udcae슲살횶햸", a_), typeof(bool), typeof(global::AcpUI.AcpComboBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpComboBox.MyExpanderProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("튞\ud8a0\udda4힦좨얪즬쪮쎰", a_), typeof(global::System.Windows.Controls.Expander), typeof(global::AcpUI.AcpComboBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpComboBox.MyParentCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("튞\ud8a0쒤햦첨얪\ud9ac얰솲\ud9b4", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::AcpUI.AcpComboBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x04000115 RID: 277
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x04000116 RID: 278
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x04000117 RID: 279
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x04000118 RID: 280
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x04000119 RID: 281
		public static readonly global::System.Windows.DependencyProperty MyLabelCtrlProperty;

		// Token: 0x0400011A RID: 282
		public static readonly global::System.Windows.DependencyProperty MyCopyButtonProperty;

		// Token: 0x0400011B RID: 283
		public static readonly global::System.Windows.DependencyProperty MyBLObjectProperty;

		// Token: 0x0400011C RID: 284
		public static readonly global::System.Windows.DependencyProperty AreValuesEqualProperty;

		// Token: 0x0400011D RID: 285
		public static readonly global::System.Windows.DependencyProperty MyExpanderProperty;

		// Token: 0x0400011E RID: 286
		public static readonly global::System.Windows.DependencyProperty MyParentCtrlProperty;
	}
}
