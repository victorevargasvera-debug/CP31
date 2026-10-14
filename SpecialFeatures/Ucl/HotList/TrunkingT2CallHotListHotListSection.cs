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
	// Token: 0x020001D0 RID: 464
	[global::System.Serializable]
	public sealed class TrunkingT2CallHotListHotListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600166D RID: 5741 RVA: 0x00002650 File Offset: 0x00000850
		internal TrunkingT2CallHotListHotListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x001F04FC File Offset: 0x001EE6FC
		// (set) Token: 0x0600166F RID: 5743 RVA: 0x001F05B4 File Offset: 0x001EE7B4
		public int UclT2TrkHotList_ContactAlias_A00040Value
		{
			get
			{
				short num = (short)535266293;
				short num2 = num;
				num = (short)2145682421;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1266089984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1535967233;
				if (num != 0)
				{
				}
				num = (short)1354301440;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_ContactAlias_A00040.Value;
			}
			set
			{
				short num = (short)657589512;
				short num2 = num;
				num = (short)992085256;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1432354816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1872494593;
				if (num != 0)
				{
				}
				num = (short)1536819200;
				if (num != 0)
				{
				}
				this.uclT2TrkHotList_ContactAlias_A00040.Value = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x001F0668 File Offset: 0x001EE868
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x001F0718 File Offset: 0x001EE918
		public global::AcpBusinessLayer.AcpRecRefField UclT2TrkHotList_ContactAlias_A00040Object
		{
			get
			{
				short num = (short)421694273;
				short num2 = num;
				num = (short)1428065089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)439025664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1847263233;
				if (num != 0)
				{
				}
				num = (short)64880640;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_ContactAlias_A00040;
			}
			set
			{
				short num = (short)827588609;
				if (num != 0)
				{
				}
				num = (short)771686400;
				short num2 = num;
				num = (short)826110136;
				short num3 = num;
				num = (short)703885496;
				switch (num3 == num)
				{
				}
				num = (short)1627717632;
				if (num != 0)
				{
				}
				this.uclT2TrkHotList_ContactAlias_A00040 = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x001F07C8 File Offset: 0x001EE9C8
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x001F087C File Offset: 0x001EEA7C
		public string UclT2TrkHotList_ContactAlias_A00040_UIValue
		{
			get
			{
				short num = (short)1277197081;
				short num2 = num;
				num = (short)1247771417;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2025062400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1372258304;
				if (num != 0)
				{
				}
				num = (short)1528102913;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_ContactAlias_A00040.UIValue;
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
					{
						if (this.uclT2TrkHotList_ContactAlias_A00040.RefRecset.KeysToNode[value].KeyField.IsReferenced)
						{
							num2 = (short)692322305;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						string reached_2000_maximum_number_of_contacts_can_be_hotlisted = global::CommonResources.AppResources.Reached_2000_maximum_number_of_contacts_can_be_hotlisted;
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, reached_2000_maximum_number_of_contacts_can_be_hotlisted);
						num2 = (short)1825374210;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						this.uclT2TrkHotList_ContactAlias_A00040.UIValue = value;
						num2 = (short)1514209285;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						num2 = (short)285540353;
						if (num2 != 0)
						{
						}
						goto IL_164;
					case 3:
						if (!((global::SpecialFeatures.Ucl.Contact.UclContactRecset)feature).ReachedMaxContactsHotlisted)
						{
							num2 = (short)420085764;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1240727552;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
					{
						num2 = (short)1960837120;
						short num3 = num2;
						this.uclT2TrkHotList_ContactAlias_A00040.UIValue = value;
						num2 = (short)445120519;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						goto IL_164;
					case 6:
						num2 = (short)1831600131;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
					{
						num2 = (short)1939113316;
						short num4 = num2;
						num2 = (short)420906340;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)1918959616;
							if (num2 != 0)
							{
							}
							goto IL_164;
						}
						break;
					}
					case 8:
						return;
					case 9:
						if (feature != null)
						{
							num2 = (short)643104774;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					goto IL_38;
					IL_164:
					this.uclT2TrkHotList_ContactAlias_A00040.SetUITimer();
					num2 = (short)1603665928;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_38:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2200);
				num2 = (short)2048327689;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x001F0AE0 File Offset: 0x001EECE0
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x001F0B94 File Offset: 0x001EED94
		public bool UclT2TrkHotList_ContactAlias_A00040_Applicable
		{
			get
			{
				short num = (short)718209025;
				if (num != 0)
				{
				}
				num = (short)1326448640;
				short num2 = num;
				num = (short)1155322557;
				short num3 = num;
				num = (short)1171051197;
				switch (num3 == num)
				{
				}
				num = (short)759365632;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_ContactAlias_A00040.Applicable;
			}
			set
			{
				short num = (short)1216400060;
				short num2 = num;
				num = (short)1323813564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)219283456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)835846145;
				if (num != 0)
				{
				}
				num = (short)385810432;
				if (num != 0)
				{
				}
				this.uclT2TrkHotList_ContactAlias_A00040.Applicable = value;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x001F0C4C File Offset: 0x001EEE4C
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x001F0D00 File Offset: 0x001EEF00
		public bool UclT2TrkHotList_ContactAlias_A00040_Editable
		{
			get
			{
				short num = (short)1987510273;
				if (num != 0)
				{
				}
				num = (short)830013440;
				short num2 = num;
				num = (short)1859962088;
				short num3 = num;
				num = (short)1340458216;
				switch (num3 == num)
				{
				}
				num = (short)2010382336;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_ContactAlias_A00040.Editable;
			}
			set
			{
				short num = (short)1051590657;
				if (num != 0)
				{
				}
				num = (short)587595776;
				short num2 = num;
				num = (short)1359823498;
				short num3 = num;
				num = (short)1461207690;
				switch (num3 == num)
				{
				}
				num = (short)768475136;
				if (num != 0)
				{
				}
				this.uclT2TrkHotList_ContactAlias_A00040.Editable = value;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x001F0DB4 File Offset: 0x001EEFB4
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x001F0E68 File Offset: 0x001EF068
		public bool UclT2TrkHotList_ContactAlias_A00040_Visible
		{
			get
			{
				short num = (short)1393801679;
				short num2 = num;
				num = (short)1065204175;
				switch (num2 == num)
				{
				}
				num = (short)2061434880;
				short num3 = num;
				num = (short)1388249088;
				if (num != 0)
				{
				}
				num = (short)778502145;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_ContactAlias_A00040.Visible;
			}
			set
			{
				short num = (short)1670866972;
				short num2 = num;
				num = (short)1802135580;
				switch (num2 == num)
				{
				}
				num = (short)620888064;
				short num3 = num;
				num = (short)429916160;
				if (num != 0)
				{
				}
				num = (short)397017089;
				if (num != 0)
				{
				}
				this.uclT2TrkHotList_ContactAlias_A00040.Visible = value;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x001F0F20 File Offset: 0x001EF120
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x001F0FD4 File Offset: 0x001EF1D4
		public bool UclT2TrkHotList_ContactAlias_A00040_Valid
		{
			get
			{
				short num = (short)730886546;
				short num2 = num;
				num = (short)1993044370;
				switch (num2 == num)
				{
				}
				num = (short)1766129664;
				short num3 = num;
				num = (short)2042626049;
				if (num != 0)
				{
				}
				num = (short)2129264640;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_ContactAlias_A00040.Valid;
			}
			set
			{
				short num = (short)485448988;
				short num2 = num;
				num = (short)1223974172;
				switch (num2 == num)
				{
				}
				num = (short)2081423360;
				short num3 = num;
				num = (short)1353777152;
				if (num != 0)
				{
				}
				num = (short)1159659521;
				if (num != 0)
				{
				}
				this.uclT2TrkHotList_ContactAlias_A00040.Valid = value;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x001F1088 File Offset: 0x001EF288
		public bool UclT2TrkHotList_ContactAlias_A00040_HasDiffs
		{
			get
			{
				short num = (short)1119703288;
				short num2 = num;
				num = (short)858935544;
				switch (num2 == num)
				{
				}
				num = (short)1036648448;
				short num3 = num;
				num = (short)1505755136;
				if (num != 0)
				{
				}
				num = (short)1885470721;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_ContactAlias_A00040._HasDiffs;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x001F113C File Offset: 0x001EF33C
		// (set) Token: 0x0600167E RID: 5758 RVA: 0x001F11F0 File Offset: 0x001EF3F0
		public int UclT2TrkHotList_CallID_A00041Value
		{
			get
			{
				short num = (short)1439367169;
				if (num != 0)
				{
				}
				num = (short)901774174;
				short num2 = num;
				num = (short)1164114782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)29753344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1476132864;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_CallID_A00041.Value;
			}
			set
			{
				short num = (short)595361302;
				short num2 = num;
				num = (short)403865110;
				switch (num2 == num)
				{
				}
				num = (short)374669312;
				short num3 = num;
				num = (short)692125696;
				if (num != 0)
				{
				}
				num = (short)648216577;
				if (num != 0)
				{
				}
				this.uclT2TrkHotList_CallID_A00041.Value = value;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x001F12A8 File Offset: 0x001EF4A8
		// (set) Token: 0x06001680 RID: 5760 RVA: 0x001F1358 File Offset: 0x001EF558
		public global::AcpBusinessLayer.AcpRecRefField UclT2TrkHotList_CallID_A00041Object
		{
			get
			{
				short num = (short)1702166529;
				if (num != 0)
				{
				}
				num = (short)451942445;
				short num2 = num;
				num = (short)1569724461;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1187840000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1699741696;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_CallID_A00041;
			}
			set
			{
				short num = (short)854654977;
				if (num != 0)
				{
				}
				num = (short)1950618229;
				short num2 = num;
				num = (short)1431835253;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1571225600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1224802304;
				if (num != 0)
				{
				}
				this.uclT2TrkHotList_CallID_A00041 = value;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x001F1408 File Offset: 0x001EF608
		// (set) Token: 0x06001682 RID: 5762 RVA: 0x001F14B8 File Offset: 0x001EF6B8
		public string UclT2TrkHotList_CallID_A00041_UIValue
		{
			get
			{
				short num = (short)1929203334;
				short num2 = num;
				num = (short)1293766278;
				switch (num2 == num)
				{
				}
				num = (short)114950144;
				short num3 = num;
				num = (short)1954349057;
				if (num != 0)
				{
				}
				num = (short)119930880;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_CallID_A00041.UIValue;
			}
			set
			{
				short num = (short)165558904;
				short num2 = num;
				num = (short)1503148664;
				switch (num2 == num)
				{
				}
				num = (short)1363410944;
				short num3 = num;
				num = (short)1348665345;
				if (num != 0)
				{
				}
				num = (short)469696512;
				if (num != 0)
				{
				}
				this.uclT2TrkHotList_CallID_A00041.UIValue = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x001F156C File Offset: 0x001EF76C
		// (set) Token: 0x06001684 RID: 5764 RVA: 0x001F1620 File Offset: 0x001EF820
		public bool UclT2TrkHotList_CallID_A00041_Applicable
		{
			get
			{
				short num = (short)1085407233;
				if (num != 0)
				{
				}
				num = (short)582012408;
				short num2 = num;
				num = (short)303091192;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1616904192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2038431744;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_CallID_A00041.Applicable;
			}
			set
			{
				short num = (short)175604582;
				short num2 = num;
				num = (short)833192806;
				switch (num2 == num)
				{
				}
				num = (short)1323630592;
				short num3 = num;
				num = (short)1039925249;
				if (num != 0)
				{
				}
				num = (short)576520192;
				if (num != 0)
				{
				}
				this.uclT2TrkHotList_CallID_A00041.Applicable = value;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x001F16D4 File Offset: 0x001EF8D4
		// (set) Token: 0x06001686 RID: 5766 RVA: 0x001F1788 File Offset: 0x001EF988
		public bool UclT2TrkHotList_CallID_A00041_Editable
		{
			get
			{
				short num = (short)37797337;
				short num2 = num;
				num = (short)630767065;
				switch (num2 == num)
				{
				}
				num = (short)1086128128;
				short num3 = num;
				num = (short)911212545;
				if (num != 0)
				{
				}
				num = (short)1878917120;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_CallID_A00041.Editable;
			}
			set
			{
				short num = (short)62051498;
				short num2 = num;
				num = (short)302961834;
				switch (num2 == num)
				{
				}
				num = (short)990904320;
				short num3 = num;
				num = (short)1047527424;
				if (num != 0)
				{
				}
				num = (short)1187119105;
				if (num != 0)
				{
				}
				this.uclT2TrkHotList_CallID_A00041.Editable = value;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x001F1838 File Offset: 0x001EFA38
		// (set) Token: 0x06001688 RID: 5768 RVA: 0x001F18EC File Offset: 0x001EFAEC
		public bool UclT2TrkHotList_CallID_A00041_Visible
		{
			get
			{
				short num = (short)1988110957;
				short num2 = num;
				num = (short)1095117421;
				switch (num2 == num)
				{
				}
				num = (short)1859059712;
				short num3 = num;
				num = (short)1704656897;
				if (num != 0)
				{
				}
				num = (short)1282867200;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_CallID_A00041.Visible;
			}
			set
			{
				short num = (short)2103518097;
				short num2 = num;
				num = (short)256910225;
				switch (num2 == num)
				{
				}
				num = (short)2117140480;
				short num3 = num;
				num = (short)728956928;
				if (num != 0)
				{
				}
				num = (short)103284737;
				if (num != 0)
				{
				}
				this.uclT2TrkHotList_CallID_A00041.Visible = value;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x001F19A4 File Offset: 0x001EFBA4
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x001F1A58 File Offset: 0x001EFC58
		public bool UclT2TrkHotList_CallID_A00041_Valid
		{
			get
			{
				short num = (short)735926261;
				short num2 = num;
				num = (short)715413493;
				switch (num2 == num)
				{
				}
				num = (short)334888960;
				short num3 = num;
				num = (short)1671757825;
				if (num != 0)
				{
				}
				num = (short)1710620672;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_CallID_A00041.Valid;
			}
			set
			{
				short num = (short)1374158849;
				if (num != 0)
				{
				}
				num = (short)765801428;
				short num2 = num;
				num = (short)407516116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)371392512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1632370688;
				if (num != 0)
				{
				}
				this.uclT2TrkHotList_CallID_A00041.Valid = value;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x001F1B0C File Offset: 0x001EFD0C
		public bool UclT2TrkHotList_CallID_A00041_HasDiffs
		{
			get
			{
				short num = (short)2085525498;
				short num2 = num;
				num = (short)1662621690;
				switch (num2 == num)
				{
				}
				num = (short)2076704768;
				short num3 = num;
				num = (short)1823342593;
				if (num != 0)
				{
				}
				num = (short)773324800;
				if (num != 0)
				{
				}
				return this.uclT2TrkHotList_CallID_A00041._HasDiffs;
			}
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0000265F File Offset: 0x0000085F
		internal TrunkingT2CallHotListHotListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x001F1BC0 File Offset: 0x001EFDC0
		public override void Init()
		{
			int a_ = 1;
			short num = (short)585080407;
			short num2 = num;
			num = (short)1708826199;
			switch (num2 == num)
			{
			}
			num = (short)1041235968;
			short num3 = num;
			num = (short)2066808832;
			if (num != 0)
			{
			}
			num = (short)1438842881;
			if (num != 0)
			{
			}
			this.uclT2TrkHotList_ContactAlias_A00040 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톃\ude89뺋\uda8d撚\udc93秊횙풟ﶡ즥욧\udea9춫춭쒯\ud8b3\udfb5\ud9b7즹ﾽ", a_), global::CommonResources.AppResources.Contact_Id, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID
			}, new int[1], true);
			this.uclT2TrkHotList_ContactAlias_A00040.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclT2TrkHotList_ContactAlias_A00040.DataTransferOrder = 1;
			this.uclT2TrkHotList_CallID_A00041 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톃\ude89뺋\uda8d撚\udc93秊횙풟ﶡ장쒧용蒳蚵袷躹趻", a_), global::CommonResources.AppResources.Call_ID, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID
			}, new int[]
			{
				65535
			}, false);
			this.uclT2TrkHotList_CallID_A00041.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclT2TrkHotList_CallID_A00041.DataTransferOrder = 2;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킃ﾅ겋잍\ud98f늑삓캟얡蒣잧\udea9貫\ud9af솱삳", a_);
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_Hot_List;
			base.DataTransferOrder = 5;
			base.Id = 10422;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x001F1D44 File Offset: 0x001EFF44
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)48312938;
			short num2 = num;
			num = (short)555692650;
			switch (num2 == num)
			{
			}
			num = (short)1132593152;
			short num3 = num;
			num = (short)1254424577;
			if (num != 0)
			{
			}
			num = (short)522911744;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x001F1DF4 File Offset: 0x001EFFF4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)807141378;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields != null)
					{
						goto IL_14A;
					}
					goto IL_28F;
				case 1:
				{
					num = (short)121646819;
					short num3 = num;
					num = (short)204615395;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14A;
					default:
						num = (short)1918763009;
						if (num != 0)
						{
						}
						num = (short)1196556288;
						if (num != 0)
						{
						}
						num = (short)782958601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 3:
					goto IL_240;
				case 4:
					this.uclT2TrkHotList_ContactAlias_A00040 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8a얐ꆒ솔펚쪢횤펦슬솮얰튲횴쎶ힺ풼\udebe닀鳂蓄杻﯊琉ￎ", a_), global::CommonResources.AppResources.Contact_Id, new string[]
					{
						global::CommonResources.AppResources.Unassigned_ID
					}, new int[1], true);
					this.uclT2TrkHotList_ContactAlias_A00040.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclT2TrkHotList_ContactAlias_A00040.DataTransferOrder = 1;
					num = (short)1610153989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_7A;
				case 6:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8a얐ꆒ솔펚쪢횤펦첬쎮\uddb0者论趼达", a_)))
					{
						num = (short)931659783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28F;
				case 7:
					this.uclT2TrkHotList_CallID_A00041 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8a얐ꆒ솔펚쪢횤펦첬쎮\uddb0者论趼达", a_), global::CommonResources.AppResources.Call_ID, new string[]
					{
						global::CommonResources.AppResources.Unassigned_ID
					}, new int[]
					{
						65535
					}, false);
					this.uclT2TrkHotList_CallID_A00041.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclT2TrkHotList_CallID_A00041.DataTransferOrder = 2;
					num = (short)662241283;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)793313280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8a얐ꆒ솔펚쪢횤펦슬솮얰튲횴쎶ힺ풼\udebe닀鳂蓄杻﯊琉ￎ", a_)))
					{
						num = (short)1073807364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)620429320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7A:
				num = (short)543948806;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14A:
				num = (short)1136787457;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_240:
			IL_28F:
			num = (short)336592896;
			short num4 = num;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8aﾎ뎒\udc94\ude96릘쾚쾠좢첤즦캨讪삮얰鎲領\udeb6쪸쾺", a_);
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_Hot_List;
			base.DataTransferOrder = 5;
			base.Id = 10422;
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x001F20EC File Offset: 0x001F02EC
		internal global::SpecialFeatures.Ucl.Contact.UclContact Contact
		{
			get
			{
				short num = (short)92237432;
				short num2 = num;
				num = (short)584478328;
				switch (num2 == num)
				{
				}
				num = (short)927399936;
				short num3 = num;
				num = (short)577765377;
				if (num != 0)
				{
				}
				num = (short)1632501760;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.UclContact)this.uclT2TrkHotList_ContactAlias_A00040.ReferencedNode;
			}
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x001F21A4 File Offset: 0x001F03A4
		public override void PopulateReferences()
		{
			short num = (short)1484062723;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)390791172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)1873936385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 4:
				{
					num = (short)1459093504;
					short num3 = num;
					num = (short)1161867036;
					short num4 = num;
					num = (short)1734258460;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)917438465;
						if (num != 0)
						{
						}
						num = (short)618856448;
						if (num != 0)
						{
						}
						this.uclT2TrkHotList_ContactAlias_A00040.SetRecset(base.ParentRecset.ContainerDoc.GetFeature(2200));
						this.uclT2TrkHotList_ContactAlias_A00040.AddSlaveField(this.uclT2TrkHotList_CallID_A00041, 10411);
						num = (short)1651769344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_39:
				if (base.ParentRecset == null)
				{
					break;
				}
				num = (short)1986920450;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x001F233C File Offset: 0x001F053C
		public override void DropReferences()
		{
			short num = (short)57878098;
			short num2 = num;
			num = (short)2064197202;
			switch (num2 == num)
			{
			}
			num = (short)513081344;
			short num3 = num;
			num = (short)233242625;
			if (num != 0)
			{
			}
			num = (short)1260912640;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x001F23E8 File Offset: 0x001F05E8
		public override void SetConstraints()
		{
			short num = (short)1531107012;
			short num2 = num;
			num = (short)1803474628;
			switch (num2 == num)
			{
			}
			num = (short)2022703104;
			short num3 = num;
			num = (short)1583415297;
			if (num != 0)
			{
			}
			num = (short)384434176;
			if (num != 0)
			{
			}
			this.uclT2TrkHotList_CallID_A00041.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.Ucl.HotList.UclHotListConstraints.conTrkT2HotListCallIDIsValid);
			this.uclT2TrkHotList_CallID_A00041.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.HotList.UclHotListConstraints.ConTrkT2ContactAliasIsNotUnassigned);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x001F24C0 File Offset: 0x001F06C0
		public override void SetupDependencies()
		{
			short num = (short)986380582;
			short num2 = num;
			num = (short)1109260582;
			switch (num2 == num)
			{
			}
			num = (short)915996672;
			short num3 = num;
			num = (short)801439745;
			if (num != 0)
			{
			}
			num = (short)1917517824;
			if (num != 0)
			{
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x001F2568 File Offset: 0x001F0768
		public bool HasDiffs
		{
			get
			{
				short num = (short)907029476;
				short num2 = num;
				num = (short)685911012;
				switch (num2 == num)
				{
				}
				num = (short)983760896;
				short num3 = num;
				num = (short)373096449;
				if (num != 0)
				{
				}
				num = (short)811073536;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04000B95 RID: 2965
		private global::AcpBusinessLayer.AcpRecRefField uclT2TrkHotList_ContactAlias_A00040;

		// Token: 0x04000B96 RID: 2966
		private global::AcpBusinessLayer.AcpRecRefField uclT2TrkHotList_CallID_A00041;
	}
}
