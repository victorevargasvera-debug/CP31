using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists
{
	// Token: 0x020005D7 RID: 1495
	[global::System.Serializable]
	public class MessageAliasTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600CE94 RID: 52884 RVA: 0x00C03CC4 File Offset: 0x00C01EC4
		public MessageAliasTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600CE95 RID: 52885 RVA: 0x00C03CE0 File Offset: 0x00C01EE0
		protected MessageAliasTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600CE96 RID: 52886 RVA: 0x00C03CF8 File Offset: 0x00C01EF8
		public override void Init()
		{
			int a_ = 15;
			short num = (short)1304937323;
			short num2 = num;
			num = (short)1457767275;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1916796928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)709951489;
			if (num != 0)
			{
			}
			num = (short)1706557440;
			if (num != 0)
			{
			}
			this.cnvAlsLstMessageAliasListMessageAliasText_A8502 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ韕듗꧙郛귝铟꿡臣闥鯧诩诫语뇯黱鷳韵请뛹闻跽瓿企愃甅笇欉欋欍儏縑紓眕欗丙礛昝吟紡攣ḥᴧᨩḫ", a_), global::CommonResources.AcgResources.ID_MESSAGEALIASTEXT, 14);
			this.cnvAlsLstMessageAliasListMessageAliasText_A8502.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvAlsLstMessageAliasListMessageAliasText_A8502.DataTransferOrder = 5;
			this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ韕듗꧙郛귝铟꿡臣闥鯧诩诫语뇯黱鷳韵请뛹闻跽瓿企愃甅笇欉欋欍儏縑紓眕欗吙椛猝䈟䜡嘣礥椧ሩᤫḭį", a_), global::CommonResources.AcgResources.ID_MESSAGEALIASNUMBER, 1, 16, null, null, 0, 1);
			this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.DataTransferOrder = 3;
			this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷏럑ꟓꗕ맗뷙맛ﻝꇟ軡跣蟥鯧쫩룫迭鋯黱釳", a_);
			base.Id = 10013;
			base.UIName = global::CommonResources.AcgResources.ID_MESSAGEALIASTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600CE97 RID: 52887 RVA: 0x00C03E60 File Offset: 0x00C02060
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)1112473606;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_79;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裊ꏌ많郐뿒ꛔ鯖꫘꿚郜뫞鋠郢蓤胦賨ꫪ臬蛮郰胲맴黶諸迺냼髾爀瀂搄怆氈䨊愌明瀐怒嬔或琘礚砜洞縠戢ᴤሦᤨᨪ", a_)))
					{
						num = (short)1473839106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_299;
				case 2:
				{
					num = (short)580583342;
					short num3 = num;
					num = (short)1960312750;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17C;
					default:
						num = (short)13434880;
						if (num != 0)
						{
						}
						this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많郐뿒ꛔ鯖꫘꿚郜뫞鋠郢蓤胦賨ꫪ臬蛮郰胲맴黶諸迺냼髾爀瀂搄怆氈䨊愌明瀐怒嬔或琘礚砜洞縠戢ᴤሦᤨᨪ", a_), global::CommonResources.AcgResources.ID_MESSAGEALIASNUMBER, null, null, 0, 1);
						this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.DataTransferOrder = 3;
						this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.ShowHexValue = false;
						num = (short)1360199688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					this.cnvAlsLstMessageAliasListMessageAliasText_A8502 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("裊ꏌ많郐뿒ꛔ鯖꫘꿚郜뫞鋠郢蓤胦賨ꫪ臬蛮郰胲맴黶諸迺냼髾爀瀂搄怆氈䨊愌明瀐怒䄔爖愘漚䈜帞ᤠᘢᔤᔦ", a_), global::CommonResources.AcgResources.ID_MESSAGEALIASTEXT, 14);
					this.cnvAlsLstMessageAliasListMessageAliasText_A8502.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cnvAlsLstMessageAliasListMessageAliasText_A8502.DataTransferOrder = 5;
					num = (short)1063911424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_17C;
				case 5:
					num = (short)1219690500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 7:
					num = (short)2069168129;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裊ꏌ많郐뿒ꛔ鯖꫘꿚郜뫞鋠郢蓤胦賨ꫪ臬蛮郰胲맴黶諸迺냼髾爀瀂搄怆氈䨊愌明瀐怒䄔爖愘漚䈜帞ᤠᘢᔤᔦ", a_)))
					{
						num = (short)1043464195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79;
				case 8:
					goto IL_223;
				case 9:
					num = (short)1207173127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_55:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)275382277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_79:
				num = (short)1233387521;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_17C:
				if (producerFields == null)
				{
					break;
				}
				num = (short)1057357824;
				short num4 = num;
				num = (short)1293025289;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_223:
			IL_299:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛊꣌볎ꋐ닒닔닖律髚뇜뛞胠郢엤돦裨觪臬諮", a_);
			base.Id = 10013;
			base.UIName = global::CommonResources.AcgResources.ID_MESSAGEALIASTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600CE98 RID: 52888 RVA: 0x00C04138 File Offset: 0x00C02338
		public override void PopulateReferences()
		{
			short num = (short)1583237020;
			short num2 = num;
			num = (short)465848220;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1947336704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)551878657;
			if (num != 0)
			{
			}
			num = (short)193462272;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CE99 RID: 52889 RVA: 0x00C041E0 File Offset: 0x00C023E0
		public override void DropReferences()
		{
			short num = (short)1093918919;
			short num2 = num;
			num = (short)1593499847;
			switch (num2 == num)
			{
			default:
			{
				num = (short)343408640;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1059586049;
			if (num != 0)
			{
			}
			num = (short)1728774144;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CE9A RID: 52890 RVA: 0x00C04288 File Offset: 0x00C02488
		public override void SetConstraints()
		{
			short num = (short)652871993;
			short num2 = num;
			num = (short)1580403001;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1679884288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)301006849;
			if (num != 0)
			{
			}
			num = (short)642187264;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CE9B RID: 52891 RVA: 0x00C04334 File Offset: 0x00C02534
		public override void SetupDependencies()
		{
			short num = (short)2060822539;
			short num2 = num;
			num = (short)1700243467;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1034420224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)165806081;
			if (num != 0)
			{
			}
			num = (short)2136014848;
			if (num != 0)
			{
			}
		}

		// Token: 0x170067E2 RID: 26594
		// (get) Token: 0x0600CE9C RID: 52892 RVA: 0x00C043DC File Offset: 0x00C025DC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1857108691;
				short num2 = num;
				num = (short)463289043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1231880192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)899547137;
				if (num != 0)
				{
				}
				num = (short)207683584;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170067E3 RID: 26595
		// (get) Token: 0x0600CE9D RID: 52893 RVA: 0x00C0448C File Offset: 0x00C0268C
		// (set) Token: 0x0600CE9E RID: 52894 RVA: 0x00C04540 File Offset: 0x00C02740
		public string CnvAlsLstMessageAliasListMessageAliasText_A8502Value
		{
			get
			{
				short num = (short)453144311;
				short num2 = num;
				num = (short)2139451127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1113522176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)713752576;
				if (num != 0)
				{
				}
				num = (short)1519321089;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasText_A8502.Value;
			}
			set
			{
				short num = (short)1630011392;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						goto IL_F1;
					case 2:
						this.cnvAlsLstMessageAliasListMessageAliasText_A8502.Value = value;
						num = (short)347078657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_30:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						return;
					}
					num = (short)57540608;
					short num3 = num;
					num = (short)764702291;
					short num4 = num;
					num = (short)1709272659;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1661861888;
						if (num != 0)
						{
						}
						num = (short)42532866;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_F1:
				num = (short)1338376193;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170067E4 RID: 26596
		// (get) Token: 0x0600CE9F RID: 52895 RVA: 0x00C0466C File Offset: 0x00C0286C
		// (set) Token: 0x0600CEA0 RID: 52896 RVA: 0x00C04720 File Offset: 0x00C02920
		public string CnvAlsLstMessageAliasListMessageAliasText_A8502_UIValue
		{
			get
			{
				short num = (short)1259536385;
				if (num != 0)
				{
				}
				num = (short)106889216;
				short num2 = num;
				num = (short)798753903;
				short num3 = num;
				num = (short)1299907695;
				switch (num3 == num)
				{
				}
				num = (short)1874198528;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasText_A8502.Value;
			}
			set
			{
				short num = (short)1301431699;
				short num2 = num;
				num = (short)2103068051;
				switch (num2 == num)
				{
				default:
				{
					num = (short)983629824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1297874945;
				if (num != 0)
				{
				}
				num = (short)737935360;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasText_A8502.Value = value;
			}
		}

		// Token: 0x170067E5 RID: 26597
		// (get) Token: 0x0600CEA1 RID: 52897 RVA: 0x00C047DC File Offset: 0x00C029DC
		public global::AcpBusinessLayer.AcpKeyField CnvAlsLstMessageAliasListMessageAliasText_A8502
		{
			get
			{
				short num = (short)144763994;
				short num2 = num;
				num = (short)91024474;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1332543488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1251672065;
				if (num != 0)
				{
				}
				num = (short)1618804736;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasText_A8502;
			}
		}

		// Token: 0x170067E6 RID: 26598
		// (get) Token: 0x0600CEA2 RID: 52898 RVA: 0x00C0488C File Offset: 0x00C02A8C
		// (set) Token: 0x0600CEA3 RID: 52899 RVA: 0x00C04940 File Offset: 0x00C02B40
		public bool CnvAlsLstMessageAliasListMessageAliasText_A8502_Applicable
		{
			get
			{
				short num = (short)1220179089;
				short num2 = num;
				num = (short)1563653265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)608501760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)980156416;
				if (num != 0)
				{
				}
				num = (short)1907228673;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasText_A8502.Applicable;
			}
			set
			{
				short num = (short)1691702686;
				short num2 = num;
				num = (short)716592542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1589248000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1983774721;
				if (num != 0)
				{
				}
				num = (short)1268383744;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasText_A8502.Applicable = value;
			}
		}

		// Token: 0x170067E7 RID: 26599
		// (get) Token: 0x0600CEA4 RID: 52900 RVA: 0x00C049F8 File Offset: 0x00C02BF8
		// (set) Token: 0x0600CEA5 RID: 52901 RVA: 0x00C04AAC File Offset: 0x00C02CAC
		public bool CnvAlsLstMessageAliasListMessageAliasText_A8502_Valid
		{
			get
			{
				short num = (short)1761508069;
				short num2 = num;
				num = (short)406354661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1722286080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1732509696;
				if (num != 0)
				{
				}
				num = (short)229441537;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasText_A8502.Valid;
			}
			set
			{
				short num = (short)166132795;
				short num2 = num;
				num = (short)1857420347;
				switch (num2 == num)
				{
				}
				num = (short)1650524161;
				if (num != 0)
				{
				}
				num = (short)2036727808;
				short num3 = num;
				num = (short)1209925632;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasText_A8502.Valid = value;
			}
		}

		// Token: 0x170067E8 RID: 26600
		// (get) Token: 0x0600CEA6 RID: 52902 RVA: 0x00C04B60 File Offset: 0x00C02D60
		// (set) Token: 0x0600CEA7 RID: 52903 RVA: 0x00C04C10 File Offset: 0x00C02E10
		public bool CnvAlsLstMessageAliasListMessageAliasText_A8502_Visible
		{
			get
			{
				short num = (short)2039349249;
				if (num != 0)
				{
				}
				num = (short)644251766;
				short num2 = num;
				num = (short)137396342;
				switch (num2 == num)
				{
				}
				num = (short)1169686528;
				short num3 = num;
				num = (short)753664000;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasText_A8502.Visible;
			}
			set
			{
				short num = (short)1223765911;
				short num2 = num;
				num = (short)1156788119;
				switch (num2 == num)
				{
				}
				num = (short)1210712065;
				if (num != 0)
				{
				}
				num = (short)1829634048;
				short num3 = num;
				num = (short)837156864;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasText_A8502.Visible = value;
			}
		}

		// Token: 0x170067E9 RID: 26601
		// (get) Token: 0x0600CEA8 RID: 52904 RVA: 0x00C04CC4 File Offset: 0x00C02EC4
		// (set) Token: 0x0600CEA9 RID: 52905 RVA: 0x00C04D78 File Offset: 0x00C02F78
		public bool CnvAlsLstMessageAliasListMessageAliasText_A8502_Editable
		{
			get
			{
				short num = (short)1587871745;
				if (num != 0)
				{
				}
				num = (short)1591172144;
				short num2 = num;
				num = (short)1195924528;
				switch (num2 == num)
				{
				}
				num = (short)1114963968;
				short num3 = num;
				num = (short)521338880;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasText_A8502.Editable;
			}
			set
			{
				short num = (short)1044844683;
				short num2 = num;
				num = (short)987697291;
				switch (num2 == num)
				{
				}
				num = (short)1032388609;
				if (num != 0)
				{
				}
				num = (short)1778188288;
				short num3 = num;
				num = (short)1736245248;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasText_A8502.Editable = value;
			}
		}

		// Token: 0x170067EA RID: 26602
		// (get) Token: 0x0600CEAA RID: 52906 RVA: 0x00C04E30 File Offset: 0x00C03030
		internal string CnvAlsLstMessageAliasListMessageAliasText_A8502_UILabel
		{
			get
			{
				short num = (short)1708963603;
				short num2 = num;
				num = (short)543602451;
				switch (num2 == num)
				{
				}
				num = (short)275578881;
				if (num != 0)
				{
				}
				num = (short)121176064;
				short num3 = num;
				num = (short)780861440;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasText_A8502.UIName;
			}
		}

		// Token: 0x170067EB RID: 26603
		// (get) Token: 0x0600CEAB RID: 52907 RVA: 0x00C04EE4 File Offset: 0x00C030E4
		// (set) Token: 0x0600CEAC RID: 52908 RVA: 0x00C04F98 File Offset: 0x00C03198
		internal bool CnvAlsLstMessageAliasListMessageAliasText_A8502_HiddenStatic
		{
			get
			{
				short num = (short)1334898368;
				short num2 = num;
				num = (short)782626496;
				switch (num2 == num)
				{
				}
				num = (short)1624440832;
				if (num != 0)
				{
				}
				num = (short)1339359232;
				short num3 = num;
				num = (short)2065235969;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasText_A8502.HiddenStatic;
			}
			set
			{
				short num = (short)242451358;
				short num2 = num;
				num = (short)1362199454;
				switch (num2 == num)
				{
				}
				num = (short)95158272;
				if (num != 0)
				{
				}
				num = (short)544735232;
				short num3 = num;
				num = (short)1179516929;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasText_A8502.HiddenStatic = value;
			}
		}

		// Token: 0x170067EC RID: 26604
		// (get) Token: 0x0600CEAD RID: 52909 RVA: 0x00C0504C File Offset: 0x00C0324C
		// (set) Token: 0x0600CEAE RID: 52910 RVA: 0x00C05100 File Offset: 0x00C03300
		internal bool CnvAlsLstMessageAliasListMessageAliasText_A8502_HiddenDynamic
		{
			get
			{
				short num = (short)673447937;
				if (num != 0)
				{
				}
				num = (short)591011195;
				short num2 = num;
				num = (short)176823675;
				switch (num2 == num)
				{
				}
				num = (short)186777600;
				short num3 = num;
				num = (short)1963589632;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasText_A8502.HiddenDynamic;
			}
			set
			{
				short num = (short)620352751;
				short num2 = num;
				num = (short)1816646895;
				switch (num2 == num)
				{
				}
				num = (short)2078539777;
				if (num != 0)
				{
				}
				num = (short)1886978048;
				short num3 = num;
				num = (short)1882324992;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasText_A8502.HiddenDynamic = value;
			}
		}

		// Token: 0x170067ED RID: 26605
		// (get) Token: 0x0600CEAF RID: 52911 RVA: 0x00C051B4 File Offset: 0x00C033B4
		public bool CnvAlsLstMessageAliasListMessageAliasText_A8502_HasDiffs
		{
			get
			{
				short num = (short)2101411841;
				if (num != 0)
				{
				}
				num = (short)431563096;
				short num2 = num;
				num = (short)1361846616;
				switch (num2 == num)
				{
				}
				num = (short)634388480;
				short num3 = num;
				num = (short)1997406208;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasText_A8502._HasDiffs;
			}
		}

		// Token: 0x170067EE RID: 26606
		// (get) Token: 0x0600CEB0 RID: 52912 RVA: 0x00C05268 File Offset: 0x00C03468
		// (set) Token: 0x0600CEB1 RID: 52913 RVA: 0x00C05320 File Offset: 0x00C03520
		public int CnvAlsLstMessageAliasListMessageAliasNumber_A8501Value
		{
			get
			{
				short num = (short)298300776;
				short num2 = num;
				num = (short)645248360;
				switch (num2 == num)
				{
				}
				num = (short)1597440001;
				if (num != 0)
				{
				}
				num = (short)1738866688;
				short num3 = num;
				num = (short)1060503552;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Value;
			}
			set
			{
				short num = (short)685399147;
				short num2 = num;
				num = (short)768957547;
				switch (num2 == num)
				{
				}
				num = (short)325189632;
				if (num != 0)
				{
				}
				num = (short)1922039808;
				short num3 = num;
				num = (short)2000027649;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Value = value;
			}
		}

		// Token: 0x170067EF RID: 26607
		// (get) Token: 0x0600CEB2 RID: 52914 RVA: 0x00C053D0 File Offset: 0x00C035D0
		public global::AcpBusinessLayer.AcpSimpleRangeField CnvAlsLstMessageAliasListMessageAliasNumber_A8501
		{
			get
			{
				short num = (short)865112033;
				short num2 = num;
				num = (short)206278625;
				switch (num2 == num)
				{
				}
				num = (short)476053505;
				if (num != 0)
				{
				}
				num = (short)470024192;
				short num3 = num;
				num = (short)163512320;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501;
			}
		}

		// Token: 0x170067F0 RID: 26608
		// (get) Token: 0x0600CEB3 RID: 52915 RVA: 0x00C05480 File Offset: 0x00C03680
		// (set) Token: 0x0600CEB4 RID: 52916 RVA: 0x00C05534 File Offset: 0x00C03734
		public string CnvAlsLstMessageAliasListMessageAliasNumber_A8501_UIValue
		{
			get
			{
				short num = (short)2008755121;
				short num2 = num;
				num = (short)2092641201;
				switch (num2 == num)
				{
				}
				num = (short)40173569;
				if (num != 0)
				{
				}
				num = (short)1467613184;
				short num3 = num;
				num = (short)492699648;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.UIValue;
			}
			set
			{
				short num = (short)1235877889;
				if (num != 0)
				{
				}
				num = (short)715807920;
				short num2 = num;
				num = (short)577395888;
				switch (num2 == num)
				{
				}
				num = (short)180748288;
				short num3 = num;
				num = (short)1769472000;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.UIValue = value;
			}
		}

		// Token: 0x170067F1 RID: 26609
		// (get) Token: 0x0600CEB5 RID: 52917 RVA: 0x00C055EC File Offset: 0x00C037EC
		// (set) Token: 0x0600CEB6 RID: 52918 RVA: 0x00C056A4 File Offset: 0x00C038A4
		internal int CnvAlsLstMessageAliasListMessageAliasNumber_A8501Min
		{
			get
			{
				short num = (short)1541420883;
				short num2 = num;
				num = (short)193148755;
				switch (num2 == num)
				{
				}
				num = (short)212860929;
				if (num != 0)
				{
				}
				num = (short)1088290816;
				short num3 = num;
				num = (short)1729757184;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Min;
			}
			set
			{
				short num = (short)304776126;
				short num2 = num;
				num = (short)1266975678;
				switch (num2 == num)
				{
				}
				num = (short)1355153409;
				if (num != 0)
				{
				}
				num = (short)68681728;
				short num3 = num;
				num = (short)2085421056;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Min = value;
			}
		}

		// Token: 0x170067F2 RID: 26610
		// (get) Token: 0x0600CEB7 RID: 52919 RVA: 0x00C0575C File Offset: 0x00C0395C
		// (set) Token: 0x0600CEB8 RID: 52920 RVA: 0x00C05810 File Offset: 0x00C03A10
		internal int CnvAlsLstMessageAliasListMessageAliasNumber_A8501Max
		{
			get
			{
				short num = (short)1196072233;
				short num2 = num;
				num = (short)1022598441;
				switch (num2 == num)
				{
				}
				num = (short)420020225;
				if (num != 0)
				{
				}
				num = (short)2043150336;
				short num3 = num;
				num = (short)1161625600;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Max;
			}
			set
			{
				short num = (short)961708140;
				short num2 = num;
				num = (short)2007859308;
				switch (num2 == num)
				{
				}
				num = (short)1805516800;
				if (num != 0)
				{
				}
				num = (short)2071461888;
				short num3 = num;
				num = (short)648609793;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Max = value;
			}
		}

		// Token: 0x170067F3 RID: 26611
		// (get) Token: 0x0600CEB9 RID: 52921 RVA: 0x00C058C8 File Offset: 0x00C03AC8
		// (set) Token: 0x0600CEBA RID: 52922 RVA: 0x00C0597C File Offset: 0x00C03B7C
		internal int CnvAlsLstMessageAliasListMessageAliasNumber_A8501Step
		{
			get
			{
				short num = (short)143857536;
				short num2 = num;
				num = (short)1858213760;
				switch (num2 == num)
				{
				}
				num = (short)2023686145;
				if (num != 0)
				{
				}
				num = (short)1307246592;
				short num3 = num;
				num = (short)739311616;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.StepSize;
			}
			set
			{
				short num = (short)1671106402;
				short num2 = num;
				num = (short)652611426;
				switch (num2 == num)
				{
				}
				num = (short)502005761;
				if (num != 0)
				{
				}
				num = (short)1230045184;
				short num3 = num;
				num = (short)1429340160;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.StepSize = value;
			}
		}

		// Token: 0x170067F4 RID: 26612
		// (get) Token: 0x0600CEBB RID: 52923 RVA: 0x00C05A30 File Offset: 0x00C03C30
		// (set) Token: 0x0600CEBC RID: 52924 RVA: 0x00C05AE4 File Offset: 0x00C03CE4
		public bool CnvAlsLstMessageAliasListMessageAliasNumber_A8501_Applicable
		{
			get
			{
				short num = (short)1451947579;
				short num2 = num;
				num = (short)548140603;
				switch (num2 == num)
				{
				}
				num = (short)2054815744;
				if (num != 0)
				{
				}
				num = (short)1972699136;
				short num3 = num;
				num = (short)1804206081;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Applicable;
			}
			set
			{
				short num = (short)1481883732;
				short num2 = num;
				num = (short)953598036;
				switch (num2 == num)
				{
				}
				num = (short)1369571329;
				if (num != 0)
				{
				}
				num = (short)1993736192;
				short num3 = num;
				num = (short)1487208448;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Applicable = value;
			}
		}

		// Token: 0x170067F5 RID: 26613
		// (get) Token: 0x0600CEBD RID: 52925 RVA: 0x00C05B98 File Offset: 0x00C03D98
		// (set) Token: 0x0600CEBE RID: 52926 RVA: 0x00C05C50 File Offset: 0x00C03E50
		public bool CnvAlsLstMessageAliasListMessageAliasNumber_A8501_Valid
		{
			get
			{
				short num = (short)234035200;
				short num2 = num;
				num = (short)2085361664;
				switch (num2 == num)
				{
				}
				num = (short)705036289;
				if (num != 0)
				{
				}
				num = (short)1343881216;
				short num3 = num;
				num = (short)434896896;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Valid;
			}
			set
			{
				short num = (short)1179562130;
				short num2 = num;
				num = (short)413380754;
				switch (num2 == num)
				{
				}
				num = (short)743178241;
				if (num != 0)
				{
				}
				num = (short)593100800;
				short num3 = num;
				num = (short)138674176;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Valid = value;
			}
		}

		// Token: 0x170067F6 RID: 26614
		// (get) Token: 0x0600CEBF RID: 52927 RVA: 0x00C05D04 File Offset: 0x00C03F04
		// (set) Token: 0x0600CEC0 RID: 52928 RVA: 0x00C05DB8 File Offset: 0x00C03FB8
		public bool CnvAlsLstMessageAliasListMessageAliasNumber_A8501_Visible
		{
			get
			{
				short num = (short)1540011659;
				short num2 = num;
				num = (short)547796619;
				switch (num2 == num)
				{
				}
				num = (short)493813761;
				if (num != 0)
				{
				}
				num = (short)1788018688;
				short num3 = num;
				num = (short)1294925824;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Visible;
			}
			set
			{
				short num = (short)1805219430;
				short num2 = num;
				num = (short)1751873126;
				switch (num2 == num)
				{
				}
				num = (short)1486946304;
				if (num != 0)
				{
				}
				num = (short)862388224;
				short num3 = num;
				num = (short)190709761;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Visible = value;
			}
		}

		// Token: 0x170067F7 RID: 26615
		// (get) Token: 0x0600CEC1 RID: 52929 RVA: 0x00C05E6C File Offset: 0x00C0406C
		// (set) Token: 0x0600CEC2 RID: 52930 RVA: 0x00C05F20 File Offset: 0x00C04120
		public bool CnvAlsLstMessageAliasListMessageAliasNumber_A8501_Editable
		{
			get
			{
				short num = (short)1000833186;
				short num2 = num;
				num = (short)872579234;
				switch (num2 == num)
				{
				}
				num = (short)1474887681;
				if (num != 0)
				{
				}
				num = (short)309002240;
				short num3 = num;
				num = (short)173080576;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Editable;
			}
			set
			{
				short num = (short)1588659065;
				short num2 = num;
				num = (short)1191510905;
				switch (num2 == num)
				{
				}
				num = (short)1127350273;
				if (num != 0)
				{
				}
				num = (short)67567616;
				short num3 = num;
				num = (short)1473839104;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.Editable = value;
			}
		}

		// Token: 0x170067F8 RID: 26616
		// (get) Token: 0x0600CEC3 RID: 52931 RVA: 0x00C05FD4 File Offset: 0x00C041D4
		internal string CnvAlsLstMessageAliasListMessageAliasNumber_A8501_UILabel
		{
			get
			{
				short num = (short)1408040961;
				if (num != 0)
				{
				}
				num = (short)728151134;
				short num2 = num;
				num = (short)670544990;
				switch (num2 == num)
				{
				}
				num = (short)679673856;
				short num3 = num;
				num = (short)1132134400;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.UIName;
			}
		}

		// Token: 0x170067F9 RID: 26617
		// (get) Token: 0x0600CEC4 RID: 52932 RVA: 0x00C06084 File Offset: 0x00C04284
		// (set) Token: 0x0600CEC5 RID: 52933 RVA: 0x00C06138 File Offset: 0x00C04338
		internal bool CnvAlsLstMessageAliasListMessageAliasNumber_A8501_HiddenStatic
		{
			get
			{
				short num = (short)1930103361;
				short num2 = num;
				num = (short)158272065;
				switch (num2 == num)
				{
				}
				num = (short)2141192193;
				if (num != 0)
				{
				}
				num = (short)564264960;
				short num3 = num;
				num = (short)1449721856;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.HiddenStatic;
			}
			set
			{
				short num = (short)1337339758;
				short num2 = num;
				num = (short)5713774;
				switch (num2 == num)
				{
				}
				num = (short)1599012865;
				if (num != 0)
				{
				}
				num = (short)343801856;
				short num3 = num;
				num = (short)84082688;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.HiddenStatic = value;
			}
		}

		// Token: 0x170067FA RID: 26618
		// (get) Token: 0x0600CEC6 RID: 52934 RVA: 0x00C061EC File Offset: 0x00C043EC
		// (set) Token: 0x0600CEC7 RID: 52935 RVA: 0x00C062A0 File Offset: 0x00C044A0
		internal bool CnvAlsLstMessageAliasListMessageAliasNumber_A8501_HiddenDynamic
		{
			get
			{
				short num = (short)762663184;
				short num2 = num;
				num = (short)1823756560;
				switch (num2 == num)
				{
				}
				num = (short)917962753;
				if (num != 0)
				{
				}
				num = (short)570556416;
				short num3 = num;
				num = (short)1431961600;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.HiddenDynamic;
			}
			set
			{
				short num = (short)1007423876;
				short num2 = num;
				num = (short)883102084;
				switch (num2 == num)
				{
				}
				num = (short)1420623873;
				if (num != 0)
				{
				}
				num = (short)602275840;
				short num3 = num;
				num = (short)23592960;
				if (num != 0)
				{
				}
				this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501.HiddenDynamic = value;
			}
		}

		// Token: 0x170067FB RID: 26619
		// (get) Token: 0x0600CEC8 RID: 52936 RVA: 0x00C06358 File Offset: 0x00C04558
		public bool CnvAlsLstMessageAliasListMessageAliasNumber_A8501_HasDiffs
		{
			get
			{
				short num = (short)2008747667;
				short num2 = num;
				num = (short)531566227;
				switch (num2 == num)
				{
				}
				num = (short)1082720256;
				if (num != 0)
				{
				}
				num = (short)2067857408;
				short num3 = num;
				num = (short)866582529;
				if (num != 0)
				{
				}
				return this.cnvAlsLstMessageAliasListMessageAliasNumber_A8501._HasDiffs;
			}
		}

		// Token: 0x0600CEC9 RID: 52937 RVA: 0x00C0640C File Offset: 0x00C0460C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)459712999;
					short num3 = num2;
					num2 = (short)1143450087;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)482803712;
						short num4 = num2;
						num2 = (short)1552351233;
						if (num2 != 0)
						{
						}
						num2 = (short)2113863680;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc == null)
						{
							return result;
						}
						break;
					}
					}
					num2 = (short)1145896964;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)1135673344;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1109393409;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1015545859;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1988952066;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04006540 RID: 25920
		private global::AcpBusinessLayer.AcpKeyField cnvAlsLstMessageAliasListMessageAliasText_A8502;

		// Token: 0x04006541 RID: 25921
		private global::AcpBusinessLayer.AcpSimpleRangeField cnvAlsLstMessageAliasListMessageAliasNumber_A8501;
	}
}
