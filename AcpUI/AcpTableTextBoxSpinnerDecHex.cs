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
	// Token: 0x02000032 RID: 50
	public class AcpTableTextBoxSpinnerDecHex : global::System.Windows.Controls.Control, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIValueCtrlBase<string>, global::AcpUILib.IAcpUIParentCtrlBase, global::AcpUILib.IAcpUIChildCtrlBase, global::AcpUILib.IAcpUICommon, global::AcpUI.ISupportsTextBoxMember
	{
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00032980 File Offset: 0x00030B80
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00032A2C File Offset: 0x00030C2C
		public string Value
		{
			get
			{
				short num = (short)1298726912;
				short num2 = num;
				num = (short)1671295348;
				short num3 = num;
				num = (short)1272312180;
				switch (num3 == num)
				{
				}
				num = (short)639369217;
				if (num != 0)
				{
				}
				num = (short)1618739200;
				if (num != 0)
				{
				}
				return this.Text;
			}
			set
			{
				short num = (short)1623392256;
				short num2 = num;
				num = (short)1403896305;
				short num3 = num;
				num = (short)1503314417;
				switch (num3 == num)
				{
				}
				num = (short)2018246657;
				if (num != 0)
				{
				}
				num = (short)1706360832;
				if (num != 0)
				{
				}
				this.Text = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00032ADC File Offset: 0x00030CDC
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00032B98 File Offset: 0x00030D98
		public bool IsAcpValid
		{
			get
			{
				short num = (short)206438400;
				short num2 = num;
				num = (short)2063990785;
				if (num != 0)
				{
				}
				num = (short)1196115386;
				short num3 = num;
				num = (short)315835834;
				switch (num3 == num)
				{
				}
				num = (short)1190920192;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.IsAcpValidProperty);
			}
			set
			{
				short num = (short)2109079552;
				short num2 = num;
				num = (short)29082097;
				short num3 = num;
				num = (short)1470022129;
				switch (num3 == num)
				{
				}
				num = (short)1653276673;
				if (num != 0)
				{
				}
				num = (short)1681850368;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.IsAcpValidProperty, value);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00032C50 File Offset: 0x00030E50
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00032D08 File Offset: 0x00030F08
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)1610481664;
				short num2 = num;
				num = (short)738581218;
				short num3 = num;
				num = (short)2088950498;
				switch (num3 == num)
				{
				}
				num = (short)1799421952;
				if (num != 0)
				{
				}
				num = (short)696320001;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2026373120;
				short num2 = num;
				num = (short)1059751300;
				short num3 = num;
				num = (short)1842382212;
				switch (num3 == num)
				{
				}
				num = (short)978386945;
				if (num != 0)
				{
				}
				num = (short)784662528;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00032DC0 File Offset: 0x00030FC0
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00032E7C File Offset: 0x0003107C
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)823918592;
				short num2 = num;
				num = (short)1678835713;
				if (num != 0)
				{
				}
				num = (short)442113556;
				short num3 = num;
				num = (short)2065243668;
				switch (num3 == num)
				{
				}
				num = (short)2033778688;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)884867072;
				short num2 = num;
				num = (short)1347092481;
				if (num != 0)
				{
				}
				num = (short)251828085;
				short num3 = num;
				num = (short)1598003061;
				switch (num3 == num)
				{
				}
				num = (short)1138688000;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00032F38 File Offset: 0x00031138
		// (set) Token: 0x060002DA RID: 730 RVA: 0x00032FF4 File Offset: 0x000311F4
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)2024472576;
				short num2 = num;
				num = (short)425057028;
				short num3 = num;
				num = (short)1054792452;
				switch (num3 == num)
				{
				}
				num = (short)1152188417;
				if (num != 0)
				{
				}
				num = (short)1453457408;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2106261504;
				short num2 = num;
				num = (short)128450183;
				short num3 = num;
				num = (short)1030553223;
				switch (num3 == num)
				{
				}
				num = (short)1874067457;
				if (num != 0)
				{
				}
				num = (short)1055916032;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002DB RID: 731 RVA: 0x000330AC File Offset: 0x000312AC
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00033164 File Offset: 0x00031364
		public global::AcpUILib.IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)1569587200;
				short num2 = num;
				num = (short)50890385;
				short num3 = num;
				num = (short)63014545;
				switch (num3 == num)
				{
				}
				num = (short)1927938048;
				if (num != 0)
				{
				}
				num = (short)2055536641;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)373358592;
				short num2 = num;
				num = (short)950398969;
				short num3 = num;
				num = (short)66056185;
				switch (num3 == num)
				{
				}
				num = (short)1508769793;
				if (num != 0)
				{
				}
				num = (short)57212928;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00033218 File Offset: 0x00031418
		// (set) Token: 0x060002DE RID: 734 RVA: 0x000332D0 File Offset: 0x000314D0
		public global::AcpUILib.IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)1248591872;
				short num2 = num;
				num = (short)287956461;
				short num3 = num;
				num = (short)89316845;
				switch (num3 == num)
				{
				}
				num = (short)1718681601;
				if (num != 0)
				{
				}
				num = (short)1464401920;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)204726422;
				short num2 = num;
				num = (short)453173398;
				switch (num2 == num)
				{
				}
				num = (short)1648820225;
				if (num != 0)
				{
				}
				num = (short)1105657856;
				short num3 = num;
				num = (short)893452288;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00033384 File Offset: 0x00031584
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x0003343C File Offset: 0x0003163C
		public global::AcpBusinessLayer.AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)949261450;
				short num2 = num;
				num = (short)719819914;
				switch (num2 == num)
				{
				}
				num = (short)724041728;
				if (num != 0)
				{
				}
				num = (short)618659840;
				short num3 = num;
				num = (short)1528496129;
				if (num != 0)
				{
				}
				return (global::AcpBusinessLayer.AcpFieldBase)base.GetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyBLObjectProperty);
			}
			set
			{
				short num = (short)525260137;
				short num2 = num;
				num = (short)1860752745;
				switch (num2 == num)
				{
				}
				num = (short)597557249;
				if (num != 0)
				{
				}
				num = (short)1422458880;
				short num3 = num;
				num = (short)1536557056;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyBLObjectProperty, value);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x000334F0 File Offset: 0x000316F0
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x000335A8 File Offset: 0x000317A8
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)1984318059;
				short num2 = num;
				num = (short)23218795;
				switch (num2 == num)
				{
				}
				num = (short)1415118849;
				if (num != 0)
				{
				}
				num = (short)238157824;
				short num3 = num;
				num = (short)1590427648;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)1338806887;
				short num2 = num;
				num = (short)98603623;
				switch (num2 == num)
				{
				}
				num = (short)547422209;
				if (num != 0)
				{
				}
				num = (short)1776025600;
				short num3 = num;
				num = (short)1035337728;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00033664 File Offset: 0x00031864
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x0003371C File Offset: 0x0003191C
		public global::System.Windows.Controls.Expander MyExpander
		{
			get
			{
				short num = (short)383977761;
				short num2 = num;
				num = (short)1329596705;
				switch (num2 == num)
				{
				}
				num = (short)1438777344;
				if (num != 0)
				{
				}
				num = (short)121110528;
				short num3 = num;
				num = (short)1457258497;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Expander)base.GetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyExpanderProperty);
			}
			set
			{
				short num = (short)547492805;
				short num2 = num;
				num = (short)1894519749;
				switch (num2 == num)
				{
				}
				num = (short)1768488961;
				if (num != 0)
				{
				}
				num = (short)1834090496;
				short num3 = num;
				num = (short)1871904768;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyExpanderProperty, value);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x000337D4 File Offset: 0x000319D4
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0003388C File Offset: 0x00031A8C
		public global::AcpUILib.IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)2061524756;
				short num2 = num;
				num = (short)1795317524;
				switch (num2 == num)
				{
				}
				num = (short)813629441;
				if (num != 0)
				{
				}
				num = (short)1054081024;
				short num3 = num;
				num = (short)1524826112;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)1362467849;
				short num2 = num;
				num = (short)1770167305;
				switch (num2 == num)
				{
				}
				num = (short)382992384;
				if (num != 0)
				{
				}
				num = (short)1167130624;
				short num3 = num;
				num = (short)2000486401;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00033944 File Offset: 0x00031B44
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x000339FC File Offset: 0x00031BFC
		public string Text
		{
			get
			{
				short num = (short)1463559046;
				short num2 = num;
				num = (short)1156195206;
				switch (num2 == num)
				{
				}
				num = (short)2068054017;
				if (num != 0)
				{
				}
				num = (short)273416192;
				short num3 = num;
				num = (short)2107375616;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.TextProperty);
			}
			set
			{
				short num = (short)2146515156;
				short num2 = num;
				num = (short)221395156;
				switch (num2 == num)
				{
				}
				num = (short)837615617;
				if (num != 0)
				{
				}
				num = (short)1808138240;
				short num3 = num;
				num = (short)224854016;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.TextProperty, value);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00033AB4 File Offset: 0x00031CB4
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00033B6C File Offset: 0x00031D6C
		public string HexText
		{
			get
			{
				short num = (short)708530323;
				short num2 = num;
				num = (short)1434210451;
				switch (num2 == num)
				{
				}
				num = (short)1648754689;
				if (num != 0)
				{
				}
				num = (short)504496128;
				short num3 = num;
				num = (short)845086720;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.HexTextProperty);
			}
			set
			{
				short num = (short)48179185;
				short num2 = num;
				num = (short)2029332465;
				switch (num2 == num)
				{
				}
				num = (short)208732161;
				if (num != 0)
				{
				}
				num = (short)1672282112;
				short num3 = num;
				num = (short)1689190400;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinnerDecHex.HexTextProperty, value);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00033C20 File Offset: 0x00031E20
		private void OnClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)802295773;
			short num2 = num;
			num = (short)1167200221;
			switch (num2 == num)
			{
			}
			num = (short)1664024577;
			if (num != 0)
			{
			}
			num = (short)1012203520;
			short num3 = num;
			num = (short)286982144;
			if (num != 0)
			{
			}
			global::AcpUI.Common.StepUpDownUtility.a(A_0, this.MyBLObject);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00033CD4 File Offset: 0x00031ED4
		private void OnKeyPressUpDownEvent(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)1114143094;
			short num2 = num;
			num = (short)557414774;
			switch (num2 == num)
			{
			}
			num = (short)379453440;
			if (num != 0)
			{
			}
			num = (short)276758528;
			short num3 = num;
			num = (short)1981808641;
			if (num != 0)
			{
			}
			global::AcpUI.Common.StepUpDownUtility.a(A_1, this.MyBLObject);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00033D88 File Offset: 0x00031F88
		public AcpTableTextBoxSpinnerDecHex()
		{
			base.Focusable = true;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00033DA4 File Offset: 0x00031FA4
		global::AcpUI.AcpTextBox global::AcpUI.ISupportsTextBoxMember.TextBoxMember
		{
			get
			{
				short num = (short)1460119555;
				short num2 = num;
				num = (short)979740675;
				switch (num2 == num)
				{
				}
				num = (short)287637504;
				if (num != 0)
				{
				}
				num = (short)1448935424;
				short num3 = num;
				num = (short)1261371393;
				if (num != 0)
				{
				}
				return this.AcpTextBoxMemberDec;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00033E50 File Offset: 0x00032050
		public global::AcpUI.AcpTableTextBoxBase AcpTextBoxMemberDec
		{
			get
			{
				short num = (short)71767620;
				short num2 = num;
				num = (short)766907972;
				switch (num2 == num)
				{
				}
				num = (short)5242881;
				if (num != 0)
				{
				}
				num = (short)674365440;
				short num3 = num;
				num = (short)934215680;
				if (num != 0)
				{
				}
				return global::System.Windows.Media.VisualTreeHelper.GetChild(global::System.Windows.Media.VisualTreeHelper.GetChild(this, 0) as global::System.Windows.UIElement, 0) as global::AcpUI.AcpTableTextBoxBase;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00033F10 File Offset: 0x00032110
		public global::AcpUI.AcpTableTextBoxBase AcpTextBoxMemberHex
		{
			get
			{
				short num = (short)1919018846;
				short num2 = num;
				num = (short)1694099294;
				switch (num2 == num)
				{
				}
				num = (short)213975041;
				if (num != 0)
				{
				}
				num = (short)219545600;
				short num3 = num;
				num = (short)737542144;
				if (num != 0)
				{
				}
				return global::System.Windows.Media.VisualTreeHelper.GetChild(global::System.Windows.Media.VisualTreeHelper.GetChild(this, 0) as global::System.Windows.UIElement, 2) as global::AcpUI.AcpTableTextBoxBase;
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00033FD0 File Offset: 0x000321D0
		// Note: this type is marked as 'beforefieldinit'.
		static AcpTableTextBoxSpinnerDecHex()
		{
			int a_ = 13;
			short num = (short)1462657731;
			short num2 = num;
			num = (short)300376771;
			switch (num2 == num)
			{
			}
			num = (short)1461977089;
			if (num != 0)
			{
			}
			num = (short)68288512;
			short num3 = num;
			num = (short)1697447936;
			if (num != 0)
			{
			}
			global::AcpUI.AcpTableTextBoxSpinnerDecHex.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("횤쪨\udbaaﮬ캮\uddb0\udab2톴", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxSpinnerDecHex.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("횤쪨\udbaa\udfae솰\udfb2\udcb4풶\ud8b8\ud9ba톼\udabe", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxSpinnerDecHex.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("횤쪨\udbaa쮮\ud8b0잲풴햶햸\udeba", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxSpinnerDecHex.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("횤쪨\udbaaﮬ욮슰\udab2ힴ\udbb6\udcb8", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyLabelCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udca4좨즪좬쎮잲잴\udbb6", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyCopyButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udca4욨\udbaa풬쒰잲솴\ud8b6ힸ즼춾귀", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyBLObjectProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udca4쾬얮풰킲솴", a_), typeof(global::AcpBusinessLayer.AcpFieldBase), typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxSpinnerDecHex.AreValuesEqualProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("힤슦ﾨ쪪솬\udaae풰삲욶첸\udaba톼", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyExpanderProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udca4톨\udbaa첬솮햰횲잴", a_), typeof(global::System.Windows.Controls.Expander), typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxSpinnerDecHex.MyParentCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udca4좨\ud9aa좬솮얰솴얶햸", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxSpinnerDecHex.TextProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("삤\udfa6\udda8", a_), typeof(string), typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxSpinnerDecHex.HexTextProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("삤\udfa6ﶨ캪햬\udbae", a_), typeof(string), typeof(global::AcpUI.AcpTableTextBoxSpinnerDecHex), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		}

		// Token: 0x040001D6 RID: 470
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x040001D7 RID: 471
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x040001D8 RID: 472
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x040001D9 RID: 473
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x040001DA RID: 474
		public static readonly global::System.Windows.DependencyProperty MyLabelCtrlProperty;

		// Token: 0x040001DB RID: 475
		public static readonly global::System.Windows.DependencyProperty MyCopyButtonProperty;

		// Token: 0x040001DC RID: 476
		public static readonly global::System.Windows.DependencyProperty MyBLObjectProperty;

		// Token: 0x040001DD RID: 477
		public static readonly global::System.Windows.DependencyProperty AreValuesEqualProperty;

		// Token: 0x040001DE RID: 478
		public static readonly global::System.Windows.DependencyProperty MyExpanderProperty;

		// Token: 0x040001DF RID: 479
		public static readonly global::System.Windows.DependencyProperty MyParentCtrlProperty;

		// Token: 0x040001E0 RID: 480
		public static readonly global::System.Windows.DependencyProperty TextProperty;

		// Token: 0x040001E1 RID: 481
		public static readonly global::System.Windows.DependencyProperty HexTextProperty;
	}
}
