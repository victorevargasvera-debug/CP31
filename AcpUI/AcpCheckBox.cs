using System;
using System.Windows;
using System.Windows.Controls;
using AcpBusinessLayer;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x02000006 RID: 6
	public class AcpCheckBox : global::System.Windows.Controls.CheckBox, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIValueCtrlBase<bool>, global::AcpUILib.IAcpUIParentCtrlBase, global::AcpUILib.IAcpUIChildCtrlBase, global::AcpUILib.IAcpUICommon
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000433C File Offset: 0x0000253C
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000043F4 File Offset: 0x000025F4
		public bool Value
		{
			get
			{
				short num = (short)931398695;
				short num2 = num;
				num = (short)750978087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1051590656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1012203521;
				if (num != 0)
				{
				}
				num = (short)261423104;
				if (num != 0)
				{
				}
				return base.IsChecked.Value;
			}
			set
			{
				short num = (short)1414514571;
				short num2 = num;
				num = (short)1301596043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1454571520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)862715905;
				if (num != 0)
				{
				}
				num = (short)1463091200;
				if (num != 0)
				{
				}
				base.IsChecked = new bool?(value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000044A8 File Offset: 0x000026A8
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00004564 File Offset: 0x00002764
		public bool IsAcpValid
		{
			get
			{
				short num = (short)1139666331;
				short num2 = num;
				num = (short)1825369499;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1716191232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)241303553;
				if (num != 0)
				{
				}
				num = (short)1827143680;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCheckBox.IsAcpValidProperty);
			}
			set
			{
				short num = (short)1590023505;
				short num2 = num;
				num = (short)1264244049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1185087488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)873660416;
				if (num != 0)
				{
				}
				num = (short)2016215041;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCheckBox.IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000461C File Offset: 0x0000281C
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000046D4 File Offset: 0x000028D4
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)445317121;
				if (num != 0)
				{
				}
				num = (short)206176256;
				short num2 = num;
				num = (short)1940665141;
				short num3 = num;
				num = (short)1256272693;
				switch (num3 == num)
				{
				}
				num = (short)774766592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCheckBox.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1138414964;
				short num2 = num;
				num = (short)973460852;
				switch (num2 == num)
				{
				default:
				{
					num = (short)817430528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1708523521;
				if (num != 0)
				{
				}
				num = (short)127139840;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCheckBox.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00004790 File Offset: 0x00002990
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00004848 File Offset: 0x00002A48
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)1131384904;
				short num2 = num;
				num = (short)1883803720;
				switch (num2 == num)
				{
				default:
				{
					num = (short)504496128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1600913409;
				if (num != 0)
				{
				}
				num = (short)155189248;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCheckBox.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)756574695;
				short num2 = num;
				num = (short)1523870183;
				switch (num2 == num)
				{
				default:
				{
					num = (short)638517248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1652424704;
				if (num != 0)
				{
				}
				num = (short)1290338305;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCheckBox.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00004904 File Offset: 0x00002B04
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000049BC File Offset: 0x00002BBC
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)328641890;
				short num2 = num;
				num = (short)381529442;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1294139392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)574554113;
				if (num != 0)
				{
				}
				num = (short)2016083968;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCheckBox.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1951003656;
				short num2 = num;
				num = (short)1240986632;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1619394560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)696254464;
				if (num != 0)
				{
				}
				num = (short)928186369;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCheckBox.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00004A78 File Offset: 0x00002C78
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00004B30 File Offset: 0x00002D30
		public global::AcpUILib.IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)1776562128;
				short num2 = num;
				num = (short)1534537680;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1931542528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)755171329;
				if (num != 0)
				{
				}
				num = (short)210763776;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpCheckBox.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)790414104;
				short num2 = num;
				num = (short)588694296;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1441333248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2136932353;
				if (num != 0)
				{
				}
				num = (short)1910308864;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCheckBox.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00004BEC File Offset: 0x00002DEC
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00004CA8 File Offset: 0x00002EA8
		public global::AcpUILib.IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)1007202008;
				short num2 = num;
				num = (short)1489088216;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2132738048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1364590593;
				if (num != 0)
				{
				}
				num = (short)593100800;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpCheckBox.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)2174108;
				short num2 = num;
				num = (short)1600072860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1104543744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1472069633;
				if (num != 0)
				{
				}
				num = (short)1323368448;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCheckBox.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00004D5C File Offset: 0x00002F5C
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00004E14 File Offset: 0x00003014
		public global::AcpBusinessLayer.AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)398467004;
				short num2 = num;
				num = (short)1427840956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1660026880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1979645953;
				if (num != 0)
				{
				}
				num = (short)738590720;
				if (num != 0)
				{
				}
				return (global::AcpBusinessLayer.AcpFieldBase)base.GetValue(global::AcpUI.AcpCheckBox.MyBLObjectProperty);
			}
			set
			{
				short num = (short)1525365709;
				short num2 = num;
				num = (short)200555469;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1464729600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1201143809;
				if (num != 0)
				{
				}
				num = (short)809697280;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCheckBox.MyBLObjectProperty, value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00004ECC File Offset: 0x000030CC
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00004F84 File Offset: 0x00003184
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)1372487197;
				short num2 = num;
				num = (short)2091613725;
				switch (num2 == num)
				{
				}
				num = (short)439156736;
				if (num != 0)
				{
				}
				num = (short)389152768;
				short num3 = num;
				num = (short)1619132417;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpCheckBox.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)1881939276;
				short num2 = num;
				num = (short)224140620;
				switch (num2 == num)
				{
				}
				num = (short)1539047425;
				if (num != 0)
				{
				}
				num = (short)1035665408;
				short num3 = num;
				num = (short)1221984256;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCheckBox.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000503C File Offset: 0x0000323C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000050F0 File Offset: 0x000032F0
		public global::System.Windows.Controls.Expander MyExpander
		{
			get
			{
				short num = (short)2083914406;
				short num2 = num;
				num = (short)170459814;
				switch (num2 == num)
				{
				}
				num = (short)222822401;
				if (num != 0)
				{
				}
				num = (short)1924857856;
				short num3 = num;
				num = (short)107020288;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Expander)base.GetValue(global::AcpUI.AcpCheckBox.MyExpanderProperty);
			}
			set
			{
				short num = (short)1602712225;
				short num2 = num;
				num = (short)1835758241;
				switch (num2 == num)
				{
				}
				num = (short)1475149825;
				if (num != 0)
				{
				}
				num = (short)702414848;
				short num3 = num;
				num = (short)1666383872;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCheckBox.MyExpanderProperty, value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000051A4 File Offset: 0x000033A4
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00005260 File Offset: 0x00003460
		public global::AcpUILib.IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)1240768532;
				short num2 = num;
				num = (short)345612308;
				switch (num2 == num)
				{
				}
				num = (short)1742864385;
				if (num != 0)
				{
				}
				num = (short)786366464;
				short num3 = num;
				num = (short)1432420352;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::AcpUI.AcpCheckBox.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)632116665;
				short num2 = num;
				num = (short)234575289;
				switch (num2 == num)
				{
				}
				num = (short)1597702145;
				if (num != 0)
				{
				}
				num = (short)1245577216;
				short num3 = num;
				num = (short)1778515968;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpCheckBox.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005314 File Offset: 0x00003514
		public AcpCheckBox()
		{
			base.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Left;
			base.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005338 File Offset: 0x00003538
		// Note: this type is marked as 'beforefieldinit'.
		static AcpCheckBox()
		{
			int a_ = 14;
			short num = (short)1065780702;
			short num2 = num;
			num = (short)1363576286;
			switch (num2 == num)
			{
			}
			num = (short)948895744;
			if (num != 0)
			{
			}
			num = (short)336723968;
			short num3 = num;
			num = (short)1466236929;
			if (num != 0)
			{
			}
			global::AcpUI.AcpCheckBox.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("향즩\udcab톯\udeb1\uddb3튵", a_), typeof(bool), typeof(global::AcpUI.AcpCheckBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpCheckBox.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("향즩\udcab삯슱\ud8b3\udfb5\udbb7\udbb9\udebb튽ꖿ", a_), typeof(bool), typeof(global::AcpUI.AcpCheckBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpCheckBox.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("향즩\udcab풯\udbb1삳ힵ\udab7횹\ud9bb", a_), typeof(bool), typeof(global::AcpUI.AcpCheckBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpCheckBox.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("향즩\udcab\ud9af솱\uddb3풵풷\udfb9", a_), typeof(bool), typeof(global::AcpUI.AcpCheckBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpCheckBox.MyLabelCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udfa5쮩캫쮭\udcaf삳쒵풷", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpCheckBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpCheckBox.MyCopyButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udfa5얩\udcab힭잱삳습ힷ풹ﾻ쪽늿껁", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpCheckBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpCheckBox.MyBLObjectProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udfa5청\udaafힱힳ습", a_), typeof(global::AcpBusinessLayer.AcpFieldBase), typeof(global::AcpUI.AcpCheckBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpCheckBox.AreValuesEqualProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("풥춧ﲩ춫슭얯ힱ잳즷쾹\uddbb튽", a_), typeof(bool), typeof(global::AcpUI.AcpCheckBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpCheckBox.MyExpanderProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udfa5튩\udcab쾭\udeaf횱톳쒵", a_), typeof(global::System.Windows.Controls.Expander), typeof(global::AcpUI.AcpCheckBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpCheckBox.MyParentCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udfa5쮩\udeab쮭\udeaf욱습쪷횹", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::AcpUI.AcpCheckBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x04000019 RID: 25
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x0400001A RID: 26
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x0400001B RID: 27
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x0400001C RID: 28
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x0400001D RID: 29
		public static readonly global::System.Windows.DependencyProperty MyLabelCtrlProperty;

		// Token: 0x0400001E RID: 30
		public static readonly global::System.Windows.DependencyProperty MyCopyButtonProperty;

		// Token: 0x0400001F RID: 31
		public static readonly global::System.Windows.DependencyProperty MyBLObjectProperty;

		// Token: 0x04000020 RID: 32
		public static readonly global::System.Windows.DependencyProperty AreValuesEqualProperty;

		// Token: 0x04000021 RID: 33
		public static readonly global::System.Windows.DependencyProperty MyExpanderProperty;

		// Token: 0x04000022 RID: 34
		public static readonly global::System.Windows.DependencyProperty MyParentCtrlProperty;
	}
}
