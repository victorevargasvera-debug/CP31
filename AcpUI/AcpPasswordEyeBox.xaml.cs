using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using AcpBusinessLayer;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x02000025 RID: 37
	public partial class AcpPasswordEyeBox : UserControl, IAcpUICtrlBase, IAcpUIValueCtrlBase<string>, IAcpUIParentCtrlBase, IAcpUIChildCtrlBase, IAcpUICommon
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0002755C File Offset: 0x0002575C
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00027614 File Offset: 0x00025814
		public int IsEyeVisible
		{
			get
			{
				short num = (short)814566644;
				short num2 = num;
				num = (short)606489844;
				switch (num2 == num)
				{
				}
				num = (short)1174208513;
				if (num != 0)
				{
				}
				num = (short)2050490368;
				if (num != 0)
				{
				}
				num = (short)1816395776;
				short num3 = num;
				return (int)base.GetValue(AcpPasswordEyeBox.IsEyeVisibleProperty);
			}
			set
			{
				short num = (short)778748905;
				short num2 = num;
				num = (short)1923728361;
				switch (num2 == num)
				{
				}
				num = (short)1312161792;
				if (num != 0)
				{
				}
				num = (short)1445396481;
				if (num != 0)
				{
				}
				num = (short)212008960;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.IsEyeVisibleProperty, value);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600021A RID: 538 RVA: 0x000276D0 File Offset: 0x000258D0
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00027788 File Offset: 0x00025988
		public bool IsCopyEnabled
		{
			get
			{
				short num = (short)736091388;
				short num2 = num;
				num = (short)2125520124;
				switch (num2 == num)
				{
				}
				num = (short)1748107265;
				if (num != 0)
				{
				}
				num = (short)1294991360;
				if (num != 0)
				{
				}
				num = (short)523108352;
				short num3 = num;
				return (bool)base.GetValue(AcpPasswordEyeBox.IsCopyEnabledProperty);
			}
			set
			{
				short num = (short)635706036;
				short num2 = num;
				num = (short)481630900;
				switch (num2 == num)
				{
				}
				num = (short)1568079873;
				if (num != 0)
				{
				}
				num = (short)1048772608;
				if (num != 0)
				{
				}
				num = (short)647626752;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.IsCopyEnabledProperty, value);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00027844 File Offset: 0x00025A44
		// (set) Token: 0x0600021D RID: 541 RVA: 0x000278F4 File Offset: 0x00025AF4
		public string Value
		{
			get
			{
				short num = (short)486177035;
				short num2 = num;
				num = (short)1406630155;
				switch (num2 == num)
				{
				}
				num = (short)538640385;
				if (num != 0)
				{
				}
				num = (short)1204092928;
				if (num != 0)
				{
				}
				num = (short)69861376;
				short num3 = num;
				return this.b.Password;
			}
			set
			{
				short num = (short)1122959361;
				if (num != 0)
				{
				}
				num = (short)211146258;
				short num2 = num;
				num = (short)1926682130;
				switch (num2 == num)
				{
				}
				num = (short)90767360;
				if (num != 0)
				{
				}
				num = (short)1312489472;
				short num3 = num;
				this.b.Password = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000279AC File Offset: 0x00025BAC
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00027A64 File Offset: 0x00025C64
		public bool IsAcpValid
		{
			get
			{
				short num = (short)261578027;
				short num2 = num;
				num = (short)775249195;
				switch (num2 == num)
				{
				}
				num = (short)782172161;
				if (num != 0)
				{
				}
				num = (short)441909248;
				if (num != 0)
				{
				}
				num = (short)1941176320;
				short num3 = num;
				return (bool)base.GetValue(AcpPasswordEyeBox.IsAcpValidProperty);
			}
			set
			{
				short num = (short)1442866027;
				short num2 = num;
				num = (short)91579243;
				switch (num2 == num)
				{
				}
				num = (short)1409417217;
				if (num != 0)
				{
				}
				num = (short)2113994752;
				if (num != 0)
				{
				}
				num = (short)1062207488;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.IsAcpValidProperty, value);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00027B1C File Offset: 0x00025D1C
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00027BD8 File Offset: 0x00025DD8
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)453647989;
				short num2 = num;
				num = (short)1668882037;
				switch (num2 == num)
				{
				}
				num = (short)1779761153;
				if (num != 0)
				{
				}
				num = (short)304480256;
				if (num != 0)
				{
				}
				num = (short)105381888;
				short num3 = num;
				return (bool)base.GetValue(AcpPasswordEyeBox.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1094451201;
				if (num != 0)
				{
				}
				num = (short)48587162;
				short num2 = num;
				num = (short)1820483994;
				switch (num2 == num)
				{
				}
				num = (short)1309999104;
				if (num != 0)
				{
				}
				num = (short)739835904;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00027C94 File Offset: 0x00025E94
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00027D4C File Offset: 0x00025F4C
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)476839937;
				if (num != 0)
				{
				}
				num = (short)1837774852;
				short num2 = num;
				num = (short)248133636;
				switch (num2 == num)
				{
				}
				num = (short)1484783616;
				if (num != 0)
				{
				}
				num = (short)1808203776;
				short num3 = num;
				return (bool)base.GetValue(AcpPasswordEyeBox.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1631474135;
				short num2 = num;
				num = (short)1088901591;
				switch (num2 == num)
				{
				}
				num = (short)43122688;
				if (num != 0)
				{
				}
				num = (short)1079967745;
				if (num != 0)
				{
				}
				num = (short)360382464;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00027E04 File Offset: 0x00026004
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00027EBC File Offset: 0x000260BC
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)529081221;
				short num2 = num;
				num = (short)601170821;
				switch (num2 == num)
				{
				}
				num = (short)1421410305;
				if (num != 0)
				{
				}
				num = (short)242548736;
				if (num != 0)
				{
				}
				num = (short)933822464;
				short num3 = num;
				return (bool)base.GetValue(AcpPasswordEyeBox.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1908507998;
				short num2 = num;
				num = (short)810321246;
				switch (num2 == num)
				{
				}
				num = (short)1815281665;
				if (num != 0)
				{
				}
				num = (short)579010560;
				if (num != 0)
				{
				}
				num = (short)1463681024;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00027F7C File Offset: 0x0002617C
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00028038 File Offset: 0x00026238
		public IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)2144682389;
				short num2 = num;
				num = (short)1691828629;
				switch (num2 == num)
				{
				}
				num = (short)1979318273;
				if (num != 0)
				{
				}
				num = (short)1716322304;
				if (num != 0)
				{
				}
				num = (short)767098880;
				short num3 = num;
				return (IAcpUIChildCtrlBase)base.GetValue(AcpPasswordEyeBox.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)1972376551;
				short num2 = num;
				num = (short)294917095;
				switch (num2 == num)
				{
				}
				num = (short)1255866369;
				if (num != 0)
				{
				}
				num = (short)1807745024;
				if (num != 0)
				{
				}
				num = (short)1069940736;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000228 RID: 552 RVA: 0x000280EC File Offset: 0x000262EC
		// (set) Token: 0x06000229 RID: 553 RVA: 0x000281A4 File Offset: 0x000263A4
		public IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)177921351;
				short num2 = num;
				num = (short)1980292423;
				switch (num2 == num)
				{
				}
				num = (short)529858561;
				if (num != 0)
				{
				}
				num = (short)1418788864;
				if (num != 0)
				{
				}
				num = (short)116719616;
				short num3 = num;
				return (IAcpUIChildCtrlBase)base.GetValue(AcpPasswordEyeBox.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)537964746;
				short num2 = num;
				num = (short)177647818;
				switch (num2 == num)
				{
				}
				num = (short)698482689;
				if (num != 0)
				{
				}
				num = (short)949813248;
				if (num != 0)
				{
				}
				num = (short)1291517952;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00028258 File Offset: 0x00026458
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00028310 File Offset: 0x00026510
		public AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)768205008;
				short num2 = num;
				num = (short)560718032;
				switch (num2 == num)
				{
				}
				num = (short)1854799872;
				if (num != 0)
				{
				}
				num = (short)795279361;
				if (num != 0)
				{
				}
				num = (short)1235943424;
				short num3 = num;
				return (AcpFieldBase)base.GetValue(AcpPasswordEyeBox.MyBLObjectProperty);
			}
			set
			{
				short num = (short)1180820530;
				short num2 = num;
				num = (short)983753778;
				switch (num2 == num)
				{
				}
				num = (short)2078277633;
				if (num != 0)
				{
				}
				num = (short)1156382720;
				if (num != 0)
				{
				}
				num = (short)1795162112;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.MyBLObjectProperty, value);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600022C RID: 556 RVA: 0x000283C8 File Offset: 0x000265C8
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00028480 File Offset: 0x00026680
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)196199610;
				short num2 = num;
				num = (short)656327866;
				switch (num2 == num)
				{
				}
				num = (short)758644737;
				if (num != 0)
				{
				}
				num = (short)1568800768;
				if (num != 0)
				{
				}
				num = (short)1627193344;
				short num3 = num;
				return (bool)base.GetValue(AcpPasswordEyeBox.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)1869517805;
				short num2 = num;
				num = (short)1109955565;
				switch (num2 == num)
				{
				}
				num = (short)577372161;
				if (num != 0)
				{
				}
				num = (short)130744320;
				if (num != 0)
				{
				}
				num = (short)470876160;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0002853C File Offset: 0x0002673C
		// (set) Token: 0x0600022F RID: 559 RVA: 0x000285F4 File Offset: 0x000267F4
		public Expander MyExpander
		{
			get
			{
				short num = (short)335359789;
				short num2 = num;
				num = (short)705638189;
				switch (num2 == num)
				{
				}
				num = (short)2013069312;
				if (num != 0)
				{
				}
				num = (short)862781441;
				if (num != 0)
				{
				}
				num = (short)1825832960;
				short num3 = num;
				return (Expander)base.GetValue(AcpPasswordEyeBox.MyExpanderProperty);
			}
			set
			{
				short num = (short)1523327383;
				short num2 = num;
				num = (short)942612887;
				switch (num2 == num)
				{
				}
				num = (short)1635319809;
				if (num != 0)
				{
				}
				num = (short)1471873024;
				if (num != 0)
				{
				}
				num = (short)1270677504;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.MyExpanderProperty, value);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000286A8 File Offset: 0x000268A8
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00028760 File Offset: 0x00026960
		public IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)1347300560;
				short num2 = num;
				num = (short)220736720;
				switch (num2 == num)
				{
				}
				num = (short)220266497;
				if (num != 0)
				{
				}
				num = (short)1900281856;
				if (num != 0)
				{
				}
				num = (short)32309248;
				short num3 = num;
				return (IAcpUIParentCtrlBase)base.GetValue(AcpPasswordEyeBox.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)1967504657;
				short num2 = num;
				num = (short)577944849;
				switch (num2 == num)
				{
				}
				num = (short)966000640;
				if (num != 0)
				{
				}
				num = (short)141426689;
				if (num != 0)
				{
				}
				num = (short)486473728;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00028814 File Offset: 0x00026A14
		// (set) Token: 0x06000233 RID: 563 RVA: 0x000288CC File Offset: 0x00026ACC
		public bool IsDigitOnly
		{
			get
			{
				short num = (short)2089348479;
				short num2 = num;
				num = (short)1665002879;
				switch (num2 == num)
				{
				}
				num = (short)1036386305;
				if (num != 0)
				{
				}
				num = (short)466485248;
				if (num != 0)
				{
				}
				num = (short)512294912;
				short num3 = num;
				return (bool)base.GetValue(AcpPasswordEyeBox.IsDigitOnlyProperty);
			}
			set
			{
				short num = (short)177599888;
				short num2 = num;
				num = (short)1049490832;
				switch (num2 == num)
				{
				}
				num = (short)604831744;
				if (num != 0)
				{
				}
				num = (short)376569857;
				if (num != 0)
				{
				}
				num = (short)1433731072;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.IsDigitOnlyProperty, value);
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00028988 File Offset: 0x00026B88
		private void AcpPasswordEyeBox_OnPreviewKeyDown(object A_0, KeyEventArgs A_1)
		{
			short num = (short)1213988915;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B32;
				case 1:
					if (Keyboard.Modifiers != ModifierKeys.None)
					{
						num = (short)1419247631;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C73;
				case 2:
					num = (short)586219589;
					num2 = (int)((IntPtr)num);
					continue;
				case 3:
					if (A_1.Key == Key.D4)
					{
						num = (short)51576893;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1254;
				case 4:
					A_1.Handled = false;
					num = (short)173932549;
					num2 = (int)((IntPtr)num);
					continue;
				case 5:
					goto IL_B32;
				case 6:
					if (A_1.Key != Key.Return)
					{
						num = (short)405864541;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C73;
				case 7:
					if (A_1.Key != Key.D8)
					{
						num = (short)229507084;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_CDF;
				case 8:
					num = (short)2114191476;
					num2 = (int)((IntPtr)num);
					continue;
				case 9:
					goto IL_B32;
				case 10:
					if (A_1.Key == Key.Decimal)
					{
						num = (short)1308754043;
						num2 = (int)((IntPtr)num);
						continue;
					}
					A_1.Handled = true;
					num = (short)498597897;
					num2 = (int)((IntPtr)num);
					continue;
				case 11:
					if (this.IsDigitOnly)
					{
						num = (short)606601286;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)616235054;
					num2 = (int)((IntPtr)num);
					continue;
				case 12:
					num = (short)825229434;
					num2 = (int)((IntPtr)num);
					continue;
				case 13:
					if (A_1.Key != Key.Oem6)
					{
						num = (short)1061552128;
						short num3 = num;
						num = (short)960168026;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_404;
				case 14:
					num = (short)689242232;
					num2 = (int)((IntPtr)num);
					continue;
				case 15:
					goto IL_F34;
				case 16:
					if (A_1.Key != Key.Subtract)
					{
						num = (short)1663172631;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1182;
				case 17:
					num = (short)787283975;
					num2 = (int)((IntPtr)num);
					continue;
				case 18:
					goto IL_12D1;
				case 19:
					num = (short)1490092035;
					num2 = (int)((IntPtr)num);
					continue;
				case 20:
					goto IL_B32;
				case 21:
					goto IL_B32;
				case 22:
					A_1.Handled = false;
					num = (short)436600853;
					num2 = (int)((IntPtr)num);
					continue;
				case 23:
					num = (short)1711865992;
					num2 = (int)((IntPtr)num);
					continue;
				case 24:
					if (Keyboard.Modifiers == ModifierKeys.None)
					{
						num = (short)976552001;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_107E;
				case 25:
					num = (short)1833828420;
					num2 = (int)((IntPtr)num);
					continue;
				case 26:
					if (A_1.Key != Key.LeftShift)
					{
						num = (short)1688666236;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_8D9;
				case 27:
					if (A_1.Key != Key.Oem4)
					{
						num = (short)1074266203;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_404;
				case 28:
					num = (short)2006909035;
					num2 = (int)((IntPtr)num);
					continue;
				case 29:
					if (Keyboard.Modifiers == ModifierKeys.Shift)
					{
						num = (short)460521497;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1254;
				case 30:
					if (A_1.Key != Key.D2)
					{
						num = (short)982908978;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1433;
				case 31:
					if (A_1.Key == Key.Multiply)
					{
						num = (short)1958936703;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)1616511047;
					num2 = (int)((IntPtr)num);
					continue;
				case 32:
					goto IL_12D1;
				case 33:
					if (A_1.Key != Key.D0)
					{
						num = (short)124125271;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1433;
				case 34:
					goto IL_93D;
				case 35:
					if (A_1.Key > Key.D9)
					{
						num = (short)1572208676;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1143;
				case 36:
					goto IL_1038;
				case 37:
					if (A_1.Key != Key.Oem1)
					{
						num = (short)1038942274;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_404;
				case 38:
					if (A_1.Key != Key.Back)
					{
						num = (short)594673711;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_8D9;
				case 39:
					if (A_1.Key != Key.D7)
					{
						num = (short)49152103;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_CDF;
				case 40:
					goto IL_B32;
				case 41:
					num = (short)400097406;
					num2 = (int)((IntPtr)num);
					continue;
				case 42:
					if (A_1.Key != Key.Oem7)
					{
						num = (short)713949269;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_404;
				case 43:
					if (A_1.Key != Key.Tab)
					{
						num = (short)1470627907;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C73;
				case 44:
					if (A_1.Key >= Key.A)
					{
						num = (short)2042888233;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_EF5;
				case 45:
					if (A_1.Key != Key.Back)
					{
						num = (short)1726152836;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_93D;
				case 46:
					if (A_1.Key != Key.RightShift)
					{
						num = (short)1172045900;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_8D9;
				case 47:
					num = (short)567672906;
					num2 = (int)((IntPtr)num);
					continue;
				case 48:
					if (Keyboard.Modifiers == ModifierKeys.None)
					{
						num = (short)991821852;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_D02;
				case 49:
					goto IL_9C1;
				case 50:
					num = (short)784072802;
					num2 = (int)((IntPtr)num);
					continue;
				case 51:
					switch (0)
					{
					case 0:
						goto IL_24C;
					}
					continue;
				case 52:
					if (A_1.Key != Key.Oem5)
					{
						num = (short)1218052201;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_404;
				case 53:
					num = (short)1525088289;
					num2 = (int)((IntPtr)num);
					continue;
				case 54:
					if (Keyboard.Modifiers == ModifierKeys.Shift)
					{
						num = (short)660471937;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_69C;
				case 55:
					if (A_1.Key != Key.Back)
					{
						num = (short)678756412;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C73;
				case 56:
					if (A_1.Key != Key.Return)
					{
						num = (short)829816929;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_8D9;
				case 57:
					if (A_1.Key == Key.OemMinus)
					{
						num = (short)2004353136;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_69C;
				case 58:
					num = (short)1193738321;
					num2 = (int)((IntPtr)num);
					continue;
				case 59:
					num = (short)544604205;
					num2 = (int)((IntPtr)num);
					continue;
				case 60:
					num = (short)483590243;
					num2 = (int)((IntPtr)num);
					continue;
				case 61:
					goto IL_CDF;
				case 62:
					goto IL_C73;
				case 63:
					num = (short)1461649409;
					num2 = (int)((IntPtr)num);
					continue;
				case 64:
					if (A_1.Key != Key.Divide)
					{
						num = (short)1145110608;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1182;
				case 65:
					A_1.Handled = false;
					num = (short)382337044;
					num2 = (int)((IntPtr)num);
					continue;
				case 66:
					num = (short)766246994;
					num2 = (int)((IntPtr)num);
					continue;
				case 67:
					num = (short)2087977015;
					num2 = (int)((IntPtr)num);
					continue;
				case 68:
					if (A_1.Key != Key.OemPlus)
					{
						num = (short)2131755025;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_CDF;
				case 69:
					if (A_1.Key != Key.OemPlus)
					{
						num = (short)1864106101;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_404;
				case 70:
					num = (short)2096365696;
					num2 = (int)((IntPtr)num);
					continue;
				case 71:
					if (A_1.Key >= Key.D0)
					{
						num = (short)1906311289;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1038;
				case 72:
					if (A_1.Key > Key.NumPad9)
					{
						num = (short)1639645276;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1182;
				case 73:
					if (A_1.Key != Key.D5)
					{
						num = (short)1523253267;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_CDF;
				case 74:
					if (A_1.Key == Key.Delete)
					{
						num = (short)1810497619;
						num2 = (int)((IntPtr)num);
						continue;
					}
					num = (short)121045040;
					num2 = (int)((IntPtr)num);
					continue;
				case 75:
					num = (short)274923654;
					num2 = (int)((IntPtr)num);
					continue;
				case 76:
					num = (short)383778842;
					num2 = (int)((IntPtr)num);
					continue;
				case 77:
					if (A_1.Key >= Key.NumPad0)
					{
						num = (short)2020737135;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_983;
				case 78:
					num = (short)1399128091;
					num2 = (int)((IntPtr)num);
					continue;
				case 79:
					if (A_1.Key != Key.Oem2)
					{
						num = (short)1904476291;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1143;
				case 80:
					num = (short)336723999;
					num2 = (int)((IntPtr)num);
					continue;
				case 81:
					if (A_1.Key != Key.Home)
					{
						num = (short)1959329806;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1456;
				case 82:
					if (A_1.Key != Key.Oem3)
					{
						num = (short)1910571086;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_404;
				case 83:
					goto IL_8D9;
				case 84:
					if (A_1.Key != Key.Right)
					{
						num = (short)933494903;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1456;
				case 85:
					num = (short)41156733;
					num2 = (int)((IntPtr)num);
					continue;
				case 86:
					if (A_1.Key != Key.OemPeriod)
					{
						num = (short)620625922;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_404;
				case 87:
					num = (short)1916665991;
					num2 = (int)((IntPtr)num);
					continue;
				case 88:
					num = (short)765198375;
					num2 = (int)((IntPtr)num);
					continue;
				case 89:
					if (A_1.Key != Key.Tab)
					{
						num = (short)1071317106;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_8D9;
				case 90:
					num = (short)2048262186;
					num2 = (int)((IntPtr)num);
					continue;
				case 91:
					num = (short)821231668;
					num2 = (int)((IntPtr)num);
					continue;
				case 92:
					goto IL_983;
				case 93:
					num = (short)1880948779;
					num2 = (int)((IntPtr)num);
					continue;
				case 94:
					if (A_1.Key == Key.OemMinus)
					{
						num = (short)1536360554;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_107E;
				case 95:
					goto IL_B32;
				case 96:
					if (A_1.Key != Key.Left)
					{
						num = (short)663617594;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1456;
				case 97:
					num = (short)953745497;
					num2 = (int)((IntPtr)num);
					continue;
				case 98:
					if (A_1.Key != Key.D6)
					{
						num = (short)900595787;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1433;
				case 99:
					if (A_1.Key == Key.Delete)
					{
						num = (short)1496842302;
						num2 = (int)((IntPtr)num);
						continue;
					}
					A_1.Handled = true;
					num = (short)14549100;
					num2 = (int)((IntPtr)num);
					continue;
				case 100:
					if (A_1.Key == Key.Delete)
					{
						num = (short)28311586;
						num2 = (int)((IntPtr)num);
						continue;
					}
					this.a = false;
					num = (short)982122528;
					num2 = (int)((IntPtr)num);
					continue;
				case 101:
					return;
				case 102:
					if (A_1.Key != Key.D1)
					{
						num = (short)416809078;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1433;
				case 103:
					num = (short)710606921;
					num2 = (int)((IntPtr)num);
					continue;
				case 104:
					num = (short)1051066454;
					num2 = (int)((IntPtr)num);
					continue;
				case 105:
					num = (short)1215365133;
					num2 = (int)((IntPtr)num);
					continue;
				case 106:
					goto IL_1143;
				case 107:
					if (A_1.Key == Key.Space)
					{
						num = (short)1585315862;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_D02;
				case 108:
					goto IL_B32;
				case 109:
					goto IL_B32;
				case 110:
					goto IL_B32;
				case 111:
					num = (short)1305935944;
					num2 = (int)((IntPtr)num);
					continue;
				case 112:
					goto IL_1433;
				case 113:
					if (A_1.Key >= Key.NumPad0)
					{
						num = (short)120782856;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_381;
				case 114:
					num = (short)860225574;
					num2 = (int)((IntPtr)num);
					continue;
				case 115:
					goto IL_B32;
				case 116:
					if (A_1.Key > Key.NumPad9)
					{
						num = (short)188612741;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_C73;
				case 117:
					num = (short)951975946;
					num2 = (int)((IntPtr)num);
					continue;
				case 118:
					num = (short)223871006;
					num2 = (int)((IntPtr)num);
					continue;
				case 119:
					num = (short)2002583648;
					num2 = (int)((IntPtr)num);
					continue;
				case 120:
					if (A_1.Key == Key.End)
					{
						num = (short)1393295490;
						num2 = (int)((IntPtr)num);
						continue;
					}
					return;
				case 121:
					num = (short)1210122275;
					num2 = (int)((IntPtr)num);
					continue;
				case 122:
					if (A_1.Key != Key.D3)
					{
						num = (short)1024655448;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_CDF;
				case 123:
					goto IL_404;
				case 124:
					num = (short)2024734776;
					num2 = (int)((IntPtr)num);
					continue;
				case 125:
					num = (short)1843986433;
					if (num != 0)
					{
					}
					if (A_1.Key != Key.OemComma)
					{
						num = (short)1923678312;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_404;
				case 126:
					if (A_1.Key <= Key.Z)
					{
						num = (short)478871556;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_EF5;
				case 127:
					goto IL_1182;
				case 128:
					if (char.IsNumber(new KeyConverter().ConvertToString(A_1.Key)[0]))
					{
						num = (short)1154809919;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_F34;
				case 129:
					num = (short)327811174;
					num2 = (int)((IntPtr)num);
					continue;
				case 130:
					goto IL_1456;
				case 131:
					num = (short)391839838;
					num2 = (int)((IntPtr)num);
					continue;
				case 132:
					num = (short)255197284;
					num2 = (int)((IntPtr)num);
					continue;
				case 133:
					goto IL_381;
				case 134:
					if (A_1.Key != Key.D9)
					{
						num = (short)1510146101;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1433;
				case 135:
					if (A_1.Key != Key.Oem2)
					{
						num = (short)1027735601;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1433;
				case 136:
					if (A_1.Key != Key.Add)
					{
						num = (short)995295369;
						num2 = (int)((IntPtr)num);
						continue;
					}
					goto IL_1182;
				case 137:
					num = (short)1791557696;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_24C:
				if (A_0 is PasswordBox)
				{
					num = (short)1757020219;
					num2 = (int)((IntPtr)num);
					continue;
				}
				break;
				IL_381:
				num = (short)641073158;
				num2 = (int)((IntPtr)num);
				continue;
				IL_404:
				A_1.Handled = false;
				num = (short)2131951725;
				num2 = (int)((IntPtr)num);
				continue;
				IL_69C:
				num = (short)11403301;
				num2 = (int)((IntPtr)num);
				continue;
				IL_8D9:
				A_1.Handled = false;
				num = (short)1299251315;
				num2 = (int)((IntPtr)num);
				continue;
				IL_93D:
				this.a = true;
				num = (short)1766981650;
				num2 = (int)((IntPtr)num);
				continue;
				IL_983:
				num = (short)1276772368;
				num2 = (int)((IntPtr)num);
				continue;
				IL_9C1:
				num = (short)1870921785;
				num2 = (int)((IntPtr)num);
				continue;
				IL_C73:
				num = (short)240537838;
				short num4 = num;
				num = (short)606032110;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_9C1;
				default:
					num = (short)542441472;
					if (num != 0)
					{
					}
					A_1.Handled = false;
					num = (short)1604321390;
					num2 = (int)((IntPtr)num);
					continue;
				}
				IL_B32:
				num = (short)370475092;
				num2 = (int)((IntPtr)num);
				continue;
				IL_CDF:
				A_1.Handled = false;
				num = (short)454885376;
				num2 = (int)((IntPtr)num);
				continue;
				IL_D02:
				num = (short)1479999565;
				num2 = (int)((IntPtr)num);
				continue;
				IL_EF5:
				num = (short)1043922973;
				num2 = (int)((IntPtr)num);
				continue;
				IL_F34:
				num = (short)957677681;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1038:
				num = (short)2085879887;
				num2 = (int)((IntPtr)num);
				continue;
				IL_107E:
				num = (short)252182572;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1143:
				num = (short)718274584;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1182:
				A_1.Handled = false;
				num = (short)1256259624;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1254:
				num = (short)448462902;
				num2 = (int)((IntPtr)num);
				continue;
				IL_12D1:
				num = (short)861143051;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1433:
				A_1.Handled = false;
				num = (short)145096799;
				num2 = (int)((IntPtr)num);
				continue;
				IL_1456:
				A_1.Handled = false;
				num = (short)275054693;
				num2 = (int)((IntPtr)num);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00029E30 File Offset: 0x00028030
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00029EE8 File Offset: 0x000280E8
		public int MaxPasswordLength
		{
			get
			{
				short num = (short)1046559564;
				short num2 = num;
				num = (short)415841100;
				switch (num2 == num)
				{
				}
				num = (short)1827799040;
				if (num != 0)
				{
				}
				num = (short)1568145409;
				if (num != 0)
				{
				}
				num = (short)1933443072;
				short num3 = num;
				return (int)base.GetValue(AcpPasswordEyeBox.MaxPasswordLengthProperty);
			}
			set
			{
				short num = (short)84415829;
				short num2 = num;
				num = (short)112792917;
				switch (num2 == num)
				{
				}
				num = (short)1538260993;
				if (num != 0)
				{
				}
				num = (short)117571584;
				if (num != 0)
				{
				}
				num = (short)895025152;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.MaxPasswordLengthProperty, value);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00029FA4 File Offset: 0x000281A4
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0002A05C File Offset: 0x0002825C
		public string PIN
		{
			get
			{
				short num = (short)403243009;
				if (num != 0)
				{
				}
				num = (short)1919248062;
				short num2 = num;
				num = (short)1015113406;
				switch (num2 == num)
				{
				}
				num = (short)1535967232;
				if (num != 0)
				{
				}
				num = (short)194117632;
				short num3 = num;
				return (string)base.GetValue(AcpPasswordEyeBox.PINProperty);
			}
			set
			{
				short num = (short)739114920;
				short num2 = num;
				num = (short)1770061736;
				switch (num2 == num)
				{
				}
				num = (short)716374017;
				if (num != 0)
				{
				}
				num = (short)1939931136;
				if (num != 0)
				{
				}
				num = (short)2147287040;
				short num3 = num;
				base.SetValue(AcpPasswordEyeBox.PINProperty, value);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0002A110 File Offset: 0x00028310
		public AcpPasswordEyeBox()
		{
			this.InitializeComponent();
			base.Focusable = true;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0002A130 File Offset: 0x00028330
		private void AcpPasswordEyeBox_LostFocus(object A_0, RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			PasswordBox passwordBox;
			for (;;)
			{
				IL_0A:
				string text;
				switch (num)
				{
				case 0:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)358547458;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_63;
				case 1:
					if (passwordBox != null)
					{
						num2 = (short)939065347;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)429273386;
					short num3 = num2;
					num2 = (short)1553019178;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_162;
					default:
						num2 = (short)1435172864;
						if (num2 != 0)
						{
						}
						text = Utility.FilterArabicDiacritics(text);
						num2 = (short)1365049349;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					text = passwordBox.Password;
					goto IL_162;
				case 4:
					goto IL_BE;
				case 5:
					goto IL_63;
				}
				goto IL_28;
				IL_63:
				passwordBox.Password = text;
				this.PIN = passwordBox.Password;
				this.a = false;
				num2 = (short)1263140865;
				if (num2 != 0)
				{
				}
				num2 = (short)1666646020;
				num = (int)((IntPtr)num2);
				continue;
				IL_162:
				num2 = (short)228851712;
				num = (int)((IntPtr)num2);
			}
			IL_BE:
			num2 = (short)2041446400;
			short num4 = num2;
			return;
			IL_28:
			passwordBox = (A_0 as PasswordBox);
			num2 = (short)1565261825;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0002A2E0 File Offset: 0x000284E0
		private void AcpPasswordEyeBox_OnLoaded(object A_0, RoutedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num3;
				PasswordBox passwordBox;
				for (;;)
				{
					IL_0A:
					num = (short)501874688;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (passwordBox != null)
						{
							num = (short)608501761;
							if (num != 0)
							{
							}
							num = (short)2139619330;
							num3 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_CC;
					case 2:
						passwordBox.Password = this.PIN;
						num = (short)2043084801;
						num3 = (int)((IntPtr)num);
						continue;
					}
					goto IL_45;
				}
				IL_CC:
				num = (short)432542574;
				short num4 = num;
				num = (short)1851790190;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_100;
				}
				IL_45:
				passwordBox = (A_0 as PasswordBox);
				num = (short)992542720;
				num3 = (int)((IntPtr)num);
				goto IL_0A;
			}
			IL_100:
			num = (short)1916010496;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0002A408 File Offset: 0x00028608
		private static void a(DependencyObject A_0, DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1014235137;
			if (num != 0)
			{
			}
			num = (short)1782707145;
			short num2 = num;
			num = (short)634319817;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1184628736;
				if (num != 0)
				{
				}
				num = (short)386334720;
				int num3 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					case 1:
						goto IL_13A;
					case 2:
					{
						AcpPasswordEyeBox acpPasswordEyeBox = (AcpPasswordEyeBox)A_0;
						acpPasswordEyeBox.b.Password = (string)A_1.NewValue;
						acpPasswordEyeBox.c.Text = (string)A_1.NewValue;
						num = (short)1849360384;
						short num4 = num;
						num = (short)805765121;
						num3 = (int)((IntPtr)num);
						continue;
					}
					}
					IL_A4:
					if (!(A_0 is AcpPasswordEyeBox))
					{
						break;
					}
					num = (short)1208549378;
					num3 = (int)((IntPtr)num);
				}
				IL_13A:
				break;
			}
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0002A554 File Offset: 0x00028754
		private void AcpPasswordEyeBox_OnChanged(object A_0, RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			PasswordBox passwordBox;
			short num2;
			for (;;)
			{
				IL_0A:
				string text;
				switch (num)
				{
				case 0:
					if (passwordBox != null)
					{
						num2 = (short)1222574084;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_DC;
				case 2:
				{
					passwordBox.Password = this.PIN;
					num2 = (short)1506279424;
					short num3 = num2;
					num2 = (short)1245380614;
					num = (int)((IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)1503264769;
					if (num2 != 0)
					{
					}
					num2 = (short)1014104071;
					num = (int)((IntPtr)num2);
					continue;
				case 4:
					text = this.PIN;
					num2 = (short)279904265;
					num = (int)((IntPtr)num2);
					continue;
				case 5:
					text = Utility.FilterArabicDiacritics(text);
					num2 = (short)893779969;
					num = (int)((IntPtr)num2);
					continue;
				case 6:
					goto IL_1BD;
				case 7:
					if (!this.a)
					{
						num2 = (short)232521730;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 8:
					if (passwordBox.Password == string.Empty)
					{
						num2 = (short)60489731;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 9:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)2081423365;
						num = (int)((IntPtr)num2);
						continue;
					}
					goto IL_DC;
				}
				goto IL_38;
				IL_DC:
				this.PIN = text;
				num2 = (short)812187656;
				num = (int)((IntPtr)num2);
			}
			IL_1BD:
			num2 = (short)1920938782;
			short num4 = num2;
			num2 = (short)529150750;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)893190144;
				if (num2 != 0)
				{
				}
				break;
			}
			return;
			IL_38:
			passwordBox = (A_0 as PasswordBox);
			num2 = (short)1503199232;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0002A790 File Offset: 0x00028990
		private void btnShowPassword_Click(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)636022582;
			short num2 = num;
			num = (short)683077430;
			switch (num2 == num)
			{
			}
			num = (short)824246273;
			if (num != 0)
			{
			}
			num = (short)1974272000;
			if (num != 0)
			{
			}
			num = (short)521928704;
			short num3 = num;
			this.b.Visibility = Visibility.Collapsed;
			this.c.Visibility = Visibility.Visible;
			this.e.Visibility = Visibility.Collapsed;
			this.f.Visibility = Visibility.Visible;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0002A868 File Offset: 0x00028A68
		private void btnShowPassword_PreviewMouseLeftButtonUp(object A_0, MouseButtonEventArgs A_1)
		{
			short num = (short)329553326;
			short num2 = num;
			num = (short)1897567662;
			switch (num2 == num)
			{
			}
			num = (short)201261057;
			if (num != 0)
			{
			}
			num = (short)1619853312;
			if (num != 0)
			{
			}
			num = (short)889978880;
			short num3 = num;
			this.b.Visibility = Visibility.Visible;
			this.c.Visibility = Visibility.Collapsed;
			this.e.Visibility = Visibility.Visible;
			this.f.Visibility = Visibility.Collapsed;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0002A940 File Offset: 0x00028B40
		private void btnShowPassword_MouseLeave(object A_0, MouseEventArgs A_1)
		{
			short num = (short)1146669319;
			short num2 = num;
			num = (short)39962887;
			switch (num2 == num)
			{
			}
			num = (short)1470234625;
			if (num != 0)
			{
			}
			num = (short)467730432;
			if (num != 0)
			{
			}
			num = (short)152371200;
			short num3 = num;
			this.b.Visibility = Visibility.Visible;
			this.c.Visibility = Visibility.Collapsed;
			this.e.Visibility = Visibility.Visible;
			this.f.Visibility = Visibility.Collapsed;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0002AA1C File Offset: 0x00028C1C
		private void CopyCommand_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				int num3;
				string text;
				for (;;)
				{
					IL_0A:
					num = (short)1516109824;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1118765058;
							num3 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_A1;
					case 2:
						Clipboard.SetText(text);
						num = (short)460849153;
						num3 = (int)((IntPtr)num);
						continue;
					}
					goto IL_46;
				}
				IL_A1:
				num = (short)517545989;
				short num4 = num;
				num = (short)369958917;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_D6;
				}
				IL_46:
				text = this.a();
				num = (short)283836416;
				num3 = (int)((IntPtr)num);
				goto IL_0A;
			}
			IL_D6:
			num = (short)394723328;
			if (num != 0)
			{
			}
			num = (short)29491201;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0002AB40 File Offset: 0x00028D40
		private void CutCommand_Executed(object A_0, ExecutedRoutedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num3;
				string text;
				for (;;)
				{
					IL_0A:
					num = (short)87293952;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)2003894274;
							num3 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_13C;
					case 2:
					{
						Clipboard.SetText(text);
						PresentationSource inputSource = PresentationSource.FromVisual(this.b);
						this.b.RaiseEvent(new KeyEventArgs(Keyboard.PrimaryDevice, inputSource, 0, Key.Delete)
						{
							RoutedEvent = Keyboard.PreviewKeyDownEvent
						});
						this.b.RaiseEvent(new KeyEventArgs(Keyboard.PrimaryDevice, inputSource, 0, Key.Delete)
						{
							RoutedEvent = Keyboard.KeyDownEvent
						});
						this.b.RaiseEvent(new KeyEventArgs(Keyboard.PrimaryDevice, inputSource, 0, Key.Delete)
						{
							RoutedEvent = Keyboard.PreviewKeyUpEvent
						});
						this.b.RaiseEvent(new KeyEventArgs(Keyboard.PrimaryDevice, inputSource, 0, Key.Delete)
						{
							RoutedEvent = Keyboard.KeyUpEvent
						});
						num = (short)779878401;
						num3 = (int)((IntPtr)num);
						continue;
					}
					}
					goto IL_45;
				}
				IL_13C:
				num = (short)1864291533;
				short num4 = num;
				num = (short)804639949;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_171;
				}
				IL_45:
				text = this.a();
				num = (short)1387659264;
				num3 = (int)((IntPtr)num);
				goto IL_0A;
			}
			IL_171:
			num = (short)744816641;
			if (num != 0)
			{
			}
			num = (short)2038235136;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0002ACFC File Offset: 0x00028EFC
		private void CopyCutCommand_CanExecute(object A_0, CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)2102460417;
			if (num != 0)
			{
			}
			num = (short)1048460934;
			short num2 = num;
			num = (short)124599942;
			switch (num2 == num)
			{
			}
			num = (short)2079981568;
			if (num != 0)
			{
			}
			num = (short)1167392768;
			short num3 = num;
			A_1.CanExecute = (this.IsCopyEnabled && !string.IsNullOrEmpty(this.b.Password));
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0002ADCC File Offset: 0x00028FCC
		private string a()
		{
			int a_ = 4;
			short num = (short)1979823344;
			short num2 = num;
			num = (short)636269808;
			switch (num2 == num)
			{
			}
			num = (short)1454112769;
			if (num != 0)
			{
			}
			num = (short)1993867264;
			if (num != 0)
			{
			}
			num = (short)804913152;
			short num3 = num;
			TextSelection textSelection = (TextSelection)typeof(PasswordBox).GetProperty(Utility.c("즙鍊얟송킣쾥잧쒩", a_), BindingFlags.Instance | BindingFlags.NonPublic).GetMethod.Invoke(this.b, null);
			Type type = textSelection.GetType().GetInterfaces().Where(new Func<Type, bool>(AcpPasswordEyeBox.<>c.<>9.a)).FirstOrDefault<Type>();
			object obj = type.GetProperty(Utility.c("즙ﾝ튟횡", a_)).GetMethod.Invoke(textSelection, null);
			object obj2 = type.GetProperty(Utility.c("\udf99瞧", a_)).GetMethod.Invoke(textSelection, null);
			MethodInfo getMethod = obj.GetType().GetProperty(Utility.c("햙瀞펟잡킣", a_), BindingFlags.Instance | BindingFlags.NonPublic).GetMethod;
			int num4 = (int)getMethod.Invoke(obj, null);
			int num5 = (int)getMethod.Invoke(obj2, null);
			return this.b.Password.Substring(num4, num5 - num4);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0002B2D8 File Offset: 0x000294D8
		// Note: this type is marked as 'beforefieldinit'.
		static AcpPasswordEyeBox()
		{
			int a_ = 15;
			short num = (short)1335585492;
			short num2 = num;
			num = (short)1649502932;
			switch (num2 == num)
			{
			}
			num = (short)657784832;
			short num3 = num;
			num = (short)991625216;
			if (num != 0)
			{
			}
			num = (short)1572274177;
			if (num != 0)
			{
			}
			AcpPasswordEyeBox.IsEyeVisibleProperty = DependencyProperty.Register(Utility.c("풦튪좬瑩\ud8b0삲\udcb4햶햸\udeba", a_), typeof(int), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(1, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpPasswordEyeBox.IsCopyEnabledProperty = DependencyProperty.Register(Utility.c("풦쒪\uddac횮\uddb2풴햶햸\udeba\ud9bc", a_), typeof(bool), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpPasswordEyeBox.IsAcpValidProperty = DependencyProperty.RegisterAttached(Utility.c("풦좪\uddac瑩킰\udfb2\udcb4펶", a_), typeof(bool), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpPasswordEyeBox.IsAcpApplicableProperty = DependencyProperty.Register(Utility.c("풦좪\uddac솰쎲\ud9b4\udeb6\udab8\udaba\udfbc펾꓀", a_), typeof(bool), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpPasswordEyeBox.IsAcpEditableProperty = DependencyProperty.Register(Utility.c("풦좪\uddac햰\udab2솴횶\udbb8ힺ\ud8bc", a_), typeof(bool), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpPasswordEyeBox.IsAcpVisibleProperty = DependencyProperty.Register(Utility.c("풦좪\uddac瑩\ud8b0삲\udcb4햶햸\udeba", a_), typeof(bool), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpPasswordEyeBox.MyLabelCtrlProperty = DependencyProperty.RegisterAttached(Utility.c("\udea6쪪쾬쪮\uddb0솴얶햸", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordEyeBox.MyCopyButtonProperty = DependencyProperty.RegisterAttached(Utility.c("\udea6쒪\uddac횮욲솴쎶횸햺ﺼ쮾돀꿂", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordEyeBox.MyBLObjectProperty = DependencyProperty.RegisterAttached(Utility.c("\udea6춮\udbb0횲횴쎶", a_), typeof(AcpFieldBase), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordEyeBox.AreValuesEqualProperty = DependencyProperty.Register(Utility.c("햦첨ﶪ첬쎮쒰횲운좸캺\udcbc펾", a_), typeof(bool), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordEyeBox.MyExpanderProperty = DependencyProperty.RegisterAttached(Utility.c("\udea6펪\uddac캮\udfb0ힲ킴얶", a_), typeof(Expander), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordEyeBox.MyParentCtrlProperty = DependencyProperty.RegisterAttached(Utility.c("\udea6令쪪\udfac쪮\udfb0잲쎶쮸ힺ", a_), typeof(IAcpUIParentCtrlBase), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordEyeBox.IsDigitOnlyProperty = DependencyProperty.Register(Utility.c("풦슪쪬욮얰ﲲ\udbb4\udbb6삸", a_), typeof(bool), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpPasswordEyeBox.MaxPasswordLengthProperty = DependencyProperty.Register(Utility.c("욦톨ﮪ첬\udcae슰쒲\udab4얶\uddb8\ud8bc톾ꛀ럂귄", a_), typeof(int), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpPasswordEyeBox.PINProperty = DependencyProperty.Register(Utility.c("", a_), typeof(string), typeof(AcpPasswordEyeBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(AcpPasswordEyeBox.a)));
		}

		// Token: 0x04000189 RID: 393
		public static readonly DependencyProperty IsEyeVisibleProperty;

		// Token: 0x0400018A RID: 394
		public static readonly DependencyProperty IsCopyEnabledProperty;

		// Token: 0x0400018B RID: 395
		public static readonly DependencyProperty IsAcpValidProperty;

		// Token: 0x0400018C RID: 396
		public static readonly DependencyProperty IsAcpApplicableProperty;

		// Token: 0x0400018D RID: 397
		public static readonly DependencyProperty IsAcpEditableProperty;

		// Token: 0x0400018E RID: 398
		public static readonly DependencyProperty IsAcpVisibleProperty;

		// Token: 0x0400018F RID: 399
		public static readonly DependencyProperty MyLabelCtrlProperty;

		// Token: 0x04000190 RID: 400
		public static readonly DependencyProperty MyCopyButtonProperty;

		// Token: 0x04000191 RID: 401
		public static readonly DependencyProperty MyBLObjectProperty;

		// Token: 0x04000192 RID: 402
		public static readonly DependencyProperty AreValuesEqualProperty;

		// Token: 0x04000193 RID: 403
		public static readonly DependencyProperty MyExpanderProperty;

		// Token: 0x04000194 RID: 404
		public static readonly DependencyProperty MyParentCtrlProperty;

		// Token: 0x04000195 RID: 405
		public static readonly DependencyProperty IsDigitOnlyProperty;

		// Token: 0x04000196 RID: 406
		private bool a;

		// Token: 0x04000197 RID: 407
		public static readonly DependencyProperty MaxPasswordLengthProperty;

		// Token: 0x04000198 RID: 408
		public static readonly DependencyProperty PINProperty;
	}
}
