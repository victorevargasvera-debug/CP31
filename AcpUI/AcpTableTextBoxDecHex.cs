using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using AcpBusinessLayer;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x0200002F RID: 47
	public class AcpTableTextBoxDecHex : global::System.Windows.Controls.Control, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIValueCtrlBase<string>, global::AcpUILib.IAcpUIParentCtrlBase, global::AcpUILib.IAcpUIChildCtrlBase, global::AcpUILib.IAcpUICommon, global::AcpUI.ISupportsTextBoxMember
	{
		// Token: 0x0600028F RID: 655 RVA: 0x0002F664 File Offset: 0x0002D864
		public AcpTableTextBoxDecHex()
		{
			base.Focusable = true;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0002F680 File Offset: 0x0002D880
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0002F730 File Offset: 0x0002D930
		public string Value
		{
			get
			{
				short num = (short)111209022;
				short num2 = num;
				num = (short)1158670910;
				switch (num2 == num)
				{
				}
				num = (short)1728249856;
				short num3 = num;
				num = (short)1406140417;
				if (num != 0)
				{
				}
				num = (short)604045312;
				if (num != 0)
				{
				}
				return this.Text;
			}
			set
			{
				short num = (short)989080441;
				short num2 = num;
				num = (short)1004678009;
				switch (num2 == num)
				{
				}
				num = (short)496697344;
				short num3 = num;
				num = (short)477691904;
				if (num != 0)
				{
				}
				num = (short)549912577;
				if (num != 0)
				{
				}
				this.Text = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0002F7E0 File Offset: 0x0002D9E0
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0002F898 File Offset: 0x0002DA98
		public bool IsAcpValid
		{
			get
			{
				short num = (short)1092327285;
				short num2 = num;
				num = (short)152868725;
				switch (num2 == num)
				{
				}
				num = (short)770441216;
				short num3 = num;
				num = (short)933691392;
				if (num != 0)
				{
				}
				num = (short)1282605057;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxDecHex.IsAcpValidProperty);
			}
			set
			{
				short num = (short)596188347;
				short num2 = num;
				num = (short)1464802491;
				switch (num2 == num)
				{
				}
				num = (short)485949440;
				short num3 = num;
				num = (short)284753920;
				if (num != 0)
				{
				}
				num = (short)1031471105;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxDecHex.IsAcpValidProperty, value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0002F954 File Offset: 0x0002DB54
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0002FA0C File Offset: 0x0002DC0C
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)1892294847;
				short num2 = num;
				num = (short)1614553279;
				switch (num2 == num)
				{
				}
				num = (short)1389625344;
				short num3 = num;
				num = (short)1327562753;
				if (num != 0)
				{
				}
				num = (short)1976303616;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxDecHex.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)203074092;
				short num2 = num;
				num = (short)69052972;
				switch (num2 == num)
				{
				}
				num = (short)867500032;
				short num3 = num;
				num = (short)1015283712;
				if (num != 0)
				{
				}
				num = (short)136249345;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxDecHex.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0002FAC8 File Offset: 0x0002DCC8
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0002FB84 File Offset: 0x0002DD84
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)769181953;
				short num2 = num;
				num = (short)1564133633;
				switch (num2 == num)
				{
				}
				num = (short)1884684288;
				short num3 = num;
				num = (short)1959133184;
				if (num != 0)
				{
				}
				num = (short)357957633;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxDecHex.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)2045485069;
				short num2 = num;
				num = (short)881238029;
				switch (num2 == num)
				{
				}
				num = (short)804257792;
				short num3 = num;
				num = (short)1811939329;
				if (num != 0)
				{
				}
				num = (short)570359808;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxDecHex.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0002FC3C File Offset: 0x0002DE3C
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0002FCF4 File Offset: 0x0002DEF4
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)5886321;
				short num2 = num;
				num = (short)155242865;
				switch (num2 == num)
				{
				}
				num = (short)2103246848;
				short num3 = num;
				num = (short)478740481;
				if (num != 0)
				{
				}
				num = (short)545062912;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxDecHex.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)204502807;
				short num2 = num;
				num = (short)2069919511;
				switch (num2 == num)
				{
				}
				num = (short)1996095488;
				short num3 = num;
				num = (short)828243968;
				if (num != 0)
				{
				}
				num = (short)204996609;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxDecHex.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0002FDAC File Offset: 0x0002DFAC
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0002FE64 File Offset: 0x0002E064
		public global::AcpUILib.IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)1338048513;
				if (num != 0)
				{
				}
				num = (short)1662418276;
				short num2 = num;
				num = (short)1254784356;
				switch (num2 == num)
				{
				default:
				{
					num = (short)637861888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330956800;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpTableTextBoxDecHex.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)775984241;
				short num2 = num;
				num = (short)683119729;
				switch (num2 == num)
				{
				}
				num = (short)1602879488;
				short num3 = num;
				num = (short)2004221953;
				if (num != 0)
				{
				}
				num = (short)770637824;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxDecHex.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0002FF18 File Offset: 0x0002E118
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0002FFD0 File Offset: 0x0002E1D0
		public global::AcpUILib.IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)855797453;
				short num2 = num;
				num = (short)526479053;
				switch (num2 == num)
				{
				}
				num = (short)723255296;
				short num3 = num;
				num = (short)1723793409;
				if (num != 0)
				{
				}
				num = (short)2130182144;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpTableTextBoxDecHex.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)2087966315;
				short num2 = num;
				num = (short)1740822123;
				switch (num2 == num)
				{
				}
				num = (short)146538496;
				short num3 = num;
				num = (short)312279040;
				if (num != 0)
				{
				}
				num = (short)2117074945;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxDecHex.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00030084 File Offset: 0x0002E284
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0003013C File Offset: 0x0002E33C
		public global::AcpBusinessLayer.AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)1393571035;
				short num2 = num;
				num = (short)531641563;
				switch (num2 == num)
				{
				}
				num = (short)2109997056;
				short num3 = num;
				num = (short)1521287168;
				if (num != 0)
				{
				}
				num = (short)241827841;
				if (num != 0)
				{
				}
				return (global::AcpBusinessLayer.AcpFieldBase)base.GetValue(global::AcpUI.AcpTableTextBoxDecHex.MyBLObjectProperty);
			}
			set
			{
				short num = (short)1675840495;
				short num2 = num;
				num = (short)1894075375;
				switch (num2 == num)
				{
				}
				num = (short)875167744;
				short num3 = num;
				num = (short)1196163072;
				if (num != 0)
				{
				}
				num = (short)1577517057;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxDecHex.MyBLObjectProperty, value);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x000301F4 File Offset: 0x0002E3F4
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x000302AC File Offset: 0x0002E4AC
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)1198803974;
				short num2 = num;
				num = (short)1373654022;
				switch (num2 == num)
				{
				}
				num = (short)1542193152;
				short num3 = num;
				num = (short)2089484289;
				if (num != 0)
				{
				}
				num = (short)329646080;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxDecHex.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)1580104053;
				short num2 = num;
				num = (short)843938165;
				switch (num2 == num)
				{
				}
				num = (short)1152647168;
				short num3 = num;
				num = (short)86704129;
				if (num != 0)
				{
				}
				num = (short)595329024;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxDecHex.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00030364 File Offset: 0x0002E564
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00030420 File Offset: 0x0002E620
		public global::System.Windows.Controls.Expander MyExpander
		{
			get
			{
				short num = (short)175921118;
				short num2 = num;
				num = (short)1746950110;
				switch (num2 == num)
				{
				}
				num = (short)596639744;
				short num3 = num;
				num = (short)1704919041;
				if (num != 0)
				{
				}
				num = (short)450166784;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Expander)base.GetValue(global::AcpUI.AcpTableTextBoxDecHex.MyExpanderProperty);
			}
			set
			{
				short num = (short)1610630331;
				short num2 = num;
				num = (short)312231099;
				switch (num2 == num)
				{
				}
				num = (short)1099956224;
				short num3 = num;
				num = (short)80609281;
				if (num != 0)
				{
				}
				num = (short)572719104;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxDecHex.MyExpanderProperty, value);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000304D8 File Offset: 0x0002E6D8
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00030590 File Offset: 0x0002E790
		public global::AcpUILib.IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)155421528;
				short num2 = num;
				num = (short)79465304;
				switch (num2 == num)
				{
				}
				num = (short)1317666816;
				short num3 = num;
				num = (short)1317601280;
				if (num != 0)
				{
				}
				num = (short)2027421697;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::AcpUI.AcpTableTextBoxDecHex.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)1341827381;
				short num2 = num;
				num = (short)1848944949;
				switch (num2 == num)
				{
				}
				num = (short)1732247552;
				short num3 = num;
				num = (short)871694337;
				if (num != 0)
				{
				}
				num = (short)20971520;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxDecHex.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00030648 File Offset: 0x0002E848
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00030704 File Offset: 0x0002E904
		public string Text
		{
			get
			{
				short num = (short)466812929;
				if (num != 0)
				{
				}
				num = (short)346525225;
				short num2 = num;
				num = (short)243174953;
				switch (num2 == num)
				{
				default:
				{
					num = (short)299433984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1126760448;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::AcpUI.AcpTableTextBoxDecHex.TextProperty);
			}
			set
			{
				short num = (short)1496514561;
				if (num != 0)
				{
				}
				num = (short)1012108032;
				short num2 = num;
				num = (short)203066112;
				switch (num2 == num)
				{
				default:
				{
					num = (short)892665856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1962475520;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxDecHex.TextProperty, value);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x000307B8 File Offset: 0x0002E9B8
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00030874 File Offset: 0x0002EA74
		public string HexText
		{
			get
			{
				short num = (short)600818173;
				short num2 = num;
				num = (short)1811661309;
				switch (num2 == num)
				{
				}
				num = (short)1820065792;
				short num3 = num;
				num = (short)2077097984;
				if (num != 0)
				{
				}
				num = (short)1379598337;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::AcpUI.AcpTableTextBoxDecHex.HexTextProperty);
			}
			set
			{
				short num = (short)71237633;
				if (num != 0)
				{
				}
				num = (short)3706161;
				short num2 = num;
				num = (short)346524977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1505492992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)487456768;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxDecHex.HexTextProperty, value);
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00030930 File Offset: 0x0002EB30
		private void OnKeyPressUpDownNoAction(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Windows.Input.Key key;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (key == global::System.Windows.Input.Key.Down)
					{
						num2 = (short)1366032388;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)799014912;
					short num3 = num2;
					num2 = (short)1422655489;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					IL_3F:
					if (key != global::System.Windows.Input.Key.Up)
					{
						num2 = (short)1664876546;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_85;
				case 4:
					goto IL_85;
				}
				goto IL_24;
				IL_85:
				num2 = (short)1909325825;
				if (num2 != 0)
				{
				}
				num2 = (short)1313880995;
				short num4 = num2;
				num2 = (short)2060401571;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3F;
				default:
					num2 = (short)909443072;
					if (num2 != 0)
					{
					}
					A_1.Handled = true;
					num2 = (short)391970816;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			return;
			IL_24:
			key = A_1.Key;
			num2 = (short)1318584323;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00030A90 File Offset: 0x0002EC90
		global::AcpUI.AcpTextBox global::AcpUI.ISupportsTextBoxMember.TextBoxMember
		{
			get
			{
				short num = (short)939081595;
				short num2 = num;
				num = (short)198983547;
				switch (num2 == num)
				{
				}
				num = (short)1274871808;
				short num3 = num;
				num = (short)249823233;
				if (num != 0)
				{
				}
				num = (short)1843658752;
				if (num != 0)
				{
				}
				return this.AcpTextBoxMemberDec;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00030B40 File Offset: 0x0002ED40
		public global::AcpUI.AcpTableTextBoxBase AcpTextBoxMemberDec
		{
			get
			{
				short num = (short)814821354;
				short num2 = num;
				num = (short)1393307626;
				switch (num2 == num)
				{
				}
				num = (short)623968256;
				short num3 = num;
				num = (short)315490305;
				if (num != 0)
				{
				}
				num = (short)1345978368;
				if (num != 0)
				{
				}
				return global::System.Windows.Media.VisualTreeHelper.GetChild(global::System.Windows.Media.VisualTreeHelper.GetChild(this, 0) as global::System.Windows.UIElement, 0) as global::AcpUI.AcpTableTextBoxBase;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00030C00 File Offset: 0x0002EE00
		public global::AcpUI.AcpTableTextBoxBase AcpTextBoxMemberHex
		{
			get
			{
				short num = (short)1819271164;
				short num2 = num;
				num = (short)1864491004;
				switch (num2 == num)
				{
				}
				num = (short)1809514496;
				short num3 = num;
				num = (short)656736256;
				if (num != 0)
				{
				}
				num = (short)355008513;
				if (num != 0)
				{
				}
				return global::System.Windows.Media.VisualTreeHelper.GetChild(global::System.Windows.Media.VisualTreeHelper.GetChild(this, 0) as global::System.Windows.UIElement, 2) as global::AcpUI.AcpTableTextBoxBase;
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00030CC4 File Offset: 0x0002EEC4
		// Note: this type is marked as 'beforefieldinit'.
		static AcpTableTextBoxDecHex()
		{
			int a_ = 8;
			short num = (short)444137472;
			short num2 = num;
			num = (short)69383462;
			short num3 = num;
			num = (short)2080879910;
			switch (num3 == num)
			{
			}
			num = (short)359202817;
			if (num != 0)
			{
			}
			num = (short)1750532096;
			if (num != 0)
			{
			}
			global::AcpUI.AcpTableTextBoxDecHex.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("힝펟잣횥ﺧ쮩삫잭풯", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxDecHex), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxDecHex.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("힝펟잣횥\udaa9\udcab슭\ud9af톱햳풵풷\udfb9", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxDecHex), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxDecHex.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("힝펟잣횥캩얫\udaad톯킱\ud8b3펵", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxDecHex), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxDecHex.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("힝펟잣횥ﺧ쎩\udfab잭튯\udeb1톳", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxDecHex), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxDecHex.MyLabelCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펝\ud99f얣쒥춧용\udaad슯\udeb1", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpTableTextBoxDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxDecHex.MyCopyButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펝\ud99f쮣횥톧\ud9ab\udaad쒯\uddb1\udab3첷좹킻", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpTableTextBoxDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxDecHex.MyBLObjectProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펝\ud99f쪧삩즫춭쒯", a_), typeof(global::AcpBusinessLayer.AcpFieldBase), typeof(global::AcpUI.AcpTableTextBoxDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxDecHex.AreValuesEqualProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\udf9d튟잡장쒧\udfa9즫\uddad쎱솳ힵ풷", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxDecHex), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxDecHex.MyExpanderProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펝\ud99f\udca3횥즧쒩좫쮭슯", a_), typeof(global::System.Windows.Controls.Expander), typeof(global::AcpUI.AcpTableTextBoxDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxDecHex.MyParentCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펝\ud99f얣풥춧쒩\ud8ab쒯삱\ud8b3", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::AcpUI.AcpTableTextBoxDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxDecHex.TextProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("쪝얟\udaa1킣", a_), typeof(string), typeof(global::AcpUI.AcpTableTextBoxDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxDecHex.HexTextProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("횝얟\udaa1쎥킧\udea9", a_), typeof(string), typeof(global::AcpUI.AcpTableTextBoxDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		}

		// Token: 0x040001BE RID: 446
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x040001BF RID: 447
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x040001C0 RID: 448
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x040001C1 RID: 449
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x040001C2 RID: 450
		public static readonly global::System.Windows.DependencyProperty MyLabelCtrlProperty;

		// Token: 0x040001C3 RID: 451
		public static readonly global::System.Windows.DependencyProperty MyCopyButtonProperty;

		// Token: 0x040001C4 RID: 452
		public static readonly global::System.Windows.DependencyProperty MyBLObjectProperty;

		// Token: 0x040001C5 RID: 453
		public static readonly global::System.Windows.DependencyProperty AreValuesEqualProperty;

		// Token: 0x040001C6 RID: 454
		public static readonly global::System.Windows.DependencyProperty MyExpanderProperty;

		// Token: 0x040001C7 RID: 455
		public static readonly global::System.Windows.DependencyProperty MyParentCtrlProperty;

		// Token: 0x040001C8 RID: 456
		public static readonly global::System.Windows.DependencyProperty TextProperty;

		// Token: 0x040001C9 RID: 457
		public static readonly global::System.Windows.DependencyProperty HexTextProperty;
	}
}
