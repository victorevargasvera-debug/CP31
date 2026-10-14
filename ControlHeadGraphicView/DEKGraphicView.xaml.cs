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
using ControlHeadGraphicView.acpcontrol;
using ControlHeadGraphicView.converters;

namespace ControlHeadGraphicView
{
	// Token: 0x02000003 RID: 3
	public partial class DEKGraphicView : UserControl
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public DEKGraphicView()
		{
			base.FlowDirection = FlowDirection.LeftToRight;
			this.InitializeComponent();
			base.DataContext = this;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002144 File Offset: 0x00000344
		private void OnFieldNameDoubleClick(object sender, RoutedEventArgs e)
		{
			short num = (short)1549698592;
			short num2 = num;
			num = (short)843679264;
			switch (num2 == num)
			{
			}
			num = (short)1799553025;
			if (num != 0)
			{
			}
			num = (short)192086016;
			short num3 = num;
			num = (short)1888157696;
			if (num != 0)
			{
			}
			Utility.GetFieldHelpText(sender);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000021F4 File Offset: 0x000003F4
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000022AC File Offset: 0x000004AC
		public bool DEKButton0FeatureIsAcpValid
		{
			get
			{
				short num = (short)1901466945;
				short num2 = num;
				num = (short)368317761;
				switch (num2 == num)
				{
				}
				num = (short)1302986753;
				if (num != 0)
				{
				}
				num = (short)2027749376;
				short num3 = num;
				num = (short)1131937792;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton0FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)781751613;
				short num2 = num;
				num = (short)408130877;
				switch (num2 == num)
				{
				}
				num = (short)1679622144;
				if (num != 0)
				{
				}
				num = (short)2107572224;
				short num3 = num;
				num = (short)1239941121;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002368 File Offset: 0x00000568
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002424 File Offset: 0x00000624
		public bool DEKButton0FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)84449591;
				short num2 = num;
				num = (short)1131977015;
				switch (num2 == num)
				{
				}
				num = (short)743309312;
				if (num != 0)
				{
				}
				num = (short)581763072;
				short num3 = num;
				num = (short)740622337;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton0FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1569612945;
				short num2 = num;
				num = (short)946300049;
				switch (num2 == num)
				{
				}
				num = (short)2074017793;
				if (num != 0)
				{
				}
				num = (short)1075970048;
				short num3 = num;
				num = (short)342556672;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000024E0 File Offset: 0x000006E0
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002598 File Offset: 0x00000798
		public bool DEKButton0FeatureIsAcpVisible
		{
			get
			{
				short num = (short)457814038;
				short num2 = num;
				num = (short)1604235286;
				switch (num2 == num)
				{
				}
				num = (short)45285377;
				if (num != 0)
				{
				}
				num = (short)80936960;
				short num3 = num;
				num = (short)1210253312;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton0FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1695316526;
				short num2 = num;
				num = (short)554138158;
				switch (num2 == num)
				{
				}
				num = (short)2126315521;
				if (num != 0)
				{
				}
				num = (short)1531314176;
				short num3 = num;
				num = (short)416612352;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002654 File Offset: 0x00000854
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002710 File Offset: 0x00000910
		public bool DEKButton0FeatureIsAcpEditable
		{
			get
			{
				short num = (short)817954485;
				short num2 = num;
				num = (short)511377077;
				switch (num2 == num)
				{
				}
				num = (short)690618369;
				if (num != 0)
				{
				}
				num = (short)513736704;
				short num3 = num;
				num = (short)1254293504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton0FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)920015981;
				short num2 = num;
				num = (short)1667322989;
				switch (num2 == num)
				{
				}
				num = (short)385220609;
				if (num != 0)
				{
				}
				num = (short)1682702336;
				short num3 = num;
				num = (short)987430912;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000027C8 File Offset: 0x000009C8
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002880 File Offset: 0x00000A80
		public string DEKButton0FeatureUIValue
		{
			get
			{
				short num = (short)327571538;
				short num2 = num;
				num = (short)1158436946;
				switch (num2 == num)
				{
				}
				num = (short)653852672;
				if (num != 0)
				{
				}
				num = (short)1562902528;
				short num3 = num;
				num = (short)640352257;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton0FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1013252097;
				if (num != 0)
				{
				}
				num = (short)310111609;
				short num2 = num;
				num = (short)1297280377;
				switch (num2 == num)
				{
				}
				num = (short)1733427200;
				short num3 = num;
				num = (short)99876864;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002938 File Offset: 0x00000B38
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000029F0 File Offset: 0x00000BF0
		public AcpListField DEKButton0FeatureList
		{
			get
			{
				short num = (short)77293132;
				short num2 = num;
				num = (short)1033135692;
				switch (num2 == num)
				{
				}
				num = (short)1915748353;
				if (num != 0)
				{
				}
				num = (short)1622081536;
				short num3 = num;
				num = (short)1910767616;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton0FeatureListProperty);
			}
			set
			{
				short num = (short)2015412343;
				short num2 = num;
				num = (short)930267255;
				switch (num2 == num)
				{
				}
				num = (short)171376641;
				if (num != 0)
				{
				}
				num = (short)540147712;
				short num3 = num;
				num = (short)316211200;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0FeatureListProperty, value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002AA4 File Offset: 0x00000CA4
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002B5C File Offset: 0x00000D5C
		public bool DEKButton0IndexIsAcpValid
		{
			get
			{
				short num = (short)1701701711;
				short num2 = num;
				num = (short)349497423;
				switch (num2 == num)
				{
				}
				num = (short)1112539137;
				if (num != 0)
				{
				}
				num = (short)960692224;
				short num3 = num;
				num = (short)752549888;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton0IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)859838719;
				short num2 = num;
				num = (short)1269897471;
				switch (num2 == num)
				{
				}
				num = (short)1326055425;
				if (num != 0)
				{
				}
				num = (short)1359740928;
				short num3 = num;
				num = (short)96403456;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002C14 File Offset: 0x00000E14
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002CD0 File Offset: 0x00000ED0
		public bool DEKButton0IndexIsAcpApplicable
		{
			get
			{
				short num = (short)1851719681;
				if (num != 0)
				{
				}
				num = (short)1848755465;
				short num2 = num;
				num = (short)1818346761;
				switch (num2 == num)
				{
				}
				num = (short)1896284160;
				short num3 = num;
				num = (short)2010644480;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton0IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1007930960;
				short num2 = num;
				num = (short)1766968912;
				switch (num2 == num)
				{
				}
				num = (short)553123840;
				if (num != 0)
				{
				}
				num = (short)1771438080;
				short num3 = num;
				num = (short)627507201;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002D8C File Offset: 0x00000F8C
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002E44 File Offset: 0x00001044
		public bool DEKButton0IndexIsAcpVisible
		{
			get
			{
				short num = (short)313596975;
				short num2 = num;
				num = (short)1307712559;
				switch (num2 == num)
				{
				}
				num = (short)1842282497;
				if (num != 0)
				{
				}
				num = (short)649986048;
				short num3 = num;
				num = (short)1614741504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton0IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1668633991;
				short num2 = num;
				num = (short)1453938055;
				switch (num2 == num)
				{
				}
				num = (short)147652608;
				if (num != 0)
				{
				}
				num = (short)915603456;
				short num3 = num;
				num = (short)482738177;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002EFC File Offset: 0x000010FC
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002FB4 File Offset: 0x000011B4
		public bool DEKButton0IndexIsAcpEditable
		{
			get
			{
				short num = (short)1081376737;
				short num2 = num;
				num = (short)459702241;
				switch (num2 == num)
				{
				}
				num = (short)2125856769;
				if (num != 0)
				{
				}
				num = (short)819462144;
				short num3 = num;
				num = (short)1200357376;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton0IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)637077712;
				short num2 = num;
				num = (short)1959266512;
				switch (num2 == num)
				{
				}
				num = (short)1518010369;
				if (num != 0)
				{
				}
				num = (short)1011482624;
				short num3 = num;
				num = (short)935854080;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000306C File Offset: 0x0000126C
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003124 File Offset: 0x00001324
		public string DEKButton0IndexUIValue
		{
			get
			{
				short num = (short)709130318;
				short num2 = num;
				num = (short)758806606;
				switch (num2 == num)
				{
				}
				num = (short)1690370048;
				if (num != 0)
				{
				}
				num = (short)628490240;
				short num3 = num;
				num = (short)2097283073;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton0IndexUIValueProperty);
			}
			set
			{
				short num = (short)2135752705;
				if (num != 0)
				{
				}
				num = (short)610769748;
				short num2 = num;
				num = (short)1537448788;
				switch (num2 == num)
				{
				}
				num = (short)445317120;
				short num3 = num;
				num = (short)186580992;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0IndexUIValueProperty, value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000031D8 File Offset: 0x000013D8
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00003290 File Offset: 0x00001490
		public AcpRangeField<int, int> DEKButton0IndexRange
		{
			get
			{
				short num = (short)1084244331;
				short num2 = num;
				num = (short)867320171;
				switch (num2 == num)
				{
				}
				num = (short)1870856192;
				if (num != 0)
				{
				}
				num = (short)1381040128;
				short num3 = num;
				num = (short)1707343873;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton0IndexRangeProperty);
			}
			set
			{
				short num = (short)1820149986;
				short num2 = num;
				num = (short)1184975074;
				switch (num2 == num)
				{
				}
				num = (short)67305472;
				if (num != 0)
				{
				}
				num = (short)1769668608;
				short num3 = num;
				num = (short)1575354369;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0IndexRangeProperty, value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003348 File Offset: 0x00001548
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00003404 File Offset: 0x00001604
		public bool DEKButton0ZoneIsAcpValid
		{
			get
			{
				short num = (short)36603388;
				short num2 = num;
				num = (short)1205306876;
				switch (num2 == num)
				{
				}
				num = (short)1967456256;
				if (num != 0)
				{
				}
				num = (short)1606287360;
				short num3 = num;
				num = (short)246939649;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton0ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)144709651;
				short num2 = num;
				num = (short)2002327571;
				switch (num2 == num)
				{
				}
				num = (short)1794179073;
				if (num != 0)
				{
				}
				num = (short)2042626048;
				short num3 = num;
				num = (short)259653632;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000034C4 File Offset: 0x000016C4
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00003580 File Offset: 0x00001780
		public bool DEKButton0ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)504465761;
				short num2 = num;
				num = (short)346524001;
				switch (num2 == num)
				{
				}
				num = (short)1674379264;
				if (num != 0)
				{
				}
				num = (short)339083264;
				short num3 = num;
				num = (short)137297921;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton0ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)300562249;
				short num2 = num;
				num = (short)1093154633;
				switch (num2 == num)
				{
				}
				num = (short)1701314560;
				if (num != 0)
				{
				}
				num = (short)451018752;
				short num3 = num;
				num = (short)1307770881;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000363C File Offset: 0x0000183C
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000036F4 File Offset: 0x000018F4
		public bool DEKButton0ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1918432502;
				short num2 = num;
				num = (short)2106258678;
				switch (num2 == num)
				{
				}
				num = (short)1852768257;
				if (num != 0)
				{
				}
				num = (short)1591607296;
				short num3 = num;
				num = (short)2014707712;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton0ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1735458817;
				if (num != 0)
				{
				}
				num = (short)1550799574;
				short num2 = num;
				num = (short)1563054806;
				switch (num2 == num)
				{
				}
				num = (short)1561853952;
				short num3 = num;
				num = (short)2040397824;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000037AC File Offset: 0x000019AC
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00003868 File Offset: 0x00001A68
		public bool DEKButton0ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1119184166;
				short num2 = num;
				num = (short)234448166;
				switch (num2 == num)
				{
				}
				num = (short)611450881;
				if (num != 0)
				{
				}
				num = (short)230621184;
				short num3 = num;
				num = (short)1395326976;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton0ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)864707610;
				short num2 = num;
				num = (short)1583309850;
				switch (num2 == num)
				{
				}
				num = (short)1819475969;
				if (num != 0)
				{
				}
				num = (short)520814592;
				short num3 = num;
				num = (short)1087569920;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003924 File Offset: 0x00001B24
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000039E0 File Offset: 0x00001BE0
		public string DEKButton0ZoneUIValue
		{
			get
			{
				short num = (short)9564491;
				short num2 = num;
				num = (short)1734668619;
				switch (num2 == num)
				{
				}
				num = (short)1251606529;
				if (num != 0)
				{
				}
				num = (short)1044840448;
				short num3 = num;
				num = (short)1985085440;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton0ZoneUIValueProperty);
			}
			set
			{
				short num = (short)1518360719;
				short num2 = num;
				num = (short)189945999;
				switch (num2 == num)
				{
				}
				num = (short)1022230529;
				if (num != 0)
				{
				}
				num = (short)765263872;
				short num3 = num;
				num = (short)567214080;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0ZoneUIValueProperty, value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003A9C File Offset: 0x00001C9C
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00003B54 File Offset: 0x00001D54
		public AcpListField DEKButton0ZoneList
		{
			get
			{
				short num = (short)151209400;
				short num2 = num;
				num = (short)1327777208;
				switch (num2 == num)
				{
				}
				num = (short)747831297;
				if (num != 0)
				{
				}
				num = (short)637337600;
				short num3 = num;
				num = (short)1780875264;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton0ZoneListProperty);
			}
			set
			{
				short num = (short)839611694;
				short num2 = num;
				num = (short)1214739758;
				switch (num2 == num)
				{
				}
				num = (short)81788929;
				if (num != 0)
				{
				}
				num = (short)1039663104;
				short num3 = num;
				num = (short)1848246272;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton0ZoneListProperty, value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003C08 File Offset: 0x00001E08
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00003CC0 File Offset: 0x00001EC0
		public bool DEKButton0ChannelIsAcpValid
		{
			get
			{
				short num = (short)1552154625;
				if (num != 0)
				{
				}
				num = (short)108646245;
				short num2 = num;
				num = (short)2143539045;
				switch (num2 == num)
				{
				}
				num = (short)1672806400;
				if (num != 0)
				{
				}
				num = (short)127467520;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton0ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)209221299;
				short num2 = num;
				num = (short)496072371;
				switch (num2 == num)
				{
				}
				num = (short)914948097;
				if (num != 0)
				{
				}
				num = (short)1262026752;
				if (num != 0)
				{
				}
				num = (short)1877934080;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton0ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003D7C File Offset: 0x00001F7C
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00003E38 File Offset: 0x00002038
		public bool DEKButton0ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)643029176;
				short num2 = num;
				num = (short)938203320;
				switch (num2 == num)
				{
				}
				num = (short)908853248;
				if (num != 0)
				{
				}
				num = (short)481034241;
				if (num != 0)
				{
				}
				num = (short)909312000;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton0ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)293093092;
				short num2 = num;
				num = (short)652033764;
				switch (num2 == num)
				{
				}
				num = (short)1298268161;
				if (num != 0)
				{
				}
				num = (short)310312960;
				if (num != 0)
				{
				}
				num = (short)41615360;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton0ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00003EF4 File Offset: 0x000020F4
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00003FAC File Offset: 0x000021AC
		public bool DEKButton0ChannelIsAcpVisible
		{
			get
			{
				short num = (short)839042648;
				short num2 = num;
				num = (short)1766442584;
				switch (num2 == num)
				{
				}
				num = (short)2134179841;
				if (num != 0)
				{
				}
				num = (short)66781184;
				if (num != 0)
				{
				}
				num = (short)741670912;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton0ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1374402531;
				short num2 = num;
				num = (short)2048047075;
				switch (num2 == num)
				{
				}
				num = (short)115671041;
				if (num != 0)
				{
				}
				num = (short)1304100864;
				if (num != 0)
				{
				}
				num = (short)785448960;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton0ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00004068 File Offset: 0x00002268
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00004124 File Offset: 0x00002324
		public bool DEKButton0ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1593661973;
				short num2 = num;
				num = (short)1082808853;
				switch (num2 == num)
				{
				}
				num = (short)1796276225;
				if (num != 0)
				{
				}
				num = (short)79364096;
				if (num != 0)
				{
				}
				num = (short)931135488;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton0ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1507382887;
				short num2 = num;
				num = (short)79943271;
				switch (num2 == num)
				{
				}
				num = (short)980090881;
				if (num != 0)
				{
				}
				num = (short)1625948160;
				if (num != 0)
				{
				}
				num = (short)1459683328;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton0ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000041E0 File Offset: 0x000023E0
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0000429C File Offset: 0x0000249C
		public string DEKButton0ChannelUIValue
		{
			get
			{
				short num = (short)1507061402;
				short num2 = num;
				num = (short)1049161370;
				switch (num2 == num)
				{
				}
				num = (short)711917569;
				if (num != 0)
				{
				}
				num = (short)1364000768;
				if (num != 0)
				{
				}
				num = (short)161153024;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton0ChannelUIValueProperty);
			}
			set
			{
				short num = (short)242362614;
				short num2 = num;
				num = (short)1329670390;
				switch (num2 == num)
				{
				}
				num = (short)884146177;
				if (num != 0)
				{
				}
				num = (short)19267584;
				if (num != 0)
				{
				}
				num = (short)2097807360;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton0ChannelUIValueProperty, value);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00004354 File Offset: 0x00002554
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000440C File Offset: 0x0000260C
		public AcpListField DEKButton0ChannelList
		{
			get
			{
				short num = (short)714887299;
				short num2 = num;
				num = (short)1847152771;
				switch (num2 == num)
				{
				}
				num = (short)788398081;
				if (num != 0)
				{
				}
				num = (short)1534525440;
				if (num != 0)
				{
				}
				num = (short)552402944;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton0ChannelListProperty);
			}
			set
			{
				short num = (short)1659004039;
				short num2 = num;
				num = (short)2142594183;
				switch (num2 == num)
				{
				}
				num = (short)2110783489;
				if (num != 0)
				{
				}
				num = (short)1935343616;
				if (num != 0)
				{
				}
				num = (short)560660480;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton0ChannelListProperty, value);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000044C0 File Offset: 0x000026C0
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00004578 File Offset: 0x00002778
		public bool DEKButton1FeatureIsAcpValid
		{
			get
			{
				short num = (short)1662545121;
				short num2 = num;
				num = (short)574909665;
				switch (num2 == num)
				{
				}
				num = (short)734920704;
				if (num != 0)
				{
				}
				num = (short)122617857;
				if (num != 0)
				{
				}
				num = (short)995360768;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton1FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1160850010;
				short num2 = num;
				num = (short)35596890;
				switch (num2 == num)
				{
				}
				num = (short)606666752;
				if (num != 0)
				{
				}
				num = (short)1367343105;
				if (num != 0)
				{
				}
				num = (short)1885011968;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00004630 File Offset: 0x00002830
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000046EC File Offset: 0x000028EC
		public bool DEKButton1FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)851375011;
				short num2 = num;
				num = (short)1408234403;
				switch (num2 == num)
				{
				}
				num = (short)1163460609;
				if (num != 0)
				{
				}
				num = (short)1009451008;
				if (num != 0)
				{
				}
				num = (short)1889730560;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton1FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)540688420;
				short num2 = num;
				num = (short)2094088228;
				switch (num2 == num)
				{
				}
				num = (short)2021195777;
				if (num != 0)
				{
				}
				num = (short)1236140032;
				if (num != 0)
				{
				}
				num = (short)1072103424;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000047A8 File Offset: 0x000029A8
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00004864 File Offset: 0x00002A64
		public bool DEKButton1FeatureIsAcpVisible
		{
			get
			{
				short num = (short)734388788;
				short num2 = num;
				num = (short)183099956;
				switch (num2 == num)
				{
				}
				num = (short)243073024;
				if (num != 0)
				{
				}
				num = (short)458753;
				if (num != 0)
				{
				}
				num = (short)566296576;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton1FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1949476151;
				short num2 = num;
				num = (short)2059380023;
				switch (num2 == num)
				{
				}
				num = (short)10813441;
				if (num != 0)
				{
				}
				num = (short)93913088;
				if (num != 0)
				{
				}
				num = (short)313851904;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00004924 File Offset: 0x00002B24
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000049E0 File Offset: 0x00002BE0
		public bool DEKButton1FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1871384018;
				short num2 = num;
				num = (short)144248274;
				switch (num2 == num)
				{
				}
				num = (short)23658497;
				if (num != 0)
				{
				}
				num = (short)1422721024;
				if (num != 0)
				{
				}
				num = (short)1059586048;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton1FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)793475564;
				short num2 = num;
				num = (short)229210604;
				switch (num2 == num)
				{
				}
				num = (short)87490561;
				if (num != 0)
				{
				}
				num = (short)741867520;
				if (num != 0)
				{
				}
				num = (short)1619591168;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00004A98 File Offset: 0x00002C98
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00004B54 File Offset: 0x00002D54
		public string DEKButton1FeatureUIValue
		{
			get
			{
				short num = (short)1053294593;
				if (num != 0)
				{
				}
				num = (short)1618432977;
				short num2 = num;
				num = (short)341988305;
				switch (num2 == num)
				{
				}
				num = (short)1089798144;
				if (num != 0)
				{
				}
				num = (short)1343619072;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton1FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1270042709;
				short num2 = num;
				num = (short)1056919637;
				switch (num2 == num)
				{
				}
				num = (short)606208000;
				if (num != 0)
				{
				}
				num = (short)980877313;
				if (num != 0)
				{
				}
				num = (short)100990976;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00004C0C File Offset: 0x00002E0C
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public AcpListField DEKButton1FeatureList
		{
			get
			{
				short num = (short)1789976213;
				short num2 = num;
				num = (short)706076309;
				switch (num2 == num)
				{
				}
				num = (short)449052672;
				if (num != 0)
				{
				}
				num = (short)305266689;
				if (num != 0)
				{
				}
				num = (short)1206059008;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton1FeatureListProperty);
			}
			set
			{
				short num = (short)311558145;
				if (num != 0)
				{
				}
				num = (short)1136105475;
				short num2 = num;
				num = (short)1026332675;
				switch (num2 == num)
				{
				}
				num = (short)1960247296;
				if (num != 0)
				{
				}
				num = (short)1082916864;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1FeatureListProperty, value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00004D7C File Offset: 0x00002F7C
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00004E34 File Offset: 0x00003034
		public bool DEKButton1IndexIsAcpValid
		{
			get
			{
				short num = (short)1309929677;
				short num2 = num;
				num = (short)1598615757;
				switch (num2 == num)
				{
				}
				num = (short)985137153;
				if (num != 0)
				{
				}
				num = (short)1345454080;
				if (num != 0)
				{
				}
				num = (short)796065792;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton1IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)792184683;
				short num2 = num;
				num = (short)203147115;
				switch (num2 == num)
				{
				}
				num = (short)1507328;
				if (num != 0)
				{
				}
				num = (short)892862465;
				if (num != 0)
				{
				}
				num = (short)1006698496;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00004EF0 File Offset: 0x000030F0
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00004FA8 File Offset: 0x000031A8
		public bool DEKButton1IndexIsAcpApplicable
		{
			get
			{
				short num = (short)250675201;
				if (num != 0)
				{
				}
				num = (short)127295351;
				short num2 = num;
				num = (short)1130717047;
				switch (num2 == num)
				{
				}
				num = (short)1275592704;
				if (num != 0)
				{
				}
				num = (short)1168441344;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton1IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)658572667;
				short num2 = num;
				num = (short)1912210811;
				switch (num2 == num)
				{
				}
				num = (short)697368576;
				if (num != 0)
				{
				}
				num = (short)1512308737;
				if (num != 0)
				{
				}
				num = (short)1954152448;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00005064 File Offset: 0x00003264
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00005120 File Offset: 0x00003320
		public bool DEKButton1IndexIsAcpVisible
		{
			get
			{
				short num = (short)1657178195;
				short num2 = num;
				num = (short)745965651;
				switch (num2 == num)
				{
				}
				num = (short)1237712897;
				if (num != 0)
				{
				}
				num = (short)797114368;
				if (num != 0)
				{
				}
				num = (short)409534464;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton1IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)110100481;
				if (num != 0)
				{
				}
				num = (short)623247922;
				short num2 = num;
				num = (short)416023090;
				switch (num2 == num)
				{
				}
				num = (short)232914944;
				if (num != 0)
				{
				}
				num = (short)1495203840;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000051DC File Offset: 0x000033DC
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00005298 File Offset: 0x00003498
		public bool DEKButton1IndexIsAcpEditable
		{
			get
			{
				short num = (short)2046676780;
				short num2 = num;
				num = (short)1667223340;
				switch (num2 == num)
				{
				}
				num = (short)360579072;
				if (num != 0)
				{
				}
				num = (short)1428226049;
				if (num != 0)
				{
				}
				num = (short)1899036672;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton1IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1202819007;
				short num2 = num;
				num = (short)1615040447;
				switch (num2 == num)
				{
				}
				num = (short)651952128;
				if (num != 0)
				{
				}
				num = (short)897777665;
				if (num != 0)
				{
				}
				num = (short)965935104;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00005354 File Offset: 0x00003554
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00005410 File Offset: 0x00003610
		public string DEKButton1IndexUIValue
		{
			get
			{
				short num = (short)2008535878;
				short num2 = num;
				num = (short)1844761414;
				switch (num2 == num)
				{
				}
				num = (short)1856897025;
				if (num != 0)
				{
				}
				num = (short)1256718336;
				if (num != 0)
				{
				}
				num = (short)1803616256;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton1IndexUIValueProperty);
			}
			set
			{
				short num = (short)1877430235;
				short num2 = num;
				num = (short)1858031579;
				switch (num2 == num)
				{
				}
				num = (short)132907009;
				if (num != 0)
				{
				}
				num = (short)469237760;
				if (num != 0)
				{
				}
				num = (short)567934976;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1IndexUIValueProperty, value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000054C4 File Offset: 0x000036C4
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000557C File Offset: 0x0000377C
		public AcpRangeField<int, int> DEKButton1IndexRange
		{
			get
			{
				short num = (short)2029190891;
				short num2 = num;
				num = (short)944963307;
				switch (num2 == num)
				{
				}
				num = (short)408092672;
				if (num != 0)
				{
				}
				num = (short)188350465;
				if (num != 0)
				{
				}
				num = (short)1105854464;
				short num3 = num;
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton1IndexRangeProperty);
			}
			set
			{
				short num = (short)631898113;
				if (num != 0)
				{
				}
				num = (short)1814799739;
				short num2 = num;
				num = (short)279225723;
				switch (num2 == num)
				{
				}
				num = (short)1317076992;
				if (num != 0)
				{
				}
				num = (short)1481703424;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1IndexRangeProperty, value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00005634 File Offset: 0x00003834
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000056F0 File Offset: 0x000038F0
		public bool DEKButton1ZoneIsAcpValid
		{
			get
			{
				short num = (short)1567490049;
				if (num != 0)
				{
				}
				num = (short)1404140751;
				short num2 = num;
				num = (short)1420262607;
				switch (num2 == num)
				{
				}
				num = (short)1457717248;
				if (num != 0)
				{
				}
				num = (short)642908160;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton1ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)1621967100;
				short num2 = num;
				num = (short)1689600252;
				switch (num2 == num)
				{
				}
				num = (short)1675427840;
				if (num != 0)
				{
				}
				num = (short)1546321921;
				if (num != 0)
				{
				}
				num = (short)206176256;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000057A8 File Offset: 0x000039A8
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00005864 File Offset: 0x00003A64
		public bool DEKButton1ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)1114701825;
				if (num != 0)
				{
				}
				num = (short)886325880;
				short num2 = num;
				num = (short)663896696;
				switch (num2 == num)
				{
				}
				num = (short)1121320960;
				if (num != 0)
				{
				}
				num = (short)872415232;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton1ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)482066539;
				short num2 = num;
				num = (short)161595499;
				switch (num2 == num)
				{
				}
				num = (short)704315393;
				if (num != 0)
				{
				}
				num = (short)362807296;
				if (num != 0)
				{
				}
				num = (short)1117519872;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000591C File Offset: 0x00003B1C
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000059D4 File Offset: 0x00003BD4
		public bool DEKButton1ZoneIsAcpVisible
		{
			get
			{
				short num = (short)579420479;
				short num2 = num;
				num = (short)1486766399;
				switch (num2 == num)
				{
				}
				num = (short)1502347265;
				if (num != 0)
				{
				}
				num = (short)520290304;
				if (num != 0)
				{
				}
				num = (short)1169686528;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton1ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)177171204;
				short num2 = num;
				num = (short)1063545604;
				switch (num2 == num)
				{
				}
				num = (short)99614721;
				if (num != 0)
				{
				}
				num = (short)1071513600;
				if (num != 0)
				{
				}
				num = (short)778502144;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00005A90 File Offset: 0x00003C90
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00005B4C File Offset: 0x00003D4C
		public bool DEKButton1ZoneIsAcpEditable
		{
			get
			{
				short num = (short)24468039;
				short num2 = num;
				num = (short)1072454215;
				switch (num2 == num)
				{
				}
				num = (short)490471425;
				if (num != 0)
				{
				}
				num = (short)561053696;
				if (num != 0)
				{
				}
				num = (short)1352073216;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton1ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)532307205;
				short num2 = num;
				num = (short)824335621;
				switch (num2 == num)
				{
				}
				num = (short)1476395009;
				if (num != 0)
				{
				}
				num = (short)1348403200;
				if (num != 0)
				{
				}
				num = (short)816316416;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00005C08 File Offset: 0x00003E08
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00005CC0 File Offset: 0x00003EC0
		public string DEKButton1ZoneUIValue
		{
			get
			{
				short num = (short)116523009;
				if (num != 0)
				{
				}
				num = (short)1106364303;
				short num2 = num;
				num = (short)721995663;
				switch (num2 == num)
				{
				}
				num = (short)1773731840;
				if (num != 0)
				{
				}
				num = (short)1547436032;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton1ZoneUIValueProperty);
			}
			set
			{
				short num = (short)1986995417;
				short num2 = num;
				num = (short)1852712153;
				switch (num2 == num)
				{
				}
				num = (short)1978466305;
				if (num != 0)
				{
				}
				num = (short)1095958528;
				if (num != 0)
				{
				}
				num = (short)1756561408;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1ZoneUIValueProperty, value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00005D78 File Offset: 0x00003F78
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00005E30 File Offset: 0x00004030
		public AcpListField DEKButton1ZoneList
		{
			get
			{
				short num = (short)1238171649;
				if (num != 0)
				{
				}
				num = (short)1608829544;
				short num2 = num;
				num = (short)1507904104;
				switch (num2 == num)
				{
				}
				num = (short)540868608;
				if (num != 0)
				{
				}
				num = (short)1874591744;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton1ZoneListProperty);
			}
			set
			{
				short num = (short)278907548;
				short num2 = num;
				num = (short)519752348;
				switch (num2 == num)
				{
				}
				num = (short)1346568193;
				if (num != 0)
				{
				}
				num = (short)1166409728;
				if (num != 0)
				{
				}
				num = (short)120586240;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton1ZoneListProperty, value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00005EE8 File Offset: 0x000040E8
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00005FA4 File Offset: 0x000041A4
		public bool DEKButton1ChannelIsAcpValid
		{
			get
			{
				short num = (short)1902403378;
				short num2 = num;
				num = (short)2131844914;
				switch (num2 == num)
				{
				}
				num = (short)1793327105;
				if (num != 0)
				{
				}
				num = (short)1508376576;
				short num3 = num;
				num = (short)241565696;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton1ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)985146625;
				short num2 = num;
				num = (short)1688937729;
				switch (num2 == num)
				{
				}
				num = (short)1569325057;
				if (num != 0)
				{
				}
				num = (short)1246167040;
				short num3 = num;
				num = (short)844038144;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton1ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00006060 File Offset: 0x00004260
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00006118 File Offset: 0x00004318
		public bool DEKButton1ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)181830118;
				short num2 = num;
				num = (short)477725158;
				switch (num2 == num)
				{
				}
				num = (short)297730049;
				if (num != 0)
				{
				}
				num = (short)921305088;
				short num3 = num;
				num = (short)2079326208;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton1ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1401900051;
				short num2 = num;
				num = (short)556157971;
				switch (num2 == num)
				{
				}
				num = (short)1518075904;
				if (num != 0)
				{
				}
				num = (short)1069744128;
				short num3 = num;
				num = (short)122159105;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton1ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000061D0 File Offset: 0x000043D0
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00006288 File Offset: 0x00004488
		public bool DEKButton1ChannelIsAcpVisible
		{
			get
			{
				short num = (short)1790050305;
				if (num != 0)
				{
				}
				num = (short)1032538813;
				short num2 = num;
				num = (short)435440317;
				switch (num2 == num)
				{
				}
				num = (short)2085355520;
				short num3 = num;
				num = (short)1330446336;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton1ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)601213900;
				short num2 = num;
				num = (short)1167248332;
				switch (num2 == num)
				{
				}
				num = (short)2089943040;
				if (num != 0)
				{
				}
				num = (short)1384054784;
				short num3 = num;
				num = (short)605618177;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton1ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00006340 File Offset: 0x00004540
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00006400 File Offset: 0x00004600
		public bool DEKButton1ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1017520476;
				short num2 = num;
				num = (short)706421084;
				switch (num2 == num)
				{
				}
				num = (short)1847525377;
				if (num != 0)
				{
				}
				num = (short)1789329408;
				short num3 = num;
				num = (short)1494810624;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton1ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)74448897;
				if (num != 0)
				{
				}
				num = (short)1672380175;
				short num2 = num;
				num = (short)249331471;
				switch (num2 == num)
				{
				}
				num = (short)898564096;
				short num3 = num;
				num = (short)1161035776;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton1ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000064B8 File Offset: 0x000046B8
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00006570 File Offset: 0x00004770
		public string DEKButton1ChannelUIValue
		{
			get
			{
				short num = (short)1852282910;
				short num2 = num;
				num = (short)1890687006;
				switch (num2 == num)
				{
				}
				num = (short)1197342721;
				if (num != 0)
				{
				}
				num = (short)189464576;
				short num3 = num;
				num = (short)67305472;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton1ChannelUIValueProperty);
			}
			set
			{
				short num = (short)624115892;
				short num2 = num;
				num = (short)858800308;
				switch (num2 == num)
				{
				}
				num = (short)1616248832;
				if (num != 0)
				{
				}
				num = (short)244580352;
				short num3 = num;
				num = (short)1026949121;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton1ChannelUIValueProperty, value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00006628 File Offset: 0x00004828
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000066E0 File Offset: 0x000048E0
		public AcpListField DEKButton1ChannelList
		{
			get
			{
				short num = (short)736579095;
				short num2 = num;
				num = (short)1038568983;
				switch (num2 == num)
				{
				}
				num = (short)1561001985;
				if (num != 0)
				{
				}
				num = (short)261226496;
				short num3 = num;
				num = (short)1114832896;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton1ChannelListProperty);
			}
			set
			{
				short num = (short)1690566380;
				short num2 = num;
				num = (short)1797258988;
				switch (num2 == num)
				{
				}
				num = (short)122683392;
				if (num != 0)
				{
				}
				num = (short)1200357376;
				short num3 = num;
				num = (short)281346049;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton1ChannelListProperty, value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00006798 File Offset: 0x00004998
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00006850 File Offset: 0x00004A50
		public bool DEKButton2FeatureIsAcpValid
		{
			get
			{
				short num = (short)233527403;
				short num2 = num;
				num = (short)49240171;
				switch (num2 == num)
				{
				}
				num = (short)1694892033;
				if (num != 0)
				{
				}
				num = (short)1404698624;
				short num3 = num;
				num = (short)1207500800;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1842435225;
				short num2 = num;
				num = (short)1730565273;
				switch (num2 == num)
				{
				}
				num = (short)957415424;
				if (num != 0)
				{
				}
				num = (short)4849664;
				short num3 = num;
				num = (short)330432513;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000690C File Offset: 0x00004B0C
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000069C8 File Offset: 0x00004BC8
		public bool DEKButton2FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1887698945;
				if (num != 0)
				{
				}
				num = (short)103697940;
				short num2 = num;
				num = (short)693849620;
				switch (num2 == num)
				{
				}
				num = (short)1924005888;
				short num3 = num;
				num = (short)1933574144;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)226356328;
				short num2 = num;
				num = (short)1368583272;
				switch (num2 == num)
				{
				}
				num = (short)2102657025;
				if (num != 0)
				{
				}
				num = (short)1620180992;
				short num3 = num;
				num = (short)1463484416;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00006A84 File Offset: 0x00004C84
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00006B40 File Offset: 0x00004D40
		public bool DEKButton2FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1736792521;
				short num2 = num;
				num = (short)911694281;
				switch (num2 == num)
				{
				}
				num = (short)1824456705;
				if (num != 0)
				{
				}
				num = (short)1837170688;
				short num3 = num;
				num = (short)178847744;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1927135428;
				short num2 = num;
				num = (short)48808132;
				switch (num2 == num)
				{
				}
				num = (short)375586817;
				if (num != 0)
				{
				}
				num = (short)1004011520;
				short num3 = num;
				num = (short)835780608;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00006BFC File Offset: 0x00004DFC
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00006CB8 File Offset: 0x00004EB8
		public bool DEKButton2FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1379729409;
				if (num != 0)
				{
				}
				num = (short)1639158080;
				short num2 = num;
				num = (short)1167692096;
				switch (num2 == num)
				{
				}
				num = (short)514064384;
				short num3 = num;
				num = (short)1843527680;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1993022725;
				short num2 = num;
				num = (short)1577721093;
				switch (num2 == num)
				{
				}
				num = (short)109576193;
				if (num != 0)
				{
				}
				num = (short)1757413376;
				short num3 = num;
				num = (short)1440088064;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00006D74 File Offset: 0x00004F74
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00006E2C File Offset: 0x0000502C
		public string DEKButton2FeatureUIValue
		{
			get
			{
				short num = (short)888471553;
				if (num != 0)
				{
				}
				num = (short)231615342;
				short num2 = num;
				num = (short)838282094;
				switch (num2 == num)
				{
				}
				num = (short)1137049600;
				short num3 = num;
				num = (short)420610048;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton2FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1171213864;
				short num2 = num;
				num = (short)1485917736;
				switch (num2 == num)
				{
				}
				num = (short)2012676097;
				if (num != 0)
				{
				}
				num = (short)1525874688;
				short num3 = num;
				num = (short)182190080;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00006EE0 File Offset: 0x000050E0
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00006F98 File Offset: 0x00005198
		public AcpListField DEKButton2FeatureList
		{
			get
			{
				short num = (short)1898250241;
				if (num != 0)
				{
				}
				num = (short)454280021;
				short num2 = num;
				num = (short)1671938901;
				switch (num2 == num)
				{
				}
				num = (short)659095552;
				short num3 = num;
				num = (short)536870912;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton2FeatureListProperty);
			}
			set
			{
				short num = (short)1396875575;
				short num2 = num;
				num = (short)416981303;
				switch (num2 == num)
				{
				}
				num = (short)473497600;
				if (num != 0)
				{
				}
				num = (short)1344733184;
				short num3 = num;
				num = (short)1968898049;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2FeatureListProperty, value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000704C File Offset: 0x0000524C
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00007108 File Offset: 0x00005308
		public bool DEKButton2IndexIsAcpValid
		{
			get
			{
				short num = (short)1508336319;
				short num2 = num;
				num = (short)2110350015;
				switch (num2 == num)
				{
				}
				num = (short)1687093249;
				if (num != 0)
				{
				}
				num = (short)1810825216;
				short num3 = num;
				num = (short)602996736;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1840270694;
				short num2 = num;
				num = (short)380718438;
				switch (num2 == num)
				{
				}
				num = (short)981204993;
				if (num != 0)
				{
				}
				num = (short)435159040;
				short num3 = num;
				num = (short)1747058688;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000071C4 File Offset: 0x000053C4
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00007280 File Offset: 0x00005480
		public bool DEKButton2IndexIsAcpApplicable
		{
			get
			{
				short num = (short)1501509805;
				short num2 = num;
				num = (short)501430445;
				switch (num2 == num)
				{
				}
				num = (short)407699456;
				if (num != 0)
				{
				}
				num = (short)1552089088;
				short num3 = num;
				num = (short)367788033;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1576069325;
				short num2 = num;
				num = (short)676653261;
				switch (num2 == num)
				{
				}
				num = (short)1587281920;
				if (num != 0)
				{
				}
				num = (short)1160249344;
				short num3 = num;
				num = (short)1356070913;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000733C File Offset: 0x0000553C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000073FC File Offset: 0x000055FC
		public bool DEKButton2IndexIsAcpVisible
		{
			get
			{
				short num = (short)2022897166;
				short num2 = num;
				num = (short)907212302;
				switch (num2 == num)
				{
				}
				num = (short)530972673;
				if (num != 0)
				{
				}
				num = (short)1938358272;
				short num3 = num;
				num = (short)269221888;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1973518735;
				short num2 = num;
				num = (short)632324495;
				switch (num2 == num)
				{
				}
				num = (short)42401793;
				if (num != 0)
				{
				}
				num = (short)291897344;
				short num3 = num;
				num = (short)1430585344;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000074BC File Offset: 0x000056BC
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00007578 File Offset: 0x00005778
		public bool DEKButton2IndexIsAcpEditable
		{
			get
			{
				short num = (short)659607667;
				short num2 = num;
				num = (short)628609139;
				switch (num2 == num)
				{
				}
				num = (short)1714618368;
				if (num != 0)
				{
				}
				num = (short)746127360;
				short num3 = num;
				num = (short)841744385;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1142279155;
				short num2 = num;
				num = (short)2014104563;
				switch (num2 == num)
				{
				}
				num = (short)437977089;
				if (num != 0)
				{
				}
				num = (short)875954176;
				short num3 = num;
				num = (short)1324613632;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00007630 File Offset: 0x00005830
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000076E8 File Offset: 0x000058E8
		public string DEKButton2IndexUIValue
		{
			get
			{
				short num = (short)630193411;
				short num2 = num;
				num = (short)1752956163;
				switch (num2 == num)
				{
				}
				num = (short)355663872;
				if (num != 0)
				{
				}
				num = (short)280035328;
				short num3 = num;
				num = (short)1993474049;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton2IndexUIValueProperty);
			}
			set
			{
				short num = (short)2134873307;
				short num2 = num;
				num = (short)1579717851;
				switch (num2 == num)
				{
				}
				num = (short)460849152;
				if (num != 0)
				{
				}
				num = (short)1674444800;
				short num3 = num;
				num = (short)769064961;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2IndexUIValueProperty, value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000779C File Offset: 0x0000599C
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00007858 File Offset: 0x00005A58
		public AcpRangeField<int, int> DEKButton2IndexRange
		{
			get
			{
				short num = (short)1025418825;
				short num2 = num;
				num = (short)988325449;
				switch (num2 == num)
				{
				}
				num = (short)45088769;
				if (num != 0)
				{
				}
				num = (short)1851654144;
				short num3 = num;
				num = (short)1695350784;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton2IndexRangeProperty);
			}
			set
			{
				short num = (short)116220754;
				short num2 = num;
				num = (short)420701010;
				switch (num2 == num)
				{
				}
				num = (short)707330048;
				if (num != 0)
				{
				}
				num = (short)1063452672;
				short num3 = num;
				num = (short)1360658433;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2IndexRangeProperty, value);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00007910 File Offset: 0x00005B10
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000079CC File Offset: 0x00005BCC
		public bool DEKButton2ZoneIsAcpValid
		{
			get
			{
				short num = (short)458063948;
				short num2 = num;
				num = (short)1976467532;
				switch (num2 == num)
				{
				}
				num = (short)1827405824;
				if (num != 0)
				{
				}
				num = (short)949288960;
				short num3 = num;
				num = (short)223477761;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)92635928;
				short num2 = num;
				num = (short)203981592;
				switch (num2 == num)
				{
				}
				num = (short)1182466048;
				if (num != 0)
				{
				}
				num = (short)1315045376;
				short num3 = num;
				num = (short)1967980545;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00007A88 File Offset: 0x00005C88
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00007B40 File Offset: 0x00005D40
		public bool DEKButton2ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)667567361;
				short num2 = num;
				num = (short)534136065;
				switch (num2 == num)
				{
				}
				num = (short)449183745;
				if (num != 0)
				{
				}
				num = (short)393609216;
				short num3 = num;
				num = (short)175243264;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1416103801;
				short num2 = num;
				num = (short)1005782905;
				switch (num2 == num)
				{
				}
				num = (short)868614145;
				if (num != 0)
				{
				}
				num = (short)1150156800;
				short num3 = num;
				num = (short)485359616;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00007BF8 File Offset: 0x00005DF8
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00007CB4 File Offset: 0x00005EB4
		public bool DEKButton2ZoneIsAcpVisible
		{
			get
			{
				short num = (short)975372289;
				if (num != 0)
				{
				}
				num = (short)547696254;
				short num2 = num;
				num = (short)1387409022;
				switch (num2 == num)
				{
				}
				num = (short)1966997504;
				short num3 = num;
				num = (short)1580072960;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1990361052;
				short num2 = num;
				num = (short)1234862044;
				switch (num2 == num)
				{
				}
				num = (short)695533569;
				if (num != 0)
				{
				}
				num = (short)303038464;
				short num3 = num;
				num = (short)2016215040;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00007D6C File Offset: 0x00005F6C
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00007E24 File Offset: 0x00006024
		public bool DEKButton2ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1402932572;
				short num2 = num;
				num = (short)1230835036;
				switch (num2 == num)
				{
				}
				num = (short)1855324161;
				if (num != 0)
				{
				}
				num = (short)1286078464;
				short num3 = num;
				num = (short)1708589056;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)570702874;
				short num2 = num;
				num = (short)1072184346;
				switch (num2 == num)
				{
				}
				num = (short)254738433;
				if (num != 0)
				{
				}
				num = (short)154796032;
				short num3 = num;
				num = (short)561446912;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00007EE0 File Offset: 0x000060E0
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00007F9C File Offset: 0x0000619C
		public string DEKButton2ZoneUIValue
		{
			get
			{
				short num = (short)1606349541;
				short num2 = num;
				num = (short)780464869;
				switch (num2 == num)
				{
				}
				num = (short)53149697;
				if (num != 0)
				{
				}
				num = (short)1078329344;
				short num3 = num;
				num = (short)232783872;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton2ZoneUIValueProperty);
			}
			set
			{
				short num = (short)646595467;
				short num2 = num;
				num = (short)1938244491;
				switch (num2 == num)
				{
				}
				num = (short)1602027521;
				if (num != 0)
				{
				}
				num = (short)1355415552;
				short num3 = num;
				num = (short)162463744;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2ZoneUIValueProperty, value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00008050 File Offset: 0x00006250
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00008108 File Offset: 0x00006308
		public AcpListField DEKButton2ZoneList
		{
			get
			{
				short num = (short)457992191;
				short num2 = num;
				num = (short)954755071;
				switch (num2 == num)
				{
				}
				num = (short)1566048256;
				if (num != 0)
				{
				}
				num = (short)650575872;
				short num3 = num;
				num = (short)584253441;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton2ZoneListProperty);
			}
			set
			{
				short num = (short)926543013;
				short num2 = num;
				num = (short)1260645541;
				switch (num2 == num)
				{
				}
				num = (short)967245825;
				if (num != 0)
				{
				}
				num = (short)569769984;
				short num3 = num;
				num = (short)541327360;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2ZoneListProperty, value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000081BC File Offset: 0x000063BC
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00008278 File Offset: 0x00006478
		public bool DEKButton2ChannelIsAcpValid
		{
			get
			{
				short num = (short)1387142383;
				short num2 = num;
				num = (short)1668881647;
				switch (num2 == num)
				{
				}
				num = (short)349896705;
				if (num != 0)
				{
				}
				num = (short)1512374272;
				short num3 = num;
				num = (short)1290076160;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)1018523102;
				short num2 = num;
				num = (short)513764830;
				switch (num2 == num)
				{
				}
				num = (short)1531117568;
				short num3 = num;
				num = (short)1918697473;
				if (num != 0)
				{
				}
				num = (short)968949760;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00008330 File Offset: 0x00006530
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000083E8 File Offset: 0x000065E8
		public bool DEKButton2ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)1630274364;
				short num2 = num;
				num = (short)1531380540;
				switch (num2 == num)
				{
				}
				num = (short)1388249088;
				short num3 = num;
				num = (short)82116608;
				if (num != 0)
				{
				}
				num = (short)1157824513;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1814562507;
				short num2 = num;
				num = (short)1008666315;
				switch (num2 == num)
				{
				}
				num = (short)647692288;
				short num3 = num;
				num = (short)1841758209;
				if (num != 0)
				{
				}
				num = (short)1023541248;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000084A4 File Offset: 0x000066A4
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000855C File Offset: 0x0000675C
		public bool DEKButton2ChannelIsAcpVisible
		{
			get
			{
				short num = (short)689083288;
				short num2 = num;
				num = (short)28545944;
				switch (num2 == num)
				{
				}
				num = (short)726401024;
				short num3 = num;
				num = (short)1098842113;
				if (num != 0)
				{
				}
				num = (short)1400438784;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2032381282;
				short num2 = num;
				num = (short)1395961186;
				switch (num2 == num)
				{
				}
				num = (short)1874788352;
				short num3 = num;
				num = (short)1647902720;
				if (num != 0)
				{
				}
				num = (short)164823041;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00008618 File Offset: 0x00006818
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000086D0 File Offset: 0x000068D0
		public bool DEKButton2ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1668325165;
				short num2 = num;
				num = (short)1115397933;
				switch (num2 == num)
				{
				}
				num = (short)1996881920;
				short num3 = num;
				num = (short)503119873;
				if (num != 0)
				{
				}
				num = (short)53280768;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton2ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)745734145;
				if (num != 0)
				{
				}
				num = (short)1810895114;
				short num2 = num;
				num = (short)890638602;
				switch (num2 == num)
				{
				default:
				{
					num = (short)936640512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1578762240;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00008788 File Offset: 0x00006988
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00008840 File Offset: 0x00006A40
		public string DEKButton2ChannelUIValue
		{
			get
			{
				short num = (short)1872388523;
				short num2 = num;
				num = (short)523788715;
				switch (num2 == num)
				{
				}
				num = (short)740491264;
				short num3 = num;
				num = (short)237043713;
				if (num != 0)
				{
				}
				num = (short)370540544;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton2ChannelUIValueProperty);
			}
			set
			{
				short num = (short)950460590;
				short num2 = num;
				num = (short)597156014;
				switch (num2 == num)
				{
				}
				num = (short)68747264;
				short num3 = num;
				num = (short)97452033;
				if (num != 0)
				{
				}
				num = (short)404488192;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2ChannelUIValueProperty, value);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000088F8 File Offset: 0x00006AF8
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000089B4 File Offset: 0x00006BB4
		public AcpListField DEKButton2ChannelList
		{
			get
			{
				short num = (short)934865235;
				short num2 = num;
				num = (short)564521299;
				switch (num2 == num)
				{
				}
				num = (short)620888064;
				short num3 = num;
				num = (short)86376449;
				if (num != 0)
				{
				}
				num = (short)1576992768;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton2ChannelListProperty);
			}
			set
			{
				short num = (short)701037910;
				short num2 = num;
				num = (short)1490025814;
				switch (num2 == num)
				{
				}
				num = (short)92078080;
				short num3 = num;
				num = (short)505348096;
				if (num != 0)
				{
				}
				num = (short)576978945;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton2ChannelListProperty, value);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00008A68 File Offset: 0x00006C68
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00008B24 File Offset: 0x00006D24
		public bool DEKButton3FeatureIsAcpValid
		{
			get
			{
				short num = (short)192123679;
				short num2 = num;
				num = (short)2035585823;
				switch (num2 == num)
				{
				}
				num = (short)1287061504;
				short num3 = num;
				num = (short)2100101121;
				if (num != 0)
				{
				}
				num = (short)1222705152;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)606222478;
				short num2 = num;
				num = (short)1594243214;
				switch (num2 == num)
				{
				}
				num = (short)369754112;
				short num3 = num;
				num = (short)222691329;
				if (num != 0)
				{
				}
				num = (short)1221722112;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00008BE0 File Offset: 0x00006DE0
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00008C9C File Offset: 0x00006E9C
		public bool DEKButton3FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1021479168;
				short num2 = num;
				num = (short)1867942144;
				switch (num2 == num)
				{
				}
				num = (short)1192886272;
				short num3 = num;
				num = (short)348454912;
				if (num != 0)
				{
				}
				num = (short)1141899265;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1625101967;
				short num2 = num;
				num = (short)213259919;
				switch (num2 == num)
				{
				}
				num = (short)1035862016;
				short num3 = num;
				num = (short)385089537;
				if (num != 0)
				{
				}
				num = (short)975372288;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00008D58 File Offset: 0x00006F58
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00008E10 File Offset: 0x00007010
		public bool DEKButton3FeatureIsAcpVisible
		{
			get
			{
				short num = (short)935817281;
				short num2 = num;
				num = (short)333803585;
				switch (num2 == num)
				{
				}
				num = (short)1736507392;
				short num3 = num;
				num = (short)881721344;
				if (num != 0)
				{
				}
				num = (short)295043073;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2030731812;
				short num2 = num;
				num = (short)1056145956;
				switch (num2 == num)
				{
				}
				num = (short)1785921536;
				short num3 = num;
				num = (short)2093154305;
				if (num != 0)
				{
				}
				num = (short)830210048;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00008ECC File Offset: 0x000070CC
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00008F88 File Offset: 0x00007188
		public bool DEKButton3FeatureIsAcpEditable
		{
			get
			{
				short num = (short)827064321;
				if (num != 0)
				{
				}
				num = (short)1961296361;
				short num2 = num;
				num = (short)262472169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)166330368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2000486400;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)23380880;
				short num2 = num;
				num = (short)2079310736;
				switch (num2 == num)
				{
				}
				num = (short)1761804288;
				short num3 = num;
				num = (short)333905921;
				if (num != 0)
				{
				}
				num = (short)1878261760;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00009040 File Offset: 0x00007240
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000090FC File Offset: 0x000072FC
		public string DEKButton3FeatureUIValue
		{
			get
			{
				short num = (short)1641000528;
				short num2 = num;
				num = (short)1799204432;
				switch (num2 == num)
				{
				}
				num = (short)954859520;
				short num3 = num;
				num = (short)2106982401;
				if (num != 0)
				{
				}
				num = (short)138936320;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton3FeatureUIValueProperty);
			}
			set
			{
				short num = (short)993460225;
				if (num != 0)
				{
				}
				num = (short)1204021954;
				short num2 = num;
				num = (short)262073026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)525926400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1072627712;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000091B0 File Offset: 0x000073B0
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00009268 File Offset: 0x00007468
		public AcpListField DEKButton3FeatureList
		{
			get
			{
				short num = (short)922840092;
				short num2 = num;
				num = (short)784952348;
				switch (num2 == num)
				{
				}
				num = (short)657260544;
				short num3 = num;
				num = (short)658571265;
				if (num != 0)
				{
				}
				num = (short)494993408;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton3FeatureListProperty);
			}
			set
			{
				short num = (short)984733360;
				short num2 = num;
				num = (short)1434572464;
				switch (num2 == num)
				{
				}
				num = (short)2010578944;
				short num3 = num;
				num = (short)1800601601;
				if (num != 0)
				{
				}
				num = (short)417726464;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3FeatureListProperty, value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000931C File Offset: 0x0000751C
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000093D4 File Offset: 0x000075D4
		public bool DEKButton3IndexIsAcpValid
		{
			get
			{
				short num = (short)810122178;
				short num2 = num;
				num = (short)461732802;
				switch (num2 == num)
				{
				}
				num = (short)106627072;
				short num3 = num;
				num = (short)1285292032;
				if (num != 0)
				{
				}
				num = (short)1407582209;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)873433542;
				short num2 = num;
				num = (short)904694214;
				switch (num2 == num)
				{
				}
				num = (short)927596544;
				short num3 = num;
				num = (short)546045952;
				if (num != 0)
				{
				}
				num = (short)1767178241;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00009490 File Offset: 0x00007690
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00009548 File Offset: 0x00007748
		public bool DEKButton3IndexIsAcpApplicable
		{
			get
			{
				short num = (short)2057502721;
				if (num != 0)
				{
				}
				num = (short)16445063;
				short num2 = num;
				num = (short)825093767;
				switch (num2 == num)
				{
				default:
				{
					num = (short)959119360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)659030016;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)572173202;
				short num2 = num;
				num = (short)1456122770;
				switch (num2 == num)
				{
				}
				num = (short)1372454912;
				short num3 = num;
				num = (short)1110966273;
				if (num != 0)
				{
				}
				num = (short)1043726336;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00009604 File Offset: 0x00007804
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000096BC File Offset: 0x000078BC
		public bool DEKButton3IndexIsAcpVisible
		{
			get
			{
				short num = (short)1606746113;
				if (num != 0)
				{
				}
				num = (short)1544634571;
				short num2 = num;
				num = (short)762593483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1524498432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)717946880;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)654935867;
				short num2 = num;
				num = (short)968460091;
				switch (num2 == num)
				{
				}
				num = (short)1185021952;
				short num3 = num;
				num = (short)1804664832;
				if (num != 0)
				{
				}
				num = (short)1217855489;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00009778 File Offset: 0x00007978
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00009838 File Offset: 0x00007A38
		public bool DEKButton3IndexIsAcpEditable
		{
			get
			{
				short num = (short)415739473;
				short num2 = num;
				num = (short)551333457;
				switch (num2 == num)
				{
				}
				num = (short)663224320;
				short num3 = num;
				num = (short)111149057;
				if (num != 0)
				{
				}
				num = (short)164757504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2123046708;
				short num2 = num;
				num = (short)2054823732;
				switch (num2 == num)
				{
				}
				num = (short)272367616;
				short num3 = num;
				num = (short)437780481;
				if (num != 0)
				{
				}
				num = (short)1639055360;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000098F4 File Offset: 0x00007AF4
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000099B0 File Offset: 0x00007BB0
		public string DEKButton3IndexUIValue
		{
			get
			{
				short num = (short)405005671;
				short num2 = num;
				num = (short)1734075751;
				switch (num2 == num)
				{
				}
				num = (short)2095448064;
				short num3 = num;
				num = (short)1161101313;
				if (num != 0)
				{
				}
				num = (short)1136787456;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton3IndexUIValueProperty);
			}
			set
			{
				short num = (short)394218503;
				short num2 = num;
				num = (short)70536199;
				switch (num2 == num)
				{
				}
				num = (short)1955397632;
				short num3 = num;
				num = (short)666697729;
				if (num != 0)
				{
				}
				num = (short)583860224;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3IndexUIValueProperty, value);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00009A64 File Offset: 0x00007C64
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00009B1C File Offset: 0x00007D1C
		public AcpRangeField<int, int> DEKButton3IndexRange
		{
			get
			{
				short num = (short)790809565;
				short num2 = num;
				num = (short)31640541;
				switch (num2 == num)
				{
				}
				num = (short)1357840384;
				short num3 = num;
				num = (short)1863909377;
				if (num != 0)
				{
				}
				num = (short)1805254656;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton3IndexRangeProperty);
			}
			set
			{
				short num = (short)2034106369;
				if (num != 0)
				{
				}
				num = (short)2034075695;
				short num2 = num;
				num = (short)2083751983;
				switch (num2 == num)
				{
				default:
				{
					num = (short)797442048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)837943296;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3IndexRangeProperty, value);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00009BD4 File Offset: 0x00007DD4
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00009C8C File Offset: 0x00007E8C
		public bool DEKButton3ZoneIsAcpValid
		{
			get
			{
				short num = (short)480673362;
				short num2 = num;
				num = (short)821460562;
				switch (num2 == num)
				{
				}
				num = (short)678166528;
				short num3 = num;
				num = (short)563609601;
				if (num != 0)
				{
				}
				num = (short)1155268608;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)273402279;
				short num2 = num;
				num = (short)1525336487;
				switch (num2 == num)
				{
				}
				num = (short)501350400;
				short num3 = num;
				num = (short)1351680001;
				if (num != 0)
				{
				}
				num = (short)130678784;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00009D44 File Offset: 0x00007F44
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00009DFC File Offset: 0x00007FFC
		public bool DEKButton3ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)2051356762;
				short num2 = num;
				num = (short)263796826;
				switch (num2 == num)
				{
				}
				num = (short)1316421632;
				short num3 = num;
				num = (short)757137408;
				if (num != 0)
				{
				}
				num = (short)1431371777;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)127160224;
				short num2 = num;
				num = (short)1888505760;
				switch (num2 == num)
				{
				}
				num = (short)413794304;
				short num3 = num;
				num = (short)1950875648;
				if (num != 0)
				{
				}
				num = (short)72351745;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00009EB8 File Offset: 0x000080B8
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00009F70 File Offset: 0x00008170
		public bool DEKButton3ZoneIsAcpVisible
		{
			get
			{
				short num = (short)620557742;
				short num2 = num;
				num = (short)278656430;
				switch (num2 == num)
				{
				}
				num = (short)404291584;
				short num3 = num;
				num = (short)1930428417;
				if (num != 0)
				{
				}
				num = (short)384172032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)934384959;
				short num2 = num;
				num = (short)1165333823;
				switch (num2 == num)
				{
				}
				num = (short)963117056;
				short num3 = num;
				num = (short)1325596673;
				if (num != 0)
				{
				}
				num = (short)1597571072;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000A02C File Offset: 0x0000822C
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000A0E4 File Offset: 0x000082E4
		public bool DEKButton3ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1187447206;
				short num2 = num;
				num = (short)1155006886;
				switch (num2 == num)
				{
				}
				num = (short)495190016;
				short num3 = num;
				num = (short)1802764289;
				if (num != 0)
				{
				}
				num = (short)1680670720;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)236560285;
				short num2 = num;
				num = (short)637640605;
				switch (num2 == num)
				{
				}
				num = (short)2127757312;
				short num3 = num;
				num = (short)305266689;
				if (num != 0)
				{
				}
				num = (short)356253696;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000A19C File Offset: 0x0000839C
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000A254 File Offset: 0x00008454
		public string DEKButton3ZoneUIValue
		{
			get
			{
				short num = (short)1728879045;
				short num2 = num;
				num = (short)382179781;
				switch (num2 == num)
				{
				}
				num = (short)2109734912;
				short num3 = num;
				num = (short)1279590401;
				if (num != 0)
				{
				}
				num = (short)1305739264;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton3ZoneUIValueProperty);
			}
			set
			{
				short num = (short)1432962987;
				short num2 = num;
				num = (short)676087723;
				switch (num2 == num)
				{
				}
				num = (short)1381892096;
				short num3 = num;
				num = (short)1444347904;
				if (num != 0)
				{
				}
				num = (short)1926103041;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3ZoneUIValueProperty, value);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000A30C File Offset: 0x0000850C
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000A3C8 File Offset: 0x000085C8
		public AcpListField DEKButton3ZoneList
		{
			get
			{
				short num = (short)28669018;
				short num2 = num;
				num = (short)600077402;
				switch (num2 == num)
				{
				}
				num = (short)273022976;
				short num3 = num;
				num = (short)842661889;
				if (num != 0)
				{
				}
				num = (short)1847328768;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton3ZoneListProperty);
			}
			set
			{
				short num = (short)1270609391;
				short num2 = num;
				num = (short)522647023;
				switch (num2 == num)
				{
				}
				num = (short)1707278336;
				short num3 = num;
				num = (short)66715649;
				if (num != 0)
				{
				}
				num = (short)16384000;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3ZoneListProperty, value);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000A480 File Offset: 0x00008680
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000A538 File Offset: 0x00008738
		public bool DEKButton3ChannelIsAcpValid
		{
			get
			{
				short num = (short)1300690651;
				short num2 = num;
				num = (short)1159788251;
				switch (num2 == num)
				{
				}
				num = (short)1271398400;
				short num3 = num;
				num = (short)1838088192;
				if (num != 0)
				{
				}
				num = (short)790560769;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)200799949;
				short num2 = num;
				num = (short)1416885965;
				switch (num2 == num)
				{
				}
				num = (short)620101632;
				short num3 = num;
				num = (short)228065281;
				if (num != 0)
				{
				}
				num = (short)1210449920;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000A5F0 File Offset: 0x000087F0
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000A6A8 File Offset: 0x000088A8
		public bool DEKButton3ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)1105972184;
				short num2 = num;
				num = (short)1342163928;
				switch (num2 == num)
				{
				}
				num = (short)1927348224;
				short num3 = num;
				num = (short)1293090817;
				if (num != 0)
				{
				}
				num = (short)586874880;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2132344833;
				if (num != 0)
				{
				}
				num = (short)199717057;
				short num2 = num;
				num = (short)736063681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2012151808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1752563712;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000A764 File Offset: 0x00008964
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000A81C File Offset: 0x00008A1C
		public bool DEKButton3ChannelIsAcpVisible
		{
			get
			{
				short num = (short)189743522;
				short num2 = num;
				num = (short)41959842;
				switch (num2 == num)
				{
				}
				num = (short)1927348224;
				short num3 = num;
				num = (short)1955463169;
				if (num != 0)
				{
				}
				num = (short)362414080;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)612106241;
				if (num != 0)
				{
				}
				num = (short)429827183;
				short num2 = num;
				num = (short)451912815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1556480000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)350945280;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000A994 File Offset: 0x00008B94
		public bool DEKButton3ChannelIsAcpEditable
		{
			get
			{
				short num = (short)897793621;
				short num2 = num;
				num = (short)290668117;
				switch (num2 == num)
				{
				}
				num = (short)699793408;
				short num3 = num;
				num = (short)1118699520;
				if (num != 0)
				{
				}
				num = (short)2012086273;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton3ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)247529473;
				if (num != 0)
				{
				}
				num = (short)1847276077;
				short num2 = num;
				num = (short)546648621;
				switch (num2 == num)
				{
				default:
				{
					num = (short)965017600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1554251776;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000AA50 File Offset: 0x00008C50
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000AB08 File Offset: 0x00008D08
		public string DEKButton3ChannelUIValue
		{
			get
			{
				short num = (short)1954808258;
				short num2 = num;
				num = (short)938803650;
				switch (num2 == num)
				{
				}
				num = (short)973537280;
				short num3 = num;
				num = (short)672137217;
				if (num != 0)
				{
				}
				num = (short)974323712;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton3ChannelUIValueProperty);
			}
			set
			{
				short num = (short)169684107;
				short num2 = num;
				num = (short)1597713547;
				switch (num2 == num)
				{
				}
				num = (short)825819136;
				short num3 = num;
				num = (short)382205953;
				if (num != 0)
				{
				}
				num = (short)1651638272;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3ChannelUIValueProperty, value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000ABBC File Offset: 0x00008DBC
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000AC78 File Offset: 0x00008E78
		public AcpListField DEKButton3ChannelList
		{
			get
			{
				short num = (short)464882441;
				short num2 = num;
				num = (short)719620873;
				switch (num2 == num)
				{
				}
				num = (short)1636761600;
				short num3 = num;
				num = (short)803078144;
				if (num != 0)
				{
				}
				num = (short)1756758017;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton3ChannelListProperty);
			}
			set
			{
				short num = (short)1681721809;
				short num2 = num;
				num = (short)750914001;
				switch (num2 == num)
				{
				}
				num = (short)384303104;
				short num3 = num;
				num = (short)1211432961;
				if (num != 0)
				{
				}
				num = (short)904724480;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton3ChannelListProperty, value);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000AD2C File Offset: 0x00008F2C
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		public bool DEKButton4FeatureIsAcpValid
		{
			get
			{
				short num = (short)859553499;
				short num2 = num;
				num = (short)201572059;
				switch (num2 == num)
				{
				}
				num = (short)1876688896;
				short num3 = num;
				num = (short)86310913;
				if (num != 0)
				{
				}
				num = (short)1172832256;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1055257498;
				short num2 = num;
				num = (short)35189658;
				switch (num2 == num)
				{
				}
				num = (short)29032448;
				short num3 = num;
				num = (short)1605566464;
				if (num != 0)
				{
				}
				num = (short)355205121;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000AEA4 File Offset: 0x000090A4
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000AF60 File Offset: 0x00009160
		public bool DEKButton4FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1820917761;
				if (num != 0)
				{
				}
				num = (short)1220661310;
				short num2 = num;
				num = (short)2120273982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169162240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)302252032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)759487088;
				short num2 = num;
				num = (short)660396656;
				switch (num2 == num)
				{
				}
				num = (short)1207173120;
				short num3 = num;
				num = (short)1986461697;
				if (num != 0)
				{
				}
				num = (short)1513029632;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000B018 File Offset: 0x00009218
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000B0D4 File Offset: 0x000092D4
		public bool DEKButton4FeatureIsAcpVisible
		{
			get
			{
				short num = (short)2095460956;
				short num2 = num;
				num = (short)489632348;
				switch (num2 == num)
				{
				}
				num = (short)582811648;
				short num3 = num;
				num = (short)416088065;
				if (num != 0)
				{
				}
				num = (short)809893888;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)12517377;
				if (num != 0)
				{
				}
				num = (short)1070582303;
				short num2 = num;
				num = (short)2004994591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1992097792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1827799040;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000B190 File Offset: 0x00009390
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000B248 File Offset: 0x00009448
		public bool DEKButton4FeatureIsAcpEditable
		{
			get
			{
				short num = (short)905910255;
				short num2 = num;
				num = (short)2067077103;
				switch (num2 == num)
				{
				}
				num = (short)2031091712;
				short num3 = num;
				num = (short)1611071489;
				if (num != 0)
				{
				}
				num = (short)1527709696;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1975142168;
				short num2 = num;
				num = (short)335759128;
				switch (num2 == num)
				{
				}
				num = (short)932904960;
				short num3 = num;
				num = (short)664666112;
				if (num != 0)
				{
				}
				num = (short)1389887489;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000B300 File Offset: 0x00009500
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000B3BC File Offset: 0x000095BC
		public string DEKButton4FeatureUIValue
		{
			get
			{
				short num = (short)455671809;
				if (num != 0)
				{
				}
				num = (short)1681747120;
				short num2 = num;
				num = (short)807890096;
				switch (num2 == num)
				{
				default:
				{
					num = (short)884867072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1589641216;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton4FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1606353105;
				short num2 = num;
				num = (short)1555955921;
				switch (num2 == num)
				{
				}
				num = (short)139984896;
				short num3 = num;
				num = (short)1060110337;
				if (num != 0)
				{
				}
				num = (short)2042822656;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000B470 File Offset: 0x00009670
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000B530 File Offset: 0x00009730
		public AcpListField DEKButton4FeatureList
		{
			get
			{
				short num = (short)341088316;
				short num2 = num;
				num = (short)1528535100;
				switch (num2 == num)
				{
				}
				num = (short)982122496;
				short num3 = num;
				num = (short)765329409;
				if (num != 0)
				{
				}
				num = (short)2096300032;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton4FeatureListProperty);
			}
			set
			{
				short num = (short)1301063321;
				short num2 = num;
				num = (short)813999769;
				switch (num2 == num)
				{
				}
				num = (short)1135411200;
				short num3 = num;
				num = (short)1816068097;
				if (num != 0)
				{
				}
				num = (short)318963712;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4FeatureListProperty, value);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000B5E8 File Offset: 0x000097E8
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000B6A4 File Offset: 0x000098A4
		public bool DEKButton4IndexIsAcpValid
		{
			get
			{
				short num = (short)1163938249;
				short num2 = num;
				num = (short)1426672073;
				switch (num2 == num)
				{
				}
				num = (short)1278083072;
				short num3 = num;
				num = (short)622854145;
				if (num != 0)
				{
				}
				num = (short)110624768;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1830027265;
				if (num != 0)
				{
				}
				num = (short)1374597704;
				short num2 = num;
				num = (short)1018475080;
				switch (num2 == num)
				{
				default:
				{
					num = (short)468713472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)437125120;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000B760 File Offset: 0x00009960
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000B818 File Offset: 0x00009A18
		public bool DEKButton4IndexIsAcpApplicable
		{
			get
			{
				short num = (short)549847041;
				if (num != 0)
				{
				}
				num = (short)1139789281;
				short num2 = num;
				num = (short)2088029665;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1694826496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)892665856;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1258559761;
				short num2 = num;
				num = (short)1102453009;
				switch (num2 == num)
				{
				}
				num = (short)1910439936;
				short num3 = num;
				num = (short)1203699713;
				if (num != 0)
				{
				}
				num = (short)1361248256;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000B988 File Offset: 0x00009B88
		public bool DEKButton4IndexIsAcpVisible
		{
			get
			{
				short num = (short)1851320603;
				short num2 = num;
				num = (short)1947199771;
				switch (num2 == num)
				{
				}
				num = (short)663879680;
				short num3 = num;
				num = (short)2110193665;
				if (num != 0)
				{
				}
				num = (short)615645184;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1914961921;
				if (num != 0)
				{
				}
				num = (short)1363070079;
				short num2 = num;
				num = (short)1468583039;
				switch (num2 == num)
				{
				default:
				{
					num = (short)18612224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)267649024;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000BA44 File Offset: 0x00009C44
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000BAFC File Offset: 0x00009CFC
		public bool DEKButton4IndexIsAcpEditable
		{
			get
			{
				short num = (short)1767587051;
				short num2 = num;
				num = (short)1500462315;
				switch (num2 == num)
				{
				}
				num = (short)1209204736;
				short num3 = num;
				num = (short)1015545857;
				if (num != 0)
				{
				}
				num = (short)829620224;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1130247191;
				short num2 = num;
				num = (short)590296087;
				switch (num2 == num)
				{
				}
				num = (short)1792999424;
				short num3 = num;
				num = (short)683999232;
				if (num != 0)
				{
				}
				num = (short)1573060609;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000BBB8 File Offset: 0x00009DB8
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000BC70 File Offset: 0x00009E70
		public string DEKButton4IndexUIValue
		{
			get
			{
				short num = (short)402462060;
				short num2 = num;
				num = (short)2017334636;
				switch (num2 == num)
				{
				}
				num = (short)1611792384;
				short num3 = num;
				num = (short)705757185;
				if (num != 0)
				{
				}
				num = (short)1488781312;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton4IndexUIValueProperty);
			}
			set
			{
				short num = (short)1236138135;
				short num2 = num;
				num = (short)676788375;
				switch (num2 == num)
				{
				}
				num = (short)65929216;
				short num3 = num;
				num = (short)551354369;
				if (num != 0)
				{
				}
				num = (short)791674880;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4IndexUIValueProperty, value);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000BD28 File Offset: 0x00009F28
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		public AcpRangeField<int, int> DEKButton4IndexRange
		{
			get
			{
				short num = (short)2128393399;
				short num2 = num;
				num = (short)2086057143;
				switch (num2 == num)
				{
				}
				num = (short)1477312512;
				short num3 = num;
				num = (short)266862593;
				if (num != 0)
				{
				}
				num = (short)641269760;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton4IndexRangeProperty);
			}
			set
			{
				short num = (short)900549118;
				short num2 = num;
				num = (short)98978302;
				switch (num2 == num)
				{
				}
				num = (short)334102528;
				short num3 = num;
				num = (short)1704787968;
				if (num != 0)
				{
				}
				num = (short)656277505;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4IndexRangeProperty, value);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000BE94 File Offset: 0x0000A094
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000BF4C File Offset: 0x0000A14C
		public bool DEKButton4ZoneIsAcpValid
		{
			get
			{
				short num = (short)1483914082;
				short num2 = num;
				num = (short)2113583970;
				switch (num2 == num)
				{
				}
				num = (short)551813120;
				short num3 = num;
				num = (short)1577844737;
				if (num != 0)
				{
				}
				num = (short)455147520;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)245710224;
				short num2 = num;
				num = (short)519781776;
				switch (num2 == num)
				{
				}
				num = (short)1452802048;
				short num3 = num;
				num = (short)1809186817;
				if (num != 0)
				{
				}
				num = (short)389218304;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000C004 File Offset: 0x0000A204
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		public bool DEKButton4ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)1069997457;
				short num2 = num;
				num = (short)1236393361;
				switch (num2 == num)
				{
				}
				num = (short)1635713024;
				short num3 = num;
				num = (short)572456960;
				if (num != 0)
				{
				}
				num = (short)1148715009;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1399537912;
				short num2 = num;
				num = (short)946749688;
				switch (num2 == num)
				{
				}
				num = (short)713555968;
				short num3 = num;
				num = (short)320012289;
				if (num != 0)
				{
				}
				num = (short)507707392;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000C178 File Offset: 0x0000A378
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000C230 File Offset: 0x0000A430
		public bool DEKButton4ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1012731313;
				short num2 = num;
				num = (short)764218801;
				switch (num2 == num)
				{
				}
				num = (short)500826112;
				short num3 = num;
				num = (short)1250164737;
				if (num != 0)
				{
				}
				num = (short)411631616;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)680499632;
				short num2 = num;
				num = (short)125606320;
				switch (num2 == num)
				{
				}
				num = (short)866648064;
				short num3 = num;
				num = (short)1880948737;
				if (num != 0)
				{
				}
				num = (short)232587264;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000C2EC File Offset: 0x0000A4EC
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		public bool DEKButton4ZoneIsAcpEditable
		{
			get
			{
				short num = (short)718571117;
				short num2 = num;
				num = (short)1802536557;
				switch (num2 == num)
				{
				}
				num = (short)1755643904;
				short num3 = num;
				num = (short)1949761537;
				if (num != 0)
				{
				}
				num = (short)2100428800;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1830900167;
				short num2 = num;
				num = (short)691360199;
				switch (num2 == num)
				{
				}
				num = (short)986251264;
				short num3 = num;
				num = (short)1764818945;
				if (num != 0)
				{
				}
				num = (short)2005729280;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000C45C File Offset: 0x0000A65C
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000C518 File Offset: 0x0000A718
		public string DEKButton4ZoneUIValue
		{
			get
			{
				short num = (short)252591774;
				short num2 = num;
				num = (short)2098085534;
				switch (num2 == num)
				{
				}
				num = (short)212992000;
				short num3 = num;
				num = (short)306053121;
				if (num != 0)
				{
				}
				num = (short)1351417856;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton4ZoneUIValueProperty);
			}
			set
			{
				short num = (short)1431973513;
				short num2 = num;
				num = (short)1228287625;
				switch (num2 == num)
				{
				}
				num = (short)535494656;
				short num3 = num;
				num = (short)1201012737;
				if (num != 0)
				{
				}
				num = (short)1013383168;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4ZoneUIValueProperty, value);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000C688 File Offset: 0x0000A888
		public AcpListField DEKButton4ZoneList
		{
			get
			{
				short num = (short)1574867140;
				short num2 = num;
				num = (short)1456443588;
				switch (num2 == num)
				{
				}
				num = (short)826998784;
				short num3 = num;
				num = (short)634454017;
				if (num != 0)
				{
				}
				num = (short)737804288;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton4ZoneListProperty);
			}
			set
			{
				short num = (short)769458707;
				short num2 = num;
				num = (short)320078355;
				switch (num2 == num)
				{
				}
				num = (short)1717436416;
				short num3 = num;
				num = (short)175636480;
				if (num != 0)
				{
				}
				num = (short)1466040321;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4ZoneListProperty, value);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000C73C File Offset: 0x0000A93C
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		public bool DEKButton4ChannelIsAcpValid
		{
			get
			{
				short num = (short)1589232896;
				short num2 = num;
				num = (short)249152768;
				switch (num2 == num)
				{
				}
				num = (short)461504512;
				short num3 = num;
				num = (short)1503985665;
				if (num != 0)
				{
				}
				num = (short)2085683200;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)696320001;
				if (num != 0)
				{
				}
				num = (short)434644790;
				short num2 = num;
				num = (short)1626416950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1233780736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1278672896;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000C8B0 File Offset: 0x0000AAB0
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0000C968 File Offset: 0x0000AB68
		public bool DEKButton4ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)1300917568;
				short num2 = num;
				num = (short)679439680;
				switch (num2 == num)
				{
				}
				num = (short)2109276160;
				short num3 = num;
				num = (short)1417674752;
				if (num != 0)
				{
				}
				num = (short)341966849;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1684656037;
				short num2 = num;
				num = (short)2110312357;
				switch (num2 == num)
				{
				}
				num = (short)1954217984;
				short num3 = num;
				num = (short)270532609;
				if (num != 0)
				{
				}
				num = (short)522256384;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000CA20 File Offset: 0x0000AC20
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
		public bool DEKButton4ChannelIsAcpVisible
		{
			get
			{
				short num = (short)263204795;
				short num2 = num;
				num = (short)1213935547;
				switch (num2 == num)
				{
				}
				num = (short)623050752;
				short num3 = num;
				num = (short)434634753;
				if (num != 0)
				{
				}
				num = (short)27000832;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)959655234;
				short num2 = num;
				num = (short)1408511298;
				switch (num2 == num)
				{
				}
				num = (short)281542656;
				short num3 = num;
				num = (short)221315073;
				if (num != 0)
				{
				}
				num = (short)771293184;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000CB94 File Offset: 0x0000AD94
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000CC50 File Offset: 0x0000AE50
		public bool DEKButton4ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1644071231;
				short num2 = num;
				num = (short)1366329663;
				switch (num2 == num)
				{
				}
				num = (short)547946496;
				short num3 = num;
				num = (short)1985871873;
				if (num != 0)
				{
				}
				num = (short)1635778560;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton4ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)193525258;
				short num2 = num;
				num = (short)638449162;
				switch (num2 == num)
				{
				}
				num = (short)1997930496;
				short num3 = num;
				num = (short)1128595457;
				if (num != 0)
				{
				}
				num = (short)1799815168;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000CD0C File Offset: 0x0000AF0C
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000CDC4 File Offset: 0x0000AFC4
		public string DEKButton4ChannelUIValue
		{
			get
			{
				short num = (short)1020354192;
				short num2 = num;
				num = (short)167927440;
				switch (num2 == num)
				{
				}
				num = (short)1146224640;
				short num3 = num;
				num = (short)1664942081;
				if (num != 0)
				{
				}
				num = (short)1944780800;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton4ChannelUIValueProperty);
			}
			set
			{
				short num = (short)1109861695;
				short num2 = num;
				num = (short)909714751;
				switch (num2 == num)
				{
				}
				num = (short)1314717696;
				short num3 = num;
				num = (short)796524544;
				if (num != 0)
				{
				}
				num = (short)579076097;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4ChannelUIValueProperty, value);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000CE78 File Offset: 0x0000B078
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x0000CF30 File Offset: 0x0000B130
		public AcpListField DEKButton4ChannelList
		{
			get
			{
				short num = (short)453912311;
				short num2 = num;
				num = (short)1771906807;
				switch (num2 == num)
				{
				}
				num = (short)1273298944;
				short num3 = num;
				num = (short)2089811969;
				if (num != 0)
				{
				}
				num = (short)629735424;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton4ChannelListProperty);
			}
			set
			{
				short num = (short)2120519513;
				short num2 = num;
				num = (short)553160537;
				switch (num2 == num)
				{
				}
				num = (short)1953431552;
				short num3 = num;
				num = (short)1839202305;
				if (num != 0)
				{
				}
				num = (short)1553727488;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton4ChannelListProperty, value);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000CFE8 File Offset: 0x0000B1E8
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000D0A0 File Offset: 0x0000B2A0
		public bool DEKButton5FeatureIsAcpValid
		{
			get
			{
				short num = (short)2081412749;
				short num2 = num;
				num = (short)1100600973;
				switch (num2 == num)
				{
				}
				num = (short)632881152;
				short num3 = num;
				num = (short)1529085952;
				if (num != 0)
				{
				}
				num = (short)2130903041;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)2086282564;
				short num2 = num;
				num = (short)1705649476;
				switch (num2 == num)
				{
				}
				num = (short)610533376;
				short num3 = num;
				num = (short)1943404545;
				if (num != 0)
				{
				}
				num = (short)431292416;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000D158 File Offset: 0x0000B358
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000D210 File Offset: 0x0000B410
		public bool DEKButton5FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1590315281;
				short num2 = num;
				num = (short)551831825;
				switch (num2 == num)
				{
				}
				num = (short)1000669184;
				short num3 = num;
				num = (short)1237450753;
				if (num != 0)
				{
				}
				num = (short)1674641408;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)228537666;
				short num2 = num;
				num = (short)1601451330;
				switch (num2 == num)
				{
				}
				num = (short)1749680128;
				short num3 = num;
				num = (short)146276353;
				if (num != 0)
				{
				}
				num = (short)1806499840;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000D2CC File Offset: 0x0000B4CC
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000D388 File Offset: 0x0000B588
		public bool DEKButton5FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1800077313;
				if (num != 0)
				{
				}
				num = (short)1988620191;
				short num2 = num;
				num = (short)1414852511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1788542976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)981336064;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)394985473;
				if (num != 0)
				{
				}
				num = (short)1712674545;
				short num2 = num;
				num = (short)59725553;
				switch (num2 == num)
				{
				default:
				{
					num = (short)608174080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)341770240;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000D444 File Offset: 0x0000B644
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0000D500 File Offset: 0x0000B700
		public bool DEKButton5FeatureIsAcpEditable
		{
			get
			{
				short num = (short)673641573;
				short num2 = num;
				num = (short)478344293;
				switch (num2 == num)
				{
				}
				num = (short)150274048;
				short num3 = num;
				num = (short)1118044160;
				if (num != 0)
				{
				}
				num = (short)1863385089;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1169555457;
				if (num != 0)
				{
				}
				num = (short)2028258884;
				short num2 = num;
				num = (short)1496041028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1586102272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1971453952;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000D5BC File Offset: 0x0000B7BC
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0000D678 File Offset: 0x0000B878
		public string DEKButton5FeatureUIValue
		{
			get
			{
				short num = (short)1287667427;
				short num2 = num;
				num = (short)240467683;
				switch (num2 == num)
				{
				}
				num = (short)1605697536;
				short num3 = num;
				num = (short)157155329;
				if (num != 0)
				{
				}
				num = (short)1089929216;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton5FeatureUIValueProperty);
			}
			set
			{
				short num = (short)185370176;
				short num2 = num;
				num = (short)1236108864;
				switch (num2 == num)
				{
				}
				num = (short)1291911168;
				short num3 = num;
				num = (short)556400641;
				if (num != 0)
				{
				}
				num = (short)1226637312;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000D72C File Offset: 0x0000B92C
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
		public AcpListField DEKButton5FeatureList
		{
			get
			{
				short num = (short)185540366;
				short num2 = num;
				num = (short)1834098446;
				switch (num2 == num)
				{
				}
				num = (short)1299644416;
				short num3 = num;
				num = (short)1628307456;
				if (num != 0)
				{
				}
				num = (short)2097283073;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton5FeatureListProperty);
			}
			set
			{
				short num = (short)1644623052;
				short num2 = num;
				num = (short)560592076;
				switch (num2 == num)
				{
				}
				num = (short)918159360;
				short num3 = num;
				num = (short)1537212417;
				if (num != 0)
				{
				}
				num = (short)1728118784;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5FeatureListProperty, value);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000D898 File Offset: 0x0000BA98
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0000D950 File Offset: 0x0000BB50
		public bool DEKButton5IndexIsAcpValid
		{
			get
			{
				short num = (short)1018555534;
				short num2 = num;
				num = (short)24177806;
				switch (num2 == num)
				{
				}
				num = (short)652869632;
				short num3 = num;
				num = (short)2033057793;
				if (num != 0)
				{
				}
				num = (short)1524826112;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)347799553;
				if (num != 0)
				{
				}
				num = (short)1109710582;
				short num2 = num;
				num = (short)1849743094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)576323584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1875378176;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000DA08 File Offset: 0x0000BC08
		// (set) Token: 0x06000105 RID: 261 RVA: 0x0000DAC4 File Offset: 0x0000BCC4
		public bool DEKButton5IndexIsAcpApplicable
		{
			get
			{
				short num = (short)1067989350;
				short num2 = num;
				num = (short)1155479910;
				switch (num2 == num)
				{
				}
				num = (short)538050560;
				short num3 = num;
				num = (short)346030080;
				if (num != 0)
				{
				}
				num = (short)1874067457;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1689834240;
				short num2 = num;
				num = (short)602395392;
				switch (num2 == num)
				{
				}
				num = (short)2020605952;
				short num3 = num;
				num = (short)680984577;
				if (num != 0)
				{
				}
				num = (short)1631256576;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000DB7C File Offset: 0x0000BD7C
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000DC34 File Offset: 0x0000BE34
		public bool DEKButton5IndexIsAcpVisible
		{
			get
			{
				short num = (short)773814883;
				short num2 = num;
				num = (short)914455139;
				switch (num2 == num)
				{
				}
				num = (short)1050869760;
				short num3 = num;
				num = (short)92340225;
				if (num != 0)
				{
				}
				num = (short)1824915456;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)240010869;
				short num2 = num;
				num = (short)1229407861;
				switch (num2 == num)
				{
				}
				num = (short)582025216;
				short num3 = num;
				num = (short)2048851969;
				if (num != 0)
				{
				}
				num = (short)1649999872;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000DCF0 File Offset: 0x0000BEF0
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0000DDAC File Offset: 0x0000BFAC
		public bool DEKButton5IndexIsAcpEditable
		{
			get
			{
				short num = (short)481257466;
				short num2 = num;
				num = (short)765028346;
				switch (num2 == num)
				{
				}
				num = (short)1677983744;
				short num3 = num;
				num = (short)85655553;
				if (num != 0)
				{
				}
				num = (short)538968064;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)721492800;
				short num2 = num;
				num = (short)1233328960;
				switch (num2 == num)
				{
				}
				num = (short)812253184;
				short num3 = num;
				num = (short)1437859840;
				if (num != 0)
				{
				}
				num = (short)796000257;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000DE68 File Offset: 0x0000C068
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0000DF20 File Offset: 0x0000C120
		public string DEKButton5IndexUIValue
		{
			get
			{
				short num = (short)130294148;
				short num2 = num;
				num = (short)70590852;
				switch (num2 == num)
				{
				}
				num = (short)342294528;
				short num3 = num;
				num = (short)106299392;
				if (num != 0)
				{
				}
				num = (short)775880705;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton5IndexUIValueProperty);
			}
			set
			{
				short num = (short)1934805965;
				short num2 = num;
				num = (short)2004536269;
				switch (num2 == num)
				{
				}
				num = (short)615645184;
				short num3 = num;
				num = (short)847249409;
				if (num != 0)
				{
				}
				num = (short)2101084160;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5IndexUIValueProperty, value);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000DFD4 File Offset: 0x0000C1D4
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000E08C File Offset: 0x0000C28C
		public AcpRangeField<int, int> DEKButton5IndexRange
		{
			get
			{
				short num = (short)1378112529;
				short num2 = num;
				num = (short)734745617;
				switch (num2 == num)
				{
				}
				num = (short)1771700224;
				short num3 = num;
				num = (short)1096482817;
				if (num != 0)
				{
				}
				num = (short)826802176;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton5IndexRangeProperty);
			}
			set
			{
				short num = (short)1408877029;
				short num2 = num;
				num = (short)1185792485;
				switch (num2 == num)
				{
				}
				num = (short)237699072;
				short num3 = num;
				num = (short)1948057601;
				if (num != 0)
				{
				}
				num = (short)367329280;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5IndexRangeProperty, value);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000E144 File Offset: 0x0000C344
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000E1FC File Offset: 0x0000C3FC
		public bool DEKButton5ZoneIsAcpValid
		{
			get
			{
				short num = (short)1171808063;
				short num2 = num;
				num = (short)700407615;
				switch (num2 == num)
				{
				}
				num = (short)599785472;
				short num3 = num;
				num = (short)282591233;
				if (num != 0)
				{
				}
				num = (short)2036334592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)1940417862;
				short num2 = num;
				num = (short)653094214;
				switch (num2 == num)
				{
				}
				num = (short)552927232;
				short num3 = num;
				num = (short)239009792;
				if (num != 0)
				{
				}
				num = (short)1873281025;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000E36C File Offset: 0x0000C56C
		public bool DEKButton5ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)830800987;
				short num2 = num;
				num = (short)2112750683;
				switch (num2 == num)
				{
				}
				num = (short)2099118080;
				short num3 = num;
				num = (short)821100545;
				if (num != 0)
				{
				}
				num = (short)285016064;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)26142762;
				short num2 = num;
				num = (short)2029381674;
				switch (num2 == num)
				{
				}
				num = (short)1059258368;
				short num3 = num;
				num = (short)1386020865;
				if (num != 0)
				{
				}
				num = (short)107544576;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000E428 File Offset: 0x0000C628
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000E4E0 File Offset: 0x0000C6E0
		public bool DEKButton5ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1694396247;
				short num2 = num;
				num = (short)1927442263;
				switch (num2 == num)
				{
				}
				num = (short)1050607616;
				short num3 = num;
				num = (short)1495924737;
				if (num != 0)
				{
				}
				num = (short)1632763904;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)373931693;
				short num2 = num;
				num = (short)752533165;
				switch (num2 == num)
				{
				}
				num = (short)1232404480;
				short num3 = num;
				num = (short)1455357953;
				if (num != 0)
				{
				}
				num = (short)1961164800;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000E59C File Offset: 0x0000C79C
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000E654 File Offset: 0x0000C854
		public bool DEKButton5ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1333324653;
				short num2 = num;
				num = (short)1509157741;
				switch (num2 == num)
				{
				}
				num = (short)805830656;
				short num3 = num;
				num = (short)1647116289;
				if (num != 0)
				{
				}
				num = (short)876675072;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1805817378;
				short num2 = num;
				num = (short)1528272418;
				switch (num2 == num)
				{
				}
				num = (short)1895628800;
				short num3 = num;
				num = (short)1219231744;
				if (num != 0)
				{
				}
				num = (short)1317208065;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000E70C File Offset: 0x0000C90C
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
		public string DEKButton5ZoneUIValue
		{
			get
			{
				short num = (short)989795992;
				short num2 = num;
				num = (short)767301272;
				switch (num2 == num)
				{
				}
				num = (short)1205862400;
				short num3 = num;
				num = (short)1833304064;
				if (num != 0)
				{
				}
				num = (short)1406074881;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton5ZoneUIValueProperty);
			}
			set
			{
				short num = (short)492391992;
				short num2 = num;
				num = (short)2012630584;
				switch (num2 == num)
				{
				}
				num = (short)2141978624;
				short num3 = num;
				num = (short)1703739393;
				if (num != 0)
				{
				}
				num = (short)721616896;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5ZoneUIValueProperty, value);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000E878 File Offset: 0x0000CA78
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000E930 File Offset: 0x0000CB30
		public AcpListField DEKButton5ZoneList
		{
			get
			{
				short num = (short)1785490026;
				short num2 = num;
				num = (short)866937450;
				switch (num2 == num)
				{
				}
				num = (short)1471086592;
				short num3 = num;
				num = (short)598343681;
				if (num != 0)
				{
				}
				num = (short)146669568;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton5ZoneListProperty);
			}
			set
			{
				short num = (short)1671424109;
				short num2 = num;
				num = (short)1208150125;
				switch (num2 == num)
				{
				}
				num = (short)107544576;
				short num3 = num;
				num = (short)596312065;
				if (num != 0)
				{
				}
				num = (short)408551424;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5ZoneListProperty, value);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0000E9E4 File Offset: 0x0000CBE4
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		public bool DEKButton5ChannelIsAcpValid
		{
			get
			{
				short num = (short)818499742;
				short num2 = num;
				num = (short)914575518;
				switch (num2 == num)
				{
				}
				num = (short)1092485120;
				short num3 = num;
				num = (short)496697344;
				if (num != 0)
				{
				}
				num = (short)2073362433;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)998265130;
				short num2 = num;
				num = (short)1027428650;
				switch (num2 == num)
				{
				}
				num = (short)296615936;
				short num3 = num;
				num = (short)2069495808;
				if (num != 0)
				{
				}
				num = (short)474152961;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0000EB58 File Offset: 0x0000CD58
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000EC10 File Offset: 0x0000CE10
		public bool DEKButton5ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)930112039;
				short num2 = num;
				num = (short)1185047079;
				switch (num2 == num)
				{
				}
				num = (short)1602682880;
				short num3 = num;
				num = (short)2078408705;
				if (num != 0)
				{
				}
				num = (short)697499648;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)785704877;
				short num2 = num;
				num = (short)85387181;
				switch (num2 == num)
				{
				}
				num = (short)1286078464;
				short num3 = num;
				num = (short)499449857;
				if (num != 0)
				{
				}
				num = (short)1583480832;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000ECCC File Offset: 0x0000CECC
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000ED8C File Offset: 0x0000CF8C
		public bool DEKButton5ChannelIsAcpVisible
		{
			get
			{
				short num = (short)365509155;
				short num2 = num;
				num = (short)18954787;
				switch (num2 == num)
				{
				}
				num = (short)2126577664;
				short num3 = num;
				num = (short)1211367425;
				if (num != 0)
				{
				}
				num = (short)865009664;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1745275519;
				short num2 = num;
				num = (short)1020381823;
				switch (num2 == num)
				{
				}
				num = (short)213647360;
				short num3 = num;
				num = (short)1354629121;
				if (num != 0)
				{
				}
				num = (short)1324810240;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000120 RID: 288 RVA: 0x0000EE44 File Offset: 0x0000D044
		// (set) Token: 0x06000121 RID: 289 RVA: 0x0000EEFC File Offset: 0x0000D0FC
		public bool DEKButton5ChannelIsAcpEditable
		{
			get
			{
				short num = (short)414303024;
				short num2 = num;
				num = (short)1040040752;
				switch (num2 == num)
				{
				}
				num = (short)1193607168;
				short num3 = num;
				num = (short)921370625;
				if (num != 0)
				{
				}
				num = (short)734134272;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton5ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)970079935;
				short num2 = num;
				num = (short)1717780159;
				switch (num2 == num)
				{
				}
				num = (short)1045037056;
				short num3 = num;
				num = (short)178388992;
				if (num != 0)
				{
				}
				num = (short)69206017;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000F074 File Offset: 0x0000D274
		public string DEKButton5ChannelUIValue
		{
			get
			{
				short num = (short)663224321;
				if (num != 0)
				{
				}
				num = (short)1216415784;
				short num2 = num;
				num = (short)1645021224;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1448148992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1659633664;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton5ChannelUIValueProperty);
			}
			set
			{
				short num = (short)314734708;
				short num2 = num;
				num = (short)262174836;
				switch (num2 == num)
				{
				}
				num = (short)753336320;
				short num3 = num;
				num = (short)1832452097;
				if (num != 0)
				{
				}
				num = (short)1573978112;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5ChannelUIValueProperty, value);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000F128 File Offset: 0x0000D328
		// (set) Token: 0x06000125 RID: 293 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		public AcpListField DEKButton5ChannelList
		{
			get
			{
				short num = (short)1789198337;
				if (num != 0)
				{
				}
				num = (short)1664082711;
				short num2 = num;
				num = (short)1127277335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)685441024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)879558656;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton5ChannelListProperty);
			}
			set
			{
				short num = (short)1848858821;
				short num2 = num;
				num = (short)1288132805;
				switch (num2 == num)
				{
				}
				num = (short)2020605952;
				short num3 = num;
				num = (short)87228417;
				if (num != 0)
				{
				}
				num = (short)461504512;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton5ChannelListProperty, value);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000F294 File Offset: 0x0000D494
		// (set) Token: 0x06000127 RID: 295 RVA: 0x0000F350 File Offset: 0x0000D550
		public bool DEKButton6FeatureIsAcpValid
		{
			get
			{
				short num = (short)996537307;
				short num2 = num;
				num = (short)358347739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1667235840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)825753601;
				if (num != 0)
				{
				}
				num = (short)72417280;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)2017703486;
				short num2 = num;
				num = (short)644920894;
				switch (num2 == num)
				{
				default:
				{
					num = (short)376504320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)776404993;
				if (num != 0)
				{
				}
				num = (short)1924268032;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000F40C File Offset: 0x0000D60C
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		public bool DEKButton6FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1540717478;
				short num2 = num;
				num = (short)1610840998;
				switch (num2 == num)
				{
				default:
				{
					num = (short)295567360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2081554432;
				if (num != 0)
				{
				}
				num = (short)1703346177;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)670898203;
				short num2 = num;
				num = (short)1248335899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2113667072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1035141121;
				if (num != 0)
				{
				}
				num = (short)1400176640;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000F580 File Offset: 0x0000D780
		// (set) Token: 0x0600012B RID: 299 RVA: 0x0000F638 File Offset: 0x0000D838
		public bool DEKButton6FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1239989572;
				short num2 = num;
				num = (short)20692292;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1747845120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)860487681;
				if (num != 0)
				{
				}
				num = (short)471269376;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1331497911;
				short num2 = num;
				num = (short)1017383863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1683881984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)164429824;
				if (num != 0)
				{
				}
				num = (short)1092681729;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000F6F8 File Offset: 0x0000D8F8
		// (set) Token: 0x0600012D RID: 301 RVA: 0x0000F7B4 File Offset: 0x0000D9B4
		public bool DEKButton6FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1600980;
				short num2 = num;
				num = (short)2073980372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)329842688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)676462593;
				if (num != 0)
				{
				}
				num = (short)512688128;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)155454143;
				short num2 = num;
				num = (short)1092422335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1949302784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)375324673;
				if (num != 0)
				{
				}
				num = (short)1878523904;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0000F86C File Offset: 0x0000DA6C
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0000F928 File Offset: 0x0000DB28
		public string DEKButton6FeatureUIValue
		{
			get
			{
				short num = (short)1997590835;
				short num2 = num;
				num = (short)270455091;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1225392128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)370933761;
				if (num != 0)
				{
				}
				num = (short)312475648;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton6FeatureUIValueProperty);
			}
			set
			{
				short num = (short)319684609;
				if (num != 0)
				{
				}
				num = (short)388300800;
				short num2 = num;
				num = (short)700352300;
				short num3 = num;
				num = (short)1675069228;
				switch (num3 == num)
				{
				}
				num = (short)492634112;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000F9E0 File Offset: 0x0000DBE0
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0000FA98 File Offset: 0x0000DC98
		public AcpListField DEKButton6FeatureList
		{
			get
			{
				short num = (short)1431361027;
				short num2 = num;
				num = (short)1310840323;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1436680192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)688914433;
				if (num != 0)
				{
				}
				num = (short)439615488;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton6FeatureListProperty);
			}
			set
			{
				short num = (short)606962265;
				short num2 = num;
				num = (short)907182681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2096300032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1399652353;
				if (num != 0)
				{
				}
				num = (short)955711488;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6FeatureListProperty, value);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000FB4C File Offset: 0x0000DD4C
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0000FC08 File Offset: 0x0000DE08
		public bool DEKButton6IndexIsAcpValid
		{
			get
			{
				short num = (short)1027035798;
				short num2 = num;
				num = (short)1247433366;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2008940544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2089287681;
				if (num != 0)
				{
				}
				num = (short)1186660352;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1688931386;
				short num2 = num;
				num = (short)1970867258;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2048393216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1136197633;
				if (num != 0)
				{
				}
				num = (short)365821952;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		// (set) Token: 0x06000135 RID: 309 RVA: 0x0000FD78 File Offset: 0x0000DF78
		public bool DEKButton6IndexIsAcpApplicable
		{
			get
			{
				short num = (short)645486316;
				short num2 = num;
				num = (short)844519148;
				switch (num2 == num)
				{
				default:
				{
					num = (short)644349952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1566113793;
				if (num != 0)
				{
				}
				num = (short)2143617024;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)329416757;
				short num2 = num;
				num = (short)109609013;
				switch (num2 == num)
				{
				default:
				{
					num = (short)623443968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)608174080;
				if (num != 0)
				{
				}
				num = (short)90767361;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000FE34 File Offset: 0x0000E034
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0000FEEC File Offset: 0x0000E0EC
		public bool DEKButton6IndexIsAcpVisible
		{
			get
			{
				short num = (short)1125449729;
				if (num != 0)
				{
				}
				num = (short)1995833344;
				short num2 = num;
				num = (short)681024211;
				short num3 = num;
				num = (short)1206622931;
				switch (num3 == num)
				{
				}
				num = (short)1586561024;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)674990315;
				short num2 = num;
				num = (short)1186302187;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1868431360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)865468417;
				if (num != 0)
				{
				}
				num = (short)971505664;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000FFA4 File Offset: 0x0000E1A4
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0001005C File Offset: 0x0000E25C
		public bool DEKButton6IndexIsAcpEditable
		{
			get
			{
				short num = (short)1170988595;
				short num2 = num;
				num = (short)1650187827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)98566144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1809645569;
				if (num != 0)
				{
				}
				num = (short)1505689600;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1923915350;
				short num2 = num;
				num = (short)1796513366;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1188102144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1770389505;
				if (num != 0)
				{
				}
				num = (short)447152128;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00010114 File Offset: 0x0000E314
		// (set) Token: 0x0600013B RID: 315 RVA: 0x000101CC File Offset: 0x0000E3CC
		public string DEKButton6IndexUIValue
		{
			get
			{
				short num = (short)491154572;
				short num2 = num;
				num = (short)783969420;
				switch (num2 == num)
				{
				default:
				{
					num = (short)847052800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)321191937;
				if (num != 0)
				{
				}
				num = (short)1001783296;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton6IndexUIValueProperty);
			}
			set
			{
				short num = (short)1986089208;
				short num2 = num;
				num = (short)835277048;
				switch (num2 == num)
				{
				default:
				{
					num = (short)968097792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)301268993;
				if (num != 0)
				{
				}
				num = (short)1823342592;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6IndexUIValueProperty, value);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00010284 File Offset: 0x0000E484
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00010340 File Offset: 0x0000E540
		public AcpRangeField<int, int> DEKButton6IndexRange
		{
			get
			{
				short num = (short)854884962;
				short num2 = num;
				num = (short)795378274;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1048772608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)478871552;
				if (num != 0)
				{
				}
				num = (short)1520566273;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton6IndexRangeProperty);
			}
			set
			{
				short num = (short)1513826616;
				short num2 = num;
				num = (short)250161464;
				switch (num2 == num)
				{
				default:
				{
					num = (short)536150016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1024917505;
				if (num != 0)
				{
				}
				num = (short)1964113920;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6IndexRangeProperty, value);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000103F8 File Offset: 0x0000E5F8
		// (set) Token: 0x0600013F RID: 319 RVA: 0x000104B0 File Offset: 0x0000E6B0
		public bool DEKButton6ZoneIsAcpValid
		{
			get
			{
				short num = (short)1432027137;
				if (num != 0)
				{
				}
				num = (short)725352448;
				short num2 = num;
				num = (short)204399693;
				short num3 = num;
				num = (short)213640269;
				switch (num3 == num)
				{
				}
				num = (short)547422208;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)622100557;
				short num2 = num;
				num = (short)429621325;
				switch (num2 == num)
				{
				default:
				{
					num = (short)308346880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1653276672;
				if (num != 0)
				{
				}
				num = (short)90505217;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0001056C File Offset: 0x0000E76C
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00010628 File Offset: 0x0000E828
		public bool DEKButton6ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)579526940;
				short num2 = num;
				num = (short)250011932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1129971712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1894776833;
				if (num != 0)
				{
				}
				num = (short)1386938368;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)126834436;
				short num2 = num;
				num = (short)2012043012;
				switch (num2 == num)
				{
				default:
				{
					num = (short)751435776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)358940673;
				if (num != 0)
				{
				}
				num = (short)666107904;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000106E0 File Offset: 0x0000E8E0
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0001079C File Offset: 0x0000E99C
		public bool DEKButton6ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1198065821;
				short num2 = num;
				num = (short)1569917085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1431633920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1059782656;
				if (num != 0)
				{
				}
				num = (short)1284898817;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1373705553;
				short num2 = num;
				num = (short)448927057;
				switch (num2 == num)
				{
				default:
				{
					num = (short)760741888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1453785089;
				if (num != 0)
				{
				}
				num = (short)274464768;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00010854 File Offset: 0x0000EA54
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0001090C File Offset: 0x0000EB0C
		public bool DEKButton6ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1949153725;
				short num2 = num;
				num = (short)519027133;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1360592896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1207894017;
				if (num != 0)
				{
				}
				num = (short)1214185472;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1771038410;
				short num2 = num;
				num = (short)406644426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)856162304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1622540289;
				if (num != 0)
				{
				}
				num = (short)993263616;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000109C8 File Offset: 0x0000EBC8
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00010A84 File Offset: 0x0000EC84
		public string DEKButton6ZoneUIValue
		{
			get
			{
				short num = (short)169249326;
				short num2 = num;
				num = (short)1267632686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2065367040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1564082177;
				if (num != 0)
				{
				}
				num = (short)988610560;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton6ZoneUIValueProperty);
			}
			set
			{
				short num = (short)1688382358;
				short num2 = num;
				num = (short)1410116502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)303038464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1303969793;
				if (num != 0)
				{
				}
				num = (short)1689321472;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6ZoneUIValueProperty, value);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00010B38 File Offset: 0x0000ED38
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		public AcpListField DEKButton6ZoneList
		{
			get
			{
				short num = (short)2117399630;
				short num2 = num;
				num = (short)1119679566;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1813118976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)357629952;
				if (num != 0)
				{
				}
				num = (short)1739980801;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton6ZoneListProperty);
			}
			set
			{
				short num = (short)1082898713;
				short num2 = num;
				num = (short)2141698329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1554120704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1205665792;
				if (num != 0)
				{
				}
				num = (short)1066336257;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6ZoneListProperty, value);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00010CAC File Offset: 0x0000EEAC
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00010D68 File Offset: 0x0000EF68
		public bool DEKButton6ChannelIsAcpValid
		{
			get
			{
				short num = (short)2097627910;
				short num2 = num;
				num = (short)2017149702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)122028032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)963641345;
				if (num != 0)
				{
				}
				num = (short)789250048;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)178377553;
				short num2 = num;
				num = (short)971756369;
				switch (num2 == num)
				{
				default:
				{
					num = (short)747175936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)592510976;
				if (num != 0)
				{
				}
				num = (short)138805249;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00010E24 File Offset: 0x0000F024
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00010EE0 File Offset: 0x0000F0E0
		public bool DEKButton6ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)429906142;
				short num2 = num;
				num = (short)741136606;
				switch (num2 == num)
				{
				default:
				{
					num = (short)690159616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)387842049;
				if (num != 0)
				{
				}
				num = (short)1666187264;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)736493569;
				if (num != 0)
				{
				}
				num = (short)1079705600;
				short num2 = num;
				num = (short)1249970913;
				short num3 = num;
				num = (short)1228933857;
				switch (num3 == num)
				{
				}
				num = (short)2089943040;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00010F9C File Offset: 0x0000F19C
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00011058 File Offset: 0x0000F258
		public bool DEKButton6ChannelIsAcpVisible
		{
			get
			{
				short num = (short)808509539;
				short num2 = num;
				num = (short)16834659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1605959680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)78249985;
				if (num != 0)
				{
				}
				num = (short)2014904320;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)271343530;
				short num2 = num;
				num = (short)190668714;
				switch (num2 == num)
				{
				default:
				{
					num = (short)317587456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)943521793;
				if (num != 0)
				{
				}
				num = (short)94240768;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00011118 File Offset: 0x0000F318
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000111D4 File Offset: 0x0000F3D4
		public bool DEKButton6ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1355618106;
				short num2 = num;
				num = (short)1146361658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)267583488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)211484673;
				if (num != 0)
				{
				}
				num = (short)2020802560;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton6ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1804126577;
				short num2 = num;
				num = (short)1535101297;
				switch (num2 == num)
				{
				default:
				{
					num = (short)256835584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)925696000;
				if (num != 0)
				{
				}
				num = (short)1563951105;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0001128C File Offset: 0x0000F48C
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00011344 File Offset: 0x0000F544
		public string DEKButton6ChannelUIValue
		{
			get
			{
				short num = (short)1648065319;
				short num2 = num;
				num = (short)456751911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2045444096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)241369088;
				if (num != 0)
				{
				}
				num = (short)1533214721;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton6ChannelUIValueProperty);
			}
			set
			{
				short num = (short)467337217;
				if (num != 0)
				{
				}
				num = (short)150601728;
				short num2 = num;
				num = (short)1979834317;
				short num3 = num;
				num = (short)2005065677;
				switch (num3 == num)
				{
				}
				num = (short)528351232;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6ChannelUIValueProperty, value);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000113FC File Offset: 0x0000F5FC
		// (set) Token: 0x06000155 RID: 341 RVA: 0x000114B8 File Offset: 0x0000F6B8
		public AcpListField DEKButton6ChannelList
		{
			get
			{
				short num = (short)664442134;
				short num2 = num;
				num = (short)2128385302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)182976512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1342832640;
				if (num != 0)
				{
				}
				num = (short)361234433;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton6ChannelListProperty);
			}
			set
			{
				short num = (short)494731265;
				if (num != 0)
				{
				}
				num = (short)1647378432;
				short num2 = num;
				num = (short)178728424;
				short num3 = num;
				num = (short)473247208;
				switch (num3 == num)
				{
				}
				num = (short)30408704;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton6ChannelListProperty, value);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0001156C File Offset: 0x0000F76C
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00011628 File Offset: 0x0000F828
		public bool DEKButton7FeatureIsAcpValid
		{
			get
			{
				short num = (short)1628599186;
				short num2 = num;
				num = (short)1614377874;
				switch (num2 == num)
				{
				default:
				{
					num = (short)356712448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1421934593;
				if (num != 0)
				{
				}
				num = (short)1264517120;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton7FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)351159034;
				short num2 = num;
				num = (short)1962885882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1596588032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1592590337;
				if (num != 0)
				{
				}
				num = (short)96600064;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton7FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000116E0 File Offset: 0x0000F8E0
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00011798 File Offset: 0x0000F998
		public bool DEKButton7FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1310368748;
				short num2 = num;
				num = (short)1703846892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1384382464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1460797440;
				if (num != 0)
				{
				}
				num = (short)1706885121;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton7FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1174372156;
				short num2 = num;
				num = (short)316571452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)134348800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1992097792;
				if (num != 0)
				{
				}
				num = (short)2072248321;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton7FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00011854 File Offset: 0x0000FA54
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00011910 File Offset: 0x0000FB10
		public bool DEKButton7FeatureIsAcpVisible
		{
			get
			{
				short num = (short)546478656;
				short num2 = num;
				num = (short)1432394304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)387448832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1228013569;
				if (num != 0)
				{
				}
				num = (short)191365120;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton7FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1881883841;
				short num2 = num;
				num = (short)498943169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1968963584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)361562113;
				if (num != 0)
				{
				}
				num = (short)1799028736;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton7FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000119CC File Offset: 0x0000FBCC
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00011A88 File Offset: 0x0000FC88
		public bool DEKButton7FeatureIsAcpEditable
		{
			get
			{
				short num = (short)934603832;
				short num2 = num;
				num = (short)238742584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1746337792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)881459201;
				if (num != 0)
				{
				}
				num = (short)1922760704;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton7FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1525523171;
				short num2 = num;
				num = (short)1512022755;
				switch (num2 == num)
				{
				default:
				{
					num = (short)710475776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)129105921;
				if (num != 0)
				{
				}
				num = (short)1336672256;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton7FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00011B44 File Offset: 0x0000FD44
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00011C00 File Offset: 0x0000FE00
		public string DEKButton7FeatureUIValue
		{
			get
			{
				short num = (short)737489884;
				short num2 = num;
				num = (short)1240675292;
				switch (num2 == num)
				{
				default:
				{
					num = (short)773062656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2021326848;
				if (num != 0)
				{
				}
				num = (short)429916161;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton7FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1894929006;
				short num2 = num;
				num = (short)1214206574;
				switch (num2 == num)
				{
				default:
				{
					num = (short)497942528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)509083649;
				if (num != 0)
				{
				}
				num = (short)274857984;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton7FeatureUIValueProperty, value);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00011CB4 File Offset: 0x0000FEB4
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00011D70 File Offset: 0x0000FF70
		public AcpListField DEKButton7FeatureList
		{
			get
			{
				short num = (short)1261908941;
				short num2 = num;
				num = (short)1891775437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)652738560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1198981121;
				if (num != 0)
				{
				}
				num = (short)770441216;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton7FeatureListProperty);
			}
			set
			{
				short num = (short)1047608567;
				short num2 = num;
				num = (short)2124496119;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1638465536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1614217217;
				if (num != 0)
				{
				}
				num = (short)1781792768;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton7FeatureListProperty, value);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00011E28 File Offset: 0x00010028
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00011EE0 File Offset: 0x000100E0
		public bool DEKButton7IndexIsAcpValid
		{
			get
			{
				short num = (short)90516123;
				short num2 = num;
				num = (short)452471451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1206714368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)945094657;
				if (num != 0)
				{
				}
				num = (short)341442560;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton7IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1717442256;
				short num2 = num;
				num = (short)1013389008;
				switch (num2 == num)
				{
				}
				num = (short)569376768;
				if (num != 0)
				{
				}
				num = (short)1738997761;
				if (num != 0)
				{
				}
				num = (short)1417871360;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00011F9C File Offset: 0x0001019C
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00012054 File Offset: 0x00010254
		public bool DEKButton7IndexIsAcpApplicable
		{
			get
			{
				short num = (short)1376453154;
				short num2 = num;
				num = (short)1514603042;
				switch (num2 == num)
				{
				}
				num = (short)940048384;
				if (num != 0)
				{
				}
				num = (short)1823342593;
				if (num != 0)
				{
				}
				num = (short)1785659392;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton7IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)441629665;
				short num2 = num;
				num = (short)116767713;
				switch (num2 == num)
				{
				}
				num = (short)218628096;
				if (num != 0)
				{
				}
				num = (short)1727004673;
				if (num != 0)
				{
				}
				num = (short)1238630400;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00012110 File Offset: 0x00010310
		// (set) Token: 0x06000167 RID: 359 RVA: 0x000121CC File Offset: 0x000103CC
		public bool DEKButton7IndexIsAcpVisible
		{
			get
			{
				short num = (short)288279919;
				short num2 = num;
				num = (short)249089391;
				switch (num2 == num)
				{
				}
				num = (short)1742995456;
				if (num != 0)
				{
				}
				num = (short)1621164033;
				if (num != 0)
				{
				}
				num = (short)1294991360;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton7IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)624619320;
				short num2 = num;
				num = (short)580644664;
				switch (num2 == num)
				{
				}
				num = (short)1688469505;
				if (num != 0)
				{
				}
				num = (short)1325400064;
				if (num != 0)
				{
				}
				num = (short)244121600;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00012288 File Offset: 0x00010488
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00012340 File Offset: 0x00010540
		public bool DEKButton7IndexIsAcpEditable
		{
			get
			{
				short num = (short)379385899;
				short num2 = num;
				num = (short)288421931;
				switch (num2 == num)
				{
				}
				num = (short)1205272577;
				if (num != 0)
				{
				}
				num = (short)30932992;
				if (num != 0)
				{
				}
				num = (short)955645952;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton7IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1461626623;
				short num2 = num;
				num = (short)1357686527;
				switch (num2 == num)
				{
				}
				num = (short)223608833;
				if (num != 0)
				{
				}
				num = (short)617152512;
				if (num != 0)
				{
				}
				num = (short)1006895104;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000123F8 File Offset: 0x000105F8
		// (set) Token: 0x0600016B RID: 363 RVA: 0x000124B0 File Offset: 0x000106B0
		public string DEKButton7IndexUIValue
		{
			get
			{
				short num = (short)2085427180;
				short num2 = num;
				num = (short)1591482348;
				switch (num2 == num)
				{
				}
				num = (short)200605697;
				if (num != 0)
				{
				}
				num = (short)1386479616;
				if (num != 0)
				{
				}
				num = (short)662241280;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton7IndexUIValueProperty);
			}
			set
			{
				short num = (short)58826195;
				short num2 = num;
				num = (short)866164179;
				switch (num2 == num)
				{
				}
				num = (short)1032650752;
				if (num != 0)
				{
				}
				num = (short)1023475713;
				if (num != 0)
				{
				}
				num = (short)2039939072;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7IndexUIValueProperty, value);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00012568 File Offset: 0x00010768
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00012624 File Offset: 0x00010824
		public AcpRangeField<int, int> DEKButton7IndexRange
		{
			get
			{
				short num = (short)663567663;
				short num2 = num;
				num = (short)77085999;
				switch (num2 == num)
				{
				}
				num = (short)852426753;
				if (num != 0)
				{
				}
				num = (short)1973420032;
				if (num != 0)
				{
				}
				num = (short)434765824;
				short num3 = num;
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton7IndexRangeProperty);
			}
			set
			{
				short num = (short)33226753;
				if (num != 0)
				{
				}
				num = (short)1009764225;
				short num2 = num;
				num = (short)744277889;
				switch (num2 == num)
				{
				}
				num = (short)692322304;
				if (num != 0)
				{
				}
				num = (short)929824768;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7IndexRangeProperty, value);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000126DC File Offset: 0x000108DC
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00012798 File Offset: 0x00010998
		public bool DEKButton7ZoneIsAcpValid
		{
			get
			{
				short num = (short)740012045;
				short num2 = num;
				num = (short)1963372557;
				switch (num2 == num)
				{
				}
				num = (short)46465024;
				if (num != 0)
				{
				}
				num = (short)738983937;
				if (num != 0)
				{
				}
				num = (short)764411904;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton7ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)625333074;
				short num2 = num;
				num = (short)1162072914;
				switch (num2 == num)
				{
				}
				num = (short)914489345;
				if (num != 0)
				{
				}
				num = (short)286195712;
				if (num != 0)
				{
				}
				num = (short)533069824;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00012854 File Offset: 0x00010A54
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00012910 File Offset: 0x00010B10
		public bool DEKButton7ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)801750514;
				short num2 = num;
				num = (short)1494203890;
				switch (num2 == num)
				{
				}
				num = (short)2006712321;
				if (num != 0)
				{
				}
				num = (short)724107264;
				if (num != 0)
				{
				}
				num = (short)1791950848;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton7ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1142885601;
				short num2 = num;
				num = (short)1999572193;
				switch (num2 == num)
				{
				}
				num = (short)591527936;
				if (num != 0)
				{
				}
				num = (short)495910913;
				if (num != 0)
				{
				}
				num = (short)954073088;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000129CC File Offset: 0x00010BCC
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00012A84 File Offset: 0x00010C84
		public bool DEKButton7ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1641429437;
				short num2 = num;
				num = (short)693189053;
				switch (num2 == num)
				{
				}
				num = (short)403636224;
				if (num != 0)
				{
				}
				num = (short)1119813633;
				if (num != 0)
				{
				}
				num = (short)16580608;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton7ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2094708976;
				short num2 = num;
				num = (short)1273739504;
				switch (num2 == num)
				{
				}
				num = (short)309657600;
				if (num != 0)
				{
				}
				num = (short)1997996033;
				if (num != 0)
				{
				}
				num = (short)1893990400;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00012B40 File Offset: 0x00010D40
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00012BFC File Offset: 0x00010DFC
		public bool DEKButton7ZoneIsAcpEditable
		{
			get
			{
				short num = (short)2113711633;
				short num2 = num;
				num = (short)293449233;
				switch (num2 == num)
				{
				}
				num = (short)1555824641;
				if (num != 0)
				{
				}
				num = (short)1492516864;
				if (num != 0)
				{
				}
				num = (short)813301760;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton7ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)24052864;
				short num2 = num;
				num = (short)187171968;
				switch (num2 == num)
				{
				}
				num = (short)672268288;
				if (num != 0)
				{
				}
				num = (short)1999044609;
				if (num != 0)
				{
				}
				num = (short)1392246784;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00012CB4 File Offset: 0x00010EB4
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00012D6C File Offset: 0x00010F6C
		public string DEKButton7ZoneUIValue
		{
			get
			{
				short num = (short)1670512641;
				if (num != 0)
				{
				}
				num = (short)1998187318;
				short num2 = num;
				num = (short)2069949238;
				switch (num2 == num)
				{
				}
				num = (short)327417856;
				if (num != 0)
				{
				}
				num = (short)2027356160;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton7ZoneUIValueProperty);
			}
			set
			{
				short num = (short)1468203009;
				if (num != 0)
				{
				}
				num = (short)1930605363;
				short num2 = num;
				num = (short)1780593459;
				switch (num2 == num)
				{
				}
				num = (short)795934720;
				if (num != 0)
				{
				}
				num = (short)147849216;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7ZoneUIValueProperty, value);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00012E20 File Offset: 0x00011020
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00012ED8 File Offset: 0x000110D8
		public AcpListField DEKButton7ZoneList
		{
			get
			{
				short num = (short)1612251137;
				if (num != 0)
				{
				}
				num = (short)1563550578;
				short num2 = num;
				num = (short)410444658;
				switch (num2 == num)
				{
				}
				num = (short)1992818688;
				if (num != 0)
				{
				}
				num = (short)881328128;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton7ZoneListProperty);
			}
			set
			{
				short num = (short)1601437697;
				if (num != 0)
				{
				}
				num = (short)533841314;
				short num2 = num;
				num = (short)1272628642;
				switch (num2 == num)
				{
				}
				num = (short)1820917760;
				if (num != 0)
				{
				}
				num = (short)510722048;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7ZoneListProperty, value);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00012F8C File Offset: 0x0001118C
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00013048 File Offset: 0x00011248
		public bool DEKButton7ChannelIsAcpValid
		{
			get
			{
				short num = (short)392130917;
				short num2 = num;
				num = (short)321417573;
				switch (num2 == num)
				{
				}
				num = (short)112656385;
				if (num != 0)
				{
				}
				num = (short)815202304;
				if (num != 0)
				{
				}
				num = (short)1602748416;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton7ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)1318140544;
				short num2 = num;
				num = (short)1380858496;
				switch (num2 == num)
				{
				}
				num = (short)83689473;
				if (num != 0)
				{
				}
				num = (short)252444672;
				if (num != 0)
				{
				}
				num = (short)1455423488;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00013100 File Offset: 0x00011300
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000131B8 File Offset: 0x000113B8
		public bool DEKButton7ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)1344752778;
				short num2 = num;
				num = (short)1095978122;
				switch (num2 == num)
				{
				}
				num = (short)817102849;
				if (num != 0)
				{
				}
				num = (short)428736512;
				if (num != 0)
				{
				}
				num = (short)1607794688;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton7ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1359496557;
				short num2 = num;
				num = (short)597116269;
				switch (num2 == num)
				{
				}
				num = (short)117506049;
				if (num != 0)
				{
				}
				num = (short)1950416896;
				if (num != 0)
				{
				}
				num = (short)27787264;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00013274 File Offset: 0x00011474
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00013330 File Offset: 0x00011530
		public bool DEKButton7ChannelIsAcpVisible
		{
			get
			{
				short num = (short)587906909;
				short num2 = num;
				num = (short)1394655069;
				switch (num2 == num)
				{
				}
				num = (short)652673025;
				if (num != 0)
				{
				}
				num = (short)36634624;
				if (num != 0)
				{
				}
				num = (short)1960640512;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton7ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1028149611;
				short num2 = num;
				num = (short)1183142251;
				switch (num2 == num)
				{
				}
				num = (short)1138163712;
				if (num != 0)
				{
				}
				num = (short)1014169601;
				if (num != 0)
				{
				}
				num = (short)1315897344;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000133EC File Offset: 0x000115EC
		// (set) Token: 0x06000181 RID: 385 RVA: 0x000134A4 File Offset: 0x000116A4
		public bool DEKButton7ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1406633276;
				short num2 = num;
				num = (short)2124055868;
				switch (num2 == num)
				{
				}
				num = (short)355467264;
				if (num != 0)
				{
				}
				num = (short)1276051457;
				if (num != 0)
				{
				}
				num = (short)1183776768;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton7ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1318121624;
				short num2 = num;
				num = (short)2091249816;
				switch (num2 == num)
				{
				}
				num = (short)321716224;
				if (num != 0)
				{
				}
				num = (short)1785069569;
				if (num != 0)
				{
				}
				num = (short)1961164800;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00013560 File Offset: 0x00011760
		// (set) Token: 0x06000183 RID: 387 RVA: 0x0001361C File Offset: 0x0001181C
		public string DEKButton7ChannelUIValue
		{
			get
			{
				short num = (short)179085188;
				short num2 = num;
				num = (short)358064004;
				switch (num2 == num)
				{
				}
				num = (short)238551040;
				if (num != 0)
				{
				}
				num = (short)1368129537;
				if (num != 0)
				{
				}
				num = (short)559087616;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton7ChannelUIValueProperty);
			}
			set
			{
				short num = (short)561814502;
				short num2 = num;
				num = (short)777296870;
				switch (num2 == num)
				{
				}
				num = (short)514588672;
				if (num != 0)
				{
				}
				num = (short)1739718657;
				if (num != 0)
				{
				}
				num = (short)320208896;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7ChannelUIValueProperty, value);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000136D0 File Offset: 0x000118D0
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0001378C File Offset: 0x0001198C
		public AcpListField DEKButton7ChannelList
		{
			get
			{
				short num = (short)2058608710;
				short num2 = num;
				num = (short)1825955910;
				switch (num2 == num)
				{
				}
				num = (short)1757937665;
				if (num != 0)
				{
				}
				num = (short)1140129792;
				if (num != 0)
				{
				}
				num = (short)1710817280;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton7ChannelListProperty);
			}
			set
			{
				short num = (short)1133169043;
				short num2 = num;
				num = (short)1893255571;
				switch (num2 == num)
				{
				}
				num = (short)1604845569;
				if (num != 0)
				{
				}
				num = (short)52822016;
				if (num != 0)
				{
				}
				num = (short)1217134592;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton7ChannelListProperty, value);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00013840 File Offset: 0x00011A40
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000138FC File Offset: 0x00011AFC
		public bool DEKButton8FeatureIsAcpValid
		{
			get
			{
				short num = (short)952524167;
				short num2 = num;
				num = (short)1224367495;
				switch (num2 == num)
				{
				}
				num = (short)1880096768;
				if (num != 0)
				{
				}
				num = (short)1317535745;
				if (num != 0)
				{
				}
				num = (short)1805647872;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton8FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1465473881;
				short num2 = num;
				num = (short)2093046617;
				switch (num2 == num)
				{
				}
				num = (short)1866858497;
				if (num != 0)
				{
				}
				num = (short)1635319808;
				if (num != 0)
				{
				}
				num = (short)793903104;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton8FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000139B8 File Offset: 0x00011BB8
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00013A70 File Offset: 0x00011C70
		public bool DEKButton8FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1196096514;
				short num2 = num;
				num = (short)1033894914;
				switch (num2 == num)
				{
				}
				num = (short)1008533504;
				if (num != 0)
				{
				}
				num = (short)1292894209;
				if (num != 0)
				{
				}
				num = (short)1214775296;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton8FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)27167726;
				short num2 = num;
				num = (short)648186862;
				switch (num2 == num)
				{
				}
				num = (short)195821569;
				if (num != 0)
				{
				}
				num = (short)629407744;
				if (num != 0)
				{
				}
				num = (short)1107361792;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton8FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00013B2C File Offset: 0x00011D2C
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00013BE8 File Offset: 0x00011DE8
		public bool DEKButton8FeatureIsAcpVisible
		{
			get
			{
				short num = (short)2140137378;
				short num2 = num;
				num = (short)40101794;
				switch (num2 == num)
				{
				}
				num = (short)804978689;
				if (num != 0)
				{
				}
				num = (short)220200960;
				if (num != 0)
				{
				}
				num = (short)1756561408;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton8FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1121644054;
				short num2 = num;
				num = (short)9039382;
				switch (num2 == num)
				{
				}
				num = (short)1646919681;
				if (num != 0)
				{
				}
				num = (short)101777408;
				if (num != 0)
				{
				}
				num = (short)909180928;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton8FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00013CA0 File Offset: 0x00011EA0
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00013D5C File Offset: 0x00011F5C
		public bool DEKButton8FeatureIsAcpEditable
		{
			get
			{
				short num = (short)146675196;
				short num2 = num;
				num = (short)1102583292;
				switch (num2 == num)
				{
				}
				num = (short)2090663937;
				if (num != 0)
				{
				}
				num = (short)175898624;
				if (num != 0)
				{
				}
				num = (short)1362165760;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton8FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)54711743;
				short num2 = num;
				num = (short)1518917055;
				switch (num2 == num)
				{
				}
				num = (short)1836843008;
				if (num != 0)
				{
				}
				num = (short)328204289;
				if (num != 0)
				{
				}
				num = (short)292093952;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton8FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00013E18 File Offset: 0x00012018
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00013ED4 File Offset: 0x000120D4
		public string DEKButton8FeatureUIValue
		{
			get
			{
				short num = (short)2029389259;
				short num2 = num;
				num = (short)812123595;
				switch (num2 == num)
				{
				}
				num = (short)920977409;
				if (num != 0)
				{
				}
				num = (short)347144192;
				if (num != 0)
				{
				}
				num = (short)1471676416;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton8FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1845484651;
				short num2 = num;
				num = (short)736746603;
				switch (num2 == num)
				{
				}
				num = (short)1478098944;
				if (num != 0)
				{
				}
				num = (short)1155072001;
				if (num != 0)
				{
				}
				num = (short)1244594176;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton8FeatureUIValueProperty, value);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00013F88 File Offset: 0x00012188
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00014044 File Offset: 0x00012244
		public AcpListField DEKButton8FeatureList
		{
			get
			{
				short num = (short)1566572545;
				if (num != 0)
				{
				}
				num = (short)1273941806;
				short num2 = num;
				num = (short)1146474286;
				switch (num2 == num)
				{
				}
				num = (short)194052096;
				if (num != 0)
				{
				}
				num = (short)234487808;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton8FeatureListProperty);
			}
			set
			{
				short num = (short)993969902;
				short num2 = num;
				num = (short)1484834542;
				switch (num2 == num)
				{
				}
				num = (short)1473380353;
				if (num != 0)
				{
				}
				num = (short)932839424;
				if (num != 0)
				{
				}
				num = (short)1515388928;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton8FeatureListProperty, value);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000140F8 File Offset: 0x000122F8
		// (set) Token: 0x06000193 RID: 403 RVA: 0x000141B0 File Offset: 0x000123B0
		public bool DEKButton8IndexIsAcpValid
		{
			get
			{
				short num = (short)1362165760;
				short num2 = num;
				num = (short)573343438;
				short num3 = num;
				num = (short)543655630;
				switch (num3 == num)
				{
				}
				num = (short)1184890880;
				if (num != 0)
				{
				}
				num = (short)1338048513;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton8IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)159055872;
				short num2 = num;
				num = (short)57990998;
				short num3 = num;
				num = (short)597548886;
				switch (num3 == num)
				{
				}
				num = (short)1212940289;
				if (num != 0)
				{
				}
				num = (short)93782016;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0001426C File Offset: 0x0001246C
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00014324 File Offset: 0x00012524
		public bool DEKButton8IndexIsAcpApplicable
		{
			get
			{
				short num = (short)992804864;
				short num2 = num;
				num = (short)1752000805;
				short num3 = num;
				num = (short)1304062245;
				switch (num3 == num)
				{
				}
				num = (short)37158913;
				if (num != 0)
				{
				}
				num = (short)1019281408;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton8IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)571736064;
				short num2 = num;
				num = (short)2034268908;
				short num3 = num;
				num = (short)1214085868;
				switch (num3 == num)
				{
				}
				num = (short)1194655744;
				if (num != 0)
				{
				}
				num = (short)888799233;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000143E0 File Offset: 0x000125E0
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0001449C File Offset: 0x0001269C
		public bool DEKButton8IndexIsAcpVisible
		{
			get
			{
				short num = (short)696385536;
				short num2 = num;
				num = (short)1454941277;
				short num3 = num;
				num = (short)1325245533;
				switch (num3 == num)
				{
				}
				num = (short)1899692033;
				if (num != 0)
				{
				}
				num = (short)268369920;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton8IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)101318656;
				short num2 = num;
				num = (short)1157902157;
				short num3 = num;
				num = (short)887172941;
				switch (num3 == num)
				{
				}
				num = (short)1906507777;
				if (num != 0)
				{
				}
				num = (short)1775239168;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00014558 File Offset: 0x00012758
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00014614 File Offset: 0x00012814
		public bool DEKButton8IndexIsAcpEditable
		{
			get
			{
				short num = (short)2004353024;
				short num2 = num;
				num = (short)50024896;
				short num3 = num;
				num = (short)829247936;
				switch (num3 == num)
				{
				}
				num = (short)2016608257;
				if (num != 0)
				{
				}
				num = (short)1254293504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton8IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)871694336;
				short num2 = num;
				num = (short)1782806375;
				short num3 = num;
				num = (short)14776167;
				switch (num3 == num)
				{
				}
				num = (short)1582825473;
				if (num != 0)
				{
				}
				num = (short)1907425280;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600019A RID: 410 RVA: 0x000146D0 File Offset: 0x000128D0
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0001478C File Offset: 0x0001298C
		public string DEKButton8IndexUIValue
		{
			get
			{
				short num = (short)714014720;
				short num2 = num;
				num = (short)106902365;
				short num3 = num;
				num = (short)2046964573;
				switch (num3 == num)
				{
				}
				num = (short)90439680;
				if (num != 0)
				{
				}
				num = (short)1534918657;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton8IndexUIValueProperty);
			}
			set
			{
				short num = (short)278528000;
				short num2 = num;
				num = (short)2098478208;
				short num3 = num;
				num = (short)145702016;
				switch (num3 == num)
				{
				}
				num = (short)168296448;
				if (num != 0)
				{
				}
				num = (short)1832058881;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8IndexUIValueProperty, value);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00014844 File Offset: 0x00012A44
		// (set) Token: 0x0600019D RID: 413 RVA: 0x000148FC File Offset: 0x00012AFC
		public AcpRangeField<int, int> DEKButton8IndexRange
		{
			get
			{
				short num = (short)1845755904;
				short num2 = num;
				num = (short)1540967036;
				short num3 = num;
				num = (short)421546620;
				switch (num3 == num)
				{
				}
				num = (short)694026241;
				if (num != 0)
				{
				}
				num = (short)619970560;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton8IndexRangeProperty);
			}
			set
			{
				short num = (short)1792737280;
				short num2 = num;
				num = (short)2039386862;
				short num3 = num;
				num = (short)1570869998;
				switch (num3 == num)
				{
				}
				num = (short)171769857;
				if (num != 0)
				{
				}
				num = (short)1278148608;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8IndexRangeProperty, value);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600019E RID: 414 RVA: 0x000149B0 File Offset: 0x00012BB0
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00014A6C File Offset: 0x00012C6C
		public bool DEKButton8ZoneIsAcpValid
		{
			get
			{
				short num = (short)1557856256;
				short num2 = num;
				num = (short)553689774;
				short num3 = num;
				num = (short)1715905198;
				switch (num3 == num)
				{
				}
				num = (short)1058603009;
				if (num != 0)
				{
				}
				num = (short)814874624;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton8ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)1076035584;
				short num2 = num;
				num = (short)309179069;
				short num3 = num;
				num = (short)1586541245;
				switch (num3 == num)
				{
				}
				num = (short)766443521;
				if (num != 0)
				{
				}
				num = (short)170131456;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00014B24 File Offset: 0x00012D24
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00014BE0 File Offset: 0x00012DE0
		public bool DEKButton8ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)713097216;
				short num2 = num;
				num = (short)719644578;
				short num3 = num;
				num = (short)110880674;
				switch (num3 == num)
				{
				}
				num = (short)1507655681;
				if (num != 0)
				{
				}
				num = (short)1039859712;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton8ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1088749568;
				short num2 = num;
				num = (short)1686881921;
				short num3 = num;
				num = (short)940820097;
				switch (num3 == num)
				{
				}
				num = (short)170917888;
				if (num != 0)
				{
				}
				num = (short)836435969;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00014C9C File Offset: 0x00012E9C
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00014D58 File Offset: 0x00012F58
		public bool DEKButton8ZoneIsAcpVisible
		{
			get
			{
				short num = (short)459210752;
				short num2 = num;
				num = (short)205258753;
				if (num != 0)
				{
				}
				num = (short)1902254230;
				short num3 = num;
				num = (short)1333926038;
				switch (num3 == num)
				{
				}
				num = (short)1526398976;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton8ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2007171072;
				short num2 = num;
				num = (short)593972375;
				short num3 = num;
				num = (short)575818903;
				switch (num3 == num)
				{
				}
				num = (short)2140536833;
				if (num != 0)
				{
				}
				num = (short)1777991680;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00014E10 File Offset: 0x00013010
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00014ECC File Offset: 0x000130CC
		public bool DEKButton8ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1845821440;
				short num2 = num;
				num = (short)1024403453;
				short num3 = num;
				num = (short)1743464445;
				switch (num3 == num)
				{
				}
				num = (short)1197211649;
				if (num != 0)
				{
				}
				num = (short)53608448;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton8ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)568197120;
				short num2 = num;
				num = (short)1373705254;
				short num3 = num;
				num = (short)676598822;
				switch (num3 == num)
				{
				}
				num = (short)1286406144;
				if (num != 0)
				{
				}
				num = (short)1322909697;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00014F88 File Offset: 0x00013188
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00015044 File Offset: 0x00013244
		public string DEKButton8ZoneUIValue
		{
			get
			{
				short num = (short)35127296;
				short num2 = num;
				num = (short)33616652;
				short num3 = num;
				num = (short)663548684;
				switch (num3 == num)
				{
				}
				num = (short)905904129;
				if (num != 0)
				{
				}
				num = (short)473104384;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton8ZoneUIValueProperty);
			}
			set
			{
				short num = (short)432078848;
				short num2 = num;
				num = (short)11206657;
				if (num != 0)
				{
				}
				num = (short)1930949727;
				short num3 = num;
				num = (short)2095379551;
				switch (num3 == num)
				{
				}
				num = (short)1064435712;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8ZoneUIValueProperty, value);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000150FC File Offset: 0x000132FC
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x000151B4 File Offset: 0x000133B4
		public AcpListField DEKButton8ZoneList
		{
			get
			{
				short num = (short)1824063488;
				short num2 = num;
				num = (short)511422297;
				short num3 = num;
				num = (short)1026666329;
				switch (num3 == num)
				{
				}
				num = (short)862126081;
				if (num != 0)
				{
				}
				num = (short)347734016;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton8ZoneListProperty);
			}
			set
			{
				short num = (short)2051014656;
				short num2 = num;
				num = (short)1179836004;
				short num3 = num;
				num = (short)2142035556;
				switch (num3 == num)
				{
				}
				num = (short)546242561;
				if (num != 0)
				{
				}
				num = (short)1325400064;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8ZoneListProperty, value);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00015268 File Offset: 0x00013468
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00015324 File Offset: 0x00013524
		public bool DEKButton8ChannelIsAcpValid
		{
			get
			{
				short num = (short)444923904;
				short num2 = num;
				num = (short)1699986669;
				short num3 = num;
				num = (short)1432009965;
				switch (num3 == num)
				{
				}
				num = (short)1334837248;
				if (num != 0)
				{
				}
				num = (short)874381313;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton8ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)825688064;
				short num2 = num;
				num = (short)1312825890;
				short num3 = num;
				num = (short)620241442;
				switch (num3 == num)
				{
				}
				num = (short)1885667329;
				if (num != 0)
				{
				}
				num = (short)81002496;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000153DC File Offset: 0x000135DC
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00015494 File Offset: 0x00013694
		public bool DEKButton8ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)2121793536;
				short num2 = num;
				num = (short)517938397;
				short num3 = num;
				num = (short)2086280413;
				switch (num3 == num)
				{
				}
				num = (short)93126657;
				if (num != 0)
				{
				}
				num = (short)1201143808;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton8ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1577779200;
				short num2 = num;
				num = (short)1358232863;
				short num3 = num;
				num = (short)1696791839;
				switch (num3 == num)
				{
				}
				num = (short)804388865;
				if (num != 0)
				{
				}
				num = (short)1538523136;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00015550 File Offset: 0x00013750
		// (set) Token: 0x060001AF RID: 431 RVA: 0x0001560C File Offset: 0x0001380C
		public bool DEKButton8ChannelIsAcpVisible
		{
			get
			{
				short num = (short)249167872;
				short num2 = num;
				num = (short)1780587831;
				short num3 = num;
				num = (short)134847799;
				switch (num3 == num)
				{
				}
				num = (short)1308229633;
				if (num != 0)
				{
				}
				num = (short)2032533504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton8ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1641349120;
				short num2 = num;
				num = (short)323882418;
				short num3 = num;
				num = (short)1750470066;
				switch (num3 == num)
				{
				}
				num = (short)945553409;
				if (num != 0)
				{
				}
				num = (short)1947074560;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x000156C4 File Offset: 0x000138C4
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00015780 File Offset: 0x00013980
		public bool DEKButton8ChannelIsAcpEditable
		{
			get
			{
				short num = (short)454492160;
				short num2 = num;
				num = (short)1049214934;
				short num3 = num;
				num = (short)1754709974;
				switch (num3 == num)
				{
				}
				num = (short)1798307840;
				if (num != 0)
				{
				}
				num = (short)1943535617;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton8ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1770389504;
				short num2 = num;
				num = (short)323654905;
				short num3 = num;
				num = (short)1225037049;
				switch (num3 == num)
				{
				}
				num = (short)2079326209;
				if (num != 0)
				{
				}
				num = (short)1196097536;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0001583C File Offset: 0x00013A3C
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x000158F4 File Offset: 0x00013AF4
		public string DEKButton8ChannelUIValue
		{
			get
			{
				short num = (short)677576704;
				short num2 = num;
				num = (short)1364749137;
				short num3 = num;
				num = (short)1776839505;
				switch (num3 == num)
				{
				}
				num = (short)746127361;
				if (num != 0)
				{
				}
				num = (short)860160000;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton8ChannelUIValueProperty);
			}
			set
			{
				short num = (short)154664960;
				short num2 = num;
				num = (short)1378025473;
				if (num != 0)
				{
				}
				num = (short)1287751067;
				short num3 = num;
				num = (short)1779271067;
				switch (num3 == num)
				{
				}
				num = (short)946929664;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8ChannelUIValueProperty, value);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000159AC File Offset: 0x00013BAC
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00015A68 File Offset: 0x00013C68
		public AcpListField DEKButton8ChannelList
		{
			get
			{
				short num = (short)2005860352;
				short num2 = num;
				num = (short)1153416863;
				short num3 = num;
				num = (short)2063384223;
				switch (num3 == num)
				{
				}
				num = (short)257228801;
				if (num != 0)
				{
				}
				num = (short)2128674816;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton8ChannelListProperty);
			}
			set
			{
				short num = (short)1833107456;
				short num2 = num;
				num = (short)761782278;
				short num3 = num;
				num = (short)1517608966;
				switch (num3 == num)
				{
				}
				num = (short)1786839040;
				if (num != 0)
				{
				}
				num = (short)1626406913;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton8ChannelListProperty, value);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00015B1C File Offset: 0x00013D1C
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00015BD8 File Offset: 0x00013DD8
		public bool DEKButton9FeatureIsAcpValid
		{
			get
			{
				short num = (short)2000945152;
				short num2 = num;
				num = (short)502196294;
				short num3 = num;
				num = (short)1932322886;
				switch (num3 == num)
				{
				}
				num = (short)1621688321;
				if (num != 0)
				{
				}
				num = (short)1080033280;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1802305536;
				short num2 = num;
				num = (short)284035664;
				short num3 = num;
				num = (short)363334224;
				switch (num3 == num)
				{
				}
				num = (short)1398669312;
				if (num != 0)
				{
				}
				num = (short)522256385;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00015C90 File Offset: 0x00013E90
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00015D4C File Offset: 0x00013F4C
		public bool DEKButton9FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1926758400;
				short num2 = num;
				num = (short)1898794043;
				short num3 = num;
				num = (short)1196313659;
				switch (num3 == num)
				{
				}
				num = (short)141688833;
				if (num != 0)
				{
				}
				num = (short)1409286144;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)766312448;
				short num2 = num;
				num = (short)2114285622;
				short num3 = num;
				num = (short)1257533494;
				switch (num3 == num)
				{
				}
				num = (short)1572865;
				if (num != 0)
				{
				}
				num = (short)1865220096;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00015E08 File Offset: 0x00014008
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00015EC4 File Offset: 0x000140C4
		public bool DEKButton9FeatureIsAcpVisible
		{
			get
			{
				short num = (short)813563904;
				short num2 = num;
				num = (short)218253862;
				short num3 = num;
				num = (short)1329154598;
				switch (num3 == num)
				{
				}
				num = (short)1246887937;
				if (num != 0)
				{
				}
				num = (short)948568064;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)149159936;
				short num2 = num;
				num = (short)1976658142;
				short num3 = num;
				num = (short)2019780830;
				switch (num3 == num)
				{
				}
				num = (short)175177728;
				if (num != 0)
				{
				}
				num = (short)901709825;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00015F7C File Offset: 0x0001417C
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00016034 File Offset: 0x00014234
		public bool DEKButton9FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1487863808;
				short num2 = num;
				num = (short)1050514997;
				short num3 = num;
				num = (short)918066741;
				switch (num3 == num)
				{
				}
				num = (short)2062352385;
				if (num != 0)
				{
				}
				num = (short)1961623552;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)457441280;
				short num2 = num;
				num = (short)396239111;
				short num3 = num;
				num = (short)1194402055;
				switch (num3 == num)
				{
				}
				num = (short)473890816;
				if (num != 0)
				{
				}
				num = (short)196804609;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001BE RID: 446 RVA: 0x000160F0 File Offset: 0x000142F0
		// (set) Token: 0x060001BF RID: 447 RVA: 0x000161AC File Offset: 0x000143AC
		public string DEKButton9FeatureUIValue
		{
			get
			{
				short num = (short)1541603328;
				short num2 = num;
				num = (short)1338310657;
				if (num != 0)
				{
				}
				num = (short)2085163228;
				short num3 = num;
				num = (short)1715081436;
				switch (num3 == num)
				{
				}
				num = (short)1183186944;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton9FeatureUIValueProperty);
			}
			set
			{
				short num = (short)670957568;
				short num2 = num;
				num = (short)834300179;
				short num3 = num;
				num = (short)1911384339;
				switch (num3 == num)
				{
				}
				num = (short)1642201089;
				if (num != 0)
				{
				}
				num = (short)1229258752;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9FeatureUIValueProperty, value);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00016260 File Offset: 0x00014460
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00016318 File Offset: 0x00014518
		public AcpListField DEKButton9FeatureList
		{
			get
			{
				short num = (short)1152385024;
				short num2 = num;
				num = (short)1494351873;
				if (num != 0)
				{
				}
				num = (short)2054547775;
				short num3 = num;
				num = (short)1088153919;
				switch (num3 == num)
				{
				}
				num = (short)665387008;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton9FeatureListProperty);
			}
			set
			{
				short num = (short)585105408;
				short num2 = num;
				num = (short)292238564;
				short num3 = num;
				num = (short)220935396;
				switch (num3 == num)
				{
				}
				num = (short)1644756992;
				if (num != 0)
				{
				}
				num = (short)435093505;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9FeatureListProperty, value);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x000163D0 File Offset: 0x000145D0
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0001648C File Offset: 0x0001468C
		public bool DEKButton9IndexIsAcpValid
		{
			get
			{
				short num = (short)243335168;
				short num2 = num;
				num = (short)1715798017;
				if (num != 0)
				{
				}
				num = (short)908265076;
				short num3 = num;
				num = (short)1542391412;
				switch (num3 == num)
				{
				}
				num = (short)1909260288;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)636747776;
				short num2 = num;
				num = (short)2063159163;
				short num3 = num;
				num = (short)1122979707;
				switch (num3 == num)
				{
				}
				num = (short)1449918464;
				if (num != 0)
				{
				}
				num = (short)1209204737;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00016544 File Offset: 0x00014744
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x000165FC File Offset: 0x000147FC
		public bool DEKButton9IndexIsAcpApplicable
		{
			get
			{
				short num = (short)762707968;
				short num2 = num;
				num = (short)156089640;
				short num3 = num;
				num = (short)734182696;
				switch (num3 == num)
				{
				}
				num = (short)386924544;
				if (num != 0)
				{
				}
				num = (short)1338114049;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)447152128;
				short num2 = num;
				num = (short)851818804;
				short num3 = num;
				num = (short)498383156;
				switch (num3 == num)
				{
				}
				num = (short)1278541824;
				if (num != 0)
				{
				}
				num = (short)1662976001;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000166B8 File Offset: 0x000148B8
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00016774 File Offset: 0x00014974
		public bool DEKButton9IndexIsAcpVisible
		{
			get
			{
				short num = (short)2089202798;
				short num2 = num;
				num = (short)2112468078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)218693632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1086849025;
				if (num != 0)
				{
				}
				num = (short)1292894208;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1479195400;
				short num2 = num;
				num = (short)1679145736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)532480000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)9109505;
				if (num != 0)
				{
				}
				num = (short)1724317696;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00016830 File Offset: 0x00014A30
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x000168EC File Offset: 0x00014AEC
		public bool DEKButton9IndexIsAcpEditable
		{
			get
			{
				short num = (short)1702089698;
				short num2 = num;
				num = (short)346280930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1265827840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1865154561;
				if (num != 0)
				{
				}
				num = (short)982319104;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1870697070;
				short num2 = num;
				num = (short)598970990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)974192640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)892338176;
				if (num != 0)
				{
				}
				num = (short)1195769857;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000169A4 File Offset: 0x00014BA4
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00016A60 File Offset: 0x00014C60
		public string DEKButton9IndexUIValue
		{
			get
			{
				short num = (short)1478438908;
				short num2 = num;
				num = (short)211234812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2116354048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1870790657;
				if (num != 0)
				{
				}
				num = (short)1271529472;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton9IndexUIValueProperty);
			}
			set
			{
				short num = (short)579046080;
				short num2 = num;
				num = (short)805866176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1137049600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)646316032;
				if (num != 0)
				{
				}
				num = (short)1927544833;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9IndexUIValueProperty, value);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00016B18 File Offset: 0x00014D18
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00016BD0 File Offset: 0x00014DD0
		public AcpRangeField<int, int> DEKButton9IndexRange
		{
			get
			{
				short num = (short)1410596865;
				if (num != 0)
				{
				}
				num = (short)1210056704;
				short num2 = num;
				num = (short)128040446;
				short num3 = num;
				num = (short)516734462;
				switch (num3 == num)
				{
				}
				num = (short)855506944;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton9IndexRangeProperty);
			}
			set
			{
				short num = (short)660111930;
				short num2 = num;
				num = (short)1199997498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1093861376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)497811456;
				if (num != 0)
				{
				}
				num = (short)126353409;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9IndexRangeProperty, value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00016C84 File Offset: 0x00014E84
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00016D3C File Offset: 0x00014F3C
		public bool DEKButton9ZoneIsAcpValid
		{
			get
			{
				short num = (short)370741871;
				short num2 = num;
				num = (short)1219629679;
				switch (num2 == num)
				{
				default:
				{
					num = (short)164233216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)325779457;
				if (num != 0)
				{
				}
				num = (short)1916403712;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)1347507360;
				short num2 = num;
				num = (short)1175868576;
				switch (num2 == num)
				{
				default:
				{
					num = (short)983040000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1860894720;
				if (num != 0)
				{
				}
				num = (short)2026176513;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00016DF4 File Offset: 0x00014FF4
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00016EB0 File Offset: 0x000150B0
		public bool DEKButton9ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)21823489;
				if (num != 0)
				{
				}
				num = (short)821952512;
				short num2 = num;
				num = (short)1228921392;
				short num3 = num;
				num = (short)569694768;
				switch (num3 == num)
				{
				}
				num = (short)1048969216;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1703224747;
				short num2 = num;
				num = (short)85665195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)186449920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)506068993;
				if (num != 0)
				{
				}
				num = (short)194052096;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00016F6C File Offset: 0x0001516C
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00017024 File Offset: 0x00015224
		public bool DEKButton9ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1003225089;
				if (num != 0)
				{
				}
				num = (short)1593835520;
				short num2 = num;
				num = (short)754613417;
				short num3 = num;
				num = (short)1435925673;
				switch (num3 == num)
				{
				}
				num = (short)1057619968;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)404534658;
				short num2 = num;
				num = (short)223589762;
				switch (num2 == num)
				{
				default:
				{
					num = (short)817692672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)514392064;
				if (num != 0)
				{
				}
				num = (short)2132541441;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000170E4 File Offset: 0x000152E4
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0001719C File Offset: 0x0001539C
		public bool DEKButton9ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1826498460;
				short num2 = num;
				num = (short)502409116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1274085376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1251540993;
				if (num != 0)
				{
				}
				num = (short)1496121344;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)167116801;
				if (num != 0)
				{
				}
				num = (short)1273823232;
				short num2 = num;
				num = (short)980426003;
				short num3 = num;
				num = (short)958274835;
				switch (num3 == num)
				{
				}
				num = (short)1013317632;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0001725C File Offset: 0x0001545C
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00017318 File Offset: 0x00015518
		public string DEKButton9ZoneUIValue
		{
			get
			{
				short num = (short)1175581726;
				short num2 = num;
				num = (short)870773790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)37224448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1168900097;
				if (num != 0)
				{
				}
				num = (short)1112473600;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton9ZoneUIValueProperty);
			}
			set
			{
				short num = (short)451741595;
				short num2 = num;
				num = (short)1903298459;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1192689664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2122121216;
				if (num != 0)
				{
				}
				num = (short)2102067201;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9ZoneUIValueProperty, value);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000173D0 File Offset: 0x000155D0
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x0001748C File Offset: 0x0001568C
		public AcpListField DEKButton9ZoneList
		{
			get
			{
				short num = (short)706076218;
				short num2 = num;
				num = (short)69131834;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1028915200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1225588737;
				if (num != 0)
				{
				}
				num = (short)1690042368;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton9ZoneListProperty);
			}
			set
			{
				short num = (short)820973125;
				short num2 = num;
				num = (short)1940655685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)35913728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)56098817;
				if (num != 0)
				{
				}
				num = (short)1613955072;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9ZoneListProperty, value);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00017540 File Offset: 0x00015740
		// (set) Token: 0x060001DB RID: 475 RVA: 0x000175F8 File Offset: 0x000157F8
		public bool DEKButton9ChannelIsAcpValid
		{
			get
			{
				short num = (short)950534235;
				short num2 = num;
				num = (short)1151795291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521549312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1535770624;
				if (num != 0)
				{
				}
				num = (short)426967041;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)1317058502;
				short num2 = num;
				num = (short)871610310;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1863450624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1971060737;
				if (num != 0)
				{
				}
				num = (short)1685782528;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060001DC RID: 476 RVA: 0x000176B0 File Offset: 0x000158B0
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00017768 File Offset: 0x00015968
		public bool DEKButton9ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)977324544;
				short num2 = num;
				num = (short)196528640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1806696448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2093744129;
				if (num != 0)
				{
				}
				num = (short)197722112;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)330009133;
				short num2 = num;
				num = (short)579111469;
				switch (num2 == num)
				{
				default:
				{
					num = (short)542179328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1707933696;
				if (num != 0)
				{
				}
				num = (short)6619137;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00017820 File Offset: 0x00015A20
		// (set) Token: 0x060001DF RID: 479 RVA: 0x000178DC File Offset: 0x00015ADC
		public bool DEKButton9ChannelIsAcpVisible
		{
			get
			{
				short num = (short)1522884138;
				short num2 = num;
				num = (short)1228693034;
				switch (num2 == num)
				{
				default:
				{
					num = (short)576978944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)784269313;
				if (num != 0)
				{
				}
				num = (short)1371799552;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)371887698;
				short num2 = num;
				num = (short)139234898;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1978925056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1638072321;
				if (num != 0)
				{
				}
				num = (short)681312256;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00017994 File Offset: 0x00015B94
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00017A4C File Offset: 0x00015C4C
		public bool DEKButton9ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1100533128;
				short num2 = num;
				num = (short)1646054792;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2120810496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)772931585;
				if (num != 0)
				{
				}
				num = (short)1146945536;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton9ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)399266778;
				short num2 = num;
				num = (short)1076188122;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1481113600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)260505601;
				if (num != 0)
				{
				}
				num = (short)477626368;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00017B08 File Offset: 0x00015D08
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00017BC4 File Offset: 0x00015DC4
		public string DEKButton9ChannelUIValue
		{
			get
			{
				short num = (short)996278273;
				if (num != 0)
				{
				}
				num = (short)403898368;
				short num2 = num;
				num = (short)1785280739;
				short num3 = num;
				num = (short)718813411;
				switch (num3 == num)
				{
				}
				num = (short)2061500416;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton9ChannelUIValueProperty);
			}
			set
			{
				short num = (short)662693880;
				short num2 = num;
				num = (short)1270081528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)429850624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)513736704;
				if (num != 0)
				{
				}
				num = (short)979566593;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9ChannelUIValueProperty, value);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00017C78 File Offset: 0x00015E78
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00017D34 File Offset: 0x00015F34
		public AcpListField DEKButton9ChannelList
		{
			get
			{
				short num = (short)157021867;
				short num2 = num;
				num = (short)303232683;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1094123520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1876164609;
				if (num != 0)
				{
				}
				num = (short)713293824;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton9ChannelListProperty);
			}
			set
			{
				short num = (short)1160400315;
				short num2 = num;
				num = (short)811093435;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1871773696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2046820352;
				if (num != 0)
				{
				}
				num = (short)211812353;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton9ChannelListProperty, value);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00017DEC File Offset: 0x00015FEC
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00017EA8 File Offset: 0x000160A8
		public bool DEKButton10FeatureIsAcpValid
		{
			get
			{
				short num = (short)1881297033;
				short num2 = num;
				num = (short)818106505;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2084765696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1327890433;
				if (num != 0)
				{
				}
				num = (short)1373503488;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1589446306;
				short num2 = num;
				num = (short)2128021154;
				switch (num2 == num)
				{
				default:
				{
					num = (short)146341888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2102132736;
				if (num != 0)
				{
				}
				num = (short)738918401;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00017F60 File Offset: 0x00016160
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00018018 File Offset: 0x00016218
		public bool DEKButton10FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1814618251;
				short num2 = num;
				num = (short)1305403531;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2003304448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)343146497;
				if (num != 0)
				{
				}
				num = (short)603914240;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1624485961;
				short num2 = num;
				num = (short)1286385737;
				switch (num2 == num)
				{
				default:
				{
					num = (short)130482176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1340932096;
				if (num != 0)
				{
				}
				num = (short)1777664001;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000180D0 File Offset: 0x000162D0
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00018188 File Offset: 0x00016388
		public bool DEKButton10FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1248178617;
				short num2 = num;
				num = (short)496611769;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1411252224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1133576193;
				if (num != 0)
				{
				}
				num = (short)2127626240;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)369437744;
				short num2 = num;
				num = (short)442706992;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2116943872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1575485441;
				if (num != 0)
				{
				}
				num = (short)385875968;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00018244 File Offset: 0x00016444
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00018300 File Offset: 0x00016500
		public bool DEKButton10FeatureIsAcpEditable
		{
			get
			{
				short num = (short)732606473;
				short num2 = num;
				num = (short)1272885257;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2102657024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)644546561;
				if (num != 0)
				{
				}
				num = (short)1475739648;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1628986757;
				short num2 = num;
				num = (short)773545349;
				switch (num2 == num)
				{
				default:
				{
					num = (short)784007168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)442695681;
				if (num != 0)
				{
				}
				num = (short)1764360192;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000183B8 File Offset: 0x000165B8
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00018470 File Offset: 0x00016670
		public string DEKButton10FeatureUIValue
		{
			get
			{
				short num = (short)443239506;
				short num2 = num;
				num = (short)336219218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)770113536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)785711104;
				if (num != 0)
				{
				}
				num = (short)528154625;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton10FeatureUIValueProperty);
			}
			set
			{
				short num = (short)562547200;
				short num2 = num;
				num = (short)1846462976;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2036793344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1619984385;
				if (num != 0)
				{
				}
				num = (short)1824129024;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10FeatureUIValueProperty, value);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00018528 File Offset: 0x00016728
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x000185E4 File Offset: 0x000167E4
		public AcpListField DEKButton10FeatureList
		{
			get
			{
				short num = (short)1622695366;
				short num2 = num;
				num = (short)465919430;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1229193216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1803812865;
				if (num != 0)
				{
				}
				num = (short)712179712;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton10FeatureListProperty);
			}
			set
			{
				short num = (short)1315304838;
				short num2 = num;
				num = (short)1813050758;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2013921280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)943849473;
				if (num != 0)
				{
				}
				num = (short)1876557824;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10FeatureListProperty, value);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00018698 File Offset: 0x00016898
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00018754 File Offset: 0x00016954
		public bool DEKButton10IndexIsAcpValid
		{
			get
			{
				short num = (short)1051168429;
				short num2 = num;
				num = (short)424447661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)82444288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1670316032;
				if (num != 0)
				{
				}
				num = (short)781910017;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)621506697;
				short num2 = num;
				num = (short)1549037705;
				switch (num2 == num)
				{
				default:
				{
					num = (short)890568704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1212809217;
				if (num != 0)
				{
				}
				num = (short)13434880;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00018810 File Offset: 0x00016A10
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x000188C8 File Offset: 0x00016AC8
		public bool DEKButton10IndexIsAcpApplicable
		{
			get
			{
				short num = (short)730113118;
				short num2 = num;
				num = (short)792634462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1300103168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2108817408;
				if (num != 0)
				{
				}
				num = (short)1473773569;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1787911002;
				short num2 = num;
				num = (short)960322394;
				switch (num2 == num)
				{
				default:
				{
					num = (short)551878656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)844890113;
				if (num != 0)
				{
				}
				num = (short)1234960384;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00018984 File Offset: 0x00016B84
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00018A40 File Offset: 0x00016C40
		public bool DEKButton10IndexIsAcpVisible
		{
			get
			{
				short num = (short)703873399;
				short num2 = num;
				num = (short)1274888567;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2117992448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)941424641;
				if (num != 0)
				{
				}
				num = (short)555483136;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)171311105;
				if (num != 0)
				{
				}
				num = (short)630128640;
				short num2 = num;
				num = (short)1718471724;
				short num3 = num;
				num = (short)312069164;
				switch (num3 == num)
				{
				}
				num = (short)1740177408;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00018AF8 File Offset: 0x00016CF8
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00018BB4 File Offset: 0x00016DB4
		public bool DEKButton10IndexIsAcpEditable
		{
			get
			{
				short num = (short)1240481990;
				short num2 = num;
				num = (short)2098610374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)98107392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1777926145;
				if (num != 0)
				{
				}
				num = (short)1940979712;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1006960345;
				short num2 = num;
				num = (short)289341145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1616314368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1607270401;
				if (num != 0)
				{
				}
				num = (short)535298048;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00018C6C File Offset: 0x00016E6C
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00018D24 File Offset: 0x00016F24
		public string DEKButton10IndexUIValue
		{
			get
			{
				short num = (short)617574720;
				short num2 = num;
				num = (short)127889728;
				switch (num2 == num)
				{
				}
				num = (short)2144010240;
				short num3 = num;
				num = (short)2101805057;
				if (num != 0)
				{
				}
				num = (short)1650589696;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton10IndexUIValueProperty);
			}
			set
			{
				short num = (short)295218915;
				short num2 = num;
				num = (short)1215606499;
				switch (num2 == num)
				{
				}
				num = (short)1784086528;
				short num3 = num;
				num = (short)1566113793;
				if (num != 0)
				{
				}
				num = (short)1810235392;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10IndexUIValueProperty, value);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00018DD8 File Offset: 0x00016FD8
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00018E94 File Offset: 0x00017094
		public AcpRangeField<int, int> DEKButton10IndexRange
		{
			get
			{
				short num = (short)1968945368;
				short num2 = num;
				num = (short)684570840;
				switch (num2 == num)
				{
				}
				num = (short)1799618560;
				short num3 = num;
				num = (short)1139277824;
				if (num != 0)
				{
				}
				num = (short)642121729;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton10IndexRangeProperty);
			}
			set
			{
				short num = (short)489356455;
				short num2 = num;
				num = (short)1280113831;
				switch (num2 == num)
				{
				}
				num = (short)125173760;
				short num3 = num;
				num = (short)1402667008;
				if (num != 0)
				{
				}
				num = (short)1628372993;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10IndexRangeProperty, value);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00018F48 File Offset: 0x00017148
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00019000 File Offset: 0x00017200
		public bool DEKButton10ZoneIsAcpValid
		{
			get
			{
				short num = (short)551285000;
				short num2 = num;
				num = (short)809496840;
				switch (num2 == num)
				{
				}
				num = (short)889520128;
				short num3 = num;
				num = (short)1744896000;
				if (num != 0)
				{
				}
				num = (short)738197505;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)1115900340;
				short num2 = num;
				num = (short)1620527540;
				switch (num2 == num)
				{
				}
				num = (short)1042612224;
				short num3 = num;
				num = (short)1157234688;
				if (num != 0)
				{
				}
				num = (short)847511553;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000200 RID: 512 RVA: 0x000190BC File Offset: 0x000172BC
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00019174 File Offset: 0x00017374
		public bool DEKButton10ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)1585132612;
				short num2 = num;
				num = (short)330445892;
				switch (num2 == num)
				{
				}
				num = (short)1617100800;
				short num3 = num;
				num = (short)1439039489;
				if (num != 0)
				{
				}
				num = (short)2041970688;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)74817962;
				short num2 = num;
				num = (short)186818986;
				switch (num2 == num)
				{
				}
				num = (short)262995968;
				short num3 = num;
				num = (short)29949953;
				if (num != 0)
				{
				}
				num = (short)5636096;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00019230 File Offset: 0x00017430
		// (set) Token: 0x06000203 RID: 515 RVA: 0x000192F0 File Offset: 0x000174F0
		public bool DEKButton10ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1325120824;
				short num2 = num;
				num = (short)1459862840;
				switch (num2 == num)
				{
				}
				num = (short)2008023040;
				short num3 = num;
				num = (short)1436811265;
				if (num != 0)
				{
				}
				num = (short)1733033984;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1107192355;
				short num2 = num;
				num = (short)1634363939;
				switch (num2 == num)
				{
				}
				num = (short)758906880;
				short num3 = num;
				num = (short)1156710401;
				if (num != 0)
				{
				}
				num = (short)824115200;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000204 RID: 516 RVA: 0x000193AC File Offset: 0x000175AC
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00019464 File Offset: 0x00017664
		public bool DEKButton10ZoneIsAcpEditable
		{
			get
			{
				short num = (short)39930199;
				short num2 = num;
				num = (short)256395607;
				switch (num2 == num)
				{
				}
				num = (short)1881276416;
				short num3 = num;
				num = (short)280625152;
				if (num != 0)
				{
				}
				num = (short)102957057;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1378429559;
				short num2 = num;
				num = (short)323627639;
				switch (num2 == num)
				{
				}
				num = (short)1683488768;
				short num3 = num;
				num = (short)232062977;
				if (num != 0)
				{
				}
				num = (short)736165888;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00019520 File Offset: 0x00017720
		// (set) Token: 0x06000207 RID: 519 RVA: 0x000195D8 File Offset: 0x000177D8
		public string DEKButton10ZoneUIValue
		{
			get
			{
				short num = (short)178216437;
				short num2 = num;
				num = (short)741760501;
				switch (num2 == num)
				{
				}
				num = (short)1258029056;
				short num3 = num;
				num = (short)519831553;
				if (num != 0)
				{
				}
				num = (short)1478492160;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton10ZoneUIValueProperty);
			}
			set
			{
				short num = (short)1147112564;
				short num2 = num;
				num = (short)371821684;
				switch (num2 == num)
				{
				}
				num = (short)1366622208;
				short num3 = num;
				num = (short)1583939585;
				if (num != 0)
				{
				}
				num = (short)1628307456;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10ZoneUIValueProperty, value);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0001968C File Offset: 0x0001788C
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00019744 File Offset: 0x00017944
		public AcpListField DEKButton10ZoneList
		{
			get
			{
				short num = (short)474666273;
				short num2 = num;
				num = (short)883479841;
				switch (num2 == num)
				{
				}
				num = (short)323289088;
				short num3 = num;
				num = (short)1406730240;
				if (num != 0)
				{
				}
				num = (short)1091174401;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton10ZoneListProperty);
			}
			set
			{
				short num = (short)271974401;
				if (num != 0)
				{
				}
				num = (short)1609266695;
				short num2 = num;
				num = (short)983987719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1355087872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1417609216;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10ZoneListProperty, value);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600020A RID: 522 RVA: 0x000197F8 File Offset: 0x000179F8
		// (set) Token: 0x0600020B RID: 523 RVA: 0x000198B0 File Offset: 0x00017AB0
		public bool DEKButton10ChannelIsAcpValid
		{
			get
			{
				short num = (short)750900470;
				short num2 = num;
				num = (short)1721160950;
				switch (num2 == num)
				{
				}
				num = (short)1364459520;
				short num3 = num;
				num = (short)1841233921;
				if (num != 0)
				{
				}
				num = (short)495910912;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)933525330;
				short num2 = num;
				num = (short)1493530450;
				switch (num2 == num)
				{
				}
				num = (short)893911040;
				short num3 = num;
				num = (short)106561537;
				if (num != 0)
				{
				}
				num = (short)463994880;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0001996C File Offset: 0x00017B6C
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00019A28 File Offset: 0x00017C28
		public bool DEKButton10ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)447441754;
				short num2 = num;
				num = (short)2070440794;
				switch (num2 == num)
				{
				}
				num = (short)699858944;
				short num3 = num;
				num = (short)1027538945;
				if (num != 0)
				{
				}
				num = (short)1889140736;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1007667182;
				short num2 = num;
				num = (short)969590766;
				switch (num2 == num)
				{
				}
				num = (short)1649934336;
				short num3 = num;
				num = (short)483131392;
				if (num != 0)
				{
				}
				num = (short)2052718593;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00019AE0 File Offset: 0x00017CE0
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00019B98 File Offset: 0x00017D98
		public bool DEKButton10ChannelIsAcpVisible
		{
			get
			{
				short num = (short)419452817;
				short num2 = num;
				num = (short)912283537;
				switch (num2 == num)
				{
				}
				num = (short)1469579264;
				short num3 = num;
				num = (short)1226113025;
				if (num != 0)
				{
				}
				num = (short)247005184;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)337936565;
				short num2 = num;
				num = (short)498892981;
				switch (num2 == num)
				{
				}
				num = (short)863436800;
				short num3 = num;
				num = (short)700055552;
				if (num != 0)
				{
				}
				num = (short)1158217729;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00019C54 File Offset: 0x00017E54
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00019D0C File Offset: 0x00017F0C
		public bool DEKButton10ChannelIsAcpEditable
		{
			get
			{
				short num = (short)999735794;
				short num2 = num;
				num = (short)453493234;
				switch (num2 == num)
				{
				}
				num = (short)1921581056;
				short num3 = num;
				num = (short)1392771073;
				if (num != 0)
				{
				}
				num = (short)457834496;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton10ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1297561179;
				short num2 = num;
				num = (short)2046834267;
				switch (num2 == num)
				{
				}
				num = (short)1613889536;
				short num3 = num;
				num = (short)952631297;
				if (num != 0)
				{
				}
				num = (short)344129536;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00019DC8 File Offset: 0x00017FC8
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00019E80 File Offset: 0x00018080
		public string DEKButton10ChannelUIValue
		{
			get
			{
				short num = (short)536500735;
				short num2 = num;
				num = (short)1993431551;
				switch (num2 == num)
				{
				}
				num = (short)1104412672;
				short num3 = num;
				num = (short)1123811329;
				if (num != 0)
				{
				}
				num = (short)1931804672;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton10ChannelUIValueProperty);
			}
			set
			{
				short num = (short)939840633;
				short num2 = num;
				num = (short)1302713465;
				switch (num2 == num)
				{
				}
				num = (short)1987969024;
				short num3 = num;
				num = (short)1221853184;
				if (num != 0)
				{
				}
				num = (short)1751973889;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10ChannelUIValueProperty, value);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00019F34 File Offset: 0x00018134
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00019FF0 File Offset: 0x000181F0
		public AcpListField DEKButton10ChannelList
		{
			get
			{
				short num = (short)1547303808;
				short num2 = num;
				num = (short)1285815168;
				switch (num2 == num)
				{
				}
				num = (short)969539584;
				short num3 = num;
				num = (short)1101201408;
				if (num != 0)
				{
				}
				num = (short)1607925761;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton10ChannelListProperty);
			}
			set
			{
				short num = (short)2074930592;
				short num2 = num;
				num = (short)1227156896;
				switch (num2 == num)
				{
				}
				num = (short)1393426432;
				short num3 = num;
				num = (short)102825985;
				if (num != 0)
				{
				}
				num = (short)1054474240;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton10ChannelListProperty, value);
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0001A0A4 File Offset: 0x000182A4
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0001A160 File Offset: 0x00018360
		public bool DEKButton11FeatureIsAcpValid
		{
			get
			{
				short num = (short)1127082484;
				short num2 = num;
				num = (short)1162406388;
				switch (num2 == num)
				{
				}
				num = (short)119865344;
				short num3 = num;
				num = (short)697106433;
				if (num != 0)
				{
				}
				num = (short)356843520;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)577044481;
				if (num != 0)
				{
				}
				num = (short)815662;
				short num2 = num;
				num = (short)126120494;
				switch (num2 == num)
				{
				default:
				{
					num = (short)600571904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)442040320;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0001A218 File Offset: 0x00018418
		// (set) Token: 0x06000219 RID: 537 RVA: 0x0001A2D0 File Offset: 0x000184D0
		public bool DEKButton11FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)19993186;
				short num2 = num;
				num = (short)2050495074;
				switch (num2 == num)
				{
				}
				num = (short)1129119744;
				short num3 = num;
				num = (short)166789121;
				if (num != 0)
				{
				}
				num = (short)1511391232;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)990642177;
				if (num != 0)
				{
				}
				num = (short)1779985590;
				short num2 = num;
				num = (short)1669033142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1197408256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)883294208;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0001A38C File Offset: 0x0001858C
		// (set) Token: 0x0600021B RID: 539 RVA: 0x0001A448 File Offset: 0x00018648
		public bool DEKButton11FeatureIsAcpVisible
		{
			get
			{
				short num = (short)58763058;
				short num2 = num;
				num = (short)2031003442;
				switch (num2 == num)
				{
				}
				num = (short)2030108672;
				short num3 = num;
				num = (short)2127101953;
				if (num != 0)
				{
				}
				num = (short)1608122368;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)840431569;
				short num2 = num;
				num = (short)807204817;
				switch (num2 == num)
				{
				}
				num = (short)1328676864;
				short num3 = num;
				num = (short)473432065;
				if (num != 0)
				{
				}
				num = (short)810745856;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0001A500 File Offset: 0x00018700
		// (set) Token: 0x0600021D RID: 541 RVA: 0x0001A5B8 File Offset: 0x000187B8
		public bool DEKButton11FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1297407099;
				short num2 = num;
				num = (short)1972427899;
				switch (num2 == num)
				{
				}
				num = (short)286392320;
				short num3 = num;
				num = (short)1813250049;
				if (num != 0)
				{
				}
				num = (short)773849088;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)633119142;
				short num2 = num;
				num = (short)961847718;
				switch (num2 == num)
				{
				}
				num = (short)2129723392;
				short num3 = num;
				num = (short)88932352;
				if (num != 0)
				{
				}
				num = (short)1584136193;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0001A674 File Offset: 0x00018874
		// (set) Token: 0x0600021F RID: 543 RVA: 0x0001A72C File Offset: 0x0001892C
		public string DEKButton11FeatureUIValue
		{
			get
			{
				short num = (short)17367041;
				if (num != 0)
				{
				}
				num = (short)352603593;
				short num2 = num;
				num = (short)244796873;
				switch (num2 == num)
				{
				default:
				{
					num = (short)935133184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2130051072;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton11FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1600512996;
				short num2 = num;
				num = (short)1675224036;
				switch (num2 == num)
				{
				}
				num = (short)1497497600;
				short num3 = num;
				num = (short)2005532673;
				if (num != 0)
				{
				}
				num = (short)1635713024;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0001A7E4 File Offset: 0x000189E4
		// (set) Token: 0x06000221 RID: 545 RVA: 0x0001A89C File Offset: 0x00018A9C
		public AcpListField DEKButton11FeatureList
		{
			get
			{
				short num = (short)1435418433;
				short num2 = num;
				num = (short)1783611201;
				switch (num2 == num)
				{
				}
				num = (short)1914372096;
				short num3 = num;
				num = (short)58458113;
				if (num != 0)
				{
				}
				num = (short)723845120;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton11FeatureListProperty);
			}
			set
			{
				short num = (short)1645242372;
				short num2 = num;
				num = (short)1980393476;
				switch (num2 == num)
				{
				}
				num = (short)1578041344;
				short num3 = num;
				num = (short)1747517440;
				if (num != 0)
				{
				}
				num = (short)561512449;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11FeatureListProperty, value);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0001A950 File Offset: 0x00018B50
		// (set) Token: 0x06000223 RID: 547 RVA: 0x0001AA0C File Offset: 0x00018C0C
		public bool DEKButton11IndexIsAcpValid
		{
			get
			{
				short num = (short)1150875627;
				short num2 = num;
				num = (short)374994923;
				switch (num2 == num)
				{
				}
				num = (short)304545792;
				short num3 = num;
				num = (short)288030721;
				if (num != 0)
				{
				}
				num = (short)1837891584;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)826412639;
				short num2 = num;
				num = (short)1068043871;
				switch (num2 == num)
				{
				}
				num = (short)1730412544;
				short num3 = num;
				num = (short)1158348800;
				if (num != 0)
				{
				}
				num = (short)1342242817;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0001AAC4 File Offset: 0x00018CC4
		// (set) Token: 0x06000225 RID: 549 RVA: 0x0001AB80 File Offset: 0x00018D80
		public bool DEKButton11IndexIsAcpApplicable
		{
			get
			{
				short num = (short)2023071821;
				short num2 = num;
				num = (short)131309645;
				switch (num2 == num)
				{
				}
				num = (short)1291780096;
				short num3 = num;
				num = (short)557580288;
				if (num != 0)
				{
				}
				num = (short)366411777;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1882513966;
				short num2 = num;
				num = (short)1722278446;
				switch (num2 == num)
				{
				}
				num = (short)238682112;
				short num3 = num;
				num = (short)669646849;
				if (num != 0)
				{
				}
				num = (short)1442447360;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0001AC38 File Offset: 0x00018E38
		// (set) Token: 0x06000227 RID: 551 RVA: 0x0001ACF0 File Offset: 0x00018EF0
		public bool DEKButton11IndexIsAcpVisible
		{
			get
			{
				short num = (short)1366720681;
				short num2 = num;
				num = (short)440762537;
				switch (num2 == num)
				{
				}
				num = (short)1423572992;
				short num3 = num;
				num = (short)1437401088;
				if (num != 0)
				{
				}
				num = (short)101974017;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1458385743;
				short num2 = num;
				num = (short)1655518031;
				switch (num2 == num)
				{
				}
				num = (short)781975552;
				short num3 = num;
				num = (short)196018177;
				if (num != 0)
				{
				}
				num = (short)653656064;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0001ADAC File Offset: 0x00018FAC
		// (set) Token: 0x06000229 RID: 553 RVA: 0x0001AE68 File Offset: 0x00019068
		public bool DEKButton11IndexIsAcpEditable
		{
			get
			{
				short num = (short)1801295760;
				short num2 = num;
				num = (short)550803344;
				switch (num2 == num)
				{
				}
				num = (short)1579286528;
				short num3 = num;
				num = (short)1363673088;
				if (num != 0)
				{
				}
				num = (short)1406337025;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1362625080;
				short num2 = num;
				num = (short)91554360;
				switch (num2 == num)
				{
				}
				num = (short)1769603072;
				short num3 = num;
				num = (short)1258225665;
				if (num != 0)
				{
				}
				num = (short)369491968;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0001AF24 File Offset: 0x00019124
		// (set) Token: 0x0600022B RID: 555 RVA: 0x0001AFDC File Offset: 0x000191DC
		public string DEKButton11IndexUIValue
		{
			get
			{
				short num = (short)2096536424;
				short num2 = num;
				num = (short)601529192;
				switch (num2 == num)
				{
				}
				num = (short)2101673985;
				if (num != 0)
				{
				}
				num = (short)132448256;
				short num3 = num;
				num = (short)735313920;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton11IndexUIValueProperty);
			}
			set
			{
				short num = (short)740240982;
				short num2 = num;
				num = (short)279391830;
				switch (num2 == num)
				{
				}
				num = (short)488112128;
				if (num != 0)
				{
				}
				num = (short)1977417728;
				short num3 = num;
				num = (short)1285357569;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11IndexUIValueProperty, value);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0001B094 File Offset: 0x00019294
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0001B148 File Offset: 0x00019348
		public AcpRangeField<int, int> DEKButton11IndexRange
		{
			get
			{
				short num = (short)1700628067;
				short num2 = num;
				num = (short)1439336035;
				switch (num2 == num)
				{
				}
				num = (short)1382547456;
				if (num != 0)
				{
				}
				num = (short)1696268288;
				short num3 = num;
				num = (short)508231681;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton11IndexRangeProperty);
			}
			set
			{
				short num = (short)844679716;
				short num2 = num;
				num = (short)2127940132;
				switch (num2 == num)
				{
				}
				num = (short)1619591168;
				if (num != 0)
				{
				}
				num = (short)1260781568;
				short num3 = num;
				num = (short)938606593;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11IndexRangeProperty, value);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0001B200 File Offset: 0x00019400
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0001B2BC File Offset: 0x000194BC
		public bool DEKButton11ZoneIsAcpValid
		{
			get
			{
				short num = (short)1817338066;
				short num2 = num;
				num = (short)2031640786;
				switch (num2 == num)
				{
				}
				num = (short)681181185;
				if (num != 0)
				{
				}
				num = (short)672006144;
				short num3 = num;
				num = (short)284753920;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)2128050392;
				short num2 = num;
				num = (short)1849260248;
				switch (num2 == num)
				{
				}
				num = (short)579338241;
				if (num != 0)
				{
				}
				num = (short)1608646656;
				short num3 = num;
				num = (short)1227948032;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0001B378 File Offset: 0x00019578
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0001B430 File Offset: 0x00019630
		public bool DEKButton11ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)758163271;
				short num2 = num;
				num = (short)1503831879;
				switch (num2 == num)
				{
				}
				num = (short)1524760576;
				if (num != 0)
				{
				}
				num = (short)1080164352;
				short num3 = num;
				num = (short)1544486913;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1090711691;
				short num2 = num;
				num = (short)2145775755;
				switch (num2 == num)
				{
				}
				num = (short)182845441;
				if (num != 0)
				{
				}
				num = (short)1102643200;
				short num3 = num;
				num = (short)631242752;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0001B4EC File Offset: 0x000196EC
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0001B5A8 File Offset: 0x000197A8
		public bool DEKButton11ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1195437296;
				short num2 = num;
				num = (short)898952432;
				switch (num2 == num)
				{
				}
				num = (short)1298661377;
				if (num != 0)
				{
				}
				num = (short)1275330560;
				short num3 = num;
				num = (short)163315712;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1396212349;
				short num2 = num;
				num = (short)789086845;
				switch (num2 == num)
				{
				}
				num = (short)1908080641;
				if (num != 0)
				{
				}
				num = (short)1489240064;
				short num3 = num;
				num = (short)1080098816;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0001B664 File Offset: 0x00019864
		// (set) Token: 0x06000235 RID: 565 RVA: 0x0001B71C File Offset: 0x0001991C
		public bool DEKButton11ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1579328168;
				short num2 = num;
				num = (short)596026024;
				switch (num2 == num)
				{
				}
				num = (short)1096679425;
				if (num != 0)
				{
				}
				num = (short)949157888;
				short num3 = num;
				num = (short)1179516928;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)508304526;
				short num2 = num;
				num = (short)1132993678;
				switch (num2 == num)
				{
				}
				num = (short)224133120;
				if (num != 0)
				{
				}
				num = (short)1716781056;
				short num3 = num;
				num = (short)621740033;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0001B7D4 File Offset: 0x000199D4
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0001B88C File Offset: 0x00019A8C
		public string DEKButton11ZoneUIValue
		{
			get
			{
				short num = (short)1593265716;
				short num2 = num;
				num = (short)1981632052;
				switch (num2 == num)
				{
				}
				num = (short)1335951360;
				if (num != 0)
				{
				}
				num = (short)250413056;
				short num3 = num;
				num = (short)248053761;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton11ZoneUIValueProperty);
			}
			set
			{
				short num = (short)655705764;
				short num2 = num;
				num = (short)2031830692;
				switch (num2 == num)
				{
				}
				num = (short)1877868544;
				if (num != 0)
				{
				}
				num = (short)1053229056;
				short num3 = num;
				num = (short)1957363713;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11ZoneUIValueProperty, value);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0001B944 File Offset: 0x00019B44
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0001BA00 File Offset: 0x00019C00
		public AcpListField DEKButton11ZoneList
		{
			get
			{
				short num = (short)1021378561;
				if (num != 0)
				{
				}
				num = (short)1474672566;
				short num2 = num;
				num = (short)1133033398;
				switch (num2 == num)
				{
				}
				num = (short)1657405440;
				short num3 = num;
				num = (short)2060713984;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton11ZoneListProperty);
			}
			set
			{
				short num = (short)1816546057;
				short num2 = num;
				num = (short)1902988041;
				switch (num2 == num)
				{
				}
				num = (short)1168703489;
				if (num != 0)
				{
				}
				num = (short)1693450240;
				short num3 = num;
				num = (short)1497628672;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11ZoneListProperty, value);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0001BAB8 File Offset: 0x00019CB8
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0001BB74 File Offset: 0x00019D74
		public bool DEKButton11ChannelIsAcpValid
		{
			get
			{
				short num = (short)1940412353;
				short num2 = num;
				num = (short)2109757377;
				switch (num2 == num)
				{
				}
				num = (short)134086657;
				if (num != 0)
				{
				}
				num = (short)35717120;
				short num3 = num;
				num = (short)398721024;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)798153888;
				short num2 = num;
				num = (short)1700322464;
				switch (num2 == num)
				{
				}
				num = (short)1343225856;
				if (num != 0)
				{
				}
				num = (short)755236864;
				short num3 = num;
				num = (short)338755585;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0001BC30 File Offset: 0x00019E30
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0001BCE8 File Offset: 0x00019EE8
		public bool DEKButton11ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)120881988;
				short num2 = num;
				num = (short)917013316;
				switch (num2 == num)
				{
				}
				num = (short)1883963393;
				if (num != 0)
				{
				}
				num = (short)1631059968;
				short num3 = num;
				num = (short)841285632;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1732142627;
				short num2 = num;
				num = (short)1947428387;
				switch (num2 == num)
				{
				}
				num = (short)444727297;
				if (num != 0)
				{
				}
				num = (short)975241216;
				short num3 = num;
				num = (short)1581907968;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0001BDA0 File Offset: 0x00019FA0
		// (set) Token: 0x0600023F RID: 575 RVA: 0x0001BE5C File Offset: 0x0001A05C
		public bool DEKButton11ChannelIsAcpVisible
		{
			get
			{
				short num = (short)1452670977;
				if (num != 0)
				{
				}
				num = (short)1293004793;
				short num2 = num;
				num = (short)1913565177;
				switch (num2 == num)
				{
				}
				num = (short)448790528;
				short num3 = num;
				num = (short)1567490048;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)357774203;
				short num2 = num;
				num = (short)1283666811;
				switch (num2 == num)
				{
				}
				num = (short)941096960;
				if (num != 0)
				{
				}
				num = (short)1526792192;
				short num3 = num;
				num = (short)808648705;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0001BF18 File Offset: 0x0001A118
		// (set) Token: 0x06000241 RID: 577 RVA: 0x0001BFD4 File Offset: 0x0001A1D4
		public bool DEKButton11ChannelIsAcpEditable
		{
			get
			{
				short num = (short)2014707713;
				if (num != 0)
				{
				}
				num = (short)159131709;
				short num2 = num;
				num = (short)1943152701;
				switch (num2 == num)
				{
				}
				num = (short)949944320;
				short num3 = num;
				num = (short)126550016;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton11ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1108865298;
				short num2 = num;
				num = (short)1154674962;
				switch (num2 == num)
				{
				}
				num = (short)1466957825;
				if (num != 0)
				{
				}
				num = (short)1725169664;
				short num3 = num;
				num = (short)808779776;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0001C090 File Offset: 0x0001A290
		// (set) Token: 0x06000243 RID: 579 RVA: 0x0001C148 File Offset: 0x0001A348
		public string DEKButton11ChannelUIValue
		{
			get
			{
				short num = (short)1896939521;
				if (num != 0)
				{
				}
				num = (short)1317779473;
				short num2 = num;
				num = (short)91797521;
				switch (num2 == num)
				{
				}
				num = (short)1139802112;
				short num3 = num;
				num = (short)1395458048;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton11ChannelUIValueProperty);
			}
			set
			{
				short num = (short)1964901205;
				short num2 = num;
				num = (short)1364919125;
				switch (num2 == num)
				{
				}
				num = (short)445251585;
				if (num != 0)
				{
				}
				num = (short)732626944;
				short num3 = num;
				num = (short)1721106432;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11ChannelUIValueProperty, value);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0001C200 File Offset: 0x0001A400
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0001C2B8 File Offset: 0x0001A4B8
		public AcpListField DEKButton11ChannelList
		{
			get
			{
				short num = (short)1752551426;
				short num2 = num;
				num = (short)1435947010;
				switch (num2 == num)
				{
				}
				num = (short)1857159169;
				if (num != 0)
				{
				}
				num = (short)1844248576;
				short num3 = num;
				num = (short)1538457600;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton11ChannelListProperty);
			}
			set
			{
				short num = (short)1228687666;
				short num2 = num;
				num = (short)262818098;
				switch (num2 == num)
				{
				}
				num = (short)1892286465;
				if (num != 0)
				{
				}
				num = (short)436469760;
				short num3 = num;
				num = (short)1526530048;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton11ChannelListProperty, value);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0001C36C File Offset: 0x0001A56C
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0001C424 File Offset: 0x0001A624
		public bool DEKButton12FeatureIsAcpValid
		{
			get
			{
				short num = (short)958398465;
				if (num != 0)
				{
				}
				num = (short)462938215;
				short num2 = num;
				num = (short)479846503;
				switch (num2 == num)
				{
				}
				num = (short)1115357184;
				short num3 = num;
				num = (short)1126825984;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)270663681;
				if (num != 0)
				{
				}
				num = (short)436133827;
				short num2 = num;
				num = (short)1556864963;
				switch (num2 == num)
				{
				}
				num = (short)943128576;
				short num3 = num;
				num = (short)85458944;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0001C4E0 File Offset: 0x0001A6E0
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0001C59C File Offset: 0x0001A79C
		public bool DEKButton12FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)197244337;
				short num2 = num;
				num = (short)1079883185;
				switch (num2 == num)
				{
				}
				num = (short)1771241473;
				if (num != 0)
				{
				}
				num = (short)1549271040;
				short num3 = num;
				num = (short)1277493248;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1695753903;
				short num2 = num;
				num = (short)1677862575;
				switch (num2 == num)
				{
				}
				num = (short)391577600;
				if (num != 0)
				{
				}
				num = (short)1097334784;
				short num3 = num;
				num = (short)1118765057;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0001C658 File Offset: 0x0001A858
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0001C710 File Offset: 0x0001A910
		public bool DEKButton12FeatureIsAcpVisible
		{
			get
			{
				short num = (short)2118466793;
				short num2 = num;
				num = (short)424164585;
				switch (num2 == num)
				{
				}
				num = (short)839778304;
				if (num != 0)
				{
				}
				num = (short)1155203072;
				short num3 = num;
				num = (short)1233387521;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)100530503;
				short num2 = num;
				num = (short)405928263;
				switch (num2 == num)
				{
				}
				num = (short)329646081;
				if (num != 0)
				{
				}
				num = (short)1897463808;
				short num3 = num;
				num = (short)665911296;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0001C7CC File Offset: 0x0001A9CC
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0001C888 File Offset: 0x0001AA88
		public bool DEKButton12FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1060372481;
				if (num != 0)
				{
				}
				num = (short)1798656568;
				short num2 = num;
				num = (short)1000559160;
				switch (num2 == num)
				{
				}
				num = (short)1147797504;
				short num3 = num;
				num = (short)1848442880;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1417526173;
				short num2 = num;
				num = (short)244637;
				switch (num2 == num)
				{
				}
				num = (short)994181121;
				if (num != 0)
				{
				}
				num = (short)394264576;
				short num3 = num;
				num = (short)259129344;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0001C940 File Offset: 0x0001AB40
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0001C9FC File Offset: 0x0001ABFC
		public string DEKButton12FeatureUIValue
		{
			get
			{
				short num = (short)1419701194;
				short num2 = num;
				num = (short)891349962;
				switch (num2 == num)
				{
				}
				num = (short)220397569;
				if (num != 0)
				{
				}
				num = (short)1441792;
				short num3 = num;
				num = (short)1217855488;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton12FeatureUIValueProperty);
			}
			set
			{
				short num = (short)234440766;
				short num2 = num;
				num = (short)215042110;
				switch (num2 == num)
				{
				}
				num = (short)1305608193;
				if (num != 0)
				{
				}
				num = (short)1004404736;
				short num3 = num;
				num = (short)1783627776;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0001CAB4 File Offset: 0x0001ACB4
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0001CB70 File Offset: 0x0001AD70
		public AcpListField DEKButton12FeatureList
		{
			get
			{
				short num = (short)967379940;
				short num2 = num;
				num = (short)1096092644;
				switch (num2 == num)
				{
				}
				num = (short)1617559553;
				if (num != 0)
				{
				}
				num = (short)1491140608;
				short num3 = num;
				num = (short)606273536;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton12FeatureListProperty);
			}
			set
			{
				short num = (short)559623770;
				short num2 = num;
				num = (short)1169763930;
				switch (num2 == num)
				{
				}
				num = (short)353959936;
				if (num != 0)
				{
				}
				num = (short)1605173248;
				short num3 = num;
				num = (short)962265089;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12FeatureListProperty, value);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0001CC28 File Offset: 0x0001AE28
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0001CCE0 File Offset: 0x0001AEE0
		public bool DEKButton12IndexIsAcpValid
		{
			get
			{
				short num = (short)1632981130;
				short num2 = num;
				num = (short)1556762762;
				switch (num2 == num)
				{
				}
				num = (short)1444741121;
				if (num != 0)
				{
				}
				num = (short)142409728;
				short num3 = num;
				num = (short)99614720;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)31910895;
				short num2 = num;
				num = (short)1338502127;
				switch (num2 == num)
				{
				}
				num = (short)1673461760;
				if (num != 0)
				{
				}
				num = (short)1025441792;
				short num3 = num;
				num = (short)140181505;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0001CD9C File Offset: 0x0001AF9C
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0001CE58 File Offset: 0x0001B058
		public bool DEKButton12IndexIsAcpApplicable
		{
			get
			{
				short num = (short)37467317;
				short num2 = num;
				num = (short)785364149;
				switch (num2 == num)
				{
				}
				num = (short)2104950784;
				if (num != 0)
				{
				}
				num = (short)783810560;
				short num3 = num;
				num = (short)1418919937;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1707854668;
				short num2 = num;
				num = (short)1547160396;
				switch (num2 == num)
				{
				}
				num = (short)1195966465;
				if (num != 0)
				{
				}
				num = (short)1033764864;
				short num3 = num;
				num = (short)1719205888;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0001CF14 File Offset: 0x0001B114
		// (set) Token: 0x06000257 RID: 599 RVA: 0x0001CFCC File Offset: 0x0001B1CC
		public bool DEKButton12IndexIsAcpVisible
		{
			get
			{
				short num = (short)232931643;
				short num2 = num;
				num = (short)1860124987;
				switch (num2 == num)
				{
				}
				num = (short)1692532737;
				if (num != 0)
				{
				}
				num = (short)269877248;
				short num3 = num;
				num = (short)924712960;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1552982707;
				short num2 = num;
				num = (short)551920307;
				switch (num2 == num)
				{
				}
				num = (short)1432944641;
				if (num != 0)
				{
				}
				num = (short)389283840;
				short num3 = num;
				num = (short)1643773952;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0001D084 File Offset: 0x0001B284
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0001D140 File Offset: 0x0001B340
		public bool DEKButton12IndexIsAcpEditable
		{
			get
			{
				short num = (short)170721281;
				if (num != 0)
				{
				}
				num = (short)2098010576;
				short num2 = num;
				num = (short)1369053648;
				switch (num2 == num)
				{
				}
				num = (short)1732247552;
				short num3 = num;
				num = (short)338362368;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2035659079;
				short num2 = num;
				num = (short)1984475463;
				switch (num2 == num)
				{
				}
				num = (short)394461185;
				if (num != 0)
				{
				}
				num = (short)580911104;
				short num3 = num;
				num = (short)1236402176;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0001D1FC File Offset: 0x0001B3FC
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0001D2B8 File Offset: 0x0001B4B8
		public string DEKButton12IndexUIValue
		{
			get
			{
				short num = (short)977032872;
				short num2 = num;
				num = (short)780162728;
				switch (num2 == num)
				{
				}
				num = (short)1280901120;
				if (num != 0)
				{
				}
				num = (short)1454440448;
				short num3 = num;
				num = (short)1422196737;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton12IndexUIValueProperty);
			}
			set
			{
				short num = (short)1701532995;
				short num2 = num;
				num = (short)17061187;
				switch (num2 == num)
				{
				}
				num = (short)733741057;
				if (num != 0)
				{
				}
				num = (short)91947008;
				short num3 = num;
				num = (short)913965056;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12IndexUIValueProperty, value);
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0001D370 File Offset: 0x0001B570
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0001D428 File Offset: 0x0001B628
		public AcpRangeField<int, int> DEKButton12IndexRange
		{
			get
			{
				short num = (short)1300662893;
				short num2 = num;
				num = (short)1710525037;
				switch (num2 == num)
				{
				}
				num = (short)1087307776;
				if (num != 0)
				{
				}
				num = (short)1171062784;
				short num3 = num;
				num = (short)1206386689;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton12IndexRangeProperty);
			}
			set
			{
				short num = (short)2023597064;
				short num2 = num;
				num = (short)245212168;
				switch (num2 == num)
				{
				}
				num = (short)605290496;
				if (num != 0)
				{
				}
				num = (short)1411907584;
				short num3 = num;
				num = (short)1399128065;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12IndexRangeProperty, value);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0001D4E0 File Offset: 0x0001B6E0
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0001D594 File Offset: 0x0001B794
		public bool DEKButton12ZoneIsAcpValid
		{
			get
			{
				short num = (short)1724887051;
				short num2 = num;
				num = (short)758165515;
				switch (num2 == num)
				{
				}
				num = (short)1606418433;
				if (num != 0)
				{
				}
				num = (short)950140928;
				short num3 = num;
				num = (short)2133721088;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)305672557;
				short num2 = num;
				num = (short)987771245;
				switch (num2 == num)
				{
				}
				num = (short)347209729;
				if (num != 0)
				{
				}
				num = (short)1566113792;
				short num3 = num;
				num = (short)1379598336;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0001D650 File Offset: 0x0001B850
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0001D708 File Offset: 0x0001B908
		public bool DEKButton12ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)895373886;
				short num2 = num;
				num = (short)1655132734;
				switch (num2 == num)
				{
				}
				num = (short)1804730369;
				if (num != 0)
				{
				}
				num = (short)554434560;
				short num3 = num;
				num = (short)45023232;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)16213996;
				short num2 = num;
				num = (short)822962156;
				switch (num2 == num)
				{
				}
				num = (short)1275199489;
				if (num != 0)
				{
				}
				num = (short)1318649856;
				short num3 = num;
				num = (short)688324608;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0001D7C4 File Offset: 0x0001B9C4
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0001D87C File Offset: 0x0001BA7C
		public bool DEKButton12ZoneIsAcpVisible
		{
			get
			{
				short num = (short)313263641;
				short num2 = num;
				num = (short)734463513;
				switch (num2 == num)
				{
				}
				num = (short)537788417;
				if (num != 0)
				{
				}
				num = (short)544210944;
				short num3 = num;
				num = (short)26673152;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1088066896;
				short num2 = num;
				num = (short)793285968;
				switch (num2 == num)
				{
				}
				num = (short)1200226305;
				if (num != 0)
				{
				}
				num = (short)381353984;
				short num3 = num;
				num = (short)1498152960;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0001D934 File Offset: 0x0001BB34
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0001D9EC File Offset: 0x0001BBEC
		public bool DEKButton12ZoneIsAcpEditable
		{
			get
			{
				short num = (short)592384531;
				short num2 = num;
				num = (short)2129728019;
				switch (num2 == num)
				{
				}
				num = (short)1692729344;
				if (num != 0)
				{
				}
				num = (short)928776192;
				short num3 = num;
				num = (short)1821376513;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1004494204;
				short num2 = num;
				num = (short)1568103804;
				switch (num2 == num)
				{
				}
				num = (short)504496128;
				if (num != 0)
				{
				}
				num = (short)1315700736;
				short num3 = num;
				num = (short)938147841;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0001DAA4 File Offset: 0x0001BCA4
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0001DB60 File Offset: 0x0001BD60
		public string DEKButton12ZoneUIValue
		{
			get
			{
				short num = (short)82815189;
				short num2 = num;
				num = (short)1976674517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)640221184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2096889856;
				if (num != 0)
				{
				}
				num = (short)946143233;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton12ZoneUIValueProperty);
			}
			set
			{
				short num = (short)107830805;
				short num2 = num;
				num = (short)892689941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1094451200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)867696641;
				if (num != 0)
				{
				}
				num = (short)876281856;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12ZoneUIValueProperty, value);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0001DC18 File Offset: 0x0001BE18
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0001DCD0 File Offset: 0x0001BED0
		public AcpListField DEKButton12ZoneList
		{
			get
			{
				short num = (short)428675108;
				short num2 = num;
				num = (short)2057965604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)123666432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1023475713;
				if (num != 0)
				{
				}
				num = (short)62717952;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton12ZoneListProperty);
			}
			set
			{
				short num = (short)1304952833;
				if (num != 0)
				{
				}
				num = (short)1605697536;
				short num2 = num;
				num = (short)2011630893;
				short num3 = num;
				num = (short)862981421;
				switch (num3 == num)
				{
				}
				num = (short)804847616;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12ZoneListProperty, value);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0001DD88 File Offset: 0x0001BF88
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0001DE44 File Offset: 0x0001C044
		public bool DEKButton12ChannelIsAcpValid
		{
			get
			{
				short num = (short)1233125377;
				if (num != 0)
				{
				}
				num = (short)209387520;
				short num2 = num;
				num = (short)985320652;
				short num3 = num;
				num = (short)1356385484;
				switch (num3 == num)
				{
				}
				num = (short)1958281216;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)175143928;
				short num2 = num;
				num = (short)488930296;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1062469632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1184235520;
				if (num != 0)
				{
				}
				num = (short)1912471553;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0001DEFC File Offset: 0x0001C0FC
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0001DFB8 File Offset: 0x0001C1B8
		public bool DEKButton12ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)1484062721;
				if (num != 0)
				{
				}
				num = (short)2074476544;
				short num2 = num;
				num = (short)1264639909;
				short num3 = num;
				num = (short)1332404133;
				switch (num3 == num)
				{
				}
				num = (short)594280448;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1174099181;
				short num2 = num;
				num = (short)1196446957;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1205207040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)881524737;
				if (num != 0)
				{
				}
				num = (short)691077120;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0001E074 File Offset: 0x0001C274
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0001E130 File Offset: 0x0001C330
		public bool DEKButton12ChannelIsAcpVisible
		{
			get
			{
				short num = (short)1450243179;
				short num2 = num;
				num = (short)192935019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)195624960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)461504512;
				if (num != 0)
				{
				}
				num = (short)1511260161;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1569848344;
				short num2 = num;
				num = (short)1816198168;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1372389376;
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
				num = (short)505217024;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0001E1EC File Offset: 0x0001C3EC
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0001E2A8 File Offset: 0x0001C4A8
		public bool DEKButton12ChannelIsAcpEditable
		{
			get
			{
				short num = (short)2132279297;
				if (num != 0)
				{
				}
				num = (short)611254272;
				short num2 = num;
				num = (short)943480639;
				short num3 = num;
				num = (short)287465279;
				switch (num3 == num)
				{
				}
				num = (short)1713111040;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton12ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2123235329;
				if (num != 0)
				{
				}
				num = (short)423034880;
				short num2 = num;
				num = (short)2049904514;
				short num3 = num;
				num = (short)275713922;
				switch (num3 == num)
				{
				}
				num = (short)1324613632;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0001E360 File Offset: 0x0001C560
		// (set) Token: 0x06000273 RID: 627 RVA: 0x0001E41C File Offset: 0x0001C61C
		public string DEKButton12ChannelUIValue
		{
			get
			{
				short num = (short)902418620;
				short num2 = num;
				num = (short)559468732;
				switch (num2 == num)
				{
				default:
				{
					num = (short)917831680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)963772417;
				if (num != 0)
				{
				}
				num = (short)457965568;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton12ChannelUIValueProperty);
			}
			set
			{
				short num = (short)1187271914;
				short num2 = num;
				num = (short)154031338;
				switch (num2 == num)
				{
				default:
				{
					num = (short)135659520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1432223745;
				if (num != 0)
				{
				}
				num = (short)851902464;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12ChannelUIValueProperty, value);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0001E4D0 File Offset: 0x0001C6D0
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0001E588 File Offset: 0x0001C788
		public AcpListField DEKButton12ChannelList
		{
			get
			{
				short num = (short)1639186433;
				if (num != 0)
				{
				}
				num = (short)623312896;
				short num2 = num;
				num = (short)1118246297;
				short num3 = num;
				num = (short)1867584921;
				switch (num3 == num)
				{
				}
				num = (short)804126720;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton12ChannelListProperty);
			}
			set
			{
				short num = (short)614056970;
				short num2 = num;
				num = (short)1364378634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)389414912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)287768577;
				if (num != 0)
				{
				}
				num = (short)1582366720;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton12ChannelListProperty, value);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0001E640 File Offset: 0x0001C840
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0001E6FC File Offset: 0x0001C8FC
		public bool DEKButton13FeatureIsAcpValid
		{
			get
			{
				short num = (short)1193246406;
				short num2 = num;
				num = (short)955678406;
				switch (num2 == num)
				{
				default:
				{
					num = (short)714145792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1277624321;
				if (num != 0)
				{
				}
				num = (short)703660032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1174756593;
				short num2 = num;
				num = (short)17390833;
				switch (num2 == num)
				{
				default:
				{
					num = (short)895483904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)245563393;
				if (num != 0)
				{
				}
				num = (short)895549440;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0001E7B4 File Offset: 0x0001C9B4
		// (set) Token: 0x06000279 RID: 633 RVA: 0x0001E86C File Offset: 0x0001CA6C
		public bool DEKButton13FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)518500310;
				short num2 = num;
				num = (short)1479913430;
				switch (num2 == num)
				{
				default:
				{
					num = (short)628948992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)862650368;
				if (num != 0)
				{
				}
				num = (short)2121793537;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)447485277;
				short num2 = num;
				num = (short)7279965;
				switch (num2 == num)
				{
				default:
				{
					num = (short)61931520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)884146176;
				if (num != 0)
				{
				}
				num = (short)1667432449;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0001E924 File Offset: 0x0001CB24
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0001E9DC File Offset: 0x0001CBDC
		public bool DEKButton13FeatureIsAcpVisible
		{
			get
			{
				short num = (short)866707845;
				short num2 = num;
				num = (short)58124677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2091581440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)645005313;
				if (num != 0)
				{
				}
				num = (short)1304297472;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)250748602;
				short num2 = num;
				num = (short)1435836090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1800667136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1870790657;
				if (num != 0)
				{
				}
				num = (short)1884749824;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0001EA98 File Offset: 0x0001CC98
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0001EB54 File Offset: 0x0001CD54
		public bool DEKButton13FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1164571273;
				short num2 = num;
				num = (short)540275337;
				switch (num2 == num)
				{
				default:
				{
					num = (short)549584896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1168375809;
				if (num != 0)
				{
				}
				num = (short)1447755776;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)712280867;
				short num2 = num;
				num = (short)1959103267;
				switch (num2 == num)
				{
				default:
				{
					num = (short)955777024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2068774913;
				if (num != 0)
				{
				}
				num = (short)724172800;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0001EC10 File Offset: 0x0001CE10
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0001ECC8 File Offset: 0x0001CEC8
		public string DEKButton13FeatureUIValue
		{
			get
			{
				short num = (short)741561685;
				short num2 = num;
				num = (short)818042197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)573046784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1145241601;
				if (num != 0)
				{
				}
				num = (short)1034944512;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton13FeatureUIValueProperty);
			}
			set
			{
				short num = (short)67441064;
				short num2 = num;
				num = (short)1316622760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2073231360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379584513;
				if (num != 0)
				{
				}
				num = (short)467206144;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0001ED80 File Offset: 0x0001CF80
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0001EE38 File Offset: 0x0001D038
		public AcpListField DEKButton13FeatureList
		{
			get
			{
				short num = (short)1227978404;
				short num2 = num;
				num = (short)1036154532;
				switch (num2 == num)
				{
				default:
				{
					num = (short)291176448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1610481665;
				if (num != 0)
				{
				}
				num = (short)713883648;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton13FeatureListProperty);
			}
			set
			{
				short num = (short)1189088123;
				short num2 = num;
				num = (short)1778715515;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1266221056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)619839489;
				if (num != 0)
				{
				}
				num = (short)1631453184;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13FeatureListProperty, value);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0001EEEC File Offset: 0x0001D0EC
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0001EFA4 File Offset: 0x0001D1A4
		public bool DEKButton13IndexIsAcpValid
		{
			get
			{
				short num = (short)209977345;
				if (num != 0)
				{
				}
				num = (short)902299648;
				short num2 = num;
				num = (short)1049798408;
				short num3 = num;
				num = (short)2069276424;
				switch (num3 == num)
				{
				}
				num = (short)1328414720;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1256843851;
				short num2 = num;
				num = (short)1180691019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1219821568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)299040769;
				if (num != 0)
				{
				}
				num = (short)183107584;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0001F060 File Offset: 0x0001D260
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0001F118 File Offset: 0x0001D318
		public bool DEKButton13IndexIsAcpApplicable
		{
			get
			{
				short num = (short)1578546564;
				short num2 = num;
				num = (short)180204932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964244992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)202113024;
				if (num != 0)
				{
				}
				num = (short)2128674817;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)54591489;
				if (num != 0)
				{
				}
				num = (short)2145976320;
				short num2 = num;
				num = (short)1950111354;
				short num3 = num;
				num = (short)677926522;
				switch (num3 == num)
				{
				}
				num = (short)265748480;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0001F1D8 File Offset: 0x0001D3D8
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0001F294 File Offset: 0x0001D494
		public bool DEKButton13IndexIsAcpVisible
		{
			get
			{
				short num = (short)204879403;
				short num2 = num;
				num = (short)139474475;
				switch (num2 == num)
				{
				default:
				{
					num = (short)40763392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1991180289;
				if (num != 0)
				{
				}
				num = (short)144769024;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)275951207;
				short num2 = num;
				num = (short)230010471;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1805975552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)796000257;
				if (num != 0)
				{
				}
				num = (short)115736576;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0001F350 File Offset: 0x0001D550
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0001F408 File Offset: 0x0001D608
		public bool DEKButton13IndexIsAcpEditable
		{
			get
			{
				short num = (short)733644164;
				short num2 = num;
				num = (short)1190167940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1197604864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)880607232;
				if (num != 0)
				{
				}
				num = (short)742981633;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)847773696;
				short num2 = num;
				num = (short)12120692;
				short num3 = num;
				num = (short)1716712052;
				switch (num3 == num)
				{
				}
				num = (short)1167523841;
				if (num != 0)
				{
				}
				num = (short)2146500608;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0001F4C8 File Offset: 0x0001D6C8
		// (set) Token: 0x0600028B RID: 651 RVA: 0x0001F580 File Offset: 0x0001D780
		public string DEKButton13IndexUIValue
		{
			get
			{
				short num = (short)1901199360;
				short num2 = num;
				num = (short)1914952651;
				short num3 = num;
				num = (short)187292619;
				switch (num3 == num)
				{
				}
				num = (short)673120257;
				if (num != 0)
				{
				}
				num = (short)1055653888;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton13IndexUIValueProperty);
			}
			set
			{
				short num = (short)1171062784;
				short num2 = num;
				num = (short)1311614856;
				short num3 = num;
				num = (short)1503569800;
				switch (num3 == num)
				{
				}
				num = (short)37421057;
				if (num != 0)
				{
				}
				num = (short)145162240;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13IndexUIValueProperty, value);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0001F634 File Offset: 0x0001D834
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0001F6F0 File Offset: 0x0001D8F0
		public AcpRangeField<int, int> DEKButton13IndexRange
		{
			get
			{
				short num = (short)1596588032;
				short num2 = num;
				num = (short)1478164096;
				short num3 = num;
				num = (short)1591344768;
				switch (num3 == num)
				{
				}
				num = (short)75825153;
				if (num != 0)
				{
				}
				num = (short)2108096512;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton13IndexRangeProperty);
			}
			set
			{
				short num = (short)2140340224;
				short num2 = num;
				num = (short)774751555;
				short num3 = num;
				num = (short)1009239363;
				switch (num3 == num)
				{
				}
				num = (short)500498432;
				if (num != 0)
				{
				}
				num = (short)1212153857;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13IndexRangeProperty, value);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0001F7A8 File Offset: 0x0001D9A8
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0001F860 File Offset: 0x0001DA60
		public bool DEKButton13ZoneIsAcpValid
		{
			get
			{
				short num = (short)1884487680;
				short num2 = num;
				num = (short)639288078;
				short num3 = num;
				num = (short)16368398;
				switch (num3 == num)
				{
				}
				num = (short)1613299713;
				if (num != 0)
				{
				}
				num = (short)593690624;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)1317994496;
				short num2 = num;
				num = (short)134857954;
				short num3 = num;
				num = (short)1070515426;
				switch (num3 == num)
				{
				}
				num = (short)419299328;
				if (num != 0)
				{
				}
				num = (short)1556217857;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0001F918 File Offset: 0x0001DB18
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0001F9D4 File Offset: 0x0001DBD4
		public bool DEKButton13ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)1921712128;
				short num2 = num;
				num = (short)1996602587;
				short num3 = num;
				num = (short)1201913051;
				switch (num3 == num)
				{
				}
				num = (short)547880961;
				if (num != 0)
				{
				}
				num = (short)1119027200;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2091384832;
				short num2 = num;
				num = (short)753687183;
				short num3 = num;
				num = (short)621238927;
				switch (num3 == num)
				{
				}
				num = (short)604569601;
				if (num != 0)
				{
				}
				num = (short)642646016;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0001FA8C File Offset: 0x0001DC8C
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0001FB44 File Offset: 0x0001DD44
		public bool DEKButton13ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1078919168;
				short num2 = num;
				num = (short)252114436;
				short num3 = num;
				num = (short)1728968196;
				switch (num3 == num)
				{
				}
				num = (short)215482369;
				if (num != 0)
				{
				}
				num = (short)207290368;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)298123264;
				short num2 = num;
				num = (short)1499167467;
				short num3 = num;
				num = (short)1457617643;
				switch (num3 == num)
				{
				}
				num = (short)54591488;
				if (num != 0)
				{
				}
				num = (short)2127101953;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0001FC00 File Offset: 0x0001DE00
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0001FCB8 File Offset: 0x0001DEB8
		public bool DEKButton13ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1400176640;
				short num2 = num;
				num = (short)333828940;
				short num3 = num;
				num = (short)279565132;
				switch (num3 == num)
				{
				}
				num = (short)59572225;
				if (num != 0)
				{
				}
				num = (short)567541760;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1655111680;
				short num2 = num;
				num = (short)1376017184;
				short num3 = num;
				num = (short)828594976;
				switch (num3 == num)
				{
				}
				num = (short)161808384;
				if (num != 0)
				{
				}
				num = (short)266665985;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0001FD70 File Offset: 0x0001DF70
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0001FE2C File Offset: 0x0001E02C
		public string DEKButton13ZoneUIValue
		{
			get
			{
				short num = (short)1740963840;
				short num2 = num;
				num = (short)479075283;
				short num3 = num;
				num = (short)450632659;
				switch (num3 == num)
				{
				}
				num = (short)299040769;
				if (num != 0)
				{
				}
				num = (short)1267335168;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton13ZoneUIValueProperty);
			}
			set
			{
				short num = (short)1490223104;
				short num2 = num;
				num = (short)1576242740;
				short num3 = num;
				num = (short)811634228;
				switch (num3 == num)
				{
				}
				num = (short)85131265;
				if (num != 0)
				{
				}
				num = (short)1519845376;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13ZoneUIValueProperty, value);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0001FEE0 File Offset: 0x0001E0E0
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0001FF98 File Offset: 0x0001E198
		public AcpListField DEKButton13ZoneList
		{
			get
			{
				short num = (short)431489024;
				short num2 = num;
				num = (short)640942081;
				if (num != 0)
				{
				}
				num = (short)272754982;
				short num3 = num;
				num = (short)83552550;
				switch (num3 == num)
				{
				}
				num = (short)195362816;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton13ZoneListProperty);
			}
			set
			{
				short num = (short)124780544;
				short num2 = num;
				num = (short)1405026305;
				if (num != 0)
				{
				}
				num = (short)648325416;
				short num3 = num;
				num = (short)1255516456;
				switch (num3 == num)
				{
				}
				num = (short)761069568;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13ZoneListProperty, value);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00020050 File Offset: 0x0001E250
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0002010C File Offset: 0x0001E30C
		public bool DEKButton13ChannelIsAcpValid
		{
			get
			{
				short num = (short)859897856;
				short num2 = num;
				num = (short)318825849;
				short num3 = num;
				num = (short)514778489;
				switch (num3 == num)
				{
				}
				num = (short)1970274305;
				if (num != 0)
				{
				}
				num = (short)1762197504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)830406656;
				short num2 = num;
				num = (short)1595342005;
				short num3 = num;
				num = (short)167378101;
				switch (num3 == num)
				{
				}
				num = (short)888406016;
				if (num != 0)
				{
				}
				num = (short)2010513409;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600029C RID: 668 RVA: 0x000201C8 File Offset: 0x0001E3C8
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00020284 File Offset: 0x0001E484
		public bool DEKButton13ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)1686568960;
				short num2 = num;
				num = (short)1385919479;
				short num3 = num;
				num = (short)751268855;
				switch (num3 == num)
				{
				}
				num = (short)1643446273;
				if (num != 0)
				{
				}
				num = (short)1272053760;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1553334272;
				short num2 = num;
				num = (short)1697221146;
				short num3 = num;
				num = (short)601262618;
				switch (num3 == num)
				{
				}
				num = (short)1226702849;
				if (num != 0)
				{
				}
				num = (short)1011220480;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0002033C File Offset: 0x0001E53C
		// (set) Token: 0x0600029F RID: 671 RVA: 0x000203F4 File Offset: 0x0001E5F4
		public bool DEKButton13ChannelIsAcpVisible
		{
			get
			{
				short num = (short)1411448832;
				short num2 = num;
				num = (short)1096903564;
				short num3 = num;
				num = (short)663972748;
				switch (num3 == num)
				{
				}
				num = (short)331022337;
				if (num != 0)
				{
				}
				num = (short)1974992896;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1973354496;
				short num2 = num;
				num = (short)1105036544;
				short num3 = num;
				num = (short)305890560;
				switch (num3 == num)
				{
				}
				num = (short)1576206336;
				if (num != 0)
				{
				}
				num = (short)767229953;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x000204B0 File Offset: 0x0001E6B0
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0002056C File Offset: 0x0001E76C
		public bool DEKButton13ChannelIsAcpEditable
		{
			get
			{
				short num = (short)864354304;
				short num2 = num;
				num = (short)179746775;
				short num3 = num;
				num = (short)154777559;
				switch (num3 == num)
				{
				}
				num = (short)1067450368;
				if (num != 0)
				{
				}
				num = (short)430571521;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton13ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)803602432;
				short num2 = num;
				num = (short)633846563;
				short num3 = num;
				num = (short)1097120547;
				switch (num3 == num)
				{
				}
				num = (short)1982595073;
				if (num != 0)
				{
				}
				num = (short)1726873600;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00020624 File Offset: 0x0001E824
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x000206E0 File Offset: 0x0001E8E0
		public string DEKButton13ChannelUIValue
		{
			get
			{
				short num = (short)1933180928;
				short num2 = num;
				num = (short)1236600147;
				short num3 = num;
				num = (short)1678378323;
				switch (num3 == num)
				{
				}
				num = (short)66977793;
				if (num != 0)
				{
				}
				num = (short)137625600;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton13ChannelUIValueProperty);
			}
			set
			{
				short num = (short)679346176;
				short num2 = num;
				num = (short)1880871977;
				short num3 = num;
				num = (short)1561641;
				switch (num3 == num)
				{
				}
				num = (short)971702273;
				if (num != 0)
				{
				}
				num = (short)752222208;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13ChannelUIValueProperty, value);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00020798 File Offset: 0x0001E998
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00020854 File Offset: 0x0001EA54
		public AcpListField DEKButton13ChannelList
		{
			get
			{
				short num = (short)1250230272;
				short num2 = num;
				num = (short)1944694245;
				short num3 = num;
				num = (short)1816440293;
				switch (num3 == num)
				{
				}
				num = (short)1376976897;
				if (num != 0)
				{
				}
				num = (short)1259601920;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton13ChannelListProperty);
			}
			set
			{
				short num = (short)44498944;
				short num2 = num;
				num = (short)1476790816;
				short num3 = num;
				num = (short)178457120;
				switch (num3 == num)
				{
				}
				num = (short)269025281;
				if (num != 0)
				{
				}
				num = (short)1895825408;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton13ChannelListProperty, value);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0002090C File Offset: 0x0001EB0C
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x000209C8 File Offset: 0x0001EBC8
		public bool DEKButton14FeatureIsAcpValid
		{
			get
			{
				short num = (short)277676032;
				short num2 = num;
				num = (short)2038449812;
				short num3 = num;
				num = (short)389564052;
				switch (num3 == num)
				{
				}
				num = (short)503513089;
				if (num != 0)
				{
				}
				num = (short)1760886784;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1223753728;
				short num2 = num;
				num = (short)832702660;
				short num3 = num;
				num = (short)696780996;
				switch (num3 == num)
				{
				}
				num = (short)782041088;
				if (num != 0)
				{
				}
				num = (short)1975779329;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00020A80 File Offset: 0x0001EC80
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00020B38 File Offset: 0x0001ED38
		public bool DEKButton14FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)784531456;
				short num2 = num;
				num = (short)1472387415;
				short num3 = num;
				num = (short)1467799895;
				switch (num3 == num)
				{
				}
				num = (short)251527169;
				if (num != 0)
				{
				}
				num = (short)1688928256;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1744175104;
				short num2 = num;
				num = (short)1463689813;
				short num3 = num;
				num = (short)424813141;
				switch (num3 == num)
				{
				}
				num = (short)337182720;
				if (num != 0)
				{
				}
				num = (short)711000065;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00020BF4 File Offset: 0x0001EDF4
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00020CAC File Offset: 0x0001EEAC
		public bool DEKButton14FeatureIsAcpVisible
		{
			get
			{
				short num = (short)172359680;
				short num2 = num;
				num = (short)1291702117;
				short num3 = num;
				num = (short)808636261;
				switch (num3 == num)
				{
				}
				num = (short)1739653121;
				if (num != 0)
				{
				}
				num = (short)1531510784;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2092761088;
				short num2 = num;
				num = (short)312156964;
				short num3 = num;
				num = (short)303899428;
				switch (num3 == num)
				{
				}
				num = (short)478740480;
				if (num != 0)
				{
				}
				num = (short)692715521;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00020D64 File Offset: 0x0001EF64
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00020E1C File Offset: 0x0001F01C
		public bool DEKButton14FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1567490048;
				short num2 = num;
				num = (short)558426174;
				short num3 = num;
				num = (short)1324607550;
				switch (num3 == num)
				{
				}
				num = (short)102236160;
				if (num != 0)
				{
				}
				num = (short)842268673;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)206766080;
				short num2 = num;
				num = (short)549115710;
				short num3 = num;
				num = (short)853595966;
				switch (num3 == num)
				{
				}
				num = (short)102563841;
				if (num != 0)
				{
				}
				num = (short)933101568;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00020ED8 File Offset: 0x0001F0D8
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00020F94 File Offset: 0x0001F194
		public string DEKButton14FeatureUIValue
		{
			get
			{
				short num = (short)1459159040;
				short num2 = num;
				num = (short)175267440;
				short num3 = num;
				num = (short)1740070512;
				switch (num3 == num)
				{
				}
				num = (short)1943535617;
				if (num != 0)
				{
				}
				num = (short)131137536;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton14FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1177026560;
				short num2 = num;
				num = (short)444006401;
				if (num != 0)
				{
				}
				num = (short)1839327891;
				short num3 = num;
				num = (short)417655443;
				switch (num3 == num)
				{
				}
				num = (short)136445952;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00021048 File Offset: 0x0001F248
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00021100 File Offset: 0x0001F300
		public AcpListField DEKButton14FeatureList
		{
			get
			{
				short num = (short)1034965583;
				short num2 = num;
				num = (short)1178030671;
				switch (num2 == num)
				{
				}
				num = (short)1039663104;
				short num3 = num;
				num = (short)904134656;
				if (num != 0)
				{
				}
				num = (short)421265409;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton14FeatureListProperty);
			}
			set
			{
				short num = (short)340337826;
				short num2 = num;
				num = (short)1868178594;
				switch (num2 == num)
				{
				}
				num = (short)1846673408;
				short num3 = num;
				num = (short)1783431168;
				if (num != 0)
				{
				}
				num = (short)1227948033;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14FeatureListProperty, value);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x000211B8 File Offset: 0x0001F3B8
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00021274 File Offset: 0x0001F474
		public bool DEKButton14IndexIsAcpValid
		{
			get
			{
				short num = (short)151609822;
				short num2 = num;
				num = (short)923951582;
				switch (num2 == num)
				{
				}
				num = (short)693895168;
				short num3 = num;
				num = (short)1423835137;
				if (num != 0)
				{
				}
				num = (short)576585728;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1319501825;
				if (num != 0)
				{
				}
				num = (short)302749689;
				short num2 = num;
				num = (short)1339529209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2030567424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)310378496;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0002132C File Offset: 0x0001F52C
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000213E8 File Offset: 0x0001F5E8
		public bool DEKButton14IndexIsAcpApplicable
		{
			get
			{
				short num = (short)2061631489;
				if (num != 0)
				{
				}
				num = (short)730502430;
				short num2 = num;
				num = (short)744068382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1612251136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)273416192;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2031147626;
				short num2 = num;
				num = (short)1489361514;
				switch (num2 == num)
				{
				}
				num = (short)1235288064;
				short num3 = num;
				num = (short)1354629121;
				if (num != 0)
				{
				}
				num = (short)651886592;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x000214A0 File Offset: 0x0001F6A0
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x0002155C File Offset: 0x0001F75C
		public bool DEKButton14IndexIsAcpVisible
		{
			get
			{
				short num = (short)678772316;
				short num2 = num;
				num = (short)1301233244;
				switch (num2 == num)
				{
				}
				num = (short)276692992;
				short num3 = num;
				num = (short)1598816256;
				if (num != 0)
				{
				}
				num = (short)597426177;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)357440387;
				short num2 = num;
				num = (short)1943280515;
				switch (num2 == num)
				{
				}
				num = (short)830341120;
				short num3 = num;
				num = (short)383647745;
				if (num != 0)
				{
				}
				num = (short)696188928;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00021618 File Offset: 0x0001F818
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x000216D0 File Offset: 0x0001F8D0
		public bool DEKButton14IndexIsAcpEditable
		{
			get
			{
				short num = (short)1063518209;
				if (num != 0)
				{
				}
				num = (short)721416103;
				short num2 = num;
				num = (short)1577906087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)764477440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)508821504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1212487891;
				short num2 = num;
				num = (short)2033260755;
				switch (num2 == num)
				{
				}
				num = (short)1497759744;
				short num3 = num;
				num = (short)1037893632;
				if (num != 0)
				{
				}
				num = (short)473628673;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0002178C File Offset: 0x0001F98C
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00021848 File Offset: 0x0001FA48
		public string DEKButton14IndexUIValue
		{
			get
			{
				short num = (short)1653145892;
				short num2 = num;
				num = (short)1477574948;
				switch (num2 == num)
				{
				}
				num = (short)1655046144;
				short num3 = num;
				num = (short)1611202561;
				if (num != 0)
				{
				}
				num = (short)67174400;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton14IndexUIValueProperty);
			}
			set
			{
				short num = (short)8522843;
				short num2 = num;
				num = (short)2021592155;
				switch (num2 == num)
				{
				}
				num = (short)871563264;
				short num3 = num;
				num = (short)1340866560;
				if (num != 0)
				{
				}
				num = (short)1922957313;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14IndexUIValueProperty, value);
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00021900 File Offset: 0x0001FB00
		// (set) Token: 0x060002BD RID: 701 RVA: 0x000219BC File Offset: 0x0001FBBC
		public AcpRangeField<int, int> DEKButton14IndexRange
		{
			get
			{
				short num = (short)562000128;
				short num2 = num;
				num = (short)609972480;
				switch (num2 == num)
				{
				}
				num = (short)208797696;
				short num3 = num;
				num = (short)1386479617;
				if (num != 0)
				{
				}
				num = (short)1195311104;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton14IndexRangeProperty);
			}
			set
			{
				short num = (short)1911568757;
				short num2 = num;
				num = (short)754071925;
				switch (num2 == num)
				{
				}
				num = (short)1999110144;
				short num3 = num;
				num = (short)576454657;
				if (num != 0)
				{
				}
				num = (short)1584332800;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14IndexRangeProperty, value);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00021A70 File Offset: 0x0001FC70
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00021B2C File Offset: 0x0001FD2C
		public bool DEKButton14ZoneIsAcpValid
		{
			get
			{
				short num = (short)432749167;
				short num2 = num;
				num = (short)590821999;
				switch (num2 == num)
				{
				}
				num = (short)846790656;
				short num3 = num;
				num = (short)1791033345;
				if (num != 0)
				{
				}
				num = (short)176160768;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)1364851561;
				short num2 = num;
				num = (short)1978661737;
				switch (num2 == num)
				{
				}
				num = (short)1314652160;
				short num3 = num;
				num = (short)932577281;
				if (num != 0)
				{
				}
				num = (short)1869348864;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00021BE4 File Offset: 0x0001FDE4
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00021CA0 File Offset: 0x0001FEA0
		public bool DEKButton14ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)1568769768;
				short num2 = num;
				num = (short)824805096;
				switch (num2 == num)
				{
				}
				num = (short)914948096;
				short num3 = num;
				num = (short)140967937;
				if (num != 0)
				{
				}
				num = (short)1494614016;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1865111243;
				short num2 = num;
				num = (short)1346590411;
				switch (num2 == num)
				{
				}
				num = (short)713949184;
				short num3 = num;
				num = (short)231931905;
				if (num != 0)
				{
				}
				num = (short)488177664;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00021D58 File Offset: 0x0001FF58
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00021E10 File Offset: 0x00020010
		public bool DEKButton14ZoneIsAcpVisible
		{
			get
			{
				short num = (short)490336176;
				short num2 = num;
				num = (short)7270320;
				switch (num2 == num)
				{
				}
				num = (short)770244608;
				short num3 = num;
				num = (short)513081345;
				if (num != 0)
				{
				}
				num = (short)647561216;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)885408604;
				short num2 = num;
				num = (short)211829596;
				switch (num2 == num)
				{
				}
				num = (short)746913792;
				short num3 = num;
				num = (short)1745944576;
				if (num != 0)
				{
				}
				num = (short)2099118081;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00021EC8 File Offset: 0x000200C8
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00021F80 File Offset: 0x00020180
		public bool DEKButton14ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1598734319;
				short num2 = num;
				num = (short)2129313775;
				switch (num2 == num)
				{
				}
				num = (short)206831616;
				short num3 = num;
				num = (short)2015821825;
				if (num != 0)
				{
				}
				num = (short)409272320;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1606086372;
				short num2 = num;
				num = (short)1079701220;
				switch (num2 == num)
				{
				}
				num = (short)1209597952;
				short num3 = num;
				num = (short)1751449601;
				if (num != 0)
				{
				}
				num = (short)823918592;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0002203C File Offset: 0x0002023C
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x000220F8 File Offset: 0x000202F8
		public string DEKButton14ZoneUIValue
		{
			get
			{
				short num = (short)654579453;
				short num2 = num;
				num = (short)2138248957;
				switch (num2 == num)
				{
				}
				num = (short)1265041408;
				short num3 = num;
				num = (short)31326209;
				if (num != 0)
				{
				}
				num = (short)1961426944;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton14ZoneUIValueProperty);
			}
			set
			{
				short num = (short)1212265146;
				short num2 = num;
				num = (short)1524871866;
				switch (num2 == num)
				{
				}
				num = (short)392626176;
				short num3 = num;
				num = (short)804061184;
				if (num != 0)
				{
				}
				num = (short)1749942273;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14ZoneUIValueProperty, value);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000221AC File Offset: 0x000203AC
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00022264 File Offset: 0x00020464
		public AcpListField DEKButton14ZoneList
		{
			get
			{
				short num = (short)311759867;
				short num2 = num;
				num = (short)1323176955;
				switch (num2 == num)
				{
				}
				num = (short)1981480960;
				short num3 = num;
				num = (short)1761083392;
				if (num != 0)
				{
				}
				num = (short)884146177;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton14ZoneListProperty);
			}
			set
			{
				short num = (short)527559999;
				short num2 = num;
				num = (short)231075135;
				switch (num2 == num)
				{
				}
				num = (short)2293760;
				short num3 = num;
				num = (short)1842806785;
				if (num != 0)
				{
				}
				num = (short)818544640;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14ZoneListProperty, value);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00022318 File Offset: 0x00020518
		// (set) Token: 0x060002CB RID: 715 RVA: 0x000223D8 File Offset: 0x000205D8
		public bool DEKButton14ChannelIsAcpValid
		{
			get
			{
				short num = (short)219128211;
				short num2 = num;
				num = (short)105161107;
				switch (num2 == num)
				{
				}
				num = (short)356450304;
				short num3 = num;
				num = (short)1553072129;
				if (num != 0)
				{
				}
				num = (short)1670381568;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)1631236342;
				short num2 = num;
				num = (short)98742518;
				switch (num2 == num)
				{
				}
				num = (short)1714618368;
				short num3 = num;
				num = (short)1772486656;
				if (num != 0)
				{
				}
				num = (short)1111359489;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00022494 File Offset: 0x00020694
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00022548 File Offset: 0x00020748
		public bool DEKButton14ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)105089979;
				short num2 = num;
				num = (short)1336052667;
				switch (num2 == num)
				{
				}
				num = (short)1725628416;
				short num3 = num;
				num = (short)432078849;
				if (num != 0)
				{
				}
				num = (short)613023744;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)205650095;
				short num2 = num;
				num = (short)1451489455;
				switch (num2 == num)
				{
				}
				num = (short)779419648;
				short num3 = num;
				num = (short)925892609;
				if (num != 0)
				{
				}
				num = (short)582156288;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00022604 File Offset: 0x00020804
		// (set) Token: 0x060002CF RID: 719 RVA: 0x000226C0 File Offset: 0x000208C0
		public bool DEKButton14ChannelIsAcpVisible
		{
			get
			{
				short num = (short)165651958;
				short num2 = num;
				num = (short)1257809398;
				switch (num2 == num)
				{
				}
				num = (short)1581514752;
				short num3 = num;
				num = (short)25559041;
				if (num != 0)
				{
				}
				num = (short)693174272;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)569577960;
				short num2 = num;
				num = (short)385290728;
				switch (num2 == num)
				{
				}
				num = (short)1850277888;
				short num3 = num;
				num = (short)221511681;
				if (num != 0)
				{
				}
				num = (short)1079771136;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0002277C File Offset: 0x0002097C
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00022834 File Offset: 0x00020A34
		public bool DEKButton14ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1746029239;
				short num2 = num;
				num = (short)1930709687;
				switch (num2 == num)
				{
				}
				num = (short)317784064;
				short num3 = num;
				num = (short)936378368;
				if (num != 0)
				{
				}
				num = (short)1862926337;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton14ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1932196582;
				short num2 = num;
				num = (short)1550449382;
				switch (num2 == num)
				{
				}
				num = (short)494338048;
				short num3 = num;
				num = (short)1387724801;
				if (num != 0)
				{
				}
				num = (short)1376780288;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000228F0 File Offset: 0x00020AF0
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x000229AC File Offset: 0x00020BAC
		public string DEKButton14ChannelUIValue
		{
			get
			{
				short num = (short)1087023717;
				short num2 = num;
				num = (short)1028958821;
				switch (num2 == num)
				{
				}
				num = (short)1141309440;
				short num3 = num;
				num = (short)125632513;
				if (num != 0)
				{
				}
				num = (short)669122560;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton14ChannelUIValueProperty);
			}
			set
			{
				short num = (short)1160597332;
				short num2 = num;
				num = (short)458379092;
				switch (num2 == num)
				{
				}
				num = (short)927137792;
				short num3 = num;
				num = (short)1383530497;
				if (num != 0)
				{
				}
				num = (short)984678400;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14ChannelUIValueProperty, value);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00022A60 File Offset: 0x00020C60
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00022B1C File Offset: 0x00020D1C
		public AcpListField DEKButton14ChannelList
		{
			get
			{
				short num = (short)1455302716;
				short num2 = num;
				num = (short)1490298940;
				switch (num2 == num)
				{
				}
				num = (short)1478557696;
				short num3 = num;
				num = (short)1356201985;
				if (num != 0)
				{
				}
				num = (short)1805451264;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton14ChannelListProperty);
			}
			set
			{
				short num = (short)487969682;
				short num2 = num;
				num = (short)655348626;
				switch (num2 == num)
				{
				}
				num = (short)916717568;
				short num3 = num;
				num = (short)51773441;
				if (num != 0)
				{
				}
				num = (short)65011712;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton14ChannelListProperty, value);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00022BD0 File Offset: 0x00020DD0
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00022C8C File Offset: 0x00020E8C
		public bool DEKButton15FeatureIsAcpValid
		{
			get
			{
				short num = (short)597946338;
				short num2 = num;
				num = (short)726593506;
				switch (num2 == num)
				{
				}
				num = (short)166264832;
				short num3 = num;
				num = (short)732561408;
				if (num != 0)
				{
				}
				num = (short)9633793;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton15FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1087364461;
				short num2 = num;
				num = (short)1946672493;
				switch (num2 == num)
				{
				}
				num = (short)1880883200;
				short num3 = num;
				num = (short)2004221953;
				if (num != 0)
				{
				}
				num = (short)1084424192;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton15FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00022D44 File Offset: 0x00020F44
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00022DFC File Offset: 0x00020FFC
		public bool DEKButton15FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)851934407;
				short num2 = num;
				num = (short)2043772103;
				switch (num2 == num)
				{
				}
				num = (short)1544617984;
				short num3 = num;
				num = (short)1042153473;
				if (num != 0)
				{
				}
				num = (short)479264768;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton15FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1625352655;
				short num2 = num;
				num = (short)1592256975;
				switch (num2 == num)
				{
				}
				num = (short)1428488192;
				short num3 = num;
				num = (short)845021184;
				if (num != 0)
				{
				}
				num = (short)808714241;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton15FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00022EB8 File Offset: 0x000210B8
		// (set) Token: 0x060002DB RID: 731 RVA: 0x00022F74 File Offset: 0x00021174
		public bool DEKButton15FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1729422465;
				short num2 = num;
				num = (short)1214702721;
				switch (num2 == num)
				{
				}
				num = (short)2062680064;
				short num3 = num;
				num = (short)1508048897;
				if (num != 0)
				{
				}
				num = (short)1214251008;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton15FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)279680273;
				short num2 = num;
				num = (short)1661965585;
				switch (num2 == num)
				{
				}
				num = (short)1332609024;
				short num3 = num;
				num = (short)911736833;
				if (num != 0)
				{
				}
				num = (short)1556676608;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton15FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00023030 File Offset: 0x00021230
		// (set) Token: 0x060002DD RID: 733 RVA: 0x000230E8 File Offset: 0x000212E8
		public bool DEKButton15FeatureIsAcpEditable
		{
			get
			{
				short num = (short)608700668;
				short num2 = num;
				num = (short)1085737212;
				switch (num2 == num)
				{
				}
				num = (short)1821638656;
				short num3 = num;
				num = (short)1635057665;
				if (num != 0)
				{
				}
				num = (short)864485376;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton15FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)107821625;
				short num2 = num;
				num = (short)2091465273;
				switch (num2 == num)
				{
				}
				num = (short)1782317056;
				short num3 = num;
				num = (short)1402208256;
				if (num != 0)
				{
				}
				num = (short)1728184321;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton15FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060002DE RID: 734 RVA: 0x000231A4 File Offset: 0x000213A4
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0002325C File Offset: 0x0002145C
		public string DEKButton15FeatureUIValue
		{
			get
			{
				short num = (short)544643012;
				short num2 = num;
				num = (short)813864900;
				switch (num2 == num)
				{
				}
				num = (short)1789067264;
				short num3 = num;
				num = (short)682688513;
				if (num != 0)
				{
				}
				num = (short)1939013632;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton15FeatureUIValueProperty);
			}
			set
			{
				short num = (short)48734177;
				short num2 = num;
				num = (short)134782945;
				switch (num2 == num)
				{
				}
				num = (short)925892609;
				if (num != 0)
				{
				}
				num = (short)1428029440;
				if (num != 0)
				{
				}
				num = (short)791281664;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00023314 File Offset: 0x00021514
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x000233D0 File Offset: 0x000215D0
		public AcpListField DEKButton15FeatureList
		{
			get
			{
				short num = (short)1963911141;
				short num2 = num;
				num = (short)946857957;
				switch (num2 == num)
				{
				}
				num = (short)1765343233;
				if (num != 0)
				{
				}
				num = (short)1341849600;
				if (num != 0)
				{
				}
				num = (short)410583040;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton15FeatureListProperty);
			}
			set
			{
				short num = (short)471979003;
				short num2 = num;
				num = (short)147772411;
				switch (num2 == num)
				{
				}
				num = (short)357629953;
				if (num != 0)
				{
				}
				num = (short)556335104;
				if (num != 0)
				{
				}
				num = (short)1992753152;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15FeatureListProperty, value);
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00023488 File Offset: 0x00021688
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00023544 File Offset: 0x00021744
		public bool DEKButton15IndexIsAcpValid
		{
			get
			{
				short num = (short)1966185532;
				short num2 = num;
				num = (short)757570620;
				switch (num2 == num)
				{
				}
				num = (short)1133641729;
				if (num != 0)
				{
				}
				num = (short)1586102272;
				if (num != 0)
				{
				}
				num = (short)1274413056;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton15IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1086099827;
				short num2 = num;
				num = (short)1032163699;
				switch (num2 == num)
				{
				}
				num = (short)776536065;
				if (num != 0)
				{
				}
				num = (short)2089353216;
				if (num != 0)
				{
				}
				num = (short)365494272;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00023600 File Offset: 0x00021800
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x000236B8 File Offset: 0x000218B8
		public bool DEKButton15IndexIsAcpApplicable
		{
			get
			{
				short num = (short)259188621;
				short num2 = num;
				num = (short)1222633357;
				switch (num2 == num)
				{
				}
				num = (short)2007891968;
				if (num != 0)
				{
				}
				num = (short)2113011713;
				if (num != 0)
				{
				}
				num = (short)1952251904;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton15IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1448418068;
				short num2 = num;
				num = (short)1749162772;
				switch (num2 == num)
				{
				}
				num = (short)1258487809;
				if (num != 0)
				{
				}
				num = (short)871628800;
				if (num != 0)
				{
				}
				num = (short)881131520;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00023774 File Offset: 0x00021974
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x0002382C File Offset: 0x00021A2C
		public bool DEKButton15IndexIsAcpVisible
		{
			get
			{
				short num = (short)1125788323;
				short num2 = num;
				num = (short)1097738915;
				switch (num2 == num)
				{
				}
				num = (short)929562625;
				if (num != 0)
				{
				}
				num = (short)464912384;
				if (num != 0)
				{
				}
				num = (short)493092864;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton15IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1424515947;
				short num2 = num;
				num = (short)663905131;
				switch (num2 == num)
				{
				}
				num = (short)2030043137;
				if (num != 0)
				{
				}
				num = (short)666304512;
				if (num != 0)
				{
				}
				num = (short)1484718080;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x000238E4 File Offset: 0x00021AE4
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x000239A0 File Offset: 0x00021BA0
		public bool DEKButton15IndexIsAcpEditable
		{
			get
			{
				short num = (short)1551437220;
				short num2 = num;
				num = (short)160959908;
				switch (num2 == num)
				{
				}
				num = (short)1895104513;
				if (num != 0)
				{
				}
				num = (short)769720320;
				if (num != 0)
				{
				}
				num = (short)1013055488;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton15IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)113094435;
				short num2 = num;
				num = (short)750497571;
				switch (num2 == num)
				{
				}
				num = (short)556466177;
				if (num != 0)
				{
				}
				num = (short)782499840;
				if (num != 0)
				{
				}
				num = (short)88408064;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00023A5C File Offset: 0x00021C5C
		// (set) Token: 0x060002EB RID: 747 RVA: 0x00023B14 File Offset: 0x00021D14
		public string DEKButton15IndexUIValue
		{
			get
			{
				short num = (short)130875393;
				if (num != 0)
				{
				}
				num = (short)285508606;
				short num2 = num;
				num = (short)743867390;
				switch (num2 == num)
				{
				}
				num = (short)142606336;
				if (num != 0)
				{
				}
				num = (short)1834221568;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton15IndexUIValueProperty);
			}
			set
			{
				short num = (short)873113566;
				short num2 = num;
				num = (short)1399367646;
				switch (num2 == num)
				{
				}
				num = (short)239992833;
				if (num != 0)
				{
				}
				num = (short)1776877568;
				if (num != 0)
				{
				}
				num = (short)2059403264;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15IndexUIValueProperty, value);
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00023BCC File Offset: 0x00021DCC
		// (set) Token: 0x060002ED RID: 749 RVA: 0x00023C88 File Offset: 0x00021E88
		public AcpRangeField<int, int> DEKButton15IndexRange
		{
			get
			{
				short num = (short)519241729;
				if (num != 0)
				{
				}
				num = (short)1253849302;
				short num2 = num;
				num = (short)1264072918;
				switch (num2 == num)
				{
				}
				num = (short)1899102208;
				if (num != 0)
				{
				}
				num = (short)1396768768;
				short num3 = num;
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton15IndexRangeProperty);
			}
			set
			{
				short num = (short)876609537;
				if (num != 0)
				{
				}
				num = (short)1253608805;
				short num2 = num;
				num = (short)886869349;
				switch (num2 == num)
				{
				}
				num = (short)240451584;
				if (num != 0)
				{
				}
				num = (short)1525874688;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15IndexRangeProperty, value);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00023D3C File Offset: 0x00021F3C
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00023DF4 File Offset: 0x00021FF4
		public bool DEKButton15ZoneIsAcpValid
		{
			get
			{
				short num = (short)961449928;
				short num2 = num;
				num = (short)94015432;
				switch (num2 == num)
				{
				}
				num = (short)1516240897;
				if (num != 0)
				{
				}
				num = (short)1489764352;
				if (num != 0)
				{
				}
				num = (short)1673527296;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton15ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)2049701624;
				short num2 = num;
				num = (short)1047787256;
				switch (num2 == num)
				{
				}
				num = (short)1530200065;
				if (num != 0)
				{
				}
				num = (short)1716912128;
				if (num != 0)
				{
				}
				num = (short)1334181888;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00023EB0 File Offset: 0x000220B0
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00023F68 File Offset: 0x00022168
		public bool DEKButton15ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)15299292;
				short num2 = num;
				num = (short)1669493468;
				switch (num2 == num)
				{
				}
				num = (short)82378753;
				if (num != 0)
				{
				}
				num = (short)1256718336;
				if (num != 0)
				{
				}
				num = (short)163250176;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton15ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1963393025;
				if (num != 0)
				{
				}
				num = (short)208531259;
				short num2 = num;
				num = (short)193457979;
				switch (num2 == num)
				{
				}
				num = (short)475332608;
				if (num != 0)
				{
				}
				num = (short)906887168;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00024024 File Offset: 0x00022224
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x000240DC File Offset: 0x000222DC
		public bool DEKButton15ZoneIsAcpVisible
		{
			get
			{
				short num = (short)2044903844;
				short num2 = num;
				num = (short)649118116;
				switch (num2 == num)
				{
				}
				num = (short)522387456;
				if (num != 0)
				{
				}
				num = (short)1870528513;
				if (num != 0)
				{
				}
				num = (short)622002176;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton15ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)901120001;
				if (num != 0)
				{
				}
				num = (short)1366783514;
				short num2 = num;
				num = (short)967865882;
				switch (num2 == num)
				{
				}
				num = (short)821428224;
				if (num != 0)
				{
				}
				num = (short)1217003520;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00024198 File Offset: 0x00022398
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00024258 File Offset: 0x00022458
		public bool DEKButton15ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1807978256;
				short num2 = num;
				num = (short)1332121360;
				switch (num2 == num)
				{
				}
				num = (short)1018560513;
				if (num != 0)
				{
				}
				num = (short)906362880;
				if (num != 0)
				{
				}
				num = (short)2045968384;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton15ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)809167642;
				short num2 = num;
				num = (short)267578138;
				switch (num2 == num)
				{
				}
				num = (short)1802502144;
				if (num != 0)
				{
				}
				num = (short)2140405761;
				if (num != 0)
				{
				}
				num = (short)2091122688;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00024310 File Offset: 0x00022510
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x000243CC File Offset: 0x000225CC
		public string DEKButton15ZoneUIValue
		{
			get
			{
				short num = (short)1756484397;
				short num2 = num;
				num = (short)1373098797;
				switch (num2 == num)
				{
				}
				num = (short)1212940288;
				if (num != 0)
				{
				}
				num = (short)2051407873;
				if (num != 0)
				{
				}
				num = (short)523501568;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton15ZoneUIValueProperty);
			}
			set
			{
				short num = (short)210088789;
				short num2 = num;
				num = (short)635351893;
				switch (num2 == num)
				{
				}
				num = (short)1154809856;
				if (num != 0)
				{
				}
				num = (short)2099249153;
				if (num != 0)
				{
				}
				num = (short)238944256;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15ZoneUIValueProperty, value);
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00024484 File Offset: 0x00022684
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x0002453C File Offset: 0x0002273C
		public AcpListField DEKButton15ZoneList
		{
			get
			{
				short num = (short)920807144;
				short num2 = num;
				num = (short)2088134376;
				switch (num2 == num)
				{
				}
				num = (short)2055143425;
				if (num != 0)
				{
				}
				num = (short)1639448576;
				if (num != 0)
				{
				}
				num = (short)117374976;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton15ZoneListProperty);
			}
			set
			{
				short num = (short)291635201;
				if (num != 0)
				{
				}
				num = (short)2065109571;
				short num2 = num;
				num = (short)858198595;
				switch (num2 == num)
				{
				}
				num = (short)957939712;
				if (num != 0)
				{
				}
				num = (short)929890304;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15ZoneListProperty, value);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060002FA RID: 762 RVA: 0x000245F0 File Offset: 0x000227F0
		// (set) Token: 0x060002FB RID: 763 RVA: 0x000246A8 File Offset: 0x000228A8
		public bool DEKButton15ChannelIsAcpValid
		{
			get
			{
				short num = (short)2046805653;
				short num2 = num;
				num = (short)24364693;
				switch (num2 == num)
				{
				}
				num = (short)2110717953;
				if (num != 0)
				{
				}
				num = (short)1285160960;
				if (num != 0)
				{
				}
				num = (short)217841664;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton15ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)1437128223;
				short num2 = num;
				num = (short)321836575;
				switch (num2 == num)
				{
				}
				num = (short)791805953;
				if (num != 0)
				{
				}
				num = (short)34144256;
				if (num != 0)
				{
				}
				num = (short)170459136;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00024760 File Offset: 0x00022960
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00024818 File Offset: 0x00022A18
		public bool DEKButton15ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)564133889;
				if (num != 0)
				{
				}
				num = (short)1165822562;
				short num2 = num;
				num = (short)380045922;
				switch (num2 == num)
				{
				}
				num = (short)385024000;
				if (num != 0)
				{
				}
				num = (short)1469710336;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton15ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2004713964;
				short num2 = num;
				num = (short)6849004;
				switch (num2 == num)
				{
				}
				num = (short)82640897;
				if (num != 0)
				{
				}
				num = (short)757989376;
				if (num != 0)
				{
				}
				num = (short)828047360;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060002FE RID: 766 RVA: 0x000248D0 File Offset: 0x00022AD0
		// (set) Token: 0x060002FF RID: 767 RVA: 0x0002498C File Offset: 0x00022B8C
		public bool DEKButton15ChannelIsAcpVisible
		{
			get
			{
				short num = (short)1212328382;
				short num2 = num;
				num = (short)1431284158;
				switch (num2 == num)
				{
				}
				num = (short)1254359041;
				if (num != 0)
				{
				}
				num = (short)815202304;
				if (num != 0)
				{
				}
				num = (short)648347648;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton15ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)453630401;
				short num2 = num;
				num = (short)1841289665;
				switch (num2 == num)
				{
				}
				num = (short)329056257;
				if (num != 0)
				{
				}
				num = (short)683016192;
				if (num != 0)
				{
				}
				num = (short)1184301056;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00024A44 File Offset: 0x00022C44
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00024AFC File Offset: 0x00022CFC
		public bool DEKButton15ChannelIsAcpEditable
		{
			get
			{
				short num = (short)365625345;
				if (num != 0)
				{
				}
				num = (short)153113979;
				short num2 = num;
				num = (short)2060932475;
				switch (num2 == num)
				{
				}
				num = (short)1631911936;
				if (num != 0)
				{
				}
				num = (short)1713700864;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton15ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1740702129;
				short num2 = num;
				num = (short)1416495537;
				switch (num2 == num)
				{
				}
				num = (short)1651441664;
				if (num != 0)
				{
				}
				num = (short)2088566785;
				if (num != 0)
				{
				}
				num = (short)1856372736;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00024BB8 File Offset: 0x00022DB8
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00024C70 File Offset: 0x00022E70
		public string DEKButton15ChannelUIValue
		{
			get
			{
				short num = (short)1915603216;
				short num2 = num;
				num = (short)78235920;
				switch (num2 == num)
				{
				}
				num = (short)1109458945;
				if (num != 0)
				{
				}
				num = (short)74252288;
				if (num != 0)
				{
				}
				num = (short)1431764992;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton15ChannelUIValueProperty);
			}
			set
			{
				short num = (short)1861269439;
				short num2 = num;
				num = (short)1445377983;
				switch (num2 == num)
				{
				}
				num = (short)1534394368;
				if (num != 0)
				{
				}
				num = (short)1979187201;
				if (num != 0)
				{
				}
				num = (short)317652992;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15ChannelUIValueProperty, value);
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00024D28 File Offset: 0x00022F28
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00024DE4 File Offset: 0x00022FE4
		public AcpListField DEKButton15ChannelList
		{
			get
			{
				short num = (short)844586098;
				short num2 = num;
				num = (short)322198642;
				switch (num2 == num)
				{
				}
				num = (short)65404929;
				if (num != 0)
				{
				}
				num = (short)877395968;
				if (num != 0)
				{
				}
				num = (short)1814495232;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton15ChannelListProperty);
			}
			set
			{
				short num = (short)261428355;
				short num2 = num;
				num = (short)344986755;
				switch (num2 == num)
				{
				}
				num = (short)124846081;
				if (num != 0)
				{
				}
				num = (short)779026432;
				if (num != 0)
				{
				}
				num = (short)15204352;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton15ChannelListProperty, value);
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00024E98 File Offset: 0x00023098
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00024F54 File Offset: 0x00023154
		public bool DEKButton16FeatureIsAcpValid
		{
			get
			{
				short num = (short)1310337627;
				short num2 = num;
				num = (short)810429019;
				switch (num2 == num)
				{
				}
				num = (short)1121845249;
				if (num != 0)
				{
				}
				num = (short)577241088;
				if (num != 0)
				{
				}
				num = (short)241303552;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton16FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1048588195;
				short num2 = num;
				num = (short)1359097763;
				switch (num2 == num)
				{
				}
				num = (short)1661730817;
				if (num != 0)
				{
				}
				num = (short)387907584;
				if (num != 0)
				{
				}
				num = (short)1320681472;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00025010 File Offset: 0x00023210
		// (set) Token: 0x06000309 RID: 777 RVA: 0x000250CC File Offset: 0x000232CC
		public bool DEKButton16FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1168363586;
				short num2 = num;
				num = (short)1950273602;
				switch (num2 == num)
				{
				}
				num = (short)1224802304;
				if (num != 0)
				{
				}
				num = (short)1991376897;
				if (num != 0)
				{
				}
				num = (short)952631296;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton16FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)902496257;
				if (num != 0)
				{
				}
				num = (short)360072953;
				short num2 = num;
				num = (short)366167801;
				switch (num2 == num)
				{
				}
				num = (short)1217003520;
				if (num != 0)
				{
				}
				num = (short)1036517376;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00025184 File Offset: 0x00023384
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00025240 File Offset: 0x00023440
		public bool DEKButton16FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1754267649;
				if (num != 0)
				{
				}
				num = (short)1455243695;
				short num2 = num;
				num = (short)576209327;
				switch (num2 == num)
				{
				}
				num = (short)98500608;
				if (num != 0)
				{
				}
				num = (short)969342976;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton16FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)70647809;
				if (num != 0)
				{
				}
				num = (short)1480227096;
				short num2 = num;
				num = (short)426146072;
				switch (num2 == num)
				{
				}
				num = (short)1668218880;
				if (num != 0)
				{
				}
				num = (short)2102132736;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000252FC File Offset: 0x000234FC
		// (set) Token: 0x0600030D RID: 781 RVA: 0x000253B8 File Offset: 0x000235B8
		public bool DEKButton16FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1227837331;
				short num2 = num;
				num = (short)1149390739;
				switch (num2 == num)
				{
				}
				num = (short)224264193;
				if (num != 0)
				{
				}
				num = (short)1482424320;
				if (num != 0)
				{
				}
				num = (short)95354880;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton16FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1037518851;
				short num2 = num;
				num = (short)1114458115;
				switch (num2 == num)
				{
				}
				num = (short)747896833;
				if (num != 0)
				{
				}
				num = (short)860487680;
				if (num != 0)
				{
				}
				num = (short)260374528;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00025474 File Offset: 0x00023674
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00025530 File Offset: 0x00023730
		public string DEKButton16FeatureUIValue
		{
			get
			{
				short num = (short)1204528278;
				short num2 = num;
				num = (short)794928278;
				switch (num2 == num)
				{
				}
				num = (short)1609236481;
				if (num != 0)
				{
				}
				num = (short)811401216;
				if (num != 0)
				{
				}
				num = (short)1070399488;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton16FeatureUIValueProperty);
			}
			set
			{
				short num = (short)322957154;
				short num2 = num;
				num = (short)731115362;
				switch (num2 == num)
				{
				}
				num = (short)60751873;
				if (num != 0)
				{
				}
				num = (short)2088173568;
				if (num != 0)
				{
				}
				num = (short)1600585728;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000255E8 File Offset: 0x000237E8
		// (set) Token: 0x06000311 RID: 785 RVA: 0x000256A4 File Offset: 0x000238A4
		public AcpListField DEKButton16FeatureList
		{
			get
			{
				short num = (short)892230150;
				short num2 = num;
				num = (short)1250777606;
				switch (num2 == num)
				{
				}
				num = (short)346030081;
				if (num != 0)
				{
				}
				num = (short)736886784;
				if (num != 0)
				{
				}
				num = (short)895352832;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton16FeatureListProperty);
			}
			set
			{
				short num = (short)930349057;
				if (num != 0)
				{
				}
				num = (short)1333718409;
				short num2 = num;
				num = (short)1274408329;
				switch (num2 == num)
				{
				}
				num = (short)368836608;
				if (num != 0)
				{
				}
				num = (short)898170880;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16FeatureListProperty, value);
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0002575C File Offset: 0x0002395C
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00025818 File Offset: 0x00023A18
		public bool DEKButton16IndexIsAcpValid
		{
			get
			{
				short num = (short)682426369;
				if (num != 0)
				{
				}
				num = (short)628302388;
				short num2 = num;
				num = (short)1888428596;
				switch (num2 == num)
				{
				}
				num = (short)1897267200;
				if (num != 0)
				{
				}
				num = (short)769458176;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton16IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)891754945;
				short num2 = num;
				num = (short)175380929;
				switch (num2 == num)
				{
				}
				num = (short)1812922369;
				if (num != 0)
				{
				}
				num = (short)1367212032;
				if (num != 0)
				{
				}
				num = (short)600309760;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000314 RID: 788 RVA: 0x000258D4 File Offset: 0x00023AD4
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00025990 File Offset: 0x00023B90
		public bool DEKButton16IndexIsAcpApplicable
		{
			get
			{
				short num = (short)152926356;
				short num2 = num;
				num = (short)35027092;
				switch (num2 == num)
				{
				}
				num = (short)1182597120;
				if (num != 0)
				{
				}
				num = (short)414973953;
				if (num != 0)
				{
				}
				num = (short)793247744;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton16IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1836786090;
				short num2 = num;
				num = (short)821895594;
				switch (num2 == num)
				{
				}
				num = (short)381419521;
				if (num != 0)
				{
				}
				num = (short)1232601088;
				if (num != 0)
				{
				}
				num = (short)1665007616;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00025A48 File Offset: 0x00023C48
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00025B04 File Offset: 0x00023D04
		public bool DEKButton16IndexIsAcpVisible
		{
			get
			{
				short num = (short)2084962305;
				if (num != 0)
				{
				}
				num = (short)1765609681;
				short num2 = num;
				num = (short)1639518417;
				switch (num2 == num)
				{
				}
				num = (short)1076756480;
				if (num != 0)
				{
				}
				num = (short)954138624;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton16IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1779563722;
				short num2 = num;
				num = (short)358808778;
				switch (num2 == num)
				{
				}
				num = (short)1260388353;
				if (num != 0)
				{
				}
				num = (short)2000748544;
				if (num != 0)
				{
				}
				num = (short)818348032;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00025BC0 File Offset: 0x00023DC0
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00025C7C File Offset: 0x00023E7C
		public bool DEKButton16IndexIsAcpEditable
		{
			get
			{
				short num = (short)1555955918;
				short num2 = num;
				num = (short)1529479374;
				switch (num2 == num)
				{
				}
				num = (short)1668612097;
				if (num != 0)
				{
				}
				num = (short)1161494528;
				if (num != 0)
				{
				}
				num = (short)876347392;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton16IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)348317926;
				short num2 = num;
				num = (short)468183270;
				switch (num2 == num)
				{
				}
				num = (short)1866792961;
				if (num != 0)
				{
				}
				num = (short)136249344;
				if (num != 0)
				{
				}
				num = (short)244842496;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00025D34 File Offset: 0x00023F34
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00025DF0 File Offset: 0x00023FF0
		public string DEKButton16IndexUIValue
		{
			get
			{
				short num = (short)402401930;
				short num2 = num;
				num = (short)765864586;
				switch (num2 == num)
				{
				}
				num = (short)797507584;
				if (num != 0)
				{
				}
				num = (short)1663565825;
				if (num != 0)
				{
				}
				num = (short)1746403328;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton16IndexUIValueProperty);
			}
			set
			{
				short num = (short)861853002;
				short num2 = num;
				num = (short)586929482;
				switch (num2 == num)
				{
				}
				num = (short)1364918272;
				if (num != 0)
				{
				}
				num = (short)1768947713;
				if (num != 0)
				{
				}
				num = (short)467140608;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16IndexUIValueProperty, value);
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00025EA4 File Offset: 0x000240A4
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00025F60 File Offset: 0x00024160
		public AcpRangeField<int, int> DEKButton16IndexRange
		{
			get
			{
				short num = (short)1254227969;
				if (num != 0)
				{
				}
				num = (short)1815696511;
				short num2 = num;
				num = (short)2074367103;
				switch (num2 == num)
				{
				}
				num = (short)356515840;
				if (num != 0)
				{
				}
				num = (short)1595342848;
				short num3 = num;
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton16IndexRangeProperty);
			}
			set
			{
				short num = (short)806092801;
				if (num != 0)
				{
				}
				num = (short)1920750723;
				short num2 = num;
				num = (short)1794659459;
				switch (num2 == num)
				{
				}
				num = (short)382402560;
				if (num != 0)
				{
				}
				num = (short)974061568;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16IndexRangeProperty, value);
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00026018 File Offset: 0x00024218
		// (set) Token: 0x0600031F RID: 799 RVA: 0x000260D0 File Offset: 0x000242D0
		public bool DEKButton16ZoneIsAcpValid
		{
			get
			{
				short num = (short)1937178625;
				if (num != 0)
				{
				}
				num = (short)381573384;
				short num2 = num;
				num = (short)1932417288;
				switch (num2 == num)
				{
				}
				num = (short)1427111936;
				if (num != 0)
				{
				}
				num = (short)1043267584;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton16ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)1102249985;
				if (num != 0)
				{
				}
				num = (short)1858177976;
				short num2 = num;
				num = (short)1287293880;
				switch (num2 == num)
				{
				}
				num = (short)1871249408;
				if (num != 0)
				{
				}
				num = (short)1443430400;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0002618C File Offset: 0x0002438C
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00026248 File Offset: 0x00024448
		public bool DEKButton16ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)1659568129;
				if (num != 0)
				{
				}
				num = (short)650315109;
				short num2 = num;
				num = (short)1800209765;
				switch (num2 == num)
				{
				}
				num = (short)1647312896;
				if (num != 0)
				{
				}
				num = (short)1930952704;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton16ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1097312828;
				short num2 = num;
				num = (short)1600694844;
				switch (num2 == num)
				{
				}
				num = (short)843972608;
				if (num != 0)
				{
				}
				num = (short)1498546177;
				if (num != 0)
				{
				}
				num = (short)1593442304;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00026300 File Offset: 0x00024500
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000263B8 File Offset: 0x000245B8
		public bool DEKButton16ZoneIsAcpVisible
		{
			get
			{
				short num = (short)992760419;
				short num2 = num;
				num = (short)1009865315;
				switch (num2 == num)
				{
				}
				num = (short)448790529;
				if (num != 0)
				{
				}
				num = (short)860487680;
				if (num != 0)
				{
				}
				num = (short)1486684160;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton16ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1899116325;
				short num2 = num;
				num = (short)517289765;
				switch (num2 == num)
				{
				}
				num = (short)926613505;
				if (num != 0)
				{
				}
				num = (short)258998272;
				if (num != 0)
				{
				}
				num = (short)1966276608;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00026474 File Offset: 0x00024674
		// (set) Token: 0x06000325 RID: 805 RVA: 0x0002652C File Offset: 0x0002472C
		public bool DEKButton16ZoneIsAcpEditable
		{
			get
			{
				short num = (short)45925460;
				short num2 = num;
				num = (short)36553812;
				switch (num2 == num)
				{
				}
				num = (short)1584857089;
				if (num != 0)
				{
				}
				num = (short)336855040;
				if (num != 0)
				{
				}
				num = (short)644546560;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton16ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1763432457;
				short num2 = num;
				num = (short)1115084809;
				switch (num2 == num)
				{
				}
				num = (short)1279852545;
				if (num != 0)
				{
				}
				num = (short)1361313792;
				if (num != 0)
				{
				}
				num = (short)1220608000;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000326 RID: 806 RVA: 0x000265E4 File Offset: 0x000247E4
		// (set) Token: 0x06000327 RID: 807 RVA: 0x0002669C File Offset: 0x0002489C
		public string DEKButton16ZoneUIValue
		{
			get
			{
				short num = (short)506986497;
				if (num != 0)
				{
				}
				num = (short)436247173;
				short num2 = num;
				num = (short)1602525829;
				switch (num2 == num)
				{
				}
				num = (short)115671040;
				if (num != 0)
				{
				}
				num = (short)1098776576;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton16ZoneUIValueProperty);
			}
			set
			{
				short num = (short)1867472473;
				short num2 = num;
				num = (short)1532452441;
				switch (num2 == num)
				{
				}
				num = (short)1588592641;
				if (num != 0)
				{
				}
				num = (short)50593792;
				if (num != 0)
				{
				}
				num = (short)2085355520;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton16ZoneUIValueProperty, value);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00026750 File Offset: 0x00024950
		// (set) Token: 0x06000329 RID: 809 RVA: 0x0002680C File Offset: 0x00024A0C
		public AcpListField DEKButton16ZoneList
		{
			get
			{
				short num = (short)358335712;
				short num2 = num;
				num = (short)856212704;
				switch (num2 == num)
				{
				}
				num = (short)566427649;
				if (num != 0)
				{
				}
				num = (short)1104936960;
				if (num != 0)
				{
				}
				num = (short)1984364544;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton16ZoneListProperty);
			}
			set
			{
				short num = (short)1283101184;
				short num2 = num;
				num = (short)1873252864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2010316800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1195180033;
				if (num != 0)
				{
				}
				num = (short)1964900352;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton16ZoneListProperty, value);
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600032A RID: 810 RVA: 0x000268C0 File Offset: 0x00024AC0
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0002697C File Offset: 0x00024B7C
		public bool DEKButton16ChannelIsAcpValid
		{
			get
			{
				short num = (short)1482663383;
				short num2 = num;
				num = (short)1991681495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1351483392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)826277889;
				if (num != 0)
				{
				}
				num = (short)1026621440;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton16ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)463161366;
				short num2 = num;
				num = (short)1834174486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1763442688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)78315521;
				if (num != 0)
				{
				}
				num = (short)125501440;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton16ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00026A34 File Offset: 0x00024C34
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00026AF0 File Offset: 0x00024CF0
		public bool DEKButton16ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)640330091;
				short num2 = num;
				num = (short)1714399595;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1144061952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)34603008;
				if (num != 0)
				{
				}
				num = (short)366870529;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton16ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)199449109;
				short num2 = num;
				num = (short)864770581;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1027080192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2138832896;
				if (num != 0)
				{
				}
				num = (short)1170669569;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton16ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00026BAC File Offset: 0x00024DAC
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00026C68 File Offset: 0x00024E68
		public bool DEKButton16ChannelIsAcpVisible
		{
			get
			{
				short num = (short)1235248066;
				short num2 = num;
				num = (short)192308162;
				switch (num2 == num)
				{
				default:
				{
					num = (short)501678080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1463287809;
				if (num != 0)
				{
				}
				num = (short)1787625472;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton16ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1030758117;
				short num2 = num;
				num = (short)1274552037;
				switch (num2 == num)
				{
				default:
				{
					num = (short)300220416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)676528129;
				if (num != 0)
				{
				}
				num = (short)1525678080;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton16ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00026D24 File Offset: 0x00024F24
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00026DDC File Offset: 0x00024FDC
		public bool DEKButton16ChannelIsAcpEditable
		{
			get
			{
				short num = (short)49507756;
				short num2 = num;
				num = (short)293498284;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2105278464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)461963265;
				if (num != 0)
				{
				}
				num = (short)1647837184;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton16ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)232314674;
				short num2 = num;
				num = (short)1622464306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1305083904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1416036352;
				if (num != 0)
				{
				}
				num = (short)1496711169;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton16ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00026E98 File Offset: 0x00025098
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00026F50 File Offset: 0x00025150
		public string DEKButton16ChannelUIValue
		{
			get
			{
				short num = (short)903707672;
				short num2 = num;
				num = (short)753368088;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2113273856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2131230721;
				if (num != 0)
				{
				}
				num = (short)1091764224;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton16ChannelUIValueProperty);
			}
			set
			{
				short num = (short)1988165633;
				if (num != 0)
				{
				}
				num = (short)243204096;
				short num2 = num;
				num = (short)380116185;
				short num3 = num;
				num = (short)1868176601;
				switch (num3 == num)
				{
				}
				num = (short)2056323072;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton16ChannelUIValueProperty, value);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00027004 File Offset: 0x00025204
		// (set) Token: 0x06000335 RID: 821 RVA: 0x000270BC File Offset: 0x000252BC
		public AcpListField DEKButton16ChannelList
		{
			get
			{
				short num = (short)1312645047;
				short num2 = num;
				num = (short)601513911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1232928768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1514668033;
				if (num != 0)
				{
				}
				num = (short)1496973312;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton16ChannelListProperty);
			}
			set
			{
				short num = (short)643403772;
				short num2 = num;
				num = (short)1126273020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)921239552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1330708481;
				if (num != 0)
				{
				}
				num = (short)1613824000;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton16ChannelListProperty, value);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00027170 File Offset: 0x00025370
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00027228 File Offset: 0x00025428
		public bool DEKButton17FeatureIsAcpValid
		{
			get
			{
				short num = (short)589848877;
				short num2 = num;
				num = (short)594305325;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1462304768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1232535553;
				if (num != 0)
				{
				}
				num = (short)405340160;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)567227345;
				short num2 = num;
				num = (short)493171665;
				switch (num2 == num)
				{
				default:
				{
					num = (short)664338432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1680801793;
				if (num != 0)
				{
				}
				num = (short)144965632;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000338 RID: 824 RVA: 0x000272E4 File Offset: 0x000254E4
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0002739C File Offset: 0x0002559C
		public bool DEKButton17FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1476063456;
				short num2 = num;
				num = (short)1341976800;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1227948032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1433337856;
				if (num != 0)
				{
				}
				num = (short)2041577473;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1468923905;
				if (num != 0)
				{
				}
				num = (short)568655872;
				short num2 = num;
				num = (short)1550175301;
				short num3 = num;
				num = (short)415616069;
				switch (num3 == num)
				{
				}
				num = (short)500563968;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00027458 File Offset: 0x00025658
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00027514 File Offset: 0x00025714
		public bool DEKButton17FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1159837424;
				short num2 = num;
				num = (short)1082701552;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1625882624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1044709377;
				if (num != 0)
				{
				}
				num = (short)1918828544;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1653604353;
				if (num != 0)
				{
				}
				num = (short)778240000;
				short num2 = num;
				num = (short)2116842380;
				short num3 = num;
				num = (short)1525117836;
				switch (num3 == num)
				{
				}
				num = (short)834273280;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600033C RID: 828 RVA: 0x000275CC File Offset: 0x000257CC
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00027684 File Offset: 0x00025884
		public bool DEKButton17FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1687480824;
				short num2 = num;
				num = (short)215214584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1488912384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)67043329;
				if (num != 0)
				{
				}
				num = (short)1145962496;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)147936528;
				short num2 = num;
				num = (short)1473402128;
				switch (num2 == num)
				{
				default:
				{
					num = (short)26935296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)914489345;
				if (num != 0)
				{
				}
				num = (short)1467613184;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00027740 File Offset: 0x00025940
		// (set) Token: 0x0600033F RID: 831 RVA: 0x000277F8 File Offset: 0x000259F8
		public string DEKButton17FeatureUIValue
		{
			get
			{
				short num = (short)1800461092;
				short num2 = num;
				num = (short)143907620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1571815424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1630732289;
				if (num != 0)
				{
				}
				num = (short)1804861440;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton17FeatureUIValueProperty);
			}
			set
			{
				short num = (short)399735742;
				short num2 = num;
				num = (short)162560958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1825439744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1430388736;
				if (num != 0)
				{
				}
				num = (short)1858011137;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17FeatureUIValueProperty, value);
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000340 RID: 832 RVA: 0x000278AC File Offset: 0x00025AAC
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00027964 File Offset: 0x00025B64
		public AcpListField DEKButton17FeatureList
		{
			get
			{
				short num = (short)1408172033;
				if (num != 0)
				{
				}
				num = (short)981401600;
				short num2 = num;
				num = (short)1297739249;
				short num3 = num;
				num = (short)364768753;
				switch (num3 == num)
				{
				}
				num = (short)783613952;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton17FeatureListProperty);
			}
			set
			{
				short num = (short)1518862337;
				if (num != 0)
				{
				}
				num = (short)165675008;
				short num2 = num;
				num = (short)1549055478;
				short num3 = num;
				num = (short)1473099254;
				switch (num3 == num)
				{
				}
				num = (short)1537015808;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17FeatureListProperty, value);
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00027A18 File Offset: 0x00025C18
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00027AD0 File Offset: 0x00025CD0
		public bool DEKButton17IndexIsAcpValid
		{
			get
			{
				short num = (short)685375489;
				if (num != 0)
				{
				}
				num = (short)1698299904;
				short num2 = num;
				num = (short)1055159218;
				short num3 = num;
				num = (short)311915442;
				switch (num3 == num)
				{
				}
				num = (short)34799616;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1593025879;
				short num2 = num;
				num = (short)1727767895;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1620115456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1209466881;
				if (num != 0)
				{
				}
				num = (short)1410007040;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00027B8C File Offset: 0x00025D8C
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00027C44 File Offset: 0x00025E44
		public bool DEKButton17IndexIsAcpApplicable
		{
			get
			{
				short num = (short)1319826848;
				short num2 = num;
				num = (short)1825699232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1463353344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)37552128;
				if (num != 0)
				{
				}
				num = (short)762118145;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1945595249;
				short num2 = num;
				num = (short)2098294129;
				switch (num2 == num)
				{
				default:
				{
					num = (short)48889856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1736638465;
				if (num != 0)
				{
				}
				num = (short)1443823616;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00027CFC File Offset: 0x00025EFC
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00027DB4 File Offset: 0x00025FB4
		public bool DEKButton17IndexIsAcpVisible
		{
			get
			{
				short num = (short)194652941;
				short num2 = num;
				num = (short)112470797;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2040135680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1754464256;
				if (num != 0)
				{
				}
				num = (short)1387397121;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)284459517;
				short num2 = num;
				num = (short)1393000957;
				switch (num2 == num)
				{
				default:
				{
					num = (short)704512000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)162070529;
				if (num != 0)
				{
				}
				num = (short)704249856;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00027E6C File Offset: 0x0002606C
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00027F24 File Offset: 0x00026124
		public bool DEKButton17IndexIsAcpEditable
		{
			get
			{
				short num = (short)773783553;
				if (num != 0)
				{
				}
				num = (short)1659109376;
				short num2 = num;
				num = (short)853758723;
				short num3 = num;
				num = (short)1895387907;
				switch (num3 == num)
				{
				}
				num = (short)1974992896;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2067776474;
				short num2 = num;
				num = (short)1176224730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1734475776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1829109760;
				if (num != 0)
				{
				}
				num = (short)1500053505;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00027FDC File Offset: 0x000261DC
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00028094 File Offset: 0x00026294
		public string DEKButton17IndexUIValue
		{
			get
			{
				short num = (short)1938554881;
				if (num != 0)
				{
				}
				num = (short)189530112;
				short num2 = num;
				num = (short)2001753313;
				short num3 = num;
				num = (short)788813025;
				switch (num3 == num)
				{
				}
				num = (short)554172416;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton17IndexUIValueProperty);
			}
			set
			{
				short num = (short)347989652;
				short num2 = num;
				num = (short)2145576596;
				switch (num2 == num)
				{
				default:
				{
					num = (short)565248000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)760610817;
				if (num != 0)
				{
				}
				num = (short)542834688;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17IndexUIValueProperty, value);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00028148 File Offset: 0x00026348
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00028200 File Offset: 0x00026400
		public AcpRangeField<int, int> DEKButton17IndexRange
		{
			get
			{
				short num = (short)1975024594;
				short num2 = num;
				num = (short)472546258;
				switch (num2 == num)
				{
				default:
				{
					num = (short)40370176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1208483841;
				if (num != 0)
				{
				}
				num = (short)644284416;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton17IndexRangeProperty);
			}
			set
			{
				short num = (short)1668663482;
				short num2 = num;
				num = (short)1275971770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1700462592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)202506240;
				if (num != 0)
				{
				}
				num = (short)1057816577;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17IndexRangeProperty, value);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600034E RID: 846 RVA: 0x000282B8 File Offset: 0x000264B8
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00028374 File Offset: 0x00026574
		public bool DEKButton17ZoneIsAcpValid
		{
			get
			{
				short num = (short)2022200159;
				short num2 = num;
				num = (short)1180193631;
				switch (num2 == num)
				{
				default:
				{
					num = (short)439877632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)527302657;
				if (num != 0)
				{
				}
				num = (short)607584256;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)499689145;
				short num2 = num;
				num = (short)259040953;
				switch (num2 == num)
				{
				default:
				{
					num = (short)766574592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)578355201;
				if (num != 0)
				{
				}
				num = (short)1591083008;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0002842C File Offset: 0x0002662C
		// (set) Token: 0x06000351 RID: 849 RVA: 0x000284E4 File Offset: 0x000266E4
		public bool DEKButton17ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)566723876;
				short num2 = num;
				num = (short)1129743652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1422000128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1273888768;
				if (num != 0)
				{
				}
				num = (short)1844379649;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1747913636;
				short num2 = num;
				num = (short)608897956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)289734656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)930545665;
				if (num != 0)
				{
				}
				num = (short)1428488192;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0002859C File Offset: 0x0002679C
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00028654 File Offset: 0x00026854
		public bool DEKButton17ZoneIsAcpVisible
		{
			get
			{
				short num = (short)146958237;
				short num2 = num;
				num = (short)2002675613;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1982464000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)604045313;
				if (num != 0)
				{
				}
				num = (short)1604648960;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1573748044;
				short num2 = num;
				num = (short)522616140;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1572208640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2126381057;
				if (num != 0)
				{
				}
				num = (short)503971840;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00028710 File Offset: 0x00026910
		// (set) Token: 0x06000355 RID: 853 RVA: 0x000287C8 File Offset: 0x000269C8
		public bool DEKButton17ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1162401898;
				short num2 = num;
				num = (short)946853994;
				switch (num2 == num)
				{
				default:
				{
					num = (short)690225152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1243217921;
				if (num != 0)
				{
				}
				num = (short)173277184;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)502792193;
				if (num != 0)
				{
				}
				num = (short)59113472;
				short num2 = num;
				num = (short)1563507758;
				short num3 = num;
				num = (short)1023884334;
				switch (num3 == num)
				{
				}
				num = (short)806551552;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00028884 File Offset: 0x00026A84
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0002893C File Offset: 0x00026B3C
		public string DEKButton17ZoneUIValue
		{
			get
			{
				short num = (short)1744055297;
				short num2 = num;
				num = (short)2109811713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1496252416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)305528832;
				if (num != 0)
				{
				}
				num = (short)1203896321;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton17ZoneUIValueProperty);
			}
			set
			{
				short num = (short)271349096;
				short num2 = num;
				num = (short)1182037352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2010841088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)232652801;
				if (num != 0)
				{
				}
				num = (short)1933770752;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17ZoneUIValueProperty, value);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000358 RID: 856 RVA: 0x000289F0 File Offset: 0x00026BF0
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00028AAC File Offset: 0x00026CAC
		public AcpListField DEKButton17ZoneList
		{
			get
			{
				short num = (short)342051087;
				short num2 = num;
				num = (short)1765493007;
				switch (num2 == num)
				{
				default:
				{
					num = (short)327942144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)673054721;
				if (num != 0)
				{
				}
				num = (short)2040659968;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton17ZoneListProperty);
			}
			set
			{
				short num = (short)1737629329;
				short num2 = num;
				num = (short)1796152977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1924071424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1039663104;
				if (num != 0)
				{
				}
				num = (short)1764294657;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17ZoneListProperty, value);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00028B64 File Offset: 0x00026D64
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00028C20 File Offset: 0x00026E20
		public bool DEKButton17ChannelIsAcpValid
		{
			get
			{
				short num = (short)1443972676;
				short num2 = num;
				num = (short)1024935492;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1626603520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1235746817;
				if (num != 0)
				{
				}
				num = (short)27262976;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)1242494990;
				short num2 = num;
				num = (short)1058666510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)480575488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)427556865;
				if (num != 0)
				{
				}
				num = (short)1728774144;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00028CD8 File Offset: 0x00026ED8
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00028D90 File Offset: 0x00026F90
		public bool DEKButton17ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)1408114968;
				short num2 = num;
				num = (short)2129404184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1468399616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1568866305;
				if (num != 0)
				{
				}
				num = (short)130547712;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)2063214329;
				short num2 = num;
				num = (short)221914873;
				switch (num2 == num)
				{
				default:
				{
					num = (short)220463104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)315752448;
				if (num != 0)
				{
				}
				num = (short)916520961;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00028E4C File Offset: 0x0002704C
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00028F08 File Offset: 0x00027108
		public bool DEKButton17ChannelIsAcpVisible
		{
			get
			{
				short num = (short)1286435937;
				short num2 = num;
				num = (short)1821013089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)604045312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1805910016;
				if (num != 0)
				{
				}
				num = (short)99221505;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1726414848;
				short num2 = num;
				num = (short)738750415;
				short num3 = num;
				num = (short)19689423;
				switch (num3 == num)
				{
				}
				num = (short)2128871424;
				if (num != 0)
				{
				}
				num = (short)206110721;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00028FC4 File Offset: 0x000271C4
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00029080 File Offset: 0x00027280
		public bool DEKButton17ChannelIsAcpEditable
		{
			get
			{
				short num = (short)843251712;
				short num2 = num;
				num = (short)1094039260;
				short num3 = num;
				num = (short)191608540;
				switch (num3 == num)
				{
				}
				num = (short)1416953857;
				if (num != 0)
				{
				}
				num = (short)746323968;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton17ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)604241920;
				short num2 = num;
				num = (short)952117785;
				short num3 = num;
				num = (short)935733785;
				switch (num3 == num)
				{
				}
				num = (short)1704067073;
				if (num != 0)
				{
				}
				num = (short)1475346432;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00029140 File Offset: 0x00027340
		// (set) Token: 0x06000363 RID: 867 RVA: 0x000291FC File Offset: 0x000273FC
		public string DEKButton17ChannelUIValue
		{
			get
			{
				short num = (short)1679949824;
				short num2 = num;
				num = (short)1828585473;
				if (num != 0)
				{
				}
				num = (short)324622885;
				short num3 = num;
				num = (short)1634490917;
				switch (num3 == num)
				{
				}
				num = (short)736952320;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton17ChannelUIValueProperty);
			}
			set
			{
				short num = (short)1348796416;
				short num2 = num;
				num = (short)549909364;
				short num3 = num;
				num = (short)1146418036;
				switch (num3 == num)
				{
				}
				num = (short)1172963328;
				if (num != 0)
				{
				}
				num = (short)1734934529;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17ChannelUIValueProperty, value);
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000364 RID: 868 RVA: 0x000292B4 File Offset: 0x000274B4
		// (set) Token: 0x06000365 RID: 869 RVA: 0x0002936C File Offset: 0x0002756C
		public AcpListField DEKButton17ChannelList
		{
			get
			{
				short num = (short)1453916160;
				short num2 = num;
				num = (short)1191503458;
				short num3 = num;
				num = (short)1425466978;
				switch (num3 == num)
				{
				}
				num = (short)345178112;
				if (num != 0)
				{
				}
				num = (short)17235969;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton17ChannelListProperty);
			}
			set
			{
				short num = (short)1802436608;
				short num2 = num;
				num = (short)1712242282;
				short num3 = num;
				num = (short)1331674730;
				switch (num3 == num)
				{
				}
				num = (short)2092892160;
				if (num != 0)
				{
				}
				num = (short)464388097;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton17ChannelListProperty, value);
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00029420 File Offset: 0x00027620
		// (set) Token: 0x06000367 RID: 871 RVA: 0x000294DC File Offset: 0x000276DC
		public bool DEKButton18FeatureIsAcpValid
		{
			get
			{
				short num = (short)575406080;
				short num2 = num;
				num = (short)12724549;
				short num3 = num;
				num = (short)81865029;
				switch (num3 == num)
				{
				}
				num = (short)1631191041;
				if (num != 0)
				{
				}
				num = (short)1644429312;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)2080178176;
				short num2 = num;
				num = (short)1012596795;
				short num3 = num;
				num = (short)270204987;
				switch (num3 == num)
				{
				}
				num = (short)1189609472;
				if (num != 0)
				{
				}
				num = (short)2101608449;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00029598 File Offset: 0x00027798
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00029654 File Offset: 0x00027854
		public bool DEKButton18FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)197853184;
				short num2 = num;
				num = (short)1235069989;
				short num3 = num;
				num = (short)632859685;
				switch (num3 == num)
				{
				}
				num = (short)548732929;
				if (num != 0)
				{
				}
				num = (short)848363520;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)314376192;
				short num2 = num;
				num = (short)496630299;
				short num3 = num;
				num = (short)342358555;
				switch (num3 == num)
				{
				}
				num = (short)1018560513;
				if (num != 0)
				{
				}
				num = (short)1430454272;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0002970C File Offset: 0x0002790C
		// (set) Token: 0x0600036B RID: 875 RVA: 0x000297C8 File Offset: 0x000279C8
		public bool DEKButton18FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1558249472;
				short num2 = num;
				num = (short)2106968534;
				short num3 = num;
				num = (short)266586582;
				switch (num3 == num)
				{
				}
				num = (short)197525504;
				if (num != 0)
				{
				}
				num = (short)379846657;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)701890560;
				short num2 = num;
				num = (short)291281884;
				short num3 = num;
				num = (short)1484102620;
				switch (num3 == num)
				{
				}
				num = (short)2138308609;
				if (num != 0)
				{
				}
				num = (short)171835392;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00029880 File Offset: 0x00027A80
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00029938 File Offset: 0x00027B38
		public bool DEKButton18FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1472724992;
				short num2 = num;
				num = (short)1703623451;
				short num3 = num;
				num = (short)1607678747;
				switch (num3 == num)
				{
				}
				num = (short)1388707841;
				if (num != 0)
				{
				}
				num = (short)1758134272;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1926889472;
				short num2 = num;
				num = (short)573046785;
				if (num != 0)
				{
				}
				num = (short)516127385;
				short num3 = num;
				num = (short)319715993;
				switch (num3 == num)
				{
				}
				num = (short)500432896;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600036E RID: 878 RVA: 0x000299F4 File Offset: 0x00027BF4
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00029AAC File Offset: 0x00027CAC
		public string DEKButton18FeatureUIValue
		{
			get
			{
				short num = (short)1562247168;
				short num2 = num;
				num = (short)1881454591;
				short num3 = num;
				num = (short)1443543039;
				switch (num3 == num)
				{
				}
				num = (short)524812289;
				if (num != 0)
				{
				}
				num = (short)646971392;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton18FeatureUIValueProperty);
			}
			set
			{
				short num = (short)500695040;
				short num2 = num;
				num = (short)473442341;
				short num3 = num;
				num = (short)275195941;
				switch (num3 == num)
				{
				}
				num = (short)1453195264;
				if (num != 0)
				{
				}
				num = (short)1056702465;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18FeatureUIValueProperty, value);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00029B64 File Offset: 0x00027D64
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00029C20 File Offset: 0x00027E20
		public AcpListField DEKButton18FeatureList
		{
			get
			{
				short num = (short)1999699968;
				short num2 = num;
				num = (short)9795814;
				short num3 = num;
				num = (short)1282898150;
				switch (num3 == num)
				{
				}
				num = (short)1605959681;
				if (num != 0)
				{
				}
				num = (short)622395392;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton18FeatureListProperty);
			}
			set
			{
				short num = (short)1166606336;
				short num2 = num;
				num = (short)273879095;
				short num3 = num;
				num = (short)1896681527;
				switch (num3 == num)
				{
				}
				num = (short)618528768;
				if (num != 0)
				{
				}
				num = (short)917831681;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18FeatureListProperty, value);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00029CD4 File Offset: 0x00027ED4
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00029D8C File Offset: 0x00027F8C
		public bool DEKButton18IndexIsAcpValid
		{
			get
			{
				short num = (short)225509376;
				short num2 = num;
				num = (short)1046474343;
				short num3 = num;
				num = (short)337702503;
				switch (num3 == num)
				{
				}
				num = (short)1760690177;
				if (num != 0)
				{
				}
				num = (short)1676738560;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)19922944;
				short num2 = num;
				num = (short)1265163859;
				short num3 = num;
				num = (short)1171971667;
				switch (num3 == num)
				{
				}
				num = (short)474087425;
				if (num != 0)
				{
				}
				num = (short)1985937408;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00029E48 File Offset: 0x00028048
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00029F00 File Offset: 0x00028100
		public bool DEKButton18IndexIsAcpApplicable
		{
			get
			{
				short num = (short)765067264;
				short num2 = num;
				num = (short)90701825;
				if (num != 0)
				{
				}
				num = (short)1045163379;
				short num3 = num;
				num = (short)1439886707;
				switch (num3 == num)
				{
				}
				num = (short)1564344320;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1388904448;
				short num2 = num;
				num = (short)1268908033;
				if (num != 0)
				{
				}
				num = (short)1972461016;
				short num3 = num;
				num = (short)1131699672;
				switch (num3 == num)
				{
				}
				num = (short)728694784;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00029FBC File Offset: 0x000281BC
		// (set) Token: 0x06000377 RID: 887 RVA: 0x0002A074 File Offset: 0x00028274
		public bool DEKButton18IndexIsAcpVisible
		{
			get
			{
				short num = (short)2140405760;
				short num2 = num;
				num = (short)956170241;
				if (num != 0)
				{
				}
				num = (short)1997841235;
				short num3 = num;
				num = (short)1625203539;
				switch (num3 == num)
				{
				}
				num = (short)649658368;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)844234752;
				short num2 = num;
				num = (short)411369473;
				if (num != 0)
				{
				}
				num = (short)1764012482;
				short num3 = num;
				num = (short)2047979970;
				switch (num3 == num)
				{
				}
				num = (short)1622540288;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0002A12C File Offset: 0x0002832C
		// (set) Token: 0x06000379 RID: 889 RVA: 0x0002A1E4 File Offset: 0x000283E4
		public bool DEKButton18IndexIsAcpEditable
		{
			get
			{
				short num = (short)50790400;
				short num2 = num;
				num = (short)661716993;
				if (num != 0)
				{
				}
				num = (short)827099637;
				short num3 = num;
				num = (short)3377653;
				switch (num3 == num)
				{
				}
				num = (short)1369112576;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2013331456;
				short num2 = num;
				num = (short)508755530;
				short num3 = num;
				num = (short)1696333386;
				switch (num3 == num)
				{
				}
				num = (short)1495728128;
				if (num != 0)
				{
				}
				num = (short)1299775489;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0002A29C File Offset: 0x0002849C
		// (set) Token: 0x0600037B RID: 891 RVA: 0x0002A358 File Offset: 0x00028558
		public string DEKButton18IndexUIValue
		{
			get
			{
				short num = (short)619773952;
				short num2 = num;
				num = (short)883317831;
				short num3 = num;
				num = (short)391208007;
				switch (num3 == num)
				{
				}
				num = (short)1948385280;
				if (num != 0)
				{
				}
				num = (short)1473052673;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton18IndexUIValueProperty);
			}
			set
			{
				short num = (short)1118896128;
				short num2 = num;
				num = (short)356581377;
				if (num != 0)
				{
				}
				num = (short)1032115982;
				short num3 = num;
				num = (short)1051514638;
				switch (num3 == num)
				{
				}
				num = (short)1708326912;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18IndexUIValueProperty, value);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0002A40C File Offset: 0x0002860C
		// (set) Token: 0x0600037D RID: 893 RVA: 0x0002A4C4 File Offset: 0x000286C4
		public AcpRangeField<int, int> DEKButton18IndexRange
		{
			get
			{
				short num = (short)162529280;
				short num2 = num;
				num = (short)1309615916;
				short num3 = num;
				num = (short)2123048748;
				switch (num3 == num)
				{
				}
				num = (short)1522401281;
				if (num != 0)
				{
				}
				num = (short)1956118528;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton18IndexRangeProperty);
			}
			set
			{
				short num = (short)1820524544;
				short num2 = num;
				num = (short)1805464319;
				short num3 = num;
				num = (short)1316762367;
				switch (num3 == num)
				{
				}
				num = (short)1392246785;
				if (num != 0)
				{
				}
				num = (short)1832910848;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18IndexRangeProperty, value);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0002A578 File Offset: 0x00028778
		// (set) Token: 0x0600037F RID: 895 RVA: 0x0002A630 File Offset: 0x00028830
		public bool DEKButton18ZoneIsAcpValid
		{
			get
			{
				short num = (short)482344960;
				short num2 = num;
				num = (short)1173119204;
				short num3 = num;
				num = (short)480796900;
				switch (num3 == num)
				{
				}
				num = (short)1125842945;
				if (num != 0)
				{
				}
				num = (short)1551040512;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)637468672;
				short num2 = num;
				num = (short)453705729;
				if (num != 0)
				{
				}
				num = (short)1738943497;
				short num3 = num;
				num = (short)2005019657;
				switch (num3 == num)
				{
				}
				num = (short)1993342976;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0002A6EC File Offset: 0x000288EC
		// (set) Token: 0x06000381 RID: 897 RVA: 0x0002A7A8 File Offset: 0x000289A8
		public bool DEKButton18ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)1169293312;
				short num2 = num;
				num = (short)548294521;
				short num3 = num;
				num = (short)498749305;
				switch (num3 == num)
				{
				}
				num = (short)1887502336;
				if (num != 0)
				{
				}
				num = (short)457113601;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1141571584;
				short num2 = num;
				num = (short)1120010241;
				if (num != 0)
				{
				}
				num = (short)1514071314;
				short num3 = num;
				num = (short)1262675218;
				switch (num3 == num)
				{
				}
				num = (short)839450624;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0002A864 File Offset: 0x00028A64
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0002A920 File Offset: 0x00028B20
		public bool DEKButton18ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1577254912;
				short num2 = num;
				num = (short)415575991;
				short num3 = num;
				num = (short)1636708279;
				switch (num3 == num)
				{
				}
				num = (short)383582208;
				if (num != 0)
				{
				}
				num = (short)1270087681;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)771883008;
				short num2 = num;
				num = (short)998789561;
				short num3 = num;
				num = (short)184308153;
				switch (num3 == num)
				{
				}
				num = (short)1793589248;
				if (num != 0)
				{
				}
				num = (short)781582337;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0002A9DC File Offset: 0x00028BDC
		// (set) Token: 0x06000385 RID: 901 RVA: 0x0002AA98 File Offset: 0x00028C98
		public bool DEKButton18ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1343160320;
				short num2 = num;
				num = (short)1697476245;
				short num3 = num;
				num = (short)55799445;
				switch (num3 == num)
				{
				}
				num = (short)1773928448;
				if (num != 0)
				{
				}
				num = (short)224460801;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)372572160;
				short num2 = num;
				num = (short)161505259;
				short num3 = num;
				num = (short)1630691307;
				switch (num3 == num)
				{
				}
				num = (short)1219821569;
				if (num != 0)
				{
				}
				num = (short)2094465024;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0002AB54 File Offset: 0x00028D54
		// (set) Token: 0x06000387 RID: 903 RVA: 0x0002AC0C File Offset: 0x00028E0C
		public string DEKButton18ZoneUIValue
		{
			get
			{
				short num = (short)558956544;
				short num2 = num;
				num = (short)2016723030;
				short num3 = num;
				num = (short)1535754326;
				switch (num3 == num)
				{
				}
				num = (short)1490878465;
				if (num != 0)
				{
				}
				num = (short)793706496;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton18ZoneUIValueProperty);
			}
			set
			{
				short num = (short)674562048;
				short num2 = num;
				num = (short)134792889;
				short num3 = num;
				num = (short)1155450553;
				switch (num3 == num)
				{
				}
				num = (short)1765343232;
				if (num != 0)
				{
				}
				num = (short)985006081;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18ZoneUIValueProperty, value);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0002ACC0 File Offset: 0x00028EC0
		// (set) Token: 0x06000389 RID: 905 RVA: 0x0002AD7C File Offset: 0x00028F7C
		public AcpListField DEKButton18ZoneList
		{
			get
			{
				short num = (short)1921646592;
				short num2 = num;
				num = (short)2069619295;
				short num3 = num;
				num = (short)1650975327;
				switch (num3 == num)
				{
				}
				num = (short)1271070721;
				if (num != 0)
				{
				}
				num = (short)1830944768;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton18ZoneListProperty);
			}
			set
			{
				short num = (short)1955135488;
				short num2 = num;
				num = (short)32204641;
				short num3 = num;
				num = (short)1196189537;
				switch (num3 == num)
				{
				}
				num = (short)277938177;
				if (num != 0)
				{
				}
				num = (short)1790181376;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18ZoneListProperty, value);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0002AE30 File Offset: 0x00029030
		// (set) Token: 0x0600038B RID: 907 RVA: 0x0002AEEC File Offset: 0x000290EC
		public bool DEKButton18ChannelIsAcpValid
		{
			get
			{
				short num = (short)1156710400;
				short num2 = num;
				num = (short)191954945;
				if (num != 0)
				{
				}
				num = (short)154390822;
				short num3 = num;
				num = (short)862179622;
				switch (num3 == num)
				{
				}
				num = (short)1318977536;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)1456734208;
				short num2 = num;
				num = (short)1818427393;
				if (num != 0)
				{
				}
				num = (short)1329389135;
				short num3 = num;
				num = (short)1357110863;
				switch (num3 == num)
				{
				}
				num = (short)1285685248;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0002AFA8 File Offset: 0x000291A8
		// (set) Token: 0x0600038D RID: 909 RVA: 0x0002B064 File Offset: 0x00029264
		public bool DEKButton18ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)627179520;
				short num2 = num;
				num = (short)169082881;
				if (num != 0)
				{
				}
				num = (short)1036350040;
				short num3 = num;
				num = (short)1680306776;
				switch (num3 == num)
				{
				}
				num = (short)675086336;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1657143296;
				short num2 = num;
				num = (short)1042190372;
				short num3 = num;
				num = (short)1672515620;
				switch (num3 == num)
				{
				}
				num = (short)1576337409;
				if (num != 0)
				{
				}
				num = (short)2100297728;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0002B124 File Offset: 0x00029324
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public bool DEKButton18ChannelIsAcpVisible
		{
			get
			{
				short num = (short)191037440;
				short num2 = num;
				num = (short)649673292;
				short num3 = num;
				num = (short)957430348;
				switch (num3 == num)
				{
				}
				num = (short)124583937;
				if (num != 0)
				{
				}
				num = (short)1489174528;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1696923648;
				short num2 = num;
				num = (short)1062325878;
				short num3 = num;
				num = (short)1536282230;
				switch (num3 == num)
				{
				}
				num = (short)909508609;
				if (num != 0)
				{
				}
				num = (short)746061824;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0002B298 File Offset: 0x00029498
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0002B350 File Offset: 0x00029550
		public bool DEKButton18ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1522008064;
				short num2 = num;
				num = (short)938763922;
				short num3 = num;
				num = (short)2060740242;
				switch (num3 == num)
				{
				}
				num = (short)686096385;
				if (num != 0)
				{
				}
				num = (short)1633288192;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton18ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1810432000;
				short num2 = num;
				num = (short)601103902;
				short num3 = num;
				num = (short)864296478;
				switch (num3 == num)
				{
				}
				num = (short)1610153985;
				if (num != 0)
				{
				}
				num = (short)211812352;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0002B408 File Offset: 0x00029608
		// (set) Token: 0x06000393 RID: 915 RVA: 0x0002B4C4 File Offset: 0x000296C4
		public string DEKButton18ChannelUIValue
		{
			get
			{
				short num = (short)1269825536;
				short num2 = num;
				num = (short)1808826152;
				short num3 = num;
				num = (short)327319336;
				switch (num3 == num)
				{
				}
				num = (short)1761476608;
				if (num != 0)
				{
				}
				num = (short)236716033;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton18ChannelUIValueProperty);
			}
			set
			{
				short num = (short)1847197696;
				short num2 = num;
				num = (short)131600609;
				short num3 = num;
				num = (short)13570273;
				switch (num3 == num)
				{
				}
				num = (short)1156251649;
				if (num != 0)
				{
				}
				num = (short)908197888;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18ChannelUIValueProperty, value);
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0002B57C File Offset: 0x0002977C
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0002B634 File Offset: 0x00029834
		public AcpListField DEKButton18ChannelList
		{
			get
			{
				short num = (short)758972416;
				short num2 = num;
				num = (short)380582034;
				short num3 = num;
				num = (short)1319581842;
				switch (num3 == num)
				{
				}
				num = (short)1290272769;
				if (num != 0)
				{
				}
				num = (short)1030029312;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton18ChannelListProperty);
			}
			set
			{
				short num = (short)1023934464;
				short num2 = num;
				num = (short)701431809;
				if (num != 0)
				{
				}
				num = (short)2047383053;
				short num3 = num;
				num = (short)483497485;
				switch (num3 == num)
				{
				}
				num = (short)1629093888;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton18ChannelListProperty, value);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0002B6EC File Offset: 0x000298EC
		// (set) Token: 0x06000397 RID: 919 RVA: 0x0002B7A4 File Offset: 0x000299A4
		public bool DEKButton19FeatureIsAcpValid
		{
			get
			{
				short num = (short)1291059200;
				short num2 = num;
				num = (short)1095139931;
				short num3 = num;
				num = (short)371098203;
				switch (num3 == num)
				{
				}
				num = (short)899022848;
				if (num != 0)
				{
				}
				num = (short)722206721;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1109065728;
				short num2 = num;
				num = (short)1609849092;
				short num3 = num;
				num = (short)1912494340;
				switch (num3 == num)
				{
				}
				num = (short)1443430401;
				if (num != 0)
				{
				}
				num = (short)881655808;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0002B860 File Offset: 0x00029A60
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0002B918 File Offset: 0x00029B18
		public bool DEKButton19FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)815661056;
				short num2 = num;
				num = (short)1992525509;
				short num3 = num;
				num = (short)133203653;
				switch (num3 == num)
				{
				}
				num = (short)340000769;
				if (num != 0)
				{
				}
				num = (short)1523318784;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1648689152;
				short num2 = num;
				num = (short)73269249;
				if (num != 0)
				{
				}
				num = (short)2134091874;
				short num3 = num;
				num = (short)979806306;
				switch (num3 == num)
				{
				}
				num = (short)1918500864;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0002B9D4 File Offset: 0x00029BD4
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0002BA8C File Offset: 0x00029C8C
		public bool DEKButton19FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1994588160;
				short num2 = num;
				num = (short)501311870;
				short num3 = num;
				num = (short)1072720254;
				switch (num3 == num)
				{
				}
				num = (short)1966669824;
				if (num != 0)
				{
				}
				num = (short)1715470337;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)865992704;
				short num2 = num;
				num = (short)301727745;
				if (num != 0)
				{
				}
				num = (short)1982916632;
				short num3 = num;
				num = (short)276752408;
				switch (num3 == num)
				{
				}
				num = (short)580714496;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0002BB48 File Offset: 0x00029D48
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0002BC00 File Offset: 0x00029E00
		public bool DEKButton19FeatureIsAcpEditable
		{
			get
			{
				short num = (short)257425408;
				short num2 = num;
				num = (short)1597898753;
				if (num != 0)
				{
				}
				num = (short)2079089186;
				short num3 = num;
				num = (short)978870818;
				switch (num3 == num)
				{
				}
				num = (short)1936523264;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1004732416;
				short num2 = num;
				num = (short)1114329655;
				short num3 = num;
				num = (short)95375927;
				switch (num3 == num)
				{
				}
				num = (short)387776513;
				if (num != 0)
				{
				}
				num = (short)1670053888;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0002BCC0 File Offset: 0x00029EC0
		// (set) Token: 0x0600039F RID: 927 RVA: 0x0002BD7C File Offset: 0x00029F7C
		public string DEKButton19FeatureUIValue
		{
			get
			{
				short num = (short)501612544;
				short num2 = num;
				num = (short)1037490447;
				short num3 = num;
				num = (short)118479119;
				switch (num3 == num)
				{
				}
				num = (short)609091584;
				if (num != 0)
				{
				}
				num = (short)1849884673;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton19FeatureUIValueProperty);
			}
			set
			{
				short num = (short)2044657664;
				short num2 = num;
				num = (short)905738533;
				short num3 = num;
				num = (short)38959397;
				switch (num3 == num)
				{
				}
				num = (short)246677504;
				if (num != 0)
				{
				}
				num = (short)50659329;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19FeatureUIValueProperty, value);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0002BE30 File Offset: 0x0002A030
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x0002BEE8 File Offset: 0x0002A0E8
		public AcpListField DEKButton19FeatureList
		{
			get
			{
				short num = (short)1585250304;
				short num2 = num;
				num = (short)582785334;
				short num3 = num;
				num = (short)68589878;
				switch (num3 == num)
				{
				}
				num = (short)515637249;
				if (num != 0)
				{
				}
				num = (short)940572672;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton19FeatureListProperty);
			}
			set
			{
				short num = (short)1819541504;
				short num2 = num;
				num = (short)210935245;
				short num3 = num;
				num = (short)1709874637;
				switch (num3 == num)
				{
				}
				num = (short)2005532672;
				if (num != 0)
				{
				}
				num = (short)21430273;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19FeatureListProperty, value);
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0002BFA0 File Offset: 0x0002A1A0
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x0002C05C File Offset: 0x0002A25C
		public bool DEKButton19IndexIsAcpValid
		{
			get
			{
				short num = (short)745537536;
				short num2 = num;
				num = (short)659770467;
				short num3 = num;
				num = (short)1420577891;
				switch (num3 == num)
				{
				}
				num = (short)249102337;
				if (num != 0)
				{
				}
				num = (short)740622336;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)454361088;
				short num2 = num;
				num = (short)2057655817;
				short num3 = num;
				num = (short)2143376905;
				switch (num3 == num)
				{
				}
				num = (short)1823997953;
				if (num != 0)
				{
				}
				num = (short)1148256256;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0002C118 File Offset: 0x0002A318
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0002C1D4 File Offset: 0x0002A3D4
		public bool DEKButton19IndexIsAcpApplicable
		{
			get
			{
				short num = (short)604045312;
				short num2 = num;
				num = (short)1183795937;
				short num3 = num;
				num = (short)961891041;
				switch (num3 == num)
				{
				}
				num = (short)1159593985;
				if (num != 0)
				{
				}
				num = (short)735707136;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)420741120;
				short num2 = num;
				num = (short)658990661;
				short num3 = num;
				num = (short)1531995717;
				switch (num3 == num)
				{
				}
				num = (short)1745944577;
				if (num != 0)
				{
				}
				num = (short)1088552960;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0002C28C File Offset: 0x0002A48C
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x0002C348 File Offset: 0x0002A548
		public bool DEKButton19IndexIsAcpVisible
		{
			get
			{
				short num = (short)1069940736;
				short num2 = num;
				num = (short)917289360;
				short num3 = num;
				num = (short)403290512;
				switch (num3 == num)
				{
				}
				num = (short)425852929;
				if (num != 0)
				{
				}
				num = (short)192282624;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)43974656;
				short num2 = num;
				num = (short)607000826;
				short num3 = num;
				num = (short)1995839738;
				switch (num3 == num)
				{
				}
				num = (short)1769537536;
				if (num != 0)
				{
				}
				num = (short)1821835265;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0002C404 File Offset: 0x0002A604
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x0002C4BC File Offset: 0x0002A6BC
		public bool DEKButton19IndexIsAcpEditable
		{
			get
			{
				short num = (short)1033568256;
				short num2 = num;
				num = (short)70713345;
				if (num != 0)
				{
				}
				num = (short)127225824;
				short num3 = num;
				num = (short)1383682016;
				switch (num3 == num)
				{
				}
				num = (short)1696858112;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1976172544;
				short num2 = num;
				num = (short)1166026669;
				short num3 = num;
				num = (short)724051885;
				switch (num3 == num)
				{
				}
				num = (short)131268609;
				if (num != 0)
				{
				}
				num = (short)1448935424;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0002C578 File Offset: 0x0002A778
		// (set) Token: 0x060003AB RID: 939 RVA: 0x0002C630 File Offset: 0x0002A830
		public string DEKButton19IndexUIValue
		{
			get
			{
				short num = (short)964493312;
				short num2 = num;
				num = (short)1907227636;
				short num3 = num;
				num = (short)935590900;
				switch (num3 == num)
				{
				}
				num = (short)2008350721;
				if (num != 0)
				{
				}
				num = (short)1052770304;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton19IndexUIValueProperty);
			}
			set
			{
				short num = (short)1049952256;
				short num2 = num;
				num = (short)1492944401;
				short num3 = num;
				num = (short)1424131601;
				switch (num3 == num)
				{
				}
				num = (short)1648951297;
				if (num != 0)
				{
				}
				num = (short)1851850752;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19IndexUIValueProperty, value);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0002C6E4 File Offset: 0x0002A8E4
		// (set) Token: 0x060003AD RID: 941 RVA: 0x0002C7A0 File Offset: 0x0002A9A0
		public AcpRangeField<int, int> DEKButton19IndexRange
		{
			get
			{
				short num = (short)1004142592;
				short num2 = num;
				num = (short)1895599281;
				short num3 = num;
				num = (short)1190628529;
				switch (num3 == num)
				{
				}
				num = (short)1749024768;
				if (num != 0)
				{
				}
				num = (short)1299513345;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton19IndexRangeProperty);
			}
			set
			{
				short num = (short)1216217088;
				short num2 = num;
				num = (short)1293549569;
				if (num != 0)
				{
				}
				num = (short)2030290180;
				short num3 = num;
				num = (short)615433476;
				switch (num3 == num)
				{
				}
				num = (short)216858624;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19IndexRangeProperty, value);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0002C858 File Offset: 0x0002AA58
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0002C910 File Offset: 0x0002AB10
		public bool DEKButton19ZoneIsAcpValid
		{
			get
			{
				short num = (short)583467008;
				short num2 = num;
				num = (short)2078097257;
				short num3 = num;
				num = (short)438583145;
				switch (num3 == num)
				{
				}
				num = (short)1645674496;
				if (num != 0)
				{
				}
				num = (short)876871681;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)2050818048;
				short num2 = num;
				num = (short)711391697;
				short num3 = num;
				num = (short)5896657;
				switch (num3 == num)
				{
				}
				num = (short)2111504385;
				if (num != 0)
				{
				}
				num = (short)226820096;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0002C9CC File Offset: 0x0002ABCC
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x0002CA84 File Offset: 0x0002AC84
		public bool DEKButton19ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)1189478400;
				short num2 = num;
				num = (short)642252801;
				if (num != 0)
				{
				}
				num = (short)474203133;
				short num3 = num;
				num = (short)752665597;
				switch (num3 == num)
				{
				}
				num = (short)1599799296;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1000931328;
				short num2 = num;
				num = (short)729845201;
				short num3 = num;
				num = (short)673746385;
				switch (num3 == num)
				{
				}
				num = (short)695533569;
				if (num != 0)
				{
				}
				num = (short)1678311424;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0002CB3C File Offset: 0x0002AD3C
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x0002CBF8 File Offset: 0x0002ADF8
		public bool DEKButton19ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1971978240;
				short num2 = num;
				num = (short)2064609403;
				short num3 = num;
				num = (short)688025723;
				switch (num3 == num)
				{
				}
				num = (short)2144600065;
				if (num != 0)
				{
				}
				num = (short)207093760;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)494010368;
				short num2 = num;
				num = (short)1787758861;
				short num3 = num;
				num = (short)227739917;
				switch (num3 == num)
				{
				}
				num = (short)1396768768;
				if (num != 0)
				{
				}
				num = (short)1887436801;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0002CCB4 File Offset: 0x0002AEB4
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x0002CD6C File Offset: 0x0002AF6C
		public bool DEKButton19ZoneIsAcpEditable
		{
			get
			{
				short num = (short)635699200;
				short num2 = num;
				num = (short)1244443606;
				short num3 = num;
				num = (short)1367520214;
				switch (num3 == num)
				{
				}
				num = (short)898039809;
				if (num != 0)
				{
				}
				num = (short)1166147584;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1339752448;
				short num2 = num;
				num = (short)648761347;
				short num3 = num;
				num = (short)156389379;
				switch (num3 == num)
				{
				}
				num = (short)1584398336;
				if (num != 0)
				{
				}
				num = (short)1897463809;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0002CE28 File Offset: 0x0002B028
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x0002CEE4 File Offset: 0x0002B0E4
		public string DEKButton19ZoneUIValue
		{
			get
			{
				short num = (short)1503133696;
				short num2 = num;
				num = (short)1374352247;
				short num3 = num;
				num = (short)287437687;
				switch (num3 == num)
				{
				}
				num = (short)498073601;
				if (num != 0)
				{
				}
				num = (short)621412352;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton19ZoneUIValueProperty);
			}
			set
			{
				short num = (short)2050883584;
				short num2 = num;
				num = (short)1592441196;
				short num3 = num;
				num = (short)1810086252;
				switch (num3 == num)
				{
				}
				num = (short)633733120;
				if (num != 0)
				{
				}
				num = (short)1002242049;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19ZoneUIValueProperty, value);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0002CF9C File Offset: 0x0002B19C
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x0002D058 File Offset: 0x0002B258
		public AcpListField DEKButton19ZoneList
		{
			get
			{
				short num = (short)444399616;
				short num2 = num;
				num = (short)1987273398;
				short num3 = num;
				num = (short)1792172726;
				switch (num3 == num)
				{
				}
				num = (short)32505857;
				if (num != 0)
				{
				}
				num = (short)523304960;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton19ZoneListProperty);
			}
			set
			{
				short num = (short)501809152;
				short num2 = num;
				num = (short)954324659;
				short num3 = num;
				num = (short)526243507;
				switch (num3 == num)
				{
				}
				num = (short)872611841;
				if (num != 0)
				{
				}
				num = (short)1628241920;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19ZoneListProperty, value);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0002D10C File Offset: 0x0002B30C
		// (set) Token: 0x060003BB RID: 955 RVA: 0x0002D1C8 File Offset: 0x0002B3C8
		public bool DEKButton19ChannelIsAcpValid
		{
			get
			{
				short num = (short)177143808;
				short num2 = num;
				num = (short)1026018035;
				short num3 = num;
				num = (short)923781875;
				switch (num3 == num)
				{
				}
				num = (short)677445633;
				if (num != 0)
				{
				}
				num = (short)1575878656;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)2752512;
				short num2 = num;
				num = (short)757319218;
				short num3 = num;
				num = (short)1600112178;
				switch (num3 == num)
				{
				}
				num = (short)794820609;
				if (num != 0)
				{
				}
				num = (short)1128464384;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0002D284 File Offset: 0x0002B484
		// (set) Token: 0x060003BD RID: 957 RVA: 0x0002D33C File Offset: 0x0002B53C
		public bool DEKButton19ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)961019904;
				short num2 = num;
				num = (short)1274738284;
				short num3 = num;
				num = (short)230749804;
				switch (num3 == num)
				{
				}
				num = (short)101187584;
				if (num != 0)
				{
				}
				num = (short)63832065;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)102236160;
				short num2 = num;
				num = (short)466999358;
				short num3 = num;
				num = (short)2016663614;
				switch (num3 == num)
				{
				}
				num = (short)2082275329;
				if (num != 0)
				{
				}
				num = (short)1492713472;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0002D3F8 File Offset: 0x0002B5F8
		// (set) Token: 0x060003BF RID: 959 RVA: 0x0002D4B4 File Offset: 0x0002B6B4
		public bool DEKButton19ChannelIsAcpVisible
		{
			get
			{
				short num = (short)1441857536;
				short num2 = num;
				num = (short)793666710;
				short num3 = num;
				num = (short)205546646;
				switch (num3 == num)
				{
				}
				num = (short)1820590080;
				if (num != 0)
				{
				}
				num = (short)1499463681;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)469565440;
				short num2 = num;
				num = (short)1855819815;
				short num3 = num;
				num = (short)1308856359;
				switch (num3 == num)
				{
				}
				num = (short)1732968449;
				if (num != 0)
				{
				}
				num = (short)699006976;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0002D570 File Offset: 0x0002B770
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x0002D62C File Offset: 0x0002B82C
		public bool DEKButton19ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1208287232;
				short num2 = num;
				num = (short)1599639122;
				short num3 = num;
				num = (short)1586728530;
				switch (num3 == num)
				{
				}
				num = (short)1631191040;
				if (num != 0)
				{
				}
				num = (short)903806977;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton19ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2051276800;
				short num2 = num;
				num = (short)1388445697;
				if (num != 0)
				{
				}
				num = (short)1739544577;
				short num3 = num;
				num = (short)127096833;
				switch (num3 == num)
				{
				}
				num = (short)621936640;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0002D6E8 File Offset: 0x0002B8E8
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x0002D7A4 File Offset: 0x0002B9A4
		public string DEKButton19ChannelUIValue
		{
			get
			{
				short num = (short)143541528;
				short num2 = num;
				num = (short)1065698584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2065432576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)57212928;
				if (num != 0)
				{
				}
				num = (short)1323433985;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton19ChannelUIValueProperty);
			}
			set
			{
				short num = (short)1035850891;
				short num2 = num;
				num = (short)1647039627;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1240006656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1169096705;
				if (num != 0)
				{
				}
				num = (short)889651200;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19ChannelUIValueProperty, value);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0002D85C File Offset: 0x0002BA5C
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x0002D918 File Offset: 0x0002BB18
		public AcpListField DEKButton19ChannelList
		{
			get
			{
				short num = (short)1887060929;
				short num2 = num;
				num = (short)1275151297;
				switch (num2 == num)
				{
				default:
				{
					num = (short)107544576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)734068737;
				if (num != 0)
				{
				}
				num = (short)1492582400;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton19ChannelListProperty);
			}
			set
			{
				short num = (short)513205315;
				short num2 = num;
				num = (short)261481539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101529088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1109590016;
				if (num != 0)
				{
				}
				num = (short)874774529;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton19ChannelListProperty, value);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0002D9CC File Offset: 0x0002BBCC
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x0002DA84 File Offset: 0x0002BC84
		public bool DEKButton20FeatureIsAcpValid
		{
			get
			{
				short num = (short)120619924;
				short num2 = num;
				num = (short)913343380;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1766785024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1942290433;
				if (num != 0)
				{
				}
				num = (short)2082799616;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)973275212;
				short num2 = num;
				num = (short)283902028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1600454656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)656605184;
				if (num != 0)
				{
				}
				num = (short)209453057;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0002DB44 File Offset: 0x0002BD44
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x0002DBFC File Offset: 0x0002BDFC
		public bool DEKButton20FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1785987073;
				if (num != 0)
				{
				}
				num = (short)1128005632;
				short num2 = num;
				num = (short)1480221838;
				short num3 = num;
				num = (short)2037671054;
				switch (num3 == num)
				{
				}
				num = (short)1791557632;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1613850157;
				short num2 = num;
				num = (short)54814253;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1763704832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1234829312;
				if (num != 0)
				{
				}
				num = (short)169803777;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060003CA RID: 970 RVA: 0x0002DCB4 File Offset: 0x0002BEB4
		// (set) Token: 0x060003CB RID: 971 RVA: 0x0002DD70 File Offset: 0x0002BF70
		public bool DEKButton20FeatureIsAcpVisible
		{
			get
			{
				short num = (short)1915994368;
				short num2 = num;
				num = (short)1031782656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)49938432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2117533697;
				if (num != 0)
				{
				}
				num = (short)455933952;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2062745601;
				if (num != 0)
				{
				}
				num = (short)1485111296;
				short num2 = num;
				num = (short)206049508;
				short num3 = num;
				num = (short)2122387684;
				switch (num3 == num)
				{
				}
				num = (short)2124021760;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0002DE28 File Offset: 0x0002C028
		// (set) Token: 0x060003CD RID: 973 RVA: 0x0002DEE4 File Offset: 0x0002C0E4
		public bool DEKButton20FeatureIsAcpEditable
		{
			get
			{
				short num = (short)414292504;
				short num2 = num;
				num = (short)2074057240;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1436024832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)768999424;
				if (num != 0)
				{
				}
				num = (short)1680932865;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)775289930;
				short num2 = num;
				num = (short)1935277130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1478295552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1576271873;
				if (num != 0)
				{
				}
				num = (short)1775173632;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0002DFA0 File Offset: 0x0002C1A0
		// (set) Token: 0x060003CF RID: 975 RVA: 0x0002E05C File Offset: 0x0002C25C
		public string DEKButton20FeatureUIValue
		{
			get
			{
				short num = (short)700435538;
				short num2 = num;
				num = (short)1748487250;
				switch (num2 == num)
				{
				default:
				{
					num = (short)745996288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)799866881;
				if (num != 0)
				{
				}
				num = (short)228720640;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton20FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1465106880;
				short num2 = num;
				num = (short)237420992;
				switch (num2 == num)
				{
				default:
				{
					num = (short)234881024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)315883521;
				if (num != 0)
				{
				}
				num = (short)1131413504;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20FeatureUIValueProperty, value);
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0002E114 File Offset: 0x0002C314
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
		public AcpListField DEKButton20FeatureList
		{
			get
			{
				short num = (short)2001037560;
				short num2 = num;
				num = (short)362047736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)971898880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)182976513;
				if (num != 0)
				{
				}
				num = (short)632553472;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton20FeatureListProperty);
			}
			set
			{
				short num = (short)173174701;
				short num2 = num;
				num = (short)1698000813;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1402273792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)612630529;
				if (num != 0)
				{
				}
				num = (short)274137088;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20FeatureListProperty, value);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0002E284 File Offset: 0x0002C484
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0002E33C File Offset: 0x0002C53C
		public bool DEKButton20IndexIsAcpValid
		{
			get
			{
				short num = (short)1308753921;
				if (num != 0)
				{
				}
				num = (short)1128923136;
				short num2 = num;
				num = (short)1226581018;
				short num3 = num;
				num = (short)32252954;
				switch (num3 == num)
				{
				}
				num = (short)1859452928;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)721474641;
				short num2 = num;
				num = (short)1204999249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)837550080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)762970113;
				if (num != 0)
				{
				}
				num = (short)507379712;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x0002E4B4 File Offset: 0x0002C6B4
		public bool DEKButton20IndexIsAcpApplicable
		{
			get
			{
				short num = (short)964485563;
				short num2 = num;
				num = (short)539156923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1076166656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)771751937;
				if (num != 0)
				{
				}
				num = (short)1072300032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)785764353;
				short num2 = num;
				num = (short)849137665;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2125070336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)55574528;
				if (num != 0)
				{
				}
				num = (short)1219756033;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0002E570 File Offset: 0x0002C770
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x0002E628 File Offset: 0x0002C828
		public bool DEKButton20IndexIsAcpVisible
		{
			get
			{
				short num = (short)1021953358;
				short num2 = num;
				num = (short)1515963726;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1142161408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1512570880;
				if (num != 0)
				{
				}
				num = (short)1695350785;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1888241970;
				short num2 = num;
				num = (short)625428786;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1182203904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1215823873;
				if (num != 0)
				{
				}
				num = (short)1030488064;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0002E6E4 File Offset: 0x0002C8E4
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x0002E7A0 File Offset: 0x0002C9A0
		public bool DEKButton20IndexIsAcpEditable
		{
			get
			{
				short num = (short)1699195477;
				short num2 = num;
				num = (short)1006807637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)238616576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)715128833;
				if (num != 0)
				{
				}
				num = (short)997457920;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1928237815;
				short num2 = num;
				num = (short)609260279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1089929216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)118226945;
				if (num != 0)
				{
				}
				num = (short)2115829760;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0002E85C File Offset: 0x0002CA5C
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0002E914 File Offset: 0x0002CB14
		public string DEKButton20IndexUIValue
		{
			get
			{
				short num = (short)1725952851;
				short num2 = num;
				num = (short)780923731;
				switch (num2 == num)
				{
				default:
				{
					num = (short)36634624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)796721153;
				if (num != 0)
				{
				}
				num = (short)1204092928;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton20IndexUIValueProperty);
			}
			set
			{
				short num = (short)1743156270;
				short num2 = num;
				num = (short)1116173358;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1666187264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1396965377;
				if (num != 0)
				{
				}
				num = (short)2070413312;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20IndexUIValueProperty, value);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0002E9CC File Offset: 0x0002CBCC
		// (set) Token: 0x060003DD RID: 989 RVA: 0x0002EA84 File Offset: 0x0002CC84
		public AcpRangeField<int, int> DEKButton20IndexRange
		{
			get
			{
				short num = (short)764189521;
				short num2 = num;
				num = (short)304782161;
				switch (num2 == num)
				{
				default:
				{
					num = (short)734003200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1699545089;
				if (num != 0)
				{
				}
				num = (short)1381564416;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton20IndexRangeProperty);
			}
			set
			{
				short num = (short)1915024221;
				short num2 = num;
				num = (short)384889693;
				switch (num2 == num)
				{
				default:
				{
					num = (short)206307328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2042953729;
				if (num != 0)
				{
				}
				num = (short)845348864;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20IndexRangeProperty, value);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0002EB3C File Offset: 0x0002CD3C
		// (set) Token: 0x060003DF RID: 991 RVA: 0x0002EBF8 File Offset: 0x0002CDF8
		public bool DEKButton20ZoneIsAcpValid
		{
			get
			{
				short num = (short)846930574;
				short num2 = num;
				num = (short)237904526;
				switch (num2 == num)
				{
				default:
				{
					num = (short)813563904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1004797953;
				if (num != 0)
				{
				}
				num = (short)324730880;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)1610446754;
				short num2 = num;
				num = (short)199456674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)678887424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1183973377;
				if (num != 0)
				{
				}
				num = (short)910688256;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0002ECB0 File Offset: 0x0002CEB0
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x0002ED68 File Offset: 0x0002CF68
		public bool DEKButton20ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)340574999;
				short num2 = num;
				num = (short)444449559;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1096876032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)389480449;
				if (num != 0)
				{
				}
				num = (short)1708457984;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1636106241;
				if (num != 0)
				{
				}
				num = (short)509083648;
				short num2 = num;
				num = (short)2099473356;
				short num3 = num;
				num = (short)957443020;
				switch (num3 == num)
				{
				}
				num = (short)973864960;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0002EE24 File Offset: 0x0002D024
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x0002EEE0 File Offset: 0x0002D0E0
		public bool DEKButton20ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1654126527;
				short num2 = num;
				num = (short)1228142527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1874329600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)719323136;
				if (num != 0)
				{
				}
				num = (short)1475936257;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)368129200;
				short num2 = num;
				num = (short)1812477104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)160628736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1634140160;
				if (num != 0)
				{
				}
				num = (short)1264779265;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0002EF98 File Offset: 0x0002D198
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x0002F054 File Offset: 0x0002D254
		public bool DEKButton20ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1770749932;
				short num2 = num;
				num = (short)1796833260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)351535104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)631177217;
				if (num != 0)
				{
				}
				num = (short)735903744;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1619159774;
				short num2 = num;
				num = (short)1882876638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)810090496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1476853760;
				if (num != 0)
				{
				}
				num = (short)485228545;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0002F110 File Offset: 0x0002D310
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x0002F1C8 File Offset: 0x0002D3C8
		public string DEKButton20ZoneUIValue
		{
			get
			{
				short num = (short)252687887;
				short num2 = num;
				num = (short)1368438287;
				switch (num2 == num)
				{
				default:
				{
					num = (short)714997760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1415970817;
				if (num != 0)
				{
				}
				num = (short)155189248;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton20ZoneUIValueProperty);
			}
			set
			{
				short num = (short)260898817;
				if (num != 0)
				{
				}
				num = (short)1315962880;
				short num2 = num;
				num = (short)1860034490;
				short num3 = num;
				num = (short)1259921338;
				switch (num3 == num)
				{
				}
				num = (short)1940586496;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20ZoneUIValueProperty, value);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0002F280 File Offset: 0x0002D480
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x0002F338 File Offset: 0x0002D538
		public AcpListField DEKButton20ZoneList
		{
			get
			{
				short num = (short)36175873;
				if (num != 0)
				{
				}
				num = (short)1656553472;
				short num2 = num;
				num = (short)303958588;
				short num3 = num;
				num = (short)2096433724;
				switch (num3 == num)
				{
				}
				num = (short)2084503552;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton20ZoneListProperty);
			}
			set
			{
				short num = (short)1012756526;
				short num2 = num;
				num = (short)650211374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)218497024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)773586945;
				if (num != 0)
				{
				}
				num = (short)1689780224;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20ZoneListProperty, value);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0002F3EC File Offset: 0x0002D5EC
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x0002F4A8 File Offset: 0x0002D6A8
		public bool DEKButton20ChannelIsAcpValid
		{
			get
			{
				short num = (short)231646335;
				short num2 = num;
				num = (short)178824319;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1788084224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1976041473;
				if (num != 0)
				{
				}
				num = (short)385941504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)630214057;
				short num2 = num;
				num = (short)848448937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1499201536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1763311617;
				if (num != 0)
				{
				}
				num = (short)1982791680;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0002F560 File Offset: 0x0002D760
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0002F61C File Offset: 0x0002D81C
		public bool DEKButton20ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)2044759811;
				short num2 = num;
				num = (short)1205505795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1177878528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)459603969;
				if (num != 0)
				{
				}
				num = (short)62128128;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1787224723;
				short num2 = num;
				num = (short)2028921491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2005598208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1162346497;
				if (num != 0)
				{
				}
				num = (short)2081554432;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0002F6D8 File Offset: 0x0002D8D8
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x0002F790 File Offset: 0x0002D990
		public bool DEKButton20ChannelIsAcpVisible
		{
			get
			{
				short num = (short)1762394113;
				if (num != 0)
				{
				}
				num = (short)25952256;
				short num2 = num;
				num = (short)1169235795;
				short num3 = num;
				num = (short)822288211;
				switch (num3 == num)
				{
				}
				num = (short)1040121856;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1254254188;
				short num2 = num;
				num = (short)1809409644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)736034816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2072444928;
				if (num != 0)
				{
				}
				num = (short)1692008449;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0002F848 File Offset: 0x0002DA48
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x0002F900 File Offset: 0x0002DB00
		public bool DEKButton20ChannelIsAcpEditable
		{
			get
			{
				short num = (short)313985632;
				short num2 = num;
				num = (short)849807968;
				switch (num2 == num)
				{
				default:
				{
					num = (short)413925376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1171587073;
				if (num != 0)
				{
				}
				num = (short)1037762560;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton20ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1772617729;
				if (num != 0)
				{
				}
				num = (short)1612775424;
				short num2 = num;
				num = (short)462686515;
				short num3 = num;
				num = (short)839518515;
				switch (num3 == num)
				{
				}
				num = (short)1985937408;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0002F9BC File Offset: 0x0002DBBC
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x0002FA78 File Offset: 0x0002DC78
		public string DEKButton20ChannelUIValue
		{
			get
			{
				short num = (short)43277625;
				short num2 = num;
				num = (short)1689541945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1708326912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1414463489;
				if (num != 0)
				{
				}
				num = (short)612368384;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton20ChannelUIValueProperty);
			}
			set
			{
				short num = (short)927499967;
				short num2 = num;
				num = (short)347965119;
				switch (num2 == num)
				{
				default:
				{
					num = (short)290455552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)16973825;
				if (num != 0)
				{
				}
				num = (short)1834483712;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20ChannelUIValueProperty, value);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0002FB30 File Offset: 0x0002DD30
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x0002FBEC File Offset: 0x0002DDEC
		public AcpListField DEKButton20ChannelList
		{
			get
			{
				short num = (short)784380964;
				short num2 = num;
				num = (short)1597027364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)412942336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1902182401;
				if (num != 0)
				{
				}
				num = (short)1197801472;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton20ChannelListProperty);
			}
			set
			{
				short num = (short)1507823685;
				short num2 = num;
				num = (short)104828997;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1165295616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1719599105;
				if (num != 0)
				{
				}
				num = (short)8060928;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton20ChannelListProperty, value);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0002FCA0 File Offset: 0x0002DEA0
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x0002FD5C File Offset: 0x0002DF5C
		public bool DEKButton21FeatureIsAcpValid
		{
			get
			{
				short num = (short)651034624;
				short num2 = num;
				num = (short)1634250348;
				short num3 = num;
				num = (short)1507372652;
				switch (num3 == num)
				{
				}
				num = (short)681050113;
				if (num != 0)
				{
				}
				num = (short)1507393536;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)44171264;
				short num2 = num;
				num = (short)1159315025;
				short num3 = num;
				num = (short)1821556305;
				switch (num3 == num)
				{
				}
				num = (short)787415040;
				if (num != 0)
				{
				}
				num = (short)84672513;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0002FE18 File Offset: 0x0002E018
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x0002FED4 File Offset: 0x0002E0D4
		public bool DEKButton21FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1021902848;
				short num2 = num;
				num = (short)2053608114;
				short num3 = num;
				num = (short)382636722;
				switch (num3 == num)
				{
				}
				num = (short)1959854081;
				if (num != 0)
				{
				}
				num = (short)2093154304;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1930231808;
				short num2 = num;
				num = (short)1938750437;
				short num3 = num;
				num = (short)1888877541;
				switch (num3 == num)
				{
				}
				num = (short)2044133377;
				if (num != 0)
				{
				}
				num = (short)1226506240;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0002FF94 File Offset: 0x0002E194
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x0003004C File Offset: 0x0002E24C
		public bool DEKButton21FeatureIsAcpVisible
		{
			get
			{
				short num = (short)2023686144;
				short num2 = num;
				num = (short)1401301557;
				short num3 = num;
				num = (short)1042360885;
				switch (num3 == num)
				{
				}
				num = (short)1510932480;
				if (num != 0)
				{
				}
				num = (short)445186049;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1678901248;
				short num2 = num;
				num = (short)1998500042;
				short num3 = num;
				num = (short)1868738762;
				switch (num3 == num)
				{
				}
				num = (short)1792344064;
				if (num != 0)
				{
				}
				num = (short)793509889;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00030104 File Offset: 0x0002E304
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x000301C0 File Offset: 0x0002E3C0
		public bool DEKButton21FeatureIsAcpEditable
		{
			get
			{
				short num = (short)290062336;
				short num2 = num;
				num = (short)1624568048;
				short num3 = num;
				num = (short)1423503600;
				switch (num3 == num)
				{
				}
				num = (short)1590099969;
				if (num != 0)
				{
				}
				num = (short)538968064;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)156631040;
				short num2 = num;
				num = (short)2073235302;
				short num3 = num;
				num = (short)2124681062;
				switch (num3 == num)
				{
				}
				num = (short)128974848;
				if (num != 0)
				{
				}
				num = (short)201981953;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0003027C File Offset: 0x0002E47C
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00030338 File Offset: 0x0002E538
		public string DEKButton21FeatureUIValue
		{
			get
			{
				short num = (short)226557952;
				short num2 = num;
				num = (short)1998415099;
				short num3 = num;
				num = (short)603612411;
				switch (num3 == num)
				{
				}
				num = (short)881262592;
				if (num != 0)
				{
				}
				num = (short)193069057;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton21FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1379270656;
				short num2 = num;
				num = (short)1352364336;
				short num3 = num;
				num = (short)1020686640;
				switch (num3 == num)
				{
				}
				num = (short)794099713;
				if (num != 0)
				{
				}
				num = (short)344915968;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x000303EC File Offset: 0x0002E5EC
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x000304A4 File Offset: 0x0002E6A4
		public AcpListField DEKButton21FeatureList
		{
			get
			{
				short num = (short)1723793408;
				short num2 = num;
				num = (short)499794847;
				short num3 = num;
				num = (short)697058207;
				switch (num3 == num)
				{
				}
				num = (short)446758912;
				if (num != 0)
				{
				}
				num = (short)1797849089;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton21FeatureListProperty);
			}
			set
			{
				short num = (short)1249181696;
				short num2 = num;
				num = (short)1004751198;
				short num3 = num;
				num = (short)1741572446;
				switch (num3 == num)
				{
				}
				num = (short)1655308288;
				if (num != 0)
				{
				}
				num = (short)775815169;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21FeatureListProperty, value);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0003055C File Offset: 0x0002E75C
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00030618 File Offset: 0x0002E818
		public bool DEKButton21IndexIsAcpValid
		{
			get
			{
				short num = (short)1846673408;
				short num2 = num;
				num = (short)1034440141;
				short num3 = num;
				num = (short)1009012173;
				switch (num3 == num)
				{
				}
				num = (short)1001848833;
				if (num != 0)
				{
				}
				num = (short)945160192;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1750728704;
				short num2 = num;
				num = (short)1000353355;
				short num3 = num;
				num = (short)1469460043;
				switch (num3 == num)
				{
				}
				num = (short)1633615872;
				if (num != 0)
				{
				}
				num = (short)1311637505;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x000306D0 File Offset: 0x0002E8D0
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x0003078C File Offset: 0x0002E98C
		public bool DEKButton21IndexIsAcpApplicable
		{
			get
			{
				short num = (short)621477888;
				short num2 = num;
				num = (short)2043872395;
				short num3 = num;
				num = (short)626590859;
				switch (num3 == num)
				{
				}
				num = (short)2123825153;
				if (num != 0)
				{
				}
				num = (short)1359151104;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1544880128;
				short num2 = num;
				num = (short)1116182434;
				short num3 = num;
				num = (short)1535088546;
				switch (num3 == num)
				{
				}
				num = (short)1851719681;
				if (num != 0)
				{
				}
				num = (short)1456603136;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00030844 File Offset: 0x0002EA44
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x000308FC File Offset: 0x0002EAFC
		public bool DEKButton21IndexIsAcpVisible
		{
			get
			{
				short num = (short)1471152128;
				short num2 = num;
				num = (short)61161940;
				short num3 = num;
				num = (short)1481261524;
				switch (num3 == num)
				{
				}
				num = (short)1967783937;
				if (num != 0)
				{
				}
				num = (short)247267328;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1940979712;
				short num2 = num;
				num = (short)716963354;
				short num3 = num;
				num = (short)935132698;
				switch (num3 == num)
				{
				}
				num = (short)708444161;
				if (num != 0)
				{
				}
				num = (short)1293811712;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x000309B4 File Offset: 0x0002EBB4
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00030A70 File Offset: 0x0002EC70
		public bool DEKButton21IndexIsAcpEditable
		{
			get
			{
				short num = (short)1084686336;
				short num2 = num;
				num = (short)353810845;
				short num3 = num;
				num = (short)1058912669;
				switch (num3 == num)
				{
				}
				num = (short)1992753152;
				if (num != 0)
				{
				}
				num = (short)458555393;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)726007808;
				short num2 = num;
				num = (short)711804000;
				short num3 = num;
				num = (short)353977440;
				switch (num3 == num)
				{
				}
				num = (short)1235222528;
				if (num != 0)
				{
				}
				num = (short)862126081;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00030B28 File Offset: 0x0002ED28
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00030BE4 File Offset: 0x0002EDE4
		public string DEKButton21IndexUIValue
		{
			get
			{
				short num = (short)98762752;
				short num2 = num;
				num = (short)1328794132;
				short num3 = num;
				num = (short)565758484;
				switch (num3 == num)
				{
				}
				num = (short)1817116673;
				if (num != 0)
				{
				}
				num = (short)1186332672;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton21IndexUIValueProperty);
			}
			set
			{
				short num = (short)1616052224;
				short num2 = num;
				num = (short)107639181;
				short num3 = num;
				num = (short)1910862221;
				switch (num3 == num)
				{
				}
				num = (short)2030436352;
				if (num != 0)
				{
				}
				num = (short)1181548545;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21IndexUIValueProperty, value);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00030C98 File Offset: 0x0002EE98
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00030D50 File Offset: 0x0002EF50
		public AcpRangeField<int, int> DEKButton21IndexRange
		{
			get
			{
				short num = (short)1901854720;
				short num2 = num;
				num = (short)52112258;
				short num3 = num;
				num = (short)145632130;
				switch (num3 == num)
				{
				}
				num = (short)310247425;
				if (num != 0)
				{
				}
				num = (short)1274216448;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton21IndexRangeProperty);
			}
			set
			{
				short num = (short)174063616;
				short num2 = num;
				num = (short)1212839845;
				short num3 = num;
				num = (short)487225253;
				switch (num3 == num)
				{
				}
				num = (short)867237889;
				if (num != 0)
				{
				}
				num = (short)1649672192;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21IndexRangeProperty, value);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00030E04 File Offset: 0x0002F004
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00030EBC File Offset: 0x0002F0BC
		public bool DEKButton21ZoneIsAcpValid
		{
			get
			{
				short num = (short)554106880;
				short num2 = num;
				num = (short)1976744495;
				short num3 = num;
				num = (short)1034402351;
				switch (num3 == num)
				{
				}
				num = (short)774504448;
				if (num != 0)
				{
				}
				num = (short)708968449;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)1398210560;
				short num2 = num;
				num = (short)633456578;
				short num3 = num;
				num = (short)1009043394;
				switch (num3 == num)
				{
				}
				num = (short)431882240;
				if (num != 0)
				{
				}
				num = (short)968949761;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00030F78 File Offset: 0x0002F178
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00031030 File Offset: 0x0002F230
		public bool DEKButton21ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)928120832;
				short num2 = num;
				num = (short)1763406755;
				short num3 = num;
				num = (short)557151139;
				switch (num3 == num)
				{
				}
				num = (short)681836545;
				if (num != 0)
				{
				}
				num = (short)571539456;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)357302272;
				short num2 = num;
				num = (short)1304071399;
				short num3 = num;
				num = (short)685411559;
				switch (num3 == num)
				{
				}
				num = (short)2003238913;
				if (num != 0)
				{
				}
				num = (short)1077477376;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x000310EC File Offset: 0x0002F2EC
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x000311A4 File Offset: 0x0002F3A4
		public bool DEKButton21ZoneIsAcpVisible
		{
			get
			{
				short num = (short)1738539008;
				short num2 = num;
				num = (short)165702093;
				short num3 = num;
				num = (short)1029728717;
				switch (num3 == num)
				{
				}
				num = (short)1820590081;
				if (num != 0)
				{
				}
				num = (short)1797455872;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1559232512;
				short num2 = num;
				num = (short)1545469953;
				if (num != 0)
				{
				}
				num = (short)1501860382;
				short num3 = num;
				num = (short)399413790;
				switch (num3 == num)
				{
				}
				num = (short)338427904;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00031260 File Offset: 0x0002F460
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00031318 File Offset: 0x0002F518
		public bool DEKButton21ZoneIsAcpEditable
		{
			get
			{
				short num = (short)1138819072;
				short num2 = num;
				num = (short)635371521;
				if (num != 0)
				{
				}
				num = (short)1647744547;
				short num3 = num;
				num = (short)42964515;
				switch (num3 == num)
				{
				}
				num = (short)314441728;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)399507456;
				short num2 = num;
				num = (short)1777769422;
				short num3 = num;
				num = (short)1297914830;
				switch (num3 == num)
				{
				}
				num = (short)1561722881;
				if (num != 0)
				{
				}
				num = (short)1433927680;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x000313D4 File Offset: 0x0002F5D4
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00031490 File Offset: 0x0002F690
		public string DEKButton21ZoneUIValue
		{
			get
			{
				short num = (short)416481280;
				short num2 = num;
				num = (short)1937490814;
				short num3 = num;
				num = (short)737133438;
				switch (num3 == num)
				{
				}
				num = (short)1229848576;
				if (num != 0)
				{
				}
				num = (short)401670145;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton21ZoneUIValueProperty);
			}
			set
			{
				short num = (short)1722482688;
				short num2 = num;
				num = (short)1231368913;
				short num3 = num;
				num = (short)1159475921;
				switch (num3 == num)
				{
				}
				num = (short)1861222401;
				if (num != 0)
				{
				}
				num = (short)1601961984;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21ZoneUIValueProperty, value);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00031548 File Offset: 0x0002F748
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00031600 File Offset: 0x0002F800
		public AcpListField DEKButton21ZoneList
		{
			get
			{
				short num = (short)830537728;
				short num2 = num;
				num = (short)500612448;
				short num3 = num;
				num = (short)1667546464;
				switch (num3 == num)
				{
				}
				num = (short)1605304321;
				if (num != 0)
				{
				}
				num = (short)484835328;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton21ZoneListProperty);
			}
			set
			{
				short num = (short)29753344;
				short num2 = num;
				num = (short)1370831213;
				short num3 = num;
				num = (short)533674349;
				switch (num3 == num)
				{
				}
				num = (short)2028797952;
				if (num != 0)
				{
				}
				num = (short)1154220033;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21ZoneListProperty, value);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x000316B0 File Offset: 0x0002F8B0
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x0003176C File Offset: 0x0002F96C
		public bool DEKButton21ChannelIsAcpValid
		{
			get
			{
				short num = (short)774963200;
				short num2 = num;
				num = (short)2053808638;
				short num3 = num;
				num = (short)755671550;
				switch (num3 == num)
				{
				}
				num = (short)1779499009;
				if (num != 0)
				{
				}
				num = (short)659357696;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)738328576;
				short num2 = num;
				num = (short)179536902;
				short num3 = num;
				num = (short)1727431686;
				switch (num3 == num)
				{
				}
				num = (short)1284833281;
				if (num != 0)
				{
				}
				num = (short)2003697664;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00031824 File Offset: 0x0002FA24
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x000318E0 File Offset: 0x0002FAE0
		public bool DEKButton21ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)566296576;
				short num2 = num;
				num = (short)1761558696;
				short num3 = num;
				num = (short)790905000;
				switch (num3 == num)
				{
				}
				num = (short)637927424;
				if (num != 0)
				{
				}
				num = (short)970194945;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1725300736;
				short num2 = num;
				num = (short)1779631429;
				short num3 = num;
				num = (short)144180549;
				switch (num3 == num)
				{
				}
				num = (short)2084306945;
				if (num != 0)
				{
				}
				num = (short)1278279680;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00031998 File Offset: 0x0002FB98
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00031A50 File Offset: 0x0002FC50
		public bool DEKButton21ChannelIsAcpVisible
		{
			get
			{
				short num = (short)2141913088;
				short num2 = num;
				num = (short)2139745994;
				short num3 = num;
				num = (short)2025647818;
				switch (num3 == num)
				{
				}
				num = (short)1986985985;
				if (num != 0)
				{
				}
				num = (short)736624640;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2094268416;
				short num2 = num;
				num = (short)1281030869;
				short num3 = num;
				num = (short)1046149845;
				switch (num3 == num)
				{
				}
				num = (short)914423809;
				if (num != 0)
				{
				}
				num = (short)338952192;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00031B0C File Offset: 0x0002FD0C
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00031BC8 File Offset: 0x0002FDC8
		public bool DEKButton21ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1999241216;
				short num2 = num;
				num = (short)865405747;
				short num3 = num;
				num = (short)748620595;
				switch (num3 == num)
				{
				}
				num = (short)1155923968;
				if (num != 0)
				{
				}
				num = (short)61538305;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton21ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)496959488;
				short num2 = num;
				num = (short)710279169;
				if (num != 0)
				{
				}
				num = (short)813839182;
				short num3 = num;
				num = (short)967783246;
				switch (num3 == num)
				{
				}
				num = (short)1304166400;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00031C80 File Offset: 0x0002FE80
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00031D38 File Offset: 0x0002FF38
		public string DEKButton21ChannelUIValue
		{
			get
			{
				short num = (short)780795904;
				short num2 = num;
				num = (short)1729563146;
				short num3 = num;
				num = (short)1766590986;
				switch (num3 == num)
				{
				}
				num = (short)1272119297;
				if (num != 0)
				{
				}
				num = (short)1159593984;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton21ChannelUIValueProperty);
			}
			set
			{
				short num = (short)1539047424;
				short num2 = num;
				num = (short)1274627493;
				short num3 = num;
				num = (short)573719973;
				switch (num3 == num)
				{
				}
				num = (short)1445462017;
				if (num != 0)
				{
				}
				num = (short)1635778560;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21ChannelUIValueProperty, value);
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00031DEC File Offset: 0x0002FFEC
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00031EA4 File Offset: 0x000300A4
		public AcpListField DEKButton21ChannelList
		{
			get
			{
				short num = (short)1629618176;
				short num2 = num;
				num = (short)1316721861;
				short num3 = num;
				num = (short)61641925;
				switch (num3 == num)
				{
				}
				num = (short)1159725056;
				if (num != 0)
				{
				}
				num = (short)1983381505;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton21ChannelListProperty);
			}
			set
			{
				short num = (short)1369964544;
				short num2 = num;
				num = (short)1318908167;
				short num3 = num;
				num = (short)461697287;
				switch (num3 == num)
				{
				}
				num = (short)2143092737;
				if (num != 0)
				{
				}
				num = (short)589889536;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton21ChannelListProperty, value);
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00031F58 File Offset: 0x00030158
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00032010 File Offset: 0x00030210
		public bool DEKButton22FeatureIsAcpValid
		{
			get
			{
				short num = (short)186712064;
				short num2 = num;
				num = (short)2047304161;
				short num3 = num;
				num = (short)1815634401;
				switch (num3 == num)
				{
				}
				num = (short)1875050497;
				if (num != 0)
				{
				}
				num = (short)483721216;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton22FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)569507840;
				short num2 = num;
				num = (short)152203966;
				short num3 = num;
				num = (short)1783853758;
				switch (num3 == num)
				{
				}
				num = (short)130023424;
				if (num != 0)
				{
				}
				num = (short)983105537;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton22FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x000320C8 File Offset: 0x000302C8
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00032180 File Offset: 0x00030380
		public bool DEKButton22FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)559808512;
				short num2 = num;
				num = (short)416139102;
				short num3 = num;
				num = (short)878298974;
				switch (num3 == num)
				{
				}
				num = (short)1208614912;
				if (num != 0)
				{
				}
				num = (short)1590231041;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton22FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)510525440;
				short num2 = num;
				num = (short)378601473;
				if (num != 0)
				{
				}
				num = (short)1787649823;
				short num3 = num;
				num = (short)900751135;
				switch (num3 == num)
				{
				}
				num = (short)1000931328;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton22FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0003223C File Offset: 0x0003043C
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x000322F8 File Offset: 0x000304F8
		public bool DEKButton22FeatureIsAcpVisible
		{
			get
			{
				short num = (short)748670241;
				short num2 = num;
				num = (short)2026425633;
				switch (num2 == num)
				{
				}
				num = (short)568524800;
				if (num != 0)
				{
				}
				num = (short)867041281;
				if (num != 0)
				{
				}
				num = (short)231276544;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1941270467;
				short num2 = num;
				num = (short)673607619;
				switch (num2 == num)
				{
				}
				num = (short)467140609;
				if (num != 0)
				{
				}
				num = (short)2017132544;
				if (num != 0)
				{
				}
				num = (short)611844096;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x000323B0 File Offset: 0x000305B0
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00032470 File Offset: 0x00030670
		public bool DEKButton22FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1342228016;
				short num2 = num;
				num = (short)118343216;
				switch (num2 == num)
				{
				}
				num = (short)1573519361;
				if (num != 0)
				{
				}
				num = (short)1328218112;
				if (num != 0)
				{
				}
				num = (short)2056126464;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)344538335;
				short num2 = num;
				num = (short)798768351;
				switch (num2 == num)
				{
				}
				num = (short)1767309313;
				if (num != 0)
				{
				}
				num = (short)1796931584;
				if (num != 0)
				{
				}
				num = (short)804454400;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00032528 File Offset: 0x00030728
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x000325E0 File Offset: 0x000307E0
		public string DEKButton22FeatureUIValue
		{
			get
			{
				short num = (short)1924567759;
				short num2 = num;
				num = (short)952996559;
				switch (num2 == num)
				{
				}
				num = (short)1367605249;
				if (num != 0)
				{
				}
				num = (short)1264517120;
				if (num != 0)
				{
				}
				num = (short)1008271360;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton22FeatureUIValueProperty);
			}
			set
			{
				short num = (short)745872140;
				short num2 = num;
				num = (short)733027084;
				switch (num2 == num)
				{
				}
				num = (short)417464320;
				if (num != 0)
				{
				}
				num = (short)950009857;
				if (num != 0)
				{
				}
				num = (short)139722752;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00032698 File Offset: 0x00030898
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00032750 File Offset: 0x00030950
		public AcpListField DEKButton22FeatureList
		{
			get
			{
				short num = (short)882590134;
				short num2 = num;
				num = (short)821576118;
				switch (num2 == num)
				{
				}
				num = (short)37552128;
				if (num != 0)
				{
				}
				num = (short)634978305;
				if (num != 0)
				{
				}
				num = (short)970784768;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton22FeatureListProperty);
			}
			set
			{
				short num = (short)2105303667;
				short num2 = num;
				num = (short)902455923;
				switch (num2 == num)
				{
				}
				num = (short)348061696;
				if (num != 0)
				{
				}
				num = (short)864026625;
				if (num != 0)
				{
				}
				num = (short)413663232;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22FeatureListProperty, value);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00032808 File Offset: 0x00030A08
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x000328C4 File Offset: 0x00030AC4
		public bool DEKButton22IndexIsAcpValid
		{
			get
			{
				short num = (short)1501707558;
				short num2 = num;
				num = (short)1689664806;
				switch (num2 == num)
				{
				}
				num = (short)1737752577;
				if (num != 0)
				{
				}
				num = (short)478740480;
				if (num != 0)
				{
				}
				num = (short)1823277056;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1039204353;
				if (num != 0)
				{
				}
				num = (short)2109432840;
				short num2 = num;
				num = (short)43279368;
				switch (num2 == num)
				{
				}
				num = (short)1523580928;
				if (num != 0)
				{
				}
				num = (short)2011234304;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00032980 File Offset: 0x00030B80
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00032A3C File Offset: 0x00030C3C
		public bool DEKButton22IndexIsAcpApplicable
		{
			get
			{
				short num = (short)553624985;
				short num2 = num;
				num = (short)1562027417;
				switch (num2 == num)
				{
				}
				num = (short)746979329;
				if (num != 0)
				{
				}
				num = (short)666042368;
				if (num != 0)
				{
				}
				num = (short)787152896;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1579995868;
				short num2 = num;
				num = (short)1557320412;
				switch (num2 == num)
				{
				}
				num = (short)992935937;
				if (num != 0)
				{
				}
				num = (short)1492516864;
				if (num != 0)
				{
				}
				num = (short)803930112;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00032AF8 File Offset: 0x00030CF8
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00032BB0 File Offset: 0x00030DB0
		public bool DEKButton22IndexIsAcpVisible
		{
			get
			{
				short num = (short)1594940173;
				short num2 = num;
				num = (short)1633999629;
				switch (num2 == num)
				{
				}
				num = (short)1146945537;
				if (num != 0)
				{
				}
				num = (short)916389888;
				if (num != 0)
				{
				}
				num = (short)2057830400;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)712157136;
				short num2 = num;
				num = (short)43100112;
				switch (num2 == num)
				{
				}
				num = (short)1192296449;
				if (num != 0)
				{
				}
				num = (short)470089728;
				if (num != 0)
				{
				}
				num = (short)544473088;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00032C68 File Offset: 0x00030E68
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00032D20 File Offset: 0x00030F20
		public bool DEKButton22IndexIsAcpEditable
		{
			get
			{
				short num = (short)1720944095;
				short num2 = num;
				num = (short)1327072735;
				switch (num2 == num)
				{
				}
				num = (short)1030684672;
				if (num != 0)
				{
				}
				num = (short)406192129;
				if (num != 0)
				{
				}
				num = (short)599719936;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)772669441;
				if (num != 0)
				{
				}
				num = (short)37296891;
				short num2 = num;
				num = (short)1989090043;
				switch (num2 == num)
				{
				}
				num = (short)131792896;
				if (num != 0)
				{
				}
				num = (short)820445184;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00032DD8 File Offset: 0x00030FD8
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00032E94 File Offset: 0x00031094
		public string DEKButton22IndexUIValue
		{
			get
			{
				short num = (short)1015509227;
				short num2 = num;
				num = (short)1654223083;
				switch (num2 == num)
				{
				}
				num = (short)1950613505;
				if (num != 0)
				{
				}
				num = (short)2046427136;
				if (num != 0)
				{
				}
				num = (short)299106304;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton22IndexUIValueProperty);
			}
			set
			{
				short num = (short)2002963229;
				short num2 = num;
				num = (short)2018560797;
				switch (num2 == num)
				{
				}
				num = (short)1193803777;
				if (num != 0)
				{
				}
				num = (short)997851136;
				if (num != 0)
				{
				}
				num = (short)932904960;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22IndexUIValueProperty, value);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00032F4C File Offset: 0x0003114C
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00033004 File Offset: 0x00031204
		public AcpRangeField<int, int> DEKButton22IndexRange
		{
			get
			{
				short num = (short)39581092;
				short num2 = num;
				num = (short)218101156;
				switch (num2 == num)
				{
				}
				num = (short)1022951424;
				if (num != 0)
				{
				}
				num = (short)869990401;
				if (num != 0)
				{
				}
				num = (short)815923200;
				short num3 = num;
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton22IndexRangeProperty);
			}
			set
			{
				short num = (short)378846670;
				short num2 = num;
				num = (short)1154727374;
				switch (num2 == num)
				{
				}
				num = (short)1669922817;
				if (num != 0)
				{
				}
				num = (short)171245568;
				if (num != 0)
				{
				}
				num = (short)1247281152;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22IndexRangeProperty, value);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x000330B8 File Offset: 0x000312B8
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00033170 File Offset: 0x00031370
		public bool DEKButton22ZoneIsAcpValid
		{
			get
			{
				short num = (short)643612018;
				short num2 = num;
				num = (short)459324786;
				switch (num2 == num)
				{
				}
				num = (short)546963457;
				if (num != 0)
				{
				}
				num = (short)725745664;
				if (num != 0)
				{
				}
				num = (short)2136735744;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)45528151;
				short num2 = num;
				num = (short)1936307287;
				switch (num2 == num)
				{
				}
				num = (short)2014183425;
				if (num != 0)
				{
				}
				num = (short)698875904;
				if (num != 0)
				{
				}
				num = (short)788529152;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0003322C File Offset: 0x0003142C
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x000332E4 File Offset: 0x000314E4
		public bool DEKButton22ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)2101630358;
				short num2 = num;
				num = (short)1393382806;
				switch (num2 == num)
				{
				}
				num = (short)1149108225;
				if (num != 0)
				{
				}
				num = (short)74645504;
				if (num != 0)
				{
				}
				num = (short)1443430400;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)822923071;
				short num2 = num;
				num = (short)2129710911;
				switch (num2 == num)
				{
				}
				num = (short)127205377;
				if (num != 0)
				{
				}
				num = (short)1156448256;
				if (num != 0)
				{
				}
				num = (short)252444672;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x000333A0 File Offset: 0x000315A0
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00033458 File Offset: 0x00031658
		public bool DEKButton22ZoneIsAcpVisible
		{
			get
			{
				short num = (short)539099137;
				if (num != 0)
				{
				}
				num = (short)545220185;
				short num2 = num;
				num = (short)818177625;
				switch (num2 == num)
				{
				}
				num = (short)1533345792;
				if (num != 0)
				{
				}
				num = (short)2091646976;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)123535361;
				if (num != 0)
				{
				}
				num = (short)1118631987;
				short num2 = num;
				num = (short)1375008819;
				switch (num2 == num)
				{
				}
				num = (short)1696333824;
				if (num != 0)
				{
				}
				num = (short)331874304;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00033514 File Offset: 0x00031714
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x000335D0 File Offset: 0x000317D0
		public bool DEKButton22ZoneIsAcpEditable
		{
			get
			{
				short num = (short)848063899;
				short num2 = num;
				num = (short)371158427;
				switch (num2 == num)
				{
				}
				num = (short)204996608;
				if (num != 0)
				{
				}
				num = (short)182976513;
				if (num != 0)
				{
				}
				num = (short)585564160;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2057008265;
				short num2 = num;
				num = (short)2049995913;
				switch (num2 == num)
				{
				}
				num = (short)585433089;
				if (num != 0)
				{
				}
				num = (short)1278148608;
				if (num != 0)
				{
				}
				num = (short)1302265856;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00033690 File Offset: 0x00031890
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x00033748 File Offset: 0x00031948
		public string DEKButton22ZoneUIValue
		{
			get
			{
				short num = (short)421330945;
				if (num != 0)
				{
				}
				num = (short)1932931836;
				short num2 = num;
				num = (short)245510908;
				switch (num2 == num)
				{
				}
				num = (short)1154351104;
				if (num != 0)
				{
				}
				num = (short)1554776064;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton22ZoneUIValueProperty);
			}
			set
			{
				short num = (short)131530753;
				if (num != 0)
				{
				}
				num = (short)825459355;
				short num2 = num;
				num = (short)671187611;
				switch (num2 == num)
				{
				}
				num = (short)1521025024;
				if (num != 0)
				{
				}
				num = (short)760807424;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22ZoneUIValueProperty, value);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x000337FC File Offset: 0x000319FC
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x000338B4 File Offset: 0x00031AB4
		public AcpListField DEKButton22ZoneList
		{
			get
			{
				short num = (short)95890181;
				short num2 = num;
				num = (short)1428957957;
				switch (num2 == num)
				{
				}
				num = (short)1108410369;
				if (num != 0)
				{
				}
				num = (short)277413888;
				if (num != 0)
				{
				}
				num = (short)1471217664;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton22ZoneListProperty);
			}
			set
			{
				short num = (short)1700329231;
				short num2 = num;
				num = (short)642250511;
				switch (num2 == num)
				{
				}
				num = (short)660275201;
				if (num != 0)
				{
				}
				num = (short)1569193984;
				if (num != 0)
				{
				}
				num = (short)2114846720;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22ZoneListProperty, value);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x00033968 File Offset: 0x00031B68
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00033A20 File Offset: 0x00031C20
		public bool DEKButton22ChannelIsAcpValid
		{
			get
			{
				short num = (short)1097662465;
				if (num != 0)
				{
				}
				num = (short)1148832447;
				short num2 = num;
				num = (short)650889919;
				switch (num2 == num)
				{
				}
				num = (short)1864957952;
				if (num != 0)
				{
				}
				num = (short)1383792640;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)2065708804;
				short num2 = num;
				num = (short)795424516;
				switch (num2 == num)
				{
				}
				num = (short)1662386176;
				if (num != 0)
				{
				}
				num = (short)1763442689;
				if (num != 0)
				{
				}
				num = (short)1619001344;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00033ADC File Offset: 0x00031CDC
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00033B98 File Offset: 0x00031D98
		public bool DEKButton22ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)1981796013;
				short num2 = num;
				num = (short)78368429;
				switch (num2 == num)
				{
				}
				num = (short)1596063744;
				if (num != 0)
				{
				}
				num = (short)652935169;
				if (num != 0)
				{
				}
				num = (short)1940652032;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1444565946;
				short num2 = num;
				num = (short)1739281338;
				switch (num2 == num)
				{
				}
				num = (short)950075393;
				if (num != 0)
				{
				}
				num = (short)823590912;
				if (num != 0)
				{
				}
				num = (short)673513472;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00033C54 File Offset: 0x00031E54
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x00033D0C File Offset: 0x00031F0C
		public bool DEKButton22ChannelIsAcpVisible
		{
			get
			{
				short num = (short)243362977;
				short num2 = num;
				num = (short)126839969;
				switch (num2 == num)
				{
				}
				num = (short)429981696;
				if (num != 0)
				{
				}
				num = (short)513081345;
				if (num != 0)
				{
				}
				num = (short)179503104;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1059487873;
				short num2 = num;
				num = (short)457146497;
				switch (num2 == num)
				{
				}
				num = (short)311558144;
				if (num != 0)
				{
				}
				num = (short)152240129;
				if (num != 0)
				{
				}
				num = (short)1980760064;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00033DC8 File Offset: 0x00031FC8
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00033E80 File Offset: 0x00032080
		public bool DEKButton22ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1837082270;
				short num2 = num;
				num = (short)2145756830;
				switch (num2 == num)
				{
				}
				num = (short)1163198465;
				if (num != 0)
				{
				}
				num = (short)1804992512;
				if (num != 0)
				{
				}
				num = (short)1090191360;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton22ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)390170353;
				short num2 = num;
				num = (short)1959167729;
				switch (num2 == num)
				{
				}
				num = (short)1678180353;
				if (num != 0)
				{
				}
				num = (short)52559872;
				if (num != 0)
				{
				}
				num = (short)2100035584;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00033F38 File Offset: 0x00032138
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00033FF4 File Offset: 0x000321F4
		public string DEKButton22ChannelUIValue
		{
			get
			{
				short num = (short)1121141328;
				short num2 = num;
				num = (short)1170752080;
				switch (num2 == num)
				{
				}
				num = (short)1446838272;
				if (num != 0)
				{
				}
				num = (short)17498113;
				if (num != 0)
				{
				}
				num = (short)2035351552;
				short num3 = num;
				return (string)base.GetValue(DEKGraphicView.DEKButton22ChannelUIValueProperty);
			}
			set
			{
				short num = (short)1319174145;
				if (num != 0)
				{
				}
				num = (short)47636021;
				short num2 = num;
				num = (short)1352064565;
				switch (num2 == num)
				{
				}
				num = (short)776011776;
				if (num != 0)
				{
				}
				num = (short)1631387648;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22ChannelUIValueProperty, value);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x000340AC File Offset: 0x000322AC
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00034168 File Offset: 0x00032368
		public AcpListField DEKButton22ChannelList
		{
			get
			{
				short num = (short)1249953822;
				short num2 = num;
				num = (short)1447151646;
				switch (num2 == num)
				{
				}
				num = (short)759037953;
				if (num != 0)
				{
				}
				num = (short)724631552;
				if (num != 0)
				{
				}
				num = (short)711458816;
				short num3 = num;
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton22ChannelListProperty);
			}
			set
			{
				short num = (short)1307871937;
				short num2 = num;
				num = (short)1271040705;
				switch (num2 == num)
				{
				}
				num = (short)1650262017;
				if (num != 0)
				{
				}
				num = (short)1716584448;
				if (num != 0)
				{
				}
				num = (short)305135616;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton22ChannelListProperty, value);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0003421C File Offset: 0x0003241C
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x000342D8 File Offset: 0x000324D8
		public bool DEKButton23FeatureIsAcpValid
		{
			get
			{
				short num = (short)1410684220;
				short num2 = num;
				num = (short)317543740;
				switch (num2 == num)
				{
				}
				num = (short)1046347777;
				if (num != 0)
				{
				}
				num = (short)703135744;
				if (num != 0)
				{
				}
				num = (short)1244463104;
				short num3 = num;
				return (bool)base.GetValue(DEKGraphicView.DEKButton23FeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)282540118;
				short num2 = num;
				num = (short)999241814;
				switch (num2 == num)
				{
				}
				num = (short)1290665985;
				if (num != 0)
				{
				}
				num = (short)1169358848;
				if (num != 0)
				{
				}
				num = (short)919666688;
				short num3 = num;
				base.SetValue(DEKGraphicView.DEKButton23FeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00034394 File Offset: 0x00032594
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00034450 File Offset: 0x00032650
		public bool DEKButton23FeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1602771009;
				short num2 = num;
				num = (short)1257855041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)378273792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1246560257;
				if (num != 0)
				{
				}
				num = (short)1487994880;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23FeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)451633721;
				short num2 = num;
				num = (short)1177510457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2040987648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)583925761;
				if (num != 0)
				{
				}
				num = (short)1914044416;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23FeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0003450C File Offset: 0x0003270C
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x000345C4 File Offset: 0x000327C4
		public bool DEKButton23FeatureIsAcpVisible
		{
			get
			{
				short num = (short)451854277;
				short num2 = num;
				num = (short)1358544837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)290848768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2051145729;
				if (num != 0)
				{
				}
				num = (short)1564278784;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23FeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)859797962;
				short num2 = num;
				num = (short)103184842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1320615936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1906573312;
				if (num != 0)
				{
				}
				num = (short)807206913;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23FeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00034680 File Offset: 0x00032880
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x0003473C File Offset: 0x0003293C
		public bool DEKButton23FeatureIsAcpEditable
		{
			get
			{
				short num = (short)1913290780;
				short num2 = num;
				num = (short)505774108;
				switch (num2 == num)
				{
				default:
				{
					num = (short)824180736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)299040769;
				if (num != 0)
				{
				}
				num = (short)1700659200;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23FeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1639945923;
				short num2 = num;
				num = (short)1785960131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964507136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)793575425;
				if (num != 0)
				{
				}
				num = (short)248643584;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23FeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x000347F4 File Offset: 0x000329F4
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x000348AC File Offset: 0x00032AAC
		public string DEKButton23FeatureUIValue
		{
			get
			{
				short num = (short)1501855001;
				short num2 = num;
				num = (short)1025735961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)562102272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)540868608;
				if (num != 0)
				{
				}
				num = (short)476119041;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton23FeatureUIValueProperty);
			}
			set
			{
				short num = (short)1376389520;
				short num2 = num;
				num = (short)782371216;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1424818176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1437597697;
				if (num != 0)
				{
				}
				num = (short)1895825408;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23FeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00034964 File Offset: 0x00032B64
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00034A1C File Offset: 0x00032C1C
		public AcpListField DEKButton23FeatureList
		{
			get
			{
				short num = (short)209822124;
				short num2 = num;
				num = (short)1586667948;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2141388800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1808138240;
				if (num != 0)
				{
				}
				num = (short)1478623233;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton23FeatureListProperty);
			}
			set
			{
				short num = (short)1804409033;
				short num2 = num;
				num = (short)2059933897;
				switch (num2 == num)
				{
				default:
				{
					num = (short)11927552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1737818113;
				if (num != 0)
				{
				}
				num = (short)1533214720;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23FeatureListProperty, value);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00034AD0 File Offset: 0x00032CD0
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00034B8C File Offset: 0x00032D8C
		public bool DEKButton23IndexIsAcpValid
		{
			get
			{
				short num = (short)933698093;
				short num2 = num;
				num = (short)1555241517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)15925248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1968504833;
				if (num != 0)
				{
				}
				num = (short)1258029056;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23IndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)175243265;
				if (num != 0)
				{
				}
				num = (short)44433408;
				short num2 = num;
				num = (short)1231681265;
				short num3 = num;
				num = (short)1611265777;
				switch (num3 == num)
				{
				}
				num = (short)510787584;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23IndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00034C48 File Offset: 0x00032E48
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00034D00 File Offset: 0x00032F00
		public bool DEKButton23IndexIsAcpApplicable
		{
			get
			{
				short num = (short)1602737797;
				short num2 = num;
				num = (short)1223284357;
				switch (num2 == num)
				{
				default:
				{
					num = (short)357761024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)125894657;
				if (num != 0)
				{
				}
				num = (short)50593792;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23IndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1316985499;
				short num2 = num;
				num = (short)612145819;
				switch (num2 == num)
				{
				default:
				{
					num = (short)426377216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2144534529;
				if (num != 0)
				{
				}
				num = (short)1589510144;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23IndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00034DBC File Offset: 0x00032FBC
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00034E74 File Offset: 0x00033074
		public bool DEKButton23IndexIsAcpVisible
		{
			get
			{
				short num = (short)1437270017;
				if (num != 0)
				{
				}
				num = (short)1878065152;
				short num2 = num;
				num = (short)111193457;
				short num3 = num;
				num = (short)1695526257;
				switch (num3 == num)
				{
				}
				num = (short)1324351488;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23IndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)822005036;
				short num2 = num;
				num = (short)1428278572;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1539833856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)816906241;
				if (num != 0)
				{
				}
				num = (short)405864448;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23IndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00034F30 File Offset: 0x00033130
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00034FEC File Offset: 0x000331EC
		public bool DEKButton23IndexIsAcpEditable
		{
			get
			{
				short num = (short)161099638;
				short num2 = num;
				num = (short)958803830;
				switch (num2 == num)
				{
				default:
				{
					num = (short)444203008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)5832704;
				if (num != 0)
				{
				}
				num = (short)477298689;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23IndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)667138699;
				short num2 = num;
				num = (short)1337571979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)789250048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)536739841;
				if (num != 0)
				{
				}
				num = (short)474873856;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23IndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x000350A8 File Offset: 0x000332A8
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00035160 File Offset: 0x00033360
		public string DEKButton23IndexUIValue
		{
			get
			{
				short num = (short)738015491;
				short num2 = num;
				num = (short)2076653827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1487994880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)454885376;
				if (num != 0)
				{
				}
				num = (short)468975617;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton23IndexUIValueProperty);
			}
			set
			{
				short num = (short)2085006986;
				short num2 = num;
				num = (short)1600106122;
				switch (num2 == num)
				{
				default:
				{
					num = (short)59375616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1961623553;
				if (num != 0)
				{
				}
				num = (short)1433796608;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23IndexUIValueProperty, value);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00035218 File Offset: 0x00033418
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x000352D0 File Offset: 0x000334D0
		public AcpRangeField<int, int> DEKButton23IndexRange
		{
			get
			{
				short num = (short)1534199836;
				short num2 = num;
				num = (short)1454180380;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1773273088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1134624769;
				if (num != 0)
				{
				}
				num = (short)1616576512;
				if (num != 0)
				{
				}
				return (AcpRangeField<int, int>)base.GetValue(DEKGraphicView.DEKButton23IndexRangeProperty);
			}
			set
			{
				short num = (short)69313544;
				short num2 = num;
				num = (short)1290904584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1944846336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)186449921;
				if (num != 0)
				{
				}
				num = (short)808058880;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23IndexRangeProperty, value);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00035388 File Offset: 0x00033588
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00035440 File Offset: 0x00033640
		public bool DEKButton23ZoneIsAcpValid
		{
			get
			{
				short num = (short)367778082;
				short num2 = num;
				num = (short)674355490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)747307008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1915748353;
				if (num != 0)
				{
				}
				num = (short)2111111168;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23ZoneIsAcpValidProperty);
			}
			set
			{
				short num = (short)1257124389;
				short num2 = num;
				num = (short)139473445;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2040201216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2030108672;
				if (num != 0)
				{
				}
				num = (short)1012858881;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23ZoneIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x000354FC File Offset: 0x000336FC
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x000355B4 File Offset: 0x000337B4
		public bool DEKButton23ZoneIsAcpApplicable
		{
			get
			{
				short num = (short)2013048410;
				short num2 = num;
				num = (short)1906159194;
				switch (num2 == num)
				{
				default:
				{
					num = (short)124846080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1412825089;
				if (num != 0)
				{
				}
				num = (short)299630592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23ZoneIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)189198441;
				short num2 = num;
				num = (short)864874601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)707854336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1363476481;
				if (num != 0)
				{
				}
				num = (short)1522204672;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23ZoneIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0003566C File Offset: 0x0003386C
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00035724 File Offset: 0x00033924
		public bool DEKButton23ZoneIsAcpVisible
		{
			get
			{
				short num = (short)281355390;
				short num2 = num;
				num = (short)25306238;
				switch (num2 == num)
				{
				default:
				{
					num = (short)521076736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)851771393;
				if (num != 0)
				{
				}
				num = (short)1346502656;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23ZoneIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1989832371;
				short num2 = num;
				num = (short)2066181811;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1748959232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)71368705;
				if (num != 0)
				{
				}
				num = (short)1893007360;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23ZoneIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x000357DC File Offset: 0x000339DC
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x00035898 File Offset: 0x00033A98
		public bool DEKButton23ZoneIsAcpEditable
		{
			get
			{
				short num = (short)352942973;
				short num2 = num;
				num = (short)1934130045;
				switch (num2 == num)
				{
				default:
				{
					num = (short)595460096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)268566529;
				if (num != 0)
				{
				}
				num = (short)979566592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23ZoneIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1066262332;
				short num2 = num;
				num = (short)1263001404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)481492992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)515244033;
				if (num != 0)
				{
				}
				num = (short)780533760;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23ZoneIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00035954 File Offset: 0x00033B54
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00035A10 File Offset: 0x00033C10
		public string DEKButton23ZoneUIValue
		{
			get
			{
				short num = (short)1120136249;
				short num2 = num;
				num = (short)223603769;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1792540672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)590741504;
				if (num != 0)
				{
				}
				num = (short)1390936065;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton23ZoneUIValueProperty);
			}
			set
			{
				short num = (short)354929365;
				short num2 = num;
				num = (short)1675872981;
				switch (num2 == num)
				{
				default:
				{
					num = (short)619315200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1250689024;
				if (num != 0)
				{
				}
				num = (short)1562116097;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23ZoneUIValueProperty, value);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00035AC8 File Offset: 0x00033CC8
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x00035B80 File Offset: 0x00033D80
		public AcpListField DEKButton23ZoneList
		{
			get
			{
				short num = (short)29522434;
				short num2 = num;
				num = (short)643791362;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1834811392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)481820672;
				if (num != 0)
				{
				}
				num = (short)1406074881;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton23ZoneListProperty);
			}
			set
			{
				short num = (short)267660802;
				short num2 = num;
				num = (short)1459564034;
				switch (num2 == num)
				{
				default:
				{
					num = (short)251199488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1238368256;
				if (num != 0)
				{
				}
				num = (short)564002817;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23ZoneListProperty, value);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00035C38 File Offset: 0x00033E38
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00035CF4 File Offset: 0x00033EF4
		public bool DEKButton23ChannelIsAcpValid
		{
			get
			{
				short num = (short)1499111410;
				short num2 = num;
				num = (short)1744478194;
				switch (num2 == num)
				{
				default:
				{
					num = (short)468058112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)721092609;
				if (num != 0)
				{
				}
				num = (short)817889280;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23ChannelIsAcpValidProperty);
			}
			set
			{
				short num = (short)1915423585;
				short num2 = num;
				num = (short)1579879265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)763232256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1353187329;
				if (num != 0)
				{
				}
				num = (short)1455489024;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23ChannelIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00035DAC File Offset: 0x00033FAC
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00035E68 File Offset: 0x00034068
		public bool DEKButton23ChannelIsAcpApplicable
		{
			get
			{
				short num = (short)753448132;
				short num2 = num;
				num = (short)1983755460;
				switch (num2 == num)
				{
				default:
				{
					num = (short)180813824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)193265665;
				if (num != 0)
				{
				}
				num = (short)1094975488;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23ChannelIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1647360306;
				short num2 = num;
				num = (short)1680980274;
				switch (num2 == num)
				{
				default:
				{
					num = (short)484442112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)967245825;
				if (num != 0)
				{
				}
				num = (short)1765015552;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23ChannelIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00035F20 File Offset: 0x00034120
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00035FD8 File Offset: 0x000341D8
		public bool DEKButton23ChannelIsAcpVisible
		{
			get
			{
				short num = (short)1377698430;
				short num2 = num;
				num = (short)2027487870;
				switch (num2 == num)
				{
				default:
				{
					num = (short)482213888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)809893888;
				if (num != 0)
				{
				}
				num = (short)1181876225;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23ChannelIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)818385986;
				short num2 = num;
				num = (short)806720578;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1342373888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1903427585;
				if (num != 0)
				{
				}
				num = (short)666763264;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23ChannelIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00036094 File Offset: 0x00034294
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00036150 File Offset: 0x00034350
		public bool DEKButton23ChannelIsAcpEditable
		{
			get
			{
				short num = (short)1995536885;
				short num2 = num;
				num = (short)1516272117;
				switch (num2 == num)
				{
				default:
				{
					num = (short)828506112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)472055809;
				if (num != 0)
				{
				}
				num = (short)1144520704;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(DEKGraphicView.DEKButton23ChannelIsAcpEditableProperty);
			}
			set
			{
				short num = (short)646693167;
				short num2 = num;
				num = (short)1846264111;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1654652928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1989476352;
				if (num != 0)
				{
				}
				num = (short)143523841;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23ChannelIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x0003620C File Offset: 0x0003440C
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x000362C4 File Offset: 0x000344C4
		public string DEKButton23ChannelUIValue
		{
			get
			{
				short num = (short)2091357527;
				short num2 = num;
				num = (short)835556695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)505217024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1650196481;
				if (num != 0)
				{
				}
				num = (short)9175040;
				if (num != 0)
				{
				}
				return (string)base.GetValue(DEKGraphicView.DEKButton23ChannelUIValueProperty);
			}
			set
			{
				short num = (short)205960676;
				short num2 = num;
				num = (short)1506325988;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1525415936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1991966721;
				if (num != 0)
				{
				}
				num = (short)160497664;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23ChannelUIValueProperty, value);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0003637C File Offset: 0x0003457C
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00036434 File Offset: 0x00034634
		public AcpListField DEKButton23ChannelList
		{
			get
			{
				short num = (short)380516749;
				short num2 = num;
				num = (short)984299917;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1239285760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)519503872;
				if (num != 0)
				{
				}
				num = (short)12058625;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(DEKGraphicView.DEKButton23ChannelListProperty);
			}
			set
			{
				short num = (short)1650292143;
				short num2 = num;
				num = (short)1589278127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)561577984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1882849280;
				if (num != 0)
				{
				}
				num = (short)161153025;
				if (num != 0)
				{
				}
				base.SetValue(DEKGraphicView.DEKButton23ChannelListProperty, value);
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0003A260 File Offset: 0x00038460
		// Note: this type is marked as 'beforefieldinit'.
		static DEKGraphicView()
		{
			int a_ = 4;
			short num = (short)1942517028;
			short num2 = num;
			num = (short)872445220;
			switch (num2 == num)
			{
			}
			num = (short)1530527745;
			if (num != 0)
			{
			}
			num = (short)57933824;
			short num3 = num;
			num = (short)1198784512;
			if (num != 0)
			{
			}
			DEKGraphicView.DEKButton0FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀Ղ⁄♆㵈㹊㽌⩎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀Ղ⁄♆㵈㹊㽌⩎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀ੂ⭄⍆ⱈ㍊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀ੂ⭄⍆ⱈ㍊Ὄ⹎㽐㑒ご", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㙖㕘㉚㥜", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀᥂⩄⥆ⱈɊ㹌๎㉐⍒ᑔ❖⥘㝚㑜㱞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㹖⩘㉚㽜㍞Ѡ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀᥂⩄⥆ⱈɊ㹌๎㉐⍒ၔ㍖じ⽚㱜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀᥂⩄⥆ⱈṊь᥎ぐ㽒⁔㉖", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀᥂⩄⥆ⱈ݊⑌㱎═", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀Bⵄ♆❈╊⡌⍎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton0ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾煀Bⵄ♆❈╊⡌⍎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀Ղ⁄♆㵈㹊㽌⩎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀Ղ⁄♆㵈㹊㽌⩎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀ੂ⭄⍆ⱈ㍊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀ੂ⭄⍆ⱈ㍊Ὄ⹎㽐㑒ご", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㙖㕘㉚㥜", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀᥂⩄⥆ⱈɊ㹌๎㉐⍒ᑔ❖⥘㝚㑜㱞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㹖⩘㉚㽜㍞Ѡ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀᥂⩄⥆ⱈɊ㹌๎㉐⍒ၔ㍖じ⽚㱜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀᥂⩄⥆ⱈṊь᥎ぐ㽒⁔㉖", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀᥂⩄⥆ⱈ݊⑌㱎═", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀Bⵄ♆❈╊⡌⍎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton1ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀Bⵄ♆❈╊⡌⍎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀Ղ⁄♆㵈㹊㽌⩎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀Ղ⁄♆㵈㹊㽌⩎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀ੂ⭄⍆ⱈ㍊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀ੂ⭄⍆ⱈ㍊Ὄ⹎㽐㑒ご", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㙖㕘㉚㥜", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀᥂⩄⥆ⱈɊ㹌๎㉐⍒ᑔ❖⥘㝚㑜㱞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㹖⩘㉚㽜㍞Ѡ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀᥂⩄⥆ⱈɊ㹌๎㉐⍒ၔ㍖じ⽚㱜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀᥂⩄⥆ⱈṊь᥎ぐ㽒⁔㉖", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀᥂⩄⥆ⱈ݊⑌㱎═", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀Bⵄ♆❈╊⡌⍎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton2ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀Bⵄ♆❈╊⡌⍎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀Ղ⁄♆㵈㹊㽌⩎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀Ղ⁄♆㵈㹊㽌⩎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀ੂ⭄⍆ⱈ㍊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀ੂ⭄⍆ⱈ㍊Ὄ⹎㽐㑒ご", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㙖㕘㉚㥜", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀᥂⩄⥆ⱈɊ㹌๎㉐⍒ᑔ❖⥘㝚㑜㱞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㹖⩘㉚㽜㍞Ѡ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀᥂⩄⥆ⱈɊ㹌๎㉐⍒ၔ㍖じ⽚㱜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀᥂⩄⥆ⱈṊь᥎ぐ㽒⁔㉖", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀᥂⩄⥆ⱈ݊⑌㱎═", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀Bⵄ♆❈╊⡌⍎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton3ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾牀Bⵄ♆❈╊⡌⍎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀Ղ⁄♆㵈㹊㽌⩎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀Ղ⁄♆㵈㹊㽌⩎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀ੂ⭄⍆ⱈ㍊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀ੂ⭄⍆ⱈ㍊Ὄ⹎㽐㑒ご", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㙖㕘㉚㥜", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀᥂⩄⥆ⱈɊ㹌๎㉐⍒ᑔ❖⥘㝚㑜㱞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㹖⩘㉚㽜㍞Ѡ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀᥂⩄⥆ⱈɊ㹌๎㉐⍒ၔ㍖じ⽚㱜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀᥂⩄⥆ⱈṊь᥎ぐ㽒⁔㉖", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀᥂⩄⥆ⱈ݊⑌㱎═", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀Bⵄ♆❈╊⡌⍎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton4ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾畀Bⵄ♆❈╊⡌⍎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀Ղ⁄♆㵈㹊㽌⩎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀Ղ⁄♆㵈㹊㽌⩎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀ੂ⭄⍆ⱈ㍊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀ੂ⭄⍆ⱈ㍊Ὄ⹎㽐㑒ご", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㙖㕘㉚㥜", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀᥂⩄⥆ⱈɊ㹌๎㉐⍒ᑔ❖⥘㝚㑜㱞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㹖⩘㉚㽜㍞Ѡ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀᥂⩄⥆ⱈɊ㹌๎㉐⍒ၔ㍖じ⽚㱜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀᥂⩄⥆ⱈṊь᥎ぐ㽒⁔㉖", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀᥂⩄⥆ⱈ݊⑌㱎═", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀Bⵄ♆❈╊⡌⍎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton5ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾瑀Bⵄ♆❈╊⡌⍎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着Ղ⁄♆㵈㹊㽌⩎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着Ղ⁄♆㵈㹊㽌⩎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着ੂ⭄⍆ⱈ㍊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着ੂ⭄⍆ⱈ㍊Ὄ⹎㽐㑒ご", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㙖㕘㉚㥜", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着᥂⩄⥆ⱈɊ㹌๎㉐⍒ᑔ❖⥘㝚㑜㱞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㹖⩘㉚㽜㍞Ѡ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着᥂⩄⥆ⱈɊ㹌๎㉐⍒ၔ㍖じ⽚㱜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着᥂⩄⥆ⱈṊь᥎ぐ㽒⁔㉖", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着᥂⩄⥆ⱈ݊⑌㱎═", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着Bⵄ♆❈╊⡌⍎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton6ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾着Bⵄ♆❈╊⡌⍎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀Ղ⁄♆㵈㹊㽌⩎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀Ղ⁄♆㵈㹊㽌⩎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀ੂ⭄⍆ⱈ㍊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀ੂ⭄⍆ⱈ㍊Ὄ⹎㽐㑒ご", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㙖㕘㉚㥜", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀᥂⩄⥆ⱈɊ㹌๎㉐⍒ᑔ❖⥘㝚㑜㱞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㹖⩘㉚㽜㍞Ѡ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀᥂⩄⥆ⱈɊ㹌๎㉐⍒ၔ㍖じ⽚㱜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀᥂⩄⥆ⱈṊь᥎ぐ㽒⁔㉖", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀᥂⩄⥆ⱈ݊⑌㱎═", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀Bⵄ♆❈╊⡌⍎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton7ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾癀Bⵄ♆❈╊⡌⍎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀Ղ⁄♆㵈㹊㽌⩎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀Ղ⁄♆㵈㹊㽌⩎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀ੂ⭄⍆ⱈ㍊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀ੂ⭄⍆ⱈ㍊Ὄ⹎㽐㑒ご", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㙖㕘㉚㥜", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀᥂⩄⥆ⱈɊ㹌๎㉐⍒ᑔ❖⥘㝚㑜㱞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㹖⩘㉚㽜㍞Ѡ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀᥂⩄⥆ⱈɊ㹌๎㉐⍒ၔ㍖じ⽚㱜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀᥂⩄⥆ⱈṊь᥎ぐ㽒⁔㉖", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀᥂⩄⥆ⱈ݊⑌㱎═", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀Bⵄ♆❈╊⡌⍎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton8ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾祀Bⵄ♆❈╊⡌⍎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础Ղ⁄♆㵈㹊㽌⩎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础Ղ⁄♆㵈㹊㽌⩎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础Ղ⁄♆㵈㹊㽌⩎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础ੂ⭄⍆ⱈ㍊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础ੂ⭄⍆ⱈ㍊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础ੂ⭄⍆ⱈ㍊Ὄ⹎㽐㑒ご", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㙖㕘㉚㥜", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础᥂⩄⥆ⱈɊ㹌๎㉐⍒ᑔ❖⥘㝚㑜㱞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础᥂⩄⥆ⱈɊ㹌๎㉐⍒͔㹖⩘㉚㽜㍞Ѡ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础᥂⩄⥆ⱈɊ㹌๎㉐⍒ၔ㍖じ⽚㱜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础᥂⩄⥆ⱈṊь᥎ぐ㽒⁔㉖", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础᥂⩄⥆ⱈ݊⑌㱎═", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㱜㍞ࡠݢ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘ᩚⵜ⽞ൠ੢٤٦୨ݪ࡬", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘൚㑜ⱞࡠŢ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础Bⵄ♆❈╊⡌⍎ᡐ⁒ᑔ㑖⥘Ṛ㥜㙞ᕠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础Bⵄ♆❈╊⡌⍎ѐᩒ͔㙖㕘⹚㡜", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton9ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾础Bⵄ♆❈╊⡌⍎ᵐ㩒♔⍖", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton10ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀獂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton11ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀牂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton12ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀煂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton13ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀灂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton14ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀睂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton15ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀療ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton16ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀畂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton17ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀瑂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton18ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀筂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton19ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾灀穂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton20ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀獂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton21ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀牂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton22ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀煂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23FeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23FeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23FeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23FeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂̈́≆⡈㽊㡌㵎㑐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23FeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂̈́≆⡈㽊㡌㵎㑐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23FeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂̈́≆⡈㽊㡌㵎㑐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23IndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㩚ㅜ㙞ՠ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23IndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖ᡘ⭚ⵜ㍞ࡠbѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23IndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖མ㉚⹜㙞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23IndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ౄ⥆ⵈ⹊㕌َ≐ቒ㙔❖᱘㽚㑜⭞`Ţ।ɦ", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23IndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ౄ⥆ⵈ⹊㕌ᩎᡐՒ㑔㭖ⱘ㹚", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23IndexRangeProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ౄ⥆ⵈ⹊㕌ᵎぐ㵒㉔㉖", a_), typeof(AcpRangeField<int, int>), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23ZoneIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ὄ⡆❈⹊ь㱎ၐげ╔Ŗ㡘㝚㑜㭞", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23ZoneIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ὄ⡆❈⹊ь㱎ၐげ╔ᙖ⥘⭚ㅜ㙞ɠɢݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23ZoneIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ὄ⡆❈⹊ь㱎ၐげ╔Ŗじ⡚㑜㵞ൠ٢", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23ZoneIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ὄ⡆❈⹊ь㱎ၐげ╔ቖ㵘㉚⥜㹞͠རd", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23ZoneUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ὄ⡆❈⹊ᡌَݐ㉒㥔≖㱘", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23ZoneListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ὄ⡆❈⹊Ō♎≐❒", a_), typeof(AcpListField), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23ChannelIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㹞ൠ੢Ť", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23ChannelIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᱜ⽞ᅠར౤Ѧࡨ४Ŭ੮", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23ChannelIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ଡ଼㙞በ੢ݤ୦౨", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23ChannelIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ل⽆⡈╊⍌⩎㵐ᩒ♔ᙖ㩘⭚ᡜ㭞ࡠᝢѤզը๪", a_), typeof(bool), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23ChannelUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ل⽆⡈╊⍌⩎㵐ْ᱔Ŗ㡘㝚⡜㩞", a_), typeof(string), typeof(DEKGraphicView));
			DEKGraphicView.DEKButton23ChannelListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("欮琰砲眴䈶䴸伺刼儾獀灂ل⽆⡈╊⍌⩎㵐ὒ㱔⑖ⵘ", a_), typeof(AcpListField), typeof(DEKGraphicView));
		}

		// Token: 0x04000003 RID: 3
		public static DependencyProperty DEKButton0FeatureIsAcpValidProperty;

		// Token: 0x04000004 RID: 4
		public static DependencyProperty DEKButton0FeatureIsAcpApplicableProperty;

		// Token: 0x04000005 RID: 5
		public static DependencyProperty DEKButton0FeatureIsAcpVisibleProperty;

		// Token: 0x04000006 RID: 6
		public static DependencyProperty DEKButton0FeatureIsAcpEditableProperty;

		// Token: 0x04000007 RID: 7
		public static DependencyProperty DEKButton0FeatureUIValueProperty;

		// Token: 0x04000008 RID: 8
		public static DependencyProperty DEKButton0FeatureListProperty;

		// Token: 0x04000009 RID: 9
		public static DependencyProperty DEKButton0IndexIsAcpValidProperty;

		// Token: 0x0400000A RID: 10
		public static DependencyProperty DEKButton0IndexIsAcpApplicableProperty;

		// Token: 0x0400000B RID: 11
		public static DependencyProperty DEKButton0IndexIsAcpVisibleProperty;

		// Token: 0x0400000C RID: 12
		public static DependencyProperty DEKButton0IndexIsAcpEditableProperty;

		// Token: 0x0400000D RID: 13
		public static DependencyProperty DEKButton0IndexUIValueProperty;

		// Token: 0x0400000E RID: 14
		public static DependencyProperty DEKButton0IndexRangeProperty;

		// Token: 0x0400000F RID: 15
		public static DependencyProperty DEKButton0ZoneIsAcpValidProperty;

		// Token: 0x04000010 RID: 16
		public static DependencyProperty DEKButton0ZoneIsAcpApplicableProperty;

		// Token: 0x04000011 RID: 17
		public static DependencyProperty DEKButton0ZoneIsAcpVisibleProperty;

		// Token: 0x04000012 RID: 18
		public static DependencyProperty DEKButton0ZoneIsAcpEditableProperty;

		// Token: 0x04000013 RID: 19
		public static DependencyProperty DEKButton0ZoneUIValueProperty;

		// Token: 0x04000014 RID: 20
		public static DependencyProperty DEKButton0ZoneListProperty;

		// Token: 0x04000015 RID: 21
		public static DependencyProperty DEKButton0ChannelIsAcpValidProperty;

		// Token: 0x04000016 RID: 22
		public static DependencyProperty DEKButton0ChannelIsAcpApplicableProperty;

		// Token: 0x04000017 RID: 23
		public static DependencyProperty DEKButton0ChannelIsAcpVisibleProperty;

		// Token: 0x04000018 RID: 24
		public static DependencyProperty DEKButton0ChannelIsAcpEditableProperty;

		// Token: 0x04000019 RID: 25
		public static DependencyProperty DEKButton0ChannelUIValueProperty;

		// Token: 0x0400001A RID: 26
		public static DependencyProperty DEKButton0ChannelListProperty;

		// Token: 0x0400001B RID: 27
		public static DependencyProperty DEKButton1FeatureIsAcpValidProperty;

		// Token: 0x0400001C RID: 28
		public static DependencyProperty DEKButton1FeatureIsAcpApplicableProperty;

		// Token: 0x0400001D RID: 29
		public static DependencyProperty DEKButton1FeatureIsAcpVisibleProperty;

		// Token: 0x0400001E RID: 30
		public static DependencyProperty DEKButton1FeatureIsAcpEditableProperty;

		// Token: 0x0400001F RID: 31
		public static DependencyProperty DEKButton1FeatureUIValueProperty;

		// Token: 0x04000020 RID: 32
		public static DependencyProperty DEKButton1FeatureListProperty;

		// Token: 0x04000021 RID: 33
		public static DependencyProperty DEKButton1IndexIsAcpValidProperty;

		// Token: 0x04000022 RID: 34
		public static DependencyProperty DEKButton1IndexIsAcpApplicableProperty;

		// Token: 0x04000023 RID: 35
		public static DependencyProperty DEKButton1IndexIsAcpVisibleProperty;

		// Token: 0x04000024 RID: 36
		public static DependencyProperty DEKButton1IndexIsAcpEditableProperty;

		// Token: 0x04000025 RID: 37
		public static DependencyProperty DEKButton1IndexUIValueProperty;

		// Token: 0x04000026 RID: 38
		public static DependencyProperty DEKButton1IndexRangeProperty;

		// Token: 0x04000027 RID: 39
		public static DependencyProperty DEKButton1ZoneIsAcpValidProperty;

		// Token: 0x04000028 RID: 40
		public static DependencyProperty DEKButton1ZoneIsAcpApplicableProperty;

		// Token: 0x04000029 RID: 41
		public static DependencyProperty DEKButton1ZoneIsAcpVisibleProperty;

		// Token: 0x0400002A RID: 42
		public static DependencyProperty DEKButton1ZoneIsAcpEditableProperty;

		// Token: 0x0400002B RID: 43
		public static DependencyProperty DEKButton1ZoneUIValueProperty;

		// Token: 0x0400002C RID: 44
		public static DependencyProperty DEKButton1ZoneListProperty;

		// Token: 0x0400002D RID: 45
		public static DependencyProperty DEKButton1ChannelIsAcpValidProperty;

		// Token: 0x0400002E RID: 46
		public static DependencyProperty DEKButton1ChannelIsAcpApplicableProperty;

		// Token: 0x0400002F RID: 47
		public static DependencyProperty DEKButton1ChannelIsAcpVisibleProperty;

		// Token: 0x04000030 RID: 48
		public static DependencyProperty DEKButton1ChannelIsAcpEditableProperty;

		// Token: 0x04000031 RID: 49
		public static DependencyProperty DEKButton1ChannelUIValueProperty;

		// Token: 0x04000032 RID: 50
		public static DependencyProperty DEKButton1ChannelListProperty;

		// Token: 0x04000033 RID: 51
		public static DependencyProperty DEKButton2FeatureIsAcpValidProperty;

		// Token: 0x04000034 RID: 52
		public static DependencyProperty DEKButton2FeatureIsAcpApplicableProperty;

		// Token: 0x04000035 RID: 53
		public static DependencyProperty DEKButton2FeatureIsAcpVisibleProperty;

		// Token: 0x04000036 RID: 54
		public static DependencyProperty DEKButton2FeatureIsAcpEditableProperty;

		// Token: 0x04000037 RID: 55
		public static DependencyProperty DEKButton2FeatureUIValueProperty;

		// Token: 0x04000038 RID: 56
		public static DependencyProperty DEKButton2FeatureListProperty;

		// Token: 0x04000039 RID: 57
		public static DependencyProperty DEKButton2IndexIsAcpValidProperty;

		// Token: 0x0400003A RID: 58
		public static DependencyProperty DEKButton2IndexIsAcpApplicableProperty;

		// Token: 0x0400003B RID: 59
		public static DependencyProperty DEKButton2IndexIsAcpVisibleProperty;

		// Token: 0x0400003C RID: 60
		public static DependencyProperty DEKButton2IndexIsAcpEditableProperty;

		// Token: 0x0400003D RID: 61
		public static DependencyProperty DEKButton2IndexUIValueProperty;

		// Token: 0x0400003E RID: 62
		public static DependencyProperty DEKButton2IndexRangeProperty;

		// Token: 0x0400003F RID: 63
		public static DependencyProperty DEKButton2ZoneIsAcpValidProperty;

		// Token: 0x04000040 RID: 64
		public static DependencyProperty DEKButton2ZoneIsAcpApplicableProperty;

		// Token: 0x04000041 RID: 65
		public static DependencyProperty DEKButton2ZoneIsAcpVisibleProperty;

		// Token: 0x04000042 RID: 66
		public static DependencyProperty DEKButton2ZoneIsAcpEditableProperty;

		// Token: 0x04000043 RID: 67
		public static DependencyProperty DEKButton2ZoneUIValueProperty;

		// Token: 0x04000044 RID: 68
		public static DependencyProperty DEKButton2ZoneListProperty;

		// Token: 0x04000045 RID: 69
		public static DependencyProperty DEKButton2ChannelIsAcpValidProperty;

		// Token: 0x04000046 RID: 70
		public static DependencyProperty DEKButton2ChannelIsAcpApplicableProperty;

		// Token: 0x04000047 RID: 71
		public static DependencyProperty DEKButton2ChannelIsAcpVisibleProperty;

		// Token: 0x04000048 RID: 72
		public static DependencyProperty DEKButton2ChannelIsAcpEditableProperty;

		// Token: 0x04000049 RID: 73
		public static DependencyProperty DEKButton2ChannelUIValueProperty;

		// Token: 0x0400004A RID: 74
		public static DependencyProperty DEKButton2ChannelListProperty;

		// Token: 0x0400004B RID: 75
		public static DependencyProperty DEKButton3FeatureIsAcpValidProperty;

		// Token: 0x0400004C RID: 76
		public static DependencyProperty DEKButton3FeatureIsAcpApplicableProperty;

		// Token: 0x0400004D RID: 77
		public static DependencyProperty DEKButton3FeatureIsAcpVisibleProperty;

		// Token: 0x0400004E RID: 78
		public static DependencyProperty DEKButton3FeatureIsAcpEditableProperty;

		// Token: 0x0400004F RID: 79
		public static DependencyProperty DEKButton3FeatureUIValueProperty;

		// Token: 0x04000050 RID: 80
		public static DependencyProperty DEKButton3FeatureListProperty;

		// Token: 0x04000051 RID: 81
		public static DependencyProperty DEKButton3IndexIsAcpValidProperty;

		// Token: 0x04000052 RID: 82
		public static DependencyProperty DEKButton3IndexIsAcpApplicableProperty;

		// Token: 0x04000053 RID: 83
		public static DependencyProperty DEKButton3IndexIsAcpVisibleProperty;

		// Token: 0x04000054 RID: 84
		public static DependencyProperty DEKButton3IndexIsAcpEditableProperty;

		// Token: 0x04000055 RID: 85
		public static DependencyProperty DEKButton3IndexUIValueProperty;

		// Token: 0x04000056 RID: 86
		public static DependencyProperty DEKButton3IndexRangeProperty;

		// Token: 0x04000057 RID: 87
		public static DependencyProperty DEKButton3ZoneIsAcpValidProperty;

		// Token: 0x04000058 RID: 88
		public static DependencyProperty DEKButton3ZoneIsAcpApplicableProperty;

		// Token: 0x04000059 RID: 89
		public static DependencyProperty DEKButton3ZoneIsAcpVisibleProperty;

		// Token: 0x0400005A RID: 90
		public static DependencyProperty DEKButton3ZoneIsAcpEditableProperty;

		// Token: 0x0400005B RID: 91
		public static DependencyProperty DEKButton3ZoneUIValueProperty;

		// Token: 0x0400005C RID: 92
		public static DependencyProperty DEKButton3ZoneListProperty;

		// Token: 0x0400005D RID: 93
		public static DependencyProperty DEKButton3ChannelIsAcpValidProperty;

		// Token: 0x0400005E RID: 94
		public static DependencyProperty DEKButton3ChannelIsAcpApplicableProperty;

		// Token: 0x0400005F RID: 95
		public static DependencyProperty DEKButton3ChannelIsAcpVisibleProperty;

		// Token: 0x04000060 RID: 96
		public static DependencyProperty DEKButton3ChannelIsAcpEditableProperty;

		// Token: 0x04000061 RID: 97
		public static DependencyProperty DEKButton3ChannelUIValueProperty;

		// Token: 0x04000062 RID: 98
		public static DependencyProperty DEKButton3ChannelListProperty;

		// Token: 0x04000063 RID: 99
		public static DependencyProperty DEKButton4FeatureIsAcpValidProperty;

		// Token: 0x04000064 RID: 100
		public static DependencyProperty DEKButton4FeatureIsAcpApplicableProperty;

		// Token: 0x04000065 RID: 101
		public static DependencyProperty DEKButton4FeatureIsAcpVisibleProperty;

		// Token: 0x04000066 RID: 102
		public static DependencyProperty DEKButton4FeatureIsAcpEditableProperty;

		// Token: 0x04000067 RID: 103
		public static DependencyProperty DEKButton4FeatureUIValueProperty;

		// Token: 0x04000068 RID: 104
		public static DependencyProperty DEKButton4FeatureListProperty;

		// Token: 0x04000069 RID: 105
		public static DependencyProperty DEKButton4IndexIsAcpValidProperty;

		// Token: 0x0400006A RID: 106
		public static DependencyProperty DEKButton4IndexIsAcpApplicableProperty;

		// Token: 0x0400006B RID: 107
		public static DependencyProperty DEKButton4IndexIsAcpVisibleProperty;

		// Token: 0x0400006C RID: 108
		public static DependencyProperty DEKButton4IndexIsAcpEditableProperty;

		// Token: 0x0400006D RID: 109
		public static DependencyProperty DEKButton4IndexUIValueProperty;

		// Token: 0x0400006E RID: 110
		public static DependencyProperty DEKButton4IndexRangeProperty;

		// Token: 0x0400006F RID: 111
		public static DependencyProperty DEKButton4ZoneIsAcpValidProperty;

		// Token: 0x04000070 RID: 112
		public static DependencyProperty DEKButton4ZoneIsAcpApplicableProperty;

		// Token: 0x04000071 RID: 113
		public static DependencyProperty DEKButton4ZoneIsAcpVisibleProperty;

		// Token: 0x04000072 RID: 114
		public static DependencyProperty DEKButton4ZoneIsAcpEditableProperty;

		// Token: 0x04000073 RID: 115
		public static DependencyProperty DEKButton4ZoneUIValueProperty;

		// Token: 0x04000074 RID: 116
		public static DependencyProperty DEKButton4ZoneListProperty;

		// Token: 0x04000075 RID: 117
		public static DependencyProperty DEKButton4ChannelIsAcpValidProperty;

		// Token: 0x04000076 RID: 118
		public static DependencyProperty DEKButton4ChannelIsAcpApplicableProperty;

		// Token: 0x04000077 RID: 119
		public static DependencyProperty DEKButton4ChannelIsAcpVisibleProperty;

		// Token: 0x04000078 RID: 120
		public static DependencyProperty DEKButton4ChannelIsAcpEditableProperty;

		// Token: 0x04000079 RID: 121
		public static DependencyProperty DEKButton4ChannelUIValueProperty;

		// Token: 0x0400007A RID: 122
		public static DependencyProperty DEKButton4ChannelListProperty;

		// Token: 0x0400007B RID: 123
		public static DependencyProperty DEKButton5FeatureIsAcpValidProperty;

		// Token: 0x0400007C RID: 124
		public static DependencyProperty DEKButton5FeatureIsAcpApplicableProperty;

		// Token: 0x0400007D RID: 125
		public static DependencyProperty DEKButton5FeatureIsAcpVisibleProperty;

		// Token: 0x0400007E RID: 126
		public static DependencyProperty DEKButton5FeatureIsAcpEditableProperty;

		// Token: 0x0400007F RID: 127
		public static DependencyProperty DEKButton5FeatureUIValueProperty;

		// Token: 0x04000080 RID: 128
		public static DependencyProperty DEKButton5FeatureListProperty;

		// Token: 0x04000081 RID: 129
		public static DependencyProperty DEKButton5IndexIsAcpValidProperty;

		// Token: 0x04000082 RID: 130
		public static DependencyProperty DEKButton5IndexIsAcpApplicableProperty;

		// Token: 0x04000083 RID: 131
		public static DependencyProperty DEKButton5IndexIsAcpVisibleProperty;

		// Token: 0x04000084 RID: 132
		public static DependencyProperty DEKButton5IndexIsAcpEditableProperty;

		// Token: 0x04000085 RID: 133
		public static DependencyProperty DEKButton5IndexUIValueProperty;

		// Token: 0x04000086 RID: 134
		public static DependencyProperty DEKButton5IndexRangeProperty;

		// Token: 0x04000087 RID: 135
		public static DependencyProperty DEKButton5ZoneIsAcpValidProperty;

		// Token: 0x04000088 RID: 136
		public static DependencyProperty DEKButton5ZoneIsAcpApplicableProperty;

		// Token: 0x04000089 RID: 137
		public static DependencyProperty DEKButton5ZoneIsAcpVisibleProperty;

		// Token: 0x0400008A RID: 138
		public static DependencyProperty DEKButton5ZoneIsAcpEditableProperty;

		// Token: 0x0400008B RID: 139
		public static DependencyProperty DEKButton5ZoneUIValueProperty;

		// Token: 0x0400008C RID: 140
		public static DependencyProperty DEKButton5ZoneListProperty;

		// Token: 0x0400008D RID: 141
		public static DependencyProperty DEKButton5ChannelIsAcpValidProperty;

		// Token: 0x0400008E RID: 142
		public static DependencyProperty DEKButton5ChannelIsAcpApplicableProperty;

		// Token: 0x0400008F RID: 143
		public static DependencyProperty DEKButton5ChannelIsAcpVisibleProperty;

		// Token: 0x04000090 RID: 144
		public static DependencyProperty DEKButton5ChannelIsAcpEditableProperty;

		// Token: 0x04000091 RID: 145
		public static DependencyProperty DEKButton5ChannelUIValueProperty;

		// Token: 0x04000092 RID: 146
		public static DependencyProperty DEKButton5ChannelListProperty;

		// Token: 0x04000093 RID: 147
		public static DependencyProperty DEKButton6FeatureIsAcpValidProperty;

		// Token: 0x04000094 RID: 148
		public static DependencyProperty DEKButton6FeatureIsAcpApplicableProperty;

		// Token: 0x04000095 RID: 149
		public static DependencyProperty DEKButton6FeatureIsAcpVisibleProperty;

		// Token: 0x04000096 RID: 150
		public static DependencyProperty DEKButton6FeatureIsAcpEditableProperty;

		// Token: 0x04000097 RID: 151
		public static DependencyProperty DEKButton6FeatureUIValueProperty;

		// Token: 0x04000098 RID: 152
		public static DependencyProperty DEKButton6FeatureListProperty;

		// Token: 0x04000099 RID: 153
		public static DependencyProperty DEKButton6IndexIsAcpValidProperty;

		// Token: 0x0400009A RID: 154
		public static DependencyProperty DEKButton6IndexIsAcpApplicableProperty;

		// Token: 0x0400009B RID: 155
		public static DependencyProperty DEKButton6IndexIsAcpVisibleProperty;

		// Token: 0x0400009C RID: 156
		public static DependencyProperty DEKButton6IndexIsAcpEditableProperty;

		// Token: 0x0400009D RID: 157
		public static DependencyProperty DEKButton6IndexUIValueProperty;

		// Token: 0x0400009E RID: 158
		public static DependencyProperty DEKButton6IndexRangeProperty;

		// Token: 0x0400009F RID: 159
		public static DependencyProperty DEKButton6ZoneIsAcpValidProperty;

		// Token: 0x040000A0 RID: 160
		public static DependencyProperty DEKButton6ZoneIsAcpApplicableProperty;

		// Token: 0x040000A1 RID: 161
		public static DependencyProperty DEKButton6ZoneIsAcpVisibleProperty;

		// Token: 0x040000A2 RID: 162
		public static DependencyProperty DEKButton6ZoneIsAcpEditableProperty;

		// Token: 0x040000A3 RID: 163
		public static DependencyProperty DEKButton6ZoneUIValueProperty;

		// Token: 0x040000A4 RID: 164
		public static DependencyProperty DEKButton6ZoneListProperty;

		// Token: 0x040000A5 RID: 165
		public static DependencyProperty DEKButton6ChannelIsAcpValidProperty;

		// Token: 0x040000A6 RID: 166
		public static DependencyProperty DEKButton6ChannelIsAcpApplicableProperty;

		// Token: 0x040000A7 RID: 167
		public static DependencyProperty DEKButton6ChannelIsAcpVisibleProperty;

		// Token: 0x040000A8 RID: 168
		public static DependencyProperty DEKButton6ChannelIsAcpEditableProperty;

		// Token: 0x040000A9 RID: 169
		public static DependencyProperty DEKButton6ChannelUIValueProperty;

		// Token: 0x040000AA RID: 170
		public static DependencyProperty DEKButton6ChannelListProperty;

		// Token: 0x040000AB RID: 171
		public static DependencyProperty DEKButton7FeatureIsAcpValidProperty;

		// Token: 0x040000AC RID: 172
		public static DependencyProperty DEKButton7FeatureIsAcpApplicableProperty;

		// Token: 0x040000AD RID: 173
		public static DependencyProperty DEKButton7FeatureIsAcpVisibleProperty;

		// Token: 0x040000AE RID: 174
		public static DependencyProperty DEKButton7FeatureIsAcpEditableProperty;

		// Token: 0x040000AF RID: 175
		public static DependencyProperty DEKButton7FeatureUIValueProperty;

		// Token: 0x040000B0 RID: 176
		public static DependencyProperty DEKButton7FeatureListProperty;

		// Token: 0x040000B1 RID: 177
		public static DependencyProperty DEKButton7IndexIsAcpValidProperty;

		// Token: 0x040000B2 RID: 178
		public static DependencyProperty DEKButton7IndexIsAcpApplicableProperty;

		// Token: 0x040000B3 RID: 179
		public static DependencyProperty DEKButton7IndexIsAcpVisibleProperty;

		// Token: 0x040000B4 RID: 180
		public static DependencyProperty DEKButton7IndexIsAcpEditableProperty;

		// Token: 0x040000B5 RID: 181
		public static DependencyProperty DEKButton7IndexUIValueProperty;

		// Token: 0x040000B6 RID: 182
		public static DependencyProperty DEKButton7IndexRangeProperty;

		// Token: 0x040000B7 RID: 183
		public static DependencyProperty DEKButton7ZoneIsAcpValidProperty;

		// Token: 0x040000B8 RID: 184
		public static DependencyProperty DEKButton7ZoneIsAcpApplicableProperty;

		// Token: 0x040000B9 RID: 185
		public static DependencyProperty DEKButton7ZoneIsAcpVisibleProperty;

		// Token: 0x040000BA RID: 186
		public static DependencyProperty DEKButton7ZoneIsAcpEditableProperty;

		// Token: 0x040000BB RID: 187
		public static DependencyProperty DEKButton7ZoneUIValueProperty;

		// Token: 0x040000BC RID: 188
		public static DependencyProperty DEKButton7ZoneListProperty;

		// Token: 0x040000BD RID: 189
		public static DependencyProperty DEKButton7ChannelIsAcpValidProperty;

		// Token: 0x040000BE RID: 190
		public static DependencyProperty DEKButton7ChannelIsAcpApplicableProperty;

		// Token: 0x040000BF RID: 191
		public static DependencyProperty DEKButton7ChannelIsAcpVisibleProperty;

		// Token: 0x040000C0 RID: 192
		public static DependencyProperty DEKButton7ChannelIsAcpEditableProperty;

		// Token: 0x040000C1 RID: 193
		public static DependencyProperty DEKButton7ChannelUIValueProperty;

		// Token: 0x040000C2 RID: 194
		public static DependencyProperty DEKButton7ChannelListProperty;

		// Token: 0x040000C3 RID: 195
		public static DependencyProperty DEKButton8FeatureIsAcpValidProperty;

		// Token: 0x040000C4 RID: 196
		public static DependencyProperty DEKButton8FeatureIsAcpApplicableProperty;

		// Token: 0x040000C5 RID: 197
		public static DependencyProperty DEKButton8FeatureIsAcpVisibleProperty;

		// Token: 0x040000C6 RID: 198
		public static DependencyProperty DEKButton8FeatureIsAcpEditableProperty;

		// Token: 0x040000C7 RID: 199
		public static DependencyProperty DEKButton8FeatureUIValueProperty;

		// Token: 0x040000C8 RID: 200
		public static DependencyProperty DEKButton8FeatureListProperty;

		// Token: 0x040000C9 RID: 201
		public static DependencyProperty DEKButton8IndexIsAcpValidProperty;

		// Token: 0x040000CA RID: 202
		public static DependencyProperty DEKButton8IndexIsAcpApplicableProperty;

		// Token: 0x040000CB RID: 203
		public static DependencyProperty DEKButton8IndexIsAcpVisibleProperty;

		// Token: 0x040000CC RID: 204
		public static DependencyProperty DEKButton8IndexIsAcpEditableProperty;

		// Token: 0x040000CD RID: 205
		public static DependencyProperty DEKButton8IndexUIValueProperty;

		// Token: 0x040000CE RID: 206
		public static DependencyProperty DEKButton8IndexRangeProperty;

		// Token: 0x040000CF RID: 207
		public static DependencyProperty DEKButton8ZoneIsAcpValidProperty;

		// Token: 0x040000D0 RID: 208
		public static DependencyProperty DEKButton8ZoneIsAcpApplicableProperty;

		// Token: 0x040000D1 RID: 209
		public static DependencyProperty DEKButton8ZoneIsAcpVisibleProperty;

		// Token: 0x040000D2 RID: 210
		public static DependencyProperty DEKButton8ZoneIsAcpEditableProperty;

		// Token: 0x040000D3 RID: 211
		public static DependencyProperty DEKButton8ZoneUIValueProperty;

		// Token: 0x040000D4 RID: 212
		public static DependencyProperty DEKButton8ZoneListProperty;

		// Token: 0x040000D5 RID: 213
		public static DependencyProperty DEKButton8ChannelIsAcpValidProperty;

		// Token: 0x040000D6 RID: 214
		public static DependencyProperty DEKButton8ChannelIsAcpApplicableProperty;

		// Token: 0x040000D7 RID: 215
		public static DependencyProperty DEKButton8ChannelIsAcpVisibleProperty;

		// Token: 0x040000D8 RID: 216
		public static DependencyProperty DEKButton8ChannelIsAcpEditableProperty;

		// Token: 0x040000D9 RID: 217
		public static DependencyProperty DEKButton8ChannelUIValueProperty;

		// Token: 0x040000DA RID: 218
		public static DependencyProperty DEKButton8ChannelListProperty;

		// Token: 0x040000DB RID: 219
		public static DependencyProperty DEKButton9FeatureIsAcpValidProperty;

		// Token: 0x040000DC RID: 220
		public static DependencyProperty DEKButton9FeatureIsAcpApplicableProperty;

		// Token: 0x040000DD RID: 221
		public static DependencyProperty DEKButton9FeatureIsAcpVisibleProperty;

		// Token: 0x040000DE RID: 222
		public static DependencyProperty DEKButton9FeatureIsAcpEditableProperty;

		// Token: 0x040000DF RID: 223
		public static DependencyProperty DEKButton9FeatureUIValueProperty;

		// Token: 0x040000E0 RID: 224
		public static DependencyProperty DEKButton9FeatureListProperty;

		// Token: 0x040000E1 RID: 225
		public static DependencyProperty DEKButton9IndexIsAcpValidProperty;

		// Token: 0x040000E2 RID: 226
		public static DependencyProperty DEKButton9IndexIsAcpApplicableProperty;

		// Token: 0x040000E3 RID: 227
		public static DependencyProperty DEKButton9IndexIsAcpVisibleProperty;

		// Token: 0x040000E4 RID: 228
		public static DependencyProperty DEKButton9IndexIsAcpEditableProperty;

		// Token: 0x040000E5 RID: 229
		public static DependencyProperty DEKButton9IndexUIValueProperty;

		// Token: 0x040000E6 RID: 230
		public static DependencyProperty DEKButton9IndexRangeProperty;

		// Token: 0x040000E7 RID: 231
		public static DependencyProperty DEKButton9ZoneIsAcpValidProperty;

		// Token: 0x040000E8 RID: 232
		public static DependencyProperty DEKButton9ZoneIsAcpApplicableProperty;

		// Token: 0x040000E9 RID: 233
		public static DependencyProperty DEKButton9ZoneIsAcpVisibleProperty;

		// Token: 0x040000EA RID: 234
		public static DependencyProperty DEKButton9ZoneIsAcpEditableProperty;

		// Token: 0x040000EB RID: 235
		public static DependencyProperty DEKButton9ZoneUIValueProperty;

		// Token: 0x040000EC RID: 236
		public static DependencyProperty DEKButton9ZoneListProperty;

		// Token: 0x040000ED RID: 237
		public static DependencyProperty DEKButton9ChannelIsAcpValidProperty;

		// Token: 0x040000EE RID: 238
		public static DependencyProperty DEKButton9ChannelIsAcpApplicableProperty;

		// Token: 0x040000EF RID: 239
		public static DependencyProperty DEKButton9ChannelIsAcpVisibleProperty;

		// Token: 0x040000F0 RID: 240
		public static DependencyProperty DEKButton9ChannelIsAcpEditableProperty;

		// Token: 0x040000F1 RID: 241
		public static DependencyProperty DEKButton9ChannelUIValueProperty;

		// Token: 0x040000F2 RID: 242
		public static DependencyProperty DEKButton9ChannelListProperty;

		// Token: 0x040000F3 RID: 243
		public static DependencyProperty DEKButton10FeatureIsAcpValidProperty;

		// Token: 0x040000F4 RID: 244
		public static DependencyProperty DEKButton10FeatureIsAcpApplicableProperty;

		// Token: 0x040000F5 RID: 245
		public static DependencyProperty DEKButton10FeatureIsAcpVisibleProperty;

		// Token: 0x040000F6 RID: 246
		public static DependencyProperty DEKButton10FeatureIsAcpEditableProperty;

		// Token: 0x040000F7 RID: 247
		public static DependencyProperty DEKButton10FeatureUIValueProperty;

		// Token: 0x040000F8 RID: 248
		public static DependencyProperty DEKButton10FeatureListProperty;

		// Token: 0x040000F9 RID: 249
		public static DependencyProperty DEKButton10IndexIsAcpValidProperty;

		// Token: 0x040000FA RID: 250
		public static DependencyProperty DEKButton10IndexIsAcpApplicableProperty;

		// Token: 0x040000FB RID: 251
		public static DependencyProperty DEKButton10IndexIsAcpVisibleProperty;

		// Token: 0x040000FC RID: 252
		public static DependencyProperty DEKButton10IndexIsAcpEditableProperty;

		// Token: 0x040000FD RID: 253
		public static DependencyProperty DEKButton10IndexUIValueProperty;

		// Token: 0x040000FE RID: 254
		public static DependencyProperty DEKButton10IndexRangeProperty;

		// Token: 0x040000FF RID: 255
		public static DependencyProperty DEKButton10ZoneIsAcpValidProperty;

		// Token: 0x04000100 RID: 256
		public static DependencyProperty DEKButton10ZoneIsAcpApplicableProperty;

		// Token: 0x04000101 RID: 257
		public static DependencyProperty DEKButton10ZoneIsAcpVisibleProperty;

		// Token: 0x04000102 RID: 258
		public static DependencyProperty DEKButton10ZoneIsAcpEditableProperty;

		// Token: 0x04000103 RID: 259
		public static DependencyProperty DEKButton10ZoneUIValueProperty;

		// Token: 0x04000104 RID: 260
		public static DependencyProperty DEKButton10ZoneListProperty;

		// Token: 0x04000105 RID: 261
		public static DependencyProperty DEKButton10ChannelIsAcpValidProperty;

		// Token: 0x04000106 RID: 262
		public static DependencyProperty DEKButton10ChannelIsAcpApplicableProperty;

		// Token: 0x04000107 RID: 263
		public static DependencyProperty DEKButton10ChannelIsAcpVisibleProperty;

		// Token: 0x04000108 RID: 264
		public static DependencyProperty DEKButton10ChannelIsAcpEditableProperty;

		// Token: 0x04000109 RID: 265
		public static DependencyProperty DEKButton10ChannelUIValueProperty;

		// Token: 0x0400010A RID: 266
		public static DependencyProperty DEKButton10ChannelListProperty;

		// Token: 0x0400010B RID: 267
		public static DependencyProperty DEKButton11FeatureIsAcpValidProperty;

		// Token: 0x0400010C RID: 268
		public static DependencyProperty DEKButton11FeatureIsAcpApplicableProperty;

		// Token: 0x0400010D RID: 269
		public static DependencyProperty DEKButton11FeatureIsAcpVisibleProperty;

		// Token: 0x0400010E RID: 270
		public static DependencyProperty DEKButton11FeatureIsAcpEditableProperty;

		// Token: 0x0400010F RID: 271
		public static DependencyProperty DEKButton11FeatureUIValueProperty;

		// Token: 0x04000110 RID: 272
		public static DependencyProperty DEKButton11FeatureListProperty;

		// Token: 0x04000111 RID: 273
		public static DependencyProperty DEKButton11IndexIsAcpValidProperty;

		// Token: 0x04000112 RID: 274
		public static DependencyProperty DEKButton11IndexIsAcpApplicableProperty;

		// Token: 0x04000113 RID: 275
		public static DependencyProperty DEKButton11IndexIsAcpVisibleProperty;

		// Token: 0x04000114 RID: 276
		public static DependencyProperty DEKButton11IndexIsAcpEditableProperty;

		// Token: 0x04000115 RID: 277
		public static DependencyProperty DEKButton11IndexUIValueProperty;

		// Token: 0x04000116 RID: 278
		public static DependencyProperty DEKButton11IndexRangeProperty;

		// Token: 0x04000117 RID: 279
		public static DependencyProperty DEKButton11ZoneIsAcpValidProperty;

		// Token: 0x04000118 RID: 280
		public static DependencyProperty DEKButton11ZoneIsAcpApplicableProperty;

		// Token: 0x04000119 RID: 281
		public static DependencyProperty DEKButton11ZoneIsAcpVisibleProperty;

		// Token: 0x0400011A RID: 282
		public static DependencyProperty DEKButton11ZoneIsAcpEditableProperty;

		// Token: 0x0400011B RID: 283
		public static DependencyProperty DEKButton11ZoneUIValueProperty;

		// Token: 0x0400011C RID: 284
		public static DependencyProperty DEKButton11ZoneListProperty;

		// Token: 0x0400011D RID: 285
		public static DependencyProperty DEKButton11ChannelIsAcpValidProperty;

		// Token: 0x0400011E RID: 286
		public static DependencyProperty DEKButton11ChannelIsAcpApplicableProperty;

		// Token: 0x0400011F RID: 287
		public static DependencyProperty DEKButton11ChannelIsAcpVisibleProperty;

		// Token: 0x04000120 RID: 288
		public static DependencyProperty DEKButton11ChannelIsAcpEditableProperty;

		// Token: 0x04000121 RID: 289
		public static DependencyProperty DEKButton11ChannelUIValueProperty;

		// Token: 0x04000122 RID: 290
		public static DependencyProperty DEKButton11ChannelListProperty;

		// Token: 0x04000123 RID: 291
		public static DependencyProperty DEKButton12FeatureIsAcpValidProperty;

		// Token: 0x04000124 RID: 292
		public static DependencyProperty DEKButton12FeatureIsAcpApplicableProperty;

		// Token: 0x04000125 RID: 293
		public static DependencyProperty DEKButton12FeatureIsAcpVisibleProperty;

		// Token: 0x04000126 RID: 294
		public static DependencyProperty DEKButton12FeatureIsAcpEditableProperty;

		// Token: 0x04000127 RID: 295
		public static DependencyProperty DEKButton12FeatureUIValueProperty;

		// Token: 0x04000128 RID: 296
		public static DependencyProperty DEKButton12FeatureListProperty;

		// Token: 0x04000129 RID: 297
		public static DependencyProperty DEKButton12IndexIsAcpValidProperty;

		// Token: 0x0400012A RID: 298
		public static DependencyProperty DEKButton12IndexIsAcpApplicableProperty;

		// Token: 0x0400012B RID: 299
		public static DependencyProperty DEKButton12IndexIsAcpVisibleProperty;

		// Token: 0x0400012C RID: 300
		public static DependencyProperty DEKButton12IndexIsAcpEditableProperty;

		// Token: 0x0400012D RID: 301
		public static DependencyProperty DEKButton12IndexUIValueProperty;

		// Token: 0x0400012E RID: 302
		public static DependencyProperty DEKButton12IndexRangeProperty;

		// Token: 0x0400012F RID: 303
		public static DependencyProperty DEKButton12ZoneIsAcpValidProperty;

		// Token: 0x04000130 RID: 304
		public static DependencyProperty DEKButton12ZoneIsAcpApplicableProperty;

		// Token: 0x04000131 RID: 305
		public static DependencyProperty DEKButton12ZoneIsAcpVisibleProperty;

		// Token: 0x04000132 RID: 306
		public static DependencyProperty DEKButton12ZoneIsAcpEditableProperty;

		// Token: 0x04000133 RID: 307
		public static DependencyProperty DEKButton12ZoneUIValueProperty;

		// Token: 0x04000134 RID: 308
		public static DependencyProperty DEKButton12ZoneListProperty;

		// Token: 0x04000135 RID: 309
		public static DependencyProperty DEKButton12ChannelIsAcpValidProperty;

		// Token: 0x04000136 RID: 310
		public static DependencyProperty DEKButton12ChannelIsAcpApplicableProperty;

		// Token: 0x04000137 RID: 311
		public static DependencyProperty DEKButton12ChannelIsAcpVisibleProperty;

		// Token: 0x04000138 RID: 312
		public static DependencyProperty DEKButton12ChannelIsAcpEditableProperty;

		// Token: 0x04000139 RID: 313
		public static DependencyProperty DEKButton12ChannelUIValueProperty;

		// Token: 0x0400013A RID: 314
		public static DependencyProperty DEKButton12ChannelListProperty;

		// Token: 0x0400013B RID: 315
		public static DependencyProperty DEKButton13FeatureIsAcpValidProperty;

		// Token: 0x0400013C RID: 316
		public static DependencyProperty DEKButton13FeatureIsAcpApplicableProperty;

		// Token: 0x0400013D RID: 317
		public static DependencyProperty DEKButton13FeatureIsAcpVisibleProperty;

		// Token: 0x0400013E RID: 318
		public static DependencyProperty DEKButton13FeatureIsAcpEditableProperty;

		// Token: 0x0400013F RID: 319
		public static DependencyProperty DEKButton13FeatureUIValueProperty;

		// Token: 0x04000140 RID: 320
		public static DependencyProperty DEKButton13FeatureListProperty;

		// Token: 0x04000141 RID: 321
		public static DependencyProperty DEKButton13IndexIsAcpValidProperty;

		// Token: 0x04000142 RID: 322
		public static DependencyProperty DEKButton13IndexIsAcpApplicableProperty;

		// Token: 0x04000143 RID: 323
		public static DependencyProperty DEKButton13IndexIsAcpVisibleProperty;

		// Token: 0x04000144 RID: 324
		public static DependencyProperty DEKButton13IndexIsAcpEditableProperty;

		// Token: 0x04000145 RID: 325
		public static DependencyProperty DEKButton13IndexUIValueProperty;

		// Token: 0x04000146 RID: 326
		public static DependencyProperty DEKButton13IndexRangeProperty;

		// Token: 0x04000147 RID: 327
		public static DependencyProperty DEKButton13ZoneIsAcpValidProperty;

		// Token: 0x04000148 RID: 328
		public static DependencyProperty DEKButton13ZoneIsAcpApplicableProperty;

		// Token: 0x04000149 RID: 329
		public static DependencyProperty DEKButton13ZoneIsAcpVisibleProperty;

		// Token: 0x0400014A RID: 330
		public static DependencyProperty DEKButton13ZoneIsAcpEditableProperty;

		// Token: 0x0400014B RID: 331
		public static DependencyProperty DEKButton13ZoneUIValueProperty;

		// Token: 0x0400014C RID: 332
		public static DependencyProperty DEKButton13ZoneListProperty;

		// Token: 0x0400014D RID: 333
		public static DependencyProperty DEKButton13ChannelIsAcpValidProperty;

		// Token: 0x0400014E RID: 334
		public static DependencyProperty DEKButton13ChannelIsAcpApplicableProperty;

		// Token: 0x0400014F RID: 335
		public static DependencyProperty DEKButton13ChannelIsAcpVisibleProperty;

		// Token: 0x04000150 RID: 336
		public static DependencyProperty DEKButton13ChannelIsAcpEditableProperty;

		// Token: 0x04000151 RID: 337
		public static DependencyProperty DEKButton13ChannelUIValueProperty;

		// Token: 0x04000152 RID: 338
		public static DependencyProperty DEKButton13ChannelListProperty;

		// Token: 0x04000153 RID: 339
		public static DependencyProperty DEKButton14FeatureIsAcpValidProperty;

		// Token: 0x04000154 RID: 340
		public static DependencyProperty DEKButton14FeatureIsAcpApplicableProperty;

		// Token: 0x04000155 RID: 341
		public static DependencyProperty DEKButton14FeatureIsAcpVisibleProperty;

		// Token: 0x04000156 RID: 342
		public static DependencyProperty DEKButton14FeatureIsAcpEditableProperty;

		// Token: 0x04000157 RID: 343
		public static DependencyProperty DEKButton14FeatureUIValueProperty;

		// Token: 0x04000158 RID: 344
		public static DependencyProperty DEKButton14FeatureListProperty;

		// Token: 0x04000159 RID: 345
		public static DependencyProperty DEKButton14IndexIsAcpValidProperty;

		// Token: 0x0400015A RID: 346
		public static DependencyProperty DEKButton14IndexIsAcpApplicableProperty;

		// Token: 0x0400015B RID: 347
		public static DependencyProperty DEKButton14IndexIsAcpVisibleProperty;

		// Token: 0x0400015C RID: 348
		public static DependencyProperty DEKButton14IndexIsAcpEditableProperty;

		// Token: 0x0400015D RID: 349
		public static DependencyProperty DEKButton14IndexUIValueProperty;

		// Token: 0x0400015E RID: 350
		public static DependencyProperty DEKButton14IndexRangeProperty;

		// Token: 0x0400015F RID: 351
		public static DependencyProperty DEKButton14ZoneIsAcpValidProperty;

		// Token: 0x04000160 RID: 352
		public static DependencyProperty DEKButton14ZoneIsAcpApplicableProperty;

		// Token: 0x04000161 RID: 353
		public static DependencyProperty DEKButton14ZoneIsAcpVisibleProperty;

		// Token: 0x04000162 RID: 354
		public static DependencyProperty DEKButton14ZoneIsAcpEditableProperty;

		// Token: 0x04000163 RID: 355
		public static DependencyProperty DEKButton14ZoneUIValueProperty;

		// Token: 0x04000164 RID: 356
		public static DependencyProperty DEKButton14ZoneListProperty;

		// Token: 0x04000165 RID: 357
		public static DependencyProperty DEKButton14ChannelIsAcpValidProperty;

		// Token: 0x04000166 RID: 358
		public static DependencyProperty DEKButton14ChannelIsAcpApplicableProperty;

		// Token: 0x04000167 RID: 359
		public static DependencyProperty DEKButton14ChannelIsAcpVisibleProperty;

		// Token: 0x04000168 RID: 360
		public static DependencyProperty DEKButton14ChannelIsAcpEditableProperty;

		// Token: 0x04000169 RID: 361
		public static DependencyProperty DEKButton14ChannelUIValueProperty;

		// Token: 0x0400016A RID: 362
		public static DependencyProperty DEKButton14ChannelListProperty;

		// Token: 0x0400016B RID: 363
		public static DependencyProperty DEKButton15FeatureIsAcpValidProperty;

		// Token: 0x0400016C RID: 364
		public static DependencyProperty DEKButton15FeatureIsAcpApplicableProperty;

		// Token: 0x0400016D RID: 365
		public static DependencyProperty DEKButton15FeatureIsAcpVisibleProperty;

		// Token: 0x0400016E RID: 366
		public static DependencyProperty DEKButton15FeatureIsAcpEditableProperty;

		// Token: 0x0400016F RID: 367
		public static DependencyProperty DEKButton15FeatureUIValueProperty;

		// Token: 0x04000170 RID: 368
		public static DependencyProperty DEKButton15FeatureListProperty;

		// Token: 0x04000171 RID: 369
		public static DependencyProperty DEKButton15IndexIsAcpValidProperty;

		// Token: 0x04000172 RID: 370
		public static DependencyProperty DEKButton15IndexIsAcpApplicableProperty;

		// Token: 0x04000173 RID: 371
		public static DependencyProperty DEKButton15IndexIsAcpVisibleProperty;

		// Token: 0x04000174 RID: 372
		public static DependencyProperty DEKButton15IndexIsAcpEditableProperty;

		// Token: 0x04000175 RID: 373
		public static DependencyProperty DEKButton15IndexUIValueProperty;

		// Token: 0x04000176 RID: 374
		public static DependencyProperty DEKButton15IndexRangeProperty;

		// Token: 0x04000177 RID: 375
		public static DependencyProperty DEKButton15ZoneIsAcpValidProperty;

		// Token: 0x04000178 RID: 376
		public static DependencyProperty DEKButton15ZoneIsAcpApplicableProperty;

		// Token: 0x04000179 RID: 377
		public static DependencyProperty DEKButton15ZoneIsAcpVisibleProperty;

		// Token: 0x0400017A RID: 378
		public static DependencyProperty DEKButton15ZoneIsAcpEditableProperty;

		// Token: 0x0400017B RID: 379
		public static DependencyProperty DEKButton15ZoneUIValueProperty;

		// Token: 0x0400017C RID: 380
		public static DependencyProperty DEKButton15ZoneListProperty;

		// Token: 0x0400017D RID: 381
		public static DependencyProperty DEKButton15ChannelIsAcpValidProperty;

		// Token: 0x0400017E RID: 382
		public static DependencyProperty DEKButton15ChannelIsAcpApplicableProperty;

		// Token: 0x0400017F RID: 383
		public static DependencyProperty DEKButton15ChannelIsAcpVisibleProperty;

		// Token: 0x04000180 RID: 384
		public static DependencyProperty DEKButton15ChannelIsAcpEditableProperty;

		// Token: 0x04000181 RID: 385
		public static DependencyProperty DEKButton15ChannelUIValueProperty;

		// Token: 0x04000182 RID: 386
		public static DependencyProperty DEKButton15ChannelListProperty;

		// Token: 0x04000183 RID: 387
		public static DependencyProperty DEKButton16FeatureIsAcpValidProperty;

		// Token: 0x04000184 RID: 388
		public static DependencyProperty DEKButton16FeatureIsAcpApplicableProperty;

		// Token: 0x04000185 RID: 389
		public static DependencyProperty DEKButton16FeatureIsAcpVisibleProperty;

		// Token: 0x04000186 RID: 390
		public static DependencyProperty DEKButton16FeatureIsAcpEditableProperty;

		// Token: 0x04000187 RID: 391
		public static DependencyProperty DEKButton16FeatureUIValueProperty;

		// Token: 0x04000188 RID: 392
		public static DependencyProperty DEKButton16FeatureListProperty;

		// Token: 0x04000189 RID: 393
		public static DependencyProperty DEKButton16IndexIsAcpValidProperty;

		// Token: 0x0400018A RID: 394
		public static DependencyProperty DEKButton16IndexIsAcpApplicableProperty;

		// Token: 0x0400018B RID: 395
		public static DependencyProperty DEKButton16IndexIsAcpVisibleProperty;

		// Token: 0x0400018C RID: 396
		public static DependencyProperty DEKButton16IndexIsAcpEditableProperty;

		// Token: 0x0400018D RID: 397
		public static DependencyProperty DEKButton16IndexUIValueProperty;

		// Token: 0x0400018E RID: 398
		public static DependencyProperty DEKButton16IndexRangeProperty;

		// Token: 0x0400018F RID: 399
		public static DependencyProperty DEKButton16ZoneIsAcpValidProperty;

		// Token: 0x04000190 RID: 400
		public static DependencyProperty DEKButton16ZoneIsAcpApplicableProperty;

		// Token: 0x04000191 RID: 401
		public static DependencyProperty DEKButton16ZoneIsAcpVisibleProperty;

		// Token: 0x04000192 RID: 402
		public static DependencyProperty DEKButton16ZoneIsAcpEditableProperty;

		// Token: 0x04000193 RID: 403
		public static DependencyProperty DEKButton16ZoneUIValueProperty;

		// Token: 0x04000194 RID: 404
		public static DependencyProperty DEKButton16ZoneListProperty;

		// Token: 0x04000195 RID: 405
		public static DependencyProperty DEKButton16ChannelIsAcpValidProperty;

		// Token: 0x04000196 RID: 406
		public static DependencyProperty DEKButton16ChannelIsAcpApplicableProperty;

		// Token: 0x04000197 RID: 407
		public static DependencyProperty DEKButton16ChannelIsAcpVisibleProperty;

		// Token: 0x04000198 RID: 408
		public static DependencyProperty DEKButton16ChannelIsAcpEditableProperty;

		// Token: 0x04000199 RID: 409
		public static DependencyProperty DEKButton16ChannelUIValueProperty;

		// Token: 0x0400019A RID: 410
		public static DependencyProperty DEKButton16ChannelListProperty;

		// Token: 0x0400019B RID: 411
		public static DependencyProperty DEKButton17FeatureIsAcpValidProperty;

		// Token: 0x0400019C RID: 412
		public static DependencyProperty DEKButton17FeatureIsAcpApplicableProperty;

		// Token: 0x0400019D RID: 413
		public static DependencyProperty DEKButton17FeatureIsAcpVisibleProperty;

		// Token: 0x0400019E RID: 414
		public static DependencyProperty DEKButton17FeatureIsAcpEditableProperty;

		// Token: 0x0400019F RID: 415
		public static DependencyProperty DEKButton17FeatureUIValueProperty;

		// Token: 0x040001A0 RID: 416
		public static DependencyProperty DEKButton17FeatureListProperty;

		// Token: 0x040001A1 RID: 417
		public static DependencyProperty DEKButton17IndexIsAcpValidProperty;

		// Token: 0x040001A2 RID: 418
		public static DependencyProperty DEKButton17IndexIsAcpApplicableProperty;

		// Token: 0x040001A3 RID: 419
		public static DependencyProperty DEKButton17IndexIsAcpVisibleProperty;

		// Token: 0x040001A4 RID: 420
		public static DependencyProperty DEKButton17IndexIsAcpEditableProperty;

		// Token: 0x040001A5 RID: 421
		public static DependencyProperty DEKButton17IndexUIValueProperty;

		// Token: 0x040001A6 RID: 422
		public static DependencyProperty DEKButton17IndexRangeProperty;

		// Token: 0x040001A7 RID: 423
		public static DependencyProperty DEKButton17ZoneIsAcpValidProperty;

		// Token: 0x040001A8 RID: 424
		public static DependencyProperty DEKButton17ZoneIsAcpApplicableProperty;

		// Token: 0x040001A9 RID: 425
		public static DependencyProperty DEKButton17ZoneIsAcpVisibleProperty;

		// Token: 0x040001AA RID: 426
		public static DependencyProperty DEKButton17ZoneIsAcpEditableProperty;

		// Token: 0x040001AB RID: 427
		public static DependencyProperty DEKButton17ZoneUIValueProperty;

		// Token: 0x040001AC RID: 428
		public static DependencyProperty DEKButton17ZoneListProperty;

		// Token: 0x040001AD RID: 429
		public static DependencyProperty DEKButton17ChannelIsAcpValidProperty;

		// Token: 0x040001AE RID: 430
		public static DependencyProperty DEKButton17ChannelIsAcpApplicableProperty;

		// Token: 0x040001AF RID: 431
		public static DependencyProperty DEKButton17ChannelIsAcpVisibleProperty;

		// Token: 0x040001B0 RID: 432
		public static DependencyProperty DEKButton17ChannelIsAcpEditableProperty;

		// Token: 0x040001B1 RID: 433
		public static DependencyProperty DEKButton17ChannelUIValueProperty;

		// Token: 0x040001B2 RID: 434
		public static DependencyProperty DEKButton17ChannelListProperty;

		// Token: 0x040001B3 RID: 435
		public static DependencyProperty DEKButton18FeatureIsAcpValidProperty;

		// Token: 0x040001B4 RID: 436
		public static DependencyProperty DEKButton18FeatureIsAcpApplicableProperty;

		// Token: 0x040001B5 RID: 437
		public static DependencyProperty DEKButton18FeatureIsAcpVisibleProperty;

		// Token: 0x040001B6 RID: 438
		public static DependencyProperty DEKButton18FeatureIsAcpEditableProperty;

		// Token: 0x040001B7 RID: 439
		public static DependencyProperty DEKButton18FeatureUIValueProperty;

		// Token: 0x040001B8 RID: 440
		public static DependencyProperty DEKButton18FeatureListProperty;

		// Token: 0x040001B9 RID: 441
		public static DependencyProperty DEKButton18IndexIsAcpValidProperty;

		// Token: 0x040001BA RID: 442
		public static DependencyProperty DEKButton18IndexIsAcpApplicableProperty;

		// Token: 0x040001BB RID: 443
		public static DependencyProperty DEKButton18IndexIsAcpVisibleProperty;

		// Token: 0x040001BC RID: 444
		public static DependencyProperty DEKButton18IndexIsAcpEditableProperty;

		// Token: 0x040001BD RID: 445
		public static DependencyProperty DEKButton18IndexUIValueProperty;

		// Token: 0x040001BE RID: 446
		public static DependencyProperty DEKButton18IndexRangeProperty;

		// Token: 0x040001BF RID: 447
		public static DependencyProperty DEKButton18ZoneIsAcpValidProperty;

		// Token: 0x040001C0 RID: 448
		public static DependencyProperty DEKButton18ZoneIsAcpApplicableProperty;

		// Token: 0x040001C1 RID: 449
		public static DependencyProperty DEKButton18ZoneIsAcpVisibleProperty;

		// Token: 0x040001C2 RID: 450
		public static DependencyProperty DEKButton18ZoneIsAcpEditableProperty;

		// Token: 0x040001C3 RID: 451
		public static DependencyProperty DEKButton18ZoneUIValueProperty;

		// Token: 0x040001C4 RID: 452
		public static DependencyProperty DEKButton18ZoneListProperty;

		// Token: 0x040001C5 RID: 453
		public static DependencyProperty DEKButton18ChannelIsAcpValidProperty;

		// Token: 0x040001C6 RID: 454
		public static DependencyProperty DEKButton18ChannelIsAcpApplicableProperty;

		// Token: 0x040001C7 RID: 455
		public static DependencyProperty DEKButton18ChannelIsAcpVisibleProperty;

		// Token: 0x040001C8 RID: 456
		public static DependencyProperty DEKButton18ChannelIsAcpEditableProperty;

		// Token: 0x040001C9 RID: 457
		public static DependencyProperty DEKButton18ChannelUIValueProperty;

		// Token: 0x040001CA RID: 458
		public static DependencyProperty DEKButton18ChannelListProperty;

		// Token: 0x040001CB RID: 459
		public static DependencyProperty DEKButton19FeatureIsAcpValidProperty;

		// Token: 0x040001CC RID: 460
		public static DependencyProperty DEKButton19FeatureIsAcpApplicableProperty;

		// Token: 0x040001CD RID: 461
		public static DependencyProperty DEKButton19FeatureIsAcpVisibleProperty;

		// Token: 0x040001CE RID: 462
		public static DependencyProperty DEKButton19FeatureIsAcpEditableProperty;

		// Token: 0x040001CF RID: 463
		public static DependencyProperty DEKButton19FeatureUIValueProperty;

		// Token: 0x040001D0 RID: 464
		public static DependencyProperty DEKButton19FeatureListProperty;

		// Token: 0x040001D1 RID: 465
		public static DependencyProperty DEKButton19IndexIsAcpValidProperty;

		// Token: 0x040001D2 RID: 466
		public static DependencyProperty DEKButton19IndexIsAcpApplicableProperty;

		// Token: 0x040001D3 RID: 467
		public static DependencyProperty DEKButton19IndexIsAcpVisibleProperty;

		// Token: 0x040001D4 RID: 468
		public static DependencyProperty DEKButton19IndexIsAcpEditableProperty;

		// Token: 0x040001D5 RID: 469
		public static DependencyProperty DEKButton19IndexUIValueProperty;

		// Token: 0x040001D6 RID: 470
		public static DependencyProperty DEKButton19IndexRangeProperty;

		// Token: 0x040001D7 RID: 471
		public static DependencyProperty DEKButton19ZoneIsAcpValidProperty;

		// Token: 0x040001D8 RID: 472
		public static DependencyProperty DEKButton19ZoneIsAcpApplicableProperty;

		// Token: 0x040001D9 RID: 473
		public static DependencyProperty DEKButton19ZoneIsAcpVisibleProperty;

		// Token: 0x040001DA RID: 474
		public static DependencyProperty DEKButton19ZoneIsAcpEditableProperty;

		// Token: 0x040001DB RID: 475
		public static DependencyProperty DEKButton19ZoneUIValueProperty;

		// Token: 0x040001DC RID: 476
		public static DependencyProperty DEKButton19ZoneListProperty;

		// Token: 0x040001DD RID: 477
		public static DependencyProperty DEKButton19ChannelIsAcpValidProperty;

		// Token: 0x040001DE RID: 478
		public static DependencyProperty DEKButton19ChannelIsAcpApplicableProperty;

		// Token: 0x040001DF RID: 479
		public static DependencyProperty DEKButton19ChannelIsAcpVisibleProperty;

		// Token: 0x040001E0 RID: 480
		public static DependencyProperty DEKButton19ChannelIsAcpEditableProperty;

		// Token: 0x040001E1 RID: 481
		public static DependencyProperty DEKButton19ChannelUIValueProperty;

		// Token: 0x040001E2 RID: 482
		public static DependencyProperty DEKButton19ChannelListProperty;

		// Token: 0x040001E3 RID: 483
		public static DependencyProperty DEKButton20FeatureIsAcpValidProperty;

		// Token: 0x040001E4 RID: 484
		public static DependencyProperty DEKButton20FeatureIsAcpApplicableProperty;

		// Token: 0x040001E5 RID: 485
		public static DependencyProperty DEKButton20FeatureIsAcpVisibleProperty;

		// Token: 0x040001E6 RID: 486
		public static DependencyProperty DEKButton20FeatureIsAcpEditableProperty;

		// Token: 0x040001E7 RID: 487
		public static DependencyProperty DEKButton20FeatureUIValueProperty;

		// Token: 0x040001E8 RID: 488
		public static DependencyProperty DEKButton20FeatureListProperty;

		// Token: 0x040001E9 RID: 489
		public static DependencyProperty DEKButton20IndexIsAcpValidProperty;

		// Token: 0x040001EA RID: 490
		public static DependencyProperty DEKButton20IndexIsAcpApplicableProperty;

		// Token: 0x040001EB RID: 491
		public static DependencyProperty DEKButton20IndexIsAcpVisibleProperty;

		// Token: 0x040001EC RID: 492
		public static DependencyProperty DEKButton20IndexIsAcpEditableProperty;

		// Token: 0x040001ED RID: 493
		public static DependencyProperty DEKButton20IndexUIValueProperty;

		// Token: 0x040001EE RID: 494
		public static DependencyProperty DEKButton20IndexRangeProperty;

		// Token: 0x040001EF RID: 495
		public static DependencyProperty DEKButton20ZoneIsAcpValidProperty;

		// Token: 0x040001F0 RID: 496
		public static DependencyProperty DEKButton20ZoneIsAcpApplicableProperty;

		// Token: 0x040001F1 RID: 497
		public static DependencyProperty DEKButton20ZoneIsAcpVisibleProperty;

		// Token: 0x040001F2 RID: 498
		public static DependencyProperty DEKButton20ZoneIsAcpEditableProperty;

		// Token: 0x040001F3 RID: 499
		public static DependencyProperty DEKButton20ZoneUIValueProperty;

		// Token: 0x040001F4 RID: 500
		public static DependencyProperty DEKButton20ZoneListProperty;

		// Token: 0x040001F5 RID: 501
		public static DependencyProperty DEKButton20ChannelIsAcpValidProperty;

		// Token: 0x040001F6 RID: 502
		public static DependencyProperty DEKButton20ChannelIsAcpApplicableProperty;

		// Token: 0x040001F7 RID: 503
		public static DependencyProperty DEKButton20ChannelIsAcpVisibleProperty;

		// Token: 0x040001F8 RID: 504
		public static DependencyProperty DEKButton20ChannelIsAcpEditableProperty;

		// Token: 0x040001F9 RID: 505
		public static DependencyProperty DEKButton20ChannelUIValueProperty;

		// Token: 0x040001FA RID: 506
		public static DependencyProperty DEKButton20ChannelListProperty;

		// Token: 0x040001FB RID: 507
		public static DependencyProperty DEKButton21FeatureIsAcpValidProperty;

		// Token: 0x040001FC RID: 508
		public static DependencyProperty DEKButton21FeatureIsAcpApplicableProperty;

		// Token: 0x040001FD RID: 509
		public static DependencyProperty DEKButton21FeatureIsAcpVisibleProperty;

		// Token: 0x040001FE RID: 510
		public static DependencyProperty DEKButton21FeatureIsAcpEditableProperty;

		// Token: 0x040001FF RID: 511
		public static DependencyProperty DEKButton21FeatureUIValueProperty;

		// Token: 0x04000200 RID: 512
		public static DependencyProperty DEKButton21FeatureListProperty;

		// Token: 0x04000201 RID: 513
		public static DependencyProperty DEKButton21IndexIsAcpValidProperty;

		// Token: 0x04000202 RID: 514
		public static DependencyProperty DEKButton21IndexIsAcpApplicableProperty;

		// Token: 0x04000203 RID: 515
		public static DependencyProperty DEKButton21IndexIsAcpVisibleProperty;

		// Token: 0x04000204 RID: 516
		public static DependencyProperty DEKButton21IndexIsAcpEditableProperty;

		// Token: 0x04000205 RID: 517
		public static DependencyProperty DEKButton21IndexUIValueProperty;

		// Token: 0x04000206 RID: 518
		public static DependencyProperty DEKButton21IndexRangeProperty;

		// Token: 0x04000207 RID: 519
		public static DependencyProperty DEKButton21ZoneIsAcpValidProperty;

		// Token: 0x04000208 RID: 520
		public static DependencyProperty DEKButton21ZoneIsAcpApplicableProperty;

		// Token: 0x04000209 RID: 521
		public static DependencyProperty DEKButton21ZoneIsAcpVisibleProperty;

		// Token: 0x0400020A RID: 522
		public static DependencyProperty DEKButton21ZoneIsAcpEditableProperty;

		// Token: 0x0400020B RID: 523
		public static DependencyProperty DEKButton21ZoneUIValueProperty;

		// Token: 0x0400020C RID: 524
		public static DependencyProperty DEKButton21ZoneListProperty;

		// Token: 0x0400020D RID: 525
		public static DependencyProperty DEKButton21ChannelIsAcpValidProperty;

		// Token: 0x0400020E RID: 526
		public static DependencyProperty DEKButton21ChannelIsAcpApplicableProperty;

		// Token: 0x0400020F RID: 527
		public static DependencyProperty DEKButton21ChannelIsAcpVisibleProperty;

		// Token: 0x04000210 RID: 528
		public static DependencyProperty DEKButton21ChannelIsAcpEditableProperty;

		// Token: 0x04000211 RID: 529
		public static DependencyProperty DEKButton21ChannelUIValueProperty;

		// Token: 0x04000212 RID: 530
		public static DependencyProperty DEKButton21ChannelListProperty;

		// Token: 0x04000213 RID: 531
		public static DependencyProperty DEKButton22FeatureIsAcpValidProperty;

		// Token: 0x04000214 RID: 532
		public static DependencyProperty DEKButton22FeatureIsAcpApplicableProperty;

		// Token: 0x04000215 RID: 533
		public static DependencyProperty DEKButton22FeatureIsAcpVisibleProperty;

		// Token: 0x04000216 RID: 534
		public static DependencyProperty DEKButton22FeatureIsAcpEditableProperty;

		// Token: 0x04000217 RID: 535
		public static DependencyProperty DEKButton22FeatureUIValueProperty;

		// Token: 0x04000218 RID: 536
		public static DependencyProperty DEKButton22FeatureListProperty;

		// Token: 0x04000219 RID: 537
		public static DependencyProperty DEKButton22IndexIsAcpValidProperty;

		// Token: 0x0400021A RID: 538
		public static DependencyProperty DEKButton22IndexIsAcpApplicableProperty;

		// Token: 0x0400021B RID: 539
		public static DependencyProperty DEKButton22IndexIsAcpVisibleProperty;

		// Token: 0x0400021C RID: 540
		public static DependencyProperty DEKButton22IndexIsAcpEditableProperty;

		// Token: 0x0400021D RID: 541
		public static DependencyProperty DEKButton22IndexUIValueProperty;

		// Token: 0x0400021E RID: 542
		public static DependencyProperty DEKButton22IndexRangeProperty;

		// Token: 0x0400021F RID: 543
		public static DependencyProperty DEKButton22ZoneIsAcpValidProperty;

		// Token: 0x04000220 RID: 544
		public static DependencyProperty DEKButton22ZoneIsAcpApplicableProperty;

		// Token: 0x04000221 RID: 545
		public static DependencyProperty DEKButton22ZoneIsAcpVisibleProperty;

		// Token: 0x04000222 RID: 546
		public static DependencyProperty DEKButton22ZoneIsAcpEditableProperty;

		// Token: 0x04000223 RID: 547
		public static DependencyProperty DEKButton22ZoneUIValueProperty;

		// Token: 0x04000224 RID: 548
		public static DependencyProperty DEKButton22ZoneListProperty;

		// Token: 0x04000225 RID: 549
		public static DependencyProperty DEKButton22ChannelIsAcpValidProperty;

		// Token: 0x04000226 RID: 550
		public static DependencyProperty DEKButton22ChannelIsAcpApplicableProperty;

		// Token: 0x04000227 RID: 551
		public static DependencyProperty DEKButton22ChannelIsAcpVisibleProperty;

		// Token: 0x04000228 RID: 552
		public static DependencyProperty DEKButton22ChannelIsAcpEditableProperty;

		// Token: 0x04000229 RID: 553
		public static DependencyProperty DEKButton22ChannelUIValueProperty;

		// Token: 0x0400022A RID: 554
		public static DependencyProperty DEKButton22ChannelListProperty;

		// Token: 0x0400022B RID: 555
		public static DependencyProperty DEKButton23FeatureIsAcpValidProperty;

		// Token: 0x0400022C RID: 556
		public static DependencyProperty DEKButton23FeatureIsAcpApplicableProperty;

		// Token: 0x0400022D RID: 557
		public static DependencyProperty DEKButton23FeatureIsAcpVisibleProperty;

		// Token: 0x0400022E RID: 558
		public static DependencyProperty DEKButton23FeatureIsAcpEditableProperty;

		// Token: 0x0400022F RID: 559
		public static DependencyProperty DEKButton23FeatureUIValueProperty;

		// Token: 0x04000230 RID: 560
		public static DependencyProperty DEKButton23FeatureListProperty;

		// Token: 0x04000231 RID: 561
		public static DependencyProperty DEKButton23IndexIsAcpValidProperty;

		// Token: 0x04000232 RID: 562
		public static DependencyProperty DEKButton23IndexIsAcpApplicableProperty;

		// Token: 0x04000233 RID: 563
		public static DependencyProperty DEKButton23IndexIsAcpVisibleProperty;

		// Token: 0x04000234 RID: 564
		public static DependencyProperty DEKButton23IndexIsAcpEditableProperty;

		// Token: 0x04000235 RID: 565
		public static DependencyProperty DEKButton23IndexUIValueProperty;

		// Token: 0x04000236 RID: 566
		public static DependencyProperty DEKButton23IndexRangeProperty;

		// Token: 0x04000237 RID: 567
		public static DependencyProperty DEKButton23ZoneIsAcpValidProperty;

		// Token: 0x04000238 RID: 568
		public static DependencyProperty DEKButton23ZoneIsAcpApplicableProperty;

		// Token: 0x04000239 RID: 569
		public static DependencyProperty DEKButton23ZoneIsAcpVisibleProperty;

		// Token: 0x0400023A RID: 570
		public static DependencyProperty DEKButton23ZoneIsAcpEditableProperty;

		// Token: 0x0400023B RID: 571
		public static DependencyProperty DEKButton23ZoneUIValueProperty;

		// Token: 0x0400023C RID: 572
		public static DependencyProperty DEKButton23ZoneListProperty;

		// Token: 0x0400023D RID: 573
		public static DependencyProperty DEKButton23ChannelIsAcpValidProperty;

		// Token: 0x0400023E RID: 574
		public static DependencyProperty DEKButton23ChannelIsAcpApplicableProperty;

		// Token: 0x0400023F RID: 575
		public static DependencyProperty DEKButton23ChannelIsAcpVisibleProperty;

		// Token: 0x04000240 RID: 576
		public static DependencyProperty DEKButton23ChannelIsAcpEditableProperty;

		// Token: 0x04000241 RID: 577
		public static DependencyProperty DEKButton23ChannelUIValueProperty;

		// Token: 0x04000242 RID: 578
		public static DependencyProperty DEKButton23ChannelListProperty;
	}
}
