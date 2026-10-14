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
	// Token: 0x020001C7 RID: 455
	[global::System.Serializable]
	public sealed class PhoneCallHotListHotListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060015D3 RID: 5587 RVA: 0x00002650 File Offset: 0x00000850
		internal PhoneCallHotListHotListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x001E9520 File Offset: 0x001E7720
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x001E95D4 File Offset: 0x001E77D4
		public int UclPhoneHotList_ContactAlias_A00049Value
		{
			get
			{
				short num = (short)1291274993;
				short num2 = num;
				num = (short)925911793;
				switch (num2 == num)
				{
				}
				num = (short)608698368;
				short num3 = num;
				num = (short)408354816;
				if (num != 0)
				{
				}
				num = (short)123404289;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_ContactAlias_A00049.Value;
			}
			set
			{
				short num = (short)1284198234;
				short num2 = num;
				num = (short)969494362;
				switch (num2 == num)
				{
				}
				num = (short)1988689920;
				short num3 = num;
				num = (short)2004877312;
				if (num != 0)
				{
				}
				num = (short)637796353;
				if (num != 0)
				{
				}
				this.uclPhoneHotList_ContactAlias_A00049.Value = value;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x001E968C File Offset: 0x001E788C
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x001E973C File Offset: 0x001E793C
		public global::AcpBusinessLayer.AcpRecRefField UclPhoneHotList_ContactAlias_A00049Object
		{
			get
			{
				short num = (short)1741488129;
				if (num != 0)
				{
				}
				num = (short)1607655574;
				short num2 = num;
				num = (short)1133240470;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1603469312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)436469760;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_ContactAlias_A00049;
			}
			set
			{
				short num = (short)418843391;
				short num2 = num;
				num = (short)1838025471;
				switch (num2 == num)
				{
				}
				num = (short)340787200;
				short num3 = num;
				num = (short)1236140032;
				if (num != 0)
				{
				}
				num = (short)275251201;
				if (num != 0)
				{
				}
				this.uclPhoneHotList_ContactAlias_A00049 = value;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x001E97E8 File Offset: 0x001E79E8
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x001E989C File Offset: 0x001E7A9C
		public string UclPhoneHotList_ContactAlias_A00049_UIValue
		{
			get
			{
				short num = (short)1628790932;
				short num2 = num;
				num = (short)294084756;
				switch (num2 == num)
				{
				}
				num = (short)538181632;
				short num3 = num;
				num = (short)2082799617;
				if (num != 0)
				{
				}
				num = (short)1674182656;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_ContactAlias_A00049.UIValue;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num2 = (short)1331953668;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 1:
						this.uclPhoneHotList_ContactAlias_A00049.UIValue = value;
						num2 = (short)1862205445;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_204;
					case 3:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (!((global::SpecialFeatures.Ucl.Contact.UclContactRecset)feature).ReachedMaxContactsHotlisted)
						{
							num2 = (short)382074881;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1089929224;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						num2 = (short)1540227073;
						if (num2 != 0)
						{
						}
						num2 = (short)1646002179;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_1E0;
					case 6:
						goto IL_1E0;
					case 7:
						this.uclPhoneHotList_ContactAlias_A00049.UIValue = value;
						num2 = (short)366542854;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
					{
						num2 = (short)144834560;
						short num3 = num2;
						if (this.uclPhoneHotList_ContactAlias_A00049.RefRecset.KeysToNode[value].KeyField.IsReferenced)
						{
							num2 = (short)311558151;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						string reached_2000_maximum_number_of_contacts_can_be_hotlisted = global::CommonResources.AppResources.Reached_2000_maximum_number_of_contacts_can_be_hotlisted;
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, reached_2000_maximum_number_of_contacts_can_be_hotlisted);
						num2 = (short)2037841929;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 9:
						goto IL_1E0;
					}
					goto IL_38;
					IL_1E0:
					this.uclPhoneHotList_ContactAlias_A00049.SetUITimer();
					num2 = (short)936312834;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_204:
				return;
				IL_38:
				num2 = (short)2126443531;
				short num4 = num2;
				num2 = (short)2103768075;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num2 = (short)79822848;
					if (num2 != 0)
					{
					}
					global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2200);
					num2 = (short)799735808;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x001E9AFC File Offset: 0x001E7CFC
		// (set) Token: 0x060015DB RID: 5595 RVA: 0x001E9BB0 File Offset: 0x001E7DB0
		public bool UclPhoneHotList_ContactAlias_A00049_Applicable
		{
			get
			{
				short num = (short)1235201261;
				short num2 = num;
				num = (short)121351405;
				switch (num2 == num)
				{
				}
				num = (short)1818689536;
				short num3 = num;
				num = (short)590741504;
				if (num != 0)
				{
				}
				num = (short)583467009;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_ContactAlias_A00049.Applicable;
			}
			set
			{
				short num = (short)1025853785;
				short num2 = num;
				num = (short)831998297;
				switch (num2 == num)
				{
				}
				num = (short)459145216;
				short num3 = num;
				num = (short)307691521;
				if (num != 0)
				{
				}
				num = (short)695271424;
				if (num != 0)
				{
				}
				this.uclPhoneHotList_ContactAlias_A00049.Applicable = value;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x001E9C64 File Offset: 0x001E7E64
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x001E9D18 File Offset: 0x001E7F18
		public bool UclPhoneHotList_ContactAlias_A00049_Editable
		{
			get
			{
				short num = (short)869466113;
				if (num != 0)
				{
				}
				num = (short)1291175372;
				short num2 = num;
				num = (short)184206796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1881407488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1481048064;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_ContactAlias_A00049.Editable;
			}
			set
			{
				short num = (short)1297705585;
				short num2 = num;
				num = (short)1333750385;
				switch (num2 == num)
				{
				}
				num = (short)846659584;
				short num3 = num;
				num = (short)1693843456;
				if (num != 0)
				{
				}
				num = (short)1152188417;
				if (num != 0)
				{
				}
				this.uclPhoneHotList_ContactAlias_A00049.Editable = value;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x001E9DD0 File Offset: 0x001E7FD0
		// (set) Token: 0x060015DF RID: 5599 RVA: 0x001E9E88 File Offset: 0x001E8088
		public bool UclPhoneHotList_ContactAlias_A00049_Visible
		{
			get
			{
				short num = (short)1349582849;
				if (num != 0)
				{
				}
				num = (short)380584092;
				short num2 = num;
				num = (short)128598172;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1432551424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2040659968;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_ContactAlias_A00049.Visible;
			}
			set
			{
				short num = (short)803903792;
				short num2 = num;
				num = (short)1309514032;
				switch (num2 == num)
				{
				}
				num = (short)186712064;
				short num3 = num;
				num = (short)1084555264;
				if (num != 0)
				{
				}
				num = (short)1399390209;
				if (num != 0)
				{
				}
				this.uclPhoneHotList_ContactAlias_A00049.Visible = value;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x001E9F40 File Offset: 0x001E8140
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x001E9FF4 File Offset: 0x001E81F4
		public bool UclPhoneHotList_ContactAlias_A00049_Valid
		{
			get
			{
				short num = (short)1558766364;
				short num2 = num;
				num = (short)43377436;
				switch (num2 == num)
				{
				}
				num = (short)1864368128;
				short num3 = num;
				num = (short)1213988865;
				if (num != 0)
				{
				}
				num = (short)571736064;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_ContactAlias_A00049.Valid;
			}
			set
			{
				short num = (short)1393534313;
				short num2 = num;
				num = (short)1405986153;
				switch (num2 == num)
				{
				}
				num = (short)2068774912;
				short num3 = num;
				num = (short)1532231681;
				if (num != 0)
				{
				}
				num = (short)651296768;
				if (num != 0)
				{
				}
				this.uclPhoneHotList_ContactAlias_A00049.Valid = value;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x001EA0A8 File Offset: 0x001E82A8
		public bool UclPhoneHotList_ContactAlias_A00049_HasDiffs
		{
			get
			{
				short num = (short)987565374;
				short num2 = num;
				num = (short)1656425790;
				switch (num2 == num)
				{
				}
				num = (short)1408368640;
				short num3 = num;
				num = (short)1471021057;
				if (num != 0)
				{
				}
				num = (short)912064512;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_ContactAlias_A00049._HasDiffs;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x001EA15C File Offset: 0x001E835C
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x001EA210 File Offset: 0x001E8410
		public int UclPhoneHotList_CallID_A00050Value
		{
			get
			{
				short num = (short)709885953;
				if (num != 0)
				{
				}
				num = (short)1009028606;
				short num2 = num;
				num = (short)1768132094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)491847680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)24903680;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_CallID_A00050.Value;
			}
			set
			{
				short num = (short)1333273034;
				short num2 = num;
				num = (short)875307466;
				switch (num2 == num)
				{
				}
				num = (short)1812332544;
				short num3 = num;
				num = (short)1278410753;
				if (num != 0)
				{
				}
				num = (short)516685824;
				if (num != 0)
				{
				}
				this.uclPhoneHotList_CallID_A00050.Value = value;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x001EA2C8 File Offset: 0x001E84C8
		// (set) Token: 0x060015E6 RID: 5606 RVA: 0x001EA37C File Offset: 0x001E857C
		public global::AcpBusinessLayer.AcpRecRefField UclPhoneHotList_CallID_A00050Object
		{
			get
			{
				short num = (short)1699089477;
				short num2 = num;
				num = (short)141691973;
				switch (num2 == num)
				{
				}
				num = (short)1871839232;
				short num3 = num;
				num = (short)977928193;
				if (num != 0)
				{
				}
				num = (short)434044928;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_CallID_A00050;
			}
			set
			{
				short num = (short)916914177;
				if (num != 0)
				{
				}
				num = (short)429158187;
				short num2 = num;
				num = (short)1967746859;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1425997824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1619197952;
				if (num != 0)
				{
				}
				this.uclPhoneHotList_CallID_A00050 = value;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x001EA430 File Offset: 0x001E8630
		// (set) Token: 0x060015E8 RID: 5608 RVA: 0x001EA4E0 File Offset: 0x001E86E0
		public string UclPhoneHotList_CallID_A00050_UIValue
		{
			get
			{
				short num = (short)1739580704;
				short num2 = num;
				num = (short)863560992;
				switch (num2 == num)
				{
				}
				num = (short)585695232;
				short num3 = num;
				num = (short)1222049792;
				if (num != 0)
				{
				}
				num = (short)1887305729;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_CallID_A00050.UIValue;
			}
			set
			{
				short num = (short)1230356624;
				short num2 = num;
				num = (short)1278394512;
				switch (num2 == num)
				{
				}
				num = (short)325844992;
				short num3 = num;
				num = (short)1244004353;
				if (num != 0)
				{
				}
				num = (short)1469906944;
				if (num != 0)
				{
				}
				this.uclPhoneHotList_CallID_A00050.UIValue = value;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x001EA594 File Offset: 0x001E8794
		// (set) Token: 0x060015EA RID: 5610 RVA: 0x001EA64C File Offset: 0x001E884C
		public bool UclPhoneHotList_CallID_A00050_Applicable
		{
			get
			{
				short num = (short)526306218;
				short num2 = num;
				num = (short)1494010794;
				switch (num2 == num)
				{
				}
				num = (short)222494720;
				short num3 = num;
				num = (short)325779457;
				if (num != 0)
				{
				}
				num = (short)1751908352;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_CallID_A00050.Applicable;
			}
			set
			{
				short num = (short)791056444;
				short num2 = num;
				num = (short)1235849276;
				switch (num2 == num)
				{
				}
				num = (short)2121662464;
				short num3 = num;
				num = (short)1097662464;
				if (num != 0)
				{
				}
				num = (short)229113857;
				if (num != 0)
				{
				}
				this.uclPhoneHotList_CallID_A00050.Applicable = value;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x001EA700 File Offset: 0x001E8900
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x001EA7B8 File Offset: 0x001E89B8
		public bool UclPhoneHotList_CallID_A00050_Editable
		{
			get
			{
				short num = (short)1577730756;
				short num2 = num;
				num = (short)1465336516;
				switch (num2 == num)
				{
				}
				num = (short)1892089856;
				short num3 = num;
				num = (short)323747841;
				if (num != 0)
				{
				}
				num = (short)1163198464;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_CallID_A00050.Editable;
			}
			set
			{
				short num = (short)759103489;
				if (num != 0)
				{
				}
				num = (short)1619765589;
				short num2 = num;
				num = (short)1386260821;
				switch (num2 == num)
				{
				default:
				{
					num = (short)850132992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)676397056;
				if (num != 0)
				{
				}
				this.uclPhoneHotList_CallID_A00050.Editable = value;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x001EA870 File Offset: 0x001E8A70
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x001EA920 File Offset: 0x001E8B20
		public bool UclPhoneHotList_CallID_A00050_Visible
		{
			get
			{
				short num = (short)739461700;
				short num2 = num;
				num = (short)1145719364;
				switch (num2 == num)
				{
				}
				num = (short)1734803456;
				short num3 = num;
				num = (short)1010958336;
				if (num != 0)
				{
				}
				num = (short)158859265;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_CallID_A00050.Visible;
			}
			set
			{
				short num = (short)1566036047;
				short num2 = num;
				num = (short)1490538575;
				switch (num2 == num)
				{
				}
				num = (short)1545928704;
				short num3 = num;
				num = (short)2147090433;
				if (num != 0)
				{
				}
				num = (short)546439168;
				if (num != 0)
				{
				}
				this.uclPhoneHotList_CallID_A00050.Visible = value;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x001EA9D4 File Offset: 0x001E8BD4
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x001EAA88 File Offset: 0x001E8C88
		public bool UclPhoneHotList_CallID_A00050_Valid
		{
			get
			{
				short num = (short)389021697;
				if (num != 0)
				{
				}
				num = (short)701364518;
				short num2 = num;
				num = (short)1321990438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)796000256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)562364416;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_CallID_A00050.Valid;
			}
			set
			{
				short num = (short)111725602;
				short num2 = num;
				num = (short)1187302434;
				switch (num2 == num)
				{
				}
				num = (short)38141952;
				short num3 = num;
				num = (short)675741696;
				if (num != 0)
				{
				}
				num = (short)1913782273;
				if (num != 0)
				{
				}
				this.uclPhoneHotList_CallID_A00050.Valid = value;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x001EAB40 File Offset: 0x001E8D40
		public bool UclPhoneHotList_CallID_A00050_HasDiffs
		{
			get
			{
				short num = (short)1710511467;
				short num2 = num;
				num = (short)523851115;
				switch (num2 == num)
				{
				}
				num = (short)695205888;
				short num3 = num;
				num = (short)297598977;
				if (num != 0)
				{
				}
				num = (short)1408040960;
				if (num != 0)
				{
				}
				return this.uclPhoneHotList_CallID_A00050._HasDiffs;
			}
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x0000265F File Offset: 0x0000085F
		internal PhoneCallHotListHotListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x001EABF4 File Offset: 0x001E8DF4
		public override void Init()
		{
			int a_ = 11;
			short num = (short)2038251856;
			short num2 = num;
			num = (short)550650192;
			switch (num2 == num)
			{
			}
			num = (short)193134592;
			short num3 = num;
			num = (short)338690049;
			if (num != 0)
			{
			}
			num = (short)1374093312;
			if (num != 0)
			{
			}
			this.uclPhoneHotList_ContactAlias_A00049 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8dﺑ쒓ﺕ鍊횝쾟횡쾥\udba7\udea9\udfaf\udcb1삳ힵ\udbb7캹ﶻ튽ꦿꏁ럃駅觇韛ﳋﻍ", a_), global::CommonResources.AppResources.Contact_Id, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID
			}, new int[1], true);
			this.uclPhoneHotList_ContactAlias_A00049.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclPhoneHotList_ContactAlias_A00049.DataTransferOrder = 1;
			this.uclPhoneHotList_CallID_A00050 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb8dﺑ쒓ﺕ鍊횝쾟횡쾥\udba7\udea9톯\udeb1\ud8b3ﾵﲷﶻ躽", a_), global::CommonResources.AppResources.Call_ID, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID
			}, new int[]
			{
				65535
			}, false);
			this.uclPhoneHotList_CallID_A00050.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclPhoneHotList_CallID_A00050.DataTransferOrder = 2;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8d﶑望뢗튙肟춣향\udca7", a_);
			base.UIName = global::CommonResources.AppResources.Phone_Hot_List;
			base.DataTransferOrder = 3;
			base.Id = 10428;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x001EAD78 File Offset: 0x001E8F78
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1750159202;
			short num2 = num;
			num = (short)1001672546;
			switch (num2 == num)
			{
			}
			num = (short)395575296;
			short num3 = num;
			num = (short)880214016;
			if (num != 0)
			{
			}
			num = (short)2142371841;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x001EAE28 File Offset: 0x001E9028
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 19;
			short num = (short)2078015488;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				case 1:
					num = (short)694550533;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_273;
				case 3:
					if (producerFields != null)
					{
						goto IL_175;
					}
					goto IL_273;
				case 4:
					num = (short)134479875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕ﮗ첛쾟첡솣잧\udea9잭쎯욱ힷ풹좻\udfbdꎿ뛁藃꫅ꇇꯉ뿋重量", a_)))
					{
						num = (short)903479302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A;
				case 6:
					this.uclPhoneHotList_ContactAlias_A00049 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕ﮗ첛쾟첡솣잧\udea9잭쎯욱ힷ풹좻\udfbdꎿ뛁藃꫅ꇇꯉ뿋重量", a_), global::CommonResources.AppResources.Contact_Id, new string[]
					{
						global::CommonResources.AppResources.Unassigned_ID
					}, new int[1], true);
					this.uclPhoneHotList_ContactAlias_A00049.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclPhoneHotList_ContactAlias_A00049.DataTransferOrder = 1;
					num = (short)163774471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)545193984;
					short num3 = num;
					goto IL_7A;
				}
				case 8:
					this.uclPhoneHotList_CallID_A00050 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕ﮗ첛쾟첡솣잧\udea9잭쎯욱\ud9b7횹킻蒿鷁藃韛溜ﻍ", a_), global::CommonResources.AppResources.Call_ID, new string[]
					{
						global::CommonResources.AppResources.Unassigned_ID
					}, new int[]
					{
						65535
					}, false);
					this.uclPhoneHotList_CallID_A00050.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclPhoneHotList_CallID_A00050.DataTransferOrder = 2;
					num = (short)767361026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕ﮗ첛쾟첡솣잧\udea9잭쎯욱\ud9b7횹킻蒿鷁藃韛溜ﻍ", a_)))
					{
						num = (short)434176008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_273;
				}
				IL_57:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)15204356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_273;
				IL_7A:
				num = (short)324337673;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_175:
				num = (short)1578762241;
				if (num != 0)
				{
				}
				num = (short)1185153025;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_273:
				num = (short)1906268013;
				short num4 = num;
				num = (short)2135250797;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_175;
				default:
					goto IL_2A7;
				}
			}
			IL_2A7:
			num = (short)1059651584;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욕ﮝ肟쮣튥袧얫\uddad쒯", a_);
			base.UIName = global::CommonResources.AppResources.Phone_Hot_List;
			base.DataTransferOrder = 3;
			base.Id = 10428;
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x001EB124 File Offset: 0x001E9324
		public global::SpecialFeatures.Ucl.Contact.UclContact Contact
		{
			get
			{
				short num = (short)84375082;
				short num2 = num;
				num = (short)1131574826;
				switch (num2 == num)
				{
				}
				num = (short)1802174464;
				short num3 = num;
				num = (short)1022164992;
				if (num != 0)
				{
				}
				num = (short)1915879425;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.UclContact)this.uclPhoneHotList_ContactAlias_A00049.ReferencedNode;
			}
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x001EB1DC File Offset: 0x001E93DC
		public override void PopulateReferences()
		{
			short num = (short)951451649;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)19333120;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					num = (short)376766465;
					if (num != 0)
					{
					}
					num = (short)1356453914;
					short num4 = num;
					num = (short)1069668378;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_188;
					default:
						goto IL_133;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1081868291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_188;
				case 4:
					num = (short)914554882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_62:
				if (base.ParentRecset != null)
				{
					num = (short)1536032772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_188:
				this.uclPhoneHotList_ContactAlias_A00049.SetRecset(base.ParentRecset.ContainerDoc.GetFeature(2200));
				this.uclPhoneHotList_ContactAlias_A00049.AddSlaveField(this.uclPhoneHotList_CallID_A00050, 10413);
				num = (short)105512960;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_133:
			num = (short)1239416832;
			if (num != 0)
			{
			}
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x001EB378 File Offset: 0x001E9578
		public override void DropReferences()
		{
			short num = (short)1659895809;
			if (num != 0)
			{
			}
			num = (short)815051405;
			short num2 = num;
			num = (short)1401467533;
			switch (num2 == num)
			{
			default:
			{
				num = (short)552730624;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1350303744;
			if (num != 0)
			{
			}
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x001EB420 File Offset: 0x001E9620
		public override void SetConstraints()
		{
			short num = (short)76361216;
			short num2 = num;
			num = (short)1006906880;
			switch (num2 == num)
			{
			}
			num = (short)1292828672;
			short num3 = num;
			num = (short)1817182209;
			if (num != 0)
			{
			}
			num = (short)1334247424;
			if (num != 0)
			{
			}
			this.uclPhoneHotList_CallID_A00050.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.Ucl.HotList.UclHotListConstraints.conPhoneHotListCallIDIsValid);
			this.uclPhoneHotList_CallID_A00050.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.HotList.UclHotListConstraints.ConPhoneContactAliasIsNotUnassigned);
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x001EB4F4 File Offset: 0x001E96F4
		public override void SetupDependencies()
		{
			short num = (short)1499258364;
			short num2 = num;
			num = (short)489217532;
			switch (num2 == num)
			{
			}
			num = (short)122355712;
			short num3 = num;
			num = (short)122355713;
			if (num != 0)
			{
			}
			num = (short)2044329984;
			if (num != 0)
			{
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x001EB59C File Offset: 0x001E979C
		public bool HasDiffs
		{
			get
			{
				short num = (short)668234676;
				short num2 = num;
				num = (short)1029993396;
				switch (num2 == num)
				{
				}
				num = (short)531824640;
				short num3 = num;
				num = (short)1657798657;
				if (num != 0)
				{
				}
				num = (short)1549991936;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04000B8B RID: 2955
		private global::AcpBusinessLayer.AcpRecRefField uclPhoneHotList_ContactAlias_A00049;

		// Token: 0x04000B8C RID: 2956
		private global::AcpBusinessLayer.AcpRecRefField uclPhoneHotList_CallID_A00050;
	}
}
