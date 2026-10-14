using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Ucl.Contact;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001C4 RID: 452
	[global::System.Serializable]
	public sealed class MDCCallHotListHotListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600159B RID: 5531 RVA: 0x00002650 File Offset: 0x00000850
		internal MDCCallHotListHotListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x001E5CE8 File Offset: 0x001E3EE8
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x001E5DA0 File Offset: 0x001E3FA0
		public int UclMDCCnvHotList_ContactAlias_A00046Value
		{
			get
			{
				short num = (short)1866924032;
				short num2 = num;
				num = (short)1981128625;
				short num3 = num;
				num = (short)1058906033;
				switch (num3 == num)
				{
				}
				num = (short)1508835329;
				if (num != 0)
				{
				}
				num = (short)1092747264;
				if (num != 0)
				{
				}
				return this.uclMDCCnvHotList_ContactAlias_A00046.Value;
			}
			set
			{
				short num = (short)421658624;
				short num2 = num;
				num = (short)1011480280;
				short num3 = num;
				num = (short)566884056;
				switch (num3 == num)
				{
				}
				num = (short)1240793088;
				if (num != 0)
				{
				}
				num = (short)590938113;
				if (num != 0)
				{
				}
				this.uclMDCCnvHotList_ContactAlias_A00046.Value = value;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x001E5E54 File Offset: 0x001E4054
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x001E5F00 File Offset: 0x001E4100
		public global::AcpBusinessLayer.AcpRecRefField UclMDCCnvHotList_ContactAlias_A00046Object
		{
			get
			{
				short num = (short)1243348992;
				short num2 = num;
				num = (short)1118675009;
				short num3 = num;
				num = (short)1505009729;
				switch (num3 == num)
				{
				}
				num = (short)330170369;
				if (num != 0)
				{
				}
				num = (short)1797849088;
				if (num != 0)
				{
				}
				return this.uclMDCCnvHotList_ContactAlias_A00046;
			}
			set
			{
				short num = (short)274857984;
				short num2 = num;
				num = (short)1371717529;
				short num3 = num;
				num = (short)526696345;
				switch (num3 == num)
				{
				}
				num = (short)1926365185;
				if (num != 0)
				{
				}
				num = (short)1175322624;
				if (num != 0)
				{
				}
				this.uclMDCCnvHotList_ContactAlias_A00046 = value;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x001E5FB0 File Offset: 0x001E41B0
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x001E6064 File Offset: 0x001E4264
		public string UclMDCCnvHotList_ContactAlias_A00046_UIValue
		{
			get
			{
				short num = (short)831586304;
				short num2 = num;
				num = (short)462714405;
				short num3 = num;
				num = (short)66156069;
				switch (num3 == num)
				{
				}
				num = (short)1868169217;
				if (num != 0)
				{
				}
				num = (short)1753939968;
				if (num != 0)
				{
				}
				return this.uclMDCCnvHotList_ContactAlias_A00046.UIValue;
			}
			set
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					short num;
					int num3;
					global::AcpCommonLib.IAcpRecordset feature;
					for (;;)
					{
						IL_0A:
						num = (short)210829312;
						short num2 = num;
						switch (num3)
						{
						case 0:
							num = (short)383582209;
							if (num != 0)
							{
							}
							this.uclMDCCnvHotList_ContactAlias_A00046.UIValue = value;
							num = (short)2098659329;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							num = (short)1938004294;
							short num4 = num;
							num = (short)940808518;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)183566336;
								if (num != 0)
								{
								}
								goto IL_169;
							}
							break;
						}
						case 2:
							this.uclMDCCnvHotList_ContactAlias_A00046.UIValue = value;
							num = (short)706871304;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)2051735557;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (feature != null)
							{
								num = (short)1841627139;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 5:
							if (!((global::SpecialFeatures.Ucl.Contact.UclContactRecset)feature).ReachedMaxContactsHotlisted)
							{
								num = (short)1982529538;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1697120263;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							return;
						case 7:
						{
							if (this.uclMDCCnvHotList_ContactAlias_A00046.RefRecset.KeysToNode[value].KeyField.IsReferenced)
							{
								num = (short)1437466624;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							string reached_2000_maximum_number_of_contacts_can_be_hotlisted = global::CommonResources.AppResources.Reached_2000_maximum_number_of_contacts_can_be_hotlisted;
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, reached_2000_maximum_number_of_contacts_can_be_hotlisted);
							num = (short)840761353;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_169;
						case 9:
							goto IL_169;
						}
						break;
						IL_169:
						this.uclMDCCnvHotList_ContactAlias_A00046.SetUITimer();
						num = (short)485425158;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_60:
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2200);
					num = (short)1678376964;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x001E62C4 File Offset: 0x001E44C4
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x001E637C File Offset: 0x001E457C
		public bool UclMDCCnvHotList_ContactAlias_A00046_Applicable
		{
			get
			{
				short num = (short)593690624;
				short num2 = num;
				num = (short)1705152061;
				short num3 = num;
				num = (short)363236925;
				switch (num3 == num)
				{
				}
				num = (short)1911619585;
				if (num != 0)
				{
				}
				num = (short)1980170240;
				if (num != 0)
				{
				}
				return this.uclMDCCnvHotList_ContactAlias_A00046.Applicable;
			}
			set
			{
				short num = (short)1372782592;
				short num2 = num;
				num = (short)1797769333;
				short num3 = num;
				num = (short)287164533;
				switch (num3 == num)
				{
				}
				num = (short)1477967872;
				if (num != 0)
				{
				}
				num = (short)1157300225;
				if (num != 0)
				{
				}
				this.uclMDCCnvHotList_ContactAlias_A00046.Applicable = value;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x001E6430 File Offset: 0x001E4630
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x001E64E4 File Offset: 0x001E46E4
		public bool UclMDCCnvHotList_ContactAlias_A00046_Editable
		{
			get
			{
				short num = (short)359268352;
				short num2 = num;
				num = (short)1909788453;
				short num3 = num;
				num = (short)2135887653;
				switch (num3 == num)
				{
				}
				num = (short)1098776577;
				if (num != 0)
				{
				}
				num = (short)1639317504;
				if (num != 0)
				{
				}
				return this.uclMDCCnvHotList_ContactAlias_A00046.Editable;
			}
			set
			{
				short num = (short)1622671360;
				short num2 = num;
				num = (short)313760916;
				short num3 = num;
				num = (short)55614612;
				switch (num3 == num)
				{
				}
				num = (short)1505427457;
				if (num != 0)
				{
				}
				num = (short)1673854976;
				if (num != 0)
				{
				}
				this.uclMDCCnvHotList_ContactAlias_A00046.Editable = value;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x001E659C File Offset: 0x001E479C
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x001E6650 File Offset: 0x001E4850
		public bool UclMDCCnvHotList_ContactAlias_A00046_Visible
		{
			get
			{
				short num = (short)1287847936;
				short num2 = num;
				num = (short)1931938502;
				short num3 = num;
				num = (short)1235094214;
				switch (num3 == num)
				{
				}
				num = (short)863830017;
				if (num != 0)
				{
				}
				num = (short)1020854272;
				if (num != 0)
				{
				}
				return this.uclMDCCnvHotList_ContactAlias_A00046.Visible;
			}
			set
			{
				short num = (short)329318400;
				short num2 = num;
				num = (short)51830926;
				short num3 = num;
				num = (short)1706745998;
				switch (num3 == num)
				{
				}
				num = (short)1670905857;
				if (num != 0)
				{
				}
				num = (short)332922880;
				if (num != 0)
				{
				}
				this.uclMDCCnvHotList_ContactAlias_A00046.Visible = value;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x001E6704 File Offset: 0x001E4904
		// (set) Token: 0x060015A9 RID: 5545 RVA: 0x001E67B8 File Offset: 0x001E49B8
		public bool UclMDCCnvHotList_ContactAlias_A00046_Valid
		{
			get
			{
				short num = (short)1153302528;
				short num2 = num;
				num = (short)216166120;
				short num3 = num;
				num = (short)1418358504;
				switch (num3 == num)
				{
				}
				num = (short)1424687104;
				if (num != 0)
				{
				}
				num = (short)513605633;
				if (num != 0)
				{
				}
				return this.uclMDCCnvHotList_ContactAlias_A00046.Valid;
			}
			set
			{
				short num = (short)1893138432;
				short num2 = num;
				num = (short)1605240064;
				short num3 = num;
				num = (short)550307072;
				switch (num3 == num)
				{
				}
				num = (short)1571553281;
				if (num != 0)
				{
				}
				num = (short)1906638848;
				if (num != 0)
				{
				}
				this.uclMDCCnvHotList_ContactAlias_A00046.Valid = value;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x001E686C File Offset: 0x001E4A6C
		public bool UclMDCCnvHotList_ContactAlias_A00046_HasDiffs
		{
			get
			{
				short num = (short)1666752008;
				short num2 = num;
				num = (short)20225544;
				switch (num2 == num)
				{
				}
				num = (short)642121729;
				if (num != 0)
				{
				}
				num = (short)842072064;
				if (num != 0)
				{
				}
				num = (short)2000748544;
				short num3 = num;
				return this.uclMDCCnvHotList_ContactAlias_A00046._HasDiffs;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x001E6924 File Offset: 0x001E4B24
		// (set) Token: 0x060015AC RID: 5548 RVA: 0x001E69D8 File Offset: 0x001E4BD8
		public int UclMDCCnvHotList_CallID_A00047Value
		{
			get
			{
				short num = (short)92786324;
				short num2 = num;
				num = (short)516804244;
				switch (num2 == num)
				{
				}
				num = (short)1954480128;
				if (num != 0)
				{
				}
				num = (short)1632763905;
				if (num != 0)
				{
				}
				num = (short)742195200;
				short num3 = num;
				return this.uclMDCCnvHotList_CallID_A00047.Value;
			}
			set
			{
				short num = (short)1019956650;
				short num2 = num;
				num = (short)1914129834;
				switch (num2 == num)
				{
				}
				num = (short)631177217;
				if (num != 0)
				{
				}
				num = (short)681902080;
				if (num != 0)
				{
				}
				num = (short)1590886400;
				short num3 = num;
				this.uclMDCCnvHotList_CallID_A00047.Value = value;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x001E6A90 File Offset: 0x001E4C90
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x001E6B40 File Offset: 0x001E4D40
		public global::AcpBusinessLayer.AcpRecRefField UclMDCCnvHotList_CallID_A00047Object
		{
			get
			{
				short num = (short)1456036709;
				short num2 = num;
				num = (short)373775205;
				switch (num2 == num)
				{
				}
				num = (short)984350721;
				if (num != 0)
				{
				}
				num = (short)1467351040;
				if (num != 0)
				{
				}
				num = (short)901644288;
				short num3 = num;
				return this.uclMDCCnvHotList_CallID_A00047;
			}
			set
			{
				short num = (short)1344386446;
				short num2 = num;
				num = (short)1682290062;
				switch (num2 == num)
				{
				}
				num = (short)722665472;
				if (num != 0)
				{
				}
				num = (short)1056243713;
				if (num != 0)
				{
				}
				num = (short)164298752;
				short num3 = num;
				this.uclMDCCnvHotList_CallID_A00047 = value;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x001E6BF0 File Offset: 0x001E4DF0
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x001E6CA4 File Offset: 0x001E4EA4
		public string UclMDCCnvHotList_CallID_A00047_UIValue
		{
			get
			{
				short num = (short)1678689116;
				short num2 = num;
				num = (short)98354012;
				switch (num2 == num)
				{
				}
				num = (short)1021313025;
				if (num != 0)
				{
				}
				num = (short)1981939712;
				if (num != 0)
				{
				}
				num = (short)113704960;
				short num3 = num;
				return this.uclMDCCnvHotList_CallID_A00047.UIValue;
			}
			set
			{
				short num = (short)1842056235;
				short num2 = num;
				num = (short)1351191595;
				switch (num2 == num)
				{
				}
				num = (short)294912001;
				if (num != 0)
				{
				}
				num = (short)764280832;
				if (num != 0)
				{
				}
				num = (short)1898840064;
				short num3 = num;
				this.uclMDCCnvHotList_CallID_A00047.UIValue = value;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x001E6D58 File Offset: 0x001E4F58
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x001E6E0C File Offset: 0x001E500C
		public bool UclMDCCnvHotList_CallID_A00047_Applicable
		{
			get
			{
				short num = (short)1728377540;
				short num2 = num;
				num = (short)1461187268;
				switch (num2 == num)
				{
				}
				num = (short)54853632;
				if (num != 0)
				{
				}
				num = (short)1865875457;
				if (num != 0)
				{
				}
				num = (short)588316672;
				short num3 = num;
				return this.uclMDCCnvHotList_CallID_A00047.Applicable;
			}
			set
			{
				short num = (short)358067582;
				short num2 = num;
				num = (short)1006873982;
				switch (num2 == num)
				{
				}
				num = (short)1853030401;
				if (num != 0)
				{
				}
				num = (short)537526272;
				if (num != 0)
				{
				}
				num = (short)1275723776;
				short num3 = num;
				this.uclMDCCnvHotList_CallID_A00047.Applicable = value;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x001E6EC4 File Offset: 0x001E50C4
		// (set) Token: 0x060015B4 RID: 5556 RVA: 0x001E6F78 File Offset: 0x001E5178
		public bool UclMDCCnvHotList_CallID_A00047_Editable
		{
			get
			{
				short num = (short)577624692;
				short num2 = num;
				num = (short)2096355956;
				switch (num2 == num)
				{
				}
				num = (short)171835393;
				if (num != 0)
				{
				}
				num = (short)1939668992;
				if (num != 0)
				{
				}
				num = (short)882376704;
				short num3 = num;
				return this.uclMDCCnvHotList_CallID_A00047.Editable;
			}
			set
			{
				short num = (short)779834664;
				short num2 = num;
				num = (short)321672488;
				switch (num2 == num)
				{
				}
				num = (short)1622736897;
				if (num != 0)
				{
				}
				num = (short)392888320;
				if (num != 0)
				{
				}
				num = (short)1291452416;
				short num3 = num;
				this.uclMDCCnvHotList_CallID_A00047.Editable = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x001E702C File Offset: 0x001E522C
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x001E70E0 File Offset: 0x001E52E0
		public bool UclMDCCnvHotList_CallID_A00047_Visible
		{
			get
			{
				short num = (short)1276654985;
				short num2 = num;
				num = (short)1468675465;
				switch (num2 == num)
				{
				}
				num = (short)2042494977;
				if (num != 0)
				{
				}
				num = (short)2130640896;
				if (num != 0)
				{
				}
				num = (short)359464960;
				short num3 = num;
				return this.uclMDCCnvHotList_CallID_A00047.Visible;
			}
			set
			{
				short num = (short)1134952470;
				short num2 = num;
				num = (short)948633622;
				switch (num2 == num)
				{
				}
				num = (short)1552678912;
				if (num != 0)
				{
				}
				num = (short)1338834945;
				if (num != 0)
				{
				}
				num = (short)777322496;
				short num3 = num;
				this.uclMDCCnvHotList_CallID_A00047.Visible = value;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x001E7198 File Offset: 0x001E5398
		// (set) Token: 0x060015B8 RID: 5560 RVA: 0x001E724C File Offset: 0x001E544C
		public bool UclMDCCnvHotList_CallID_A00047_Valid
		{
			get
			{
				short num = (short)1002744608;
				short num2 = num;
				num = (short)437693216;
				switch (num2 == num)
				{
				}
				num = (short)1512308737;
				if (num != 0)
				{
				}
				num = (short)2018377728;
				if (num != 0)
				{
				}
				num = (short)1966014464;
				short num3 = num;
				return this.uclMDCCnvHotList_CallID_A00047.Valid;
			}
			set
			{
				short num = (short)482878220;
				short num2 = num;
				num = (short)204940044;
				switch (num2 == num)
				{
				}
				num = (short)1521156097;
				if (num != 0)
				{
				}
				num = (short)1046020096;
				if (num != 0)
				{
				}
				num = (short)2121728000;
				short num3 = num;
				this.uclMDCCnvHotList_CallID_A00047.Valid = value;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x001E7300 File Offset: 0x001E5500
		public bool UclMDCCnvHotList_CallID_A00047_HasDiffs
		{
			get
			{
				short num = (short)1333395457;
				if (num != 0)
				{
				}
				num = (short)1423245799;
				short num2 = num;
				num = (short)927465959;
				switch (num2 == num)
				{
				}
				num = (short)511115264;
				if (num != 0)
				{
				}
				num = (short)1254621184;
				short num3 = num;
				return this.uclMDCCnvHotList_CallID_A00047._HasDiffs;
			}
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x0000265F File Offset: 0x0000085F
		internal MDCCallHotListHotListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x001E73B4 File Offset: 0x001E55B4
		public override void Init()
		{
			int a_ = 14;
			short num = (short)1924402838;
			short num2 = num;
			num = (short)1546653334;
			switch (num2 == num)
			{
			}
			num = (short)295567361;
			if (num != 0)
			{
			}
			num = (short)15269888;
			if (num != 0)
			{
			}
			num = (short)1545142272;
			short num3 = num;
			this.uclMDCCnvHotList_ContactAlias_A00046 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒐璉\uda96\udd98\ud89a\ude9c힠쪤펦슪\udeac\udbae\udab4\ud9b6춸\udaba\udebc쮾胀꿂계ꛆ뫈铊賌ￎ", a_), global::CommonResources.AppResources.Contact_Id, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID
			}, new int[1], true);
			this.uclMDCCnvHotList_ContactAlias_A00046.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclMDCCnvHotList_ContactAlias_A00046.DataTransferOrder = 1;
			this.uclMDCCnvHotList_CallID_A00047 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒐璉\uda96\udd98\ud89a\ude9c힠쪤펦슪\udeac\udbae풴\udbb6햸寮胀﷈ﳊ", a_), global::CommonResources.AppResources.Call_ID, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID
			}, new int[]
			{
				65535
			}, false);
			this.uclMDCCnvHotList_CallID_A00047.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclMDCCnvHotList_CallID_A00047.DataTransferOrder = 2;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc90힒횔랖\uda98쒠춢톤캦욨얪첬쎮醰﮲\udab4쎶馸풼첾뗀", a_);
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_Hot_List;
			base.DataTransferOrder = 2;
			base.Id = 10420;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x001E753C File Offset: 0x001E573C
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)57344001;
			if (num != 0)
			{
			}
			num = (short)1177282811;
			short num2 = num;
			num = (short)117106939;
			switch (num2 == num)
			{
			}
			num = (short)1429143552;
			if (num != 0)
			{
			}
			num = (short)116129792;
			short num3 = num;
			base.GetObjectData(info, context);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x001E75F4 File Offset: 0x001E57F4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)1675809865;
			short num2 = num;
			num = (short)1376048201;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A1:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_2BC;
				}
				num = (short)649592836;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)308477952;
				if (num != 0)
				{
				}
				num = (short)644481033;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삔횚\ud99c\udc9e춢펤욨\udfaa욮슰잲횸햺즼\udebeꋀ럂蓄ꯆꃈ꫊뻌郎郐", a_)))
					{
						num = (short)868876290;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C5;
				case 1:
					goto IL_C5;
				case 2:
					this.uclMDCCnvHotList_ContactAlias_A00046 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삔횚\ud99c\udc9e춢펤욨\udfaa욮슰잲횸햺즼\udebeꋀ럂蓄ꯆꃈ꫊뻌郎郐", a_), global::CommonResources.AppResources.Contact_Id, new string[]
					{
						global::CommonResources.AppResources.Unassigned_ID
					}, new int[1], true);
					this.uclMDCCnvHotList_ContactAlias_A00046.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclMDCCnvHotList_ContactAlias_A00046.DataTransferOrder = 1;
					num = (short)1150812161;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)2043543552;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)2071134214;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.uclMDCCnvHotList_CallID_A00047 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삔횚\ud99c\udc9e춢펤욨\udfaa욮슰잲\ud8b8ힺ톼藀鳂蓄杻﯊琉", a_), global::CommonResources.AppResources.Call_ID, new string[]
					{
						global::CommonResources.AppResources.Unassigned_ID
					}, new int[]
					{
						65535
					}, false);
					this.uclMDCCnvHotList_CallID_A00047.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclMDCCnvHotList_CallID_A00047.DataTransferOrder = 2;
					num = (short)2023358465;
					if (num != 0)
					{
					}
					num = (short)1648820231;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields != null)
					{
						num = (short)1647443971;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2BC;
				case 7:
					goto IL_26C;
				case 8:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삔횚\ud99c\udc9e춢펤욨\udfaa욮슰잲\ud8b8ힺ톼藀鳂蓄杻﯊琉", a_)))
					{
						num = (short)1430913029;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2BC;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_A1;
					}
					continue;
				}
				goto IL_A1;
				IL_C5:
				num = (short)822607872;
				short num4 = num;
				num = (short)1319698440;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_26C:
			IL_2BC:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud894펖\uda98뮚\ude9c쾠햢삤즦\udda8슪슬솮킰\udfb2閴ﾶ횸쾺鶼ꣀ냂뇄", a_);
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_Hot_List;
			base.DataTransferOrder = 2;
			base.Id = 10420;
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x001E78F0 File Offset: 0x001E5AF0
		public global::SpecialFeatures.Ucl.Contact.UclContact Contact
		{
			get
			{
				short num = (short)241041340;
				short num2 = num;
				num = (short)1135345596;
				switch (num2 == num)
				{
				}
				num = (short)1682767873;
				if (num != 0)
				{
				}
				num = (short)1459355648;
				if (num != 0)
				{
				}
				num = (short)1319763968;
				short num3 = num;
				return (global::SpecialFeatures.Ucl.Contact.UclContact)this.uclMDCCnvHotList_ContactAlias_A00046.ReferencedNode;
			}
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x001E79AC File Offset: 0x001E5BAC
		public override void PopulateReferences()
		{
			short num = (short)954007556;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.uclMDCCnvHotList_ContactAlias_A00046.SetRecset(base.ParentRecset.ContainerDoc.GetFeature(2200));
					this.uclMDCCnvHotList_ContactAlias_A00046.AddSlaveField(this.uclMDCCnvHotList_CallID_A00047, 10405);
					num = (short)243269634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)740491264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					return;
				case 3:
				{
					num = (short)1019346945;
					if (num != 0)
					{
					}
					num = (short)1582628864;
					short num3 = num;
					num = (short)1966874591;
					short num4 = num;
					num = (short)747053023;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1862008832;
						if (num != 0)
						{
						}
						num = (short)202178561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (base.ParentRecset == null)
				{
					break;
				}
				num = (short)471072771;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x001E7B44 File Offset: 0x001E5D44
		public override void DropReferences()
		{
			short num = (short)829021560;
			short num2 = num;
			num = (short)595516792;
			switch (num2 == num)
			{
			}
			num = (short)663552000;
			if (num != 0)
			{
			}
			num = (short)444530689;
			if (num != 0)
			{
			}
			num = (short)936247296;
			short num3 = num;
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x001E7BF4 File Offset: 0x001E5DF4
		public override void SetConstraints()
		{
			short num = (short)1851720425;
			short num2 = num;
			num = (short)725222121;
			switch (num2 == num)
			{
			}
			num = (short)2078605312;
			if (num != 0)
			{
			}
			num = (short)152698881;
			if (num != 0)
			{
			}
			num = (short)976158720;
			short num3 = num;
			this.uclMDCCnvHotList_CallID_A00047.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.Ucl.HotList.UclHotListConstraints.conMDCHotListCallIDIsValid);
			this.uclMDCCnvHotList_CallID_A00047.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.HotList.UclHotListConstraints.ConMDCContactAliasIsNotUnassigned);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x001E7CCC File Offset: 0x001E5ECC
		public override void SetupDependencies()
		{
			short num = (short)142916974;
			short num2 = num;
			num = (short)1887026542;
			switch (num2 == num)
			{
			}
			num = (short)2012151808;
			if (num != 0)
			{
			}
			num = (short)1324351489;
			if (num != 0)
			{
			}
			num = (short)288751616;
			short num3 = num;
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x001E7D74 File Offset: 0x001E5F74
		public bool HasDiffs
		{
			get
			{
				short num = (short)131602593;
				short num2 = num;
				num = (short)8394913;
				switch (num2 == num)
				{
				}
				num = (short)1928986625;
				if (num != 0)
				{
				}
				num = (short)1335623680;
				if (num != 0)
				{
				}
				num = (short)2068512768;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x04000B87 RID: 2951
		private global::AcpBusinessLayer.AcpRecRefField uclMDCCnvHotList_ContactAlias_A00046;

		// Token: 0x04000B88 RID: 2952
		private global::AcpBusinessLayer.AcpRecRefField uclMDCCnvHotList_CallID_A00047;
	}
}
