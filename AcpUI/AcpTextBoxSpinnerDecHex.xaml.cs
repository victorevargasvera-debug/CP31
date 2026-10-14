using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using AcpBusinessLayer;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x02000037 RID: 55
	public partial class AcpTextBoxSpinnerDecHex : UserControl, IAcpUICtrlBase, IAcpUIValueCtrlBase<string>, IAcpUIParentCtrlBase, IAcpUIChildCtrlBase, IAcpUICommon, ISupportsTextBoxMember
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00039EF4 File Offset: 0x000380F4
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00039FA0 File Offset: 0x000381A0
		public string Value
		{
			get
			{
				short num = (short)1435201317;
				short num2 = num;
				num = (short)487747365;
				switch (num2 == num)
				{
				}
				num = (short)988086273;
				if (num != 0)
				{
				}
				num = (short)1516044288;
				short num3 = num;
				num = (short)872546304;
				if (num != 0)
				{
				}
				return this.Text;
			}
			set
			{
				short num = (short)1567678211;
				short num2 = num;
				num = (short)6807299;
				switch (num2 == num)
				{
				}
				num = (short)599261184;
				if (num != 0)
				{
				}
				num = (short)1358430208;
				short num3 = num;
				num = (short)1051262977;
				if (num != 0)
				{
				}
				this.Text = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0003A050 File Offset: 0x00038250
		// (set) Token: 0x06000363 RID: 867 RVA: 0x0003A10C File Offset: 0x0003830C
		public bool IsAcpValid
		{
			get
			{
				short num = (short)162673765;
				short num2 = num;
				num = (short)1733112933;
				switch (num2 == num)
				{
				}
				num = (short)397672448;
				if (num != 0)
				{
				}
				num = (short)429719552;
				short num3 = num;
				num = (short)715063297;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinnerDecHex.IsAcpValidProperty);
			}
			set
			{
				short num = (short)1617353058;
				short num2 = num;
				num = (short)2144655714;
				switch (num2 == num)
				{
				}
				num = (short)1462042624;
				if (num != 0)
				{
				}
				num = (short)1366818816;
				short num3 = num;
				num = (short)1188626433;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinnerDecHex.IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0003A1C8 File Offset: 0x000383C8
		// (set) Token: 0x06000365 RID: 869 RVA: 0x0003A284 File Offset: 0x00038484
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)84947547;
				short num2 = num;
				num = (short)326775387;
				switch (num2 == num)
				{
				}
				num = (short)425721856;
				if (num != 0)
				{
				}
				num = (short)752943104;
				short num3 = num;
				num = (short)1493041153;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinnerDecHex.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1330899295;
				short num2 = num;
				num = (short)997583199;
				switch (num2 == num)
				{
				}
				num = (short)2015428608;
				if (num != 0)
				{
				}
				num = (short)144375808;
				short num3 = num;
				num = (short)298254337;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinnerDecHex.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0003A33C File Offset: 0x0003853C
		// (set) Token: 0x06000367 RID: 871 RVA: 0x0003A3F4 File Offset: 0x000385F4
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)1057043335;
				short num2 = num;
				num = (short)984363911;
				switch (num2 == num)
				{
				}
				num = (short)689242113;
				if (num != 0)
				{
				}
				num = (short)60227584;
				short num3 = num;
				num = (short)582156288;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinnerDecHex.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1942104124;
				short num2 = num;
				num = (short)785393724;
				switch (num2 == num)
				{
				}
				num = (short)565575680;
				if (num != 0)
				{
				}
				num = (short)2024472576;
				short num3 = num;
				num = (short)1002766337;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinnerDecHex.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0003A4B0 File Offset: 0x000386B0
		// (set) Token: 0x06000369 RID: 873 RVA: 0x0003A56C File Offset: 0x0003876C
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)1675704402;
				short num2 = num;
				num = (short)1623668818;
				switch (num2 == num)
				{
				}
				num = (short)733478913;
				if (num != 0)
				{
				}
				num = (short)93847552;
				short num3 = num;
				num = (short)99155968;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinnerDecHex.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1394147329;
				if (num != 0)
				{
				}
				num = (short)1219554291;
				short num2 = num;
				num = (short)1200352243;
				switch (num2 == num)
				{
				}
				num = (short)1256914944;
				short num3 = num;
				num = (short)518979584;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinnerDecHex.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0003A628 File Offset: 0x00038828
		// (set) Token: 0x0600036B RID: 875 RVA: 0x0003A6E0 File Offset: 0x000388E0
		public IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)696254465;
				if (num != 0)
				{
				}
				num = (short)946781958;
				short num2 = num;
				num = (short)1616494342;
				switch (num2 == num)
				{
				}
				num = (short)1841168384;
				short num3 = num;
				num = (short)475267072;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpTextBoxSpinnerDecHex.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)1737929120;
				short num2 = num;
				num = (short)803123616;
				switch (num2 == num)
				{
				}
				num = (short)174325761;
				if (num != 0)
				{
				}
				num = (short)345178112;
				short num3 = num;
				num = (short)1044316160;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinnerDecHex.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0003A794 File Offset: 0x00038994
		// (set) Token: 0x0600036D RID: 877 RVA: 0x0003A850 File Offset: 0x00038A50
		public IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)1261502465;
				if (num != 0)
				{
				}
				num = (short)783594415;
				short num2 = num;
				num = (short)1840952239;
				switch (num2 == num)
				{
				}
				num = (short)1111097344;
				short num3 = num;
				num = (short)2009792512;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpTextBoxSpinnerDecHex.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)928344077;
				short num2 = num;
				num = (short)1743480845;
				switch (num2 == num)
				{
				}
				num = (short)1806172161;
				if (num != 0)
				{
				}
				num = (short)472645632;
				short num3 = num;
				num = (short)1047068672;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinnerDecHex.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0003A904 File Offset: 0x00038B04
		// (set) Token: 0x0600036F RID: 879 RVA: 0x0003A9BC File Offset: 0x00038BBC
		public AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)105644033;
				if (num != 0)
				{
				}
				num = (short)860098642;
				short num2 = num;
				num = (short)1910181970;
				switch (num2 == num)
				{
				}
				num = (short)1199046656;
				short num3 = num;
				num = (short)1626210304;
				if (num != 0)
				{
				}
				return (AcpFieldBase)base.GetValue(AcpTextBoxSpinnerDecHex.MyBLObjectProperty);
			}
			set
			{
				short num = (short)996190601;
				short num2 = num;
				num = (short)2095294857;
				switch (num2 == num)
				{
				}
				num = (short)1035665409;
				if (num != 0)
				{
				}
				num = (short)1227161600;
				short num3 = num;
				num = (short)357433344;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinnerDecHex.MyBLObjectProperty, value);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0003AA74 File Offset: 0x00038C74
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0003AB30 File Offset: 0x00038D30
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)1773783424;
				short num2 = num;
				num = (short)349555072;
				switch (num2 == num)
				{
				}
				num = (short)1689518081;
				if (num != 0)
				{
				}
				num = (short)81068032;
				short num3 = num;
				num = (short)439156736;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinnerDecHex.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)838417943;
				short num2 = num;
				num = (short)1529429527;
				switch (num2 == num)
				{
				}
				num = (short)1608908800;
				if (num != 0)
				{
				}
				num = (short)1242365952;
				short num3 = num;
				num = (short)930742273;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinnerDecHex.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0003ABE8 File Offset: 0x00038DE8
		// (set) Token: 0x06000373 RID: 883 RVA: 0x0003ACA4 File Offset: 0x00038EA4
		public Expander MyExpander
		{
			get
			{
				short num = (short)1007399793;
				short num2 = num;
				num = (short)313176945;
				switch (num2 == num)
				{
				}
				num = (short)26476545;
				if (num != 0)
				{
				}
				num = (short)648151040;
				short num3 = num;
				num = (short)812843008;
				if (num != 0)
				{
				}
				return (Expander)base.GetValue(AcpTextBoxSpinnerDecHex.MyExpanderProperty);
			}
			set
			{
				short num = (short)674182015;
				short num2 = num;
				num = (short)468398975;
				switch (num2 == num)
				{
				}
				num = (short)909901825;
				if (num != 0)
				{
				}
				num = (short)76414976;
				short num3 = num;
				num = (short)1179779072;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinnerDecHex.MyExpanderProperty, value);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0003AD5C File Offset: 0x00038F5C
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0003AE18 File Offset: 0x00039018
		public IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)1490258182;
				short num2 = num;
				num = (short)2032240902;
				switch (num2 == num)
				{
				}
				num = (short)149356545;
				if (num != 0)
				{
				}
				num = (short)747569152;
				short num3 = num;
				num = (short)771489792;
				if (num != 0)
				{
				}
				return (IAcpUIParentCtrlBase)base.GetValue(AcpTextBoxSpinnerDecHex.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)1043848311;
				short num2 = num;
				num = (short)1240194167;
				switch (num2 == num)
				{
				}
				num = (short)1914568705;
				if (num != 0)
				{
				}
				num = (short)1449590784;
				short num3 = num;
				num = (short)14680064;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinnerDecHex.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0003AECC File Offset: 0x000390CC
		// (set) Token: 0x06000377 RID: 887 RVA: 0x0003AF84 File Offset: 0x00039184
		public string Text
		{
			get
			{
				short num = (short)1146552321;
				if (num != 0)
				{
				}
				num = (short)1604243596;
				short num2 = num;
				num = (short)689033356;
				switch (num2 == num)
				{
				}
				num = (short)147128320;
				short num3 = num;
				num = (short)1799553024;
				if (num != 0)
				{
				}
				return (string)base.GetValue(AcpTextBoxSpinnerDecHex.TextProperty);
			}
			set
			{
				short num = (short)1710448490;
				short num2 = num;
				num = (short)1987403626;
				switch (num2 == num)
				{
				}
				num = (short)1251540992;
				if (num != 0)
				{
				}
				num = (short)210501632;
				short num3 = num;
				num = (short)1493762049;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinnerDecHex.TextProperty, value);
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0003B038 File Offset: 0x00039238
		// (set) Token: 0x06000379 RID: 889 RVA: 0x0003B0F0 File Offset: 0x000392F0
		public string HexText
		{
			get
			{
				short num = (short)138595953;
				short num2 = num;
				num = (short)261672561;
				switch (num2 == num)
				{
				}
				num = (short)624885761;
				if (num != 0)
				{
				}
				num = (short)32505856;
				short num3 = num;
				num = (short)1805320192;
				if (num != 0)
				{
				}
				return (string)base.GetValue(AcpTextBoxSpinnerDecHex.HexTextProperty);
			}
			set
			{
				short num = (short)1664356255;
				short num2 = num;
				num = (short)1775636383;
				switch (num2 == num)
				{
				}
				num = (short)1156382721;
				if (num != 0)
				{
				}
				num = (short)742916096;
				short num3 = num;
				num = (short)1536098304;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinnerDecHex.HexTextProperty, value);
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0003B1A4 File Offset: 0x000393A4
		private void OnClick(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1996690279;
			short num2 = num;
			num = (short)1078530919;
			switch (num2 == num)
			{
			}
			num = (short)1072889857;
			if (num != 0)
			{
			}
			num = (short)1511260160;
			short num3 = num;
			num = (short)14352384;
			if (num != 0)
			{
			}
			StepUpDownUtility.a(A_0, this.MyBLObject);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0003B258 File Offset: 0x00039458
		private void OnKeyPressUpDownEvent(object A_0, KeyEventArgs A_1)
		{
			short num = (short)660287822;
			short num2 = num;
			num = (short)420753742;
			switch (num2 == num)
			{
			}
			num = (short)1366818816;
			if (num != 0)
			{
			}
			num = (short)1178337280;
			short num3 = num;
			num = (short)2110128129;
			if (num != 0)
			{
			}
			StepUpDownUtility.a(A_1, this.MyBLObject);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0003B30C File Offset: 0x0003950C
		public AcpTextBoxSpinnerDecHex()
		{
			this.InitializeComponent();
			base.Focusable = true;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0003B32C File Offset: 0x0003952C
		protected override void OnGotFocus(RoutedEventArgs e)
		{
			short num = (short)1955777543;
			short num2 = num;
			num = (short)556518407;
			switch (num2 == num)
			{
			}
			num = (short)1699938305;
			if (num != 0)
			{
			}
			num = (short)581500928;
			short num3 = num;
			num = (short)781385728;
			if (num != 0)
			{
			}
			this.a.Focus();
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0003B3E0 File Offset: 0x000395E0
		AcpTextBox ISupportsTextBoxMember.TextBoxMember
		{
			get
			{
				short num = (short)632000967;
				short num2 = num;
				num = (short)462262727;
				switch (num2 == num)
				{
				}
				num = (short)1847721985;
				if (num != 0)
				{
				}
				num = (short)2129330176;
				short num3 = num;
				num = (short)1118044160;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0003B56C File Offset: 0x0003976C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		internal Delegate a(Type A_0, string A_1)
		{
			short num = (short)907292715;
			short num2 = num;
			num = (short)789065771;
			switch (num2 == num)
			{
			}
			num = (short)1564672000;
			if (num != 0)
			{
			}
			num = (short)1853489152;
			short num3 = num;
			num = (short)694747137;
			if (num != 0)
			{
			}
			return Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0003B7A8 File Offset: 0x000399A8
		// Note: this type is marked as 'beforefieldinit'.
		static AcpTextBoxSpinnerDecHex()
		{
			int a_ = 15;
			short num = (short)1674838852;
			short num2 = num;
			num = (short)1390281540;
			switch (num2 == num)
			{
			}
			num = (short)561250305;
			if (num != 0)
			{
			}
			num = (short)1082851328;
			short num3 = num;
			num = (short)1645346816;
			if (num != 0)
			{
			}
			AcpTextBoxSpinnerDecHex.IsAcpValidProperty = DependencyProperty.Register(Utility.c("풦좪\uddac瑩킰\udfb2\udcb4펶", a_), typeof(bool), typeof(AcpTextBoxSpinnerDecHex), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinnerDecHex.IsAcpApplicableProperty = DependencyProperty.Register(Utility.c("풦좪\uddac솰쎲\ud9b4\udeb6\udab8\udaba\udfbc펾꓀", a_), typeof(bool), typeof(AcpTextBoxSpinnerDecHex), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinnerDecHex.IsAcpEditableProperty = DependencyProperty.Register(Utility.c("풦좪\uddac햰\udab2솴횶\udbb8ힺ\ud8bc", a_), typeof(bool), typeof(AcpTextBoxSpinnerDecHex), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinnerDecHex.IsAcpVisibleProperty = DependencyProperty.Register(Utility.c("풦좪\uddac瑩\ud8b0삲\udcb4햶햸\udeba", a_), typeof(bool), typeof(AcpTextBoxSpinnerDecHex), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinnerDecHex.MyLabelCtrlProperty = DependencyProperty.RegisterAttached(Utility.c("\udea6쪪쾬쪮\uddb0솴얶햸", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpTextBoxSpinnerDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinnerDecHex.MyCopyButtonProperty = DependencyProperty.RegisterAttached(Utility.c("\udea6쒪\uddac횮욲솴쎶횸햺ﺼ쮾돀꿂", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpTextBoxSpinnerDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinnerDecHex.MyBLObjectProperty = DependencyProperty.RegisterAttached(Utility.c("\udea6춮\udbb0횲횴쎶", a_), typeof(AcpFieldBase), typeof(AcpTextBoxSpinnerDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinnerDecHex.AreValuesEqualProperty = DependencyProperty.Register(Utility.c("햦첨ﶪ첬쎮쒰횲운좸캺\udcbc펾", a_), typeof(bool), typeof(AcpTextBoxSpinnerDecHex), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinnerDecHex.MyExpanderProperty = DependencyProperty.RegisterAttached(Utility.c("\udea6펪\uddac캮\udfb0ힲ킴얶", a_), typeof(Expander), typeof(AcpTextBoxSpinnerDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinnerDecHex.MyParentCtrlProperty = DependencyProperty.RegisterAttached(Utility.c("\udea6令쪪\udfac쪮\udfb0잲쎶쮸ힺ", a_), typeof(IAcpUIParentCtrlBase), typeof(AcpTextBoxSpinnerDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinnerDecHex.TextProperty = DependencyProperty.Register(Utility.c("슦톨\udfaa", a_), typeof(string), typeof(AcpTextBoxSpinnerDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinnerDecHex.HexTextProperty = DependencyProperty.Register(Utility.c("슦톨ﾪ좬힮얰", a_), typeof(string), typeof(AcpTextBoxSpinnerDecHex), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		}

		// Token: 0x04000211 RID: 529
		public static readonly DependencyProperty IsAcpValidProperty;

		// Token: 0x04000212 RID: 530
		public static readonly DependencyProperty IsAcpApplicableProperty;

		// Token: 0x04000213 RID: 531
		public static readonly DependencyProperty IsAcpEditableProperty;

		// Token: 0x04000214 RID: 532
		public static readonly DependencyProperty IsAcpVisibleProperty;

		// Token: 0x04000215 RID: 533
		public static readonly DependencyProperty MyLabelCtrlProperty;

		// Token: 0x04000216 RID: 534
		public static readonly DependencyProperty MyCopyButtonProperty;

		// Token: 0x04000217 RID: 535
		public static readonly DependencyProperty MyBLObjectProperty;

		// Token: 0x04000218 RID: 536
		public static readonly DependencyProperty AreValuesEqualProperty;

		// Token: 0x04000219 RID: 537
		public static readonly DependencyProperty MyExpanderProperty;

		// Token: 0x0400021A RID: 538
		public static readonly DependencyProperty MyParentCtrlProperty;

		// Token: 0x0400021B RID: 539
		public static readonly DependencyProperty TextProperty;

		// Token: 0x0400021C RID: 540
		public static readonly DependencyProperty HexTextProperty;
	}
}
