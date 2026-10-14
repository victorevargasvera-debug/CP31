using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001EB RID: 491
	[global::System.Serializable]
	public class TrunkingProductIndependentButtonListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06005549 RID: 21833 RVA: 0x004D5D98 File Offset: 0x004D3F98
		public TrunkingProductIndependentButtonListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x004D5DB4 File Offset: 0x004D3FB4
		protected TrunkingProductIndependentButtonListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600554B RID: 21835 RVA: 0x004D5DCC File Offset: 0x004D3FCC
		public override void Init()
		{
			int a_ = 5;
			short num = (short)1871792240;
			short num2 = num;
			num = (short)1620068464;
			switch (num2 == num)
			{
			}
			num = (short)1297940480;
			short num3 = num;
			num = (short)1796210689;
			if (num != 0)
			{
			}
			num = (short)221904896;
			if (num != 0)
			{
			}
			this.trunkingProductIndependentButtonKey = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鋅뫇뿉ꋋꗍ맏병돓蛕꫗뗙룛ꯝ菟雡귣裥賧迩鳫语黯雱釳飵賷룹觻諽瓿洁樃䴅洇猉", a_), global::CommonResources.AcgResources.ID_TRUNKINGPRODUCTINDEPENDENTBUTTONKEY, 14);
			this.trunkingProductIndependentButtonKey.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trunkingProductIndependentButtonKey.DataTransferOrder = 13;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋅뫇뿉ꋋꗍ맏병돓裗꣙돛뫝闟臡郣웥ꇧ蓩裫语胯韱髳鋵鷷铹裻\udefd䋿省瀃爅朇搉Ⰻ䈍礏愑怓", a_);
			base.Id = 10028;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGPRODUCTINDEPENDENTBUTTONLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x004D5EEC File Offset: 0x004D40EC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)901513220;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("闀뇂냄꧆ꋈꋊꏌ꣎臐ꇒ뫔돖곘룚꧜雞迠蟢胤韦賨藪觬諮鿰蟲럴苶跸迺鋼釾䨀昂簄", a_)))
					{
						num = (short)257556481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E3;
				case 1:
				{
					num = (short)1312489472;
					short num3 = num;
					this.trunkingProductIndependentButtonKey = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("闀뇂냄꧆ꋈꋊꏌ꣎臐ꇒ뫔돖곘룚꧜雞迠蟢胤韦賨藪觬諮鿰蟲럴苶跸迺鋼釾䨀昂簄", a_), global::CommonResources.AcgResources.ID_TRUNKINGPRODUCTINDEPENDENTBUTTONKEY, 14);
					this.trunkingProductIndependentButtonKey.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trunkingProductIndependentButtonKey.DataTransferOrder = 13;
					num = (short)280363009;
					if (num != 0)
					{
					}
					num = (short)1720385539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (producerFields != null)
					{
						num = (short)796524549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E3;
				case 3:
					goto IL_10F;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 5:
					goto IL_114;
				case 6:
				{
					num = (short)95416232;
					short num4 = num;
					num = (short)2135158696;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_114;
					default:
						num = (short)1225719808;
						if (num != 0)
						{
						}
						num = (short)52756482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_4A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1960247302;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_114:
				num = (short)260177920;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			IL_1E3:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闀뇂냄꧆ꋈꋊꏌ꣎菒꟔룖뷘껚뻜ꯞ쇠ꫢ诤菦賨鯪裬臮闰雲鯴菶\ud9f8맺裼课甀氂欄✆䔈戊縌笎", a_);
			base.Id = 10028;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGPRODUCTINDEPENDENTBUTTONLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600554D RID: 21837 RVA: 0x004D6110 File Offset: 0x004D4310
		public override void PopulateReferences()
		{
			short num = (short)2107058113;
			short num2 = num;
			num = (short)123742145;
			switch (num2 == num)
			{
			}
			num = (short)1139867648;
			short num3 = num;
			num = (short)1119748096;
			if (num != 0)
			{
			}
			num = (short)1101135873;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600554E RID: 21838 RVA: 0x004D61B8 File Offset: 0x004D43B8
		public override void DropReferences()
		{
			short num = (short)48622123;
			short num2 = num;
			num = (short)873654827;
			switch (num2 == num)
			{
			}
			num = (short)1109262336;
			short num3 = num;
			num = (short)1476329473;
			if (num != 0)
			{
			}
			num = (short)470745088;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x004D6260 File Offset: 0x004D4460
		public override void SetConstraints()
		{
			short num = (short)372435388;
			short num2 = num;
			num = (short)1693903292;
			switch (num2 == num)
			{
			}
			num = (short)335544320;
			short num3 = num;
			num = (short)311820289;
			if (num != 0)
			{
			}
			num = (short)1471545344;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x004D630C File Offset: 0x004D450C
		public override void SetupDependencies()
		{
			short num = (short)53420442;
			short num2 = num;
			num = (short)942547354;
			switch (num2 == num)
			{
			}
			num = (short)857341952;
			short num3 = num;
			num = (short)1817772033;
			if (num != 0)
			{
			}
			num = (short)1735000064;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x06005551 RID: 21841 RVA: 0x004D63B4 File Offset: 0x004D45B4
		public bool HasDiffs
		{
			get
			{
				short num = (short)956327077;
				short num2 = num;
				num = (short)829645989;
				switch (num2 == num)
				{
				}
				num = (short)1843134464;
				short num3 = num;
				num = (short)1854078977;
				if (num != 0)
				{
				}
				num = (short)358744064;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x06005552 RID: 21842 RVA: 0x004D6464 File Offset: 0x004D4664
		// (set) Token: 0x06005553 RID: 21843 RVA: 0x004D6518 File Offset: 0x004D4718
		public string TrunkingProductIndependentButtonKeyValue
		{
			get
			{
				short num = (short)1041979305;
				short num2 = num;
				num = (short)949770153;
				switch (num2 == num)
				{
				}
				num = (short)1243676672;
				short num3 = num;
				num = (short)876937217;
				if (num != 0)
				{
				}
				num = (short)871104512;
				if (num != 0)
				{
				}
				return this.trunkingProductIndependentButtonKey.Value;
			}
			set
			{
				short num = (short)40239105;
				if (num != 0)
				{
				}
				num = (short)611450882;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1034888617;
						short num3 = num;
						num = (short)534259113;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1983119360;
							if (num != 0)
							{
							}
							this.trunkingProductIndependentButtonKey.Value = value;
							num = (short)1525153793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_56;
						}
						continue;
					}
					IL_56:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)1173946368;
					short num4 = num;
					num = (short)208732160;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x06005554 RID: 21844 RVA: 0x004D663C File Offset: 0x004D483C
		// (set) Token: 0x06005555 RID: 21845 RVA: 0x004D66F0 File Offset: 0x004D48F0
		public string TrunkingProductIndependentButtonKey_UIValue
		{
			get
			{
				short num = (short)1236421529;
				short num2 = num;
				num = (short)2129611673;
				switch (num2 == num)
				{
				}
				num = (short)147849216;
				short num3 = num;
				num = (short)435290113;
				if (num != 0)
				{
				}
				num = (short)1717174272;
				if (num != 0)
				{
				}
				return this.trunkingProductIndependentButtonKey.Value;
			}
			set
			{
				short num = (short)1432301309;
				short num2 = num;
				num = (short)729558781;
				switch (num2 == num)
				{
				}
				num = (short)679018496;
				short num3 = num;
				num = (short)1473445888;
				if (num != 0)
				{
				}
				num = (short)1181417473;
				if (num != 0)
				{
				}
				this.trunkingProductIndependentButtonKey.Value = value;
			}
		}

		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x06005556 RID: 21846 RVA: 0x004D67A4 File Offset: 0x004D49A4
		public global::AcpBusinessLayer.AcpKeyField TrunkingProductIndependentButtonKey
		{
			get
			{
				short num = (short)325779457;
				if (num != 0)
				{
				}
				num = (short)871645320;
				short num2 = num;
				num = (short)731398280;
				switch (num2 == num)
				{
				default:
				{
					num = (short)801243136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)628948992;
				if (num != 0)
				{
				}
				return this.trunkingProductIndependentButtonKey;
			}
		}

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x06005557 RID: 21847 RVA: 0x004D6854 File Offset: 0x004D4A54
		// (set) Token: 0x06005558 RID: 21848 RVA: 0x004D6908 File Offset: 0x004D4B08
		public bool TrunkingProductIndependentButtonKey_Applicable
		{
			get
			{
				short num = (short)1789329409;
				if (num != 0)
				{
				}
				num = (short)1695240837;
				short num2 = num;
				num = (short)1198740101;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1339752448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)652738560;
				if (num != 0)
				{
				}
				return this.trunkingProductIndependentButtonKey.Applicable;
			}
			set
			{
				short num = (short)446532161;
				short num2 = num;
				num = (short)1893829185;
				switch (num2 == num)
				{
				}
				num = (short)962265088;
				short num3 = num;
				num = (short)417726465;
				if (num != 0)
				{
				}
				num = (short)37945344;
				if (num != 0)
				{
				}
				this.trunkingProductIndependentButtonKey.Applicable = value;
			}
		}

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x06005559 RID: 21849 RVA: 0x004D69BC File Offset: 0x004D4BBC
		// (set) Token: 0x0600555A RID: 21850 RVA: 0x004D6A70 File Offset: 0x004D4C70
		public bool TrunkingProductIndependentButtonKey_Valid
		{
			get
			{
				short num = (short)493185126;
				short num2 = num;
				num = (short)419063910;
				switch (num2 == num)
				{
				}
				num = (short)204734464;
				short num3 = num;
				num = (short)1431044097;
				if (num != 0)
				{
				}
				num = (short)934084608;
				if (num != 0)
				{
				}
				return this.trunkingProductIndependentButtonKey.Valid;
			}
			set
			{
				short num = (short)1439872758;
				short num2 = num;
				num = (short)1108457206;
				switch (num2 == num)
				{
				}
				num = (short)2134835200;
				short num3 = num;
				num = (short)1819869185;
				if (num != 0)
				{
				}
				num = (short)1970929664;
				if (num != 0)
				{
				}
				this.trunkingProductIndependentButtonKey.Valid = value;
			}
		}

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x0600555B RID: 21851 RVA: 0x004D6B24 File Offset: 0x004D4D24
		// (set) Token: 0x0600555C RID: 21852 RVA: 0x004D6BDC File Offset: 0x004D4DDC
		public bool TrunkingProductIndependentButtonKey_Visible
		{
			get
			{
				short num = (short)1631059969;
				if (num != 0)
				{
				}
				num = (short)1195736266;
				short num2 = num;
				num = (short)1010924746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)788856832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)860815360;
				if (num != 0)
				{
				}
				return this.trunkingProductIndependentButtonKey.Visible;
			}
			set
			{
				short num = (short)1675803628;
				short num2 = num;
				num = (short)1363590124;
				switch (num2 == num)
				{
				}
				num = (short)273612800;
				short num3 = num;
				num = (short)702676992;
				if (num != 0)
				{
				}
				num = (short)499843073;
				if (num != 0)
				{
				}
				this.trunkingProductIndependentButtonKey.Visible = value;
			}
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x0600555D RID: 21853 RVA: 0x004D6C90 File Offset: 0x004D4E90
		// (set) Token: 0x0600555E RID: 21854 RVA: 0x004D6D44 File Offset: 0x004D4F44
		public bool TrunkingProductIndependentButtonKey_Editable
		{
			get
			{
				short num = (short)587730866;
				short num2 = num;
				num = (short)1022365618;
				switch (num2 == num)
				{
				}
				num = (short)1648820224;
				short num3 = num;
				num = (short)15335425;
				if (num != 0)
				{
				}
				num = (short)1752498176;
				if (num != 0)
				{
				}
				return this.trunkingProductIndependentButtonKey.Editable;
			}
			set
			{
				short num = (short)247999965;
				short num2 = num;
				num = (short)1830432221;
				switch (num2 == num)
				{
				}
				num = (short)2126708736;
				short num3 = num;
				num = (short)639500289;
				if (num != 0)
				{
				}
				num = (short)943652864;
				if (num != 0)
				{
				}
				this.trunkingProductIndependentButtonKey.Editable = value;
			}
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x0600555F RID: 21855 RVA: 0x004D6DF8 File Offset: 0x004D4FF8
		internal string TrunkingProductIndependentButtonKey_UILabel
		{
			get
			{
				short num = (short)1507984221;
				short num2 = num;
				num = (short)1144718173;
				switch (num2 == num)
				{
				}
				num = (short)829882368;
				short num3 = num;
				num = (short)1743388673;
				if (num != 0)
				{
				}
				num = (short)377487360;
				if (num != 0)
				{
				}
				return this.trunkingProductIndependentButtonKey.UIName;
			}
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x06005560 RID: 21856 RVA: 0x004D6EAC File Offset: 0x004D50AC
		// (set) Token: 0x06005561 RID: 21857 RVA: 0x004D6F64 File Offset: 0x004D5164
		internal bool TrunkingProductIndependentButtonKey_HiddenStatic
		{
			get
			{
				short num = (short)1144573006;
				short num2 = num;
				num = (short)161467470;
				switch (num2 == num)
				{
				}
				num = (short)469237760;
				short num3 = num;
				num = (short)1509621761;
				if (num != 0)
				{
				}
				num = (short)188022784;
				if (num != 0)
				{
				}
				return this.trunkingProductIndependentButtonKey.HiddenStatic;
			}
			set
			{
				short num = (short)1885963935;
				short num2 = num;
				num = (short)1057916575;
				switch (num2 == num)
				{
				}
				num = (short)778043392;
				short num3 = num;
				num = (short)2135425025;
				if (num != 0)
				{
				}
				num = (short)1877475328;
				if (num != 0)
				{
				}
				this.trunkingProductIndependentButtonKey.HiddenStatic = value;
			}
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x06005562 RID: 21858 RVA: 0x004D701C File Offset: 0x004D521C
		// (set) Token: 0x06005563 RID: 21859 RVA: 0x004D70D0 File Offset: 0x004D52D0
		internal bool TrunkingProductIndependentButtonKey_HiddenDynamic
		{
			get
			{
				short num = (short)61747375;
				short num2 = num;
				num = (short)611463343;
				switch (num2 == num)
				{
				}
				num = (short)1022164992;
				short num3 = num;
				num = (short)1522270208;
				if (num != 0)
				{
				}
				num = (short)876478465;
				if (num != 0)
				{
				}
				return this.trunkingProductIndependentButtonKey.HiddenDynamic;
			}
			set
			{
				short num = (short)924880368;
				short num2 = num;
				num = (short)791973360;
				switch (num2 == num)
				{
				}
				num = (short)115933184;
				short num3 = num;
				num = (short)1043857409;
				if (num != 0)
				{
				}
				num = (short)1050607616;
				if (num != 0)
				{
				}
				this.trunkingProductIndependentButtonKey.HiddenDynamic = value;
			}
		}

		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x06005564 RID: 21860 RVA: 0x004D7188 File Offset: 0x004D5388
		public bool TrunkingProductIndependentButtonKey_HasDiffs
		{
			get
			{
				short num = (short)270401537;
				if (num != 0)
				{
				}
				num = (short)1886135072;
				short num2 = num;
				num = (short)1749754656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2949120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)28508160;
				if (num != 0)
				{
				}
				return this.trunkingProductIndependentButtonKey._HasDiffs;
			}
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x004D7240 File Offset: 0x004D5440
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)327811073;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
					return result;
				case 1:
					if (base.ParentRecset != null)
					{
						goto IL_6C;
					}
					return result;
				case 2:
					num = (short)716570628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1436483584;
					short num3 = num;
					num = (short)1633266643;
					short num4 = num;
					num = (short)1010674643;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6C;
					default:
						num = (short)1031798784;
						if (num != 0)
						{
						}
						num = (short)112852992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)254672899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_4B;
				IL_6C:
				num = (short)2051342338;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4B:
			result = null;
			num = (short)12320769;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x04002179 RID: 8569
		private global::AcpBusinessLayer.AcpKeyField trunkingProductIndependentButtonKey;
	}
}
