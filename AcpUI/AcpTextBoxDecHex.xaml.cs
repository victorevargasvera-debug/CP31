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
	// Token: 0x02000034 RID: 52
	public partial class AcpTextBoxDecHex : UserControl, IAcpUICtrlBase, IAcpUIValueCtrlBase<string>, IAcpUIParentCtrlBase, IAcpUIChildCtrlBase, IAcpUICommon, ISupportsTextBoxMember
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x000345E0 File Offset: 0x000327E0
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00034694 File Offset: 0x00032894
		public string Value
		{
			get
			{
				short num = (short)590416235;
				short num2 = num;
				num = (short)2089814379;
				switch (num2 == num)
				{
				}
				num = (short)1476984832;
				short num3 = num;
				num = (short)1221853184;
				if (num != 0)
				{
				}
				num = (short)1505427457;
				if (num != 0)
				{
				}
				return this.Text;
			}
			set
			{
				short num = (short)447634652;
				short num2 = num;
				num = (short)499342556;
				switch (num2 == num)
				{
				}
				num = (short)782827520;
				short num3 = num;
				num = (short)492175361;
				if (num != 0)
				{
				}
				num = (short)1198260224;
				if (num != 0)
				{
				}
				this.Text = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00034744 File Offset: 0x00032944
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00034800 File Offset: 0x00032A00
		public bool IsAcpValid
		{
			get
			{
				short num = (short)2114413964;
				short num2 = num;
				num = (short)1649501580;
				switch (num2 == num)
				{
				}
				num = (short)966459392;
				short num3 = num;
				num = (short)1854865409;
				if (num != 0)
				{
				}
				num = (short)1713438720;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxDecHex.IsAcpValidProperty);
			}
			set
			{
				short num = (short)876778698;
				short num2 = num;
				num = (short)1537709258;
				switch (num2 == num)
				{
				}
				num = (short)512557056;
				short num3 = num;
				num = (short)347602945;
				if (num != 0)
				{
				}
				num = (short)339017728;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxDecHex.IsAcpValidProperty, value);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002FA RID: 762 RVA: 0x000348BC File Offset: 0x00032ABC
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00034978 File Offset: 0x00032B78
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)946339841;
				if (num != 0)
				{
				}
				num = (short)698380928;
				short num2 = num;
				num = (short)226456192;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1185873920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)71237632;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxDecHex.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1209228323;
				short num2 = num;
				num = (short)230906915;
				switch (num2 == num)
				{
				}
				num = (short)673120256;
				short num3 = num;
				num = (short)1376911360;
				if (num != 0)
				{
				}
				num = (short)1335099393;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxDecHex.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00034A30 File Offset: 0x00032C30
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00034AE8 File Offset: 0x00032CE8
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)911738404;
				short num2 = num;
				num = (short)513934884;
				switch (num2 == num)
				{
				}
				num = (short)608567296;
				short num3 = num;
				num = (short)1040318464;
				if (num != 0)
				{
				}
				num = (short)655361;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxDecHex.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1515136436;
				short num2 = num;
				num = (short)1482171828;
				switch (num2 == num)
				{
				}
				num = (short)2002386944;
				short num3 = num;
				num = (short)1356005376;
				if (num != 0)
				{
				}
				num = (short)1156775937;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxDecHex.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00034BA0 File Offset: 0x00032DA0
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00034C5C File Offset: 0x00032E5C
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)1751659289;
				short num2 = num;
				num = (short)2113352473;
				switch (num2 == num)
				{
				}
				num = (short)2094268416;
				short num3 = num;
				num = (short)103350273;
				if (num != 0)
				{
				}
				num = (short)647823360;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxDecHex.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2109575277;
				short num2 = num;
				num = (short)399675501;
				switch (num2 == num)
				{
				}
				num = (short)186843136;
				short num3 = num;
				num = (short)2004746240;
				if (num != 0)
				{
				}
				num = (short)122224641;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxDecHex.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00034D14 File Offset: 0x00032F14
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00034DCC File Offset: 0x00032FCC
		public IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)1324269712;
				short num2 = num;
				num = (short)136036496;
				switch (num2 == num)
				{
				}
				num = (short)1433010176;
				short num3 = num;
				num = (short)465829889;
				if (num != 0)
				{
				}
				num = (short)1453522944;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpTextBoxDecHex.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)28688031;
				short num2 = num;
				num = (short)1827389087;
				switch (num2 == num)
				{
				}
				num = (short)1737162752;
				short num3 = num;
				num = (short)250937345;
				if (num != 0)
				{
				}
				num = (short)332201984;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxDecHex.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00034E80 File Offset: 0x00033080
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00034F38 File Offset: 0x00033138
		public IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)194550245;
				short num2 = num;
				num = (short)580819429;
				switch (num2 == num)
				{
				}
				num = (short)1853423616;
				short num3 = num;
				num = (short)391774209;
				if (num != 0)
				{
				}
				num = (short)676724736;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpTextBoxDecHex.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)1984299008;
				short num2 = num;
				num = (short)512339818;
				short num3 = num;
				num = (short)259960682;
				switch (num3 == num)
				{
				}
				num = (short)1297285121;
				if (num != 0)
				{
				}
				num = (short)2086666240;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxDecHex.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00034FF0 File Offset: 0x000331F0
		// (set) Token: 0x06000305 RID: 773 RVA: 0x000350AC File Offset: 0x000332AC
		public AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)153419776;
				short num2 = num;
				num = (short)829124785;
				short num3 = num;
				num = (short)55144625;
				switch (num3 == num)
				{
				}
				num = (short)960888833;
				if (num != 0)
				{
				}
				num = (short)1753808896;
				if (num != 0)
				{
				}
				return (AcpFieldBase)base.GetValue(AcpTextBoxDecHex.MyBLObjectProperty);
			}
			set
			{
				short num = (short)1979187200;
				short num2 = num;
				num = (short)922550273;
				if (num != 0)
				{
				}
				num = (short)1652519159;
				short num3 = num;
				num = (short)1663594743;
				switch (num3 == num)
				{
				}
				num = (short)1706033152;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxDecHex.MyBLObjectProperty, value);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00035160 File Offset: 0x00033360
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0003521C File Offset: 0x0003341C
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)2099904512;
				short num2 = num;
				num = (short)1745815025;
				short num3 = num;
				num = (short)486671857;
				switch (num3 == num)
				{
				}
				num = (short)2000420865;
				if (num != 0)
				{
				}
				num = (short)806223872;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxDecHex.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)1424621568;
				short num2 = num;
				num = (short)1239868983;
				short num3 = num;
				num = (short)1445193271;
				switch (num3 == num)
				{
				}
				num = (short)2008547328;
				if (num != 0)
				{
				}
				num = (short)2013462529;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxDecHex.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000308 RID: 776 RVA: 0x000352D4 File Offset: 0x000334D4
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00035390 File Offset: 0x00033590
		public Expander MyExpander
		{
			get
			{
				short num = (short)481165312;
				short num2 = num;
				num = (short)758709595;
				short num3 = num;
				num = (short)1691155803;
				switch (num3 == num)
				{
				}
				num = (short)2086862848;
				if (num != 0)
				{
				}
				num = (short)1045692417;
				if (num != 0)
				{
				}
				return (Expander)base.GetValue(AcpTextBoxDecHex.MyExpanderProperty);
			}
			set
			{
				short num = (short)777846784;
				short num2 = num;
				num = (short)1650087292;
				short num3 = num;
				num = (short)981357948;
				switch (num3 == num)
				{
				}
				num = (short)1194131457;
				if (num != 0)
				{
				}
				num = (short)1121845248;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxDecHex.MyExpanderProperty, value);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00035448 File Offset: 0x00033648
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00035500 File Offset: 0x00033700
		public IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)699727872;
				short num2 = num;
				num = (short)543829050;
				short num3 = num;
				num = (short)225586234;
				switch (num3 == num)
				{
				}
				num = (short)2106458112;
				if (num != 0)
				{
				}
				num = (short)735313921;
				if (num != 0)
				{
				}
				return (IAcpUIParentCtrlBase)base.GetValue(AcpTextBoxDecHex.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)1275789312;
				short num2 = num;
				num = (short)413761983;
				short num3 = num;
				num = (short)2009694655;
				switch (num3 == num)
				{
				}
				num = (short)459735040;
				if (num != 0)
				{
				}
				num = (short)1911029761;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxDecHex.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000355B8 File Offset: 0x000337B8
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00035674 File Offset: 0x00033874
		public string Text
		{
			get
			{
				short num = (short)1666318336;
				short num2 = num;
				num = (short)412876801;
				if (num != 0)
				{
				}
				num = (short)1161206083;
				short num3 = num;
				num = (short)424319299;
				switch (num3 == num)
				{
				}
				num = (short)1164509184;
				if (num != 0)
				{
				}
				return (string)base.GetValue(AcpTextBoxDecHex.TextProperty);
			}
			set
			{
				short num = (short)1377173504;
				short num2 = num;
				num = (short)637100791;
				short num3 = num;
				num = (short)1558405879;
				switch (num3 == num)
				{
				}
				num = (short)953942016;
				if (num != 0)
				{
				}
				num = (short)2012807169;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxDecHex.TextProperty, value);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00035728 File Offset: 0x00033928
		// (set) Token: 0x0600030F RID: 783 RVA: 0x000357E4 File Offset: 0x000339E4
		public string HexText
		{
			get
			{
				short num = (short)981467136;
				short num2 = num;
				num = (short)1542931521;
				short num3 = num;
				num = (short)438060097;
				switch (num3 == num)
				{
				}
				num = (short)561905665;
				if (num != 0)
				{
				}
				num = (short)1580007424;
				if (num != 0)
				{
				}
				return (string)base.GetValue(AcpTextBoxDecHex.HexTextProperty);
			}
			set
			{
				short num = (short)864223232;
				short num2 = num;
				num = (short)1701932277;
				short num3 = num;
				num = (short)1090940149;
				switch (num3 == num)
				{
				}
				num = (short)1523777537;
				if (num != 0)
				{
				}
				num = (short)1561067520;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxDecHex.HexTextProperty, value);
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00035898 File Offset: 0x00033A98
		private void OnKeyPressUpDownNoAction(object A_0, KeyEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			Key key;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (key != Key.Up)
					{
						goto IL_44;
					}
					goto IL_5D;
				case 1:
					goto IL_5D;
				case 2:
					if (key == Key.Down)
					{
						num2 = (short)641335297;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
				{
					num2 = (short)1667432448;
					short num3 = num2;
					num2 = (short)292159490;
					num = (int)((IntPtr)num2);
					continue;
				}
				}
				goto IL_24;
				IL_44:
				num2 = (short)2000814084;
				num = (int)((IntPtr)num2);
				continue;
				IL_5D:
				A_1.Handled = true;
				num2 = (short)882915159;
				short num4 = num2;
				num2 = (short)1936406359;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_44;
				default:
					num2 = (short)1758134273;
					if (num2 != 0)
					{
					}
					num2 = (short)563019776;
					if (num2 != 0)
					{
					}
					num2 = (short)1396965379;
					num = (int)((IntPtr)num2);
					break;
				}
			}
			return;
			IL_24:
			key = A_1.Key;
			num2 = (short)1806761984;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000359F8 File Offset: 0x00033BF8
		protected override void OnGotFocus(RoutedEventArgs e)
		{
			short num = (short)1826160640;
			short num2 = num;
			num = (short)1488283906;
			short num3 = num;
			num = (short)520579330;
			switch (num3 == num)
			{
			}
			num = (short)2037710849;
			if (num != 0)
			{
			}
			num = (short)1685585920;
			if (num != 0)
			{
			}
			this.a.Focus();
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00035AB0 File Offset: 0x00033CB0
		public AcpTextBoxDecHex()
		{
			this.InitializeComponent();
			base.Focusable = true;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00035AD0 File Offset: 0x00033CD0
		AcpTextBox ISupportsTextBoxMember.TextBoxMember
		{
			get
			{
				short num = (short)1722744832;
				short num2 = num;
				num = (short)794970606;
				short num3 = num;
				num = (short)325863918;
				switch (num3 == num)
				{
				}
				num = (short)915931137;
				if (num != 0)
				{
				}
				num = (short)64487424;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00035C5C File Offset: 0x00033E5C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		internal Delegate a(Type A_0, string A_1)
		{
			short num = (short)2137980928;
			short num2 = num;
			num = (short)2080078831;
			short num3 = num;
			num = (short)1586396143;
			switch (num3 == num)
			{
			}
			num = (short)1466957825;
			if (num != 0)
			{
			}
			num = (short)1112539136;
			if (num != 0)
			{
			}
			return Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00035E78 File Offset: 0x00034078
		// Note: this type is marked as 'beforefieldinit'.
		static AcpTextBoxDecHex()
		{
			int a_ = 7;
			short num = (short)22544384;
			short num2 = num;
			num = (short)1529244983;
			short num3 = num;
			num = (short)714370359;
			switch (num3 == num)
			{
			}
			num = (short)1374683136;
			if (num != 0)
			{
			}
			num = (short)1700593665;
			if (num != 0)
			{
			}
			AcpTextBoxDecHex.IsAcpValidProperty = DependencyProperty.Register(Utility.c("풜삢햤좨잪쒬쮮", a_), typeof(bool), typeof(AcpTextBoxDecHex), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxDecHex.IsAcpApplicableProperty = DependencyProperty.Register(Utility.c("풜삢햤\ud9a8\udbaa솬욮튰튲ힴ\udbb6\udcb8", a_), typeof(bool), typeof(AcpTextBoxDecHex), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxDecHex.IsAcpEditableProperty = DependencyProperty.Register(Utility.c("풜삢햤춨슪\ud9ac캮펰\udfb2킴", a_), typeof(bool), typeof(AcpTextBoxDecHex), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxDecHex.IsAcpVisibleProperty = DependencyProperty.Register(Utility.c("풜삢햤삨\ud8aa쒬춮\uddb0횲", a_), typeof(bool), typeof(AcpTextBoxDecHex), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxDecHex.MyLabelCtrlProperty = DependencyProperty.RegisterAttached(Utility.c("킜슢잤슦얨\ud9ac\uddae\uddb0", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpTextBoxDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxDecHex.MyCopyButtonProperty = DependencyProperty.RegisterAttached(Utility.c("킜첢햤\udea6\udeaa\ud9ac\udbae\udeb0\uddb2쎶쮸ힺ", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpTextBoxDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxDecHex.MyBLObjectProperty = DependencyProperty.RegisterAttached(Utility.c("킜얦쎨캪캬\udbae", a_), typeof(AcpFieldBase), typeof(AcpTextBoxDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxDecHex.AreValuesEqualProperty = DependencyProperty.Register(Utility.c("\udc9c쒠쒤쮦\udca8캪\udeac산욲풴\udbb6", a_), typeof(bool), typeof(AcpTextBoxDecHex), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxDecHex.MyExpanderProperty = DependencyProperty.RegisterAttached(Utility.c("킜\udba2햤욦잨쾪좬\uddae", a_), typeof(Expander), typeof(AcpTextBoxDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxDecHex.MyParentCtrlProperty = DependencyProperty.RegisterAttached(Utility.c("킜슢힤슦잨\udfaa\udbae쎰\udfb2", a_), typeof(IAcpUIParentCtrlBase), typeof(AcpTextBoxDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxDecHex.TextProperty = DependencyProperty.Register(Utility.c("즜爵\ud9a0힢", a_), typeof(string), typeof(AcpTextBoxDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxDecHex.HexTextProperty = DependencyProperty.Register(Utility.c("햜爵\ud9a0삤\udfa6\udda8", a_), typeof(string), typeof(AcpTextBoxDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		}

		// Token: 0x040001E3 RID: 483
		public static readonly DependencyProperty IsAcpValidProperty;

		// Token: 0x040001E4 RID: 484
		public static readonly DependencyProperty IsAcpApplicableProperty;

		// Token: 0x040001E5 RID: 485
		public static readonly DependencyProperty IsAcpEditableProperty;

		// Token: 0x040001E6 RID: 486
		public static readonly DependencyProperty IsAcpVisibleProperty;

		// Token: 0x040001E7 RID: 487
		public static readonly DependencyProperty MyLabelCtrlProperty;

		// Token: 0x040001E8 RID: 488
		public static readonly DependencyProperty MyCopyButtonProperty;

		// Token: 0x040001E9 RID: 489
		public static readonly DependencyProperty MyBLObjectProperty;

		// Token: 0x040001EA RID: 490
		public static readonly DependencyProperty AreValuesEqualProperty;

		// Token: 0x040001EB RID: 491
		public static readonly DependencyProperty MyExpanderProperty;

		// Token: 0x040001EC RID: 492
		public static readonly DependencyProperty MyParentCtrlProperty;

		// Token: 0x040001ED RID: 493
		public static readonly DependencyProperty TextProperty;

		// Token: 0x040001EE RID: 494
		public static readonly DependencyProperty HexTextProperty;
	}
}
