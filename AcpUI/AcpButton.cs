using System;
using System.Windows;
using System.Windows.Controls;
using AcpBusinessLayer;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x02000003 RID: 3
	public class AcpButton : global::System.Windows.Controls.Button, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIParentCtrlBase, global::AcpUILib.IAcpUIChildCtrlBase, global::AcpUILib.IAcpUICommon
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000021DC File Offset: 0x000003DC
		public bool IsAcpValid
		{
			get
			{
				short num = (short)762380289;
				if (num != 0)
				{
				}
				num = (short)648590833;
				short num2 = num;
				num = (short)349353457;
				switch (num2 == num)
				{
				}
				num = (short)1892089856;
				if (num != 0)
				{
				}
				num = (short)1649606656;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpButton.IsAcpValidProperty);
			}
			set
			{
				short num = (short)1709783434;
				short num2 = num;
				num = (short)1103116682;
				switch (num2 == num)
				{
				}
				num = (short)1430061056;
				if (num != 0)
				{
				}
				num = (short)322699265;
				if (num != 0)
				{
				}
				num = (short)994967552;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpButton.IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000229C File Offset: 0x0000049C
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002358 File Offset: 0x00000558
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)1241040492;
				short num2 = num;
				num = (short)1705100908;
				switch (num2 == num)
				{
				}
				num = (short)1641807872;
				if (num != 0)
				{
				}
				num = (short)496828417;
				if (num != 0)
				{
				}
				num = (short)257032192;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpButton.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1054881797;
				short num2 = num;
				num = (short)1711355909;
				switch (num2 == num)
				{
				}
				num = (short)1135149057;
				if (num != 0)
				{
				}
				num = (short)1129185280;
				if (num != 0)
				{
				}
				num = (short)1973092352;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpButton.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002414 File Offset: 0x00000614
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000024D0 File Offset: 0x000006D0
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)1085014017;
				if (num != 0)
				{
				}
				num = (short)798465789;
				short num2 = num;
				num = (short)566599421;
				switch (num2 == num)
				{
				}
				num = (short)631308288;
				if (num != 0)
				{
				}
				num = (short)25690112;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpButton.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)593129769;
				short num2 = num;
				num = (short)638873897;
				switch (num2 == num)
				{
				}
				num = (short)1497956352;
				if (num != 0)
				{
				}
				num = (short)1076232193;
				if (num != 0)
				{
				}
				num = (short)552271872;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpButton.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000258C File Offset: 0x0000078C
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002644 File Offset: 0x00000844
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)189939129;
				short num2 = num;
				num = (short)1142046137;
				switch (num2 == num)
				{
				}
				num = (short)2137718785;
				if (num != 0)
				{
				}
				num = (short)1750990848;
				if (num != 0)
				{
				}
				num = (short)1742209024;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpButton.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1286072453;
				short num2 = num;
				num = (short)1521412229;
				switch (num2 == num)
				{
				}
				num = (short)2108227585;
				if (num != 0)
				{
				}
				num = (short)1797586944;
				if (num != 0)
				{
				}
				num = (short)1471741952;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpButton.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002700 File Offset: 0x00000900
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000027BC File Offset: 0x000009BC
		public global::AcpUILib.IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)1057334923;
				short num2 = num;
				num = (short)2035000971;
				switch (num2 == num)
				{
				}
				num = (short)949026817;
				if (num != 0)
				{
				}
				num = (short)328663040;
				if (num != 0)
				{
				}
				num = (short)1003552768;
				short num3 = num;
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpButton.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)400658115;
				short num2 = num;
				num = (short)1499041475;
				switch (num2 == num)
				{
				}
				num = (short)1744371713;
				if (num != 0)
				{
				}
				num = (short)455671808;
				if (num != 0)
				{
				}
				num = (short)2083520512;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpButton.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002874 File Offset: 0x00000A74
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002930 File Offset: 0x00000B30
		public global::AcpUILib.IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)2074703269;
				short num2 = num;
				num = (short)2051831205;
				switch (num2 == num)
				{
				}
				num = (short)1681129473;
				if (num != 0)
				{
				}
				num = (short)1955987456;
				if (num != 0)
				{
				}
				num = (short)369491968;
				short num3 = num;
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpButton.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)673588533;
				short num2 = num;
				num = (short)1717511477;
				switch (num2 == num)
				{
				}
				num = (short)1868627969;
				if (num != 0)
				{
				}
				num = (short)731054080;
				if (num != 0)
				{
				}
				num = (short)1654652928;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpButton.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000029E4 File Offset: 0x00000BE4
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002AA0 File Offset: 0x00000CA0
		public global::AcpBusinessLayer.AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)2006013636;
				short num2 = num;
				num = (short)913462980;
				switch (num2 == num)
				{
				}
				num = (short)2009989121;
				if (num != 0)
				{
				}
				num = (short)1352990720;
				if (num != 0)
				{
				}
				num = (short)779354112;
				short num3 = num;
				return (global::AcpBusinessLayer.AcpFieldBase)base.GetValue(global::AcpUI.AcpButton.MyBLObjectProperty);
			}
			set
			{
				short num = (short)1924290332;
				short num2 = num;
				num = (short)1053644572;
				switch (num2 == num)
				{
				}
				num = (short)1673003009;
				if (num != 0)
				{
				}
				num = (short)1315635200;
				if (num != 0)
				{
				}
				num = (short)1623064576;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpButton.MyBLObjectProperty, value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002B54 File Offset: 0x00000D54
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002C10 File Offset: 0x00000E10
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)2046834512;
				short num2 = num;
				num = (short)1013528400;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1667760128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2001141760;
				if (num != 0)
				{
				}
				num = (short)29032449;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpButton.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)1060882953;
				short num2 = num;
				num = (short)618973705;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1944387584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)565968897;
				if (num != 0)
				{
				}
				num = (short)220725248;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpButton.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002CD0 File Offset: 0x00000ED0
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002D88 File Offset: 0x00000F88
		public global::System.Windows.Controls.Expander MyExpander
		{
			get
			{
				short num = (short)509371245;
				short num2 = num;
				num = (short)407987053;
				switch (num2 == num)
				{
				default:
				{
					num = (short)105250816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1898774528;
				if (num != 0)
				{
				}
				num = (short)190709761;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Expander)base.GetValue(global::AcpUI.AcpButton.MyExpanderProperty);
			}
			set
			{
				short num = (short)1810022102;
				short num2 = num;
				num = (short)1184218838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)309133312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2080636929;
				if (num != 0)
				{
				}
				num = (short)1563557888;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpButton.MyExpanderProperty, value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002E40 File Offset: 0x00001040
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002EF4 File Offset: 0x000010F4
		public global::AcpUILib.IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)1697152497;
				short num2 = num;
				num = (short)86474225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)588382208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1672413185;
				if (num != 0)
				{
				}
				num = (short)1829830656;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::AcpUI.AcpButton.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)126610258;
				short num2 = num;
				num = (short)1636363090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2074345472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)143327232;
				if (num != 0)
				{
				}
				num = (short)271450113;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpButton.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002FBC File Offset: 0x000011BC
		// Note: this type is marked as 'beforefieldinit'.
		static AcpButton()
		{
			int a_ = 3;
			short num = (short)1788587377;
			short num2 = num;
			num = (short)1478602097;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1210449920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1271005185;
			if (num != 0)
			{
			}
			num = (short)1733754880;
			if (num != 0)
			{
			}
			global::AcpUI.AcpButton.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("킘\udc9cﲞ토쒤쮦삨쾪", a_), typeof(bool), typeof(global::AcpUI.AcpButton), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpButton.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("킘\udc9cﲞ토햤힦얨슪캬캮펰\udfb2킴", a_), typeof(bool), typeof(global::AcpUI.AcpButton), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpButton.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("킘\udc9cﲞ토솤캦\udda8쪪쾬쎮풰", a_), typeof(bool), typeof(global::AcpUI.AcpButton), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpButton.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("킘\udc9cﲞ토첤풦삨즪솬쪮", a_), typeof(bool), typeof(global::AcpUI.AcpButton), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpButton.MyLabelCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("풘톜ﺞ쎠욢즤\udda8\ud9aa솬", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpButton), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpButton.MyCopyButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("풘\ude9c토\udaa2튦\udda8\udfaa슬솮잲잴\udbb6", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpButton), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpButton.MyBLObjectProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("풘\udf9c펞솢쾤슦쪨\udfaa", a_), typeof(global::AcpBusinessLayer.AcpFieldBase), typeof(global::AcpUI.AcpButton), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpButton.AreValuesEqualProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud898즞삠쾢키슦\udaa8\udcac\udaae킰\udfb2", a_), typeof(bool), typeof(global::AcpUI.AcpButton), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpButton.MyExpanderProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("풘\ud89c토슢쮤쎦첨\ud9aa", a_), typeof(global::System.Windows.Controls.Expander), typeof(global::AcpUI.AcpButton), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpButton.MyParentCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("풘출ﺞ펠욢쮤펦\udfaa\udfac쎮", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::AcpUI.AcpButton), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x04000003 RID: 3
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x04000004 RID: 4
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x04000005 RID: 5
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x04000006 RID: 6
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x04000007 RID: 7
		public static readonly global::System.Windows.DependencyProperty MyLabelCtrlProperty;

		// Token: 0x04000008 RID: 8
		public static readonly global::System.Windows.DependencyProperty MyCopyButtonProperty;

		// Token: 0x04000009 RID: 9
		public static readonly global::System.Windows.DependencyProperty MyBLObjectProperty;

		// Token: 0x0400000A RID: 10
		public static readonly global::System.Windows.DependencyProperty AreValuesEqualProperty;

		// Token: 0x0400000B RID: 11
		public static readonly global::System.Windows.DependencyProperty MyExpanderProperty;

		// Token: 0x0400000C RID: 12
		public static readonly global::System.Windows.DependencyProperty MyParentCtrlProperty;
	}
}
