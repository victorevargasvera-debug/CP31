using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Shapes;
using AcpBusinessLayer;
using AcpUI;
using AcpUI.Common;
using ControlHeadGraphicView.converters;

namespace ControlHeadGraphicView
{
	// Token: 0x02000006 RID: 6
	public partial class KeypadGraphicView : UserControl
	{
		// Token: 0x060004DF RID: 1247 RVA: 0x000458A0 File Offset: 0x00043AA0
		public KeypadGraphicView()
		{
			base.FlowDirection = FlowDirection.LeftToRight;
			this.InitializeComponent();
			base.DataContext = this;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000458C8 File Offset: 0x00043AC8
		private void OnFieldNameDoubleClick(object sender, RoutedEventArgs e)
		{
			short num = (short)1141902947;
			short num2 = num;
			num = (short)1789791843;
			switch (num2 == num)
			{
			}
			num = (short)625999873;
			if (num != 0)
			{
			}
			num = (short)479395840;
			if (num != 0)
			{
			}
			num = (short)183369728;
			short num3 = num;
			Utility.GetFieldHelpText(sender);
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00045978 File Offset: 0x00043B78
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00045A30 File Offset: 0x00043C30
		public bool DialPad0ButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)535183337;
				short num2 = num;
				num = (short)1773748201;
				switch (num2 == num)
				{
				}
				num = (short)1710161920;
				if (num != 0)
				{
				}
				num = (short)1780547585;
				if (num != 0)
				{
				}
				num = (short)1719402496;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPad0ButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1973420033;
				if (num != 0)
				{
				}
				num = (short)630998260;
				short num2 = num;
				num = (short)1575699700;
				switch (num2 == num)
				{
				}
				num = (short)1619001344;
				if (num != 0)
				{
				}
				num = (short)1227882496;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPad0ButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00045AEC File Offset: 0x00043CEC
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00045BA4 File Offset: 0x00043DA4
		public bool DialPad0ButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1784678175;
				short num2 = num;
				num = (short)1695942431;
				switch (num2 == num)
				{
				}
				num = (short)1907556353;
				if (num != 0)
				{
				}
				num = (short)209256448;
				if (num != 0)
				{
				}
				num = (short)1786052608;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPad0ButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1006067138;
				short num2 = num;
				num = (short)2079677890;
				switch (num2 == num)
				{
				}
				num = (short)1003487233;
				if (num != 0)
				{
				}
				num = (short)1472593920;
				if (num != 0)
				{
				}
				num = (short)1344798720;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPad0ButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00045C60 File Offset: 0x00043E60
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00045D1C File Offset: 0x00043F1C
		public bool DialPad0ButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)39124993;
				if (num != 0)
				{
				}
				num = (short)1324263837;
				short num2 = num;
				num = (short)1553574301;
				switch (num2 == num)
				{
				}
				num = (short)1638727680;
				if (num != 0)
				{
				}
				num = (short)2752512;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPad0ButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1108342788;
				short num2 = num;
				num = (short)1263073284;
				switch (num2 == num)
				{
				}
				num = (short)1333002241;
				if (num != 0)
				{
				}
				num = (short)1075838976;
				if (num != 0)
				{
				}
				num = (short)512884736;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPad0ButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00045DD8 File Offset: 0x00043FD8
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00045E90 File Offset: 0x00044090
		public bool DialPad0ButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)122290177;
				if (num != 0)
				{
				}
				num = (short)122849566;
				short num2 = num;
				num = (short)1202620702;
				switch (num2 == num)
				{
				}
				num = (short)1185611776;
				if (num != 0)
				{
				}
				num = (short)1305739264;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPad0ButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)30460953;
				short num2 = num;
				num = (short)552520729;
				switch (num2 == num)
				{
				}
				num = (short)1882193921;
				if (num != 0)
				{
				}
				num = (short)529727488;
				if (num != 0)
				{
				}
				num = (short)1041891328;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPad0ButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00045F4C File Offset: 0x0004414C
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00046008 File Offset: 0x00044208
		public string DialPad0ButtonFeatureUIValue
		{
			get
			{
				short num = (short)1224892723;
				short num2 = num;
				num = (short)169435443;
				switch (num2 == num)
				{
				}
				num = (short)304873473;
				if (num != 0)
				{
				}
				num = (short)2073952256;
				if (num != 0)
				{
				}
				num = (short)1900609536;
				short num3 = num;
				return (string)base.GetValue(KeypadGraphicView.DialPad0ButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1285297275;
				short num2 = num;
				num = (short)1457067131;
				switch (num2 == num)
				{
				}
				num = (short)603914241;
				if (num != 0)
				{
				}
				num = (short)478806016;
				if (num != 0)
				{
				}
				num = (short)335347712;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPad0ButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x000460BC File Offset: 0x000442BC
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00046178 File Offset: 0x00044378
		public AcpListField DialPad0ButtonFeatureList
		{
			get
			{
				short num = (short)1265649200;
				short num2 = num;
				num = (short)210847280;
				switch (num2 == num)
				{
				}
				num = (short)1309868033;
				if (num != 0)
				{
				}
				num = (short)1900740608;
				if (num != 0)
				{
				}
				num = (short)22609920;
				short num3 = num;
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad0ButtonFeatureListProperty);
			}
			set
			{
				short num = (short)646388850;
				short num2 = num;
				num = (short)34282610;
				switch (num2 == num)
				{
				}
				num = (short)2019033088;
				if (num != 0)
				{
				}
				num = (short)1337196545;
				if (num != 0)
				{
				}
				num = (short)1837891584;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPad0ButtonFeatureListProperty, value);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0004622C File Offset: 0x0004442C
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x000462E4 File Offset: 0x000444E4
		public bool DialPad0ButtonIndexIsAcpValid
		{
			get
			{
				short num = (short)1129615900;
				short num2 = num;
				num = (short)1194955292;
				switch (num2 == num)
				{
				}
				num = (short)912130048;
				if (num != 0)
				{
				}
				num = (short)266993665;
				if (num != 0)
				{
				}
				num = (short)71106560;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPad0ButtonIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)739269371;
				short num2 = num;
				num = (short)307256059;
				switch (num2 == num)
				{
				}
				num = (short)1792606209;
				if (num != 0)
				{
				}
				num = (short)395575296;
				if (num != 0)
				{
				}
				num = (short)1033699328;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPad0ButtonIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x000463A0 File Offset: 0x000445A0
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00046458 File Offset: 0x00044658
		public bool DialPad0ButtonIndexIsAcpApplicable
		{
			get
			{
				short num = (short)989265921;
				if (num != 0)
				{
				}
				num = (short)1928538501;
				short num2 = num;
				num = (short)1052912005;
				switch (num2 == num)
				{
				}
				num = (short)1660616704;
				if (num != 0)
				{
				}
				num = (short)1030225920;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPad0ButtonIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1727776818;
				short num2 = num;
				num = (short)9816114;
				switch (num2 == num)
				{
				}
				num = (short)2018508800;
				if (num != 0)
				{
				}
				num = (short)980353025;
				if (num != 0)
				{
				}
				num = (short)343408640;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPad0ButtonIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00046510 File Offset: 0x00044710
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x000465C8 File Offset: 0x000447C8
		public bool DialPad0ButtonIndexIsAcpVisible
		{
			get
			{
				short num = (short)1896480768;
				short num2 = num;
				num = (short)1459876443;
				short num3 = num;
				num = (short)1927410267;
				switch (num3 == num)
				{
				}
				num = (short)1461911553;
				if (num != 0)
				{
				}
				num = (short)897777664;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad0ButtonIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)337051648;
				short num2 = num;
				num = (short)1572449123;
				short num3 = num;
				num = (short)705080163;
				switch (num3 == num)
				{
				}
				num = (short)1118896129;
				if (num != 0)
				{
				}
				num = (short)1912340480;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad0ButtonIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00046684 File Offset: 0x00044884
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00046740 File Offset: 0x00044940
		public bool DialPad0ButtonIndexIsAcpEditable
		{
			get
			{
				short num = (short)1314848768;
				short num2 = num;
				num = (short)388956161;
				if (num != 0)
				{
				}
				num = (short)411713781;
				short num3 = num;
				num = (short)1947353333;
				switch (num3 == num)
				{
				}
				num = (short)1122631680;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad0ButtonIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1062600704;
				short num2 = num;
				num = (short)291519336;
				short num3 = num;
				num = (short)1070873448;
				switch (num3 == num)
				{
				}
				num = (short)285343745;
				if (num != 0)
				{
				}
				num = (short)2076639232;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad0ButtonIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x000467F8 File Offset: 0x000449F8
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x000468B4 File Offset: 0x00044AB4
		public string DialPad0ButtonIndexUIValue
		{
			get
			{
				short num = (short)1848180736;
				short num2 = num;
				num = (short)1616516083;
				short num3 = num;
				num = (short)411440115;
				switch (num3 == num)
				{
				}
				num = (short)2068578304;
				if (num != 0)
				{
				}
				num = (short)158990337;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad0ButtonIndexUIValueProperty);
			}
			set
			{
				short num = (short)1252917248;
				short num2 = num;
				num = (short)710954787;
				short num3 = num;
				num = (short)302337827;
				switch (num3 == num)
				{
				}
				num = (short)1692925952;
				if (num != 0)
				{
				}
				num = (short)345505793;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad0ButtonIndexUIValueProperty, value);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00046968 File Offset: 0x00044B68
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00046A24 File Offset: 0x00044C24
		public AcpListField DialPad0ButtonIndexList
		{
			get
			{
				short num = (short)1955069952;
				short num2 = num;
				num = (short)382490303;
				short num3 = num;
				num = (short)285693631;
				switch (num3 == num)
				{
				}
				num = (short)1933312001;
				if (num != 0)
				{
				}
				num = (short)1322516480;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad0ButtonIndexListProperty);
			}
			set
			{
				short num = (short)1455423488;
				short num2 = num;
				num = (short)1852179052;
				short num3 = num;
				num = (short)24183404;
				switch (num3 == num)
				{
				}
				num = (short)1917321217;
				if (num != 0)
				{
				}
				num = (short)793051136;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad0ButtonIndexListProperty, value);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00046AD8 File Offset: 0x00044CD8
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00046B94 File Offset: 0x00044D94
		public bool DialPad1ButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)904724480;
				short num2 = num;
				num = (short)1395857323;
				short num3 = num;
				num = (short)1782847403;
				switch (num3 == num)
				{
				}
				num = (short)1033830401;
				if (num != 0)
				{
				}
				num = (short)1546256384;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad1ButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1984888832;
				short num2 = num;
				num = (short)997419896;
				short num3 = num;
				num = (short)2007853944;
				switch (num3 == num)
				{
				}
				num = (short)1076625408;
				if (num != 0)
				{
				}
				num = (short)505610241;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad1ButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00046C50 File Offset: 0x00044E50
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00046D08 File Offset: 0x00044F08
		public bool DialPad1ButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)163446784;
				short num2 = num;
				num = (short)1989455863;
				short num3 = num;
				num = (short)1626779639;
				switch (num3 == num)
				{
				}
				num = (short)341508097;
				if (num != 0)
				{
				}
				num = (short)1744961536;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad1ButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)694288384;
				short num2 = num;
				num = (short)527175749;
				short num3 = num;
				num = (short)1467813957;
				switch (num3 == num)
				{
				}
				num = (short)185139201;
				if (num != 0)
				{
				}
				num = (short)1166082048;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad1ButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00046DC4 File Offset: 0x00044FC4
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00046E7C File Offset: 0x0004507C
		public bool DialPad1ButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)653197312;
				short num2 = num;
				num = (short)1654259713;
				if (num != 0)
				{
				}
				num = (short)1192766009;
				short num3 = num;
				num = (short)1381444153;
				switch (num3 == num)
				{
				}
				num = (short)2114584576;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad1ButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1710030848;
				short num2 = num;
				num = (short)1728424216;
				short num3 = num;
				num = (short)1298114840;
				switch (num3 == num)
				{
				}
				num = (short)1834024961;
				if (num != 0)
				{
				}
				num = (short)1096876032;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad1ButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00046F38 File Offset: 0x00045138
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00046FF0 File Offset: 0x000451F0
		public bool DialPad1ButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1026424832;
				short num2 = num;
				num = (short)537919489;
				if (num != 0)
				{
				}
				num = (short)452384124;
				short num3 = num;
				num = (short)434951548;
				switch (num3 == num)
				{
				}
				num = (short)1227096064;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad1ButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1803616256;
				short num2 = num;
				num = (short)982018496;
				short num3 = num;
				num = (short)117926336;
				switch (num3 == num)
				{
				}
				num = (short)669908992;
				if (num != 0)
				{
				}
				num = (short)1198653441;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad1ButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x000470AC File Offset: 0x000452AC
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00047164 File Offset: 0x00045364
		public string DialPad1ButtonFeatureUIValue
		{
			get
			{
				short num = (short)1112735744;
				short num2 = num;
				num = (short)1293011949;
				short num3 = num;
				num = (short)1796656109;
				switch (num3 == num)
				{
				}
				num = (short)544669696;
				if (num != 0)
				{
				}
				num = (short)15204353;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad1ButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1782185984;
				short num2 = num;
				num = (short)445417123;
				short num3 = num;
				num = (short)297502371;
				switch (num3 == num)
				{
				}
				num = (short)1146028033;
				if (num != 0)
				{
				}
				num = (short)1820459008;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad1ButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00047218 File Offset: 0x00045418
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x000472D0 File Offset: 0x000454D0
		public AcpListField DialPad1ButtonFeatureList
		{
			get
			{
				short num = (short)1644363776;
				short num2 = num;
				num = (short)824311809;
				if (num != 0)
				{
				}
				num = (short)629363420;
				short num3 = num;
				num = (short)1087984348;
				switch (num3 == num)
				{
				}
				num = (short)1216806912;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad1ButtonFeatureListProperty);
			}
			set
			{
				short num = (short)1026490368;
				short num2 = num;
				num = (short)802095105;
				if (num != 0)
				{
				}
				num = (short)1105986641;
				short num3 = num;
				num = (short)1758069841;
				switch (num3 == num)
				{
				}
				num = (short)132644864;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad1ButtonFeatureListProperty, value);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00047384 File Offset: 0x00045584
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x0004743C File Offset: 0x0004563C
		public bool DialPad1ButtonIndexIsAcpValid
		{
			get
			{
				short num = (short)260833280;
				short num2 = num;
				num = (short)61493930;
				short num3 = num;
				num = (short)1563513514;
				switch (num3 == num)
				{
				}
				num = (short)1400766464;
				if (num != 0)
				{
				}
				num = (short)1310457857;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad1ButtonIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)795738112;
				short num2 = num;
				num = (short)895622000;
				short num3 = num;
				num = (short)822549360;
				switch (num3 == num)
				{
				}
				num = (short)68222976;
				if (num != 0)
				{
				}
				num = (short)1687158785;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad1ButtonIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x000474F4 File Offset: 0x000456F4
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x000475AC File Offset: 0x000457AC
		public bool DialPad1ButtonIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1321926656;
				short num2 = num;
				num = (short)1381948955;
				short num3 = num;
				num = (short)298901019;
				switch (num3 == num)
				{
				}
				num = (short)203358209;
				if (num != 0)
				{
				}
				num = (short)254607360;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad1ButtonIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1265893376;
				short num2 = num;
				num = (short)518651905;
				if (num != 0)
				{
				}
				num = (short)1221761517;
				short num3 = num;
				num = (short)731617773;
				switch (num3 == num)
				{
				}
				num = (short)838926336;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad1ButtonIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00047668 File Offset: 0x00045868
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00047720 File Offset: 0x00045920
		public bool DialPad1ButtonIndexIsAcpVisible
		{
			get
			{
				short num = (short)1884553216;
				short num2 = num;
				num = (short)267764940;
				short num3 = num;
				num = (short)123520204;
				switch (num3 == num)
				{
				}
				num = (short)694681601;
				if (num != 0)
				{
				}
				num = (short)214499328;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad1ButtonIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1768620032;
				short num2 = num;
				num = (short)215484967;
				short num3 = num;
				num = (short)1240205863;
				switch (num3 == num)
				{
				}
				num = (short)520093696;
				if (num != 0)
				{
				}
				num = (short)74055681;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad1ButtonIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x000477DC File Offset: 0x000459DC
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00047898 File Offset: 0x00045A98
		public bool DialPad1ButtonIndexIsAcpEditable
		{
			get
			{
				short num = (short)1431896064;
				short num2 = num;
				num = (short)2123450474;
				short num3 = num;
				num = (short)228673642;
				switch (num3 == num)
				{
				}
				num = (short)89653249;
				if (num != 0)
				{
				}
				num = (short)526188544;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad1ButtonIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1149501440;
				short num2 = num;
				num = (short)451647038;
				short num3 = num;
				num = (short)674731582;
				switch (num3 == num)
				{
				}
				num = (short)1024720896;
				if (num != 0)
				{
				}
				num = (short)540147713;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad1ButtonIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00047954 File Offset: 0x00045B54
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00047A10 File Offset: 0x00045C10
		public string DialPad1ButtonIndexUIValue
		{
			get
			{
				short num = (short)1924071424;
				short num2 = num;
				num = (short)1122158781;
				short num3 = num;
				num = (short)1296484541;
				switch (num3 == num)
				{
				}
				num = (short)1402339328;
				if (num != 0)
				{
				}
				num = (short)879558657;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad1ButtonIndexUIValueProperty);
			}
			set
			{
				short num = (short)334495744;
				short num2 = num;
				num = (short)1118569298;
				short num3 = num;
				num = (short)2027160402;
				switch (num3 == num)
				{
				}
				num = (short)1214578688;
				if (num != 0)
				{
				}
				num = (short)213450753;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad1ButtonIndexUIValueProperty, value);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00047ACC File Offset: 0x00045CCC
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00047B88 File Offset: 0x00045D88
		public AcpListField DialPad1ButtonIndexList
		{
			get
			{
				short num = (short)350945280;
				short num2 = num;
				num = (short)756834086;
				short num3 = num;
				num = (short)1633312550;
				switch (num3 == num)
				{
				}
				num = (short)168493057;
				if (num != 0)
				{
				}
				num = (short)1762197504;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad1ButtonIndexListProperty);
			}
			set
			{
				short num = (short)196018176;
				short num2 = num;
				num = (short)2064002439;
				short num3 = num;
				num = (short)1781476743;
				switch (num3 == num)
				{
				}
				num = (short)2062680065;
				if (num != 0)
				{
				}
				num = (short)1215037440;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad1ButtonIndexListProperty, value);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00047C3C File Offset: 0x00045E3C
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00047CF8 File Offset: 0x00045EF8
		public bool DialPad2ButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)350748672;
				short num2 = num;
				num = (short)1557928891;
				short num3 = num;
				num = (short)1338973115;
				switch (num3 == num)
				{
				}
				num = (short)1400045569;
				if (num != 0)
				{
				}
				num = (short)271712256;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad2ButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)236716032;
				short num2 = num;
				num = (short)1826011793;
				short num3 = num;
				num = (short)654031505;
				switch (num3 == num)
				{
				}
				num = (short)210894849;
				if (num != 0)
				{
				}
				num = (short)1152581632;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad2ButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00047DB4 File Offset: 0x00045FB4
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00047E70 File Offset: 0x00046070
		public bool DialPad2ButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1024917504;
				short num2 = num;
				num = (short)1609291433;
				short num3 = num;
				num = (short)1052038825;
				switch (num3 == num)
				{
				}
				num = (short)749207552;
				if (num != 0)
				{
				}
				num = (short)301793281;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad2ButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)314310656;
				short num2 = num;
				num = (short)1202192385;
				if (num != 0)
				{
				}
				num = (short)1331521644;
				short num3 = num;
				num = (short)20080748;
				switch (num3 == num)
				{
				}
				num = (short)982056960;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad2ButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00047F28 File Offset: 0x00046128
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00047FE4 File Offset: 0x000461E4
		public bool DialPad2ButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)619053056;
				short num2 = num;
				num = (short)301529810;
				short num3 = num;
				num = (short)591395538;
				switch (num3 == num)
				{
				}
				num = (short)1418788865;
				if (num != 0)
				{
				}
				num = (short)754122752;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad2ButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)207814656;
				short num2 = num;
				num = (short)693132930;
				short num3 = num;
				num = (short)1003970178;
				switch (num3 == num)
				{
				}
				num = (short)1533149185;
				if (num != 0)
				{
				}
				num = (short)1949433856;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad2ButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x000480A4 File Offset: 0x000462A4
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00048160 File Offset: 0x00046360
		public bool DialPad2ButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1003487232;
				short num2 = num;
				num = (short)1875180144;
				short num3 = num;
				num = (short)1507654256;
				switch (num3 == num)
				{
				}
				num = (short)117374976;
				if (num != 0)
				{
				}
				num = (short)284950529;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad2ButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1444085760;
				short num2 = num;
				num = (short)325451777;
				if (num != 0)
				{
				}
				num = (short)1973940421;
				short num3 = num;
				num = (short)1160573125;
				switch (num3 == num)
				{
				}
				num = (short)938082304;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad2ButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0004821C File Offset: 0x0004641C
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x000482D8 File Offset: 0x000464D8
		public string DialPad2ButtonFeatureUIValue
		{
			get
			{
				short num = (short)721682432;
				short num2 = num;
				num = (short)1301933620;
				short num3 = num;
				num = (short)526249524;
				switch (num3 == num)
				{
				}
				num = (short)1560281089;
				if (num != 0)
				{
				}
				num = (short)533069824;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad2ButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)187564032;
				short num2 = num;
				num = (short)930676737;
				if (num != 0)
				{
				}
				num = (short)1143407795;
				short num3 = num;
				num = (short)117900467;
				switch (num3 == num)
				{
				}
				num = (short)580780032;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad2ButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0004838C File Offset: 0x0004658C
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00048444 File Offset: 0x00046644
		public AcpListField DialPad2ButtonFeatureList
		{
			get
			{
				short num = (short)188284928;
				short num2 = num;
				num = (short)1242318358;
				short num3 = num;
				num = (short)1157711382;
				switch (num3 == num)
				{
				}
				num = (short)1935736832;
				if (num != 0)
				{
				}
				num = (short)1748828161;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad2ButtonFeatureListProperty);
			}
			set
			{
				short num = (short)485031936;
				short num2 = num;
				num = (short)723976193;
				if (num != 0)
				{
				}
				num = (short)413351461;
				short num3 = num;
				num = (short)1890008613;
				switch (num3 == num)
				{
				}
				num = (short)624885760;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad2ButtonFeatureListProperty, value);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x000484FC File Offset: 0x000466FC
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x000485B8 File Offset: 0x000467B8
		public bool DialPad2ButtonIndexIsAcpValid
		{
			get
			{
				short num = (short)1217658880;
				short num2 = num;
				num = (short)974014476;
				short num3 = num;
				num = (short)1172981772;
				switch (num3 == num)
				{
				}
				num = (short)1120731136;
				if (num != 0)
				{
				}
				num = (short)140050433;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad2ButtonIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)159580160;
				short num2 = num;
				num = (short)1450277080;
				short num3 = num;
				num = (short)822704344;
				switch (num3 == num)
				{
				}
				num = (short)1517027329;
				if (num != 0)
				{
				}
				num = (short)391774208;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad2ButtonIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00048674 File Offset: 0x00046874
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00048730 File Offset: 0x00046930
		public bool DialPad2ButtonIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1832648704;
				short num2 = num;
				num = (short)1824170464;
				short num3 = num;
				num = (short)1587192288;
				switch (num3 == num)
				{
				}
				num = (short)1236336641;
				if (num != 0)
				{
				}
				num = (short)1999962112;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad2ButtonIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1136328704;
				short num2 = num;
				num = (short)1133557786;
				short num3 = num;
				num = (short)475445274;
				switch (num3 == num)
				{
				}
				num = (short)675872768;
				if (num != 0)
				{
				}
				num = (short)60620801;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad2ButtonIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x000487EC File Offset: 0x000469EC
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x000488A8 File Offset: 0x00046AA8
		public bool DialPad2ButtonIndexIsAcpVisible
		{
			get
			{
				short num = (short)130482176;
				short num2 = num;
				num = (short)1734557439;
				short num3 = num;
				num = (short)1682063103;
				switch (num3 == num)
				{
				}
				num = (short)854261761;
				if (num != 0)
				{
				}
				num = (short)37683200;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad2ButtonIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2060386304;
				short num2 = num;
				num = (short)955636848;
				short num3 = num;
				num = (short)923720816;
				switch (num3 == num)
				{
				}
				num = (short)695861249;
				if (num != 0)
				{
				}
				num = (short)1911488512;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad2ButtonIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00048964 File Offset: 0x00046B64
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00048A20 File Offset: 0x00046C20
		public bool DialPad2ButtonIndexIsAcpEditable
		{
			get
			{
				short num = (short)2032664576;
				short num2 = num;
				num = (short)129433601;
				if (num != 0)
				{
				}
				num = (short)312037508;
				short num3 = num;
				num = (short)742412420;
				switch (num3 == num)
				{
				}
				num = (short)1361117184;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad2ButtonIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1249771520;
				short num2 = num;
				num = (short)2122910584;
				short num3 = num;
				num = (short)1547832184;
				switch (num3 == num)
				{
				}
				num = (short)38731777;
				if (num != 0)
				{
				}
				num = (short)1989214208;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad2ButtonIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00048ADC File Offset: 0x00046CDC
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00048B98 File Offset: 0x00046D98
		public string DialPad2ButtonIndexUIValue
		{
			get
			{
				short num = (short)712638464;
				short num2 = num;
				num = (short)1253640222;
				short num3 = num;
				num = (short)1914439710;
				switch (num3 == num)
				{
				}
				num = (short)1805582337;
				if (num != 0)
				{
				}
				num = (short)150863872;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad2ButtonIndexUIValueProperty);
			}
			set
			{
				short num = (short)1980366848;
				short num2 = num;
				num = (short)496631809;
				if (num != 0)
				{
				}
				num = (short)1111106867;
				short num3 = num;
				num = (short)1839473971;
				switch (num3 == num)
				{
				}
				num = (short)147128320;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad2ButtonIndexUIValueProperty, value);
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00048C50 File Offset: 0x00046E50
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00048D0C File Offset: 0x00046F0C
		public AcpListField DialPad2ButtonIndexList
		{
			get
			{
				short num = (short)1014562816;
				short num2 = num;
				num = (short)1652585864;
				short num3 = num;
				num = (short)444691848;
				switch (num3 == num)
				{
				}
				num = (short)409272321;
				if (num != 0)
				{
				}
				num = (short)1492451328;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad2ButtonIndexListProperty);
			}
			set
			{
				short num = (short)936771584;
				short num2 = num;
				num = (short)1861277418;
				short num3 = num;
				num = (short)1462097642;
				switch (num3 == num)
				{
				}
				num = (short)1311965185;
				if (num != 0)
				{
				}
				num = (short)533987328;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad2ButtonIndexListProperty, value);
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00048DC4 File Offset: 0x00046FC4
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00048E7C File Offset: 0x0004707C
		public bool DialPad3ButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)752418816;
				short num2 = num;
				num = (short)1747307848;
				short num3 = num;
				num = (short)621989192;
				switch (num3 == num)
				{
				}
				num = (short)1190658049;
				if (num != 0)
				{
				}
				num = (short)732299264;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad3ButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1475936256;
				short num2 = num;
				num = (short)803733505;
				if (num != 0)
				{
				}
				num = (short)1898555143;
				short num3 = num;
				num = (short)1852811015;
				switch (num3 == num)
				{
				}
				num = (short)1851326464;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad3ButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00048F38 File Offset: 0x00047138
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00048FF0 File Offset: 0x000471F0
		public bool DialPad3ButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)47972352;
				short num2 = num;
				num = (short)1097758364;
				short num3 = num;
				num = (short)1712682652;
				switch (num3 == num)
				{
				}
				num = (short)590675968;
				if (num != 0)
				{
				}
				num = (short)1292173313;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad3ButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1523253248;
				short num2 = num;
				num = (short)691145163;
				short num3 = num;
				num = (short)163121611;
				switch (num3 == num)
				{
				}
				num = (short)1502937088;
				if (num != 0)
				{
				}
				num = (short)7077889;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad3ButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x000490AC File Offset: 0x000472AC
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00049168 File Offset: 0x00047368
		public bool DialPad3ButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)651362304;
				short num2 = num;
				num = (short)1142884025;
				short num3 = num;
				num = (short)619251385;
				switch (num3 == num)
				{
				}
				num = (short)574226433;
				if (num != 0)
				{
				}
				num = (short)1891696640;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad3ButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)98893824;
				short num2 = num;
				num = (short)1933295745;
				short num3 = num;
				num = (short)1579663489;
				switch (num3 == num)
				{
				}
				num = (short)643694593;
				if (num != 0)
				{
				}
				num = (short)1208680448;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad3ButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00049224 File Offset: 0x00047424
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x000492DC File Offset: 0x000474DC
		public bool DialPad3ButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)48627712;
				short num2 = num;
				num = (short)938490286;
				short num3 = num;
				num = (short)579615150;
				switch (num3 == num)
				{
				}
				num = (short)745144321;
				if (num != 0)
				{
				}
				num = (short)1682833408;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad3ButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1214316544;
				short num2 = num;
				num = (short)1537086552;
				short num3 = num;
				num = (short)906368088;
				switch (num3 == num)
				{
				}
				num = (short)1795096577;
				if (num != 0)
				{
				}
				num = (short)914161664;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad3ButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00049394 File Offset: 0x00047594
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x0004944C File Offset: 0x0004764C
		public string DialPad3ButtonFeatureUIValue
		{
			get
			{
				short num = (short)211943424;
				short num2 = num;
				num = (short)477170769;
				short num3 = num;
				num = (short)662441041;
				switch (num3 == num)
				{
				}
				num = (short)162856961;
				if (num != 0)
				{
				}
				num = (short)728760320;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad3ButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)635830272;
				short num2 = num;
				num = (short)478216193;
				if (num != 0)
				{
				}
				num = (short)730825328;
				short num3 = num;
				num = (short)215450224;
				switch (num3 == num)
				{
				}
				num = (short)2144600064;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad3ButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00049504 File Offset: 0x00047704
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x000495C0 File Offset: 0x000477C0
		public AcpListField DialPad3ButtonFeatureList
		{
			get
			{
				short num = (short)272367616;
				short num2 = num;
				num = (short)34665609;
				short num3 = num;
				num = (short)1882518665;
				switch (num3 == num)
				{
				}
				num = (short)1466892289;
				if (num != 0)
				{
				}
				num = (short)1053097984;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad3ButtonFeatureListProperty);
			}
			set
			{
				short num = (short)1644101632;
				short num2 = num;
				num = (short)1340764071;
				short num3 = num;
				num = (short)1303867303;
				switch (num3 == num)
				{
				}
				num = (short)1662124032;
				if (num != 0)
				{
				}
				num = (short)2129330177;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad3ButtonFeatureListProperty, value);
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00049674 File Offset: 0x00047874
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x0004972C File Offset: 0x0004792C
		public bool DialPad3ButtonIndexIsAcpValid
		{
			get
			{
				short num = (short)1101201408;
				short num2 = num;
				num = (short)1642975855;
				short num3 = num;
				num = (short)1580520047;
				switch (num3 == num)
				{
				}
				num = (short)1151926273;
				if (num != 0)
				{
				}
				num = (short)719978496;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad3ButtonIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)433061888;
				short num2 = num;
				num = (short)663973135;
				short num3 = num;
				num = (short)542993679;
				switch (num3 == num)
				{
				}
				num = (short)523173888;
				if (num != 0)
				{
				}
				num = (short)942342145;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad3ButtonIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x000497E8 File Offset: 0x000479E8
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x000498A4 File Offset: 0x00047AA4
		public bool DialPad3ButtonIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1040449536;
				short num2 = num;
				num = (short)269643501;
				short num3 = num;
				num = (short)812543725;
				switch (num3 == num)
				{
				}
				num = (short)735051777;
				if (num != 0)
				{
				}
				num = (short)545718272;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad3ButtonIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1372454912;
				short num2 = num;
				num = (short)1949396331;
				short num3 = num;
				num = (short)1369140587;
				switch (num3 == num)
				{
				}
				num = (short)1435631617;
				if (num != 0)
				{
				}
				num = (short)1442643968;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad3ButtonIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00049960 File Offset: 0x00047B60
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00049A1C File Offset: 0x00047C1C
		public bool DialPad3ButtonIndexIsAcpVisible
		{
			get
			{
				short num = (short)751828992;
				short num2 = num;
				num = (short)1141541939;
				short num3 = num;
				num = (short)103451699;
				switch (num3 == num)
				{
				}
				num = (short)1032716289;
				if (num != 0)
				{
				}
				num = (short)126418944;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad3ButtonIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1095630848;
				short num2 = num;
				num = (short)420413441;
				if (num != 0)
				{
				}
				num = (short)1220436503;
				short num3 = num;
				num = (short)943022615;
				switch (num3 == num)
				{
				}
				num = (short)1527185408;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad3ButtonIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00049AD4 File Offset: 0x00047CD4
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00049B8C File Offset: 0x00047D8C
		public bool DialPad3ButtonIndexIsAcpEditable
		{
			get
			{
				short num = (short)1073938432;
				short num2 = num;
				num = (short)2075858461;
				short num3 = num;
				num = (short)613684765;
				switch (num3 == num)
				{
				}
				num = (short)1056178177;
				if (num != 0)
				{
				}
				num = (short)1097531392;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad3ButtonIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1237909504;
				short num2 = num;
				num = (short)1045712374;
				short num3 = num;
				num = (short)637554166;
				switch (num3 == num)
				{
				}
				num = (short)1422065665;
				if (num != 0)
				{
				}
				num = (short)1795358720;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad3ButtonIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00049C48 File Offset: 0x00047E48
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00049D04 File Offset: 0x00047F04
		public string DialPad3ButtonIndexUIValue
		{
			get
			{
				short num = (short)450166784;
				short num2 = num;
				num = (short)692387841;
				if (num != 0)
				{
				}
				num = (short)1709888858;
				short num3 = num;
				num = (short)213112154;
				switch (num3 == num)
				{
				}
				num = (short)725942272;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad3ButtonIndexUIValueProperty);
			}
			set
			{
				short num = (short)693895168;
				short num2 = num;
				num = (short)575905781;
				short num3 = num;
				num = (short)1703387125;
				switch (num3 == num)
				{
				}
				num = (short)1878458369;
				if (num != 0)
				{
				}
				num = (short)1643446272;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad3ButtonIndexUIValueProperty, value);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00049DB8 File Offset: 0x00047FB8
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00049E74 File Offset: 0x00048074
		public AcpListField DialPad3ButtonIndexList
		{
			get
			{
				short num = (short)971112448;
				short num2 = num;
				num = (short)1209335809;
				if (num != 0)
				{
				}
				num = (short)1450529248;
				short num3 = num;
				num = (short)1310609888;
				switch (num3 == num)
				{
				}
				num = (short)1165885440;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad3ButtonIndexListProperty);
			}
			set
			{
				short num = (short)696123392;
				short num2 = num;
				num = (short)1281379315;
				short num3 = num;
				num = (short)1094011891;
				switch (num3 == num)
				{
				}
				num = (short)1887567873;
				if (num != 0)
				{
				}
				num = (short)972488704;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad3ButtonIndexListProperty, value);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00049F2C File Offset: 0x0004812C
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00049FE8 File Offset: 0x000481E8
		public bool DialPad4ButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)466026496;
				short num2 = num;
				num = (short)1700685895;
				short num3 = num;
				num = (short)134506567;
				switch (num3 == num)
				{
				}
				num = (short)2084503553;
				if (num != 0)
				{
				}
				num = (short)595722240;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad4ButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)54722560;
				short num2 = num;
				num = (short)1361481807;
				short num3 = num;
				num = (short)2029555791;
				switch (num3 == num)
				{
				}
				num = (short)34799617;
				if (num != 0)
				{
				}
				num = (short)817561600;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad4ButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0004A0A0 File Offset: 0x000482A0
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x0004A158 File Offset: 0x00048358
		public bool DialPad4ButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)381157376;
				short num2 = num;
				num = (short)930043710;
				short num3 = num;
				num = (short)1142314814;
				switch (num3 == num)
				{
				}
				num = (short)1743912961;
				if (num != 0)
				{
				}
				num = (short)198377472;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad4ButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1541275648;
				short num2 = num;
				num = (short)1021897805;
				short num3 = num;
				num = (short)1638788173;
				switch (num3 == num)
				{
				}
				num = (short)1856634881;
				if (num != 0)
				{
				}
				num = (short)197066752;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad4ButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0004A214 File Offset: 0x00048414
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x0004A2D4 File Offset: 0x000484D4
		public bool DialPad4ButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)821166080;
				short num2 = num;
				num = (short)194228941;
				short num3 = num;
				num = (short)1648472781;
				switch (num3 == num)
				{
				}
				num = (short)980484096;
				if (num != 0)
				{
				}
				num = (short)1735000065;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad4ButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)916389888;
				short num2 = num;
				num = (short)1360483246;
				short num3 = num;
				num = (short)1329615790;
				switch (num3 == num)
				{
				}
				num = (short)18219008;
				if (num != 0)
				{
				}
				num = (short)690683905;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad4ButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0004A38C File Offset: 0x0004858C
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x0004A444 File Offset: 0x00048644
		public bool DialPad4ButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)517210112;
				short num2 = num;
				num = (short)1408050536;
				short num3 = num;
				num = (short)2140677480;
				switch (num3 == num)
				{
				}
				num = (short)433651712;
				if (num != 0)
				{
				}
				num = (short)1724907521;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad4ButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)775487488;
				short num2 = num;
				num = (short)703919751;
				short num3 = num;
				num = (short)1399912071;
				switch (num3 == num)
				{
				}
				num = (short)402128897;
				if (num != 0)
				{
				}
				num = (short)1511522304;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad4ButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0004A500 File Offset: 0x00048700
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x0004A5BC File Offset: 0x000487BC
		public string DialPad4ButtonFeatureUIValue
		{
			get
			{
				short num = (short)877002752;
				short num2 = num;
				num = (short)1056785673;
				short num3 = num;
				num = (short)1146176777;
				switch (num3 == num)
				{
				}
				num = (short)120061953;
				if (num != 0)
				{
				}
				num = (short)1947729920;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad4ButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)271581184;
				short num2 = num;
				num = (short)1578500030;
				short num3 = num;
				num = (short)7929790;
				switch (num3 == num)
				{
				}
				num = (short)553648129;
				if (num != 0)
				{
				}
				num = (short)1329922048;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad4ButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0004A670 File Offset: 0x00048870
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x0004A728 File Offset: 0x00048928
		public AcpListField DialPad4ButtonFeatureList
		{
			get
			{
				short num = (short)920715264;
				short num2 = num;
				num = (short)1981717283;
				short num3 = num;
				num = (short)167877411;
				switch (num3 == num)
				{
				}
				num = (short)1580400640;
				if (num != 0)
				{
				}
				num = (short)212074497;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad4ButtonFeatureListProperty);
			}
			set
			{
				short num = (short)849084416;
				short num2 = num;
				num = (short)1999262666;
				short num3 = num;
				num = (short)1372345290;
				switch (num3 == num)
				{
				}
				num = (short)1884028929;
				if (num != 0)
				{
				}
				num = (short)1912602624;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad4ButtonFeatureListProperty, value);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0004A7E0 File Offset: 0x000489E0
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x0004A89C File Offset: 0x00048A9C
		public bool DialPad4ButtonIndexIsAcpValid
		{
			get
			{
				short num = (short)605487104;
				short num2 = num;
				num = (short)1163519974;
				short num3 = num;
				num = (short)1576331238;
				switch (num3 == num)
				{
				}
				num = (short)571146240;
				if (num != 0)
				{
				}
				num = (short)1044643841;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad4ButtonIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1999831040;
				short num2 = num;
				num = (short)535429121;
				if (num != 0)
				{
				}
				num = (short)536866981;
				short num3 = num;
				num = (short)1400041637;
				switch (num3 == num)
				{
				}
				num = (short)2122317824;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad4ButtonIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0004A958 File Offset: 0x00048B58
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0004AA10 File Offset: 0x00048C10
		public bool DialPad4ButtonIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1702363136;
				short num2 = num;
				num = (short)1884809739;
				short num3 = num;
				num = (short)770435595;
				switch (num3 == num)
				{
				}
				num = (short)1344077825;
				if (num != 0)
				{
				}
				num = (short)690159616;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad4ButtonIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)46858240;
				short num2 = num;
				num = (short)811216306;
				short num3 = num;
				num = (short)223161778;
				switch (num3 == num)
				{
				}
				num = (short)729284608;
				if (num != 0)
				{
				}
				num = (short)46071809;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad4ButtonIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0004AACC File Offset: 0x00048CCC
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x0004AB88 File Offset: 0x00048D88
		public bool DialPad4ButtonIndexIsAcpVisible
		{
			get
			{
				short num = (short)361024260;
				short num2 = num;
				num = (short)869190404;
				switch (num2 == num)
				{
				}
				num = (short)25755648;
				short num3 = num;
				num = (short)1867251713;
				if (num != 0)
				{
				}
				num = (short)1041039360;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad4ButtonIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1525887422;
				short num2 = num;
				num = (short)1976512958;
				switch (num2 == num)
				{
				}
				num = (short)130482176;
				short num3 = num;
				num = (short)1570504705;
				if (num != 0)
				{
				}
				num = (short)903086080;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad4ButtonIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0004AC44 File Offset: 0x00048E44
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x0004AD00 File Offset: 0x00048F00
		public bool DialPad4ButtonIndexIsAcpEditable
		{
			get
			{
				short num = (short)269890004;
				short num2 = num;
				num = (short)276967892;
				switch (num2 == num)
				{
				}
				num = (short)1218707456;
				short num3 = num;
				num = (short)1488781313;
				if (num != 0)
				{
				}
				num = (short)612302848;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad4ButtonIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1346225564;
				short num2 = num;
				num = (short)638174620;
				switch (num2 == num)
				{
				}
				num = (short)338821120;
				short num3 = num;
				num = (short)1804402688;
				if (num != 0)
				{
				}
				num = (short)1896808449;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad4ButtonIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0004ADBC File Offset: 0x00048FBC
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x0004AE74 File Offset: 0x00049074
		public string DialPad4ButtonIndexUIValue
		{
			get
			{
				short num = (short)962298958;
				short num2 = num;
				num = (short)478577742;
				switch (num2 == num)
				{
				}
				num = (short)1515061248;
				short num3 = num;
				num = (short)366739456;
				if (num != 0)
				{
				}
				num = (short)288292865;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad4ButtonIndexUIValueProperty);
			}
			set
			{
				short num = (short)409809464;
				short num2 = num;
				num = (short)1741369912;
				switch (num2 == num)
				{
				}
				num = (short)979238912;
				short num3 = num;
				num = (short)1923481600;
				if (num != 0)
				{
				}
				num = (short)1659961345;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad4ButtonIndexUIValueProperty, value);
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0004AF2C File Offset: 0x0004912C
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x0004AFE4 File Offset: 0x000491E4
		public AcpListField DialPad4ButtonIndexList
		{
			get
			{
				short num = (short)100328875;
				short num2 = num;
				num = (short)1837557163;
				switch (num2 == num)
				{
				}
				num = (short)1944453120;
				short num3 = num;
				num = (short)495517697;
				if (num != 0)
				{
				}
				num = (short)1134690304;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad4ButtonIndexListProperty);
			}
			set
			{
				short num = (short)1121374703;
				short num2 = num;
				num = (short)1939460591;
				switch (num2 == num)
				{
				}
				num = (short)273285120;
				short num3 = num;
				num = (short)1372782593;
				if (num != 0)
				{
				}
				num = (short)479461376;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad4ButtonIndexListProperty, value);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0004B098 File Offset: 0x00049298
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x0004B154 File Offset: 0x00049354
		public bool DialPad5ButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)2025549186;
				short num2 = num;
				num = (short)106327426;
				switch (num2 == num)
				{
				}
				num = (short)278134784;
				short num3 = num;
				num = (short)2018574337;
				if (num != 0)
				{
				}
				num = (short)1523449856;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad5ButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)73130777;
				short num2 = num;
				num = (short)1391584025;
				switch (num2 == num)
				{
				}
				num = (short)1096155136;
				short num3 = num;
				num = (short)1109131264;
				if (num != 0)
				{
				}
				num = (short)989200385;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad5ButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x0004B210 File Offset: 0x00049410
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x0004B2CC File Offset: 0x000494CC
		public bool DialPad5ButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1276870469;
				short num2 = num;
				num = (short)2133950277;
				switch (num2 == num)
				{
				}
				num = (short)1363345408;
				short num3 = num;
				num = (short)571342849;
				if (num != 0)
				{
				}
				num = (short)1999699968;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad5ButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)891921927;
				short num2 = num;
				num = (short)690005511;
				switch (num2 == num)
				{
				}
				num = (short)999686144;
				short num3 = num;
				num = (short)1715273729;
				if (num != 0)
				{
				}
				num = (short)1049493504;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad5ButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0004B388 File Offset: 0x00049588
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x0004B444 File Offset: 0x00049644
		public bool DialPad5ButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1487015702;
				short num2 = num;
				num = (short)645664534;
				switch (num2 == num)
				{
				}
				num = (short)95485952;
				short num3 = num;
				num = (short)304742401;
				if (num != 0)
				{
				}
				num = (short)1939537920;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad5ButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)716318609;
				short num2 = num;
				num = (short)109062033;
				switch (num2 == num)
				{
				}
				num = (short)466550784;
				short num3 = num;
				num = (short)315228161;
				if (num != 0)
				{
				}
				num = (short)1942814720;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad5ButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0004B4FC File Offset: 0x000496FC
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x0004B5B4 File Offset: 0x000497B4
		public bool DialPad5ButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)90112400;
				short num2 = num;
				num = (short)1235747216;
				switch (num2 == num)
				{
				}
				num = (short)702939136;
				short num3 = num;
				num = (short)1729626113;
				if (num != 0)
				{
				}
				num = (short)234225664;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad5ButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2042232833;
				if (num != 0)
				{
				}
				num = (short)1529032019;
				short num2 = num;
				num = (short)859057491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1173487616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1046347776;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad5ButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x0004B66C File Offset: 0x0004986C
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x0004B724 File Offset: 0x00049924
		public string DialPad5ButtonFeatureUIValue
		{
			get
			{
				short num = (short)1828978689;
				if (num != 0)
				{
				}
				num = (short)1438799142;
				short num2 = num;
				num = (short)2094617894;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1187250176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)623509504;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad5ButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1613769384;
				short num2 = num;
				num = (short)574106280;
				switch (num2 == num)
				{
				}
				num = (short)408354816;
				short num3 = num;
				num = (short)829685761;
				if (num != 0)
				{
				}
				num = (short)1654915072;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad5ButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x0004B7D8 File Offset: 0x000499D8
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x0004B894 File Offset: 0x00049A94
		public AcpListField DialPad5ButtonFeatureList
		{
			get
			{
				short num = (short)1223205251;
				short num2 = num;
				num = (short)2084282755;
				switch (num2 == num)
				{
				}
				num = (short)525139968;
				short num3 = num;
				num = (short)45023233;
				if (num != 0)
				{
				}
				num = (short)19267584;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad5ButtonFeatureListProperty);
			}
			set
			{
				short num = (short)235601921;
				if (num != 0)
				{
				}
				num = (short)612398698;
				short num2 = num;
				num = (short)1216378474;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1943601152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1711734784;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad5ButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x0004B948 File Offset: 0x00049B48
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x0004BA04 File Offset: 0x00049C04
		public bool DialPad5ButtonIndexIsAcpValid
		{
			get
			{
				short num = (short)1524826113;
				if (num != 0)
				{
				}
				num = (short)24996163;
				short num2 = num;
				num = (short)152463683;
				switch (num2 == num)
				{
				default:
				{
					num = (short)318963712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2085224448;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad5ButtonIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1799638369;
				short num2 = num;
				num = (short)11423073;
				switch (num2 == num)
				{
				}
				num = (short)1719336960;
				short num3 = num;
				num = (short)1895104512;
				if (num != 0)
				{
				}
				num = (short)2030108673;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad5ButtonIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x0004BABC File Offset: 0x00049CBC
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x0004BB78 File Offset: 0x00049D78
		public bool DialPad5ButtonIndexIsAcpApplicable
		{
			get
			{
				short num = (short)2143379850;
				short num2 = num;
				num = (short)1344627082;
				switch (num2 == num)
				{
				}
				num = (short)1194065920;
				short num3 = num;
				num = (short)343408640;
				if (num != 0)
				{
				}
				num = (short)780730369;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad5ButtonIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)324122787;
				short num2 = num;
				num = (short)28031139;
				switch (num2 == num)
				{
				}
				num = (short)286851072;
				short num3 = num;
				num = (short)1219952641;
				if (num != 0)
				{
				}
				num = (short)740163584;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad5ButtonIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0004BC34 File Offset: 0x00049E34
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x0004BCEC File Offset: 0x00049EEC
		public bool DialPad5ButtonIndexIsAcpVisible
		{
			get
			{
				short num = (short)1205207041;
				if (num != 0)
				{
				}
				num = (short)2027576583;
				short num2 = num;
				num = (short)506879239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1888616448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)166658048;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad5ButtonIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1481047554;
				short num2 = num;
				num = (short)493616642;
				switch (num2 == num)
				{
				}
				num = (short)517603328;
				short num3 = num;
				num = (short)830603265;
				if (num != 0)
				{
				}
				num = (short)1083244544;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad5ButtonIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0004BDA8 File Offset: 0x00049FA8
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0004BE60 File Offset: 0x0004A060
		public bool DialPad5ButtonIndexIsAcpEditable
		{
			get
			{
				short num = (short)927804062;
				short num2 = num;
				num = (short)244722334;
				switch (num2 == num)
				{
				}
				num = (short)1379598336;
				short num3 = num;
				num = (short)162856961;
				if (num != 0)
				{
				}
				num = (short)690290688;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad5ButtonIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)912904881;
				short num2 = num;
				num = (short)2091438769;
				switch (num2 == num)
				{
				}
				num = (short)1114112;
				if (num != 0)
				{
				}
				num = (short)1461387264;
				short num3 = num;
				num = (short)286851073;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad5ButtonIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0004BF1C File Offset: 0x0004A11C
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x0004BFD4 File Offset: 0x0004A1D4
		public string DialPad5ButtonIndexUIValue
		{
			get
			{
				short num = (short)1494482945;
				if (num != 0)
				{
				}
				num = (short)1922224619;
				short num2 = num;
				num = (short)1192940011;
				switch (num2 == num)
				{
				}
				num = (short)786432000;
				short num3 = num;
				num = (short)1227882496;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad5ButtonIndexUIValueProperty);
			}
			set
			{
				short num = (short)1725438754;
				short num2 = num;
				num = (short)370875170;
				switch (num2 == num)
				{
				}
				num = (short)1556611072;
				if (num != 0)
				{
				}
				num = (short)1969225728;
				short num3 = num;
				num = (short)2045771777;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad5ButtonIndexUIValueProperty, value);
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0004C088 File Offset: 0x0004A288
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x0004C144 File Offset: 0x0004A344
		public AcpListField DialPad5ButtonIndexList
		{
			get
			{
				short num = (short)1516012933;
				short num2 = num;
				num = (short)337806725;
				switch (num2 == num)
				{
				}
				num = (short)1715142657;
				if (num != 0)
				{
				}
				num = (short)96075776;
				short num3 = num;
				num = (short)898236416;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad5ButtonIndexListProperty);
			}
			set
			{
				short num = (short)144769025;
				if (num != 0)
				{
				}
				num = (short)686332814;
				short num2 = num;
				num = (short)787258254;
				switch (num2 == num)
				{
				}
				num = (short)290455552;
				short num3 = num;
				num = (short)1651048448;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad5ButtonIndexListProperty, value);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x0004C1F8 File Offset: 0x0004A3F8
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x0004C2B0 File Offset: 0x0004A4B0
		public bool DialPad6ButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)1400731660;
				short num2 = num;
				num = (short)1010857996;
				switch (num2 == num)
				{
				}
				num = (short)729677825;
				if (num != 0)
				{
				}
				num = (short)1869414400;
				short num3 = num;
				num = (short)785711104;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad6ButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)50718826;
				short num2 = num;
				num = (short)50260074;
				switch (num2 == num)
				{
				}
				num = (short)1482424321;
				if (num != 0)
				{
				}
				num = (short)1331494912;
				short num3 = num;
				num = (short)1198653440;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad6ButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0004C368 File Offset: 0x0004A568
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x0004C424 File Offset: 0x0004A624
		public bool DialPad6ButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1622377202;
				short num2 = num;
				num = (short)2125759218;
				switch (num2 == num)
				{
				}
				num = (short)1509425152;
				if (num != 0)
				{
				}
				num = (short)452001792;
				short num3 = num;
				num = (short)1522991105;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad6ButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1669899163;
				short num2 = num;
				num = (short)1113039771;
				switch (num2 == num)
				{
				}
				num = (short)958988288;
				if (num != 0)
				{
				}
				num = (short)1317011456;
				short num3 = num;
				num = (short)541392897;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad6ButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0004C4DC File Offset: 0x0004A6DC
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x0004C598 File Offset: 0x0004A798
		public bool DialPad6ButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)794848801;
				short num2 = num;
				num = (short)1740729889;
				switch (num2 == num)
				{
				}
				num = (short)1048707073;
				if (num != 0)
				{
				}
				num = (short)761790464;
				short num3 = num;
				num = (short)863502336;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad6ButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)552337409;
				if (num != 0)
				{
				}
				num = (short)1015254083;
				short num2 = num;
				num = (short)1768918083;
				switch (num2 == num)
				{
				}
				num = (short)1430913024;
				short num3 = num;
				num = (short)324141056;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad6ButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0004C654 File Offset: 0x0004A854
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x0004C710 File Offset: 0x0004A910
		public bool DialPad6ButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)2028980133;
				short num2 = num;
				num = (short)2113062821;
				switch (num2 == num)
				{
				}
				num = (short)779681793;
				if (num != 0)
				{
				}
				num = (short)2079653888;
				short num3 = num;
				num = (short)518193152;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad6ButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1677276686;
				short num2 = num;
				num = (short)430781966;
				switch (num2 == num)
				{
				}
				num = (short)1326055425;
				if (num != 0)
				{
				}
				num = (short)517799936;
				short num3 = num;
				num = (short)231800832;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad6ButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0004C7CC File Offset: 0x0004A9CC
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x0004C888 File Offset: 0x0004AA88
		public string DialPad6ButtonFeatureUIValue
		{
			get
			{
				short num = (short)1716038307;
				short num2 = num;
				num = (short)367372963;
				switch (num2 == num)
				{
				}
				num = (short)745078784;
				if (num != 0)
				{
				}
				num = (short)2024538112;
				short num3 = num;
				num = (short)582680577;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad6ButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1484849153;
				if (num != 0)
				{
				}
				num = (short)1856734542;
				short num2 = num;
				num = (short)1487504718;
				switch (num2 == num)
				{
				}
				num = (short)438501376;
				short num3 = num;
				num = (short)1924923392;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad6ButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0004C93C File Offset: 0x0004AB3C
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0004C9FC File Offset: 0x0004ABFC
		public AcpListField DialPad6ButtonFeatureList
		{
			get
			{
				short num = (short)657129473;
				if (num != 0)
				{
				}
				num = (short)1936686794;
				short num2 = num;
				num = (short)1860075210;
				switch (num2 == num)
				{
				}
				num = (short)1396965376;
				short num3 = num;
				num = (short)1372651520;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad6ButtonFeatureListProperty);
			}
			set
			{
				short num = (short)1842544641;
				if (num != 0)
				{
				}
				num = (short)707645364;
				short num2 = num;
				num = (short)1574096820;
				switch (num2 == num)
				{
				}
				num = (short)2013528064;
				short num3 = num;
				num = (short)1800798208;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad6ButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0004CAB0 File Offset: 0x0004ACB0
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x0004CB6C File Offset: 0x0004AD6C
		public bool DialPad6ButtonIndexIsAcpValid
		{
			get
			{
				short num = (short)1634456680;
				short num2 = num;
				num = (short)1275253864;
				switch (num2 == num)
				{
				}
				num = (short)1582301185;
				if (num != 0)
				{
				}
				num = (short)1878392832;
				short num3 = num;
				num = (short)1023737856;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad6ButtonIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)56393569;
				short num2 = num;
				num = (short)705789793;
				switch (num2 == num)
				{
				}
				num = (short)827195393;
				if (num != 0)
				{
				}
				num = (short)390463488;
				short num3 = num;
				num = (short)1293942784;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad6ButtonIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0004CC28 File Offset: 0x0004AE28
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0004CCE4 File Offset: 0x0004AEE4
		public bool DialPad6ButtonIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1261299569;
				short num2 = num;
				num = (short)732358513;
				switch (num2 == num)
				{
				}
				num = (short)1023803393;
				if (num != 0)
				{
				}
				num = (short)1083965440;
				short num3 = num;
				num = (short)1666646016;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad6ButtonIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2133204343;
				short num2 = num;
				num = (short)57220471;
				switch (num2 == num)
				{
				}
				num = (short)1280180224;
				if (num != 0)
				{
				}
				num = (short)1712783360;
				short num3 = num;
				num = (short)867237889;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad6ButtonIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0004CDA0 File Offset: 0x0004AFA0
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x0004CE58 File Offset: 0x0004B058
		public bool DialPad6ButtonIndexIsAcpVisible
		{
			get
			{
				short num = (short)1110114305;
				if (num != 0)
				{
				}
				num = (short)316604416;
				short num2 = num;
				num = (short)1401355821;
				short num3 = num;
				num = (short)320470573;
				switch (num3 == num)
				{
				}
				num = (short)1814036480;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad6ButtonIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1685614032;
				short num2 = num;
				num = (short)1525837264;
				switch (num2 == num)
				{
				default:
				{
					num = (short)757268480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1264254976;
				if (num != 0)
				{
				}
				num = (short)760872961;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad6ButtonIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0004CF14 File Offset: 0x0004B114
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x0004CFD0 File Offset: 0x0004B1D0
		public bool DialPad6ButtonIndexIsAcpEditable
		{
			get
			{
				short num = (short)836239012;
				short num2 = num;
				num = (short)366542500;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1842216960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)333971457;
				if (num != 0)
				{
				}
				num = (short)432406528;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad6ButtonIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)602537985;
				if (num != 0)
				{
				}
				num = (short)1729429504;
				short num2 = num;
				num = (short)36224318;
				short num3 = num;
				num = (short)1199291710;
				switch (num3 == num)
				{
				}
				num = (short)669777920;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad6ButtonIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0004D088 File Offset: 0x0004B288
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x0004D140 File Offset: 0x0004B340
		public string DialPad6ButtonIndexUIValue
		{
			get
			{
				short num = (short)39931681;
				short num2 = num;
				num = (short)101797665;
				switch (num2 == num)
				{
				default:
				{
					num = (short)443744256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2054422529;
				if (num != 0)
				{
				}
				num = (short)2000683008;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad6ButtonIndexUIValueProperty);
			}
			set
			{
				short num = (short)571569056;
				short num2 = num;
				num = (short)423326624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1444020224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)831062017;
				if (num != 0)
				{
				}
				num = (short)2119368704;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad6ButtonIndexUIValueProperty, value);
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0004D1F4 File Offset: 0x0004B3F4
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x0004D2AC File Offset: 0x0004B4AC
		public AcpListField DialPad6ButtonIndexList
		{
			get
			{
				short num = (short)403424367;
				short num2 = num;
				num = (short)1118880879;
				switch (num2 == num)
				{
				default:
				{
					num = (short)508166144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1913389056;
				if (num != 0)
				{
				}
				num = (short)354877441;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad6ButtonIndexListProperty);
			}
			set
			{
				short num = (short)1768390051;
				short num2 = num;
				num = (short)844791203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)666566656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2101870592;
				if (num != 0)
				{
				}
				num = (short)1639907329;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad6ButtonIndexListProperty, value);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0004D360 File Offset: 0x0004B560
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x0004D418 File Offset: 0x0004B618
		public bool DialPad7ButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)796577843;
				short num2 = num;
				num = (short)800641075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)321781760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)495190017;
				if (num != 0)
				{
				}
				num = (short)745734144;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad7ButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)2130147632;
				short num2 = num;
				num = (short)1570404656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1154940928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2075525121;
				if (num != 0)
				{
				}
				num = (short)1462894592;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad7ButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0004D4D4 File Offset: 0x0004B6D4
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0004D590 File Offset: 0x0004B790
		public bool DialPad7ButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1890936981;
				short num2 = num;
				num = (short)1863870613;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1020067840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1290272768;
				if (num != 0)
				{
				}
				num = (short)1775632385;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad7ButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1200719436;
				short num2 = num;
				num = (short)706643532;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1784348672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1542193153;
				if (num != 0)
				{
				}
				num = (short)710344704;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad7ButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0004D650 File Offset: 0x0004B850
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x0004D708 File Offset: 0x0004B908
		public bool DialPad7ButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)453511066;
				short num2 = num;
				num = (short)759105434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)241434624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)361037825;
				if (num != 0)
				{
				}
				num = (short)1492647936;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad7ButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)257430266;
				short num2 = num;
				num = (short)147854074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)671612928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1320747008;
				if (num != 0)
				{
				}
				num = (short)492240897;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad7ButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0004D7C4 File Offset: 0x0004B9C4
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0004D87C File Offset: 0x0004BA7C
		public bool DialPad7ButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)253755395;
				short num2 = num;
				num = (short)1939668995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1910964224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1547567105;
				if (num != 0)
				{
				}
				num = (short)2008612864;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad7ButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1234063968;
				short num2 = num;
				num = (short)251286112;
				switch (num2 == num)
				{
				default:
				{
					num = (short)953614336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)933036033;
				if (num != 0)
				{
				}
				num = (short)1481375744;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad7ButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0004D934 File Offset: 0x0004BB34
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x0004D9F0 File Offset: 0x0004BBF0
		public string DialPad7ButtonFeatureUIValue
		{
			get
			{
				short num = (short)1852792212;
				short num2 = num;
				num = (short)648371604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1931608064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)117899265;
				if (num != 0)
				{
				}
				num = (short)1764360192;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad7ButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)407561143;
				short num2 = num;
				num = (short)652927927;
				switch (num2 == num)
				{
				default:
				{
					num = (short)229572608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)44105729;
				if (num != 0)
				{
				}
				num = (short)352321536;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad7ButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0004DAA8 File Offset: 0x0004BCA8
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x0004DB60 File Offset: 0x0004BD60
		public AcpListField DialPad7ButtonFeatureList
		{
			get
			{
				short num = (short)1750019578;
				short num2 = num;
				num = (short)1047997946;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1087700992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)451608576;
				if (num != 0)
				{
				}
				num = (short)374538241;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad7ButtonFeatureListProperty);
			}
			set
			{
				short num = (short)1147207681;
				if (num != 0)
				{
				}
				num = (short)756023296;
				short num2 = num;
				num = (short)87565996;
				short num3 = num;
				num = (short)1268000428;
				switch (num3 == num)
				{
				}
				num = (short)393936896;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad7ButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0004DC14 File Offset: 0x0004BE14
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0004DCCC File Offset: 0x0004BECC
		public bool DialPad7ButtonIndexIsAcpValid
		{
			get
			{
				short num = (short)500540575;
				short num2 = num;
				num = (short)1104651423;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1379467264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)510918657;
				if (num != 0)
				{
				}
				num = (short)1029373952;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad7ButtonIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1621908980;
				short num2 = num;
				num = (short)164322804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1420230656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1549336577;
				if (num != 0)
				{
				}
				num = (short)2103705600;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad7ButtonIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0004DD84 File Offset: 0x0004BF84
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x0004DE40 File Offset: 0x0004C040
		public bool DialPad7ButtonIndexIsAcpApplicable
		{
			get
			{
				short num = (short)2040905521;
				short num2 = num;
				num = (short)15908657;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1330774016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)214040577;
				if (num != 0)
				{
				}
				num = (short)403832832;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad7ButtonIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2055194850;
				short num2 = num;
				num = (short)1149225186;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1710030848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1272840192;
				if (num != 0)
				{
				}
				num = (short)42532865;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad7ButtonIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0004DEF8 File Offset: 0x0004C0F8
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x0004DFB4 File Offset: 0x0004C1B4
		public bool DialPad7ButtonIndexIsAcpVisible
		{
			get
			{
				short num = (short)992568066;
				short num2 = num;
				num = (short)1226203906;
				switch (num2 == num)
				{
				default:
				{
					num = (short)354746368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1343029249;
				if (num != 0)
				{
				}
				num = (short)1034027008;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad7ButtonIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1351641973;
				short num2 = num;
				num = (short)23030645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1005846528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)852230145;
				if (num != 0)
				{
				}
				num = (short)2070872064;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad7ButtonIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0004E06C File Offset: 0x0004C26C
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x0004E124 File Offset: 0x0004C324
		public bool DialPad7ButtonIndexIsAcpEditable
		{
			get
			{
				short num = (short)2147142599;
				short num2 = num;
				num = (short)2028391367;
				switch (num2 == num)
				{
				default:
				{
					num = (short)320602112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2146566145;
				if (num != 0)
				{
				}
				num = (short)1587871744;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad7ButtonIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)767033345;
				if (num != 0)
				{
				}
				num = (short)1186922496;
				short num2 = num;
				num = (short)785376244;
				short num3 = num;
				num = (short)522773492;
				switch (num3 == num)
				{
				}
				num = (short)1578762240;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad7ButtonIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0004E1DC File Offset: 0x0004C3DC
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x0004E294 File Offset: 0x0004C494
		public string DialPad7ButtonIndexUIValue
		{
			get
			{
				short num = (short)494128791;
				short num2 = num;
				num = (short)719703703;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1765474304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)30343168;
				if (num != 0)
				{
				}
				num = (short)918487041;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad7ButtonIndexUIValueProperty);
			}
			set
			{
				short num = (short)1010602454;
				short num2 = num;
				num = (short)339382742;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2009661440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)237371392;
				if (num != 0)
				{
				}
				num = (short)2103640065;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad7ButtonIndexUIValueProperty, value);
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0004E348 File Offset: 0x0004C548
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x0004E404 File Offset: 0x0004C604
		public AcpListField DialPad7ButtonIndexList
		{
			get
			{
				short num = (short)683402298;
				short num2 = num;
				num = (short)76604474;
				switch (num2 == num)
				{
				default:
				{
					num = (short)556269568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1643511808;
				if (num != 0)
				{
				}
				num = (short)1850933249;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad7ButtonIndexListProperty);
			}
			set
			{
				short num = (short)1969348006;
				short num2 = num;
				num = (short)1871830438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)81788928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1046282241;
				if (num != 0)
				{
				}
				num = (short)1902903296;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad7ButtonIndexListProperty, value);
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0004E4C0 File Offset: 0x0004C6C0
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x0004E578 File Offset: 0x0004C778
		public bool DialPad8ButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)1604064913;
				short num2 = num;
				num = (short)1081415313;
				switch (num2 == num)
				{
				default:
				{
					num = (short)995950592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)356646912;
				if (num != 0)
				{
				}
				num = (short)1972633601;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad8ButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1314196775;
				short num2 = num;
				num = (short)1008667943;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1004535808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)314769408;
				if (num != 0)
				{
				}
				num = (short)1164902401;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad8ButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0004E630 File Offset: 0x0004C830
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0004E6F0 File Offset: 0x0004C8F0
		public bool DialPad8ButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)771806340;
				short num2 = num;
				num = (short)1891423364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954138624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1328414721;
				if (num != 0)
				{
				}
				num = (short)996147200;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad8ButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1008296987;
				short num2 = num;
				num = (short)114975771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1112211456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1245642753;
				if (num != 0)
				{
				}
				num = (short)601489408;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad8ButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0004E7AC File Offset: 0x0004C9AC
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0004E864 File Offset: 0x0004CA64
		public bool DialPad8ButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1612717182;
				short num2 = num;
				num = (short)1065950334;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1485766656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)737804289;
				if (num != 0)
				{
				}
				num = (short)836108288;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad8ButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2078853191;
				short num2 = num;
				num = (short)2107164743;
				switch (num2 == num)
				{
				default:
				{
					num = (short)328400896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1675755521;
				if (num != 0)
				{
				}
				num = (short)2008350720;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad8ButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0004E920 File Offset: 0x0004CB20
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x0004E9DC File Offset: 0x0004CBDC
		public bool DialPad8ButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1253526636;
				short num2 = num;
				num = (short)1620659308;
				switch (num2 == num)
				{
				default:
				{
					num = (short)367853568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)703266817;
				if (num != 0)
				{
				}
				num = (short)1023148032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad8ButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1349780588;
				short num2 = num;
				num = (short)2066416748;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1693515776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)597688321;
				if (num != 0)
				{
				}
				num = (short)1565786112;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad8ButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0004EA94 File Offset: 0x0004CC94
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0004EB4C File Offset: 0x0004CD4C
		public string DialPad8ButtonFeatureUIValue
		{
			get
			{
				short num = (short)861742074;
				short num2 = num;
				num = (short)110633978;
				switch (num2 == num)
				{
				default:
				{
					num = (short)747372544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1316487169;
				if (num != 0)
				{
				}
				num = (short)923992064;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad8ButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)2041251150;
				short num2 = num;
				num = (short)1284900174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2131361792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1303642113;
				if (num != 0)
				{
				}
				num = (short)1193738240;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad8ButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0004EC04 File Offset: 0x0004CE04
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0004ECBC File Offset: 0x0004CEBC
		public AcpListField DialPad8ButtonFeatureList
		{
			get
			{
				short num = (short)467391336;
				short num2 = num;
				num = (short)1548014440;
				switch (num2 == num)
				{
				default:
				{
					num = (short)52756480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1997668353;
				if (num != 0)
				{
				}
				num = (short)1053097984;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad8ButtonFeatureListProperty);
			}
			set
			{
				short num = (short)1387921408;
				short num2 = num;
				num = (short)1799091440;
				short num3 = num;
				num = (short)1662317808;
				switch (num3 == num)
				{
				}
				num = (short)874512385;
				if (num != 0)
				{
				}
				num = (short)1996750848;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad8ButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0004ED74 File Offset: 0x0004CF74
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x0004EE2C File Offset: 0x0004D02C
		public bool DialPad8ButtonIndexIsAcpValid
		{
			get
			{
				short num = (short)640024576;
				short num2 = num;
				num = (short)18031534;
				short num3 = num;
				num = (short)1242899374;
				switch (num3 == num)
				{
				}
				num = (short)494469121;
				if (num != 0)
				{
				}
				num = (short)431816704;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad8ButtonIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1796997120;
				short num2 = num;
				num = (short)1544765784;
				short num3 = num;
				num = (short)621822296;
				switch (num3 == num)
				{
				}
				num = (short)22085632;
				if (num != 0)
				{
				}
				num = (short)522321921;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad8ButtonIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0004EEE4 File Offset: 0x0004D0E4
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0004EF9C File Offset: 0x0004D19C
		public bool DialPad8ButtonIndexIsAcpApplicable
		{
			get
			{
				short num = (short)12189696;
				short num2 = num;
				num = (short)593243764;
				short num3 = num;
				num = (short)1801596532;
				switch (num3 == num)
				{
				}
				num = (short)1584594945;
				if (num != 0)
				{
				}
				num = (short)1330708480;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad8ButtonIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)580648960;
				short num2 = num;
				num = (short)1806276521;
				short num3 = num;
				num = (short)1703122857;
				switch (num3 == num)
				{
				}
				num = (short)130088960;
				if (num != 0)
				{
				}
				num = (short)1176436737;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad8ButtonIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0004F054 File Offset: 0x0004D254
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0004F10C File Offset: 0x0004D30C
		public bool DialPad8ButtonIndexIsAcpVisible
		{
			get
			{
				short num = (short)2097283072;
				short num2 = num;
				num = (short)234521930;
				short num3 = num;
				num = (short)1879344458;
				switch (num3 == num)
				{
				}
				num = (short)1401028609;
				if (num != 0)
				{
				}
				num = (short)1681391616;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad8ButtonIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1597505536;
				short num2 = num;
				num = (short)654912617;
				short num3 = num;
				num = (short)1814506601;
				switch (num3 == num)
				{
				}
				num = (short)1444741121;
				if (num != 0)
				{
				}
				num = (short)156762112;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad8ButtonIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0004F1C4 File Offset: 0x0004D3C4
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x0004F27C File Offset: 0x0004D47C
		public bool DialPad8ButtonIndexIsAcpEditable
		{
			get
			{
				short num = (short)889913344;
				short num2 = num;
				num = (short)1352954400;
				short num3 = num;
				num = (short)848458272;
				switch (num3 == num)
				{
				}
				num = (short)1469382657;
				if (num != 0)
				{
				}
				num = (short)149422080;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad8ButtonIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)999096320;
				short num2 = num;
				num = (short)580907184;
				short num3 = num;
				num = (short)83554480;
				switch (num3 == num)
				{
				}
				num = (short)2044002305;
				if (num != 0)
				{
				}
				num = (short)572784640;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad8ButtonIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0004F338 File Offset: 0x0004D538
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x0004F3F0 File Offset: 0x0004D5F0
		public string DialPad8ButtonIndexUIValue
		{
			get
			{
				short num = (short)845414400;
				short num2 = num;
				num = (short)216944998;
				short num3 = num;
				num = (short)273764710;
				switch (num3 == num)
				{
				}
				num = (short)230031361;
				if (num != 0)
				{
				}
				num = (short)2142502912;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad8ButtonIndexUIValueProperty);
			}
			set
			{
				short num = (short)445382656;
				short num2 = num;
				num = (short)1183695044;
				short num3 = num;
				num = (short)1240121540;
				switch (num3 == num)
				{
				}
				num = (short)1144061953;
				if (num != 0)
				{
				}
				num = (short)1973223424;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad8ButtonIndexUIValueProperty, value);
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0004F4A8 File Offset: 0x0004D6A8
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0004F564 File Offset: 0x0004D764
		public AcpListField DialPad8ButtonIndexList
		{
			get
			{
				short num = (short)1550385152;
				short num2 = num;
				num = (short)1633581272;
				short num3 = num;
				num = (short)895645912;
				switch (num3 == num)
				{
				}
				num = (short)378535937;
				if (num != 0)
				{
				}
				num = (short)1322188800;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad8ButtonIndexListProperty);
			}
			set
			{
				short num = (short)708575232;
				short num2 = num;
				num = (short)541827128;
				short num3 = num;
				num = (short)516857912;
				switch (num3 == num)
				{
				}
				num = (short)881065985;
				if (num != 0)
				{
				}
				num = (short)151519232;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad8ButtonIndexListProperty, value);
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0004F618 File Offset: 0x0004D818
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x0004F6D0 File Offset: 0x0004D8D0
		public bool DialPad9ButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)807141376;
				short num2 = num;
				num = (short)14921374;
				short num3 = num;
				num = (short)1053666974;
				switch (num3 == num)
				{
				}
				num = (short)985792513;
				if (num != 0)
				{
				}
				num = (short)2060713984;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad9ButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)772472832;
				short num2 = num;
				num = (short)335361473;
				short num3 = num;
				num = (short)1788491201;
				switch (num3 == num)
				{
				}
				num = (short)575143937;
				if (num != 0)
				{
				}
				num = (short)1072889856;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad9ButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0004F790 File Offset: 0x0004D990
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x0004F848 File Offset: 0x0004DA48
		public bool DialPad9ButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)675872768;
				short num2 = num;
				num = (short)180181563;
				short num3 = num;
				num = (short)985881147;
				switch (num3 == num)
				{
				}
				num = (short)1076625408;
				if (num != 0)
				{
				}
				num = (short)1145569281;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad9ButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)130678784;
				short num2 = num;
				num = (short)1265034155;
				short num3 = num;
				num = (short)859693995;
				switch (num3 == num)
				{
				}
				num = (short)1151533057;
				if (num != 0)
				{
				}
				num = (short)1844641792;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad9ButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0004F900 File Offset: 0x0004DB00
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x0004F9B8 File Offset: 0x0004DBB8
		public bool DialPad9ButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1255276544;
				short num2 = num;
				num = (short)1889468417;
				if (num != 0)
				{
				}
				num = (short)1474471897;
				short num3 = num;
				num = (short)1246537689;
				switch (num3 == num)
				{
				}
				num = (short)973537280;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad9ButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)198770688;
				short num2 = num;
				num = (short)424861819;
				short num3 = num;
				num = (short)1868816507;
				switch (num3 == num)
				{
				}
				num = (short)1590034432;
				if (num != 0)
				{
				}
				num = (short)763166721;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad9ButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0004FA70 File Offset: 0x0004DC70
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x0004FB28 File Offset: 0x0004DD28
		public bool DialPad9ButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1294401536;
				short num2 = num;
				num = (short)1998171916;
				short num3 = num;
				num = (short)1669508876;
				switch (num3 == num)
				{
				}
				num = (short)1500381184;
				if (num != 0)
				{
				}
				num = (short)388104193;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad9ButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)538509312;
				short num2 = num;
				num = (short)329072220;
				short num3 = num;
				num = (short)3620444;
				switch (num3 == num)
				{
				}
				num = (short)204734465;
				if (num != 0)
				{
				}
				num = (short)450101248;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad9ButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0004FBE4 File Offset: 0x0004DDE4
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x0004FC9C File Offset: 0x0004DE9C
		public string DialPad9ButtonFeatureUIValue
		{
			get
			{
				short num = (short)555614208;
				short num2 = num;
				num = (short)52401397;
				short num3 = num;
				num = (short)1408406773;
				switch (num3 == num)
				{
				}
				num = (short)1929379841;
				if (num != 0)
				{
				}
				num = (short)1087963136;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad9ButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1160577024;
				short num2 = num;
				num = (short)926875649;
				if (num != 0)
				{
				}
				num = (short)1475775214;
				short num3 = num;
				num = (short)185371374;
				switch (num3 == num)
				{
				}
				num = (short)583073792;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad9ButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0004FD54 File Offset: 0x0004DF54
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x0004FE10 File Offset: 0x0004E010
		public AcpListField DialPad9ButtonFeatureList
		{
			get
			{
				short num = (short)1357250560;
				short num2 = num;
				num = (short)82079675;
				short num3 = num;
				num = (short)510291899;
				switch (num3 == num)
				{
				}
				num = (short)426377216;
				if (num != 0)
				{
				}
				num = (short)442302465;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad9ButtonFeatureListProperty);
			}
			set
			{
				short num = (short)1767768064;
				short num2 = num;
				num = (short)1242233458;
				short num3 = num;
				num = (short)996014706;
				switch (num3 == num)
				{
				}
				num = (short)355205121;
				if (num != 0)
				{
				}
				num = (short)1638662144;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad9ButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0004FEC8 File Offset: 0x0004E0C8
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x0004FF80 File Offset: 0x0004E180
		public bool DialPad9ButtonIndexIsAcpValid
		{
			get
			{
				short num = (short)105185280;
				short num2 = num;
				num = (short)63848053;
				short num3 = num;
				num = (short)1669545589;
				switch (num3 == num)
				{
				}
				num = (short)535560193;
				if (num != 0)
				{
				}
				num = (short)1844051968;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad9ButtonIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1122828288;
				short num2 = num;
				num = (short)137363457;
				if (num != 0)
				{
				}
				num = (short)40475624;
				short num3 = num;
				num = (short)1791859688;
				switch (num3 == num)
				{
				}
				num = (short)209190912;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad9ButtonIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00050038 File Offset: 0x0004E238
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x000500F4 File Offset: 0x0004E2F4
		public bool DialPad9ButtonIndexIsAcpApplicable
		{
			get
			{
				short num = (short)688259072;
				short num2 = num;
				num = (short)1892941825;
				if (num != 0)
				{
				}
				num = (short)118109666;
				short num3 = num;
				num = (short)2076390882;
				switch (num3 == num)
				{
				}
				num = (short)107806720;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad9ButtonIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)380436480;
				short num2 = num;
				num = (short)501284865;
				if (num != 0)
				{
				}
				num = (short)622105932;
				short num3 = num;
				num = (short)363566412;
				switch (num3 == num)
				{
				}
				num = (short)79167488;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad9ButtonIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x000501B0 File Offset: 0x0004E3B0
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00050268 File Offset: 0x0004E468
		public bool DialPad9ButtonIndexIsAcpVisible
		{
			get
			{
				short num = (short)1809973248;
				short num2 = num;
				num = (short)466917194;
				short num3 = num;
				num = (short)1816172362;
				switch (num3 == num)
				{
				}
				num = (short)45350913;
				if (num != 0)
				{
				}
				num = (short)1983184896;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad9ButtonIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1855324160;
				short num2 = num;
				num = (short)671951245;
				short num3 = num;
				num = (short)869738893;
				switch (num3 == num)
				{
				}
				num = (short)497614849;
				if (num != 0)
				{
				}
				num = (short)1531772928;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad9ButtonIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00050324 File Offset: 0x0004E524
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x000503E4 File Offset: 0x0004E5E4
		public bool DialPad9ButtonIndexIsAcpEditable
		{
			get
			{
				short num = (short)1574830080;
				short num2 = num;
				num = (short)1002439345;
				short num3 = num;
				num = (short)906887857;
				switch (num3 == num)
				{
				}
				num = (short)369688577;
				if (num != 0)
				{
				}
				num = (short)340459520;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPad9ButtonIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2106654720;
				short num2 = num;
				num = (short)1474076496;
				short num3 = num;
				num = (short)2081529680;
				switch (num3 == num)
				{
				}
				num = (short)2095710209;
				if (num != 0)
				{
				}
				num = (short)218890240;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad9ButtonIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x000504A0 File Offset: 0x0004E6A0
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x0005055C File Offset: 0x0004E75C
		public string DialPad9ButtonIndexUIValue
		{
			get
			{
				short num = (short)756678656;
				short num2 = num;
				num = (short)65537;
				if (num != 0)
				{
				}
				num = (short)1811778188;
				short num3 = num;
				num = (short)93227660;
				switch (num3 == num)
				{
				}
				num = (short)142999552;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPad9ButtonIndexUIValueProperty);
			}
			set
			{
				short num = (short)1591279616;
				short num2 = num;
				num = (short)930597440;
				short num3 = num;
				num = (short)4311616;
				switch (num3 == num)
				{
				}
				num = (short)676462593;
				if (num != 0)
				{
				}
				num = (short)271581184;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad9ButtonIndexUIValueProperty, value);
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00050610 File Offset: 0x0004E810
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x000506CC File Offset: 0x0004E8CC
		public AcpListField DialPad9ButtonIndexList
		{
			get
			{
				short num = (short)133234688;
				short num2 = num;
				num = (short)2009834804;
				short num3 = num;
				num = (short)1623565620;
				switch (num3 == num)
				{
				}
				num = (short)480575489;
				if (num != 0)
				{
				}
				num = (short)2129723392;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPad9ButtonIndexListProperty);
			}
			set
			{
				short num = (short)1642987520;
				short num2 = num;
				num = (short)58401194;
				short num3 = num;
				num = (short)752361898;
				switch (num3 == num)
				{
				}
				num = (short)613285889;
				if (num != 0)
				{
				}
				num = (short)164626432;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPad9ButtonIndexListProperty, value);
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00050784 File Offset: 0x0004E984
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x0005083C File Offset: 0x0004EA3C
		public bool DialPadPoundButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)1234894848;
				short num2 = num;
				num = (short)498008065;
				if (num != 0)
				{
				}
				num = (short)1268989184;
				short num3 = num;
				num = (short)1543912704;
				switch (num3 == num)
				{
				}
				num = (short)1395523584;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPadPoundButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1988427776;
				short num2 = num;
				num = (short)1048130589;
				short num3 = num;
				num = (short)817509405;
				switch (num3 == num)
				{
				}
				num = (short)1457520641;
				if (num != 0)
				{
				}
				num = (short)390856704;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPadPoundButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x000508F8 File Offset: 0x0004EAF8
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x000509B0 File Offset: 0x0004EBB0
		public bool DialPadPoundButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1992687616;
				short num2 = num;
				num = (short)730422953;
				short num3 = num;
				num = (short)168451753;
				switch (num3 == num)
				{
				}
				num = (short)920584193;
				if (num != 0)
				{
				}
				num = (short)814481408;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPadPoundButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2053308416;
				short num2 = num;
				num = (short)583049773;
				short num3 = num;
				num = (short)160801325;
				switch (num3 == num)
				{
				}
				num = (short)1839267841;
				if (num != 0)
				{
				}
				num = (short)1885208576;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPadPoundButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00050A6C File Offset: 0x0004EC6C
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00050B24 File Offset: 0x0004ED24
		public bool DialPadPoundButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)300744704;
				short num2 = num;
				num = (short)1904877494;
				short num3 = num;
				num = (short)571875254;
				switch (num3 == num)
				{
				}
				num = (short)1238892545;
				if (num != 0)
				{
				}
				num = (short)354156544;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPadPoundButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1597177856;
				short num2 = num;
				num = (short)1359147913;
				short num3 = num;
				num = (short)225244041;
				switch (num3 == num)
				{
				}
				num = (short)1624113153;
				if (num != 0)
				{
				}
				num = (short)135659520;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPadPoundButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00050BDC File Offset: 0x0004EDDC
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00050C94 File Offset: 0x0004EE94
		public bool DialPadPoundButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)151257088;
				short num2 = num;
				num = (short)1825832961;
				if (num != 0)
				{
				}
				num = (short)792955967;
				short num3 = num;
				num = (short)473533503;
				switch (num3 == num)
				{
				}
				num = (short)2007040000;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPadPoundButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1820655616;
				short num2 = num;
				num = (short)335566284;
				short num3 = num;
				num = (short)1526814156;
				switch (num3 == num)
				{
				}
				num = (short)1520828417;
				if (num != 0)
				{
				}
				num = (short)1767768064;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPadPoundButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00050D50 File Offset: 0x0004EF50
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00050E0C File Offset: 0x0004F00C
		public string DialPadPoundButtonFeatureUIValue
		{
			get
			{
				short num = (short)1234894848;
				short num2 = num;
				num = (short)667784270;
				short num3 = num;
				num = (short)944149582;
				switch (num3 == num)
				{
				}
				num = (short)1269170177;
				if (num != 0)
				{
				}
				num = (short)1209729024;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadGraphicView.DialPadPoundButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)805765120;
				short num2 = num;
				num = (short)1244987393;
				if (num != 0)
				{
				}
				num = (short)1392456779;
				short num3 = num;
				num = (short)1356411979;
				switch (num3 == num)
				{
				}
				num = (short)381026304;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPadPoundButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00050EC4 File Offset: 0x0004F0C4
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00050F7C File Offset: 0x0004F17C
		public AcpListField DialPadPoundButtonFeatureList
		{
			get
			{
				short num = (short)1238171648;
				short num2 = num;
				num = (short)410236284;
				short num3 = num;
				num = (short)150451580;
				switch (num3 == num)
				{
				}
				num = (short)2036727808;
				if (num != 0)
				{
				}
				num = (short)1900478465;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPadPoundButtonFeatureListProperty);
			}
			set
			{
				short num = (short)1212612608;
				short num2 = num;
				num = (short)546694845;
				short num3 = num;
				num = (short)570353341;
				switch (num3 == num)
				{
				}
				num = (short)588840960;
				if (num != 0)
				{
				}
				num = (short)55836673;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPadPoundButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0005102C File Offset: 0x0004F22C
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x000510E4 File Offset: 0x0004F2E4
		public bool DialPadPoundButtonIndexIsAcpValid
		{
			get
			{
				short num = (short)1117716480;
				short num2 = num;
				num = (short)1101753868;
				short num3 = num;
				num = (short)489975308;
				switch (num3 == num)
				{
				}
				num = (short)1061879809;
				if (num != 0)
				{
				}
				num = (short)1664614400;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPadPoundButtonIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)373293056;
				short num2 = num;
				num = (short)472737984;
				short num3 = num;
				num = (short)778135744;
				switch (num3 == num)
				{
				}
				num = (short)552861697;
				if (num != 0)
				{
				}
				num = (short)1201864704;
				if (num != 0)
				{
				}
				base.SetValue(KeypadGraphicView.DialPadPoundButtonIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x000511A0 File Offset: 0x0004F3A0
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00051258 File Offset: 0x0004F458
		public bool DialPadPoundButtonIndexIsAcpApplicable
		{
			get
			{
				short num = (short)1999699968;
				short num2 = num;
				num = (short)458448019;
				short num3 = num;
				num = (short)449338515;
				switch (num3 == num)
				{
				}
				num = (short)1881145345;
				if (num != 0)
				{
				}
				num = (short)1875116032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadGraphicView.DialPadPoundButtonIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1810121599;
				short num2 = num;
				num = (short)811484031;
				switch (num2 == num)
				{
				}
				num = (short)1253769216;
				if (num != 0)
				{
				}
				num = (short)1206910977;
				if (num != 0)
				{
				}
				num = (short)769261568;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadPoundButtonIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00051310 File Offset: 0x0004F510
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x000513CC File Offset: 0x0004F5CC
		public bool DialPadPoundButtonIndexIsAcpVisible
		{
			get
			{
				short num = (short)335828546;
				short num2 = num;
				num = (short)437343810;
				switch (num2 == num)
				{
				}
				num = (short)118554625;
				if (num != 0)
				{
				}
				num = (short)1825767424;
				if (num != 0)
				{
				}
				num = (short)1708654592;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPadPoundButtonIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)151229708;
				short num2 = num;
				num = (short)1896125708;
				switch (num2 == num)
				{
				}
				num = (short)75235328;
				if (num != 0)
				{
				}
				num = (short)759037953;
				if (num != 0)
				{
				}
				num = (short)1203175424;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadPoundButtonIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00051488 File Offset: 0x0004F688
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00051540 File Offset: 0x0004F740
		public bool DialPadPoundButtonIndexIsAcpEditable
		{
			get
			{
				short num = (short)1938882561;
				if (num != 0)
				{
				}
				num = (short)373710842;
				short num2 = num;
				num = (short)1082220538;
				switch (num2 == num)
				{
				}
				num = (short)1921056768;
				if (num != 0)
				{
				}
				num = (short)613548032;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPadPoundButtonIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1596627136;
				short num2 = num;
				num = (short)774936768;
				switch (num2 == num)
				{
				}
				num = (short)1390936065;
				if (num != 0)
				{
				}
				num = (short)1942028288;
				if (num != 0)
				{
				}
				num = (short)668008448;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadPoundButtonIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00051600 File Offset: 0x0004F800
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x000516B8 File Offset: 0x0004F8B8
		public string DialPadPoundButtonIndexUIValue
		{
			get
			{
				short num = (short)193134593;
				if (num != 0)
				{
				}
				num = (short)1986187676;
				short num2 = num;
				num = (short)112644508;
				switch (num2 == num)
				{
				}
				num = (short)1162870784;
				if (num != 0)
				{
				}
				num = (short)1885667328;
				short num3 = num;
				return (string)base.GetValue(KeypadGraphicView.DialPadPoundButtonIndexUIValueProperty);
			}
			set
			{
				short num = (short)1404777473;
				short num2 = num;
				num = (short)290993153;
				switch (num2 == num)
				{
				}
				num = (short)1157890049;
				if (num != 0)
				{
				}
				num = (short)2059599872;
				if (num != 0)
				{
				}
				num = (short)1741357056;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadPoundButtonIndexUIValueProperty, value);
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0005176C File Offset: 0x0004F96C
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00051824 File Offset: 0x0004FA24
		public AcpListField DialPadPoundButtonIndexList
		{
			get
			{
				short num = (short)387209523;
				short num2 = num;
				num = (short)559569203;
				switch (num2 == num)
				{
				}
				num = (short)1659305985;
				if (num != 0)
				{
				}
				num = (short)1315700736;
				if (num != 0)
				{
				}
				num = (short)822083584;
				short num3 = num;
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPadPoundButtonIndexListProperty);
			}
			set
			{
				short num = (short)910027106;
				short num2 = num;
				num = (short)1508829538;
				switch (num2 == num)
				{
				}
				num = (short)1159266305;
				if (num != 0)
				{
				}
				num = (short)857931776;
				if (num != 0)
				{
				}
				num = (short)833224704;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadPoundButtonIndexListProperty, value);
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000518D8 File Offset: 0x0004FAD8
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x00051994 File Offset: 0x0004FB94
		public bool DialPadAsteriskButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)1762653831;
				short num2 = num;
				num = (short)1750464135;
				switch (num2 == num)
				{
				}
				num = (short)893321217;
				if (num != 0)
				{
				}
				num = (short)1257635840;
				if (num != 0)
				{
				}
				num = (short)606339072;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPadAsteriskButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)576249043;
				short num2 = num;
				num = (short)1080810707;
				switch (num2 == num)
				{
				}
				num = (short)398589953;
				if (num != 0)
				{
				}
				num = (short)1759313920;
				if (num != 0)
				{
				}
				num = (short)387448832;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadAsteriskButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00051A50 File Offset: 0x0004FC50
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00051B08 File Offset: 0x0004FD08
		public bool DialPadAsteriskButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)255088998;
				short num2 = num;
				num = (short)1259493734;
				switch (num2 == num)
				{
				}
				num = (short)448462849;
				if (num != 0)
				{
				}
				num = (short)1283391488;
				if (num != 0)
				{
				}
				num = (short)1521025024;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPadAsteriskButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)565248001;
				if (num != 0)
				{
				}
				num = (short)1775052761;
				short num2 = num;
				num = (short)1810638809;
				switch (num2 == num)
				{
				}
				num = (short)853344256;
				if (num != 0)
				{
				}
				num = (short)973209600;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadAsteriskButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00051BC0 File Offset: 0x0004FDC0
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00051C78 File Offset: 0x0004FE78
		public bool DialPadAsteriskButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)929480211;
				short num2 = num;
				num = (short)525712915;
				switch (num2 == num)
				{
				}
				num = (short)215613440;
				if (num != 0)
				{
				}
				num = (short)1940520961;
				if (num != 0)
				{
				}
				num = (short)1536557056;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPadAsteriskButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1902903297;
				if (num != 0)
				{
				}
				num = (short)1982585223;
				short num2 = num;
				num = (short)1928649095;
				switch (num2 == num)
				{
				}
				num = (short)599457792;
				if (num != 0)
				{
				}
				num = (short)1917452288;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadAsteriskButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00051D30 File Offset: 0x0004FF30
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00051DE8 File Offset: 0x0004FFE8
		public bool DialPadAsteriskButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)975050156;
				short num2 = num;
				num = (short)268047788;
				switch (num2 == num)
				{
				}
				num = (short)1336672257;
				if (num != 0)
				{
				}
				num = (short)1031077888;
				if (num != 0)
				{
				}
				num = (short)1108869120;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPadAsteriskButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1854268509;
				short num2 = num;
				num = (short)1387127901;
				switch (num2 == num)
				{
				}
				num = (short)1094844417;
				if (num != 0)
				{
				}
				num = (short)893517824;
				if (num != 0)
				{
				}
				num = (short)323092480;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadAsteriskButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00051EA4 File Offset: 0x000500A4
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00051F5C File Offset: 0x0005015C
		public string DialPadAsteriskButtonFeatureUIValue
		{
			get
			{
				short num = (short)1619366029;
				short num2 = num;
				num = (short)1393004685;
				switch (num2 == num)
				{
				}
				num = (short)1215234048;
				if (num != 0)
				{
				}
				num = (short)838336513;
				if (num != 0)
				{
				}
				num = (short)581369856;
				short num3 = num;
				return (string)base.GetValue(KeypadGraphicView.DialPadAsteriskButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1828337808;
				short num2 = num;
				num = (short)721893520;
				switch (num2 == num)
				{
				}
				num = (short)854654977;
				if (num != 0)
				{
				}
				num = (short)720371712;
				if (num != 0)
				{
				}
				num = (short)1238237184;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadAsteriskButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00052010 File Offset: 0x00050210
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x000520C8 File Offset: 0x000502C8
		public AcpListField DialPadAsteriskButtonFeatureList
		{
			get
			{
				short num = (short)445818539;
				short num2 = num;
				num = (short)1033807531;
				switch (num2 == num)
				{
				}
				num = (short)346619905;
				if (num != 0)
				{
				}
				num = (short)66715648;
				if (num != 0)
				{
				}
				num = (short)1330446336;
				short num3 = num;
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPadAsteriskButtonFeatureListProperty);
			}
			set
			{
				short num = (short)876377019;
				short num2 = num;
				num = (short)804484027;
				switch (num2 == num)
				{
				}
				num = (short)2131099649;
				if (num != 0)
				{
				}
				num = (short)1466236928;
				if (num != 0)
				{
				}
				num = (short)1433927680;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadAsteriskButtonFeatureListProperty, value);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0005217C File Offset: 0x0005037C
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00052238 File Offset: 0x00050438
		public bool DialPadAsteriskButtonIndexIsAcpValid
		{
			get
			{
				short num = (short)787055057;
				short num2 = num;
				num = (short)2035581393;
				switch (num2 == num)
				{
				}
				num = (short)1706426369;
				if (num != 0)
				{
				}
				num = (short)2068250624;
				if (num != 0)
				{
				}
				num = (short)1674706944;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPadAsteriskButtonIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)417074398;
				short num2 = num;
				num = (short)278727902;
				switch (num2 == num)
				{
				}
				num = (short)300810240;
				if (num != 0)
				{
				}
				num = (short)1566441473;
				if (num != 0)
				{
				}
				num = (short)85852160;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadAsteriskButtonIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000522F4 File Offset: 0x000504F4
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x000523B0 File Offset: 0x000505B0
		public bool DialPadAsteriskButtonIndexIsAcpApplicable
		{
			get
			{
				short num = (short)271982246;
				short num2 = num;
				num = (short)711794342;
				switch (num2 == num)
				{
				}
				num = (short)1454833665;
				if (num != 0)
				{
				}
				num = (short)462159872;
				if (num != 0)
				{
				}
				num = (short)1739259904;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPadAsteriskButtonIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)361013612;
				short num2 = num;
				num = (short)607494508;
				switch (num2 == num)
				{
				}
				num = (short)389808129;
				if (num != 0)
				{
				}
				num = (short)2109669376;
				if (num != 0)
				{
				}
				num = (short)2016018432;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadAsteriskButtonIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00052474 File Offset: 0x00050674
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x0005252C File Offset: 0x0005072C
		public bool DialPadAsteriskButtonIndexIsAcpVisible
		{
			get
			{
				short num = (short)2023555073;
				if (num != 0)
				{
				}
				num = (short)1426194094;
				short num2 = num;
				num = (short)387120814;
				switch (num2 == num)
				{
				}
				num = (short)2103246848;
				if (num != 0)
				{
				}
				num = (short)1406533632;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPadAsteriskButtonIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2053315055;
				short num2 = num;
				num = (short)655301103;
				switch (num2 == num)
				{
				}
				num = (short)1600258049;
				if (num != 0)
				{
				}
				num = (short)926482432;
				if (num != 0)
				{
				}
				num = (short)1974796288;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadAsteriskButtonIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x000525E8 File Offset: 0x000507E8
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x000526A0 File Offset: 0x000508A0
		public bool DialPadAsteriskButtonIndexIsAcpEditable
		{
			get
			{
				short num = (short)1896048164;
				short num2 = num;
				num = (short)1179543076;
				switch (num2 == num)
				{
				}
				num = (short)230031361;
				if (num != 0)
				{
				}
				num = (short)1697120256;
				if (num != 0)
				{
				}
				num = (short)658767872;
				short num3 = num;
				return (bool)base.GetValue(KeypadGraphicView.DialPadAsteriskButtonIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2042366506;
				short num2 = num;
				num = (short)738789930;
				switch (num2 == num)
				{
				}
				num = (short)305790977;
				if (num != 0)
				{
				}
				num = (short)642252800;
				if (num != 0)
				{
				}
				num = (short)1912668160;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadAsteriskButtonIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0005275C File Offset: 0x0005095C
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00052818 File Offset: 0x00050A18
		public string DialPadAsteriskButtonIndexUIValue
		{
			get
			{
				short num = (short)405530219;
				short num2 = num;
				num = (short)1268508267;
				switch (num2 == num)
				{
				}
				num = (short)356122625;
				if (num != 0)
				{
				}
				num = (short)688652288;
				if (num != 0)
				{
				}
				num = (short)1876754432;
				short num3 = num;
				return (string)base.GetValue(KeypadGraphicView.DialPadAsteriskButtonIndexUIValueProperty);
			}
			set
			{
				short num = (short)1252020004;
				short num2 = num;
				num = (short)230379300;
				switch (num2 == num)
				{
				}
				num = (short)825950209;
				if (num != 0)
				{
				}
				num = (short)1459224576;
				if (num != 0)
				{
				}
				num = (short)1479737344;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadAsteriskButtonIndexUIValueProperty, value);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x000528CC File Offset: 0x00050ACC
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00052984 File Offset: 0x00050B84
		public AcpListField DialPadAsteriskButtonIndexList
		{
			get
			{
				short num = (short)859645760;
				short num2 = num;
				num = (short)954935104;
				switch (num2 == num)
				{
				}
				num = (short)1910308865;
				if (num != 0)
				{
				}
				num = (short)1058603008;
				if (num != 0)
				{
				}
				num = (short)111149056;
				short num3 = num;
				return (AcpListField)base.GetValue(KeypadGraphicView.DialPadAsteriskButtonIndexListProperty);
			}
			set
			{
				short num = (short)200093321;
				short num2 = num;
				num = (short)1932865161;
				switch (num2 == num)
				{
				}
				num = (short)291635201;
				if (num != 0)
				{
				}
				num = (short)1342570496;
				if (num != 0)
				{
				}
				num = (short)592117760;
				short num3 = num;
				base.SetValue(KeypadGraphicView.DialPadAsteriskButtonIndexListProperty, value);
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00053DA0 File Offset: 0x00051FA0
		// Note: this type is marked as 'beforefieldinit'.
		static KeypadGraphicView()
		{
			int a_ = 9;
			short num = (short)1654147341;
			short num2 = num;
			num = (short)1196050701;
			switch (num2 == num)
			{
			}
			num = (short)974061568;
			if (num != 0)
			{
			}
			num = (short)1340997632;
			short num3 = num;
			num = (short)953352193;
			if (num != 0)
			{
			}
			KeypadGraphicView.DialPad0ButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿牁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧୩kݭᑯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad0ButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿牁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ⥧ᩩᱫɭ᥯ᅱᕳᑵᑷό", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad0ButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿牁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧ͩὫݭቯṱᅳ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad0ButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿牁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥⵧ๩իᩭᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad0ButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿牁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ଢ଼⥟㑡գ੥ᵧཀྵ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad0ButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿牁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ቝय़ᅡၣ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad0ButtonIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿牁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ݥѧͩ࡫", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad0ButtonIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿牁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ╣ᙥᡧ٩ի൭ᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad0ButtonIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿牁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ཥ᭧ͩ๫ɭᕯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad0ButtonIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿牁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡⅣɥŧṩ൫౭ᱯ᝱", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad0ButtonIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿牁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ཙᕛ࡝ş๡ᅣͥ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad0ButtonIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿牁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ᙙ㕛ⵝᑟ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad1ButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿獁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧୩kݭᑯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad1ButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿獁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ⥧ᩩᱫɭ᥯ᅱᕳᑵᑷό", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad1ButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿獁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧ͩὫݭቯṱᅳ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad1ButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿獁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥⵧ๩իᩭᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad1ButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿獁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ଢ଼⥟㑡գ੥ᵧཀྵ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad1ButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿獁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ቝय़ᅡၣ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad1ButtonIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿獁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ݥѧͩ࡫", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad1ButtonIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿獁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ╣ᙥᡧ٩ի൭ᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad1ButtonIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿獁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ཥ᭧ͩ๫ɭᕯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad1ButtonIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿獁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡⅣɥŧṩ൫౭ᱯ᝱", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad1ButtonIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿獁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ཙᕛ࡝ş๡ᅣͥ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad1ButtonIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿獁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ᙙ㕛ⵝᑟ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad2ButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿灁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧୩kݭᑯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad2ButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿灁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ⥧ᩩᱫɭ᥯ᅱᕳᑵᑷό", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad2ButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿灁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧ͩὫݭቯṱᅳ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad2ButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿灁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥⵧ๩իᩭᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad2ButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿灁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ଢ଼⥟㑡գ੥ᵧཀྵ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad2ButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿灁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ቝय़ᅡၣ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad2ButtonIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿灁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ݥѧͩ࡫", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad2ButtonIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿灁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ╣ᙥᡧ٩ի൭ᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad2ButtonIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿灁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ཥ᭧ͩ๫ɭᕯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad2ButtonIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿灁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡⅣɥŧṩ൫౭ᱯ᝱", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad2ButtonIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿灁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ཙᕛ࡝ş๡ᅣͥ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad2ButtonIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿灁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ᙙ㕛ⵝᑟ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad3ButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿煁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧୩kݭᑯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad3ButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿煁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ⥧ᩩᱫɭ᥯ᅱᕳᑵᑷό", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad3ButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿煁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧ͩὫݭቯṱᅳ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad3ButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿煁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥⵧ๩իᩭᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad3ButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿煁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ଢ଼⥟㑡գ੥ᵧཀྵ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad3ButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿煁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ቝय़ᅡၣ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad3ButtonIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿煁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ݥѧͩ࡫", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad3ButtonIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿煁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ╣ᙥᡧ٩ի൭ᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad3ButtonIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿煁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ཥ᭧ͩ๫ɭᕯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad3ButtonIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿煁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡⅣɥŧṩ൫౭ᱯ᝱", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad3ButtonIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿煁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ཙᕛ࡝ş๡ᅣͥ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad3ButtonIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿煁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ᙙ㕛ⵝᑟ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad4ButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿癁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧୩kݭᑯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad4ButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿癁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ⥧ᩩᱫɭ᥯ᅱᕳᑵᑷό", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad4ButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿癁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧ͩὫݭቯṱᅳ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad4ButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿癁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥⵧ๩իᩭᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad4ButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿癁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ଢ଼⥟㑡գ੥ᵧཀྵ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad4ButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿癁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ቝय़ᅡၣ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad4ButtonIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿癁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ݥѧͩ࡫", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad4ButtonIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿癁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ╣ᙥᡧ٩ի൭ᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad4ButtonIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿癁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ཥ᭧ͩ๫ɭᕯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad4ButtonIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿癁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡⅣɥŧṩ൫౭ᱯ᝱", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad4ButtonIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿癁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ཙᕛ࡝ş๡ᅣͥ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad4ButtonIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿癁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ᙙ㕛ⵝᑟ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad5ButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿睁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧୩kݭᑯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad5ButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿睁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ⥧ᩩᱫɭ᥯ᅱᕳᑵᑷό", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad5ButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿睁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧ͩὫݭቯṱᅳ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad5ButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿睁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥⵧ๩իᩭᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad5ButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿睁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ଢ଼⥟㑡գ੥ᵧཀྵ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad5ButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿睁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ቝय़ᅡၣ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad5ButtonIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿睁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ݥѧͩ࡫", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad5ButtonIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿睁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ╣ᙥᡧ٩ի൭ᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad5ButtonIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿睁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ཥ᭧ͩ๫ɭᕯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad5ButtonIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿睁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡⅣɥŧṩ൫౭ᱯ᝱", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad5ButtonIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿睁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ཙᕛ࡝ş๡ᅣͥ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad5ButtonIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿睁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ᙙ㕛ⵝᑟ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad6ButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿瑁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧୩kݭᑯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad6ButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿瑁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ⥧ᩩᱫɭ᥯ᅱᕳᑵᑷό", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad6ButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿瑁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧ͩὫݭቯṱᅳ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad6ButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿瑁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥⵧ๩իᩭᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad6ButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿瑁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ଢ଼⥟㑡գ੥ᵧཀྵ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad6ButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿瑁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ቝय़ᅡၣ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad6ButtonIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿瑁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ݥѧͩ࡫", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad6ButtonIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿瑁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ╣ᙥᡧ٩ի൭ᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad6ButtonIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿瑁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ཥ᭧ͩ๫ɭᕯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad6ButtonIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿瑁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡⅣɥŧṩ൫౭ᱯ᝱", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad6ButtonIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿瑁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ཙᕛ࡝ş๡ᅣͥ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad6ButtonIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿瑁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ᙙ㕛ⵝᑟ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad7ButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿畁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧୩kݭᑯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad7ButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿畁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ⥧ᩩᱫɭ᥯ᅱᕳᑵᑷό", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad7ButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿畁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧ͩὫݭቯṱᅳ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad7ButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿畁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥⵧ๩իᩭᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad7ButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿畁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ଢ଼⥟㑡գ੥ᵧཀྵ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad7ButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿畁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ቝय़ᅡၣ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad7ButtonIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿畁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ݥѧͩ࡫", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad7ButtonIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿畁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ╣ᙥᡧ٩ի൭ᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad7ButtonIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿畁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ཥ᭧ͩ๫ɭᕯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad7ButtonIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿畁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡⅣɥŧṩ൫౭ᱯ᝱", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad7ButtonIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿畁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ཙᕛ࡝ş๡ᅣͥ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad7ButtonIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿畁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ᙙ㕛ⵝᑟ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad8ButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿穁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧୩kݭᑯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad8ButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿穁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ⥧ᩩᱫɭ᥯ᅱᕳᑵᑷό", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad8ButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿穁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧ͩὫݭቯṱᅳ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad8ButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿穁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥⵧ๩իᩭᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad8ButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿穁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ଢ଼⥟㑡գ੥ᵧཀྵ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad8ButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿穁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ቝय़ᅡၣ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad8ButtonIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿穁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ݥѧͩ࡫", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad8ButtonIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿穁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ╣ᙥᡧ٩ի൭ᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad8ButtonIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿穁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ཥ᭧ͩ๫ɭᕯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad8ButtonIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿穁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡⅣɥŧṩ൫౭ᱯ᝱", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad8ButtonIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿穁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ཙᕛ࡝ş๡ᅣͥ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad8ButtonIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿穁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ᙙ㕛ⵝᑟ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad9ButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿筁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧୩kݭᑯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad9ButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿筁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ⥧ᩩᱫɭ᥯ᅱᕳᑵᑷό", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad9ButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿筁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥ㹧ͩὫݭቯṱᅳ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad9ButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿筁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛᝝፟⍡ݣᙥⵧ๩իᩭᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad9ButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿筁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ଢ଼⥟㑡գ੥ᵧཀྵ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad9ButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿筁ك㍅㱇㹉⍋⁍ᙏ㝑㕓≕ⵗ⡙㥛ቝय़ᅡၣ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad9ButtonIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿筁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ݥѧͩ࡫", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad9ButtonIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿筁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ╣ᙥᡧ٩ի൭ᅯၱᡳ፵", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad9ButtonIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿筁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡ㉣ཥ᭧ͩ๫ɭᕯ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad9ButtonIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿筁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ፙ⽛Ὕ͟ቡⅣɥŧṩ൫౭ᱯ᝱", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPad9ButtonIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿筁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ཙᕛ࡝ş๡ᅣͥ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPad9ButtonIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿筁ك㍅㱇㹉⍋⁍᥏㱑こ㍕⁗ᙙ㕛ⵝᑟ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadPoundButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿ቁ⭃㍅♇⹉๋㭍⑏♑㭓㡕ṗ㽙㵛⩝ᕟၡţ⽥᭧⭩ཫṭ♯፱ᡳήᱷ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadPoundButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿ቁ⭃㍅♇⹉๋㭍⑏♑㭓㡕ṗ㽙㵛⩝ᕟၡţ⽥᭧⭩ཫṭㅯɱѳ᩵ᅷ᥹ᵻᱽ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadPoundButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿ቁ⭃㍅♇⹉๋㭍⑏♑㭓㡕ṗ㽙㵛⩝ᕟၡţ⽥᭧⭩ཫṭ♯᭱ݳή᩷ᙹ᥻", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadPoundButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿ቁ⭃㍅♇⹉๋㭍⑏♑㭓㡕ṗ㽙㵛⩝ᕟၡţ⽥᭧⭩ཫṭ㕯ᙱᵳɵ᥷᡹ၻ᭽", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadPoundButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿ቁ⭃㍅♇⹉๋㭍⑏♑㭓㡕ṗ㽙㵛⩝ᕟၡţ㍥Ⅷ㱩൫ɭկ᝱", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPadPoundButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿ቁ⭃㍅♇⹉๋㭍⑏♑㭓㡕ṗ㽙㵛⩝ᕟၡţ⩥ŧᥩᡫ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadPoundButtonIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿ቁ⭃㍅♇⹉๋㭍⑏♑㭓㡕ᅗ㑙㡛㭝ᡟ⭡ᝣ❥୧ᩩ㩫཭ᱯ᭱ၳ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadPoundButtonIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿ቁ⭃㍅♇⹉๋㭍⑏♑㭓㡕ᅗ㑙㡛㭝ᡟ⭡ᝣ❥୧ᩩ⵫ṭoṱᵳᕵ᥷᡹ၻ᭽", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadPoundButtonIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿ቁ⭃㍅♇⹉๋㭍⑏♑㭓㡕ᅗ㑙㡛㭝ᡟ⭡ᝣ❥୧ᩩ㩫ݭͯ᭱ᙳ᩵ᵷ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadPoundButtonIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿ቁ⭃㍅♇⹉๋㭍⑏♑㭓㡕ᅗ㑙㡛㭝ᡟ⭡ᝣ❥୧ᩩ⥫੭᥯ٱᕳᑵᑷό", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadPoundButtonIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿ቁ⭃㍅♇⹉๋㭍⑏♑㭓㡕ᅗ㑙㡛㭝ᡟ㝡ⵣづ१٩ᥫ୭", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPadPoundButtonIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿ቁ⭃㍅♇⹉๋㭍⑏♑㭓㡕ᅗ㑙㡛㭝ᡟ⹡ൣᕥᱧ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadAsteriskButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿́㝃㉅ⵇ㡉╋㵍㭏ၑ⅓≕ⱗ㕙㉛ᡝ՟͡ၣ፥ᩧཀྵ╫ᵭㅯᅱѳ⁵᥷ᙹᕻ᩽", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadAsteriskButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿́㝃㉅ⵇ㡉╋㵍㭏ၑ⅓≕ⱗ㕙㉛ᡝ՟͡ၣ፥ᩧཀྵ╫ᵭㅯᅱѳ㝵ࡷ੹ၻ᝽", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadAsteriskButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿́㝃㉅ⵇ㡉╋㵍㭏ၑ⅓≕ⱗ㕙㉛ᡝ՟͡ၣ፥ᩧཀྵ╫ᵭㅯᅱѳ⁵ᅷॹᕻᱽ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadAsteriskButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿́㝃㉅ⵇ㡉╋㵍㭏ၑ⅓≕ⱗ㕙㉛ᡝ՟͡ၣ፥ᩧཀྵ╫ᵭㅯᅱѳ㍵ᱷ፹ࡻώ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadAsteriskButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿́㝃㉅ⵇ㡉╋㵍㭏ၑ⅓≕ⱗ㕙㉛ᡝ՟͡ၣ፥ᩧཀྵ㥫❭♯፱ᡳ͵ᵷ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPadAsteriskButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿́㝃㉅ⵇ㡉╋㵍㭏ၑ⅓≕ⱗ㕙㉛ᡝ՟͡ၣ፥ᩧཀྵ⁫ݭͯٱ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadAsteriskButtonIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿́㝃㉅ⵇ㡉╋㵍㭏ၑ⅓≕ⱗ㕙㉛᝝๟١ţṥⅧᥩ⵫൭o⑱ᕳ᩵ᅷṹ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadAsteriskButtonIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿́㝃㉅ⵇ㡉╋㵍㭏ၑ⅓≕ⱗ㕙㉛᝝๟١ţṥⅧᥩ⵫൭o㍱ѳٵᑷ፹ύώ", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadAsteriskButtonIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿́㝃㉅ⵇ㡉╋㵍㭏ၑ⅓≕ⱗ㕙㉛᝝๟١ţṥⅧᥩ⵫൭o⑱ᵳյᅷ᡹ၻ᭽", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadAsteriskButtonIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿́㝃㉅ⵇ㡉╋㵍㭏ၑ⅓≕ⱗ㕙㉛᝝๟١ţṥⅧᥩ⵫൭o㝱ၳή౷᭹ṻች", a_), typeof(bool), typeof(KeypadGraphicView));
			KeypadGraphicView.DialPadAsteriskButtonIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿́㝃㉅ⵇ㡉╋㵍㭏ၑ⅓≕ⱗ㕙㉛᝝๟١ţṥ㵧⍩㩫཭ᱯݱᅳ", a_), typeof(string), typeof(KeypadGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadGraphicView.DialPadAsteriskButtonIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀳張夷嘹氻弽␿́㝃㉅ⵇ㡉╋㵍㭏ၑ⅓≕ⱗ㕙㉛᝝๟١ţṥ⑧ͩὫᩭ", a_), typeof(AcpListField), typeof(KeypadGraphicView));
		}

		// Token: 0x04000551 RID: 1361
		public static DependencyProperty DialPad0ButtonFeatureIsAcpValidProperty;

		// Token: 0x04000552 RID: 1362
		public static DependencyProperty DialPad0ButtonFeatureIsAcpApplicableProperty;

		// Token: 0x04000553 RID: 1363
		public static DependencyProperty DialPad0ButtonFeatureIsAcpVisibleProperty;

		// Token: 0x04000554 RID: 1364
		public static DependencyProperty DialPad0ButtonFeatureIsAcpEditableProperty;

		// Token: 0x04000555 RID: 1365
		public static DependencyProperty DialPad0ButtonFeatureUIValueProperty;

		// Token: 0x04000556 RID: 1366
		public static DependencyProperty DialPad0ButtonFeatureListProperty;

		// Token: 0x04000557 RID: 1367
		public static DependencyProperty DialPad0ButtonIndexIsAcpValidProperty;

		// Token: 0x04000558 RID: 1368
		public static DependencyProperty DialPad0ButtonIndexIsAcpApplicableProperty;

		// Token: 0x04000559 RID: 1369
		public static DependencyProperty DialPad0ButtonIndexIsAcpVisibleProperty;

		// Token: 0x0400055A RID: 1370
		public static DependencyProperty DialPad0ButtonIndexIsAcpEditableProperty;

		// Token: 0x0400055B RID: 1371
		public static DependencyProperty DialPad0ButtonIndexUIValueProperty;

		// Token: 0x0400055C RID: 1372
		public static DependencyProperty DialPad0ButtonIndexListProperty;

		// Token: 0x0400055D RID: 1373
		public static DependencyProperty DialPad1ButtonFeatureIsAcpValidProperty;

		// Token: 0x0400055E RID: 1374
		public static DependencyProperty DialPad1ButtonFeatureIsAcpApplicableProperty;

		// Token: 0x0400055F RID: 1375
		public static DependencyProperty DialPad1ButtonFeatureIsAcpVisibleProperty;

		// Token: 0x04000560 RID: 1376
		public static DependencyProperty DialPad1ButtonFeatureIsAcpEditableProperty;

		// Token: 0x04000561 RID: 1377
		public static DependencyProperty DialPad1ButtonFeatureUIValueProperty;

		// Token: 0x04000562 RID: 1378
		public static DependencyProperty DialPad1ButtonFeatureListProperty;

		// Token: 0x04000563 RID: 1379
		public static DependencyProperty DialPad1ButtonIndexIsAcpValidProperty;

		// Token: 0x04000564 RID: 1380
		public static DependencyProperty DialPad1ButtonIndexIsAcpApplicableProperty;

		// Token: 0x04000565 RID: 1381
		public static DependencyProperty DialPad1ButtonIndexIsAcpVisibleProperty;

		// Token: 0x04000566 RID: 1382
		public static DependencyProperty DialPad1ButtonIndexIsAcpEditableProperty;

		// Token: 0x04000567 RID: 1383
		public static DependencyProperty DialPad1ButtonIndexUIValueProperty;

		// Token: 0x04000568 RID: 1384
		public static DependencyProperty DialPad1ButtonIndexListProperty;

		// Token: 0x04000569 RID: 1385
		public static DependencyProperty DialPad2ButtonFeatureIsAcpValidProperty;

		// Token: 0x0400056A RID: 1386
		public static DependencyProperty DialPad2ButtonFeatureIsAcpApplicableProperty;

		// Token: 0x0400056B RID: 1387
		public static DependencyProperty DialPad2ButtonFeatureIsAcpVisibleProperty;

		// Token: 0x0400056C RID: 1388
		public static DependencyProperty DialPad2ButtonFeatureIsAcpEditableProperty;

		// Token: 0x0400056D RID: 1389
		public static DependencyProperty DialPad2ButtonFeatureUIValueProperty;

		// Token: 0x0400056E RID: 1390
		public static DependencyProperty DialPad2ButtonFeatureListProperty;

		// Token: 0x0400056F RID: 1391
		public static DependencyProperty DialPad2ButtonIndexIsAcpValidProperty;

		// Token: 0x04000570 RID: 1392
		public static DependencyProperty DialPad2ButtonIndexIsAcpApplicableProperty;

		// Token: 0x04000571 RID: 1393
		public static DependencyProperty DialPad2ButtonIndexIsAcpVisibleProperty;

		// Token: 0x04000572 RID: 1394
		public static DependencyProperty DialPad2ButtonIndexIsAcpEditableProperty;

		// Token: 0x04000573 RID: 1395
		public static DependencyProperty DialPad2ButtonIndexUIValueProperty;

		// Token: 0x04000574 RID: 1396
		public static DependencyProperty DialPad2ButtonIndexListProperty;

		// Token: 0x04000575 RID: 1397
		public static DependencyProperty DialPad3ButtonFeatureIsAcpValidProperty;

		// Token: 0x04000576 RID: 1398
		public static DependencyProperty DialPad3ButtonFeatureIsAcpApplicableProperty;

		// Token: 0x04000577 RID: 1399
		public static DependencyProperty DialPad3ButtonFeatureIsAcpVisibleProperty;

		// Token: 0x04000578 RID: 1400
		public static DependencyProperty DialPad3ButtonFeatureIsAcpEditableProperty;

		// Token: 0x04000579 RID: 1401
		public static DependencyProperty DialPad3ButtonFeatureUIValueProperty;

		// Token: 0x0400057A RID: 1402
		public static DependencyProperty DialPad3ButtonFeatureListProperty;

		// Token: 0x0400057B RID: 1403
		public static DependencyProperty DialPad3ButtonIndexIsAcpValidProperty;

		// Token: 0x0400057C RID: 1404
		public static DependencyProperty DialPad3ButtonIndexIsAcpApplicableProperty;

		// Token: 0x0400057D RID: 1405
		public static DependencyProperty DialPad3ButtonIndexIsAcpVisibleProperty;

		// Token: 0x0400057E RID: 1406
		public static DependencyProperty DialPad3ButtonIndexIsAcpEditableProperty;

		// Token: 0x0400057F RID: 1407
		public static DependencyProperty DialPad3ButtonIndexUIValueProperty;

		// Token: 0x04000580 RID: 1408
		public static DependencyProperty DialPad3ButtonIndexListProperty;

		// Token: 0x04000581 RID: 1409
		public static DependencyProperty DialPad4ButtonFeatureIsAcpValidProperty;

		// Token: 0x04000582 RID: 1410
		public static DependencyProperty DialPad4ButtonFeatureIsAcpApplicableProperty;

		// Token: 0x04000583 RID: 1411
		public static DependencyProperty DialPad4ButtonFeatureIsAcpVisibleProperty;

		// Token: 0x04000584 RID: 1412
		public static DependencyProperty DialPad4ButtonFeatureIsAcpEditableProperty;

		// Token: 0x04000585 RID: 1413
		public static DependencyProperty DialPad4ButtonFeatureUIValueProperty;

		// Token: 0x04000586 RID: 1414
		public static DependencyProperty DialPad4ButtonFeatureListProperty;

		// Token: 0x04000587 RID: 1415
		public static DependencyProperty DialPad4ButtonIndexIsAcpValidProperty;

		// Token: 0x04000588 RID: 1416
		public static DependencyProperty DialPad4ButtonIndexIsAcpApplicableProperty;

		// Token: 0x04000589 RID: 1417
		public static DependencyProperty DialPad4ButtonIndexIsAcpVisibleProperty;

		// Token: 0x0400058A RID: 1418
		public static DependencyProperty DialPad4ButtonIndexIsAcpEditableProperty;

		// Token: 0x0400058B RID: 1419
		public static DependencyProperty DialPad4ButtonIndexUIValueProperty;

		// Token: 0x0400058C RID: 1420
		public static DependencyProperty DialPad4ButtonIndexListProperty;

		// Token: 0x0400058D RID: 1421
		public static DependencyProperty DialPad5ButtonFeatureIsAcpValidProperty;

		// Token: 0x0400058E RID: 1422
		public static DependencyProperty DialPad5ButtonFeatureIsAcpApplicableProperty;

		// Token: 0x0400058F RID: 1423
		public static DependencyProperty DialPad5ButtonFeatureIsAcpVisibleProperty;

		// Token: 0x04000590 RID: 1424
		public static DependencyProperty DialPad5ButtonFeatureIsAcpEditableProperty;

		// Token: 0x04000591 RID: 1425
		public static DependencyProperty DialPad5ButtonFeatureUIValueProperty;

		// Token: 0x04000592 RID: 1426
		public static DependencyProperty DialPad5ButtonFeatureListProperty;

		// Token: 0x04000593 RID: 1427
		public static DependencyProperty DialPad5ButtonIndexIsAcpValidProperty;

		// Token: 0x04000594 RID: 1428
		public static DependencyProperty DialPad5ButtonIndexIsAcpApplicableProperty;

		// Token: 0x04000595 RID: 1429
		public static DependencyProperty DialPad5ButtonIndexIsAcpVisibleProperty;

		// Token: 0x04000596 RID: 1430
		public static DependencyProperty DialPad5ButtonIndexIsAcpEditableProperty;

		// Token: 0x04000597 RID: 1431
		public static DependencyProperty DialPad5ButtonIndexUIValueProperty;

		// Token: 0x04000598 RID: 1432
		public static DependencyProperty DialPad5ButtonIndexListProperty;

		// Token: 0x04000599 RID: 1433
		public static DependencyProperty DialPad6ButtonFeatureIsAcpValidProperty;

		// Token: 0x0400059A RID: 1434
		public static DependencyProperty DialPad6ButtonFeatureIsAcpApplicableProperty;

		// Token: 0x0400059B RID: 1435
		public static DependencyProperty DialPad6ButtonFeatureIsAcpVisibleProperty;

		// Token: 0x0400059C RID: 1436
		public static DependencyProperty DialPad6ButtonFeatureIsAcpEditableProperty;

		// Token: 0x0400059D RID: 1437
		public static DependencyProperty DialPad6ButtonFeatureUIValueProperty;

		// Token: 0x0400059E RID: 1438
		public static DependencyProperty DialPad6ButtonFeatureListProperty;

		// Token: 0x0400059F RID: 1439
		public static DependencyProperty DialPad6ButtonIndexIsAcpValidProperty;

		// Token: 0x040005A0 RID: 1440
		public static DependencyProperty DialPad6ButtonIndexIsAcpApplicableProperty;

		// Token: 0x040005A1 RID: 1441
		public static DependencyProperty DialPad6ButtonIndexIsAcpVisibleProperty;

		// Token: 0x040005A2 RID: 1442
		public static DependencyProperty DialPad6ButtonIndexIsAcpEditableProperty;

		// Token: 0x040005A3 RID: 1443
		public static DependencyProperty DialPad6ButtonIndexUIValueProperty;

		// Token: 0x040005A4 RID: 1444
		public static DependencyProperty DialPad6ButtonIndexListProperty;

		// Token: 0x040005A5 RID: 1445
		public static DependencyProperty DialPad7ButtonFeatureIsAcpValidProperty;

		// Token: 0x040005A6 RID: 1446
		public static DependencyProperty DialPad7ButtonFeatureIsAcpApplicableProperty;

		// Token: 0x040005A7 RID: 1447
		public static DependencyProperty DialPad7ButtonFeatureIsAcpVisibleProperty;

		// Token: 0x040005A8 RID: 1448
		public static DependencyProperty DialPad7ButtonFeatureIsAcpEditableProperty;

		// Token: 0x040005A9 RID: 1449
		public static DependencyProperty DialPad7ButtonFeatureUIValueProperty;

		// Token: 0x040005AA RID: 1450
		public static DependencyProperty DialPad7ButtonFeatureListProperty;

		// Token: 0x040005AB RID: 1451
		public static DependencyProperty DialPad7ButtonIndexIsAcpValidProperty;

		// Token: 0x040005AC RID: 1452
		public static DependencyProperty DialPad7ButtonIndexIsAcpApplicableProperty;

		// Token: 0x040005AD RID: 1453
		public static DependencyProperty DialPad7ButtonIndexIsAcpVisibleProperty;

		// Token: 0x040005AE RID: 1454
		public static DependencyProperty DialPad7ButtonIndexIsAcpEditableProperty;

		// Token: 0x040005AF RID: 1455
		public static DependencyProperty DialPad7ButtonIndexUIValueProperty;

		// Token: 0x040005B0 RID: 1456
		public static DependencyProperty DialPad7ButtonIndexListProperty;

		// Token: 0x040005B1 RID: 1457
		public static DependencyProperty DialPad8ButtonFeatureIsAcpValidProperty;

		// Token: 0x040005B2 RID: 1458
		public static DependencyProperty DialPad8ButtonFeatureIsAcpApplicableProperty;

		// Token: 0x040005B3 RID: 1459
		public static DependencyProperty DialPad8ButtonFeatureIsAcpVisibleProperty;

		// Token: 0x040005B4 RID: 1460
		public static DependencyProperty DialPad8ButtonFeatureIsAcpEditableProperty;

		// Token: 0x040005B5 RID: 1461
		public static DependencyProperty DialPad8ButtonFeatureUIValueProperty;

		// Token: 0x040005B6 RID: 1462
		public static DependencyProperty DialPad8ButtonFeatureListProperty;

		// Token: 0x040005B7 RID: 1463
		public static DependencyProperty DialPad8ButtonIndexIsAcpValidProperty;

		// Token: 0x040005B8 RID: 1464
		public static DependencyProperty DialPad8ButtonIndexIsAcpApplicableProperty;

		// Token: 0x040005B9 RID: 1465
		public static DependencyProperty DialPad8ButtonIndexIsAcpVisibleProperty;

		// Token: 0x040005BA RID: 1466
		public static DependencyProperty DialPad8ButtonIndexIsAcpEditableProperty;

		// Token: 0x040005BB RID: 1467
		public static DependencyProperty DialPad8ButtonIndexUIValueProperty;

		// Token: 0x040005BC RID: 1468
		public static DependencyProperty DialPad8ButtonIndexListProperty;

		// Token: 0x040005BD RID: 1469
		public static DependencyProperty DialPad9ButtonFeatureIsAcpValidProperty;

		// Token: 0x040005BE RID: 1470
		public static DependencyProperty DialPad9ButtonFeatureIsAcpApplicableProperty;

		// Token: 0x040005BF RID: 1471
		public static DependencyProperty DialPad9ButtonFeatureIsAcpVisibleProperty;

		// Token: 0x040005C0 RID: 1472
		public static DependencyProperty DialPad9ButtonFeatureIsAcpEditableProperty;

		// Token: 0x040005C1 RID: 1473
		public static DependencyProperty DialPad9ButtonFeatureUIValueProperty;

		// Token: 0x040005C2 RID: 1474
		public static DependencyProperty DialPad9ButtonFeatureListProperty;

		// Token: 0x040005C3 RID: 1475
		public static DependencyProperty DialPad9ButtonIndexIsAcpValidProperty;

		// Token: 0x040005C4 RID: 1476
		public static DependencyProperty DialPad9ButtonIndexIsAcpApplicableProperty;

		// Token: 0x040005C5 RID: 1477
		public static DependencyProperty DialPad9ButtonIndexIsAcpVisibleProperty;

		// Token: 0x040005C6 RID: 1478
		public static DependencyProperty DialPad9ButtonIndexIsAcpEditableProperty;

		// Token: 0x040005C7 RID: 1479
		public static DependencyProperty DialPad9ButtonIndexUIValueProperty;

		// Token: 0x040005C8 RID: 1480
		public static DependencyProperty DialPad9ButtonIndexListProperty;

		// Token: 0x040005C9 RID: 1481
		public static DependencyProperty DialPadPoundButtonFeatureIsAcpValidProperty;

		// Token: 0x040005CA RID: 1482
		public static DependencyProperty DialPadPoundButtonFeatureIsAcpApplicableProperty;

		// Token: 0x040005CB RID: 1483
		public static DependencyProperty DialPadPoundButtonFeatureIsAcpVisibleProperty;

		// Token: 0x040005CC RID: 1484
		public static DependencyProperty DialPadPoundButtonFeatureIsAcpEditableProperty;

		// Token: 0x040005CD RID: 1485
		public static DependencyProperty DialPadPoundButtonFeatureUIValueProperty;

		// Token: 0x040005CE RID: 1486
		public static DependencyProperty DialPadPoundButtonFeatureListProperty;

		// Token: 0x040005CF RID: 1487
		public static DependencyProperty DialPadPoundButtonIndexIsAcpValidProperty;

		// Token: 0x040005D0 RID: 1488
		public static DependencyProperty DialPadPoundButtonIndexIsAcpApplicableProperty;

		// Token: 0x040005D1 RID: 1489
		public static DependencyProperty DialPadPoundButtonIndexIsAcpVisibleProperty;

		// Token: 0x040005D2 RID: 1490
		public static DependencyProperty DialPadPoundButtonIndexIsAcpEditableProperty;

		// Token: 0x040005D3 RID: 1491
		public static DependencyProperty DialPadPoundButtonIndexUIValueProperty;

		// Token: 0x040005D4 RID: 1492
		public static DependencyProperty DialPadPoundButtonIndexListProperty;

		// Token: 0x040005D5 RID: 1493
		public static DependencyProperty DialPadAsteriskButtonFeatureIsAcpValidProperty;

		// Token: 0x040005D6 RID: 1494
		public static DependencyProperty DialPadAsteriskButtonFeatureIsAcpApplicableProperty;

		// Token: 0x040005D7 RID: 1495
		public static DependencyProperty DialPadAsteriskButtonFeatureIsAcpVisibleProperty;

		// Token: 0x040005D8 RID: 1496
		public static DependencyProperty DialPadAsteriskButtonFeatureIsAcpEditableProperty;

		// Token: 0x040005D9 RID: 1497
		public static DependencyProperty DialPadAsteriskButtonFeatureUIValueProperty;

		// Token: 0x040005DA RID: 1498
		public static DependencyProperty DialPadAsteriskButtonFeatureListProperty;

		// Token: 0x040005DB RID: 1499
		public static DependencyProperty DialPadAsteriskButtonIndexIsAcpValidProperty;

		// Token: 0x040005DC RID: 1500
		public static DependencyProperty DialPadAsteriskButtonIndexIsAcpApplicableProperty;

		// Token: 0x040005DD RID: 1501
		public static DependencyProperty DialPadAsteriskButtonIndexIsAcpVisibleProperty;

		// Token: 0x040005DE RID: 1502
		public static DependencyProperty DialPadAsteriskButtonIndexIsAcpEditableProperty;

		// Token: 0x040005DF RID: 1503
		public static DependencyProperty DialPadAsteriskButtonIndexUIValueProperty;

		// Token: 0x040005E0 RID: 1504
		public static DependencyProperty DialPadAsteriskButtonIndexListProperty;
	}
}
