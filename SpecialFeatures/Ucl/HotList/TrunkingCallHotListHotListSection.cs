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
	// Token: 0x020001CD RID: 461
	[global::System.Serializable]
	public sealed class TrunkingCallHotListHotListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001637 RID: 5687 RVA: 0x00002650 File Offset: 0x00000850
		internal TrunkingCallHotListHotListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x001EDC30 File Offset: 0x001EBE30
		// (set) Token: 0x06001639 RID: 5689 RVA: 0x001EDCE4 File Offset: 0x001EBEE4
		public int UclAstro25TrkHotList_ContactAlias_A00037Value
		{
			get
			{
				short num = (short)244766824;
				short num2 = num;
				num = (short)1918359656;
				switch (num2 == num)
				{
				}
				num = (short)1734541313;
				if (num != 0)
				{
				}
				num = (short)1570570240;
				if (num != 0)
				{
				}
				num = (short)2020737024;
				short num3 = num;
				return this.uclAstro25TrkHotList_ContactAlias_A00037.Value;
			}
			set
			{
				short num = (short)314545124;
				short num2 = num;
				num = (short)432903140;
				switch (num2 == num)
				{
				}
				num = (short)1469644800;
				if (num != 0)
				{
				}
				num = (short)108855297;
				if (num != 0)
				{
				}
				num = (short)1017053184;
				short num3 = num;
				this.uclAstro25TrkHotList_ContactAlias_A00037.Value = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x001EDD98 File Offset: 0x001EBF98
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x001EDE48 File Offset: 0x001EC048
		public global::AcpBusinessLayer.AcpRecRefField UclAstro25TrkHotList_ContactAlias_A00037Object
		{
			get
			{
				short num = (short)379650499;
				short num2 = num;
				num = (short)1057685955;
				switch (num2 == num)
				{
				}
				num = (short)1380122625;
				if (num != 0)
				{
				}
				num = (short)421199872;
				if (num != 0)
				{
				}
				num = (short)1141506048;
				short num3 = num;
				return this.uclAstro25TrkHotList_ContactAlias_A00037;
			}
			set
			{
				short num = (short)546920660;
				short num2 = num;
				num = (short)1183602900;
				switch (num2 == num)
				{
				}
				num = (short)109314048;
				if (num != 0)
				{
				}
				num = (short)1550450689;
				if (num != 0)
				{
				}
				num = (short)1052114944;
				short num3 = num;
				this.uclAstro25TrkHotList_ContactAlias_A00037 = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x001EDEF8 File Offset: 0x001EC0F8
		// (set) Token: 0x0600163D RID: 5693 RVA: 0x001EDFB0 File Offset: 0x001EC1B0
		public string UclAstro25TrkHotList_ContactAlias_A00037_UIValue
		{
			get
			{
				short num = (short)618656623;
				short num2 = num;
				num = (short)84669295;
				switch (num2 == num)
				{
				}
				num = (short)2093350912;
				if (num != 0)
				{
				}
				num = (short)98762753;
				if (num != 0)
				{
				}
				num = (short)1236074496;
				short num3 = num;
				return this.uclAstro25TrkHotList_ContactAlias_A00037.UIValue;
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
						if (this.uclAstro25TrkHotList_ContactAlias_A00037.RefRecset.KeysToNode[value].KeyField.IsReferenced)
						{
							num2 = (short)1019936769;
							if (num2 != 0)
							{
							}
							num2 = (short)716242949;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						string reached_2000_maximum_number_of_contacts_can_be_hotlisted = global::CommonResources.AppResources.Reached_2000_maximum_number_of_contacts_can_be_hotlisted;
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, reached_2000_maximum_number_of_contacts_can_be_hotlisted);
						num2 = (short)1729953794;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						return;
					case 2:
						goto IL_1AE;
					case 3:
					{
						num2 = (short)1362034688;
						short num3 = num2;
						goto IL_1AE;
					}
					case 4:
						num2 = (short)1936457734;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						this.uclAstro25TrkHotList_ContactAlias_A00037.UIValue = value;
						num2 = (short)1975648263;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
					{
						if (!((global::SpecialFeatures.Ucl.Contact.UclContactRecset)feature).ReachedMaxContactsHotlisted)
						{
							num2 = (short)1660354569;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1738444846;
						short num4 = num2;
						num2 = (short)160206894;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_247;
						default:
							num2 = (short)2058551296;
							if (num2 != 0)
							{
							}
							num2 = (short)1330053120;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 7:
						goto IL_247;
					case 8:
						if (feature != null)
						{
							num2 = (short)1812463620;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 9:
						this.uclAstro25TrkHotList_ContactAlias_A00037.UIValue = value;
						num2 = (short)1979842563;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_38;
					IL_1AE:
					this.uclAstro25TrkHotList_ContactAlias_A00037.SetUITimer();
					num2 = (short)1987837953;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_247:
					goto IL_1AE;
				}
				return;
				IL_38:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2200);
				num2 = (short)21626888;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x001EE20C File Offset: 0x001EC40C
		// (set) Token: 0x0600163F RID: 5695 RVA: 0x001EE2C0 File Offset: 0x001EC4C0
		public bool UclAstro25TrkHotList_ContactAlias_A00037_Applicable
		{
			get
			{
				short num = (short)283606099;
				short num2 = num;
				num = (short)1318419539;
				switch (num2 == num)
				{
				}
				num = (short)1775632385;
				if (num != 0)
				{
				}
				num = (short)1767768064;
				if (num != 0)
				{
				}
				num = (short)1469972480;
				short num3 = num;
				return this.uclAstro25TrkHotList_ContactAlias_A00037.Applicable;
			}
			set
			{
				short num = (short)1880317284;
				short num2 = num;
				num = (short)468016484;
				switch (num2 == num)
				{
				}
				num = (short)2089418752;
				if (num != 0)
				{
				}
				num = (short)1272119297;
				if (num != 0)
				{
				}
				num = (short)1711210496;
				short num3 = num;
				this.uclAstro25TrkHotList_ContactAlias_A00037.Applicable = value;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x001EE378 File Offset: 0x001EC578
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x001EE42C File Offset: 0x001EC62C
		public bool UclAstro25TrkHotList_ContactAlias_A00037_Editable
		{
			get
			{
				short num = (short)1087432693;
				short num2 = num;
				num = (short)896198645;
				switch (num2 == num)
				{
				}
				num = (short)1261174785;
				if (num != 0)
				{
				}
				num = (short)126156800;
				if (num != 0)
				{
				}
				num = (short)1442185216;
				short num3 = num;
				return this.uclAstro25TrkHotList_ContactAlias_A00037.Editable;
			}
			set
			{
				short num = (short)1614348289;
				if (num != 0)
				{
				}
				num = (short)1304215340;
				short num2 = num;
				num = (short)1299496748;
				switch (num2 == num)
				{
				}
				num = (short)1337327616;
				if (num != 0)
				{
				}
				num = (short)122290176;
				short num3 = num;
				this.uclAstro25TrkHotList_ContactAlias_A00037.Editable = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x001EE4E4 File Offset: 0x001EC6E4
		// (set) Token: 0x06001643 RID: 5699 RVA: 0x001EE594 File Offset: 0x001EC794
		public bool UclAstro25TrkHotList_ContactAlias_A00037_Visible
		{
			get
			{
				short num = (short)89921255;
				short num2 = num;
				num = (short)1015813863;
				switch (num2 == num)
				{
				}
				num = (short)70189057;
				if (num != 0)
				{
				}
				num = (short)666238976;
				if (num != 0)
				{
				}
				num = (short)1443102720;
				short num3 = num;
				return this.uclAstro25TrkHotList_ContactAlias_A00037.Visible;
			}
			set
			{
				short num = (short)1368653825;
				if (num != 0)
				{
				}
				num = (short)773573818;
				short num2 = num;
				num = (short)1236651194;
				switch (num2 == num)
				{
				}
				num = (short)1366032384;
				if (num != 0)
				{
				}
				num = (short)504233984;
				short num3 = num;
				this.uclAstro25TrkHotList_ContactAlias_A00037.Visible = value;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x001EE64C File Offset: 0x001EC84C
		// (set) Token: 0x06001645 RID: 5701 RVA: 0x001EE700 File Offset: 0x001EC900
		public bool UclAstro25TrkHotList_ContactAlias_A00037_Valid
		{
			get
			{
				short num = (short)1347824091;
				short num2 = num;
				num = (short)2029922779;
				switch (num2 == num)
				{
				}
				num = (short)1632239617;
				if (num != 0)
				{
				}
				num = (short)1184235520;
				if (num != 0)
				{
				}
				num = (short)1011810304;
				short num3 = num;
				return this.uclAstro25TrkHotList_ContactAlias_A00037.Valid;
			}
			set
			{
				short num = (short)1524754122;
				short num2 = num;
				num = (short)688973514;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1206386688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1207369728;
				if (num != 0)
				{
				}
				num = (short)916848641;
				if (num != 0)
				{
				}
				this.uclAstro25TrkHotList_ContactAlias_A00037.Valid = value;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x001EE7B4 File Offset: 0x001EC9B4
		public bool UclAstro25TrkHotList_ContactAlias_A00037_HasDiffs
		{
			get
			{
				short num = (short)691089732;
				short num2 = num;
				num = (short)587411780;
				switch (num2 == num)
				{
				default:
				{
					num = (short)385155072;
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
				num = (short)266469376;
				if (num != 0)
				{
				}
				return this.uclAstro25TrkHotList_ContactAlias_A00037._HasDiffs;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x001EE86C File Offset: 0x001ECA6C
		// (set) Token: 0x06001648 RID: 5704 RVA: 0x001EE924 File Offset: 0x001ECB24
		public int UclAstro25TrkHotList_CallID_a00038Value
		{
			get
			{
				short num = (short)1592207624;
				short num2 = num;
				num = (short)1881090312;
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
				num = (short)881590273;
				if (num != 0)
				{
				}
				num = (short)1309671424;
				if (num != 0)
				{
				}
				return this.uclAstro25TrkHotList_CallID_a00038.Value;
			}
			set
			{
				short num = (short)747063588;
				short num2 = num;
				num = (short)1103251748;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1226375168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)196673537;
				if (num != 0)
				{
				}
				num = (short)1653473280;
				if (num != 0)
				{
				}
				this.uclAstro25TrkHotList_CallID_a00038.Value = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x001EE9D8 File Offset: 0x001ECBD8
		// (set) Token: 0x0600164A RID: 5706 RVA: 0x001EEA84 File Offset: 0x001ECC84
		public global::AcpBusinessLayer.AcpRecRefField UclAstro25TrkHotList_CallID_a00038Object
		{
			get
			{
				short num = (short)123965870;
				short num2 = num;
				num = (short)134517166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)840433664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1222508544;
				if (num != 0)
				{
				}
				num = (short)1148059649;
				if (num != 0)
				{
				}
				return this.uclAstro25TrkHotList_CallID_a00038;
			}
			set
			{
				short num = (short)1008599041;
				if (num != 0)
				{
				}
				num = (short)337903616;
				short num2 = num;
				num = (short)1699476320;
				short num3 = num;
				num = (short)955904864;
				switch (num3 == num)
				{
				}
				num = (short)1151270912;
				if (num != 0)
				{
				}
				this.uclAstro25TrkHotList_CallID_a00038 = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x001EEB34 File Offset: 0x001ECD34
		// (set) Token: 0x0600164C RID: 5708 RVA: 0x001EEBE8 File Offset: 0x001ECDE8
		public string UclAstro25TrkHotList_CallID_a00038_UIValue
		{
			get
			{
				short num = (short)1431576432;
				short num2 = num;
				num = (short)1281630064;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2043019264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)966852609;
				if (num != 0)
				{
				}
				num = (short)831324160;
				if (num != 0)
				{
				}
				return this.uclAstro25TrkHotList_CallID_a00038.UIValue;
			}
			set
			{
				short num = (short)1033924353;
				short num2 = num;
				num = (short)1480093441;
				switch (num2 == num)
				{
				default:
				{
					num = (short)486932480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2133262337;
				if (num != 0)
				{
				}
				num = (short)1349320704;
				if (num != 0)
				{
				}
				this.uclAstro25TrkHotList_CallID_a00038.UIValue = value;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x001EEC9C File Offset: 0x001ECE9C
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x001EED50 File Offset: 0x001ECF50
		public bool UclAstro25TrkHotList_CallID_a00038_Applicable
		{
			get
			{
				short num = (short)2003964799;
				short num2 = num;
				num = (short)1981944703;
				switch (num2 == num)
				{
				default:
				{
					num = (short)902758400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1170014209;
				if (num != 0)
				{
				}
				num = (short)1277886464;
				if (num != 0)
				{
				}
				return this.uclAstro25TrkHotList_CallID_a00038.Applicable;
			}
			set
			{
				short num = (short)1700614489;
				short num2 = num;
				num = (short)780161369;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1094975488;
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
				num = (short)621740033;
				if (num != 0)
				{
				}
				this.uclAstro25TrkHotList_CallID_a00038.Applicable = value;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x001EEE08 File Offset: 0x001ED008
		// (set) Token: 0x06001650 RID: 5712 RVA: 0x001EEEBC File Offset: 0x001ED0BC
		public bool UclAstro25TrkHotList_CallID_a00038_Editable
		{
			get
			{
				short num = (short)440223732;
				short num2 = num;
				num = (short)1471236084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1559887872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)444530689;
				if (num != 0)
				{
				}
				num = (short)1317994496;
				if (num != 0)
				{
				}
				return this.uclAstro25TrkHotList_CallID_a00038.Editable;
			}
			set
			{
				short num = (short)876937217;
				if (num != 0)
				{
				}
				num = (short)163905536;
				short num2 = num;
				num = (short)218886327;
				short num3 = num;
				num = (short)1718022327;
				switch (num3 == num)
				{
				}
				num = (short)203685888;
				if (num != 0)
				{
				}
				this.uclAstro25TrkHotList_CallID_a00038.Editable = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x001EEF74 File Offset: 0x001ED174
		// (set) Token: 0x06001652 RID: 5714 RVA: 0x001EF024 File Offset: 0x001ED224
		public bool UclAstro25TrkHotList_CallID_a00038_Visible
		{
			get
			{
				short num = (short)1795719645;
				short num2 = num;
				num = (short)1257603549;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1542324224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)625999873;
				if (num != 0)
				{
				}
				num = (short)1726545920;
				if (num != 0)
				{
				}
				return this.uclAstro25TrkHotList_CallID_a00038.Visible;
			}
			set
			{
				short num = (short)1212298002;
				short num2 = num;
				num = (short)585118482;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1124663296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1472593920;
				if (num != 0)
				{
				}
				num = (short)414777345;
				if (num != 0)
				{
				}
				this.uclAstro25TrkHotList_CallID_a00038.Visible = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x001EF0D8 File Offset: 0x001ED2D8
		// (set) Token: 0x06001654 RID: 5716 RVA: 0x001EF18C File Offset: 0x001ED38C
		public bool UclAstro25TrkHotList_CallID_a00038_Valid
		{
			get
			{
				short num = (short)1580084059;
				short num2 = num;
				num = (short)523905883;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1542127616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661782529;
				if (num != 0)
				{
				}
				num = (short)1847132160;
				if (num != 0)
				{
				}
				return this.uclAstro25TrkHotList_CallID_a00038.Valid;
			}
			set
			{
				short num = (short)1490641414;
				short num2 = num;
				num = (short)1331454470;
				switch (num2 == num)
				{
				default:
				{
					num = (short)191234048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1035665408;
				if (num != 0)
				{
				}
				num = (short)1866465281;
				if (num != 0)
				{
				}
				this.uclAstro25TrkHotList_CallID_a00038.Valid = value;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x001EF244 File Offset: 0x001ED444
		public bool UclAstro25TrkHotList_CallID_a00038_HasDiffs
		{
			get
			{
				short num = (short)1067215327;
				short num2 = num;
				num = (short)1477143007;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1484849152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)874971137;
				if (num != 0)
				{
				}
				num = (short)2112487424;
				if (num != 0)
				{
				}
				return this.uclAstro25TrkHotList_CallID_a00038._HasDiffs;
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0000265F File Offset: 0x0000085F
		internal TrunkingCallHotListHotListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x001EF2F8 File Offset: 0x001ED4F8
		public override void Init()
		{
			int a_ = 8;
			short num = (short)2021851137;
			if (num != 0)
			{
			}
			num = (short)1133576192;
			short num2 = num;
			num = (short)2077468414;
			short num3 = num;
			num = (short)626763518;
			switch (num3 == num)
			{
			}
			num = (short)196608000;
			if (num != 0)
			{
			}
			this.uclAstro25TrkHotList_ContactAlias_A00037 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8a킐ꦚꢜ쮞펠좢좦\udda8쒬\udcae얰\ud8b6ힸ쾺\udcbc\udcbe뗀苂꧄껆꣈룊鋌軎", a_), global::CommonResources.AppResources.Contact_Id, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID
			}, new int[1], true);
			this.uclAstro25TrkHotList_ContactAlias_A00037.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstro25TrkHotList_ContactAlias_A00037.DataTransferOrder = 1;
			this.uclAstro25TrkHotList_CallID_a00038 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8a킐ꦚꢜ쮞펠좢좦\udda8쒬\udcae얰횶햸ힺ﮾黀ꋂ杻", a_), global::CommonResources.AppResources.Call_ID, new string[]
			{
				global::CommonResources.AppResources.Unassigned_ID
			}, new int[]
			{
				65535
			}, false);
			this.uclAstro25TrkHotList_CallID_a00038.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.uclAstro25TrkHotList_CallID_a00038.DataTransferOrder = 2;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪊\ude8c\udb8e쎐\udc92떔ꖖ겘뮚즜풠춢캤캦잨첪趬\udeb0잲閴﮶킸좺즼", a_);
			base.UIName = global::CommonResources.AppResources.ASTRO_25_Trunking_Hot_List;
			base.DataTransferOrder = 4;
			base.Id = 10416;
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x001EF47C File Offset: 0x001ED67C
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1257766913;
			if (num != 0)
			{
			}
			num = (short)2126577664;
			short num2 = num;
			num = (short)1473643633;
			short num3 = num;
			num = (short)1322583153;
			switch (num3 == num)
			{
			}
			num = (short)219217920;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x001EF52C File Offset: 0x001ED72C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)1578041354;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_276;
				case 1:
					return;
				case 2:
					if (producerFields != null)
					{
						num = (short)1199308804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_1B4;
				case 4:
					num = (short)1939996673;
					if (num != 0)
					{
					}
					num = (short)2143158281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("작歹\ud997쾟邡醣\udaa7솩솭쒯ﺱ\uddb3억첷ﾻ\udfbd겿껁跃苅韇ꯉﳋﻍ", a_)))
					{
						num = (short)2093154310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B4;
				case 6:
					this.uclAstro25TrkHotList_CallID_a00038 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("작歹\ud997쾟邡醣\udaa7솩솭쒯ﺱ\uddb3억첷ﾻ\udfbd겿껁跃苅韇ꯉﳋﻍ", a_), global::CommonResources.AppResources.Call_ID, new string[]
					{
						global::CommonResources.AppResources.Unassigned_ID
					}, new int[]
					{
						65535
					}, false);
					this.uclAstro25TrkHotList_CallID_a00038.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstro25TrkHotList_CallID_a00038.DataTransferOrder = 2;
					num = (short)1800601603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1089208322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.uclAstro25TrkHotList_ContactAlias_A00037 = new global::AcpBusinessLayer.AcpRecRefField(this, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("작歹\ud997쾟邡醣\udaa7솩솭쒯ﺱ\uddb3억첷ﾻ톽꺿뛁ꗃꗅ볇诉ꃋꟍ뇏ꇑ诓韕ퟟ", a_), global::CommonResources.AppResources.Contact_Id, new string[]
					{
						global::CommonResources.AppResources.Unassigned_ID
					}, new int[1], true);
					this.uclAstro25TrkHotList_ContactAlias_A00037.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.uclAstro25TrkHotList_ContactAlias_A00037.DataTransferOrder = 1;
					num = (short)1746927616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					IL_219:
					if (producerFields.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("작歹\ud997쾟邡醣\udaa7솩솭쒯ﺱ\uddb3억첷ﾻ톽꺿뛁ꗃꗅ볇诉ꃋꟍ뇏ꇑ诓韕ퟟ", a_)))
					{
						num = (short)334299136;
						short num3 = num;
						num = (short)298123272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_276;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				}
				IL_59:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)829161479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1B4:
				base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펑잓슕쪗햙벛겝閟芡풥\udda7쒩잫잭\udeaf햱钳ﺵힷ캹鲻ꦿ뇁냃", a_);
				base.UIName = global::CommonResources.AppResources.ASTRO_25_Trunking_Hot_List;
				base.DataTransferOrder = 4;
				base.Id = 10416;
				num = (short)1470169089;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_276:
				num = (short)1062501940;
				short num4 = num;
				num = (short)1160281652;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_219;
				default:
					num = (short)744685568;
					if (num != 0)
					{
					}
					num = (short)1182990341;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x001EF848 File Offset: 0x001EDA48
		public global::SpecialFeatures.Ucl.Contact.UclContact Contact
		{
			get
			{
				short num = (short)731049826;
				short num2 = num;
				num = (short)304541538;
				switch (num2 == num)
				{
				default:
				{
					num = (short)15073280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1414987776;
				if (num != 0)
				{
				}
				num = (short)651100161;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.UclContact)this.uclAstro25TrkHotList_ContactAlias_A00037.ReferencedNode;
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x001EF900 File Offset: 0x001EDB00
		public override void PopulateReferences()
		{
			short num = (short)1537081348;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1671036929;
					if (num != 0)
					{
					}
					num = (short)1894318083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.uclAstro25TrkHotList_ContactAlias_A00037.SetRecset(base.ParentRecset.ContainerDoc.GetFeature(2200));
					this.uclAstro25TrkHotList_ContactAlias_A00037.AddSlaveField(this.uclAstro25TrkHotList_CallID_a00038, 10401);
					num = (short)623050754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1102452945;
					short num3 = num;
					num = (short)288233681;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_43;
					case 1:
						goto IL_108;
					}
					goto Block_1;
				}
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1288896513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				}
				goto IL_38;
				IL_43:
				num = (short)1561788416;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_38:
				if (base.ParentRecset != null)
				{
					goto IL_43;
				}
				return;
			}
			Block_1:
			num = (short)1086783488;
			short num4 = num;
			IL_108:
			num = (short)1912209408;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x001EFA94 File Offset: 0x001EDC94
		public override void DropReferences()
		{
			short num = (short)318287326;
			short num2 = num;
			num = (short)1492823518;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1609498624;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1674575873;
			if (num != 0)
			{
			}
			num = (short)1702756352;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x001EFB3C File Offset: 0x001EDD3C
		public override void SetConstraints()
		{
			short num = (short)491126785;
			if (num != 0)
			{
			}
			num = (short)64225280;
			short num2 = num;
			num = (short)497249070;
			short num3 = num;
			num = (short)910322478;
			switch (num3 == num)
			{
			}
			num = (short)533987328;
			if (num != 0)
			{
			}
			this.uclAstro25TrkHotList_CallID_a00038.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::SpecialFeatures.Ucl.HotList.UclHotListConstraints.conAstro25HotListCallIDIsValid);
			this.uclAstro25TrkHotList_CallID_a00038.IsApplicable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Ucl.HotList.UclHotListConstraints.ConAstro25ContactAliasIsNotUnassigned);
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x001EFC14 File Offset: 0x001EDE14
		public override void SetupDependencies()
		{
			short num = (short)1700557945;
			short num2 = num;
			num = (short)824079481;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1514930176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)571277313;
			if (num != 0)
			{
			}
			num = (short)1843200000;
			if (num != 0)
			{
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x001EFCC0 File Offset: 0x001EDEC0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1315006272;
				short num2 = num;
				num = (short)1404921664;
				switch (num2 == num)
				{
				default:
				{
					num = (short)887881728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)512229377;
				if (num != 0)
				{
				}
				num = (short)905248768;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04000B91 RID: 2961
		private global::AcpBusinessLayer.AcpRecRefField uclAstro25TrkHotList_ContactAlias_A00037;

		// Token: 0x04000B92 RID: 2962
		private global::AcpBusinessLayer.AcpRecRefField uclAstro25TrkHotList_CallID_a00038;
	}
}
