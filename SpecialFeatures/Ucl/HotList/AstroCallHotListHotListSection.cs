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
	// Token: 0x020001BD RID: 445
	[global::System.Serializable]
	public sealed class AstroCallHotListHotListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001535 RID: 5429 RVA: 0x00002650 File Offset: 0x00000850
		internal AstroCallHotListHotListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x001E0D08 File Offset: 0x001DEF08
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x001E0DBC File Offset: 0x001DEFBC
		public int UclAstroCnvHotList_ContactAlias_A00043Value
		{
			get
			{
				short num = (short)713920646;
				short num2 = num;
				num = (short)1540264070;
				switch (num2 == num)
				{
				}
				num = (short)1537146880;
				if (num != 0)
				{
				}
				num = (short)638517248;
				short num3 = num;
				num = (short)896401409;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_ContactAlias_A00043.Value;
			}
			set
			{
				short num = (short)1482075747;
				short num2 = num;
				num = (short)253931107;
				switch (num2 == num)
				{
				}
				num = (short)2127560705;
				if (num != 0)
				{
				}
				num = (short)26345472;
				short num3 = num;
				num = (short)816840704;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_ContactAlias_A00043.Value = value;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x001E0E74 File Offset: 0x001DF074
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x001E0F28 File Offset: 0x001DF128
		public global::AcpBusinessLayer.AcpRecRefField UclAstroCnvHotList_ContactAlias_A00043Object
		{
			get
			{
				short num = (short)1892292285;
				short num2 = num;
				num = (short)231216829;
				switch (num2 == num)
				{
				}
				num = (short)491913217;
				if (num != 0)
				{
				}
				num = (short)45416448;
				short num3 = num;
				num = (short)9568256;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_ContactAlias_A00043;
			}
			set
			{
				short num = (short)1016843908;
				short num2 = num;
				num = (short)1293012612;
				switch (num2 == num)
				{
				}
				num = (short)621805569;
				if (num != 0)
				{
				}
				num = (short)773718016;
				short num3 = num;
				num = (short)1214840832;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_ContactAlias_A00043 = value;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x001E0FD8 File Offset: 0x001DF1D8
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x001E1090 File Offset: 0x001DF290
		public string UclAstroCnvHotList_ContactAlias_A00043_UIValue
		{
			get
			{
				short num = (short)1704468476;
				short num2 = num;
				num = (short)430579708;
				switch (num2 == num)
				{
				}
				num = (short)1564868608;
				if (num != 0)
				{
				}
				num = (short)1249968128;
				short num3 = num;
				num = (short)524746753;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_ContactAlias_A00043.UIValue;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				short num2;
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_1E0;
					case 1:
						this.uclAstroCnvHotList_ContactAlias_A00043.UIValue = value;
						num2 = (short)628948992;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						num2 = (short)359464969;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						num2 = (short)1395130368;
						short num3 = num2;
						if (this.uclAstroCnvHotList_ContactAlias_A00043.RefRecset.KeysToNode[value].KeyField.IsReferenced)
						{
							num2 = (short)867237896;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						string reached_2000_maximum_number_of_contacts_can_be_hotlisted = global::CommonResources.AppResources.Reached_2000_maximum_number_of_contacts_can_be_hotlisted;
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, reached_2000_maximum_number_of_contacts_can_be_hotlisted);
						num2 = (short)1091436549;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						return;
					case 5:
						num2 = (short)1133445121;
						if (num2 != 0)
						{
						}
						goto IL_1E0;
					case 6:
						goto IL_1E0;
					case 7:
						if (feature != null)
						{
							num2 = (short)1977090050;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 8:
						this.uclAstroCnvHotList_ContactAlias_A00043.UIValue = value;
						num2 = (short)1603469318;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
					{
						if (((global::SpecialFeatures.Ucl.Contact.UclContactRecset)feature).ReachedMaxContactsHotlisted)
						{
							num2 = (short)25821187;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)730121079;
						short num4 = num2;
						num2 = (short)1571406711;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num2 = (short)2098397184;
							if (num2 != 0)
							{
							}
							num2 = (short)1395916801;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_38;
					IL_1E0:
					this.uclAstroCnvHotList_ContactAlias_A00043.SetUITimer();
					num2 = (short)146604036;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_38:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2200);
				num2 = (short)1210056711;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x001E12F0 File Offset: 0x001DF4F0
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x001E13A4 File Offset: 0x001DF5A4
		public bool UclAstroCnvHotList_ContactAlias_A00043_Applicable
		{
			get
			{
				short num = (short)14272469;
				short num2 = num;
				num = (short)1773062101;
				switch (num2 == num)
				{
				}
				num = (short)429129728;
				if (num != 0)
				{
				}
				num = (short)456720384;
				short num3 = num;
				num = (short)994508801;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_ContactAlias_A00043.Applicable;
			}
			set
			{
				short num = (short)1946355364;
				short num2 = num;
				num = (short)1540294308;
				switch (num2 == num)
				{
				}
				num = (short)1807286272;
				if (num != 0)
				{
				}
				num = (short)2147352576;
				short num3 = num;
				num = (short)529465345;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_ContactAlias_A00043.Applicable = value;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x001E1458 File Offset: 0x001DF658
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x001E150C File Offset: 0x001DF70C
		public bool UclAstroCnvHotList_ContactAlias_A00043_Editable
		{
			get
			{
				short num = (short)1254256825;
				short num2 = num;
				num = (short)1255960761;
				switch (num2 == num)
				{
				}
				num = (short)648282112;
				if (num != 0)
				{
				}
				num = (short)1166082048;
				short num3 = num;
				num = (short)1158348801;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_ContactAlias_A00043.Editable;
			}
			set
			{
				short num = (short)1474348324;
				short num2 = num;
				num = (short)1274529060;
				switch (num2 == num)
				{
				}
				num = (short)1481113601;
				if (num != 0)
				{
				}
				num = (short)1776353280;
				short num3 = num;
				num = (short)916193280;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_ContactAlias_A00043.Editable = value;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x001E15C4 File Offset: 0x001DF7C4
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x001E167C File Offset: 0x001DF87C
		public bool UclAstroCnvHotList_ContactAlias_A00043_Visible
		{
			get
			{
				short num = (short)1258940126;
				short num2 = num;
				num = (short)1841161950;
				switch (num2 == num)
				{
				}
				num = (short)421527553;
				if (num != 0)
				{
				}
				num = (short)676200448;
				short num3 = num;
				num = (short)1944125440;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_ContactAlias_A00043.Visible;
			}
			set
			{
				short num = (short)1596788904;
				short num2 = num;
				num = (short)1959858344;
				switch (num2 == num)
				{
				}
				num = (short)1937571840;
				if (num != 0)
				{
				}
				num = (short)848363520;
				short num3 = num;
				num = (short)1502347265;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_ContactAlias_A00043.Visible = value;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x001E1730 File Offset: 0x001DF930
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x001E17E8 File Offset: 0x001DF9E8
		public bool UclAstroCnvHotList_ContactAlias_A00043_Valid
		{
			get
			{
				short num = (short)922222593;
				if (num != 0)
				{
				}
				num = (short)1701403337;
				short num2 = num;
				num = (short)1494964937;
				switch (num2 == num)
				{
				}
				num = (short)910884864;
				short num3 = num;
				num = (short)612696064;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_ContactAlias_A00043.Valid;
			}
			set
			{
				short num = (short)1425602200;
				short num2 = num;
				num = (short)1825699480;
				switch (num2 == num)
				{
				}
				num = (short)764084225;
				if (num != 0)
				{
				}
				num = (short)1013776384;
				short num3 = num;
				num = (short)598605824;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_ContactAlias_A00043.Valid = value;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x001E189C File Offset: 0x001DFA9C
		public bool UclAstroCnvHotList_ContactAlias_A00043_HasDiffs
		{
			get
			{
				short num = (short)1040035247;
				short num2 = num;
				num = (short)1744416175;
				switch (num2 == num)
				{
				}
				num = (short)856883201;
				if (num != 0)
				{
				}
				num = (short)1865875456;
				short num3 = num;
				num = (short)406716416;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_ContactAlias_A00043._HasDiffs;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x001E1954 File Offset: 0x001DFB54
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x001E1A0C File Offset: 0x001DFC0C
		public int UclAstroCnvHotList_CallID_A00044Value
		{
			get
			{
				short num = (short)2047641136;
				short num2 = num;
				num = (short)58099248;
				switch (num2 == num)
				{
				}
				num = (short)1906835457;
				if (num != 0)
				{
				}
				num = (short)1137442816;
				short num3 = num;
				num = (short)1007353856;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_CallID_A00044.Value;
			}
			set
			{
				short num = (short)268210053;
				short num2 = num;
				num = (short)6459269;
				switch (num2 == num)
				{
				}
				num = (short)286261248;
				if (num != 0)
				{
				}
				num = (short)260112384;
				short num3 = num;
				num = (short)918945793;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_CallID_A00044.Value = value;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x001E1AC0 File Offset: 0x001DFCC0
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x001E1B70 File Offset: 0x001DFD70
		public global::AcpBusinessLayer.AcpRecRefField UclAstroCnvHotList_CallID_A00044Object
		{
			get
			{
				short num = (short)1017638022;
				short num2 = num;
				num = (short)1537666182;
				switch (num2 == num)
				{
				}
				num = (short)458162176;
				if (num != 0)
				{
				}
				num = (short)1775042560;
				short num3 = num;
				num = (short)1525874689;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_CallID_A00044;
			}
			set
			{
				short num = (short)79495169;
				if (num != 0)
				{
				}
				num = (short)1055527857;
				short num2 = num;
				num = (short)834147249;
				switch (num2 == num)
				{
				}
				num = (short)2060320768;
				short num3 = num;
				num = (short)1071710208;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_CallID_A00044 = value;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x001E1C24 File Offset: 0x001DFE24
		// (set) Token: 0x0600154A RID: 5450 RVA: 0x001E1CD8 File Offset: 0x001DFED8
		public string UclAstroCnvHotList_CallID_A00044_UIValue
		{
			get
			{
				short num = (short)1508084056;
				short num2 = num;
				num = (short)283478360;
				switch (num2 == num)
				{
				}
				num = (short)1769078785;
				if (num != 0)
				{
				}
				num = (short)1657602048;
				short num3 = num;
				num = (short)630063104;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_CallID_A00044.UIValue;
			}
			set
			{
				short num = (short)182826708;
				short num2 = num;
				num = (short)159692500;
				switch (num2 == num)
				{
				}
				num = (short)1540423681;
				if (num != 0)
				{
				}
				num = (short)1670840320;
				short num3 = num;
				num = (short)185597952;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_CallID_A00044.UIValue = value;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x001E1D90 File Offset: 0x001DFF90
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x001E1E48 File Offset: 0x001E0048
		public bool UclAstroCnvHotList_CallID_A00044_Applicable
		{
			get
			{
				short num = (short)1776510231;
				short num2 = num;
				num = (short)32138519;
				switch (num2 == num)
				{
				}
				num = (short)1035599873;
				if (num != 0)
				{
				}
				num = (short)2029518848;
				short num3 = num;
				num = (short)1792475136;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_CallID_A00044.Applicable;
			}
			set
			{
				short num = (short)698565663;
				short num2 = num;
				num = (short)770655263;
				switch (num2 == num)
				{
				}
				num = (short)965083137;
				if (num != 0)
				{
				}
				num = (short)1614544896;
				short num3 = num;
				num = (short)790298624;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_CallID_A00044.Applicable = value;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x001E1F00 File Offset: 0x001E0100
		// (set) Token: 0x0600154E RID: 5454 RVA: 0x001E1FB4 File Offset: 0x001E01B4
		public bool UclAstroCnvHotList_CallID_A00044_Editable
		{
			get
			{
				short num = (short)1718996271;
				short num2 = num;
				num = (short)138399023;
				switch (num2 == num)
				{
				}
				num = (short)1501757441;
				if (num != 0)
				{
				}
				num = (short)1392836608;
				short num3 = num;
				num = (short)1832452096;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_CallID_A00044.Editable;
			}
			set
			{
				short num = (short)771113964;
				short num2 = num;
				num = (short)2028225516;
				switch (num2 == num)
				{
				}
				num = (short)784531457;
				if (num != 0)
				{
				}
				num = (short)1569062912;
				short num3 = num;
				num = (short)2074673152;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_CallID_A00044.Editable = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x001E206C File Offset: 0x001E026C
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x001E2120 File Offset: 0x001E0320
		public bool UclAstroCnvHotList_CallID_A00044_Visible
		{
			get
			{
				short num = (short)2076442625;
				if (num != 0)
				{
				}
				num = (short)1800565307;
				short num2 = num;
				num = (short)1395290683;
				switch (num2 == num)
				{
				}
				num = (short)2021982208;
				short num3 = num;
				num = (short)428277760;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_CallID_A00044.Visible;
			}
			set
			{
				short num = (short)156779864;
				short num2 = num;
				num = (short)943211864;
				switch (num2 == num)
				{
				}
				num = (short)1701183488;
				if (num != 0)
				{
				}
				num = (short)601358336;
				short num3 = num;
				num = (short)1644232705;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_CallID_A00044.Visible = value;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x001E21D4 File Offset: 0x001E03D4
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x001E228C File Offset: 0x001E048C
		public bool UclAstroCnvHotList_CallID_A00044_Valid
		{
			get
			{
				short num = (short)1966050116;
				short num2 = num;
				num = (short)2018872132;
				switch (num2 == num)
				{
				}
				num = (short)859439104;
				if (num != 0)
				{
				}
				num = (short)1055522816;
				short num3 = num;
				num = (short)900595713;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_CallID_A00044.Valid;
			}
			set
			{
				short num = (short)1144743864;
				short num2 = num;
				num = (short)1434675128;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1785856000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1204486145;
				if (num != 0)
				{
				}
				num = (short)1381564416;
				if (num != 0)
				{
				}
				this.uclAstroCnvHotList_CallID_A00044.Valid = value;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x001E2344 File Offset: 0x001E0544
		public bool UclAstroCnvHotList_CallID_A00044_HasDiffs
		{
			get
			{
				short num = (short)1828070951;
				short num2 = num;
				num = (short)46081575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1489240064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)361168897;
				if (num != 0)
				{
				}
				num = (short)1930428416;
				if (num != 0)
				{
				}
				return this.uclAstroCnvHotList_CallID_A00044._HasDiffs;
			}
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0000265F File Offset: 0x0000085F
		internal AstroCallHotListHotListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x001E23F4 File Offset: 0x001E05F4
		public override void Init()
		{
			int a_ = 7;
			short num = (short)439688090;
			short num2 = num;
			num = (short)1104812954;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1235419136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1860960256;
			if (num != 0)
			{
			}
			num = (short)311951361;
			if (num != 0)
			{
			}
			this.uclAstroCnvHotList_ContactAlias_A00043 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf89톏\ud999춡킣솧\ud9a9\ud8ab\uddb1\udab3습\ud9b7\ud9b9좻ﾽ겿ꯁꗃ뗅韇诉ﳋﻍ", a_), global::CommonResources.AppResources.Contact_Id, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID
			}, new int[1], true);
			this.uclAstroCnvHotList_ContactAlias_A00043.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstroCnvHotList_ContactAlias_A00043.DataTransferOrder = 1;
			this.uclAstroCnvHotList_CallID_A00044 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf89톏\ud999춡킣솧\ud9a9\ud8ab펱\ud8b3\udab5ﺹﾽﳇ", a_), global::CommonResources.AppResources.Call_ID, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID
			}, new int[]
			{
				65535
			}, false);
			this.uclAstroCnvHotList_CallID_A00044.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstroCnvHotList_CallID_A00044.DataTransferOrder = 2;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮉\udf8b\uda8d슏\udd91뒓햕ﮝ캟횡춣즥욧쮩삫躭\uddb1삳隵펹쾻쪽", a_);
			base.UIName = global::CommonResources.AppResources.ASTRO_Conventional_Hot_List;
			base.DataTransferOrder = 1;
			base.Id = 10418;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x001E2574 File Offset: 0x001E0774
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)2142564003;
			short num2 = num;
			num = (short)2039082659;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1291452416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1803681792;
			if (num != 0)
			{
			}
			num = (short)540934145;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x001E2624 File Offset: 0x001E0824
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)421396486;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields != null)
					{
						num = (short)342360068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C5;
				case 1:
					goto IL_276;
				case 2:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톃쮉ﾋ揄﶑힓튙쮡힣튥쎫삭쒯펱ힳ습醴횹햻\udfbd뎿鷁藃韛﷍", a_)))
					{
						num = (short)1898971145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A;
				case 3:
					goto IL_7A;
				case 4:
					num = (short)1228931074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)253071540;
					short num3 = num;
					num = (short)823890100;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1099431936;
						if (num != 0)
						{
						}
						this.uclAstroCnvHotList_CallID_A00044 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톃쮉ﾋ揄﶑힓튙쮡힣튥춫슭\udcafﮱ醴誹費躽", a_), global::CommonResources.AppResources.Call_ID, new string[]
						{
							global::CommonResources.AppResources.Unassigned_ID
						}, new int[]
						{
							65535
						}, false);
						this.uclAstroCnvHotList_CallID_A00044.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.uclAstroCnvHotList_CallID_A00044.DataTransferOrder = 2;
						break;
					}
					num = (short)519372801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 7:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톃쮉ﾋ揄﶑힓튙쮡힣튥춫슭\udcafﮱ醴誹費躽", a_)))
					{
						num = (short)291110917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C5;
				case 8:
				{
					num = (short)1534132224;
					short num4 = num;
					num = (short)686817280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					this.uclAstroCnvHotList_ContactAlias_A00043 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톃쮉ﾋ揄﶑힓튙쮡힣튥쎫삭쒯펱ힳ습醴횹햻\udfbd뎿鷁藃韛﷍", a_), global::CommonResources.AppResources.Contact_Id, new string[]
					{
						global::CommonResources.AppResources.Unassigned_ID
					}, new int[1], true);
					this.uclAstroCnvHotList_ContactAlias_A00043.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstroCnvHotList_ContactAlias_A00043.DataTransferOrder = 1;
					num = (short)1204420611;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1063452680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7A:
				num = (short)782893057;
				if (num != 0)
				{
				}
				num = (short)383647751;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_276:
			IL_2C5:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얃햅\udc87\ud889쎋꺍펏﶑望ﶗ쾟첡얣쪥袧쎫\udaad邯ﺱ\uddb3억첷", a_);
			base.UIName = global::CommonResources.AppResources.ASTRO_Conventional_Hot_List;
			base.DataTransferOrder = 1;
			base.Id = 10418;
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x001E2928 File Offset: 0x001E0B28
		public global::SpecialFeatures.Ucl.Contact.UclContact Contact
		{
			get
			{
				short num = (short)29268792;
				short num2 = num;
				num = (short)2010946360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1306984448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1846214656;
				if (num != 0)
				{
				}
				num = (short)335085569;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.UclContact)this.uclAstroCnvHotList_ContactAlias_A00043.ReferencedNode;
			}
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x001E29E0 File Offset: 0x001E0BE0
		public override void PopulateReferences()
		{
			short num = (short)1348993027;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14B;
				case 1:
				{
					num = (short)1796022855;
					short num3 = num;
					num = (short)515318343;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14B;
					default:
						goto IL_E0;
					}
					break;
				}
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)396427268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 4:
					this.uclAstroCnvHotList_ContactAlias_A00043.SetRecset(base.ParentRecset.ContainerDoc.GetFeature(2200));
					this.uclAstroCnvHotList_ContactAlias_A00043.AddSlaveField(this.uclAstroCnvHotList_CallID_A00044, 10403);
					num = (short)479920129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_39:
				if (base.ParentRecset != null)
				{
					num = (short)1113325568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_14B:
				num = (short)769785858;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E0:
			num = (short)530120704;
			short num4 = num;
			num = (short)657195009;
			if (num != 0)
			{
			}
			num = (short)1233649664;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x001E2B78 File Offset: 0x001E0D78
		public override void DropReferences()
		{
			short num = (short)1634729985;
			if (num != 0)
			{
			}
			num = (short)1462894592;
			short num2 = num;
			num = (short)1646594693;
			short num3 = num;
			num = (short)2044004997;
			switch (num3 == num)
			{
			}
			num = (short)451149824;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x001E2C20 File Offset: 0x001E0E20
		public override void SetConstraints()
		{
			short num = (short)2114259240;
			short num2 = num;
			num = (short)650447144;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1682898944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1556676609;
			if (num != 0)
			{
			}
			num = (short)1137704960;
			if (num != 0)
			{
			}
			this.uclAstroCnvHotList_CallID_A00044.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.Ucl.HotList.UclHotListConstraints.conAstroHotListCallIDIsValid);
			this.uclAstroCnvHotList_CallID_A00044.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.HotList.UclHotListConstraints.ConAstroContactAliasIsNotUnassigned);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x001E2CF8 File Offset: 0x001E0EF8
		public override void SetupDependencies()
		{
			short num = (short)942342334;
			short num2 = num;
			num = (short)1613627582;
			switch (num2 == num)
			{
			default:
			{
				num = (short)331874304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)75038721;
			if (num != 0)
			{
			}
			num = (short)917307392;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x001E2DA0 File Offset: 0x001E0FA0
		public bool HasDiffs
		{
			get
			{
				short num = (short)505366279;
				short num2 = num;
				num = (short)303187719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1279590400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1443889153;
				if (num != 0)
				{
				}
				num = (short)1855193088;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04000B80 RID: 2944
		private global::AcpBusinessLayer.AcpRecRefField uclAstroCnvHotList_ContactAlias_A00043;

		// Token: 0x04000B81 RID: 2945
		private global::AcpBusinessLayer.AcpRecRefField uclAstroCnvHotList_CallID_A00044;
	}
}
