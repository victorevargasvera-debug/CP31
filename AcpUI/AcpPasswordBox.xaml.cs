using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using AcpBusinessLayer;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x02000024 RID: 36
	public partial class AcpPasswordBox : UserControl, IAcpUICtrlBase, IAcpUIValueCtrlBase<string>, IAcpUIParentCtrlBase, IAcpUIChildCtrlBase, IAcpUICommon
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00024070 File Offset: 0x00022270
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00024128 File Offset: 0x00022328
		public string Value
		{
			get
			{
				short num = (short)2041405794;
				short num2 = num;
				num = (short)568418658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1052508160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2061631489;
				if (num != 0)
				{
				}
				num = (short)1087569920;
				if (num != 0)
				{
				}
				return this.b.Password;
			}
			set
			{
				short num = (short)133168371;
				short num2 = num;
				num = (short)217578739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1536098304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)66715649;
				if (num != 0)
				{
				}
				num = (short)1548550144;
				if (num != 0)
				{
				}
				this.b.Password = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000241DC File Offset: 0x000223DC
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00024298 File Offset: 0x00022498
		public bool IsAcpValid
		{
			get
			{
				short num = (short)698609897;
				short num2 = num;
				num = (short)1465970921;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1989279744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1114374144;
				if (num != 0)
				{
				}
				num = (short)2141585409;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpPasswordBox.IsAcpValidProperty);
			}
			set
			{
				short num = (short)1173505464;
				short num2 = num;
				num = (short)1834042808;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1240072192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1238499329;
				if (num != 0)
				{
				}
				num = (short)1374355456;
				if (num != 0)
				{
				}
				base.SetValue(AcpPasswordBox.IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00024354 File Offset: 0x00022554
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x0002440C File Offset: 0x0002260C
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)1300010876;
				short num2 = num;
				num = (short)874026876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964507136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)176291841;
				if (num != 0)
				{
				}
				num = (short)1168900096;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpPasswordBox.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2096329271;
				short num2 = num;
				num = (short)932475447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1457651712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1483800576;
				if (num != 0)
				{
				}
				num = (short)1981677569;
				if (num != 0)
				{
				}
				base.SetValue(AcpPasswordBox.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000244C4 File Offset: 0x000226C4
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00024580 File Offset: 0x00022780
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)856836971;
				short num2 = num;
				num = (short)1229867883;
				switch (num2 == num)
				{
				default:
				{
					num = (short)526188544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)824115201;
				if (num != 0)
				{
				}
				num = (short)2137587712;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpPasswordBox.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)980680705;
				if (num != 0)
				{
				}
				num = (short)1332609024;
				short num2 = num;
				num = (short)1500551172;
				short num3 = num;
				num = (short)707762180;
				switch (num3 == num)
				{
				}
				num = (short)2075983872;
				if (num != 0)
				{
				}
				base.SetValue(AcpPasswordBox.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0002463C File Offset: 0x0002283C
		// (set) Token: 0x060001FC RID: 508 RVA: 0x000246F4 File Offset: 0x000228F4
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)660533031;
				short num2 = num;
				num = (short)993062695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)879230976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1780154369;
				if (num != 0)
				{
				}
				num = (short)697171968;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpPasswordBox.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1779027057;
				short num2 = num;
				num = (short)1912654961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1290600448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1741225984;
				if (num != 0)
				{
				}
				num = (short)1015676929;
				if (num != 0)
				{
				}
				base.SetValue(AcpPasswordBox.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000247B0 File Offset: 0x000229B0
		// (set) Token: 0x060001FE RID: 510 RVA: 0x0002486C File Offset: 0x00022A6C
		public IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)2023702744;
				short num2 = num;
				num = (short)616775896;
				switch (num2 == num)
				{
				default:
				{
					num = (short)518520832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1242628096;
				if (num != 0)
				{
				}
				num = (short)812318721;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpPasswordBox.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)797949109;
				short num2 = num;
				num = (short)1168817333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1248788480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1861746689;
				if (num != 0)
				{
				}
				num = (short)1548156928;
				if (num != 0)
				{
				}
				base.SetValue(AcpPasswordBox.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00024920 File Offset: 0x00022B20
		// (set) Token: 0x06000200 RID: 512 RVA: 0x000249D8 File Offset: 0x00022BD8
		public IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)48367458;
				short num2 = num;
				num = (short)352978786;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1496842240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1092878336;
				if (num != 0)
				{
				}
				num = (short)1560805377;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpPasswordBox.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)1810300929;
				if (num != 0)
				{
				}
				num = (short)672006144;
				short num2 = num;
				num = (short)1050666695;
				short num3 = num;
				num = (short)1116333767;
				switch (num3 == num)
				{
				}
				num = (short)1560936448;
				if (num != 0)
				{
				}
				base.SetValue(AcpPasswordBox.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00024A90 File Offset: 0x00022C90
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00024B48 File Offset: 0x00022D48
		public AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)1736318831;
				short num2 = num;
				num = (short)5316463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)957939712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)131006465;
				if (num != 0)
				{
				}
				num = (short)1097596928;
				if (num != 0)
				{
				}
				return (AcpFieldBase)base.GetValue(AcpPasswordBox.MyBLObjectProperty);
			}
			set
			{
				short num = (short)731512833;
				if (num != 0)
				{
				}
				num = (short)1833762816;
				short num2 = num;
				num = (short)215572579;
				short num3 = num;
				num = (short)233267299;
				switch (num3 == num)
				{
				}
				num = (short)695009280;
				if (num != 0)
				{
				}
				base.SetValue(AcpPasswordBox.MyBLObjectProperty, value);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00024C00 File Offset: 0x00022E00
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00024CB8 File Offset: 0x00022EB8
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)1618804737;
				if (num != 0)
				{
				}
				num = (short)1426718720;
				short num2 = num;
				num = (short)1683404723;
				short num3 = num;
				num = (short)682538931;
				switch (num3 == num)
				{
				}
				num = (short)881655808;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpPasswordBox.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)58593306;
				short num2 = num;
				num = (short)1791692826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)331153408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)851771393;
				if (num != 0)
				{
				}
				num = (short)2106064896;
				if (num != 0)
				{
				}
				base.SetValue(AcpPasswordBox.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00024D74 File Offset: 0x00022F74
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00024E2C File Offset: 0x0002302C
		public Expander MyExpander
		{
			get
			{
				short num = (short)524550145;
				if (num != 0)
				{
				}
				num = (short)1437663232;
				short num2 = num;
				num = (short)26085866;
				short num3 = num;
				num = (short)1205144042;
				switch (num3 == num)
				{
				}
				num = (short)351535104;
				if (num != 0)
				{
				}
				return (Expander)base.GetValue(AcpPasswordBox.MyExpanderProperty);
			}
			set
			{
				short num = (short)1563365049;
				short num2 = num;
				num = (short)1328418489;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1009844224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)168820737;
				if (num != 0)
				{
				}
				num = (short)267976704;
				if (num != 0)
				{
				}
				base.SetValue(AcpPasswordBox.MyExpanderProperty, value);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00024EE0 File Offset: 0x000230E0
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00024F9C File Offset: 0x0002319C
		public IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)1681628954;
				short num2 = num;
				num = (short)81960730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1848180736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2027487233;
				if (num != 0)
				{
				}
				num = (short)558563328;
				if (num != 0)
				{
				}
				return (IAcpUIParentCtrlBase)base.GetValue(AcpPasswordBox.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)1066695984;
				short num2 = num;
				num = (short)758676784;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1400963072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1096351745;
				if (num != 0)
				{
				}
				num = (short)336527360;
				if (num != 0)
				{
				}
				base.SetValue(AcpPasswordBox.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00025054 File Offset: 0x00023254
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00025110 File Offset: 0x00023310
		public bool IsDigitOnly
		{
			get
			{
				short num = (short)1865824313;
				short num2 = num;
				num = (short)228341817;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1004142592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)431292417;
				if (num != 0)
				{
				}
				num = (short)574357504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpPasswordBox.IsDigitOnlyProperty);
			}
			set
			{
				short num = (short)587554044;
				short num2 = num;
				num = (short)687299836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1571094528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2147024897;
				if (num != 0)
				{
				}
				num = (short)1230110720;
				if (num != 0)
				{
				}
				base.SetValue(AcpPasswordBox.IsDigitOnlyProperty, value);
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000251C8 File Offset: 0x000233C8
		private void AcpPasswordBox_OnPreviewKeyDown(object A_0, KeyEventArgs A_1)
		{
			short num = (short)372572175;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_1.Key != Key.D6)
					{
						num = (short)26607621;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_143C;
				case 1:
					if (A_1.Key >= Key.D0)
					{
						num = (short)1698955297;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1021;
				case 2:
					num = (short)1556021283;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					num = (short)1410727957;
					num2 = (int)((IntPtr)num);
					continue;
				case 4:
					if (A_1.Key != Key.OemComma)
					{
						num = (short)651100280;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3FE;
				case 5:
					num = (short)1036845180;
					num2 = (int)((IntPtr)num);
					continue;
				case 6:
					goto IL_12DD;
				case 7:
					if (Keyboard.Modifiers == ModifierKeys.Shift)
					{
						num = (short)1047789568;
						short num3 = num;
						num = (short)459669600;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1260;
				case 8:
					num = (short)1604386938;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
					return;
				case 10:
					if (A_1.Key == Key.Decimal)
					{
						num = (short)1520369785;
						num2 = (int)((IntPtr)num);
						continue;
					}
					A_1.Handled = true;
					num = (short)515309569;
					if (num != 0)
					{
					}
					num = (short)915079262;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
					goto IL_11B6;
				case 12:
					if (A_1.Key == Key.Delete)
					{
						num = (short)1085800573;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.a = false;
					num = (short)591855622;
					num2 = (int)((IntPtr)num);
					continue;
				case 13:
					num = (short)702349332;
					num2 = (int)((IntPtr)num);
					continue;
				case 14:
					IL_41C:
					goto IL_B15;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_24D;
					}
					continue;
				case 16:
					num = (short)236716160;
					num2 = (int)((IntPtr)num);
					continue;
				case 17:
					if (A_1.Key != Key.D8)
					{
						num = (short)1683226640;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C7B;
				case 18:
					if (A_1.Key != Key.Return)
					{
						num = (short)1154220059;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C57;
				case 19:
					if (A_1.Key != Key.Return)
					{
						num = (short)354877448;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_8DC;
				case 20:
					if (A_1.Key != Key.Oem6)
					{
						num = (short)650313793;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3FE;
				case 21:
					if (A_1.Key != Key.Left)
					{
						num = (short)404226101;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1460;
				case 22:
					goto IL_B15;
				case 23:
					if (A_1.Key != Key.Oem5)
					{
						num = (short)209453069;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3FE;
				case 24:
					if (A_1.Key == Key.OemMinus)
					{
						num = (short)1127153751;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_692;
				case 25:
					if (A_1.Key != Key.Home)
					{
						num = (short)1152516169;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1460;
				case 26:
					goto IL_B15;
				case 27:
					num = (short)2012217478;
					num2 = (int)((IntPtr)num);
					continue;
				case 28:
					num = (short)236191835;
					num2 = (int)((IntPtr)num);
					continue;
				case 29:
					goto IL_C7B;
				case 30:
					if (Keyboard.Modifiers == ModifierKeys.Shift)
					{
						num = (short)2105802816;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_692;
				case 31:
					num = (short)1870069883;
					num2 = (int)((IntPtr)num);
					continue;
				case 32:
					if (A_1.Key != Key.Oem2)
					{
						num = (short)1341915193;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_112B;
				case 33:
					num = (short)2099904643;
					num2 = (int)((IntPtr)num);
					continue;
				case 34:
					if (A_1.Key != Key.Oem7)
					{
						num = (short)1318387748;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3FE;
				case 35:
					if (A_1.Key != Key.D5)
					{
						num = (short)729612319;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C7B;
				case 36:
					num = (short)809893892;
					num2 = (int)((IntPtr)num);
					continue;
				case 37:
					if (A_1.Key != Key.Oem4)
					{
						num = (short)445382775;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3FE;
				case 38:
					goto IL_B15;
				case 39:
					if (A_1.Key != Key.Oem2)
					{
						num = (short)2001862708;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_143C;
				case 40:
					if (A_1.Key == Key.Delete)
					{
						num = (short)1007026281;
						num2 = (int)((IntPtr)num);
						continue;
					}
					A_1.Handled = true;
					num = (short)1668939802;
					num2 = (int)((IntPtr)num);
					continue;
				case 41:
					goto IL_8DC;
				case 42:
					num = (short)1800863881;
					num2 = (int)((IntPtr)num);
					continue;
				case 43:
					if (A_1.Key == Key.End)
					{
						num = (short)153878618;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 44:
					num = (short)1524039719;
					num2 = (int)((IntPtr)num);
					continue;
				case 45:
					num = (short)194248759;
					num2 = (int)((IntPtr)num);
					continue;
				case 46:
					num = (short)861012022;
					num2 = (int)((IntPtr)num);
					continue;
				case 47:
					if (A_1.Key != Key.RightShift)
					{
						num = (short)1263206445;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_8DC;
				case 48:
					num = (short)1616904204;
					num2 = (int)((IntPtr)num);
					continue;
				case 49:
					if (A_1.Key != Key.Right)
					{
						num = (short)597688323;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1460;
				case 50:
					if (A_1.Key > Key.NumPad9)
					{
						num = (short)1016135751;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C57;
				case 51:
					goto IL_B15;
				case 52:
					num = (short)989724696;
					num2 = (int)((IntPtr)num);
					continue;
				case 53:
					num = (short)1247805465;
					num2 = (int)((IntPtr)num);
					continue;
				case 54:
					if (A_1.Key != Key.OemPlus)
					{
						num = (short)1387266155;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3FE;
				case 55:
					if (A_1.Key != Key.LeftShift)
					{
						num = (short)2070937714;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_8DC;
				case 56:
					num = (short)459866149;
					num2 = (int)((IntPtr)num);
					continue;
				case 57:
					num = (short)788594817;
					num2 = (int)((IntPtr)num);
					continue;
				case 58:
					goto IL_1021;
				case 59:
					if (A_1.Key != Key.Oem1)
					{
						num = (short)2490480;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3FE;
				case 60:
					num = (short)1931214926;
					num2 = (int)((IntPtr)num);
					continue;
				case 61:
					num = (short)1709637718;
					num2 = (int)((IntPtr)num);
					continue;
				case 62:
					num = (short)1434714248;
					num2 = (int)((IntPtr)num);
					continue;
				case 63:
					goto IL_B15;
				case 64:
					num = (short)1823080565;
					num2 = (int)((IntPtr)num);
					continue;
				case 65:
					num = (short)1530200098;
					num2 = (int)((IntPtr)num);
					continue;
				case 66:
					num = (short)1538392167;
					num2 = (int)((IntPtr)num);
					continue;
				case 67:
					num = (short)47972352;
					num2 = (int)((IntPtr)num);
					continue;
				case 68:
					if (A_1.Key != Key.Oem3)
					{
						num = (short)263127096;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3FE;
				case 69:
					num = (short)1443627135;
					num2 = (int)((IntPtr)num);
					continue;
				case 70:
					A_1.Handled = false;
					num = (short)721748070;
					num2 = (int)((IntPtr)num);
					continue;
				case 71:
					goto IL_37E;
				case 72:
					if (A_1.Key != Key.OemPeriod)
					{
						num = (short)1865678894;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_3FE;
				case 73:
					num = (short)1150615595;
					num2 = (int)((IntPtr)num);
					continue;
				case 74:
					goto IL_12DD;
				case 75:
					goto IL_112B;
				case 76:
					num = (short)1879703592;
					num2 = (int)((IntPtr)num);
					continue;
				case 77:
					if (char.IsNumber(new KeyConverter().ConvertToString(A_1.Key)[0]))
					{
						num = (short)159187037;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_F1B;
				case 78:
					if (A_1.Key != Key.Add)
					{
						num = (short)1525022782;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_11B6;
				case 79:
					A_1.Handled = false;
					num = (short)672661604;
					num2 = (int)((IntPtr)num);
					continue;
				case 80:
					goto IL_F1B;
				case 81:
					num = (short)2090598485;
					num2 = (int)((IntPtr)num);
					continue;
				case 82:
					if (A_1.Key != Key.Subtract)
					{
						num = (short)994902076;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_11B6;
				case 83:
					if (A_1.Key != Key.OemPlus)
					{
						num = (short)346947714;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C7B;
				case 84:
					goto IL_B15;
				case 85:
					if (A_1.Key == Key.Delete)
					{
						num = (short)1026949161;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)75104345;
					num2 = (int)((IntPtr)num);
					continue;
				case 86:
					if (A_1.Key != Key.Back)
					{
						num = (short)1809055825;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_8DC;
				case 87:
					goto IL_143C;
				case 88:
					if (A_1.Key != Key.D7)
					{
						num = (short)1085734914;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C7B;
				case 89:
					if (Keyboard.Modifiers == ModifierKeys.None)
					{
						num = (short)755630177;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C9E;
				case 90:
					goto IL_1460;
				case 91:
					if (A_1.Key != Key.D0)
					{
						num = (short)51052588;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_143C;
				case 92:
					if (A_1.Key == Key.Space)
					{
						num = (short)321323087;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C9E;
				case 93:
					num = (short)1080033415;
					num2 = (int)((IntPtr)num);
					continue;
				case 94:
					goto IL_B15;
				case 95:
					if (A_1.Key == Key.Multiply)
					{
						num = (short)829620235;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)897712129;
					num2 = (int)((IntPtr)num);
					continue;
				case 96:
					num = (short)253296723;
					num2 = (int)((IntPtr)num);
					continue;
				case 97:
					num = (short)399310940;
					num2 = (int)((IntPtr)num);
					continue;
				case 98:
					A_1.Handled = false;
					num = (short)690159725;
					num2 = (int)((IntPtr)num);
					continue;
				case 99:
					num = (short)220135530;
					num2 = (int)((IntPtr)num);
					continue;
				case 100:
					goto IL_B15;
				case 101:
					if (A_1.Key >= Key.NumPad0)
					{
						num = (short)1381630078;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_37E;
				case 102:
					goto IL_B15;
				case 103:
					if (A_1.Key != Key.Back)
					{
						num = (short)479526960;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_941;
				case 104:
					num = (short)227934341;
					num2 = (int)((IntPtr)num);
					continue;
				case 105:
					goto IL_C57;
				case 106:
					if (A_1.Key > Key.NumPad9)
					{
						num = (short)719257708;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_11B6;
				case 107:
					num = (short)1269235722;
					num2 = (int)((IntPtr)num);
					continue;
				case 108:
					goto IL_988;
				case 109:
					goto IL_B15;
				case 110:
					num = (short)171835487;
					num2 = (int)((IntPtr)num);
					continue;
				case 111:
					if (A_1.Key >= Key.A)
					{
						num = (short)1638442;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_EB4;
				case 112:
					num = (short)1718812740;
					num2 = (int)((IntPtr)num);
					continue;
				case 113:
					if (Keyboard.Modifiers == ModifierKeys.None)
					{
						num = (short)857473122;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1066;
				case 114:
					num = (short)56033299;
					num2 = (int)((IntPtr)num);
					continue;
				case 115:
					num = (short)1304887384;
					num2 = (int)((IntPtr)num);
					continue;
				case 116:
					if (A_1.Key >= Key.NumPad0)
					{
						num = (short)2134966371;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_988;
				case 117:
					if (A_1.Key != Key.D1)
					{
						num = (short)578420840;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_143C;
				case 118:
					if (this.IsDigitOnly)
					{
						num = (short)581173380;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1166082095;
					num2 = (int)((IntPtr)num);
					continue;
				case 119:
					num = (short)7733271;
					num2 = (int)((IntPtr)num);
					continue;
				case 120:
					num = (short)178126920;
					num2 = (int)((IntPtr)num);
					continue;
				case 121:
					goto IL_3FE;
				case 122:
					if (A_1.Key != Key.Tab)
					{
						num = (short)990576701;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_8DC;
				case 123:
					if (A_1.Key == Key.D4)
					{
						num = (short)212074525;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1260;
				case 124:
					if (A_1.Key != Key.D9)
					{
						num = (short)1332019228;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_143C;
				case 125:
					goto IL_941;
				case 126:
					num = (short)1072431154;
					num2 = (int)((IntPtr)num);
					continue;
				case 127:
					if (A_1.Key != Key.Back)
					{
						num = (short)1548484684;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C57;
				case 128:
					if (A_1.Key != Key.D3)
					{
						num = (short)1762787443;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C7B;
				case 129:
					if (A_1.Key == Key.OemMinus)
					{
						num = (short)654114891;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1066;
				case 130:
					num = (short)585236497;
					num2 = (int)((IntPtr)num);
					continue;
				case 131:
					if (A_1.Key > Key.D9)
					{
						num = (short)316342330;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_112B;
				case 132:
					num = (short)1899364429;
					num2 = (int)((IntPtr)num);
					continue;
				case 133:
					if (A_1.Key != Key.D2)
					{
						num = (short)1291714627;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_143C;
				case 134:
					if (A_1.Key != Key.Tab)
					{
						num = (short)1488453701;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C57;
				case 135:
					if (Keyboard.Modifiers != ModifierKeys.None)
					{
						num = (short)1986723920;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C57;
				case 136:
					if (A_1.Key != Key.Divide)
					{
						num = (short)1184825454;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_11B6;
				case 137:
					if (A_1.Key <= Key.Z)
					{
						num = (short)184090694;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_EB4;
				}
				IL_24D:
				if (A_0 is PasswordBox)
				{
					num = (short)1263468610;
					num2 = (int)((IntPtr)num);
					continue;
				}
				break;
				IL_37E:
				num = (short)1842413586;
				num2 = (int)((IntPtr)num);
				continue;
				IL_3FE:
				A_1.Handled = false;
				num = (short)1541799950;
				num2 = (int)((IntPtr)num);
				continue;
				IL_692:
				num = (short)1681784891;
				num2 = (int)((IntPtr)num);
				continue;
				IL_8DC:
				A_1.Handled = false;
				num = (short)873201686;
				num2 = (int)((IntPtr)num);
				continue;
				IL_941:
				this.a = true;
				num = (short)1592197194;
				num2 = (int)((IntPtr)num);
				continue;
				IL_988:
				num = (short)954859602;
				num2 = (int)((IntPtr)num);
				continue;
				IL_B15:
				num = (short)1088749617;
				num2 = (int)((IntPtr)num);
				continue;
				IL_112B:
				num = (short)1976047243;
				short num4 = num;
				num = (short)147789451;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_41C;
				default:
					num = (short)1149566976;
					if (num != 0)
					{
					}
					num = (short)1906376817;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_C57:
				A_1.Handled = false;
				num = (short)1952120916;
				num2 = (int)((IntPtr)num);
				continue;
				IL_C7B:
				A_1.Handled = false;
				num = (short)1964376102;
				num2 = (int)((IntPtr)num);
				continue;
				IL_C9E:
				num = (short)653459572;
				num2 = (int)((IntPtr)num);
				continue;
				IL_EB4:
				num = (short)564264967;
				num2 = (int)((IntPtr)num);
				continue;
				IL_F1B:
				num = (short)1876820069;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1021:
				num = (short)805961760;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1066:
				num = (short)1872035951;
				num2 = (int)((IntPtr)num);
				continue;
				IL_11B6:
				A_1.Handled = false;
				num = (short)984350771;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1260:
				num = (short)1844969502;
				num2 = (int)((IntPtr)num);
				continue;
				IL_12DD:
				num = (short)1533870198;
				num2 = (int)((IntPtr)num);
				continue;
				IL_143C:
				A_1.Handled = false;
				num = (short)1404436543;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1460:
				A_1.Handled = false;
				num = (short)504561673;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0002667C File Offset: 0x0002487C
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00026734 File Offset: 0x00024934
		public int MaxPasswordLength
		{
			get
			{
				short num = (short)289437156;
				short num2 = num;
				num = (short)1366390244;
				switch (num2 == num)
				{
				}
				num = (short)288292864;
				if (num != 0)
				{
				}
				num = (short)130547713;
				if (num != 0)
				{
				}
				num = (short)2052128768;
				short num3 = num;
				return (int)base.GetValue(AcpPasswordBox.MaxPasswordLengthProperty);
			}
			set
			{
				short num = (short)915490151;
				short num2 = num;
				num = (short)283919719;
				switch (num2 == num)
				{
				}
				num = (short)1097334784;
				if (num != 0)
				{
				}
				num = (short)1322647553;
				if (num != 0)
				{
				}
				num = (short)1556676608;
				short num3 = num;
				base.SetValue(AcpPasswordBox.MaxPasswordLengthProperty, value);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600020E RID: 526 RVA: 0x000267F0 File Offset: 0x000249F0
		// (set) Token: 0x0600020F RID: 527 RVA: 0x000268A8 File Offset: 0x00024AA8
		public string PIN
		{
			get
			{
				short num = (short)1852280410;
				short num2 = num;
				num = (short)1872465498;
				switch (num2 == num)
				{
				}
				num = (short)497614849;
				if (num != 0)
				{
				}
				num = (short)823656448;
				if (num != 0)
				{
				}
				num = (short)486342656;
				short num3 = num;
				return (string)base.GetValue(AcpPasswordBox.PINProperty);
			}
			set
			{
				short num = (short)312846980;
				short num2 = num;
				num = (short)524593796;
				switch (num2 == num)
				{
				}
				num = (short)1673658368;
				if (num != 0)
				{
				}
				num = (short)1909981185;
				if (num != 0)
				{
				}
				num = (short)1048182784;
				short num3 = num;
				base.SetValue(AcpPasswordBox.PINProperty, value);
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0002695C File Offset: 0x00024B5C
		public AcpPasswordBox()
		{
			this.InitializeComponent();
			base.Focusable = true;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0002697C File Offset: 0x00024B7C
		private void AcpPasswordBox_LostFocus(object A_0, RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			PasswordBox passwordBox;
			for (;;)
			{
				IL_0A:
				string text;
				switch (num)
				{
				case 0:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)856686593;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_D8;
				case 1:
					text = Utility.FilterArabicDiacritics(text);
					num2 = (short)2115960837;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1837758871;
					short num3 = num2;
					num2 = (short)42662295;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15F;
					default:
						num2 = (short)2028863488;
						if (num2 != 0)
						{
						}
						if (passwordBox != null)
						{
							num2 = (short)1164378116;
							num = (int)((IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 3:
					return;
				case 4:
					num2 = (short)1115226113;
					if (num2 != 0)
					{
					}
					text = passwordBox.Password;
					goto IL_15F;
				case 5:
				{
					num2 = (short)822345728;
					short num4 = num2;
					goto IL_D8;
				}
				}
				goto IL_28;
				IL_D8:
				passwordBox.Password = text;
				this.PIN = passwordBox.Password;
				this.a = false;
				num2 = (short)1075183619;
				num = (int)((IntPtr)num2);
				continue;
				IL_15F:
				num2 = (short)846790656;
				num = (int)((IntPtr)num2);
			}
			return;
			IL_28:
			passwordBox = (A_0 as PasswordBox);
			num2 = (short)510525442;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00026B28 File Offset: 0x00024D28
		private void AcpPasswordBox_OnLoaded(object A_0, RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_66;
			}
			short num;
			int num3;
			PasswordBox passwordBox;
			for (;;)
			{
				IL_0A:
				num = (short)1650162562;
				short num2 = num;
				num = (short)420576130;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)640876544;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_F1;
					case 1:
						return;
					case 2:
						if (passwordBox != null)
						{
							num = (short)1443364864;
							short num4 = num;
							num = (short)1736769536;
							num3 = (int)((IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_66;
				}
				IL_F1:
				passwordBox.Password = this.PIN;
				num = (short)1404108801;
				num3 = (int)((IntPtr)num);
			}
			return;
			IL_66:
			num = (short)821362689;
			if (num != 0)
			{
			}
			passwordBox = (A_0 as PasswordBox);
			num = (short)1807220738;
			num3 = (int)((IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00026C50 File Offset: 0x00024E50
		private static void a(DependencyObject A_0, DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)2070413314;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)204932492;
					short num3 = num;
					num = (short)1240728972;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3C;
					default:
					{
						num = (short)967311360;
						if (num != 0)
						{
						}
						num = (short)1155203073;
						if (num != 0)
						{
						}
						num = (short)1674838016;
						short num4 = num;
						((AcpPasswordBox)A_0).b.Password = (string)A_1.NewValue;
						num = (short)1600847873;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				goto IL_31;
				IL_3C:
				num = (short)497942528;
				num2 = (int)((IntPtr)num);
				continue;
				IL_31:
				if (A_0 is AcpPasswordBox)
				{
					goto IL_3C;
				}
				break;
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00026D84 File Offset: 0x00024F84
		private void AcpPasswordBox_OnChanged(object A_0, RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			PasswordBox passwordBox;
			for (;;)
			{
				IL_0A:
				string text;
				switch (num)
				{
				case 0:
					num2 = (short)928120841;
					num = (int)((IntPtr)num2);
					continue;
				case 1:
					if (passwordBox.Password == string.Empty)
					{
						num2 = (short)705101824;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 2:
					text = this.PIN;
					num2 = (short)690552837;
					num = (int)((IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)2094966624;
					short num3 = num2;
					num2 = (short)727820128;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19C;
					default:
						goto IL_1F3;
					}
					break;
				}
				case 4:
					num2 = (short)1296433153;
					if (num2 != 0)
					{
					}
					if (passwordBox != null)
					{
						num2 = (short)811008002;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 5:
				{
					num2 = (short)1562116096;
					short num4 = num2;
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)352059399;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_DD;
				}
				case 6:
					goto IL_DD;
				case 7:
					text = Utility.FilterArabicDiacritics(text);
					num2 = (short)128647174;
					num = (int)((IntPtr)num2);
					continue;
				case 8:
					goto IL_19C;
				case 9:
					if (!this.a)
					{
						num2 = (short)842203144;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_38;
				IL_DD:
				this.PIN = text;
				num2 = (short)1117192193;
				num = (int)((IntPtr)num2);
				continue;
				IL_19C:
				passwordBox.Password = this.PIN;
				num2 = (short)989724675;
				num = (int)((IntPtr)num2);
			}
			IL_1F3:
			num2 = (short)1916534784;
			if (num2 != 0)
			{
			}
			return;
			IL_38:
			passwordBox = (A_0 as PasswordBox);
			num2 = (short)14680068;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000271C4 File Offset: 0x000253C4
		// Note: this type is marked as 'beforefieldinit'.
		static AcpPasswordBox()
		{
			int a_ = 8;
			short num = (short)278720069;
			short num2 = num;
			num = (short)830860869;
			switch (num2 == num)
			{
			}
			num = (short)1487470593;
			if (num != 0)
			{
			}
			num = (short)1955397632;
			if (num != 0)
			{
			}
			num = (short)1638400000;
			short num3 = num;
			AcpPasswordBox.IsAcpValidProperty = DependencyProperty.RegisterAttached(Utility.c("힝펟잣횥ﺧ쮩삫잭풯", a_), typeof(bool), typeof(AcpPasswordBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpPasswordBox.IsAcpApplicableProperty = DependencyProperty.Register(Utility.c("힝펟잣횥\udaa9\udcab슭\ud9af톱햳풵풷\udfb9", a_), typeof(bool), typeof(AcpPasswordBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpPasswordBox.IsAcpEditableProperty = DependencyProperty.Register(Utility.c("힝펟잣횥캩얫\udaad톯킱\ud8b3펵", a_), typeof(bool), typeof(AcpPasswordBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpPasswordBox.IsAcpVisibleProperty = DependencyProperty.Register(Utility.c("힝펟잣횥ﺧ쎩\udfab잭튯\udeb1톳", a_), typeof(bool), typeof(AcpPasswordBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpPasswordBox.MyLabelCtrlProperty = DependencyProperty.RegisterAttached(Utility.c("펝\ud99f얣쒥춧용\udaad슯\udeb1", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpPasswordBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordBox.MyCopyButtonProperty = DependencyProperty.RegisterAttached(Utility.c("펝\ud99f쮣횥톧\ud9ab\udaad쒯\uddb1\udab3첷좹킻", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpPasswordBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordBox.MyBLObjectProperty = DependencyProperty.RegisterAttached(Utility.c("펝\ud99f쪧삩즫춭쒯", a_), typeof(AcpFieldBase), typeof(AcpPasswordBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordBox.AreValuesEqualProperty = DependencyProperty.Register(Utility.c("\udf9d튟잡장쒧\udfa9즫\uddad쎱솳ힵ풷", a_), typeof(bool), typeof(AcpPasswordBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordBox.MyExpanderProperty = DependencyProperty.RegisterAttached(Utility.c("펝\ud99f\udca3횥즧쒩좫쮭슯", a_), typeof(Expander), typeof(AcpPasswordBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordBox.MyParentCtrlProperty = DependencyProperty.RegisterAttached(Utility.c("펝\ud99f얣풥춧쒩\ud8ab쒯삱\ud8b3", a_), typeof(IAcpUIParentCtrlBase), typeof(AcpPasswordBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordBox.IsDigitOnlyProperty = DependencyProperty.Register(Utility.c("힝펟춣솥솧\udea9삭\udcaf쮱", a_), typeof(bool), typeof(AcpPasswordBox), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordBox.MaxPasswordLengthProperty = DependencyProperty.Register(Utility.c("펝솟\udaa1장\udba7\ud9a9\udbab솭슯횱펵횷\uddb9좻횽", a_), typeof(int), typeof(AcpPasswordBox), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpPasswordBox.PINProperty = DependencyProperty.Register(Utility.c("캝", a_), typeof(string), typeof(AcpPasswordBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(AcpPasswordBox.a)));
		}

		// Token: 0x04000179 RID: 377
		public static readonly DependencyProperty IsAcpValidProperty;

		// Token: 0x0400017A RID: 378
		public static readonly DependencyProperty IsAcpApplicableProperty;

		// Token: 0x0400017B RID: 379
		public static readonly DependencyProperty IsAcpEditableProperty;

		// Token: 0x0400017C RID: 380
		public static readonly DependencyProperty IsAcpVisibleProperty;

		// Token: 0x0400017D RID: 381
		public static readonly DependencyProperty MyLabelCtrlProperty;

		// Token: 0x0400017E RID: 382
		public static readonly DependencyProperty MyCopyButtonProperty;

		// Token: 0x0400017F RID: 383
		public static readonly DependencyProperty MyBLObjectProperty;

		// Token: 0x04000180 RID: 384
		public static readonly DependencyProperty AreValuesEqualProperty;

		// Token: 0x04000181 RID: 385
		public static readonly DependencyProperty MyExpanderProperty;

		// Token: 0x04000182 RID: 386
		public static readonly DependencyProperty MyParentCtrlProperty;

		// Token: 0x04000183 RID: 387
		public static readonly DependencyProperty IsDigitOnlyProperty;

		// Token: 0x04000184 RID: 388
		private bool a;

		// Token: 0x04000185 RID: 389
		public static readonly DependencyProperty MaxPasswordLengthProperty;

		// Token: 0x04000186 RID: 390
		public static readonly DependencyProperty PINProperty;
	}
}
