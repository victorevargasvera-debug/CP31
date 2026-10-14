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
	// Token: 0x0200002C RID: 44
	public class AcpTextBox : global::System.Windows.Controls.TextBox, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIValueCtrlBase<string>, global::AcpUILib.IAcpUIParentCtrlBase, global::AcpUILib.IAcpUIChildCtrlBase, global::AcpUILib.IAcpUICommon, global::AcpUI.ISupportsTextBoxMember
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0002D108 File Offset: 0x0002B308
		// (set) Token: 0x06000268 RID: 616 RVA: 0x0002D1B8 File Offset: 0x0002B3B8
		public string Value
		{
			get
			{
				short num = (short)305384252;
				short num2 = num;
				num = (short)148884284;
				switch (num2 == num)
				{
				}
				num = (short)933363712;
				if (num != 0)
				{
				}
				num = (short)373227520;
				short num3 = num;
				num = (short)1363279873;
				if (num != 0)
				{
				}
				return base.Text;
			}
			set
			{
				short num = (short)395525448;
				short num2 = num;
				num = (short)730414408;
				switch (num2 == num)
				{
				}
				num = (short)2010578945;
				if (num != 0)
				{
				}
				num = (short)806027264;
				short num3 = num;
				num = (short)1909391360;
				if (num != 0)
				{
				}
				base.Text = value;
				this.GetBindingExpression(global::System.Windows.Controls.TextBox.TextProperty).UpdateSource();
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0002D278 File Offset: 0x0002B478
		// (set) Token: 0x0600026A RID: 618 RVA: 0x0002D330 File Offset: 0x0002B530
		public bool IsAcpValid
		{
			get
			{
				short num = (short)889706283;
				short num2 = num;
				num = (short)141874987;
				switch (num2 == num)
				{
				}
				num = (short)766640129;
				if (num != 0)
				{
				}
				num = (short)84213760;
				short num3 = num;
				num = (short)875167744;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTextBox.IsAcpValidProperty);
			}
			set
			{
				short num = (short)855717806;
				short num2 = num;
				num = (short)1899116462;
				switch (num2 == num)
				{
				}
				num = (short)19333121;
				if (num != 0)
				{
				}
				num = (short)121962496;
				short num3 = num;
				num = (short)32440320;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTextBox.IsAcpValidProperty, value);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0002D3F0 File Offset: 0x0002B5F0
		// (set) Token: 0x0600026C RID: 620 RVA: 0x0002D4AC File Offset: 0x0002B6AC
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)2047897564;
				short num2 = num;
				num = (short)90992604;
				switch (num2 == num)
				{
				}
				num = (short)690618369;
				if (num != 0)
				{
				}
				num = (short)1294401536;
				short num3 = num;
				num = (short)210042880;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTextBox.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)592904193;
				if (num != 0)
				{
				}
				num = (short)821474720;
				short num2 = num;
				num = (short)14792096;
				switch (num2 == num)
				{
				}
				num = (short)1022164992;
				short num3 = num;
				num = (short)362217472;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTextBox.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0002D56C File Offset: 0x0002B76C
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0002D628 File Offset: 0x0002B828
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)1274617831;
				short num2 = num;
				num = (short)1038163943;
				switch (num2 == num)
				{
				}
				num = (short)2003501057;
				if (num != 0)
				{
				}
				num = (short)135659520;
				short num3 = num;
				num = (short)1968046080;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTextBox.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1185590525;
				short num2 = num;
				num = (short)2005249277;
				switch (num2 == num)
				{
				}
				num = (short)568918016;
				if (num != 0)
				{
				}
				num = (short)311558144;
				short num3 = num;
				num = (short)1046609921;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTextBox.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0002D6E4 File Offset: 0x0002B8E4
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0002D79C File Offset: 0x0002B99C
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)1693650336;
				short num2 = num;
				num = (short)924126624;
				switch (num2 == num)
				{
				}
				num = (short)86573056;
				if (num != 0)
				{
				}
				num = (short)1212481536;
				short num3 = num;
				num = (short)641335297;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTextBox.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1574975840;
				short num2 = num;
				num = (short)1367882080;
				switch (num2 == num)
				{
				}
				num = (short)1602355201;
				if (num != 0)
				{
				}
				num = (short)1267073024;
				short num3 = num;
				num = (short)1227489280;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTextBox.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0002D858 File Offset: 0x0002BA58
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0002D910 File Offset: 0x0002BB10
		public global::AcpUILib.IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)1600415983;
				short num2 = num;
				num = (short)1031104751;
				switch (num2 == num)
				{
				}
				num = (short)1360003073;
				if (num != 0)
				{
				}
				num = (short)413532160;
				short num3 = num;
				num = (short)737607680;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpTextBox.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)468882200;
				short num2 = num;
				num = (short)567644952;
				switch (num2 == num)
				{
				}
				num = (short)836370433;
				if (num != 0)
				{
				}
				num = (short)1231355904;
				short num3 = num;
				num = (short)582811648;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTextBox.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0002D9C8 File Offset: 0x0002BBC8
		// (set) Token: 0x06000274 RID: 628 RVA: 0x0002DA80 File Offset: 0x0002BC80
		public global::AcpUILib.IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)501053508;
				short num2 = num;
				num = (short)665745476;
				switch (num2 == num)
				{
				}
				num = (short)681443328;
				short num3 = num;
				num = (short)599195648;
				if (num != 0)
				{
				}
				num = (short)799080449;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpTextBox.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)1029018099;
				short num2 = num;
				num = (short)469209587;
				switch (num2 == num)
				{
				}
				num = (short)1200750592;
				short num3 = num;
				num = (short)633405441;
				if (num != 0)
				{
				}
				num = (short)1376911360;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTextBox.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0002DB34 File Offset: 0x0002BD34
		// (set) Token: 0x06000276 RID: 630 RVA: 0x0002DBF0 File Offset: 0x0002BDF0
		public global::AcpBusinessLayer.AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)1766981633;
				if (num != 0)
				{
				}
				num = (short)1670024715;
				short num2 = num;
				num = (short)70880779;
				switch (num2 == num)
				{
				default:
				{
					num = (short)385941504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1687289856;
				if (num != 0)
				{
				}
				return (global::AcpBusinessLayer.AcpFieldBase)base.GetValue(global::AcpUI.AcpTextBox.MyBLObjectProperty);
			}
			set
			{
				short num = (short)1184456819;
				short num2 = num;
				num = (short)1806065779;
				switch (num2 == num)
				{
				}
				num = (short)1439498240;
				short num3 = num;
				num = (short)840564737;
				if (num != 0)
				{
				}
				num = (short)1219887104;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTextBox.MyBLObjectProperty, value);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0002DCA4 File Offset: 0x0002BEA4
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0002DD60 File Offset: 0x0002BF60
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)506068993;
				if (num != 0)
				{
				}
				num = (short)276302021;
				short num2 = num;
				num = (short)1970800837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1937047552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2083061760;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTextBox.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)597767948;
				short num2 = num;
				num = (short)1957246732;
				switch (num2 == num)
				{
				}
				num = (short)531431424;
				short num3 = num;
				num = (short)959250433;
				if (num != 0)
				{
				}
				num = (short)1059520512;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTextBox.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0002DE1C File Offset: 0x0002C01C
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0002DED8 File Offset: 0x0002C0D8
		public global::System.Windows.Controls.Expander MyExpander
		{
			get
			{
				short num = (short)700452946;
				short num2 = num;
				num = (short)693440594;
				switch (num2 == num)
				{
				}
				num = (short)1862598656;
				short num3 = num;
				num = (short)1218838529;
				if (num != 0)
				{
				}
				num = (short)1728577536;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Expander)base.GetValue(global::AcpUI.AcpTextBox.MyExpanderProperty);
			}
			set
			{
				short num = (short)1994850599;
				short num2 = num;
				num = (short)1591345447;
				switch (num2 == num)
				{
				}
				num = (short)1011220480;
				short num3 = num;
				num = (short)512360448;
				if (num != 0)
				{
				}
				num = (short)829030401;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTextBox.MyExpanderProperty, value);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0002DF90 File Offset: 0x0002C190
		// (set) Token: 0x0600027C RID: 636 RVA: 0x0002E048 File Offset: 0x0002C248
		public global::AcpUILib.IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)1980261736;
				short num2 = num;
				num = (short)1051813224;
				switch (num2 == num)
				{
				}
				num = (short)882049024;
				short num3 = num;
				num = (short)949485569;
				if (num != 0)
				{
				}
				num = (short)239337472;
				if (num != 0)
				{
				}
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::AcpUI.AcpTextBox.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)329151936;
				short num2 = num;
				num = (short)797275584;
				switch (num2 == num)
				{
				}
				num = (short)1157103616;
				short num3 = num;
				num = (short)263979008;
				if (num != 0)
				{
				}
				num = (short)1883373569;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTextBox.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0002E0FC File Offset: 0x0002C2FC
		// (set) Token: 0x0600027E RID: 638 RVA: 0x0002E1B4 File Offset: 0x0002C3B4
		public string MaskType
		{
			get
			{
				short num = (short)1387139341;
				short num2 = num;
				num = (short)2059735309;
				switch (num2 == num)
				{
				}
				num = (short)299433984;
				short num3 = num;
				num = (short)1443561472;
				if (num != 0)
				{
				}
				num = (short)874381313;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::AcpUI.AcpTextBox.MaskTypeProperty);
			}
			set
			{
				short num = (short)110777707;
				short num2 = num;
				num = (short)1366644075;
				switch (num2 == num)
				{
				}
				num = (short)1125318656;
				short num3 = num;
				num = (short)2118713345;
				if (num != 0)
				{
				}
				num = (short)759300096;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTextBox.MaskTypeProperty, value);
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0002E26C File Offset: 0x0002C46C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			int a_ = 18;
			short num = (short)875560971;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A9;
				case 1:
					if (global::AcpUI.AcpTextBox.DisableMask)
					{
						num = (short)1235812366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				case 2:
				{
					string text;
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)696385545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::AcpUI.AcpTextBox acpTextBox;
					acpTextBox.IsMasked = false;
					num = (short)511901699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_3BB;
				case 4:
					return;
				case 5:
				{
					num = (short)7446122;
					short num3 = num;
					num = (short)777297514;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2F7;
					default:
						num = (short)819658752;
						if (num != 0)
						{
						}
						num = (short)1034354698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					if (global::AcpUI.AcpTextBox.DisableIPMask)
					{
						num = (short)1096220677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
				{
					num = (short)173867009;
					if (num != 0)
					{
					}
					global::AcpUI.AcpTextBox acpTextBox;
					acpTextBox.IsMasked = false;
					num = (short)1432485892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
				{
					global::AcpUI.AcpTextBox acpTextBox;
					acpTextBox.IsMasked = false;
					num = (short)949354496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
				{
					global::AcpUI.AcpTextBox acpTextBox;
					acpTextBox.IsMasked = true;
					num = (short)1696399373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
				{
					string text;
					if (text != null)
					{
						num = (short)1700528145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 11:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 12:
				{
					string text;
					if (text != global::AcpUI.Common.Utility.c("펧즩쒫쾭슯袱貳貵袷鞹薻\udfbd룁藃鋇￑꧓", a_))
					{
						num = (short)676921352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				}
				case 13:
					goto IL_3BB;
				case 14:
					num = (short)1685258259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)1496383508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
				{
					global::AcpUI.AcpTextBox acpTextBox = (global::AcpUI.AcpTextBox)A_0;
					string text = (string)A_1.NewValue;
					goto IL_2F7;
				}
				case 17:
					num = (short)918290450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
				{
					string text;
					if (text.Contains(global::AcpUI.Common.Utility.c("펧쒩\ud9ab쎭튯ힱ욳貵袷鞹躻讽뿁뷅ꛇ뿉ꇋ곍뗏ꃑ鷟쳡鿣裥鷧蟩軫语苯죱쓳\udbf5쫷쿹짻菽", a_)))
					{
						num = (short)1052966919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 19:
				{
					string text;
					if (text != null)
					{
						num = (short)66322447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				}
				case 20:
				{
					string text;
					if (text.Contains(global::AcpUI.Common.Utility.c("즧螩횫鶯", a_)))
					{
						num = (short)2062811157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				}
				case 21:
				{
					num = (short)238288896;
					short num4 = num;
					num = (short)1067515916;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_85:
				if (A_0 is global::AcpUI.AcpTextBox)
				{
					num = (short)544342032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A9:
				num = (short)1309736966;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F7:
				num = (short)2068054018;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3BB:
				num = (short)1174798337;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0002E674 File Offset: 0x0002C874
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0002E72C File Offset: 0x0002C92C
		public bool IsMasked
		{
			get
			{
				short num = (short)1171786981;
				short num2 = num;
				num = (short)1051725029;
				switch (num2 == num)
				{
				}
				num = (short)1252589568;
				short num3 = num;
				num = (short)1857159168;
				if (num != 0)
				{
				}
				num = (short)1553268737;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpTextBox.IsMaskedProperty);
			}
			set
			{
				short num = (short)2063823198;
				short num2 = num;
				num = (short)1812492638;
				switch (num2 == num)
				{
				}
				num = (short)786432000;
				short num3 = num;
				num = (short)1736441857;
				if (num != 0)
				{
				}
				num = (short)1652162560;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpTextBox.IsMaskedProperty, value);
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0002E7E8 File Offset: 0x0002C9E8
		protected override void OnTextChanged(global::System.Windows.Controls.TextChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_11C;
				case 1:
				{
					num2 = (short)1745813505;
					if (num2 != 0)
					{
					}
					num2 = (short)466596593;
					short num3 = num2;
					num2 = (short)1915925233;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D3;
					default:
						num2 = (short)1112670208;
						if (num2 != 0)
						{
						}
						if (!string.IsNullOrEmpty(text))
						{
							num2 = (short)1059127298;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_164;
					}
					break;
				}
				case 2:
					goto IL_D3;
				case 3:
					if (text != base.Text)
					{
						num2 = (short)1498939396;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_164;
				case 4:
					base.Text = text;
					num2 = (short)1153236992;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_D3:
				num2 = (short)1728053248;
				short num4 = num2;
				text = global::AcpUI.Common.Utility.FilterArabicDiacritics(text);
				num2 = (short)1027407875;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_11C:
			IL_164:
			base.OnTextChanged(e);
			return;
			IL_24:
			text = base.Text;
			num2 = (short)1813970945;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0002E960 File Offset: 0x0002CB60
		public TChild FindVisualChild<TChild>(global::System.Windows.DependencyObject obj) where TChild : global::System.Windows.DependencyObject
		{
			short num = (short)1865547776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				TChild tchild;
				int num3;
				for (;;)
				{
					IL_27:
					global::System.Windows.DependencyObject child;
					switch (num2)
					{
					case 0:
						goto IL_199;
					case 1:
						num = (short)577765377;
						if (num != 0)
						{
						}
						if (tchild != null)
						{
							num = (short)827457542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)1891958784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1D4;
					case 3:
						if (child is TChild)
						{
							num = (short)139132935;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED;
					case 4:
						goto IL_199;
					case 5:
						if (num3 >= global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(obj))
						{
							num = (short)1562836994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						child = global::System.Windows.Media.VisualTreeHelper.GetChild(obj, num3);
						num = (short)785842184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return tchild;
					case 7:
						goto IL_194;
					case 8:
						if (child != null)
						{
							num = (short)1689255945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED;
					case 9:
						num = (short)1281490947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56;
					IL_ED:
					tchild = this.FindVisualChild<TChild>(child);
					num = (short)802095105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_199:
					num = (short)2109800453;
					num2 = (int)((global::System.IntPtr)num);
				}
				return tchild;
				IL_1D4:
				return default(TChild);
				IL_56:
				num3 = 0;
				num = (short)2019360768;
				short num4 = num;
				num = (short)1094677926;
				short num5 = num;
				num = (short)459699622;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_194:
					global::System.Windows.DependencyObject child;
					return (TChild)((object)child);
				}
				default:
					num = (short)325844992;
					if (num != 0)
					{
					}
					num = (short)1869414404;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				break;
			}
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0002EBBC File Offset: 0x0002CDBC
		public static T FindVisualParent<T>(global::System.Windows.UIElement element) where T : global::System.Windows.UIElement
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			T t;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_14B;
				case 1:
					goto IL_149;
				case 2:
					goto IL_14B;
				case 3:
				{
					if (t != null)
					{
						num2 = (short)382664705;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Windows.UIElement uielement = global::System.Windows.Media.VisualTreeHelper.GetParent(uielement) as global::System.Windows.UIElement;
					num2 = (short)1672282114;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					global::System.Windows.UIElement uielement;
					if (uielement == null)
					{
						num2 = (short)1767243781;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					t = (uielement as T);
					num2 = (short)852623363;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_17D;
				}
				goto IL_28;
				IL_14B:
				num2 = (short)1982726148;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_149:
			return t;
			IL_17D:
			return default(T);
			IL_28:
			num2 = (short)1867883678;
			short num3 = num2;
			num2 = (short)2051908766;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return t;
			default:
			{
				num2 = (short)421986305;
				if (num2 != 0)
				{
				}
				num2 = (short)2099314688;
				if (num2 != 0)
				{
				}
				global::System.Windows.UIElement uielement = element;
				num2 = (short)883425280;
				short num4 = num2;
				num2 = (short)2125725696;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0002ED54 File Offset: 0x0002CF54
		public static T GetElementUnderMouse<T>() where T : global::System.Windows.UIElement
		{
			short num = (short)2086989681;
			short num2 = num;
			num = (short)1063645041;
			switch (num2 == num)
			{
			}
			num = (short)667025408;
			short num3 = num;
			num = (short)1219624961;
			if (num != 0)
			{
			}
			num = (short)2131492864;
			if (num != 0)
			{
			}
			return global::AcpUI.AcpTextBox.FindVisualParent<T>(global::System.Windows.Input.Mouse.DirectlyOver as global::System.Windows.UIElement);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0002EE08 File Offset: 0x0002D008
		public AcpTextBox()
		{
			base.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
			base.ContextMenu = null;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0002EE2C File Offset: 0x0002D02C
		global::AcpUI.AcpTextBox global::AcpUI.ISupportsTextBoxMember.TextBoxMember
		{
			get
			{
				short num = (short)1335623681;
				if (num != 0)
				{
				}
				num = (short)1678886079;
				short num2 = num;
				num = (short)613532863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1943666688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1638596608;
				if (num != 0)
				{
				}
				return this;
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0002EED8 File Offset: 0x0002D0D8
		// Note: this type is marked as 'beforefieldinit'.
		static AcpTextBox()
		{
			int a_ = 12;
			short num = (short)1565726504;
			short num2 = num;
			num = (short)2066093864;
			switch (num2 == num)
			{
			}
			num = (short)127008768;
			short num3 = num;
			num = (short)708706304;
			if (num != 0)
			{
			}
			num = (short)76808193;
			if (num != 0)
			{
			}
			global::AcpUI.AcpTextBox.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("힣쮧\udaa9磌쾭\udcaf\udbb1킳", a_), typeof(bool), typeof(global::AcpUI.AcpTextBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTextBox.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("힣쮧\udaa9\udead삯\udeb1\uddb3햵\ud9b7\ud8b9킻\udbbd", a_), typeof(bool), typeof(global::AcpUI.AcpTextBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTextBox.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("힣쮧\udaa9쪭\ud9af욱햳풵풷\udfb9", a_), typeof(bool), typeof(global::AcpUI.AcpTextBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTextBox.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("힣쮧\udaa9磌잭쎯\udbb1횳\udab5\uddb7", a_), typeof(bool), typeof(global::AcpUI.AcpTextBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpTextBox.MyLabelCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udda3즧좩즫슭욱욳\udab5", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpTextBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTextBox.MyCopyButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udda3잧\udaa9햫얯욱삳\ud9b5횷惡좻첽겿", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpTextBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTextBox.MyBLObjectProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udda3캫쒭햯톱삳", a_), typeof(global::AcpBusinessLayer.AcpFieldBase), typeof(global::AcpUI.AcpTextBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTextBox.AreValuesEqualProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("횣쎥ﺧ쮩삫\udbad햯솱잵춷\udbb9킻", a_), typeof(bool), typeof(global::AcpUI.AcpTextBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTextBox.MyExpanderProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udda3킧\udaa9춫삭풯ힱ욳", a_), typeof(global::System.Windows.Controls.Expander), typeof(global::AcpUI.AcpTextBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTextBox.MyParentCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udda3즧\ud8a9즫삭쒯삳쒵풷", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::AcpUI.AcpTextBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpTextBox.MaskTypeProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("얣향쎧ﺩ햫\udead햯", a_), typeof(string), typeof(global::AcpUI.AcpTextBox), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::AcpUI.AcpTextBox.a)));
			global::AcpUI.AcpTextBox.DisableMask = false;
			global::AcpUI.AcpTextBox.DisableIPMask = false;
			global::AcpUI.AcpTextBox.IsMaskedProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("힣즧\ud9a9잫쮭풯", a_), typeof(bool), typeof(global::AcpUI.AcpTextBox), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x040001AF RID: 431
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x040001B0 RID: 432
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x040001B1 RID: 433
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x040001B2 RID: 434
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x040001B3 RID: 435
		public static readonly global::System.Windows.DependencyProperty MyLabelCtrlProperty;

		// Token: 0x040001B4 RID: 436
		public static readonly global::System.Windows.DependencyProperty MyCopyButtonProperty;

		// Token: 0x040001B5 RID: 437
		public static readonly global::System.Windows.DependencyProperty MyBLObjectProperty;

		// Token: 0x040001B6 RID: 438
		public static readonly global::System.Windows.DependencyProperty AreValuesEqualProperty;

		// Token: 0x040001B7 RID: 439
		public static readonly global::System.Windows.DependencyProperty MyExpanderProperty;

		// Token: 0x040001B8 RID: 440
		public static readonly global::System.Windows.DependencyProperty MyParentCtrlProperty;

		// Token: 0x040001B9 RID: 441
		public static readonly global::System.Windows.DependencyProperty MaskTypeProperty;

		// Token: 0x040001BA RID: 442
		public static bool DisableMask;

		// Token: 0x040001BB RID: 443
		public static bool DisableIPMask;

		// Token: 0x040001BC RID: 444
		public static readonly global::System.Windows.DependencyProperty IsMaskedProperty;
	}
}
