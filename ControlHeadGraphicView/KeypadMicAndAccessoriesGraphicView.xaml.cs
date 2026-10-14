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
	// Token: 0x02000007 RID: 7
	public partial class KeypadMicAndAccessoriesGraphicView : UserControl
	{
		// Token: 0x06000604 RID: 1540 RVA: 0x0005587C File Offset: 0x00053A7C
		public KeypadMicAndAccessoriesGraphicView()
		{
			base.FlowDirection = FlowDirection.LeftToRight;
			this.InitializeComponent();
			base.DataContext = this;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x000558A4 File Offset: 0x00053AA4
		private void OnFieldNameDoubleClick(object sender, RoutedEventArgs e)
		{
			short num = (short)1299314047;
			short num2 = num;
			num = (short)877262207;
			switch (num2 == num)
			{
			}
			num = (short)1310785537;
			if (num != 0)
			{
			}
			num = (short)1317404672;
			short num3 = num;
			num = (short)952369152;
			if (num != 0)
			{
			}
			Utility.GetFieldHelpText(sender);
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00055950 File Offset: 0x00053B50
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x00055A08 File Offset: 0x00053C08
		public bool KMSideTopButtonConventionalFeatureIsAcpValid
		{
			get
			{
				short num = (short)593952769;
				if (num != 0)
				{
				}
				num = (short)34957894;
				short num2 = num;
				num = (short)1662872134;
				switch (num2 == num)
				{
				}
				num = (short)1823145984;
				short num3 = num;
				num = (short)1031143424;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)162466931;
				short num2 = num;
				num = (short)2101152883;
				switch (num2 == num)
				{
				}
				num = (short)1916796929;
				if (num != 0)
				{
				}
				num = (short)830472192;
				short num3 = num;
				num = (short)620560384;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00055AC0 File Offset: 0x00053CC0
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x00055B7C File Offset: 0x00053D7C
		public bool KMSideTopButtonConventionalFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)902778893;
				short num2 = num;
				num = (short)524898317;
				switch (num2 == num)
				{
				}
				num = (short)1923547137;
				if (num != 0)
				{
				}
				num = (short)206897152;
				short num3 = num;
				num = (short)1189937152;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1848248575;
				short num2 = num;
				num = (short)653068543;
				switch (num2 == num)
				{
				}
				num = (short)1395851265;
				if (num != 0)
				{
				}
				num = (short)869990400;
				short num3 = num;
				num = (short)648216576;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00055C34 File Offset: 0x00053E34
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x00055CF0 File Offset: 0x00053EF0
		public bool KMSideTopButtonConventionalFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1191238377;
				short num2 = num;
				num = (short)1423563497;
				switch (num2 == num)
				{
				}
				num = (short)223805440;
				if (num != 0)
				{
				}
				num = (short)2127560704;
				short num3 = num;
				num = (short)2010513409;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1462203719;
				short num2 = num;
				num = (short)764114247;
				switch (num2 == num)
				{
				}
				num = (short)1955397632;
				if (num != 0)
				{
				}
				num = (short)1597374464;
				short num3 = num;
				num = (short)1294729217;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x00055DAC File Offset: 0x00053FAC
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00055E64 File Offset: 0x00054064
		public bool KMSideTopButtonConventionalFeatureIsAcpEditable
		{
			get
			{
				short num = (short)489073573;
				short num2 = num;
				num = (short)2004265893;
				switch (num2 == num)
				{
				}
				num = (short)79560705;
				if (num != 0)
				{
				}
				num = (short)1133576192;
				short num3 = num;
				num = (short)961675264;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1964393186;
				short num2 = num;
				num = (short)940589794;
				switch (num2 == num)
				{
				}
				num = (short)149553153;
				if (num != 0)
				{
				}
				num = (short)2145452032;
				short num3 = num;
				num = (short)1542651904;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x00055F20 File Offset: 0x00054120
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00055FD8 File Offset: 0x000541D8
		public string KMSideTopButtonConventionalFeatureUIValue
		{
			get
			{
				short num = (short)1660157953;
				if (num != 0)
				{
				}
				num = (short)1877187107;
				short num2 = num;
				num = (short)1188993571;
				switch (num2 == num)
				{
				}
				num = (short)970981376;
				short num3 = num;
				num = (short)1927741440;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1930978406;
				short num2 = num;
				num = (short)186672230;
				switch (num2 == num)
				{
				}
				num = (short)773914624;
				if (num != 0)
				{
				}
				num = (short)898105344;
				short num3 = num;
				num = (short)773455873;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureUIValueProperty, value);
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0005608C File Offset: 0x0005428C
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00056144 File Offset: 0x00054344
		public AcpListField KMSideTopButtonConventionalFeatureList
		{
			get
			{
				short num = (short)57710520;
				short num2 = num;
				num = (short)1271961528;
				switch (num2 == num)
				{
				}
				num = (short)186384385;
				if (num != 0)
				{
				}
				num = (short)1165754368;
				short num3 = num;
				num = (short)1863319552;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureListProperty);
			}
			set
			{
				short num = (short)1036106439;
				short num2 = num;
				num = (short)947174087;
				switch (num2 == num)
				{
				}
				num = (short)1991704577;
				if (num != 0)
				{
				}
				num = (short)253624320;
				short num3 = num;
				num = (short)1683095552;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureListProperty, value);
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x000561FC File Offset: 0x000543FC
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x000562B4 File Offset: 0x000544B4
		public bool KMSideTopButtonTrunkingFeatureIsAcpValid
		{
			get
			{
				short num = (short)1953373855;
				short num2 = num;
				num = (short)432873119;
				switch (num2 == num)
				{
				}
				num = (short)597950465;
				if (num != 0)
				{
				}
				num = (short)1364656128;
				short num3 = num;
				num = (short)2042363904;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)128831774;
				short num2 = num;
				num = (short)1404883230;
				switch (num2 == num)
				{
				}
				num = (short)1504837632;
				if (num != 0)
				{
				}
				num = (short)402194432;
				short num3 = num;
				num = (short)483786753;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00056370 File Offset: 0x00054570
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x00056428 File Offset: 0x00054628
		public bool KMSideTopButtonTrunkingFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)84366895;
				short num2 = num;
				num = (short)1867339311;
				switch (num2 == num)
				{
				}
				num = (short)1214119936;
				if (num != 0)
				{
				}
				num = (short)1063256064;
				short num3 = num;
				num = (short)1249116161;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1165440379;
				short num2 = num;
				num = (short)1700541819;
				switch (num2 == num)
				{
				}
				num = (short)1229651969;
				if (num != 0)
				{
				}
				num = (short)1215365120;
				short num3 = num;
				num = (short)1899298816;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x000564E0 File Offset: 0x000546E0
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x0005659C File Offset: 0x0005479C
		public bool KMSideTopButtonTrunkingFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1805369877;
				short num2 = num;
				num = (short)1189003797;
				switch (num2 == num)
				{
				}
				num = (short)978780160;
				if (num != 0)
				{
				}
				num = (short)848429056;
				short num3 = num;
				num = (short)2117926913;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2112940247;
				short num2 = num;
				num = (short)1307961559;
				switch (num2 == num)
				{
				}
				num = (short)570556416;
				if (num != 0)
				{
				}
				num = (short)30867456;
				short num3 = num;
				num = (short)1061289985;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0005665C File Offset: 0x0005485C
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x00056714 File Offset: 0x00054914
		public bool KMSideTopButtonTrunkingFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1831387565;
				short num2 = num;
				num = (short)1342816685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1451753472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1193345025;
				if (num != 0)
				{
				}
				num = (short)808386560;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2146978148;
				short num2 = num;
				num = (short)2114865508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1457127424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1978990593;
				if (num != 0)
				{
				}
				num = (short)1412169728;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x000567CC File Offset: 0x000549CC
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00056888 File Offset: 0x00054A88
		public string KMSideTopButtonTrunkingFeatureUIValue
		{
			get
			{
				short num = (short)1707177573;
				short num2 = num;
				num = (short)1114273381;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2005401600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1340932097;
				if (num != 0)
				{
				}
				num = (short)1217396736;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureUIValueProperty);
			}
			set
			{
				short num = (short)37207694;
				short num2 = num;
				num = (short)1756151438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)109772800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)80347137;
				if (num != 0)
				{
				}
				num = (short)808058880;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00056940 File Offset: 0x00054B40
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x000569FC File Offset: 0x00054BFC
		public AcpListField KMSideTopButtonTrunkingFeatureList
		{
			get
			{
				short num = (short)278396929;
				if (num != 0)
				{
				}
				num = (short)1487011840;
				short num2 = num;
				num = (short)7248401;
				short num3 = num;
				num = (short)833853969;
				switch (num3 == num)
				{
				}
				num = (short)17498112;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureListProperty);
			}
			set
			{
				short num = (short)815380397;
				short num2 = num;
				num = (short)1963767725;
				switch (num2 == num)
				{
				default:
				{
					num = (short)94568448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1431961601;
				if (num != 0)
				{
				}
				num = (short)822935552;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureListProperty, value);
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00056AB4 File Offset: 0x00054CB4
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00056B70 File Offset: 0x00054D70
		public bool KMSideMiddleButtonConventionalFeatureIsAcpValid
		{
			get
			{
				short num = (short)773180893;
				short num2 = num;
				num = (short)652332509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)857341952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1725104129;
				if (num != 0)
				{
				}
				num = (short)488505344;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1530875657;
				short num2 = num;
				num = (short)610815753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1145372672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1158021121;
				if (num != 0)
				{
				}
				num = (short)384761856;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00056C2C File Offset: 0x00054E2C
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00056CE8 File Offset: 0x00054EE8
		public bool KMSideMiddleButtonConventionalFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1417282294;
				short num2 = num;
				num = (short)1058996982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1274216448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)123469825;
				if (num != 0)
				{
				}
				num = (short)719519744;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1013163874;
				short num2 = num;
				num = (short)1735960418;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2067202048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)829554689;
				if (num != 0)
				{
				}
				num = (short)79691776;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x00056DA4 File Offset: 0x00054FA4
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x00056E5C File Offset: 0x0005505C
		public bool KMSideMiddleButtonConventionalFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1349517313;
				if (num != 0)
				{
				}
				num = (short)1390477312;
				short num2 = num;
				num = (short)648656274;
				short num3 = num;
				num = (short)592360850;
				switch (num3 == num)
				{
				}
				num = (short)786759680;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1469983452;
				short num2 = num;
				num = (short)1904028380;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1541931008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1592131585;
				if (num != 0)
				{
				}
				num = (short)441516032;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x00056F18 File Offset: 0x00055118
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x00056FD4 File Offset: 0x000551D4
		public bool KMSideMiddleButtonConventionalFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1860524766;
				short num2 = num;
				num = (short)684153566;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1620312064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)811597824;
				if (num != 0)
				{
				}
				num = (short)691535873;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)389021408;
				short num2 = num;
				num = (short)378470112;
				switch (num2 == num)
				{
				default:
				{
					num = (short)31719424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)320667649;
				if (num != 0)
				{
				}
				num = (short)2000683008;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00057090 File Offset: 0x00055290
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x0005714C File Offset: 0x0005534C
		public string KMSideMiddleButtonConventionalFeatureUIValue
		{
			get
			{
				short num = (short)560173178;
				short num2 = num;
				num = (short)936546426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)799735808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2027945985;
				if (num != 0)
				{
				}
				num = (short)1330315264;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureUIValueProperty);
			}
			set
			{
				short num = (short)218308652;
				short num2 = num;
				num = (short)1111760940;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1584529408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)394788865;
				if (num != 0)
				{
				}
				num = (short)679608320;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00057200 File Offset: 0x00055400
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x000572B8 File Offset: 0x000554B8
		public AcpListField KMSideMiddleButtonConventionalFeatureList
		{
			get
			{
				short num = (short)1724645377;
				if (num != 0)
				{
				}
				num = (short)489684992;
				short num2 = num;
				num = (short)1046444567;
				short num3 = num;
				num = (short)1563589143;
				switch (num3 == num)
				{
				}
				num = (short)1715732480;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureListProperty);
			}
			set
			{
				short num = (short)1358988313;
				short num2 = num;
				num = (short)301958169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1421737984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1931149313;
				if (num != 0)
				{
				}
				num = (short)1148321792;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureListProperty, value);
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x0005736C File Offset: 0x0005556C
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x00057424 File Offset: 0x00055624
		public bool KMSideMiddleButtonTrunkingFeatureIsAcpValid
		{
			get
			{
				short num = (short)1291905154;
				short num2 = num;
				num = (short)1363208322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)765132800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)536608768;
				if (num != 0)
				{
				}
				num = (short)985923585;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)536190380;
				short num2 = num;
				num = (short)461675948;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1437138944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1091960832;
				if (num != 0)
				{
				}
				num = (short)750780417;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x000574DC File Offset: 0x000556DC
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00057598 File Offset: 0x00055798
		public bool KMSideMiddleButtonTrunkingFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)501717202;
				short num2 = num;
				num = (short)1206884562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1637351424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)320012289;
				if (num != 0)
				{
				}
				num = (short)840564736;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1386679434;
				short num2 = num;
				num = (short)1635060874;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2109538304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1309474817;
				if (num != 0)
				{
				}
				num = (short)314179584;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00057654 File Offset: 0x00055854
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00057710 File Offset: 0x00055910
		public bool KMSideMiddleButtonTrunkingFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1238655289;
				short num2 = num;
				num = (short)692740409;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2112356352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)804519937;
				if (num != 0)
				{
				}
				num = (short)1762983936;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)626121667;
				short num2 = num;
				num = (short)1314315203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)646840320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1525415936;
				if (num != 0)
				{
				}
				num = (short)2098987009;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x000577D0 File Offset: 0x000559D0
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x0005788C File Offset: 0x00055A8C
		public bool KMSideMiddleButtonTrunkingFeatureIsAcpEditable
		{
			get
			{
				short num = (short)401999688;
				short num2 = num;
				num = (short)1000212296;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1309736960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2044198913;
				if (num != 0)
				{
				}
				num = (short)1198522368;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)2040463361;
				if (num != 0)
				{
				}
				num = (short)14811136;
				short num2 = num;
				num = (short)2137102920;
				short num3 = num;
				num = (short)1084398152;
				switch (num3 == num)
				{
				}
				num = (short)1008074752;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00057948 File Offset: 0x00055B48
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x00057A00 File Offset: 0x00055C00
		public string KMSideMiddleButtonTrunkingFeatureUIValue
		{
			get
			{
				short num = (short)1165787702;
				short num2 = num;
				num = (short)585073206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)490143744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)674365441;
				if (num != 0)
				{
				}
				num = (short)872153088;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureUIValueProperty);
			}
			set
			{
				short num = (short)771926876;
				short num2 = num;
				num = (short)16886620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)536412160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1941962752;
				if (num != 0)
				{
				}
				num = (short)550699009;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureUIValueProperty, value);
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00057AB8 File Offset: 0x00055CB8
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00057B74 File Offset: 0x00055D74
		public AcpListField KMSideMiddleButtonTrunkingFeatureList
		{
			get
			{
				short num = (short)486140810;
				short num2 = num;
				num = (short)1991371658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1251540992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1583022080;
				if (num != 0)
				{
				}
				num = (short)887291905;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureListProperty);
			}
			set
			{
				short num = (short)1029051725;
				short num2 = num;
				num = (short)906958157;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1802240000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)725483521;
				if (num != 0)
				{
				}
				num = (short)539361280;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureListProperty, value);
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x00057C2C File Offset: 0x00055E2C
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00057CE4 File Offset: 0x00055EE4
		public bool KMSideBottomButtonConventionalFeatureIsAcpValid
		{
			get
			{
				short num = (short)1875704053;
				short num2 = num;
				num = (short)526121205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1610153984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1108541441;
				if (num != 0)
				{
				}
				num = (short)1941438464;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1679552965;
				short num2 = num;
				num = (short)1722151365;
				switch (num2 == num)
				{
				default:
				{
					num = (short)724434944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2145779713;
				if (num != 0)
				{
				}
				num = (short)1587216384;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00057D9C File Offset: 0x00055F9C
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x00057E54 File Offset: 0x00056054
		public bool KMSideBottomButtonConventionalFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1089825908;
				short num2 = num;
				num = (short)2130144372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)112590848;
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
				num = (short)735444992;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1223484451;
				short num2 = num;
				num = (short)1899095075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1553137664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2117271553;
				if (num != 0)
				{
				}
				num = (short)702873600;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00057F14 File Offset: 0x00056114
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00057FCC File Offset: 0x000561CC
		public bool KMSideBottomButtonConventionalFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1856830853;
				short num2 = num;
				num = (short)1792015749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)201588736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)479199233;
				if (num != 0)
				{
				}
				num = (short)2064646144;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)187695017;
				short num2 = num;
				num = (short)1848115113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)645988352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)591134721;
				if (num != 0)
				{
				}
				num = (short)1857617920;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00058084 File Offset: 0x00056284
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x0005813C File Offset: 0x0005633C
		public bool KMSideBottomButtonConventionalFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1656782617;
				short num2 = num;
				num = (short)1703509785;
				switch (num2 == num)
				{
				default:
				{
					num = (short)483393536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1401225216;
				if (num != 0)
				{
				}
				num = (short)1793064961;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)328051639;
				short num2 = num;
				num = (short)377727927;
				switch (num2 == num)
				{
				default:
				{
					num = (short)312606720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)956366849;
				if (num != 0)
				{
				}
				num = (short)2099445760;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x000581F8 File Offset: 0x000563F8
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x000582B4 File Offset: 0x000564B4
		public string KMSideBottomButtonConventionalFeatureUIValue
		{
			get
			{
				short num = (short)805794402;
				short num2 = num;
				num = (short)1377464930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1588854784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)873332737;
				if (num != 0)
				{
				}
				num = (short)1276379136;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1055561824;
				short num2 = num;
				num = (short)583964768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1538392064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1281294337;
				if (num != 0)
				{
				}
				num = (short)1907425280;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x0005836C File Offset: 0x0005656C
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00058428 File Offset: 0x00056628
		public AcpListField KMSideBottomButtonConventionalFeatureList
		{
			get
			{
				short num = (short)2103261985;
				short num2 = num;
				num = (short)934230817;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1984364544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)329252864;
				if (num != 0)
				{
				}
				num = (short)40501249;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureListProperty);
			}
			set
			{
				short num = (short)659327967;
				short num2 = num;
				num = (short)1438682079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2145452032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2119761921;
				if (num != 0)
				{
				}
				num = (short)982777856;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureListProperty, value);
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x000584E0 File Offset: 0x000566E0
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x0005859C File Offset: 0x0005679C
		public bool KMSideBottomButtonTrunkingFeatureIsAcpValid
		{
			get
			{
				short num = (short)2095280721;
				short num2 = num;
				num = (short)1036546641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)290717696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2088108033;
				if (num != 0)
				{
				}
				num = (short)1088618496;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)23266370;
				short num2 = num;
				num = (short)1616774210;
				switch (num2 == num)
				{
				default:
				{
					num = (short)196608000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1372389377;
				if (num != 0)
				{
				}
				num = (short)324141056;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00058658 File Offset: 0x00056858
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00058710 File Offset: 0x00056910
		public bool KMSideBottomButtonTrunkingFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)2018741584;
				short num2 = num;
				num = (short)1457294672;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1928396800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2143551489;
				if (num != 0)
				{
				}
				num = (short)319160320;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)90861383;
				short num2 = num;
				num = (short)1120431943;
				switch (num2 == num)
				{
				default:
				{
					num = (short)816119808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2055340032;
				if (num != 0)
				{
				}
				num = (short)1789067265;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x000587C8 File Offset: 0x000569C8
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x00058880 File Offset: 0x00056A80
		public bool KMSideBottomButtonTrunkingFeatureIsAcpVisible
		{
			get
			{
				short num = (short)2069760391;
				short num2 = num;
				num = (short)394922375;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1612644352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)150142977;
				if (num != 0)
				{
				}
				num = (short)1981415424;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1703188696;
				short num2 = num;
				num = (short)1402968280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)868155392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1051394048;
				if (num != 0)
				{
				}
				num = (short)176095233;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x0005893C File Offset: 0x00056B3C
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x000589F8 File Offset: 0x00056BF8
		public bool KMSideBottomButtonTrunkingFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1430978561;
				if (num != 0)
				{
				}
				num = (short)2052980736;
				short num2 = num;
				num = (short)698427980;
				short num3 = num;
				num = (short)1095182924;
				switch (num3 == num)
				{
				}
				num = (short)275578880;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1381695091;
				short num2 = num;
				num = (short)238354035;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1605435392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1462108161;
				if (num != 0)
				{
				}
				num = (short)1666777088;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00058AB4 File Offset: 0x00056CB4
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00058B6C File Offset: 0x00056D6C
		public string KMSideBottomButtonTrunkingFeatureUIValue
		{
			get
			{
				short num = (short)368531206;
				short num2 = num;
				num = (short)1508923142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)596574208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1746141185;
				if (num != 0)
				{
				}
				num = (short)1848442880;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureUIValueProperty);
			}
			set
			{
				short num = (short)814469654;
				short num2 = num;
				num = (short)2090783254;
				switch (num2 == num)
				{
				default:
				{
					num = (short)824573952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)926089217;
				if (num != 0)
				{
				}
				num = (short)1600847872;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00058C20 File Offset: 0x00056E20
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00058CD8 File Offset: 0x00056ED8
		public AcpListField KMSideBottomButtonTrunkingFeatureList
		{
			get
			{
				short num = (short)762203384;
				short num2 = num;
				num = (short)1387613432;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1501364224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2111963137;
				if (num != 0)
				{
				}
				num = (short)1713766400;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureListProperty);
			}
			set
			{
				short num = (short)1443627009;
				if (num != 0)
				{
				}
				num = (short)2107441152;
				short num2 = num;
				num = (short)1790452841;
				short num3 = num;
				num = (short)1745888361;
				switch (num3 == num)
				{
				}
				num = (short)1465319424;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureListProperty, value);
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00058D8C File Offset: 0x00056F8C
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00058E44 File Offset: 0x00057044
		public bool KMDataButtonConventionalFeatureIsAcpValid
		{
			get
			{
				short num = (short)2034696193;
				if (num != 0)
				{
				}
				num = (short)577699840;
				short num2 = num;
				num = (short)1817464836;
				short num3 = num;
				num = (short)612782084;
				switch (num3 == num)
				{
				}
				num = (short)1531248640;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1945894913;
				if (num != 0)
				{
				}
				num = (short)1546256384;
				short num2 = num;
				num = (short)2077996323;
				short num3 = num;
				num = (short)347387171;
				switch (num3 == num)
				{
				}
				num = (short)1839136768;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00058EFC File Offset: 0x000570FC
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x00058FB4 File Offset: 0x000571B4
		public bool KMDataButtonConventionalFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)2015881258;
				short num2 = num;
				num = (short)801040426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1628438528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)166133761;
				if (num != 0)
				{
				}
				num = (short)651296768;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1007065762;
				short num2 = num;
				num = (short)908892834;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1527316480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1397293056;
				if (num != 0)
				{
				}
				num = (short)872087553;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0005906C File Offset: 0x0005726C
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x00059124 File Offset: 0x00057324
		public bool KMDataButtonConventionalFeatureIsAcpVisible
		{
			get
			{
				short num = (short)237895681;
				if (num != 0)
				{
				}
				num = (short)1444872192;
				short num2 = num;
				num = (short)1882765126;
				short num3 = num;
				num = (short)147633990;
				switch (num3 == num)
				{
				}
				num = (short)706150400;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)734920649;
				short num2 = num;
				num = (short)543621065;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1008664576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1844445184;
				if (num != 0)
				{
				}
				num = (short)1319239681;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x000591DC File Offset: 0x000573DC
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00059298 File Offset: 0x00057498
		public bool KMDataButtonConventionalFeatureIsAcpEditable
		{
			get
			{
				short num = (short)273954166;
				short num2 = num;
				num = (short)1210004854;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1429536768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)943980545;
				if (num != 0)
				{
				}
				num = (short)1831075840;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)969613952;
				short num2 = num;
				num = (short)806101632;
				switch (num2 == num)
				{
				default:
				{
					num = (short)845414400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2014969857;
				if (num != 0)
				{
				}
				num = (short)962854912;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00059354 File Offset: 0x00057554
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00059410 File Offset: 0x00057610
		public string KMDataButtonConventionalFeatureUIValue
		{
			get
			{
				short num = (short)1695179647;
				short num2 = num;
				num = (short)1843422079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2114781184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1208549377;
				if (num != 0)
				{
				}
				num = (short)1691484160;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureUIValueProperty);
			}
			set
			{
				short num = (short)575139241;
				short num2 = num;
				num = (short)340848041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2084175872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1828847616;
				if (num != 0)
				{
				}
				num = (short)72155137;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureUIValueProperty, value);
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x000594C8 File Offset: 0x000576C8
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00059584 File Offset: 0x00057784
		public AcpListField KMDataButtonConventionalFeatureList
		{
			get
			{
				short num = (short)1553247853;
				short num2 = num;
				num = (short)1372368493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)264110080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)510459904;
				if (num != 0)
				{
				}
				num = (short)971636737;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureListProperty);
			}
			set
			{
				short num = (short)768787405;
				short num2 = num;
				num = (short)2011612109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)463601664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1465122816;
				if (num != 0)
				{
				}
				num = (short)1019346945;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureListProperty, value);
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00059638 File Offset: 0x00057838
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x000596F0 File Offset: 0x000578F0
		public bool KMDataButtonConventionalIndexIsAcpValid
		{
			get
			{
				short num = (short)257212007;
				short num2 = num;
				num = (short)848346727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)709558272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1314324480;
				if (num != 0)
				{
				}
				num = (short)969539585;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)586315451;
				short num2 = num;
				num = (short)1715959483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1096941568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1840381953;
				if (num != 0)
				{
				}
				num = (short)1854930944;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x000597AC File Offset: 0x000579AC
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00059868 File Offset: 0x00057A68
		public bool KMDataButtonConventionalIndexIsAcpApplicable
		{
			get
			{
				short num = (short)2014183771;
				short num2 = num;
				num = (short)747700571;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2125398016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)640352257;
				if (num != 0)
				{
				}
				num = (short)435552256;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)195989712;
				short num2 = num;
				num = (short)1389269200;
				switch (num2 == num)
				{
				default:
				{
					num = (short)804454400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1267597312;
				if (num != 0)
				{
				}
				num = (short)1108082689;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00059920 File Offset: 0x00057B20
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x000599D8 File Offset: 0x00057BD8
		public bool KMDataButtonConventionalIndexIsAcpVisible
		{
			get
			{
				short num = (short)1497145618;
				short num2 = num;
				num = (short)1855496466;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1948319744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1286275073;
				if (num != 0)
				{
				}
				num = (short)778698752;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)62508640;
				short num2 = num;
				num = (short)519753312;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1767309312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)344260609;
				if (num != 0)
				{
				}
				num = (short)2107113472;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00059A94 File Offset: 0x00057C94
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x00059B50 File Offset: 0x00057D50
		public bool KMDataButtonConventionalIndexIsAcpEditable
		{
			get
			{
				short num = (short)1659834807;
				short num2 = num;
				num = (short)1001066935;
				switch (num2 == num)
				{
				default:
				{
					num = (short)507969536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1142226945;
				if (num != 0)
				{
				}
				num = (short)318504960;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)796807202;
				short num2 = num;
				num = (short)400576546;
				switch (num2 == num)
				{
				default:
				{
					num = (short)828768256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1972699137;
				if (num != 0)
				{
				}
				num = (short)1284702208;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00059C0C File Offset: 0x00057E0C
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00059CC8 File Offset: 0x00057EC8
		public string KMDataButtonConventionalIndexUIValue
		{
			get
			{
				short num = (short)1623286410;
				short num2 = num;
				num = (short)749101706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)581828608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2133590016;
				if (num != 0)
				{
				}
				num = (short)377815041;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexUIValueProperty);
			}
			set
			{
				short num = (short)1100349441;
				if (num != 0)
				{
				}
				num = (short)1778384896;
				short num2 = num;
				num = (short)1570180338;
				short num3 = num;
				num = (short)680398066;
				switch (num3 == num)
				{
				}
				num = (short)590020608;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexUIValueProperty, value);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00059D80 File Offset: 0x00057F80
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00059E3C File Offset: 0x0005803C
		public AcpListField KMDataButtonConventionalIndexList
		{
			get
			{
				short num = (short)2139986488;
				short num2 = num;
				num = (short)2074516024;
				switch (num2 == num)
				{
				default:
				{
					num = (short)613351424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1434320897;
				if (num != 0)
				{
				}
				num = (short)2021982208;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexListProperty);
			}
			set
			{
				short num = (short)1655069942;
				short num2 = num;
				num = (short)1795972342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)304676864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1420099584;
				if (num != 0)
				{
				}
				num = (short)749404161;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexListProperty, value);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00059EF4 File Offset: 0x000580F4
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00059FAC File Offset: 0x000581AC
		public bool KMDataButtonTrunkingFeatureIsAcpValid
		{
			get
			{
				short num = (short)543752193;
				if (num != 0)
				{
				}
				num = (short)1904869376;
				short num2 = num;
				num = (short)895700595;
				short num3 = num;
				num = (short)1238650483;
				switch (num3 == num)
				{
				}
				num = (short)1268121600;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)539793408;
				short num2 = num;
				num = (short)868194304;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1647837184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)235208705;
				if (num != 0)
				{
				}
				num = (short)344195072;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x0005A068 File Offset: 0x00058268
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x0005A124 File Offset: 0x00058324
		public bool KMDataButtonTrunkingFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1411354816;
				short num2 = num;
				num = (short)311595200;
				switch (num2 == num)
				{
				default:
				{
					num = (short)617480192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)76939264;
				if (num != 0)
				{
				}
				num = (short)85065729;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)44820830;
				short num2 = num;
				num = (short)861464926;
				switch (num2 == num)
				{
				default:
				{
					num = (short)694812672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1170669569;
				if (num != 0)
				{
				}
				num = (short)344588288;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0005A1E0 File Offset: 0x000583E0
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x0005A298 File Offset: 0x00058498
		public bool KMDataButtonTrunkingFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1103266064;
				short num2 = num;
				num = (short)1011056912;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1310720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)34996224;
				if (num != 0)
				{
				}
				num = (short)1748631553;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1477897495;
				short num2 = num;
				num = (short)969862423;
				switch (num2 == num)
				{
				default:
				{
					num = (short)803078144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2074148865;
				if (num != 0)
				{
				}
				num = (short)1131806720;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x0005A350 File Offset: 0x00058550
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x0005A40C File Offset: 0x0005860C
		public bool KMDataButtonTrunkingFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1519828550;
				short num2 = num;
				num = (short)20561478;
				switch (num2 == num)
				{
				default:
				{
					num = (short)642252800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1263271936;
				if (num != 0)
				{
				}
				num = (short)569966593;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)582352897;
				if (num != 0)
				{
				}
				num = (short)979566592;
				short num2 = num;
				num = (short)1503274718;
				short num3 = num;
				num = (short)65742558;
				switch (num3 == num)
				{
				}
				num = (short)1567817728;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0005A4C8 File Offset: 0x000586C8
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x0005A584 File Offset: 0x00058784
		public string KMDataButtonTrunkingFeatureUIValue
		{
			get
			{
				short num = (short)365667532;
				short num2 = num;
				num = (short)897819852;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1719599104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1827995648;
				if (num != 0)
				{
				}
				num = (short)1037107201;
				if (num != 0)
				{
				}
				return (string)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1857505290;
				short num2 = num;
				num = (short)1320830986;
				switch (num2 == num)
				{
				default:
				{
					num = (short)951386112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)789512193;
				if (num != 0)
				{
				}
				num = (short)21430272;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureUIValueProperty, value);
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x0005A638 File Offset: 0x00058838
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x0005A6F0 File Offset: 0x000588F0
		public AcpListField KMDataButtonTrunkingFeatureList
		{
			get
			{
				short num = (short)2020512798;
				short num2 = num;
				num = (short)1094423582;
				switch (num2 == num)
				{
				default:
				{
					num = (short)291438592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)897122305;
				if (num != 0)
				{
				}
				num = (short)385286144;
				if (num != 0)
				{
				}
				return (AcpListField)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureListProperty);
			}
			set
			{
				short num = (short)1312292865;
				if (num != 0)
				{
				}
				num = (short)1066139648;
				short num2 = num;
				num = (short)149506146;
				short num3 = num;
				num = (short)953501794;
				switch (num3 == num)
				{
				}
				num = (short)1810038784;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureListProperty, value);
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x0005A7A4 File Offset: 0x000589A4
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x0005A860 File Offset: 0x00058A60
		public bool KMDataButtonTrunkingIndexIsAcpValid
		{
			get
			{
				short num = (short)83957630;
				short num2 = num;
				num = (short)1345591166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1816199168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)658767872;
				if (num != 0)
				{
				}
				num = (short)1880162305;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexIsAcpValidProperty);
			}
			set
			{
				short num = (short)1545404417;
				if (num != 0)
				{
				}
				num = (short)1415577600;
				short num2 = num;
				num = (short)1113318519;
				short num3 = num;
				num = (short)1389225079;
				switch (num3 == num)
				{
				}
				num = (short)175767552;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexIsAcpValidProperty, value);
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x0005A91C File Offset: 0x00058B1C
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x0005A9D4 File Offset: 0x00058BD4
		public bool KMDataButtonTrunkingIndexIsAcpApplicable
		{
			get
			{
				short num = (short)506393712;
				short num2 = num;
				num = (short)652670064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)491585536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1618083841;
				if (num != 0)
				{
				}
				num = (short)924123136;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1928688281;
				short num2 = num;
				num = (short)1274639001;
				switch (num2 == num)
				{
				default:
				{
					num = (short)505085952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1695088641;
				if (num != 0)
				{
				}
				num = (short)1087111168;
				if (num != 0)
				{
				}
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x0005AA8C File Offset: 0x00058C8C
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x0005AB48 File Offset: 0x00058D48
		public bool KMDataButtonTrunkingIndexIsAcpVisible
		{
			get
			{
				short num = (short)353894401;
				if (num != 0)
				{
				}
				num = (short)2065104896;
				short num2 = num;
				num = (short)1529570025;
				short num3 = num;
				num = (short)1184916201;
				switch (num3 == num)
				{
				}
				num = (short)889389056;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)2047023264;
				short num2 = num;
				num = (short)655038624;
				switch (num2 == num)
				{
				}
				num = (short)841809921;
				if (num != 0)
				{
				}
				num = (short)952434688;
				if (num != 0)
				{
				}
				num = (short)833290240;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x0005AC04 File Offset: 0x00058E04
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x0005ACBC File Offset: 0x00058EBC
		public bool KMDataButtonTrunkingIndexIsAcpEditable
		{
			get
			{
				short num = (short)1775118432;
				short num2 = num;
				num = (short)1618356320;
				switch (num2 == num)
				{
				}
				num = (short)1246953472;
				if (num != 0)
				{
				}
				num = (short)1312620545;
				if (num != 0)
				{
				}
				num = (short)1115357184;
				short num3 = num;
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexIsAcpEditableProperty);
			}
			set
			{
				short num = (short)745768104;
				short num2 = num;
				num = (short)1334412456;
				switch (num2 == num)
				{
				}
				num = (short)1213726720;
				if (num != 0)
				{
				}
				num = (short)1571749889;
				if (num != 0)
				{
				}
				num = (short)877068288;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x0005AD78 File Offset: 0x00058F78
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x0005AE30 File Offset: 0x00059030
		public string KMDataButtonTrunkingIndexUIValue
		{
			get
			{
				short num = (short)1763464660;
				short num2 = num;
				num = (short)1781749204;
				switch (num2 == num)
				{
				}
				num = (short)1136918529;
				if (num != 0)
				{
				}
				num = (short)1048117248;
				if (num != 0)
				{
				}
				num = (short)1221656576;
				short num3 = num;
				return (string)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexUIValueProperty);
			}
			set
			{
				short num = (short)933087618;
				short num2 = num;
				num = (short)652462466;
				switch (num2 == num)
				{
				}
				num = (short)829882368;
				if (num != 0)
				{
				}
				num = (short)1624244225;
				if (num != 0)
				{
				}
				num = (short)949026816;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexUIValueProperty, value);
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0005AEE0 File Offset: 0x000590E0
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x0005AF98 File Offset: 0x00059198
		public AcpListField KMDataButtonTrunkingIndexList
		{
			get
			{
				short num = (short)1055784961;
				if (num != 0)
				{
				}
				num = (short)1656598752;
				short num2 = num;
				num = (short)1460515040;
				switch (num2 == num)
				{
				}
				num = (short)2057633792;
				if (num != 0)
				{
				}
				num = (short)1904279552;
				short num3 = num;
				return (AcpListField)base.GetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexListProperty);
			}
			set
			{
				short num = (short)137138891;
				short num2 = num;
				num = (short)1663931083;
				switch (num2 == num)
				{
				}
				num = (short)647036928;
				if (num != 0)
				{
				}
				num = (short)171048961;
				if (num != 0)
				{
				}
				num = (short)1948123136;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexListProperty, value);
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x0005B04C File Offset: 0x0005924C
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x0005B108 File Offset: 0x00059308
		public bool UpButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)1480890237;
				short num2 = num;
				num = (short)1586927485;
				switch (num2 == num)
				{
				}
				num = (short)1784610816;
				if (num != 0)
				{
				}
				num = (short)1920860161;
				if (num != 0)
				{
				}
				num = (short)220463104;
				short num3 = num;
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.UpButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)1372651521;
				if (num != 0)
				{
				}
				num = (short)344889724;
				short num2 = num;
				num = (short)1050515836;
				switch (num2 == num)
				{
				}
				num = (short)681246720;
				if (num != 0)
				{
				}
				num = (short)514850816;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.UpButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0005B1C0 File Offset: 0x000593C0
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x0005B27C File Offset: 0x0005947C
		public bool UpButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1597791584;
				short num2 = num;
				num = (short)671505760;
				switch (num2 == num)
				{
				}
				num = (short)118030337;
				if (num != 0)
				{
				}
				num = (short)974716928;
				if (num != 0)
				{
				}
				num = (short)1731198976;
				short num3 = num;
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.UpButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)1469876390;
				short num2 = num;
				num = (short)2110884006;
				switch (num2 == num)
				{
				}
				num = (short)297598977;
				if (num != 0)
				{
				}
				num = (short)1556938752;
				if (num != 0)
				{
				}
				num = (short)855965696;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.UpButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x0005B334 File Offset: 0x00059534
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x0005B3F0 File Offset: 0x000595F0
		public bool UpButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)1798750303;
				short num2 = num;
				num = (short)1438171231;
				switch (num2 == num)
				{
				}
				num = (short)1902706689;
				if (num != 0)
				{
				}
				num = (short)1781858304;
				if (num != 0)
				{
				}
				num = (short)304087040;
				short num3 = num;
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.UpButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)100400342;
				short num2 = num;
				num = (short)1993145558;
				switch (num2 == num)
				{
				}
				num = (short)1112801280;
				if (num != 0)
				{
				}
				num = (short)446169089;
				if (num != 0)
				{
				}
				num = (short)2070740992;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.UpButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x0005B4AC File Offset: 0x000596AC
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x0005B568 File Offset: 0x00059768
		public bool UpButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)860749825;
				if (num != 0)
				{
				}
				num = (short)1055310303;
				short num2 = num;
				num = (short)73515487;
				switch (num2 == num)
				{
				}
				num = (short)1487667200;
				if (num != 0)
				{
				}
				num = (short)1320288256;
				short num3 = num;
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.UpButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)1089667073;
				if (num != 0)
				{
				}
				num = (short)892683026;
				short num2 = num;
				num = (short)1569145618;
				switch (num2 == num)
				{
				}
				num = (short)122683392;
				if (num != 0)
				{
				}
				num = (short)339410944;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.UpButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0005B620 File Offset: 0x00059820
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x0005B6DC File Offset: 0x000598DC
		public string UpButtonFeatureUIValue
		{
			get
			{
				short num = (short)267655914;
				short num2 = num;
				num = (short)1938234090;
				switch (num2 == num)
				{
				}
				num = (short)1036320769;
				if (num != 0)
				{
				}
				num = (short)1615921152;
				if (num != 0)
				{
				}
				num = (short)113573888;
				short num3 = num;
				return (string)base.GetValue(KeypadMicAndAccessoriesGraphicView.UpButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)1868466996;
				short num2 = num;
				num = (short)923437876;
				switch (num2 == num)
				{
				}
				num = (short)1548288001;
				if (num != 0)
				{
				}
				num = (short)652607488;
				if (num != 0)
				{
				}
				num = (short)2132672512;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.UpButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0005B790 File Offset: 0x00059990
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x0005B84C File Offset: 0x00059A4C
		public AcpListField UpButtonFeatureList
		{
			get
			{
				short num = (short)1752648751;
				short num2 = num;
				num = (short)1246252079;
				switch (num2 == num)
				{
				}
				num = (short)2008023041;
				if (num != 0)
				{
				}
				num = (short)967639040;
				if (num != 0)
				{
				}
				num = (short)190971904;
				short num3 = num;
				return (AcpListField)base.GetValue(KeypadMicAndAccessoriesGraphicView.UpButtonFeatureListProperty);
			}
			set
			{
				short num = (short)1172119366;
				short num2 = num;
				num = (short)860430150;
				switch (num2 == num)
				{
				}
				num = (short)1078394881;
				if (num != 0)
				{
				}
				num = (short)1517158400;
				if (num != 0)
				{
				}
				num = (short)595984384;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.UpButtonFeatureListProperty, value);
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x0005B900 File Offset: 0x00059B00
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x0005B9B8 File Offset: 0x00059BB8
		public bool DownButtonFeatureIsAcpValid
		{
			get
			{
				short num = (short)775094273;
				if (num != 0)
				{
				}
				num = (short)414805768;
				short num2 = num;
				num = (short)1898737416;
				switch (num2 == num)
				{
				}
				num = (short)949288960;
				if (num != 0)
				{
				}
				num = (short)276758528;
				short num3 = num;
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.DownButtonFeatureIsAcpValidProperty);
			}
			set
			{
				short num = (short)2014071832;
				short num2 = num;
				num = (short)1261194264;
				switch (num2 == num)
				{
				}
				num = (short)324599809;
				if (num != 0)
				{
				}
				num = (short)628490240;
				if (num != 0)
				{
				}
				num = (short)2055405568;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.DownButtonFeatureIsAcpValidProperty, value);
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0005BA70 File Offset: 0x00059C70
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x0005BB28 File Offset: 0x00059D28
		public bool DownButtonFeatureIsAcpApplicable
		{
			get
			{
				short num = (short)1393009008;
				short num2 = num;
				num = (short)238461296;
				switch (num2 == num)
				{
				}
				num = (short)293011457;
				if (num != 0)
				{
				}
				num = (short)1105264640;
				if (num != 0)
				{
				}
				num = (short)1659043840;
				short num3 = num;
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.DownButtonFeatureIsAcpApplicableProperty);
			}
			set
			{
				short num = (short)644415489;
				if (num != 0)
				{
				}
				num = (short)1003910760;
				short num2 = num;
				num = (short)255161960;
				switch (num2 == num)
				{
				}
				num = (short)1092354048;
				if (num != 0)
				{
				}
				num = (short)516947968;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.DownButtonFeatureIsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0005BBE0 File Offset: 0x00059DE0
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x0005BC98 File Offset: 0x00059E98
		public bool DownButtonFeatureIsAcpVisible
		{
			get
			{
				short num = (short)190197603;
				short num2 = num;
				num = (short)1490759523;
				switch (num2 == num)
				{
				}
				num = (short)626786304;
				if (num != 0)
				{
				}
				num = (short)1224867841;
				if (num != 0)
				{
				}
				num = (short)1169031168;
				short num3 = num;
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.DownButtonFeatureIsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1552713615;
				short num2 = num;
				num = (short)529958799;
				switch (num2 == num)
				{
				}
				num = (short)791281664;
				if (num != 0)
				{
				}
				num = (short)1886650369;
				if (num != 0)
				{
				}
				num = (short)1985544192;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.DownButtonFeatureIsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x0005BD50 File Offset: 0x00059F50
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x0005BE0C File Offset: 0x0005A00C
		public bool DownButtonFeatureIsAcpEditable
		{
			get
			{
				short num = (short)1840914177;
				short num2 = num;
				num = (short)1152655105;
				switch (num2 == num)
				{
				}
				num = (short)1967521792;
				if (num != 0)
				{
				}
				num = (short)660340737;
				if (num != 0)
				{
				}
				num = (short)804585472;
				short num3 = num;
				return (bool)base.GetValue(KeypadMicAndAccessoriesGraphicView.DownButtonFeatureIsAcpEditableProperty);
			}
			set
			{
				short num = (short)41252444;
				short num2 = num;
				num = (short)390231644;
				switch (num2 == num)
				{
				}
				num = (short)798228481;
				if (num != 0)
				{
				}
				num = (short)21954560;
				if (num != 0)
				{
				}
				num = (short)359661568;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.DownButtonFeatureIsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0005BEC8 File Offset: 0x0005A0C8
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x0005BF84 File Offset: 0x0005A184
		public string DownButtonFeatureUIValue
		{
			get
			{
				short num = (short)558817949;
				short num2 = num;
				num = (short)1433592477;
				switch (num2 == num)
				{
				}
				num = (short)933691392;
				if (num != 0)
				{
				}
				num = (short)289210369;
				if (num != 0)
				{
				}
				num = (short)436666368;
				short num3 = num;
				return (string)base.GetValue(KeypadMicAndAccessoriesGraphicView.DownButtonFeatureUIValueProperty);
			}
			set
			{
				short num = (short)135135233;
				if (num != 0)
				{
				}
				num = (short)2117646584;
				short num2 = num;
				num = (short)661174520;
				switch (num2 == num)
				{
				}
				num = (short)1188233216;
				if (num != 0)
				{
				}
				num = (short)1072496640;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.DownButtonFeatureUIValueProperty, value);
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0005C038 File Offset: 0x0005A238
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x0005C0F4 File Offset: 0x0005A2F4
		public AcpListField DownButtonFeatureList
		{
			get
			{
				short num = (short)1346992465;
				short num2 = num;
				num = (short)1263040849;
				switch (num2 == num)
				{
				}
				num = (short)1300561920;
				if (num != 0)
				{
				}
				num = (short)1927413761;
				if (num != 0)
				{
				}
				num = (short)1441136640;
				short num3 = num;
				return (AcpListField)base.GetValue(KeypadMicAndAccessoriesGraphicView.DownButtonFeatureListProperty);
			}
			set
			{
				short num = (short)592755867;
				short num2 = num;
				num = (short)183090331;
				switch (num2 == num)
				{
				}
				num = (short)2081226753;
				if (num != 0)
				{
				}
				num = (short)541655040;
				if (num != 0)
				{
				}
				num = (short)1873215488;
				short num3 = num;
				base.SetValue(KeypadMicAndAccessoriesGraphicView.DownButtonFeatureListProperty, value);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0005CC54 File Offset: 0x0005AE54
		// Note: this type is marked as 'beforefieldinit'.
		static KeypadMicAndAccessoriesGraphicView()
		{
			int a_ = 16;
			short num = (short)2056711480;
			short num2 = num;
			num = (short)2016800056;
			switch (num2 == num)
			{
			}
			num = (short)644612096;
			short num3 = num;
			num = (short)363069441;
			if (num != 0)
			{
			}
			num = (short)2138308608;
			if (num != 0)
			{
			}
			KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄ፆ♈㭊ཌ㩎═❒㩔㥖ᩘ㑚㍜⥞Ѡൢᅤ๦٨ժ౬ͮ㝰ᙲᑴͶ౸ॺ᡼㙾슂\udf88", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄ፆ♈㭊ཌ㩎═❒㩔㥖ᩘ㑚㍜⥞Ѡൢᅤ๦٨ժ౬ͮ㝰ᙲᑴͶ౸ॺ᡼㙾슂좈ﮊﶌﺚ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄ፆ♈㭊ཌ㩎═❒㩔㥖ᩘ㑚㍜⥞Ѡൢᅤ๦٨ժ౬ͮ㝰ᙲᑴͶ౸ॺ᡼㙾슂\udf88ﺌﾒ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄ፆ♈㭊ཌ㩎═❒㩔㥖ᩘ㑚㍜⥞Ѡൢᅤ๦٨ժ౬ͮ㝰ᙲᑴͶ౸ॺ᡼㙾슂첈ﮎ璉", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄ፆ♈㭊ཌ㩎═❒㩔㥖ᩘ㑚㍜⥞Ѡൢᅤ๦٨ժ౬ͮ㝰ᙲᑴͶ౸ॺ᡼⩾좀햂ﲈ", a_), typeof(string), typeof(KeypadMicAndAccessoriesGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadMicAndAccessoriesGraphicView.KMSideTopButtonConventionalFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄ፆ♈㭊ཌ㩎═❒㩔㥖ᩘ㑚㍜⥞Ѡൢᅤ๦٨ժ౬ͮ㝰ᙲᑴͶ౸ॺ᡼㍾", a_), typeof(AcpListField), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄ፆ♈㭊ཌ㩎═❒㩔㥖൘⥚⡜ㅞ੠੢୤f⽨๪౬᭮ѰŲၴ㹶੸㩺Ṽཾ힀", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄ፆ♈㭊ཌ㩎═❒㩔㥖൘⥚⡜ㅞ੠੢୤f⽨๪౬᭮ѰŲၴ㹶੸㩺Ṽཾ삀﶐", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄ፆ♈㭊ཌ㩎═❒㩔㥖൘⥚⡜ㅞ੠੢୤f⽨๪౬᭮ѰŲၴ㹶੸㩺Ṽཾ힀", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄ፆ♈㭊ཌ㩎═❒㩔㥖൘⥚⡜ㅞ੠੢୤f⽨๪౬᭮ѰŲၴ㹶੸㩺Ṽཾ쒀", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄ፆ♈㭊ཌ㩎═❒㩔㥖൘⥚⡜ㅞ੠੢୤f⽨๪౬᭮ѰŲၴ≶へ⵺ᱼ፾", a_), typeof(string), typeof(KeypadMicAndAccessoriesGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadMicAndAccessoriesGraphicView.KMSideTopButtonTrunkingFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄ፆ♈㭊ཌ㩎═❒㩔㥖൘⥚⡜ㅞ੠੢୤f⽨๪౬᭮ѰŲၴ㭶ၸࡺॼ", a_), typeof(AcpListField), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄੆⁈⽊⥌⍎㑐ᅒ⁔⍖ⵘ㑚㍜ᱞ๠ൢ፤ɦݨὪѬnὰቲᥴㅶᱸ᩺ॼ੾첄좈ﶌ\ud98eﾒﲔ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄੆⁈⽊⥌⍎㑐ᅒ⁔⍖ⵘ㑚㍜ᱞ๠ൢ፤ɦݨὪѬnὰቲᥴㅶᱸ᩺ॼ੾첄좈ﶌ캎璉ﺖ滛漢ﾜ쒠", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄੆⁈⽊⥌⍎㑐ᅒ⁔⍖ⵘ㑚㍜ᱞ๠ൢ፤ɦݨὪѬnὰቲᥴㅶᱸ᩺ॼ੾첄좈ﶌ\ud98eﲔﺚ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄੆⁈⽊⥌⍎㑐ᅒ⁔⍖ⵘ㑚㍜ᱞ๠ൢ፤ɦݨὪѬnὰቲᥴㅶᱸ᩺ॼ੾첄좈ﶌ쪎朗ﮘ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄੆⁈⽊⥌⍎㑐ᅒ⁔⍖ⵘ㑚㍜ᱞ๠ൢ፤ɦݨὪѬnὰቲᥴㅶᱸ᩺ॼ੾킄캆\udf88搜", a_), typeof(string), typeof(KeypadMicAndAccessoriesGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonConventionalFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄੆⁈⽊⥌⍎㑐ᅒ⁔⍖ⵘ㑚㍜ᱞ๠ൢ፤ɦݨὪѬnὰቲᥴㅶᱸ᩺ॼ੾즄愈ﾊ", a_), typeof(AcpListField), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄੆⁈⽊⥌⍎㑐ᅒ⁔⍖ⵘ㑚㍜୞፠ᙢ୤౦hժ੬⥮ᑰቲŴɶ୸Ṻ㑼౾삀톆", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄੆⁈⽊⥌⍎㑐ᅒ⁔⍖ⵘ㑚㍜୞፠ᙢ୤౦hժ੬⥮ᑰቲŴɶ୸Ṻ㑼౾삀욆麗ﮊﮖﲘ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄੆⁈⽊⥌⍎㑐ᅒ⁔⍖ⵘ㑚㍜୞፠ᙢ୤౦hժ੬⥮ᑰቲŴɶ୸Ṻ㑼౾삀톆﶐", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄੆⁈⽊⥌⍎㑐ᅒ⁔⍖ⵘ㑚㍜୞፠ᙢ୤౦hժ੬⥮ᑰቲŴɶ୸Ṻ㑼౾삀슆歷ﾒ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄੆⁈⽊⥌⍎㑐ᅒ⁔⍖ⵘ㑚㍜୞፠ᙢ୤౦hժ੬⥮ᑰቲŴɶ୸Ṻ⡼㙾힀", a_), typeof(string), typeof(KeypadMicAndAccessoriesGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadMicAndAccessoriesGraphicView.KMSideMiddleButtonTrunkingFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄੆⁈⽊⥌⍎㑐ᅒ⁔⍖ⵘ㑚㍜୞፠ᙢ୤౦hժ੬⥮ᑰቲŴɶ୸Ṻㅼᙾ", a_), typeof(AcpListField), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄Ն♈㽊㥌⁎㱐ᅒ⁔⍖ⵘ㑚㍜ᱞ๠ൢ፤ɦݨὪѬnὰቲᥴㅶᱸ᩺ॼ੾첄좈ﶌ\ud98eﾒﲔ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄Ն♈㽊㥌⁎㱐ᅒ⁔⍖ⵘ㑚㍜ᱞ๠ൢ፤ɦݨὪѬnὰቲᥴㅶᱸ᩺ॼ੾첄좈ﶌ캎璉ﺖ滛漢ﾜ쒠", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄Ն♈㽊㥌⁎㱐ᅒ⁔⍖ⵘ㑚㍜ᱞ๠ൢ፤ɦݨὪѬnὰቲᥴㅶᱸ᩺ॼ੾첄좈ﶌ\ud98eﲔﺚ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄Ն♈㽊㥌⁎㱐ᅒ⁔⍖ⵘ㑚㍜ᱞ๠ൢ፤ɦݨὪѬnὰቲᥴㅶᱸ᩺ॼ੾첄좈ﶌ쪎朗ﮘ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄Ն♈㽊㥌⁎㱐ᅒ⁔⍖ⵘ㑚㍜ᱞ๠ൢ፤ɦݨὪѬnὰቲᥴㅶᱸ᩺ॼ੾킄캆\udf88搜", a_), typeof(string), typeof(KeypadMicAndAccessoriesGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonConventionalFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄Ն♈㽊㥌⁎㱐ᅒ⁔⍖ⵘ㑚㍜ᱞ๠ൢ፤ɦݨὪѬnὰቲᥴㅶᱸ᩺ॼ੾즄愈ﾊ", a_), typeof(AcpListField), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄Ն♈㽊㥌⁎㱐ᅒ⁔⍖ⵘ㑚㍜୞፠ᙢ୤౦hժ੬⥮ᑰቲŴɶ୸Ṻ㑼౾삀톆", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄Ն♈㽊㥌⁎㱐ᅒ⁔⍖ⵘ㑚㍜୞፠ᙢ୤౦hժ੬⥮ᑰቲŴɶ୸Ṻ㑼౾삀욆麗ﮊﮖﲘ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄Ն♈㽊㥌⁎㱐ᅒ⁔⍖ⵘ㑚㍜୞፠ᙢ୤౦hժ੬⥮ᑰቲŴɶ୸Ṻ㑼౾삀톆﶐", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄Ն♈㽊㥌⁎㱐ᅒ⁔⍖ⵘ㑚㍜୞፠ᙢ୤౦hժ੬⥮ᑰቲŴɶ୸Ṻ㑼౾삀슆歷ﾒ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄Ն♈㽊㥌⁎㱐ᅒ⁔⍖ⵘ㑚㍜୞፠ᙢ୤౦hժ੬⥮ᑰቲŴɶ୸Ṻ⡼㙾힀", a_), typeof(string), typeof(KeypadMicAndAccessoriesGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadMicAndAccessoriesGraphicView.KMSideBottomButtonTrunkingFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼氾⡀❂⁄Ն♈㽊㥌⁎㱐ᅒ⁔⍖ⵘ㑚㍜୞፠ᙢ୤౦hժ੬⥮ᑰቲŴɶ୸Ṻㅼᙾ", a_), typeof(AcpListField), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ၒ㩔㥖⽘㹚㍜⭞ࡠౢ୤٦ը⵪࡬๮հٲݴቶへࡺ㱼᱾햂", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ၒ㩔㥖⽘㹚㍜⭞ࡠౢ୤٦ը⵪࡬๮հٲݴቶへࡺ㱼᱾슂ﾒ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ၒ㩔㥖⽘㹚㍜⭞ࡠౢ୤٦ը⵪࡬๮հٲݴቶへࡺ㱼᱾햂", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ၒ㩔㥖⽘㹚㍜⭞ࡠౢ୤٦ը⵪࡬๮հٲݴቶへࡺ㱼᱾욂ﶈ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ၒ㩔㥖⽘㹚㍜⭞ࡠౢ୤٦ը⵪࡬๮հٲݴቶⱸ㉺⭼Ṿ", a_), typeof(string), typeof(KeypadMicAndAccessoriesGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ၒ㩔㥖⽘㹚㍜⭞ࡠౢ୤٦ը⵪࡬๮հٲݴቶ㕸ቺ๼୾", a_), typeof(AcpListField), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ၒ㩔㥖⽘㹚㍜⭞ࡠౢ୤٦ը≪ͬ୮ᑰ୲㱴Ѷ㡸᡺ർ⥾", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ၒ㩔㥖⽘㹚㍜⭞ࡠౢ୤٦ը≪ͬ୮ᑰ୲㱴Ѷ㡸᡺ർ㹾", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ၒ㩔㥖⽘㹚㍜⭞ࡠౢ୤٦ը≪ͬ୮ᑰ୲㱴Ѷ㡸᡺ർ⥾", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ၒ㩔㥖⽘㹚㍜⭞ࡠౢ୤٦ը≪ͬ୮ᑰ୲㱴Ѷ㡸᡺ർ㩾", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ၒ㩔㥖⽘㹚㍜⭞ࡠౢ୤٦ը≪ͬ୮ᑰ୲⁴㹶⽸᩺ᅼ੾", a_), typeof(string), typeof(KeypadMicAndAccessoriesGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonConventionalIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ၒ㩔㥖⽘㹚㍜⭞ࡠౢ୤٦ը≪ͬ୮ᑰ୲㥴Ṷ੸ེ", a_), typeof(AcpListField), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ݒ❔≖㝘ず㑜ㅞ٠╢d٦ᵨṪὬ੮㡰r㑴ᑶॸ⵺ᱼ፾", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ݒ❔≖㝘ず㑜ㅞ٠╢d٦ᵨṪὬ੮㡰r㑴ᑶॸ㩺ർཾ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ݒ❔≖㝘ず㑜ㅞ٠╢d٦ᵨṪὬ੮㡰r㑴ᑶॸ⵺ᑼ౾", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ݒ❔≖㝘ず㑜ㅞ٠╢d٦ᵨṪὬ੮㡰r㑴ᑶॸ㹺᥼ᙾ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ݒ❔≖㝘ず㑜ㅞ٠╢d٦ᵨṪὬ੮⑰㩲⍴ᙶᕸ๺᡼", a_), typeof(string), typeof(KeypadMicAndAccessoriesGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ݒ❔≖㝘ず㑜ㅞ٠╢d٦ᵨṪὬ੮㵰ᩲٴͶ", a_), typeof(AcpListField), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ݒ❔≖㝘ず㑜ㅞ٠⩢୤ͦ౨፪⑬ᱮばၲմⅶᡸ᝺ᑼ᭾", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ݒ❔≖㝘ず㑜ㅞ٠⩢୤ͦ౨፪⑬ᱮばၲմ㙶ॸ୺ᅼᙾ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ݒ❔≖㝘ず㑜ㅞ٠⩢୤ͦ౨፪⑬ᱮばၲմⅶၸࡺᑼᵾ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ݒ❔≖㝘ず㑜ㅞ٠⩢୤ͦ౨፪⑬ᱮばၲմ㉶ᵸቺॼṾ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ݒ❔≖㝘ず㑜ㅞ٠⩢୤ͦ౨፪㡬♮❰ቲᥴɶᱸ", a_), typeof(string), typeof(KeypadMicAndAccessoriesGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadMicAndAccessoriesGraphicView.KMDataButtonTrunkingIndexListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("瀺瀼笾⁀㝂⑄Ն㱈㽊㥌⁎㽐ݒ❔≖㝘ず㑜ㅞ٠⩢୤ͦ౨፪Ⅼٮɰݲ", a_), typeof(AcpListField), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.UpButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渺䴼紾㑀㝂ㅄ⡆❈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢Ѥ୦hཪ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.UpButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渺䴼紾㑀㝂ㅄ⡆❈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ≢ᕤᝦըɪ๬๮፰ὲၴ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.UpButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渺䴼紾㑀㝂ㅄ⡆❈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ㕢౤ᑦh४Ŭ੮", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.UpButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渺䴼紾㑀㝂ㅄ⡆❈ൊ⡌⹎═♒❔㉖ၘ⡚ᱜ㱞ᅠ♢Ť๦ᵨ੪ཬͮᑰ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.UpButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渺䴼紾㑀㝂ㅄ⡆❈ൊ⡌⹎═♒❔㉖ౘቚଡ଼㹞ൠᙢd", a_), typeof(string), typeof(KeypadMicAndAccessoriesGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadMicAndAccessoriesGraphicView.UpButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("渺䴼紾㑀㝂ㅄ⡆❈ൊ⡌⹎═♒❔㉖ᕘ㉚⹜⭞", a_), typeof(AcpListField), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.DownButtonFeatureIsAcpValidProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("缺刼䠾⽀łい㍆㵈⑊⍌ॎ㑐㉒⅔≖⭘㹚ᑜⱞ⁠bᕤㅦࡨݪѬ୮", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.DownButtonFeatureIsAcpApplicableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("缺刼䠾⽀łい㍆㵈⑊⍌ॎ㑐㉒⅔≖⭘㹚ᑜⱞ⁠bᕤ♦ᥨ᭪Ŭٮተቲ᝴᭶ᱸ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.DownButtonFeatureIsAcpVisibleProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("缺刼䠾⽀łい㍆㵈⑊⍌ॎ㑐㉒⅔≖⭘㹚ᑜⱞ⁠bᕤㅦhᡪѬ൮ᵰᙲ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.DownButtonFeatureIsAcpEditableProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("缺刼䠾⽀łい㍆㵈⑊⍌ॎ㑐㉒⅔≖⭘㹚ᑜⱞ⁠bᕤ≦൨ɪᥬ๮፰ὲၴ", a_), typeof(bool), typeof(KeypadMicAndAccessoriesGraphicView));
			KeypadMicAndAccessoriesGraphicView.DownButtonFeatureUIValueProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("缺刼䠾⽀łい㍆㵈⑊⍌ॎ㑐㉒⅔≖⭘㹚࡜ᙞ㝠ɢ।ቦ౨", a_), typeof(string), typeof(KeypadMicAndAccessoriesGraphicView), new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			KeypadMicAndAccessoriesGraphicView.DownButtonFeatureListProperty = DependencyProperty.Register(O9GraphicviewMenuItemsVisibilityConverter.b("缺刼䠾⽀łい㍆㵈⑊⍌ॎ㑐㉒⅔≖⭘㹚ᅜ㙞በᝢ", a_), typeof(AcpListField), typeof(KeypadMicAndAccessoriesGraphicView));
		}

		// Token: 0x040006A7 RID: 1703
		public static DependencyProperty KMSideTopButtonConventionalFeatureIsAcpValidProperty;

		// Token: 0x040006A8 RID: 1704
		public static DependencyProperty KMSideTopButtonConventionalFeatureIsAcpApplicableProperty;

		// Token: 0x040006A9 RID: 1705
		public static DependencyProperty KMSideTopButtonConventionalFeatureIsAcpVisibleProperty;

		// Token: 0x040006AA RID: 1706
		public static DependencyProperty KMSideTopButtonConventionalFeatureIsAcpEditableProperty;

		// Token: 0x040006AB RID: 1707
		public static DependencyProperty KMSideTopButtonConventionalFeatureUIValueProperty;

		// Token: 0x040006AC RID: 1708
		public static DependencyProperty KMSideTopButtonConventionalFeatureListProperty;

		// Token: 0x040006AD RID: 1709
		public static DependencyProperty KMSideTopButtonTrunkingFeatureIsAcpValidProperty;

		// Token: 0x040006AE RID: 1710
		public static DependencyProperty KMSideTopButtonTrunkingFeatureIsAcpApplicableProperty;

		// Token: 0x040006AF RID: 1711
		public static DependencyProperty KMSideTopButtonTrunkingFeatureIsAcpVisibleProperty;

		// Token: 0x040006B0 RID: 1712
		public static DependencyProperty KMSideTopButtonTrunkingFeatureIsAcpEditableProperty;

		// Token: 0x040006B1 RID: 1713
		public static DependencyProperty KMSideTopButtonTrunkingFeatureUIValueProperty;

		// Token: 0x040006B2 RID: 1714
		public static DependencyProperty KMSideTopButtonTrunkingFeatureListProperty;

		// Token: 0x040006B3 RID: 1715
		public static DependencyProperty KMSideMiddleButtonConventionalFeatureIsAcpValidProperty;

		// Token: 0x040006B4 RID: 1716
		public static DependencyProperty KMSideMiddleButtonConventionalFeatureIsAcpApplicableProperty;

		// Token: 0x040006B5 RID: 1717
		public static DependencyProperty KMSideMiddleButtonConventionalFeatureIsAcpVisibleProperty;

		// Token: 0x040006B6 RID: 1718
		public static DependencyProperty KMSideMiddleButtonConventionalFeatureIsAcpEditableProperty;

		// Token: 0x040006B7 RID: 1719
		public static DependencyProperty KMSideMiddleButtonConventionalFeatureUIValueProperty;

		// Token: 0x040006B8 RID: 1720
		public static DependencyProperty KMSideMiddleButtonConventionalFeatureListProperty;

		// Token: 0x040006B9 RID: 1721
		public static DependencyProperty KMSideMiddleButtonTrunkingFeatureIsAcpValidProperty;

		// Token: 0x040006BA RID: 1722
		public static DependencyProperty KMSideMiddleButtonTrunkingFeatureIsAcpApplicableProperty;

		// Token: 0x040006BB RID: 1723
		public static DependencyProperty KMSideMiddleButtonTrunkingFeatureIsAcpVisibleProperty;

		// Token: 0x040006BC RID: 1724
		public static DependencyProperty KMSideMiddleButtonTrunkingFeatureIsAcpEditableProperty;

		// Token: 0x040006BD RID: 1725
		public static DependencyProperty KMSideMiddleButtonTrunkingFeatureUIValueProperty;

		// Token: 0x040006BE RID: 1726
		public static DependencyProperty KMSideMiddleButtonTrunkingFeatureListProperty;

		// Token: 0x040006BF RID: 1727
		public static DependencyProperty KMSideBottomButtonConventionalFeatureIsAcpValidProperty;

		// Token: 0x040006C0 RID: 1728
		public static DependencyProperty KMSideBottomButtonConventionalFeatureIsAcpApplicableProperty;

		// Token: 0x040006C1 RID: 1729
		public static DependencyProperty KMSideBottomButtonConventionalFeatureIsAcpVisibleProperty;

		// Token: 0x040006C2 RID: 1730
		public static DependencyProperty KMSideBottomButtonConventionalFeatureIsAcpEditableProperty;

		// Token: 0x040006C3 RID: 1731
		public static DependencyProperty KMSideBottomButtonConventionalFeatureUIValueProperty;

		// Token: 0x040006C4 RID: 1732
		public static DependencyProperty KMSideBottomButtonConventionalFeatureListProperty;

		// Token: 0x040006C5 RID: 1733
		public static DependencyProperty KMSideBottomButtonTrunkingFeatureIsAcpValidProperty;

		// Token: 0x040006C6 RID: 1734
		public static DependencyProperty KMSideBottomButtonTrunkingFeatureIsAcpApplicableProperty;

		// Token: 0x040006C7 RID: 1735
		public static DependencyProperty KMSideBottomButtonTrunkingFeatureIsAcpVisibleProperty;

		// Token: 0x040006C8 RID: 1736
		public static DependencyProperty KMSideBottomButtonTrunkingFeatureIsAcpEditableProperty;

		// Token: 0x040006C9 RID: 1737
		public static DependencyProperty KMSideBottomButtonTrunkingFeatureUIValueProperty;

		// Token: 0x040006CA RID: 1738
		public static DependencyProperty KMSideBottomButtonTrunkingFeatureListProperty;

		// Token: 0x040006CB RID: 1739
		public static DependencyProperty KMDataButtonConventionalFeatureIsAcpValidProperty;

		// Token: 0x040006CC RID: 1740
		public static DependencyProperty KMDataButtonConventionalFeatureIsAcpApplicableProperty;

		// Token: 0x040006CD RID: 1741
		public static DependencyProperty KMDataButtonConventionalFeatureIsAcpVisibleProperty;

		// Token: 0x040006CE RID: 1742
		public static DependencyProperty KMDataButtonConventionalFeatureIsAcpEditableProperty;

		// Token: 0x040006CF RID: 1743
		public static DependencyProperty KMDataButtonConventionalFeatureUIValueProperty;

		// Token: 0x040006D0 RID: 1744
		public static DependencyProperty KMDataButtonConventionalFeatureListProperty;

		// Token: 0x040006D1 RID: 1745
		public static DependencyProperty KMDataButtonConventionalIndexIsAcpValidProperty;

		// Token: 0x040006D2 RID: 1746
		public static DependencyProperty KMDataButtonConventionalIndexIsAcpApplicableProperty;

		// Token: 0x040006D3 RID: 1747
		public static DependencyProperty KMDataButtonConventionalIndexIsAcpVisibleProperty;

		// Token: 0x040006D4 RID: 1748
		public static DependencyProperty KMDataButtonConventionalIndexIsAcpEditableProperty;

		// Token: 0x040006D5 RID: 1749
		public static DependencyProperty KMDataButtonConventionalIndexUIValueProperty;

		// Token: 0x040006D6 RID: 1750
		public static DependencyProperty KMDataButtonConventionalIndexListProperty;

		// Token: 0x040006D7 RID: 1751
		public static DependencyProperty KMDataButtonTrunkingFeatureIsAcpValidProperty;

		// Token: 0x040006D8 RID: 1752
		public static DependencyProperty KMDataButtonTrunkingFeatureIsAcpApplicableProperty;

		// Token: 0x040006D9 RID: 1753
		public static DependencyProperty KMDataButtonTrunkingFeatureIsAcpVisibleProperty;

		// Token: 0x040006DA RID: 1754
		public static DependencyProperty KMDataButtonTrunkingFeatureIsAcpEditableProperty;

		// Token: 0x040006DB RID: 1755
		public static DependencyProperty KMDataButtonTrunkingFeatureUIValueProperty;

		// Token: 0x040006DC RID: 1756
		public static DependencyProperty KMDataButtonTrunkingFeatureListProperty;

		// Token: 0x040006DD RID: 1757
		public static DependencyProperty KMDataButtonTrunkingIndexIsAcpValidProperty;

		// Token: 0x040006DE RID: 1758
		public static DependencyProperty KMDataButtonTrunkingIndexIsAcpApplicableProperty;

		// Token: 0x040006DF RID: 1759
		public static DependencyProperty KMDataButtonTrunkingIndexIsAcpVisibleProperty;

		// Token: 0x040006E0 RID: 1760
		public static DependencyProperty KMDataButtonTrunkingIndexIsAcpEditableProperty;

		// Token: 0x040006E1 RID: 1761
		public static DependencyProperty KMDataButtonTrunkingIndexUIValueProperty;

		// Token: 0x040006E2 RID: 1762
		public static DependencyProperty KMDataButtonTrunkingIndexListProperty;

		// Token: 0x040006E3 RID: 1763
		public static DependencyProperty UpButtonFeatureIsAcpValidProperty;

		// Token: 0x040006E4 RID: 1764
		public static DependencyProperty UpButtonFeatureIsAcpApplicableProperty;

		// Token: 0x040006E5 RID: 1765
		public static DependencyProperty UpButtonFeatureIsAcpVisibleProperty;

		// Token: 0x040006E6 RID: 1766
		public static DependencyProperty UpButtonFeatureIsAcpEditableProperty;

		// Token: 0x040006E7 RID: 1767
		public static DependencyProperty UpButtonFeatureUIValueProperty;

		// Token: 0x040006E8 RID: 1768
		public static DependencyProperty UpButtonFeatureListProperty;

		// Token: 0x040006E9 RID: 1769
		public static DependencyProperty DownButtonFeatureIsAcpValidProperty;

		// Token: 0x040006EA RID: 1770
		public static DependencyProperty DownButtonFeatureIsAcpApplicableProperty;

		// Token: 0x040006EB RID: 1771
		public static DependencyProperty DownButtonFeatureIsAcpVisibleProperty;

		// Token: 0x040006EC RID: 1772
		public static DependencyProperty DownButtonFeatureIsAcpEditableProperty;

		// Token: 0x040006ED RID: 1773
		public static DependencyProperty DownButtonFeatureUIValueProperty;

		// Token: 0x040006EE RID: 1774
		public static DependencyProperty DownButtonFeatureListProperty;
	}
}
