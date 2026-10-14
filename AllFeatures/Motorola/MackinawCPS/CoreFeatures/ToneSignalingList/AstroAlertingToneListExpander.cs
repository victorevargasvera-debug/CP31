using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.ToneSignalingList
{
	// Token: 0x020001BB RID: 443
	[global::System.Serializable]
	public class AstroAlertingToneListExpander : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060051C6 RID: 20934 RVA: 0x004A5BA4 File Offset: 0x004A3DA4
		public AstroAlertingToneListExpander(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x004A5BE4 File Offset: 0x004A3DE4
		protected AstroAlertingToneListExpander(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x004A5BFC File Offset: 0x004A3DFC
		public override void Init()
		{
			int a_ = 3;
			short num = (short)665368687;
			short num2 = num;
			num = (short)1948366959;
			switch (num2 == num)
			{
			}
			num = (short)1807024128;
			if (num != 0)
			{
			}
			num = (short)1529937921;
			if (num != 0)
			{
			}
			num = (short)843841536;
			short num3 = num;
			this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏鏑ꟓꋕ꫗뗙鷛닝藟郡郣迥蛧跩룫臭黯韱ꃳ韵髷雹駻뿽珿瘁瘃椅䤇昉椋簍搏笑稓焕䰗甙爛笝琟䌡䘣䨥䴧欩䀫䜭儯䄱", a_), global::CommonResources.AcgResources.ID_TONELISTALIAS, 14);
			this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.DataTransferOrder = 1002;
			this.radErgoAstroAlertingToneListType_A43068 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.LOVs.indexRadErgoAstroAlertingToneListType_A43068LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.LOVs.idRadErgoAstroAlertingToneListType_A43068LovStrs), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏鏑ꟓꋕ꫗뗙鷛닝藟郡郣迥蛧跩룫臭黯韱룳鿵请軹ꣻ蟽烿朁嬃䜅㰇㤉㰋㠍⠏", a_), global::CommonResources.AcgResources.ID_TONELISTTYPE, global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.LOVs.RadErgoAstroAlertingToneListType_A43068LovStrs);
			this.radErgoAstroAlertingToneListType_A43068.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoAstroAlertingToneListType_A43068.DataTransferOrder = 1300;
			this.radErgoAstroAlertingToneListType_A43068.EvaluateRecRefs = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郃꧅ꛇ꿉鷍맏뗑뫓럕듗동닛망샟껡跣闥鳧", a_);
			base.Id = 10787;
			base.UIName = global::CommonResources.AcgResources.ID_TONESIGNALINGLIST;
			base.DataTransferOrder = 1001;
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x004A5D7C File Offset: 0x004A3F7C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)926154755;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋词ꋏ뗑믓韕ꯗ껙껛뇝ꇟ軡臣铥鳧菩苫觭ꓯ鷱髳鏵곷鯹黻鋽旿䌁眃爅稇攉䴋戍甏怑怓缕瘗紙䠛焝丟䜡瀣䜥䨧䘩䤫漭尯嬱唳䔵", a_), global::CommonResources.AcgResources.ID_TONELISTALIAS, 14);
					this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.DataTransferOrder = 1002;
					num = (short)1762918405;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)135462913;
					if (num != 0)
					{
					}
					this.radErgoAstroAlertingToneListType_A43068 = new global::AcpBusinessLayer.AcpSparseLOVField(1, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.LOVs.indexRadErgoAstroAlertingToneListType_A43068LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.LOVs.idRadErgoAstroAlertingToneListType_A43068LovStrs), this, global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋词ꋏ뗑믓韕ꯗ껙껛뇝ꇟ軡臣铥鳧菩苫觭ꓯ鷱髳鏵듷鏹迻諽哿笁球挅圇䬉㠋㴍‏␑Ⱃ", a_), global::CommonResources.AcgResources.ID_TONELISTTYPE, global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.LOVs.RadErgoAstroAlertingToneListType_A43068LovStrs);
					this.radErgoAstroAlertingToneListType_A43068.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoAstroAlertingToneListType_A43068.DataTransferOrder = 1300;
					this.radErgoAstroAlertingToneListType_A43068.EvaluateRecRefs = true;
					num = (short)1592000520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)349437958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1E;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋词ꋏ뗑믓韕ꯗ껙껛뇝ꇟ軡臣铥鳧菩苫觭ꓯ鷱髳鏵듷鏹迻諽哿笁球挅圇䬉㠋㴍‏␑Ⱃ", a_)))
					{
						num = (short)279838721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B0;
				case 5:
					goto IL_A4;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髇ꯉ꣋词ꋏ뗑믓韕ꯗ껙껛뇝ꇟ軡臣铥鳧菩苫觭ꓯ鷱髳鏵곷鯹黻鋽旿䌁眃爅稇攉䴋戍甏怑怓缕瘗紙䠛焝丟䜡瀣䜥䨧䘩䤫漭尯嬱唳䔵", a_)))
					{
						num = (short)1679818752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A4;
				case 7:
				{
					if (producerFields == null)
					{
						goto IL_2B0;
					}
					num = (short)1530119238;
					short num3 = num;
					num = (short)997835846;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E;
					default:
						num = (short)1548550144;
						if (num != 0)
						{
						}
						num = (short)931725314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					goto IL_25F;
				case 9:
					num = (short)890765319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_81;
				IL_1E:
				num = (short)492503040;
				short num4 = num;
				switch (0)
				{
				case 0:
					IL_81:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_2B0;
					}
					num = (short)2046885897;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_A4:
				num = (short)979435524;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_25F:
			IL_2B0:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳇ꗉꋋꯍ臑뷓뇕뛗믙냛럝軟藡쓣ꫥ臧駩飫", a_);
			base.Id = 10787;
			base.UIName = global::CommonResources.AcgResources.ID_TONESIGNALINGLIST;
			base.DataTransferOrder = 1001;
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x004A6070 File Offset: 0x004A4270
		public override void PopulateReferences()
		{
			short num = (short)963028485;
			short num2 = num;
			num = (short)1138730501;
			switch (num2 == num)
			{
			}
			num = (short)1325793280;
			short num3 = num;
			num = (short)2008416257;
			if (num != 0)
			{
			}
			num = (short)716242944;
			if (num != 0)
			{
			}
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x004A6118 File Offset: 0x004A4318
		public override void DropReferences()
		{
			short num = (short)1261300328;
			short num2 = num;
			num = (short)1840114280;
			switch (num2 == num)
			{
			}
			num = (short)1473314816;
			short num3 = num;
			num = (short)16908289;
			if (num != 0)
			{
			}
			num = (short)1551826944;
			if (num != 0)
			{
			}
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x004A61C0 File Offset: 0x004A43C0
		public override void SetConstraints()
		{
			short num = (short)1875289856;
			short num2 = num;
			num = (short)194488064;
			switch (num2 == num)
			{
			}
			num = (short)1067974656;
			short num3 = num;
			num = (short)1126825984;
			if (num != 0)
			{
			}
			num = (short)298778625;
			if (num != 0)
			{
			}
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x004A626C File Offset: 0x004A446C
		public override void SetupDependencies()
		{
			short num = (short)158537004;
			short num2 = num;
			num = (short)714020140;
			switch (num2 == num)
			{
			}
			num = (short)1683161088;
			short num3 = num;
			num = (short)900005889;
			if (num != 0)
			{
			}
			num = (short)1960443904;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x060051CE RID: 20942 RVA: 0x004A6318 File Offset: 0x004A4518
		public bool HasDiffs
		{
			get
			{
				short num = (short)1666112836;
				short num2 = num;
				num = (short)1002691908;
				switch (num2 == num)
				{
				}
				num = (short)133627904;
				short num3 = num;
				num = (short)623312897;
				if (num != 0)
				{
				}
				num = (short)981139456;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17002A78 RID: 10872
		// (get) Token: 0x060051CF RID: 20943 RVA: 0x004A63C8 File Offset: 0x004A45C8
		// (set) Token: 0x060051D0 RID: 20944 RVA: 0x004A647C File Offset: 0x004A467C
		public string RadErgoAstroAlertingToneTableAstroAlertingToneTableAliasValue
		{
			get
			{
				short num = (short)1821656187;
				short num2 = num;
				num = (short)1543062651;
				switch (num2 == num)
				{
				}
				num = (short)1822425088;
				short num3 = num;
				num = (short)1375666177;
				if (num != 0)
				{
				}
				num = (short)711131136;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.Value;
			}
			set
			{
				short num = (short)748879873;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)967084745;
						short num3 = num;
						num = (short)470780617;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8B;
						default:
							goto IL_D6;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.Value = value;
						goto IL_8B;
					}
					IL_31:
					if (!string.IsNullOrEmpty(value.Trim()))
					{
						num = (short)1473183744;
						short num4 = num;
						num = (short)633208834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_8B:
					num = (short)1618804736;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D6:
				num = (short)1549860865;
				if (num != 0)
				{
				}
				num = (short)1457586176;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17002A79 RID: 10873
		// (get) Token: 0x060051D1 RID: 20945 RVA: 0x004A65A0 File Offset: 0x004A47A0
		// (set) Token: 0x060051D2 RID: 20946 RVA: 0x004A6654 File Offset: 0x004A4854
		public string RadErgoAstroAlertingToneTableAstroAlertingToneTableAlias_UIValue
		{
			get
			{
				short num = (short)16926386;
				short num2 = num;
				num = (short)945178290;
				switch (num2 == num)
				{
				}
				num = (short)1897070592;
				short num3 = num;
				num = (short)889847809;
				if (num != 0)
				{
				}
				num = (short)1092747264;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.Value;
			}
			set
			{
				short num = (short)1071356461;
				short num2 = num;
				num = (short)385129005;
				switch (num2 == num)
				{
				}
				num = (short)629800960;
				short num3 = num;
				num = (short)1099956225;
				if (num != 0)
				{
				}
				num = (short)375390208;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.Value = value;
			}
		}

		// Token: 0x17002A7A RID: 10874
		// (get) Token: 0x060051D3 RID: 20947 RVA: 0x004A6708 File Offset: 0x004A4908
		public global::AcpBusinessLayer.AcpKeyField RadErgoAstroAlertingToneTableAstroAlertingToneTableAlias
		{
			get
			{
				short num = (short)1075183617;
				if (num != 0)
				{
				}
				num = (short)1515085556;
				short num2 = num;
				num = (short)160849652;
				switch (num2 == num)
				{
				default:
				{
					num = (short)972750848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)282525696;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias;
			}
		}

		// Token: 0x17002A7B RID: 10875
		// (get) Token: 0x060051D4 RID: 20948 RVA: 0x004A67B8 File Offset: 0x004A49B8
		// (set) Token: 0x060051D5 RID: 20949 RVA: 0x004A686C File Offset: 0x004A4A6C
		public bool RadErgoAstroAlertingToneTableAstroAlertingToneTableAlias_Applicable
		{
			get
			{
				short num = (short)1828026418;
				short num2 = num;
				num = (short)460421170;
				switch (num2 == num)
				{
				}
				num = (short)1284505600;
				short num3 = num;
				num = (short)64290817;
				if (num != 0)
				{
				}
				num = (short)68354048;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.Applicable;
			}
			set
			{
				short num = (short)880476161;
				if (num != 0)
				{
				}
				num = (short)643344322;
				short num2 = num;
				num = (short)771532738;
				switch (num2 == num)
				{
				default:
				{
					num = (short)838991872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1657143296;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.Applicable = value;
			}
		}

		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x060051D6 RID: 20950 RVA: 0x004A6920 File Offset: 0x004A4B20
		// (set) Token: 0x060051D7 RID: 20951 RVA: 0x004A69D8 File Offset: 0x004A4BD8
		public bool RadErgoAstroAlertingToneTableAstroAlertingToneTableAlias_Valid
		{
			get
			{
				short num = (short)82289722;
				short num2 = num;
				num = (short)495690810;
				switch (num2 == num)
				{
				}
				num = (short)267649024;
				short num3 = num;
				num = (short)247201793;
				if (num != 0)
				{
				}
				num = (short)1703542784;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.Valid;
			}
			set
			{
				short num = (short)598022418;
				short num2 = num;
				num = (short)1194137874;
				switch (num2 == num)
				{
				}
				num = (short)1043136512;
				short num3 = num;
				num = (short)2062811137;
				if (num != 0)
				{
				}
				num = (short)1750728704;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.Valid = value;
			}
		}

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x060051D8 RID: 20952 RVA: 0x004A6A90 File Offset: 0x004A4C90
		// (set) Token: 0x060051D9 RID: 20953 RVA: 0x004A6B44 File Offset: 0x004A4D44
		public bool RadErgoAstroAlertingToneTableAstroAlertingToneTableAlias_Visible
		{
			get
			{
				short num = (short)1039447453;
				short num2 = num;
				num = (short)640464285;
				switch (num2 == num)
				{
				}
				num = (short)245563392;
				short num3 = num;
				num = (short)1509228544;
				if (num != 0)
				{
				}
				num = (short)1307508737;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.Visible;
			}
			set
			{
				short num = (short)1893924865;
				if (num != 0)
				{
				}
				num = (short)1835946414;
				short num2 = num;
				num = (short)1917407662;
				switch (num2 == num)
				{
				default:
				{
					num = (short)668270592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1666514944;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.Visible = value;
			}
		}

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x060051DA RID: 20954 RVA: 0x004A6BF8 File Offset: 0x004A4DF8
		// (set) Token: 0x060051DB RID: 20955 RVA: 0x004A6CA8 File Offset: 0x004A4EA8
		public bool RadErgoAstroAlertingToneTableAstroAlertingToneTableAlias_Editable
		{
			get
			{
				short num = (short)911722058;
				short num2 = num;
				num = (short)1609418314;
				switch (num2 == num)
				{
				}
				num = (short)1585840128;
				short num3 = num;
				num = (short)1366884352;
				if (num != 0)
				{
				}
				num = (short)1756626945;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.Editable;
			}
			set
			{
				short num = (short)1093927699;
				short num2 = num;
				num = (short)1713373971;
				switch (num2 == num)
				{
				}
				num = (short)1491861504;
				short num3 = num;
				num = (short)1759444993;
				if (num != 0)
				{
				}
				num = (short)1483603968;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.Editable = value;
			}
		}

		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x060051DC RID: 20956 RVA: 0x004A6D60 File Offset: 0x004A4F60
		internal string RadErgoAstroAlertingToneTableAstroAlertingToneTableAlias_UILabel
		{
			get
			{
				short num = (short)1671198448;
				short num2 = num;
				num = (short)755005168;
				switch (num2 == num)
				{
				}
				num = (short)777256960;
				short num3 = num;
				num = (short)1003552768;
				if (num != 0)
				{
				}
				num = (short)79888385;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.UIName;
			}
		}

		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x060051DD RID: 20957 RVA: 0x004A6E14 File Offset: 0x004A5014
		// (set) Token: 0x060051DE RID: 20958 RVA: 0x004A6EC8 File Offset: 0x004A50C8
		internal bool RadErgoAstroAlertingToneTableAstroAlertingToneTableAlias_HiddenStatic
		{
			get
			{
				short num = (short)1067391098;
				short num2 = num;
				num = (short)1497176186;
				switch (num2 == num)
				{
				}
				num = (short)1280049152;
				short num3 = num;
				num = (short)751566849;
				if (num != 0)
				{
				}
				num = (short)182583296;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.HiddenStatic;
			}
			set
			{
				short num = (short)743362914;
				short num2 = num;
				num = (short)1274532194;
				switch (num2 == num)
				{
				}
				num = (short)924188672;
				short num3 = num;
				num = (short)780599297;
				if (num != 0)
				{
				}
				num = (short)109707264;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.HiddenStatic = value;
			}
		}

		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x060051DF RID: 20959 RVA: 0x004A6F80 File Offset: 0x004A5180
		// (set) Token: 0x060051E0 RID: 20960 RVA: 0x004A7034 File Offset: 0x004A5234
		internal bool RadErgoAstroAlertingToneTableAstroAlertingToneTableAlias_HiddenDynamic
		{
			get
			{
				short num = (short)504057291;
				short num2 = num;
				num = (short)563432907;
				switch (num2 == num)
				{
				}
				num = (short)1171259392;
				short num3 = num;
				num = (short)551878657;
				if (num != 0)
				{
				}
				num = (short)1865154560;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.HiddenDynamic;
			}
			set
			{
				short num = (short)1775991081;
				short num2 = num;
				num = (short)811039017;
				switch (num2 == num)
				{
				}
				num = (short)1742798848;
				short num3 = num;
				num = (short)1696858112;
				if (num != 0)
				{
				}
				num = (short)665911297;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias.HiddenDynamic = value;
			}
		}

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x060051E1 RID: 20961 RVA: 0x004A70E8 File Offset: 0x004A52E8
		public bool RadErgoAstroAlertingToneTableAstroAlertingToneTableAlias_HasDiffs
		{
			get
			{
				short num = (short)1470665765;
				short num2 = num;
				num = (short)468358181;
				switch (num2 == num)
				{
				}
				num = (short)1884553216;
				short num3 = num;
				num = (short)1230045185;
				if (num != 0)
				{
				}
				num = (short)642449408;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneTableAstroAlertingToneTableAlias._HasDiffs;
			}
		}

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x060051E2 RID: 20962 RVA: 0x004A719C File Offset: 0x004A539C
		// (set) Token: 0x060051E3 RID: 20963 RVA: 0x004A7254 File Offset: 0x004A5454
		public int RadErgoAstroAlertingToneListType_A43068Value
		{
			get
			{
				short num = (short)1780852717;
				short num2 = num;
				num = (short)1892722669;
				switch (num2 == num)
				{
				}
				num = (short)2096955392;
				short num3 = num;
				num = (short)1653604352;
				if (num != 0)
				{
				}
				num = (short)1853489153;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneListType_A43068.Value;
			}
			set
			{
				short num = (short)550401674;
				short num2 = num;
				num = (short)935818890;
				switch (num2 == num)
				{
				}
				num = (short)1383858176;
				short num3 = num;
				num = (short)938278913;
				if (num != 0)
				{
				}
				num = (short)1513684992;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneListType_A43068.Value = value;
			}
		}

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x060051E4 RID: 20964 RVA: 0x004A7308 File Offset: 0x004A5508
		// (set) Token: 0x060051E5 RID: 20965 RVA: 0x004A73BC File Offset: 0x004A55BC
		public string RadErgoAstroAlertingToneListType_A43068_UIValue
		{
			get
			{
				short num = (short)1259055501;
				short num2 = num;
				num = (short)732277133;
				switch (num2 == num)
				{
				}
				num = (short)1631977472;
				short num3 = num;
				num = (short)876937217;
				if (num != 0)
				{
				}
				num = (short)1043529728;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneListType_A43068.UIValue;
			}
			set
			{
				short num = (short)20716674;
				short num2 = num;
				num = (short)665459842;
				switch (num2 == num)
				{
				}
				num = (short)372703232;
				short num3 = num;
				num = (short)1661927425;
				if (num != 0)
				{
				}
				num = (short)1035534336;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneListType_A43068.UIValue = value;
			}
		}

		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x060051E6 RID: 20966 RVA: 0x004A7474 File Offset: 0x004A5674
		public global::AcpBusinessLayer.AcpListField RadErgoAstroAlertingToneListType_A43068
		{
			get
			{
				short num = (short)143762184;
				short num2 = num;
				num = (short)102146824;
				switch (num2 == num)
				{
				}
				num = (short)1846607872;
				short num3 = num;
				num = (short)444661760;
				if (num != 0)
				{
				}
				num = (short)1777598465;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneListType_A43068;
			}
		}

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x060051E7 RID: 20967 RVA: 0x004A7524 File Offset: 0x004A5724
		// (set) Token: 0x060051E8 RID: 20968 RVA: 0x004A75D8 File Offset: 0x004A57D8
		public bool RadErgoAstroAlertingToneListType_A43068_Applicable
		{
			get
			{
				short num = (short)1726108893;
				short num2 = num;
				num = (short)1277580509;
				switch (num2 == num)
				{
				}
				num = (short)1014235136;
				short num3 = num;
				num = (short)833617920;
				if (num != 0)
				{
				}
				num = (short)248184833;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneListType_A43068.Applicable;
			}
			set
			{
				short num = (short)1118441203;
				short num2 = num;
				num = (short)1510477555;
				switch (num2 == num)
				{
				}
				num = (short)1468137472;
				short num3 = num;
				num = (short)1024589824;
				if (num != 0)
				{
				}
				num = (short)1210056705;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneListType_A43068.Applicable = value;
			}
		}

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x060051E9 RID: 20969 RVA: 0x004A7690 File Offset: 0x004A5890
		// (set) Token: 0x060051EA RID: 20970 RVA: 0x004A7744 File Offset: 0x004A5944
		public bool RadErgoAstroAlertingToneListType_A43068_Valid
		{
			get
			{
				short num = (short)906648155;
				short num2 = num;
				num = (short)1379752539;
				switch (num2 == num)
				{
				}
				num = (short)909115392;
				short num3 = num;
				num = (short)1116995584;
				if (num != 0)
				{
				}
				num = (short)1731919873;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneListType_A43068.Valid;
			}
			set
			{
				short num = (short)1848866947;
				short num2 = num;
				num = (short)1779005571;
				switch (num2 == num)
				{
				}
				num = (short)64028672;
				short num3 = num;
				num = (short)1705508864;
				if (num != 0)
				{
				}
				num = (short)657457153;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneListType_A43068.Valid = value;
			}
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x060051EB RID: 20971 RVA: 0x004A77F8 File Offset: 0x004A59F8
		// (set) Token: 0x060051EC RID: 20972 RVA: 0x004A78B0 File Offset: 0x004A5AB0
		public bool RadErgoAstroAlertingToneListType_A43068_Visible
		{
			get
			{
				short num = (short)1147361536;
				short num2 = num;
				num = (short)1375623424;
				switch (num2 == num)
				{
				}
				num = (short)99614720;
				short num3 = num;
				num = (short)1983381505;
				if (num != 0)
				{
				}
				num = (short)1688010752;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneListType_A43068.Visible;
			}
			set
			{
				short num = (short)614849915;
				short num2 = num;
				num = (short)2012863867;
				switch (num2 == num)
				{
				}
				num = (short)2024210432;
				short num3 = num;
				num = (short)1631715328;
				if (num != 0)
				{
				}
				num = (short)2085158913;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneListType_A43068.Visible = value;
			}
		}

		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x060051ED RID: 20973 RVA: 0x004A7964 File Offset: 0x004A5B64
		// (set) Token: 0x060051EE RID: 20974 RVA: 0x004A7A14 File Offset: 0x004A5C14
		public bool RadErgoAstroAlertingToneListType_A43068_Editable
		{
			get
			{
				short num = (short)41301020;
				short num2 = num;
				num = (short)1065235484;
				switch (num2 == num)
				{
				}
				num = (short)1440219136;
				short num3 = num;
				num = (short)1035862017;
				if (num != 0)
				{
				}
				num = (short)980156416;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneListType_A43068.Editable;
			}
			set
			{
				short num = (short)1027855445;
				short num2 = num;
				num = (short)335205461;
				switch (num2 == num)
				{
				}
				num = (short)1664417792;
				short num3 = num;
				num = (short)136380417;
				if (num != 0)
				{
				}
				num = (short)1168179200;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneListType_A43068.Editable = value;
			}
		}

		// Token: 0x17002A8A RID: 10890
		// (get) Token: 0x060051EF RID: 20975 RVA: 0x004A7ACC File Offset: 0x004A5CCC
		internal string RadErgoAstroAlertingToneListType_A43068_UILabel
		{
			get
			{
				short num = (short)1495567755;
				short num2 = num;
				num = (short)1255181707;
				switch (num2 == num)
				{
				}
				num = (short)1723727872;
				short num3 = num;
				num = (short)817889280;
				if (num != 0)
				{
				}
				num = (short)1879638017;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneListType_A43068.UIName;
			}
		}

		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x060051F0 RID: 20976 RVA: 0x004A7B80 File Offset: 0x004A5D80
		// (set) Token: 0x060051F1 RID: 20977 RVA: 0x004A7C38 File Offset: 0x004A5E38
		internal bool RadErgoAstroAlertingToneListType_A43068_HiddenStatic
		{
			get
			{
				short num = (short)494574482;
				short num2 = num;
				num = (short)678927250;
				switch (num2 == num)
				{
				}
				num = (short)2033057792;
				short num3 = num;
				num = (short)899350528;
				if (num != 0)
				{
				}
				num = (short)1780285441;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneListType_A43068.HiddenStatic;
			}
			set
			{
				short num = (short)68157441;
				if (num != 0)
				{
				}
				num = (short)2010902244;
				short num2 = num;
				num = (short)1304620772;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1553661952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1366228992;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneListType_A43068.HiddenStatic = value;
			}
		}

		// Token: 0x17002A8C RID: 10892
		// (get) Token: 0x060051F2 RID: 20978 RVA: 0x004A7CEC File Offset: 0x004A5EEC
		// (set) Token: 0x060051F3 RID: 20979 RVA: 0x004A7DA4 File Offset: 0x004A5FA4
		internal bool RadErgoAstroAlertingToneListType_A43068_HiddenDynamic
		{
			get
			{
				short num = (short)218354769;
				short num2 = num;
				num = (short)1640158289;
				switch (num2 == num)
				{
				}
				num = (short)405798912;
				short num3 = num;
				num = (short)305922049;
				if (num != 0)
				{
				}
				num = (short)955514880;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneListType_A43068.HiddenDynamic;
			}
			set
			{
				short num = (short)622187446;
				short num2 = num;
				num = (short)1169675190;
				switch (num2 == num)
				{
				}
				num = (short)1434714112;
				short num3 = num;
				num = (short)277217280;
				if (num != 0)
				{
				}
				num = (short)1916796929;
				if (num != 0)
				{
				}
				this.radErgoAstroAlertingToneListType_A43068.HiddenDynamic = value;
			}
		}

		// Token: 0x17002A8D RID: 10893
		// (get) Token: 0x060051F4 RID: 20980 RVA: 0x004A7E58 File Offset: 0x004A6058
		public bool RadErgoAstroAlertingToneListType_A43068_HasDiffs
		{
			get
			{
				short num = (short)951017524;
				short num2 = num;
				num = (short)1254187060;
				switch (num2 == num)
				{
				}
				num = (short)145817600;
				short num3 = num;
				num = (short)476053505;
				if (num != 0)
				{
				}
				num = (short)439353344;
				if (num != 0)
				{
				}
				return this.radErgoAstroAlertingToneListType_A43068._HasDiffs;
			}
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x004A7F0C File Offset: 0x004A610C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)13135783;
			short num2 = num;
			num = (short)1917284263;
			global::AcpCommonLib.IAcpRecordset result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1249247233;
				if (num != 0)
				{
				}
				num = (short)1823211520;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_99;
				}
				int num3;
				for (;;)
				{
					IL_7F:
					switch (num3)
					{
					case 0:
						goto IL_F6;
					case 1:
						if (base.ParentRecset != null)
						{
							num = (short)1725825027;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139;
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)400752640;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)98107396;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1646002178;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139;
					}
					goto IL_99;
				}
				IL_F6:
				break;
				IL_99:
				result = null;
				num = (short)778305537;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7F;
			}
			}
			IL_139:
			num = (short)89980928;
			short num4 = num;
			return result;
		}

		// Token: 0x04001F1F RID: 7967
		private global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset innerRecset;

		// Token: 0x04001F20 RID: 7968
		private global::AcpBusinessLayer.AcpKeyField radErgoAstroAlertingToneTableAstroAlertingToneTableAlias;

		// Token: 0x04001F21 RID: 7969
		private global::AcpBusinessLayer.AcpListField radErgoAstroAlertingToneListType_A43068;
	}
}
