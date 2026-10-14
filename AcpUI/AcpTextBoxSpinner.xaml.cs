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
	// Token: 0x02000036 RID: 54
	public partial class AcpTextBoxSpinner : UserControl, IAcpUICtrlBase, IAcpUIValueCtrlBase<string>, IAcpUIParentCtrlBase, IAcpUIChildCtrlBase, IAcpUICommon, ISupportsTextBoxMember
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600033B RID: 827 RVA: 0x000381C0 File Offset: 0x000363C0
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00038270 File Offset: 0x00036470
		public string Value
		{
			get
			{
				short num = (short)646884477;
				short num2 = num;
				num = (short)454405245;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2121007104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330760192;
				if (num != 0)
				{
				}
				num = (short)1631911937;
				if (num != 0)
				{
				}
				return this.Text;
			}
			set
			{
				short num = (short)1234065506;
				short num2 = num;
				num = (short)1113217122;
				switch (num2 == num)
				{
				}
				num = (short)426311680;
				if (num != 0)
				{
				}
				num = (short)354156544;
				short num3 = num;
				num = (short)2082603009;
				if (num != 0)
				{
				}
				this.Text = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00038320 File Offset: 0x00036520
		// (set) Token: 0x0600033E RID: 830 RVA: 0x000383D8 File Offset: 0x000365D8
		public bool IsAcpValid
		{
			get
			{
				short num = (short)1008714951;
				short num2 = num;
				num = (short)900973767;
				switch (num2 == num)
				{
				}
				num = (short)1453588480;
				if (num != 0)
				{
				}
				num = (short)680656896;
				short num3 = num;
				num = (short)278265857;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinner.IsAcpValidProperty);
			}
			set
			{
				short num = (short)1761083393;
				if (num != 0)
				{
				}
				num = (short)1121034103;
				short num2 = num;
				num = (short)19111799;
				switch (num2 == num)
				{
				}
				num = (short)905117696;
				short num3 = num;
				num = (short)450035712;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner.IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00038494 File Offset: 0x00036694
		// (set) Token: 0x06000340 RID: 832 RVA: 0x0003854C File Offset: 0x0003674C
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)80871425;
				if (num != 0)
				{
				}
				num = (short)753109609;
				short num2 = num;
				num = (short)544967273;
				switch (num2 == num)
				{
				}
				num = (short)1251868672;
				short num3 = num;
				num = (short)839843840;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinner.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)989550479;
				short num2 = num;
				num = (short)2033080207;
				switch (num2 == num)
				{
				}
				num = (short)1225719809;
				if (num != 0)
				{
				}
				num = (short)662437888;
				short num3 = num;
				num = (short)1749876736;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00038608 File Offset: 0x00036808
		// (set) Token: 0x06000342 RID: 834 RVA: 0x000386C4 File Offset: 0x000368C4
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)760017943;
				short num2 = num;
				num = (short)361821207;
				switch (num2 == num)
				{
				}
				num = (short)25821185;
				if (num != 0)
				{
				}
				num = (short)597950464;
				short num3 = num;
				num = (short)31129600;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinner.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)15656416;
				short num2 = num;
				num = (short)2018895328;
				switch (num2 == num)
				{
				}
				num = (short)2142437376;
				if (num != 0)
				{
				}
				num = (short)637009920;
				short num3 = num;
				num = (short)1519517697;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00038780 File Offset: 0x00036980
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00038838 File Offset: 0x00036A38
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)1115701473;
				short num2 = num;
				num = (short)1188184289;
				switch (num2 == num)
				{
				}
				num = (short)942276609;
				if (num != 0)
				{
				}
				num = (short)1549336576;
				short num3 = num;
				num = (short)1119027200;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinner.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2084265838;
				short num2 = num;
				num = (short)2113625966;
				switch (num2 == num)
				{
				}
				num = (short)299171841;
				if (num != 0)
				{
				}
				num = (short)1276051456;
				short num3 = num;
				num = (short)1017511936;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000345 RID: 837 RVA: 0x000388F0 File Offset: 0x00036AF0
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000389AC File Offset: 0x00036BAC
		public IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)1161857862;
				short num2 = num;
				num = (short)1473678150;
				switch (num2 == num)
				{
				}
				num = (short)799473665;
				if (num != 0)
				{
				}
				num = (short)1398865920;
				short num3 = num;
				num = (short)783745024;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpTextBoxSpinner.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)1517092865;
				if (num != 0)
				{
				}
				num = (short)11081377;
				short num2 = num;
				num = (short)1749685921;
				switch (num2 == num)
				{
				}
				num = (short)993067008;
				short num3 = num;
				num = (short)1239089152;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00038A64 File Offset: 0x00036C64
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00038B20 File Offset: 0x00036D20
		public IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)2136248706;
				short num2 = num;
				num = (short)924094850;
				switch (num2 == num)
				{
				}
				num = (short)1669136385;
				if (num != 0)
				{
				}
				num = (short)753205248;
				short num3 = num;
				num = (short)1627455488;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpTextBoxSpinner.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)1006326761;
				short num2 = num;
				num = (short)2099729385;
				switch (num2 == num)
				{
				}
				num = (short)475856896;
				if (num != 0)
				{
				}
				num = (short)1557528576;
				short num3 = num;
				num = (short)1114439681;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00038BD8 File Offset: 0x00036DD8
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00038C94 File Offset: 0x00036E94
		public AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)1917255681;
				if (num != 0)
				{
				}
				num = (short)1766093084;
				short num2 = num;
				num = (short)582381852;
				switch (num2 == num)
				{
				}
				num = (short)1907884032;
				short num3 = num;
				num = (short)1847853056;
				if (num != 0)
				{
				}
				return (AcpFieldBase)base.GetValue(AcpTextBoxSpinner.MyBLObjectProperty);
			}
			set
			{
				short num = (short)1173684225;
				if (num != 0)
				{
				}
				num = (short)1521562901;
				short num2 = num;
				num = (short)1932801301;
				switch (num2 == num)
				{
				}
				num = (short)59965440;
				short num3 = num;
				num = (short)626327552;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner.MyBLObjectProperty, value);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00038D4C File Offset: 0x00036F4C
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00038E04 File Offset: 0x00037004
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)1166396275;
				short num2 = num;
				num = (short)1741146995;
				switch (num2 == num)
				{
				}
				num = (short)588382209;
				if (num != 0)
				{
				}
				num = (short)1150025728;
				short num3 = num;
				num = (short)1983709184;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxSpinner.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)1770841440;
				short num2 = num;
				num = (short)2053694816;
				switch (num2 == num)
				{
				}
				num = (short)896466944;
				if (num != 0)
				{
				}
				num = (short)649003008;
				short num3 = num;
				num = (short)788660225;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00038EBC File Offset: 0x000370BC
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00038F78 File Offset: 0x00037178
		public Expander MyExpander
		{
			get
			{
				short num = (short)307841790;
				short num2 = num;
				num = (short)856050430;
				switch (num2 == num)
				{
				}
				num = (short)269615105;
				if (num != 0)
				{
				}
				num = (short)2052718592;
				short num3 = num;
				num = (short)2143289344;
				if (num != 0)
				{
				}
				return (Expander)base.GetValue(AcpTextBoxSpinner.MyExpanderProperty);
			}
			set
			{
				short num = (short)1069100547;
				short num2 = num;
				num = (short)623259139;
				switch (num2 == num)
				{
				}
				num = (short)1952120833;
				if (num != 0)
				{
				}
				num = (short)1248591872;
				short num3 = num;
				num = (short)1717829632;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner.MyExpanderProperty, value);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00039030 File Offset: 0x00037230
		// (set) Token: 0x06000350 RID: 848 RVA: 0x000390E8 File Offset: 0x000372E8
		public IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)2131795447;
				short num2 = num;
				num = (short)2059312631;
				switch (num2 == num)
				{
				}
				num = (short)504561664;
				if (num != 0)
				{
				}
				num = (short)1969094656;
				short num3 = num;
				num = (short)250806273;
				if (num != 0)
				{
				}
				return (IAcpUIParentCtrlBase)base.GetValue(AcpTextBoxSpinner.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)46102782;
				short num2 = num;
				num = (short)66681086;
				switch (num2 == num)
				{
				}
				num = (short)167444481;
				if (num != 0)
				{
				}
				num = (short)191168512;
				short num3 = num;
				num = (short)1961558016;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0003919C File Offset: 0x0003739C
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00039254 File Offset: 0x00037454
		public string Text
		{
			get
			{
				short num = (short)534237020;
				short num2 = num;
				num = (short)1030868828;
				switch (num2 == num)
				{
				}
				num = (short)789708801;
				if (num != 0)
				{
				}
				num = (short)310902784;
				short num3 = num;
				num = (short)1853161472;
				if (num != 0)
				{
				}
				return (string)base.GetValue(AcpTextBoxSpinner.TextProperty);
			}
			set
			{
				short num = (short)1753081936;
				short num2 = num;
				num = (short)13363280;
				switch (num2 == num)
				{
				}
				num = (short)1044447233;
				if (num != 0)
				{
				}
				num = (short)836239360;
				short num3 = num;
				num = (short)1418199040;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxSpinner.TextProperty, value);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00039308 File Offset: 0x00037508
		// (set) Token: 0x06000354 RID: 852 RVA: 0x000393C4 File Offset: 0x000375C4
		public string MaskTypeSpinner
		{
			get
			{
				short num;
				while (AcpTextBox.DisableMask)
				{
					num = (short)1481035499;
					short num2 = num;
					num = (short)622251755;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)820445184;
						if (num != 0)
						{
						}
						return null;
					}
				}
				num = (short)1924136960;
				short num3 = num;
				num = (short)402391041;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)2016608257;
				if (num != 0)
				{
				}
				num = (short)991832830;
				short num2 = num;
				num = (short)555363070;
				switch (num2 == num)
				{
				}
				num = (short)1121779712;
				short num3 = num;
				num = (short)1511915520;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00039478 File Offset: 0x00037678
		private void OnClick(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1529610241;
			if (num != 0)
			{
			}
			num = (short)92637469;
			short num2 = num;
			num = (short)1999800605;
			switch (num2 == num)
			{
			}
			num = (short)663486464;
			short num3 = num;
			num = (short)1507917824;
			if (num != 0)
			{
			}
			StepUpDownUtility.a(A_0, this.MyBLObject);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0003952C File Offset: 0x0003772C
		private void OnLostFocus(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1351541879;
			short num2 = num;
			num = (short)2140988535;
			switch (num2 == num)
			{
			}
			num = (short)887029760;
			if (num != 0)
			{
			}
			num = (short)2061828096;
			short num3 = num;
			num = (short)1320091649;
			if (num != 0)
			{
			}
			this.Text = this.b.Text;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000395E8 File Offset: 0x000377E8
		private void OnKeyPressUpDownEvent(object A_0, KeyEventArgs A_1)
		{
			short num = (short)1084084856;
			short num2 = num;
			num = (short)1343410808;
			switch (num2 == num)
			{
			}
			num = (short)1148387329;
			if (num != 0)
			{
			}
			num = (short)1913978880;
			short num3 = num;
			num = (short)1396375552;
			if (num != 0)
			{
			}
			StepUpDownUtility.a(A_1, this.MyBLObject);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0003969C File Offset: 0x0003789C
		private void AcpTextBoxSpinner_GotFocus(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1003229075;
			short num2 = num;
			num = (short)136253331;
			switch (num2 == num)
			{
			}
			num = (short)298713089;
			if (num != 0)
			{
			}
			num = (short)1945174016;
			short num3 = num;
			num = (short)750387200;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00039748 File Offset: 0x00037948
		protected override void OnGotFocus(RoutedEventArgs e)
		{
			short num = (short)39097191;
			short num2 = num;
			num = (short)1802670951;
			switch (num2 == num)
			{
			}
			num = (short)49152001;
			if (num != 0)
			{
			}
			num = (short)449970176;
			short num3 = num;
			num = (short)675282944;
			if (num != 0)
			{
			}
			this.b.Focus();
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000397FC File Offset: 0x000379FC
		public AcpTextBoxSpinner()
		{
			this.InitializeComponent();
			base.Focusable = true;
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0003981C File Offset: 0x00037A1C
		AcpTextBox ISupportsTextBoxMember.TextBoxMember
		{
			get
			{
				short num = (short)371063166;
				short num2 = num;
				num = (short)591460734;
				switch (num2 == num)
				{
				}
				num = (short)1785659392;
				if (num != 0)
				{
				}
				num = (short)1625227264;
				short num3 = num;
				num = (short)333643777;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000399B4 File Offset: 0x00037BB4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		internal Delegate a(Type A_0, string A_1)
		{
			short num = (short)1100964182;
			short num2 = num;
			num = (short)762732886;
			switch (num2 == num)
			{
			}
			num = (short)689111040;
			if (num != 0)
			{
			}
			num = (short)1947664384;
			short num3 = num;
			num = (short)464781313;
			if (num != 0)
			{
			}
			return Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00039BE0 File Offset: 0x00037DE0
		// Note: this type is marked as 'beforefieldinit'.
		static AcpTextBoxSpinner()
		{
			int a_ = 8;
			short num = (short)210071000;
			short num2 = num;
			num = (short)477785560;
			switch (num2 == num)
			{
			}
			num = (short)2043674624;
			if (num != 0)
			{
			}
			num = (short)196542464;
			short num3 = num;
			num = (short)265093121;
			if (num != 0)
			{
			}
			AcpTextBoxSpinner.IsAcpValidProperty = DependencyProperty.Register(Utility.c("힝펟잣횥ﺧ쮩삫잭풯", a_), typeof(bool), typeof(AcpTextBoxSpinner), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinner.IsAcpApplicableProperty = DependencyProperty.Register(Utility.c("힝펟잣횥\udaa9\udcab슭\ud9af톱햳풵풷\udfb9", a_), typeof(bool), typeof(AcpTextBoxSpinner), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinner.IsAcpEditableProperty = DependencyProperty.Register(Utility.c("힝펟잣횥캩얫\udaad톯킱\ud8b3펵", a_), typeof(bool), typeof(AcpTextBoxSpinner), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinner.IsAcpVisibleProperty = DependencyProperty.Register(Utility.c("힝펟잣횥ﺧ쎩\udfab잭튯\udeb1톳", a_), typeof(bool), typeof(AcpTextBoxSpinner), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxSpinner.MyLabelCtrlProperty = DependencyProperty.RegisterAttached(Utility.c("펝\ud99f얣쒥춧용\udaad슯\udeb1", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpTextBoxSpinner), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinner.MyCopyButtonProperty = DependencyProperty.RegisterAttached(Utility.c("펝\ud99f쮣횥톧\ud9ab\udaad쒯\uddb1\udab3첷좹킻", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpTextBoxSpinner), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinner.MyBLObjectProperty = DependencyProperty.RegisterAttached(Utility.c("펝\ud99f쪧삩즫춭쒯", a_), typeof(AcpFieldBase), typeof(AcpTextBoxSpinner), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinner.AreValuesEqualProperty = DependencyProperty.Register(Utility.c("\udf9d튟잡장쒧\udfa9즫\uddad쎱솳ힵ풷", a_), typeof(bool), typeof(AcpTextBoxSpinner), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinner.MyExpanderProperty = DependencyProperty.RegisterAttached(Utility.c("펝\ud99f\udca3횥즧쒩좫쮭슯", a_), typeof(Expander), typeof(AcpTextBoxSpinner), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinner.MyParentCtrlProperty = DependencyProperty.RegisterAttached(Utility.c("펝\ud99f얣풥춧쒩\ud8ab쒯삱\ud8b3", a_), typeof(IAcpUIParentCtrlBase), typeof(AcpTextBoxSpinner), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxSpinner.TextProperty = DependencyProperty.Register(Utility.c("쪝얟\udaa1킣", a_), typeof(string), typeof(AcpTextBoxSpinner), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		}

		// Token: 0x04000201 RID: 513
		public static readonly DependencyProperty IsAcpValidProperty;

		// Token: 0x04000202 RID: 514
		public static readonly DependencyProperty IsAcpApplicableProperty;

		// Token: 0x04000203 RID: 515
		public static readonly DependencyProperty IsAcpEditableProperty;

		// Token: 0x04000204 RID: 516
		public static readonly DependencyProperty IsAcpVisibleProperty;

		// Token: 0x04000205 RID: 517
		public static readonly DependencyProperty MyLabelCtrlProperty;

		// Token: 0x04000206 RID: 518
		public static readonly DependencyProperty MyCopyButtonProperty;

		// Token: 0x04000207 RID: 519
		public static readonly DependencyProperty MyBLObjectProperty;

		// Token: 0x04000208 RID: 520
		public static readonly DependencyProperty AreValuesEqualProperty;

		// Token: 0x04000209 RID: 521
		public static readonly DependencyProperty MyExpanderProperty;

		// Token: 0x0400020A RID: 522
		public static readonly DependencyProperty MyParentCtrlProperty;

		// Token: 0x0400020B RID: 523
		public static readonly DependencyProperty TextProperty;

		// Token: 0x0400020C RID: 524
		private string a;
	}
}
