using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpBusinessLayer;
using AcpUI;
using AcpUILib;

namespace AcpUITTS
{
	// Token: 0x02000004 RID: 4
	public partial class AcpTTSTextBox : UserControl, IAcpUICtrlBase, IAcpUIValueCtrlBase<string>, IAcpUIParentCtrlBase, IAcpUIChildCtrlBase, IAcpUICommon
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000031E0 File Offset: 0x000013E0
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00003290 File Offset: 0x00001490
		public string Value
		{
			get
			{
				short num = (short)491139060;
				short num2 = num;
				num = (short)1699885044;
				switch (num2 == num)
				{
				}
				num = (short)2021654528;
				short num3 = num;
				num = (short)1050542081;
				if (num != 0)
				{
				}
				num = (short)1541275648;
				if (num != 0)
				{
				}
				return this.Text;
			}
			set
			{
				short num = (short)1421582664;
				short num2 = num;
				num = (short)501326152;
				switch (num2 == num)
				{
				}
				num = (short)429260800;
				short num3 = num;
				num = (short)39976961;
				if (num != 0)
				{
				}
				num = (short)2116878336;
				if (num != 0)
				{
				}
				this.Text = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003340 File Offset: 0x00001540
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000033FC File Offset: 0x000015FC
		public bool IsAcpValid
		{
			get
			{
				short num = (short)742726167;
				short num2 = num;
				num = (short)1311578647;
				switch (num2 == num)
				{
				}
				num = (short)1843724288;
				short num3 = num;
				num = (short)2028208129;
				if (num != 0)
				{
				}
				num = (short)541786112;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTTSTextBox.IsAcpValidProperty);
			}
			set
			{
				short num = (short)1026428260;
				short num2 = num;
				num = (short)170593636;
				switch (num2 == num)
				{
				}
				num = (short)1537146880;
				short num3 = num;
				num = (short)1863647232;
				if (num != 0)
				{
				}
				num = (short)1258160129;
				if (num != 0)
				{
				}
				base.SetValue(AcpTTSTextBox.IsAcpValidProperty, value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000034B8 File Offset: 0x000016B8
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00003574 File Offset: 0x00001774
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)1158583022;
				short num2 = num;
				num = (short)1604817646;
				switch (num2 == num)
				{
				}
				num = (short)882638848;
				short num3 = num;
				num = (short)5701633;
				if (num != 0)
				{
				}
				num = (short)1692794880;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTTSTextBox.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)600400959;
				short num2 = num;
				num = (short)853959743;
				switch (num2 == num)
				{
				}
				num = (short)1796407296;
				short num3 = num;
				num = (short)1485570048;
				if (num != 0)
				{
				}
				num = (short)936443905;
				if (num != 0)
				{
				}
				base.SetValue(AcpTTSTextBox.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000362C File Offset: 0x0000182C
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000036E8 File Offset: 0x000018E8
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)1980318719;
				short num2 = num;
				num = (short)1039483903;
				switch (num2 == num)
				{
				}
				num = (short)1674248192;
				short num3 = num;
				num = (short)1677328384;
				if (num != 0)
				{
				}
				num = (short)505020417;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTTSTextBox.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)233853686;
				short num2 = num;
				num = (short)690967286;
				switch (num2 == num)
				{
				}
				num = (short)1760755712;
				short num3 = num;
				num = (short)641073153;
				if (num != 0)
				{
				}
				num = (short)1532821504;
				if (num != 0)
				{
				}
				base.SetValue(AcpTTSTextBox.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000037A4 File Offset: 0x000019A4
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00003860 File Offset: 0x00001A60
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)1501395974;
				short num2 = num;
				num = (short)766999558;
				switch (num2 == num)
				{
				}
				num = (short)1519321088;
				short num3 = num;
				num = (short)1855586305;
				if (num != 0)
				{
				}
				num = (short)555286528;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTTSTextBox.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1858469889;
				if (num != 0)
				{
				}
				num = (short)1916388610;
				short num2 = num;
				num = (short)1311491330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)904265728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1258160128;
				if (num != 0)
				{
				}
				base.SetValue(AcpTTSTextBox.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003918 File Offset: 0x00001B18
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000039D4 File Offset: 0x00001BD4
		public IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)1775904695;
				short num2 = num;
				num = (short)588392375;
				switch (num2 == num)
				{
				}
				num = (short)956563456;
				short num3 = num;
				num = (short)1197342720;
				if (num != 0)
				{
				}
				num = (short)693895169;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpTTSTextBox.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)1877655872;
				short num2 = num;
				num = (short)924434752;
				switch (num2 == num)
				{
				}
				num = (short)40042496;
				short num3 = num;
				num = (short)1006043137;
				if (num != 0)
				{
				}
				num = (short)1781202944;
				if (num != 0)
				{
				}
				base.SetValue(AcpTTSTextBox.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003A88 File Offset: 0x00001C88
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00003B44 File Offset: 0x00001D44
		public IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)681653028;
				short num2 = num;
				num = (short)1704407844;
				switch (num2 == num)
				{
				}
				num = (short)1209073664;
				short num3 = num;
				num = (short)1512701953;
				if (num != 0)
				{
				}
				num = (short)556597248;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpTTSTextBox.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)1466423293;
				short num2 = num;
				num = (short)63690749;
				switch (num2 == num)
				{
				}
				num = (short)1936195584;
				short num3 = num;
				num = (short)73465856;
				if (num != 0)
				{
				}
				num = (short)1315241985;
				if (num != 0)
				{
				}
				base.SetValue(AcpTTSTextBox.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003BF8 File Offset: 0x00001DF8
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00003CB0 File Offset: 0x00001EB0
		public AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)2095708663;
				short num2 = num;
				num = (short)1637939703;
				switch (num2 == num)
				{
				}
				num = (short)818282496;
				short num3 = num;
				num = (short)2070020096;
				if (num != 0)
				{
				}
				num = (short)903610369;
				if (num != 0)
				{
				}
				return (AcpFieldBase)base.GetValue(AcpTTSTextBox.MyBLObjectProperty);
			}
			set
			{
				short num = (short)1847638288;
				short num2 = num;
				num = (short)490125584;
				switch (num2 == num)
				{
				}
				num = (short)565837824;
				short num3 = num;
				num = (short)651427841;
				if (num != 0)
				{
				}
				num = (short)11599872;
				if (num != 0)
				{
				}
				base.SetValue(AcpTTSTextBox.MyBLObjectProperty, value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003D64 File Offset: 0x00001F64
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00003E20 File Offset: 0x00002020
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)2104754177;
				if (num != 0)
				{
				}
				num = (short)731634983;
				short num2 = num;
				num = (short)14212391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)304807936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1024065536;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTTSTextBox.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)880906352;
				short num2 = num;
				num = (short)1650102384;
				switch (num2 == num)
				{
				}
				num = (short)2127233024;
				short num3 = num;
				num = (short)946601985;
				if (num != 0)
				{
				}
				num = (short)1606877184;
				if (num != 0)
				{
				}
				base.SetValue(AcpTTSTextBox.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003ED8 File Offset: 0x000020D8
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00003F94 File Offset: 0x00002194
		public Expander MyExpander
		{
			get
			{
				short num = (short)1949106177;
				if (num != 0)
				{
				}
				num = (short)2070979639;
				short num2 = num;
				num = (short)2123408439;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521352704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)255393792;
				if (num != 0)
				{
				}
				return (Expander)base.GetValue(AcpTTSTextBox.MyExpanderProperty);
			}
			set
			{
				short num = (short)556684169;
				short num2 = num;
				num = (short)997151625;
				switch (num2 == num)
				{
				}
				num = (short)1966211072;
				short num3 = num;
				num = (short)208338945;
				if (num != 0)
				{
				}
				num = (short)602537984;
				if (num != 0)
				{
				}
				base.SetValue(AcpTTSTextBox.MyExpanderProperty, value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00004048 File Offset: 0x00002248
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00004100 File Offset: 0x00002300
		public IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)1437794305;
				if (num != 0)
				{
				}
				num = (short)200223950;
				short num2 = num;
				num = (short)1206201550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1639055360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1007812608;
				if (num != 0)
				{
				}
				return (IAcpUIParentCtrlBase)base.GetValue(AcpTTSTextBox.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)888077175;
				short num2 = num;
				num = (short)871496567;
				switch (num2 == num)
				{
				}
				num = (short)1620377600;
				short num3 = num;
				num = (short)48824320;
				if (num != 0)
				{
				}
				num = (short)1309540353;
				if (num != 0)
				{
				}
				base.SetValue(AcpTTSTextBox.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000041B4 File Offset: 0x000023B4
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000426C File Offset: 0x0000246C
		public string Text
		{
			get
			{
				short num = (short)1202019566;
				short num2 = num;
				num = (short)368663790;
				switch (num2 == num)
				{
				}
				num = (short)1580138496;
				short num3 = num;
				num = (short)2359297;
				if (num != 0)
				{
				}
				num = (short)1583611904;
				if (num != 0)
				{
				}
				return (string)base.GetValue(AcpTTSTextBox.TextProperty);
			}
			set
			{
				short num = (short)2122491208;
				short num2 = num;
				num = (short)460432712;
				switch (num2 == num)
				{
				}
				num = (short)1886060544;
				short num3 = num;
				num = (short)2076311552;
				if (num != 0)
				{
				}
				num = (short)247463937;
				if (num != 0)
				{
				}
				base.SetValue(AcpTTSTextBox.TextProperty, value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00004324 File Offset: 0x00002524
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000043E0 File Offset: 0x000025E0
		public int MaxLengthTts
		{
			get
			{
				short num = (short)638472225;
				short num2 = num;
				num = (short)18239521;
				switch (num2 == num)
				{
				}
				num = (short)268828672;
				short num3 = num;
				num = (short)1148518400;
				if (num != 0)
				{
				}
				num = (short)1137180673;
				if (num != 0)
				{
				}
				return (int)base.GetValue(AcpTTSTextBox.MaxLengthTtsProperty);
			}
			set
			{
				short num = (short)486037364;
				short num2 = num;
				num = (short)764041076;
				switch (num2 == num)
				{
				}
				num = (short)880410624;
				short num3 = num;
				num = (short)579403777;
				if (num != 0)
				{
				}
				num = (short)2138963968;
				if (num != 0)
				{
				}
				base.SetValue(AcpTTSTextBox.MaxLengthTtsProperty, value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00004498 File Offset: 0x00002698
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00004550 File Offset: 0x00002750
		public string TargetSpeaker
		{
			get
			{
				short num = (short)1884792449;
				short num2 = num;
				num = (short)1856939649;
				switch (num2 == num)
				{
				}
				num = (short)129171456;
				short num3 = num;
				num = (short)926482433;
				if (num != 0)
				{
				}
				num = (short)925433856;
				if (num != 0)
				{
				}
				return (string)base.GetValue(AcpTTSTextBox.TargetSpeakerProperty);
			}
			set
			{
				short num = (short)193904699;
				short num2 = num;
				num = (short)372752443;
				switch (num2 == num)
				{
				}
				num = (short)1599733760;
				short num3 = num;
				num = (short)1564016641;
				if (num != 0)
				{
				}
				num = (short)1416298496;
				if (num != 0)
				{
				}
				base.SetValue(AcpTTSTextBox.TargetSpeakerProperty, value);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004608 File Offset: 0x00002808
		internal void OnTTSButtonclick(object A_0, RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			short num;
			int num3;
			ACPTTSVoiceAnnouncement acpttsvoiceAnnouncement;
			AcpTTSButton acpTTSButton;
			for (;;)
			{
				IL_0A:
				num = (short)357629952;
				short num2 = num;
				num = (short)286654465;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					acpttsvoiceAnnouncement.Play(acpTTSButton.Speaker, acpTTSButton.TTS);
					num = (short)53936129;
					num3 = (int)((IntPtr)num);
					continue;
				case 1:
					goto IL_E1;
				case 2:
					if (!string.IsNullOrEmpty(acpTTSButton.TTS))
					{
						num = (short)1007288320;
						num3 = (int)((IntPtr)num);
						continue;
					}
					goto IL_E3;
				}
				goto IL_6A;
			}
			IL_E1:
			IL_E3:
			num = (short)1223179304;
			short num4 = num;
			num = (short)321928232;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_E1;
			default:
				num = (short)109707264;
				if (num != 0)
				{
				}
				return;
			}
			IL_6A:
			acpTTSButton = (AcpTTSButton)A_0;
			acpttsvoiceAnnouncement = new ACPTTSVoiceAnnouncement();
			num = (short)1109131266;
			num3 = (int)((IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004744 File Offset: 0x00002944
		internal void AcpTTSButton_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1992049906;
			short num2 = num;
			num = (short)1543390450;
			switch (num2 == num)
			{
			}
			num = (short)1713700864;
			short num3 = num;
			num = (short)109510657;
			if (num != 0)
			{
			}
			num = (short)679477248;
			if (num != 0)
			{
			}
			this.OnTTSButtonclick(A_0, A_1);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000047F4 File Offset: 0x000029F4
		public AcpTTSTextBox()
		{
			this.InitializeComponent();
			base.Loaded += this.AcpTTSButton_Loaded;
			base.Unloaded += this.AcpTTSButton_Unloaded;
			this.a();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004838 File Offset: 0x00002A38
		private void AcpTTSButton_Loaded(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)563126510;
			short num2 = num;
			num = (short)982622446;
			switch (num2 == num)
			{
			}
			num = (short)1056047104;
			short num3 = num;
			num = (short)638255105;
			if (num != 0)
			{
			}
			num = (short)490602496;
			if (num != 0)
			{
			}
			this.b.Click += this.AcpTTSButton_Click;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000048F8 File Offset: 0x00002AF8
		private void AcpTTSButton_Unloaded(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1458110465;
			if (num != 0)
			{
			}
			num = (short)2135937491;
			short num2 = num;
			num = (short)258068947;
			switch (num2 == num)
			{
			default:
			{
				num = (short)448593920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)249561088;
			if (num != 0)
			{
			}
			this.b.Click -= this.AcpTTSButton_Click;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000049B4 File Offset: 0x00002BB4
		private void AcpTextBoxMember_TextChanged(object A_0, TextChangedEventArgs A_1)
		{
			short num = (short)1594054701;
			short num2 = num;
			num = (short)1323587629;
			switch (num2 == num)
			{
			}
			num = (short)416940032;
			short num3 = num;
			num = (short)110166017;
			if (num != 0)
			{
			}
			num = (short)1832386560;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004A64 File Offset: 0x00002C64
		private void a()
		{
			short num = (short)560529411;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				string value;
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)928907264;
					short num3 = num;
					num = (short)1247344679;
					short num4 = num;
					num = (short)1911617575;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1934688256;
						if (num != 0)
						{
						}
						break;
					}
					this.b.Visibility = Visibility.Collapsed;
					num = (short)1794703360;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 2:
					value = null;
					goto IL_83;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				}
				IL_36:
				string text = this.a.Text;
				if (text == null)
				{
					num = (short)1418002434;
					num2 = (int)((IntPtr)num);
					continue;
				}
				value = text.Trim();
				IL_83:
				if (!string.IsNullOrEmpty(value))
				{
					goto IL_127;
				}
				num = (short)1423704065;
				num2 = (int)((IntPtr)num);
			}
			return;
			IL_127:
			num = (short)938737665;
			if (num != 0)
			{
			}
			this.b.Visibility = Visibility.Visible;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004CAC File Offset: 0x00002EAC
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		internal Delegate a(Type A_0, string A_1)
		{
			short num = (short)74896286;
			short num2 = num;
			num = (short)659346334;
			switch (num2 == num)
			{
			}
			num = (short)1673461760;
			short num3 = num;
			num = (short)481689601;
			if (num != 0)
			{
			}
			num = (short)1263009792;
			if (num != 0)
			{
			}
			return Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004EEC File Offset: 0x000030EC
		// Note: this type is marked as 'beforefieldinit'.
		static AcpTTSTextBox()
		{
			int a_ = 3;
			short num = (short)1203696247;
			short num2 = num;
			num = (short)506589815;
			switch (num2 == num)
			{
			}
			num = (short)1430061056;
			if (num != 0)
			{
			}
			num = (short)1757675521;
			if (num != 0)
			{
			}
			num = (short)1471741952;
			short num3 = num;
			AcpTTSTextBox.IsAcpValidProperty = DependencyProperty.Register(ACPTTSVoiceAnnouncement.b("簴䐶砸堺䴼椾⁀⽂ⱄ⍆", a_), typeof(bool), typeof(AcpTTSTextBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTTSTextBox.IsAcpApplicableProperty = DependencyProperty.Register(ACPTTSVoiceAnnouncement.b("簴䐶砸堺䴼績ㅀ㍂⥄⹆⩈⩊⽌⍎㑐", a_), typeof(bool), typeof(AcpTTSTextBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTTSTextBox.IsAcpEditableProperty = DependencyProperty.Register(ACPTTSVoiceAnnouncement.b("簴䐶砸堺䴼稾╀⩂ㅄ♆⭈❊⡌", a_), typeof(bool), typeof(AcpTTSTextBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTTSTextBox.IsAcpVisibleProperty = DependencyProperty.Register(ACPTTSVoiceAnnouncement.b("簴䐶砸堺䴼椾⡀あⱄ╆╈⹊", a_), typeof(bool), typeof(AcpTTSTextBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTTSTextBox.MyLabelCtrlProperty = DependencyProperty.RegisterAttached(ACPTTSVoiceAnnouncement.b("破丶甸娺弼娾ⵀBㅄ㕆╈", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpTTSTextBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTTSTextBox.MyCopyButtonProperty = DependencyProperty.RegisterAttached(ACPTTSVoiceAnnouncement.b("破丶稸吺䴼䘾̀㙂ㅄ㍆♈╊์㭎⍐㽒", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpTTSTextBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTTSTextBox.MyBLObjectProperty = DependencyProperty.RegisterAttached(ACPTTSVoiceAnnouncement.b("破丶笸眺爼崾⭀♂♄㍆", a_), typeof(AcpFieldBase), typeof(AcpTTSTextBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTTSTextBox.AreValuesEqualProperty = DependencyProperty.Register(ACPTTSVoiceAnnouncement.b("琴䔶尸洺尼匾㑀♂㙄Ɇ㡈㹊ⱌ⍎", a_), typeof(bool), typeof(AcpTTSTextBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTTSTextBox.MyExpanderProperty = DependencyProperty.RegisterAttached(ACPTTSVoiceAnnouncement.b("破丶簸䌺䴼帾⽀❂⁄㕆", a_), typeof(Expander), typeof(AcpTTSTextBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTTSTextBox.MyParentCtrlProperty = DependencyProperty.RegisterAttached(ACPTTSVoiceAnnouncement.b("破丶椸娺似娾⽀㝂ل㍆㭈❊", a_), typeof(IAcpUIParentCtrlBase), typeof(AcpTTSTextBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTTSTextBox.TextProperty = DependencyProperty.Register(ACPTTSVoiceAnnouncement.b("愴制䄸伺", a_), typeof(string), typeof(AcpTTSTextBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTTSTextBox.MaxLengthTtsProperty = DependencyProperty.Register(ACPTTSVoiceAnnouncement.b("破嘶䄸眺堼儾♀㝂ⵄፆ㵈㡊", a_), typeof(int), typeof(AcpTTSTextBox), new FrameworkPropertyMetadata(35, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTTSTextBox.TargetSpeakerProperty = DependencyProperty.Register(ACPTTSVoiceAnnouncement.b("愴嘶䬸尺堼䬾ቀ㍂⁄♆≈⹊㽌", a_), typeof(string), typeof(AcpTTSTextBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		}

		// Token: 0x0400000A RID: 10
		public static readonly DependencyProperty IsAcpValidProperty;

		// Token: 0x0400000B RID: 11
		public static readonly DependencyProperty IsAcpApplicableProperty;

		// Token: 0x0400000C RID: 12
		public static readonly DependencyProperty IsAcpEditableProperty;

		// Token: 0x0400000D RID: 13
		public static readonly DependencyProperty IsAcpVisibleProperty;

		// Token: 0x0400000E RID: 14
		public static readonly DependencyProperty MyLabelCtrlProperty;

		// Token: 0x0400000F RID: 15
		public static readonly DependencyProperty MyCopyButtonProperty;

		// Token: 0x04000010 RID: 16
		public static readonly DependencyProperty MyBLObjectProperty;

		// Token: 0x04000011 RID: 17
		public static readonly DependencyProperty AreValuesEqualProperty;

		// Token: 0x04000012 RID: 18
		public static readonly DependencyProperty MyExpanderProperty;

		// Token: 0x04000013 RID: 19
		public static readonly DependencyProperty MyParentCtrlProperty;

		// Token: 0x04000014 RID: 20
		public static readonly DependencyProperty TextProperty;

		// Token: 0x04000015 RID: 21
		public static readonly DependencyProperty MaxLengthTtsProperty;

		// Token: 0x04000016 RID: 22
		public static readonly DependencyProperty TargetSpeakerProperty;
	}
}
