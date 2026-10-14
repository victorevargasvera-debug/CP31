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
	// Token: 0x02000031 RID: 49
	public class AcpTableTextBoxSpinner : global::System.Windows.Controls.Control, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIValueCtrlBase<string>, global::AcpUILib.IAcpUIParentCtrlBase, global::AcpUILib.IAcpUIChildCtrlBase, global::AcpUILib.IAcpUICommon, global::AcpUI.ISupportsTextBoxMember
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00031010 File Offset: 0x0002F210
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x000310C0 File Offset: 0x0002F2C0
		public string Value
		{
			get
			{
				short num = (short)432603136;
				short num2 = num;
				num = (short)1944322049;
				if (num != 0)
				{
				}
				num = (short)1132017578;
				short num3 = num;
				num = (short)1382430634;
				switch (num3 == num)
				{
				}
				num = (short)1498284032;
				if (num != 0)
				{
				}
				return this.Text;
			}
			set
			{
				short num = (short)80216064;
				short num2 = num;
				num = (short)1534317184;
				short num3 = num;
				num = (short)499962496;
				switch (num3 == num)
				{
				}
				num = (short)1259339777;
				if (num != 0)
				{
				}
				num = (short)772407296;
				if (num != 0)
				{
				}
				this.Text = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00031170 File Offset: 0x0002F370
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00031228 File Offset: 0x0002F428
		public bool IsAcpValid
		{
			get
			{
				short num = (short)227409920;
				short num2 = num;
				num = (short)297440234;
				short num3 = num;
				num = (short)1621136362;
				switch (num3 == num)
				{
				}
				num = (short)717029376;
				if (num != 0)
				{
				}
				num = (short)31522817;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxSpinner.IsAcpValidProperty);
			}
			set
			{
				short num = (short)1932525568;
				short num2 = num;
				num = (short)600396007;
				short num3 = num;
				num = (short)705712359;
				switch (num3 == num)
				{
				}
				num = (short)1167720449;
				if (num != 0)
				{
				}
				num = (short)1403715584;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinner.IsAcpValidProperty, value);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x000312E8 File Offset: 0x0002F4E8
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000313A0 File Offset: 0x0002F5A0
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)961478656;
				short num2 = num;
				num = (short)1031280326;
				short num3 = num;
				num = (short)630593222;
				switch (num3 == num)
				{
				}
				num = (short)316932096;
				if (num != 0)
				{
				}
				num = (short)1195376641;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxSpinner.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)44367872;
				short num2 = num;
				num = (short)1225438329;
				short num3 = num;
				num = (short)1804711033;
				switch (num3 == num)
				{
				}
				num = (short)1885929472;
				if (num != 0)
				{
				}
				num = (short)1934163969;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinner.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0003145C File Offset: 0x0002F65C
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00031514 File Offset: 0x0002F714
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)532086784;
				short num2 = num;
				num = (short)1918398722;
				short num3 = num;
				num = (short)1704161538;
				switch (num3 == num)
				{
				}
				num = (short)960823296;
				if (num != 0)
				{
				}
				num = (short)820445185;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxSpinner.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)19398656;
				short num2 = num;
				num = (short)673479405;
				short num3 = num;
				num = (short)412252909;
				switch (num3 == num)
				{
				}
				num = (short)1803354113;
				if (num != 0)
				{
				}
				num = (short)60555264;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinner.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x000315CC File Offset: 0x0002F7CC
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00031684 File Offset: 0x0002F884
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)1261436928;
				short num2 = num;
				num = (short)1283117388;
				short num3 = num;
				num = (short)678023500;
				switch (num3 == num)
				{
				}
				num = (short)189857792;
				if (num != 0)
				{
				}
				num = (short)677183489;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxSpinner.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1541275648;
				short num2 = num;
				num = (short)604984514;
				short num3 = num;
				num = (short)1251628226;
				switch (num3 == num)
				{
				}
				num = (short)592576513;
				if (num != 0)
				{
				}
				num = (short)753074176;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinner.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0003173C File Offset: 0x0002F93C
		// (set) Token: 0x060002BB RID: 699 RVA: 0x000317F8 File Offset: 0x0002F9F8
		public global::AcpUILib.IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)508297216;
				short num2 = num;
				num = (short)138784107;
				short num3 = num;
				num = (short)678276459;
				switch (num3 == num)
				{
				}
				num = (short)1654390784;
				if (num != 0)
				{
				}
				num = (short)1128529921;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpTableTextBoxSpinner.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)289865728;
				short num2 = num;
				num = (short)366463135;
				short num3 = num;
				num = (short)1654048927;
				switch (num3 == num)
				{
				}
				num = (short)348258304;
				if (num != 0)
				{
				}
				num = (short)1791950849;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinner.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000318B0 File Offset: 0x0002FAB0
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0003196C File Offset: 0x0002FB6C
		public global::AcpUILib.IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)1585446912;
				short num2 = num;
				num = (short)1159264671;
				short num3 = num;
				num = (short)345569695;
				switch (num3 == num)
				{
				}
				num = (short)1439498241;
				if (num != 0)
				{
				}
				num = (short)825556992;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpTableTextBoxSpinner.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)12255232;
				short num2 = num;
				num = (short)377140631;
				short num3 = num;
				num = (short)214087063;
				switch (num3 == num)
				{
				}
				num = (short)1708654592;
				if (num != 0)
				{
				}
				num = (short)2107768833;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinner.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00031A20 File Offset: 0x0002FC20
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00031AD8 File Offset: 0x0002FCD8
		public global::AcpBusinessLayer.AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)2142175232;
				short num2 = num;
				num = (short)1180202897;
				short num3 = num;
				num = (short)1948219281;
				switch (num3 == num)
				{
				}
				num = (short)2004353025;
				if (num != 0)
				{
				}
				num = (short)95813632;
				if (num != 0)
				{
				}
				return (global::AcpBusinessLayer.AcpFieldBase)base.GetValue(global::AcpUI.AcpTableTextBoxSpinner.MyBLObjectProperty);
			}
			set
			{
				short num = (short)2125594624;
				short num2 = num;
				num = (short)1443494601;
				short num3 = num;
				num = (short)416283337;
				switch (num3 == num)
				{
				}
				num = (short)851574785;
				if (num != 0)
				{
				}
				num = (short)1132462080;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinner.MyBLObjectProperty, value);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00031B8C File Offset: 0x0002FD8C
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00031C48 File Offset: 0x0002FE48
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)1575485440;
				short num2 = num;
				num = (short)879506049;
				short num3 = num;
				num = (short)1901671041;
				switch (num3 == num)
				{
				}
				num = (short)2072969217;
				if (num != 0)
				{
				}
				num = (short)882966528;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTableTextBoxSpinner.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)628752384;
				short num2 = num;
				num = (short)673655733;
				short num3 = num;
				num = (short)1475816373;
				switch (num3 == num)
				{
				}
				num = (short)2054946816;
				if (num != 0)
				{
				}
				num = (short)403111937;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinner.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00031D04 File Offset: 0x0002FF04
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00031DBC File Offset: 0x0002FFBC
		public global::System.Windows.Controls.Expander MyExpander
		{
			get
			{
				short num = (short)574881792;
				short num2 = num;
				num = (short)1933496533;
				short num3 = num;
				num = (short)538104021;
				switch (num3 == num)
				{
				}
				num = (short)267976704;
				if (num != 0)
				{
				}
				num = (short)1233780737;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Expander)base.GetValue(global::AcpUI.AcpTableTextBoxSpinner.MyExpanderProperty);
			}
			set
			{
				short num = (short)1035599872;
				short num2 = num;
				num = (short)2132952051;
				short num3 = num;
				num = (short)533545971;
				switch (num3 == num)
				{
				}
				num = (short)165806081;
				if (num != 0)
				{
				}
				num = (short)1587871744;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinner.MyExpanderProperty, value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00031E70 File Offset: 0x00030070
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00031F28 File Offset: 0x00030128
		public global::AcpUILib.IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)2057699328;
				short num2 = num;
				num = (short)1053987232;
				short num3 = num;
				num = (short)1219858848;
				switch (num3 == num)
				{
				}
				num = (short)180355072;
				if (num != 0)
				{
				}
				num = (short)1516175361;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::AcpUI.AcpTableTextBoxSpinner.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)1571356672;
				short num2 = num;
				num = (short)5832405;
				short num3 = num;
				num = (short)1307836117;
				switch (num3 == num)
				{
				}
				num = (short)19988480;
				if (num != 0)
				{
				}
				num = (short)366477313;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinner.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00031FE0 File Offset: 0x000301E0
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00032098 File Offset: 0x00030298
		public string Text
		{
			get
			{
				short num = (short)825032704;
				short num2 = num;
				num = (short)1340441068;
				short num3 = num;
				num = (short)447578604;
				switch (num3 == num)
				{
				}
				num = (short)242024449;
				if (num != 0)
				{
				}
				num = (short)2063859712;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::AcpUI.AcpTableTextBoxSpinner.TextProperty);
			}
			set
			{
				short num = (short)68288512;
				short num2 = num;
				num = (short)1756720121;
				short num3 = num;
				num = (short)530148345;
				switch (num3 == num)
				{
				}
				num = (short)968556545;
				if (num != 0)
				{
				}
				num = (short)1580597248;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTableTextBoxSpinner.TextProperty, value);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0003214C File Offset: 0x0003034C
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00032204 File Offset: 0x00030404
		public string MaskTypeSpinner
		{
			get
			{
				short num = (short)1498284033;
				if (num != 0)
				{
				}
				num = (short)322257161;
				short num2 = num;
				num = (short)1262502153;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)768475136;
					if (num != 0)
					{
					}
					num = (short)638058496;
					short num3 = num;
					if (global::AcpUI.AcpTextBox.DisableMask)
					{
						return null;
					}
					break;
				}
				}
				return this.a;
			}
			set
			{
				short num = (short)1949827072;
				short num2 = num;
				num = (short)947297616;
				short num3 = num;
				num = (short)1286446416;
				switch (num3 == num)
				{
				}
				num = (short)2099445760;
				if (num != 0)
				{
				}
				num = (short)73072641;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000322B4 File Offset: 0x000304B4
		private void OnClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2117140480;
			short num2 = num;
			num = (short)1640500341;
			short num3 = num;
			num = (short)1275333749;
			switch (num3 == num)
			{
			}
			num = (short)67305472;
			if (num != 0)
			{
			}
			num = (short)1814560769;
			if (num != 0)
			{
			}
			global::AcpUI.Common.StepUpDownUtility.a(A_0, this.MyBLObject);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0003236C File Offset: 0x0003056C
		private void OnLostFocus(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)777125888;
			short num2 = num;
			num = (short)1249443841;
			if (num != 0)
			{
			}
			num = (short)606952125;
			short num3 = num;
			num = (short)585456317;
			switch (num3 == num)
			{
			}
			num = (short)1556807680;
			if (num != 0)
			{
			}
			this.Text = this.AcpTextBoxMember.Text;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00032428 File Offset: 0x00030628
		private void OnKeyPressUpDownEvent(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)1210843136;
			short num2 = num;
			num = (short)165909390;
			short num3 = num;
			num = (short)1083806606;
			switch (num3 == num)
			{
			}
			num = (short)277217281;
			if (num != 0)
			{
			}
			num = (short)179372032;
			if (num != 0)
			{
			}
			global::AcpUI.Common.StepUpDownUtility.a(A_1, this.MyBLObject);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000324DC File Offset: 0x000306DC
		public AcpTableTextBoxSpinner()
		{
			base.Focusable = true;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000324F8 File Offset: 0x000306F8
		global::AcpUI.AcpTextBox global::AcpUI.ISupportsTextBoxMember.TextBoxMember
		{
			get
			{
				short num = (short)782172160;
				short num2 = num;
				num = (short)1833463433;
				short num3 = num;
				num = (short)470380169;
				switch (num3 == num)
				{
				}
				num = (short)1805778945;
				if (num != 0)
				{
				}
				num = (short)199688192;
				if (num != 0)
				{
				}
				return this.AcpTextBoxMember;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002CF RID: 719 RVA: 0x000325A8 File Offset: 0x000307A8
		public global::AcpUI.AcpTableTextBoxBase AcpTextBoxMember
		{
			get
			{
				short num = (short)975568896;
				short num2 = num;
				num = (short)1291749766;
				short num3 = num;
				num = (short)689932678;
				switch (num3 == num)
				{
				}
				num = (short)1552547841;
				if (num != 0)
				{
				}
				num = (short)872087552;
				if (num != 0)
				{
				}
				return global::System.Windows.Media.VisualTreeHelper.GetChild(global::System.Windows.Media.VisualTreeHelper.GetChild(this, 0) as global::System.Windows.UIElement, 0) as global::AcpUI.AcpTableTextBoxBase;
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00032668 File Offset: 0x00030868
		// Note: this type is marked as 'beforefieldinit'.
		static AcpTableTextBoxSpinner()
		{
			int a_ = 16;
			short num = (short)458162176;
			short num2 = num;
			num = (short)1599172642;
			short num3 = num;
			num = (short)1730441250;
			switch (num3 == num)
			{
			}
			num = (short)1245184001;
			if (num != 0)
			{
			}
			num = (short)769196032;
			if (num != 0)
			{
			}
			global::AcpUI.AcpTableTextBoxSpinner.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\udba7쾫\udead펱\ud8b3\udfb5\udcb7", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxSpinner), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxSpinner.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\udba7쾫\udead슱쒳\udab5톷\ud9b9\uddbb\udcbd겿ꟁ", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxSpinner), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxSpinner.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\udba7쾫\udead횱\uddb3습\ud9b7\ud8b9킻\udbbd", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxSpinner), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxSpinner.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\udba7쾫\udead\udbb1잳\udfb5\udab7횹\ud9bb", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxSpinner), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTableTextBoxSpinner.MyLabelCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("톧춫청햯\udeb1습쪷횹", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpTableTextBoxSpinner), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxSpinner.MyCopyButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("톧쎫\udead즯솳습첷햹튻ﶽ뒿냁ꣃ", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpTableTextBoxSpinner), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxSpinner.MyBLObjectProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("톧튯\ud8b1톳햵첷", a_), typeof(global::AcpBusinessLayer.AcpFieldBase), typeof(global::AcpUI.AcpTableTextBoxSpinner), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxSpinner.AreValuesEqualProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\udaa7쾩磌쾭\udcaf잱톳억ﶷ쮹즻\udfbd겿", a_), typeof(bool), typeof(global::AcpUI.AcpTableTextBoxSpinner), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxSpinner.MyExpanderProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("톧풫\udead톯\udcb1킳펵쪷", a_), typeof(global::System.Windows.Controls.Expander), typeof(global::AcpUI.AcpTableTextBoxSpinner), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxSpinner.MyParentCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("톧睊춫\udcad햯\udcb1삳첷좹킻", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::AcpUI.AcpTableTextBoxSpinner), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTableTextBoxSpinner.TextProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("춧튩\ud8ab", a_), typeof(string), typeof(global::AcpUI.AcpTableTextBoxSpinner), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		}

		// Token: 0x040001CA RID: 458
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x040001CB RID: 459
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x040001CC RID: 460
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x040001CD RID: 461
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x040001CE RID: 462
		public static readonly global::System.Windows.DependencyProperty MyLabelCtrlProperty;

		// Token: 0x040001CF RID: 463
		public static readonly global::System.Windows.DependencyProperty MyCopyButtonProperty;

		// Token: 0x040001D0 RID: 464
		public static readonly global::System.Windows.DependencyProperty MyBLObjectProperty;

		// Token: 0x040001D1 RID: 465
		public static readonly global::System.Windows.DependencyProperty AreValuesEqualProperty;

		// Token: 0x040001D2 RID: 466
		public static readonly global::System.Windows.DependencyProperty MyExpanderProperty;

		// Token: 0x040001D3 RID: 467
		public static readonly global::System.Windows.DependencyProperty MyParentCtrlProperty;

		// Token: 0x040001D4 RID: 468
		public static readonly global::System.Windows.DependencyProperty TextProperty;

		// Token: 0x040001D5 RID: 469
		private string a;
	}
}
